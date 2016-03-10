using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;
using System.Collections.Generic;


public class ChangeLevelDesign : EditorWindow
{

    public List<string> m_Identifier = new List<string>();

    [MenuItem("LevelEditorTools/Change")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ChangeLevelDesign));
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
        /*
        m_Identifier.Add("Arbre01");
        m_Identifier.Add("Arbre02");
        m_Identifier.Add("Bamboo");
        m_Identifier.Add("Arch");
        m_Identifier.Add("DragonRuin");
        m_Identifier.Add("Gong");
        m_Identifier.Add("GrandBonsai");
        m_Identifier.Add("Souche");
        m_Identifier.Add("Hemisphere");
        m_Identifier.Add("Obstacle04");
        m_Identifier.Add("Vertebre");
        m_Identifier.Add("JumpRing");
        m_Identifier.Add("Obstacle01");
        m_Identifier.Add("Seashell");
        m_Identifier.Add("Rocks01");
        m_Identifier.Add("Rocks02");
        m_Identifier.Add("Rocks03");
        m_Identifier.Add("Rocks04");
        m_Identifier.Add("Spring01");
        m_Identifier.Add("Roots01");
        m_Identifier.Add("Tube");
        m_Identifier.Add("Stick01");
        */

        m_Identifier.Add("collectible");

        foreach (string _id in m_Identifier)
        {
            GameObject[] ObjectsWithTag = GameObject.FindGameObjectsWithTag(_id);

            if(ObjectsWithTag.Length>0)
            {
                GameObject _go = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + _id+".prefab", typeof(GameObject)));

                for (int i = 0; i < ObjectsWithTag.Length; i++)
                {
                    GameObject Instance;
                    Instance = PrefabUtility.InstantiatePrefab(_go) as GameObject;
                    Instance.transform.position = ObjectsWithTag[i].transform.position;
                    Instance.transform.rotation = ObjectsWithTag[i].transform.rotation;
                }
            }

        }
        /*


        GameObject[] Arbre01Blocs = GameObject.FindGameObjectsWithTag("Arbre01");
        GameObject[] Arbre02Blocs = GameObject.FindGameObjectsWithTag("Arbre02");
        GameObject[] BambooBlocs = GameObject.FindGameObjectsWithTag("Bamboo");
        GameObject[] ArchBlocs = GameObject.FindGameObjectsWithTag("Arch");
        GameObject[] DragonRuinBlocs = GameObject.FindGameObjectsWithTag("DragonRuin");
        GameObject[] GongBlocs = GameObject.FindGameObjectsWithTag("Gong");
        GameObject[] GrandBonsaiBlocs = GameObject.FindGameObjectsWithTag("GrandBonsai");
        GameObject[] SoucheBlocs = GameObject.FindGameObjectsWithTag("Souche");
        GameObject[] HemisphereBlocs = GameObject.FindGameObjectsWithTag("Hemisphere");
        GameObject[] Obstacle04Blocs = GameObject.FindGameObjectsWithTag("Obstacle04");
        GameObject[] VertebreBlocs = GameObject.FindGameObjectsWithTag("Vertebre");
        GameObject[] JumpRingBlocs = GameObject.FindGameObjectsWithTag("JumpRing");
        GameObject[] Obstacle01Blocs = GameObject.FindGameObjectsWithTag("Obstacle01");
        GameObject[] SeashellBlocs = GameObject.FindGameObjectsWithTag("Seashell");
        GameObject[] Rocks01Blocs = GameObject.FindGameObjectsWithTag("Rocks01");
        GameObject[] Rocks02Blocs = GameObject.FindGameObjectsWithTag("Rocks02");
        GameObject[] Rocks03Blocs = GameObject.FindGameObjectsWithTag("Rocks03");
        GameObject[] Rocks04Blocs = GameObject.FindGameObjectsWithTag("Rocks04");
        GameObject[] Spring01Blocs = GameObject.FindGameObjectsWithTag("Spring01");
        GameObject[] TubeBlocs = GameObject.FindGameObjectsWithTag("Tube");
        GameObject[] Stick01Blocs = GameObject.FindGameObjectsWithTag("Stick01");

        Arbre01 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/"+ "Arbre01.prefab", typeof(GameObject)));
        Arbre02 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Arbre02.prefab", typeof(GameObject)));
        Bamboo = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Bamboo.prefab", typeof(GameObject)));
        Arch = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Arch.prefab", typeof(GameObject)));
        DragonRuin = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "DragonRuin.prefab", typeof(GameObject)));
        Gong = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Gong.prefab", typeof(GameObject)));
        GrandBonsai = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "GrandBonsai.prefab", typeof(GameObject)));
        Souche = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Souche.prefab", typeof(GameObject)));
        Hemisphere = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Hemisphere.prefab", typeof(GameObject)));
        Obstacle04 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Obstacle04.prefab", typeof(GameObject)));
        Seashell = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Seashell.prefab", typeof(GameObject)));
        Rocks01 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Rocks01.prefab", typeof(GameObject)));
        Rocks02 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Rocks02.prefab", typeof(GameObject)));
        Rocks03 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Rocks03.prefab", typeof(GameObject)));
        Rocks04 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Rocks04.prefab", typeof(GameObject)));
        Spring01 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Spring01.prefab", typeof(GameObject)));
        Tube = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Tube.prefab", typeof(GameObject)));
        Stick01 = ((GameObject)AssetDatabase.LoadAssetAtPath("Assets/Resources/" + "Stick01.prefab", typeof(GameObject)));

        for (int i = 0; i < Arbre01Blocs.Length; i++)
        {
            GameObject Instance;
            Instance =PrefabUtility.InstantiatePrefab(Arbre01) as GameObject;
            Instance.transform.position = Arbre01Blocs[i].transform.position;
            Instance.transform.rotation = Arbre01Blocs[i].transform.rotation;
        }
        */
    }

}


