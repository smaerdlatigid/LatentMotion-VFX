using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidInput : MonoBehaviour
{
    public float freq1 = 0.1f;
    public float freq2 = 0.15f;
    public float amp1 = 1f;
    public float amp2 = 2f;

    public LoopbackAudio Audio;

    public float AudioAverageTime;
    public float AudioSubTime;


    // Start is called before the first frame update
    void Start()
    {
        AudioAverageTime = 0f;
        AudioSubTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        AudioAverageTime += Audio.WeightedAverage;
        AudioSubTime += Audio.WeightedPostScaledSpectrumData[0];

        GetComponent<AnimationDecoder>().inputs = new float[] { 
            amp1*Mathf.Sin(AudioAverageTime*freq1),
            amp2*Mathf.Sin(AudioAverageTime*freq2),
        };
    }
}
