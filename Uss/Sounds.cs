using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Uss
{
    public class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "viktor.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "crunch.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }

        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            player.controls.play();
        }
        public void Dead()
        {
            player.URL = pathToMedia + "dead.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}