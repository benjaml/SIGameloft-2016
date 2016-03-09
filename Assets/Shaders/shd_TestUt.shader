// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:4474,x:32890,y:32711,varname:node_4474,prsc:2|emission-3813-OUT;n:type:ShaderForge.SFN_Vector1,id:3648,x:32559,y:32570,varname:node_3648,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:1896,x:32559,y:32630,varname:node_1896,prsc:2,v1:1;n:type:ShaderForge.SFN_Smoothstep,id:3813,x:32499,y:32801,varname:node_3813,prsc:2|A-756-OUT,B-1118-OUT,V-8696-OUT;n:type:ShaderForge.SFN_Slider,id:8696,x:32169,y:33049,ptovrint:False,ptlb:node_8696,ptin:_node_8696,varname:node_8696,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5641026,max:1;n:type:ShaderForge.SFN_Tex2d,id:9996,x:31949,y:32538,ptovrint:False,ptlb:node_9996,ptin:_node_9996,varname:node_9996,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Step,id:1118,x:32188,y:32548,varname:node_1118,prsc:2|A-9996-RGB,B-5807-OUT;n:type:ShaderForge.SFN_Step,id:756,x:32188,y:32673,varname:node_756,prsc:2|A-9996-RGB,B-4513-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5807,x:31922,y:32855,ptovrint:False,ptlb:node_5807,ptin:_node_5807,varname:node_5807,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:4513,x:31922,y:32929,ptovrint:False,ptlb:node_5807_copy,ptin:_node_5807_copy,varname:_node_5807_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.7;n:type:ShaderForge.SFN_Step,id:4327,x:32188,y:32799,varname:node_4327,prsc:2|A-9996-RGB,B-617-OUT;n:type:ShaderForge.SFN_ValueProperty,id:617,x:31922,y:33007,ptovrint:False,ptlb:node_5807_copy_copy,ptin:_node_5807_copy_copy,varname:_node_5807_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.6;n:type:ShaderForge.SFN_Slider,id:123,x:32169,y:33138,ptovrint:False,ptlb:node_8696_copy,ptin:_node_8696_copy,varname:_node_8696_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;proporder:8696-9996-5807-4513-617-123;pass:END;sub:END;*/

Shader "Custom/shd_TestUt" {
    Properties {
        _node_8696 ("node_8696", Range(0, 1)) = 0.5641026
        _node_9996 ("node_9996", 2D) = "white" {}
        _node_5807 ("node_5807", Float ) = 0.5
        _node_5807_copy ("node_5807_copy", Float ) = 0.7
        _node_5807_copy_copy ("node_5807_copy_copy", Float ) = 0.6
        _node_8696_copy ("node_8696_copy", Range(0, 1)) = 1
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
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float _node_8696;
            uniform sampler2D _node_9996; uniform float4 _node_9996_ST;
            uniform float _node_5807;
            uniform float _node_5807_copy;
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
                float4 _node_9996_var = tex2D(_node_9996,TRANSFORM_TEX(i.uv0, _node_9996));
                float3 emissive = smoothstep( step(_node_9996_var.rgb,_node_5807_copy), step(_node_9996_var.rgb,_node_5807), float3(_node_8696,_node_8696,_node_8696) );
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
