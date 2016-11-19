using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReloadGame : MonoBehaviour {

    public KeyCode restart;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(restart))
        {
            SceneManager.LoadScene("Scene0", LoadSceneMode.Single);
        }
	}
}
