using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigid = null;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

}
