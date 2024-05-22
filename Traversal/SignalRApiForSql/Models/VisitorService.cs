using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRApiForSql.Dal;
using SignalRApiForSql.Hubs;

namespace SignalRApiForSql.Models
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(IHubContext<VisitorHub> hubContext, Context context)
        {
            _hubContext = hubContext;
            _context = context;
        }
        public IQueryable<Visitor> GetList()
        {
            return _context.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _context.Visitors.AddAsync(visitor);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveVisitorList", GetVisitorChardList());
        }

        public List<VisitorChard> GetVisitorChardList()
        {
            List<VisitorChard> visitorChards = new List<VisitorChard>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = @"
                                            SELECT tarih, [1], [2], [3], [4], [5]
                                            FROM
                                            (
                                                SELECT
                                                    CAST([VisitDate] AS Date) AS tarih,
                                                    [City],
                                                    CityVisitCount
                                                FROM Visitors
                                            ) AS visitTable
                                            PIVOT
                                            (
                                                SUM(CityVisitCount)
                                                FOR City IN([1], [2], [3], [4], [5])
                                            ) AS pivotTable
                                            ORDER BY tarih ASC;";
                command.CommandType = System.Data.CommandType.Text;
                _context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VisitorChard visitorChard = new VisitorChard();
                        visitorChard.VisitDate = reader.GetDateTime(0).ToShortDateString();
                        foreach (var item in Enumerable.Range(1, 5).ToList())
                        {
                            visitorChard.Counts.Add(reader.GetInt32(item));
                        }
                        visitorChards.Add(visitorChard);
                    }
                }
                _context.Database.CloseConnection();
                return visitorChards;
            }
        }
    }
}
