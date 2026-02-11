using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000044 RID: 68
	public class DynamicResolutionHandler : Object
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00020CF4 File Offset: 0x0001EEF4
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicResolutionHandler()
		{
			Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DynamicResolutionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr);
			DynamicResolutionHandler.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_Enabled");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_UseMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_UseMipBias");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_MinScreenFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_MinScreenFraction");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_MaxScreenFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_MaxScreenFraction");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CurrentFraction");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_ForcingRes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_ForcingRes");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentCameraRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CurrentCameraRequest");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevFraction");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_ForceSoftwareFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_ForceSoftwareFallback");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_RunUpscalerFilterOnFullResolution");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevHWScaleWidth");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_PrevHWScaleHeight");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_LastScaledSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_LastScaledSize");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveScalerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveScalerSlot");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_ScalerContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ScalerContainers");
			DynamicResolutionHandler.NativeFieldInfoPtr_cachedOriginalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "cachedOriginalSize");
			DynamicResolutionHandler.NativeFieldInfoPtr__filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "<filter>k__BackingField");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraUpscaleFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_CameraUpscaleFilters");
			DynamicResolutionHandler.NativeFieldInfoPtr__finalViewport_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "<finalViewport>k__BackingField");
			DynamicResolutionHandler.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "type");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_CachedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_CachedSettings");
			DynamicResolutionHandler.NativeFieldInfoPtr_CameraDictionaryMaxcCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "CameraDictionaryMaxcCapacity");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_OwnerCameraWeakRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_OwnerCameraWeakRef");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_CameraInstances");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_DefaultInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_DefaultInstance");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveCameraId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveCameraId");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveInstance");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstanceDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_ActiveInstanceDirty");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_GlobalHwFraction");
			DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwUpresActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "s_GlobalHwUpresActive");
			DynamicResolutionHandler.NativeFieldInfoPtr_m_UpsamplerSchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "m_UpsamplerSchedule");
			DynamicResolutionHandler.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663965);
			DynamicResolutionHandler.NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663966);
			DynamicResolutionHandler.NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663967);
			DynamicResolutionHandler.NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663968);
			DynamicResolutionHandler.NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663969);
			DynamicResolutionHandler.NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663970);
			DynamicResolutionHandler.NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663971);
			DynamicResolutionHandler.NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663972);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663973);
			DynamicResolutionHandler.NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663974);
			DynamicResolutionHandler.NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663975);
			DynamicResolutionHandler.NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663976);
			DynamicResolutionHandler.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663977);
			DynamicResolutionHandler.NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663978);
			DynamicResolutionHandler.NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663979);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663980);
			DynamicResolutionHandler.NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663981);
			DynamicResolutionHandler.NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663982);
			DynamicResolutionHandler.NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663983);
			DynamicResolutionHandler.NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663984);
			DynamicResolutionHandler.NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663985);
			DynamicResolutionHandler.NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663986);
			DynamicResolutionHandler.NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663987);
			DynamicResolutionHandler.NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663988);
			DynamicResolutionHandler.NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663989);
			DynamicResolutionHandler.NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663990);
			DynamicResolutionHandler.NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663991);
			DynamicResolutionHandler.NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663992);
			DynamicResolutionHandler.NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663993);
			DynamicResolutionHandler.NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663994);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663995);
			DynamicResolutionHandler.NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663996);
			DynamicResolutionHandler.NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663997);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetCurrentScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663998);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100663999);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664000);
			DynamicResolutionHandler.NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, 100664001);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00021274 File Offset: 0x0001F474
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000212A8 File Offset: 0x0001F4A8
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x000212E4 File Offset: 0x0001F4E4
		public unsafe DynamicResUpscaleFilter filter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00021324 File Offset: 0x0001F524
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00021360 File Offset: 0x0001F560
		public unsafe Vector2Int finalViewport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000213E0 File Offset: 0x0001F5E0
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x000213A0 File Offset: 0x0001F5A0
		public unsafe bool runUpscalerFilterOnFullResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002141C File Offset: 0x0001F61C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959924, RefRangeEnd = 959925, XrefRangeStart = 959917, XrefRangeEnd = 959924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FlushScalableBufferManagerState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00021458 File Offset: 0x0001F658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959990, RefRangeEnd = 959991, XrefRangeStart = 959925, XrefRangeEnd = 959990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicResolutionHandler GetOrCreateDrsInstanceHandler(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr3) : null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000214DC File Offset: 0x0001F6DC
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x0002149C File Offset: 0x0001F69C
		public unsafe DynamicResolutionHandler.UpsamplerScheduleType upsamplerSchedule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00021518 File Offset: 0x0001F718
		public unsafe static DynamicResolutionHandler instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 959991, XrefRangeEnd = 959995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002154C File Offset: 0x0001F74C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 959996, RefRangeEnd = 959997, XrefRangeStart = 959995, XrefRangeEnd = 959996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicResolutionHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00021588 File Offset: 0x0001F788
		[CallerCount(0)]
		public unsafe static float DefaultDynamicResMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000215B8 File Offset: 0x0001F7B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960015, RefRangeEnd = 960016, XrefRangeStart = 959997, XrefRangeEnd = 960015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSettings(GlobalDynamicResolutionSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000215F8 File Offset: 0x0001F7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960016, XrefRangeEnd = 960018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetResolvedScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00021634 File Offset: 0x0001F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960018, XrefRangeEnd = 960023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateMipBias(Vector2Int inputResolution, Vector2Int outputResolution, bool forceApply = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputResolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputResolution;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceApply;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002169C File Offset: 0x0001F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960023, XrefRangeEnd = 960029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000216E0 File Offset: 0x0001F8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960029, XrefRangeEnd = 960035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSystemDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = DynamicResScalePolicyType.ReturnsMinMaxLerpFactor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scalerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00021724 File Offset: 0x0001F924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960035, XrefRangeEnd = 960039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetActiveDynamicScalerSlot(DynamicResScalerSlot slot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref slot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00021758 File Offset: 0x0001F958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960039, XrefRangeEnd = 960047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSelectedCamera()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00021780 File Offset: 0x0001F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960047, XrefRangeEnd = 960067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUpscaleFilter(Camera camera, DynamicResUpscaleFilter filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000217C4 File Offset: 0x0001F9C4
		[CallerCount(0)]
		public unsafe void SetCurrentCameraRequest(bool cameraRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cameraRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00021804 File Offset: 0x0001FA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960067, XrefRangeEnd = 960097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateAndUseCamera(Camera camera, Nullable<GlobalDynamicResolutionSettings> settings = null, Action OnResolutionChange = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnResolutionChange);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00021864 File Offset: 0x0001FA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960118, RefRangeEnd = 960119, XrefRangeStart = 960097, XrefRangeEnd = 960118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settings;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(OnResolutionChange);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000218B4 File Offset: 0x0001FAB4
		[CallerCount(0)]
		public unsafe bool SoftwareDynamicResIsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000218F0 File Offset: 0x0001FAF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 960119, RefRangeEnd = 960121, XrefRangeStart = 960119, XrefRangeEnd = 960119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HardwareDynamicResIsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002192C File Offset: 0x0001FB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960121, RefRangeEnd = 960122, XrefRangeStart = 960121, XrefRangeEnd = 960121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequestsHardwareDynamicResolution()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00021968 File Offset: 0x0001FB68
		[CallerCount(0)]
		public unsafe bool DynamicResolutionEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000219A4 File Offset: 0x0001FBA4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 689957, RefRangeEnd = 689983, XrefRangeStart = 689957, XrefRangeEnd = 689983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceSoftwareFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000219D8 File Offset: 0x0001FBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960122, XrefRangeEnd = 960137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetScaledSize(Vector2Int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00021A24 File Offset: 0x0001FC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960137, XrefRangeEnd = 960153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int ApplyScalesOnSize(Vector2Int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00021A70 File Offset: 0x0001FC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 960166, RefRangeEnd = 960167, XrefRangeStart = 960153, XrefRangeEnd = 960166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int ApplyScalesOnSize(Vector2Int size, Vector2 scales)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scales;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[CallerCount(0)]
		public unsafe float GetCurrentScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetCurrentScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00021B04 File Offset: 0x0001FD04
		[CallerCount(0)]
		public unsafe Vector2Int GetLastScaledSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00021B40 File Offset: 0x0001FD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960167, XrefRangeEnd = 960171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowResMultiplier(float targetLowRes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetLowRes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00021B8C File Offset: 0x0001FD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960171, XrefRangeEnd = 960175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowResMultiplier(float targetLowRes, float minimumThreshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetLowRes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResolutionHandler.NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000040FE File Offset: 0x000022FE
		public DynamicResolutionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00021BE4 File Offset: 0x0001FDE4
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004107 File Offset: 0x00002307
		public unsafe bool m_Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_Enabled)) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00021C0C File Offset: 0x0001FE0C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00004122 File Offset: 0x00002322
		public unsafe bool m_UseMipBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_UseMipBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_UseMipBias)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00021C34 File Offset: 0x0001FE34
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000413D File Offset: 0x0000233D
		public unsafe float m_MinScreenFraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_MinScreenFraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_MinScreenFraction)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00021C5C File Offset: 0x0001FE5C
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004158 File Offset: 0x00002358
		public unsafe float m_MaxScreenFraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_MaxScreenFraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_MaxScreenFraction)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00021C84 File Offset: 0x0001FE84
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00004173 File Offset: 0x00002373
		public unsafe float m_CurrentFraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentFraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentFraction)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00021CAC File Offset: 0x0001FEAC
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0000418E File Offset: 0x0000238E
		public unsafe bool m_ForcingRes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_ForcingRes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_ForcingRes)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00021CD4 File Offset: 0x0001FED4
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000041A9 File Offset: 0x000023A9
		public unsafe bool m_CurrentCameraRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentCameraRequest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CurrentCameraRequest)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00021CFC File Offset: 0x0001FEFC
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000041C4 File Offset: 0x000023C4
		public unsafe float m_PrevFraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevFraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevFraction)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00021D24 File Offset: 0x0001FF24
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x000041DF File Offset: 0x000023DF
		public unsafe bool m_ForceSoftwareFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_ForceSoftwareFallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_ForceSoftwareFallback)) = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00021D4C File Offset: 0x0001FF4C
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x000041FA File Offset: 0x000023FA
		public unsafe bool m_RunUpscalerFilterOnFullResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00021D74 File Offset: 0x0001FF74
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004215 File Offset: 0x00002415
		public unsafe float m_PrevHWScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleWidth)) = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00021D9C File Offset: 0x0001FF9C
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004230 File Offset: 0x00002430
		public unsafe float m_PrevHWScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_PrevHWScaleHeight)) = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00021DC4 File Offset: 0x0001FFC4
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x0000424B File Offset: 0x0000244B
		public unsafe Vector2Int m_LastScaledSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_LastScaledSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_LastScaledSize)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00021DEC File Offset: 0x0001FFEC
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00004266 File Offset: 0x00002466
		public unsafe static DynamicResScalerSlot s_ActiveScalerSlot
		{
			get
			{
				DynamicResScalerSlot dynamicResScalerSlot;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveScalerSlot, (void*)(&dynamicResScalerSlot));
				return dynamicResScalerSlot;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveScalerSlot, (void*)(&value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00021E08 File Offset: 0x00020008
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe static Il2CppReferenceArray<DynamicResolutionHandler.ScalerContainer> s_ScalerContainers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ScalerContainers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicResolutionHandler.ScalerContainer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ScalerContainers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00021E30 File Offset: 0x00020030
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00004286 File Offset: 0x00002486
		public unsafe Vector2Int cachedOriginalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_cachedOriginalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_cachedOriginalSize)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00021E58 File Offset: 0x00020058
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x000042A1 File Offset: 0x000024A1
		public unsafe DynamicResUpscaleFilter _filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr__filter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr__filter_k__BackingField)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00021E80 File Offset: 0x00020080
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x000042BC File Offset: 0x000024BC
		public unsafe static Dictionary<int, DynamicResUpscaleFilter> s_CameraUpscaleFilters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraUpscaleFilters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DynamicResUpscaleFilter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraUpscaleFilters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00021EA8 File Offset: 0x000200A8
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x000042CE File Offset: 0x000024CE
		public unsafe Vector2Int _finalViewport_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr__finalViewport_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr__finalViewport_k__BackingField)) = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00021ED0 File Offset: 0x000200D0
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x000042E9 File Offset: 0x000024E9
		public unsafe DynamicResolutionType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00021EF8 File Offset: 0x000200F8
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00004304 File Offset: 0x00002504
		public unsafe GlobalDynamicResolutionSettings m_CachedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CachedSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_CachedSettings)) = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00021F20 File Offset: 0x00020120
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0000431F File Offset: 0x0000251F
		public unsafe static int CameraDictionaryMaxcCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_CameraDictionaryMaxcCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_CameraDictionaryMaxcCapacity, (void*)(&value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00021F3C File Offset: 0x0002013C
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000432D File Offset: 0x0000252D
		public unsafe WeakReference m_OwnerCameraWeakRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_OwnerCameraWeakRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_OwnerCameraWeakRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00021F6C File Offset: 0x0002016C
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0000434C File Offset: 0x0000254C
		public unsafe static Dictionary<int, DynamicResolutionHandler> s_CameraInstances
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraInstances, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DynamicResolutionHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_CameraInstances, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00021F94 File Offset: 0x00020194
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0000435E File Offset: 0x0000255E
		public unsafe static DynamicResolutionHandler s_DefaultInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_DefaultInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_DefaultInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00021FBC File Offset: 0x000201BC
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004370 File Offset: 0x00002570
		public unsafe static int s_ActiveCameraId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveCameraId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveCameraId, (void*)(&value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00021FD8 File Offset: 0x000201D8
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000437E File Offset: 0x0000257E
		public unsafe static DynamicResolutionHandler s_ActiveInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicResolutionHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00022000 File Offset: 0x00020200
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe static bool s_ActiveInstanceDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstanceDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_ActiveInstanceDirty, (void*)(&value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0002201C File Offset: 0x0002021C
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x0000439E File Offset: 0x0000259E
		public unsafe static float s_GlobalHwFraction
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwFraction, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwFraction, (void*)(&value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00022038 File Offset: 0x00020238
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000043AC File Offset: 0x000025AC
		public unsafe static bool s_GlobalHwUpresActive
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwUpresActive, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicResolutionHandler.NativeFieldInfoPtr_s_GlobalHwUpresActive, (void*)(&value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00022054 File Offset: 0x00020254
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000043BA File Offset: 0x000025BA
		public unsafe DynamicResolutionHandler.UpsamplerScheduleType m_UpsamplerSchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_UpsamplerSchedule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.NativeFieldInfoPtr_m_UpsamplerSchedule)) = value;
			}
		}

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_m_Enabled;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_m_UseMipBias;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeFieldInfoPtr_m_MinScreenFraction;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxScreenFraction;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFraction;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_m_ForcingRes;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRequest;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevFraction;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceSoftwareFallback;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_m_RunUpscalerFilterOnFullResolution;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevHWScaleWidth;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevHWScaleHeight;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeFieldInfoPtr_m_LastScaledSize;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_s_ActiveScalerSlot;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_s_ScalerContainers;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_cachedOriginalSize;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__filter_k__BackingField;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr_s_CameraUpscaleFilters;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr__finalViewport_k__BackingField;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedSettings;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr_CameraDictionaryMaxcCapacity;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnerCameraWeakRef;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_s_CameraInstances;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultInstance;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_s_ActiveCameraId;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_s_ActiveInstance;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_s_ActiveInstanceDirty;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_s_GlobalHwFraction;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_s_GlobalHwUpresActive;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_m_UpsamplerSchedule;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_get_filter_Public_get_DynamicResUpscaleFilter_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_set_filter_Private_set_Void_DynamicResUpscaleFilter_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_get_finalViewport_Public_get_Vector2Int_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_set_finalViewport_Public_set_Void_Vector2Int_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_set_runUpscalerFilterOnFullResolution_Public_set_Void_Boolean_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_runUpscalerFilterOnFullResolution_Public_get_Boolean_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_FlushScalableBufferManagerState_Private_Boolean_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateDrsInstanceHandler_Private_Static_DynamicResolutionHandler_Camera_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_set_upsamplerSchedule_Public_set_Void_UpsamplerScheduleType_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_get_upsamplerSchedule_Public_get_UpsamplerScheduleType_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_DynamicResolutionHandler_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_DefaultDynamicResMethod_Private_Static_Single_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSettings_Private_Void_GlobalDynamicResolutionSettings_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedScale_Public_Vector2_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMipBias_Public_Single_Vector2Int_Vector2Int_Boolean_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_SetDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_SetSystemDynamicResScaler_Public_Static_Void_PerformDynamicRes_DynamicResScalePolicyType_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveDynamicScalerSlot_Public_Static_Void_DynamicResScalerSlot_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelectedCamera_Public_Static_Void_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_SetUpscaleFilter_Public_Static_Void_Camera_DynamicResUpscaleFilter_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentCameraRequest_Public_Void_Boolean_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAndUseCamera_Public_Static_Void_Camera_Nullable_1_GlobalDynamicResolutionSettings_Action_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_GlobalDynamicResolutionSettings_Action_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_SoftwareDynamicResIsEnabled_Public_Boolean_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_HardwareDynamicResIsEnabled_Public_Boolean_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_RequestsHardwareDynamicResolution_Public_Boolean_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_DynamicResolutionEnabled_Public_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_ForceSoftwareFallback_Public_Void_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledSize_Public_Vector2Int_Vector2Int_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScalesOnSize_Public_Vector2Int_Vector2Int_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_ApplyScalesOnSize_Internal_Vector2Int_Vector2Int_Vector2_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentScale_Public_Single_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_GetLastScaledSize_Public_Vector2Int_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_GetLowResMultiplier_Public_Single_Single_Single_0;

		// Token: 0x0200017C RID: 380
		public sealed class ScalerContainer : ValueType
		{
			// Token: 0x0600162B RID: 5675 RVA: 0x00060268 File Offset: 0x0005E468
			// Note: this type is marked as 'beforefieldinit'.
			static ScalerContainer()
			{
				Il2CppClassPointerStore<DynamicResolutionHandler.ScalerContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicResolutionHandler>.NativeClassPtr, "ScalerContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicResolutionHandler.ScalerContainer>.NativeClassPtr);
				DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler.ScalerContainer>.NativeClassPtr, "type");
				DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResolutionHandler.ScalerContainer>.NativeClassPtr, "method");
			}

			// Token: 0x0600162C RID: 5676 RVA: 0x0000B2A6 File Offset: 0x000094A6
			public ScalerContainer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600162D RID: 5677 RVA: 0x0000B2AF File Offset: 0x000094AF
			public ScalerContainer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicResolutionHandler.ScalerContainer>.NativeClassPtr))
			{
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x0600162E RID: 5678 RVA: 0x000602BC File Offset: 0x0005E4BC
			// (set) Token: 0x0600162F RID: 5679 RVA: 0x0000B2C1 File Offset: 0x000094C1
			public unsafe DynamicResScalePolicyType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001630 RID: 5680 RVA: 0x000602E4 File Offset: 0x0005E4E4
			// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000B2DC File Offset: 0x000094DC
			public unsafe PerformDynamicRes method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_method);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PerformDynamicRes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResolutionHandler.ScalerContainer.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400102B RID: 4139
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400102C RID: 4140
			private static readonly IntPtr NativeFieldInfoPtr_method;
		}

		// Token: 0x0200017D RID: 381
		public enum UpsamplerScheduleType
		{
			// Token: 0x0400102E RID: 4142
			BeforePost,
			// Token: 0x0400102F RID: 4143
			AfterDepthOfField,
			// Token: 0x04001030 RID: 4144
			AfterPost
		}
	}
}
