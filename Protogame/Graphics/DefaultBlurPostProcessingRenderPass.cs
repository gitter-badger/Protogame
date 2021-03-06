﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Protogame
{
    /// <summary>
    /// The default implementation of an <see cref="IBlurPostProcessingRenderPass"/>.
    /// </summary>
    /// <module>Graphics</module>
    /// <internal>True</internal>
    /// <interface_ref>Protogame.IBlurPostProcessingRenderPass</interface_ref>
    public class DefaultBlurPostProcessingRenderPass : IBlurPostProcessingRenderPass
    {
        private readonly Effect _blurEffect;

        private readonly IGraphicsBlit _graphicsBlit;

        public DefaultBlurPostProcessingRenderPass(IAssetManagerProvider assetManagerProvider, IGraphicsBlit graphicsBlit)
        {
            _blurEffect = assetManagerProvider.GetAssetManager().Get<EffectAsset>("effect.Blur").Effect;
            _graphicsBlit = graphicsBlit;
        }

        /// <summary>
        /// Gets a value indicating that this is a post-processing render pass.
        /// </summary>
        /// <value>Always true.</value>
        public bool IsPostProcessingPass
        {
            get { return true; }
        }

        /// <summary>
        /// Gets or sets the number of blur iterations to apply.
        /// </summary>
        public int Iterations { get; set; }

        public void BeginRenderPass(IGameContext gameContext, IRenderContext renderContext, IRenderPass previousPass, RenderTarget2D postProcessingSource)
        {
            // TODO Make iterations work.

            _blurEffect.Parameters["PixelWidth"].SetValue(1f/postProcessingSource.Width);
            _blurEffect.Parameters["PixelHeight"].SetValue(1f/postProcessingSource.Height);
            //_blurEffect.CurrentTechnique.Passes[0].Apply();

            // Parameters will get applied when blitting occurs.

            _graphicsBlit.Blit(renderContext, postProcessingSource, null, _blurEffect);
        }

        public void EndRenderPass(IGameContext gameContext, IRenderContext renderContext, IRenderPass nextPass)
        {
        }
    }
}
