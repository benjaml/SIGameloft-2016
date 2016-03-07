using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerationBlocs : MonoBehaviour {

    //FAIRE UN SYSTEM PLUS SOUPLE BASE SUR LA ROTATION 
    //FAIRE UN SCRIPT POUR RECUPERER END ET START SUR L'OBJET

    //Récupère l'asset "Test_BlocLD".
    public GameObject blocLD;       
    //List of previous level design blocs
    public List<GameObject> myListGlobal = new List<GameObject>(1);

    void Start ()
    {
        StartCoroutine(spawnBlocs());
	}      

    //This coroutine 
    IEnumerator spawnBlocs()
    {
        //The height of a bloc
        float _height = blocLD.transform.GetChild(0).GetComponent<Renderer>().bounds.size.z;
        Debug.Log(_height);

        //Compteur
        int _heightNb = 0;

        //Blocks instantiate compteur;
        int _blocNb = 0;

        //WaitForSeconds time
        float _time = 5f;

        while (true)
        {
            //Instantiate a bloc 
            GameObject bloc = Instantiate(blocLD, new Vector3(blocLD.transform.position.x, blocLD.transform.position.y + _height * _heightNb, blocLD.transform.position.z), Quaternion.Euler(blocLD.transform.eulerAngles.x, blocLD.transform.eulerAngles.y, blocLD.transform.eulerAngles.z)) as GameObject;

            //name the block
            bloc.name = "bloc_" + _blocNb;

        //Get the previous block, get the end of this previous block, get its position
        if (myListGlobal.Count - 1 >= 0)
        {
            GameObject _lastObject = myListGlobal[myListGlobal.Count - 1];
            GameObject _lastObjectChild = _lastObject.transform.GetComponent<StartEndManager>().End.gameObject;
            Vector3 _heightEnd = _lastObjectChild.transform.position;
            Debug.Log(_heightEnd);

            //Get the distance between the previous "end" and the actual "start"

            float _heightDifference = Vector3.Distance(blocLD.transform.GetComponent<StartEndManager>().Start.transform.position, _heightEnd);
            Debug.Log(_heightDifference);


            //set the position of the actual bloc 
            bloc.transform.position = new Vector3(blocLD.transform.position.x, blocLD.transform.position.y + _heightDifference, blocLD.transform.position.z);
        }

        myListGlobal.Add(bloc);

        //Next bloc
        _blocNb++;
        _heightNb++;
        yield return new WaitForSeconds(_time);
        }
    }
	
}