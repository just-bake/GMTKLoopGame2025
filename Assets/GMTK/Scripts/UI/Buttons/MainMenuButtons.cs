using System.Linq;
using JetBrains.Annotations;
using Michsky.LSS;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace gmtk
{
    public class MainMenuButtons : MonoBehaviour
    {
        private LSS_Manager _lsm; // LSM variable

        [CanBeNull]
        private LSS_Manager Lsm
        {
            get
            {
                if (_lsm == null)
                {
                    _lsm = FindObjectsByType<LSS_Manager>(FindObjectsSortMode.None).First();
                }

                return _lsm;
            }
        }

        public void PlayButtonClicked()
        {
            Lsm?.UnloadAdditiveScene("MainMenuScene");
            Lsm?.LoadSceneAdditive("GameScene");
        }

        public void SettingsButtonClicked()
        {
            Lsm?.UnloadAdditiveScene("MainMenuScene");
            Lsm?.LoadSceneAdditive("SettingsScene");
        }

        public void QuitButtonClicked()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}