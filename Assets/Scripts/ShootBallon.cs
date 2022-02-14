using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBallon : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;

    public void Shoot() {

        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit )) {

            if (hit.transform.name == "ballon1(Clone)" ||hit.transform.name == "ballon2(Clone)" || hit.transform.name == "ballon3(Clone)") {

               Destroy(hit.transform.gameObject);

               Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal)); 
            }
        }
    }
}
