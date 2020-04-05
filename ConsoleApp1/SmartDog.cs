using System;
using System.Collections.Generic;

namespace SmartDog
{
    class SmartDog
    {
        private string[] introductions;
        private string[] musings;
        private string[] songs;

        private Queue<string> stuffHesSayingNow;

        public SmartDog()
        {
            SetupTheDogSayings();
            stuffHesSayingNow = new Queue<string>(introductions);
        }

        public void Talk()
        {
            if (stuffHesSayingNow.Count > 0)
            {
                var hisNewSaying = stuffHesSayingNow.Dequeue();
                Console.WriteLine(hisNewSaying);
            }
            else
            {
                Console.WriteLine("*whistles loudly*");
            }
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
        
        private void SetupTheDogSayings()
        {
            introductions = new[]
            {
                "Hi who are you? I'm a cool dog.",
                "Well would you look at the weather!"
            };

            musings = new[]
            {
                "Ya ever thingk about the size of cars these days.",
                "I got a hundred thousand ideas if you would listen to them..."
            };

            songs = new[]
            {
                "Hahaha I know a really funny song! Well let me sing it for you hahaha ok *sings yankee doodle*",
                "Sing us a song, mister piano man, Sing us a song tonight..."
            };
        }
        
        private void SetWhatHesSayingNow(string[] sayings)
        {
            stuffHesSayingNow = new Queue<string>(sayings);
        }
        
        
    }
}