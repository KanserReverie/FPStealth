using FPStealth.Scripts.Utility;
using UnityEngine;

namespace FPStealth.Scripts.Menus
{
    public class MainMenuManager : MonoBehaviour
    {
        public void OpenSceneByName(string sceneName)
        {
            CommonlyUsedStaticMethods.OpenSceneWithSceneName(sceneName);
        }
    }
}
