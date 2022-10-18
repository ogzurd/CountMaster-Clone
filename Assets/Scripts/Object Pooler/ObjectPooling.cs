using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{   
    public static ObjectPooling instance;

    [SerializeField]
 
        private Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    

    private void Awake() {
        
        if(instance == null){
            instance = this;
        }

            pooledObjects = new Queue<GameObject>();

            for (int j = 0; j < poolSize; j++)
            {
                GameObject obj = Instantiate(objectPrefab);
                obj.SetActive(false);
                pooledObjects.Enqueue(obj);
            }
        

    }

    

    public GameObject GetPooledObject() {

        GameObject obj = pooledObjects.Dequeue();
        obj.SetActive(true);
        pooledObjects.Enqueue(obj);
        return obj;
    }






}
