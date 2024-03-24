using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MVC_NATHAN.Implementation
{
    public class Client
    {
        static int lastID = 0;

        private int _id;
        private string _name;
        private int _age;
        private string _town;
   

        Client( string name, int age, string town)
        {
            _id = lastID++;
            _name = name;
            _age = age;
           _town = town;
        }

         public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

        public string GetTown()
        {
            return _town;
        }

    }
}
