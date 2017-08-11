using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using NotificationSystem.Models;

namespace NotificationSystem
{
    public class NotificationComponent
    {
        //add function for register notification(will add sql dependency)
        public void RegisterNotification(DateTime currentTime)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlConString"].ConnectionString;
            string sqlCommand = @"Select [ContactId],[ContactName],[ContactNo] from [dbo].[Contacts] where [AddedOn] > @AddedOn";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlCommand,connection);
                cmd.Parameters.AddWithValue("@AddedOn",currentTime);
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                cmd.Notification = null;
                SqlDependency sqlDependency = new SqlDependency(cmd);
                sqlDependency.OnChange += SqlDependencyOnChange;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                }
            }
        }

        void SqlDependencyOnChange(object sender,SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                SqlDependency sqlDependency = sender as SqlDependency;
                sqlDependency.OnChange -= SqlDependencyOnChange;

                //send notifiction message to client
                var notificationHub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                notificationHub.Clients.All.Notify("Added");

                //re register notification
                RegisterNotification(DateTime.Now);
            }
        }

        public List<Contact> GetContacts(DateTime afterDate)
        {
            using (MyPushNotificationEntities db = new MyPushNotificationEntities())
            {
                return db.Contacts.Where(a => a.AddedOn > afterDate).OrderByDescending(a => a.AddedOn).ToList();
            }
        }
    }
}