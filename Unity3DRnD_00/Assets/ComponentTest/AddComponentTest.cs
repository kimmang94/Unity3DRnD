using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponentTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody> ();
    }

}
