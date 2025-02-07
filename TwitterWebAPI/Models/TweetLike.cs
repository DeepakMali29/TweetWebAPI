﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwitterWebAPI.Models
{
    public class TweetLike
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TweetId { get; set; }
        public int TweetLikeCount { get; set; }
        public virtual User User { get; set; }
        public virtual Tweet Tweet { get; set; }
    }
}
