// Shader created with Shader Forge v1.26 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.26;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:8156,x:34318,y:32557,varname:node_8156,prsc:2|diff-939-OUT,spec-395-OUT,gloss-317-OUT,alpha-2743-OUT,refract-4133-OUT;n:type:ShaderForge.SFN_Tex2d,id:5932,x:31391,y:32045,ptovrint:False,ptlb:Clouds,ptin:_Clouds,varname:node_5932,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2729-UVOUT;n:type:ShaderForge.SFN_Tex2dAsset,id:121,x:32176,y:32667,ptovrint:False,ptlb:Losanges,ptin:_Losanges,varname:node_121,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:7068,x:32374,y:32545,varname:node_7068,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-8272-OUT,TEX-121-TEX;n:type:ShaderForge.SFN_Tex2d,id:1550,x:32374,y:32722,varname:node_1550,prsc:2,tex:dd0a425ad60b4e34aaed7a6b41cf35e7,ntxv:0,isnm:False|UVIN-5519-OUT,TEX-121-TEX;n:type:ShaderForge.SFN_Color,id:9922,x:32374,y:32378,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_9922,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Add,id:939,x:33426,y:32577,varname:node_939,prsc:2|A-9922-RGB,B-7068-G,C-1550-B;n:type:ShaderForge.SFN_TexCoord,id:3154,x:31036,y:32412,varname:node_3154,prsc:2,uv:0;n:type:ShaderForge.SFN_Panner,id:2729,x:31290,y:32490,varname:node_2729,prsc:2,spu:0,spv:1|UVIN-3154-UVOUT,DIST-4465-OUT;n:type:ShaderForge.SFN_Multiply,id:4465,x:31036,y:32704,varname:node_4465,prsc:2|A-7150-T,B-7787-OUT;n:type:ShaderForge.SFN_Time,id:7150,x:30816,y:32648,varname:node_7150,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:7787,x:30816,y:32806,ptovrint:False,ptlb:Mouv Speed,ptin:_MouvSpeed,varname:node_7787,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Lerp,id:8272,x:31897,y:32333,varname:node_8272,prsc:2|A-2729-UVOUT,B-3163-OUT,T-7936-OUT;n:type:ShaderForge.SFN_Slider,id:7936,x:31466,y:32373,ptovrint:False,ptlb:Deformation Bande 2,ptin:_DeformationBande2,varname:node_7936,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:975,x:32821,y:32843,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_975,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:685,x:31466,y:32479,ptovrint:False,ptlb:Deformation Refraction,ptin:_DeformationRefraction,varname:_DeformationDiffuse_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:3380,x:31897,y:32456,varname:node_3380,prsc:2|A-3154-UVOUT,B-3163-OUT,T-685-OUT;n:type:ShaderForge.SFN_Slider,id:3191,x:31725,y:32998,ptovrint:False,ptlb:Refraction,ptin:_Refraction,varname:node_3191,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-0.2,cur:0,max:0.2;n:type:ShaderForge.SFN_Lerp,id:4133,x:32281,y:32944,varname:node_4133,prsc:2|A-9820-OUT,B-3380-OUT,T-3191-OUT;n:type:ShaderForge.SFN_Vector1,id:9820,x:31919,y:32922,varname:node_9820,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:3446,x:33209,y:32761,varname:node_3446,prsc:2|A-1765-OUT,B-1958-OUT,C-975-OUT;n:type:ShaderForge.SFN_Lerp,id:1765,x:33008,y:32337,varname:node_1765,prsc:2|A-1430-OUT,B-7068-G,T-4030-OUT;n:type:ShaderForge.SFN_Vector1,id:1430,x:32787,y:32337,varname:node_1430,prsc:2,v1:0;n:type:ShaderForge.SFN_Slider,id:4030,x:32630,y:32422,ptovrint:False,ptlb:Alpha Bandes 1,ptin:_AlphaBandes1,varname:node_4030,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:9647,x:32630,y:32513,ptovrint:False,ptlb:Alpha Bandes 2,ptin:_AlphaBandes2,varname:_AlphaBandes2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Lerp,id:1958,x:33008,y:32470,varname:node_1958,prsc:2|A-1430-OUT,B-1550-B,T-9647-OUT;n:type:ShaderForge.SFN_Lerp,id:5519,x:31897,y:32182,varname:node_5519,prsc:2|A-2729-UVOUT,B-3163-OUT,T-9317-OUT;n:type:ShaderForge.SFN_Slider,id:9317,x:31466,y:32253,ptovrint:False,ptlb:Deformation Bande 1,ptin:_DeformationBande1,varname:_DeformationBande3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Append,id:3163,x:31564,y:32062,varname:node_3163,prsc:2|A-5932-R,B-5932-G;n:type:ShaderForge.SFN_Multiply,id:2743,x:33383,y:32802,varname:node_2743,prsc:2|A-3446-OUT,B-975-OUT;n:type:ShaderForge.SFN_Slider,id:5732,x:33550,y:32667,ptovrint:False,ptlb:Specular,ptin:_Specular,varname:node_5732,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:317,x:33550,y:32757,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_317,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Tex2d,id:9469,x:33707,y:32494,ptovrint:False,ptlb:Spec Tex,ptin:_SpecTex,varname:node_9469,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:395,x:33997,y:32624,varname:node_395,prsc:2|A-5732-OUT,B-9469-R;proporder:9922-121-5932-7787-975-4030-9647-9317-7936-3191-685-5732-317-9469;pass:END;sub:END;*/

