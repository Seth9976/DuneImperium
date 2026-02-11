using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000EA RID: 234
	public class UniversalAdditionalCameraData : MonoBehaviour
	{
		// Token: 0x0600117D RID: 4477 RVA: 0x00052298 File Offset: 0x00050498
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalAdditionalCameraData()
		{
			Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalAdditionalCameraData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr);
			UniversalAdditionalCameraData.NativeFieldInfoPtr_k_GizmoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "k_GizmoPath");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_k_BaseCameraGizmoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "k_BaseCameraGizmoPath");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_k_OverlayCameraGizmoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "k_OverlayCameraGizmoPath");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_k_PostProcessingGizmoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "k_PostProcessingGizmoPath");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RenderShadows");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTextureOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RequiresDepthTextureOption");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresOpaqueTextureOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RequiresOpaqueTextureOption");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_CameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_CameraType");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_Cameras");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RendererIndex");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_VolumeLayerMask");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_VolumeTrigger");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeFrameworkUpdateModeOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_VolumeFrameworkUpdateModeOption");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RenderPostProcessing");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Antialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_Antialiasing");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AntialiasingQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_AntialiasingQuality");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_StopNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_StopNaN");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Dithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_Dithering");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ClearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_ClearDepth");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowXRRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_AllowXRRendering");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowHDROutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_AllowHDROutput");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_UseScreenCoordOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_UseScreenCoordOverride");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_ScreenSizeOverride");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenCoordScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_ScreenCoordScaleBias");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_Camera");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RequiresDepthTexture");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_RequiresColorTexture");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_Version");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_MotionVectorsPersistentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_MotionVectorsPersistentData");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaPersistentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_TaaPersistentData");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_TaaSettings");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_s_DefaultAdditionalCameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "s_DefaultAdditionalCameraData");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_s_CachedVolumeStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "s_CachedVolumeStacks");
			UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "m_VolumeStack");
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_version_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665515);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_defaultAdditionalCameraData_Internal_Static_get_UniversalAdditionalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665516);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665517);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665518);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderShadows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665519);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresDepthOption_Public_get_CameraOverrideOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665520);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresDepthOption_Public_set_Void_CameraOverrideOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665521);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresColorOption_Public_get_CameraOverrideOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665522);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresColorOption_Public_set_Void_CameraOverrideOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665523);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderType_Public_get_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665524);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderType_Public_set_Void_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665525);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_cameraStack_Public_get_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665526);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_UpdateCameraStack_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665527);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_clearDepth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665528);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665529);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresDepthTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665530);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresColorTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665531);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresColorTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665532);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665533);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_SetRenderer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665534);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeLayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665535);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeLayerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665536);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeTrigger_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665537);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeTrigger_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665538);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Internal_get_VolumeFrameworkUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665539);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeFrameworkUpdateMode_Internal_set_Void_VolumeFrameworkUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665540);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresVolumeFrameworkUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665541);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeStack_Public_get_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665542);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeStack_Public_set_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665543);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_GetOrCreateVolumeStack_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665544);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderPostProcessing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665545);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderPostProcessing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665546);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_antialiasing_Public_get_AntialiasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665547);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_antialiasing_Public_set_Void_AntialiasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665548);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_antialiasingQuality_Public_get_AntialiasingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665549);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_antialiasingQuality_Public_set_Void_AntialiasingQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665550);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_taaSettings_Public_get_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665551);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_taaPersistentData_Internal_get_TaaPersistentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665552);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_motionVectorsPersistentData_Internal_get_MotionVectorsPersistentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665553);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_resetHistory_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665554);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_resetHistory_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665555);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_stopNaN_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665556);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_stopNaN_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665557);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_dithering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665558);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_dithering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665559);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_allowXRRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665560);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_allowXRRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665561);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_useScreenCoordOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665562);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_useScreenCoordOverride_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665563);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_screenSizeOverride_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665564);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_screenSizeOverride_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665565);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_screenCoordScaleBias_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665566);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_screenCoordScaleBias_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665567);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_get_allowHDROutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665568);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_set_allowHDROutput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665569);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665570);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665571);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665572);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665573);
			UniversalAdditionalCameraData.NativeMethodInfoPtr_GetRawRenderer_Private_ScriptableRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665574);
			UniversalAdditionalCameraData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, 100665575);
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00052A34 File Offset: 0x00050C34
		public unsafe float version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_version_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00052A70 File Offset: 0x00050C70
		public unsafe static UniversalAdditionalCameraData defaultAdditionalCameraData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618879, XrefRangeEnd = 618911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_defaultAdditionalCameraData_Internal_Static_get_UniversalAdditionalCameraData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr3) : null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00052AA4 File Offset: 0x00050CA4
		public unsafe Camera camera
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 618919, RefRangeEnd = 618922, XrefRangeStart = 618911, XrefRangeEnd = 618919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00052AE4 File Offset: 0x00050CE4
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00052B20 File Offset: 0x00050D20
		public unsafe bool renderShadows
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderShadows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00052B60 File Offset: 0x00050D60
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x00052B9C File Offset: 0x00050D9C
		public unsafe CameraOverrideOption requiresDepthOption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresDepthOption_Public_get_CameraOverrideOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresDepthOption_Public_set_Void_CameraOverrideOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00052BDC File Offset: 0x00050DDC
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x00052C18 File Offset: 0x00050E18
		public unsafe CameraOverrideOption requiresColorOption
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresColorOption_Public_get_CameraOverrideOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresColorOption_Public_set_Void_CameraOverrideOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00052C58 File Offset: 0x00050E58
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x00052C94 File Offset: 0x00050E94
		public unsafe CameraRenderType renderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderType_Public_get_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderType_Public_set_Void_CameraRenderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00052CD4 File Offset: 0x00050ED4
		public unsafe List<Camera> cameraStack
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 618929, RefRangeEnd = 618932, XrefRangeStart = 618922, XrefRangeEnd = 618929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_cameraStack_Public_get_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr3) : null;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00052D14 File Offset: 0x00050F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618977, RefRangeEnd = 618978, XrefRangeStart = 618932, XrefRangeEnd = 618977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_UpdateCameraStack_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00052D48 File Offset: 0x00050F48
		public unsafe bool clearDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_clearDepth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00052D84 File Offset: 0x00050F84
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00052DC0 File Offset: 0x00050FC0
		public unsafe bool requiresDepthTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 618979, RefRangeEnd = 618980, XrefRangeStart = 618978, XrefRangeEnd = 618979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresDepthTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00052E00 File Offset: 0x00051000
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00052E3C File Offset: 0x0005103C
		public unsafe bool requiresColorTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 618981, RefRangeEnd = 618982, XrefRangeStart = 618980, XrefRangeEnd = 618981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresColorTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_requiresColorTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00052E7C File Offset: 0x0005107C
		public unsafe ScriptableRenderer scriptableRenderer
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 619027, RefRangeEnd = 619036, XrefRangeStart = 618982, XrefRangeEnd = 619027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00052EBC File Offset: 0x000510BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRenderer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_SetRenderer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00052EFC File Offset: 0x000510FC
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00052F38 File Offset: 0x00051138
		public unsafe LayerMask volumeLayerMask
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeLayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeLayerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00052F78 File Offset: 0x00051178
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00052FB8 File Offset: 0x000511B8
		public unsafe Transform volumeTrigger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeTrigger_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeTrigger_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00052FFC File Offset: 0x000511FC
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00053038 File Offset: 0x00051238
		public unsafe VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Internal_get_VolumeFrameworkUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeFrameworkUpdateMode_Internal_set_Void_VolumeFrameworkUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00053078 File Offset: 0x00051278
		public unsafe bool requiresVolumeFrameworkUpdate
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 619037, RefRangeEnd = 619040, XrefRangeStart = 619036, XrefRangeEnd = 619037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_requiresVolumeFrameworkUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000530B4 File Offset: 0x000512B4
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x000530F4 File Offset: 0x000512F4
		public unsafe VolumeStack volumeStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_volumeStack_Public_get_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 619060, RefRangeEnd = 619063, XrefRangeStart = 619040, XrefRangeEnd = 619060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_volumeStack_Public_set_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00053138 File Offset: 0x00051338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 619114, RefRangeEnd = 619115, XrefRangeStart = 619063, XrefRangeEnd = 619114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOrCreateVolumeStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_GetOrCreateVolumeStack_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0005316C File Offset: 0x0005136C
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x000531A8 File Offset: 0x000513A8
		public unsafe bool renderPostProcessing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_renderPostProcessing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_renderPostProcessing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000531E8 File Offset: 0x000513E8
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00053224 File Offset: 0x00051424
		public unsafe AntialiasingMode antialiasing
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_antialiasing_Public_get_AntialiasingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_antialiasing_Public_set_Void_AntialiasingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00053264 File Offset: 0x00051464
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x000532A0 File Offset: 0x000514A0
		public unsafe AntialiasingQuality antialiasingQuality
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_antialiasingQuality_Public_get_AntialiasingQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_antialiasingQuality_Public_set_Void_AntialiasingQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000532E0 File Offset: 0x000514E0
		public unsafe ref TemporalAA.Settings taaSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 619115, RefRangeEnd = 619117, XrefRangeStart = 619115, XrefRangeEnd = 619115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_taaSettings_Public_get_byref_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00053314 File Offset: 0x00051514
		public unsafe TaaPersistentData taaPersistentData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_taaPersistentData_Internal_get_TaaPersistentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaaPersistentData>(intPtr3) : null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00053354 File Offset: 0x00051554
		public unsafe MotionVectorsPersistentData motionVectorsPersistentData
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_motionVectorsPersistentData_Internal_get_MotionVectorsPersistentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MotionVectorsPersistentData>(intPtr3) : null;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00053394 File Offset: 0x00051594
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x000533D0 File Offset: 0x000515D0
		public unsafe bool resetHistory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_resetHistory_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619117, XrefRangeEnd = 619119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_resetHistory_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00053410 File Offset: 0x00051610
		// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0005344C File Offset: 0x0005164C
		public unsafe bool stopNaN
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_stopNaN_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_stopNaN_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0005348C File Offset: 0x0005168C
		// (set) Token: 0x060011AA RID: 4522 RVA: 0x000534C8 File Offset: 0x000516C8
		public unsafe bool dithering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_dithering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_dithering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00053508 File Offset: 0x00051708
		// (set) Token: 0x060011AC RID: 4524 RVA: 0x00053544 File Offset: 0x00051744
		public unsafe bool allowXRRendering
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_allowXRRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_allowXRRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00053584 File Offset: 0x00051784
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x000535C0 File Offset: 0x000517C0
		public unsafe bool useScreenCoordOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_useScreenCoordOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_useScreenCoordOverride_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00053600 File Offset: 0x00051800
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0005363C File Offset: 0x0005183C
		public unsafe Vector4 screenSizeOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_screenSizeOverride_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_screenSizeOverride_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0005367C File Offset: 0x0005187C
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x000536B8 File Offset: 0x000518B8
		public unsafe Vector4 screenCoordScaleBias
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_screenCoordScaleBias_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_screenCoordScaleBias_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000536F8 File Offset: 0x000518F8
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00053734 File Offset: 0x00051934
		public unsafe bool allowHDROutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_get_allowHDROutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_set_allowHDROutput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00053774 File Offset: 0x00051974
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x000537A8 File Offset: 0x000519A8
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x000537DC File Offset: 0x000519DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619119, XrefRangeEnd = 619132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00053810 File Offset: 0x00051A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619132, XrefRangeEnd = 619158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00053844 File Offset: 0x00051A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619158, XrefRangeEnd = 619176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRenderer GetRawRenderer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr_GetRawRenderer_Private_ScriptableRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr3) : null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00053884 File Offset: 0x00051A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 619176, XrefRangeEnd = 619196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalAdditionalCameraData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public UniversalAdditionalCameraData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000538C0 File Offset: 0x00051AC0
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000A6E1 File Offset: 0x000088E1
		public unsafe static string k_GizmoPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_GizmoPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_GizmoPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000538E0 File Offset: 0x00051AE0
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000A6F3 File Offset: 0x000088F3
		public unsafe static string k_BaseCameraGizmoPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_BaseCameraGizmoPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_BaseCameraGizmoPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00053900 File Offset: 0x00051B00
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0000A705 File Offset: 0x00008905
		public unsafe static string k_OverlayCameraGizmoPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_OverlayCameraGizmoPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_OverlayCameraGizmoPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00053920 File Offset: 0x00051B20
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0000A717 File Offset: 0x00008917
		public unsafe static string k_PostProcessingGizmoPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_PostProcessingGizmoPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_k_PostProcessingGizmoPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00053940 File Offset: 0x00051B40
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0000A729 File Offset: 0x00008929
		public unsafe bool m_RenderShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderShadows)) = value;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00053968 File Offset: 0x00051B68
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0000A744 File Offset: 0x00008944
		public unsafe CameraOverrideOption m_RequiresDepthTextureOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTextureOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTextureOption)) = value;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00053990 File Offset: 0x00051B90
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0000A75F File Offset: 0x0000895F
		public unsafe CameraOverrideOption m_RequiresOpaqueTextureOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresOpaqueTextureOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresOpaqueTextureOption)) = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000539B8 File Offset: 0x00051BB8
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x0000A77A File Offset: 0x0000897A
		public unsafe CameraRenderType m_CameraType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_CameraType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_CameraType)) = value;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000539E0 File Offset: 0x00051BE0
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x0000A795 File Offset: 0x00008995
		public unsafe List<Camera> m_Cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00053A10 File Offset: 0x00051C10
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public unsafe int m_RendererIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RendererIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RendererIndex)) = value;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00053A38 File Offset: 0x00051C38
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x0000A7CF File Offset: 0x000089CF
		public unsafe LayerMask m_VolumeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeLayerMask)) = value;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00053A60 File Offset: 0x00051C60
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x0000A7EA File Offset: 0x000089EA
		public unsafe Transform m_VolumeTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00053A90 File Offset: 0x00051C90
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x0000A809 File Offset: 0x00008A09
		public unsafe VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeFrameworkUpdateModeOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeFrameworkUpdateModeOption)) = value;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00053AB8 File Offset: 0x00051CB8
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x0000A824 File Offset: 0x00008A24
		public unsafe bool m_RenderPostProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderPostProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RenderPostProcessing)) = value;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00053AE0 File Offset: 0x00051CE0
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x0000A83F File Offset: 0x00008A3F
		public unsafe AntialiasingMode m_Antialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Antialiasing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Antialiasing)) = value;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00053B08 File Offset: 0x00051D08
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x0000A85A File Offset: 0x00008A5A
		public unsafe AntialiasingQuality m_AntialiasingQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AntialiasingQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AntialiasingQuality)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00053B30 File Offset: 0x00051D30
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x0000A875 File Offset: 0x00008A75
		public unsafe bool m_StopNaN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_StopNaN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_StopNaN)) = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00053B58 File Offset: 0x00051D58
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0000A890 File Offset: 0x00008A90
		public unsafe bool m_Dithering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Dithering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Dithering)) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00053B80 File Offset: 0x00051D80
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000A8AB File Offset: 0x00008AAB
		public unsafe bool m_ClearDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ClearDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ClearDepth)) = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00053BA8 File Offset: 0x00051DA8
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000A8C6 File Offset: 0x00008AC6
		public unsafe bool m_AllowXRRendering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowXRRendering);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowXRRendering)) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00053BD0 File Offset: 0x00051DD0
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0000A8E1 File Offset: 0x00008AE1
		public unsafe bool m_AllowHDROutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowHDROutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_AllowHDROutput)) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x00053BF8 File Offset: 0x00051DF8
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public unsafe bool m_UseScreenCoordOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_UseScreenCoordOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_UseScreenCoordOverride)) = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00053C20 File Offset: 0x00051E20
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0000A917 File Offset: 0x00008B17
		public unsafe Vector4 m_ScreenSizeOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenSizeOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenSizeOverride)) = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00053C48 File Offset: 0x00051E48
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000A932 File Offset: 0x00008B32
		public unsafe Vector4 m_ScreenCoordScaleBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenCoordScaleBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_ScreenCoordScaleBias)) = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00053C70 File Offset: 0x00051E70
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x0000A94D File Offset: 0x00008B4D
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00053CA0 File Offset: 0x00051EA0
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0000A96C File Offset: 0x00008B6C
		public unsafe bool m_RequiresDepthTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresDepthTexture)) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00053CC8 File Offset: 0x00051EC8
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000A987 File Offset: 0x00008B87
		public unsafe bool m_RequiresColorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresColorTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_RequiresColorTexture)) = value;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00053CF0 File Offset: 0x00051EF0
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000A9A2 File Offset: 0x00008BA2
		public unsafe float m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00053D18 File Offset: 0x00051F18
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000A9BD File Offset: 0x00008BBD
		public unsafe MotionVectorsPersistentData m_MotionVectorsPersistentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_MotionVectorsPersistentData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionVectorsPersistentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_MotionVectorsPersistentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00053D48 File Offset: 0x00051F48
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public unsafe TaaPersistentData m_TaaPersistentData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaPersistentData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaaPersistentData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaPersistentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00053D78 File Offset: 0x00051F78
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000A9FB File Offset: 0x00008BFB
		public unsafe TemporalAA.Settings m_TaaSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_TaaSettings)) = value;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x00053DA0 File Offset: 0x00051FA0
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0000AA16 File Offset: 0x00008C16
		public unsafe static UniversalAdditionalCameraData s_DefaultAdditionalCameraData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_s_DefaultAdditionalCameraData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_s_DefaultAdditionalCameraData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00053DC8 File Offset: 0x00051FC8
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000AA28 File Offset: 0x00008C28
		public unsafe static List<VolumeStack> s_CachedVolumeStacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_s_CachedVolumeStacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeStack>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.NativeFieldInfoPtr_s_CachedVolumeStacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x00053DF0 File Offset: 0x00051FF0
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000AA3A File Offset: 0x00008C3A
		public unsafe VolumeStack m_VolumeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalAdditionalCameraData.NativeFieldInfoPtr_m_VolumeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_k_GizmoPath;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr_k_BaseCameraGizmoPath;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr_k_OverlayCameraGizmoPath;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr_k_PostProcessingGizmoPath;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderShadows;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiresDepthTextureOption;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiresOpaqueTextureOption;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraType;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr_m_Cameras;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererIndex;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr_m_VolumeLayerMask;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr_m_VolumeTrigger;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeFieldInfoPtr_m_VolumeFrameworkUpdateModeOption;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderPostProcessing;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr_m_Antialiasing;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeFieldInfoPtr_m_AntialiasingQuality;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeFieldInfoPtr_m_StopNaN;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr_m_Dithering;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDepth;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowXRRendering;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowHDROutput;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeFieldInfoPtr_m_UseScreenCoordOverride;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenSizeOverride;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenCoordScaleBias;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiresDepthTexture;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiresColorTexture;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionVectorsPersistentData;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_m_TaaPersistentData;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_m_TaaSettings;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultAdditionalCameraData;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_s_CachedVolumeStacks;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_m_VolumeStack;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_Single_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultAdditionalCameraData_Internal_Static_get_UniversalAdditionalCameraData_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_get_camera_Internal_get_Camera_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_renderShadows_Public_get_Boolean_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_set_renderShadows_Public_set_Void_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresDepthOption_Public_get_CameraOverrideOption_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_set_requiresDepthOption_Public_set_Void_CameraOverrideOption_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresColorOption_Public_get_CameraOverrideOption_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_set_requiresColorOption_Public_set_Void_CameraOverrideOption_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_get_renderType_Public_get_CameraRenderType_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_set_renderType_Public_set_Void_CameraRenderType_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraStack_Public_get_List_1_Camera_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraStack_Internal_Void_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDepth_Public_get_Boolean_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresDepthTexture_Public_get_Boolean_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_set_requiresDepthTexture_Public_set_Void_Boolean_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresColorTexture_Public_get_Boolean_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_set_requiresColorTexture_Public_set_Void_Boolean_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_get_scriptableRenderer_Public_get_ScriptableRenderer_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_SetRenderer_Public_Void_Int32_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeLayerMask_Public_get_LayerMask_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeLayerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeTrigger_Public_get_Transform_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeTrigger_Public_set_Void_Transform_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeFrameworkUpdateMode_Internal_get_VolumeFrameworkUpdateMode_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeFrameworkUpdateMode_Internal_set_Void_VolumeFrameworkUpdateMode_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_get_requiresVolumeFrameworkUpdate_Public_get_Boolean_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_get_volumeStack_Public_get_VolumeStack_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_set_volumeStack_Public_set_Void_VolumeStack_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateVolumeStack_Internal_Void_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_renderPostProcessing_Public_get_Boolean_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_set_renderPostProcessing_Public_set_Void_Boolean_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_get_antialiasing_Public_get_AntialiasingMode_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_set_antialiasing_Public_set_Void_AntialiasingMode_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_get_antialiasingQuality_Public_get_AntialiasingQuality_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_set_antialiasingQuality_Public_set_Void_AntialiasingQuality_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_get_taaSettings_Public_get_byref_Settings_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_get_taaPersistentData_Internal_get_TaaPersistentData_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_get_motionVectorsPersistentData_Internal_get_MotionVectorsPersistentData_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_get_resetHistory_Public_get_Boolean_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_set_resetHistory_Public_set_Void_Boolean_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_get_stopNaN_Public_get_Boolean_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_set_stopNaN_Public_set_Void_Boolean_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_get_dithering_Public_get_Boolean_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_set_dithering_Public_set_Void_Boolean_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_get_allowXRRendering_Public_get_Boolean_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_set_allowXRRendering_Public_set_Void_Boolean_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_get_useScreenCoordOverride_Public_get_Boolean_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_set_useScreenCoordOverride_Public_set_Void_Boolean_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_get_screenSizeOverride_Public_get_Vector4_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_set_screenSizeOverride_Public_set_Void_Vector4_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_get_screenCoordScaleBias_Public_get_Vector4_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_set_screenCoordScaleBias_Public_set_Void_Vector4_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_get_allowHDROutput_Public_get_Boolean_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_set_allowHDROutput_Public_set_Void_Boolean_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_GetRawRenderer_Private_ScriptableRenderer_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001C7 RID: 455
		[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalAdditionalCameraData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600205A RID: 8282 RVA: 0x0007E6B8 File Offset: 0x0007C8B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalAdditionalCameraData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr);
				UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr, "<>9");
				UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr, "<>9__52_0");
				UniversalAdditionalCameraData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr, 100665577);
				UniversalAdditionalCameraData.__c.NativeMethodInfoPtr__UpdateCameraStack_b__52_0_Internal_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr, 100665578);
			}

			// Token: 0x0600205B RID: 8283 RVA: 0x0007E734 File Offset: 0x0007C934
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalAdditionalCameraData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600205C RID: 8284 RVA: 0x0007E770 File Offset: 0x0007C970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 618868, XrefRangeEnd = 618879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCameraStack_b__52_0(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalAdditionalCameraData.__c.NativeMethodInfoPtr__UpdateCameraStack_b__52_0_Internal_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600205D RID: 8285 RVA: 0x0001282C File Offset: 0x00010A2C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x0600205E RID: 8286 RVA: 0x0007E7C0 File Offset: 0x0007C9C0
			// (set) Token: 0x0600205F RID: 8287 RVA: 0x00012835 File Offset: 0x00010A35
			public unsafe static UniversalAdditionalCameraData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002060 RID: 8288 RVA: 0x0007E7E8 File Offset: 0x0007C9E8
			// (set) Token: 0x06002061 RID: 8289 RVA: 0x00012847 File Offset: 0x00010A47
			public unsafe static Predicate<Camera> __9__52_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UniversalAdditionalCameraData.__c.NativeFieldInfoPtr___9__52_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeFieldInfoPtr___9__52_0;

			// Token: 0x04001713 RID: 5907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCameraStack_b__52_0_Internal_Boolean_Camera_0;
		}
	}
}
