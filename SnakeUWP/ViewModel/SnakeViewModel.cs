using SnakeUWP.Common;
using SnakeUWP.Model;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace SnakeUWP.ViewModel
{
    /// <summary>
    /// The SnakeViewModel class represents the View Model for the Snake game.
    /// </summary>
    public class SnakeViewModel : NotificationBase
    {

        #region Fields
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SnakeViewModel()
        {
            SnakeGameLogic = new SnakeGame();
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
        }

        #endregion

        #region Events
        #endregion

        #region Properties

        /// <summary>
        /// Gets the snake game logic.
        /// </summary>
        public SnakeGame SnakeGameLogic { get; }
        
        #endregion

        #region Methods

        void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)
        {
            if (SnakeGameLogic.IsGameRunning)
            {
                if (args.VirtualKey == Windows.System.VirtualKey.Up)
                {
                    SnakeGameLogic.ProcessKeyboardEvent(Direction.Up);
                }
                else if (args.VirtualKey == Windows.System.VirtualKey.Right)
                {
                    SnakeGameLogic.ProcessKeyboardEvent(Direction.Right);
                }
                else if (args.VirtualKey == Windows.System.VirtualKey.Down)
                {
                    SnakeGameLogic.ProcessKeyboardEvent(Direction.Down);
                }
                else if (args.VirtualKey == Windows.System.VirtualKey.Left)
                {
                    SnakeGameLogic.ProcessKeyboardEvent(Direction.Left);
                }
            }
        }
        
        #endregion
    }
}
