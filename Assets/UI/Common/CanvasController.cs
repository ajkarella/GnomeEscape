using UnityEngine;

namespace UI
{
    public class CanvasController : MonoBehaviour
    {
        [SerializeField] private bool enabledOnAwake;
        private Canvas _canvas;
        
        public void Show()
        {
            _canvas.enabled = true;
        }
        public void Hide()
        {
            _canvas.enabled = false;
        }

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();
            _canvas.enabled = enabledOnAwake;
        }
    }
}