using UnityEngine;

namespace Settings
{
    public class PlayerPrefsDataStoreAdapter : DataStore
    {
        public T GetData<T>(string name)
        {
            var json = PlayerPrefs.GetString(name, "{}");
            return JsonUtility.FromJson<T>(json);
        }

        public bool Exists(string name)
        {
            return PlayerPrefs.HasKey(name);
        }

        public void SetData<T>(T data, string name)
        {
            var json = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(name, json);
            PlayerPrefs.Save();
        }
    }
}