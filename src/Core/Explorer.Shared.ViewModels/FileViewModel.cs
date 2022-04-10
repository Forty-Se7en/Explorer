namespace Explorer.Shared.ViewModels
{
    public sealed class FileViewModel : FileEntityViewModel
    {
        public FileViewModel(string fileName) : base(fileName) { this.FullName = fileName; }

        public FileViewModel(FileInfo fileInfo) : base(fileInfo.Name) { this.FullName = fileInfo.FullName; }
    }

}