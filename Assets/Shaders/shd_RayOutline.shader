// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:3,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:5416,x:33104,y:32695,varname:node_5416,prsc:2|emission-9580-RGB,alpha-7107-OUT;n:type:ShaderForge.SFN_Fresnel,id:6986,x:32229,y:32886,varname:node_6986,prsc:2|EXP-3442-OUT;n:type:ShaderForge.SFN_Color,id:9580,x:32229,y:32691,ptovrint:False,ptlb:Main Color,ptin:_MainColor,varname:node_9580,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_If,id:4631,x:32451,y:32886,varname:node_4631,prsc:2|A-6986-OUT,B-9522-OUT,GT-6322-OUT,EQ-323-OUT,LT-323-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9522,x:32061,y:33100,ptovrint:False,ptlb:Outline Side 2,ptin:_OutlineSide2,varname:node_9522,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Vector1,id:6322,x:32252,y:33112,varname:node_6322,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:323,x:32252,y:33176,varname:node_323,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:4556,x:32692,y:32888,varname:node_4556,prsc:2|A-6986-OUT,B-4631-OUT;n:type:ShaderForge.SFN_Vector1,id:3442,x:32029,y:32905,varname:node_3442,prsc:2,v1:4;n:type:ShaderForge.SFN_Multiply,id:7107,x:32882,y:32922,varname:node_7107,prsc:2|A-4556-OUT,B-9841-OUT;n:type:ShaderForge.SFN_Slider,id:9841,x:32556,y:33079,ptovrint:False,ptlb:Aplha,ptin:_Aplha,varname:node_9841,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:9580-9522-9841;pass:END;sub:END;*/

Shader "Custom/shd_RayOutline" {
    Properties {
        _MainColor ("Main Color", Color) = (0.5,0.5,0.5,1)
        _OutlineSide2 ("Outline Side 2", Float ) = 0
        _Aplha ("Aplha", Range(0, 1)) = 0
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
            ZTest GEqual
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
            uniform float4 _MainColor;
            uniform float _OutlineSide2;
            uniform float _Aplha;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                UNITY_FOG_COORDS(2)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
////// Lighting:
////// Emissive:
                float3 emissive = _MainColor.rgb;
                float3 finalColor = emissive;
                float node_6986 = pow(1.0-max(0,dot(normalDirection, viewDirection)),4.0);
                float node_4631_if_leA = step(node_6986,_OutlineSide2);
                float node_4631_if_leB = step(_OutlineSide2,node_6986);
                float node_323 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor,((node_6986+lerp((node_4631_if_leA*node_323)+(node_4631_if_leB*1.0),node_323,node_4631_if_leA*node_4631_if_leB))*_Aplha));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
