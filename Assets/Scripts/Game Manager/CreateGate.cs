using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGate : MonoBehaviour
{
    // x: -6 veua 6 
    // z: 45 ile 700 arası bir değer
    // 10 tane üretelim  

    public GameObject gatePrefab; 
    [HideInInspector]
    public GameObject newGate;
    private Vector3 _direction;
    [SerializeField]  int gateCount = 5;

    int randomX;
    int randomZ;

    public void CreateGates() {

        for (int i = 0; i <= gateCount; i++)
        {
            RandomizePosition();
            newGate = Instantiate(gatePrefab, _direction, Quaternion.identity);
        }
    }


    private void RandomizePosition() {
    
        int randomBinary = Random.Range(0, 2);

        if (randomBinary == 0) {
            randomX = -6;
        }
        else {
            randomX = 6;
        }
        
        randomZ = Random.Range(150, 600);

        _direction = new Vector3(randomX, 1, randomZ);

    }

}
