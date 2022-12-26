using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador_ElSoldado
{
    public interface IView
    {
        void Show_text(string text);
        void Set_weapon_menu(Dictionary<string, int> menuItems);
    }
}
