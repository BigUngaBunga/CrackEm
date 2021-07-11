using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace CrackEm
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private bool isUnlocked;
        [SerializeField] private string scene;


        private void Awake() => gameObject.GetComponent<Image>().color = isUnlocked ? Color.green : Color.red;

        public void SelectLevel()
        {
            if (isUnlocked)
            {
                SceneManager.LoadScene(scene);
                Debug.Log("Loaded " + scene);
            }
                
        }
    }
}

