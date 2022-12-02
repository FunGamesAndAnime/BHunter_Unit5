using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class targit : MonoBehaviour
{
    private const float minforce = 10;
    private const float maxforce = 15;
    private const float maxTorque = 10;
    private const float minTorque = -10;
    private const float minXpos = -3;
    private const float maxXpos = 3;
    private const float yspawnpos = 2;
    private Rigidbody targetRB;
    private gameManager gameManager;
    public int pointvalue;
    public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();

        gameManager = GameObject.Find("Gamemanager").GetComponent<gameManager>();
        Randomforce();
        RandomTorgue();
        RandomSpawnPos();

    }
    void Randomforce()
    {
        targetRB.AddForce(Vector3.up * Random.Range(minforce, maxforce), ForceMode.Impulse);

    }
    void RandomTorgue()
    {
        targetRB.AddTorque(Random.Range(minTorque, maxTorque), Random.Range(minTorque, maxTorque), Random.Range(minTorque, maxTorque), ForceMode.Impulse);

    }
    void RandomSpawnPos()
    {
        transform.position = new Vector3(Random.Range(minXpos, maxXpos), yspawnpos);
    }

    private void OnMouseDown()
    {
        if (gameManager.gameact)
        {


            gameManager.Updatescore(pointvalue);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        Destroy(gameObject);
        if (!gameObject.CompareTag("hazord"))
        {
            gameManager.gameover();
        }
    }
}
   
