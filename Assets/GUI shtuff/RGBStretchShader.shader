Shader "Custom/RGBStretch"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _StretchFactor ("Stretch Factor", float) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _StretchFactor;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 offset = float2(_StretchFactor * 0.01, _StretchFactor * 0.01);
                float3 color = float3(
                    tex2D(_MainTex, i.uv + float2(offset.x, 0)).r,
                    tex2D(_MainTex, i.uv + float2(0, offset.y)).g,
                    tex2D(_MainTex, i.uv).b
                );
                return fixed4(color, 1.0);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
}
