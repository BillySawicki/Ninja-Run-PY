using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockExit : MonoBehaviour
{
    public GameObject door;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("coin")){
            Debug.Log("Yout touched it!");
            Destroy(other.gameObject);
            Destroy(door);
        }
    }
}

