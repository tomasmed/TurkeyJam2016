using UnityEngine;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;

public class MovementController : MonoBehaviour {
    public Rigidbody rb;
    public Transform trans;
    public float speed;
    Vector3 vel;

    public List<GameObject> BombBelt;

    public static MovementController S;

    void Awake() { S = this; }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        vel = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < BombBelt.Count; i++)
            {
                BombBelt[i].GetComponent<Pusher>().active = true;
                BombBelt[i].GetComponent<Renderer>().material = BombBelt[i].GetComponent<Pusher>().vola;
            }
            BombBelt = new List<GameObject>();
        }

        if (Input.GetKeyDown(KeyCode.W)){
            if (!Physics.Raycast(trans.position, Vector3.right, 1,1,QueryTriggerInteraction.Ignore))
            {
                transform.DOMove(new Vector3(trans.position.x + 1, trans.position.y, trans.position.z), 0.01f);
            }
        }
        if (Input.GetKeyDown(KeyCode.S)){
            if (!Physics.Raycast(trans.position, Vector3.left, 1,1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                transform.DOMove(vel, 0.01f);
            }
        }
        if (Input.GetKeyDown(KeyCode.A)){
            if (!Physics.Raycast(trans.position, Vector3.forward, 1,1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                transform.DOMove(vel, 0.01f);
            }
        }
        if (Input.GetKeyDown(KeyCode.D)){
            if (!Physics.Raycast(trans.position, Vector3.back, 1,1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                transform.DOMove(vel, 0.01f);
            }
        }
    }
}
