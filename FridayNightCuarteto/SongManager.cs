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
        AudioFileReader reader = new AudioFileReader("assets/songs/Enamorado tuyo - El Cuarteto de Nos.mp3");
        WaveOutEvent outputDevice = new WaveOutEvent();

        public void startSong()
        {
            outputDevice.Init(reader);
            outputDevice.Play();
        }

        public void stopSong()
        {
            outputDevice.Stop();
            reader.Position = 0;
        }
    }
}
