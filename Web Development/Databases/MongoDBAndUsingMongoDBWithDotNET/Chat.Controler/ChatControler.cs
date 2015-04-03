namespace Chat.Controler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MongoDB.Bson;
    using MongoDB.Driver.Builders;

    using Chat.Model;
    using Chat.Data;

    public class ChatControler : IChatControler
    {
        public IChatControler controler;
        public User loggedUser;
        public ChatDB db;

        public ChatControler()
        {
            this.loggedUser = new User
            {
                UserName = null
            };
        }

        public User LoggedUser
        {
            get { return this.loggedUser; }
            set { this.loggedUser = value; }
        }

        public DateTime UserLoggedTime { get; set; }

        public void InsertMessage(string text)
        {
            var messages = this.db.database.GetCollection<Message>("Messages");

            var newMessage = new Message()
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Date = DateTime.Now,
                Text = text,
                User = this.loggedUser
            };

            messages.Insert(newMessage);
        }
        public List<Message> GetAllMessage()
        {
            var messages = this.db.database.GetCollection<Message>("Messages");
            var query = Query.Exists("Date");

            var allMessage = messages.FindAll().ToList();

            return allMessage;
        }
    }
}
