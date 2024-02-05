using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase 
    {
#pragma warning disable CA1822 // Mark members as static
        private string greeting="pORGI ZBIHAL";
        public void Command()
        {
            Greeting = "new message";  
            this.RaisePropertyChanged(nameof(Greeting));
        }
        public string Greeting { get => greeting; set => greeting = value; }
#pragma warning restore CA1822 // Mark members as static
    }
}