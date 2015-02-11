using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataSimple
{
    interface IGameObject
    {

        public void renderSelf();
        public void updateSelf();

        public Boolean isGoingToDie();
        public void prepareToDie();
        public void die();

    }
}
