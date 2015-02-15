using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataComplex
{
    public class BaseGameScene : IGameScene
    {
        public IGameScene updateSelf()
        {
            return this;
        }

        public void launch()
        {
            
        }
    }
}
