﻿// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

using dataSimple;
using dataComplex;


namespace logic
{

    public class ThisGameWindow : GameWindow
    {

        private IGameScene activeScene;

        public ThisGameWindow(IGameScene initialScene)
            : base(800, 600, new GraphicsMode(32, 0, 0, 4))
        {
            KeyDown += Keyboard_KeyDown;

            this.activeScene = initialScene;
            initialScene.launch();
        }

        #region Keyboard_KeyDown

        /// <summary>
        /// Occurs when a key is pressed.
        /// </summary>
        /// <param name="sender">The KeyboardDevice which generated this event.</param>
        /// <param name="key">The key that was pressed.</param>
        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Exit();

            if (e.Key == Key.F11)
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
        }

        #endregion

        #region OnLoad

        /// <summary>
        /// Setup OpenGL and load resources here.
        /// </summary>
        /// <param name="e">Not used.</param>
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.MidnightBlue);
        }

        #endregion

        #region OnResize

        /// <summary>
        /// Respond to resize events here.
        /// </summary>
        /// <param name="e">Contains information on the new GameWindow size.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);

            base.OnResize(e);
        }

        #endregion

        #region OnUpdateFrame

        /// <summary>
        /// Add your game logic here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            IGameScene returnScene = activeScene.updateSelf();
            if (returnScene != activeScene)
            {
                activeScene = returnScene;
                activeScene.launch();
            }
            
            //foreach (ILogicObject logicObject in activeScene.getLogicObjects())
            //{
            //    logicObject.updateSelf();
            //}
            //foreach (ILogicObject logicObject in activeScene.getLogicObjects())
            //{
            //    if(logicObject.dead()) activeScene.remove(logicObject);
            //}
            //foreach (ParticleSystem system in activeScene.getParticleSystems())
            //{
            //    activeScene.addParticles(system.getNewParticles());
            //}
        }

        #endregion

        #region OnRenderFrame

        /// <summary>
        /// Add your game rendering code here.
        /// </summary>
        /// <param name="e">Contains timing information.</param>
        /// <remarks>There is no need to call the base implementation.</remarks>
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //foreach (IRenderable renderable in activeScene.getRenderables()) 
            //{
            //    renderable.renderSelf();
            //}
            GL.Begin(PrimitiveType.Triangles);
            
            GL.Color4(Color4.AliceBlue);
            GL.Vertex2(-1.0f, 1.0f);
            GL.Color4(Color4.SpringGreen);
            GL.Vertex2(0.0f, -1.0f);
            GL.Color4(Color4.Ivory);
            GL.Vertex2(1.0f, 1.0f);

            GL.End();

            this.SwapBuffers();
        }

        #endregion
    }
}
