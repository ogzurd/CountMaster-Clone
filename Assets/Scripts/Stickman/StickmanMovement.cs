using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanMovement : MonoBehaviour
{
    Vector3 _direction;
    Rigidbody _rb;
    float newPositionX;
    private void FixedUpdate() {
        GetBoundsRange();
        Move(); 
    }


    private void Move() { 
        

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){ 
            _direction = Vector3.right * 3f;
            transform.Translate(Vector3.back * 25f * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){ 
            _direction = Vector3.left * 3f;
            transform.Translate(Vector3.back * 25f * Time.fixedDeltaTime);
        }
        else { 
            _direction = Vector3.back * 200f * Time.fixedDeltaTime;
        }
        
        transform.Translate(_direction * Time.fixedDeltaTime * 5f);
    
    } 


    private void GetBoundsRange() { 
        // -6, 6
        newPositionX = Mathf.Clamp(transform.position.x, -6f, 6f);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);

    }



}
