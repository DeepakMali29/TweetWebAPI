using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwitterWebAPI.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string TweetMessage { get; set; }
        public DateTime TweetCreatedDate { get; set; }
        public DateTime TweetModifiedDate { get; set; }
        public virtual User User { get; set; }
    }
}
