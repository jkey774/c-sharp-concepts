using System;
namespace c_sharp_concepts.EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: sending a text message... " + e.Video.Title);
        }
    }
}
