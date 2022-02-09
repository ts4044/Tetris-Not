using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{

    private float shakeDuration = 0;
    private float shakeAmount = .1f;
    private float decreaseFactor = 1;

    public Camera cam;

    public void shake()
    {
        shakeDuration = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0)
        {
            Vector2 circle = Random.insideUnitCircle * shakeAmount;
            cam.transform.localPosition = new Vector3(circle.x, circle.y, -10);
            shakeDuration -= Time.deltaTime * decreaseFactor;

        }
        else
        {
            shakeDuration = 0;
        }
    }
}
