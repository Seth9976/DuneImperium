using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000100 RID: 256
	public static class ShaderPropertyId : Object
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x0005B910 File Offset: 0x00059B10
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderPropertyId()
		{
			Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderPropertyId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr);
			ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentColor");
			ShaderPropertyId.NativeFieldInfoPtr_subtractiveShadowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "subtractiveShadowColor");
			ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentCubeMap");
			ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentCubeMapHDR");
			ShaderPropertyId.NativeFieldInfoPtr_ambientSkyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientSkyColor");
			ShaderPropertyId.NativeFieldInfoPtr_ambientEquatorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientEquatorColor");
			ShaderPropertyId.NativeFieldInfoPtr_ambientGroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientGroundColor");
			ShaderPropertyId.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "time");
			ShaderPropertyId.NativeFieldInfoPtr_sinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "sinTime");
			ShaderPropertyId.NativeFieldInfoPtr_cosTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cosTime");
			ShaderPropertyId.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "deltaTime");
			ShaderPropertyId.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "timeParameters");
			ShaderPropertyId.NativeFieldInfoPtr_scaledScreenParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaledScreenParams");
			ShaderPropertyId.NativeFieldInfoPtr_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "worldSpaceCameraPos");
			ShaderPropertyId.NativeFieldInfoPtr_screenParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenParams");
			ShaderPropertyId.NativeFieldInfoPtr_alphaToMaskAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "alphaToMaskAvailable");
			ShaderPropertyId.NativeFieldInfoPtr_projectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "projectionParams");
			ShaderPropertyId.NativeFieldInfoPtr_zBufferParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "zBufferParams");
			ShaderPropertyId.NativeFieldInfoPtr_orthoParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "orthoParams");
			ShaderPropertyId.NativeFieldInfoPtr_globalMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "globalMipBias");
			ShaderPropertyId.NativeFieldInfoPtr_screenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenSize");
			ShaderPropertyId.NativeFieldInfoPtr_screenCoordScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenCoordScaleBias");
			ShaderPropertyId.NativeFieldInfoPtr_screenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenSizeOverride");
			ShaderPropertyId.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "projectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_viewAndProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewAndProjectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_inverseViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseViewMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_inverseProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseProjectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_inverseViewAndProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseViewAndProjectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_cameraProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraProjectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_inverseCameraProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseCameraProjectionMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_worldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "worldToCameraMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_cameraToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraToWorldMatrix");
			ShaderPropertyId.NativeFieldInfoPtr_shadowBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "shadowBias");
			ShaderPropertyId.NativeFieldInfoPtr_lightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "lightDirection");
			ShaderPropertyId.NativeFieldInfoPtr_lightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "lightPosition");
			ShaderPropertyId.NativeFieldInfoPtr_cameraWorldClipPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraWorldClipPlanes");
			ShaderPropertyId.NativeFieldInfoPtr_billboardNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardNormal");
			ShaderPropertyId.NativeFieldInfoPtr_billboardTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardTangent");
			ShaderPropertyId.NativeFieldInfoPtr_billboardCameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardCameraParams");
			ShaderPropertyId.NativeFieldInfoPtr_blitTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "blitTexture");
			ShaderPropertyId.NativeFieldInfoPtr_blitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "blitScaleBias");
			ShaderPropertyId.NativeFieldInfoPtr_sourceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "sourceTex");
			ShaderPropertyId.NativeFieldInfoPtr_scaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaleBias");
			ShaderPropertyId.NativeFieldInfoPtr_scaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaleBiasRt");
			ShaderPropertyId.NativeFieldInfoPtr_rendererColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "rendererColor");
			ShaderPropertyId.NativeFieldInfoPtr_ditheringTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ditheringTexture");
			ShaderPropertyId.NativeFieldInfoPtr_ditheringTextureInvSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ditheringTextureInvSize");
			ShaderPropertyId.NativeFieldInfoPtr_renderingLayerMaxInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "renderingLayerMaxInt");
			ShaderPropertyId.NativeFieldInfoPtr_renderingLayerRcpMaxInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "renderingLayerRcpMaxInt");
			ShaderPropertyId.NativeFieldInfoPtr_overlayUITexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "overlayUITexture");
			ShaderPropertyId.NativeFieldInfoPtr_hdrOutputLuminanceParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrOutputLuminanceParams");
			ShaderPropertyId.NativeFieldInfoPtr_hdrOutputGradingParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrOutputGradingParams");
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000C14D File Offset: 0x0000A34D
		public ShaderPropertyId(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0005BD64 File Offset: 0x00059F64
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x0000C156 File Offset: 0x0000A356
		public unsafe static int glossyEnvironmentColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentColor, (void*)(&value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0005BD80 File Offset: 0x00059F80
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0000C164 File Offset: 0x0000A364
		public unsafe static int subtractiveShadowColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_subtractiveShadowColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_subtractiveShadowColor, (void*)(&value));
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0005BD9C File Offset: 0x00059F9C
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000C172 File Offset: 0x0000A372
		public unsafe static int glossyEnvironmentCubeMap
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMap, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMap, (void*)(&value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0005BDB8 File Offset: 0x00059FB8
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x0000C180 File Offset: 0x0000A380
		public unsafe static int glossyEnvironmentCubeMapHDR
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR, (void*)(&value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0005BDD4 File Offset: 0x00059FD4
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000C18E File Offset: 0x0000A38E
		public unsafe static int ambientSkyColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_ambientSkyColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_ambientSkyColor, (void*)(&value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0005BDF0 File Offset: 0x00059FF0
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x0000C19C File Offset: 0x0000A39C
		public unsafe static int ambientEquatorColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_ambientEquatorColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_ambientEquatorColor, (void*)(&value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0005BE0C File Offset: 0x0005A00C
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x0000C1AA File Offset: 0x0000A3AA
		public unsafe static int ambientGroundColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_ambientGroundColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_ambientGroundColor, (void*)(&value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0005BE28 File Offset: 0x0005A028
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public unsafe static int time
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_time, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_time, (void*)(&value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0005BE44 File Offset: 0x0005A044
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		public unsafe static int sinTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_sinTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_sinTime, (void*)(&value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0005BE60 File Offset: 0x0005A060
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public unsafe static int cosTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_cosTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_cosTime, (void*)(&value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0005BE7C File Offset: 0x0005A07C
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		public unsafe static int deltaTime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_deltaTime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_deltaTime, (void*)(&value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x0005BE98 File Offset: 0x0005A098
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		public unsafe static int timeParameters
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_timeParameters, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_timeParameters, (void*)(&value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0000C1FE File Offset: 0x0000A3FE
		public unsafe static int scaledScreenParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_scaledScreenParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_scaledScreenParams, (void*)(&value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0005BED0 File Offset: 0x0005A0D0
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0000C20C File Offset: 0x0000A40C
		public unsafe static int worldSpaceCameraPos
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_worldSpaceCameraPos, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_worldSpaceCameraPos, (void*)(&value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0000C21A File Offset: 0x0000A41A
		public unsafe static int screenParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_screenParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_screenParams, (void*)(&value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005BF08 File Offset: 0x0005A108
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000C228 File Offset: 0x0000A428
		public unsafe static int alphaToMaskAvailable
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_alphaToMaskAvailable, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_alphaToMaskAvailable, (void*)(&value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005BF24 File Offset: 0x0005A124
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000C236 File Offset: 0x0000A436
		public unsafe static int projectionParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_projectionParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_projectionParams, (void*)(&value));
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0005BF40 File Offset: 0x0005A140
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000C244 File Offset: 0x0000A444
		public unsafe static int zBufferParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_zBufferParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_zBufferParams, (void*)(&value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0005BF5C File Offset: 0x0005A15C
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000C252 File Offset: 0x0000A452
		public unsafe static int orthoParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_orthoParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_orthoParams, (void*)(&value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0005BF78 File Offset: 0x0005A178
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000C260 File Offset: 0x0000A460
		public unsafe static int globalMipBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_globalMipBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_globalMipBias, (void*)(&value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0005BF94 File Offset: 0x0005A194
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000C26E File Offset: 0x0000A46E
		public unsafe static int screenSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_screenSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_screenSize, (void*)(&value));
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0000C27C File Offset: 0x0000A47C
		public unsafe static int screenCoordScaleBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_screenCoordScaleBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_screenCoordScaleBias, (void*)(&value));
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0005BFCC File Offset: 0x0005A1CC
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0000C28A File Offset: 0x0000A48A
		public unsafe static int screenSizeOverride
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_screenSizeOverride, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_screenSizeOverride, (void*)(&value));
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0005BFE8 File Offset: 0x0005A1E8
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000C298 File Offset: 0x0000A498
		public unsafe static int viewMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_viewMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_viewMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0005C004 File Offset: 0x0005A204
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000C2A6 File Offset: 0x0000A4A6
		public unsafe static int projectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_projectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_projectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0005C020 File Offset: 0x0005A220
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000C2B4 File Offset: 0x0000A4B4
		public unsafe static int viewAndProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_viewAndProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_viewAndProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0005C03C File Offset: 0x0005A23C
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0000C2C2 File Offset: 0x0000A4C2
		public unsafe static int inverseViewMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_inverseViewMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_inverseViewMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0005C058 File Offset: 0x0005A258
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		public unsafe static int inverseProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_inverseProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_inverseProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0005C074 File Offset: 0x0005A274
		// (set) Token: 0x060014BA RID: 5306 RVA: 0x0000C2DE File Offset: 0x0000A4DE
		public unsafe static int inverseViewAndProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_inverseViewAndProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_inverseViewAndProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0005C090 File Offset: 0x0005A290
		// (set) Token: 0x060014BC RID: 5308 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		public unsafe static int cameraProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_cameraProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_cameraProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060014BD RID: 5309 RVA: 0x0005C0AC File Offset: 0x0005A2AC
		// (set) Token: 0x060014BE RID: 5310 RVA: 0x0000C2FA File Offset: 0x0000A4FA
		public unsafe static int inverseCameraProjectionMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_inverseCameraProjectionMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_inverseCameraProjectionMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x0005C0C8 File Offset: 0x0005A2C8
		// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0000C308 File Offset: 0x0000A508
		public unsafe static int worldToCameraMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_worldToCameraMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_worldToCameraMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0005C0E4 File Offset: 0x0005A2E4
		// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0000C316 File Offset: 0x0000A516
		public unsafe static int cameraToWorldMatrix
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_cameraToWorldMatrix, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_cameraToWorldMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0005C100 File Offset: 0x0005A300
		// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0000C324 File Offset: 0x0000A524
		public unsafe static int shadowBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_shadowBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_shadowBias, (void*)(&value));
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0005C11C File Offset: 0x0005A31C
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0000C332 File Offset: 0x0000A532
		public unsafe static int lightDirection
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_lightDirection, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_lightDirection, (void*)(&value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x0005C138 File Offset: 0x0005A338
		// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000C340 File Offset: 0x0000A540
		public unsafe static int lightPosition
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_lightPosition, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_lightPosition, (void*)(&value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060014C9 RID: 5321 RVA: 0x0005C154 File Offset: 0x0005A354
		// (set) Token: 0x060014CA RID: 5322 RVA: 0x0000C34E File Offset: 0x0000A54E
		public unsafe static int cameraWorldClipPlanes
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_cameraWorldClipPlanes, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_cameraWorldClipPlanes, (void*)(&value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x0005C170 File Offset: 0x0005A370
		// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000C35C File Offset: 0x0000A55C
		public unsafe static int billboardNormal
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_billboardNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_billboardNormal, (void*)(&value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0005C18C File Offset: 0x0005A38C
		// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000C36A File Offset: 0x0000A56A
		public unsafe static int billboardTangent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_billboardTangent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_billboardTangent, (void*)(&value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0005C1A8 File Offset: 0x0005A3A8
		// (set) Token: 0x060014D0 RID: 5328 RVA: 0x0000C378 File Offset: 0x0000A578
		public unsafe static int billboardCameraParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_billboardCameraParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_billboardCameraParams, (void*)(&value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0005C1C4 File Offset: 0x0005A3C4
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x0000C386 File Offset: 0x0000A586
		public unsafe static int blitTexture
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_blitTexture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_blitTexture, (void*)(&value));
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060014D3 RID: 5331 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		// (set) Token: 0x060014D4 RID: 5332 RVA: 0x0000C394 File Offset: 0x0000A594
		public unsafe static int blitScaleBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_blitScaleBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_blitScaleBias, (void*)(&value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005C1FC File Offset: 0x0005A3FC
		// (set) Token: 0x060014D6 RID: 5334 RVA: 0x0000C3A2 File Offset: 0x0000A5A2
		public unsafe static int sourceTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_sourceTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_sourceTex, (void*)(&value));
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0005C218 File Offset: 0x0005A418
		// (set) Token: 0x060014D8 RID: 5336 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public unsafe static int scaleBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_scaleBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_scaleBias, (void*)(&value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x0005C234 File Offset: 0x0005A434
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x0000C3BE File Offset: 0x0000A5BE
		public unsafe static int scaleBiasRt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_scaleBiasRt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_scaleBiasRt, (void*)(&value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0005C250 File Offset: 0x0005A450
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		public unsafe static int rendererColor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_rendererColor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_rendererColor, (void*)(&value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0005C26C File Offset: 0x0005A46C
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x0000C3DA File Offset: 0x0000A5DA
		public unsafe static int ditheringTexture
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_ditheringTexture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_ditheringTexture, (void*)(&value));
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060014DF RID: 5343 RVA: 0x0005C288 File Offset: 0x0005A488
		// (set) Token: 0x060014E0 RID: 5344 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		public unsafe static int ditheringTextureInvSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_ditheringTextureInvSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_ditheringTextureInvSize, (void*)(&value));
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0005C2A4 File Offset: 0x0005A4A4
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x0000C3F6 File Offset: 0x0000A5F6
		public unsafe static int renderingLayerMaxInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_renderingLayerMaxInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_renderingLayerMaxInt, (void*)(&value));
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x0005C2C0 File Offset: 0x0005A4C0
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x0000C404 File Offset: 0x0000A604
		public unsafe static int renderingLayerRcpMaxInt
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_renderingLayerRcpMaxInt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_renderingLayerRcpMaxInt, (void*)(&value));
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0005C2DC File Offset: 0x0005A4DC
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x0000C412 File Offset: 0x0000A612
		public unsafe static int overlayUITexture
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_overlayUITexture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_overlayUITexture, (void*)(&value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x0000C420 File Offset: 0x0000A620
		public unsafe static int hdrOutputLuminanceParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_hdrOutputLuminanceParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_hdrOutputLuminanceParams, (void*)(&value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0005C314 File Offset: 0x0005A514
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x0000C42E File Offset: 0x0000A62E
		public unsafe static int hdrOutputGradingParams
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderPropertyId.NativeFieldInfoPtr_hdrOutputGradingParams, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderPropertyId.NativeFieldInfoPtr_hdrOutputGradingParams, (void*)(&value));
			}
		}

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_glossyEnvironmentColor;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_subtractiveShadowColor;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr_glossyEnvironmentCubeMap;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr_ambientSkyColor;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeFieldInfoPtr_ambientEquatorColor;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr_ambientGroundColor;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr_sinTime;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr_cosTime;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_deltaTime;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_timeParameters;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_scaledScreenParams;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_worldSpaceCameraPos;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_screenParams;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_alphaToMaskAvailable;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_projectionParams;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_zBufferParams;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_orthoParams;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_globalMipBias;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_screenSize;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_screenCoordScaleBias;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_screenSizeOverride;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_viewMatrix;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_projectionMatrix;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_viewAndProjectionMatrix;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_inverseViewMatrix;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_inverseProjectionMatrix;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_inverseViewAndProjectionMatrix;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_cameraProjectionMatrix;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_inverseCameraProjectionMatrix;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_worldToCameraMatrix;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_cameraToWorldMatrix;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_shadowBias;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_lightDirection;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_lightPosition;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_cameraWorldClipPlanes;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr_billboardNormal;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr_billboardTangent;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_billboardCameraParams;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_blitTexture;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_blitScaleBias;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_sourceTex;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_scaleBias;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_scaleBiasRt;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_rendererColor;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeFieldInfoPtr_ditheringTexture;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeFieldInfoPtr_ditheringTextureInvSize;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMaxInt;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerRcpMaxInt;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_overlayUITexture;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_hdrOutputLuminanceParams;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_hdrOutputGradingParams;
	}
}
