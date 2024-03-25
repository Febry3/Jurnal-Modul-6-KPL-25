using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220084
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        String username;

        public SayaTubeUser(String username)
        {
            this.username = username;
            this.uploadVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoCount()
        {
            int total = 0;
            for (int i = 0; i < uploadVideos.Count; i++)
            {
                total += uploadVideos[i].getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video) 
        {
            uploadVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User:" + this.username);
            for (int i = 0;i < uploadVideos.Count;i++)
            {
                Console.WriteLine($"Video {i} judul: " + this.uploadVideos[i].getTitle());
            }
        }
    }
}
