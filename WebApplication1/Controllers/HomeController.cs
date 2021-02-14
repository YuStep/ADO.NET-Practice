using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication1.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        IDb db = new Db();
        [System.Web.Http.HttpGet]
        public List<Message> AllMessages()
        {
            
            List<Message>msg = new List<Message>(db.AllMessages());
            return msg;
        }

        public Message GetMessageById(int Id)
        {
            return db.MessageById(Id);
        }

        public Message GetMessageByAddressee(string Addressee)
        {
            return db.MessageByAddressee(Addressee);
        }

        public Message GetMessageByDate(DateTime Date)
        {
            return db.MessageByDate(Date);
        }
        public Message GetMessageBySender(string Sender)
        {
            return db.MessageBySender(Sender);
        }

        public Message GetMessageByTag(string Tag)
        {
            return db.MessageByTag(Tag);
        }
        
        [HttpPost]
        public string UpdateMessage(Message message)
        {
            return db.UpdateMessageById(message);
        }
    }
    
}
