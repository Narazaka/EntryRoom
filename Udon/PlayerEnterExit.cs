using System;
using System.Runtime.CompilerServices;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[assembly: InternalsVisibleTo("Narazaka.VRChat.EntryRoom.Helper.Editor")]

namespace Narazaka.VRChat.EntryRoom
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    [RequireComponent(typeof(Collider))]
    internal class PlayerEnterExit : UdonSharpBehaviour
    {
        [SerializeField] GameObject Target;

        public override void OnPlayerTriggerStay(VRCPlayerApi player)
        {
            if (!player.isLocal) return;

            Target.SetActive(true);
        }

        public override void OnPlayerTriggerExit(VRCPlayerApi player)
        {
            if (!player.isLocal) return;

            Target.SetActive(false);
        }
    }
}
