﻿using Infrastructure.Enums;

namespace ListCard.Data.Requests
{
    public class CardRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public int ListId { get; set; }
        public DateTime DueDate { get; set; }
    }
}