namespace Chat.Data
{
    using System;
    using System.Linq;

    using MongoDB.Driver;

    public class ChatDB : IChatDB
    {
        public MongoDatabase database;

        public static void  DatabaseDB()
        {
            var mongoClient = new MongoClient();
            var server = mongoClient.GetServer();

            var database = server.GetDatabase("ChatDatabase");

           // this.Database = server.GetDatabase(database);
        }

        public MongoDatabase Database 
        {
            get
            {
                return this.database;
            }
            set
            {
                this.database = value;
            }
        }

    }
}
