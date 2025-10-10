using UnityEngine;
using GameNetcodeStuff;
using VoxxWeatherPlugin.Utils;

namespace VoxxWeatherPlugin.Behaviours
{
    internal sealed class ToxicFumes : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                PlayerControllerB playerController = other.gameObject.GetComponent<PlayerControllerB>();

                if (playerController == GameNetworkManager.Instance.localPlayerController)
                {
                    PlayerEffectsManager.isPoisoned = true;
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                PlayerControllerB playerController = other.gameObject.GetComponent<PlayerControllerB>();

                if (playerController == GameNetworkManager.Instance.localPlayerController)
                {
                    PlayerEffectsManager.isPoisoned = false;
                }
            }
        }
    }
}
