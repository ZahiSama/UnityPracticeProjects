using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public GameObject[] textArray = new GameObject[16];
    public static GameObject[] textArrayStatic = new GameObject[16];
    public static int[,] array = new int[4, 4];
    public static int[] numSize = new int[11] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };


    // Start is called before the first frame update
    void Start()
    {
        for (int c = 0; c < 16; c++)
        {
            textArrayStatic[c] = textArray[c];
        }
    }

    private void FixedUpdate()
    {
        textArrayStatic[0].GetComponent<Text>().text = array[0, 0].ToString();
        textArrayStatic[1].GetComponent<Text>().text = array[1, 0].ToString();
        textArrayStatic[2].GetComponent<Text>().text = array[2, 0].ToString();
        textArrayStatic[3].GetComponent<Text>().text = array[3, 0].ToString();
        textArrayStatic[4].GetComponent<Text>().text = array[0, 1].ToString();
        textArrayStatic[5].GetComponent<Text>().text = array[1, 1].ToString();
        textArrayStatic[6].GetComponent<Text>().text = array[2, 1].ToString();
        textArrayStatic[7].GetComponent<Text>().text = array[3, 1].ToString();
        textArrayStatic[8].GetComponent<Text>().text = array[0, 2].ToString();
        textArrayStatic[9].GetComponent<Text>().text = array[1, 2].ToString();
        textArrayStatic[10].GetComponent<Text>().text = array[2, 2].ToString();
        textArrayStatic[11].GetComponent<Text>().text = array[3, 2].ToString();
        textArrayStatic[12].GetComponent<Text>().text = array[0, 3].ToString();
        textArrayStatic[13].GetComponent<Text>().text = array[1, 3].ToString();
        textArrayStatic[14].GetComponent<Text>().text = array[2, 3].ToString();
        textArrayStatic[15].GetComponent<Text>().text = array[3, 3].ToString();
    }
}
