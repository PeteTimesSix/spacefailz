﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataComplex
{
    public interface IGameScene
    {

        IGameScene updateSelf();
        void launch();

    }
}
