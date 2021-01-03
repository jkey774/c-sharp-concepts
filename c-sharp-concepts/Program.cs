using c_sharp_concepts.EventsAndDelegates;

namespace c_sharp_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Begin Events and Delegates Demo **/

            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            /** End Events and Delegates Demo **/
        }
    }
}