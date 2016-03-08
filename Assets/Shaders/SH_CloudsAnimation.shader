// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5882353,fgcg:0.627451,fgcb:0.6509804,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:35028,y:32581,varname:node_1,prsc:2|emission-8059-OUT,alpha-3300-OUT;n:type:ShaderForge.SFN_Tex2d,id:2,x:34123,y:32627,ptovrint:False,ptlb:Cloud Texture,ptin:_CloudTexture,varname:node_7211,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8bde8f836059c294a9e54708cf2f0865,ntxv:0,isnm:False|UVIN-89-UVOUT;n:type:ShaderForge.SFN_Panner,id:89,x:33231,y:33053,varname:node_89,prsc:2,spu:1,spv:0|UVIN-3495-UVOUT,DIST-92-OUT;n:type:ShaderForge.SFN_Multiply,id:92,x:33053,y:33047,varname:node_92,prsc:2|A-5777-OUT,B-102-OUT;n:type:ShaderForge.SFN_ValueProperty,id:102,x:32844,y:33091,ptovrint:False,ptlb:Cloud Mouvement Speed,ptin:_CloudMouvementSpeed,varname:node_7629,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Slider,id:106,x:34345,y:33080,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_9558,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.8,max:1;n:type:ShaderForge.SFN_TexCoord,id:3495,x:32669,y:33036,varname:node_3495,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:8930,x:34508,y:32601,varname:node_8930,prsc:2|A-2-RGB,B-4025-OUT;n:type:ShaderForge.SFN_Lerp,id:8059,x:34792,y:32425,varname:node_8059,prsc:2|A-2-RGB,B-8930-OUT,T-3416-OUT;n:type:ShaderForge.SFN_Slider,id:3416,x:34420,y:32377,ptovrint:False,ptlb:Light Affected,ptin:_LightAffected,varname:node_3416,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:3300,x:34760,y:32844,varname:node_3300,prsc:2|A-2-A,B-106-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5777,x:32802,y:32980,ptovrint:False,ptlb:CloudsMouvSlider,ptin:_CloudsMouvSlider,varname:node_5777,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Color,id:4562,x:34034,y:32842,ptovrint:False,ptlb:SunColor,ptin:_SunColor,varname:node_4562,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.9006085,c3:0.6397059,c4:1;n:type:ShaderForge.SFN_Tex2d,id:9688,x:34034,y:33179,ptovrint:False,ptlb:ShadowMask,ptin:_ShadowMask,varname:node_9688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:fdcb5a46bc5ccc04c81f094f86400b04,ntxv:0,isnm:False|UVIN-89-UVOUT;n:type:ShaderForge.SFN_Color,id:366,x:34034,y:33008,ptovrint:False,ptlb:ShadowColor,ptin:_ShadowColor,varname:_SunColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2063149,c2:0.3214086,c3:0.3897059,c4:1;n:type:ShaderForge.SFN_Lerp,id:4025,x:34301,y:32830,varname:node_4025,prsc:2|A-4562-RGB,B-366-RGB,T-9688-R;proporder:2-102-106-3416-5777-4562-9688-366;pass:END;sub:END;*/

Shader "Custom/shd_CloudsAnimation" {
    Properties {
        _CloudTexture ("Cloud Texture", 2D) = "white" {}
        _CloudMouvementSpeed ("Cloud Mouvement Speed", Float ) = 0.5
        _Alpha ("Alpha", Range(0, 1)) = 0.8
        _LightAffected ("Light Affected", Range(0, 1)) = 0
        _CloudsMouvSlider ("CloudsMouvSlider", Float ) = 0
        _SunColor ("SunColor", Color) = (1,0.9006085,0.6397059,1)
        _ShadowMask ("ShadowMask", 2D) = "white" {}
        _ShadowColor ("ShadowColor", Color) = (0.2063149,0.3214086,0.3897059,1)
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
            uniform float _LightAffected;
            uniform float _CloudsMouvSlider;
            uniform float4 _SunColor;
            uniform sampler2D _ShadowMask; uniform float4 _ShadowMask_ST;
            uniform float4 _ShadowColor;
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
                float4 _ShadowMask_var = tex2D(_ShadowMask,TRANSFORM_TEX(node_89, _ShadowMask));
                float3 emissive = lerp(_CloudTexture_var.rgb,(_CloudTexture_var.rgb*lerp(_SunColor.rgb,_ShadowColor.rgb,_ShadowMask_var.r)),_LightAffected);
                float3 finalColor = emissive;
                return fixed4(finalColor,(_CloudTexture_var.a*_Alpha));
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
