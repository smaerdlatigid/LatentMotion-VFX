using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class AudioVFX : MonoBehaviour
{
    public LoopbackAudio Audio;
    public VisualEffect vis;
    public float normalizedVolume = 0.1f;
    Color height;
    public float AudioAverageTime;
    public float AudioSubTime; 

    void Start()
    {
        vis = GetComponent<VisualEffect>();
        AudioAverageTime = 0f;
        AudioSubTime = 0f;
    }



    void Update()
    {
        AudioAverageTime += Audio.WeightedAverage;
        AudioSubTime += Audio.WeightedPostScaledSpectrumData[0]; 

        vis.SetFloat("AudioAverage", Audio.WeightedAverage);
        vis.SetFloat("AudioSub", Audio.WeightedPostScaledSpectrumData[0]);
        vis.SetFloat("AudioAverageTime", AudioAverageTime);
        vis.SetFloat("AudioSubTime", AudioSubTime);

        float[,] audioData = Audio.getBuffer(0);

        Texture2D texture = new Texture2D(Audio.bufferSize, Audio.SpectrumSize);

        for (int y = 0; y < Audio.SpectrumSize; y++)
        {
            for (int x = 0; x < Audio.bufferSize; x++)
            {
                height = new Color(
                    audioData[Audio.bufferSize - x - 1, y] * normalizedVolume,
                    audioData[Audio.bufferSize - x - 1, y] * normalizedVolume,
                    audioData[Audio.bufferSize - x - 1, y] * normalizedVolume,
                    1f
                );
                texture.SetPixel(x, y, height);
            }
        }
        texture.Apply();
        vis.SetTexture("AudioSpectrum", texture);
    }
}