Shader "Custom/shd_Water" {
    Properties {
        _Diffuse ("Diffuse", Color) = (0.5,0.5,0.5,1)
        _Losanges ("Losanges", 2D) = "white" {}
        _Clouds ("Clouds", 2D) = "white" {}
        _MouvSpeed ("Mouv Speed", Float ) = 0
        _Alpha ("Alpha", Range(0, 1)) = 0
        _AlphaBandes1 ("Alpha Bandes 1", Range(0, 1)) = 0
        _AlphaBandes2 ("Alpha Bandes 2", Range(0, 1)) = 0
        _DeformationBande1 ("Deformation Bande 1", Range(0, 1)) = 0
        _DeformationBande2 ("Deformation Bande 2", Range(0, 1)) = 0
        _Refraction ("Refraction", Range(-0.2, 0.2)) = 0
        _DeformationRefraction ("Deformation Refraction", Range(0, 1)) = 0
        _Specular ("Specular", Range(0, 1)) = 0
        _Glossiness ("Glossiness", Range(0, 1)) = 0
        _SpecTex ("Spec Tex", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        LOD 200
        GrabPass{ }
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform sampler2D _Losanges; uniform float4 _Losanges_ST;
            uniform float4 _Diffuse;
            uniform float _MouvSpeed;
            uniform float _DeformationBande2;
            uniform float _Alpha;
            uniform float _DeformationRefraction;
            uniform float _Refraction;
            uniform float _AlphaBandes1;
            uniform float _AlphaBandes2;
            uniform float _DeformationBande1;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform sampler2D _SpecTex; uniform float4 _SpecTex_ST;
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
                float4 screenPos : TEXCOORD3;
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float node_9820 = 0.0;
                float4 node_7150 = _Time + _TimeEditor;
                float2 node_2729 = (i.uv0+(node_7150.g*_MouvSpeed)*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_2729, _Clouds));
                float2 node_3163 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + lerp(float2(node_9820,node_9820),lerp(i.uv0,node_3163,_DeformationRefraction),_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
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
                float4 _SpecTex_var = tex2D(_SpecTex,TRANSFORM_TEX(i.uv0, _SpecTex));
                float node_395 = (_Specular*_SpecTex_var.r);
                float3 specularColor = float3(node_395,node_395,node_395);
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
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float2 node_8272 = lerp(node_2729,node_3163,_DeformationBande2);
                float4 node_7068 = tex2D(_Losanges,TRANSFORM_TEX(node_8272, _Losanges));
                float2 node_5519 = lerp(node_2729,node_3163,_DeformationBande1);
                float4 node_1550 = tex2D(_Losanges,TRANSFORM_TEX(node_5519, _Losanges));
                float3 diffuseColor = (_Diffuse.rgb+node_7068.g+node_1550.b);
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_1430 = 0.0;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,((lerp(node_1430,node_7068.g,_AlphaBandes1)+lerp(node_1430,node_1550.b,_AlphaBandes2)+_Alpha)*_Alpha)),1);
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float4 _TimeEditor;
            uniform sampler2D _Clouds; uniform float4 _Clouds_ST;
            uniform sampler2D _Losanges; uniform float4 _Losanges_ST;
            uniform float4 _Diffuse;
            uniform float _MouvSpeed;
            uniform float _DeformationBande2;
            uniform float _Alpha;
            uniform float _DeformationRefraction;
            uniform float _Refraction;
            uniform float _AlphaBandes1;
            uniform float _AlphaBandes2;
            uniform float _DeformationBande1;
            uniform float _Specular;
            uniform float _Glossiness;
            uniform sampler2D _SpecTex; uniform float4 _SpecTex_ST;
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
                float4 screenPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.screenPos = o.pos;
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                #if UNITY_UV_STARTS_AT_TOP
                    float grabSign = -_ProjectionParams.x;
                #else
                    float grabSign = _ProjectionParams.x;
                #endif
                i.normalDir = normalize(i.normalDir);
                i.screenPos = float4( i.screenPos.xy / i.screenPos.w, 0, 0 );
                i.screenPos.y *= _ProjectionParams.x;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float node_9820 = 0.0;
                float4 node_7150 = _Time + _TimeEditor;
                float2 node_2729 = (i.uv0+(node_7150.g*_MouvSpeed)*float2(0,1));
                float4 _Clouds_var = tex2D(_Clouds,TRANSFORM_TEX(node_2729, _Clouds));
                float2 node_3163 = float2(_Clouds_var.r,_Clouds_var.g);
                float2 sceneUVs = float2(1,grabSign)*i.screenPos.xy*0.5+0.5 + lerp(float2(node_9820,node_9820),lerp(i.uv0,node_3163,_DeformationRefraction),_Refraction);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
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
                float4 _SpecTex_var = tex2D(_SpecTex,TRANSFORM_TEX(i.uv0, _SpecTex));
                float node_395 = (_Specular*_SpecTex_var.r);
                float3 specularColor = float3(node_395,node_395,node_395);
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
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float3 directDiffuse = ((1 +(fd90 - 1)*pow((1.00001-NdotL), 5)) * (1 + (fd90 - 1)*pow((1.00001-NdotV), 5)) * NdotL) * attenColor;
                float2 node_8272 = lerp(node_2729,node_3163,_DeformationBande2);
                float4 node_7068 = tex2D(_Losanges,TRANSFORM_TEX(node_8272, _Losanges));
                float2 node_5519 = lerp(node_2729,node_3163,_DeformationBande1);
                float4 node_1550 = tex2D(_Losanges,TRANSFORM_TEX(node_5519, _Losanges));
                float3 diffuseColor = (_Diffuse.rgb+node_7068.g+node_1550.b);
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_1430 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor * ((lerp(node_1430,node_7068.g,_AlphaBandes1)+lerp(node_1430,node_1550.b,_AlphaBandes2)+_Alpha)*_Alpha),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
