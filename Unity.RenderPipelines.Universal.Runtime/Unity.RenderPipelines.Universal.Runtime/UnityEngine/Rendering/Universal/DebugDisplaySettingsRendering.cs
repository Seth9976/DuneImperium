using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005A RID: 90
	public class DebugDisplaySettingsRendering : Object
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		// Note: this type is marked as 'beforefieldinit'.
		static DebugDisplaySettingsRendering()
		{
			Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugDisplaySettingsRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr);
			DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_WireframeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "m_WireframeMode");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_Overdraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "m_Overdraw");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_OverdrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "m_OverdrawMode");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__maxOverdrawCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<maxOverdrawCount>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<fullScreenDebugMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugModeOutputSizeScreenPercent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<fullScreenDebugModeOutputSizeScreenPercent>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__sceneOverrideMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<sceneOverrideMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__mipInfoMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<mipInfoMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__postProcessingDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<postProcessingDebugMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableMsaa_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<enableMsaa>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableHDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<enableHDR>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__taaDebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<taaDebugMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<validationMode>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationChannels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<validationChannels>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<validationRangeMin>k__BackingField");
			DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMax_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "<validationRangeMax>k__BackingField");
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_wireframeMode_Public_get_DebugWireframeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664253);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_wireframeMode_Public_set_Void_DebugWireframeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664254);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_overdraw_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664255);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_overdraw_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664256);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_overdrawMode_Public_get_DebugOverdrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664257);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_overdrawMode_Public_set_Void_DebugOverdrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664258);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_maxOverdrawCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664259);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_maxOverdrawCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664260);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_UpdateDebugSceneOverrideMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664261);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_fullScreenDebugMode_Public_get_DebugFullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664262);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_fullScreenDebugMode_Public_set_Void_DebugFullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664263);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_fullScreenDebugModeOutputSizeScreenPercent_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664264);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_fullScreenDebugModeOutputSizeScreenPercent_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664265);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_sceneOverrideMode_Internal_get_DebugSceneOverrideMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664266);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_sceneOverrideMode_Internal_set_Void_DebugSceneOverrideMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664267);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_mipInfoMode_Internal_get_DebugMipInfoMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664268);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_mipInfoMode_Internal_set_Void_DebugMipInfoMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664269);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_postProcessingDebugMode_Public_get_DebugPostProcessingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664270);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_postProcessingDebugMode_Public_set_Void_DebugPostProcessingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664271);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_enableMsaa_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664272);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_enableMsaa_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664273);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_enableHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664274);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_enableHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664275);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_taaDebugMode_Public_get_TaaDebugMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664276);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_taaDebugMode_Public_set_Void_TaaDebugMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664277);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationMode_Public_get_DebugValidationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664278);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationMode_Public_set_Void_DebugValidationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664279);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationChannels_Public_get_PixelValidationChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664280);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationChannels_Public_set_Void_PixelValidationChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664281);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationRangeMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664282);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationRangeMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664283);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationRangeMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664284);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationRangeMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664285);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664286);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664287);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664288);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664289);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664290);
			DebugDisplaySettingsRendering.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, 100664291);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0002F534 File Offset: 0x0002D734
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0002F570 File Offset: 0x0002D770
		public unsafe DebugWireframeMode wireframeMode
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_wireframeMode_Public_get_DebugWireframeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_wireframeMode_Public_set_Void_DebugWireframeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0002F5EC File Offset: 0x0002D7EC
		public unsafe bool overdraw
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_overdraw_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_overdraw_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0002F62C File Offset: 0x0002D82C
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x0002F668 File Offset: 0x0002D868
		public unsafe DebugOverdrawMode overdrawMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_overdrawMode_Public_get_DebugOverdrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_overdrawMode_Public_set_Void_DebugOverdrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0002F6E4 File Offset: 0x0002D8E4
		public unsafe int maxOverdrawCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_maxOverdrawCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_maxOverdrawCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0002F724 File Offset: 0x0002D924
		[CallerCount(0)]
		public unsafe void UpdateDebugSceneOverrideMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_UpdateDebugSceneOverrideMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0002F758 File Offset: 0x0002D958
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0002F794 File Offset: 0x0002D994
		public unsafe DebugFullScreenMode fullScreenDebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_fullScreenDebugMode_Public_get_DebugFullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_fullScreenDebugMode_Public_set_Void_DebugFullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0002F7D4 File Offset: 0x0002D9D4
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0002F810 File Offset: 0x0002DA10
		public unsafe int fullScreenDebugModeOutputSizeScreenPercent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_fullScreenDebugModeOutputSizeScreenPercent_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_fullScreenDebugModeOutputSizeScreenPercent_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0002F850 File Offset: 0x0002DA50
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0002F88C File Offset: 0x0002DA8C
		public unsafe DebugSceneOverrideMode sceneOverrideMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_sceneOverrideMode_Internal_get_DebugSceneOverrideMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_sceneOverrideMode_Internal_set_Void_DebugSceneOverrideMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x0002F8CC File Offset: 0x0002DACC
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0002F908 File Offset: 0x0002DB08
		public unsafe DebugMipInfoMode mipInfoMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_mipInfoMode_Internal_get_DebugMipInfoMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_mipInfoMode_Internal_set_Void_DebugMipInfoMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0002F948 File Offset: 0x0002DB48
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0002F984 File Offset: 0x0002DB84
		public unsafe DebugPostProcessingMode postProcessingDebugMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_postProcessingDebugMode_Public_get_DebugPostProcessingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_postProcessingDebugMode_Public_set_Void_DebugPostProcessingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0002FA00 File Offset: 0x0002DC00
		public unsafe bool enableMsaa
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_enableMsaa_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_enableMsaa_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0002FA40 File Offset: 0x0002DC40
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		public unsafe bool enableHDR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_enableHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_enableHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0002FABC File Offset: 0x0002DCBC
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		public unsafe DebugDisplaySettingsRendering.TaaDebugMode taaDebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_taaDebugMode_Public_get_TaaDebugMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_taaDebugMode_Public_set_Void_TaaDebugMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002FB38 File Offset: 0x0002DD38
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0002FB74 File Offset: 0x0002DD74
		public unsafe DebugValidationMode validationMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationMode_Public_get_DebugValidationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationMode_Public_set_Void_DebugValidationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002FBB4 File Offset: 0x0002DDB4
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		public unsafe PixelValidationChannels validationChannels
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationChannels_Public_get_PixelValidationChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationChannels_Public_set_Void_PixelValidationChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0002FC30 File Offset: 0x0002DE30
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0002FC6C File Offset: 0x0002DE6C
		public unsafe float validationRangeMin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationRangeMin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 599562, RefRangeEnd = 599563, XrefRangeStart = 599562, XrefRangeEnd = 599563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationRangeMin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0002FCAC File Offset: 0x0002DEAC
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
		public unsafe float validationRangeMax
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_validationRangeMax_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318239, RefRangeEnd = 318240, XrefRangeStart = 318239, XrefRangeEnd = 318240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_set_validationRangeMax_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0002FD28 File Offset: 0x0002DF28
		public unsafe virtual bool AreAnySettingsActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0002FD64 File Offset: 0x0002DF64
		public unsafe virtual bool IsPostProcessingAllowed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
		public unsafe virtual bool IsLightingActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002FDDC File Offset: 0x0002DFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605753, XrefRangeEnd = 605754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetScreenClearColor(ref Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0002FE28 File Offset: 0x0002E028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605754, XrefRangeEnd = 605758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDebugDisplaySettingsPanelDisposable UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDebugDisplaySettingsPanelDisposable>(intPtr3) : null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0002FE68 File Offset: 0x0002E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605758, XrefRangeEnd = 605759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugDisplaySettingsRendering()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000536A File Offset: 0x0000356A
		public DebugDisplaySettingsRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00005373 File Offset: 0x00003573
		public unsafe DebugWireframeMode m_WireframeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_WireframeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_WireframeMode)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0002FECC File Offset: 0x0002E0CC
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0000538E File Offset: 0x0000358E
		public unsafe bool m_Overdraw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_Overdraw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_Overdraw)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x000053A9 File Offset: 0x000035A9
		public unsafe DebugOverdrawMode m_OverdrawMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_OverdrawMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr_m_OverdrawMode)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0002FF1C File Offset: 0x0002E11C
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x000053C4 File Offset: 0x000035C4
		public unsafe int _maxOverdrawCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__maxOverdrawCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__maxOverdrawCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0002FF44 File Offset: 0x0002E144
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x000053DF File Offset: 0x000035DF
		public unsafe DebugFullScreenMode _fullScreenDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0002FF6C File Offset: 0x0002E16C
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x000053FA File Offset: 0x000035FA
		public unsafe int _fullScreenDebugModeOutputSizeScreenPercent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugModeOutputSizeScreenPercent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__fullScreenDebugModeOutputSizeScreenPercent_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0002FF94 File Offset: 0x0002E194
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00005415 File Offset: 0x00003615
		public unsafe DebugSceneOverrideMode _sceneOverrideMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__sceneOverrideMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__sceneOverrideMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002FFBC File Offset: 0x0002E1BC
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x00005430 File Offset: 0x00003630
		public unsafe DebugMipInfoMode _mipInfoMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__mipInfoMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__mipInfoMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0002FFE4 File Offset: 0x0002E1E4
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x0000544B File Offset: 0x0000364B
		public unsafe DebugPostProcessingMode _postProcessingDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__postProcessingDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__postProcessingDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x0003000C File Offset: 0x0002E20C
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x00005466 File Offset: 0x00003666
		public unsafe bool _enableMsaa_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableMsaa_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableMsaa_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x00030034 File Offset: 0x0002E234
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x00005481 File Offset: 0x00003681
		public unsafe bool _enableHDR_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableHDR_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__enableHDR_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x0003005C File Offset: 0x0002E25C
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000549C File Offset: 0x0000369C
		public unsafe DebugDisplaySettingsRendering.TaaDebugMode _taaDebugMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__taaDebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__taaDebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00030084 File Offset: 0x0002E284
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x000054B7 File Offset: 0x000036B7
		public unsafe DebugValidationMode _validationMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000300AC File Offset: 0x0002E2AC
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x000054D2 File Offset: 0x000036D2
		public unsafe PixelValidationChannels _validationChannels_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationChannels_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationChannels_k__BackingField)) = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x000300D4 File Offset: 0x0002E2D4
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x000054ED File Offset: 0x000036ED
		public unsafe float _validationRangeMin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMin_k__BackingField)) = value;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x000300FC File Offset: 0x0002E2FC
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00005508 File Offset: 0x00003708
		public unsafe float _validationRangeMax_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMax_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.NativeFieldInfoPtr__validationRangeMax_k__BackingField)) = value;
			}
		}

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_m_WireframeMode;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_m_Overdraw;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_m_OverdrawMode;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr__maxOverdrawCount_k__BackingField;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr__fullScreenDebugMode_k__BackingField;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr__fullScreenDebugModeOutputSizeScreenPercent_k__BackingField;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr__sceneOverrideMode_k__BackingField;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr__mipInfoMode_k__BackingField;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr__postProcessingDebugMode_k__BackingField;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr__enableMsaa_k__BackingField;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr__enableHDR_k__BackingField;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr__taaDebugMode_k__BackingField;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr__validationMode_k__BackingField;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr__validationChannels_k__BackingField;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr__validationRangeMin_k__BackingField;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr__validationRangeMax_k__BackingField;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_wireframeMode_Public_get_DebugWireframeMode_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_set_wireframeMode_Public_set_Void_DebugWireframeMode_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_overdraw_Public_get_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_set_overdraw_Public_set_Void_Boolean_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_get_overdrawMode_Public_get_DebugOverdrawMode_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_set_overdrawMode_Public_set_Void_DebugOverdrawMode_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_get_maxOverdrawCount_Public_get_Int32_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_set_maxOverdrawCount_Public_set_Void_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDebugSceneOverrideMode_Private_Void_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreenDebugMode_Public_get_DebugFullScreenMode_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_set_fullScreenDebugMode_Public_set_Void_DebugFullScreenMode_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreenDebugModeOutputSizeScreenPercent_Public_get_Int32_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_set_fullScreenDebugModeOutputSizeScreenPercent_Public_set_Void_Int32_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneOverrideMode_Internal_get_DebugSceneOverrideMode_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_set_sceneOverrideMode_Internal_set_Void_DebugSceneOverrideMode_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_get_mipInfoMode_Internal_get_DebugMipInfoMode_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_set_mipInfoMode_Internal_set_Void_DebugMipInfoMode_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_postProcessingDebugMode_Public_get_DebugPostProcessingMode_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_set_postProcessingDebugMode_Public_set_Void_DebugPostProcessingMode_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_enableMsaa_Public_get_Boolean_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_set_enableMsaa_Public_set_Void_Boolean_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_get_enableHDR_Public_get_Boolean_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_set_enableHDR_Public_set_Void_Boolean_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_get_taaDebugMode_Public_get_TaaDebugMode_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_set_taaDebugMode_Public_set_Void_TaaDebugMode_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_validationMode_Public_get_DebugValidationMode_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_set_validationMode_Public_set_Void_DebugValidationMode_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_validationChannels_Public_get_PixelValidationChannels_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_set_validationChannels_Public_set_Void_PixelValidationChannels_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_validationRangeMin_Public_get_Single_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_set_validationRangeMin_Public_set_Void_Single_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_validationRangeMax_Public_get_Single_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_set_validationRangeMax_Public_set_Void_Single_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Rendering_IDebugDisplaySettingsData_CreatePanel_Private_Virtual_Final_New_IDebugDisplaySettingsPanelDisposable_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000176 RID: 374
		public enum TaaDebugMode
		{
			// Token: 0x0400149D RID: 5277
			None,
			// Token: 0x0400149E RID: 5278
			ShowRawFrame,
			// Token: 0x0400149F RID: 5279
			ShowRawFrameNoJitter,
			// Token: 0x040014A0 RID: 5280
			ShowClampedHistory
		}

		// Token: 0x02000177 RID: 375
		public static class Strings : Object
		{
			// Token: 0x06001C52 RID: 7250 RVA: 0x00074818 File Offset: 0x00072A18
			// Note: this type is marked as 'beforefieldinit'.
			static Strings()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "Strings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr);
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_RangeValidationSettingsContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "RangeValidationSettingsContainerName");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapOverlays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "MapOverlays");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "MapSize");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_AdditionalWireframeModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "AdditionalWireframeModes");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_WireframeNotSupportedWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "WireframeNotSupportedWarning");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_OverdrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "OverdrawMode");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MaxOverdrawCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "MaxOverdrawCount");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "PostProcessing");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MSAA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "MSAA");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "HDR");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_TaaDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "TaaDebugMode");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PixelValidationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "PixelValidationMode");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_Channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "Channels");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "ValueRangeMin");
				DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.Strings>.NativeClassPtr, "ValueRangeMax");
			}

			// Token: 0x06001C53 RID: 7251 RVA: 0x000101A6 File Offset: 0x0000E3A6
			public Strings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00074970 File Offset: 0x00072B70
			// (set) Token: 0x06001C55 RID: 7253 RVA: 0x000101AF File Offset: 0x0000E3AF
			public unsafe static string RangeValidationSettingsContainerName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_RangeValidationSettingsContainerName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_RangeValidationSettingsContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00074990 File Offset: 0x00072B90
			// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000101C1 File Offset: 0x0000E3C1
			public unsafe static DebugUI.Widget.NameAndTooltip MapOverlays
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapOverlays, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapOverlays, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000749CC File Offset: 0x00072BCC
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x000101D8 File Offset: 0x0000E3D8
			public unsafe static DebugUI.Widget.NameAndTooltip MapSize
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapSize, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MapSize, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00074A08 File Offset: 0x00072C08
			// (set) Token: 0x06001C5B RID: 7259 RVA: 0x000101EF File Offset: 0x0000E3EF
			public unsafe static DebugUI.Widget.NameAndTooltip AdditionalWireframeModes
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_AdditionalWireframeModes, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_AdditionalWireframeModes, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00074A44 File Offset: 0x00072C44
			// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00010206 File Offset: 0x0000E406
			public unsafe static DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_WireframeNotSupportedWarning, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_WireframeNotSupportedWarning, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00074A80 File Offset: 0x00072C80
			// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0001021D File Offset: 0x0000E41D
			public unsafe static DebugUI.Widget.NameAndTooltip OverdrawMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_OverdrawMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_OverdrawMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00074ABC File Offset: 0x00072CBC
			// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00010234 File Offset: 0x0000E434
			public unsafe static DebugUI.Widget.NameAndTooltip MaxOverdrawCount
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MaxOverdrawCount, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MaxOverdrawCount, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00074AF8 File Offset: 0x00072CF8
			// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0001024B File Offset: 0x0000E44B
			public unsafe static DebugUI.Widget.NameAndTooltip PostProcessing
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PostProcessing, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PostProcessing, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06001C64 RID: 7268 RVA: 0x00074B34 File Offset: 0x00072D34
			// (set) Token: 0x06001C65 RID: 7269 RVA: 0x00010262 File Offset: 0x0000E462
			public unsafe static DebugUI.Widget.NameAndTooltip MSAA
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MSAA, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_MSAA, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06001C66 RID: 7270 RVA: 0x00074B70 File Offset: 0x00072D70
			// (set) Token: 0x06001C67 RID: 7271 RVA: 0x00010279 File Offset: 0x0000E479
			public unsafe static DebugUI.Widget.NameAndTooltip HDR
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_HDR, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_HDR, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06001C68 RID: 7272 RVA: 0x00074BAC File Offset: 0x00072DAC
			// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00010290 File Offset: 0x0000E490
			public unsafe static DebugUI.Widget.NameAndTooltip TaaDebugMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_TaaDebugMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_TaaDebugMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00074BE8 File Offset: 0x00072DE8
			// (set) Token: 0x06001C6B RID: 7275 RVA: 0x000102A7 File Offset: 0x0000E4A7
			public unsafe static DebugUI.Widget.NameAndTooltip PixelValidationMode
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PixelValidationMode, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_PixelValidationMode, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00074C24 File Offset: 0x00072E24
			// (set) Token: 0x06001C6D RID: 7277 RVA: 0x000102BE File Offset: 0x0000E4BE
			public unsafe static DebugUI.Widget.NameAndTooltip Channels
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_Channels, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_Channels, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00074C60 File Offset: 0x00072E60
			// (set) Token: 0x06001C6F RID: 7279 RVA: 0x000102D5 File Offset: 0x0000E4D5
			public unsafe static DebugUI.Widget.NameAndTooltip ValueRangeMin
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMin, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMin, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00074C9C File Offset: 0x00072E9C
			// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000102EC File Offset: 0x0000E4EC
			public unsafe static DebugUI.Widget.NameAndTooltip ValueRangeMax
			{
				get
				{
					IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, (UIntPtr)0)];
					IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMax, intPtr);
					return new DebugUI.Widget.NameAndTooltip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugUI.Widget.NameAndTooltip>.NativeClassPtr, intPtr));
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.Strings.NativeFieldInfoPtr_ValueRangeMax, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
				}
			}

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeFieldInfoPtr_RangeValidationSettingsContainerName;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeFieldInfoPtr_MapOverlays;

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeFieldInfoPtr_MapSize;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeFieldInfoPtr_AdditionalWireframeModes;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeFieldInfoPtr_WireframeNotSupportedWarning;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeFieldInfoPtr_OverdrawMode;

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeFieldInfoPtr_MaxOverdrawCount;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeFieldInfoPtr_PostProcessing;

			// Token: 0x040014A9 RID: 5289
			private static readonly IntPtr NativeFieldInfoPtr_MSAA;

			// Token: 0x040014AA RID: 5290
			private static readonly IntPtr NativeFieldInfoPtr_HDR;

			// Token: 0x040014AB RID: 5291
			private static readonly IntPtr NativeFieldInfoPtr_TaaDebugMode;

			// Token: 0x040014AC RID: 5292
			private static readonly IntPtr NativeFieldInfoPtr_PixelValidationMode;

			// Token: 0x040014AD RID: 5293
			private static readonly IntPtr NativeFieldInfoPtr_Channels;

			// Token: 0x040014AE RID: 5294
			private static readonly IntPtr NativeFieldInfoPtr_ValueRangeMin;

			// Token: 0x040014AF RID: 5295
			private static readonly IntPtr NativeFieldInfoPtr_ValueRangeMax;
		}

		// Token: 0x02000178 RID: 376
		public static class WidgetFactory : Object
		{
			// Token: 0x06001C72 RID: 7282 RVA: 0x00074CD8 File Offset: 0x00072ED8
			// Note: this type is marked as 'beforefieldinit'.
			static WidgetFactory()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "WidgetFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMapOverlays_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664293);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMapOverlaySize_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664294);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateAdditionalWireframeShaderViews_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664295);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateWireframeNotSupportedWarning_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664296);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateOverdrawMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664297);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMaxOverdrawCount_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664298);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePostProcessing_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664299);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMSAA_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664300);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateHDR_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664301);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateTaaDebugMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664302);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValidationMode_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664303);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValidationChannels_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664304);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValueRangeMin_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664305);
				DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValueRangeMax_Internal_Static_Widget_SettingsPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, 100664306);
			}

			// Token: 0x06001C73 RID: 7283 RVA: 0x00074E1C File Offset: 0x0007301C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604900, RefRangeEnd = 604901, XrefRangeStart = 604851, XrefRangeEnd = 604900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMapOverlays(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMapOverlays_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C74 RID: 7284 RVA: 0x00074E60 File Offset: 0x00073060
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 604967, RefRangeEnd = 604968, XrefRangeStart = 604901, XrefRangeEnd = 604967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMapOverlaySize(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMapOverlaySize_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x00074EA4 File Offset: 0x000730A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605033, RefRangeEnd = 605034, XrefRangeStart = 604968, XrefRangeEnd = 605033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateAdditionalWireframeShaderViews(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateAdditionalWireframeShaderViews_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x00074EE8 File Offset: 0x000730E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605034, XrefRangeEnd = 605055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateWireframeNotSupportedWarning(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateWireframeNotSupportedWarning_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C77 RID: 7287 RVA: 0x00074F2C File Offset: 0x0007312C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605104, RefRangeEnd = 605105, XrefRangeStart = 605055, XrefRangeEnd = 605104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateOverdrawMode(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateOverdrawMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C78 RID: 7288 RVA: 0x00074F70 File Offset: 0x00073170
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605178, RefRangeEnd = 605179, XrefRangeStart = 605105, XrefRangeEnd = 605178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMaxOverdrawCount(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMaxOverdrawCount_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C79 RID: 7289 RVA: 0x00074FB4 File Offset: 0x000731B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605228, RefRangeEnd = 605229, XrefRangeStart = 605179, XrefRangeEnd = 605228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreatePostProcessing(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePostProcessing_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7A RID: 7290 RVA: 0x00074FF8 File Offset: 0x000731F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605229, XrefRangeEnd = 605259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateMSAA(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateMSAA_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7B RID: 7291 RVA: 0x0007503C File Offset: 0x0007323C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605259, XrefRangeEnd = 605289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateHDR(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateHDR_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7C RID: 7292 RVA: 0x00075080 File Offset: 0x00073280
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605354, RefRangeEnd = 605355, XrefRangeStart = 605289, XrefRangeEnd = 605354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreateTaaDebugMode(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreateTaaDebugMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7D RID: 7293 RVA: 0x000750C4 File Offset: 0x000732C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605420, RefRangeEnd = 605421, XrefRangeStart = 605355, XrefRangeEnd = 605420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreatePixelValidationMode(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValidationMode_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7E RID: 7294 RVA: 0x00075108 File Offset: 0x00073308
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605470, RefRangeEnd = 605471, XrefRangeStart = 605421, XrefRangeEnd = 605470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreatePixelValidationChannels(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValidationChannels_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x0007514C File Offset: 0x0007334C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605471, XrefRangeEnd = 605501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreatePixelValueRangeMin(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValueRangeMin_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x00075190 File Offset: 0x00073390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 605501, XrefRangeEnd = 605531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DebugUI.Widget CreatePixelValueRangeMax(DebugDisplaySettingsRendering.SettingsPanel panel)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.NativeMethodInfoPtr_CreatePixelValueRangeMax_Internal_Static_Widget_SettingsPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
				}
			}

			// Token: 0x06001C81 RID: 7297 RVA: 0x00010303 File Offset: 0x0000E503
			public WidgetFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040014B0 RID: 5296
			private static readonly IntPtr NativeMethodInfoPtr_CreateMapOverlays_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B1 RID: 5297
			private static readonly IntPtr NativeMethodInfoPtr_CreateMapOverlaySize_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B2 RID: 5298
			private static readonly IntPtr NativeMethodInfoPtr_CreateAdditionalWireframeShaderViews_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B3 RID: 5299
			private static readonly IntPtr NativeMethodInfoPtr_CreateWireframeNotSupportedWarning_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B4 RID: 5300
			private static readonly IntPtr NativeMethodInfoPtr_CreateOverdrawMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B5 RID: 5301
			private static readonly IntPtr NativeMethodInfoPtr_CreateMaxOverdrawCount_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B6 RID: 5302
			private static readonly IntPtr NativeMethodInfoPtr_CreatePostProcessing_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B7 RID: 5303
			private static readonly IntPtr NativeMethodInfoPtr_CreateMSAA_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B8 RID: 5304
			private static readonly IntPtr NativeMethodInfoPtr_CreateHDR_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014B9 RID: 5305
			private static readonly IntPtr NativeMethodInfoPtr_CreateTaaDebugMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014BA RID: 5306
			private static readonly IntPtr NativeMethodInfoPtr_CreatePixelValidationMode_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeMethodInfoPtr_CreatePixelValidationChannels_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeMethodInfoPtr_CreatePixelValueRangeMin_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeMethodInfoPtr_CreatePixelValueRangeMax_Internal_Static_Widget_SettingsPanel_0;

			// Token: 0x0200022D RID: 557
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x06002457 RID: 9303 RVA: 0x000882B4 File Offset: 0x000864B4
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__1_2");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__1_3");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__2_4");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__5_3");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__5_4");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__9_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__9_4");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__10_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, "<>9__10_4");
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664308);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664309);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_3_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664310);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_4_Internal_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664311);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_3_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664312);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_4_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664313);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateTaaDebugMode_b__9_4_Internal_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664314);
					DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreatePixelValidationMode_b__10_4_Internal_Void_Field_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr, 100664315);
				}

				// Token: 0x06002458 RID: 9304 RVA: 0x00088420 File Offset: 0x00086620
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002459 RID: 9305 RVA: 0x0008845C File Offset: 0x0008665C
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMapOverlaySize_b__1_2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600245A RID: 9306 RVA: 0x00088498 File Offset: 0x00086698
				[CallerCount(0)]
				public unsafe int _CreateMapOverlaySize_b__1_3()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_3_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600245B RID: 9307 RVA: 0x000884D4 File Offset: 0x000866D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604790, XrefRangeEnd = 604796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAdditionalWireframeShaderViews_b__2_4(DebugUI.Field<int> _, int _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_4_Internal_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600245C RID: 9308 RVA: 0x00088524 File Offset: 0x00086724
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaxOverdrawCount_b__5_3()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_3_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600245D RID: 9309 RVA: 0x00088560 File Offset: 0x00086760
				[CallerCount(0)]
				public unsafe int _CreateMaxOverdrawCount_b__5_4()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_4_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600245E RID: 9310 RVA: 0x0008859C File Offset: 0x0008679C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604796, XrefRangeEnd = 604802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateTaaDebugMode_b__9_4(DebugUI.Field<int> _, int _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreateTaaDebugMode_b__9_4_Internal_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600245F RID: 9311 RVA: 0x000885EC File Offset: 0x000867EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604802, XrefRangeEnd = 604808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValidationMode_b__10_4(DebugUI.Field<int> _, int _)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeMethodInfoPtr__CreatePixelValidationMode_b__10_4_Internal_Void_Field_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002460 RID: 9312 RVA: 0x00014CA1 File Offset: 0x00012EA1
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CF5 RID: 3317
				// (get) Token: 0x06002461 RID: 9313 RVA: 0x0008863C File Offset: 0x0008683C
				// (set) Token: 0x06002462 RID: 9314 RVA: 0x00014CAA File Offset: 0x00012EAA
				public unsafe static DebugDisplaySettingsRendering.WidgetFactory.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.WidgetFactory.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CF6 RID: 3318
				// (get) Token: 0x06002463 RID: 9315 RVA: 0x00088664 File Offset: 0x00086864
				// (set) Token: 0x06002464 RID: 9316 RVA: 0x00014CBC File Offset: 0x00012EBC
				public unsafe static Func<int> __9__1_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CF7 RID: 3319
				// (get) Token: 0x06002465 RID: 9317 RVA: 0x0008868C File Offset: 0x0008688C
				// (set) Token: 0x06002466 RID: 9318 RVA: 0x00014CCE File Offset: 0x00012ECE
				public unsafe static Func<int> __9__1_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CF8 RID: 3320
				// (get) Token: 0x06002467 RID: 9319 RVA: 0x000886B4 File Offset: 0x000868B4
				// (set) Token: 0x06002468 RID: 9320 RVA: 0x00014CE0 File Offset: 0x00012EE0
				public unsafe static Action<DebugUI.Field<int>, int> __9__2_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CF9 RID: 3321
				// (get) Token: 0x06002469 RID: 9321 RVA: 0x000886DC File Offset: 0x000868DC
				// (set) Token: 0x0600246A RID: 9322 RVA: 0x00014CF2 File Offset: 0x00012EF2
				public unsafe static Func<int> __9__5_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CFA RID: 3322
				// (get) Token: 0x0600246B RID: 9323 RVA: 0x00088704 File Offset: 0x00086904
				// (set) Token: 0x0600246C RID: 9324 RVA: 0x00014D04 File Offset: 0x00012F04
				public unsafe static Func<int> __9__5_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CFB RID: 3323
				// (get) Token: 0x0600246D RID: 9325 RVA: 0x0008872C File Offset: 0x0008692C
				// (set) Token: 0x0600246E RID: 9326 RVA: 0x00014D16 File Offset: 0x00012F16
				public unsafe static Action<DebugUI.Field<int>, int> __9__9_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__9_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__9_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000CFC RID: 3324
				// (get) Token: 0x0600246F RID: 9327 RVA: 0x00088754 File Offset: 0x00086954
				// (set) Token: 0x06002470 RID: 9328 RVA: 0x00014D28 File Offset: 0x00012F28
				public unsafe static Action<DebugUI.Field<int>, int> __9__10_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__10_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugUI.Field<int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DebugDisplaySettingsRendering.WidgetFactory.__c.NativeFieldInfoPtr___9__10_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001943 RID: 6467
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04001944 RID: 6468
				private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

				// Token: 0x04001945 RID: 6469
				private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

				// Token: 0x04001946 RID: 6470
				private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

				// Token: 0x04001947 RID: 6471
				private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

				// Token: 0x04001948 RID: 6472
				private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

				// Token: 0x04001949 RID: 6473
				private static readonly IntPtr NativeFieldInfoPtr___9__9_4;

				// Token: 0x0400194A RID: 6474
				private static readonly IntPtr NativeFieldInfoPtr___9__10_4;

				// Token: 0x0400194B RID: 6475
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400194C RID: 6476
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlaySize_b__1_2_Internal_Int32_0;

				// Token: 0x0400194D RID: 6477
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlaySize_b__1_3_Internal_Int32_0;

				// Token: 0x0400194E RID: 6478
				private static readonly IntPtr NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_4_Internal_Void_Field_1_Int32_Int32_0;

				// Token: 0x0400194F RID: 6479
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_3_Internal_Int32_0;

				// Token: 0x04001950 RID: 6480
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaxOverdrawCount_b__5_4_Internal_Int32_0;

				// Token: 0x04001951 RID: 6481
				private static readonly IntPtr NativeMethodInfoPtr__CreateTaaDebugMode_b__9_4_Internal_Void_Field_1_Int32_Int32_0;

				// Token: 0x04001952 RID: 6482
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationMode_b__10_4_Internal_Void_Field_1_Int32_Int32_0;
			}

			// Token: 0x0200022E RID: 558
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x06002471 RID: 9329 RVA: 0x0008877C File Offset: 0x0008697C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664316);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664317);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664318);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664319);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr, 100664320);
				}

				// Token: 0x06002472 RID: 9330 RVA: 0x00088820 File Offset: 0x00086A20
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002473 RID: 9331 RVA: 0x0008885C File Offset: 0x00086A5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604808, XrefRangeEnd = 604809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMapOverlays_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002474 RID: 9332 RVA: 0x00088898 File Offset: 0x00086A98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604809, XrefRangeEnd = 604810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMapOverlays_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002475 RID: 9333 RVA: 0x000888D8 File Offset: 0x00086AD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604810, XrefRangeEnd = 604811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMapOverlays_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002476 RID: 9334 RVA: 0x00088914 File Offset: 0x00086B14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604811, XrefRangeEnd = 604812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMapOverlays_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__CreateMapOverlays_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002477 RID: 9335 RVA: 0x00014D3A File Offset: 0x00012F3A
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CFD RID: 3325
				// (get) Token: 0x06002478 RID: 9336 RVA: 0x00088954 File Offset: 0x00086B54
				// (set) Token: 0x06002479 RID: 9337 RVA: 0x00014D43 File Offset: 0x00012F43
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001953 RID: 6483
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001954 RID: 6484
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001955 RID: 6485
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlays_b__0_Internal_Int32_0;

				// Token: 0x04001956 RID: 6486
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlays_b__1_Internal_Void_Int32_0;

				// Token: 0x04001957 RID: 6487
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlays_b__2_Internal_Int32_0;

				// Token: 0x04001958 RID: 6488
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlays_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x0200022F RID: 559
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass10_0")]
			public sealed class __c__DisplayClass10_0 : Object
			{
				// Token: 0x0600247A RID: 9338 RVA: 0x00088984 File Offset: 0x00086B84
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass10_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass10_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664321);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664322);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664323);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664324);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr, 100664325);
				}

				// Token: 0x0600247B RID: 9339 RVA: 0x00088A28 File Offset: 0x00086C28
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass10_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600247C RID: 9340 RVA: 0x00088A64 File Offset: 0x00086C64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604812, XrefRangeEnd = 604813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePixelValidationMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600247D RID: 9341 RVA: 0x00088AA0 File Offset: 0x00086CA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604813, XrefRangeEnd = 604814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValidationMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600247E RID: 9342 RVA: 0x00088AE0 File Offset: 0x00086CE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604814, XrefRangeEnd = 604815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePixelValidationMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600247F RID: 9343 RVA: 0x00088B1C File Offset: 0x00086D1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604815, XrefRangeEnd = 604816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValidationMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeMethodInfoPtr__CreatePixelValidationMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002480 RID: 9344 RVA: 0x00014D62 File Offset: 0x00012F62
				public __c__DisplayClass10_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CFE RID: 3326
				// (get) Token: 0x06002481 RID: 9345 RVA: 0x00088B5C File Offset: 0x00086D5C
				// (set) Token: 0x06002482 RID: 9346 RVA: 0x00014D6B File Offset: 0x00012F6B
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass10_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001959 RID: 6489
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400195A RID: 6490
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400195B RID: 6491
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationMode_b__0_Internal_Int32_0;

				// Token: 0x0400195C RID: 6492
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationMode_b__1_Internal_Void_Int32_0;

				// Token: 0x0400195D RID: 6493
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationMode_b__2_Internal_Int32_0;

				// Token: 0x0400195E RID: 6494
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationMode_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000230 RID: 560
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass11_0")]
			public sealed class __c__DisplayClass11_0 : Object
			{
				// Token: 0x06002483 RID: 9347 RVA: 0x00088B8C File Offset: 0x00086D8C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass11_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass11_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, 100664326);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, 100664327);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, 100664328);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, 100664329);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr, 100664330);
				}

				// Token: 0x06002484 RID: 9348 RVA: 0x00088C30 File Offset: 0x00086E30
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass11_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002485 RID: 9349 RVA: 0x00088C6C File Offset: 0x00086E6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604816, XrefRangeEnd = 604817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePixelValidationChannels_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002486 RID: 9350 RVA: 0x00088CA8 File Offset: 0x00086EA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604817, XrefRangeEnd = 604818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValidationChannels_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002487 RID: 9351 RVA: 0x00088CE8 File Offset: 0x00086EE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604818, XrefRangeEnd = 604819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePixelValidationChannels_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002488 RID: 9352 RVA: 0x00088D24 File Offset: 0x00086F24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604819, XrefRangeEnd = 604820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValidationChannels_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeMethodInfoPtr__CreatePixelValidationChannels_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002489 RID: 9353 RVA: 0x00014D8A File Offset: 0x00012F8A
				public __c__DisplayClass11_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000CFF RID: 3327
				// (get) Token: 0x0600248A RID: 9354 RVA: 0x00088D64 File Offset: 0x00086F64
				// (set) Token: 0x0600248B RID: 9355 RVA: 0x00014D93 File Offset: 0x00012F93
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass11_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400195F RID: 6495
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001960 RID: 6496
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001961 RID: 6497
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationChannels_b__0_Internal_Int32_0;

				// Token: 0x04001962 RID: 6498
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationChannels_b__1_Internal_Void_Int32_0;

				// Token: 0x04001963 RID: 6499
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationChannels_b__2_Internal_Int32_0;

				// Token: 0x04001964 RID: 6500
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValidationChannels_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000231 RID: 561
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass12_0")]
			public sealed class __c__DisplayClass12_0 : Object
			{
				// Token: 0x0600248C RID: 9356 RVA: 0x00088D94 File Offset: 0x00086F94
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass12_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass12_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr, 100664331);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__CreatePixelValueRangeMin_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr, 100664332);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__CreatePixelValueRangeMin_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr, 100664333);
				}

				// Token: 0x0600248D RID: 9357 RVA: 0x00088E10 File Offset: 0x00087010
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass12_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600248E RID: 9358 RVA: 0x00088E4C File Offset: 0x0008704C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604820, XrefRangeEnd = 604821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreatePixelValueRangeMin_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__CreatePixelValueRangeMin_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600248F RID: 9359 RVA: 0x00088E88 File Offset: 0x00087088
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604821, XrefRangeEnd = 604822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValueRangeMin_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeMethodInfoPtr__CreatePixelValueRangeMin_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002490 RID: 9360 RVA: 0x00014DB2 File Offset: 0x00012FB2
				public __c__DisplayClass12_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D00 RID: 3328
				// (get) Token: 0x06002491 RID: 9361 RVA: 0x00088EC8 File Offset: 0x000870C8
				// (set) Token: 0x06002492 RID: 9362 RVA: 0x00014DBB File Offset: 0x00012FBB
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass12_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001965 RID: 6501
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001966 RID: 6502
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001967 RID: 6503
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValueRangeMin_b__0_Internal_Single_0;

				// Token: 0x04001968 RID: 6504
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValueRangeMin_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000232 RID: 562
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass13_0")]
			public sealed class __c__DisplayClass13_0 : Object
			{
				// Token: 0x06002493 RID: 9363 RVA: 0x00088EF8 File Offset: 0x000870F8
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass13_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass13_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr, 100664334);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__CreatePixelValueRangeMax_b__0_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr, 100664335);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__CreatePixelValueRangeMax_b__1_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr, 100664336);
				}

				// Token: 0x06002494 RID: 9364 RVA: 0x00088F74 File Offset: 0x00087174
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass13_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002495 RID: 9365 RVA: 0x00088FB0 File Offset: 0x000871B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604822, XrefRangeEnd = 604823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe float _CreatePixelValueRangeMax_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__CreatePixelValueRangeMax_b__0_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06002496 RID: 9366 RVA: 0x00088FEC File Offset: 0x000871EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604823, XrefRangeEnd = 604824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePixelValueRangeMax_b__1(float value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeMethodInfoPtr__CreatePixelValueRangeMax_b__1_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002497 RID: 9367 RVA: 0x00014DDA File Offset: 0x00012FDA
				public __c__DisplayClass13_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D01 RID: 3329
				// (get) Token: 0x06002498 RID: 9368 RVA: 0x0008902C File Offset: 0x0008722C
				// (set) Token: 0x06002499 RID: 9369 RVA: 0x00014DE3 File Offset: 0x00012FE3
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass13_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001969 RID: 6505
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400196A RID: 6506
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400196B RID: 6507
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValueRangeMax_b__0_Internal_Single_0;

				// Token: 0x0400196C RID: 6508
				private static readonly IntPtr NativeMethodInfoPtr__CreatePixelValueRangeMax_b__1_Internal_Void_Single_0;
			}

			// Token: 0x02000233 RID: 563
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass1_0")]
			public sealed class __c__DisplayClass1_0 : Object
			{
				// Token: 0x0600249A RID: 9370 RVA: 0x0008905C File Offset: 0x0008725C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass1_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass1_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664337);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMapOverlaySize_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664338);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr, 100664339);
				}

				// Token: 0x0600249B RID: 9371 RVA: 0x000890D8 File Offset: 0x000872D8
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass1_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600249C RID: 9372 RVA: 0x00089114 File Offset: 0x00087314
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604824, XrefRangeEnd = 604825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMapOverlaySize_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMapOverlaySize_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600249D RID: 9373 RVA: 0x00089150 File Offset: 0x00087350
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604825, XrefRangeEnd = 604826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMapOverlaySize_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMapOverlaySize_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600249E RID: 9374 RVA: 0x00014E02 File Offset: 0x00013002
				public __c__DisplayClass1_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D02 RID: 3330
				// (get) Token: 0x0600249F RID: 9375 RVA: 0x00089190 File Offset: 0x00087390
				// (set) Token: 0x060024A0 RID: 9376 RVA: 0x00014E0B File Offset: 0x0001300B
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400196D RID: 6509
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400196E RID: 6510
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400196F RID: 6511
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlaySize_b__0_Internal_Int32_0;

				// Token: 0x04001970 RID: 6512
				private static readonly IntPtr NativeMethodInfoPtr__CreateMapOverlaySize_b__1_Internal_Void_Int32_0;
			}

			// Token: 0x02000234 RID: 564
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass2_0")]
			public sealed class __c__DisplayClass2_0 : Object
			{
				// Token: 0x060024A1 RID: 9377 RVA: 0x000891C0 File Offset: 0x000873C0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass2_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass2_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664340);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664341);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664342);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664343);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr, 100664344);
				}

				// Token: 0x060024A2 RID: 9378 RVA: 0x00089264 File Offset: 0x00087464
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass2_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024A3 RID: 9379 RVA: 0x000892A0 File Offset: 0x000874A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604826, XrefRangeEnd = 604827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateAdditionalWireframeShaderViews_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024A4 RID: 9380 RVA: 0x000892DC File Offset: 0x000874DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604827, XrefRangeEnd = 604828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAdditionalWireframeShaderViews_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024A5 RID: 9381 RVA: 0x0008931C File Offset: 0x0008751C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604828, XrefRangeEnd = 604829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateAdditionalWireframeShaderViews_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024A6 RID: 9382 RVA: 0x00089358 File Offset: 0x00087558
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604829, XrefRangeEnd = 604830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateAdditionalWireframeShaderViews_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024A7 RID: 9383 RVA: 0x00014E2A File Offset: 0x0001302A
				public __c__DisplayClass2_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D03 RID: 3331
				// (get) Token: 0x060024A8 RID: 9384 RVA: 0x00089398 File Offset: 0x00087598
				// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00014E33 File Offset: 0x00013033
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass2_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001971 RID: 6513
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001972 RID: 6514
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001973 RID: 6515
				private static readonly IntPtr NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__0_Internal_Int32_0;

				// Token: 0x04001974 RID: 6516
				private static readonly IntPtr NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__1_Internal_Void_Int32_0;

				// Token: 0x04001975 RID: 6517
				private static readonly IntPtr NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__2_Internal_Int32_0;

				// Token: 0x04001976 RID: 6518
				private static readonly IntPtr NativeMethodInfoPtr__CreateAdditionalWireframeShaderViews_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000235 RID: 565
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Object
			{
				// Token: 0x060024AA RID: 9386 RVA: 0x000893C8 File Offset: 0x000875C8
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664345);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateWireframeNotSupportedWarning_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr, 100664346);
				}

				// Token: 0x060024AB RID: 9387 RVA: 0x00089430 File Offset: 0x00087630
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024AC RID: 9388 RVA: 0x0008946C File Offset: 0x0008766C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604830, XrefRangeEnd = 604832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateWireframeNotSupportedWarning_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateWireframeNotSupportedWarning_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024AD RID: 9389 RVA: 0x00014E52 File Offset: 0x00013052
				public __c__DisplayClass3_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D04 RID: 3332
				// (get) Token: 0x060024AE RID: 9390 RVA: 0x000894A8 File Offset: 0x000876A8
				// (set) Token: 0x060024AF RID: 9391 RVA: 0x00014E5B File Offset: 0x0001305B
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass3_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001977 RID: 6519
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001978 RID: 6520
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001979 RID: 6521
				private static readonly IntPtr NativeMethodInfoPtr__CreateWireframeNotSupportedWarning_b__0_Internal_Boolean_0;
			}

			// Token: 0x02000236 RID: 566
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x060024B0 RID: 9392 RVA: 0x000894D8 File Offset: 0x000876D8
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664347);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664348);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664349);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664350);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr, 100664351);
				}

				// Token: 0x060024B1 RID: 9393 RVA: 0x0008957C File Offset: 0x0008777C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024B2 RID: 9394 RVA: 0x000895B8 File Offset: 0x000877B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604832, XrefRangeEnd = 604833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateOverdrawMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024B3 RID: 9395 RVA: 0x000895F4 File Offset: 0x000877F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604833, XrefRangeEnd = 604834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateOverdrawMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024B4 RID: 9396 RVA: 0x00089634 File Offset: 0x00087834
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604834, XrefRangeEnd = 604835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateOverdrawMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024B5 RID: 9397 RVA: 0x00089670 File Offset: 0x00087870
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604835, XrefRangeEnd = 604836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateOverdrawMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeMethodInfoPtr__CreateOverdrawMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024B6 RID: 9398 RVA: 0x00014E7A File Offset: 0x0001307A
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D05 RID: 3333
				// (get) Token: 0x060024B7 RID: 9399 RVA: 0x000896B0 File Offset: 0x000878B0
				// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00014E83 File Offset: 0x00013083
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass4_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400197A RID: 6522
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400197B RID: 6523
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400197C RID: 6524
				private static readonly IntPtr NativeMethodInfoPtr__CreateOverdrawMode_b__0_Internal_Int32_0;

				// Token: 0x0400197D RID: 6525
				private static readonly IntPtr NativeMethodInfoPtr__CreateOverdrawMode_b__1_Internal_Void_Int32_0;

				// Token: 0x0400197E RID: 6526
				private static readonly IntPtr NativeMethodInfoPtr__CreateOverdrawMode_b__2_Internal_Int32_0;

				// Token: 0x0400197F RID: 6527
				private static readonly IntPtr NativeMethodInfoPtr__CreateOverdrawMode_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000237 RID: 567
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Object
			{
				// Token: 0x060024B9 RID: 9401 RVA: 0x000896E0 File Offset: 0x000878E0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass5_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664352);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664353);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__1_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664354);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr, 100664355);
				}

				// Token: 0x060024BA RID: 9402 RVA: 0x00089770 File Offset: 0x00087970
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024BB RID: 9403 RVA: 0x000897AC File Offset: 0x000879AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604836, XrefRangeEnd = 604837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateMaxOverdrawCount_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024BC RID: 9404 RVA: 0x000897E8 File Offset: 0x000879E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604837, XrefRangeEnd = 604838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateMaxOverdrawCount_b__1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__1_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024BD RID: 9405 RVA: 0x00089824 File Offset: 0x00087A24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604838, XrefRangeEnd = 604839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMaxOverdrawCount_b__2(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeMethodInfoPtr__CreateMaxOverdrawCount_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024BE RID: 9406 RVA: 0x00014EA2 File Offset: 0x000130A2
				public __c__DisplayClass5_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D06 RID: 3334
				// (get) Token: 0x060024BF RID: 9407 RVA: 0x00089864 File Offset: 0x00087A64
				// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00014EAB File Offset: 0x000130AB
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass5_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001980 RID: 6528
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001981 RID: 6529
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001982 RID: 6530
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaxOverdrawCount_b__0_Internal_Boolean_0;

				// Token: 0x04001983 RID: 6531
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaxOverdrawCount_b__1_Internal_Int32_0;

				// Token: 0x04001984 RID: 6532
				private static readonly IntPtr NativeMethodInfoPtr__CreateMaxOverdrawCount_b__2_Internal_Void_Int32_0;
			}

			// Token: 0x02000238 RID: 568
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Object
			{
				// Token: 0x060024C1 RID: 9409 RVA: 0x00089894 File Offset: 0x00087A94
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664356);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664357);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664358);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664359);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr, 100664360);
				}

				// Token: 0x060024C2 RID: 9410 RVA: 0x00089938 File Offset: 0x00087B38
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024C3 RID: 9411 RVA: 0x00089974 File Offset: 0x00087B74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604839, XrefRangeEnd = 604840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePostProcessing_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024C4 RID: 9412 RVA: 0x000899B0 File Offset: 0x00087BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604840, XrefRangeEnd = 604841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePostProcessing_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024C5 RID: 9413 RVA: 0x000899F0 File Offset: 0x00087BF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604841, XrefRangeEnd = 604842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreatePostProcessing_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024C6 RID: 9414 RVA: 0x00089A2C File Offset: 0x00087C2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604842, XrefRangeEnd = 604843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreatePostProcessing_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeMethodInfoPtr__CreatePostProcessing_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024C7 RID: 9415 RVA: 0x00014ECA File Offset: 0x000130CA
				public __c__DisplayClass6_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D07 RID: 3335
				// (get) Token: 0x060024C8 RID: 9416 RVA: 0x00089A6C File Offset: 0x00087C6C
				// (set) Token: 0x060024C9 RID: 9417 RVA: 0x00014ED3 File Offset: 0x000130D3
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass6_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001985 RID: 6533
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001986 RID: 6534
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001987 RID: 6535
				private static readonly IntPtr NativeMethodInfoPtr__CreatePostProcessing_b__0_Internal_Int32_0;

				// Token: 0x04001988 RID: 6536
				private static readonly IntPtr NativeMethodInfoPtr__CreatePostProcessing_b__1_Internal_Void_Int32_0;

				// Token: 0x04001989 RID: 6537
				private static readonly IntPtr NativeMethodInfoPtr__CreatePostProcessing_b__2_Internal_Int32_0;

				// Token: 0x0400198A RID: 6538
				private static readonly IntPtr NativeMethodInfoPtr__CreatePostProcessing_b__3_Internal_Void_Int32_0;
			}

			// Token: 0x02000239 RID: 569
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass7_0")]
			public sealed class __c__DisplayClass7_0 : Object
			{
				// Token: 0x060024CA RID: 9418 RVA: 0x00089A9C File Offset: 0x00087C9C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass7_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass7_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664361);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateMSAA_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664362);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateMSAA_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr, 100664363);
				}

				// Token: 0x060024CB RID: 9419 RVA: 0x00089B18 File Offset: 0x00087D18
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass7_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024CC RID: 9420 RVA: 0x00089B54 File Offset: 0x00087D54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604843, XrefRangeEnd = 604844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateMSAA_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateMSAA_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024CD RID: 9421 RVA: 0x00089B90 File Offset: 0x00087D90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604844, XrefRangeEnd = 604845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateMSAA_b__1(bool value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeMethodInfoPtr__CreateMSAA_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024CE RID: 9422 RVA: 0x00014EF2 File Offset: 0x000130F2
				public __c__DisplayClass7_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D08 RID: 3336
				// (get) Token: 0x060024CF RID: 9423 RVA: 0x00089BD0 File Offset: 0x00087DD0
				// (set) Token: 0x060024D0 RID: 9424 RVA: 0x00014EFB File Offset: 0x000130FB
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass7_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400198B RID: 6539
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x0400198C RID: 6540
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400198D RID: 6541
				private static readonly IntPtr NativeMethodInfoPtr__CreateMSAA_b__0_Internal_Boolean_0;

				// Token: 0x0400198E RID: 6542
				private static readonly IntPtr NativeMethodInfoPtr__CreateMSAA_b__1_Internal_Void_Boolean_0;
			}

			// Token: 0x0200023A RID: 570
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass8_0")]
			public sealed class __c__DisplayClass8_0 : Object
			{
				// Token: 0x060024D1 RID: 9425 RVA: 0x00089C00 File Offset: 0x00087E00
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass8_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass8_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664364);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateHDR_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664365);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateHDR_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr, 100664366);
				}

				// Token: 0x060024D2 RID: 9426 RVA: 0x00089C7C File Offset: 0x00087E7C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass8_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024D3 RID: 9427 RVA: 0x00089CB8 File Offset: 0x00087EB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604845, XrefRangeEnd = 604846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _CreateHDR_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateHDR_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024D4 RID: 9428 RVA: 0x00089CF4 File Offset: 0x00087EF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604846, XrefRangeEnd = 604847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateHDR_b__1(bool value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateHDR_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024D5 RID: 9429 RVA: 0x00014F1A File Offset: 0x0001311A
				public __c__DisplayClass8_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D09 RID: 3337
				// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00089D34 File Offset: 0x00087F34
				// (set) Token: 0x060024D7 RID: 9431 RVA: 0x00014F23 File Offset: 0x00013123
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass8_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400198F RID: 6543
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001990 RID: 6544
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001991 RID: 6545
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDR_b__0_Internal_Boolean_0;

				// Token: 0x04001992 RID: 6546
				private static readonly IntPtr NativeMethodInfoPtr__CreateHDR_b__1_Internal_Void_Boolean_0;
			}

			// Token: 0x0200023B RID: 571
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+WidgetFactory+<>c__DisplayClass9_0")]
			public sealed class __c__DisplayClass9_0 : Object
			{
				// Token: 0x060024D8 RID: 9432 RVA: 0x00089D64 File Offset: 0x00087F64
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass9_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory>.NativeClassPtr, "<>c__DisplayClass9_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, "panel");
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664367);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__0_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664368);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664369);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__2_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664370);
					DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr, 100664371);
				}

				// Token: 0x060024D9 RID: 9433 RVA: 0x00089E08 File Offset: 0x00088008
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass9_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024DA RID: 9434 RVA: 0x00089E44 File Offset: 0x00088044
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604847, XrefRangeEnd = 604848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateTaaDebugMode_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__0_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024DB RID: 9435 RVA: 0x00089E80 File Offset: 0x00088080
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604848, XrefRangeEnd = 604849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateTaaDebugMode_b__1(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024DC RID: 9436 RVA: 0x00089EC0 File Offset: 0x000880C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604849, XrefRangeEnd = 604850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _CreateTaaDebugMode_b__2()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__2_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024DD RID: 9437 RVA: 0x00089EFC File Offset: 0x000880FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 604850, XrefRangeEnd = 604851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CreateTaaDebugMode_b__3(int value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateTaaDebugMode_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024DE RID: 9438 RVA: 0x00014F42 File Offset: 0x00013142
				public __c__DisplayClass9_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D0A RID: 3338
				// (get) Token: 0x060024DF RID: 9439 RVA: 0x00089F3C File Offset: 0x0008813C
				// (set) Token: 0x060024E0 RID: 9440 RVA: 0x00014F4B File Offset: 0x0001314B
				public unsafe DebugDisplaySettingsRendering.SettingsPanel panel
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering.SettingsPanel>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.WidgetFactory.__c__DisplayClass9_0.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001993 RID: 6547
				private static readonly IntPtr NativeFieldInfoPtr_panel;

				// Token: 0x04001994 RID: 6548
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04001995 RID: 6549
				private static readonly IntPtr NativeMethodInfoPtr__CreateTaaDebugMode_b__0_Internal_Int32_0;

				// Token: 0x04001996 RID: 6550
				private static readonly IntPtr NativeMethodInfoPtr__CreateTaaDebugMode_b__1_Internal_Void_Int32_0;

				// Token: 0x04001997 RID: 6551
				private static readonly IntPtr NativeMethodInfoPtr__CreateTaaDebugMode_b__2_Internal_Int32_0;

				// Token: 0x04001998 RID: 6552
				private static readonly IntPtr NativeMethodInfoPtr__CreateTaaDebugMode_b__3_Internal_Void_Int32_0;
			}
		}

		// Token: 0x02000179 RID: 377
		public class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsRendering>
		{
			// Token: 0x06001C82 RID: 7298 RVA: 0x0001030C File Offset: 0x0000E50C
			// Note: this type is marked as 'beforefieldinit'.
			static SettingsPanel()
			{
				Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering>.NativeClassPtr, "SettingsPanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel>.NativeClassPtr);
				DebugDisplaySettingsRendering.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel>.NativeClassPtr, 100664372);
			}

			// Token: 0x06001C83 RID: 7299 RVA: 0x000751D4 File Offset: 0x000733D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 605752, RefRangeEnd = 605753, XrefRangeStart = 605531, XrefRangeEnd = 605752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SettingsPanel(DebugDisplaySettingsRendering data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.SettingsPanel.NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C84 RID: 7300 RVA: 0x00010340 File Offset: 0x0000E540
			public SettingsPanel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugDisplaySettingsRendering_0;

			// Token: 0x0200023C RID: 572
			[ObfuscatedName("UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering+SettingsPanel+<>c__DisplayClass0_0")]
			public sealed class __c__DisplayClass0_0 : Object
			{
				// Token: 0x060024E1 RID: 9441 RVA: 0x00089F6C File Offset: 0x0008816C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass0_0()
				{
					Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel>.NativeClassPtr, "<>c__DisplayClass0_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr);
					DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, "data");
					DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, 100664373);
					DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr, 100664374);
				}

				// Token: 0x060024E2 RID: 9442 RVA: 0x00089FD4 File Offset: 0x000881D4
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass0_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024E3 RID: 9443 RVA: 0x0008A010 File Offset: 0x00088210
				[CallerCount(0)]
				public unsafe bool __ctor_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060024E4 RID: 9444 RVA: 0x00014F6A File Offset: 0x0001316A
				public __c__DisplayClass0_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000D0B RID: 3339
				// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0008A04C File Offset: 0x0008824C
				// (set) Token: 0x060024E6 RID: 9446 RVA: 0x00014F73 File Offset: 0x00013173
				public unsafe DebugDisplaySettingsRendering data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugDisplaySettingsRendering.SettingsPanel.__c__DisplayClass0_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001999 RID: 6553
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x0400199A RID: 6554
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400199B RID: 6555
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_0;
			}
		}
	}
}
