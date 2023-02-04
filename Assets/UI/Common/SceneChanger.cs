using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class SceneChanger : MonoBehaviour
    {
        [SerializeField] private string sceneName;

        public void ChangeScene()
        {
            SceneManager.LoadScene(sceneName);
        }

        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
