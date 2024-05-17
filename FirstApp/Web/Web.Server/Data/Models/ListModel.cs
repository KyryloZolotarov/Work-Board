﻿namespace Web.Server.Data.Models
{
    public class ListModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? BoardId { get; set; }
        public List<CardModel> Cards { get; set; }
    }
}
