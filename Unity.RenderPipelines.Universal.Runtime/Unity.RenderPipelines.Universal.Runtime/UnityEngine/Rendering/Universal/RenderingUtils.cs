using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000CC RID: 204
	public static class RenderingUtils : Object
	{
		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004BA50 File Offset: 0x00049C50
		// Note: this type is marked as 'beforefieldinit'.
		static RenderingUtils()
		{
			Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "RenderingUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr);
			RenderingUtils.NativeFieldInfoPtr_m_LegacyShaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "m_LegacyShaderPassNames");
			RenderingUtils.NativeFieldInfoPtr_s_EmptyAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_EmptyAttachment");
			RenderingUtils.NativeFieldInfoPtr_s_FullscreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_FullscreenMesh");
			RenderingUtils.NativeFieldInfoPtr_s_ErrorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "s_ErrorMaterial");
			RenderingUtils.NativeFieldInfoPtr_m_RenderTextureFormatSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "m_RenderTextureFormatSupport");
			RenderingUtils.NativeFieldInfoPtr_m_GraphicsFormatSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, "m_GraphicsFormatSupport");
			RenderingUtils.NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665285);
			RenderingUtils.NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665286);
			RenderingUtils.NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665287);
			RenderingUtils.NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665288);
			RenderingUtils.NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665289);
			RenderingUtils.NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665290);
			RenderingUtils.NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665291);
			RenderingUtils.NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665292);
			RenderingUtils.NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665293);
			RenderingUtils.NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_byref_CameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665294);
			RenderingUtils.NativeMethodInfoPtr_RenderObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665295);
			RenderingUtils.NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665296);
			RenderingUtils.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665297);
			RenderingUtils.NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665298);
			RenderingUtils.NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665299);
			RenderingUtils.NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665300);
			RenderingUtils.NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665301);
			RenderingUtils.NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665302);
			RenderingUtils.NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665303);
			RenderingUtils.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665304);
			RenderingUtils.NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665305);
			RenderingUtils.NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665306);
			RenderingUtils.NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665307);
			RenderingUtils.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665308);
			RenderingUtils.NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665309);
			RenderingUtils.NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665310);
			RenderingUtils.NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665311);
			RenderingUtils.NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665312);
			RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665313);
			RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665314);
			RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665315);
			RenderingUtils.NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665316);
			RenderingUtils.NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665317);
			RenderingUtils.NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665318);
			RenderingUtils.NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingUtils>.NativeClassPtr, 100665319);
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		public unsafe static AttachmentDescriptor emptyAttachment
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615975, XrefRangeEnd = 615979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0004BDE4 File Offset: 0x00049FE4
		public unsafe static Mesh fullscreenMesh
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 615979, XrefRangeEnd = 616048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0004BE18 File Offset: 0x0004A018
		public unsafe static bool useStructuredBuffer
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0004BE48 File Offset: 0x0004A048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616048, RefRangeEnd = 616049, XrefRangeStart = 616048, XrefRangeEnd = 616048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsLightLayers(GraphicsDeviceType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0004BE88 File Offset: 0x0004A088
		public unsafe static Material errorMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 616073, RefRangeEnd = 616075, XrefRangeStart = 616049, XrefRangeEnd = 616073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004BEBC File Offset: 0x0004A0BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 616096, RefRangeEnd = 616098, XrefRangeStart = 616075, XrefRangeEnd = 616096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectionMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setInverseMatrices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004BF1C File Offset: 0x0004A11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616111, RefRangeEnd = 616112, XrefRangeStart = 616098, XrefRangeEnd = 616111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScaleBiasRt(CommandBuffer cmd, [In] ref RenderingData renderingData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_CommandBuffer_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0004BF68 File Offset: 0x0004A168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616126, RefRangeEnd = 616127, XrefRangeStart = 616112, XrefRangeEnd = 616126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewport;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004C02C File Offset: 0x0004A22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616141, RefRangeEnd = 616142, XrefRangeStart = 616127, XrefRangeEnd = 616141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewport;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationColor);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorLoadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorStoreAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationDepthStencil);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilLoadAction;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthStencilStoreAction;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlag;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004C124 File Offset: 0x0004A324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 616172, RefRangeEnd = 616176, XrefRangeStart = 616142, XrefRangeEnd = 616172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinalBlit(CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(cameraData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadAction;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeAction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_byref_CameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004C1D0 File Offset: 0x0004A3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616176, XrefRangeEnd = 616217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cullResults;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterSettings;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_RenderObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0004C240 File Offset: 0x0004A440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616229, RefRangeEnd = 616230, XrefRangeStart = 616217, XrefRangeEnd = 616229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSystemInfoCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004C268 File Offset: 0x0004A468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616244, RefRangeEnd = 616245, XrefRangeStart = 616230, XrefRangeEnd = 616244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004C2A8 File Offset: 0x0004A4A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 616262, RefRangeEnd = 616273, XrefRangeStart = 616245, XrefRangeEnd = 616262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0004C2F4 File Offset: 0x0004A4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616273, XrefRangeEnd = 616275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLastValidColorBufferIndex(Il2CppStructArray<RenderTargetIdentifier> colorBuffers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0004C338 File Offset: 0x0004A538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616278, RefRangeEnd = 616281, XrefRangeStart = 616275, XrefRangeEnd = 616278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetValidColorBufferCount(Il2CppStructArray<RenderTargetIdentifier> colorBuffers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004C37C File Offset: 0x0004A57C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 616284, RefRangeEnd = 616286, XrefRangeStart = 616281, XrefRangeEnd = 616284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetValidColorBufferCount(Il2CppReferenceArray<RTHandle> colorBuffers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0004C3C0 File Offset: 0x0004A5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 616292, RefRangeEnd = 616293, XrefRangeStart = 616286, XrefRangeEnd = 616292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMRT(Il2CppStructArray<RenderTargetIdentifier> colorBuffers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0004C404 File Offset: 0x0004A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616293, XrefRangeEnd = 616299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMRT(Il2CppReferenceArray<RTHandle> colorBuffers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorBuffers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004C448 File Offset: 0x0004A648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616299, XrefRangeEnd = 616301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains(Il2CppStructArray<RenderTargetIdentifier> source, RenderTargetIdentifier value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004C498 File Offset: 0x0004A698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616301, XrefRangeEnd = 616303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOf(Il2CppStructArray<RenderTargetIdentifier> source, RenderTargetIdentifier value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616303, XrefRangeEnd = 616307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint CountDistinct(Il2CppStructArray<RenderTargetIdentifier> source, RenderTargetIdentifier value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004C538 File Offset: 0x0004A738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616307, XrefRangeEnd = 616309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastValid(Il2CppStructArray<RenderTargetIdentifier> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004C57C File Offset: 0x0004A77C
		[CallerCount(0)]
		public unsafe static bool Contains(ClearFlag a, ClearFlag b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004C5C8 File Offset: 0x0004A7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616309, XrefRangeEnd = 616311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SequenceEqual(Il2CppStructArray<RenderTargetIdentifier> left, Il2CppStructArray<RenderTargetIdentifier> right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004C61C File Offset: 0x0004A81C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 616320, RefRangeEnd = 616325, XrefRangeStart = 616311, XrefRangeEnd = 616320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MultisampleDepthResolveSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004C64C File Offset: 0x0004A84C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 616354, RefRangeEnd = 616358, XrefRangeStart = 616325, XrefRangeEnd = 616354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RTHandleNeedsReAlloc(RTHandle handle, [In] ref TextureDesc descriptor, bool scaled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(descriptor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 616369, RefRangeEnd = 616373, XrefRangeStart = 616358, XrefRangeEnd = 616369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0004C6F4 File Offset: 0x0004A8F4
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 616407, RefRangeEnd = 616463, XrefRangeStart = 616373, XrefRangeEnd = 616407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			handle = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0004C7B4 File Offset: 0x0004A9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616463, XrefRangeEnd = 616501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			handle = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004C884 File Offset: 0x0004AA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616501, XrefRangeEnd = 616541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, [In] ref RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scaleFunc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &descriptor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isShadowMap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anisoLevel;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipMapBias;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			handle = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004C958 File Offset: 0x0004AB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 616541, XrefRangeEnd = 616554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetMaxRTHandlePoolCapacity(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004C998 File Offset: 0x0004AB98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616564, RefRangeEnd = 616567, XrefRangeStart = 616554, XrefRangeEnd = 616564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004C9E8 File Offset: 0x0004ABE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 616581, RefRangeEnd = 616585, XrefRangeStart = 616567, XrefRangeEnd = 616581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shaderTagId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingCriteria;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004CA48 File Offset: 0x0004AC48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 616614, RefRangeEnd = 616617, XrefRangeStart = 616585, XrefRangeEnd = 616614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shaderTagIdList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingCriteria;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderingUtils.NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00009C40 File Offset: 0x00007E40
		public RenderingUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x0004CAAC File Offset: 0x0004ACAC
		// (set) Token: 0x06001006 RID: 4102 RVA: 0x00009C49 File Offset: 0x00007E49
		public unsafe static List<ShaderTagId> m_LegacyShaderPassNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_m_LegacyShaderPassNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_m_LegacyShaderPassNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x0004CAD4 File Offset: 0x0004ACD4
		// (set) Token: 0x06001008 RID: 4104 RVA: 0x00009C5B File Offset: 0x00007E5B
		public unsafe static AttachmentDescriptor s_EmptyAttachment
		{
			get
			{
				AttachmentDescriptor attachmentDescriptor;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_s_EmptyAttachment, (void*)(&attachmentDescriptor));
				return attachmentDescriptor;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_s_EmptyAttachment, (void*)(&value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x0004CAF0 File Offset: 0x0004ACF0
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00009C69 File Offset: 0x00007E69
		public unsafe static Mesh s_FullscreenMesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_s_FullscreenMesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_s_FullscreenMesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0004CB18 File Offset: 0x0004AD18
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00009C7B File Offset: 0x00007E7B
		public unsafe static Material s_ErrorMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_s_ErrorMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_s_ErrorMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0004CB40 File Offset: 0x0004AD40
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00009C8D File Offset: 0x00007E8D
		public unsafe static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_m_RenderTextureFormatSupport, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RenderTextureFormat, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_m_RenderTextureFormatSupport, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x0004CB68 File Offset: 0x0004AD68
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00009C9F File Offset: 0x00007E9F
		public unsafe static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderingUtils.NativeFieldInfoPtr_m_GraphicsFormatSupport, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderingUtils.NativeFieldInfoPtr_m_GraphicsFormatSupport, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeFieldInfoPtr_m_LegacyShaderPassNames;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyAttachment;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeFieldInfoPtr_s_FullscreenMesh;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeFieldInfoPtr_s_ErrorMaterial;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTextureFormatSupport;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicsFormatSupport;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_get_emptyAttachment_Internal_Static_get_AttachmentDescriptor_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_get_fullscreenMesh_Public_Static_get_Mesh_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_get_useStructuredBuffer_Internal_Static_get_Boolean_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_SupportsLightLayers_Internal_Static_Boolean_GraphicsDeviceType_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_get_errorMaterial_Private_Static_get_Material_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_SetViewAndProjectionMatrices_Public_Static_Void_CommandBuffer_Matrix4x4_Matrix4x4_Boolean_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleBiasRt_Internal_Static_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Internal_Static_Void_CommandBuffer_RTHandle_Rect_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_ClearFlag_Color_Material_Int32_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_FinalBlit_Internal_Static_Void_CommandBuffer_byref_CameraData_RTHandle_RTHandle_RenderBufferLoadAction_RenderBufferStoreAction_Material_Int32_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_RenderObjectsWithError_Internal_Static_Void_ScriptableRenderContext_byref_CullingResults_Camera_FilteringSettings_SortingCriteria_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_ClearSystemInfoCache_Internal_Static_Void_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_SupportsGraphicsFormat_Public_Static_Boolean_GraphicsFormat_FormatUsage_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_GetLastValidColorBufferIndex_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_GetValidColorBufferCount_Internal_Static_UInt32_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_IsMRT_Internal_Static_Boolean_Il2CppReferenceArray_1_RTHandle_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_CountDistinct_Internal_Static_UInt32_Il2CppStructArray_1_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_LastValid_Internal_Static_Int32_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Static_Boolean_ClearFlag_ClearFlag_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_SequenceEqual_Internal_Static_Boolean_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderTargetIdentifier_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_MultisampleDepthResolveSupported_Internal_Static_Boolean_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_RTHandleNeedsReAlloc_Internal_Static_Boolean_RTHandle_byref_TextureDesc_Boolean_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraTargetIdentifier_Internal_Static_RenderTargetIdentifier_byref_RenderingData_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_Vector2_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocateIfNeeded_Public_Static_Boolean_byref_RTHandle_ScaleFunc_byref_RenderTextureDescriptor_FilterMode_TextureWrapMode_Boolean_Int32_Single_String_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxRTHandlePoolCapacity_Public_Static_Boolean_Int32_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_AddStaleResourceToPoolOrRelease_Internal_Static_Void_TextureDesc_RTHandle_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_ShaderTagId_byref_RenderingData_SortingCriteria_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Public_Static_DrawingSettings_List_1_ShaderTagId_byref_RenderingData_SortingCriteria_0;
	}
}
