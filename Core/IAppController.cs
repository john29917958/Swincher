namespace Switcher.Core
{
    interface IAppController
    {
        bool Find(string name);
        void Open(string name);
        void Focus(string name);
    }
}
