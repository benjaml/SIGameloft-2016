using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerationBlocs : MonoBehaviour {

    public GameObject blocLDTest;       //Récupère l'asset "Test_BlocLD".
    public List<GameObject> myListGlobal = new List<GameObject>(1);

    void Start () {

        StartCoroutine(spawnBlocs());
	}      

    IEnumerator spawnBlocs()
    {
        Debug.Log("dans la coroutine");
        float _height = blocLDTest.transform.GetChild(0).GetComponent<Renderer>().bounds.size.z;
        int _heightNb = 0;
        Vector3 _heightDifference;
        int _blocNb = 1;
        float _time = 2f;

        while (true)
        {
            Debug.Log("dans le while");
            GameObject bloc = Instantiate(blocLDTest, new Vector3(0, _height * _heightNb, 0), Quaternion.Euler(90, 0, 0)) as GameObject;
            bloc.name = "bloc_" + _blocNb;
            myListGlobal.Add(bloc);
            _heightDifference = myListGlobal[myListGlobal.Count-1].transform.Find("End").transform.position;
            bloc.transform.position = new Vector3(transform.position.x, Vector3.Distance(transform.position, _heightDifference) , transform.position.z);

            _blocNb++;
            _heightNb++;
            yield return new WaitForSeconds(_time);
        }
    }
	
}