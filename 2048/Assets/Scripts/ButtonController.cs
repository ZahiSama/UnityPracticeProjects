using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public static bool isGame = false;
    private static Button button;
    public static Text text;

    public bool S;
    // Start is called before the first frame update
    void Start()
    {
        S = isGame;
        button = GetComponent<Button>();
        text = this.GetComponentInChildren<Text>();
        text.text = "Start";
        button.onClick.AddListener(StartOrStopGame);
    }
    //判断游戏是否开始
    public static void StartOrStopGame()
    {
        if (isGame==false)
        {
            GameController.CreateBoard();
        }
        else
        {
            GameController.ReloadBoard();
        }

    }
}
