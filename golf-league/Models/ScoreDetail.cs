﻿namespace golf_league.Models
{
    public class ScoreDetail
    {
        public Guid Id { get; set; }
        public Guid ScoreId { get; set; }
        public Guid HoleId { get; set; }
        public int Score { get; set; }
    }
}
