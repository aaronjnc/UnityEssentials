using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EnemySize))]
public class EnemySizeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        EnemySize script = (EnemySize)target;
        script.waitSeconds = EditorGUILayout.FloatField("Wait Seconds", script.waitSeconds);
        if (GUILayout.Button("Press Me"))
        {
            Debug.Log("Hello World");
        }
    }
}
