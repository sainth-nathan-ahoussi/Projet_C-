using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MVC_NATHAN.Interfaces
{
    public interface IController
    {
        void SetModel(IModel model);
        void AddClient(string name, int age, string town);
        void RemoveClient(int id);

    }
}
