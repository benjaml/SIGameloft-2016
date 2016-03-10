using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour {
	#region Members

	[Header("MUSICS")]
	public List<AudioClip> Music = new List<AudioClip>();

	[Header("SOUNDS")]
	public List<AudioClip> Sound= new List<AudioClip>();
	
	[Header("VOICES")]
	public List<AudioClip> Voice = new List<AudioClip>();

	[Header("Sound Listeners")]
	public List<AudioSource> Source = new List<AudioSource>();


    #endregion

    bool m_Ready = false;


	// Use this for initialization
	void Start()
	{
		SoundManagerEvent.onEvent += Play;
	}

	void OnDestroy()
	{
		SoundManagerEvent.onEvent -= Play;
	}

	public void Play(SoundManagerType emt)
	{
		switch (emt)
		{
            case SoundManagerType.MowerStart:
                if (!Source[1].isPlaying)
                {
                    Source[1].Stop();
                    Source[1].clip = Sound[0];
                    Source[1].Play();
                }
                break;

            case SoundManagerType.MowerStartAndGo:
                Source[1].Stop();
                Source[1].clip = Sound[1];
                Source[1].Play();

                m_Ready = true;
                Play(SoundManagerType.MoweGrass);

                StartCoroutine(DecreaseMoweSound());
                break;

            case SoundManagerType.MoweGrass:
                if(m_Ready)
                {
                    StopAllCoroutines();

                    Source[2].Stop();
                    Source[2].clip = Sound[2];

                    if(Source[2].volume<0.5f)
                    {
                        Source[2].volume = 0.5f;
                    }

                    Source[2].Play();
                }
				
				break;

            case SoundManagerType.MoweNoGrass:
                if (m_Ready)
                {
                    StartCoroutine(DecreaseMoweSoundBig());
                }
                break;

            case SoundManagerType.PoolBounce:
                Source[1].Stop();
                Source[1].clip = Sound[4];
                Source[1].Play();
                break;

            case SoundManagerType.BalloonBounce:
                Source[1].Stop();
                Source[1].clip = Sound[5];
                Source[1].Play();
                break;

            case SoundManagerType.HomeRun:
                Source[3].Stop();
                Source[3].clip = Sound[6];
                Source[3].Play();
                break;

            case SoundManagerType.MenuMove:
                Source[1].Stop();
                Source[1].clip = Sound[7];
                Source[1].Play();
                break;

            case SoundManagerType.Victory:
                Source[5].Stop();
                Source[5].clip = Sound[8];
                Source[5].Play();
                break;

            case SoundManagerType.WoodShock:
                Source[4].Stop();
                Source[4].clip = Sound[9];
                Source[4].Play();
                break;



        }
	}

    IEnumerator DecreaseMoweSound()
    {
        while(Source[2].volume>0.5f)
        {
            Source[2].volume -= 0.01f;
            yield return new WaitForSeconds(0.1f);
        }

        Source[2].volume = 0.5f;
    }

    IEnumerator DecreaseMoweSoundBig()
    {
        while (Source[2].volume > 0.1f)
        {
            Source[2].volume -= 0.05f;
            yield return new WaitForSeconds(0.1f);
        }

        Source[2].volume = 0.1f;
    }


}
