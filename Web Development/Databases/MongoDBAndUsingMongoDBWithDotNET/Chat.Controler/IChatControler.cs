namespace Chat.Controler
{
    using System;
    using System.Collections.Generic;

    using Chat.Model;

    public interface IChatControler
    {
        List<Message> GetAllMessage();
        void InsertMessage(string tex);
        User LoggedUser { get; }
        DateTime UserLoggedTime { get; set; }

    }
}
