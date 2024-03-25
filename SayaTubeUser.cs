using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username.Length <= 100 && username != null, "Username lebih dari 100 kata atau null");
            this.username = username;
            uploadVideos = new List<SayaTubeVideo>();
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
            Debug.Assert(video != null, "inputtan video harus memiliki isi");
            Debug.Assert(video.getPlayCount() < int.MaxValue, "Playcount lebih dari 25juta");
            uploadVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User:" + this.username);
            for (int i = 0;i < uploadVideos.Count;i++)
            {
                Console.WriteLine($"Video {i + 1} judul: " + this.uploadVideos[i].getTitle());
                Debug.Assert(i > 8, "Lebih dari 8 video");
            }
        }
    }
}
