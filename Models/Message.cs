using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Message
    {
        [Key] public int ID { get; set; }
        public string Text { get; set; }
        public string Theme { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public DateTime Date { get; set; }
    }
}
