using modul6_1302220084;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("Febry");
        SayaTubeVideo video = new SayaTubeVideo("Review Film Intestellar oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);
       

        video = new SayaTubeVideo("Review Film Teletubbies oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        for (int i = 0; i < 100; i++)
        {
            video.IncreasePlayCount(25000000);
        }

        video = new SayaTubeVideo("Review Film Godzilla 1 oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Godzilla Minus 1 oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film TWD oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film The Last of Us oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Expendables oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me 2 oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me 3 oleh Febry");
        video.IncreasePlayCount(123456);
        user1.AddVideo(video);

        for (int i = 0; i < 10; i++)
        {
            video.IncreasePlayCount(25000000);
        }

       

        user1.PrintAllVideoPlayCount();
        Console.WriteLine("Total playcount: " + user1.GetTotalVideoCount());
    }
}