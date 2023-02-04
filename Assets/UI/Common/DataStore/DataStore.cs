namespace Settings
{
    public interface DataStore
    {
        void SetData<T>(T data, string name);
        T GetData<T>(string name);

        bool Exists(string name);
    }
}