using System.Collections.ObjectModel;
using Protoinject;

namespace Protogame
{
    using System;
    using Microsoft.Xna.Framework;

    /// <summary>
    /// The GameContext interface.
    /// </summary>
    /// <module>Core API</module>
    public interface IGameContext
    {
        /// <summary>
        /// Gets the frames-per-second of the current game.
        /// </summary>
        /// <value>
        /// The FPS.
        /// </value>
        int FPS { get; set; }

        /// <summary>
        /// Gets the number of frames that have been rendered in total during the game.
        /// </summary>
        /// <value>
        /// The total number of frames rendered.
        /// </value>
        int FrameCount { get; set; }

        /// <summary>
        /// Gets the game instance.
        /// </summary>
        /// <value>
        /// The game instance.
        /// </value>
        Game Game { get; }

        /// <summary>
        /// Gets the amount of game time elapsed since the last update or render step.
        /// </summary>
        /// <value>
        /// The elapsed game time since the last update or render step.
        /// </value>
        GameTime GameTime { get; set; }

        /// <summary>
        /// Gets the graphics device manager, which provide a high-level API to the graphics device.
        /// </summary>
        /// <value>
        /// The graphics device manager.
        /// </value>
        GraphicsDeviceManager Graphics { get; }

        /// <summary>
        /// Gets the game window.
        /// </summary>
        /// <value>
        /// The window the game is rendering in.
        /// </value>
        IGameWindow Window { get; }

        /// <summary>
        /// Gets the current world.
        /// </summary>
        /// <value>
        /// The current active world in the game.
        /// </value>
        IWorld World { get; }

        /// <summary>
        /// Gets the world manager.
        /// </summary>
        /// <value>
        /// The world manager.
        /// </value>
        IWorldManager WorldManager { get; }

        /// <summary>
        /// Gets the dependency injection hierarchy, which contains all worlds, entities and components.
        /// </summary>
        /// <value>
        /// The dependency injection hierarchy, which contains all worlds, entities and components.
        /// </value>
        IHierarchy Hierarchy { get; }

        /// <summary>
        /// Gets or sets the ray representing the mouse cursor in 3D space.  This is
        /// updated automatically by DefaultRenderContext based on the World, View and Projection
        /// properties of the current render context.
        /// </summary>
        /// <value>The ray representing the mouse cursor in 3D space.</value>
        Ray MouseRay { get; set; }

        /// <summary>
        /// Gets or sets the plane representing the mouse cursor's Y position in 3D space.  This forms
        /// a plane such that if it were projected back to the screen it would intersect the mouse's
        /// Y position along the X axis of the screen.  This is updated automatically by 
        /// DefaultRenderContext based on the World, View and Projection properties of the current render context.
        /// </summary>
        /// <value>The plane representing the mouse cursor's Y position in 3D space.</value>
        Plane MouseHorizontalPlane { get; set; }

        /// <summary>
        /// Gets or sets the plane representing the mouse cursor's X position in 3D space.  This forms
        /// a plane such that if it were projected back to the screen it would intersect the mouse's
        /// X position along the Y axis of the screen.  This is updated automatically by 
        /// DefaultRenderContext based on the World, View and Projection properties of the current render context.
        /// </summary>
        /// <value>The plane representing the mouse cursor's X position in 3D space.</value>
        Plane MouseVerticalPlane { get; set; }

        /// <summary>
        /// Creates the specified world and returns it.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the world to create.
        /// </typeparam>
        /// <returns>
        /// The <see cref="IWorld"/>.
        /// </returns>
        IWorld CreateWorld<T>() where T : IWorld;

        /// <summary>
        /// Creates the specified world using a given factory and returns it.
        /// </summary>
        /// <param name="creator">The method used to create the world.</param>
        /// <typeparam name="T">
        /// The type of the world to create.
        /// </typeparam>
        /// <returns>
        /// The <see cref="IWorld"/>.
        /// </returns>
        IWorld CreateWorld<TFactory>(Func<TFactory, IWorld> creator);

        /// <summary>
        /// Resizes the game window to the specified width and height.  This method
        /// can only be called during the update step (not during rendering).
        /// </summary>
        /// <param name="width">
        /// The desired width of the game window.
        /// </param>
        /// <param name="height">
        /// The desired height of the game window.
        /// </param>
        void ResizeWindow(int width, int height);

        /// <summary>
        /// Switches the current active world to a new instance of the world, as
        /// specified by the given type.
        /// </summary>
        /// <typeparam name="T">
        /// The type of world to create and switch to.
        /// </typeparam>
        void SwitchWorld<T>() where T : IWorld;

        /// <summary>
        /// Switches the current active world to a new instance of the world, using
        /// the specified factory method to create the instance of the world.
        /// </summary>
        /// <param name="creator">
        /// The factory method used to create the world.
        /// </param>
        /// <typeparam name="TFactory">
        /// The type of world to create and switch to.
        /// </typeparam>
        void SwitchWorld<TFactory>(Func<TFactory, IWorld> creator);

        /// <summary>
        /// Switches the current active world to the specified world instance.
        /// </summary>
        /// <param name="world">
        /// The world instance to switch to.
        /// </param>
        /// <typeparam name="TFactory">
        /// The type of world to switch to.
        /// </typeparam>
        void SwitchWorld<T>(T world) where T : IWorld;
    }
}