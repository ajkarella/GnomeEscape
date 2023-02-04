namespace Settings
{
    public class SettingsData
    {
        public float Volume;
        public bool IsGore;

        public SettingsData(float volume, bool isGore)
        {
            Volume = volume;
            IsGore = isGore;
        }
    }
}