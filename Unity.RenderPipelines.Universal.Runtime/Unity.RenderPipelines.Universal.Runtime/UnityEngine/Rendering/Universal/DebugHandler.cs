using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005C RID: 92
	public class DebugHandler : Object
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x000303D4 File Offset: 0x0002E5D4
		// Note: this type is marked as 'beforefieldinit'.
		static DebugHandler()
		{
			Il2CppClassPointerStore<DebugHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr);
			DebugHandler.NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugColorInvalidModePropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugColorPropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugTexturePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTexturePropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTextureNoStereoPropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugTextureDisplayRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTextureDisplayRect");
			DebugHandler.NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugRenderTargetSupportsStereo");
			DebugHandler.NativeFieldInfoPtr_k_DebugMaterialModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaterialModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugVertexAttributeModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugVertexAttributeModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugMaterialValidationModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaterialValidationModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugMipInfoModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipInfoModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugSceneOverrideModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugSceneOverrideModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugFullScreenModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugFullScreenModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidationModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidationModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateBelowMinThresholdColorPropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAboveMaxThresholdColorPropertyId");
			DebugHandler.NativeFieldInfoPtr_k_DebugMaxPixelCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaxPixelCost");
			DebugHandler.NativeFieldInfoPtr_k_DebugLightingModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugLightingModeId");
			DebugHandler.NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugLightingFeatureFlagsId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoMinLuminanceId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoMaxLuminanceId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoSaturationToleranceId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoHueToleranceId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoCompareColorId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateMetallicMinValueId");
			DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateMetallicMaxValueId");
			DebugHandler.NativeFieldInfoPtr_k_ValidationChannelsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_ValidationChannelsId");
			DebugHandler.NativeFieldInfoPtr_k_RangeMinimumId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_RangeMinimumId");
			DebugHandler.NativeFieldInfoPtr_k_RangeMaximumId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_RangeMaximumId");
			DebugHandler.NativeFieldInfoPtr_m_ReplacementMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_ReplacementMaterial");
			DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HDRDebugViewMaterial");
			DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HDRDebugViewPass");
			DebugHandler.NativeFieldInfoPtr_m_DebugScreenColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugScreenColorHandle");
			DebugHandler.NativeFieldInfoPtr_m_DebugScreenDepthHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugScreenDepthHandle");
			DebugHandler.NativeFieldInfoPtr_m_HasDebugRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HasDebugRenderTarget");
			DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetSupportsStereo");
			DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetPixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetPixelRect");
			DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetIdentifier");
			DebugHandler.NativeFieldInfoPtr_m_DebugDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugDisplaySettings");
			DebugHandler.NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664384);
			DebugHandler.NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664385);
			DebugHandler.NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664386);
			DebugHandler.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664387);
			DebugHandler.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664388);
			DebugHandler.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664389);
			DebugHandler.NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664390);
			DebugHandler.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664391);
			DebugHandler.NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664392);
			DebugHandler.NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664393);
			DebugHandler.NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664394);
			DebugHandler.NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664395);
			DebugHandler.NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664396);
			DebugHandler.NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664397);
			DebugHandler.NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664398);
			DebugHandler.NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664399);
			DebugHandler.NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664400);
			DebugHandler.NativeMethodInfoPtr__ctor_Internal_Void_ScriptableRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664401);
			DebugHandler.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664402);
			DebugHandler.NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664403);
			DebugHandler.NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664404);
			DebugHandler.NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664405);
			DebugHandler.NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664406);
			DebugHandler.NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664407);
			DebugHandler.NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_CommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664408);
			DebugHandler.NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RenderTargetIdentifier_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664409);
			DebugHandler.NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664410);
			DebugHandler.NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_byref_CameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664411);
			DebugHandler.NativeMethodInfoPtr_Setup_Internal_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664412);
			DebugHandler.NativeMethodInfoPtr_CreateDebugRenderSetupEnumerable_Internal_IEnumerable_1_DebugRenderSetup_ScriptableRenderContext_CommandBuffer_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664413);
			DebugHandler.NativeMethodInfoPtr_DrawWithDebugRenderState_Internal_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_DrawFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100664414);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00030968 File Offset: 0x0002EB68
		public unsafe DebugDisplaySettingsLighting LightingSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr3) : null;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000309A8 File Offset: 0x0002EBA8
		public unsafe DebugDisplaySettingsMaterial MaterialSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000309E8 File Offset: 0x0002EBE8
		public unsafe DebugDisplaySettingsRendering RenderingSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr3) : null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00030A28 File Offset: 0x0002EC28
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605850, RefRangeEnd = 605851, XrefRangeStart = 605849, XrefRangeEnd = 605850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00030A64 File Offset: 0x0002EC64
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 605852, RefRangeEnd = 605854, XrefRangeStart = 605851, XrefRangeEnd = 605852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00030AA0 File Offset: 0x0002ECA0
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 605855, RefRangeEnd = 605857, XrefRangeStart = 605854, XrefRangeEnd = 605855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00030ADC File Offset: 0x0002ECDC
		public unsafe bool IsActiveModeUnsupportedForDeferred
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605857, RefRangeEnd = 605858, XrefRangeStart = 605857, XrefRangeEnd = 605857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00030B18 File Offset: 0x0002ED18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 605859, RefRangeEnd = 605860, XrefRangeStart = 605858, XrefRangeEnd = 605859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00030B64 File Offset: 0x0002ED64
		public unsafe Material ReplacementMaterial
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00030BA4 File Offset: 0x0002EDA4
		public unsafe UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineDebugDisplaySettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00030BE4 File Offset: 0x0002EDE4
		public unsafe ref RTHandle DebugScreenColorHandle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 605860, RefRangeEnd = 605867, XrefRangeStart = 605860, XrefRangeEnd = 605860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00030C18 File Offset: 0x0002EE18
		public unsafe ref RTHandle DebugScreenDepthHandle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 605867, RefRangeEnd = 605873, XrefRangeStart = 605867, XrefRangeEnd = 605867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00030C4C File Offset: 0x0002EE4C
		public unsafe HDRDebugViewPass hdrDebugViewPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HDRDebugViewPass>(intPtr3) : null;
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 605873, RefRangeEnd = 605888, XrefRangeStart = 605873, XrefRangeEnd = 605873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HDRDebugViewIsActive(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00030CDC File Offset: 0x0002EEDC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 605873, RefRangeEnd = 605888, XrefRangeStart = 605873, XrefRangeEnd = 605888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteToDebugScreenTexture(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00030D2C File Offset: 0x0002EF2C
		public unsafe bool IsScreenClearNeeded
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 605888, RefRangeEnd = 605891, XrefRangeStart = 605888, XrefRangeEnd = 605888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00030D68 File Offset: 0x0002EF68
		public unsafe bool IsRenderPassSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605891, RefRangeEnd = 605892, XrefRangeStart = 605891, XrefRangeEnd = 605891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00030DA4 File Offset: 0x0002EFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605892, XrefRangeEnd = 605923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugHandler(ScriptableRendererData scriptableRendererData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scriptableRendererData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr__ctor_Internal_Void_ScriptableRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 605932, RefRangeEnd = 605933, XrefRangeStart = 605923, XrefRangeEnd = 605932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00030E24 File Offset: 0x0002F024
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 605934, RefRangeEnd = 605942, XrefRangeStart = 605933, XrefRangeEnd = 605934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsActiveForCamera(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00030E74 File Offset: 0x0002F074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 605942, RefRangeEnd = 605943, XrefRangeStart = 605942, XrefRangeEnd = 605942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &debugFullScreenMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00030EC0 File Offset: 0x0002F0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 605943, RefRangeEnd = 605944, XrefRangeStart = 605943, XrefRangeEnd = 605943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &debugFullScreenMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &textureHeightPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00030F18 File Offset: 0x0002F118
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 605948, RefRangeEnd = 605951, XrefRangeStart = 605944, XrefRangeEnd = 605948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00030F68 File Offset: 0x0002F168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 605955, RefRangeEnd = 605957, XrefRangeStart = 605951, XrefRangeEnd = 605955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &descriptor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00030FC4 File Offset: 0x0002F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605957, XrefRangeEnd = 606003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupShaderProperties(CommandBuffer cmd, int passIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_CommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00031014 File Offset: 0x0002F214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606003, RefRangeEnd = 606004, XrefRangeStart = 606003, XrefRangeEnd = 606003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDebugRenderTarget(RenderTargetIdentifier renderTargetIdentifier, Rect displayRect, bool supportsStereo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTargetIdentifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref displayRect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref supportsStereo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RenderTargetIdentifier_Rect_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00031070 File Offset: 0x0002F270
		[CallerCount(0)]
		public unsafe void ResetDebugRenderTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000310A4 File Offset: 0x0002F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606004, XrefRangeEnd = 606033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, ref CameraData cameraData, bool isFinalPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFinalPass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_byref_CameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00031108 File Offset: 0x0002F308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606033, XrefRangeEnd = 606074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_Setup_Internal_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0003115C File Offset: 0x0002F35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606074, XrefRangeEnd = 606080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<DebugRenderSetup> CreateDebugRenderSetupEnumerable(ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filteringSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_CreateDebugRenderSetupEnumerable_Internal_IEnumerable_1_DebugRenderSetup_ScriptableRenderContext_CommandBuffer_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DebugRenderSetup>>(intPtr3) : null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x000311C8 File Offset: 0x0002F3C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 606111, RefRangeEnd = 606113, XrefRangeStart = 606080, XrefRangeEnd = 606111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawWithDebugRenderState(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, DebugHandler.DrawFunction func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderStateBlock;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.NativeMethodInfoPtr_DrawWithDebugRenderState_Internal_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_DrawFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000554B File Offset: 0x0000374B
		public DebugHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0003126C File Offset: 0x0002F46C
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00005554 File Offset: 0x00003754
		public unsafe static int k_DebugColorInvalidModePropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId, (void*)(&value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00031288 File Offset: 0x0002F488
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00005562 File Offset: 0x00003762
		public unsafe static int k_DebugColorPropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugColorPropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugColorPropertyId, (void*)(&value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000312A4 File Offset: 0x0002F4A4
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00005570 File Offset: 0x00003770
		public unsafe static int k_DebugTexturePropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugTexturePropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugTexturePropertyId, (void*)(&value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000312C0 File Offset: 0x0002F4C0
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0000557E File Offset: 0x0000377E
		public unsafe static int k_DebugTextureNoStereoPropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId, (void*)(&value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000312DC File Offset: 0x0002F4DC
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0000558C File Offset: 0x0000378C
		public unsafe static int k_DebugTextureDisplayRect
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugTextureDisplayRect, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugTextureDisplayRect, (void*)(&value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000312F8 File Offset: 0x0002F4F8
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x0000559A File Offset: 0x0000379A
		public unsafe static int k_DebugRenderTargetSupportsStereo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo, (void*)(&value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00031314 File Offset: 0x0002F514
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000055A8 File Offset: 0x000037A8
		public unsafe static int k_DebugMaterialModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaterialModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaterialModeId, (void*)(&value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00031330 File Offset: 0x0002F530
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x000055B6 File Offset: 0x000037B6
		public unsafe static int k_DebugVertexAttributeModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugVertexAttributeModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugVertexAttributeModeId, (void*)(&value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0003134C File Offset: 0x0002F54C
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x000055C4 File Offset: 0x000037C4
		public unsafe static int k_DebugMaterialValidationModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaterialValidationModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaterialValidationModeId, (void*)(&value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00031368 File Offset: 0x0002F568
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x000055D2 File Offset: 0x000037D2
		public unsafe static int k_DebugMipInfoModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugMipInfoModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugMipInfoModeId, (void*)(&value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00031384 File Offset: 0x0002F584
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x000055E0 File Offset: 0x000037E0
		public unsafe static int k_DebugSceneOverrideModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugSceneOverrideModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugSceneOverrideModeId, (void*)(&value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x000313A0 File Offset: 0x0002F5A0
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000055EE File Offset: 0x000037EE
		public unsafe static int k_DebugFullScreenModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugFullScreenModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugFullScreenModeId, (void*)(&value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x000313BC File Offset: 0x0002F5BC
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000055FC File Offset: 0x000037FC
		public unsafe static int k_DebugValidationModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidationModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidationModeId, (void*)(&value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000313D8 File Offset: 0x0002F5D8
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0000560A File Offset: 0x0000380A
		public unsafe static int k_DebugValidateBelowMinThresholdColorPropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId, (void*)(&value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x000313F4 File Offset: 0x0002F5F4
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00005618 File Offset: 0x00003818
		public unsafe static int k_DebugValidateAboveMaxThresholdColorPropertyId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId, (void*)(&value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00031410 File Offset: 0x0002F610
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00005626 File Offset: 0x00003826
		public unsafe static int k_DebugMaxPixelCost
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaxPixelCost, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugMaxPixelCost, (void*)(&value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0003142C File Offset: 0x0002F62C
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00005634 File Offset: 0x00003834
		public unsafe static int k_DebugLightingModeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugLightingModeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugLightingModeId, (void*)(&value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00031448 File Offset: 0x0002F648
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00005642 File Offset: 0x00003842
		public unsafe static int k_DebugLightingFeatureFlagsId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId, (void*)(&value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00031464 File Offset: 0x0002F664
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00005650 File Offset: 0x00003850
		public unsafe static int k_DebugValidateAlbedoMinLuminanceId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId, (void*)(&value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00031480 File Offset: 0x0002F680
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000565E File Offset: 0x0000385E
		public unsafe static int k_DebugValidateAlbedoMaxLuminanceId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId, (void*)(&value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0003149C File Offset: 0x0002F69C
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x0000566C File Offset: 0x0000386C
		public unsafe static int k_DebugValidateAlbedoSaturationToleranceId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId, (void*)(&value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000314B8 File Offset: 0x0002F6B8
		// (set) Token: 0x060007FE RID: 2046 RVA: 0x0000567A File Offset: 0x0000387A
		public unsafe static int k_DebugValidateAlbedoHueToleranceId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId, (void*)(&value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000314D4 File Offset: 0x0002F6D4
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00005688 File Offset: 0x00003888
		public unsafe static int k_DebugValidateAlbedoCompareColorId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId, (void*)(&value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x000314F0 File Offset: 0x0002F6F0
		// (set) Token: 0x06000802 RID: 2050 RVA: 0x00005696 File Offset: 0x00003896
		public unsafe static int k_DebugValidateMetallicMinValueId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId, (void*)(&value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0003150C File Offset: 0x0002F70C
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000056A4 File Offset: 0x000038A4
		public unsafe static int k_DebugValidateMetallicMaxValueId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId, (void*)(&value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00031528 File Offset: 0x0002F728
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x000056B2 File Offset: 0x000038B2
		public unsafe static int k_ValidationChannelsId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_ValidationChannelsId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_ValidationChannelsId, (void*)(&value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00031544 File Offset: 0x0002F744
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x000056C0 File Offset: 0x000038C0
		public unsafe static int k_RangeMinimumId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_RangeMinimumId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_RangeMinimumId, (void*)(&value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00031560 File Offset: 0x0002F760
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x000056CE File Offset: 0x000038CE
		public unsafe static int k_RangeMaximumId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DebugHandler.NativeFieldInfoPtr_k_RangeMaximumId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugHandler.NativeFieldInfoPtr_k_RangeMaximumId, (void*)(&value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0003157C File Offset: 0x0002F77C
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x000056DC File Offset: 0x000038DC
		public unsafe Material m_ReplacementMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_ReplacementMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_ReplacementMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000315AC File Offset: 0x0002F7AC
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x000056FB File Offset: 0x000038FB
		public unsafe Material m_HDRDebugViewMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000315DC File Offset: 0x0002F7DC
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe HDRDebugViewPass m_HDRDebugViewPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRDebugViewPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HDRDebugViewPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0003160C File Offset: 0x0002F80C
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00005739 File Offset: 0x00003939
		public unsafe RTHandle m_DebugScreenColorHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugScreenColorHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugScreenColorHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0003163C File Offset: 0x0002F83C
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00005758 File Offset: 0x00003958
		public unsafe RTHandle m_DebugScreenDepthHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugScreenDepthHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugScreenDepthHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0003166C File Offset: 0x0002F86C
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00005777 File Offset: 0x00003977
		public unsafe bool m_HasDebugRenderTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HasDebugRenderTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_HasDebugRenderTarget)) = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00031694 File Offset: 0x0002F894
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00005792 File Offset: 0x00003992
		public unsafe bool m_DebugRenderTargetSupportsStereo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo)) = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000316BC File Offset: 0x0002F8BC
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x000057AD File Offset: 0x000039AD
		public unsafe Vector4 m_DebugRenderTargetPixelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetPixelRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetPixelRect)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000316E4 File Offset: 0x0002F8E4
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000057C8 File Offset: 0x000039C8
		public unsafe RenderTargetIdentifier m_DebugRenderTargetIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetIdentifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugRenderTargetIdentifier)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0003170C File Offset: 0x0002F90C
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000057E3 File Offset: 0x000039E3
		public unsafe UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugDisplaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineDebugDisplaySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.NativeFieldInfoPtr_m_DebugDisplaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugColorPropertyId;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugTexturePropertyId;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugTextureDisplayRect;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugMaterialModeId;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugVertexAttributeModeId;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugMaterialValidationModeId;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugMipInfoModeId;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugSceneOverrideModeId;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugFullScreenModeId;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidationModeId;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugMaxPixelCost;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugLightingModeId;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_k_ValidationChannelsId;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_k_RangeMinimumId;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_k_RangeMaximumId;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_m_ReplacementMaterial;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_m_HDRDebugViewMaterial;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_m_HDRDebugViewPass;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugScreenColorHandle;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugScreenDepthHandle;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_m_HasDebugRenderTarget;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugRenderTargetPixelRect;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugRenderTargetIdentifier;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugDisplaySettings;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_byref_CameraData_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_byref_CameraData_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ScriptableRendererData_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_byref_CameraData_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_Int32_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_CommandBuffer_Int32_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RenderTargetIdentifier_Rect_Boolean_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_byref_CameraData_Boolean_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Internal_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_CreateDebugRenderSetupEnumerable_Internal_IEnumerable_1_DebugRenderSetup_ScriptableRenderContext_CommandBuffer_FilteringSettings_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_DrawWithDebugRenderState_Internal_Void_ScriptableRenderContext_CommandBuffer_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_DrawFunction_0;

		// Token: 0x0200017B RID: 379
		public class DebugRenderPassEnumerable : Object
		{
			// Token: 0x06001C89 RID: 7305 RVA: 0x00075308 File Offset: 0x00073508
			// Note: this type is marked as 'beforefieldinit'.
			static DebugRenderPassEnumerable()
			{
				Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "DebugRenderPassEnumerable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr);
				DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_DebugHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, "m_DebugHandler");
				DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, "m_Context");
				DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, "m_CommandBuffer");
				DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, "m_FilteringSettings");
				DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, 100664416);
				DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DebugRenderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, 100664417);
				DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, 100664418);
			}

			// Token: 0x06001C8A RID: 7306 RVA: 0x000753C0 File Offset: 0x000735C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605818, XrefRangeEnd = 605821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugRenderPassEnumerable(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugHandler);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filteringSettings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C8B RID: 7307 RVA: 0x0007543C File Offset: 0x0007363C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605821, XrefRangeEnd = 605827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<DebugRenderSetup> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DebugRenderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DebugRenderSetup>>(intPtr3) : null;
			}

			// Token: 0x06001C8C RID: 7308 RVA: 0x0007547C File Offset: 0x0007367C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C8D RID: 7309 RVA: 0x00010352 File Offset: 0x0000E552
			public DebugRenderPassEnumerable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000754BC File Offset: 0x000736BC
			// (set) Token: 0x06001C8F RID: 7311 RVA: 0x0001035B File Offset: 0x0000E55B
			public unsafe DebugHandler m_DebugHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_DebugHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_DebugHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000754EC File Offset: 0x000736EC
			// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0001037A File Offset: 0x0000E57A
			public unsafe ScriptableRenderContext m_Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_Context);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_Context)) = value;
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00075514 File Offset: 0x00073714
			// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00010395 File Offset: 0x0000E595
			public unsafe CommandBuffer m_CommandBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_CommandBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_CommandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00075544 File Offset: 0x00073744
			// (set) Token: 0x06001C95 RID: 7317 RVA: 0x000103B4 File Offset: 0x0000E5B4
			public unsafe FilteringSettings m_FilteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_FilteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.NativeFieldInfoPtr_m_FilteringSettings)) = value;
				}
			}

			// Token: 0x040014C1 RID: 5313
			private static readonly IntPtr NativeFieldInfoPtr_m_DebugHandler;

			// Token: 0x040014C2 RID: 5314
			private static readonly IntPtr NativeFieldInfoPtr_m_Context;

			// Token: 0x040014C3 RID: 5315
			private static readonly IntPtr NativeFieldInfoPtr_m_CommandBuffer;

			// Token: 0x040014C4 RID: 5316
			private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

			// Token: 0x040014C5 RID: 5317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0;

			// Token: 0x040014C6 RID: 5318
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DebugRenderSetup_0;

			// Token: 0x040014C7 RID: 5319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0200023D RID: 573
			public class Enumerator : Object
			{
				// Token: 0x060024E7 RID: 9447 RVA: 0x0008A07C File Offset: 0x0008827C
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable>.NativeClassPtr, "Enumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_DebugHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_DebugHandler");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_Context");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_CommandBuffer");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_FilteringSettings");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_NumIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_NumIterations");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "m_Index");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, "<Current>k__BackingField");
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DebugRenderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664419);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_DebugRenderSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664420);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664421);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664422);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664423);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664424);
					DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr, 100664425);
				}

				// Token: 0x17000D13 RID: 3347
				// (get) Token: 0x060024E8 RID: 9448 RVA: 0x0008A1C0 File Offset: 0x000883C0
				// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0008A200 File Offset: 0x00088400
				public unsafe virtual DebugRenderSetup Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DebugRenderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugRenderSetup>(intPtr3) : null;
					}
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_set_Current_Private_set_Void_DebugRenderSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17000D14 RID: 3348
				// (get) Token: 0x060024EA RID: 9450 RVA: 0x0008A244 File Offset: 0x00088444
				public unsafe virtual Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060024EB RID: 9451 RVA: 0x0008A284 File Offset: 0x00088484
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605795, XrefRangeEnd = 605798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, FilteringSettings filteringSettings)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugHandler.DebugRenderPassEnumerable.Enumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugHandler);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filteringSettings;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024EC RID: 9452 RVA: 0x0008A300 File Offset: 0x00088500
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605798, XrefRangeEnd = 605815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024ED RID: 9453 RVA: 0x0008A33C File Offset: 0x0008853C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605815, XrefRangeEnd = 605817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024EE RID: 9454 RVA: 0x0008A370 File Offset: 0x00088570
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605817, XrefRangeEnd = 605818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe virtual void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024EF RID: 9455 RVA: 0x00014F92 File Offset: 0x00013192
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D0C RID: 3340
				// (get) Token: 0x060024F0 RID: 9456 RVA: 0x0008A3A4 File Offset: 0x000885A4
				// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00014F9B File Offset: 0x0001319B
				public unsafe DebugHandler m_DebugHandler
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_DebugHandler);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_DebugHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D0D RID: 3341
				// (get) Token: 0x060024F2 RID: 9458 RVA: 0x0008A3D4 File Offset: 0x000885D4
				// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00014FBA File Offset: 0x000131BA
				public unsafe ScriptableRenderContext m_Context
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Context);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Context)) = value;
					}
				}

				// Token: 0x17000D0E RID: 3342
				// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0008A3FC File Offset: 0x000885FC
				// (set) Token: 0x060024F5 RID: 9461 RVA: 0x00014FD5 File Offset: 0x000131D5
				public unsafe CommandBuffer m_CommandBuffer
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_CommandBuffer);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_CommandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000D0F RID: 3343
				// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0008A42C File Offset: 0x0008862C
				// (set) Token: 0x060024F7 RID: 9463 RVA: 0x00014FF4 File Offset: 0x000131F4
				public unsafe FilteringSettings m_FilteringSettings
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_FilteringSettings);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_FilteringSettings)) = value;
					}
				}

				// Token: 0x17000D10 RID: 3344
				// (get) Token: 0x060024F8 RID: 9464 RVA: 0x0008A454 File Offset: 0x00088654
				// (set) Token: 0x060024F9 RID: 9465 RVA: 0x0001500F File Offset: 0x0001320F
				public unsafe int m_NumIterations
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_NumIterations);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_NumIterations)) = value;
					}
				}

				// Token: 0x17000D11 RID: 3345
				// (get) Token: 0x060024FA RID: 9466 RVA: 0x0008A47C File Offset: 0x0008867C
				// (set) Token: 0x060024FB RID: 9467 RVA: 0x0001502A File Offset: 0x0001322A
				public unsafe int m_Index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr_m_Index)) = value;
					}
				}

				// Token: 0x17000D12 RID: 3346
				// (get) Token: 0x060024FC RID: 9468 RVA: 0x0008A4A4 File Offset: 0x000886A4
				// (set) Token: 0x060024FD RID: 9469 RVA: 0x00015045 File Offset: 0x00013245
				public unsafe DebugRenderSetup _Current_k__BackingField
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr__Current_k__BackingField);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugRenderSetup>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugHandler.DebugRenderPassEnumerable.Enumerator.NativeFieldInfoPtr__Current_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400199C RID: 6556
				private static readonly IntPtr NativeFieldInfoPtr_m_DebugHandler;

				// Token: 0x0400199D RID: 6557
				private static readonly IntPtr NativeFieldInfoPtr_m_Context;

				// Token: 0x0400199E RID: 6558
				private static readonly IntPtr NativeFieldInfoPtr_m_CommandBuffer;

				// Token: 0x0400199F RID: 6559
				private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

				// Token: 0x040019A0 RID: 6560
				private static readonly IntPtr NativeFieldInfoPtr_m_NumIterations;

				// Token: 0x040019A1 RID: 6561
				private static readonly IntPtr NativeFieldInfoPtr_m_Index;

				// Token: 0x040019A2 RID: 6562
				private static readonly IntPtr NativeFieldInfoPtr__Current_k__BackingField;

				// Token: 0x040019A3 RID: 6563
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DebugRenderSetup_0;

				// Token: 0x040019A4 RID: 6564
				private static readonly IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_DebugRenderSetup_0;

				// Token: 0x040019A5 RID: 6565
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040019A6 RID: 6566
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_FilteringSettings_0;

				// Token: 0x040019A7 RID: 6567
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040019A8 RID: 6568
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

				// Token: 0x040019A9 RID: 6569
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x0200017C RID: 380
		public sealed class DrawFunction : MulticastDelegate
		{
			// Token: 0x06001C96 RID: 7318 RVA: 0x0007556C File Offset: 0x0007376C
			// Note: this type is marked as 'beforefieldinit'.
			static DrawFunction()
			{
				Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "DrawFunction");
				DebugHandler.DrawFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr, 100664426);
				DebugHandler.DrawFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr, 100664427);
				DebugHandler.DrawFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr, 100664428);
				DebugHandler.DrawFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr, 100664429);
			}

			// Token: 0x06001C97 RID: 7319 RVA: 0x000755E0 File Offset: 0x000737E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 605830, RefRangeEnd = 605832, XrefRangeStart = 605827, XrefRangeEnd = 605830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrawFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugHandler.DrawFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DrawFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C98 RID: 7320 RVA: 0x0007563C File Offset: 0x0007383C
			[CallerCount(0)]
			public unsafe void Invoke(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref context;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderStateBlock;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DrawFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C99 RID: 7321 RVA: 0x000756BC File Offset: 0x000738BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605832, XrefRangeEnd = 605848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ScriptableRenderContext context, ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref context;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderStateBlock;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DrawFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001C9A RID: 7322 RVA: 0x00075770 File Offset: 0x00073970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605848, XrefRangeEnd = 605849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref RenderingData renderingData, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &drawingSettings;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filteringSettings;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &renderStateBlock;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugHandler.DrawFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9B RID: 7323 RVA: 0x000103CF File Offset: 0x0000E5CF
			public DrawFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040014C8 RID: 5320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040014C9 RID: 5321
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

			// Token: 0x040014CA RID: 5322
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ScriptableRenderContext_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_AsyncCallback_Object_0;

			// Token: 0x040014CB RID: 5323
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_RenderingData_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_IAsyncResult_0;
		}
	}
}
