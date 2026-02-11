using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000077 RID: 119
	public sealed class Camera : Behaviour
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x00022BE0 File Offset: 0x00020DE0
		// Note: this type is marked as 'beforefieldinit'.
		static Camera()
		{
			Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Camera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
			Camera.NativeFieldInfoPtr_kMinAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinAperture");
			Camera.NativeFieldInfoPtr_kMaxAperture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxAperture");
			Camera.NativeFieldInfoPtr_kMinBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMinBladeCount");
			Camera.NativeFieldInfoPtr_kMaxBladeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "kMaxBladeCount");
			Camera.NativeFieldInfoPtr_onPreCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreCull");
			Camera.NativeFieldInfoPtr_onPreRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPreRender");
			Camera.NativeFieldInfoPtr_onPostRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "onPostRender");
			Camera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663735);
			Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663736);
			Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663737);
			Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663738);
			Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663739);
			Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663740);
			Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663741);
			Camera.NativeMethodInfoPtr_get_renderingPath_Public_get_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663742);
			Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663743);
			Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663744);
			Camera.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663745);
			Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663746);
			Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663747);
			Camera.NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663748);
			Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663749);
			Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663750);
			Camera.NativeMethodInfoPtr_set_allowDynamicResolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663751);
			Camera.NativeMethodInfoPtr_get_forceIntoRenderTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663752);
			Camera.NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663753);
			Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663754);
			Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663755);
			Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663756);
			Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663757);
			Camera.NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663758);
			Camera.NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663759);
			Camera.NativeMethodInfoPtr_get_transparencySortMode_Public_get_TransparencySortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663760);
			Camera.NativeMethodInfoPtr_set_transparencySortMode_Public_set_Void_TransparencySortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663761);
			Camera.NativeMethodInfoPtr_get_transparencySortAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663762);
			Camera.NativeMethodInfoPtr_set_transparencySortAxis_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663763);
			Camera.NativeMethodInfoPtr_ResetTransparencySortSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663764);
			Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663765);
			Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663766);
			Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663767);
			Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663768);
			Camera.NativeMethodInfoPtr_ResetAspect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663769);
			Camera.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663770);
			Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663771);
			Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663772);
			Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663773);
			Camera.NativeMethodInfoPtr_set_eventMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663774);
			Camera.NativeMethodInfoPtr_get_layerCullSpherical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663775);
			Camera.NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663776);
			Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663777);
			Camera.NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663778);
			Camera.NativeMethodInfoPtr_get_skyboxMaterial_Internal_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663779);
			Camera.NativeMethodInfoPtr_get_overrideSceneCullingMask_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663780);
			Camera.NativeMethodInfoPtr_set_overrideSceneCullingMask_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663781);
			Camera.NativeMethodInfoPtr_get_sceneCullingMask_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663782);
			Camera.NativeMethodInfoPtr_GetLayerCullDistances_Private_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663783);
			Camera.NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663784);
			Camera.NativeMethodInfoPtr_get_layerCullDistances_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663785);
			Camera.NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663786);
			Camera.NativeMethodInfoPtr_get_PreviewCullingLayer_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663787);
			Camera.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663788);
			Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663789);
			Camera.NativeMethodInfoPtr_get_cullingMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663790);
			Camera.NativeMethodInfoPtr_set_cullingMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663791);
			Camera.NativeMethodInfoPtr_ResetCullingMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663792);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663793);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663794);
			Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663795);
			Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663796);
			Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663797);
			Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663798);
			Camera.NativeMethodInfoPtr_get_clearStencilAfterLightingPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663799);
			Camera.NativeMethodInfoPtr_set_clearStencilAfterLightingPass_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663800);
			Camera.NativeMethodInfoPtr_SetReplacementShader_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663801);
			Camera.NativeMethodInfoPtr_ResetReplacementShader_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663802);
			Camera.NativeMethodInfoPtr_get_projectionMatrixMode_Internal_get_ProjectionMatrixMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663803);
			Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663804);
			Camera.NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663805);
			Camera.NativeMethodInfoPtr_get_iso_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663806);
			Camera.NativeMethodInfoPtr_set_iso_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663807);
			Camera.NativeMethodInfoPtr_get_shutterSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663808);
			Camera.NativeMethodInfoPtr_set_shutterSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663809);
			Camera.NativeMethodInfoPtr_get_aperture_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663810);
			Camera.NativeMethodInfoPtr_set_aperture_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663811);
			Camera.NativeMethodInfoPtr_get_focusDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663812);
			Camera.NativeMethodInfoPtr_set_focusDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663813);
			Camera.NativeMethodInfoPtr_get_focalLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663814);
			Camera.NativeMethodInfoPtr_set_focalLength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663815);
			Camera.NativeMethodInfoPtr_get_bladeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663816);
			Camera.NativeMethodInfoPtr_set_bladeCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663817);
			Camera.NativeMethodInfoPtr_get_curvature_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663818);
			Camera.NativeMethodInfoPtr_set_curvature_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663819);
			Camera.NativeMethodInfoPtr_get_barrelClipping_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663820);
			Camera.NativeMethodInfoPtr_set_barrelClipping_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663821);
			Camera.NativeMethodInfoPtr_get_anamorphism_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663822);
			Camera.NativeMethodInfoPtr_set_anamorphism_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663823);
			Camera.NativeMethodInfoPtr_get_sensorSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663824);
			Camera.NativeMethodInfoPtr_set_sensorSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663825);
			Camera.NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663826);
			Camera.NativeMethodInfoPtr_set_lensShift_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663827);
			Camera.NativeMethodInfoPtr_get_gateFit_Public_get_GateFitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663828);
			Camera.NativeMethodInfoPtr_set_gateFit_Public_set_Void_GateFitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663829);
			Camera.NativeMethodInfoPtr_GetGateFittedFieldOfView_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663830);
			Camera.NativeMethodInfoPtr_GetGateFittedLensShift_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663831);
			Camera.NativeMethodInfoPtr_GetLocalSpaceAim_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663832);
			Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663833);
			Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663834);
			Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663835);
			Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663836);
			Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663837);
			Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663838);
			Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663839);
			Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663840);
			Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663841);
			Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663842);
			Camera.NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663843);
			Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663844);
			Camera.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663845);
			Camera.NativeMethodInfoPtr_SetTargetBuffersImpl_Private_Void_RenderBuffer_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663846);
			Camera.NativeMethodInfoPtr_SetTargetBuffers_Public_Void_RenderBuffer_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663847);
			Camera.NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Private_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663848);
			Camera.NativeMethodInfoPtr_SetTargetBuffers_Public_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663849);
			Camera.NativeMethodInfoPtr_GetCameraBufferWarnings_Internal_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663850);
			Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663851);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663852);
			Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663853);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663854);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663855);
			Camera.NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663856);
			Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663857);
			Camera.NativeMethodInfoPtr_get_useJitteredProjectionMatrixForTransparentRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663858);
			Camera.NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663859);
			Camera.NativeMethodInfoPtr_get_previousViewProjectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663860);
			Camera.NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663861);
			Camera.NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663862);
			Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663863);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663864);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663865);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663866);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663867);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663868);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663869);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663870);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663871);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663872);
			Camera.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663873);
			Camera.NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Internal_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663874);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663875);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663876);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663877);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663878);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663879);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663880);
			Camera.NativeMethodInfoPtr_CalculateFrustumCornersInternal_Private_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663881);
			Camera.NativeMethodInfoPtr_CalculateFrustumCorners_Public_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663882);
			Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Private_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663883);
			Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalProperties_Public_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663884);
			Camera.NativeMethodInfoPtr_FocalLengthToFieldOfView_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663885);
			Camera.NativeMethodInfoPtr_FieldOfViewToFocalLength_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663886);
			Camera.NativeMethodInfoPtr_HorizontalToVerticalFieldOfView_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663887);
			Camera.NativeMethodInfoPtr_VerticalToHorizontalFieldOfView_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663888);
			Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663889);
			Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663890);
			Camera.NativeMethodInfoPtr_get_scene_Public_get_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663891);
			Camera.NativeMethodInfoPtr_set_scene_Public_set_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663892);
			Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663893);
			Camera.NativeMethodInfoPtr_get_stereoSeparation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663894);
			Camera.NativeMethodInfoPtr_set_stereoSeparation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663895);
			Camera.NativeMethodInfoPtr_get_stereoConvergence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663896);
			Camera.NativeMethodInfoPtr_set_stereoConvergence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663897);
			Camera.NativeMethodInfoPtr_get_areVRStereoViewMatricesWithinSingleCullTolerance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663898);
			Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663899);
			Camera.NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663900);
			Camera.NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663901);
			Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663902);
			Camera.NativeMethodInfoPtr_GetStereoViewMatrix_Public_Matrix4x4_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663903);
			Camera.NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663904);
			Camera.NativeMethodInfoPtr_GetStereoProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663905);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663906);
			Camera.NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663907);
			Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663908);
			Camera.NativeMethodInfoPtr_ResetStereoViewMatrices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663909);
			Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663910);
			Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663911);
			Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663912);
			Camera.NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663913);
			Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663914);
			Camera.NativeMethodInfoPtr_RenderToCubemapImpl_Private_Boolean_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663915);
			Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663916);
			Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663917);
			Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663918);
			Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663919);
			Camera.NativeMethodInfoPtr_GetFilterMode_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663920);
			Camera.NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663921);
			Camera.NativeMethodInfoPtr_RenderToCubemapEyeImpl_Private_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663922);
			Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663923);
			Camera.NativeMethodInfoPtr_Render_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663924);
			Camera.NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663925);
			Camera.NativeMethodInfoPtr_RenderDontRestore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663926);
			Camera.NativeMethodInfoPtr_SubmitRenderRequests_Public_Void_List_1_RenderRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663927);
			Camera.NativeMethodInfoPtr_SubmitRenderRequest_Public_Void_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663928);
			Camera.NativeMethodInfoPtr_SubmitRenderRequestsInternal_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663929);
			Camera.NativeMethodInfoPtr_SubmitBuiltInObjectIDRenderRequest_Private_Il2CppReferenceArray_1_Object_RenderTexture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663930);
			Camera.NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663931);
			Camera.NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663932);
			Camera.NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663933);
			Camera.NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663934);
			Camera.NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663935);
			Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663936);
			Camera.NativeMethodInfoPtr_AddCommandBufferAsyncImpl_Private_Void_CameraEvent_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663937);
			Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663938);
			Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663939);
			Camera.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_CameraEvent_CommandBuffer_ComputeQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663940);
			Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663941);
			Camera.NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663942);
			Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663943);
			Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663944);
			Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663945);
			Camera.NativeMethodInfoPtr_OnlyUsedForTesting1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663946);
			Camera.NativeMethodInfoPtr_OnlyUsedForTesting2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663947);
			Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663948);
			Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663949);
			Camera.NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663950);
			Camera.NativeMethodInfoPtr_get_transparencySortAxis_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663951);
			Camera.NativeMethodInfoPtr_set_transparencySortAxis_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663952);
			Camera.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663953);
			Camera.NativeMethodInfoPtr_get_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663954);
			Camera.NativeMethodInfoPtr_set_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663955);
			Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663956);
			Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663957);
			Camera.NativeMethodInfoPtr_get_curvature_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663958);
			Camera.NativeMethodInfoPtr_set_curvature_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663959);
			Camera.NativeMethodInfoPtr_get_sensorSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663960);
			Camera.NativeMethodInfoPtr_set_sensorSize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663961);
			Camera.NativeMethodInfoPtr_get_lensShift_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663962);
			Camera.NativeMethodInfoPtr_set_lensShift_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663963);
			Camera.NativeMethodInfoPtr_GetGateFittedLensShift_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663964);
			Camera.NativeMethodInfoPtr_GetLocalSpaceAim_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663965);
			Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663966);
			Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663967);
			Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663968);
			Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663969);
			Camera.NativeMethodInfoPtr_SetTargetBuffersImpl_Injected_Private_Void_byref_RenderBuffer_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663970);
			Camera.NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Injected_Private_Void_Il2CppStructArray_1_RenderBuffer_byref_RenderBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663971);
			Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663972);
			Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663973);
			Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663974);
			Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663975);
			Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663976);
			Camera.NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663977);
			Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663978);
			Camera.NativeMethodInfoPtr_get_previousViewProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663979);
			Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663980);
			Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663981);
			Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663982);
			Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663983);
			Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663984);
			Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663985);
			Camera.NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663986);
			Camera.NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Injected_Private_Void_Single_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663987);
			Camera.NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663988);
			Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663989);
			Camera.NativeMethodInfoPtr_CalculateFrustumCornersInternal_Injected_Private_Void_byref_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663990);
			Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Private_Static_Void_byref_Matrix4x4_Single_byref_Vector2_byref_Vector2_Single_Single_Single_GateFitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663991);
			Camera.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663992);
			Camera.NativeMethodInfoPtr_set_scene_Injected_Private_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663993);
			Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663994);
			Camera.NativeMethodInfoPtr_GetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663995);
			Camera.NativeMethodInfoPtr_GetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663996);
			Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663997);
			Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100663998);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0002413C File Offset: 0x0002233C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00024178 File Offset: 0x00022378
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x000241B4 File Offset: 0x000223B4
		public unsafe float nearClipPlane
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 645316, RefRangeEnd = 645341, XrefRangeStart = 645314, XrefRangeEnd = 645316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645343, RefRangeEnd = 645344, XrefRangeStart = 645341, XrefRangeEnd = 645343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000241F4 File Offset: 0x000223F4
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00024230 File Offset: 0x00022430
		public unsafe float farClipPlane
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 645346, RefRangeEnd = 645369, XrefRangeStart = 645344, XrefRangeEnd = 645346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645371, RefRangeEnd = 645372, XrefRangeStart = 645369, XrefRangeEnd = 645371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00024270 File Offset: 0x00022470
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x000242AC File Offset: 0x000224AC
		public unsafe float fieldOfView
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 645374, RefRangeEnd = 645386, XrefRangeStart = 645372, XrefRangeEnd = 645374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 645388, RefRangeEnd = 645394, XrefRangeStart = 645386, XrefRangeEnd = 645388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x000242EC File Offset: 0x000224EC
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00024328 File Offset: 0x00022528
		public unsafe RenderingPath renderingPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645394, XrefRangeEnd = 645396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_renderingPath_Public_get_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645396, XrefRangeEnd = 645398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00024368 File Offset: 0x00022568
		public unsafe RenderingPath actualRenderingPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645398, XrefRangeEnd = 645400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000243A4 File Offset: 0x000225A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645400, XrefRangeEnd = 645402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x000243D8 File Offset: 0x000225D8
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00024414 File Offset: 0x00022614
		public unsafe bool allowHDR
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645404, RefRangeEnd = 645405, XrefRangeStart = 645402, XrefRangeEnd = 645404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645405, XrefRangeEnd = 645407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00024454 File Offset: 0x00022654
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00024490 File Offset: 0x00022690
		public unsafe bool allowMSAA
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645409, RefRangeEnd = 645411, XrefRangeStart = 645407, XrefRangeEnd = 645409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645411, XrefRangeEnd = 645413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x000244D0 File Offset: 0x000226D0
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x0002450C File Offset: 0x0002270C
		public unsafe bool allowDynamicResolution
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 645415, RefRangeEnd = 645421, XrefRangeStart = 645413, XrefRangeEnd = 645415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645421, XrefRangeEnd = 645423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_allowDynamicResolution_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002454C File Offset: 0x0002274C
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00024588 File Offset: 0x00022788
		public unsafe bool forceIntoRenderTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645423, XrefRangeEnd = 645425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_forceIntoRenderTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645425, XrefRangeEnd = 645427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000245C8 File Offset: 0x000227C8
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00024604 File Offset: 0x00022804
		public unsafe float orthographicSize
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 645429, RefRangeEnd = 645435, XrefRangeStart = 645427, XrefRangeEnd = 645429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645437, RefRangeEnd = 645439, XrefRangeStart = 645435, XrefRangeEnd = 645437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00024644 File Offset: 0x00022844
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00024680 File Offset: 0x00022880
		public unsafe bool orthographic
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 645441, RefRangeEnd = 645459, XrefRangeStart = 645439, XrefRangeEnd = 645441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645459, XrefRangeEnd = 645461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000246C0 File Offset: 0x000228C0
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000246FC File Offset: 0x000228FC
		public unsafe UnityEngine.Rendering.OpaqueSortMode opaqueSortMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645463, RefRangeEnd = 645465, XrefRangeStart = 645461, XrefRangeEnd = 645463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645465, XrefRangeEnd = 645467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0002473C File Offset: 0x0002293C
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00024778 File Offset: 0x00022978
		public unsafe TransparencySortMode transparencySortMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645467, XrefRangeEnd = 645469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_transparencySortMode_Public_get_TransparencySortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645469, XrefRangeEnd = 645471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_transparencySortMode_Public_set_Void_TransparencySortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000247B8 File Offset: 0x000229B8
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x000247F4 File Offset: 0x000229F4
		public unsafe Vector3 transparencySortAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645471, XrefRangeEnd = 645473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_transparencySortAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645473, XrefRangeEnd = 645475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_transparencySortAxis_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00024834 File Offset: 0x00022A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645475, XrefRangeEnd = 645477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTransparencySortSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetTransparencySortSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00024868 File Offset: 0x00022A68
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x000248A4 File Offset: 0x00022AA4
		public unsafe float depth
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 645479, RefRangeEnd = 645490, XrefRangeStart = 645477, XrefRangeEnd = 645479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645490, XrefRangeEnd = 645492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000248E4 File Offset: 0x00022AE4
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00024920 File Offset: 0x00022B20
		public unsafe float aspect
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 645494, RefRangeEnd = 645497, XrefRangeStart = 645492, XrefRangeEnd = 645494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_aspect_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645499, RefRangeEnd = 645500, XrefRangeStart = 645497, XrefRangeEnd = 645499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00024960 File Offset: 0x00022B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645500, XrefRangeEnd = 645502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAspect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetAspect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00024994 File Offset: 0x00022B94
		public unsafe Vector3 velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645502, XrefRangeEnd = 645504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000249D0 File Offset: 0x00022BD0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00024A0C File Offset: 0x00022C0C
		public unsafe int cullingMask
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 645506, RefRangeEnd = 645521, XrefRangeStart = 645504, XrefRangeEnd = 645506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645521, XrefRangeEnd = 645523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00024A4C File Offset: 0x00022C4C
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00024A88 File Offset: 0x00022C88
		public unsafe int eventMask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 645525, RefRangeEnd = 645528, XrefRangeStart = 645523, XrefRangeEnd = 645525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645528, XrefRangeEnd = 645530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_eventMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00024AC8 File Offset: 0x00022CC8
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00024B04 File Offset: 0x00022D04
		public unsafe bool layerCullSpherical
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645530, XrefRangeEnd = 645532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_layerCullSpherical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645532, XrefRangeEnd = 645534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00024B44 File Offset: 0x00022D44
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00024B80 File Offset: 0x00022D80
		public unsafe CameraType cameraType
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 645536, RefRangeEnd = 645556, XrefRangeStart = 645534, XrefRangeEnd = 645536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645556, XrefRangeEnd = 645558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00024BC0 File Offset: 0x00022DC0
		public unsafe Material skyboxMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645558, XrefRangeEnd = 645560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_skyboxMaterial_Internal_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00024C00 File Offset: 0x00022E00
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00024C3C File Offset: 0x00022E3C
		public unsafe ulong overrideSceneCullingMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645560, XrefRangeEnd = 645562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_overrideSceneCullingMask_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645562, XrefRangeEnd = 645564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_overrideSceneCullingMask_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00024C7C File Offset: 0x00022E7C
		public unsafe ulong sceneCullingMask
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645564, XrefRangeEnd = 645566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_sceneCullingMask_Internal_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00024CB8 File Offset: 0x00022EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645566, XrefRangeEnd = 645568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetLayerCullDistances()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetLayerCullDistances_Private_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00024CF8 File Offset: 0x00022EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645568, XrefRangeEnd = 645570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerCullDistances(Il2CppStructArray<float> d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00024D3C File Offset: 0x00022F3C
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00024D7C File Offset: 0x00022F7C
		public unsafe Il2CppStructArray<float> layerCullDistances
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_layerCullDistances_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645570, XrefRangeEnd = 645579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00024DC0 File Offset: 0x00022FC0
		public unsafe static int PreviewCullingLayer
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_PreviewCullingLayer_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00024DF0 File Offset: 0x00022FF0
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00024E2C File Offset: 0x0002302C
		public unsafe bool useOcclusionCulling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645579, XrefRangeEnd = 645581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645581, XrefRangeEnd = 645583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00024E6C File Offset: 0x0002306C
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00024EA8 File Offset: 0x000230A8
		public unsafe Matrix4x4 cullingMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645583, XrefRangeEnd = 645585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645585, XrefRangeEnd = 645587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cullingMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00024EE8 File Offset: 0x000230E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645587, XrefRangeEnd = 645589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCullingMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetCullingMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00024F1C File Offset: 0x0002311C
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00024F58 File Offset: 0x00023158
		public unsafe Color backgroundColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645591, RefRangeEnd = 645593, XrefRangeStart = 645589, XrefRangeEnd = 645591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645595, RefRangeEnd = 645597, XrefRangeStart = 645593, XrefRangeEnd = 645595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00024F98 File Offset: 0x00023198
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00024FD4 File Offset: 0x000231D4
		public unsafe CameraClearFlags clearFlags
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 645599, RefRangeEnd = 645607, XrefRangeStart = 645597, XrefRangeEnd = 645599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645607, XrefRangeEnd = 645609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00025014 File Offset: 0x00023214
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00025050 File Offset: 0x00023250
		public unsafe DepthTextureMode depthTextureMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645611, RefRangeEnd = 645612, XrefRangeStart = 645609, XrefRangeEnd = 645611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645614, RefRangeEnd = 645615, XrefRangeStart = 645612, XrefRangeEnd = 645614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00025090 File Offset: 0x00023290
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x000250CC File Offset: 0x000232CC
		public unsafe bool clearStencilAfterLightingPass
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645615, XrefRangeEnd = 645617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_clearStencilAfterLightingPass_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645617, XrefRangeEnd = 645619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_clearStencilAfterLightingPass_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0002510C File Offset: 0x0002330C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645619, XrefRangeEnd = 645621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReplacementShader(Shader shader, string replacementTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacementTag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetReplacementShader_Public_Void_Shader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00025160 File Offset: 0x00023360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645621, XrefRangeEnd = 645623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetReplacementShader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetReplacementShader_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00025194 File Offset: 0x00023394
		public unsafe Camera.ProjectionMatrixMode projectionMatrixMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645623, XrefRangeEnd = 645625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrixMode_Internal_get_ProjectionMatrixMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x000251D0 File Offset: 0x000233D0
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0002520C File Offset: 0x0002340C
		public unsafe bool usePhysicalProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645625, XrefRangeEnd = 645627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645627, XrefRangeEnd = 645629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0002524C File Offset: 0x0002344C
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00025288 File Offset: 0x00023488
		public unsafe int iso
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645629, XrefRangeEnd = 645631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_iso_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645631, XrefRangeEnd = 645633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_iso_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000252C8 File Offset: 0x000234C8
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00025304 File Offset: 0x00023504
		public unsafe float shutterSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645633, XrefRangeEnd = 645635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_shutterSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645635, XrefRangeEnd = 645637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_shutterSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00025344 File Offset: 0x00023544
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00025380 File Offset: 0x00023580
		public unsafe float aperture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645637, XrefRangeEnd = 645639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_aperture_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645639, XrefRangeEnd = 645641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_aperture_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x000253C0 File Offset: 0x000235C0
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000253FC File Offset: 0x000235FC
		public unsafe float focusDistance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645641, XrefRangeEnd = 645643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_focusDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645643, XrefRangeEnd = 645645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_focusDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0002543C File Offset: 0x0002363C
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00025478 File Offset: 0x00023678
		public unsafe float focalLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645645, XrefRangeEnd = 645647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_focalLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645647, XrefRangeEnd = 645649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_focalLength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000254B8 File Offset: 0x000236B8
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000254F4 File Offset: 0x000236F4
		public unsafe int bladeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645649, XrefRangeEnd = 645651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_bladeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645651, XrefRangeEnd = 645653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_bladeCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00025534 File Offset: 0x00023734
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00025570 File Offset: 0x00023770
		public unsafe Vector2 curvature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645653, XrefRangeEnd = 645655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_curvature_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645655, XrefRangeEnd = 645657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_curvature_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000255B0 File Offset: 0x000237B0
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x000255EC File Offset: 0x000237EC
		public unsafe float barrelClipping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645657, XrefRangeEnd = 645659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_barrelClipping_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645659, XrefRangeEnd = 645661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_barrelClipping_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0002562C File Offset: 0x0002382C
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00025668 File Offset: 0x00023868
		public unsafe float anamorphism
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645661, XrefRangeEnd = 645663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_anamorphism_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645663, XrefRangeEnd = 645665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_anamorphism_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000256A8 File Offset: 0x000238A8
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x000256E4 File Offset: 0x000238E4
		public unsafe Vector2 sensorSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645665, XrefRangeEnd = 645667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_sensorSize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645667, XrefRangeEnd = 645669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_sensorSize_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00025724 File Offset: 0x00023924
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00025760 File Offset: 0x00023960
		public unsafe Vector2 lensShift
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645669, XrefRangeEnd = 645671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645671, XrefRangeEnd = 645673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_lensShift_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000257A0 File Offset: 0x000239A0
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000257DC File Offset: 0x000239DC
		public unsafe Camera.GateFitMode gateFit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645673, XrefRangeEnd = 645675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_gateFit_Public_get_GateFitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645675, XrefRangeEnd = 645677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_gateFit_Public_set_Void_GateFitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0002581C File Offset: 0x00023A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645677, XrefRangeEnd = 645679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetGateFittedFieldOfView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetGateFittedFieldOfView_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00025858 File Offset: 0x00023A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645679, XrefRangeEnd = 645681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetGateFittedLensShift()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetGateFittedLensShift_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00025894 File Offset: 0x00023A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645681, XrefRangeEnd = 645683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetLocalSpaceAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetLocalSpaceAim_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000258D0 File Offset: 0x00023AD0
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0002590C File Offset: 0x00023B0C
		public unsafe Rect rect
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 645685, RefRangeEnd = 645691, XrefRangeStart = 645683, XrefRangeEnd = 645685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 645693, RefRangeEnd = 645698, XrefRangeStart = 645691, XrefRangeEnd = 645693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0002594C File Offset: 0x00023B4C
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00025988 File Offset: 0x00023B88
		public unsafe Rect pixelRect
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 645700, RefRangeEnd = 645710, XrefRangeStart = 645698, XrefRangeEnd = 645700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645712, RefRangeEnd = 645713, XrefRangeStart = 645710, XrefRangeEnd = 645712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000259C8 File Offset: 0x00023BC8
		public unsafe int pixelWidth
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 645715, RefRangeEnd = 645724, XrefRangeStart = 645713, XrefRangeEnd = 645715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00025A04 File Offset: 0x00023C04
		public unsafe int pixelHeight
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 645726, RefRangeEnd = 645735, XrefRangeStart = 645724, XrefRangeEnd = 645726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00025A40 File Offset: 0x00023C40
		public unsafe int scaledPixelWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645735, XrefRangeEnd = 645737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00025A7C File Offset: 0x00023C7C
		public unsafe int scaledPixelHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645737, XrefRangeEnd = 645739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00025AB8 File Offset: 0x00023CB8
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00025AF8 File Offset: 0x00023CF8
		public unsafe RenderTexture targetTexture
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 645741, RefRangeEnd = 645757, XrefRangeStart = 645739, XrefRangeEnd = 645741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 645759, RefRangeEnd = 645761, XrefRangeStart = 645757, XrefRangeEnd = 645759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00025B3C File Offset: 0x00023D3C
		public unsafe RenderTexture activeTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645761, XrefRangeEnd = 645763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00025B7C File Offset: 0x00023D7C
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00025BB8 File Offset: 0x00023DB8
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 645765, RefRangeEnd = 645768, XrefRangeStart = 645763, XrefRangeEnd = 645765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645768, XrefRangeEnd = 645770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00025BF8 File Offset: 0x00023DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645770, XrefRangeEnd = 645772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffersImpl_Private_Void_RenderBuffer_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00025C44 File Offset: 0x00023E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645772, XrefRangeEnd = 645774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colorBuffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffers_Public_Void_RenderBuffer_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00025C90 File Offset: 0x00023E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645774, XrefRangeEnd = 645776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffersMRTImpl(Il2CppStructArray<RenderBuffer> color, RenderBuffer depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Private_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00025CE0 File Offset: 0x00023EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645776, XrefRangeEnd = 645778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffers(Il2CppStructArray<RenderBuffer> colorBuffer, RenderBuffer depthBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffers_Public_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00025D30 File Offset: 0x00023F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645778, XrefRangeEnd = 645780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetCameraBufferWarnings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetCameraBufferWarnings_Internal_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00025D70 File Offset: 0x00023F70
		public unsafe Matrix4x4 cameraToWorldMatrix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645782, RefRangeEnd = 645783, XrefRangeStart = 645780, XrefRangeEnd = 645782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00025DAC File Offset: 0x00023FAC
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00025DE8 File Offset: 0x00023FE8
		public unsafe Matrix4x4 worldToCameraMatrix
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 645785, RefRangeEnd = 645792, XrefRangeStart = 645783, XrefRangeEnd = 645785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645794, RefRangeEnd = 645795, XrefRangeStart = 645792, XrefRangeEnd = 645794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00025E28 File Offset: 0x00024028
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00025E64 File Offset: 0x00024064
		public unsafe Matrix4x4 projectionMatrix
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 645797, RefRangeEnd = 645804, XrefRangeStart = 645795, XrefRangeEnd = 645797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645804, XrefRangeEnd = 645806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00025EA4 File Offset: 0x000240A4
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00025EE0 File Offset: 0x000240E0
		public unsafe Matrix4x4 nonJitteredProjectionMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645806, XrefRangeEnd = 645808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645808, XrefRangeEnd = 645810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00025F20 File Offset: 0x00024120
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00025F5C File Offset: 0x0002415C
		public unsafe bool useJitteredProjectionMatrixForTransparentRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645810, XrefRangeEnd = 645812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_useJitteredProjectionMatrixForTransparentRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645812, XrefRangeEnd = 645814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00025F9C File Offset: 0x0002419C
		public unsafe Matrix4x4 previousViewProjectionMatrix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645814, XrefRangeEnd = 645816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_previousViewProjectionMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00025FD8 File Offset: 0x000241D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645818, RefRangeEnd = 645819, XrefRangeStart = 645816, XrefRangeEnd = 645818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetWorldToCameraMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002600C File Offset: 0x0002420C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645819, XrefRangeEnd = 645821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetProjectionMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00026040 File Offset: 0x00024240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645821, XrefRangeEnd = 645823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipPlane;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002608C File Offset: 0x0002428C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645823, XrefRangeEnd = 645825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000260E4 File Offset: 0x000242E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645825, XrefRangeEnd = 645827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002613C File Offset: 0x0002433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645827, XrefRangeEnd = 645829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00026194 File Offset: 0x00024394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645829, XrefRangeEnd = 645831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000261EC File Offset: 0x000243EC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 645833, RefRangeEnd = 645849, XrefRangeStart = 645831, XrefRangeEnd = 645833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToScreenPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00026238 File Offset: 0x00024438
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 645851, RefRangeEnd = 645856, XrefRangeStart = 645849, XrefRangeEnd = 645851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 WorldToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00026284 File Offset: 0x00024484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645856, XrefRangeEnd = 645858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x000262D0 File Offset: 0x000244D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 645860, RefRangeEnd = 645867, XrefRangeStart = 645858, XrefRangeEnd = 645860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToWorldPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002631C File Offset: 0x0002451C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 645869, RefRangeEnd = 645873, XrefRangeStart = 645867, XrefRangeEnd = 645869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ScreenToViewportPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00026368 File Offset: 0x00024568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645873, XrefRangeEnd = 645875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ViewportToScreenPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000263B4 File Offset: 0x000245B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645875, XrefRangeEnd = 645877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetFrustumPlaneSizeAt(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Internal_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00026400 File Offset: 0x00024600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645877, XrefRangeEnd = 645879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00026458 File Offset: 0x00024658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645879, XrefRangeEnd = 645881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000264B0 File Offset: 0x000246B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 645883, RefRangeEnd = 645887, XrefRangeStart = 645881, XrefRangeEnd = 645883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ViewportPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000264FC File Offset: 0x000246FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645887, XrefRangeEnd = 645889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00026554 File Offset: 0x00024754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645889, XrefRangeEnd = 645891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000265AC File Offset: 0x000247AC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 645893, RefRangeEnd = 645911, XrefRangeStart = 645891, XrefRangeEnd = 645893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray ScreenPointToRay(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000265F8 File Offset: 0x000247F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645911, XrefRangeEnd = 645913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewport;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateFrustumCornersInternal_Private_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*outCorners = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00026674 File Offset: 0x00024874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645913, XrefRangeEnd = 645915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Il2CppStructArray<Vector3> outCorners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewport;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outCorners);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateFrustumCorners_Public_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000266E4 File Offset: 0x000248E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645915, XrefRangeEnd = 645917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focalLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensorSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lensShift;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nearClip;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref farClip;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gateAspect;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gateFitMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Private_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00026778 File Offset: 0x00024978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645917, XrefRangeEnd = 645919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, Camera.GateFitParameters gateFitParameters = default(Camera.GateFitParameters))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focalLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensorSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lensShift;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nearClip;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref farClip;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gateFitParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalProperties_Public_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00026800 File Offset: 0x00024A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645919, XrefRangeEnd = 645921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FocalLengthToFieldOfView(float focalLength, float sensorSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref focalLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensorSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FocalLengthToFieldOfView_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0002684C File Offset: 0x00024A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645921, XrefRangeEnd = 645923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fieldOfView;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sensorSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FieldOfViewToFocalLength_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00026898 File Offset: 0x00024A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645925, RefRangeEnd = 645926, XrefRangeStart = 645923, XrefRangeEnd = 645925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref horizontalFieldOfView;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspectRatio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HorizontalToVerticalFieldOfView_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000268E4 File Offset: 0x00024AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 645928, RefRangeEnd = 645929, XrefRangeStart = 645926, XrefRangeEnd = 645928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verticalFieldOfView;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspectRatio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_VerticalToHorizontalFieldOfView_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00026930 File Offset: 0x00024B30
		public unsafe static Camera main
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 645931, RefRangeEnd = 645965, XrefRangeStart = 645929, XrefRangeEnd = 645931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00026964 File Offset: 0x00024B64
		public unsafe static Camera current
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 645967, RefRangeEnd = 645973, XrefRangeStart = 645965, XrefRangeEnd = 645967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00026998 File Offset: 0x00024B98
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000269D4 File Offset: 0x00024BD4
		public unsafe UnityEngine.SceneManagement.Scene scene
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645973, XrefRangeEnd = 645975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scene_Public_get_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645975, XrefRangeEnd = 645977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_scene_Public_set_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00026A14 File Offset: 0x00024C14
		public unsafe bool stereoEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 645979, RefRangeEnd = 645980, XrefRangeStart = 645977, XrefRangeEnd = 645979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00026A50 File Offset: 0x00024C50
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00026A8C File Offset: 0x00024C8C
		public unsafe float stereoSeparation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645980, XrefRangeEnd = 645982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoSeparation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645982, XrefRangeEnd = 645984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_stereoSeparation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00026ACC File Offset: 0x00024CCC
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00026B08 File Offset: 0x00024D08
		public unsafe float stereoConvergence
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645984, XrefRangeEnd = 645986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoConvergence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645986, XrefRangeEnd = 645988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_stereoConvergence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00026B48 File Offset: 0x00024D48
		public unsafe bool areVRStereoViewMatricesWithinSingleCullTolerance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645988, XrefRangeEnd = 645990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_areVRStereoViewMatricesWithinSingleCullTolerance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00026B84 File Offset: 0x00024D84
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00026BC0 File Offset: 0x00024DC0
		public unsafe StereoTargetEyeMask stereoTargetEye
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645990, XrefRangeEnd = 645992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645992, XrefRangeEnd = 645994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00026C00 File Offset: 0x00024E00
		public unsafe Camera.MonoOrStereoscopicEye stereoActiveEye
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645994, XrefRangeEnd = 645996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00026C3C File Offset: 0x00024E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645996, XrefRangeEnd = 645998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00026C88 File Offset: 0x00024E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 645998, XrefRangeEnd = 646000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoViewMatrix_Public_Matrix4x4_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00026CD4 File Offset: 0x00024ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646000, XrefRangeEnd = 646002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00026D14 File Offset: 0x00024F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646002, XrefRangeEnd = 646004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00026D60 File Offset: 0x00024F60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646006, RefRangeEnd = 646007, XrefRangeStart = 646004, XrefRangeEnd = 646006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00026DAC File Offset: 0x00024FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646007, XrefRangeEnd = 646009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStereoProjectionMatrices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00026DE0 File Offset: 0x00024FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646011, RefRangeEnd = 646012, XrefRangeStart = 646009, XrefRangeEnd = 646011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoViewMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00026E2C File Offset: 0x0002502C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646012, XrefRangeEnd = 646014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStereoViewMatrices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ResetStereoViewMatrices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00026E60 File Offset: 0x00025060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 646016, RefRangeEnd = 646019, XrefRangeStart = 646014, XrefRangeEnd = 646016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00026E90 File Offset: 0x00025090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646019, XrefRangeEnd = 646021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCamerasImpl([Out] Il2CppReferenceArray<Camera> cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*cam = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Camera>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00026EE4 File Offset: 0x000250E4
		public unsafe static int allCamerasCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 646016, RefRangeEnd = 646019, XrefRangeStart = 646016, XrefRangeEnd = 646019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00026F14 File Offset: 0x00025114
		public unsafe static Il2CppReferenceArray<Camera> allCameras
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 646028, RefRangeEnd = 646031, XrefRangeStart = 646021, XrefRangeEnd = 646028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Camera>>(intPtr3) : null;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00026F48 File Offset: 0x00025148
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 646046, RefRangeEnd = 646051, XrefRangeStart = 646031, XrefRangeEnd = 646046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAllCameras(Il2CppReferenceArray<Camera> cameras)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameras);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00026F8C File Offset: 0x0002518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646051, XrefRangeEnd = 646053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemapImpl(Texture tex, int faceMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemapImpl_Private_Boolean_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00026FE8 File Offset: 0x000251E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemap(Cubemap cubemap, int faceMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00027044 File Offset: 0x00025244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646053, XrefRangeEnd = 646055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemap(Cubemap cubemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00027094 File Offset: 0x00025294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemap(RenderTexture cubemap, int faceMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000270F0 File Offset: 0x000252F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemap(RenderTexture cubemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00027140 File Offset: 0x00025340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 646057, RefRangeEnd = 646059, XrefRangeStart = 646055, XrefRangeEnd = 646057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFilterMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetFilterMode_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0002717C File Offset: 0x0002537C
		public unsafe Camera.SceneViewFilterMode sceneViewFilterMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 646057, RefRangeEnd = 646059, XrefRangeStart = 646057, XrefRangeEnd = 646059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000271B8 File Offset: 0x000253B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646059, XrefRangeEnd = 646061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoEye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemapEyeImpl_Private_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00027224 File Offset: 0x00025424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RenderToCubemap(RenderTexture cubemap, int faceMask, Camera.MonoOrStereoscopicEye stereoEye)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cubemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceMask;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoEye;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00027290 File Offset: 0x00025490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646061, XrefRangeEnd = 646063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_Render_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000272C4 File Offset: 0x000254C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646063, XrefRangeEnd = 646065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderWithShader(Shader shader, string replacementTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacementTag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00027318 File Offset: 0x00025518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646065, XrefRangeEnd = 646067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderDontRestore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RenderDontRestore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0002734C File Offset: 0x0002554C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646067, XrefRangeEnd = 646077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitRenderRequests(List<Camera.RenderRequest> renderRequests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderRequests);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SubmitRenderRequests_Public_Void_List_1_RenderRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00027390 File Offset: 0x00025590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646077, XrefRangeEnd = 646116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitRenderRequest<RequestData>(RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(RequestData).IsValueType)
				{
					RequestData requestData = renderRequest;
					intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref renderRequest;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.MethodInfoStoreGeneric_SubmitRenderRequest_Public_Void_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00027408 File Offset: 0x00025608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 646118, RefRangeEnd = 646119, XrefRangeStart = 646116, XrefRangeEnd = 646118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitRenderRequestsInternal(Object requests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requests);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SubmitRenderRequestsInternal_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002744C File Offset: 0x0002564C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646119, XrefRangeEnd = 646121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SubmitBuiltInObjectIDRenderRequest_Private_Il2CppReferenceArray_1_Object_RenderTexture_Int32_CubemapFace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000274C8 File Offset: 0x000256C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 646123, RefRangeEnd = 646127, XrefRangeStart = 646121, XrefRangeEnd = 646123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupCurrent(Camera cur)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cur);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00027500 File Offset: 0x00025700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646127, XrefRangeEnd = 646129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Camera other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00027544 File Offset: 0x00025744
		public unsafe int commandBufferCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646129, XrefRangeEnd = 646131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00027580 File Offset: 0x00025780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646131, XrefRangeEnd = 646133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000275C0 File Offset: 0x000257C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646133, XrefRangeEnd = 646135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllCommandBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000275F4 File Offset: 0x000257F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646135, XrefRangeEnd = 646137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00027644 File Offset: 0x00025844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646137, XrefRangeEnd = 646139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBufferAsyncImpl_Private_Void_CameraEvent_CommandBuffer_ComputeQueueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000276A4 File Offset: 0x000258A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646139, XrefRangeEnd = 646141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000276F4 File Offset: 0x000258F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646141, XrefRangeEnd = 646160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00027744 File Offset: 0x00025944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646160, XrefRangeEnd = 646179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queueType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_CameraEvent_CommandBuffer_ComputeQueueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000277A4 File Offset: 0x000259A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646179, XrefRangeEnd = 646198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000277F4 File Offset: 0x000259F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646198, XrefRangeEnd = 646200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer> GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.Rendering.CommandBuffer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00027840 File Offset: 0x00025A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646200, XrefRangeEnd = 646202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreCull(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00027878 File Offset: 0x00025A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646202, XrefRangeEnd = 646204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPreRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000278B0 File Offset: 0x00025AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646204, XrefRangeEnd = 646206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireOnPostRender(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000278E8 File Offset: 0x00025AE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnlyUsedForTesting1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_OnlyUsedForTesting1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002791C File Offset: 0x00025B1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnlyUsedForTesting2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_OnlyUsedForTesting2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00027950 File Offset: 0x00025B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646206, XrefRangeEnd = 646208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCullingParameters(out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullingParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002799C File Offset: 0x00025B9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 646210, RefRangeEnd = 646213, XrefRangeStart = 646208, XrefRangeEnd = 646210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCullingParameters(bool stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stereoAware;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullingParameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000279F4 File Offset: 0x00025BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646213, XrefRangeEnd = 646215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stereoAware;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullingParameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedCullingParametersSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00027A60 File Offset: 0x00025C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646215, XrefRangeEnd = 646217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_transparencySortAxis_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_transparencySortAxis_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00027AA0 File Offset: 0x00025CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646217, XrefRangeEnd = 646219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_transparencySortAxis_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_transparencySortAxis_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00027AE0 File Offset: 0x00025CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646219, XrefRangeEnd = 646221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_velocity_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00027B20 File Offset: 0x00025D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646221, XrefRangeEnd = 646223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_cullingMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00027B60 File Offset: 0x00025D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646223, XrefRangeEnd = 646225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_cullingMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646225, XrefRangeEnd = 646227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_backgroundColor_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00027BE0 File Offset: 0x00025DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646227, XrefRangeEnd = 646229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_backgroundColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00027C20 File Offset: 0x00025E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646229, XrefRangeEnd = 646231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_curvature_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_curvature_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00027C60 File Offset: 0x00025E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646231, XrefRangeEnd = 646233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_curvature_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_curvature_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00027CA0 File Offset: 0x00025EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646233, XrefRangeEnd = 646235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_sensorSize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_sensorSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00027CE0 File Offset: 0x00025EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646235, XrefRangeEnd = 646237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_sensorSize_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_sensorSize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00027D20 File Offset: 0x00025F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646237, XrefRangeEnd = 646239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_lensShift_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_lensShift_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00027D60 File Offset: 0x00025F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646239, XrefRangeEnd = 646241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_lensShift_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_lensShift_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00027DA0 File Offset: 0x00025FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646241, XrefRangeEnd = 646243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetGateFittedLensShift_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetGateFittedLensShift_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00027DE0 File Offset: 0x00025FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646243, XrefRangeEnd = 646245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalSpaceAim_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetLocalSpaceAim_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00027E20 File Offset: 0x00026020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646245, XrefRangeEnd = 646247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00027E60 File Offset: 0x00026060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646247, XrefRangeEnd = 646249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00027EA0 File Offset: 0x000260A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646249, XrefRangeEnd = 646251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pixelRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00027EE0 File Offset: 0x000260E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646251, XrefRangeEnd = 646253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pixelRect_Injected(ref Rect value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00027F20 File Offset: 0x00026120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646253, XrefRangeEnd = 646255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &color;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffersImpl_Injected_Private_Void_byref_RenderBuffer_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00027F6C File Offset: 0x0002616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646255, XrefRangeEnd = 646257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetBuffersMRTImpl_Injected(Il2CppStructArray<RenderBuffer> color, ref RenderBuffer depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Injected_Private_Void_Il2CppStructArray_1_RenderBuffer_byref_RenderBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00027FBC File Offset: 0x000261BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646257, XrefRangeEnd = 646259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00027FFC File Offset: 0x000261FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646259, XrefRangeEnd = 646261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0002803C File Offset: 0x0002623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646261, XrefRangeEnd = 646263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_worldToCameraMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002807C File Offset: 0x0002627C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646263, XrefRangeEnd = 646265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000280BC File Offset: 0x000262BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646265, XrefRangeEnd = 646267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_projectionMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000280FC File Offset: 0x000262FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646267, XrefRangeEnd = 646269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002813C File Offset: 0x0002633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646269, XrefRangeEnd = 646271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0002817C File Offset: 0x0002637C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646271, XrefRangeEnd = 646273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_previousViewProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000281BC File Offset: 0x000263BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646273, XrefRangeEnd = 646275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &clipPlane;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00028208 File Offset: 0x00026408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646275, XrefRangeEnd = 646277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00028264 File Offset: 0x00026464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646277, XrefRangeEnd = 646279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000282C0 File Offset: 0x000264C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646279, XrefRangeEnd = 646281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0002831C File Offset: 0x0002651C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646281, XrefRangeEnd = 646283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00028378 File Offset: 0x00026578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646283, XrefRangeEnd = 646285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000283C4 File Offset: 0x000265C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646285, XrefRangeEnd = 646287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00028410 File Offset: 0x00026610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646287, XrefRangeEnd = 646289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref distance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Injected_Private_Void_Single_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0002845C File Offset: 0x0002665C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646289, XrefRangeEnd = 646291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000284B8 File Offset: 0x000266B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646291, XrefRangeEnd = 646293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00028514 File Offset: 0x00026714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646293, XrefRangeEnd = 646295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Il2CppStructArray<Vector3> outCorners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewport;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eye;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateFrustumCornersInternal_Injected_Private_Void_byref_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*outCorners = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00028590 File Offset: 0x00026790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646295, XrefRangeEnd = 646297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, Camera.GateFitMode gateFitMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focalLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sensorSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lensShift;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nearClip;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref farClip;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gateAspect;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gateFitMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Private_Static_Void_byref_Matrix4x4_Single_byref_Vector2_byref_Vector2_Single_Single_Single_GateFitMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00028624 File Offset: 0x00026824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646297, XrefRangeEnd = 646299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00028664 File Offset: 0x00026864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646299, XrefRangeEnd = 646301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_scene_Injected(ref UnityEngine.SceneManagement.Scene value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_scene_Injected_Private_Void_byref_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000286A4 File Offset: 0x000268A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646301, XrefRangeEnd = 646303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000286F0 File Offset: 0x000268F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646303, XrefRangeEnd = 646305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0002873C File Offset: 0x0002693C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646305, XrefRangeEnd = 646307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_GetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00028788 File Offset: 0x00026988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646307, XrefRangeEnd = 646309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000287D4 File Offset: 0x000269D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646309, XrefRangeEnd = 646311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eye;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000416C File Offset: 0x0000236C
		public Camera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00028820 File Offset: 0x00026A20
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00004175 File Offset: 0x00002375
		public unsafe static float kMinAperture
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMinAperture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMinAperture, (void*)(&value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0002883C File Offset: 0x00026A3C
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00004183 File Offset: 0x00002383
		public unsafe static float kMaxAperture
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMaxAperture, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMaxAperture, (void*)(&value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00028858 File Offset: 0x00026A58
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00004191 File Offset: 0x00002391
		public unsafe static int kMinBladeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMinBladeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMinBladeCount, (void*)(&value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00028874 File Offset: 0x00026A74
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0000419F File Offset: 0x0000239F
		public unsafe static int kMaxBladeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_kMaxBladeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_kMaxBladeCount, (void*)(&value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00028890 File Offset: 0x00026A90
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x000041AD File Offset: 0x000023AD
		public unsafe static Camera.CameraCallback onPreCull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreCull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreCull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000288B8 File Offset: 0x00026AB8
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x000041BF File Offset: 0x000023BF
		public unsafe static Camera.CameraCallback onPreRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPreRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPreRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x000288E0 File Offset: 0x00026AE0
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x000041D1 File Offset: 0x000023D1
		public unsafe static Camera.CameraCallback onPostRender
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_onPostRender, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera.CameraCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_onPostRender, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_kMinAperture;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_kMaxAperture;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_kMinBladeCount;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_kMaxBladeCount;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_onPreCull;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_onPreRender;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_onPostRender;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_get_nearClipPlane_Public_get_Single_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_set_nearClipPlane_Public_set_Void_Single_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_farClipPlane_Public_get_Single_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_set_farClipPlane_Public_set_Void_Single_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_set_fieldOfView_Public_set_Void_Single_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingPath_Public_get_RenderingPath_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_set_renderingPath_Public_set_Void_RenderingPath_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_get_actualRenderingPath_Public_get_RenderingPath_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_get_allowHDR_Public_get_Boolean_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_set_allowHDR_Public_set_Void_Boolean_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_get_allowMSAA_Public_get_Boolean_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_set_allowMSAA_Public_set_Void_Boolean_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_get_allowDynamicResolution_Public_get_Boolean_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_set_allowDynamicResolution_Public_set_Void_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_get_forceIntoRenderTexture_Public_get_Boolean_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_set_forceIntoRenderTexture_Public_set_Void_Boolean_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographicSize_Public_get_Single_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographicSize_Public_set_Void_Single_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_get_orthographic_Public_get_Boolean_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_set_orthographic_Public_set_Void_Boolean_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_get_opaqueSortMode_Public_get_OpaqueSortMode_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_set_opaqueSortMode_Public_set_Void_OpaqueSortMode_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_get_transparencySortMode_Public_get_TransparencySortMode_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_set_transparencySortMode_Public_set_Void_TransparencySortMode_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_get_transparencySortAxis_Public_get_Vector3_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_set_transparencySortAxis_Public_set_Void_Vector3_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_ResetTransparencySortSettings_Public_Void_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Single_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_set_depth_Public_set_Void_Single_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_get_aspect_Public_get_Single_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_set_aspect_Public_set_Void_Single_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_ResetAspect_Public_Void_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMask_Public_get_Int32_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMask_Public_set_Void_Int32_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_Int32_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_set_eventMask_Public_set_Void_Int32_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_get_layerCullSpherical_Public_get_Boolean_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_set_layerCullSpherical_Public_set_Void_Boolean_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraType_Public_get_CameraType_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_set_cameraType_Public_set_Void_CameraType_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_get_skyboxMaterial_Internal_get_Material_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSceneCullingMask_Public_get_UInt64_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSceneCullingMask_Public_set_Void_UInt64_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCullingMask_Internal_get_UInt64_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCullDistances_Private_Il2CppStructArray_1_Single_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerCullDistances_Private_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_get_layerCullDistances_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_set_layerCullDistances_Public_set_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviewCullingLayer_Internal_Static_get_Int32_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_ResetCullingMatrix_Public_Void_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Public_get_Color_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Public_set_Void_Color_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_get_clearFlags_Public_get_CameraClearFlags_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_set_clearFlags_Public_set_Void_CameraClearFlags_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_get_depthTextureMode_Public_get_DepthTextureMode_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_set_depthTextureMode_Public_set_Void_DepthTextureMode_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_get_clearStencilAfterLightingPass_Public_get_Boolean_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_set_clearStencilAfterLightingPass_Public_set_Void_Boolean_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_SetReplacementShader_Public_Void_Shader_String_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_ResetReplacementShader_Public_Void_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrixMode_Internal_get_ProjectionMatrixMode_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_get_usePhysicalProperties_Public_get_Boolean_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_set_usePhysicalProperties_Public_set_Void_Boolean_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_get_iso_Public_get_Int32_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_set_iso_Public_set_Void_Int32_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_get_shutterSpeed_Public_get_Single_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_set_shutterSpeed_Public_set_Void_Single_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_get_aperture_Public_get_Single_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_set_aperture_Public_set_Void_Single_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_focusDistance_Public_get_Single_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_set_focusDistance_Public_set_Void_Single_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_focalLength_Public_get_Single_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_set_focalLength_Public_set_Void_Single_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_get_bladeCount_Public_get_Int32_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_set_bladeCount_Public_set_Void_Int32_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_curvature_Public_get_Vector2_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_set_curvature_Public_set_Void_Vector2_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_barrelClipping_Public_get_Single_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_set_barrelClipping_Public_set_Void_Single_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_anamorphism_Public_get_Single_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_set_anamorphism_Public_set_Void_Single_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_sensorSize_Public_get_Vector2_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_set_sensorSize_Public_set_Void_Vector2_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_lensShift_Public_get_Vector2_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_set_lensShift_Public_set_Void_Vector2_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_get_gateFit_Public_get_GateFitMode_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_set_gateFit_Public_set_Void_GateFitMode_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_GetGateFittedFieldOfView_Public_Single_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_GetGateFittedLensShift_Public_Vector2_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalSpaceAim_Internal_Vector3_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Public_set_Void_Rect_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Public_set_Void_Rect_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelWidth_Public_get_Int32_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelHeight_Public_get_Int32_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelWidth_Public_get_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelHeight_Public_get_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_activeTexture_Public_get_RenderTexture_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffersImpl_Private_Void_RenderBuffer_RenderBuffer_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffers_Public_Void_RenderBuffer_RenderBuffer_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Private_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffers_Public_Void_Il2CppStructArray_1_RenderBuffer_RenderBuffer_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraBufferWarnings_Internal_Il2CppStringArray_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_set_worldToCameraMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_useJitteredProjectionMatrixForTransparentRendering_Public_get_Boolean_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_set_useJitteredProjectionMatrixForTransparentRendering_Public_set_Void_Boolean_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_previousViewProjectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_ResetWorldToCameraMatrix_Public_Void_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_ResetProjectionMatrix_Public_Void_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_CalculateObliqueMatrix_Public_Matrix4x4_Vector4_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Public_Vector3_Vector3_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Public_Vector3_Vector3_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Internal_Vector2_Single_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Public_Ray_Vector3_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Private_Ray_Vector2_MonoOrStereoscopicEye_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_MonoOrStereoscopicEye_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Public_Ray_Vector3_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumCornersInternal_Private_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumCorners_Public_Void_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Private_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_Single_GateFitMode_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalProperties_Public_Static_Void_byref_Matrix4x4_Single_Vector2_Vector2_Single_Single_GateFitParameters_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_FocalLengthToFieldOfView_Public_Static_Single_Single_Single_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_FieldOfViewToFocalLength_Public_Static_Single_Single_Single_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_HorizontalToVerticalFieldOfView_Public_Static_Single_Single_Single_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_VerticalToHorizontalFieldOfView_Public_Static_Single_Single_Single_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Camera_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Camera_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Public_get_Scene_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_set_scene_Public_set_Void_Scene_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoEnabled_Public_get_Boolean_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoSeparation_Public_get_Single_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoSeparation_Public_set_Void_Single_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoConvergence_Public_get_Single_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoConvergence_Public_set_Void_Single_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_get_areVRStereoViewMatricesWithinSingleCullTolerance_Public_get_Boolean_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoTargetEye_Public_get_StereoTargetEyeMask_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoTargetEye_Public_set_Void_StereoTargetEyeMask_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoActiveEye_Public_get_MonoOrStereoscopicEye_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoViewMatrix_Public_Matrix4x4_StereoscopicEye_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_CopyStereoDeviceProjectionMatrixToNonJittered_Public_Void_StereoscopicEye_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoProjectionMatrix_Public_Matrix4x4_StereoscopicEye_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_ResetStereoProjectionMatrices_Public_Void_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Public_Void_StereoscopicEye_Matrix4x4_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_ResetStereoViewMatrices_Public_Void_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasCount_Private_Static_Int32_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCamerasImpl_Private_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_allCamerasCount_Public_Static_get_Int32_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_get_allCameras_Public_Static_get_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCameras_Public_Static_Int32_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemapImpl_Private_Boolean_Texture_Int32_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_Int32_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_Cubemap_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_GetFilterMode_Private_Int32_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneViewFilterMode_Public_get_SceneViewFilterMode_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemapEyeImpl_Private_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_RenderToCubemap_Public_Boolean_RenderTexture_Int32_MonoOrStereoscopicEye_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Void_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_RenderWithShader_Public_Void_Shader_String_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_RenderDontRestore_Public_Void_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRenderRequests_Public_Void_List_1_RenderRequest_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRenderRequest_Public_Void_RequestData_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_SubmitRenderRequestsInternal_Private_Void_Object_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_SubmitBuiltInObjectIDRenderRequest_Private_Il2CppReferenceArray_1_Object_RenderTexture_Int32_CubemapFace_Int32_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_SetupCurrent_Public_Static_Void_Camera_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_Camera_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_commandBufferCount_Public_get_Int32_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffers_Public_Void_CameraEvent_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllCommandBuffers_Public_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferAsyncImpl_Private_Void_CameraEvent_CommandBuffer_ComputeQueueType_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBufferImpl_Private_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_AddCommandBufferAsync_Public_Void_CameraEvent_CommandBuffer_ComputeQueueType_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCommandBuffer_Public_Void_CameraEvent_CommandBuffer_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandBuffers_Public_Il2CppReferenceArray_1_CommandBuffer_CameraEvent_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreCull_Private_Static_Void_Camera_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPreRender_Private_Static_Void_Camera_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_FireOnPostRender_Private_Static_Void_Camera_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_OnlyUsedForTesting1_Internal_Void_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_OnlyUsedForTesting2_Internal_Void_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_byref_ScriptableCullingParameters_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCullingParameters_Public_Boolean_Boolean_byref_ScriptableCullingParameters_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingParameters_Internal_Private_Static_Boolean_Camera_Boolean_byref_ScriptableCullingParameters_Int32_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_get_transparencySortAxis_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_set_transparencySortAxis_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_get_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_set_backgroundColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_curvature_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_set_curvature_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_sensorSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_set_sensorSize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_get_lensShift_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_set_lensShift_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_GetGateFittedLensShift_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalSpaceAim_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_set_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffersImpl_Injected_Private_Void_byref_RenderBuffer_byref_RenderBuffer_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetBuffersMRTImpl_Injected_Private_Void_Il2CppStructArray_1_RenderBuffer_byref_RenderBuffer_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_get_cameraToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_set_worldToCameraMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_set_projectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_set_nonJitteredProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_get_previousViewProjectionMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_CalculateObliqueMatrix_Injected_Private_Void_byref_Vector4_byref_Matrix4x4_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_WorldToScreenPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToWorldPoint_Injected_Private_Void_byref_Vector3_MonoOrStereoscopicEye_byref_Vector3_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_ScreenToViewportPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_ViewportToScreenPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_GetFrustumPlaneSizeAt_Injected_Private_Void_Single_byref_Vector2_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_ViewportPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_ScreenPointToRay_Injected_Private_Void_byref_Vector2_MonoOrStereoscopicEye_byref_Ray_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumCornersInternal_Injected_Private_Void_byref_Rect_Single_MonoOrStereoscopicEye_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected_Private_Static_Void_byref_Matrix4x4_Single_byref_Vector2_byref_Vector2_Single_Single_Single_GateFitMode_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_set_scene_Injected_Private_Void_byref_Scene_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoNonJitteredProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoProjectionMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_SetStereoViewMatrix_Injected_Private_Void_StereoscopicEye_byref_Matrix4x4_0;

		// Token: 0x02000448 RID: 1096
		public enum ProjectionMatrixMode
		{
			// Token: 0x04002B2A RID: 11050
			Explicit,
			// Token: 0x04002B2B RID: 11051
			Implicit,
			// Token: 0x04002B2C RID: 11052
			PhysicalPropertiesBased
		}

		// Token: 0x02000449 RID: 1097
		public enum GateFitMode
		{
			// Token: 0x04002B2E RID: 11054
			Vertical = 1,
			// Token: 0x04002B2F RID: 11055
			Horizontal,
			// Token: 0x04002B30 RID: 11056
			Fill,
			// Token: 0x04002B31 RID: 11057
			Overscan,
			// Token: 0x04002B32 RID: 11058
			None = 0
		}

		// Token: 0x0200044A RID: 1098
		[StructLayout(2)]
		public struct GateFitParameters
		{
			// Token: 0x0600318A RID: 12682 RVA: 0x000B8430 File Offset: 0x000B6630
			// Note: this type is marked as 'beforefieldinit'.
			static GateFitParameters()
			{
				Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "GateFitParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr);
				Camera.GateFitParameters.NativeFieldInfoPtr__mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr, "<mode>k__BackingField");
				Camera.GateFitParameters.NativeFieldInfoPtr__aspect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr, "<aspect>k__BackingField");
				Camera.GateFitParameters.NativeMethodInfoPtr_get_mode_Public_get_GateFitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr, 100663999);
				Camera.GateFitParameters.NativeMethodInfoPtr_get_aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr, 100664000);
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x0600318B RID: 12683 RVA: 0x000B84AC File Offset: 0x000B66AC
			public unsafe Camera.GateFitMode mode
			{
				[CallerCount(200)]
				[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.GateFitParameters.NativeMethodInfoPtr_get_mode_Public_get_GateFitMode_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x0600318C RID: 12684 RVA: 0x000B84DC File Offset: 0x000B66DC
			public unsafe float aspect
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.GateFitParameters.NativeMethodInfoPtr_get_aspect_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600318D RID: 12685 RVA: 0x00013A65 File Offset: 0x00011C65
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Camera.GateFitParameters>.NativeClassPtr, ref this));
			}

			// Token: 0x04002B33 RID: 11059
			private static readonly IntPtr NativeFieldInfoPtr__mode_k__BackingField;

			// Token: 0x04002B34 RID: 11060
			private static readonly IntPtr NativeFieldInfoPtr__aspect_k__BackingField;

			// Token: 0x04002B35 RID: 11061
			private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_GateFitMode_0;

			// Token: 0x04002B36 RID: 11062
			private static readonly IntPtr NativeMethodInfoPtr_get_aspect_Public_get_Single_0;

			// Token: 0x04002B37 RID: 11063
			[FieldOffset(0)]
			public Camera.GateFitMode _mode_k__BackingField;

			// Token: 0x04002B38 RID: 11064
			[FieldOffset(4)]
			public float _aspect_k__BackingField;
		}

		// Token: 0x0200044B RID: 1099
		public enum StereoscopicEye
		{
			// Token: 0x04002B3A RID: 11066
			Left,
			// Token: 0x04002B3B RID: 11067
			Right
		}

		// Token: 0x0200044C RID: 1100
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x04002B3D RID: 11069
			Left,
			// Token: 0x04002B3E RID: 11070
			Right,
			// Token: 0x04002B3F RID: 11071
			Mono
		}

		// Token: 0x0200044D RID: 1101
		public enum SceneViewFilterMode
		{
			// Token: 0x04002B41 RID: 11073
			Off,
			// Token: 0x04002B42 RID: 11074
			ShowFiltered
		}

		// Token: 0x0200044E RID: 1102
		public enum RenderRequestMode
		{
			// Token: 0x04002B44 RID: 11076
			None,
			// Token: 0x04002B45 RID: 11077
			ObjectId,
			// Token: 0x04002B46 RID: 11078
			Depth,
			// Token: 0x04002B47 RID: 11079
			VertexNormal,
			// Token: 0x04002B48 RID: 11080
			WorldPosition,
			// Token: 0x04002B49 RID: 11081
			EntityId,
			// Token: 0x04002B4A RID: 11082
			BaseColor,
			// Token: 0x04002B4B RID: 11083
			SpecularColor,
			// Token: 0x04002B4C RID: 11084
			Metallic,
			// Token: 0x04002B4D RID: 11085
			Emission,
			// Token: 0x04002B4E RID: 11086
			Normal,
			// Token: 0x04002B4F RID: 11087
			Smoothness,
			// Token: 0x04002B50 RID: 11088
			Occlusion,
			// Token: 0x04002B51 RID: 11089
			DiffuseColor
		}

		// Token: 0x0200044F RID: 1103
		public enum RenderRequestOutputSpace
		{
			// Token: 0x04002B53 RID: 11091
			ScreenSpace = -1,
			// Token: 0x04002B54 RID: 11092
			UV0,
			// Token: 0x04002B55 RID: 11093
			UV1,
			// Token: 0x04002B56 RID: 11094
			UV2,
			// Token: 0x04002B57 RID: 11095
			UV3,
			// Token: 0x04002B58 RID: 11096
			UV4,
			// Token: 0x04002B59 RID: 11097
			UV5,
			// Token: 0x04002B5A RID: 11098
			UV6,
			// Token: 0x04002B5B RID: 11099
			UV7,
			// Token: 0x04002B5C RID: 11100
			UV8
		}

		// Token: 0x02000450 RID: 1104
		public sealed class RenderRequest : ValueType
		{
			// Token: 0x0600318E RID: 12686 RVA: 0x000B850C File Offset: 0x000B670C
			// Note: this type is marked as 'beforefieldinit'.
			static RenderRequest()
			{
				Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "RenderRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr);
				Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_CameraRenderMode");
				Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_ResultRT");
				Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr, "m_OutputSpace");
			}

			// Token: 0x0600318F RID: 12687 RVA: 0x00013A77 File Offset: 0x00011C77
			public RenderRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003190 RID: 12688 RVA: 0x00013A80 File Offset: 0x00011C80
			public RenderRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.RenderRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06003191 RID: 12689 RVA: 0x000B8574 File Offset: 0x000B6774
			// (set) Token: 0x06003192 RID: 12690 RVA: 0x00013A92 File Offset: 0x00011C92
			public unsafe Camera.RenderRequestMode m_CameraRenderMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_CameraRenderMode)) = value;
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06003193 RID: 12691 RVA: 0x000B859C File Offset: 0x000B679C
			// (set) Token: 0x06003194 RID: 12692 RVA: 0x00013AAD File Offset: 0x00011CAD
			public unsafe RenderTexture m_ResultRT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_ResultRT), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06003195 RID: 12693 RVA: 0x000B85CC File Offset: 0x000B67CC
			// (set) Token: 0x06003196 RID: 12694 RVA: 0x00013ACC File Offset: 0x00011CCC
			public unsafe Camera.RenderRequestOutputSpace m_OutputSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.RenderRequest.NativeFieldInfoPtr_m_OutputSpace)) = value;
				}
			}

			// Token: 0x04002B5D RID: 11101
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraRenderMode;

			// Token: 0x04002B5E RID: 11102
			private static readonly IntPtr NativeFieldInfoPtr_m_ResultRT;

			// Token: 0x04002B5F RID: 11103
			private static readonly IntPtr NativeFieldInfoPtr_m_OutputSpace;
		}

		// Token: 0x02000451 RID: 1105
		public sealed class CameraCallback : MulticastDelegate
		{
			// Token: 0x06003197 RID: 12695 RVA: 0x00013AE7 File Offset: 0x00011CE7
			// Note: this type is marked as 'beforefieldinit'.
			static CameraCallback()
			{
				Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Camera>.NativeClassPtr, "CameraCallback");
				Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100664001);
				Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr, 100664002);
			}

			// Token: 0x06003198 RID: 12696 RVA: 0x000B85F4 File Offset: 0x000B67F4
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera.CameraCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003199 RID: 12697 RVA: 0x000B8650 File Offset: 0x000B6850
			[CallerCount(0)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.CameraCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600319A RID: 12698 RVA: 0x00013B25 File Offset: 0x00011D25
			public CameraCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600319B RID: 12699 RVA: 0x00013B2E File Offset: 0x00011D2E
			public static implicit operator Camera.CameraCallback(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<Camera.CameraCallback>(A_0);
			}

			// Token: 0x0600319C RID: 12700 RVA: 0x00013B36 File Offset: 0x00011D36
			public static Camera.CameraCallback operator +(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Camera.CameraCallback>();
			}

			// Token: 0x0600319D RID: 12701 RVA: 0x00013B44 File Offset: 0x00011D44
			public static Camera.CameraCallback operator -(Camera.CameraCallback A_0, Camera.CameraCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Camera.CameraCallback>();
				}
				return delegate2;
			}

			// Token: 0x04002B60 RID: 11104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B61 RID: 11105
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;
		}

		// Token: 0x02000452 RID: 1106
		private sealed class MethodInfoStoreGeneric_SubmitRenderRequest_Public_Void_RequestData_0<RequestData>
		{
			// Token: 0x04002B62 RID: 11106
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Camera.NativeMethodInfoPtr_SubmitRenderRequest_Public_Void_RequestData_0, Il2CppClassPointerStore<Camera>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}

		// Token: 0x02000453 RID: 1107
		public enum FieldOfViewAxis
		{
			// Token: 0x04002B64 RID: 11108
			Vertical,
			// Token: 0x04002B65 RID: 11109
			Horizontal
		}
	}
}
