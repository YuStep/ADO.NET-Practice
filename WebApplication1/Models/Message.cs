using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Message
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Addressee { get; set; }

        public string Sender { get; set; }

        public string Tags { get; set; }

        public string Content { get; set; }

        public Message()
        {
            Name = "Empty";
            Date = DateTime.Now;
            Addressee = "Empty";
            Sender = "Empty";
            Tags = "Empty";
            Content = "Empty";
        }

    }
}