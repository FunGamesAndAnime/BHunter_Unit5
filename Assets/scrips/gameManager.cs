using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI gameovertext;
    private int score = 0;
    public bool gameact = false;
   
    private float spawnrate = 2.0f;
    public List<GameObject> prefabs;
    public Button restartbutten;
    public GameObject titleScrean;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    public void SartGame(int diff)
    {
        gameact = true;
        score = 0;
        StartCoroutine(spawnTarget());
        Updatescore(0);
        titleScrean.gameObject.SetActive(false);
        spawnrate = spawnrate / diff;

    }
    public void gameover()
    {
        gameact = false;
        gameovertext.gameObject.SetActive(true);
        restartbutten.gameObject.SetActive(true);
    }

    IEnumerator spawnTarget()
    {
        while (gameact)
        {
            yield return new WaitForSeconds(spawnrate);
            Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Updatescore(int scoreDelta)
    {
        score += scoreDelta;
        if(score < 0)
        {
            score = 0;
        }
        scoretext.text = "Score: " + score;
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
