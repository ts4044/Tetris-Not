using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioSource bgm;
    public ParticleSystem backgroundParticle;
    public Board board;
    public Piece piece;
 
    public void bgmToggleSwitch(bool switchStat)
    {
        if (switchStat)
        {
            bgm.Play();
        }
        else
        {
            bgm.Stop();
        }
    }

    public void backgroundParticleSwitch(bool switchStat)
    {
        if (switchStat)
        {
            backgroundParticle.Play();
        }
        else
        {
            backgroundParticle.Stop();
        }
    }

    public void ceasingParticleSwitch(bool switchStat)
    {
        board.isCeasingParticleOn = switchStat;
    }

    public void soundEffectSwitch(bool switchStat)
    {
        board.isSoundEffectOn = switchStat;
        piece.isSoundEffectOn = switchStat;
    }

    public void shakeEffectSwitch(bool switchStat)
    {
        board.isShakerOn = switchStat;
    }

    public void backgroundSwitch(bool switchStat)
    {
        board.isBackgroundOn = switchStat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
