// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1517,x:35050,y:32669,varname:node_1517,prsc:2|diff-8777-OUT,spec-8361-OUT,gloss-9548-OUT,normal-2098-RGB,emission-5809-OUT,transm-6949-OUT,voffset-675-OUT,tess-1834-OUT;n:type:ShaderForge.SFN_Multiply,id:5626,x:30884,y:33176,varname:node_5626,prsc:2|A-196-T,B-9263-OUT;n:type:ShaderForge.SFN_Time,id:196,x:30666,y:33135,varname:node_196,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:5432,x:30443,y:33311,ptovrint:False,ptlb:MouvSpeed,ptin:_MouvSpeed,varname:node_5432,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.3;n:type:ShaderForge.SFN_Panner,id:7997,x:31152,y:33036,varname:node_7997,prsc:2,spu:0,spv:1|UVIN-4418-UVOUT,DIST-5626-OUT;n:type:ShaderForge.SFN_TexCoord,id:4418,x:30890,y:32963,varname:node_4418,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:7146,x:30942,y:32469,ptovrint:False,ptlb:Clouds,ptin:_Clouds,varname:node_7146,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-7997-UVOUT;n:type:ShaderForge.SFN_Append,id:118,x:31128,y:32486,varname:node_118,prsc:2|A-7146-R,B-7146-G;n:type:ShaderForge.SFN_Slider,id:244,x:31023,y:32666,ptovrint:False,ptlb:Deformation Bande 1,ptin:_DeformationBande1,varname:node_244,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.03795135,max:1;n:type:ShaderForge.SFN_Slider,id:5882,x:31017,y:32756,ptovrint:False,ptlb:Deformation Bande 2,ptin:_DeformationBande2,varname:node_5882,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Lerp,id:5595,x:31424,y:32509,varname:node_5595,prsc:2|A-4418-UVOUT,B-118-OUT,T-244-OUT;n:type:ShaderForge.SFN_Lerp,id:6262,x:31424,y:32640,varname:node_6262,prsc:2|A-4418-UVOUT,B-118-OUT,T-5882-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5141,x:32230,y:32877,ptovrint:False,ptlb:Foam Tex,ptin:_FoamTex,varname:node_5141,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:654,x:32475,y:32787,varname:node_654,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-5595-OUT,TEX-5141-TEX;n:type:ShaderForge.SFN_Tex2d,id:902,x:32476,y:32972,varname:node_902,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-6262-OUT,TEX-5141-TEX;n:type:ShaderForge.SFN_Color,id:8653,x:32742,y:32866,ptovrint:False,ptlb:Main Color,ptin:_MainColor,varname:node_8653,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.002757356,c3:0.002757356,c4:1;n:type:ShaderForge.SFN_Add,id:6391,x:34003,y:32275,varname:node_6391,prsc:2|A-372-OUT,B-902-B;n:type:ShaderForge.SFN_Fresnel,id:2751,x:33079,y:33130,varname:node_2751,prsc:2|EXP-8745-OUT;n:type:ShaderForge.SFN_Lerp,id:7051,x:33370,y:32768,varname:node_7051,prsc:2|A-8482-OUT,B-7451-OUT,T-2751-OUT;n:type:ShaderForge.SFN_Multiply,id:675,x:34745,y:33221,varname:node_675,prsc:2|A-3529-OUT,B-7741-OUT;n:type:ShaderForge.SFN_Slider,id:249,x:33199,y:32140,ptovrint:False,ptlb:Foam Offset,ptin:_FoamOffset,varname:node_249,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7762493,max:1;n:type:ShaderForge.SFN_Slider,id:1834,x:33626,y:33512,ptovrint:False,ptlb:Tesselation,ptin:_Tesselation,varname:node_1834,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:20;n:type:ShaderForge.SFN_Slider,id:8745,x:32736,y:33225,ptovrint:False,ptlb:Profondeur,ptin:_Profondeur,varname:node_8745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6710028,max:1;n:type:ShaderForge.SFN_NormalVector,id:7741,x:34284,y:33432,prsc:2,pt:False;n:type:ShaderForge.SFN_Tex2d,id:2098,x:32475,y:32624,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_2098,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:263b0239f45cb9049a87d8a57304673c,ntxv:3,isnm:True|UVIN-5595-OUT;n:type:ShaderForge.SFN_Slider,id:8361,x:34290,y:32722,ptovrint:False,ptlb:Specular,ptin:_Specular,varname:node_8361,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9548,x:34290,y:32806,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_9548,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Fresnel,id:9258,x:33338,y:33200,varname:node_9258,prsc:2|EXP-7082-OUT;n:type:ShaderForge.SFN_Slider,id:7082,x:32980,y:33373,ptovrint:False,ptlb:Emission Fresnel,ptin:_EmissionFresnel,varname:node_7082,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:5;n:type:ShaderForge.SFN_Multiply,id:4656,x:33524,y:33200,varname:node_4656,prsc:2|A-9258-OUT,B-8960-OUT,C-5367-RGB;n:type:ShaderForge.SFN_Slider,id:8960,x:32980,y:33463,ptovrint:False,ptlb:Emission Opacity,ptin:_EmissionOpacity,varname:node_8960,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:6949,x:34401,y:33088,varname:node_6949,prsc:2|A-2751-OUT,B-6430-OUT;n:type:ShaderForge.SFN_Slider,id:6430,x:33893,y:33190,ptovrint:False,ptlb:Transmission,ptin:_Transmission,varname:node_6430,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:395,x:33782,y:32519,varname:node_395,prsc:2|A-902-B,B-6812-OUT;n:type:ShaderForge.SFN_ViewReflectionVector,id:4117,x:33734,y:31908,varname:node_4117,prsc:2;n:type:ShaderForge.SFN_Lerp,id:8777,x:34713,y:32387,varname:node_8777,prsc:2|A-6630-OUT,B-2371-RGB,T-6062-OUT;n:type:ShaderForge.SFN_LightColor,id:2371,x:33915,y:31783,varname:node_2371,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:6227,x:33893,y:31908,varname:node_6227,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-4117-OUT;n:type:ShaderForge.SFN_Multiply,id:6062,x:34102,y:31908,varname:node_6062,prsc:2|A-6227-G,B-7863-OUT;n:type:ShaderForge.SFN_Slider,id:7863,x:33736,y:32075,ptovrint:False,ptlb:Light Reflection Opacity,ptin:_LightReflectionOpacity,varname:node_7863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Multiply,id:8482,x:33194,y:32768,varname:node_8482,prsc:2|A-7451-OUT,B-4736-OUT;n:type:ShaderForge.SFN_Vector1,id:4736,x:32742,y:33015,varname:node_4736,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Color,id:9859,x:32742,y:32705,ptovrint:False,ptlb:Main Color_Mad,ptin:_MainColor_Mad,varname:_MainColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.002757356,c3:0.002757356,c4:1;n:type:ShaderForge.SFN_Lerp,id:7451,x:32994,y:32768,varname:node_7451,prsc:2|A-8653-RGB,B-9859-RGB,T-9937-OUT;n:type:ShaderForge.SFN_Slider,id:9937,x:30194,y:33679,ptovrint:False,ptlb:Madness,ptin:_Madness,varname:node_9937,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4539779,max:1;n:type:ShaderForge.SFN_Slider,id:4718,x:33199,y:32236,ptovrint:False,ptlb:Foam Offset_Mad,ptin:_FoamOffset_Mad,varname:_FoamOffset_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7762493,max:1;n:type:ShaderForge.SFN_Lerp,id:6812,x:33591,y:32190,varname:node_6812,prsc:2|A-249-OUT,B-4718-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Add,id:5809,x:33729,y:33200,varname:node_5809,prsc:2|A-4656-OUT,B-3934-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6648,x:30443,y:33386,ptovrint:False,ptlb:MouvSpeed_Mad,ptin:_MouvSpeed_Mad,varname:_MouvSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_Lerp,id:9263,x:30693,y:33311,varname:node_9263,prsc:2|A-5432-OUT,B-6648-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Multiply,id:372,x:33566,y:32452,varname:node_372,prsc:2|A-7051-OUT,B-654-G;n:type:ShaderForge.SFN_Multiply,id:5905,x:33834,y:32654,varname:node_5905,prsc:2|A-9937-OUT,B-9937-OUT;n:type:ShaderForge.SFN_Color,id:6978,x:34150,y:32497,ptovrint:False,ptlb:Foam Mad,ptin:_FoamMad,varname:node_6978,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:6630,x:34512,y:32387,varname:node_6630,prsc:2|A-6391-OUT,B-5136-OUT;n:type:ShaderForge.SFN_Lerp,id:5136,x:34330,y:32411,varname:node_5136,prsc:2|A-3622-OUT,B-6978-RGB,T-5905-OUT;n:type:ShaderForge.SFN_Vector1,id:3622,x:34150,y:32411,varname:node_3622,prsc:2,v1:1;n:type:ShaderForge.SFN_LightColor,id:5367,x:33137,y:33543,varname:node_5367,prsc:2;n:type:ShaderForge.SFN_Vector1,id:460,x:33502,y:33368,varname:node_460,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:3934,x:33584,y:32964,varname:node_3934,prsc:2|A-7051-OUT,B-501-OUT;n:type:ShaderForge.SFN_Vector1,id:501,x:33407,y:33073,varname:node_501,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:1287,x:34352,y:33678,varname:node_1287,prsc:2|A-2129-RGB,B-4828-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5688,x:33914,y:33864,ptovrint:False,ptlb:Global Offset Mad,ptin:_GlobalOffsetMad,varname:node_5688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:8793,x:33914,y:33786,varname:node_8793,prsc:2,v1:0;n:type:ShaderForge.SFN_Lerp,id:4828,x:34152,y:33786,varname:node_4828,prsc:2|A-8793-OUT,B-5688-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Add,id:3529,x:34558,y:33402,varname:node_3529,prsc:2|A-395-OUT,B-1287-OUT;n:type:ShaderForge.SFN_Tex2d,id:2129,x:33471,y:33927,ptovrint:False,ptlb:Offset Tex,ptin:_OffsetTex,varname:node_2129,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8bfed68c9c6e3344d99ecc62624aec4c,ntxv:0,isnm:False|UVIN-7014-UVOUT;n:type:ShaderForge.SFN_Panner,id:7014,x:33280,y:33927,varname:node_7014,prsc:2,spu:1,spv:1|UVIN-9599-UVOUT,DIST-9979-OUT;n:type:ShaderForge.SFN_Time,id:5295,x:32864,y:34050,varname:node_5295,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9979,x:33080,y:34069,varname:node_9979,prsc:2|A-5295-T,B-253-OUT;n:type:ShaderForge.SFN_ValueProperty,id:253,x:32869,y:34204,ptovrint:False,ptlb:Global Offset Mouv Speed,ptin:_GlobalOffsetMouvSpeed,varname:node_253,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_TexCoord,id:9599,x:32979,y:33858,varname:node_9599,prsc:2,uv:0;proporder:5141-8653-9859-7146-9937-5432-6648-244-5882-249-4718-1834-8745-2098-8361-9548-7082-8960-6430-7863-6978-5688-2129-253;pass:END;sub:END;*/

