using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public void Play(int sceneNumber) {
        SceneManager.LoadScene(sceneNumber);
    }

    

}