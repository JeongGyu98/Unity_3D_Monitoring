using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : MonoBehaviour
{
    private Animation anim;
    private Text textPlaying, textResult;
    private AnimationClip clip;
    private int count = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        textPlaying = GameObject.Find("TextPlaying").GetComponent<Text>();
        textResult = GameObject.Find("TextResult").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnimation(int K){

        int number = 0;
        number = K;

        if(count == 1){
            textResult.text = "양치 중..";
        }
        else if(count > 20){
            textResult.text = "양치 끝";
        }

        switch(number){
            case 1: 
                anim.Play("brush_down_L_O");
                textPlaying.text = "왼쪽 아래 바깥면 " + count;
                break;
            case 2:
                anim.Play("brush_down_L");
                textPlaying.text = "왼쪽 아래 씹는면 " + count;
                break;
            case 3:
                anim.Play("brush_down_L_I");
                textPlaying.text = "왼쪽 아래 안쪽면 " + count;
                break;
            case 4:
                anim.Play("brush_down_F_I");
                textPlaying.text = "앞쪽 아래 안쪽면 " + count;
                break;
            case 5:
                anim.Play("brush_down_F_O");
                textPlaying.text = "앞쪽 아래 바깥쪽 " + count;
                break;
            case 6:
                anim.Play("brush_down_R_I");
                textPlaying.text = "오른쪽 아래 안쪽면 " + count;
                break;
            case 7:
                anim.Play("brush_down_R");
                textPlaying.text = "오른쪽 아래 씹는면 " + count;
                break;  
            case 8:
                anim.Play("brush_down_R_O");
                textPlaying.text = "오른쪽 아래 바깥면 " + count;
                break;    
            case 9:
                anim.Play("brush_up_R_O");
                textPlaying.text = "오른쪽 위 바깥면 " + count;
                break;
            case 10:
                anim.Play("brush_up_R");
                textPlaying.text = "오른쪽 위 씹는면 " + count;
                break;
            case 11:
                anim.Play("brush_up_R_I");
                textPlaying.text = "오른쪽 위 안쪽면 " + count;
                break;
            case 12:
                anim.Play("brush_up_F_I");
                textPlaying.text = "앞쪽 위 안쪽면 " + count;
                break;
            case 13:
                anim.Play("brush_up_F_O");
                textPlaying.text = "앞쪽 위 바깥면 " + count;
                break;    
            case 14:
                anim.Play("brush_up_L_I");
                textPlaying.text = "왼쪽 위 안쪽면 " + count;
                break;
            case 15:
                anim.Play("brush_up_L");
                textPlaying.text = "왼쪽 위 씹는면 " + count;
                break;    
            case 16:
                anim.Play("brush_up_L_O");
                textPlaying.text = "왼쪽 위 바깥면" + count;
                break;    
            default : 
                Debug.Log("default case");
                break;
        }
        
        count ++; 
    }   
}
