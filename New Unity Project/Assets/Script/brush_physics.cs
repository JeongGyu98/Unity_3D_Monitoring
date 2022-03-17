using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brush_physics : MonoBehaviour
{

    // Start is called before the first frame update

    private RaycastHit hitInfo;
    private LayerMask layerMask;
    private Color initialColor;
    private Color targetColor;
    private Material hitObjectMaterial;
    Renderer capsuleColor;
    void Start()
    {
        capsuleColor = gameObject.GetComponent<MeshRenderer>();
        targetColor = new Color(1.0f ,1.0f ,1.0f ,1.0f);
    }


    // Update is called once per frame
    void Update()
    {

        if(Physics.Raycast(transform.position,  transform.forward, out hitInfo, 0.2f))
        {
             Debug.DrawRay(transform.position, transform.forward * hitInfo.distance, Color.red);
            

            initialColor = hitInfo.collider.GetComponent<MeshRenderer>().material.color;
            Debug.Log(initialColor);
           
            if(initialColor.r <= 1.0f) {
                initialColor.r += 0.005f;
            } 
            if (initialColor.g <= 1.0f){
                initialColor.g += 0.005f;
            }
            if(initialColor.b<= 1.0f){
                initialColor.b += 0.005f;
            }

            hitInfo.transform.GetComponent<MeshRenderer>().material.color = initialColor;
            //timeLeft = 1.0f;
            // hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.Lerp(initialColor, 
            //                                                                                 targetColor, Mathf.PingPong(Time.time, 1));
            //timeLeft -= Time.deltaTime;                                                                            
            //objectName = hitInfo.collider.name;

            //Debug.Log(capsuleColor.material.GetColor("_Color"));
            //Debug.Log("hit point: " + hitInfo.collider.name);

            //hitInfo.transform.GetComponent<MeshRenderer>().material.color = new Color(color_R / 255, color_G / 255, color_B / 255);
            //GameObject.Find(objectName).GetComponent<MeshRenderer>().material.color = new Color(GameObject.Find(objectName).GetComponent<MeshRenderer>().material.color.r + updateColor, color_G / 255, color_B / 255);

        }
        else
        {    
            Debug.DrawRay(transform.position, transform.forward * 0.2f, Color.red);
            capsuleColor.material.color = Color.white;
        }
    }
}
