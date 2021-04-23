using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SoundCode : MonoBehaviour
{
    public AudioSource source;
    float[] clipSampleData = new float[1024];
    bool isSpeaking = false;
    public float minimumLevel;

    // Start is called before the first frame update
    void Start()
    {
        
        source.clip = Microphone.Start(Microphone.devices[0], true, 10, AudioSettings.outputSampleRate);
        source.loop = true;
        while(!(Microphone.GetPosition(null) > 0)) 
        {

        }
        source.Play();

    }

    // Update is called once per frame
    void Update()
    {
        source.GetSpectrumData(clipSampleData, 0, FFTWindow.Rectangular);
        float currentAverageVolume = clipSampleData.Average();
        if (currentAverageVolume > minimumLevel)
        {
            isSpeaking = true;
            Debug.Log("BLowing");
        }
    }
}
