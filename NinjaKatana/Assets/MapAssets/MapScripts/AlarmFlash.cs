using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmFlash : MonoBehaviour
{
    private new Light light;
    private new Renderer renderer;

    public bool isFlashing = false;
    public float timeDelay;

    // Start is called before the first frame update
    void Start()
    {
        //Get the AlarmLight child from its parent and name it as alarmLight
        Transform alarmLight = transform.Find("AlarmLight");
        //Get Light component from alarmLight and anme it as light
        light = alarmLight.GetComponent<Light>();

        //Get renderer so we can change the object's color
        renderer = alarmLight.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isFlashing == false)
        {
            StartCoroutine(FlashingLight());
        }
    }

    IEnumerator FlashingLight()
    {
        isFlashing = true;
        light.intensity = 0;
        renderer.material.color = Color.white;
        timeDelay = 1f;
        yield return new WaitForSeconds(timeDelay);
        light.intensity = 5;
        renderer.material.color = Color.red;
        timeDelay = 1f;
        yield return new WaitForSeconds(timeDelay);
        isFlashing = false;
    }
    //slay
}
