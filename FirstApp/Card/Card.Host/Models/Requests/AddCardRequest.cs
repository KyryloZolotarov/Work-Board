﻿using Infrastructure.Enums;

namespace Card.Host.Models.Requests
{
    public class AddCardRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public int ListId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
