using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerationBlocs : MonoBehaviour {

    //FAIRE UN SYSTEM PLUS SOUPLE BASE SUR LA ROTATION 
    //FAIRE UN SCRIPT POUR RECUPERER END ET START SUR L'OBJET

    //Récupère l'asset "Test_BlocLD".
    public GameObject blocLDTest;       
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
        float _height = blocLDTest.transform.GetChild(0).GetComponent<Renderer>().bounds.size.z;

        //Compteur
        int _heightNb = 0;

        //Blocks instantiate compteur;
        int _blocNb = 0;

        //WaitForSeconds time
        float _time = 2f;

        while (true)
        {
            //Instantiate a bloc 
            GameObject bloc = Instantiate(blocLDTest, new Vector3(0, _height * _heightNb, 0), Quaternion.Euler(90, 0, 0)) as GameObject;

            //name the block
            bloc.name = "bloc_" + _blocNb;

            //Get the previous block, get the end of this previous block, get its position
            if(myListGlobal.Count - 1>0)
            {
                GameObject _lastObject = myListGlobal[myListGlobal.Count - 1];
                GameObject _lastObjectChild = _lastObject.transform.GetChild(2).gameObject;
                Debug.Log(_lastObject.transform.GetChild(1).name);
                Vector3 _heightEnd = _lastObjectChild.transform.position; //local?

                //Get the distance between the previous "end" and the actual "start"

                float _heightDifference = Vector3.Distance(blocLDTest.transform.GetChild(1).transform.position, _lastObjectChild.transform.position);


                //set the position of the actual bloc 
                bloc.transform.position = new Vector3(transform.position.x, transform.position.y - _heightDifference, transform.position.z) * -1;
            }
           


            myListGlobal.Add(bloc);

            //Next bloc
            _blocNb++;
            _heightNb++; 
            yield return new WaitForSeconds(_time);
        }
    }
	
}