using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    private Animation anim;
    private AnimationClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("brush_down_L_O");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play("brush_down_L");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play("brush_down_L_I");
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            anim.Play("brush_down_F_I");
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            anim.Play("brush_down_F_O");
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            anim.Play("brush_down_R_I");
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            anim.Play("brush_down_R");
        }else if (Input.GetKeyDown(KeyCode.K))
        {
            anim.Play("brush_down_R_O");
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.Play("brush_up_L_O");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("brush_up_L");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("brush_up_L_I");
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            anim.Play("brush_up_F_I");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            anim.Play("brush_up_F_O");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            anim.Play("brush_up_R_I");
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            anim.Play("brush_up_R");
        }else if (Input.GetKeyDown(KeyCode.I))
        {
            anim.Play("brush_up_R_O");
        }
    }
}
