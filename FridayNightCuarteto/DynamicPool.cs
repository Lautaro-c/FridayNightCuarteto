using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class DynamicPool <T> where T : GameObject <T>
    {
        private List<T> active = new List<T>();
        private List<T> inactive = new List<T>();

        //almacena los datos usados para crear el pool
        //object puede guardar cualquier tipo de dato
        private object[] constructorParams;

        //params permite que varios tipos de variables sin tener que definirlos previamente como un array
        public DynamicPool(Type type, params object[] parameters)
        {
            constructorParams = parameters; // Guarda los parámetros para futuras instancias
        }



        public T GetT()
        {
            T newT = null;

            if (inactive.Count > 0)
            {
                newT = inactive[0];
                inactive.RemoveAt(0);
            }
            else
            {
                newT = CreateInstance();
                newT.OnDeactive += RecycleT;
            }
            active.Add(newT);
            VerTDisponibles();
            return newT;

        }

        public void RecycleT(T T)
        {
            active.Remove(T);
            inactive.Add(T);
            Engine.Debug("Elimine una T");
        }

        public void VerTDisponibles()
        {
            Engine.Debug("T disponibles: " + inactive.Count);
            Engine.Debug("T en uso: " + active.Count);
        }

        private T CreateInstance()
        {
            //Instancia objetos de una clase con los parametros que guardo
            return (T)Activator.CreateInstance(typeof(T), constructorParams);
        }
    }
}