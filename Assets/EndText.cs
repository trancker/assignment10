using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndText : MonoBehaviour
{
    public GameObject BoxCollider;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

        // start text off as completely transparent black
        text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(BoxCollider.GetComponent<EndGame>().hit == true)
        {
            text.color = new Color(1, 0, 0, 1);

            if (Input.GetButtonDown("Jump"))
            {
                // reload entire scene, starting music over again, refreshing score, etc.
                SceneManager.LoadScene("Level");
            }
        }
    }
}
