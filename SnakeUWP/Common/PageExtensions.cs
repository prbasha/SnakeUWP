using Windows.UI.ViewManagement;
using Windows.UI.Xaml;

namespace SnakeUWP.Common
{
    /// <summary>
    /// The PageExtensions class provides the ability to customise a UWP application title text.
    /// It allows the title text to be bound to a property.
    /// </summary>
    public static class PageExtensions
    {
        /// <summary>
        /// Title dependecy property.
        /// </summary>
        public static readonly DependencyProperty TitleProperty = DependencyProperty.RegisterAttached("Title", typeof(string), typeof(PageExtensions), new PropertyMetadata(string.Empty, OnTitlePropertyChanged));

        /// <summary>
        /// The GetTitle method is called to get the title text.
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string GetTitle(DependencyObject d)
        {
            return d.GetValue(TitleProperty).ToString();
        }

        /// <summary>
        /// The SetTitle method is called to set the title text.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="value"></param>
        public static void SetTitle(DependencyObject d, string value)
        {
            d.SetValue(TitleProperty, value);
        }

        /// <summary>
        /// The OnTitlePropertyChanged is called when the title text is changed.
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            string title = e.NewValue.ToString();
            var window = ApplicationView.GetForCurrentView();
            window.Title = title;
        }
    }
}
