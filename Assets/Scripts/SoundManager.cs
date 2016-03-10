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
    int m_FlowerSource = 0;
    private float m_flowerDelay = 2;
    int m_VoiceFlowerIndex = 1;
    int m_DragonSufferingIndex = 5;

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
                if (!Source[17].isPlaying)
                {
                    Source[17].Stop();
                    Source[17].clip = Sound[9];
                    Source[17].Play();
                }
                break;

            case SoundManagerType.DiveOut:
                if (!Source[18].isPlaying)
                {
                    Source[18].Stop();
                    Source[18].clip = Sound[10];
                    Source[18].Play();
                }
                break;

            case SoundManagerType.Jump:
                if (!Source[15].isPlaying)
                {
                    Source[15].Stop();
                    Source[15].clip = Sound[11];
                    Source[15].Play();
                }
                break;

            case SoundManagerType.Straff:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[12];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Acceleration:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[13];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.BarrelRoll:
                if (!Source[14].isPlaying)
                {
                    Source[14].Stop();
                    Source[14].clip = Sound[20];
                    Source[14].Play();
                }
                break;

            #endregion

            #region Dragon
            case SoundManagerType.Anrgy:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[14];
                    Source[5].Play();
                }
                break;

            case SoundManagerType.Suffering:
                m_DragonSufferingIndex++;

                if (m_DragonSufferingIndex > 6)
                {
                       m_DragonSufferingIndex = 5;
                }

                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[m_DragonSufferingIndex -1]; //Mettre les sons du dragon entre 5 et 6 //Pas de sons à 7 et 8
                    Source[5].Play();
                }
                break;

            case SoundManagerType.BellRung:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[15];
                    Source[5].Play();
                }
                break;
            #endregion

            #region Bell
            case SoundManagerType.Gong:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[16];
                    Source[6].Play();
                }
                break;

            case SoundManagerType.Bell:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[17];
                    Source[6].Play();
                }
                break;
            #endregion

            #region Flower
            case SoundManagerType.Flower:

                StopAllCoroutines();
                m_FlowerIndex++;

                if(m_FlowerIndex == 5)
                {
                    SoundManagerEvent.emit(SoundManagerType.Talk);
                }

                if(m_FlowerIndex > 5)
                {
                    
                    m_FlowerIndex = 2;
                }
                m_FlowerSource = m_FlowerIndex + 8;

                if (!Source[m_FlowerSource].isPlaying)
                {
                    Source[m_FlowerSource].Stop();
                    Source[m_FlowerSource].clip = Sound[m_FlowerIndex - 1]; //Mettre les sons des flower dans sounds aux index entre 0 et 4
                    Source[m_FlowerSource].Play();
                }
                StartCoroutine(flowerCooldown());
                break;
            #endregion

            #region Environment

            case SoundManagerType.Impact:
                if (!Source[8].isPlaying)
                {
                    Source[8].Stop();
                    Source[8].clip = Sound[18];
                    Source[8].Play();
                }
                break;

            case SoundManagerType.Stream:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[19];
                    Source[7].Play();
                }
                break;

            //case SoundManagerType.Thunder:
            //    if (!Source[9].isPlaying)
            //    {
            //        Source[9].Stop();
            //        Source[9].clip = Sound[15];
            //        Source[9].Play();
            //    }
            //    break;
            #endregion

            #region Character Voice
            case SoundManagerType.CharacterHurt:
                if (!Source[3].isPlaying)
                {
                    Source[3].Stop();
                    Source[3].clip = Voice[0];
                    Source[3].Play();
                }
                break;

            case SoundManagerType.Talk:
                m_VoiceFlowerIndex++;
                if (m_FlowerIndex == 5)
                {
                   if (m_VoiceFlowerIndex > 5)
                    {
                        m_VoiceFlowerIndex = 1;
                    }
                }
                Debug.Log(m_VoiceFlowerIndex);

                if (!Source[4].isPlaying)
                {
                    Source[4].Stop();
                    Source[4].clip = Voice[m_VoiceFlowerIndex - 1]; //Mettre les sons dans de voix dans Voice,  aux index entre 1 et 5
                    Source[4].Play();
                }
                StartCoroutine(flowerCooldown());
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
