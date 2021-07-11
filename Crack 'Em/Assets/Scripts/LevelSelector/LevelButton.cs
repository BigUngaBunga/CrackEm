using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace CrackEm
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private bool isUnlocked;
        [SerializeField] private int sceneNumber;


        private void Awake()
        {
            GetComponentInChildren<TextMeshProUGUI>().SetText(sceneNumber.ToString());;
            isUnlocked = PlayerPrefs.GetInt("HighestLevel") + 1 >= sceneNumber;
            gameObject.GetComponent<Image>().color = isUnlocked ? Color.green : Color.red;
        }

        public void SelectLevel()
        {
            if (isUnlocked)
            {
                SceneManager.LoadScene(sceneNumber);
                Debug.Log("Loaded scene " + sceneNumber);
            }
        }
    }
}

