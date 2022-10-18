using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScaleToPlayAnim : MonoBehaviour
{

    [SerializeField] private GameObject _stickman;
    [SerializeField] private Animator _animator;
    private void  Update() {

        if (_stickman.transform.position.z > 600) {

            if (Vector3.Magnitude(PlayerManager.instance.GetTotalScaleOfStickmans()) > Vector3.Magnitude(transform.localScale)) {
                _animator.SetBool("isKick", true);
            }
        }
    }




}
