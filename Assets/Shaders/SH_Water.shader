// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:1517,x:35970,y:32666,varname:node_1517,prsc:2|diff-8777-OUT,spec-8361-OUT,gloss-9548-OUT,normal-2098-RGB,emission-5801-OUT,transm-6949-OUT,voffset-8658-OUT;n:type:ShaderForge.SFN_Multiply,id:5626,x:30884,y:33176,varname:node_5626,prsc:2|A-196-T,B-2456-OUT;n:type:ShaderForge.SFN_Time,id:196,x:30666,y:33135,varname:node_196,prsc:2;n:type:ShaderForge.SFN_Panner,id:7997,x:31152,y:33036,varname:node_7997,prsc:2,spu:0,spv:1|UVIN-4418-UVOUT,DIST-5626-OUT;n:type:ShaderForge.SFN_TexCoord,id:4418,x:30890,y:32963,varname:node_4418,prsc:2,uv:0;n:type:ShaderForge.SFN_Tex2d,id:7146,x:30942,y:32469,ptovrint:False,ptlb:Clouds,ptin:_Clouds,varname:node_7146,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-7997-UVOUT;n:type:ShaderForge.SFN_Append,id:118,x:31128,y:32486,varname:node_118,prsc:2|A-7146-R,B-7146-G;n:type:ShaderForge.SFN_Lerp,id:5595,x:31424,y:32509,varname:node_5595,prsc:2|A-4418-UVOUT,B-118-OUT,T-5074-OUT;n:type:ShaderForge.SFN_Lerp,id:6262,x:31424,y:32640,varname:node_6262,prsc:2|A-4418-UVOUT,B-118-OUT,T-5012-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:5141,x:32230,y:32877,ptovrint:False,ptlb:Foam Tex,ptin:_FoamTex,varname:node_5141,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:654,x:32475,y:32787,varname:node_654,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-5595-OUT,TEX-5141-TEX;n:type:ShaderForge.SFN_Tex2d,id:902,x:32476,y:32972,varname:node_902,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-6262-OUT,TEX-5141-TEX;n:type:ShaderForge.SFN_Color,id:8653,x:32742,y:32866,ptovrint:False,ptlb:Main Color,ptin:_MainColor,varname:node_8653,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.002757356,c3:0.002757356,c4:1;n:type:ShaderForge.SFN_Add,id:6391,x:34003,y:32275,varname:node_6391,prsc:2|A-372-OUT,B-902-B;n:type:ShaderForge.SFN_Fresnel,id:2751,x:33079,y:33130,varname:node_2751,prsc:2|EXP-9209-OUT;n:type:ShaderForge.SFN_Lerp,id:7051,x:33370,y:32768,varname:node_7051,prsc:2|A-8482-OUT,B-7451-OUT,T-2751-OUT;n:type:ShaderForge.SFN_Multiply,id:675,x:35139,y:33424,varname:node_675,prsc:2|A-5197-OUT,B-7741-OUT;n:type:ShaderForge.SFN_NormalVector,id:7741,x:34861,y:33599,prsc:2,pt:False;n:type:ShaderForge.SFN_Tex2d,id:2098,x:34719,y:32755,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_2098,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:263b0239f45cb9049a87d8a57304673c,ntxv:3,isnm:True|UVIN-5595-OUT;n:type:ShaderForge.SFN_Slider,id:8361,x:34290,y:32722,ptovrint:False,ptlb:Specular,ptin:_Specular,varname:node_8361,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9548,x:34290,y:32806,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_9548,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Fresnel,id:9258,x:33338,y:33200,varname:node_9258,prsc:2|EXP-1696-OUT;n:type:ShaderForge.SFN_Multiply,id:4656,x:33524,y:33200,varname:node_4656,prsc:2|A-9258-OUT,B-4119-OUT,C-5367-RGB;n:type:ShaderForge.SFN_Multiply,id:6949,x:34401,y:33088,varname:node_6949,prsc:2|A-2751-OUT,B-8946-OUT;n:type:ShaderForge.SFN_Multiply,id:395,x:33782,y:32519,varname:node_395,prsc:2|A-902-B,B-6812-OUT;n:type:ShaderForge.SFN_ViewReflectionVector,id:4117,x:33734,y:31908,varname:node_4117,prsc:2;n:type:ShaderForge.SFN_Lerp,id:8777,x:34713,y:32387,varname:node_8777,prsc:2|A-6630-OUT,B-2371-RGB,T-6062-OUT;n:type:ShaderForge.SFN_LightColor,id:2371,x:33893,y:31779,varname:node_2371,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:6227,x:33893,y:31908,varname:node_6227,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-4117-OUT;n:type:ShaderForge.SFN_Multiply,id:6062,x:34102,y:31908,varname:node_6062,prsc:2|A-6227-G,B-5480-OUT;n:type:ShaderForge.SFN_Multiply,id:8482,x:33194,y:32768,varname:node_8482,prsc:2|A-7451-OUT,B-4736-OUT;n:type:ShaderForge.SFN_Vector1,id:4736,x:32742,y:33015,varname:node_4736,prsc:2,v1:0.3;n:type:ShaderForge.SFN_Color,id:9859,x:32742,y:32705,ptovrint:False,ptlb:Main Color_Mad,ptin:_MainColor_Mad,varname:_MainColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.375,c2:0.002757356,c3:0.002757356,c4:1;n:type:ShaderForge.SFN_Lerp,id:7451,x:32994,y:32768,varname:node_7451,prsc:2|A-8653-RGB,B-9859-RGB,T-9937-OUT;n:type:ShaderForge.SFN_Slider,id:9937,x:30194,y:33679,ptovrint:False,ptlb:Madness,ptin:_Madness,varname:node_9937,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4539779,max:1;n:type:ShaderForge.SFN_Lerp,id:6812,x:33591,y:32190,varname:node_6812,prsc:2|A-7076-OUT,B-8859-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Add,id:5809,x:34401,y:32954,varname:node_5809,prsc:2|A-4042-OUT,B-3934-OUT;n:type:ShaderForge.SFN_Multiply,id:372,x:33566,y:32452,varname:node_372,prsc:2|A-7051-OUT,B-654-G;n:type:ShaderForge.SFN_Multiply,id:5905,x:33834,y:32654,varname:node_5905,prsc:2|A-9937-OUT,B-9937-OUT;n:type:ShaderForge.SFN_Color,id:6978,x:34150,y:32497,ptovrint:False,ptlb:Foam Mad,ptin:_FoamMad,varname:node_6978,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:6630,x:34512,y:32387,varname:node_6630,prsc:2|A-6391-OUT,B-5136-OUT;n:type:ShaderForge.SFN_Lerp,id:5136,x:34330,y:32411,varname:node_5136,prsc:2|A-3622-OUT,B-6978-RGB,T-5905-OUT;n:type:ShaderForge.SFN_Vector1,id:3622,x:34150,y:32411,varname:node_3622,prsc:2,v1:1;n:type:ShaderForge.SFN_LightColor,id:5367,x:33137,y:33543,varname:node_5367,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3934,x:33584,y:32964,varname:node_3934,prsc:2|A-7051-OUT,B-501-OUT;n:type:ShaderForge.SFN_Vector1,id:501,x:33407,y:33073,varname:node_501,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:1287,x:34005,y:33509,varname:node_1287,prsc:2|A-2129-RGB,B-4828-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5688,x:33567,y:33695,ptovrint:False,ptlb:Global Offset Mad,ptin:_GlobalOffsetMad,varname:node_5688,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:4828,x:33805,y:33617,varname:node_4828,prsc:2|A-316-OUT,B-5688-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Add,id:3529,x:34431,y:33450,varname:node_3529,prsc:2|A-395-OUT,B-1287-OUT;n:type:ShaderForge.SFN_Tex2d,id:2129,x:33471,y:33927,ptovrint:False,ptlb:Offset Tex,ptin:_OffsetTex,varname:node_2129,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8bfed68c9c6e3344d99ecc62624aec4c,ntxv:0,isnm:False|UVIN-7014-UVOUT;n:type:ShaderForge.SFN_Panner,id:7014,x:33280,y:33927,varname:node_7014,prsc:2,spu:1,spv:1|UVIN-9599-UVOUT,DIST-9979-OUT;n:type:ShaderForge.SFN_Time,id:5295,x:32864,y:34050,varname:node_5295,prsc:2;n:type:ShaderForge.SFN_Multiply,id:9979,x:33080,y:34069,varname:node_9979,prsc:2|A-5295-T,B-4616-OUT;n:type:ShaderForge.SFN_TexCoord,id:9599,x:32979,y:33858,varname:node_9599,prsc:2,uv:0;n:type:ShaderForge.SFN_Vector1,id:9209,x:32816,y:33158,varname:node_9209,prsc:2,v1:0.6;n:type:ShaderForge.SFN_Vector1,id:4616,x:32864,y:34172,varname:node_4616,prsc:2,v1:0.15;n:type:ShaderForge.SFN_Vector1,id:4119,x:33137,y:33452,varname:node_4119,prsc:2,v1:0.7;n:type:ShaderForge.SFN_Vector1,id:1696,x:33137,y:33368,varname:node_1696,prsc:2,v1:4.5;n:type:ShaderForge.SFN_Vector1,id:5012,x:31206,y:32718,varname:node_5012,prsc:2,v1:0.03;n:type:ShaderForge.SFN_Vector1,id:5074,x:31206,y:32660,varname:node_5074,prsc:2,v1:0.06;n:type:ShaderForge.SFN_Vector1,id:2456,x:30666,y:33273,cmnt: Mouv Speed,varname:node_2456,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:5480,x:33893,y:32062,cmnt:Light Reflection Op,varname:node_5480,prsc:2,v1:0.13;n:type:ShaderForge.SFN_Vector1,id:7076,x:33394,y:32158,cmnt:Foam Offset,varname:node_7076,prsc:2,v1:0.05;n:type:ShaderForge.SFN_Vector1,id:8859,x:33394,y:32218,cmnt:Foam Offset Mad,varname:node_8859,prsc:2,v1:0.2;n:type:ShaderForge.SFN_Vector1,id:8946,x:34182,y:33173,varname:node_8946,prsc:2,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:316,x:33567,y:33617,ptovrint:False,ptlb:Global Offset,ptin:_GlobalOffset,varname:node_316,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_RemapRange,id:5197,x:34861,y:33425,varname:node_5197,prsc:2,frmn:0,frmx:1,tomn:-0.5,tomx:0.5|IN-3529-OUT;n:type:ShaderForge.SFN_Tex2d,id:2860,x:34706,y:32926,ptovrint:False,ptlb:Plancton,ptin:_Plancton,varname:node_2860,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:bd885693d691f084bb2e9a0805f95947,ntxv:2,isnm:False;n:type:ShaderForge.SFN_Color,id:3350,x:34706,y:33079,ptovrint:False,ptlb:Plancton Color,ptin:_PlanctonColor,varname:node_3350,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4705882,c2:0.9342799,c3:1,c4:1;n:type:ShaderForge.SFN_Add,id:144,x:35109,y:32904,varname:node_144,prsc:2|A-5809-OUT,B-3262-OUT,C-3262-OUT;n:type:ShaderForge.SFN_Multiply,id:3262,x:34908,y:32989,varname:node_3262,prsc:2|A-2860-RGB,B-3350-RGB;n:type:ShaderForge.SFN_Lerp,id:4042,x:33870,y:33148,varname:node_4042,prsc:2|A-4656-OUT,B-9550-OUT,T-2650-OUT;n:type:ShaderForge.SFN_Multiply,id:9550,x:33682,y:33333,varname:node_9550,prsc:2|A-9258-OUT,B-3350-RGB;n:type:ShaderForge.SFN_Slider,id:2650,x:33932,y:33966,ptovrint:False,ptlb:Night,ptin:_Night,varname:node_2650,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.263735,max:1;n:type:ShaderForge.SFN_Lerp,id:5801,x:35277,y:33069,varname:node_5801,prsc:2|A-5809-OUT,B-144-OUT,T-2650-OUT;n:type:ShaderForge.SFN_Lerp,id:8658,x:35390,y:33441,varname:node_8658,prsc:2|A-3471-OUT,B-675-OUT,T-9937-OUT;n:type:ShaderForge.SFN_Vector1,id:3471,x:35139,y:33370,varname:node_3471,prsc:2,v1:0;proporder:5141-8653-9859-7146-9937-2098-8361-9548-6978-5688-2129-316-2860-3350-2650;pass:END;sub:END;*/

