using JetBrains.Annotations;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Narazaka.VRChat.EntryRoom
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    internal class Send : UdonSharpBehaviour
    {
        [SerializeField] UdonBehaviour target;
        [SerializeField] string eventName;

        public override void Interact()
        {
            SendEvent();
        }

        [PublicAPI]
        public void SendEvent()
        {
            if (target != null && !string.IsNullOrEmpty(eventName))
            {
                target.SendCustomEvent(eventName);
            }
            else
            {
                Debug.LogWarning("Target or event name is not set in Send component.");
            }
        }
    }
}
