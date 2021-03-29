using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WebApplication1.Models
{
    public class Db:IDb
    {
        //private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly string connectionString = @"Data Source=DESKTOP-AJLU7U0;Initial Catalog=messages;Integrated Security=True;";
        
        public List<Message> AllMessages()
        {
            string sqlExpression = "AllMessages";

            List<Message> messages = new List<Message>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Message message = new Message();

                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2).Date;
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                        messages.Add(message);
                    }
                }
                reader.Close();
            }
            return messages;
        }

        public Message MessageById(int id)
        {
            string sqlExpression = "messageById";
            Message message = new Message();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Idparameter = new SqlParameter
                {
                    ParameterName = "@Id",
                    Value = id

                };
                command.Parameters.Add(Idparameter);
                var reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2);
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                    }
                }
                reader.Close();
            }
            return message;
        }

        public Message MessageByAddressee(string addressee)
        {
            string sqlExpression = "messageByAddressee";
            Message message = new Message();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Addresseeparameter = new SqlParameter
                {
                    ParameterName = "@Addressee",
                    Value = addressee

                };
                command.Parameters.Add(Addresseeparameter);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2);
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                    }
                }
                reader.Close();
            }
            return message;
        }

        public Message MessageBySender(string sender)
        {
            string sqlExpression = "messageBySender";
            Message message = new Message();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Senderparameter = new SqlParameter
                {
                    ParameterName = "@Sender",
                    Value = sender

                };
                command.Parameters.Add(Senderparameter);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2);
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                    }
                }
                reader.Close();
            }
            return message;
        }

        public Message MessageByTag(string tag)
        {
            string sqlExpression = "messageByTag";
            Message message = new Message();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Tagparameter = new SqlParameter
                {
                    ParameterName = "@Tags",
                    Value = tag

                };
                command.Parameters.Add(Tagparameter);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2);
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                    }
                }
                reader.Close();
            }
            return message;
        }

        public Message MessageByDate(DateTime date)
        {
            string sqlExpression = "messageByDate";
            Message message = new Message();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter Dateparameter = new SqlParameter
                {
                    ParameterName = "@Date",
                    Value = date.ToShortDateString()

                };
                command.Parameters.Add(Dateparameter);
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        message.Id = reader.GetInt32(0);
                        message.Name = reader.GetString(1);
                        message.Date = reader.GetDateTime(2);
                        message.Addressee = reader.GetString(3);
                        message.Sender = reader.GetString(4);
                        message.Tags = reader.GetString(5);
                        message.Content = reader.GetString(6);

                    }
                }
                reader.Close();
            }
            return message;
        }

        public string UpdateMessageById(Message message)
        {
            string sqlExpression = "updateMessageById";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                if(message.Date.Year < 1800 || message.Date.Year > 9999)
                {
                    message.Date = DateTime.Now;
                }

                command.Parameters.AddWithValue("@Id", message.Id);
                command.Parameters.AddWithValue("@Date", message.Date);
                command.Parameters.AddWithValue("@Name", message.Name);
                command.Parameters.AddWithValue("@Addressee", message.Addressee);
                command.Parameters.AddWithValue("@Sender", message.Sender);
                command.Parameters.AddWithValue("@Tags", message.Tags);
                command.Parameters.AddWithValue("@Contente", message.Content);
                var reader = command.ExecuteReader();

                
            }
            return "Ok";
        }
    }
}