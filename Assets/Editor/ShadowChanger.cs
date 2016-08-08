using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;


public class ShadowChanger : EditorWindow
{

	public List<string> m_Identifier = new List<string>();

	[MenuItem("ShadowTools/Change")]
	public static void ShowWindow()
	{
		EditorWindow.GetWindow(typeof(ShadowChanger));
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(3, 50, position.width - 6, 20), "Change"))
		{
			ChangeLevelDesignBlock();
		}
	}

	public void ChangeLevelDesignBlock()
	{
		GameObject[] shadows = GameObject.FindGameObjectsWithTag ("Shadow");
		foreach (GameObject sha in shadows) 
		{
			sha.layer = 12;
		}
	}

}


