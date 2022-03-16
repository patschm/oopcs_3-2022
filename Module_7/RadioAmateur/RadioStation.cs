using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioAmateur
{
    public delegate void Ontvangst(string msg);

    public class RadioStation
    {
        //private Ontvangst _subscribers;

        public event Ontvangst subscribers;
        //{
        //    add
        //    {
        //        _subscribers += value;
        //    }
        //    remove
        //    {
        //        _subscribers -= value;
        //    }
        //}

        public void Broadcast()
        {
            Console.WriteLine("We gaan live");

            subscribers.Invokes("Ha!!!!");
            //foreach(var del in subscribers.GetInvocationList())
            //try
            //{           
            //    //subscribers?.Invoke("Hallo luisteraars");
            //    del.Method.Invoke(null, new object[] { "Hallo allemaal" });
            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
