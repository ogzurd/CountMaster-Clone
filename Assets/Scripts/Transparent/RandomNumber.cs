using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class RandomNumber : MonoBehaviour
{


    // toplama(+) , çarpma (-) veya çıkarma(-) rastgele bir biçimde olacak. 
    // toplama veya çıkarma 10 ile 30 arası rastgele (+10, -15, ..)
    // çarpma (x1, x2, x3)
    
    public TextMeshPro numberText;
    public int _number;
    public bool isMultiply; //randomly
    

    private void Start() {
        GetRandomNumber();
    }


    private void GetRandomNumber() { 

        RandomMultiplyStatus();

        if (isMultiply) {
            _number = Random.Range(2, 4);
            numberText.text = "x" + _number;
        }
        else {

            _number = Random.Range(5, 21);
            if (_number % 2 != 0){
                _number += 1;
            }

            numberText.text = "+" + _number;  
        }


    }



    void RandomMultiplyStatus() {
        int multiplyNum = Random.Range(0, 2);
        if (multiplyNum == 0){
            isMultiply = true;
        }
        else {isMultiply = false;}
    }

}
