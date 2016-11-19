using UnityEngine;
using System.Collections;

public class BombManager : MonoBehaviour {

    public GameObject pusherN;
    public GameObject pusherS;
    public GameObject pusherW;
    public GameObject pusherE;

    private GameObject temp;
    Vector3 objectivepos = Vector3.zero;
	// Use this for initialization
	void Start () {
	
	}
	


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        {
            objectivepos = this.gameObject.transform.position + Vector3.back * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject) GameObject.Instantiate(pusherN, objectivepos , transform.rotation);
            MovementController.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            objectivepos = this.gameObject.transform.position + Vector3.back * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherS, objectivepos, transform.rotation);
            MovementController.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            objectivepos = this.gameObject.transform.position + Vector3.back * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherW, objectivepos, transform.rotation);
            MovementController.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            objectivepos = this.gameObject.transform.position + Vector3.back * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherE, objectivepos, transform.rotation);
            MovementController.S.BombBelt.Add(temp);
        }
    }
}
