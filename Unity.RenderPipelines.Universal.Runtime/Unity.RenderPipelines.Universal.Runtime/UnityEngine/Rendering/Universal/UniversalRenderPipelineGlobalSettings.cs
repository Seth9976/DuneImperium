using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000105 RID: 261
	public class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings
	{
		// Token: 0x060015C5 RID: 5573 RVA: 0x0005DAEC File Offset: 0x0005BCEC
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalRenderPipelineGlobalSettings()
		{
			Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderPipelineGlobalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr);
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_k_AssetVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "k_AssetVersion");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_cachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "cachedInstance");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_defaultAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "defaultAssetName");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_RenderingLayerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_RenderingLayerNames");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_PrefixedRenderingLayerNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_PrefixedRenderingLayerNames");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ValidRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ValidRenderingLayers");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName0");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName1");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName2");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName3");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName4");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName5");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName6");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "lightLayerName7");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripDebugVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripDebugVariants");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripUnusedPostProcessingVariants");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripUnusedVariants");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedLODCrossFadeVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripUnusedLODCrossFadeVariants");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_StripScreenCoordOverrideVariants");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_supportRuntimeDebugDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "supportRuntimeDebugDisplay");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ShaderVariantLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ShaderVariantLogLevel");
			UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ExportShaderVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, "m_ExportShaderVariants");
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665805);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665806);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_instance_Public_Static_get_UniversalRenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665807);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_UpdateGraphicsSettings_Internal_Static_Void_UniversalRenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665808);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665809);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_renderingLayerNames_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665810);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedRenderingLayerNames_Private_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665811);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665812);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665813);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_validRenderingLayers_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665814);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_UpdateRenderingLayerNames_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665815);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665816);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665817);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665818);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripDebugVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665819);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripDebugVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665820);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedPostProcessingVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665821);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedPostProcessingVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665822);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665823);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665824);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665825);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665826);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripScreenCoordOverrideVariants_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665827);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripScreenCoordOverrideVariants_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665828);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Virtual_Final_New_get_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665829);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Virtual_Final_New_set_Void_ShaderVariantLogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665830);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_exportShaderVariants_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665831);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_exportShaderVariants_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665832);
			UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr, 100665833);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0005DF18 File Offset: 0x0005C118
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0005DF4C File Offset: 0x0005C14C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0005DF80 File Offset: 0x0005C180
		public unsafe static UniversalRenderPipelineGlobalSettings instance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 622779, RefRangeEnd = 622789, XrefRangeStart = 622756, XrefRangeEnd = 622779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_instance_Public_Static_get_UniversalRenderPipelineGlobalSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineGlobalSettings>(intPtr3) : null;
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0005DFB4 File Offset: 0x0005C1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622789, XrefRangeEnd = 622812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_UpdateGraphicsSettings_Internal_Static_Void_UniversalRenderPipelineGlobalSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0005DFEC File Offset: 0x0005C1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622812, XrefRangeEnd = 622813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0005E020 File Offset: 0x0005C220
		public unsafe Il2CppStringArray renderingLayerNames
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 622814, RefRangeEnd = 622817, XrefRangeStart = 622813, XrefRangeEnd = 622814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_renderingLayerNames_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x0005E060 File Offset: 0x0005C260
		public unsafe Il2CppStringArray prefixedRenderingLayerNames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 622818, RefRangeEnd = 622819, XrefRangeStart = 622817, XrefRangeEnd = 622818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedRenderingLayerNames_Private_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x0005E0A0 File Offset: 0x0005C2A0
		public unsafe Il2CppStringArray renderingLayerMaskNames
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 622814, RefRangeEnd = 622817, XrefRangeStart = 622814, XrefRangeEnd = 622817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x0005E0E0 File Offset: 0x0005C2E0
		public unsafe Il2CppStringArray prefixedRenderingLayerMaskNames
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 622818, RefRangeEnd = 622819, XrefRangeStart = 622818, XrefRangeEnd = 622819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0005E120 File Offset: 0x0005C320
		public unsafe uint validRenderingLayers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622819, XrefRangeEnd = 622820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_validRenderingLayers_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0005E15C File Offset: 0x0005C35C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 622847, RefRangeEnd = 622853, XrefRangeStart = 622820, XrefRangeEnd = 622847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRenderingLayerNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_UpdateRenderingLayerNames_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0005E190 File Offset: 0x0005C390
		public unsafe Il2CppStringArray prefixedLightLayerNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622853, XrefRangeEnd = 622856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
		public unsafe Il2CppStringArray lightLayerNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622856, XrefRangeEnd = 622859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x0005E210 File Offset: 0x0005C410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622859, XrefRangeEnd = 622868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRenderingLayerNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x0005E244 File Offset: 0x0005C444
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0005E280 File Offset: 0x0005C480
		public unsafe bool stripDebugVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripDebugVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripDebugVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0005E2C0 File Offset: 0x0005C4C0
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0005E2FC File Offset: 0x0005C4FC
		public unsafe bool stripUnusedPostProcessingVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedPostProcessingVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedPostProcessingVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0005E33C File Offset: 0x0005C53C
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0005E378 File Offset: 0x0005C578
		public unsafe bool stripUnusedVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0005E3B8 File Offset: 0x0005C5B8
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0005E3F4 File Offset: 0x0005C5F4
		public unsafe bool stripUnusedLODCrossFadeVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x0005E434 File Offset: 0x0005C634
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0005E470 File Offset: 0x0005C670
		public unsafe bool stripScreenCoordOverrideVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_stripScreenCoordOverrideVariants_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_stripScreenCoordOverrideVariants_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0005E4B0 File Offset: 0x0005C6B0
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0005E4EC File Offset: 0x0005C6EC
		public unsafe virtual ShaderVariantLogLevel shaderVariantLogLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Virtual_Final_New_get_ShaderVariantLogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Virtual_Final_New_set_Void_ShaderVariantLogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0005E52C File Offset: 0x0005C72C
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0005E568 File Offset: 0x0005C768
		public unsafe virtual bool exportShaderVariants
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_get_exportShaderVariants_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr_set_exportShaderVariants_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622868, XrefRangeEnd = 622878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalRenderPipelineGlobalSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderPipelineGlobalSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalRenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		public UniversalRenderPipelineGlobalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0005E5E4 File Offset: 0x0005C7E4
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000CB85 File Offset: 0x0000AD85
		public unsafe int k_AssetVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_k_AssetVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_k_AssetVersion)) = value;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x0005E60C File Offset: 0x0005C80C
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		public unsafe static UniversalRenderPipelineGlobalSettings cachedInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_cachedInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalRenderPipelineGlobalSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_cachedInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x0005E634 File Offset: 0x0005C834
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0000CBB2 File Offset: 0x0000ADB2
		public unsafe static string defaultAssetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_defaultAssetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_defaultAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x0005E654 File Offset: 0x0005C854
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		public unsafe Il2CppStringArray m_RenderingLayerNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_RenderingLayerNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_RenderingLayerNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x0005E684 File Offset: 0x0005C884
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x0000CBE3 File Offset: 0x0000ADE3
		public unsafe Il2CppStringArray m_PrefixedRenderingLayerNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_PrefixedRenderingLayerNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_PrefixedRenderingLayerNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x0005E6B4 File Offset: 0x0005C8B4
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0000CC02 File Offset: 0x0000AE02
		public unsafe uint m_ValidRenderingLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ValidRenderingLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ValidRenderingLayers)) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0005E6DC File Offset: 0x0005C8DC
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x0000CC1D File Offset: 0x0000AE1D
		public unsafe string lightLayerName0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName0);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName0), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x0005E704 File Offset: 0x0005C904
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		public unsafe string lightLayerName1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName1);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName1), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x0005E72C File Offset: 0x0005C92C
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000CC5B File Offset: 0x0000AE5B
		public unsafe string lightLayerName2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0005E754 File Offset: 0x0005C954
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000CC7A File Offset: 0x0000AE7A
		public unsafe string lightLayerName3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0005E77C File Offset: 0x0005C97C
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000CC99 File Offset: 0x0000AE99
		public unsafe string lightLayerName4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName4);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName4), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		public unsafe string lightLayerName5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName5);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName5), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x0005E7CC File Offset: 0x0005C9CC
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000CCD7 File Offset: 0x0000AED7
		public unsafe string lightLayerName6
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName6);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName6), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0005E7F4 File Offset: 0x0005C9F4
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000CCF6 File Offset: 0x0000AEF6
		public unsafe string lightLayerName7
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName7);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_lightLayerName7), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x0005E81C File Offset: 0x0005CA1C
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000CD15 File Offset: 0x0000AF15
		public unsafe bool m_StripDebugVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripDebugVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripDebugVariants)) = value;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0005E844 File Offset: 0x0005CA44
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000CD30 File Offset: 0x0000AF30
		public unsafe bool m_StripUnusedPostProcessingVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants)) = value;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0005E86C File Offset: 0x0005CA6C
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000CD4B File Offset: 0x0000AF4B
		public unsafe bool m_StripUnusedVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedVariants)) = value;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0005E894 File Offset: 0x0005CA94
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x0000CD66 File Offset: 0x0000AF66
		public unsafe bool m_StripUnusedLODCrossFadeVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedLODCrossFadeVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripUnusedLODCrossFadeVariants)) = value;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0005E8BC File Offset: 0x0005CABC
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x0000CD81 File Offset: 0x0000AF81
		public unsafe bool m_StripScreenCoordOverrideVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants)) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x0005E8E4 File Offset: 0x0005CAE4
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public unsafe bool supportRuntimeDebugDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_supportRuntimeDebugDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_supportRuntimeDebugDisplay)) = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0005E90C File Offset: 0x0005CB0C
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000CDB7 File Offset: 0x0000AFB7
		public unsafe ShaderVariantLogLevel m_ShaderVariantLogLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ShaderVariantLogLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ShaderVariantLogLevel)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x0005E934 File Offset: 0x0005CB34
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x0000CDD2 File Offset: 0x0000AFD2
		public unsafe bool m_ExportShaderVariants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ExportShaderVariants);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalRenderPipelineGlobalSettings.NativeFieldInfoPtr_m_ExportShaderVariants)) = value;
			}
		}

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr_k_AssetVersion;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr_cachedInstance;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr_defaultAssetName;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderingLayerNames;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeFieldInfoPtr_m_PrefixedRenderingLayerNames;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidRenderingLayers;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName1;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName2;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName3;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName4;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName5;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName6;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr_lightLayerName7;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr_m_StripDebugVariants;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr_m_StripUnusedPostProcessingVariants;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_m_StripUnusedVariants;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_m_StripUnusedLODCrossFadeVariants;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr_m_StripScreenCoordOverrideVariants;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr_supportRuntimeDebugDisplay;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderVariantLogLevel;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr_m_ExportShaderVariants;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_UniversalRenderPipelineGlobalSettings_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGraphicsSettings_Internal_Static_Void_UniversalRenderPipelineGlobalSettings_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerNames_Private_get_Il2CppStringArray_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerNames_Private_get_Il2CppStringArray_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_get_validRenderingLayers_Public_get_UInt32_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRenderingLayerNames_Internal_Void_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_get_prefixedLightLayerNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_get_lightLayerNames_Public_get_Il2CppStringArray_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_ResetRenderingLayerNames_Internal_Void_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_get_stripDebugVariants_Public_get_Boolean_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_set_stripDebugVariants_Public_set_Void_Boolean_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_get_stripUnusedPostProcessingVariants_Public_get_Boolean_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_set_stripUnusedPostProcessingVariants_Public_set_Void_Boolean_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_get_stripUnusedVariants_Public_get_Boolean_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_set_stripUnusedVariants_Public_set_Void_Boolean_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_get_stripUnusedLODCrossFadeVariants_Public_get_Boolean_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_set_stripUnusedLODCrossFadeVariants_Public_set_Void_Boolean_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_get_stripScreenCoordOverrideVariants_Public_get_Boolean_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_set_stripScreenCoordOverrideVariants_Public_set_Void_Boolean_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_get_shaderVariantLogLevel_Public_Virtual_Final_New_get_ShaderVariantLogLevel_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_set_shaderVariantLogLevel_Public_Virtual_Final_New_set_Void_ShaderVariantLogLevel_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_get_exportShaderVariants_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_set_exportShaderVariants_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
