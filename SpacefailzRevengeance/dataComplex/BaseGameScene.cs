using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dataSimple;

namespace dataComplex
{
    public class BaseGameScene : IGameScene
    {
        /// <summary>
        /// Whenever the next launch call will be the first.
        /// </summary>
        internal Boolean firstTimeLaunch = true; 
        /// <summary>
        /// An array of game object lists...
        /// Must be same length as camera list.
        /// </summary>
        internal List<IGameObject> [] gameObjectLists;
        /// <summary>
        /// ...and the associated scene cameras.
        /// Must be same length as objects list.
        /// </summary>
        internal Camera[] cameras;
        
        virtual public IGameScene updateSelf()
        {
            return this;
        }

        virtual public void launch()
        {
            firstTimeLaunch = false;
        }
    }
}
