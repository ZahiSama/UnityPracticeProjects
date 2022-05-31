using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public static bool isGame;
    private static Button button;
    private static Text text;
    private void Awake() {
        isGame=false;
    }
    // Start is called before the first frame update
    void Start(){
        button =GetComponent<Button>();
        text =this.GetComponentInChildren<Text>();
        text.text ="Start";
    }

    // Update is called once per frame
    void Update(){
        IsGameStart();
    }
    public static void IsGameStart(){
        if (isGame == false){
            button.onClick.AddListener(StartGame);
        }
        if(isGame == true){
            button.onClick.AddListener(StopGame);
        }
    }
    public static void StartGame(){
        isGame = true;
        text.text ="Stop";
    }
    public static void StopGame(){
        isGame = false;
        text.text ="Start";
    }
}
