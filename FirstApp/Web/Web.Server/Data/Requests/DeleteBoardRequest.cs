﻿namespace Web.Server.Data.Requests
{
    public class DeleteBoardRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? UserId { get; set; }
    }
}
