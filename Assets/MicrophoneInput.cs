/* Credit: http://www.kaappine.fi/tutorials/using-microphone-input-in-unity3d/ */
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MicrophoneInput : MonoBehaviour
{
    
    public float sensitivity;
    public float loudness = 0;
        
    void Start()
    {
        GetComponent<AudioSource>().clip = Microphone.Start("Microphone (High Definition Audio Device)", true, 10, 44100);
        GetComponent<AudioSource>().loop = true; // Set the AudioClip to loop
        //GetComponent<AudioSource>().mute = true; // Mute the sound, we don't want the player to hear it
        while (!(Microphone.GetPosition("") > 0))
        {
        } // Wait until the recording has started
        GetComponent<AudioSource>().Play(); // Play the audio source!
        
        foreach (var device in Microphone.devices)
        {

            Debug.Log("Le micro connecté est : "+ device);
        }
    }
        
    void Update()
    {
        loudness = GetAveragedVolume() * sensitivity;
    }
        
    float GetAveragedVolume()
    { 
        float[] data = new float[256];
        float a = 0;
        GetComponent<AudioSource>().GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        return a / 256;
        
    }
}