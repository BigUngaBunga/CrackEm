using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrackEm
{
    public class SceneManagement : MonoBehaviour
    {
        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
            ResetTime();
        }

        public void ReturnToMenu()
        {
            SceneManager.LoadScene("MainMenu");
            ResetTime();
        }

        private void ResetTime() => Time.timeScale = 1;

    }
}


