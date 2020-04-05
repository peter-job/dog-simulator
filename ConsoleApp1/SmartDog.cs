using System;
using System.Collections.Generic;
using System.IO;

namespace SmartDog
{
    class SmartDog
    {
        private string[] introductions;
        private string[] musings;
        private string[] songs;

        private int strength = 5;
        private int pizzazz = 1;

        private Queue<string> stuffHesSayingNow;

        public SmartDog()
        {
            ReadSayingsFromFile();
            StartIntroducingYourself();
        }

        public void Talk()
        {
            if (strength <= 0)
            {
                Console.WriteLine("Too tired to talk sorry");
            }
            else if (pizzazz >= 5)
            {
                Console.WriteLine("I'm too cool for this shit.");
            } 
            else if (stuffHesSayingNow.Count > 0)
            {
                var hisNewSaying = stuffHesSayingNow.Dequeue();
                Console.WriteLine(hisNewSaying);
            }
            else
            {
                Console.WriteLine("*whistles loudly*");
            }
            strength--;
            pizzazz++;
        }

        public void StartIntroducingYourself()
        {
            SetWhatHesSayingNow(introductions);
        }

        public void StartTellingMusings()
        {
            SetWhatHesSayingNow(musings);
        }

        public void StartSingingSongs()
        {
            SetWhatHesSayingNow(songs);
        }
        
        private void ReadSayingsFromFile()
        {
            // read this stuff from files now
            introductions = File.ReadAllLines("dialog/dog/introductions.txt");
            musings = File.ReadAllLines("dialog/dog/musings.txt");
            songs = File.ReadAllLines("dialog/dog/songs.txt");
        }
        
        private void SetWhatHesSayingNow(string[] sayings)
        {
            stuffHesSayingNow = new Queue<string>(sayings);
        }
    }
}