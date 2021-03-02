using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Ball")

        {

            PlayerDies();
        }


    }



    public void PlayerDies()
    {



        UnityEngine.SceneManagement.SceneManager.LoadScene(1);




    }
}
