﻿namespace TraversalCoreProje.CQRS.Results.DestinationResults
{
    public class GetAllDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DayNighy { get; set; }
        public double Price { get; set; }
    }
}
