using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class SearchBymaterial : EditorWindow
{

	public List<string> m_Identifier = new List<string>();
	public Material targetMat;
	[MenuItem("Search/SearchByMaterial")]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow(typeof(SearchBymaterial));
	}

	void OnGUI()
	{
		EditorGUILayout.BeginHorizontal ();
		targetMat = (Material)EditorGUILayout.ObjectField (targetMat, typeof(Material), true);
		EditorGUILayout.EndHorizontal ();
		if(GUILayout.Button("Search"))
		{
			Debug.Log ("Search Start");
			SearchWith(targetMat);
			Debug.Log ("Search End");
		}
	}

	public void SearchWith(Material mat)
	{
		Selection.activeGameObject = null;
		MeshRenderer[] meshs = FindObjectsOfType<MeshRenderer> ();
		List<GameObject> selection = new List<GameObject> (meshs.Length);
		int size = 0;
		foreach (MeshRenderer mesh in meshs)
			if (mesh.sharedMaterial == mat) 
			{
				selection.Add (mesh.gameObject);
				size++;
			}
		Debug.Log ("Found " + size + " Object using this material");
		GameObject[] finalSelection = new GameObject[size];
		int index = 0;
		while (index < size) 
		{
			finalSelection [index] = selection [index];
			++index;
		}
		Selection.objects = finalSelection;
	}
}
