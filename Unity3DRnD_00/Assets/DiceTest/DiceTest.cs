using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTest : MonoBehaviour
{
    
    public void OnClickShufleDice()
    { 
        int rand = Random.Range(1, 7);
        Debug.Log(rand);
    }
}
