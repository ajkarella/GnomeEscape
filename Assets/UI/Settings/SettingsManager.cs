using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Settings
{
    public class SettingsManager : MonoBehaviour
    {
        [SerializeField] private Button saveButton;
        [SerializeField] private Button cancelButton;
        [SerializeField] private CanvasController settingsCanvas;
        [SerializeField] private CanvasController mainMenuCanvas;
        
        private DataStore _dataStoreAdapter;
        private SettingsData _data;
        private SettingsData Data { get; set; }

        public void SetVolume(float volume)
        {
            Data.Volume = volume;
        }

        public void SetIsGore(bool isGore)
        {
            Data.IsGore = isGore;
        }

        private void Save()
        {
            _dataStoreAdapter.SetData(_data, "Settings");
        }

        private void Cancel()
        {
            settingsCanvas.Hide();
            mainMenuCanvas.Show();
        }

        private void Awake()
        {
            saveButton.onClick.AddListener(Save);
            cancelButton.onClick.AddListener(Cancel);
            LoadOrCreate();
        }

        private void LoadOrCreate()
        {
            _dataStoreAdapter = new PlayerPrefsDataStoreAdapter();
            if (!_dataStoreAdapter.Exists("Settings"))
            {
                _data = new SettingsData(1.0f, false);
                Save();
            }
            else
            {
                _data = _dataStoreAdapter.GetData<SettingsData>("Settings");
            }
        }
    }
}
