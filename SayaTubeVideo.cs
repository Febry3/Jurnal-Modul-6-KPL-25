using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220084
{
    public class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random rdm = new Random();
            this.title = title;
            this.id = rdm.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = playCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"id          : {this.id}");
            Console.WriteLine($"title       : {this.title}");
            Console.WriteLine($"play count  : {this.playCount}");
        }

        public int getPlayCount() 
        { 
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }
    }
}
