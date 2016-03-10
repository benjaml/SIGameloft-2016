// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:6,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32722,y:32712,varname:node_3138,prsc:2|emission-8518-OUT,alpha-8518-OUT;n:type:ShaderForge.SFN_Tex2d,id:1991,x:30790,y:32614,varname:node_1991,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-1594-UVOUT,TEX-7528-TEX;n:type:ShaderForge.SFN_ComponentMask,id:4010,x:31040,y:32614,varname:node_4010,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1991-B;n:type:ShaderForge.SFN_TexCoord,id:1651,x:29554,y:32290,varname:node_1651,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:1594,x:30479,y:32611,varname:node_1594,prsc:2,spu:0,spv:-4|UVIN-5640-OUT;n:type:ShaderForge.SFN_ComponentMask,id:4066,x:30649,y:32809,varname:node_4066,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-4660-UVOUT;n:type:ShaderForge.SFN_Multiply,id:1467,x:29769,y:32484,varname:node_1467,prsc:2|A-1651-U,B-3738-OUT;n:type:ShaderForge.SFN_Append,id:5640,x:30220,y:32604,varname:node_5640,prsc:2|A-1467-OUT,B-1651-V;n:type:ShaderForge.SFN_Tex2dAsset,id:7528,x:30610,y:32420,ptovrint:False,ptlb:node_7528,ptin:_node_7528,varname:node_7528,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7742,x:30830,y:32331,varname:node_7742,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-8958-UVOUT,TEX-7528-TEX;n:type:ShaderForge.SFN_Append,id:3245,x:30214,y:32326,varname:node_3245,prsc:2|A-8967-OUT,B-1651-V;n:type:ShaderForge.SFN_Multiply,id:8967,x:29772,y:32131,varname:node_8967,prsc:2|A-5233-OUT,B-1651-U;n:type:ShaderForge.SFN_ComponentMask,id:3021,x:31040,y:32345,varname:node_3021,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-7742-B;n:type:ShaderForge.SFN_Add,id:5554,x:31347,y:32494,varname:node_5554,prsc:2|A-3021-OUT,B-4010-OUT;n:type:ShaderForge.SFN_Panner,id:8958,x:30468,y:32326,varname:node_8958,prsc:2,spu:0.1,spv:-2|UVIN-3245-OUT;n:type:ShaderForge.SFN_Multiply,id:2662,x:31079,y:32841,varname:node_2662,prsc:2|A-4066-OUT,B-9217-OUT,C-304-OUT;n:type:ShaderForge.SFN_Vector1,id:6300,x:30883,y:33061,varname:node_6300,prsc:2,v1:4;n:type:ShaderForge.SFN_Clamp01,id:565,x:31492,y:32837,varname:node_565,prsc:2|IN-2233-OUT;n:type:ShaderForge.SFN_Multiply,id:8518,x:32149,y:32836,varname:node_8518,prsc:2|A-1502-OUT,B-565-OUT;n:type:ShaderForge.SFN_Slider,id:6439,x:31410,y:32120,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_6439,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Multiply,id:1502,x:31903,y:32358,varname:node_1502,prsc:2|A-6439-OUT,B-3650-OUT;n:type:ShaderForge.SFN_OneMinus,id:9217,x:30883,y:32881,varname:node_9217,prsc:2|IN-4066-OUT;n:type:ShaderForge.SFN_Power,id:2233,x:31283,y:32837,varname:node_2233,prsc:2|VAL-2662-OUT,EXP-304-OUT;n:type:ShaderForge.SFN_TexCoord,id:4660,x:30272,y:32775,varname:node_4660,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:590,x:29772,y:31917,varname:node_590,prsc:2|A-3905-OUT,B-1651-U;n:type:ShaderForge.SFN_Slider,id:3738,x:28658,y:32222,ptovrint:False,ptlb:Stripes,ptin:_Stripes,varname:node_3738,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.5,max:10;n:type:ShaderForge.SFN_Multiply,id:5233,x:29057,y:32068,varname:node_5233,prsc:2|A-3738-OUT,B-592-OUT;n:type:ShaderForge.SFN_Vector1,id:592,x:28813,y:31935,varname:node_592,prsc:2,v1:2;n:type:ShaderForge.SFN_Multiply,id:3905,x:29269,y:31896,varname:node_3905,prsc:2|A-5233-OUT,B-592-OUT;n:type:ShaderForge.SFN_Append,id:6930,x:30220,y:31984,varname:node_6930,prsc:2|A-590-OUT,B-1651-V;n:type:ShaderForge.SFN_Panner,id:2879,x:30470,y:31984,varname:node_2879,prsc:2,spu:0,spv:-1|UVIN-6930-OUT;n:type:ShaderForge.SFN_Tex2d,id:8596,x:30829,y:32022,varname:node_8596,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-2879-UVOUT,TEX-7528-TEX;n:type:ShaderForge.SFN_ComponentMask,id:5785,x:31048,y:32079,varname:node_5785,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-8596-B;n:type:ShaderForge.SFN_Add,id:3650,x:31619,y:32374,varname:node_3650,prsc:2|A-5785-OUT,B-5554-OUT;n:type:ShaderForge.SFN_Slider,id:304,x:31172,y:33154,ptovrint:False,ptlb:Fade,ptin:_Fade,varname:node_304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:4,max:10;proporder:7528-6439-3738-304;pass:END;sub:END;*/

Shader "Shader Forge/SH_SpeedEffect" {
    Properties {
        _node_7528 ("node_7528", 2D) = "white" {}
        _Opacity ("Opacity", Range(0, 1)) = 0.5
        _Stripes ("Stripes", Range(0, 10)) = 1.5
        _Fade ("Fade", Range(0, 10)) = 4
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One OneMinusSrcColor
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_7528; uniform float4 _node_7528_ST;
            uniform float _Opacity;
            uniform float _Stripes;
            uniform float _Fade;
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
                float4 node_5593 = _Time + _TimeEditor;
                float node_592 = 2.0;
                float node_5233 = (_Stripes*node_592);
                float2 node_2879 = (float2(((node_5233*node_592)*i.uv0.r),i.uv0.g)+node_5593.g*float2(0,-1));
                float4 node_8596 = tex2D(_node_7528,TRANSFORM_TEX(node_2879, _node_7528));
                float2 node_8958 = (float2((node_5233*i.uv0.r),i.uv0.g)+node_5593.g*float2(0.1,-2));
                float4 node_7742 = tex2D(_node_7528,TRANSFORM_TEX(node_8958, _node_7528));
                float2 node_1594 = (float2((i.uv0.r*_Stripes),i.uv0.g)+node_5593.g*float2(0,-4));
                float4 node_1991 = tex2D(_node_7528,TRANSFORM_TEX(node_1594, _node_7528));
                float node_4066 = i.uv0.g;
                float node_8518 = ((_Opacity*(node_8596.b.r+(node_7742.b.r+node_1991.b.r)))*saturate(pow((node_4066*(1.0 - node_4066)*_Fade),_Fade)));
                float3 emissive = float3(node_8518,node_8518,node_8518);
                float3 finalColor = emissive;
                return fixed4(finalColor,node_8518);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
