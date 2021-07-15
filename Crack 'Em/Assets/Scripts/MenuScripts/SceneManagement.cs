using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrackEm
{
    public class SceneManagement : MonoBehaviour
    {
        public void RestartScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

        public void ReturnToMenu() => SceneManager.LoadScene("MainMenu");
    }
}


