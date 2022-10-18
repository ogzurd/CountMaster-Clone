using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform stickman;
    private Vector3 _offset;

    private void Start() {
        _offset = transform.position - stickman.transform.position;
    }
    private void Update() {

        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, _offset.z + stickman.position.z);
        transform.position = newPosition;
    }
}
