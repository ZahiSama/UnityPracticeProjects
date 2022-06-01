using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public static GameObject[] textArray = new GameObject[16];
    public static int[,] array= new int[4,4];
    public static int[] numSize = new int[11]{2,4,8,16,32,64,128,256,512,1024,2048};


    // Start is called before the first frame update
    void Start(){
        //textArray[0].GetComponent<Text>().text="n";

        for (int i = 0; i < 16; i++)
        {
            for (int num1 = 0; num1 < 5; num1++)
            {
                for (int num2 = 0; num2 < 5; num2++)
                {
                    textArray[i].GetComponent<Text>().text=array[num1,num2].ToString();
                    break;
                }
                break;
            }
        }
    }
    // Update is called once per frame
    void Update(){
        
    }
}
