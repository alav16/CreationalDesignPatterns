/*
Design a system where depending on the user input, you can create different types of Notification objects
(EmailNotification, SMSNotification, PushNotification).
Each notification type should have a method to send the notification.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3FactoryMethod
{
    public interface INotification
    {
        void Send();
    }

    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("EmailNotification sent");
        }
    }

    public class SMSNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("SMSNotification sent");
        }
    }

    public class PushNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("PushNotification sent");
        }
    }

    public abstract class Creator
    {
        public abstract INotification CreateNotification();

        public void Create()
        {
            var note = this.CreateNotification();
            note.Send();
        }
    }

    public class EmailCreator : Creator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }

    public class SmsCreator : Creator
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }

    public class PushCreator : Creator
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Creator creatorEmail = new EmailCreator();
            creatorEmail.Create();

            Creator creatorSms = new SmsCreator();
            creatorSms.Create();

            Creator creatorPush = new PushCreator();
            creatorPush.Create();
        }
    }
}
