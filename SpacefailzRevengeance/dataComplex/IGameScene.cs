using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataComplex
{
    /// <summary>
    /// A container for a game scene.
    /// </summary>
    public interface IGameScene
    {

        /// <summary>
        /// Performs any per-logic updates for this scene.
        /// May return a different scene to transition to.
        /// </summary>
        /// <returns>Scene to switch to, or self</returns>
        IGameScene updateSelf();

        /// <summary>
        /// Setup. Called any time scene comes into play.
        /// </summary>
        void launch();

    }
}
