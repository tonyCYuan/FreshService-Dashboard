using System.Windows;

namespace SDTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeApplication();
        }

        /// <summary>
        /// Initializes the application and loads the necessary data
        /// </summary>
        private void InitializeApplication()
        {
            // Check if API key and domain are configured
            var apiKey = System.Configuration.ConfigurationManager.AppSettings["FreshserviceApiKey"];
            var domain = System.Configuration.ConfigurationManager.AppSettings["FreshserviceDomain"];

            if (string.IsNullOrEmpty(apiKey) || apiKey == "your-api-key-here" ||
                string.IsNullOrEmpty(domain) || domain == "your-domain.freshservice.com")
            {
                MessageBox.Show("Please configure your Freshservice API key and domain in the App.config file.",
                    "Configuration Required",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            // Initialize services and load data
            LoadCurrentTickets();
        }

        /// <summary>
        /// Loads the current tickets for the user
        /// </summary>
        private void LoadCurrentTickets()
        {
            // This will be implemented to fetch tickets via the Freshservice API
            // For now, this is a placeholder
            try
            {
                // Call to Freshservice API will be implemented here
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}