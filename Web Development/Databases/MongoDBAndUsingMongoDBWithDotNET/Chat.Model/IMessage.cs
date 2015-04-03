namespace Chat.Model
{
    using System;

    public interface IMessage
    {
        DateTime Date { get; set; }

        string Id { get; set; }

        string Text { get; set; }

        User User { get; set; }

    }
}
