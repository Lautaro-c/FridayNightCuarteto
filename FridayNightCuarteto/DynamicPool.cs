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
        private object[] constructorParams;
        public DynamicPool(Type type, params object[] parameters)
        {
            constructorParams = parameters; 
        }
        public List<T> Active => active;
        public List<T> Inactive => inactive;


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
            return newT;

        }

        public void RecycleT(T T)
        {
            active.Remove(T);
            inactive.Add(T);
        }

        private T CreateInstance()
        {
            return (T)Activator.CreateInstance(typeof(T), constructorParams);
        }
    }
}