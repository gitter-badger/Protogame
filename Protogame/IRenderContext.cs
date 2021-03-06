using System;
using System.Runtime.CompilerServices;

namespace Protogame
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// The RenderContext interface.
    /// </summary>
    /// <module>Core API</module>
    public interface IRenderContext
    {
        /// <summary>
        /// Gets the bounding frustum for the current view and projection matrixes.
        /// </summary>
        /// <value>
        /// The bounding frustum for the current view and projection matrixes.
        /// </value>
        BoundingFrustum BoundingFrustum { get; }

        /// <summary>
        /// Gets the current active effect for rendering.
        /// </summary>
        /// <value>
        /// The effect.
        /// </value>
        Effect Effect { get; }

        /// <summary>
        /// Gets the associated graphics device.
        /// </summary>
        /// <value>
        /// The graphics device.
        /// </value>
        GraphicsDevice GraphicsDevice { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the world manager is currently
        /// rendering a 3D context.  For games using a 2D world manager, this will
        /// always be false.  For 3D games, world managers will do an initial 3D pass
        /// followed by a 2D pass that is rendered on top (for UI, etc.) In a 3D
        /// context, only I3DRenderUtilities can be used; in a 2D context, only
        /// I2DRenderUtilities can be used.
        /// </summary>
        /// <value>
        /// Whether the rendering context is currently a 3D context.
        /// </value>
        [Obsolete("For games using the new render pipeline, call IRenderContext.IsCurrentRenderPass<I3DRenderPass>() instead.")]
        bool Is3DContext { get; set; }

        /// <summary>
        /// Gets a value indicating whether the game is currently rendering
        /// in either the render pipeline or the backbuffer.  This value will always
        /// be true within any method call that occurs below <see cref="Game.Draw"/>
        /// in the call stack.  When you are rendering, certain operations can not
        /// be performed, in particular, operations which reset the graphics device
        /// like resizing the game window.
        /// </summary>
        bool IsRendering { get; set; }

        /// <summary>
        /// Gets or sets the projection matrix for 3D rendering.
        /// </summary>
        /// <value>
        /// The projection matrix for 3D rendering.
        /// </value>
        Matrix Projection { get; set; }

        /// <summary>
        /// Gets a texture representing a single white pixel.
        /// </summary>
        /// <value>
        /// The single white pixel.
        /// </value>
        Texture2D SingleWhitePixel { get; }

        /// <summary>
        /// Gets a sprite batch associated with the current device, upon which 2D rendering is performed.
        /// </summary>
        /// <value>
        /// The sprite batch.
        /// </value>
        SpriteBatch SpriteBatch { get; }

        /// <summary>
        /// Gets or sets the view matrix for 3D rendering.
        /// </summary>
        /// <value>
        /// The view matrix for 3D rendering.
        /// </value>
        Matrix View { get; set; }

        /// <summary>
        /// Gets or sets the world matrix for 3D rendering.
        /// </summary>
        /// <value>
        /// The world matrix for 3D rendering.
        /// </value>
        Matrix World { get; set; }

        /// <summary>
        /// Enables rendering with textures for the current effect.
        /// </summary>
        void EnableTextures();

        /// <summary>
        /// Enables rendering with plain colors for the current effect.
        /// </summary>
        void EnableVertexColors();

        /// <summary>
        /// Pop an effect from the current rendering context.
        /// </summary>
        /// <returns>
        /// The effect that was popped from the current rendering context.
        /// </returns>
        Effect PopEffect();

        /// <summary>
        /// Pops the current render target from the current rendering context.  If there are no more render targets
        /// in the stack after this call, then the rendering will default back to rendering to the back buffer.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">
        /// Thrown if the current render target does not match the top of the stack.  This indicates that there
        /// is other code calling SetRenderTarget, and changing the render target with this method may corrupt
        /// the rendering state.
        /// </exception>
        void PopRenderTarget();

        /// <summary>
        /// Push an effect onto the current rendering context, making it the active effect used for rendering.
        /// </summary>
        /// <param name="effect">
        /// The effect instance.
        /// </param>
        void PushEffect(Effect effect);

        /// <summary>
        /// Push a render target onto the current rendering context, making it
        /// the active target for rendering.  By using the PushRenderTarget / PopRenderTarget
        /// methods, this allows you to safely chain render target switches, without risk
        /// of losing the previous render target.  An example of where this can be used is
        /// if you want to capture the next frame, you can simply start with a PushRenderTarget
        /// and as long as all other render target switching uses these methods or respects the
        /// previous render target, then everything will be captured as intended.
        /// </summary>
        /// <param name="renderTarget">
        /// The render target instance to make active.
        /// </param>
        void PushRenderTarget(RenderTargetBinding renderTarget);

        /// <summary>
        /// Push an array of render targets onto the current rendering context, making them
        /// the active target for rendering.  By using the PushRenderTarget / PopRenderTarget
        /// methods, this allows you to safely chain render target switches, without risk
        /// of losing the previous render target.
        /// </summary>
        /// <param name="renderTargets">
        /// The render targets to make active.
        /// </param>
        void PushRenderTarget(params RenderTargetBinding[] renderTargets);

        /// <summary>
        /// Called by the world manager to set up the render context at the beginning of a render.
        /// </summary>
        /// <param name="context">
        /// The current game context.
        /// </param>
        void Render(IGameContext context);

        /// <summary>
        /// Set the active texture used in rendering.
        /// </summary>
        /// <param name="texture">
        /// The active texture.
        /// </param>
        void SetActiveTexture(Texture2D texture);

        /// <summary>
        /// Adds the specified render pass to the render pipeline
        /// permanently.  This render pass will take effect after the
        /// start of the next frame.
        /// </summary>
        /// <returns>
        /// The render pass that was given to this function.  This return
        /// value is for convenience only, so that you may construct and add
        /// a render pass in a single statement, while obtaining a reference to
        /// it if you need to modify it's values or call <see cref="RemoveFixedRenderPass"/>
        /// later.  The render pass is not modified by this function.
        /// </returns>
        /// <param name="renderPass">The render pass to add.</param>
        IRenderPass AddFixedRenderPass(IRenderPass renderPass);

        /// <summary>
        /// Removes the specified render pass from the render pipeline.
        /// </summary>
        /// <param name="renderPass">The render pass to remove.</param>
        void RemoveFixedRenderPass(IRenderPass renderPass);

        /// <summary>
        /// Append the specified render pass to the render pipeline
        /// for this frame only.  This is method that allows you to temporarily
        /// add additional render passes to a frame.
        /// <para>
        /// If all standard (non-post-processing) render passes have finished
        /// post-processing has begun and this method is given a standard render
        /// pass, it will have no effect.
        /// </para>
        /// <para>
        /// Render passes that were appended can not be removed with
        /// <see cref="RemoveFixedRenderPass"/>.
        /// </para>
        /// </summary>
        /// <returns>
        /// The render pass that was given to this function.  This return
        /// value is for convenience only, so that you may construct and add
        /// a render pass in a single statement, while obtaining a reference to
        /// it if you need to modify it's value.  The render pass is not
        /// modified by this function.
        /// </returns>
        /// <param name="renderPass">The render pass to add.</param>
        IRenderPass AppendTransientRenderPass(IRenderPass renderPass);

        /// <summary>
        /// Gets the current render pass that is being used.
        /// </summary>
        /// <value>The current render pass that is being used.</value>
        IRenderPass CurrentRenderPass { get; }

        /// <summary>
        /// Returns whether or not the current render pass is of the specified type.
        /// </summary>
        /// <typeparam name="T">The type to check the render pass against.</typeparam>
        /// <returns>Whether or not the current render pass is of the specified type.</returns>
        bool IsCurrentRenderPass<T>() where T : class, IRenderPass;

        /// <summary>
        /// Returns whether or not the current render pass is of the specified type.  Outputs
        /// the casted render pass to currentRenderPass.
        /// </summary>
        /// <typeparam name="T">The type to check the render pass against.</typeparam>
        /// <param name="currentRenderPass">The current render pass casted to the specified type.</param>
        /// <returns>Whether or not the current render pass is of the specified type.</returns>
        bool IsCurrentRenderPass<T>(out T currentRenderPass) where T : class, IRenderPass;

        /// <summary>
        /// Returns the current render pass as the type T.
        /// </summary>
        /// <typeparam name="T">The type of render pass to return.</typeparam>
        /// <returns>The current render pass as the type T.</returns>
        T GetCurrentRenderPass<T>() where T : class, IRenderPass;

        /// <summary>
        /// Returns whether this is the first render pass being performed.  You can use
        /// this method to isolate render logic that should only occur once per
        /// frame (such as appending transient render passes).
        /// </summary>
        /// <returns>Whether this is the first render pass being performed.</returns>
        bool IsFirstRenderPass();
    }
}