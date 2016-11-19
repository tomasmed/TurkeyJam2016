using UnityEngine;
using System.Collections;

public class BombManagerP2 : MonoBehaviour
{

    public GameObject pusherN;
    public GameObject pusherS;
    public GameObject pusherW;
    public GameObject pusherE;

    private GameObject temp;
    Vector3 objectivepos = Vector3.zero;
    // Use this for initialization
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            objectivepos = this.gameObject.transform.position + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherN, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            objectivepos = this.gameObject.transform.position + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherS, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            objectivepos = this.gameObject.transform.position + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherW, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            objectivepos = this.gameObject.transform.position + Vector3.forward * 12;
            //GameObject.Instantiate(pusher,  objectivepos, gameObject.transform.rotation ,gameObject.transform);
            temp = (GameObject)GameObject.Instantiate(pusherE, objectivepos, transform.rotation);
            MovementPlayer2.S.BombBelt.Add(temp);
        }
    }
}