// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5284926,fgcg:0.7610294,fgcb:0.8455882,fgca:1,fgde:0.006,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:9249,x:33060,y:32659,varname:node_9249,prsc:2|emission-6890-OUT,alpha-4257-OUT;n:type:ShaderForge.SFN_Tex2d,id:2253,x:32217,y:32680,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_2253,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:6890,x:32463,y:32784,varname:node_6890,prsc:2|A-2253-RGB,B-2974-OUT;n:type:ShaderForge.SFN_Slider,id:4160,x:31944,y:32956,ptovrint:False,ptlb:FadeToBlack,ptin:_FadeToBlack,varname:node_4160,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1367521,max:1;n:type:ShaderForge.SFN_OneMinus,id:2974,x:32294,y:32891,varname:node_2974,prsc:2|IN-4160-OUT;n:type:ShaderForge.SFN_OneMinus,id:3269,x:32676,y:32887,varname:node_3269,prsc:2|IN-6890-OUT;n:type:ShaderForge.SFN_ComponentMask,id:4257,x:32846,y:32887,varname:node_4257,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-3269-OUT;proporder:2253-4160;pass:END;sub:END;*/

Shader "Custom/SH_GameOver" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _FadeToBlack ("FadeToBlack", Range(0, 1)) = 0.1367521
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
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _FadeToBlack;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 node_6890 = (_MainTex_var.rgb*(1.0 - _FadeToBlack));
                float3 emissive = node_6890;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,(1.0 - node_6890).r);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
