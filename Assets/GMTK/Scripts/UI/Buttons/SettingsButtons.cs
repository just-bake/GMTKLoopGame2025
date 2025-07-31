using System.Linq;
using JetBrains.Annotations;
using Michsky.LSS;
using UnityEngine;

namespace gmtk
{
    public class SettingsButtons : MonoBehaviour
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

        public void BackButtonClicked()
        {
            Lsm?.UnloadAdditiveScene("SettingsScene");
            Lsm?.LoadSceneAdditive("MainMenuScene");
        }
    }
}