Shader "Custom/shd_WaterOp2" {
    Properties {
        _FoamTex ("Foam Tex", 2D) = "white" {}
        _MainColor ("Main Color", Color) = (0.375,0.002757356,0.002757356,1)
        _MainColor_Mad ("Main Color_Mad", Color) = (0.375,0.002757356,0.002757356,1)
        _Clouds ("Clouds", 2D) = "white" {}
        _Madness ("Madness", Range(0, 1)) = 0.4539779
        _Normal ("Normal", 2D) = "bump" {}
        _Specular ("Specular", Range(0, 1)) = 0
        _Glossiness ("Glossiness", Range(0, 1)) = 0
        _FoamMad ("Foam Mad", Color) = (0.5,0.5,0.5,1)
        _GlobalOffsetMad ("Global Offset Mad", Float ) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _GlobalOffset ("Global Offset", Float ) = 0
        _Plancton ("Plancton", 2D) = "black" {}
        _PlanctonColor ("Plancton Color", Color) = (0.4705882,0.9342799,1,1)
        _Night ("Night", Range(0, 1)) = 0.263735
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
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float4 _MainColor;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform float4 _MainColor_Mad;
            uniform float _Madness;
            uniform float4 _FoamMad;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffset;
            uniform sampler2D _Plancton; uniform float4 _Plancton_ST;
            uniform float4 _PlanctonColor;
            uniform float _Night;
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
                float node_3471 = 0.0;
                float4 node_196 = _Time + _TimeEditor;
                float2 node_7997 = (o.uv0+(node_196.g*0.1)*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,0.03);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*0.15)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                float3 node_3529 = ((node_902.b*lerp(0.05,0.2,_Madness))+(_OffsetTex_var.rgb*lerp(_GlobalOffset,_GlobalOffsetMad,_Madness)));
                v.vertex.xyz += lerp(float3(node_3471,node_3471,node_3471),((node_3529*1.0+-0.5)*v.normal),_Madness);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_196 = _Time + _TimeEditor;
                float2 node_7997 = (i.uv0+(node_196.g*0.1)*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_7997, _Clouds));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_5595 = lerp(i.uv0,node_118,0.06);
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
                float node_2751 = pow(1.0-max(0,dot(normalDirection, viewDirection)),0.6);
                float node_6949 = (node_2751*1.0);
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
                float2 node_6262 = lerp(i.uv0,node_118,0.03);
                float4 node_902 = tex2D(_FoamTex,TRANSFORM_TEX(node_6262, _FoamTex));
                float node_3622 = 1.0;
                float3 diffuseColor = lerp((((node_7051*node_654.g)+node_902.b)*lerp(float3(node_3622,node_3622,node_3622),_FoamMad.rgb,(_Madness*_Madness))),_LightColor0.rgb,(viewReflectDirection.rgb.g*0.13));
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float node_9258 = pow(1.0-max(0,dot(normalDirection, viewDirection)),4.5);
                float3 node_5809 = (lerp((node_9258*0.7*_LightColor0.rgb),(node_9258*_PlanctonColor.rgb),_Night)+(node_7051*0.2));
                float4 _Plancton_var = tex2D(_Plancton,TRANSFORM_TEX(i.uv0, _Plancton));
                float3 node_3262 = (_Plancton_var.rgb*_PlanctonColor.rgb);
                float3 emissive = lerp(node_5809,(node_5809+node_3262+node_3262),_Night);
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
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float4 _MainColor;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform float4 _MainColor_Mad;
            uniform float _Madness;
            uniform float4 _FoamMad;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffset;
            uniform sampler2D _Plancton; uniform float4 _Plancton_ST;
            uniform float4 _PlanctonColor;
            uniform float _Night;
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
                float node_3471 = 0.0;
                float4 node_196 = _Time + _TimeEditor;
                float2 node_7997 = (o.uv0+(node_196.g*0.1)*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,0.03);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*0.15)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                float3 node_3529 = ((node_902.b*lerp(0.05,0.2,_Madness))+(_OffsetTex_var.rgb*lerp(_GlobalOffset,_GlobalOffsetMad,_Madness)));
                v.vertex.xyz += lerp(float3(node_3471,node_3471,node_3471),((node_3529*1.0+-0.5)*v.normal),_Madness);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float4 node_196 = _Time + _TimeEditor;
                float2 node_7997 = (i.uv0+(node_196.g*0.1)*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_7997, _Clouds));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_5595 = lerp(i.uv0,node_118,0.06);
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
                float node_2751 = pow(1.0-max(0,dot(normalDirection, viewDirection)),0.6);
                float node_6949 = (node_2751*1.0);
                float3 backLight = max(0.0, -NdotL ) * float3(node_6949,node_6949,node_6949);
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 NdotLWrap = max(0,NdotL);
                NdotLWrap = max(float3(0,0,0), NdotLWrap);
                float3 directDiffuse = ((forwardLight+backLight) + ((1 +(fd90 - 1)*pow((1.00001-NdotLWrap), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL)) * attenColor;
                float3 node_7451 = lerp(_MainColor.rgb,_MainColor_Mad.rgb,_Madness);
                float3 node_7051 = lerp((node_7451*0.3),node_7451,node_2751);
                float4 node_654 = tex2D(_FoamTex,TRANSFORM_TEX(node_5595, _FoamTex));
                float2 node_6262 = lerp(i.uv0,node_118,0.03);
                float4 node_902 = tex2D(_FoamTex,TRANSFORM_TEX(node_6262, _FoamTex));
                float node_3622 = 1.0;
                float3 diffuseColor = lerp((((node_7051*node_654.g)+node_902.b)*lerp(float3(node_3622,node_3622,node_3622),_FoamMad.rgb,(_Madness*_Madness))),_LightColor0.rgb,(viewReflectDirection.rgb.g*0.13));
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
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            #pragma glsl
            uniform float4 _TimeEditor;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform sampler2D _FoamTex; uniform float4 _FoamTex_ST;
            uniform float _Madness;
            uniform float _GlobalOffsetMad;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _GlobalOffset;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
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
                float node_3471 = 0.0;
                float4 node_196 = _Time + _TimeEditor;
                float2 node_7997 = (o.uv0+(node_196.g*0.1)*float2(0,1));
                float4 _Clouds_var = tex2Dlod(_Clouds,float4(TRANSFORM_TEX(node_7997, _Clouds),0.0,0));
                float2 node_118 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 node_6262 = lerp(o.uv0,node_118,0.03);
                float4 node_902 = tex2Dlod(_FoamTex,float4(TRANSFORM_TEX(node_6262, _FoamTex),0.0,0));
                float4 node_5295 = _Time + _TimeEditor;
                float2 node_7014 = (o.uv0+(node_5295.g*0.15)*float2(1,1));
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_7014, _OffsetTex),0.0,0));
                float3 node_3529 = ((node_902.b*lerp(0.05,0.2,_Madness))+(_OffsetTex_var.rgb*lerp(_GlobalOffset,_GlobalOffsetMad,_Madness)));
                v.vertex.xyz += lerp(float3(node_3471,node_3471,node_3471),((node_3529*1.0+-0.5)*v.normal),_Madness);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
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
