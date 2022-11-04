Shader "Custom/Quad"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue" = "Transparent"}
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows alpha:fade

        sampler2D _MainTex;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            //float2: 수직으로 움직임. x값 고정, y 값만 위로 이동하도록 -
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex.x, IN.uv_MainTex.y - _Time.y));
            o.Albedo = c.rgb;
            //o.Emission = float3(IN.uv_MainTex.x, IN.uv_MainTex.y, 0);
            o.Emission = c.rgb * d.rgb;
            o.Alpha = c.a * d.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
