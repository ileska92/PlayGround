using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstansiateExample : MonoBehaviour
{
    public GameObject mySphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(mySphere, transform.position, transform.rotation);
    }
}
