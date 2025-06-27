using UnityEngine;
using VRC.SDK3.Components;
using Narazaka.VRChat.FadeTeleport;

namespace Narazaka.VRChat.EntryRoom.Helper
{
    public class EntryRoomHelper : MonoBehaviour
    {
        public VRCSceneDescriptor vrcWorld;
        public FadeTeleportTo FadeTeleportTo;
        public Transform gimmickRoot;
        public Transform parent;
    }
}