Shader "Custom/shd_WaterOp" {
    Properties {
        _FoamTex ("Foam Tex", 2D) = "white" {}
        _MainColor ("Main Color", Color) = (0.375,0.002757356,0.002757356,1)
        _MainColor_Mad ("Main Color_Mad", Color) = (0.375,0.002757356,0.002757356,1)
        _Clouds ("Clouds", 2D) = "white" {}
        _Madness ("Madness", Range(0, 1)) = 0.4539779
        _MouvSpeed ("MouvSpeed", Float ) = 0.3
        _MouvSpeed_Mad ("MouvSpeed_Mad", Float ) = 0.5
        _DeformationBande1 ("Deformation Bande 1", Range(0, 1)) = 0.03795135
        _DeformationBande2 ("Deformation Bande 2", Range(0, 1)) = 1
        _FoamOffset ("Foam Offset", Range(0, 1)) = 0.7762493
        _FoamOffset_Mad ("Foam Offset_Mad", Range(0, 1)) = 0.7762493
        _Tesselation ("Tesselation", Range(1, 20)) = 1
        _Profondeur ("Profondeur", Range(0, 1)) = 0.6710028
        _Normal ("Normal", 2D) = "bump" {}
        _Specular ("Specular", Range(0, 1)) = 0
        _Glossiness ("Glossiness", Range(0, 1)) = 0
        _EmissionFresnel ("Emission Fresnel", Range(1, 5)) = 1
        _EmissionOpacity ("Emission Opacity", Range(0, 1)) = 0
        _Transmission ("Transmission", Range(0, 1)) = 0
        _LightReflectionOpacity ("Light Reflection Opacity", Range(0, 1)) = 0
        _FoamMad ("Foam Mad", Color) = (0.5,0.5,0.5,1)
        _GlobalOffsetMad ("Global Offset Mad", Float ) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _GlobalOffsetMouvSpeed ("Global Offset Mouv Speed", Float ) = 0
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
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _MouvSpeed;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform float _DeformationBande1;
            uniform float _DeformationBande2;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float4 _MainColor;
            uniform float _FoamOffset;
            uniform float _Tesselation;
            uniform float _Profondeur;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform float _EmissionFresnel;
            uniform float _EmissionOpacity;
            uniform float _Transmission;
            uniform float _LightReflectionOpacity;
            uniform float4 _MainColor_Mad;
            uniform float _Madness;
            uniform float _FoamOffset_Mad;
            uniform float _MouvSpeed_Mad;
            uniform float4 _FoamMad;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffsetMouvSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_196 = _Time + _TimeEditor;
                float node_5626 = (node_196.g*lerp(_MouvSpeed,_MouvSpeed_Mad,_Madness));
                float2 node_7997 = (o.uv0+node_5626*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,_DeformationBande2);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*_GlobalOffsetMouvSpeed)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                v.vertex.xyz += (((node_902.b*lerp(_FoamOffset,_FoamOffset_Mad,_Madness))+(_OffsetTex_var.rgb*lerp(0.0,_GlobalOffsetMad,_Madness)))*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_196 = _Time + _TimeEditor;
                float node_5626 = (node_196.g*lerp(_MouvSpeed,_MouvSpeed_Mad,_Madness));
                float2 node_7997 = (i.uv0+node_5626*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_7997, _Clouds));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_5595 = lerp(i.uv0,node_118,_DeformationBande1);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_5595, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Glossiness;
                float specPow = exp2( gloss * 10.0+1.0);
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = float3(_Specular,_Specular,_Specular);
                float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = (floor(attenuation) * _LightColor0.xyz) * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float node_2751 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Profondeur);
                float node_6949 = (node_2751*_Transmission);
                float3 backLight = max(0.0, -NdotL ) * float3(node_6949,node_6949,node_6949);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 NdotLWrap = max(0,NdotL);
                NdotLWrap = max(float3(0,0,0), NdotLWrap);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL)) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 node_7451 = lerp(_MainColor.rgb,_MainColor_Mad.rgb,_Madness);
                float3 node_7051 = lerp((node_7451*0.3),node_7451,node_2751);
                float4 node_654 = tex2D(_FoamTex,TRANSFORM_TEX(node_5595, _FoamTex));
                float2 node_6262 = lerp(i.uv0,node_118,_DeformationBande2);
                float4 node_902 = tex2D(_FoamTex,TRANSFORM_TEX(node_6262, _FoamTex));
                float node_3622 = 1.0;
                float3 diffuseColor = lerp((((node_7051*node_654.g)+node_902.b)*lerp(float3(node_3622,node_3622,node_3622),_FoamMad.rgb,(_Madness*_Madness))),_LightColor0.rgb,(viewReflectDirection.rgb.g*_LightReflectionOpacity));
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = ((pow(1.0-max(0,dot(normalDirection, viewDirection)),_EmissionFresnel)*_EmissionOpacity*_LightColor0.rgb)+(node_7051*0.2));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _MouvSpeed;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform float _DeformationBande1;
            uniform float _DeformationBande2;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float4 _MainColor;
            uniform float _FoamOffset;
            uniform float _Tesselation;
            uniform float _Profondeur;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform float _EmissionFresnel;
            uniform float _EmissionOpacity;
            uniform float _Transmission;
            uniform float _LightReflectionOpacity;
            uniform float4 _MainColor_Mad;
            uniform float _Madness;
            uniform float _FoamOffset_Mad;
            uniform float _MouvSpeed_Mad;
            uniform float4 _FoamMad;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffsetMouvSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
                UNITY_FOG_COORDS(7)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( _Object2World, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_196 = _Time + _TimeEditor;
                float node_5626 = (node_196.g*lerp(_MouvSpeed,_MouvSpeed_Mad,_Madness));
                float2 node_7997 = (o.uv0+node_5626*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,_DeformationBande2);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*_GlobalOffsetMouvSpeed)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                v.vertex.xyz += (((node_902.b*lerp(_FoamOffset,_FoamOffset_Mad,_Madness))+(_OffsetTex_var.rgb*lerp(0.0,_GlobalOffsetMad,_Madness)))*v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_196 = _Time + _TimeEditor;
                float node_5626 = (node_196.g*lerp(_MouvSpeed,_MouvSpeed_Mad,_Madness));
                float2 node_7997 = (i.uv0+node_5626*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_7997, _Clouds));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_5595 = lerp(i.uv0,node_118,_DeformationBande1);
                float3 _Normal_var = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_5595, _Normal)));
                float3 normalLocal = _Normal_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Glossiness;
                float specPow = exp2( gloss * 10.0+1.0);
