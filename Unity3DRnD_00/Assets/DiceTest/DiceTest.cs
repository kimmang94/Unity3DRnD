using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DiceTest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text = null;
    public void OnClickShufleDice()
    { 
        int rand = Random.Range(1, 7);
        text.text = rand.ToString();
    }
}
