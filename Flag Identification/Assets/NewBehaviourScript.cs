using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
        public void EndGame()
    {
        Application.Quit();
        Debug.Log("Game Closed"); 
    }

    // Update is called once per frame   
        public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
