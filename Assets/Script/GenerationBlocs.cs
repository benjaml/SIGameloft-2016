using UnityEngine;
using System.Collections;

public class GenerationBlocs : MonoBehaviour {

    public GameObject blocLDTest;       //Récupère l'asset "Test_BlocLD".

	void Start () {

        StartCoroutine(spawnBlocs());
	}      

    IEnumerator spawnBlocs()
    {
        Debug.Log("dans la coroutine");
        float _height = blocLDTest.GetComponent<Renderer>().bounds.size.y;
        int _heightNb = 1;
        int _blocNb = 1;
        float _time = 3f;

        while (true)
        {
            Debug.Log("dans le while");
            GameObject bloc = Instantiate(blocLDTest, new Vector3(0,_height * _heightNb, 0), Quaternion.Euler(90, 0, 0)) as GameObject;
            bloc.name = "bloc_" + _blocNb;
            _heightNb++;
            yield return new WaitForSeconds(_time);
        }
    }
	
}