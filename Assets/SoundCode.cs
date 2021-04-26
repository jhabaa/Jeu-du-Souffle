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

    private const int SAMPLECOUNT = 1024;   // Sample Count.
    private const float REFVALUE = 0.1f;    // RMS value for 0 dB.
    private const float THRESHOLD = 0.02f;  // Minimum amplitude to extract pitch (recieve anything)
    private const float ALPHA = 0.09f;      // The alpha for the low pass filter (I don't really understand this).

    public int recordedLength;    // How many previous frames of sound are analyzed.
    public int requiedBlowTime;    // How long a blow must last to be classified as a blow (and not a sigh for instance).
    public int clamp;            // Used to clamp dB (I don't really understand this either).

    private float rmsValue;            // Volume in RMS
    private float dbValue;             // Volume in DB
    private float pitchValue;          // Pitch - Hz (is this frequency?)
    private int blowingTime;           // How long each blow has lasted

    private double lowPassResults;      // Low Pass Filter result
    private float peakPowerForChannel; //

    private GameObject[] cubes; // This is cubes array to show spectrum
    public float SpectrumRefreshTime; // refresh rate to show cubes
    private float lastUpdate = 0;
    public float scaleFactor = 10000;
    private float[] samples;           // Samples
    private float[] spectrum = new float[1024];          // Spectrum
    private List<float> dbValues;      // Used to average recent volume.
    private List<float> pitchValues;   // Used to average recent pitch.

    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!source.isPlaying)
        {
            StartMicListener();
        }
        SoundAnalyse();
    }

    private void StartMicListener() /// Starts the Mic, and plays the audio back in (near) real-time.
    {
        source.clip = Microphone.Start(Microphone.devices[0], true, 10, AudioSettings.outputSampleRate);
        // HACK - Forces the function to wait until the microphone has started, before moving onto the play function.
        while (!(Microphone.GetPosition(Microphone.devices[0]) > 0))
        {
        }
        source.loop = true;
        source.Play();
        
    }
    private void SoundAnalyse()
    {
        if (source.time >= 2f && source.time < 4f)
        {
            float[] curSpectrum = new float[1024];
            source.GetSpectrumData(curSpectrum, 0, FFTWindow.BlackmanHarris);

            float targetFrequency = 234f;
            float hertzPerBin = (float)AudioSettings.outputSampleRate / 2f / 1024;
            int targetIndex = (int)(targetFrequency / hertzPerBin);

            string outString = "";
            for (int i = targetIndex - 3; i <= targetIndex + 3; i++)
            {
                outString += string.Format("| Bin {0} : {1}Hz : {2} |   ", i, i * hertzPerBin, curSpectrum[i]);
            }

            Debug.Log(outString);
        }
        else
            Debug.Log("Pas de son");
    }


}
