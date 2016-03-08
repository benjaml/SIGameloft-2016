//using UnityEngine;
//using System.Collections;
////using XInputDotNetPure;

//public class Vibrations : MonoBehaviour {

//    float m_ValueOfLeftVibrating=0 ;  //valeur de vibration gauche
//    float m_ValueOfRightVibrating=0 ;  //valeur de vibration droite
//    bool m_isVibrating = false;

//    bool m_isVibrationModeActive = true;


//    // Vibrations On/Off

//    public void SetVibration (bool newVib)
//    {
//        if(m_isVibrationModeActive)
//        {
//            if (!newVib)
//            {
//                m_ValueOfLeftVibrating = 0;
//                m_ValueOfRightVibrating = 0;
//                m_isVibrating = false;
//            }
//            else
//            {
//                m_ValueOfLeftVibrating = 0.2f;
//                m_ValueOfRightVibrating = 0.2f;
//                m_isVibrating = true;
//            }
//        }
       
//        //&GamePad.SetVibration(PlayerIndex.One, testA, testB);
//    }

//    public void SetVibration(bool _isVibrating, float _value)
//    {
       
//        if (m_isVibrationModeActive)
//        {
            
//            if (!_isVibrating)
//            {
//                m_ValueOfLeftVibrating = 0;
//                m_ValueOfRightVibrating = 0;
//                m_isVibrating = false;
//            }
//            else
//            {
//                m_ValueOfLeftVibrating = _value;
//                m_ValueOfRightVibrating = _value;
//                m_isVibrating = true;
//            }
//        }
//    }

//    public void SetVibration(float _value, float _time)
//    {

//        if (m_isVibrationModeActive)
//        {

//            if (_value>0)
//            {
//                m_ValueOfLeftVibrating = _value;
//                m_ValueOfRightVibrating = _value;
//                m_isVibrating = true;

//                Invoke("StopVibration", _time);
//            }

//        }
//    }

//    void StopVibration()
//    {
//        m_ValueOfLeftVibrating = 0;
//        m_ValueOfRightVibrating = 0;
//        m_isVibrating = false;
//    }

//    public void ActivateVibration(bool _isActivate)
//    {
//        m_isVibrationModeActive = _isActivate;

//        if(m_isVibrating)
//        {
//            m_ValueOfLeftVibrating = 0;
//            m_ValueOfRightVibrating = 0;
//            m_isVibrating = false;
//        }
//    }


//    void Update()
//    {
//        if(m_isVibrationModeActive)
//        {
//            GamePad.SetVibration(PlayerIndex.One, m_ValueOfLeftVibrating, m_ValueOfRightVibrating);
//        }
        

//        if (Input.GetButtonDown("Start_0"))
//        {
//            ActivateVibration(!m_isVibrationModeActive);
//        }
//    }

//    void OnApplicationQuit()
//    {
//        GamePad.SetVibration(PlayerIndex.One, 0, 0);
//        GamePad.SetVibration(PlayerIndex.Two, 0, 0);
//        GamePad.SetVibration(PlayerIndex.Three, 0, 0);
//        GamePad.SetVibration(PlayerIndex.Four, 0, 0);
//    }

//}

