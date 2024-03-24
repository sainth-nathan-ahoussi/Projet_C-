using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MVC_NATHAN.Interfaces
{
    public interface IView
    {
        void UpdateView();
        void SetController(IController controller);
        void SetModel(IModel model);
    }
}
