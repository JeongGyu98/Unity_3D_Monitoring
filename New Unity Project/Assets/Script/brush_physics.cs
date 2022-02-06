using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brush_physics : MonoBehaviour
{

    // Start is called before the first frame update

    private RaycastHit hitInfo;
    private LayerMask layerMask;
    Renderer capsuleColor;

    float color_R = 214.0f;
    float color_G = 182.0f;
    float color_B = 110.0f;
    float updateColor = 0.5f;
    string objectName;

    void Start()
    {
        capsuleColor = gameObject.GetComponent<MeshRenderer>();
    }


    // Update is called once per frame
    void Update()
    {

        if(Physics.Raycast(transform.position,  transform.forward, out hitInfo, 0.2f))
        {
            color_B += updateColor;
            color_G += updateColor;
            color_R += updateColor;
 
            Debug.DrawRay(transform.position, transform.forward * hitInfo.distance, Color.red);

            objectName = hitInfo.collider.name;
            //capsuleColor.material.color = Color.magenta;

            //Debug.Log(capsuleColor.material.GetColor("_Color"));
            Debug.Log("hit point: " + hitInfo.collider.name);

            hitInfo.transform.GetComponent<MeshRenderer>().material.color = new Color(color_R / 255, color_G / 255, color_B / 255);
            //GameObject.Find(objectName).GetComponent<MeshRenderer>().material.color = new Color(GameObject.Find(objectName).GetComponent<MeshRenderer>().material.color.r + updateColor, color_G / 255, color_B / 255);

        }
        else
        {    
            Debug.DrawRay(transform.position, transform.forward * 0.2f, Color.red);
            capsuleColor.material.color = Color.white;
        }
    }
}
