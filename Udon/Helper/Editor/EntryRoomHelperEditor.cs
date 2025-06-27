using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UdonSharp;
using VRC.SDK3.Components;
using System.Linq;

namespace Narazaka.VRChat.EntryRoom.Helper.Editor
{
    [CustomEditor(typeof(EntryRoomHelper))]
    public class EntryRoomHelperEditor : UnityEditor.Editor
    {
        SerializedProperty vrcWorld;

        private void OnEnable()
        {
            vrcWorld = serializedObject.FindProperty(nameof(EntryRoomHelper.vrcWorld));
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            serializedObject.UpdateIfRequiredOrScript();
            if (vrcWorld.objectReferenceValue == null)
            {
                vrcWorld.objectReferenceValue = FindObjectsByType<VRCSceneDescriptor>(FindObjectsSortMode.None).FirstOrDefault();
                serializedObject.ApplyModifiedProperties();
            }
            if (GUILayout.Button("Setup"))
            {
                Setup(target as EntryRoomHelper);
            }
        }

        private void Setup(EntryRoomHelper helper)
        {
            helper.vrcWorld.spawns = new Transform[0];
            foreach (Transform child in helper.parent)
            {
                var setPosition = child.Find("System/GimmickPosition").GetComponent<SetPosition>();
                var so = new SerializedObject(setPosition);
                so.FindProperty("Target").objectReferenceValue = helper.gimmickRoot;
                so.ApplyModifiedProperties();

                var spawnPoint = child.Find("System/SpawnPoint");
                ArrayUtility.Add(ref helper.vrcWorld.spawns, spawnPoint);
            }
            Undo.RecordObject(helper.vrcWorld, "Spawn System Helper Setup");
        }
    }
}
