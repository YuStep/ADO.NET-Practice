using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    interface IDb
    {
        List<Message> AllMessages();

        Message MessageById(int id);

        Message MessageByAddressee(string addressee);

        Message MessageBySender(string sender);

        Message MessageByTag(string tag);

        Message MessageByDate(DateTime date);

        string UpdateMessageById(Message message);


    }
}
