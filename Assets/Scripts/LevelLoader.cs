using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  


public class LevelLoader : MonoBehaviour {

    public int levelToload;
	private void OnTriggerEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Candy")
        {
            SceneManager.LoadScene(levelToload);
        }
    }
}
