using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DropDown))]
public class DropdownEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        DropDown script = (DropDown)target;

        GUIContent arrayList1 = new GUIContent("Slot1");
        script.listIdx = EditorGUILayout.Popup(arrayList1, script.listIdx, script.Slot1.ToArray());

        GUIContent arrayList2 = new GUIContent("Slot2");
        script.listIdx2 = EditorGUILayout.Popup(arrayList2, script.listIdx2, script.MyList2.ToArray());

        GUIContent arrayList3 = new GUIContent("Slot3");
        script.listIdx3 = EditorGUILayout.Popup(arrayList3, script.listIdx3, script.MyList3.ToArray());

        GUIContent arrayList4 = new GUIContent("Slot4");
        script.listIdx4 = EditorGUILayout.Popup(arrayList4, script.listIdx4, script.MyList4.ToArray());

        GUIContent arrayList5 = new GUIContent("Slot5");
        script.listIdx5 = EditorGUILayout.Popup(arrayList5, script.listIdx5, script.MyList5.ToArray());

        GUIContent arrayList6 = new GUIContent("Slot6");
        script.listIdx6 = EditorGUILayout.Popup(arrayList6, script.listIdx6, script.MyList6.ToArray());

        GUIContent arrayList7 = new GUIContent("Slot7");
        script.listIdx7 = EditorGUILayout.Popup(arrayList7, script.listIdx7, script.MyList7.ToArray());

        GUIContent arrayList8 = new GUIContent("Slot8");
        script.listIdx8 = EditorGUILayout.Popup(arrayList8, script.listIdx8, script.MyList8.ToArray());
    }
}    