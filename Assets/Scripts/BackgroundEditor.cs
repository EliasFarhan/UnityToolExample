using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Background))]
public class BackgroundEditor : Editor
{

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		
		Background backgroundScript = (Background)target;
		if (GUILayout.Button("Generate Background"))
		{
			backgroundScript.Generate();
		}
	}
}
