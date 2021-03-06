using Protoinject;
using Protogame;
using System.Diagnostics;
using System;

namespace ProtogameAssetManager
{
    internal class AssetManagerGame : CoreGame<AssetManagerWorld, Default2DWorldManager>
    {
        private IAssetManager m_AssetManager;

        private AssetManagerWorld AssetWorld
        {
            get { return this.GameContext.World as AssetManagerWorld; }
        }

        public AssetManagerGame(IKernel kernel) : base(kernel)
        {
            // We can't pass the asset manager into the game because
            // we need to wait for CoreGame to register IAssetContentManager.
            this.m_AssetManager = kernel.Get<IAssetManagerProvider>().GetAssetManager(true);
        }
        
        protected override void LoadContent()
        {
            base.LoadContent();

            this.GameContext.ResizeWindow(800, 600);
            this.IsMouseVisible = true;
            this.Window.Title = "Protogame Asset Manager";

            this.AssetWorld.AssetManager = this.m_AssetManager;
        }
    }
}
