using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine.XR.ARFoundation.Samples
{
    public class BackButton : MonoBehaviour
    {
        [SerializeField]
        GameObject m_BackButton;
        public GameObject backButton
        {
            get => m_BackButton;
            set => m_BackButton = value;
        }

        void Start()
        {
            if (Application.CanStreamedLevelBeLoaded("Menu"))
                m_BackButton.SetActive(true);
        }

        void Update()
        {
            if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
                BackButtonPressed();
        }

        public void BackButtonPressed()
        {
            if (Application.CanStreamedLevelBeLoaded("Menu"))
                SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        public void FrontCam()
        {
            if (Application.CanStreamedLevelBeLoaded("FrontCamera"))
                SceneManager.LoadScene("FrontCamera", LoadSceneMode.Single);
        }
        public void BackCam()
        {
            if (Application.CanStreamedLevelBeLoaded("BackCamera"))
                SceneManager.LoadScene("BackCamera", LoadSceneMode.Single);
        }

    }
}
