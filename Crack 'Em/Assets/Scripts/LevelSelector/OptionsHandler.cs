using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CrackEm
{
    public class OptionsHandler : MonoBehaviour
    {
        [SerializeField] GameObject levelSelectObject, mainOptionsObject;

        public void ChangeMenu()
        {
            bool mainOptionsState = mainOptionsObject.activeInHierarchy;
            levelSelectObject.SetActive(mainOptionsState);
            mainOptionsObject.SetActive(!mainOptionsState);
        }
    }
}


