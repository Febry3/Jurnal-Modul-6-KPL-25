using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title.Length <= 200 && title != null, "Judul terlalu panjang");
            Random rdm = new Random();
            this.title = title;
            this.id = rdm.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "input yang ingin ditambahkan melebihi 25 juta");
            Debug.Assert(playCount >= 0, "input tidak boleh negatif");
            try
            {
                checked
                {
                    this.playCount+= playCount;
                }
            } catch { 
                Console.WriteLine("Play Count telah melebihi batas tertinggi integer");
            }
            
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
