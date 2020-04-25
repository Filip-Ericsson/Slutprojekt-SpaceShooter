using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


//detta script skriver ut ett medelvärde som skrivs som motsvarar hur hör fps spelet har
public class FpsCounter : MonoBehaviour
{
    Queue<float> fpsQueue = new Queue<float>();

    public Text displayText;
    float fpsToDisplay = 0;
    int averageFramesRounded = 0;
    float averageFrames = 0;

    void Update()
    {
        fpsToDisplay = (1 / Time.deltaTime); //värden som läggs i fpsQueue

        fpsQueue.Enqueue(fpsToDisplay);

        if (fpsQueue.Count > 5)
        {
            fpsQueue.Dequeue();
        }

        averageFrames = fpsQueue.Sum() / fpsQueue.Count; //summan av frames divideras med antalet värden som finns i fpsQueuen

        averageFramesRounded = (int)Math.Round(averageFrames, 0); //här avrundas medelvärdet till ett heltal som trunkeras, för tydlighets skull 

        displayText.text = averageFramesRounded + " fps"; //printar värdet av det trunkerade medelvärdet i ett text element
    }
}
