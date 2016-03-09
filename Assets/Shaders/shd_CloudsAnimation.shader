// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5882353,fgcg:0.627451,fgcb:0.6509804,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:35028,y:32581,varname:node_1,prsc:2|emission-8059-OUT,transm-4664-OUT,alpha-3300-OUT;n:type:ShaderForge.SFN_Tex2d,id:2,x:34244,y:32650,ptovrint:False,ptlb:Cloud Texture,ptin:_CloudTexture,varname:node_7211,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8012e8e952b19034590f94caad94ace5,ntxv:0,isnm:False|UVIN-89-UVOUT;n:type:ShaderForge.SFN_Panner,id:89,x:33231,y:33053,varname:node_89,prsc:2,spu:1,spv:0|UVIN-3495-UVOUT,DIST-92-OUT;n:type:ShaderForge.SFN_Multiply,id:92,x:33053,y:33047,varname:node_92,prsc:2|A-5777-OUT,B-102-OUT;n:type:ShaderForge.SFN_ValueProperty,id:102,x:32844,y:33091,ptovrint:False,ptlb:Cloud Mouvement Speed,ptin:_CloudMouvementSpeed,varname:node_7629,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Slider,id:106,x:34125,y:32915,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_9558,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_Color,id:225,x:32722,y:33976,ptovrint:False,ptlb:SunColorDay,ptin:_SunColorDay,varname:node_827,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.9413793,c3:0.75,c4:1;n:type:ShaderForge.SFN_Color,id:226,x:32722,y:33654,ptovrint:False,ptlb:SunColorNight,ptin:_SunColorNight,varname:node_1930,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9931033,c2:0.5,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:227,x:32722,y:33813,ptovrint:False,ptlb:SunColorNoon,ptin:_SunColorNoon,varname:node_8926,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.555,c3:0.3455882,c4:1;n:type:ShaderForge.SFN_Lerp,id:228,x:32964,y:33759,varname:node_228,prsc:2|A-226-RGB,B-227-RGB,T-229-OUT;n:type:ShaderForge.SFN_Slider,id:229,x:32159,y:33976,ptovrint:False,ptlb:LightTransitionSlider,ptin:_LightTransitionSlider,varname:node_503,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:236,x:32964,y:33910,varname:node_236,prsc:2|A-227-RGB,B-225-RGB,T-229-OUT;n:type:ShaderForge.SFN_Lerp,id:238,x:32956,y:34201,varname:node_238,prsc:2|A-225-RGB,B-227-RGB,T-229-OUT;n:type:ShaderForge.SFN_Lerp,id:240,x:32956,y:34054,varname:node_240,prsc:2|A-227-RGB,B-226-RGB,T-229-OUT;n:type:ShaderForge.SFN_Lerp,id:242,x:33210,y:33839,varname:node_242,prsc:2|A-228-OUT,B-236-OUT,T-247-OUT;n:type:ShaderForge.SFN_Lerp,id:244,x:33198,y:34070,varname:node_244,prsc:2|A-240-OUT,B-238-OUT,T-247-OUT;n:type:ShaderForge.SFN_Lerp,id:246,x:33406,y:33951,varname:node_246,prsc:2|A-242-OUT,B-244-OUT,T-249-OUT;n:type:ShaderForge.SFN_ValueProperty,id:247,x:32956,y:34414,ptovrint:False,ptlb:BoolDay,ptin:_BoolDay,varname:node_9233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:249,x:32956,y:34487,ptovrint:False,ptlb:BoolAfternoon,ptin:_BoolAfternoon,varname:node_3043,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:3495,x:32669,y:33036,varname:node_3495,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:4664,x:34607,y:33282,ptovrint:False,ptlb:Transmission,ptin:_Transmission,varname:node_4664,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Multiply,id:8930,x:34633,y:32682,varname:node_8930,prsc:2|A-2-RGB,B-246-OUT;n:type:ShaderForge.SFN_Lerp,id:8059,x:34792,y:32425,varname:node_8059,prsc:2|A-2-RGB,B-8930-OUT,T-3416-OUT;n:type:ShaderForge.SFN_Slider,id:3416,x:34420,y:32377,ptovrint:False,ptlb:Light Affected,ptin:_LightAffected,varname:node_3416,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:3300,x:34592,y:32858,varname:node_3300,prsc:2|A-2-A,B-106-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5777,x:32802,y:32980,ptovrint:False,ptlb:CloudsMouvSlider,ptin:_CloudsMouvSlider,varname:node_5777,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Slider,id:7310,x:34252,y:32910,ptovrint:False,ptlb:node_4763_copy,ptin:_node_4763_copy,varname:_node_4763_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:2-102-106-226-227-225-229-247-249-4664-3416-5777;pass:END;sub:END;*/

Shader "Custom/shd_CloudsAnimation" {
    Properties {
        _CloudTexture ("Cloud Texture", 2D) = "white" {}
        _CloudMouvementSpeed ("Cloud Mouvement Speed", Float ) = 0.5
        _Alpha ("Alpha", Range(0, 1)) = 0.8
        _SunColorNight ("SunColorNight", Color) = (0.9931033,0.5,1,1)
        _SunColorNoon ("SunColorNoon", Color) = (1,0.555,0.3455882,1)
        _SunColorDay ("SunColorDay", Color) = (1,0.9413793,0.75,1)
        _LightTransitionSlider ("LightTransitionSlider", Range(0, 1)) = 0
        _BoolDay ("BoolDay", Float ) = 0
        _BoolAfternoon ("BoolAfternoon", Float ) = 0
        _Transmission ("Transmission", Float ) = 0
        _LightAffected ("Light Affected", Range(0, 1)) = 0
        _CloudsMouvSlider ("CloudsMouvSlider", Float ) = 0
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform sampler2D _CloudTexture; uniform float4 _CloudTexture_ST;
            uniform float _CloudMouvementSpeed;
            uniform float _Alpha;
            uniform float4 _SunColorDay;
            uniform float4 _SunColorNight;
            uniform float4 _SunColorNoon;
            uniform float _LightTransitionSlider;
            uniform float _BoolDay;
            uniform float _BoolAfternoon;
            uniform float _Transmission;
            uniform float _LightAffected;
            uniform float _CloudsMouvSlider;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float2 node_89 = (i.uv0+(_CloudsMouvSlider*_CloudMouvementSpeed)*float2(1,0));
                float4 _CloudTexture_var = tex2D(_CloudTexture,TRANSFORM_TEX(node_89, _CloudTexture));
                float3 emissive = lerp(_CloudTexture_var.rgb,(_CloudTexture_var.rgb*lerp(lerp(lerp(_SunColorNight.rgb,_SunColorNoon.rgb,_LightTransitionSlider),lerp(_SunColorNoon.rgb,_SunColorDay.rgb,_LightTransitionSlider),_BoolDay),lerp(lerp(_SunColorNoon.rgb,_SunColorNight.rgb,_LightTransitionSlider),lerp(_SunColorDay.rgb,_SunColorNoon.rgb,_LightTransitionSlider),_BoolDay),_BoolAfternoon)),_LightAffected);
                float3 finalColor = emissive;
                return fixed4(finalColor,(_CloudTexture_var.a*_Alpha));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
