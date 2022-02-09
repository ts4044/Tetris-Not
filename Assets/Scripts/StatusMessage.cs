using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusMessage : MonoBehaviour
{
    public GameObject board;
    public GameObject msg;
    public GameObject ghost;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            board.SetActive(true);
            ghost.SetActive(true);
            msg.SetActive(false);
        }
    }
}
