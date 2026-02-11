using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000033 RID: 51
	public static class RendererLighting : Object
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00022D1C File Offset: 0x00020F1C
		// Note: this type is marked as 'beforefieldinit'.
		static RendererLighting()
		{
			Il2CppClassPointerStore<RendererLighting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RendererLighting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr);
			RendererLighting.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "m_ProfilingSampler");
			RendererLighting.NativeFieldInfoPtr_k_NormalsRenderingPassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_NormalsRenderingPassName");
			RendererLighting.NativeFieldInfoPtr_k_NormalClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_NormalClearColor");
			RendererLighting.NativeFieldInfoPtr_k_SpriteLightKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_SpriteLightKeyword");
			RendererLighting.NativeFieldInfoPtr_k_UsePointLightCookiesKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_UsePointLightCookiesKeyword");
			RendererLighting.NativeFieldInfoPtr_k_LightQualityFastKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightQualityFastKeyword");
			RendererLighting.NativeFieldInfoPtr_k_UseNormalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_UseNormalMap");
			RendererLighting.NativeFieldInfoPtr_k_UseAdditiveBlendingKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_UseAdditiveBlendingKeyword");
			RendererLighting.NativeFieldInfoPtr_k_UseBlendStyleKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_UseBlendStyleKeywords");
			RendererLighting.NativeFieldInfoPtr_k_BlendFactorsPropIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_BlendFactorsPropIDs");
			RendererLighting.NativeFieldInfoPtr_k_MaskFilterPropIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_MaskFilterPropIDs");
			RendererLighting.NativeFieldInfoPtr_k_InvertedFilterPropIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_InvertedFilterPropIDs");
			RendererLighting.NativeFieldInfoPtr_s_RenderTextureFormatToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "s_RenderTextureFormatToUse");
			RendererLighting.NativeFieldInfoPtr_s_HasSetupRenderTextureFormatToUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "s_HasSetupRenderTextureFormatToUse");
			RendererLighting.NativeFieldInfoPtr_k_SrcBlendID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_SrcBlendID");
			RendererLighting.NativeFieldInfoPtr_k_DstBlendID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_DstBlendID");
			RendererLighting.NativeFieldInfoPtr_k_FalloffIntensityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_FalloffIntensityID");
			RendererLighting.NativeFieldInfoPtr_k_FalloffDistanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_FalloffDistanceID");
			RendererLighting.NativeFieldInfoPtr_k_LightColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightColorID");
			RendererLighting.NativeFieldInfoPtr_k_VolumeOpacityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_VolumeOpacityID");
			RendererLighting.NativeFieldInfoPtr_k_CookieTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_CookieTexID");
			RendererLighting.NativeFieldInfoPtr_k_FalloffLookupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_FalloffLookupID");
			RendererLighting.NativeFieldInfoPtr_k_LightPositionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightPositionID");
			RendererLighting.NativeFieldInfoPtr_k_LightInvMatrixID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightInvMatrixID");
			RendererLighting.NativeFieldInfoPtr_k_InnerRadiusMultID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_InnerRadiusMultID");
			RendererLighting.NativeFieldInfoPtr_k_OuterAngleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_OuterAngleID");
			RendererLighting.NativeFieldInfoPtr_k_InnerAngleMultID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_InnerAngleMultID");
			RendererLighting.NativeFieldInfoPtr_k_LightLookupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightLookupID");
			RendererLighting.NativeFieldInfoPtr_k_IsFullSpotlightID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_IsFullSpotlightID");
			RendererLighting.NativeFieldInfoPtr_k_LightZDistanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_LightZDistanceID");
			RendererLighting.NativeFieldInfoPtr_k_PointLightCookieTexID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, "k_PointLightCookieTexID");
			RendererLighting.NativeMethodInfoPtr_GetRenderTextureFormat_Private_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663764);
			RendererLighting.NativeMethodInfoPtr_CreateNormalMapRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663765);
			RendererLighting.NativeMethodInfoPtr_GetBlendStyleRenderTextureDesc_Public_Static_RenderTextureDescriptor_IRenderPass2D_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663766);
			RendererLighting.NativeMethodInfoPtr_CreateCameraSortingLayerRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Downsampling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663767);
			RendererLighting.NativeMethodInfoPtr_EnableBlendStyle_Public_Static_Void_CommandBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663768);
			RendererLighting.NativeMethodInfoPtr_DisableAllKeywords_Public_Static_Void_IRenderPass2D_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663769);
			RendererLighting.NativeMethodInfoPtr_ReleaseRenderTextures_Public_Static_Void_IRenderPass2D_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663770);
			RendererLighting.NativeMethodInfoPtr_DrawPointLight_Public_Static_Void_CommandBuffer_Light2D_Mesh_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663771);
			RendererLighting.NativeMethodInfoPtr_CanCastShadows_Private_Static_Boolean_Light2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663772);
			RendererLighting.NativeMethodInfoPtr_CanCastVolumetricShadows_Private_Static_Boolean_Light2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663773);
			RendererLighting.NativeMethodInfoPtr_ShouldRenderLight_Private_Static_Boolean_Light2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663774);
			RendererLighting.NativeMethodInfoPtr_RenderLightSet_Private_Static_Void_IRenderPass2D_RenderingData_Int32_CommandBuffer_Int32_RenderTargetIdentifier_List_1_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663775);
			RendererLighting.NativeMethodInfoPtr_RenderLightVolumes_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_Int32_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferStoreAction_RenderBufferStoreAction_Boolean_List_1_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663776);
			RendererLighting.NativeMethodInfoPtr_SetShapeLightShaderGlobals_Public_Static_Void_IRenderPass2D_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663777);
			RendererLighting.NativeMethodInfoPtr_GetNormalizedInnerRadius_Private_Static_Single_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663778);
			RendererLighting.NativeMethodInfoPtr_GetNormalizedAngle_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663779);
			RendererLighting.NativeMethodInfoPtr_GetScaledLightInvMatrix_Private_Static_Void_Light2D_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663780);
			RendererLighting.NativeMethodInfoPtr_SetGeneralLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663781);
			RendererLighting.NativeMethodInfoPtr_SetPointLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663782);
			RendererLighting.NativeMethodInfoPtr_ClearDirtyLighting_Public_Static_Void_IRenderPass2D_CommandBuffer_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663783);
			RendererLighting.NativeMethodInfoPtr_RenderNormals_Internal_Static_Void_IRenderPass2D_ScriptableRenderContext_RenderingData_DrawingSettings_FilteringSettings_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663784);
			RendererLighting.NativeMethodInfoPtr_RenderLights_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_byref_LayerBatch_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663785);
			RendererLighting.NativeMethodInfoPtr_SetBlendModes_Private_Static_Void_Material_BlendMode_BlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663786);
			RendererLighting.NativeMethodInfoPtr_GetLightMaterialIndex_Private_Static_UInt32_Light2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663787);
			RendererLighting.NativeMethodInfoPtr_CreateLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663788);
			RendererLighting.NativeMethodInfoPtr_GetLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererLighting>.NativeClassPtr, 100663789);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000231C0 File Offset: 0x000213C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 601054, RefRangeEnd = 601057, XrefRangeStart = 601035, XrefRangeEnd = 601054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetRenderTextureFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetRenderTextureFormat_Private_Static_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000231F0 File Offset: 0x000213F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601083, RefRangeEnd = 601084, XrefRangeStart = 601057, XrefRangeEnd = 601083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateNormalMapRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_CreateNormalMapRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00023260 File Offset: 0x00021460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601084, XrefRangeEnd = 601096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(this IRenderPass2D pass, RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetBlendStyleRenderTextureDesc_Public_Static_RenderTextureDescriptor_IRenderPass2D_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000232B8 File Offset: 0x000214B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601096, XrefRangeEnd = 601107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateCameraSortingLayerRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downsamplingMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_CreateCameraSortingLayerRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Downsampling_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00023328 File Offset: 0x00021528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 601115, RefRangeEnd = 601118, XrefRangeStart = 601107, XrefRangeEnd = 601115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStyleIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_EnableBlendStyle_Public_Static_Void_CommandBuffer_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002337C File Offset: 0x0002157C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601118, XrefRangeEnd = 601124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableAllKeywords(this IRenderPass2D pass, CommandBuffer cmd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_DisableAllKeywords_Public_Static_Void_IRenderPass2D_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000233C4 File Offset: 0x000215C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601124, XrefRangeEnd = 601139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseRenderTextures(this IRenderPass2D pass, CommandBuffer cmd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_ReleaseRenderTextures_Public_Static_Void_IRenderPass2D_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002340C File Offset: 0x0002160C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601145, RefRangeEnd = 601147, XrefRangeStart = 601139, XrefRangeEnd = 601145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPointLight(CommandBuffer cmd, Light2D light, Mesh lightMesh, Material material)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightMesh);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_DrawPointLight_Public_Static_Void_CommandBuffer_Light2D_Mesh_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00023478 File Offset: 0x00021678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601148, RefRangeEnd = 601149, XrefRangeStart = 601147, XrefRangeEnd = 601148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCastShadows(Light2D light, int layerToRender)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_CanCastShadows_Private_Static_Boolean_Light2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000234C8 File Offset: 0x000216C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601149, XrefRangeEnd = 601150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanCastVolumetricShadows(Light2D light, int endLayerValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLayerValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_CanCastVolumetricShadows_Private_Static_Boolean_Light2D_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00023518 File Offset: 0x00021718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601155, RefRangeEnd = 601157, XrefRangeStart = 601150, XrefRangeEnd = 601155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldRenderLight(Light2D light, int blendStyleIndex, int layerToRender)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStyleIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_ShouldRenderLight_Private_Static_Boolean_Light2D_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00023578 File Offset: 0x00021778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601246, RefRangeEnd = 601247, XrefRangeStart = 601157, XrefRangeEnd = 601246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, List<Light2D> lights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStyleIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderTexture;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_RenderLightSet_Private_Static_Void_IRenderPass2D_RenderingData_Int32_CommandBuffer_Int32_RenderTargetIdentifier_List_1_Light2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00023614 File Offset: 0x00021814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601326, RefRangeEnd = 601327, XrefRangeStart = 601247, XrefRangeEnd = 601326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderLightVolumes(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, int endLayerValue, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endLayerValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderTexture;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTexture;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intermediateStoreAction;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finalStoreAction;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresRTInit;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_RenderLightVolumes_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_Int32_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferStoreAction_RenderBufferStoreAction_Boolean_List_1_Light2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000236EC File Offset: 0x000218EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601355, RefRangeEnd = 601356, XrefRangeStart = 601327, XrefRangeEnd = 601355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShapeLightShaderGlobals(this IRenderPass2D pass, CommandBuffer cmd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_SetShapeLightShaderGlobals_Public_Static_Void_IRenderPass2D_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00023734 File Offset: 0x00021934
		[CallerCount(0)]
		public unsafe static float GetNormalizedInnerRadius(Light2D light)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetNormalizedInnerRadius_Private_Static_Single_Light2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00023778 File Offset: 0x00021978
		[CallerCount(0)]
		public unsafe static float GetNormalizedAngle(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetNormalizedAngle_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000237B8 File Offset: 0x000219B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601356, XrefRangeEnd = 601363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &retMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetScaledLightInvMatrix_Private_Static_Void_Light2D_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000237FC File Offset: 0x000219FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601375, RefRangeEnd = 601377, XrefRangeStart = 601363, XrefRangeEnd = 601375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGeneralLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_SetGeneralLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00023858 File Offset: 0x00021A58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601444, RefRangeEnd = 601446, XrefRangeStart = 601377, XrefRangeEnd = 601444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPointLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_SetPointLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000238B4 File Offset: 0x00021AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601446, XrefRangeEnd = 601461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearDirtyLighting(this IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendStylesUsed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_ClearDirtyLighting_Public_Static_Void_IRenderPass2D_CommandBuffer_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0002390C File Offset: 0x00021B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601513, RefRangeEnd = 601514, XrefRangeStart = 601461, XrefRangeEnd = 601513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderNormals(this IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget, bool bFirstClear)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterSettings;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthTarget;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFirstClear;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_RenderNormals_Internal_Static_Void_IRenderPass2D_ScriptableRenderContext_RenderingData_DrawingSettings_FilteringSettings_RenderTargetIdentifier_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000239A0 File Offset: 0x00021BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601550, RefRangeEnd = 601551, XrefRangeStart = 601514, XrefRangeEnd = 601550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderLights(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerToRender;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &layerBatch;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rtDesc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_RenderLights_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_byref_LayerBatch_byref_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00023A2C File Offset: 0x00021C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601551, XrefRangeEnd = 601559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBlendModes(Material material, BlendMode src, BlendMode dst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_SetBlendModes_Private_Static_Void_Material_BlendMode_BlendMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00023A80 File Offset: 0x00021C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 601559, XrefRangeEnd = 601568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetLightMaterialIndex(Light2D light, bool isVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetLightMaterialIndex_Private_Static_UInt32_Light2D_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00023AD0 File Offset: 0x00021CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 601625, RefRangeEnd = 601626, XrefRangeStart = 601568, XrefRangeEnd = 601625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_CreateLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00023B34 File Offset: 0x00021D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 601648, RefRangeEnd = 601650, XrefRangeStart = 601626, XrefRangeEnd = 601648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetLightMaterial(this Renderer2DData rendererData, Light2D light, bool isVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(light);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererLighting.NativeMethodInfoPtr_GetLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000038F8 File Offset: 0x00001AF8
		public RendererLighting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00023B98 File Offset: 0x00021D98
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00003901 File Offset: 0x00001B01
		public unsafe static ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00023BC0 File Offset: 0x00021DC0
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00003913 File Offset: 0x00001B13
		public unsafe static ShaderTagId k_NormalsRenderingPassName
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_NormalsRenderingPassName, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_NormalsRenderingPassName, (void*)(&value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00023BDC File Offset: 0x00021DDC
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003921 File Offset: 0x00001B21
		public unsafe static Color k_NormalClearColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_NormalClearColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_NormalClearColor, (void*)(&value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00023BF8 File Offset: 0x00021DF8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000392F File Offset: 0x00001B2F
		public unsafe static string k_SpriteLightKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_SpriteLightKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_SpriteLightKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00023C18 File Offset: 0x00021E18
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003941 File Offset: 0x00001B41
		public unsafe static string k_UsePointLightCookiesKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_UsePointLightCookiesKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_UsePointLightCookiesKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00023C38 File Offset: 0x00021E38
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003953 File Offset: 0x00001B53
		public unsafe static string k_LightQualityFastKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightQualityFastKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightQualityFastKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00023C58 File Offset: 0x00021E58
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003965 File Offset: 0x00001B65
		public unsafe static string k_UseNormalMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_UseNormalMap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_UseNormalMap, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00023C78 File Offset: 0x00021E78
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003977 File Offset: 0x00001B77
		public unsafe static string k_UseAdditiveBlendingKeyword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_UseAdditiveBlendingKeyword, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_UseAdditiveBlendingKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00023C98 File Offset: 0x00021E98
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003989 File Offset: 0x00001B89
		public unsafe static Il2CppStringArray k_UseBlendStyleKeywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_UseBlendStyleKeywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_UseBlendStyleKeywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00023CC0 File Offset: 0x00021EC0
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000399B File Offset: 0x00001B9B
		public unsafe static Il2CppStructArray<int> k_BlendFactorsPropIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_BlendFactorsPropIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_BlendFactorsPropIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00023CE8 File Offset: 0x00021EE8
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x000039AD File Offset: 0x00001BAD
		public unsafe static Il2CppStructArray<int> k_MaskFilterPropIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_MaskFilterPropIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_MaskFilterPropIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00023D10 File Offset: 0x00021F10
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000039BF File Offset: 0x00001BBF
		public unsafe static Il2CppStructArray<int> k_InvertedFilterPropIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_InvertedFilterPropIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_InvertedFilterPropIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00023D38 File Offset: 0x00021F38
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000039D1 File Offset: 0x00001BD1
		public unsafe static GraphicsFormat s_RenderTextureFormatToUse
		{
			get
			{
				GraphicsFormat graphicsFormat;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_s_RenderTextureFormatToUse, (void*)(&graphicsFormat));
				return graphicsFormat;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_s_RenderTextureFormatToUse, (void*)(&value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00023D54 File Offset: 0x00021F54
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x000039DF File Offset: 0x00001BDF
		public unsafe static bool s_HasSetupRenderTextureFormatToUse
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_s_HasSetupRenderTextureFormatToUse, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_s_HasSetupRenderTextureFormatToUse, (void*)(&value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00023D70 File Offset: 0x00021F70
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000039ED File Offset: 0x00001BED
		public unsafe static int k_SrcBlendID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_SrcBlendID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_SrcBlendID, (void*)(&value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00023D8C File Offset: 0x00021F8C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000039FB File Offset: 0x00001BFB
		public unsafe static int k_DstBlendID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_DstBlendID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_DstBlendID, (void*)(&value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00023DA8 File Offset: 0x00021FA8
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003A09 File Offset: 0x00001C09
		public unsafe static int k_FalloffIntensityID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_FalloffIntensityID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_FalloffIntensityID, (void*)(&value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00023DC4 File Offset: 0x00021FC4
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003A17 File Offset: 0x00001C17
		public unsafe static int k_FalloffDistanceID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_FalloffDistanceID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_FalloffDistanceID, (void*)(&value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00023DE0 File Offset: 0x00021FE0
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003A25 File Offset: 0x00001C25
		public unsafe static int k_LightColorID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightColorID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightColorID, (void*)(&value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00023DFC File Offset: 0x00021FFC
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003A33 File Offset: 0x00001C33
		public unsafe static int k_VolumeOpacityID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_VolumeOpacityID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_VolumeOpacityID, (void*)(&value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00023E18 File Offset: 0x00022018
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003A41 File Offset: 0x00001C41
		public unsafe static int k_CookieTexID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_CookieTexID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_CookieTexID, (void*)(&value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00023E34 File Offset: 0x00022034
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003A4F File Offset: 0x00001C4F
		public unsafe static int k_FalloffLookupID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_FalloffLookupID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_FalloffLookupID, (void*)(&value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00023E50 File Offset: 0x00022050
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003A5D File Offset: 0x00001C5D
		public unsafe static int k_LightPositionID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightPositionID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightPositionID, (void*)(&value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00023E6C File Offset: 0x0002206C
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003A6B File Offset: 0x00001C6B
		public unsafe static int k_LightInvMatrixID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightInvMatrixID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightInvMatrixID, (void*)(&value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00023E88 File Offset: 0x00022088
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003A79 File Offset: 0x00001C79
		public unsafe static int k_InnerRadiusMultID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_InnerRadiusMultID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_InnerRadiusMultID, (void*)(&value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00023EA4 File Offset: 0x000220A4
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003A87 File Offset: 0x00001C87
		public unsafe static int k_OuterAngleID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_OuterAngleID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_OuterAngleID, (void*)(&value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00023EC0 File Offset: 0x000220C0
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003A95 File Offset: 0x00001C95
		public unsafe static int k_InnerAngleMultID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_InnerAngleMultID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_InnerAngleMultID, (void*)(&value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00023EDC File Offset: 0x000220DC
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public unsafe static int k_LightLookupID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightLookupID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightLookupID, (void*)(&value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00023EF8 File Offset: 0x000220F8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003AB1 File Offset: 0x00001CB1
		public unsafe static int k_IsFullSpotlightID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_IsFullSpotlightID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_IsFullSpotlightID, (void*)(&value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00023F14 File Offset: 0x00022114
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003ABF File Offset: 0x00001CBF
		public unsafe static int k_LightZDistanceID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_LightZDistanceID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_LightZDistanceID, (void*)(&value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00023F30 File Offset: 0x00022130
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003ACD File Offset: 0x00001CCD
		public unsafe static int k_PointLightCookieTexID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RendererLighting.NativeFieldInfoPtr_k_PointLightCookieTexID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererLighting.NativeFieldInfoPtr_k_PointLightCookieTexID, (void*)(&value));
			}
		}

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalsRenderingPassName;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_k_NormalClearColor;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_k_SpriteLightKeyword;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_k_UsePointLightCookiesKeyword;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_k_LightQualityFastKeyword;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_k_UseNormalMap;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_k_UseAdditiveBlendingKeyword;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_k_UseBlendStyleKeywords;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_k_BlendFactorsPropIDs;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_k_MaskFilterPropIDs;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_k_InvertedFilterPropIDs;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_s_RenderTextureFormatToUse;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_s_HasSetupRenderTextureFormatToUse;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_k_SrcBlendID;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_k_DstBlendID;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_k_FalloffIntensityID;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_k_FalloffDistanceID;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_k_LightColorID;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_k_VolumeOpacityID;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_k_CookieTexID;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_k_FalloffLookupID;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_k_LightPositionID;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_k_LightInvMatrixID;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_k_InnerRadiusMultID;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_k_OuterAngleID;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_k_InnerAngleMultID;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_k_LightLookupID;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_k_IsFullSpotlightID;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_k_LightZDistanceID;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_k_PointLightCookieTexID;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Private_Static_GraphicsFormat_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_CreateNormalMapRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Single_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GetBlendStyleRenderTextureDesc_Public_Static_RenderTextureDescriptor_IRenderPass2D_RenderingData_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_CreateCameraSortingLayerRenderTexture_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Downsampling_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_EnableBlendStyle_Public_Static_Void_CommandBuffer_Int32_Boolean_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_DisableAllKeywords_Public_Static_Void_IRenderPass2D_CommandBuffer_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRenderTextures_Public_Static_Void_IRenderPass2D_CommandBuffer_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_DrawPointLight_Public_Static_Void_CommandBuffer_Light2D_Mesh_Material_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_CanCastShadows_Private_Static_Boolean_Light2D_Int32_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_CanCastVolumetricShadows_Private_Static_Boolean_Light2D_Int32_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRenderLight_Private_Static_Boolean_Light2D_Int32_Int32_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_RenderLightSet_Private_Static_Void_IRenderPass2D_RenderingData_Int32_CommandBuffer_Int32_RenderTargetIdentifier_List_1_Light2D_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_RenderLightVolumes_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_Int32_RenderTargetIdentifier_RenderTargetIdentifier_RenderBufferStoreAction_RenderBufferStoreAction_Boolean_List_1_Light2D_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_SetShapeLightShaderGlobals_Public_Static_Void_IRenderPass2D_CommandBuffer_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedInnerRadius_Private_Static_Single_Light2D_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedAngle_Private_Static_Single_Single_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledLightInvMatrix_Private_Static_Void_Light2D_byref_Matrix4x4_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_SetGeneralLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_SetPointLightShaderGlobals_Private_Static_Void_IRenderPass2D_CommandBuffer_Light2D_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_ClearDirtyLighting_Public_Static_Void_IRenderPass2D_CommandBuffer_UInt32_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_RenderNormals_Internal_Static_Void_IRenderPass2D_ScriptableRenderContext_RenderingData_DrawingSettings_FilteringSettings_RenderTargetIdentifier_Boolean_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_RenderLights_Public_Static_Void_IRenderPass2D_RenderingData_CommandBuffer_Int32_byref_LayerBatch_byref_RenderTextureDescriptor_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_SetBlendModes_Private_Static_Void_Material_BlendMode_BlendMode_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_GetLightMaterialIndex_Private_Static_UInt32_Light2D_Boolean_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_CreateLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_GetLightMaterial_Private_Static_Material_Renderer2DData_Light2D_Boolean_0;
	}
}
