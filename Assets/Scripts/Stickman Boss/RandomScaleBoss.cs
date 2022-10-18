using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomScaleBoss : MonoBehaviour
{

    public int randomNumber; 

    private void Start() {
        randomNumber = Random.Range(5, 20);
        transform.localScale = new Vector3(randomNumber,randomNumber,randomNumber);

    }
}
