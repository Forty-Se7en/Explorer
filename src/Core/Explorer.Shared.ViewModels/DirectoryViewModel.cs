namespace Explorer.Shared.ViewModels
{
    public sealed class DirectoryViewModel : FileEntityViewModel
    {
        public DirectoryViewModel(string directoryName) : base(directoryName) 
        {
            this.FullName = directoryName;
        }

        public DirectoryViewModel(DirectoryInfo directoryInfo) : base(directoryInfo.Name) 
        {
            this.FullName = directoryInfo.FullName;   
        }

    }

}