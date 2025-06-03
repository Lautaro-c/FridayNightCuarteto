using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MyGame
{
    public class SongManager
    {

        public void startSong()
        {
            AudioFileReader reader = new AudioFileReader("assets/songs/Enamorado tuyo - El Cuarteto de Nos.mp3");
            WaveOutEvent outputDevice = new WaveOutEvent();
            outputDevice.Init(reader);
            outputDevice.Play();
        }
    }
}
