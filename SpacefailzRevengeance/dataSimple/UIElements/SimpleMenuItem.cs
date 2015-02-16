using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataSimple.UIElements
{
    /// <summary>
    /// A (very) simple implementation of a button menu.
    /// Expects to be 2D.
    /// </summary>
    class SimpleMenuItem : IGameObject
    {
        private string label;

        private SimpleMenuItem next;
        private SimpleMenuItem last;

        private Rectangle bounds;

        public SimpleMenuItem(string label, Rectangle bounds)
        {
            this.label = label;
            this.bounds = bounds;
        }

        public void renderSelf()
        {
            throw new NotImplementedException();
        }

        public void updateSelf()
        {
            throw new NotImplementedException();
        }

        public bool isGoingToDie()
        {
            throw new NotImplementedException();
        }

        public void prepareToDie()
        {
            throw new NotImplementedException();
        }

        public void die()
        {
            throw new NotImplementedException();
        }

        internal void setNext(SimpleMenuItem nextItem)
        {
            this.next = nextItem;
        }

        internal void setLast(SimpleMenuItem lastItem)
        {
            this.last = lastItem;
        }
    }
}
