using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static int randomNum;
    public static int x;
    public static int y;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

    }
    //
    public static void CreateBoard(){
    }
    public static void ReloadBoard(){

    }



    public static void Movement(){
        //when press W
        if (Input.GetKeyDown(KeyCode.W)){
            TextController.array[x,y]=TextController.numSize[randomNum];
        }
        //when press S
        if (Input.GetKeyDown(KeyCode.S)){

        }
        //when press A
        if (Input.GetKeyDown(KeyCode.A)){
            
        }
        //when press D
        if (Input.GetKeyDown(KeyCode.D)){
        }
    }
    public static void GetRandomNum(){
        foreach (int i in TextController.array)
        {
            if(i>=8){
                randomNum =Random.Range(0,3);
            }
            else if(i>=16){
                randomNum=Random.Range(1,4);
            }
            else if(i>=64){
                randomNum=Random.Range(2,5);
            }
            else if(i>=256){
                randomNum=Random.Range(4,7);
            }
            else if(i>=1024){
                randomNum=Random.Range(8,11);
            }
        }
    }
    
}
