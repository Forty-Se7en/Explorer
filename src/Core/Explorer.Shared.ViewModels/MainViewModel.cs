using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Explorer.Shared.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        #endregion

        #region Properties

        public string MainDiskName { get; set; }

        #endregion

        #region Ctors
        public MainViewModel()
        {
            MainDiskName = Environment.SystemDirectory;
        }


        #endregion

        #region Methods
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}