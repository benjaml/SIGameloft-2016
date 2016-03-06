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
            #region Character Movement 
            case SoundManagerType.Diving:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[0];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Jump:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[0];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Flying:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[0];
                    Source[2].Play();
                }
                break;

            case SoundManagerType.Straff:
                if (!Source[2].isPlaying)
                {
                    Source[2].Stop();
                    Source[2].clip = Sound[0];
                    Source[2].Play();
                }
                break;
            #endregion

            #region Character Damage
            case SoundManagerType.Damage:
                if (!Source[3].isPlaying)
                {
                    Source[3].Stop();
                    Source[3].clip = Sound[0];
                    Source[3].Play();
                }
                break;
            #endregion

            #region Dragon
            case SoundManagerType.Anrgy:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[0];
                    Source[5].Play();
                }
                break;

            case SoundManagerType.Suffering:
                if (!Source[5].isPlaying)
                {
                    Source[5].Stop();
                    Source[5].clip = Sound[0];
                    Source[5].Play();
                }
                break;
            #endregion

            #region Bell
            case SoundManagerType.Gong:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[0];
                    Source[6].Play();
                }
                break;

            case SoundManagerType.Bell:
                if (!Source[6].isPlaying)
                {
                    Source[6].Stop();
                    Source[6].clip = Sound[0];
                    Source[6].Play();
                }
                break;
            #endregion

            #region Flower
            case SoundManagerType.Flower_1:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[0];
                    Source[7].Play();
                }
                break;

            case SoundManagerType.Flower_2:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[0];
                    Source[7].Play();
                }
                break;

            case SoundManagerType.Flower_3:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[0];
                    Source[7].Play();
                }
                break;

            case SoundManagerType.Flower_4:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[0];
                    Source[7].Play();
                }
                break;

            case SoundManagerType.Flower_5:
                if (!Source[7].isPlaying)
                {
                    Source[7].Stop();
                    Source[7].clip = Sound[0];
                    Source[7].Play();
                }
                break;
            #endregion

            #region Envrionment
            case SoundManagerType.Stream:
                if (!Source[8].isPlaying)
                {
                    Source[8].Stop();
                    Source[8].clip = Sound[0];
                    Source[8].Play();
                }
                break;

            case SoundManagerType.Thunder:
                if (!Source[9].isPlaying)
                {
                    Source[9].Stop();
                    Source[9].clip = Sound[0];
                    Source[9].Play();
                }
                break;
            #endregion

            #region Character Voice
            case SoundManagerType.Talk:
                if (!Source[4].isPlaying)
                {
                    Source[4].Stop();
                    Source[4].clip = Music[0];
                    Source[4].Play();
                }
                break;
                #endregion


        }
    }

   
}
