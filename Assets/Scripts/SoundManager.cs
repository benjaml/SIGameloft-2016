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
    int m_FlowerIndex = 0;
    private float m_flowerDelay = 2;

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
            #region Character Movement 
            case SoundManagerType.Diving:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[5];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Jump:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[6];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Flying:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[7];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Straff:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[8];
                    Source[2].Play();
                }
                break;
            #endregion

            #region Character Damage
            case SoundManagerType.Damage:
                if (!Source[3].isPlaying)
                {
                    Source[3].Stop();
                    Source[3].clip = Sound[9];
                    Source[3].Play();
                }
                break;
            #endregion

            #region Dragon
            case SoundManagerType.Anrgy:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[10];
                    Source[5].Play();
                }
                break;

            case SoundManagerType.Suffering:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[11];
                    Source[5].Play();
                }
                break;
            #endregion

            #region Bell
            case SoundManagerType.Gong:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[12];
                    Source[6].Play();
                }
                break;

            case SoundManagerType.Bell:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[13];
                    Source[6].Play();
                }
                break;
            #endregion

            #region Flower
            case SoundManagerType.Flower:

                StopAllCoroutines();
                m_FlowerIndex++;

                if(m_FlowerIndex > 5)
                {
                    m_FlowerIndex = 1;
                }

                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[m_FlowerIndex - 1]; //Mettre les sons des flower aux index entre 0 et 4
                    Source[7].Play();
                }
                StartCoroutine(flowerCooldown());
                break;
            #endregion

            #region Envrionment
            case SoundManagerType.Stream:
                if (!Source[8].isPlaying)
                {
                    Source[8].Stop();
                    Source[8].clip = Sound[14];
                    Source[8].Play();
                }
                break;

            case SoundManagerType.Thunder:
                if (!Source[9].isPlaying)
                {
                    Source[9].Stop();
                    Source[9].clip = Sound[15];
                    Source[9].Play();
                }
                break;
            #endregion

            #region Character Voice
            case SoundManagerType.Talk:
                if (!Source[4].isPlaying)
                {
                    Source[4].Stop();
                    Source[4].clip = Voice[1];
                    Source[4].Play();
                }
                break;
                #endregion


        }
    }

    IEnumerator flowerCooldown ()
    {

        yield return new WaitForSeconds(m_flowerDelay);
        m_FlowerIndex = 0;

    }
   
}
