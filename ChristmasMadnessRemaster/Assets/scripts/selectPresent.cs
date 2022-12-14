using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class selectPresent : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
    public Camera playerCamera;
    public Animation slideAnimation;
    public TMP_Text scoreBar;
    private int score = 0;


    void Start()
    {
        scoreBar.text = "SCORE: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        changeMaterial changeM;
        RaycastHit rCast;
        if (Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out rCast, range) && rCast.transform.tag == "presents")
            {
                changeMaterial ch = rCast.collider.GetComponent<changeMaterial>();
                changeM = ch;
                if (ch != null)
                {
                    Debug.Log("got materail");
                    ch.materialChange("new");
                }
                // Debug.Log("hit " + rCast.transform.name);
                score += 1;
                scoreBar.text = "SCORE: " + score;
                Debug.Log("score is: " + score);
            }

            slideAnimation.Play();
            

        }

        
    }
}
