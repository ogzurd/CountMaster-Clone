using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private CreateGate createGate;
    [SerializeField] private CreateRandomStickman createRandomStickman;
    public TextMeshProUGUI tapToPlayText;
    void Start()
    {   
        Time.timeScale = 0.0f;
        createGate.CreateGates();
        createRandomStickman.CreateStickmanGroup();
        
    }


    private void Update() {

        if (Input.anyKey) {
            Time.timeScale = 1;
            tapToPlayText.gameObject.SetActive(false);  
        }
    }
}
