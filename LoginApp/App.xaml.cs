using LoginApp.Models;

namespace LoginApp
{
    public partial class App : Application
    {

        public static UserInfo UserInfo;
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}