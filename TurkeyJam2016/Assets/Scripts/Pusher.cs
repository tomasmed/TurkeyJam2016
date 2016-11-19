using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Pusher : MonoBehaviour {
    Vector3 vel = Vector3.zero;
    public bool active = false;
    public float lifetime = 5f;
    public float intensity = 3f;

    public int bombdirection = 0;

    public Material vola;
    public Material dorm;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (active)
        {
            lifetime -= Time.deltaTime;
            if (lifetime < 1) Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (active)
        {
            if (coll.gameObject.tag == "Player")
            {
                switch (bombdirection)
                {
                    case 0:
                        vel = new Vector3(coll.transform.position.x + intensity, coll.transform.position.y, coll.transform.position.z);
                        coll.transform.DOMove(vel, 0.1f);
                        break;
                    case 1:
                        vel = new Vector3(coll.transform.position.x, coll.transform.position.y, coll.transform.position.z + intensity);
                        coll.transform.DOMove(vel, 0.1f);
                        break;
                    case 2:
                        vel = new Vector3(coll.transform.position.x - intensity, coll.transform.position.y, coll.transform.position.z);
                        coll.transform.DOMove(vel, 0.1f);
                        break;
                    case 3:
                        vel = new Vector3(coll.transform.position.x , coll.transform.position.y, coll.transform.position.z - intensity);
                        coll.transform.DOMove(vel, 0.1f);
                        break;
                }
                
            }
        }
    }
}
