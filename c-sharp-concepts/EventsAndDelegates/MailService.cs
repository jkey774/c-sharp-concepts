using System;
namespace c_sharp_concepts.EventsAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an email... " + e.Video.Title);
        }
    }
}
