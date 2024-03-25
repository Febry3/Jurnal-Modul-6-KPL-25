using modul6_1302220084;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser user1 = new SayaTubeUser("Febry");
        SayaTubeVideo video = new SayaTubeVideo("Review Film Intestellar oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Teletubbies oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Godzilla 1 oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Godzilla Minus 1 oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film TWD oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film The Last of Us oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Expendables oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me 2 oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me 3 oleh Febry");
        user1.AddVideo(video);

        video = new SayaTubeVideo("Review Film Despicable Me 4 oleh Febry");
        user1.AddVideo(video);

        user1.PrintAllVideoPlayCount();
    }
}