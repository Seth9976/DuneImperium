using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000036 RID: 54
	public class Renderer2D : ScriptableRenderer
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00024B70 File Offset: 0x00022D70
		// Note: this type is marked as 'beforefieldinit'.
		static Renderer2D()
		{
			Il2CppClassPointerStore<Renderer2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Renderer2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr);
			Renderer2D.NativeFieldInfoPtr_k_DepthBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "k_DepthBufferBits");
			Renderer2D.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "k_FinalBlitPassQueueOffset");
			Renderer2D.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "k_AfterFinalBlitPassQueueOffset");
			Renderer2D.NativeFieldInfoPtr_m_Render2DLightingPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_Render2DLightingPass");
			Renderer2D.NativeFieldInfoPtr_m_PixelPerfectBackgroundPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_PixelPerfectBackgroundPass");
			Renderer2D.NativeFieldInfoPtr_m_UpscalePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_UpscalePass");
			Renderer2D.NativeFieldInfoPtr_m_FinalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_FinalBlitPass");
			Renderer2D.NativeFieldInfoPtr_m_DrawOffscreenUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_DrawOffscreenUIPass");
			Renderer2D.NativeFieldInfoPtr_m_DrawOverlayUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_DrawOverlayUIPass");
			Renderer2D.NativeFieldInfoPtr_m_LightCullResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_LightCullResult");
			Renderer2D.NativeFieldInfoPtr_m_ColorBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_ColorBufferSystem");
			Renderer2D.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_ProfilingSampler");
			Renderer2D.NativeFieldInfoPtr_m_UseDepthStencilBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_UseDepthStencilBuffer");
			Renderer2D.NativeFieldInfoPtr_m_CreateColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_CreateColorTexture");
			Renderer2D.NativeFieldInfoPtr_m_CreateDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_CreateDepthTexture");
			Renderer2D.NativeFieldInfoPtr_m_ColorTextureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_ColorTextureHandle");
			Renderer2D.NativeFieldInfoPtr_m_DepthTextureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_DepthTextureHandle");
			Renderer2D.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_BlitMaterial");
			Renderer2D.NativeFieldInfoPtr_m_BlitHDRMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_BlitHDRMaterial");
			Renderer2D.NativeFieldInfoPtr_m_SamplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_SamplingMaterial");
			Renderer2D.NativeFieldInfoPtr_m_Renderer2DData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_Renderer2DData");
			Renderer2D.NativeFieldInfoPtr_m_PostProcessPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "m_PostProcessPasses");
			Renderer2D.NativeMethodInfoPtr_get_createColorTexture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663813);
			Renderer2D.NativeMethodInfoPtr_get_createDepthTexture_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663814);
			Renderer2D.NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663815);
			Renderer2D.NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663816);
			Renderer2D.NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663817);
			Renderer2D.NativeMethodInfoPtr_get_afterPostProcessColorHandle_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663818);
			Renderer2D.NativeMethodInfoPtr_get_colorGradingLutHandle_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663819);
			Renderer2D.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663820);
			Renderer2D.NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663821);
			Renderer2D.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663822);
			Renderer2D.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663823);
			Renderer2D.NativeMethodInfoPtr_GetRenderer2DData_Public_Renderer2DData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663824);
			Renderer2D.NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663825);
			Renderer2D.NativeMethodInfoPtr_CreateRenderTextures_Private_Void_byref_RenderPassInputSummary_CommandBuffer_byref_CameraData_Boolean_FilterMode_byref_RTHandle_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663826);
			Renderer2D.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663827);
			Renderer2D.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663828);
			Renderer2D.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663829);
			Renderer2D.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663830);
			Renderer2D.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663831);
			Renderer2D.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, 100663832);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00024EE8 File Offset: 0x000230E8
		public unsafe bool createColorTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_createColorTexture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00024F24 File Offset: 0x00023124
		public unsafe bool createDepthTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_createDepthTexture_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00024F60 File Offset: 0x00023160
		public unsafe ColorGradingLutPass colorGradingLutPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass>(intPtr3) : null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00024FA0 File Offset: 0x000231A0
		public unsafe PostProcessPass postProcessPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00024FE0 File Offset: 0x000231E0
		public unsafe PostProcessPass finalPostProcessPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00025020 File Offset: 0x00023220
		public unsafe RTHandle afterPostProcessColorHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_afterPostProcessColorHandle_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00025060 File Offset: 0x00023260
		public unsafe RTHandle colorGradingLutHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_get_colorGradingLutHandle_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000250A0 File Offset: 0x000232A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int SupportedCameraStackingTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000250E8 File Offset: 0x000232E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601876, RefRangeEnd = 601877, XrefRangeStart = 601740, XrefRangeEnd = 601876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Renderer2D(Renderer2DData data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00025134 File Offset: 0x00023334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601877, XrefRangeEnd = 601900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00025180 File Offset: 0x00023380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601900, XrefRangeEnd = 601903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseRenderTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000251BC File Offset: 0x000233BC
		[CallerCount(0)]
		public unsafe Renderer2DData GetRenderer2DData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_GetRenderer2DData_Public_Renderer2DData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer2DData>(intPtr3) : null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000251FC File Offset: 0x000233FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601916, RefRangeEnd = 601917, XrefRangeStart = 601903, XrefRangeEnd = 601916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Renderer2D.RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00025260 File Offset: 0x00023460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601936, RefRangeEnd = 601937, XrefRangeStart = 601917, XrefRangeEnd = 601936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateRenderTextures(ref Renderer2D.RenderPassInputSummary renderPassInputs, CommandBuffer cmd, ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, out RTHandle colorTargetHandle, out RTHandle depthTargetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &renderPassInputs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceCreateColorTexture;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorTextureFilterMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Renderer2D.NativeMethodInfoPtr_CreateRenderTextures_Private_Void_byref_RenderPassInputSummary_CommandBuffer_byref_CameraData_Boolean_FilterMode_byref_RTHandle_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			colorTargetHandle = ((intPtr5 == 0) ? null : new RTHandle(intPtr5));
			IntPtr intPtr6 = intPtr2;
			depthTargetHandle = ((intPtr6 == 0) ? null : new RTHandle(intPtr6));
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00025328 File Offset: 0x00023528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601937, XrefRangeEnd = 602102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00025384 File Offset: 0x00023584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602102, XrefRangeEnd = 602111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullingParameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000253E0 File Offset: 0x000235E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602111, XrefRangeEnd = 602127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SwapColorBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00025430 File Offset: 0x00023630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602127, XrefRangeEnd = 602129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0002548C File Offset: 0x0002368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602129, XrefRangeEnd = 602131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000254E8 File Offset: 0x000236E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 602131, XrefRangeEnd = 602133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSwapBufferMSAA(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Renderer2D.NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00003CA5 File Offset: 0x00001EA5
		public Renderer2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00025534 File Offset: 0x00023734
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003CAE File Offset: 0x00001EAE
		public unsafe static int k_DepthBufferBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Renderer2D.NativeFieldInfoPtr_k_DepthBufferBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Renderer2D.NativeFieldInfoPtr_k_DepthBufferBits, (void*)(&value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00025550 File Offset: 0x00023750
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00003CBC File Offset: 0x00001EBC
		public unsafe static int k_FinalBlitPassQueueOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Renderer2D.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Renderer2D.NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0002556C File Offset: 0x0002376C
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00003CCA File Offset: 0x00001ECA
		public unsafe static int k_AfterFinalBlitPassQueueOffset
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Renderer2D.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Renderer2D.NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00025588 File Offset: 0x00023788
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public unsafe Render2DLightingPass m_Render2DLightingPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_Render2DLightingPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Render2DLightingPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_Render2DLightingPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000255B8 File Offset: 0x000237B8
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003CF7 File Offset: 0x00001EF7
		public unsafe PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_PixelPerfectBackgroundPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PixelPerfectBackgroundPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_PixelPerfectBackgroundPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000255E8 File Offset: 0x000237E8
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003D16 File Offset: 0x00001F16
		public unsafe UpscalePass m_UpscalePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_UpscalePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpscalePass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_UpscalePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00025618 File Offset: 0x00023818
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003D35 File Offset: 0x00001F35
		public unsafe FinalBlitPass m_FinalBlitPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_FinalBlitPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinalBlitPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_FinalBlitPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x00025648 File Offset: 0x00023848
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00003D54 File Offset: 0x00001F54
		public unsafe DrawScreenSpaceUIPass m_DrawOffscreenUIPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DrawOffscreenUIPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DrawOffscreenUIPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00025678 File Offset: 0x00023878
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003D73 File Offset: 0x00001F73
		public unsafe DrawScreenSpaceUIPass m_DrawOverlayUIPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DrawOverlayUIPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DrawOverlayUIPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000256A8 File Offset: 0x000238A8
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003D92 File Offset: 0x00001F92
		public unsafe Light2DCullResult m_LightCullResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_LightCullResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light2DCullResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_LightCullResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x000256D8 File Offset: 0x000238D8
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003DB1 File Offset: 0x00001FB1
		public unsafe RenderTargetBufferSystem m_ColorBufferSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_ColorBufferSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTargetBufferSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_ColorBufferSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00025708 File Offset: 0x00023908
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public unsafe static ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Renderer2D.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Renderer2D.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00025730 File Offset: 0x00023930
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003DE2 File Offset: 0x00001FE2
		public unsafe bool m_UseDepthStencilBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_UseDepthStencilBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_UseDepthStencilBuffer)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00025758 File Offset: 0x00023958
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003DFD File Offset: 0x00001FFD
		public unsafe bool m_CreateColorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_CreateColorTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_CreateColorTexture)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00025780 File Offset: 0x00023980
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003E18 File Offset: 0x00002018
		public unsafe bool m_CreateDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_CreateDepthTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_CreateDepthTexture)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000257A8 File Offset: 0x000239A8
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003E33 File Offset: 0x00002033
		public unsafe RTHandle m_ColorTextureHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_ColorTextureHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_ColorTextureHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000257D8 File Offset: 0x000239D8
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003E52 File Offset: 0x00002052
		public unsafe RTHandle m_DepthTextureHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DepthTextureHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_DepthTextureHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00025808 File Offset: 0x00023A08
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003E71 File Offset: 0x00002071
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00025838 File Offset: 0x00023A38
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003E90 File Offset: 0x00002090
		public unsafe Material m_BlitHDRMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_BlitHDRMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_BlitHDRMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00025868 File Offset: 0x00023A68
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003EAF File Offset: 0x000020AF
		public unsafe Material m_SamplingMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_SamplingMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_SamplingMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00025898 File Offset: 0x00023A98
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003ECE File Offset: 0x000020CE
		public unsafe Renderer2DData m_Renderer2DData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_Renderer2DData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer2DData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_Renderer2DData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000258C8 File Offset: 0x00023AC8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003EED File Offset: 0x000020ED
		public PostProcessPasses m_PostProcessPasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_PostProcessPasses);
				return new PostProcessPasses(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Renderer2D.NativeFieldInfoPtr_m_PostProcessPasses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_k_DepthBufferBits;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_k_FinalBlitPassQueueOffset;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_m_Render2DLightingPass;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_m_PixelPerfectBackgroundPass;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr_m_UpscalePass;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalBlitPass;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawOffscreenUIPass;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr_m_DrawOverlayUIPass;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_m_LightCullResult;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorBufferSystem;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_m_UseDepthStencilBuffer;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateColorTexture;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateDepthTexture;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTextureHandle;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthTextureHandle;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitHDRMaterial;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_SamplingMaterial;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer2DData;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_m_PostProcessPasses;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_get_createColorTexture_Internal_get_Boolean_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_get_createDepthTexture_Internal_get_Boolean_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_afterPostProcessColorHandle_Internal_get_RTHandle_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLutHandle_Internal_get_RTHandle_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Renderer2DData_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderer2DData_Public_Renderer2DData_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_byref_RenderingData_byref_CameraData_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderTextures_Private_Void_byref_RenderPassInputSummary_CommandBuffer_byref_CameraData_Boolean_FilterMode_byref_RTHandle_byref_RTHandle_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0200015F RID: 351
		[StructLayout(2)]
		public struct RenderPassInputSummary
		{
			// Token: 0x06001B8B RID: 7051 RVA: 0x00072890 File Offset: 0x00070A90
			// Note: this type is marked as 'beforefieldinit'.
			static RenderPassInputSummary()
			{
				Il2CppClassPointerStore<Renderer2D.RenderPassInputSummary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "RenderPassInputSummary");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer2D.RenderPassInputSummary>.NativeClassPtr);
				Renderer2D.RenderPassInputSummary.NativeFieldInfoPtr_requiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D.RenderPassInputSummary>.NativeClassPtr, "requiresDepthTexture");
				Renderer2D.RenderPassInputSummary.NativeFieldInfoPtr_requiresColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D.RenderPassInputSummary>.NativeClassPtr, "requiresColorTexture");
			}

			// Token: 0x06001B8C RID: 7052 RVA: 0x0000F9A6 File Offset: 0x0000DBA6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Renderer2D.RenderPassInputSummary>.NativeClassPtr, ref this));
			}

			// Token: 0x04001418 RID: 5144
			private static readonly IntPtr NativeFieldInfoPtr_requiresDepthTexture;

			// Token: 0x04001419 RID: 5145
			private static readonly IntPtr NativeFieldInfoPtr_requiresColorTexture;

			// Token: 0x0400141A RID: 5146
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool requiresDepthTexture;

			// Token: 0x0400141B RID: 5147
			[FieldOffset(1)]
			[MarshalAs(4)]
			public bool requiresColorTexture;
		}

		// Token: 0x02000160 RID: 352
		[ObfuscatedName("UnityEngine.Rendering.Universal.Renderer2D+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06001B8D RID: 7053 RVA: 0x000728E4 File Offset: 0x00070AE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Renderer2D>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr);
				Renderer2D.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, "<>9");
				Renderer2D.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, "<>9__44_1");
				Renderer2D.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, "<>9__44_0");
				Renderer2D.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, 100663835);
				Renderer2D.__c.NativeMethodInfoPtr__Setup_b__44_1_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, 100663836);
				Renderer2D.__c.NativeMethodInfoPtr__Setup_b__44_0_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr, 100663837);
			}

			// Token: 0x06001B8E RID: 7054 RVA: 0x00072988 File Offset: 0x00070B88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Renderer2D.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B8F RID: 7055 RVA: 0x000729C4 File Offset: 0x00070BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601739, XrefRangeEnd = 601740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Setup_b__44_1(ScriptableRenderPass x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.__c.NativeMethodInfoPtr__Setup_b__44_1_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B90 RID: 7056 RVA: 0x00072A14 File Offset: 0x00070C14
			[CallerCount(0)]
			public unsafe bool _Setup_b__44_0(ScriptableRenderPass x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Renderer2D.__c.NativeMethodInfoPtr__Setup_b__44_0_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B91 RID: 7057 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00072A64 File Offset: 0x00070C64
			// (set) Token: 0x06001B93 RID: 7059 RVA: 0x0000F9C1 File Offset: 0x0000DBC1
			public unsafe static Renderer2D.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Renderer2D.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer2D.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Renderer2D.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x06001B94 RID: 7060 RVA: 0x00072A8C File Offset: 0x00070C8C
			// (set) Token: 0x06001B95 RID: 7061 RVA: 0x0000F9D3 File Offset: 0x0000DBD3
			public unsafe static Predicate<ScriptableRenderPass> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Renderer2D.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRenderPass>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Renderer2D.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00072AB4 File Offset: 0x00070CB4
			// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000F9E5 File Offset: 0x0000DBE5
			public unsafe static Predicate<ScriptableRenderPass> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Renderer2D.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ScriptableRenderPass>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Renderer2D.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400141C RID: 5148
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400141D RID: 5149
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x0400141E RID: 5150
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x0400141F RID: 5151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001420 RID: 5152
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__44_1_Internal_Boolean_ScriptableRenderPass_0;

			// Token: 0x04001421 RID: 5153
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__44_0_Internal_Boolean_ScriptableRenderPass_0;
		}
	}
}
