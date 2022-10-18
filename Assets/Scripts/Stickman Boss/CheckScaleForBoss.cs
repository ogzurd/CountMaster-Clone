using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScaleForBoss : MonoBehaviour
{

    public PlayerManager playerManager;  //get scale of stickmans function
    private RandomScaleBoss randomScaleBoss; //get randomNumber for boss scale
    public Animator animator;
    private void Start() {
        randomScaleBoss = GameObject.FindObjectOfType<RandomScaleBoss>();
    }

    private void LateUpdate() {
        AddAllScaleOfStickmans();
    }

    void AddAllScaleOfStickmans() {
        
        if (transform.position.z > 600) {
            
            transform.localScale = playerManager.GetTotalScaleOfStickmans();

            if (Vector3.Magnitude(transform.localScale) > 36) 
            {transform.localScale = new Vector3(12f, 12f, 12f);}
            if (Vector3.Magnitude(transform.localScale) <= 0) 
            {transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);}

            for (int i = 2; i < gameObject.transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                } 
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Finish Line")) {
            Debug.Log("Bastı!");

            if (Vector3.Magnitude(transform.localScale) > randomScaleBoss.randomNumber * 3) {
                animator.SetBool("isKick", true);
            }
            

        }
    }





}
