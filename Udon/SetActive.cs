using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Narazaka.VRChat.EntryRoom
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    internal class SetActive : UdonSharpBehaviour
    {
        [SerializeField] GameObject[] SetActives = new GameObject[0];
        [SerializeField] GameObject[] SetInactives = new GameObject[0];

        void OnEnable()
        {
            if (SetActives != null)
            {
                foreach (var go in SetActives)
                {
                    if (go != null)
                    {
                        go.SetActive(true);
                    }
                }
            }
            if (SetInactives != null)
            {
                foreach (var go in SetInactives)
                {
                    if (go != null)
                    {
                        go.SetActive(false);
                    }
                }
            }
        }
    }
}
