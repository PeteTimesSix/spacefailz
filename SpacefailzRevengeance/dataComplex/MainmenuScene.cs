using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dataSimple;
using dataSimple.UIElements;

namespace dataComplex
{
    public class MainmenuScene : BaseGameScene
    {

        public override IGameScene updateSelf() 
        {
            return base.updateSelf();
        }

        public override void launch()
        {
            if (firstTimeLaunch) 
            {
                //initialise object and camera arrays
                gameObjectLists = new List<IGameObject>[1];
                gameObjectLists[0] = new List<IGameObject>();
                
                cameras = new Camera[1];
                cameras[0] = new Camera();

                SimpleMenuItem newGame = new SimpleMenuItem("New Game");
                SimpleMenuItem loadGame = new SimpleMenuItem("Load Game");
                SimpleMenuItem quitGame = new SimpleMenuItem("Quit Game");

                newGame.setNext(loadGame);
                loadGame.setNext(quitGame);
                quitGame.setNext(newGame);
                quitGame.setLast(loadGame);
                loadGame.setLast(newGame);
                newGame.setLast(quitGame);

                gameObjectLists[0].Add(newGame);
                gameObjectLists[0].Add(loadGame);
                gameObjectLists[0].Add(quitGame);

            }
            base.launch();
        }

    }
}
