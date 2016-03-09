// Shader created with Shader Forge Beta 0.28 
// Shader Forge (c) Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:0.28;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,hqsc:True,hqlp:False,blpr:2,bsrc:0,bdst:0,culm:0,dpts:2,wrdp:False,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5882353,fgcg:0.627451,fgcb:0.6509804,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:1,x:32491,y:32611|emission-187-OUT;n:type:ShaderForge.SFN_Tex2d,id:2,x:33259,y:32757,ptlb:Star Texture,ptin:_StarTexture,tex:446b15d6a24266445a0c9e16b71ad836,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Sin,id:14,x:34063,y:32676|IN-16-OUT;n:type:ShaderForge.SFN_Time,id:15,x:34410,y:32658;n:type:ShaderForge.SFN_Multiply,id:16,x:34237,y:32676|A-15-T,B-17-OUT;n:type:ShaderForge.SFN_ValueProperty,id:17,x:34410,y:32822,ptlb:Vitesse Clignotement,ptin:_VitesseClignotement,glob:False,v1:0;n:type:ShaderForge.SFN_RemapRange,id:61,x:33882,y:32676,frmn:-1,frmx:1,tomn:0,tomx:1|IN-14-OUT;n:type:ShaderForge.SFN_Tex2d,id:137,x:33911,y:32360,ptlb:Noise Texture,ptin:_NoiseTexture,tex:8bfed68c9c6e3344d99ecc62624aec4c,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:154,x:33398,y:32552|A-61-OUT,B-171-OUT,T-137-R;n:type:ShaderForge.SFN_OneMinus,id:171,x:33694,y:32676|IN-61-OUT;n:type:ShaderForge.SFN_RemapRange,id:176,x:33223,y:32550,frmn:0,frmx:1,tomn:0.5,tomx:1|IN-154-OUT;n:type:ShaderForge.SFN_Multiply,id:187,x:32985,y:32822|A-176-OUT,B-2-RGB,C-224-OUT,D-137-RGB;n:type:ShaderForge.SFN_ValueProperty,id:224,x:33259,y:32961,ptlb:StarsAlpha,ptin:_StarsAlpha,glob:False,v1:0;proporder:2-17-137-224;pass:END;sub:END;*/

Shader "Custom/shd_Stars" {
    Properties {
        _StarTexture ("Star Texture", 2D) = "white" {}
        _VitesseClignotement ("Vitesse Clignotement", Float ) = 0
        _NoiseTexture ("Noise Texture", 2D) = "white" {}
        _StarsAlpha ("StarsAlpha", Float ) = 0
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers xbox360 ps3 flash d3d11_9x 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _StarTexture; uniform float4 _StarTexture_ST;
            uniform float _VitesseClignotement;
            uniform sampler2D _NoiseTexture; uniform float4 _NoiseTexture_ST;
            uniform float _StarsAlpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float4 uv0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o;
                o.uv0 = v.uv0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                return o;
            }
            fixed4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_15 = _Time + _TimeEditor;
                float node_61 = (sin((node_15.g*_VitesseClignotement))*0.5+0.5);
                float2 node_252 = i.uv0;
                float4 node_137 = tex2D(_NoiseTexture,TRANSFORM_TEX(node_252.rg, _NoiseTexture));
                float3 emissive = ((lerp(node_61,(1.0 - node_61),node_137.r)*0.5+0.5)*tex2D(_StarTexture,TRANSFORM_TEX(node_252.rg, _StarTexture)).rgb*_StarsAlpha*node_137.rgb);
                float3 finalColor = emissive;
/// Final Color:
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
