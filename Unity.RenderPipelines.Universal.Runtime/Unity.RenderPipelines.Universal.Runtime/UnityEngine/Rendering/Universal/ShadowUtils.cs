using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000D6 RID: 214
	public static class ShadowUtils : Object
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x0004E890 File Offset: 0x0004CA90
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowUtils()
		{
			Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShadowUtils");
			ShadowUtils.NativeFieldInfoPtr_m_ForceShadowPointSampling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "m_ForceShadowPointSampling");
			ShadowUtils.NativeFieldInfoPtr__ShadowBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "_ShadowBias");
			ShadowUtils.NativeFieldInfoPtr__LightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "_LightDirection");
			ShadowUtils.NativeFieldInfoPtr__LightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "_LightPosition");
			ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "kMinimumPunctualLightHardShadowResolution");
			ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, "kMinimumPunctualLightSoftShadowResolution");
			ShadowUtils.NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665393);
			ShadowUtils.NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665394);
			ShadowUtils.NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665395);
			ShadowUtils.NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665396);
			ShadowUtils.NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665397);
			ShadowUtils.NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665398);
			ShadowUtils.NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665399);
			ShadowUtils.NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665400);
			ShadowUtils.NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665401);
			ShadowUtils.NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665402);
			ShadowUtils.NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665403);
			ShadowUtils.NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_CommandBuffer_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665404);
			ShadowUtils.NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_CommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665405);
			ShadowUtils.NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_CommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665406);
			ShadowUtils.NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_CommandBuffer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665407);
			ShadowUtils.NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_CommandBuffer_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665408);
			ShadowUtils.NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665409);
			ShadowUtils.NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665410);
			ShadowUtils.NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665411);
			ShadowUtils.NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665412);
			ShadowUtils.NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665413);
			ShadowUtils.NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665414);
			ShadowUtils.NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665415);
			ShadowUtils.NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665416);
			ShadowUtils.NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665417);
			ShadowUtils.NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_CommandBuffer_byref_ShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665418);
			ShadowUtils.NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_byref_LightData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665419);
			ShadowUtils.NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665420);
			ShadowUtils.NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowUtils>.NativeClassPtr, 100665421);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0004EB74 File Offset: 0x0004CD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617193, XrefRangeEnd = 617197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowLightIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cascadeIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowmapWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowmapHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlane;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cascadeSplitDistance;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSliceData;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0004EC58 File Offset: 0x0004CE58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617212, RefRangeEnd = 617214, XrefRangeStart = 617197, XrefRangeEnd = 617212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractDirectionalLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, out Vector4 cascadeSplitDistance, out ShadowSliceData shadowSliceData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowLightIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cascadeIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowmapWidth;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowmapHeight;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlane;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cascadeSplitDistance;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSliceData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0004ED1C File Offset: 0x0004CF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617219, RefRangeEnd = 617220, XrefRangeStart = 617214, XrefRangeEnd = 617219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractSpotLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowLightIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &splitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617225, RefRangeEnd = 617226, XrefRangeStart = 617220, XrefRangeEnd = 617225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractPointLightMatrix(ref CullingResults cullResults, ref ShadowData shadowData, int shadowLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 shadowMatrix, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData splitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &cullResults;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowLightIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fovBias;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &splitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0004EE70 File Offset: 0x0004D070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617240, RefRangeEnd = 617241, XrefRangeStart = 617226, XrefRangeEnd = 617240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings, Matrix4x4 proj, Matrix4x4 view)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSliceData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &settings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref proj;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0004EEEC File Offset: 0x0004D0EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617258, RefRangeEnd = 617259, XrefRangeStart = 617241, XrefRangeEnd = 617258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderShadowSlice(CommandBuffer cmd, ref ScriptableRenderContext context, ref ShadowSliceData shadowSliceData, ref ShadowDrawingSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSliceData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0004EF4C File Offset: 0x0004D14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617259, RefRangeEnd = 617260, XrefRangeStart = 617259, XrefRangeEnd = 617259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref atlasWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0004EFA8 File Offset: 0x0004D1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617260, XrefRangeEnd = 617263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplySliceTransform(ref ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &shadowSliceData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617312, RefRangeEnd = 617314, XrefRangeStart = 617263, XrefRangeEnd = 617312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetShadowBias(ref VisibleLight shadowLight, int shadowLightIndex, ref ShadowData shadowData, Matrix4x4 lightProjectionMatrix, float shadowResolution)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &shadowLight;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightProjectionMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0004F074 File Offset: 0x0004D274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617314, RefRangeEnd = 617316, XrefRangeStart = 617314, XrefRangeEnd = 617314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, out float scale, out float bias)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fadeDistance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0004F0D0 File Offset: 0x0004D2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617338, RefRangeEnd = 617340, XrefRangeStart = 617316, XrefRangeEnd = 617338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupShadowCasterConstantBuffer(CommandBuffer cmd, ref VisibleLight shadowLight, Vector4 shadowBias)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowLight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0004F124 File Offset: 0x0004D324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617340, XrefRangeEnd = 617345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShadowBias(CommandBuffer cmd, Vector4 shadowBias)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowBias;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_CommandBuffer_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0004F168 File Offset: 0x0004D368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617345, XrefRangeEnd = 617350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightDirection(CommandBuffer cmd, Vector3 lightDirection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_CommandBuffer_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0004F1AC File Offset: 0x0004D3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617350, XrefRangeEnd = 617355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightPosition(CommandBuffer cmd, Vector3 lightPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_CommandBuffer_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0004F1F0 File Offset: 0x0004D3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617360, RefRangeEnd = 617361, XrefRangeStart = 617355, XrefRangeEnd = 617360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCameraPosition(CommandBuffer cmd, Vector3 worldSpaceCameraPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpaceCameraPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_CommandBuffer_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0004F234 File Offset: 0x0004D434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 617371, RefRangeEnd = 617373, XrefRangeStart = 617361, XrefRangeEnd = 617371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorldToCameraAndCameraToWorldMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_CommandBuffer_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0004F278 File Offset: 0x0004D478
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 617396, RefRangeEnd = 617401, XrefRangeStart = 617373, XrefRangeEnd = 617396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0004F2D4 File Offset: 0x0004D4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617401, XrefRangeEnd = 617409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTexture GetTemporaryShadowTexture(int width, int height, int bits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0004F330 File Offset: 0x0004D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617409, XrefRangeEnd = 617433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShadowRTNeedsReAlloc(RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0004F3CC File Offset: 0x0004D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617433, XrefRangeEnd = 617442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0004F458 File Offset: 0x0004D658
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 617470, RefRangeEnd = 617474, XrefRangeStart = 617442, XrefRangeEnd = 617470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShadowRTReAllocateIfNeeded(ref RTHandle handle, int width, int height, int bits, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			handle = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0004F50C File Offset: 0x0004D70C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617479, RefRangeEnd = 617482, XrefRangeStart = 617474, XrefRangeEnd = 617479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0004F558 File Offset: 0x0004D758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617501, RefRangeEnd = 617504, XrefRangeStart = 617482, XrefRangeEnd = 617501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SoftShadowQualityToShaderProperty(Light light, bool softShadowsEnabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softShadowsEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0004F5A8 File Offset: 0x0004D7A8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsPerLightSoftShadowQuality()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0004F5D8 File Offset: 0x0004D7D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617513, RefRangeEnd = 617516, XrefRangeStart = 617504, XrefRangeEnd = 617513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPerLightSoftShadowKeyword(CommandBuffer cmd, bool hasSoftShadows)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasSoftShadows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_CommandBuffer_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0004F61C File Offset: 0x0004D81C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 617537, RefRangeEnd = 617540, XrefRangeStart = 617516, XrefRangeEnd = 617537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSoftShadowQualityShaderKeywords(CommandBuffer cmd, ref ShadowData shadowData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(shadowData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_CommandBuffer_byref_ShadowData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0004F668 File Offset: 0x0004D868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617540, XrefRangeEnd = 617553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_byref_LightData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0004F6B8 File Offset: 0x0004D8B8
		[CallerCount(0)]
		public unsafe static int GetPunctualLightShadowSlicesCount([In] ref LightType lightType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lightType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0004F6F8 File Offset: 0x0004D8F8
		[CallerCount(0)]
		public unsafe static int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref softShadow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowUtils.NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00009EC6 File Offset: 0x000080C6
		public ShadowUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0004F738 File Offset: 0x0004D938
		// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00009ECF File Offset: 0x000080CF
		public unsafe static bool m_ForceShadowPointSampling
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr_m_ForceShadowPointSampling, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr_m_ForceShadowPointSampling, (void*)(&value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0004F754 File Offset: 0x0004D954
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00009EDD File Offset: 0x000080DD
		public unsafe static int _ShadowBias
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr__ShadowBias, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr__ShadowBias, (void*)(&value));
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x0004F770 File Offset: 0x0004D970
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00009EEB File Offset: 0x000080EB
		public unsafe static int _LightDirection
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr__LightDirection, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr__LightDirection, (void*)(&value));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x0004F78C File Offset: 0x0004D98C
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00009EF9 File Offset: 0x000080F9
		public unsafe static int _LightPosition
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr__LightPosition, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr__LightPosition, (void*)(&value));
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0004F7A8 File Offset: 0x0004D9A8
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00009F07 File Offset: 0x00008107
		public unsafe static int kMinimumPunctualLightHardShadowResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&value));
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0004F7C4 File Offset: 0x0004D9C4
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00009F15 File Offset: 0x00008115
		public unsafe static int kMinimumPunctualLightSoftShadowResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowUtils.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&value));
			}
		}

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceShadowPointSampling;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr__ShadowBias;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr__LightDirection;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr__LightPosition;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_ExtractDirectionalLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_Int32_Int32_Int32_Int32_Single_byref_Vector4_byref_ShadowSliceData_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_ExtractSpotLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_ExtractPointLightMatrix_Public_Static_Boolean_byref_CullingResults_byref_ShadowData_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_RenderShadowSlice_Public_Static_Void_CommandBuffer_byref_ScriptableRenderContext_byref_ShadowSliceData_byref_ShadowDrawingSettings_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTileResolutionInAtlas_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_ApplySliceTransform_Public_Static_Void_byref_ShadowSliceData_Int32_Int32_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowBias_Public_Static_Vector4_byref_VisibleLight_Int32_byref_ShadowData_Matrix4x4_Single_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_GetScaleAndBiasForLinearDistanceFade_Internal_Static_Void_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_SetupShadowCasterConstantBuffer_Public_Static_Void_CommandBuffer_byref_VisibleLight_Vector4_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_SetShadowBias_Internal_Static_Void_CommandBuffer_Vector4_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_SetLightDirection_Internal_Static_Void_CommandBuffer_Vector3_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_SetLightPosition_Internal_Static_Void_CommandBuffer_Vector3_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraPosition_Internal_Static_Void_CommandBuffer_Vector3_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldToCameraAndCameraToWorldMatrices_Internal_Static_Void_CommandBuffer_Matrix4x4_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryShadowTextureDescriptor_Private_Static_RenderTextureDescriptor_Int32_Int32_Int32_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_GetTemporaryShadowTexture_Public_Static_RenderTexture_Int32_Int32_Int32_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_ShadowRTNeedsReAlloc_Public_Static_Boolean_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_AllocShadowRT_Public_Static_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_ShadowRTReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Int32_Int32_Int32_Int32_Single_String_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowTransform_Private_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_SoftShadowQualityToShaderProperty_Internal_Static_Single_Light_Boolean_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_SupportsPerLightSoftShadowQuality_Internal_Static_Boolean_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_SetPerLightSoftShadowKeyword_Internal_Static_Void_CommandBuffer_Boolean_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_SetSoftShadowQualityShaderKeywords_Internal_Static_Void_CommandBuffer_byref_ShadowData_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_IsValidShadowCastingLight_Internal_Static_Boolean_byref_LightData_Int32_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Internal_Static_Int32_byref_LightType_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Internal_Static_Int32_Boolean_0;
	}
}
