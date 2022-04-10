namespace Explorer.Shared.ViewModels
{
    public abstract class FileEntityViewModel : BaseViewModel
    {
        public string Name { get; }

        public string FullName { get; protected set; }

        protected FileEntityViewModel(string name)
        {
            Name = name;
        }
    }

}