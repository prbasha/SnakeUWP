using SnakeUWP.ViewModel;
using Windows.UI.Xaml.Controls;

namespace SnakeUWP.View
{
    /// <summary>
    /// The SnakeView class represents the View for the Snake game.
    /// </summary>
    public sealed partial class SnakeView : Page
    {
        #region Fields
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SnakeView()
        {
            InitializeComponent();
            
            // Create the View Model.
            ViewModel = new SnakeViewModel();
        }
        
        #endregion

        #region Events
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the View Model.
        /// </summary>
        public SnakeViewModel ViewModel { get; set; }

        #endregion

        #region Methods
        #endregion
    }
}
