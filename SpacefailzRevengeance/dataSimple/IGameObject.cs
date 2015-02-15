using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataSimple
{
    public interface IGameObject
    {

        void renderSelf();
        void updateSelf();

        Boolean isGoingToDie();
        void prepareToDie();
        void die();

    }
}