////// Specular:
                float NdotL = max(0, dot( normalDirection, lightDirection ));
                float LdotH = max(0.0,dot(lightDirection, halfDirection));
                float3 specularColor = float3(_Specular,_Specular,_Specular);
                float specularMonochrome = max( max(specularColor.r, specularColor.g), specularColor.b);
                float NdotV = max(0.0,dot( normalDirection, viewDirection ));
                float NdotH = max(0.0,dot( normalDirection, halfDirection ));
                float VdotH = max(0.0,dot( viewDirection, halfDirection ));
                float visTerm = SmithBeckmannVisibilityTerm( NdotL, NdotV, 1.0-gloss );
                float normTerm = max(0.0, NDFBlinnPhongNormalizedTerm(NdotH, RoughnessToSpecPower(1.0-gloss)));
                float specularPBL = max(0, (NdotL*visTerm*normTerm) * (UNITY_PI / 4) );
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularPBL*lightColor*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = dot( normalDirection, lightDirection );
                float3 forwardLight = max(0.0, NdotL );
                float node_2751 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Profondeur);
                float node_6949 = (node_2751*_Transmission);
                float3 backLight = max(0.0, -NdotL ) * float3(node_6949,node_6949,node_6949);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 NdotLWrap = max(0,NdotL);
                NdotLWrap = max(float3(0,0,0), NdotLWrap);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL)) * attenColor;
                float3 node_7451 = lerp(_MainColor.rgb,_MainColor_Mad.rgb,_Madness);
                float3 node_7051 = lerp((node_7451*0.3),node_7451,node_2751);
                float4 node_654 = tex2D(_FoamTex,TRANSFORM_TEX(node_5595, _FoamTex));
                float2 node_6262 = lerp(i.uv0,node_118,_DeformationBande2);
                float4 node_902 = tex2D(_FoamTex,TRANSFORM_TEX(node_6262, _FoamTex));
                float node_3622 = 1.0;
                float3 diffuseColor = lerp((((node_7051*node_654.g)+node_902.b)*lerp(float3(node_3622,node_3622,node_3622),_FoamMad.rgb,(_Madness*_Madness))),_LightColor0.rgb,(viewReflectDirection.rgb.g*_LightReflectionOpacity));
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 5.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform float _MouvSpeed;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform float _DeformationBande2;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float _FoamOffset;
            uniform float _Tesselation;
            uniform float _Madness;
            uniform float _FoamOffset_Mad;
            uniform float _MouvSpeed_Mad;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffsetMouvSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_196 = _Time + _TimeEditor;
                float node_5626 = (node_196.g*lerp(_MouvSpeed,_MouvSpeed_Mad,_Madness));
                float2 node_7997 = (o.uv0+node_5626*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,_DeformationBande2);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*_GlobalOffsetMouvSpeed)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                v.vertex.xyz += (((node_902.b*lerp(_FoamOffset,_FoamOffset_Mad,_Madness))+(_OffsetTex_var.rgb*lerp(0.0,_GlobalOffsetMad,_Madness)))*v.normal);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tesselation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
