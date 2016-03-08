// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.04705883,fgcg:0.3529412,fgcb:0.3921569,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1,x:33881,y:32712,varname:node_1,prsc:2|emission-5170-OUT;n:type:ShaderForge.SFN_Tex2d,id:26,x:33292,y:32856,ptovrint:False,ptlb:Sky Gradient,ptin:_SkyGradient,varname:node_3446,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5d9a33a989f91334782040ec2ee8a7ae,ntxv:0,isnm:False|UVIN-32-UVOUT;n:type:ShaderForge.SFN_Panner,id:32,x:33047,y:32856,varname:node_32,prsc:2,spu:1,spv:0|UVIN-5558-UVOUT,DIST-55-OUT;n:type:ShaderForge.SFN_Slider,id:55,x:32692,y:33135,ptovrint:False,ptlb:TimeSlider,ptin:_TimeSlider,varname:node_4212,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1000;n:type:ShaderForge.SFN_TexCoord,id:5558,x:32715,y:32961,varname:node_5558,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:5343,x:33292,y:33042,ptovrint:False,ptlb:OrageGradient,ptin:_OrageGradient,varname:node_5343,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Lerp,id:5170,x:33551,y:32895,varname:node_5170,prsc:2|A-26-RGB,B-5343-RGB,T-9276-OUT;n:type:ShaderForge.SFN_Slider,id:9276,x:33135,y:33230,ptovrint:False,ptlb:Madness,ptin:_Madness,varname:node_9276,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:26-55-5343-9276;pass:END;sub:END;*/

Shader "Custom/shd_CustoSky" {
    Properties {
        _SkyGradient ("Sky Gradient", 2D) = "white" {}
        _TimeSlider ("TimeSlider", Range(0, 1000)) = 0
        _OrageGradient ("OrageGradient", 2D) = "white" {}
        _Madness ("Madness", Range(0, 1)) = 0
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
                float2 node_32 = (i.uv0+_TimeSlider*float2(1,0));
                float4 _SkyGradient_var = tex2D(_SkyGradient,TRANSFORM_TEX(node_32, _SkyGradient));
                float4 _OrageGradient_var = tex2D(_OrageGradient,TRANSFORM_TEX(i.uv0, _OrageGradient));
                float3 emissive = lerp(_SkyGradient_var.rgb,_OrageGradient_var.rgb,_Madness);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
