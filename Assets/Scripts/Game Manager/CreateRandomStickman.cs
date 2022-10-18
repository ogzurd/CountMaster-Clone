using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomStickman : MonoBehaviour
{
    public GameObject randomStickmanPrefab;
    private Vector3 newStickmanPosition;
    public int numberOfStickman;
    int randomX; 
    int randomZ;


    public void CreateStickmanGroup() 
    {
        int randomNumber = Random.Range(0, 3);
        for (int i = 0; i <= randomNumber; i++)
        {
            CreateStickman();
        }
    }


    private void CreateStickman()
    {
        for (int i = 0; i < numberOfStickman; i++)
        {
            randomX = Random.Range(-8, 8);
            randomZ = Random.Range(130, 500);
            newStickmanPosition = new Vector3(randomX, transform.position.y, randomZ);

            GameObject newStickman = Instantiate(randomStickmanPrefab, newStickmanPosition, Quaternion.identity);

            newStickman.transform.GetChild(1).gameObject.GetComponent<RandomStickmanColor>().RandomizeMaterialColor();
            newStickman.gameObject.GetComponent<Animator>().enabled = false;
        
        }
    }

}
