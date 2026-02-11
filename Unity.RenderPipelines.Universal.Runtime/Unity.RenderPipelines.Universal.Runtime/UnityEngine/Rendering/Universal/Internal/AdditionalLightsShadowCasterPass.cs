using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal
{
	// Token: 0x02000119 RID: 281
	public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
	{
		// Token: 0x060017DD RID: 6109 RVA: 0x000658F4 File Offset: 0x00063AF4
		// Note: this type is marked as 'beforefieldinit'.
		static AdditionalLightsShadowCasterPass()
		{
			Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "AdditionalLightsShadowCasterPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr);
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsBufferId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalShadowsBufferId");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsIndicesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalShadowsIndicesId");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_c_DefaultShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "c_DefaultShadowParams");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsWorldToShadow_SSBO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsWorldToShadow_SSBO");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowParams_SSBO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalShadowParams_SSBO");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_UseStructuredBuffer");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_ShadowmapBufferBits");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsShadowmapID");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsShadowmapHandle");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_CreateEmptyShadowmap");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_EmptyAdditionalLightShadowmapTexture");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_EmptyShadowMapDimensions");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_AdditionalLightShadowMapTextureName");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_EmptyAdditionalLightShadowMapTextureName");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "s_EmptyAdditionalLightIndexToShadowParams");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_MaxShadowDistanceSq");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_CascadeBorder");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsShadowSlices");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_VisibleLightIndexToAdditionalLightIndex");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightIndexToVisibleLightIndex");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ShadowSliceToAdditionalLightIndex");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_GlobalShadowSliceIndexToPerLightShadowSliceIndex");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightIndexToShadowParams");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowResolutionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ShadowResolutionRequests");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToCameraSquareDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_VisibleLightIndexToCameraSquareDistance");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_SortedShadowResolutionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_SortedShadowResolutionRequests");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UnusedAtlasSquareAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_UnusedAtlasSquareAreas");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "renderTargetWidth");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "renderTargetHeight");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ProfilingSetupSampler");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Spot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "LightTypeIdentifierInShadowParams_Spot");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "LightTypeIdentifierInShadowParams_Point");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "kMinimumPunctualLightHardShadowResolution");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "kMinimumPunctualLightSoftShadowResolution");
			AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowRequestsHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ShadowRequestsHashes");
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666113);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666114);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Private_Int32_byref_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666115);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666116);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666117);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666118);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_InsertionSort_Internal_Void_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666119);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Int32_byref_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666120);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_AtlasLayout_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666121);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666122);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666123);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666124);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666125);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666126);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666127);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666128);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666129);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetEmptyAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666130);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetEmptyAdditionalLightShadowParams_Internal_Static_Void_CommandBuffer_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666131);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666132);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666133);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_IsValidShadowCastingLight_Private_Boolean_byref_LightData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666134);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666135);
			AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666136);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00065DE8 File Offset: 0x00063FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625444, RefRangeEnd = 625445, XrefRangeStart = 625293, XrefRangeEnd = 625444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditionalLightsShadowCasterPass(RenderPassEvent evt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00065E30 File Offset: 0x00064030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 600839, RefRangeEnd = 600840, XrefRangeStart = 600839, XrefRangeEnd = 600840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00065E64 File Offset: 0x00064064
		[CallerCount(0)]
		public unsafe int GetPunctualLightShadowSlicesCount([In] ref LightType lightType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lightType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Private_Int32_byref_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00065EB0 File Offset: 0x000640B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625445, XrefRangeEnd = 625447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frustumAngleInDegrees;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guardBandSizeInTexels;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliceResolutionInTexels;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00065F0C File Offset: 0x0006410C
		[CallerCount(0)]
		public unsafe int MinimalPunctualLightShadowResolution(bool softShadow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref softShadow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00065F58 File Offset: 0x00064158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 625453, RefRangeEnd = 625455, XrefRangeStart = 625447, XrefRangeEnd = 625453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shadowSliceResolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowFiltering;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00065FA4 File Offset: 0x000641A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625455, RefRangeEnd = 625456, XrefRangeStart = 625455, XrefRangeEnd = 625455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertionSort(Il2CppStructArray<AdditionalLightsShadowCasterPass.ShadowResolutionRequest> array, int startIndex, int lastIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_InsertionSort_Internal_Void_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00066004 File Offset: 0x00064204
		[CallerCount(0)]
		public unsafe int EstimateScaleFactorNeededToFitAllShadowsInAtlas([In] ref Il2CppStructArray<AdditionalLightsShadowCasterPass.ShadowResolutionRequest> shadowResolutionRequests, int endIndex, int atlasWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(shadowResolutionRequests);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasWidth;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Int32_byref_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			shadowResolutionRequests = ((intPtr4 == 0) ? null : new Il2CppStructArray<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00066084 File Offset: 0x00064284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625474, RefRangeEnd = 625475, XrefRangeStart = 625456, XrefRangeEnd = 625474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref atlasSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalShadowSlicesCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref estimatedScaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_AtlasLayout_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000660E0 File Offset: 0x000642E0
		[CallerCount(0)]
		public unsafe ulong ResolutionLog2ForHash(int resolution)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resolution;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0006612C File Offset: 0x0006432C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625475, XrefRangeEnd = 625499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ComputeShadowRequestHash(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0006617C File Offset: 0x0006437C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 625668, RefRangeEnd = 625671, XrefRangeStart = 625499, XrefRangeEnd = 625668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Setup(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000661CC File Offset: 0x000643CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 625682, RefRangeEnd = 625684, XrefRangeStart = 625671, XrefRangeEnd = 625682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetupForEmptyRendering(ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0006621C File Offset: 0x0006441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625684, XrefRangeEnd = 625686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraTextureDescriptor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00066278 File Offset: 0x00064478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625686, XrefRangeEnd = 625688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000662D4 File Offset: 0x000644D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 625688, RefRangeEnd = 625691, XrefRangeStart = 625688, XrefRangeEnd = 625688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibleLightIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00066320 File Offset: 0x00064520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625691, XrefRangeEnd = 625692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00066354 File Offset: 0x00064554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625723, RefRangeEnd = 625724, XrefRangeStart = 625692, XrefRangeEnd = 625723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmptyAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetEmptyAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000663A8 File Offset: 0x000645A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625740, RefRangeEnd = 625741, XrefRangeStart = 625724, XrefRangeEnd = 625740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEmptyAdditionalLightShadowParams(CommandBuffer cmd, Il2CppStructArray<Vector4> lightIndexToShadowParams)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lightIndexToShadowParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetEmptyAdditionalLightShadowParams_Internal_Static_Void_CommandBuffer_Il2CppStructArray_1_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000663F0 File Offset: 0x000645F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 625800, RefRangeEnd = 625802, XrefRangeStart = 625741, XrefRangeEnd = 625800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderAdditionalShadowmapAtlas(ref ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00066444 File Offset: 0x00064644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 625835, RefRangeEnd = 625836, XrefRangeStart = 625802, XrefRangeEnd = 625835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupAdditionalLightsShadowReceiverConstants(CommandBuffer cmd, bool softShadows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref softShadows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00066494 File Offset: 0x00064694
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 625848, RefRangeEnd = 625852, XrefRangeStart = 625836, XrefRangeEnd = 625848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidShadowCastingLight(ref LightData lightData, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(lightData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_IsValidShadowCastingLight_Private_Boolean_byref_LightData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000664F0 File Offset: 0x000646F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 625925, RefRangeEnd = 625927, XrefRangeStart = 625852, XrefRangeEnd = 625925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureHandle Render(RenderGraph graph, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00066550 File Offset: 0x00064750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625927, XrefRangeEnd = 625931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPassData(ref AdditionalLightsShadowCasterPass.PassData passData, ref RenderingData renderingData, ref RenderGraph graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(passData);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			passData = ((intPtr5 == 0) ? null : new AdditionalLightsShadowCasterPass.PassData(intPtr5));
			IntPtr intPtr6 = intPtr2;
			graph = ((intPtr6 == 0) ? null : new RenderGraph(intPtr6));
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0000D94E File Offset: 0x0000BB4E
		public AdditionalLightsShadowCasterPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000665E4 File Offset: 0x000647E4
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000D957 File Offset: 0x0000BB57
		public unsafe static int m_AdditionalShadowsBufferId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsBufferId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsBufferId, (void*)(&value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x00066600 File Offset: 0x00064800
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0000D965 File Offset: 0x0000BB65
		public unsafe static int m_AdditionalShadowsIndicesId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsIndicesId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowsIndicesId, (void*)(&value));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x0006661C File Offset: 0x0006481C
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000D973 File Offset: 0x0000BB73
		public unsafe static Vector4 c_DefaultShadowParams
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_c_DefaultShadowParams, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_c_DefaultShadowParams, (void*)(&value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00066638 File Offset: 0x00064838
		// (set) Token: 0x060017FE RID: 6142 RVA: 0x0000D981 File Offset: 0x0000BB81
		public unsafe static int m_AdditionalLightsWorldToShadow_SSBO
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsWorldToShadow_SSBO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsWorldToShadow_SSBO, (void*)(&value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00066654 File Offset: 0x00064854
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x0000D98F File Offset: 0x0000BB8F
		public unsafe static int m_AdditionalShadowParams_SSBO
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowParams_SSBO, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalShadowParams_SSBO, (void*)(&value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00066670 File Offset: 0x00064870
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000D99D File Offset: 0x0000BB9D
		public unsafe bool m_UseStructuredBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UseStructuredBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UseStructuredBuffer)) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00066698 File Offset: 0x00064898
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		public unsafe static int k_ShadowmapBufferBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&value));
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000666B4 File Offset: 0x000648B4
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x0000D9C6 File Offset: 0x0000BBC6
		public unsafe int m_AdditionalLightsShadowmapID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapID)) = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x000666DC File Offset: 0x000648DC
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x0000D9E1 File Offset: 0x0000BBE1
		public unsafe RTHandle m_AdditionalLightsShadowmapHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0006670C File Offset: 0x0006490C
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x0000DA00 File Offset: 0x0000BC00
		public unsafe bool m_CreateEmptyShadowmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CreateEmptyShadowmap)) = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00066734 File Offset: 0x00064934
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x0000DA1B File Offset: 0x0000BC1B
		public unsafe RTHandle m_EmptyAdditionalLightShadowmapTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00066764 File Offset: 0x00064964
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x0000DA3A File Offset: 0x0000BC3A
		public unsafe static int k_EmptyShadowMapDimensions
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&value));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00066780 File Offset: 0x00064980
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x0000DA48 File Offset: 0x0000BC48
		public unsafe static string k_AdditionalLightShadowMapTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000667A0 File Offset: 0x000649A0
		// (set) Token: 0x06001812 RID: 6162 RVA: 0x0000DA5A File Offset: 0x0000BC5A
		public unsafe static string k_EmptyAdditionalLightShadowMapTextureName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x000667C0 File Offset: 0x000649C0
		// (set) Token: 0x06001814 RID: 6164 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		public unsafe static Il2CppStructArray<Vector4> s_EmptyAdditionalLightIndexToShadowParams
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000667E8 File Offset: 0x000649E8
		// (set) Token: 0x06001816 RID: 6166 RVA: 0x0000DA7E File Offset: 0x0000BC7E
		public unsafe float m_MaxShadowDistanceSq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_MaxShadowDistanceSq)) = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00066810 File Offset: 0x00064A10
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x0000DA99 File Offset: 0x0000BC99
		public unsafe float m_CascadeBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_CascadeBorder)) = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00066838 File Offset: 0x00064A38
		// (set) Token: 0x0600181A RID: 6170 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		public unsafe Il2CppStructArray<ShadowSliceData> m_AdditionalLightsShadowSlices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowSlices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShadowSliceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightsShadowSlices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00066868 File Offset: 0x00064A68
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x0000DAD3 File Offset: 0x0000BCD3
		public unsafe Il2CppStructArray<int> m_VisibleLightIndexToAdditionalLightIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00066898 File Offset: 0x00064A98
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x0000DAF2 File Offset: 0x0000BCF2
		public unsafe Il2CppStructArray<int> m_AdditionalLightIndexToVisibleLightIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000668C8 File Offset: 0x00064AC8
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0000DB11 File Offset: 0x0000BD11
		public unsafe List<int> m_ShadowSliceToAdditionalLightIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000668F8 File Offset: 0x00064AF8
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public unsafe List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00066928 File Offset: 0x00064B28
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x0000DB4F File Offset: 0x0000BD4F
		public unsafe Il2CppStructArray<Vector4> m_AdditionalLightIndexToShadowParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00066958 File Offset: 0x00064B58
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0000DB6E File Offset: 0x0000BD6E
		public unsafe Il2CppStructArray<Matrix4x4> m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x00066988 File Offset: 0x00064B88
		// (set) Token: 0x06001828 RID: 6184 RVA: 0x0000DB8D File Offset: 0x0000BD8D
		public unsafe List<AdditionalLightsShadowCasterPass.ShadowResolutionRequest> m_ShadowResolutionRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowResolutionRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowResolutionRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x000669B8 File Offset: 0x00064BB8
		// (set) Token: 0x0600182A RID: 6186 RVA: 0x0000DBAC File Offset: 0x0000BDAC
		public unsafe Il2CppStructArray<float> m_VisibleLightIndexToCameraSquareDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToCameraSquareDistance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToCameraSquareDistance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x000669E8 File Offset: 0x00064BE8
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x0000DBCB File Offset: 0x0000BDCB
		public unsafe Il2CppStructArray<AdditionalLightsShadowCasterPass.ShadowResolutionRequest> m_SortedShadowResolutionRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_SortedShadowResolutionRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_SortedShadowResolutionRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00066A18 File Offset: 0x00064C18
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000DBEA File Offset: 0x0000BDEA
		public unsafe Il2CppStructArray<int> m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00066A48 File Offset: 0x00064C48
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x0000DC09 File Offset: 0x0000BE09
		public unsafe List<RectInt> m_UnusedAtlasSquareAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UnusedAtlasSquareAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectInt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_UnusedAtlasSquareAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00066A78 File Offset: 0x00064C78
		// (set) Token: 0x06001832 RID: 6194 RVA: 0x0000DC28 File Offset: 0x0000BE28
		public unsafe int renderTargetWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetWidth)) = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00066AA0 File Offset: 0x00064CA0
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x0000DC43 File Offset: 0x0000BE43
		public unsafe int renderTargetHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_renderTargetHeight)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00066AC8 File Offset: 0x00064CC8
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000DC5E File Offset: 0x0000BE5E
		public unsafe ProfilingSampler m_ProfilingSetupSampler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ProfilingSetupSampler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x00066AF8 File Offset: 0x00064CF8
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000DC7D File Offset: 0x0000BE7D
		public unsafe static float LightTypeIdentifierInShadowParams_Spot
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Spot, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Spot, (void*)(&value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00066B14 File Offset: 0x00064D14
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000DC8B File Offset: 0x0000BE8B
		public unsafe static float LightTypeIdentifierInShadowParams_Point
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Point, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Point, (void*)(&value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00066B30 File Offset: 0x00064D30
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000DC99 File Offset: 0x0000BE99
		public unsafe static int kMinimumPunctualLightHardShadowResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution, (void*)(&value));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00066B4C File Offset: 0x00064D4C
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000DCA7 File Offset: 0x0000BEA7
		public unsafe static int kMinimumPunctualLightSoftShadowResolution
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution, (void*)(&value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00066B68 File Offset: 0x00064D68
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x0000DCB5 File Offset: 0x0000BEB5
		public unsafe Dictionary<int, ulong> m_ShadowRequestsHashes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowRequestsHashes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.NativeFieldInfoPtr_m_ShadowRequestsHashes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalShadowsBufferId;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalShadowsIndicesId;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeFieldInfoPtr_c_DefaultShadowParams;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsWorldToShadow_SSBO;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalShadowParams_SSBO;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeFieldInfoPtr_k_ShadowmapBufferBits;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowmapID;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateEmptyShadowmap;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyShadowMapDimensions;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxShadowDistanceSq;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr_m_CascadeBorder;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowSlices;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowResolutionRequests;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToCameraSquareDistance;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr_m_SortedShadowResolutionRequests;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeFieldInfoPtr_m_UnusedAtlasSquareAreas;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetWidth;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeFieldInfoPtr_renderTargetHeight;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSetupSampler;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Spot;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr_LightTypeIdentifierInShadowParams_Point;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr_kMinimumPunctualLightHardShadowResolution;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_kMinimumPunctualLightSoftShadowResolution;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowRequestsHashes;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_GetPunctualLightShadowSlicesCount_Private_Int32_byref_LightType_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_MinimalPunctualLightShadowResolution_Private_Int32_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Internal_Void_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_EstimateScaleFactorNeededToFitAllShadowsInAtlas_Private_Int32_byref_Il2CppStructArray_1_ShadowResolutionRequest_Int32_Int32_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_AtlasLayout_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_byref_RenderingData_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_byref_RenderingData_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_SetEmptyAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_SetEmptyAdditionalLightShadowParams_Internal_Static_Void_CommandBuffer_Il2CppStructArray_1_Vector4_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_byref_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_CommandBuffer_Boolean_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_IsValidShadowCastingLight_Private_Boolean_byref_LightData_Int32_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_byref_RenderingData_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_byref_RenderingData_byref_RenderGraph_0;

		// Token: 0x020001E6 RID: 486
		public static class AdditionalShadowsConstantBuffer : Object
		{
			// Token: 0x060021E9 RID: 8681 RVA: 0x000825C4 File Offset: 0x000807C4
			// Note: this type is marked as 'beforefieldinit'.
			static AdditionalShadowsConstantBuffer()
			{
				Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "AdditionalShadowsConstantBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr);
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalLightsWorldToShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalLightsWorldToShadow");
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowParams");
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowOffset0");
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowOffset1");
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowFadeParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowFadeParams");
				AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowmapSize");
			}

			// Token: 0x060021EA RID: 8682 RVA: 0x00013659 File Offset: 0x00011859
			public AdditionalShadowsConstantBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3B RID: 3131
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x00082668 File Offset: 0x00080868
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x00013662 File Offset: 0x00011862
			public unsafe static int _AdditionalLightsWorldToShadow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalLightsWorldToShadow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalLightsWorldToShadow, (void*)(&value));
				}
			}

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x060021ED RID: 8685 RVA: 0x00082684 File Offset: 0x00080884
			// (set) Token: 0x060021EE RID: 8686 RVA: 0x00013670 File Offset: 0x00011870
			public unsafe static int _AdditionalShadowParams
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowParams, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowParams, (void*)(&value));
				}
			}

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x060021EF RID: 8687 RVA: 0x000826A0 File Offset: 0x000808A0
			// (set) Token: 0x060021F0 RID: 8688 RVA: 0x0001367E File Offset: 0x0001187E
			public unsafe static int _AdditionalShadowOffset0
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset0, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset0, (void*)(&value));
				}
			}

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x000826BC File Offset: 0x000808BC
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0001368C File Offset: 0x0001188C
			public unsafe static int _AdditionalShadowOffset1
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset1, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowOffset1, (void*)(&value));
				}
			}

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x000826D8 File Offset: 0x000808D8
			// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0001369A File Offset: 0x0001189A
			public unsafe static int _AdditionalShadowFadeParams
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowFadeParams, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowFadeParams, (void*)(&value));
				}
			}

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x000826F4 File Offset: 0x000808F4
			// (set) Token: 0x060021F6 RID: 8694 RVA: 0x000136A8 File Offset: 0x000118A8
			public unsafe static int _AdditionalShadowmapSize
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowmapSize, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.AdditionalShadowsConstantBuffer.NativeFieldInfoPtr__AdditionalShadowmapSize, (void*)(&value));
				}
			}

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalLightsWorldToShadow;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalShadowParams;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalShadowOffset0;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalShadowOffset1;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalShadowFadeParams;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeFieldInfoPtr__AdditionalShadowmapSize;
		}

		// Token: 0x020001E7 RID: 487
		[StructLayout(2)]
		public struct ShadowResolutionRequest
		{
			// Token: 0x060021F7 RID: 8695 RVA: 0x00082710 File Offset: 0x00080910
			// Note: this type is marked as 'beforefieldinit'.
			static ShadowResolutionRequest()
			{
				Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "ShadowResolutionRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr);
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_visibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "visibleLightIndex");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_perLightShadowSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "perLightShadowSliceIndex");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_requestedResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "requestedResolution");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_softShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "softShadow");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_pointLightShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "pointLightShadow");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "offsetX");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_offsetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "offsetY");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeFieldInfoPtr_allocatedResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, "allocatedResolution");
				AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, 100666138);
			}

			// Token: 0x060021F8 RID: 8696 RVA: 0x000827F0 File Offset: 0x000809F0
			[CallerCount(0)]
			public unsafe ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _visibleLightIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _perLightShadowSliceIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _requestedResolution;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _softShadow;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointLightShadow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.ShadowResolutionRequest.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021F9 RID: 8697 RVA: 0x000136B6 File Offset: 0x000118B6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.ShadowResolutionRequest>.NativeClassPtr, ref this));
			}

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeFieldInfoPtr_visibleLightIndex;

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr_perLightShadowSliceIndex;

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeFieldInfoPtr_requestedResolution;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeFieldInfoPtr_softShadow;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeFieldInfoPtr_pointLightShadow;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeFieldInfoPtr_offsetX;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeFieldInfoPtr_offsetY;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeFieldInfoPtr_allocatedResolution;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_0;

			// Token: 0x04001803 RID: 6147
			[FieldOffset(0)]
			public int visibleLightIndex;

			// Token: 0x04001804 RID: 6148
			[FieldOffset(4)]
			public int perLightShadowSliceIndex;

			// Token: 0x04001805 RID: 6149
			[FieldOffset(8)]
			public int requestedResolution;

			// Token: 0x04001806 RID: 6150
			[FieldOffset(12)]
			[MarshalAs(4)]
			public bool softShadow;

			// Token: 0x04001807 RID: 6151
			[FieldOffset(13)]
			[MarshalAs(4)]
			public bool pointLightShadow;

			// Token: 0x04001808 RID: 6152
			[FieldOffset(16)]
			public int offsetX;

			// Token: 0x04001809 RID: 6153
			[FieldOffset(20)]
			public int offsetY;

			// Token: 0x0400180A RID: 6154
			[FieldOffset(24)]
			public int allocatedResolution;
		}

		// Token: 0x020001E8 RID: 488
		public class PassData : Object
		{
			// Token: 0x060021FA RID: 8698 RVA: 0x0008285C File Offset: 0x00080A5C
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr);
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "pass");
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "graph");
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "shadowmapTexture");
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "renderingData");
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "shadowmapID");
				AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, "emptyShadowmap");
				AdditionalLightsShadowCasterPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr, 100666139);
			}

			// Token: 0x060021FB RID: 8699 RVA: 0x00082914 File Offset: 0x00080B14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x000136C8 File Offset: 0x000118C8
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x00082950 File Offset: 0x00080B50
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x000136D1 File Offset: 0x000118D1
			public unsafe AdditionalLightsShadowCasterPass pass
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_pass);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_pass), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x00082980 File Offset: 0x00080B80
			// (set) Token: 0x06002200 RID: 8704 RVA: 0x000136F0 File Offset: 0x000118F0
			public unsafe RenderGraph graph
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_graph);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderGraph>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_graph), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06002201 RID: 8705 RVA: 0x000829B0 File Offset: 0x00080BB0
			// (set) Token: 0x06002202 RID: 8706 RVA: 0x0001370F File Offset: 0x0001190F
			public unsafe TextureHandle shadowmapTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapTexture)) = value;
				}
			}

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x000829D8 File Offset: 0x00080BD8
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x0001372A File Offset: 0x0001192A
			public RenderingData renderingData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData);
					return new RenderingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_renderingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x00082A08 File Offset: 0x00080C08
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x00013758 File Offset: 0x00011958
			public unsafe int shadowmapID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_shadowmapID)) = value;
				}
			}

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x06002207 RID: 8711 RVA: 0x00082A30 File Offset: 0x00080C30
			// (set) Token: 0x06002208 RID: 8712 RVA: 0x00013773 File Offset: 0x00011973
			public unsafe bool emptyShadowmap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditionalLightsShadowCasterPass.PassData.NativeFieldInfoPtr_emptyShadowmap)) = value;
				}
			}

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeFieldInfoPtr_pass;

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeFieldInfoPtr_graph;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeFieldInfoPtr_shadowmapTexture;

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeFieldInfoPtr_renderingData;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr_shadowmapID;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr_emptyShadowmap;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001E9 RID: 489
		[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002209 RID: 8713 RVA: 0x00082A58 File Offset: 0x00080C58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr);
				AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, "<>9");
				AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, "<>9__62_0");
				AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, "<>9__62_1");
				AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, 100666141);
				AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__62_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, 100666142);
				AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__62_1_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr, 100666143);
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x00082AFC File Offset: 0x00080CFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220B RID: 8715 RVA: 0x00082B38 File Offset: 0x00080D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625286, XrefRangeEnd = 625287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__62_0(AdditionalLightsShadowCasterPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__62_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220C RID: 8716 RVA: 0x00082B8C File Offset: 0x00080D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 625287, XrefRangeEnd = 625293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__62_1(AdditionalLightsShadowCasterPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditionalLightsShadowCasterPass.__c.NativeMethodInfoPtr__Render_b__62_1_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600220D RID: 8717 RVA: 0x0001378E File Offset: 0x0001198E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x0600220E RID: 8718 RVA: 0x00082BE0 File Offset: 0x00080DE0
			// (set) Token: 0x0600220F RID: 8719 RVA: 0x00013797 File Offset: 0x00011997
			public unsafe static AdditionalLightsShadowCasterPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x06002210 RID: 8720 RVA: 0x00082C08 File Offset: 0x00080E08
			// (set) Token: 0x06002211 RID: 8721 RVA: 0x000137A9 File Offset: 0x000119A9
			public unsafe static RenderFunc<AdditionalLightsShadowCasterPass.PassData> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<AdditionalLightsShadowCasterPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06002212 RID: 8722 RVA: 0x00082C30 File Offset: 0x00080E30
			// (set) Token: 0x06002213 RID: 8723 RVA: 0x000137BB File Offset: 0x000119BB
			public unsafe static RenderFunc<AdditionalLightsShadowCasterPass.PassData> __9__62_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<AdditionalLightsShadowCasterPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AdditionalLightsShadowCasterPass.__c.NativeFieldInfoPtr___9__62_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeFieldInfoPtr___9__62_1;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__62_0_Internal_Void_PassData_RenderGraphContext_0;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__62_1_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
