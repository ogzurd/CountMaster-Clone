using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using DG.Tweening;
public class PlayerManager : MonoBehaviour
{
    private int numberOfStickman;
    [SerializeField] private TextMeshProUGUI numOfStickmanText;
    [SerializeField] private SkinnedMeshRenderer meshRenderer;

    private List<GameObject> newStickmanList = new List<GameObject>();
    private Transform player;
    [Range(0f, 1f)] [SerializeField] private float distanceFactor, _radius;
    private RandomNumber randomNumber;
    int totalScale;

    public static PlayerManager instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }
    private void Start() {

        player = transform;
        numberOfStickman = transform.childCount - 1;
        numOfStickmanText.text = numberOfStickman.ToString();


    }

    private void MakeStickman(int number) {

        
        for (int i = 0; i < number; i++)
        {   
            
            GameObject newStickman = ObjectPooling.instance.GetPooledObject();
            newStickman.gameObject.transform.GetChild(1).gameObject.GetComponent<SkinnedMeshRenderer>().material = meshRenderer.material;
            newStickman.gameObject.transform.SetParent(player);
            
            newStickmanList.Add(newStickman);
        
        
        }
        numberOfStickman = transform.childCount - 1;
        numOfStickmanText.text = numberOfStickman.ToString();
        FormatStickman();
    }



        private void OnTriggerEnter(Collider other) {

        MeshRenderer collidedMeshRenderer = other.gameObject.GetComponent<MeshRenderer>();
        
        if (collidedMeshRenderer.material.color == meshRenderer.material.color) {

            randomNumber = other.gameObject.GetComponent<RandomNumber>();

            if (randomNumber.isMultiply) {
                MakeStickman(numberOfStickman * randomNumber._number);
            }
            else {
                MakeStickman(numberOfStickman + randomNumber._number);
            }
        }
        else {
            meshRenderer.material.color = collidedMeshRenderer.material.color;
        }
    }
    
    public Vector3  GetTotalScaleOfStickmans(){
        
        float total = 0;
        foreach (GameObject stickman in newStickmanList)
        {
            total += stickman.transform.localScale.x;
        }
        Vector3 totalScale = new Vector3(total, total, total) / 10;
        return totalScale;
        
    }



    private void FormatStickman() {

        for (int i = 1; i < player.childCount; i++)
        {
            float x = distanceFactor * Mathf.Sqrt(i) * Mathf.Cos(i * _radius);
            float z = distanceFactor * Mathf.Sqrt(i) * Mathf.Sin(i * _radius);

            Vector3 newPosition = new Vector3(x, -0.55f, z);

            player.GetChild(i).DOLocalMove(newPosition, 1f).SetEase(Ease.OutBack);
        }
    }

}
