using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logic;

using dataComplex;


class Entry
{

    #region public static void Main()

    /// <summary>
    /// Entry point.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        MainmenuScene mainmenu = new MainmenuScene();
        using (ThisGameWindow game = new ThisGameWindow(mainmenu))
        {
            game.Run(30.0, 30.0);
        }
    }

    #endregion

}
