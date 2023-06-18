Shader "Hidden/CameraMotionBlur" {
Properties {
 _MainTex ("-", 2D) = "" {}
 _NoiseTex ("-", 2D) = "grey" {}
 _VelTex ("-", 2D) = "black" {}
 _NeighbourMaxTex ("-", 2D) = "black" {}
}
	//DummyShaderTextExporter
	
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard fullforwardshadows
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}