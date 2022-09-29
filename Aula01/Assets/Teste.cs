using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{

    public GameObject variable1;

    // Start is called before the first frame update
    void Start()
    {

        variable1.GetComponent<Animator>().Play("teste");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
