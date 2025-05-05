using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Points
    {
        private int rythmPoints = 0;

        public int RythmPoints
        { 
            get 
            { 
                return rythmPoints; 
            }
            set 
            {
                if (value < 20)
                {
                    rythmPoints += value;
                    Engine.Debug($"{rythmPoints}");
                }
            }
        }

        public Points() 
        {
            
        }

        //si los puntos son mayores a 3450 ganas, sino perdes
        //Menu principal
        //Movimiento del jugador
        //Pantalla de victoria 
        //Pantalla de derrota
        //Un objeto con animaciones
        //singleton
    }
}