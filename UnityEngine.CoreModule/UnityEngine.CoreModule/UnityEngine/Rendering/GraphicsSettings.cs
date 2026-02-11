using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000213 RID: 531
	public sealed class GraphicsSettings : Object
	{
		// Token: 0x0600221C RID: 8732 RVA: 0x00095710 File Offset: 0x00093910
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667888);
			GraphicsSettings.NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667889);
			GraphicsSettings.NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667890);
			GraphicsSettings.NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667891);
			GraphicsSettings.NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667892);
			GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667893);
			GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667894);
			GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667895);
			GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667896);
			GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667897);
			GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667898);
			GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667899);
			GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667900);
			GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667901);
			GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667902);
			GraphicsSettings.get_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
			GraphicsSettings.set_transparencySortModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
			GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
			GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
			GraphicsSettings.get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
			GraphicsSettings.get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
			GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
			GraphicsSettings.get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
			GraphicsSettings.set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
			GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
			GraphicsSettings.get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
			GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightProbeOutsideHullStrategy");
			GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightProbeOutsideHullStrategy");
			GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline");
			GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate>("UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines");
			GraphicsSettings.GetGraphicsSettingsDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetGraphicsSettingsDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings");
			GraphicsSettings.SetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
			GraphicsSettings.GetShaderModeDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::GetShaderMode");
			GraphicsSettings.SetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.SetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader");
			GraphicsSettings.GetCustomShaderDelegateField = IL2CPP.ResolveICall<GraphicsSettings.GetCustomShaderDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader");
			GraphicsSettings.get_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeLightCulling");
			GraphicsSettings.set_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeLightCulling");
			GraphicsSettings.get_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeShadowCulling");
			GraphicsSettings.set_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeShadowCulling");
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsSettings.set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x00095A10 File Offset: 0x00093C10
		// (set) Token: 0x0600221E RID: 8734 RVA: 0x00095A40 File Offset: 0x00093C40
		public unsafe static bool lightsUseLinearIntensity
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 681834, RefRangeEnd = 681841, XrefRangeStart = 681832, XrefRangeEnd = 681834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681843, RefRangeEnd = 681844, XrefRangeStart = 681841, XrefRangeEnd = 681843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0000CF95 File Offset: 0x0000B195
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00095A74 File Offset: 0x00093C74
		public unsafe static bool lightsUseColorTemperature
		{
			get
			{
				return GraphicsSettings.get_lightsUseColorTemperatureDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681846, RefRangeEnd = 681847, XrefRangeStart = 681844, XrefRangeEnd = 681846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
		// (set) Token: 0x06002220 RID: 8736 RVA: 0x00095AA8 File Offset: 0x00093CA8
		public unsafe static uint defaultRenderingLayerMask
		{
			get
			{
				return GraphicsSettings.get_defaultRenderingLayerMaskDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681849, RefRangeEnd = 681850, XrefRangeStart = 681847, XrefRangeEnd = 681849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x0000CFAD File Offset: 0x0000B1AD
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00095ADC File Offset: 0x00093CDC
		public unsafe static bool useScriptableRenderPipelineBatching
		{
			get
			{
				return GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegateField();
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 681852, RefRangeEnd = 681853, XrefRangeStart = 681850, XrefRangeEnd = 681852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00095B10 File Offset: 0x00093D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681853, XrefRangeEnd = 681855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defineHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00095B5C File Offset: 0x00093D5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 681861, RefRangeEnd = 681866, XrefRangeStart = 681855, XrefRangeEnd = 681861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasShaderDefine(BuiltinShaderDefine defineHash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defineHash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00095B9C File Offset: 0x00093D9C
		public unsafe static ScriptableObject INTERNAL_currentRenderPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681866, XrefRangeEnd = 681868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x00095BD0 File Offset: 0x00093DD0
		public unsafe static RenderPipelineAsset currentRenderPipeline
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 681871, RefRangeEnd = 681876, XrefRangeStart = 681868, XrefRangeEnd = 681871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr3) : null;
			}
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00095C04 File Offset: 0x00093E04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681883, RefRangeEnd = 681884, XrefRangeStart = 681876, XrefRangeEnd = 681883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00095C3C File Offset: 0x00093E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681886, RefRangeEnd = 681887, XrefRangeStart = 681884, XrefRangeEnd = 681886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRenderPipeline(string renderpipelineName, Object settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00095C84 File Offset: 0x00093E84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681894, RefRangeEnd = 681895, XrefRangeStart = 681887, XrefRangeEnd = 681894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_UnregisterRenderPipelineSettings_Public_Static_Void_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00095CAC File Offset: 0x00093EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681897, RefRangeEnd = 681898, XrefRangeStart = 681895, XrefRangeEnd = 681897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRenderPipeline(string renderpipelineName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x00095CE4 File Offset: 0x00093EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 681905, RefRangeEnd = 681907, XrefRangeStart = 681898, XrefRangeEnd = 681905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr3) : null;
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00095D18 File Offset: 0x00093F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681909, RefRangeEnd = 681910, XrefRangeStart = 681907, XrefRangeEnd = 681909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetSettingsForRenderPipeline(string renderpipelineName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0000CF51 File Offset: 0x0000B151
		public GraphicsSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x0000CF5A File Offset: 0x0000B15A
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x0000CF66 File Offset: 0x0000B166
		public static TransparencySortMode transparencySortMode
		{
			get
			{
				return GraphicsSettings.get_transparencySortModeDelegateField();
			}
			set
			{
				GraphicsSettings.set_transparencySortModeDelegateField(value);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00095D5C File Offset: 0x00093F5C
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x0000CF73 File Offset: 0x0000B173
		public static Vector3 transparencySortAxis
		{
			get
			{
				Vector3 vector;
				GraphicsSettings.get_transparencySortAxis_Injected(out vector);
				return vector;
			}
			set
			{
				GraphicsSettings.set_transparencySortAxis_Injected(ref value);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x0000CF7C File Offset: 0x0000B17C
		// (set) Token: 0x06002232 RID: 8754 RVA: 0x0000CF88 File Offset: 0x0000B188
		public static bool realtimeDirectRectangularAreaLights
		{
			get
			{
				return GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegateField();
			}
			set
			{
				GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegateField(value);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0000CFB9 File Offset: 0x0000B1B9
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x0000CFC5 File Offset: 0x0000B1C5
		public static bool logWhenShaderIsCompiled
		{
			get
			{
				return GraphicsSettings.get_logWhenShaderIsCompiledDelegateField();
			}
			set
			{
				GraphicsSettings.set_logWhenShaderIsCompiledDelegateField(value);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0000CFD2 File Offset: 0x0000B1D2
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x0000CFDE File Offset: 0x0000B1DE
		public static bool disableBuiltinCustomRenderTextureUpdate
		{
			get
			{
				return GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegateField();
			}
			set
			{
				GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0000CFEB File Offset: 0x0000B1EB
		public static VideoShadersIncludeMode videoShadersIncludeMode
		{
			get
			{
				return GraphicsSettings.get_videoShadersIncludeModeDelegateField();
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0000CFF7 File Offset: 0x0000B1F7
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x0000D003 File Offset: 0x0000B203
		public static LightProbeOutsideHullStrategy lightProbeOutsideHullStrategy
		{
			get
			{
				return GraphicsSettings.get_lightProbeOutsideHullStrategyDelegateField();
			}
			set
			{
				GraphicsSettings.set_lightProbeOutsideHullStrategyDelegateField(value);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x00095D74 File Offset: 0x00093F74
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x0000D010 File Offset: 0x0000B210
		public static RenderPipelineAsset renderPipelineAsset
		{
			get
			{
				return GraphicsSettings.defaultRenderPipeline;
			}
			set
			{
				GraphicsSettings.defaultRenderPipeline = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x00095D8C File Offset: 0x00093F8C
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x0000D01A File Offset: 0x0000B21A
		public static ScriptableObject INTERNAL_defaultRenderPipeline
		{
			get
			{
				IntPtr intPtr = GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegateField(IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00095DB4 File Offset: 0x00093FB4
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x0000D02C File Offset: 0x0000B22C
		public static RenderPipelineAsset defaultRenderPipeline
		{
			get
			{
				return GraphicsSettings.INTERNAL_defaultRenderPipeline.TryCast<RenderPipelineAsset>();
			}
			set
			{
				GraphicsSettings.INTERNAL_defaultRenderPipeline = value;
			}
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00095DD0 File Offset: 0x00093FD0
		public static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
		{
			IntPtr intPtr = GraphicsSettings.GetAllConfiguredRenderPipelinesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr2) : null;
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0000D036 File Offset: 0x0000B236
		public static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00095DF8 File Offset: 0x00093FF8
		public static Object GetGraphicsSettings()
		{
			IntPtr intPtr = GraphicsSettings.GetGraphicsSettingsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0000D043 File Offset: 0x0000B243
		public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
		{
			GraphicsSettings.SetShaderModeDelegateField(type, mode);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0000D051 File Offset: 0x0000B251
		public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
		{
			return GraphicsSettings.GetShaderModeDelegateField(type);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0000D05E File Offset: 0x0000B25E
		public static void SetCustomShader(BuiltinShaderType type, Shader shader)
		{
			GraphicsSettings.SetCustomShaderDelegateField(type, IL2CPP.Il2CppObjectBaseToPtr(shader));
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00095E20 File Offset: 0x00094020
		public static Shader GetCustomShader(BuiltinShaderType type)
		{
			IntPtr intPtr = GraphicsSettings.GetCustomShaderDelegateField(type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x0000D071 File Offset: 0x0000B271
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x0000D07D File Offset: 0x0000B27D
		public static bool cameraRelativeLightCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeLightCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeLightCullingDelegateField(value);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x0000D08A File Offset: 0x0000B28A
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x0000D096 File Offset: 0x0000B296
		public static bool cameraRelativeShadowCulling
		{
			get
			{
				return GraphicsSettings.get_cameraRelativeShadowCullingDelegateField();
			}
			set
			{
				GraphicsSettings.set_cameraRelativeShadowCullingDelegateField(value);
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0000D0A3 File Offset: 0x0000B2A3
		public static void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			GraphicsSettings.get_transparencySortAxis_InjectedDelegateField(out ret);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public static void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			GraphicsSettings.set_transparencySortAxis_InjectedDelegateField(ref value);
		}

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultRenderingLayerMask_Public_Static_set_Void_UInt32_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRenderPipeline_Private_Static_Void_String_Object_0;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRenderPipeline_Private_Static_Void_String_0;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Private_Static_Object_String_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly GraphicsSettings.get_transparencySortModeDelegate get_transparencySortModeDelegateField;

		// Token: 0x04001EA0 RID: 7840
		private static readonly GraphicsSettings.set_transparencySortModeDelegate set_transparencySortModeDelegateField;

		// Token: 0x04001EA1 RID: 7841
		private static readonly GraphicsSettings.get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001EA2 RID: 7842
		private static readonly GraphicsSettings.set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;

		// Token: 0x04001EA3 RID: 7843
		private static readonly GraphicsSettings.get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;

		// Token: 0x04001EA4 RID: 7844
		private static readonly GraphicsSettings.get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;

		// Token: 0x04001EA5 RID: 7845
		private static readonly GraphicsSettings.get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;

		// Token: 0x04001EA6 RID: 7846
		private static readonly GraphicsSettings.get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;

		// Token: 0x04001EA7 RID: 7847
		private static readonly GraphicsSettings.set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;

		// Token: 0x04001EA8 RID: 7848
		private static readonly GraphicsSettings.get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x04001EA9 RID: 7849
		private static readonly GraphicsSettings.set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;

		// Token: 0x04001EAA RID: 7850
		private static readonly GraphicsSettings.get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;

		// Token: 0x04001EAB RID: 7851
		private static readonly GraphicsSettings.get_lightProbeOutsideHullStrategyDelegate get_lightProbeOutsideHullStrategyDelegateField;

		// Token: 0x04001EAC RID: 7852
		private static readonly GraphicsSettings.set_lightProbeOutsideHullStrategyDelegate set_lightProbeOutsideHullStrategyDelegateField;

		// Token: 0x04001EAD RID: 7853
		private static readonly GraphicsSettings.get_INTERNAL_defaultRenderPipelineDelegate get_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x04001EAE RID: 7854
		private static readonly GraphicsSettings.set_INTERNAL_defaultRenderPipelineDelegate set_INTERNAL_defaultRenderPipelineDelegateField;

		// Token: 0x04001EAF RID: 7855
		private static readonly GraphicsSettings.GetAllConfiguredRenderPipelinesDelegate GetAllConfiguredRenderPipelinesDelegateField;

		// Token: 0x04001EB0 RID: 7856
		private static readonly GraphicsSettings.GetGraphicsSettingsDelegate GetGraphicsSettingsDelegateField;

		// Token: 0x04001EB1 RID: 7857
		private static readonly GraphicsSettings.SetShaderModeDelegate SetShaderModeDelegateField;

		// Token: 0x04001EB2 RID: 7858
		private static readonly GraphicsSettings.GetShaderModeDelegate GetShaderModeDelegateField;

		// Token: 0x04001EB3 RID: 7859
		private static readonly GraphicsSettings.SetCustomShaderDelegate SetCustomShaderDelegateField;

		// Token: 0x04001EB4 RID: 7860
		private static readonly GraphicsSettings.GetCustomShaderDelegate GetCustomShaderDelegateField;

		// Token: 0x04001EB5 RID: 7861
		private static readonly GraphicsSettings.get_cameraRelativeLightCullingDelegate get_cameraRelativeLightCullingDelegateField;

		// Token: 0x04001EB6 RID: 7862
		private static readonly GraphicsSettings.set_cameraRelativeLightCullingDelegate set_cameraRelativeLightCullingDelegateField;

		// Token: 0x04001EB7 RID: 7863
		private static readonly GraphicsSettings.get_cameraRelativeShadowCullingDelegate get_cameraRelativeShadowCullingDelegateField;

		// Token: 0x04001EB8 RID: 7864
		private static readonly GraphicsSettings.set_cameraRelativeShadowCullingDelegate set_cameraRelativeShadowCullingDelegateField;

		// Token: 0x04001EB9 RID: 7865
		private static readonly GraphicsSettings.get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

		// Token: 0x04001EBA RID: 7866
		private static readonly GraphicsSettings.set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

		// Token: 0x0200093A RID: 2362
		private sealed class MethodInfoStoreGeneric_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0<T>
		{
			// Token: 0x04002D1D RID: 11549
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_RegisterRenderPipelineSettings_Public_Static_Void_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200093B RID: 2363
		private sealed class MethodInfoStoreGeneric_UnregisterRenderPipelineSettings_Public_Static_Void_0<T>
		{
			// Token: 0x04002D1E RID: 11550
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_UnregisterRenderPipelineSettings_Public_Static_Void_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200093C RID: 2364
		private sealed class MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>
		{
			// Token: 0x04002D1F RID: 11551
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GraphicsSettings.NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200093D RID: 2365
		// (Invoke) Token: 0x06003B94 RID: 15252
		private delegate TransparencySortMode get_transparencySortModeDelegate();

		// Token: 0x0200093E RID: 2366
		// (Invoke) Token: 0x06003B96 RID: 15254
		private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

		// Token: 0x0200093F RID: 2367
		// (Invoke) Token: 0x06003B98 RID: 15256
		private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

		// Token: 0x02000940 RID: 2368
		// (Invoke) Token: 0x06003B9A RID: 15258
		private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

		// Token: 0x02000941 RID: 2369
		// (Invoke) Token: 0x06003B9C RID: 15260
		private delegate bool get_lightsUseColorTemperatureDelegate();

		// Token: 0x02000942 RID: 2370
		// (Invoke) Token: 0x06003B9E RID: 15262
		private delegate uint get_defaultRenderingLayerMaskDelegate();

		// Token: 0x02000943 RID: 2371
		// (Invoke) Token: 0x06003BA0 RID: 15264
		private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

		// Token: 0x02000944 RID: 2372
		// (Invoke) Token: 0x06003BA2 RID: 15266
		private delegate bool get_logWhenShaderIsCompiledDelegate();

		// Token: 0x02000945 RID: 2373
		// (Invoke) Token: 0x06003BA4 RID: 15268
		private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

		// Token: 0x02000946 RID: 2374
		// (Invoke) Token: 0x06003BA6 RID: 15270
		private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

		// Token: 0x02000947 RID: 2375
		// (Invoke) Token: 0x06003BA8 RID: 15272
		private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

		// Token: 0x02000948 RID: 2376
		// (Invoke) Token: 0x06003BAA RID: 15274
		private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

		// Token: 0x02000949 RID: 2377
		// (Invoke) Token: 0x06003BAC RID: 15276
		private delegate LightProbeOutsideHullStrategy get_lightProbeOutsideHullStrategyDelegate();

		// Token: 0x0200094A RID: 2378
		// (Invoke) Token: 0x06003BAE RID: 15278
		private delegate void set_lightProbeOutsideHullStrategyDelegate(LightProbeOutsideHullStrategy value);

		// Token: 0x0200094B RID: 2379
		// (Invoke) Token: 0x06003BB0 RID: 15280
		private delegate IntPtr get_INTERNAL_defaultRenderPipelineDelegate();

		// Token: 0x0200094C RID: 2380
		// (Invoke) Token: 0x06003BB2 RID: 15282
		private delegate void set_INTERNAL_defaultRenderPipelineDelegate(IntPtr value);

		// Token: 0x0200094D RID: 2381
		// (Invoke) Token: 0x06003BB4 RID: 15284
		private delegate IntPtr GetAllConfiguredRenderPipelinesDelegate();

		// Token: 0x0200094E RID: 2382
		// (Invoke) Token: 0x06003BB6 RID: 15286
		private delegate IntPtr GetGraphicsSettingsDelegate();

		// Token: 0x0200094F RID: 2383
		// (Invoke) Token: 0x06003BB8 RID: 15288
		private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

		// Token: 0x02000950 RID: 2384
		// (Invoke) Token: 0x06003BBA RID: 15290
		private delegate BuiltinShaderMode GetShaderModeDelegate(BuiltinShaderType type);

		// Token: 0x02000951 RID: 2385
		// (Invoke) Token: 0x06003BBC RID: 15292
		private delegate void SetCustomShaderDelegate(BuiltinShaderType type, IntPtr shader);

		// Token: 0x02000952 RID: 2386
		// (Invoke) Token: 0x06003BBE RID: 15294
		private delegate IntPtr GetCustomShaderDelegate(BuiltinShaderType type);

		// Token: 0x02000953 RID: 2387
		// (Invoke) Token: 0x06003BC0 RID: 15296
		private delegate bool get_cameraRelativeLightCullingDelegate();

		// Token: 0x02000954 RID: 2388
		// (Invoke) Token: 0x06003BC2 RID: 15298
		private delegate void set_cameraRelativeLightCullingDelegate(bool value);

		// Token: 0x02000955 RID: 2389
		// (Invoke) Token: 0x06003BC4 RID: 15300
		private delegate bool get_cameraRelativeShadowCullingDelegate();

		// Token: 0x02000956 RID: 2390
		// (Invoke) Token: 0x06003BC6 RID: 15302
		private delegate void set_cameraRelativeShadowCullingDelegate(bool value);

		// Token: 0x02000957 RID: 2391
		// (Invoke) Token: 0x06003BC8 RID: 15304
		private delegate void get_transparencySortAxis_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000958 RID: 2392
		// (Invoke) Token: 0x06003BCA RID: 15306
		private delegate void set_transparencySortAxis_InjectedDelegate(IntPtr value);
	}
}
