using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Events
        #endregion

        #region Properties

        public string FilePath { get; set; }

        public ObservableCollection<FileEntityViewModel> DirsAndFiles { get; set; } = new ObservableCollection<FileEntityViewModel>();

        public FileEntityViewModel SelectedFileEntity { get; set; }
        #endregion

        #region Commands

        public ICommand OpenDirCommand { get; }

        #endregion

        #region Ctors

        public MainViewModel()
        {
            OpenDirCommand = new CommandDelegate(OpenDir);

            foreach (var el in Directory.GetLogicalDrives())
            {
                DirsAndFiles.Add(new DirectoryViewModel(el));
            }
        }

        #endregion

        #region Methods
        #endregion

        #region CommandMethods

        void OpenDir(object parameter) 
        {
            if (parameter is DirectoryViewModel directoryViewModel)
            {
                this.FilePath = directoryViewModel.FullName;
                DirsAndFiles.Clear();
                
                var directoryInfo = new DirectoryInfo(this.FilePath);
                
                foreach (var dir in directoryInfo.GetDirectories())
                {
                    DirsAndFiles.Add(new DirectoryViewModel(dir));
                }
                foreach (var file in directoryInfo.GetFiles())
                {
                    DirsAndFiles.Add(new FileViewModel(file));
                }

            }
        }

        #endregion


    }

}