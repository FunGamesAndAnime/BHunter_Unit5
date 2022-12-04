using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dificalyButton : MonoBehaviour
{
    private Button button;
    public int difficulty;
    private gameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        GameManager = GameObject.Find("Gamemanager").GetComponent<gameManager>();
    }

    // Update is called once per frame
    void setDifficulty()
    {
        Debug.Log(gameObject.name + "Was click");
        GameManager.SartGame(difficulty);
    }
}
