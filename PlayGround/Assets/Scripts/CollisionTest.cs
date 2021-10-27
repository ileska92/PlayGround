using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            print("Hit the Floor");
        }

        if(collision.gameObject.name == "Wall")
        {
            print("Dance Wall");
        }
    }
}
