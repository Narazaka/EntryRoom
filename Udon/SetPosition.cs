using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Narazaka.VRChat.EntryRoom
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    internal class SetPosition : UdonSharpBehaviour
    {
        [SerializeField] Transform Target;
        [SerializeField] Transform Position;

        void OnEnable()
        {
            Target.position = Position.position;
            Target.rotation = Position.rotation;
        }
    }
}
