using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Settings
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Button settingsButton;
        [SerializeField] private CanvasController settingsCanvas;
        [SerializeField] private CanvasController mainMenuCanvas;
        [SerializeField] private SceneChanger sceneChanger;
        [SerializeField] private string mainSceneName; 
        
        private void Awake()
        {
            startButton.onClick.AddListener(StartAction);
            settingsButton.onClick.AddListener(CancelAction);
        }
        private void StartAction()
        {
            sceneChanger.ChangeScene(mainSceneName);
        }
        private void CancelAction()
        {
            settingsCanvas.Hide();
            settingsCanvas.Show();
        }
    }
}