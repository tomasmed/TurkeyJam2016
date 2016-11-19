using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Controller : MonoBehaviour {



    public float timesofar = 0f;
    public int bombsthisround = 10;
    public Text bombtimer;
    public float bombrefreshtime = 19;

    public static Controller S;

    void Awake()
    {
        S = this;
    }


	// Use this for initialization
	void Start () {
        bombtimer.text = "Time Until Bombs: " + (bombrefreshtime-timesofar);
	
	}
	
	// Update is called once per frame
	void Update () {
        timesofar += Time.deltaTime;
        bombtimer.text = "Time Until Bombs: " + (bombrefreshtime - timesofar);



    }
}
