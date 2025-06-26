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
        AudioFileReader reader1 = new AudioFileReader("assets/songs/Enamorado tuyo - El Cuarteto de Nos.mp3");
        AudioFileReader reader2 = new AudioFileReader("assets/songs/El Cuarteto de Nos - Invisible.mp3");
        WaveOutEvent outputDevice = new WaveOutEvent();

        public void startSong(int songNumber)
        {
            if (songNumber == 1)
            {
                outputDevice.Init(reader1);
                outputDevice.Play();
            }
            if (songNumber == 2)
            {
                outputDevice.Init(reader2);
                outputDevice.Play();
            }
        }

        public void stopSong(int songNumber)
        {
            if (songNumber == 1)
            {
                outputDevice.Stop();
                reader1.Position = 0;
            }
            if (songNumber == 2)
            {
                outputDevice.Stop();
                reader2.Position = 0;
            }
        }
    }
}
