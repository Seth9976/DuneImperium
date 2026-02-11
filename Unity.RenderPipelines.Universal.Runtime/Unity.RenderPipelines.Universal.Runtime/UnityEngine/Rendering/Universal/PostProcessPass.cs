using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B3 RID: 179
	public class PostProcessPass : ScriptableRenderPass
	{
		// Token: 0x06000DF6 RID: 3574 RVA: 0x00045C14 File Offset: 0x00043E14
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessPass()
		{
			Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr);
			PostProcessPass.NativeFieldInfoPtr_m_Descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Descriptor");
			PostProcessPass.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Source");
			PostProcessPass.NativeFieldInfoPtr_m_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Destination");
			PostProcessPass.NativeFieldInfoPtr_m_Depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Depth");
			PostProcessPass.NativeFieldInfoPtr_m_InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_InternalLut");
			PostProcessPass.NativeFieldInfoPtr_m_MotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MotionVectors");
			PostProcessPass.NativeFieldInfoPtr_m_FullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_FullCoCTexture");
			PostProcessPass.NativeFieldInfoPtr_m_HalfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_HalfCoCTexture");
			PostProcessPass.NativeFieldInfoPtr_m_PingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PingTexture");
			PostProcessPass.NativeFieldInfoPtr_m_PongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PongTexture");
			PostProcessPass.NativeFieldInfoPtr_m_BloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BloomMipDown");
			PostProcessPass.NativeFieldInfoPtr_m_BloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BloomMipUp");
			PostProcessPass.NativeFieldInfoPtr_m_BlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BlendTexture");
			PostProcessPass.NativeFieldInfoPtr_m_EdgeColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EdgeColorTexture");
			PostProcessPass.NativeFieldInfoPtr_m_EdgeStencilTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EdgeStencilTexture");
			PostProcessPass.NativeFieldInfoPtr_m_TempTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_TempTarget");
			PostProcessPass.NativeFieldInfoPtr_m_TempTarget2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_TempTarget2");
			PostProcessPass.NativeFieldInfoPtr_k_RenderPostProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_RenderPostProcessingTag");
			PostProcessPass.NativeFieldInfoPtr_k_RenderFinalPostProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_RenderFinalPostProcessingTag");
			PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ProfilingRenderPostProcessing");
			PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ProfilingRenderFinalPostProcessing");
			PostProcessPass.NativeFieldInfoPtr_m_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Materials");
			PostProcessPass.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Data");
			PostProcessPass.NativeFieldInfoPtr_m_DepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DepthOfField");
			PostProcessPass.NativeFieldInfoPtr_m_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MotionBlur");
			PostProcessPass.NativeFieldInfoPtr_m_PaniniProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_PaniniProjection");
			PostProcessPass.NativeFieldInfoPtr_m_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Bloom");
			PostProcessPass.NativeFieldInfoPtr_m_LensDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_LensDistortion");
			PostProcessPass.NativeFieldInfoPtr_m_ChromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ChromaticAberration");
			PostProcessPass.NativeFieldInfoPtr_m_Vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Vignette");
			PostProcessPass.NativeFieldInfoPtr_m_ColorLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ColorLookup");
			PostProcessPass.NativeFieldInfoPtr_m_ColorAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ColorAdjustments");
			PostProcessPass.NativeFieldInfoPtr_m_Tonemapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_Tonemapping");
			PostProcessPass.NativeFieldInfoPtr_m_FilmGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_FilmGrain");
			PostProcessPass.NativeFieldInfoPtr_k_MaxPyramidSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_MaxPyramidSize");
			PostProcessPass.NativeFieldInfoPtr_m_DefaultHDRFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DefaultHDRFormat");
			PostProcessPass.NativeFieldInfoPtr_m_UseRGBM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UseRGBM");
			PostProcessPass.NativeFieldInfoPtr_m_SMAAEdgeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_SMAAEdgeFormat");
			PostProcessPass.NativeFieldInfoPtr_m_GaussianCoCFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_GaussianCoCFormat");
			PostProcessPass.NativeFieldInfoPtr_m_DitheringTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_DitheringTextureIndex");
			PostProcessPass.NativeFieldInfoPtr_m_MRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_MRT2");
			PostProcessPass.NativeFieldInfoPtr_m_BokehKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehKernel");
			PostProcessPass.NativeFieldInfoPtr_m_BokehHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehHash");
			PostProcessPass.NativeFieldInfoPtr_m_BokehMaxRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehMaxRadius");
			PostProcessPass.NativeFieldInfoPtr_m_BokehRCPAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BokehRCPAspect");
			PostProcessPass.NativeFieldInfoPtr_m_IsFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_IsFinalPass");
			PostProcessPass.NativeFieldInfoPtr_m_HasFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_HasFinalPass");
			PostProcessPass.NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_EnableColorEncodingIfNeeded");
			PostProcessPass.NativeFieldInfoPtr_m_UseFastSRGBLinearConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UseFastSRGBLinearConversion");
			PostProcessPass.NativeFieldInfoPtr_m_SupportDataDrivenLensFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_SupportDataDrivenLensFlare");
			PostProcessPass.NativeFieldInfoPtr_m_ResolveToScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ResolveToScreen");
			PostProcessPass.NativeFieldInfoPtr_m_UseSwapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UseSwapBuffer");
			PostProcessPass.NativeFieldInfoPtr_m_ScalingSetupTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_ScalingSetupTarget");
			PostProcessPass.NativeFieldInfoPtr_m_UpscaledTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_UpscaledTarget");
			PostProcessPass.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "m_BlitMaterial");
			PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_ViewProjM");
			PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_PrevViewProjM");
			PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_ViewProjMStereo");
			PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "k_ShaderPropertyId_PrevViewProjMStereo");
			PostProcessPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665118);
			PostProcessPass.NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665119);
			PostProcessPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665120);
			PostProcessPass.NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665121);
			PostProcessPass.NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665122);
			PostProcessPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665123);
			PostProcessPass.NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665124);
			PostProcessPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665125);
			PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665126);
			PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665127);
			PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665128);
			PostProcessPass.NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665129);
			PostProcessPass.NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665130);
			PostProcessPass.NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665131);
			PostProcessPass.NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665132);
			PostProcessPass.NativeMethodInfoPtr_DoDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665133);
			PostProcessPass.NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665134);
			PostProcessPass.NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665135);
			PostProcessPass.NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665136);
			PostProcessPass.NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665137);
			PostProcessPass.NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665138);
			PostProcessPass.NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665139);
			PostProcessPass.NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665140);
			PostProcessPass.NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665141);
			PostProcessPass.NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665142);
			PostProcessPass.NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665143);
			PostProcessPass.NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665144);
			PostProcessPass.NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665145);
			PostProcessPass.NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665146);
			PostProcessPass.NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665147);
			PostProcessPass.NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665148);
			PostProcessPass.NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665149);
			PostProcessPass.NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665150);
			PostProcessPass.NativeMethodInfoPtr_SetupGrain_Private_Void_byref_CameraData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665151);
			PostProcessPass.NativeMethodInfoPtr_SetupDithering_Private_Void_byref_CameraData_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665152);
			PostProcessPass.NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665153);
			PostProcessPass.NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665154);
			PostProcessPass.NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665156);
			PostProcessPass.NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665157);
			PostProcessPass.NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass68_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, 100665158);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00046400 File Offset: 0x00044600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613340, RefRangeEnd = 613342, XrefRangeStart = 613249, XrefRangeEnd = 613340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(postProcessParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0004646C File Offset: 0x0004466C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 613344, RefRangeEnd = 613348, XrefRangeStart = 613342, XrefRangeEnd = 613344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000464A0 File Offset: 0x000446A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613363, RefRangeEnd = 613365, XrefRangeStart = 613348, XrefRangeEnd = 613363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000464D4 File Offset: 0x000446D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613376, RefRangeEnd = 613378, XrefRangeStart = 613365, XrefRangeEnd = 613376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup([In] ref RenderTextureDescriptor baseDescriptor, [In] ref RTHandle source, bool resolveToScreen, [In] ref RTHandle depth, [In] ref RTHandle internalLut, [In] ref RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &baseDescriptor;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolveToScreen;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(depth);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(internalLut);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(motionVectors);
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasFinalPass;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableColorEncoding;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			source = ((intPtr7 == 0) ? null : new RTHandle(intPtr7));
			IntPtr intPtr8 = intPtr2;
			depth = ((intPtr8 == 0) ? null : new RTHandle(intPtr8));
			IntPtr intPtr9 = intPtr3;
			internalLut = ((intPtr9 == 0) ? null : new RTHandle(intPtr9));
			IntPtr intPtr10 = intPtr4;
			motionVectors = ((intPtr10 == 0) ? null : new RTHandle(intPtr10));
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x000465E4 File Offset: 0x000447E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613384, RefRangeEnd = 613385, XrefRangeStart = 613378, XrefRangeEnd = 613384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFinalPass([In] ref RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(source);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSwapBuffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableColorEncoding;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00046658 File Offset: 0x00044858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483004, RefRangeEnd = 483006, XrefRangeStart = 483004, XrefRangeEnd = 483006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000466B8 File Offset: 0x000448B8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRunOnTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000466F4 File Offset: 0x000448F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613385, XrefRangeEnd = 613450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostProcessPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00046750 File Offset: 0x00044950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613452, RefRangeEnd = 613453, XrefRangeStart = 613450, XrefRangeEnd = 613452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetCompatibleDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0004678C File Offset: 0x0004498C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 613458, RefRangeEnd = 613471, XrefRangeStart = 613453, XrefRangeEnd = 613458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00046800 File Offset: 0x00044A00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613473, RefRangeEnd = 613475, XrefRangeStart = 613471, XrefRangeEnd = 613473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthBufferBits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00046878 File Offset: 0x00044A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613475, XrefRangeEnd = 613476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequireSRGBConversionBlitToBackBuffer(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000468C8 File Offset: 0x00044AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613476, XrefRangeEnd = 613477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequireHDROutput(ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00046918 File Offset: 0x00044B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613698, RefRangeEnd = 613699, XrefRangeStart = 613477, XrefRangeEnd = 613698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00046970 File Offset: 0x00044B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613758, RefRangeEnd = 613759, XrefRangeStart = 613699, XrefRangeEnd = 613758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000469EC File Offset: 0x00044BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613759, XrefRangeEnd = 613760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00046A74 File Offset: 0x00044C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613822, RefRangeEnd = 613823, XrefRangeStart = 613760, XrefRangeEnd = 613822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00046AFC File Offset: 0x00044CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613835, RefRangeEnd = 613836, XrefRangeStart = 613823, XrefRangeEnd = 613835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareBokehKernel(float maxRadius, float rcpAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rcpAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00046B48 File Offset: 0x00044D48
		[CallerCount(0)]
		public unsafe static float GetMaxBokehRadiusInPixels(float viewportHeight)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewportHeight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00046B88 File Offset: 0x00044D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 613887, RefRangeEnd = 613889, XrefRangeStart = 613836, XrefRangeEnd = 613887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00046BFC File Offset: 0x00044DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613894, RefRangeEnd = 613895, XrefRangeStart = 613889, XrefRangeEnd = 613894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00046C60 File Offset: 0x00044E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613910, RefRangeEnd = 613911, XrefRangeStart = 613895, XrefRangeEnd = 613910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LensFlareDataDrivenComputeOcclusion(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePanini;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniCropToFit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00046CEC File Offset: 0x00044EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613940, RefRangeEnd = 613941, XrefRangeStart = 613911, XrefRangeEnd = 613940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LensFlareDataDriven(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePanini;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniCropToFit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00046D78 File Offset: 0x00044F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613953, RefRangeEnd = 613954, XrefRangeStart = 613941, XrefRangeEnd = 613953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(material);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xr);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			material = ((intPtr4 == 0) ? null : new Material(intPtr4));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00046DE8 File Offset: 0x00044FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613969, RefRangeEnd = 613970, XrefRangeStart = 613954, XrefRangeEnd = 613969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, ref CameraData cameraData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00046E64 File Offset: 0x00045064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 613992, RefRangeEnd = 613993, XrefRangeStart = 613970, XrefRangeEnd = 613992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00046EE0 File Offset: 0x000450E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613993, XrefRangeEnd = 613995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalcViewExtents(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00046F30 File Offset: 0x00045130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613995, XrefRangeEnd = 613999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalcCropExtents(Camera camera, float d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00046F8C File Offset: 0x0004518C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614089, RefRangeEnd = 614090, XrefRangeStart = 613999, XrefRangeEnd = 614089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00046FF4 File Offset: 0x000451F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614103, RefRangeEnd = 614104, XrefRangeStart = 614090, XrefRangeEnd = 614103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupLensDistortion(Material material, bool isSceneView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSceneView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00047044 File Offset: 0x00045244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614104, XrefRangeEnd = 614112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupChromaticAberration(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00047088 File Offset: 0x00045288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614128, RefRangeEnd = 614129, XrefRangeStart = 614112, XrefRangeEnd = 614128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupVignette(Material material, XRPass xrPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000470DC File Offset: 0x000452DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614150, RefRangeEnd = 614151, XrefRangeStart = 614129, XrefRangeEnd = 614150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00047144 File Offset: 0x00045344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614159, RefRangeEnd = 614161, XrefRangeStart = 614151, XrefRangeEnd = 614159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupGrain(ref CameraData cameraData, Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupGrain_Private_Void_byref_CameraData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0004719C File Offset: 0x0004539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614161, XrefRangeEnd = 614165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupDithering(ref CameraData cameraData, Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupDithering_Private_Void_byref_CameraData_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x000471F4 File Offset: 0x000453F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 614175, RefRangeEnd = 614178, XrefRangeStart = 614165, XrefRangeEnd = 614175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hdrDisplayInformation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrDisplayColorGamut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdrOperations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00047260 File Offset: 0x00045460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614273, RefRangeEnd = 614274, XrefRangeStart = 614178, XrefRangeEnd = 614273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000472B8 File Offset: 0x000454B8
		[CallerCount(0)]
		public unsafe RTHandle Method_Private_RTHandle_byref___c__DisplayClass68_0_0(ref PostProcessPass.__c__DisplayClass68_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0004730C File Offset: 0x0004550C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 614291, RefRangeEnd = 614298, XrefRangeStart = 614274, XrefRangeEnd = 614291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTHandle Method_Private_RTHandle_byref___c__DisplayClass68_0_1(ref PostProcessPass.__c__DisplayClass68_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00047360 File Offset: 0x00045560
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 614308, RefRangeEnd = 614315, XrefRangeStart = 614298, XrefRangeEnd = 614308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass68_0_0(ref ScriptableRenderer r, ref PostProcessPass.__c__DisplayClass68_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(r);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass68_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			r = ((intPtr4 == 0) ? null : new ScriptableRenderer(intPtr4));
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00008992 File Offset: 0x00006B92
		public PostProcessPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000473CC File Offset: 0x000455CC
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0000899B File Offset: 0x00006B9B
		public unsafe RenderTextureDescriptor m_Descriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Descriptor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Descriptor)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000473F4 File Offset: 0x000455F4
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x000089B6 File Offset: 0x00006BB6
		public unsafe RTHandle m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00047424 File Offset: 0x00045624
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x000089D5 File Offset: 0x00006BD5
		public unsafe RTHandle m_Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00047454 File Offset: 0x00045654
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x000089F4 File Offset: 0x00006BF4
		public unsafe RTHandle m_Depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Depth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Depth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00047484 File Offset: 0x00045684
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00008A13 File Offset: 0x00006C13
		public unsafe RTHandle m_InternalLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_InternalLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_InternalLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x000474B4 File Offset: 0x000456B4
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00008A32 File Offset: 0x00006C32
		public unsafe RTHandle m_MotionVectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MotionVectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MotionVectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000474E4 File Offset: 0x000456E4
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00008A51 File Offset: 0x00006C51
		public unsafe RTHandle m_FullCoCTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_FullCoCTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_FullCoCTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00047514 File Offset: 0x00045714
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00008A70 File Offset: 0x00006C70
		public unsafe RTHandle m_HalfCoCTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_HalfCoCTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_HalfCoCTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00047544 File Offset: 0x00045744
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00008A8F File Offset: 0x00006C8F
		public unsafe RTHandle m_PingTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PingTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PingTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00047574 File Offset: 0x00045774
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x00008AAE File Offset: 0x00006CAE
		public unsafe RTHandle m_PongTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PongTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PongTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x000475A4 File Offset: 0x000457A4
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00008ACD File Offset: 0x00006CCD
		public unsafe Il2CppReferenceArray<RTHandle> m_BloomMipDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BloomMipDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BloomMipDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000475D4 File Offset: 0x000457D4
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00008AEC File Offset: 0x00006CEC
		public unsafe Il2CppReferenceArray<RTHandle> m_BloomMipUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BloomMipUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BloomMipUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00047604 File Offset: 0x00045804
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00008B0B File Offset: 0x00006D0B
		public unsafe RTHandle m_BlendTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BlendTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BlendTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00047634 File Offset: 0x00045834
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00008B2A File Offset: 0x00006D2A
		public unsafe RTHandle m_EdgeColorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EdgeColorTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EdgeColorTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00047664 File Offset: 0x00045864
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00008B49 File Offset: 0x00006D49
		public unsafe RTHandle m_EdgeStencilTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EdgeStencilTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EdgeStencilTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00047694 File Offset: 0x00045894
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00008B68 File Offset: 0x00006D68
		public unsafe RTHandle m_TempTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_TempTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_TempTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000476C4 File Offset: 0x000458C4
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00008B87 File Offset: 0x00006D87
		public unsafe RTHandle m_TempTarget2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_TempTarget2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_TempTarget2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x000476F4 File Offset: 0x000458F4
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00008BA6 File Offset: 0x00006DA6
		public unsafe static string k_RenderPostProcessingTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_RenderPostProcessingTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_RenderPostProcessingTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00047714 File Offset: 0x00045914
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00008BB8 File Offset: 0x00006DB8
		public unsafe static string k_RenderFinalPostProcessingTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_RenderFinalPostProcessingTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_RenderFinalPostProcessingTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00047734 File Offset: 0x00045934
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00008BCA File Offset: 0x00006DCA
		public unsafe static ProfilingSampler m_ProfilingRenderPostProcessing
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderPostProcessing, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderPostProcessing, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004775C File Offset: 0x0004595C
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00008BDC File Offset: 0x00006DDC
		public unsafe static ProfilingSampler m_ProfilingRenderFinalPostProcessing
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00047784 File Offset: 0x00045984
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00008BEE File Offset: 0x00006DEE
		public unsafe PostProcessPass.MaterialLibrary m_Materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessPass.MaterialLibrary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x000477B4 File Offset: 0x000459B4
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00008C0D File Offset: 0x00006E0D
		public unsafe PostProcessData m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000477E4 File Offset: 0x000459E4
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00008C2C File Offset: 0x00006E2C
		public unsafe DepthOfField m_DepthOfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DepthOfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DepthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00047814 File Offset: 0x00045A14
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00008C4B File Offset: 0x00006E4B
		public unsafe MotionBlur m_MotionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MotionBlur);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlur>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MotionBlur), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00047844 File Offset: 0x00045A44
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00008C6A File Offset: 0x00006E6A
		public unsafe PaniniProjection m_PaniniProjection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PaniniProjection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PaniniProjection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_PaniniProjection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00047874 File Offset: 0x00045A74
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00008C89 File Offset: 0x00006E89
		public unsafe Bloom m_Bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bloom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x000478A4 File Offset: 0x00045AA4
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00008CA8 File Offset: 0x00006EA8
		public unsafe LensDistortion m_LensDistortion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_LensDistortion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensDistortion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_LensDistortion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000478D4 File Offset: 0x00045AD4
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00008CC7 File Offset: 0x00006EC7
		public unsafe ChromaticAberration m_ChromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ChromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ChromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00047904 File Offset: 0x00045B04
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00008CE6 File Offset: 0x00006EE6
		public unsafe Vignette m_Vignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Vignette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vignette>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Vignette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00047934 File Offset: 0x00045B34
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00008D05 File Offset: 0x00006F05
		public unsafe ColorLookup m_ColorLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ColorLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorLookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ColorLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00047964 File Offset: 0x00045B64
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00008D24 File Offset: 0x00006F24
		public unsafe ColorAdjustments m_ColorAdjustments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ColorAdjustments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorAdjustments>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ColorAdjustments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00047994 File Offset: 0x00045B94
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00008D43 File Offset: 0x00006F43
		public unsafe Tonemapping m_Tonemapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Tonemapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tonemapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_Tonemapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000479C4 File Offset: 0x00045BC4
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00008D62 File Offset: 0x00006F62
		public unsafe FilmGrain m_FilmGrain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_FilmGrain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilmGrain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_FilmGrain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000479F4 File Offset: 0x00045BF4
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00008D81 File Offset: 0x00006F81
		public unsafe static int k_MaxPyramidSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_MaxPyramidSize, (void*)(&value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00047A10 File Offset: 0x00045C10
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00008D8F File Offset: 0x00006F8F
		public unsafe GraphicsFormat m_DefaultHDRFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DefaultHDRFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DefaultHDRFormat)) = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00047A38 File Offset: 0x00045C38
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00008DAA File Offset: 0x00006FAA
		public unsafe bool m_UseRGBM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseRGBM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseRGBM)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00047A60 File Offset: 0x00045C60
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00008DC5 File Offset: 0x00006FC5
		public unsafe GraphicsFormat m_SMAAEdgeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_SMAAEdgeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_SMAAEdgeFormat)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00047A88 File Offset: 0x00045C88
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public unsafe GraphicsFormat m_GaussianCoCFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_GaussianCoCFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_GaussianCoCFormat)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00047AB0 File Offset: 0x00045CB0
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00008DFB File Offset: 0x00006FFB
		public unsafe int m_DitheringTextureIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DitheringTextureIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_DitheringTextureIndex)) = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x00047AD8 File Offset: 0x00045CD8
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00008E16 File Offset: 0x00007016
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MRT2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_MRT2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00047B08 File Offset: 0x00045D08
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00008E35 File Offset: 0x00007035
		public unsafe Il2CppStructArray<Vector4> m_BokehKernel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehKernel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehKernel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00047B38 File Offset: 0x00045D38
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00008E54 File Offset: 0x00007054
		public unsafe int m_BokehHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehHash)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00047B60 File Offset: 0x00045D60
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00008E6F File Offset: 0x0000706F
		public unsafe float m_BokehMaxRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehMaxRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehMaxRadius)) = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00047B88 File Offset: 0x00045D88
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00008E8A File Offset: 0x0000708A
		public unsafe float m_BokehRCPAspect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehRCPAspect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BokehRCPAspect)) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00047BB0 File Offset: 0x00045DB0
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00008EA5 File Offset: 0x000070A5
		public unsafe bool m_IsFinalPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_IsFinalPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_IsFinalPass)) = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00047BD8 File Offset: 0x00045DD8
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00008EC0 File Offset: 0x000070C0
		public unsafe bool m_HasFinalPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_HasFinalPass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_HasFinalPass)) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00047C00 File Offset: 0x00045E00
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00008EDB File Offset: 0x000070DB
		public unsafe bool m_EnableColorEncodingIfNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00047C28 File Offset: 0x00045E28
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00008EF6 File Offset: 0x000070F6
		public unsafe bool m_UseFastSRGBLinearConversion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseFastSRGBLinearConversion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseFastSRGBLinearConversion)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00047C50 File Offset: 0x00045E50
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00008F11 File Offset: 0x00007111
		public unsafe bool m_SupportDataDrivenLensFlare
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_SupportDataDrivenLensFlare);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_SupportDataDrivenLensFlare)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00047C78 File Offset: 0x00045E78
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00008F2C File Offset: 0x0000712C
		public unsafe bool m_ResolveToScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ResolveToScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ResolveToScreen)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00047CA0 File Offset: 0x00045EA0
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00008F47 File Offset: 0x00007147
		public unsafe bool m_UseSwapBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseSwapBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UseSwapBuffer)) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00047CC8 File Offset: 0x00045EC8
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00008F62 File Offset: 0x00007162
		public unsafe RTHandle m_ScalingSetupTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ScalingSetupTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_ScalingSetupTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00047CF8 File Offset: 0x00045EF8
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00008F81 File Offset: 0x00007181
		public unsafe RTHandle m_UpscaledTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UpscaledTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_UpscaledTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00047D28 File Offset: 0x00045F28
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00008FA0 File Offset: 0x000071A0
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00047D58 File Offset: 0x00045F58
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00008FBF File Offset: 0x000071BF
		public unsafe static int k_ShaderPropertyId_ViewProjM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM, (void*)(&value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00047D74 File Offset: 0x00045F74
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00008FCD File Offset: 0x000071CD
		public unsafe static int k_ShaderPropertyId_PrevViewProjM
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM, (void*)(&value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00047D90 File Offset: 0x00045F90
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00008FDB File Offset: 0x000071DB
		public unsafe static int k_ShaderPropertyId_ViewProjMStereo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo, (void*)(&value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00047DAC File Offset: 0x00045FAC
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00008FE9 File Offset: 0x000071E9
		public unsafe static int k_ShaderPropertyId_PrevViewProjMStereo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PostProcessPass.NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo, (void*)(&value));
			}
		}

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_m_Descriptor;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_m_Destination;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_m_Depth;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLut;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionVectors;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr_m_FullCoCTexture;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr_m_HalfCoCTexture;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr_m_PingTexture;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_m_PongTexture;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_m_BloomMipDown;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_m_BloomMipUp;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendTexture;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_m_EdgeColorTexture;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_m_EdgeStencilTexture;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr_m_TempTarget;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_m_TempTarget2;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_k_RenderPostProcessingTag;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_k_RenderFinalPostProcessingTag;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingRenderPostProcessing;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingRenderFinalPostProcessing;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_m_Materials;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthOfField;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_m_MotionBlur;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_m_PaniniProjection;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_m_Bloom;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_m_LensDistortion;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_m_ChromaticAberration;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_m_Vignette;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorLookup;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorAdjustments;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_m_Tonemapping;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_m_FilmGrain;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxPyramidSize;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultHDRFormat;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_m_UseRGBM;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_m_SMAAEdgeFormat;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_m_GaussianCoCFormat;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_m_DitheringTextureIndex;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT2;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_m_BokehKernel;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_m_BokehHash;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_m_BokehMaxRadius;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_m_BokehRCPAspect;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_m_IsFinalPass;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFinalPass;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableColorEncodingIfNeeded;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeFieldInfoPtr_m_UseFastSRGBLinearConversion;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_m_SupportDataDrivenLensFlare;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolveToScreen;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_m_UseSwapBuffer;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_m_ScalingSetupTarget;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_m_UpscaledTarget;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjM;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjM;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_ViewProjMStereo;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderPropertyId_PrevViewProjMStereo;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_byref_PostProcessParams_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_RenderTextureDescriptor_byref_RTHandle_Boolean_byref_RTHandle_byref_RTHandle_byref_RTHandle_Boolean_Boolean_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_SetupFinalPass_Public_Void_byref_RTHandle_Boolean_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_CanRunOnTile_Public_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Private_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_GetCompatibleDescriptor_Internal_Static_RenderTextureDescriptor_RenderTextureDescriptor_Int32_Int32_GraphicsFormat_DepthBits_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_RequireSRGBConversionBlitToBackBuffer_Private_Boolean_byref_CameraData_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_RequireHDROutput_Private_Boolean_byref_CameraData_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_Render_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_DoSubpixelMorphologicalAntialiasing_Private_Void_byref_CameraData_CommandBuffer_RTHandle_RTHandle_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_DoDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_DoGaussianDepthOfField_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_Rect_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_PrepareBokehKernel_Private_Void_Single_Single_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxBokehRadiusInPixels_Private_Static_Single_Single_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_DoBokehDepthOfField_Private_Void_CommandBuffer_RTHandle_RTHandle_Rect_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_GetLensFlareLightAttenuation_Private_Static_Single_Light_Camera_Vector3_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_LensFlareDataDrivenComputeOcclusion_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_LensFlareDataDriven_Private_Void_Camera_CommandBuffer_RenderTargetIdentifier_Boolean_Single_Single_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMotionBlurMatrices_Internal_Static_Void_byref_Material_Camera_XRPass_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_DoMotionBlur_Private_Void_CommandBuffer_RTHandle_RTHandle_byref_CameraData_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_DoPaniniProjection_Private_Void_Camera_CommandBuffer_RTHandle_RTHandle_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_CalcViewExtents_Private_Vector2_Camera_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_CalcCropExtents_Private_Vector2_Camera_Single_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_SetupBloom_Private_Void_CommandBuffer_RTHandle_Material_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_SetupLensDistortion_Private_Void_Material_Boolean_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_SetupChromaticAberration_Private_Void_Material_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_SetupVignette_Private_Void_Material_XRPass_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_SetupColorGrading_Private_Void_CommandBuffer_byref_RenderingData_Material_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_SetupGrain_Private_Void_byref_CameraData_Material_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_SetupDithering_Private_Void_byref_CameraData_Material_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_SetupHDROutput_Private_Void_HDRDisplayInformation_ColorGamut_Material_Operation_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_RenderFinalPass_Private_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_RTHandle_byref___c__DisplayClass68_0_1;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_byref_ScriptableRenderer_byref___c__DisplayClass68_0_0;

		// Token: 0x020001A9 RID: 425
		public class MaterialLibrary : Object
		{
			// Token: 0x06001EA6 RID: 7846 RVA: 0x0007AA8C File Offset: 0x00078C8C
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialLibrary()
			{
				Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "MaterialLibrary");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr);
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_stopNaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "stopNaN");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "subpixelMorphologicalAntialiasing");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_gaussianDepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "gaussianDepthOfField");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bokehDepthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "bokehDepthOfField");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_cameraMotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "cameraMotionBlur");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_paniniProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "paniniProjection");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "bloom");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_temporalAntialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "temporalAntialiasing");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_scalingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "scalingSetup");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_easu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "easu");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_uber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "uber");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_finalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "finalPass");
				PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_lensFlareDataDriven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, "lensFlareDataDriven");
				PostProcessPass.MaterialLibrary.NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, 100665159);
				PostProcessPass.MaterialLibrary.NativeMethodInfoPtr_Load_Private_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, 100665160);
				PostProcessPass.MaterialLibrary.NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr, 100665161);
			}

			// Token: 0x06001EA7 RID: 7847 RVA: 0x0007ABF8 File Offset: 0x00078DF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 613193, RefRangeEnd = 613194, XrefRangeStart = 613165, XrefRangeEnd = 613193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialLibrary(PostProcessData data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPass.MaterialLibrary>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.MaterialLibrary.NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001EA8 RID: 7848 RVA: 0x0007AC44 File Offset: 0x00078E44
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 613215, RefRangeEnd = 613228, XrefRangeStart = 613194, XrefRangeEnd = 613215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Material Load(Shader shader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(shader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.MaterialLibrary.NativeMethodInfoPtr_Load_Private_Material_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
				}
			}

			// Token: 0x06001EA9 RID: 7849 RVA: 0x0007AC94 File Offset: 0x00078E94
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 613244, RefRangeEnd = 613245, XrefRangeStart = 613228, XrefRangeEnd = 613244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Cleanup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.MaterialLibrary.NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EAA RID: 7850 RVA: 0x00011927 File Offset: 0x0000FB27
			public MaterialLibrary(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0007ACC8 File Offset: 0x00078EC8
			// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00011930 File Offset: 0x0000FB30
			public unsafe Material stopNaN
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_stopNaN);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_stopNaN), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x06001EAD RID: 7853 RVA: 0x0007ACF8 File Offset: 0x00078EF8
			// (set) Token: 0x06001EAE RID: 7854 RVA: 0x0001194F File Offset: 0x0000FB4F
			public unsafe Material subpixelMorphologicalAntialiasing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_subpixelMorphologicalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06001EAF RID: 7855 RVA: 0x0007AD28 File Offset: 0x00078F28
			// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x0001196E File Offset: 0x0000FB6E
			public unsafe Material gaussianDepthOfField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_gaussianDepthOfField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_gaussianDepthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x0007AD58 File Offset: 0x00078F58
			// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x0001198D File Offset: 0x0000FB8D
			public unsafe Material bokehDepthOfField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bokehDepthOfField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bokehDepthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x0007AD88 File Offset: 0x00078F88
			// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x000119AC File Offset: 0x0000FBAC
			public unsafe Material cameraMotionBlur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_cameraMotionBlur);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_cameraMotionBlur), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x0007ADB8 File Offset: 0x00078FB8
			// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x000119CB File Offset: 0x0000FBCB
			public unsafe Material paniniProjection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_paniniProjection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_paniniProjection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x0007ADE8 File Offset: 0x00078FE8
			// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x000119EA File Offset: 0x0000FBEA
			public unsafe Material bloom
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bloom);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x0007AE18 File Offset: 0x00079018
			// (set) Token: 0x06001EBA RID: 7866 RVA: 0x00011A09 File Offset: 0x0000FC09
			public unsafe Material temporalAntialiasing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_temporalAntialiasing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_temporalAntialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0007AE48 File Offset: 0x00079048
			// (set) Token: 0x06001EBC RID: 7868 RVA: 0x00011A28 File Offset: 0x0000FC28
			public unsafe Material scalingSetup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_scalingSetup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_scalingSetup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06001EBD RID: 7869 RVA: 0x0007AE78 File Offset: 0x00079078
			// (set) Token: 0x06001EBE RID: 7870 RVA: 0x00011A47 File Offset: 0x0000FC47
			public unsafe Material easu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_easu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_easu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06001EBF RID: 7871 RVA: 0x0007AEA8 File Offset: 0x000790A8
			// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x00011A66 File Offset: 0x0000FC66
			public unsafe Material uber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_uber);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_uber), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0007AED8 File Offset: 0x000790D8
			// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x00011A85 File Offset: 0x0000FC85
			public unsafe Material finalPass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_finalPass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_finalPass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x0007AF08 File Offset: 0x00079108
			// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x00011AA4 File Offset: 0x0000FCA4
			public unsafe Material lensFlareDataDriven
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_lensFlareDataDriven);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.MaterialLibrary.NativeFieldInfoPtr_lensFlareDataDriven), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeFieldInfoPtr_stopNaN;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeFieldInfoPtr_subpixelMorphologicalAntialiasing;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeFieldInfoPtr_gaussianDepthOfField;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeFieldInfoPtr_bokehDepthOfField;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeFieldInfoPtr_cameraMotionBlur;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeFieldInfoPtr_paniniProjection;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeFieldInfoPtr_bloom;

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr_temporalAntialiasing;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeFieldInfoPtr_scalingSetup;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeFieldInfoPtr_easu;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeFieldInfoPtr_uber;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr_finalPass;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeFieldInfoPtr_lensFlareDataDriven;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_0;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr_Load_Private_Material_Shader_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;
		}

		// Token: 0x020001AA RID: 426
		public static class ShaderConstants : Object
		{
			// Token: 0x06001EC5 RID: 7877 RVA: 0x0007AF38 File Offset: 0x00079138
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderConstants()
			{
				Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "ShaderConstants");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr);
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_TempTarget");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_TempTarget2");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_StencilRef");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_StencilMask");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FullCoCTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__HalfCoCTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_HalfCoCTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DofTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_DofTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__CoCParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_CoCParams");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_BokehKernel");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_BokehConstants");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PongTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_PongTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PingTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_PingTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Metrics");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__AreaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_AreaTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SearchTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_SearchTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__EdgeTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_EdgeTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BlendTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_BlendTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__ColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_ColorTexture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SourceTexLowMip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_SourceTexLowMip");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Bloom_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_RGBM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Bloom_RGBM");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Bloom_Texture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_LensDirt_Texture");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_LensDirt_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_LensDirt_Intensity");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Distortion_Params1");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Distortion_Params2");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Chroma_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Chroma_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Vignette_Params1");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Vignette_Params2");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_ParamsXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Vignette_ParamsXR");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_Lut_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_UserLut_Params");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_InternalLut");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_UserLut");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DownSampleScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_DownSampleScaleFactor");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionRemapTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareOcclusionRemapTex");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareOcclusionTex");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareOcclusionIndex");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareTex");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareColorValue");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData0");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData1");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData2");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData3");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData4");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FlareData5");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullscreenProjMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_FullscreenProjMat");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_BloomMipUp");
				PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.ShaderConstants>.NativeClassPtr, "_BloomMipDown");
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x00011AC3 File Offset: 0x0000FCC3
			public ShaderConstants(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x0007B360 File Offset: 0x00079560
			// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00011ACC File Offset: 0x0000FCCC
			public unsafe static int _TempTarget
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget, (void*)(&value));
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0007B37C File Offset: 0x0007957C
			// (set) Token: 0x06001ECA RID: 7882 RVA: 0x00011ADA File Offset: 0x0000FCDA
			public unsafe static int _TempTarget2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__TempTarget2, (void*)(&value));
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0007B398 File Offset: 0x00079598
			// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00011AE8 File Offset: 0x0000FCE8
			public unsafe static int _StencilRef
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilRef, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilRef, (void*)(&value));
				}
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0007B3B4 File Offset: 0x000795B4
			// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00011AF6 File Offset: 0x0000FCF6
			public unsafe static int _StencilMask
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilMask, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__StencilMask, (void*)(&value));
				}
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06001ECF RID: 7887 RVA: 0x0007B3D0 File Offset: 0x000795D0
			// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x00011B04 File Offset: 0x0000FD04
			public unsafe static int _FullCoCTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullCoCTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullCoCTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x0007B3EC File Offset: 0x000795EC
			// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x00011B12 File Offset: 0x0000FD12
			public unsafe static int _HalfCoCTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__HalfCoCTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__HalfCoCTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x0007B408 File Offset: 0x00079608
			// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x00011B20 File Offset: 0x0000FD20
			public unsafe static int _DofTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DofTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DofTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0007B424 File Offset: 0x00079624
			// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x00011B2E File Offset: 0x0000FD2E
			public unsafe static int _CoCParams
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__CoCParams, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__CoCParams, (void*)(&value));
				}
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0007B440 File Offset: 0x00079640
			// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x00011B3C File Offset: 0x0000FD3C
			public unsafe static int _BokehKernel
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehKernel, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehKernel, (void*)(&value));
				}
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x0007B45C File Offset: 0x0007965C
			// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00011B4A File Offset: 0x0000FD4A
			public unsafe static int _BokehConstants
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehConstants, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BokehConstants, (void*)(&value));
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0007B478 File Offset: 0x00079678
			// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00011B58 File Offset: 0x0000FD58
			public unsafe static int _PongTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PongTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PongTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0007B494 File Offset: 0x00079694
			// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00011B66 File Offset: 0x0000FD66
			public unsafe static int _PingTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PingTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__PingTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0007B4B0 File Offset: 0x000796B0
			// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x00011B74 File Offset: 0x0000FD74
			public unsafe static int _Metrics
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Metrics, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Metrics, (void*)(&value));
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0007B4CC File Offset: 0x000796CC
			// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00011B82 File Offset: 0x0000FD82
			public unsafe static int _AreaTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__AreaTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__AreaTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0007B4E8 File Offset: 0x000796E8
			// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00011B90 File Offset: 0x0000FD90
			public unsafe static int _SearchTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SearchTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SearchTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0007B504 File Offset: 0x00079704
			// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x00011B9E File Offset: 0x0000FD9E
			public unsafe static int _EdgeTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__EdgeTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__EdgeTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x0007B520 File Offset: 0x00079720
			// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x00011BAC File Offset: 0x0000FDAC
			public unsafe static int _BlendTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BlendTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BlendTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0007B53C File Offset: 0x0007973C
			// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00011BBA File Offset: 0x0000FDBA
			public unsafe static int _ColorTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__ColorTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__ColorTexture, (void*)(&value));
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06001EEB RID: 7915 RVA: 0x0007B558 File Offset: 0x00079758
			// (set) Token: 0x06001EEC RID: 7916 RVA: 0x00011BC8 File Offset: 0x0000FDC8
			public unsafe static int _Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Params, (void*)(&value));
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x06001EED RID: 7917 RVA: 0x0007B574 File Offset: 0x00079774
			// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00011BD6 File Offset: 0x0000FDD6
			public unsafe static int _SourceTexLowMip
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SourceTexLowMip, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__SourceTexLowMip, (void*)(&value));
				}
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0007B590 File Offset: 0x00079790
			// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00011BE4 File Offset: 0x0000FDE4
			public unsafe static int _Bloom_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0007B5AC File Offset: 0x000797AC
			// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00011BF2 File Offset: 0x0000FDF2
			public unsafe static int _Bloom_RGBM
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_RGBM, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_RGBM, (void*)(&value));
				}
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0007B5C8 File Offset: 0x000797C8
			// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00011C00 File Offset: 0x0000FE00
			public unsafe static int _Bloom_Texture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Texture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Bloom_Texture, (void*)(&value));
				}
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x0007B5E4 File Offset: 0x000797E4
			// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00011C0E File Offset: 0x0000FE0E
			public unsafe static int _LensDirt_Texture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Texture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Texture, (void*)(&value));
				}
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0007B600 File Offset: 0x00079800
			// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00011C1C File Offset: 0x0000FE1C
			public unsafe static int _LensDirt_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0007B61C File Offset: 0x0007981C
			// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00011C2A File Offset: 0x0000FE2A
			public unsafe static int _LensDirt_Intensity
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Intensity, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__LensDirt_Intensity, (void*)(&value));
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x06001EFB RID: 7931 RVA: 0x0007B638 File Offset: 0x00079838
			// (set) Token: 0x06001EFC RID: 7932 RVA: 0x00011C38 File Offset: 0x0000FE38
			public unsafe static int _Distortion_Params1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params1, (void*)(&value));
				}
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06001EFD RID: 7933 RVA: 0x0007B654 File Offset: 0x00079854
			// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00011C46 File Offset: 0x0000FE46
			public unsafe static int _Distortion_Params2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Distortion_Params2, (void*)(&value));
				}
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0007B670 File Offset: 0x00079870
			// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00011C54 File Offset: 0x0000FE54
			public unsafe static int _Chroma_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Chroma_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Chroma_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0007B68C File Offset: 0x0007988C
			// (set) Token: 0x06001F02 RID: 7938 RVA: 0x00011C62 File Offset: 0x0000FE62
			public unsafe static int _Vignette_Params1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params1, (void*)(&value));
				}
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0007B6A8 File Offset: 0x000798A8
			// (set) Token: 0x06001F04 RID: 7940 RVA: 0x00011C70 File Offset: 0x0000FE70
			public unsafe static int _Vignette_Params2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_Params2, (void*)(&value));
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0007B6C4 File Offset: 0x000798C4
			// (set) Token: 0x06001F06 RID: 7942 RVA: 0x00011C7E File Offset: 0x0000FE7E
			public unsafe static int _Vignette_ParamsXR
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_ParamsXR, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Vignette_ParamsXR, (void*)(&value));
				}
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0007B6E0 File Offset: 0x000798E0
			// (set) Token: 0x06001F08 RID: 7944 RVA: 0x00011C8C File Offset: 0x0000FE8C
			public unsafe static int _Lut_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__Lut_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0007B6FC File Offset: 0x000798FC
			// (set) Token: 0x06001F0A RID: 7946 RVA: 0x00011C9A File Offset: 0x0000FE9A
			public unsafe static int _UserLut_Params
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut_Params, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut_Params, (void*)(&value));
				}
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0007B718 File Offset: 0x00079918
			// (set) Token: 0x06001F0C RID: 7948 RVA: 0x00011CA8 File Offset: 0x0000FEA8
			public unsafe static int _InternalLut
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__InternalLut, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__InternalLut, (void*)(&value));
				}
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x06001F0D RID: 7949 RVA: 0x0007B734 File Offset: 0x00079934
			// (set) Token: 0x06001F0E RID: 7950 RVA: 0x00011CB6 File Offset: 0x0000FEB6
			public unsafe static int _UserLut
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__UserLut, (void*)(&value));
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0007B750 File Offset: 0x00079950
			// (set) Token: 0x06001F10 RID: 7952 RVA: 0x00011CC4 File Offset: 0x0000FEC4
			public unsafe static int _DownSampleScaleFactor
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DownSampleScaleFactor, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__DownSampleScaleFactor, (void*)(&value));
				}
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0007B76C File Offset: 0x0007996C
			// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00011CD2 File Offset: 0x0000FED2
			public unsafe static int _FlareOcclusionRemapTex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionRemapTex, (void*)(&value));
				}
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0007B788 File Offset: 0x00079988
			// (set) Token: 0x06001F14 RID: 7956 RVA: 0x00011CE0 File Offset: 0x0000FEE0
			public unsafe static int _FlareOcclusionTex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionTex, (void*)(&value));
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0007B7A4 File Offset: 0x000799A4
			// (set) Token: 0x06001F16 RID: 7958 RVA: 0x00011CEE File Offset: 0x0000FEEE
			public unsafe static int _FlareOcclusionIndex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareOcclusionIndex, (void*)(&value));
				}
			}

			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0007B7C0 File Offset: 0x000799C0
			// (set) Token: 0x06001F18 RID: 7960 RVA: 0x00011CFC File Offset: 0x0000FEFC
			public unsafe static int _FlareTex
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareTex, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareTex, (void*)(&value));
				}
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0007B7DC File Offset: 0x000799DC
			// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00011D0A File Offset: 0x0000FF0A
			public unsafe static int _FlareColorValue
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareColorValue, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareColorValue, (void*)(&value));
				}
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0007B7F8 File Offset: 0x000799F8
			// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00011D18 File Offset: 0x0000FF18
			public unsafe static int _FlareData0
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData0, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData0, (void*)(&value));
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0007B814 File Offset: 0x00079A14
			// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00011D26 File Offset: 0x0000FF26
			public unsafe static int _FlareData1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData1, (void*)(&value));
				}
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06001F1F RID: 7967 RVA: 0x0007B830 File Offset: 0x00079A30
			// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00011D34 File Offset: 0x0000FF34
			public unsafe static int _FlareData2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData2, (void*)(&value));
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06001F21 RID: 7969 RVA: 0x0007B84C File Offset: 0x00079A4C
			// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00011D42 File Offset: 0x0000FF42
			public unsafe static int _FlareData3
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData3, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData3, (void*)(&value));
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06001F23 RID: 7971 RVA: 0x0007B868 File Offset: 0x00079A68
			// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00011D50 File Offset: 0x0000FF50
			public unsafe static int _FlareData4
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData4, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData4, (void*)(&value));
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06001F25 RID: 7973 RVA: 0x0007B884 File Offset: 0x00079A84
			// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00011D5E File Offset: 0x0000FF5E
			public unsafe static int _FlareData5
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData5, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FlareData5, (void*)(&value));
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06001F27 RID: 7975 RVA: 0x0007B8A0 File Offset: 0x00079AA0
			// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00011D6C File Offset: 0x0000FF6C
			public unsafe static int _FullscreenProjMat
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullscreenProjMat, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__FullscreenProjMat, (void*)(&value));
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0007B8BC File Offset: 0x00079ABC
			// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00011D7A File Offset: 0x0000FF7A
			public unsafe static Il2CppStructArray<int> _BloomMipUp
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipUp, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipUp, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0007B8E4 File Offset: 0x00079AE4
			// (set) Token: 0x06001F2C RID: 7980 RVA: 0x00011D8C File Offset: 0x0000FF8C
			public unsafe static Il2CppStructArray<int> _BloomMipDown
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipDown, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.ShaderConstants.NativeFieldInfoPtr__BloomMipDown, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeFieldInfoPtr__TempTarget;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeFieldInfoPtr__TempTarget2;

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeFieldInfoPtr__StencilRef;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeFieldInfoPtr__StencilMask;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeFieldInfoPtr__FullCoCTexture;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeFieldInfoPtr__HalfCoCTexture;

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeFieldInfoPtr__DofTexture;

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr__CoCParams;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr__BokehKernel;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeFieldInfoPtr__BokehConstants;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeFieldInfoPtr__PongTexture;

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeFieldInfoPtr__PingTexture;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeFieldInfoPtr__Metrics;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeFieldInfoPtr__AreaTexture;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeFieldInfoPtr__SearchTexture;

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeFieldInfoPtr__EdgeTexture;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeFieldInfoPtr__BlendTexture;

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr__ColorTexture;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeFieldInfoPtr__Params;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeFieldInfoPtr__SourceTexLowMip;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_Params;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_RGBM;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_Texture;

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeFieldInfoPtr__LensDirt_Texture;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeFieldInfoPtr__LensDirt_Params;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeFieldInfoPtr__LensDirt_Intensity;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeFieldInfoPtr__Distortion_Params1;

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeFieldInfoPtr__Distortion_Params2;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeFieldInfoPtr__Chroma_Params;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Params1;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Params2;

			// Token: 0x04001628 RID: 5672
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_ParamsXR;

			// Token: 0x04001629 RID: 5673
			private static readonly IntPtr NativeFieldInfoPtr__Lut_Params;

			// Token: 0x0400162A RID: 5674
			private static readonly IntPtr NativeFieldInfoPtr__UserLut_Params;

			// Token: 0x0400162B RID: 5675
			private static readonly IntPtr NativeFieldInfoPtr__InternalLut;

			// Token: 0x0400162C RID: 5676
			private static readonly IntPtr NativeFieldInfoPtr__UserLut;

			// Token: 0x0400162D RID: 5677
			private static readonly IntPtr NativeFieldInfoPtr__DownSampleScaleFactor;

			// Token: 0x0400162E RID: 5678
			private static readonly IntPtr NativeFieldInfoPtr__FlareOcclusionRemapTex;

			// Token: 0x0400162F RID: 5679
			private static readonly IntPtr NativeFieldInfoPtr__FlareOcclusionTex;

			// Token: 0x04001630 RID: 5680
			private static readonly IntPtr NativeFieldInfoPtr__FlareOcclusionIndex;

			// Token: 0x04001631 RID: 5681
			private static readonly IntPtr NativeFieldInfoPtr__FlareTex;

			// Token: 0x04001632 RID: 5682
			private static readonly IntPtr NativeFieldInfoPtr__FlareColorValue;

			// Token: 0x04001633 RID: 5683
			private static readonly IntPtr NativeFieldInfoPtr__FlareData0;

			// Token: 0x04001634 RID: 5684
			private static readonly IntPtr NativeFieldInfoPtr__FlareData1;

			// Token: 0x04001635 RID: 5685
			private static readonly IntPtr NativeFieldInfoPtr__FlareData2;

			// Token: 0x04001636 RID: 5686
			private static readonly IntPtr NativeFieldInfoPtr__FlareData3;

			// Token: 0x04001637 RID: 5687
			private static readonly IntPtr NativeFieldInfoPtr__FlareData4;

			// Token: 0x04001638 RID: 5688
			private static readonly IntPtr NativeFieldInfoPtr__FlareData5;

			// Token: 0x04001639 RID: 5689
			private static readonly IntPtr NativeFieldInfoPtr__FullscreenProjMat;

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeFieldInfoPtr__BloomMipUp;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeFieldInfoPtr__BloomMipDown;
		}

		// Token: 0x020001AB RID: 427
		[ObfuscatedName("UnityEngine.Rendering.Universal.PostProcessPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F2D RID: 7981 RVA: 0x0007B90C File Offset: 0x00079B0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr);
				PostProcessPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr, "<>9");
				PostProcessPass.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr, "<>9__77_0");
				PostProcessPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr, 100665164);
				PostProcessPass.__c.NativeMethodInfoPtr__LensFlareDataDriven_b__77_0_Internal_Single_Light_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr, 100665165);
			}

			// Token: 0x06001F2E RID: 7982 RVA: 0x0007B988 File Offset: 0x00079B88
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F2F RID: 7983 RVA: 0x0007B9C4 File Offset: 0x00079BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 613245, XrefRangeEnd = 613249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _LensFlareDataDriven_b__77_0(Light light, Camera cam, Vector3 wo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPass.__c.NativeMethodInfoPtr__LensFlareDataDriven_b__77_0_Internal_Single_Light_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F30 RID: 7984 RVA: 0x00011D9E File Offset: 0x0000FF9E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0007BA34 File Offset: 0x00079C34
			// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00011DA7 File Offset: 0x0000FFA7
			public unsafe static PostProcessPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0007BA5C File Offset: 0x00079C5C
			// (set) Token: 0x06001F34 RID: 7988 RVA: 0x00011DB9 File Offset: 0x0000FFB9
			public unsafe static Func<Light, Camera, Vector3, float> __9__77_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PostProcessPass.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Light, Camera, Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PostProcessPass.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeMethodInfoPtr__LensFlareDataDriven_b__77_0_Internal_Single_Light_Camera_Vector3_0;
		}

		// Token: 0x020001AC RID: 428
		[ObfuscatedName("UnityEngine.Rendering.Universal.PostProcessPass+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : ValueType
		{
			// Token: 0x06001F35 RID: 7989 RVA: 0x0007BA84 File Offset: 0x00079C84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostProcessPass>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr);
				PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr, "source");
				PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr, "destination");
				PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
				PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_amountOfPassesRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr, "amountOfPassesRemaining");
				PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr, "cmd");
			}

			// Token: 0x06001F36 RID: 7990 RVA: 0x00011DCB File Offset: 0x0000FFCB
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F37 RID: 7991 RVA: 0x00011DD4 File Offset: 0x0000FFD4
			public __c__DisplayClass68_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPass.__c__DisplayClass68_0>.NativeClassPtr))
			{
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0007BB14 File Offset: 0x00079D14
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00011DE6 File Offset: 0x0000FFE6
			public unsafe RTHandle source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0007BB44 File Offset: 0x00079D44
			// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00011E05 File Offset: 0x00010005
			public unsafe RTHandle destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0007BB74 File Offset: 0x00079D74
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00011E24 File Offset: 0x00010024
			public unsafe PostProcessPass __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0007BBA4 File Offset: 0x00079DA4
			// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00011E43 File Offset: 0x00010043
			public unsafe int amountOfPassesRemaining
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_amountOfPassesRemaining);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_amountOfPassesRemaining)) = value;
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0007BBCC File Offset: 0x00079DCC
			// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00011E5E File Offset: 0x0001005E
			public unsafe CommandBuffer cmd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_cmd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPass.__c__DisplayClass68_0.NativeFieldInfoPtr_cmd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeFieldInfoPtr_amountOfPassesRemaining;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeFieldInfoPtr_cmd;
		}
	}
}
