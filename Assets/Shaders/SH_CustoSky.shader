// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.04705883,fgcg:0.3529412,fgcb:0.3921569,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:34223,y:32829,varname:node_1,prsc:2|emission-2234-OUT;n:type:ShaderForge.SFN_Tex2d,id:26,x:33292,y:32856,ptovrint:False,ptlb:Sky Gradient,ptin:_SkyGradient,varname:node_3446,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5d9a33a989f91334782040ec2ee8a7ae,ntxv:0,isnm:False|UVIN-32-UVOUT;n:type:ShaderForge.SFN_Panner,id:32,x:33047,y:32856,varname:node_32,prsc:2,spu:1,spv:0|UVIN-5558-UVOUT,DIST-55-OUT;n:type:ShaderForge.SFN_Slider,id:55,x:32692,y:33135,ptovrint:False,ptlb:TimeSlider,ptin:_TimeSlider,varname:node_4212,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1000;n:type:ShaderForge.SFN_TexCoord,id:5558,x:32715,y:32961,varname:node_5558,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:5343,x:33292,y:33042,ptovrint:False,ptlb:OrageGradient,ptin:_OrageGradient,varname:node_5343,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:5170,x:33551,y:32895,varname:node_5170,prsc:2|A-26-RGB,B-5343-RGB,T-9276-OUT;n:type:ShaderForge.SFN_Slider,id:9276,x:33135,y:33230,ptovrint:False,ptlb:Madness,ptin:_Madness,varname:node_9276,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Add,id:2234,x:33990,y:32928,varname:node_2234,prsc:2|A-5170-OUT,B-4330-OUT;n:type:ShaderForge.SFN_Cubemap,id:792,x:33551,y:33063,ptovrint:False,ptlb:Stars,ptin:_Stars,varname:node_792,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,pvfc:0;n:type:ShaderForge.SFN_Multiply,id:4330,x:33806,y:33038,varname:node_4330,prsc:2|A-792-RGB,B-1503-OUT;n:type:ShaderForge.SFN_Slider,id:2159,x:33456,y:33247,ptovrint:False,ptlb:StarsOpacity,ptin:_StarsOpacity,varname:node_2159,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.5,cur:0,max:1;n:type:ShaderForge.SFN_Clamp01,id:1503,x:33768,y:33240,varname:node_1503,prsc:2|IN-2159-OUT;proporder:26-55-5343-9276-792-2159;pass:END;sub:END;*/

Shader "Custom/shd_CustoSky" {
    Properties {
        _SkyGradient ("Sky Gradient", 2D) = "white" {}
        _TimeSlider ("TimeSlider", Range(0, 1000)) = 0
        _OrageGradient ("OrageGradient", 2D) = "white" {}
        _Madness ("Madness", Range(0, 1)) = 0
        _Stars ("Stars", Cube) = "_Skybox" {}
        _StarsOpacity ("StarsOpacity", Range(-0.5, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        LOD 200
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers xbox360 ps3 
            #pragma target 3.0
            uniform sampler2D _SkyGradient; uniform float4 _SkyGradient_ST;
            uniform float _TimeSlider;
            uniform sampler2D _OrageGradient; uniform float4 _OrageGradient_ST;
            uniform float _Madness;
            uniform samplerCUBE _Stars;
            uniform float _StarsOpacity;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float2 node_32 = (i.uv0+_TimeSlider*float2(1,0));
                float4 _SkyGradient_var = tex2D(_SkyGradient,TRANSFORM_TEX(node_32, _SkyGradient));
                float4 _OrageGradient_var = tex2D(_OrageGradient,TRANSFORM_TEX(i.uv0, _OrageGradient));
                float3 emissive = (lerp(_SkyGradient_var.rgb,_OrageGradient_var.rgb,_Madness)+(texCUBE(_Stars,viewReflectDirection).rgb*saturate(_StarsOpacity)));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
