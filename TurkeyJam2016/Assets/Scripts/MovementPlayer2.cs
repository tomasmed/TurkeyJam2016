using UnityEngine;
using System.Collections;
using DG.Tweening;
using System.Collections.Generic;


public class MovementPlayer2 : MonoBehaviour
{
    public Rigidbody rb;
    public Transform trans;
    public float speed;
    Vector3 vel;

    public List<GameObject> BombBelt;
    // Use this for initialization

    public static MovementPlayer2 S;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        vel = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightShift)) {
            for (int i = 0; i < BombBelt.Count; i++)
            {
                BombBelt[i].GetComponent<Pusher>().active = true;
                BombBelt[i].GetComponent<Renderer>().material = BombBelt[i].GetComponent<Pusher>().vola;
            }
            BombBelt = new List<GameObject>();
        }



        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!Physics.Raycast(trans.position, Vector3.right, 1, 1, QueryTriggerInteraction.Ignore))
            {
                transform.DOMove(new Vector3(trans.position.x + 1, trans.position.y, trans.position.z) , 0.1f);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!Physics.Raycast(trans.position, Vector3.left, 1, 1, QueryTriggerInteraction.Ignore))
            {

                vel = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
                transform.DOMove(vel, 0.1f);
                //trans.position = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!Physics.Raycast(trans.position, Vector3.forward, 1, 1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
                transform.DOMove(vel, 0.1f);

                //trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!Physics.Raycast(trans.position, Vector3.back, 1, 1, QueryTriggerInteraction.Ignore))
            {
                vel = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
                transform.DOMove(vel, 0.1f);

                //trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
            }
        }
    }
}
