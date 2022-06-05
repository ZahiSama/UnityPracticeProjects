using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static int randomNum;
    public static int x;
    public static int y;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        GetRandomNum();
    }
    //
    public static void CreateBoard()
    {
        ButtonController.isGame = true;
        ButtonController.text.text = "Stop";
        x = Random.Range(0, 4);
        y = Random.Range(0, 4);
        TextController.array[GameController.x, GameController.y] = 2;

    }
    public static void ReloadBoard()
    {
        ButtonController.isGame = false;
        ButtonController.text.text = "Start";
        for (int i = 0; i < 4; i++)
        {
            for (int a = 0; a < 4; a++)
            {
                TextController.array[i, a] = 0;
            }
        }
    }

    public static void Movement()
    {
        if (ButtonController.isGame)
        {
            //when press W
            if (Input.GetKeyDown(KeyCode.W))
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        TextController.array[i,a]
                    }
                }
                GetZeroNum();
            }
            //when press S
            if (Input.GetKeyDown(KeyCode.S))
            {
                GetZeroNum();
            }
            //when press A
            if (Input.GetKeyDown(KeyCode.A))
            {
                GetZeroNum();
            }
            //when press D
            if (Input.GetKeyDown(KeyCode.D))
            {
                GetZeroNum();
            }
        }
    }
    public static void GetRandomNum()
    {
        foreach (int i in TextController.array)
        {
            if (i >= 8)
            {
                randomNum = Random.Range(0, 3);
            }
            else if (i >= 16)
            {
                randomNum = Random.Range(1, 4);
            }
            else if (i >= 64)
            {
                randomNum = Random.Range(2, 5);
            }
            else if (i >= 256)
            {
                randomNum = Random.Range(4, 7);
            }
            else if (i >= 1024)
            {
                randomNum = Random.Range(8, 11);
            }
        }
    }

    private static void GetZeroNum()
    {
        x = Random.Range(0, 4);
        y = Random.Range(0, 4);
        if (TextController.array[x, y] == 0)
        {
            TextController.array[x, y] = TextController.numSize[randomNum];
        }
        else
        {
            GetZeroNum();
        }
    }
}
