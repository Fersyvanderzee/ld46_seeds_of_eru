using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    // Floats
    public float countdownTime = 65f;
    public float startTime = 5f;

    // bools
    public bool timer = true;

    // GameObjects
    private GameObject spawner;
    private SpawnMeteor spawn;
    private GameEnd ge;
    private PlayerController pc;
    private Counter ct;

    // Texts
    public Text countdownText;
    public Text TimeLeftIndicator;
    public Text countTillStart;
    public Text StartGameIn;
    public Text seedsCollected;


    void Start()
    {
        spawn = GameObject.FindObjectOfType(typeof(SpawnMeteor)) as SpawnMeteor;
        ge = GameObject.FindObjectOfType(typeof(GameEnd)) as GameEnd;
        pc = GameObject.FindObjectOfType(typeof(PlayerController)) as PlayerController;

        countdownText.text = "";
        TimeLeftIndicator.text = "";
        countTillStart.text = "";
        StartGameIn.text = "";
        seedsCollected.text = "";

        spawn.MeteorShower();

        spawner = GameObject.Find("Spawner");
    }

    void Update()
    {
        seedsCollected.text = "Seeds: " + pc.playerCollect + " / " + pc.minSeeds;
        
        //TimeLeftIndicator.text = "Time till shower ends: " + countdownTime.ToString("0");
        if(timer == true)
        {
            countdownTime -= 1 * Time.deltaTime;
            startTime -= 1 * Time.deltaTime;

            if(startTime > 0)
            {
                countTillStart.text = startTime.ToString("0");
                StartGameIn.text = "Game starts in";
            } else
            {
                countTillStart.text = "";
                StartGameIn.text = "";
            }

            if(countdownTime <= 60)
            {
                countdownText.text = countdownTime.ToString("0");
            }

            if(countdownTime <= 0 && pc.playerCollect != pc.minSeeds)
            {
                ge.GameOver();
            }

        }

        
    }

}
