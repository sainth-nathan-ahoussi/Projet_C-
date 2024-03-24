using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MVC_NATHAN.Implementation;

namespace TP_MVC_NATHAN.Interfaces
{
    public interface IModel
    {
        void SetView(IView view);
        int AddClient(string name, int age, string town);
        bool RemoveClient(int id);

        List<Client> GetData();
    }
}
