using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x0200022F RID: 559
	[StructLayout(2)]
	public struct CullingResults
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x0009FD1C File Offset: 0x0009DF1C
		// Note: this type is marked as 'beforefieldinit'.
		static CullingResults()
		{
			Il2CppClassPointerStore<CullingResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingResults");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingResults>.NativeClassPtr);
			CullingResults.NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "ptr");
			CullingResults.NativeFieldInfoPtr_m_AllocationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "m_AllocationInfo");
			CullingResults.NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668118);
			CullingResults.NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668119);
			CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668120);
			CullingResults.NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668121);
			CullingResults.NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668122);
			CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668123);
			CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668124);
			CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668125);
			CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668126);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668127);
			CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668128);
			CullingResults.NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668129);
			CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668130);
			CullingResults.NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668131);
			CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668132);
			CullingResults.NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668133);
			CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668134);
			CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668135);
			CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668136);
			CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668137);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668138);
			CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668139);
			CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668140);
			CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668141);
			CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668142);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100668143);
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField = IL2CPP.ResolveICall<CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegate>("UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndicesGraphicsBuffer");
			CullingResults.GetReflectionProbeIndexMapSizeDelegateField = IL2CPP.ResolveICall<CullingResults.GetReflectionProbeIndexMapSizeDelegate>("UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexMapSize");
			CullingResults.FillReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.FillReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::FillReflectionProbeIndexMap");
			CullingResults.SetReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.SetReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::SetReflectionProbeIndexMap");
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x0009FFB8 File Offset: 0x0009E1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683541, XrefRangeEnd = 683543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLightIndexCount(IntPtr cullingResultsPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x0009FFF8 File Offset: 0x0009E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683543, XrefRangeEnd = 683545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000A0038 File Offset: 0x0009E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683545, XrefRangeEnd = 683547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000A007C File Offset: 0x0009E27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683547, XrefRangeEnd = 683549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLightIndexMapSize(IntPtr cullingResultsPtr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x000A00BC File Offset: 0x0009E2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683549, XrefRangeEnd = 683551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x000A010C File Offset: 0x0009E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683551, XrefRangeEnd = 683553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000A015C File Offset: 0x0009E35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683553, XrefRangeEnd = 683555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000A01B8 File Offset: 0x0009E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683555, XrefRangeEnd = 683557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000A0230 File Offset: 0x0009E430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683557, XrefRangeEnd = 683559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fovBias;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000A02C4 File Offset: 0x0009E4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683559, XrefRangeEnd = 683561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitRatio;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000A0384 File Offset: 0x0009E584
		public unsafe Unity.Collections.NativeArray<VisibleLight> visibleLights
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683564, RefRangeEnd = 683565, XrefRangeStart = 683561, XrefRangeEnd = 683564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Unity.Collections.NativeArray<VisibleLight>(intPtr);
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000A03B0 File Offset: 0x0009E5B0
		public unsafe Unity.Collections.NativeArray<VisibleReflectionProbe> visibleReflectionProbes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683568, RefRangeEnd = 683570, XrefRangeStart = 683565, XrefRangeEnd = 683568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Unity.Collections.NativeArray<VisibleReflectionProbe>(intPtr);
			}
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000A03DC File Offset: 0x0009E5DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683572, RefRangeEnd = 683574, XrefRangeStart = 683570, XrefRangeEnd = 683572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dataPointer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeArray<T>(intPtr);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000A0424 File Offset: 0x0009E624
		public unsafe int lightAndReflectionProbeIndexCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 683578, RefRangeEnd = 683579, XrefRangeStart = 683574, XrefRangeEnd = 683578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000A0454 File Offset: 0x0009E654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683581, RefRangeEnd = 683582, XrefRangeStart = 683579, XrefRangeEnd = 683581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000A048C File Offset: 0x0009E68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683593, RefRangeEnd = 683594, XrefRangeStart = 683582, XrefRangeEnd = 683593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Unity.Collections.NativeArray<int>(intPtr);
			}
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000A04C4 File Offset: 0x0009E6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683600, RefRangeEnd = 683601, XrefRangeStart = 683594, XrefRangeEnd = 683600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightIndexMap));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000A0500 File Offset: 0x0009E700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683603, RefRangeEnd = 683605, XrefRangeStart = 683601, XrefRangeEnd = 683603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000A054C File Offset: 0x0009E74C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683607, RefRangeEnd = 683608, XrefRangeStart = 683605, XrefRangeEnd = 683607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeLightIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000A05B4 File Offset: 0x0009E7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683610, RefRangeEnd = 683611, XrefRangeStart = 683608, XrefRangeEnd = 683610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeLightIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fovBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000A063C File Offset: 0x0009E83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683613, RefRangeEnd = 683614, XrefRangeStart = 683611, XrefRangeEnd = 683613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activeLightIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitRatio;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000A06F0 File Offset: 0x0009E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683614, XrefRangeEnd = 683618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CullingResults other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000A0730 File Offset: 0x0009E930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683618, XrefRangeEnd = 683625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000A0774 File Offset: 0x0009E974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683625, XrefRangeEnd = 683626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000A07A4 File Offset: 0x0009E9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683626, XrefRangeEnd = 683630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CullingResults left, CullingResults right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000A07F0 File Offset: 0x0009E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683630, XrefRangeEnd = 683632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cullingResultsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &splitRatio;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0000ECD5 File Offset: 0x0000CED5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, ref this));
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0000ECE7 File Offset: 0x0000CEE7
		public static void FillLightAndReflectionProbeIndicesGraphicsBuffer(IntPtr cullingResultsPtr, GraphicsBuffer buffer)
		{
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField(cullingResultsPtr, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0000ECFA File Offset: 0x0000CEFA
		public static int GetReflectionProbeIndexMapSize(IntPtr cullingResultsPtr)
		{
			return CullingResults.GetReflectionProbeIndexMapSizeDelegateField(cullingResultsPtr);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0000ED07 File Offset: 0x0000CF07
		public static void FillReflectionProbeIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			CullingResults.FillReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0000ED16 File Offset: 0x0000CF16
		public static void SetReflectionProbeIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			CullingResults.SetReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x0000ED25 File Offset: 0x0000CF25
		public Unity.Collections.NativeArray<VisibleLight> visibleOffscreenVertexLights
		{
			get
			{
				return this.GetNativeArray<VisibleLight>(this.m_AllocationInfo.visibleOffscreenVertexLightsPtr, this.m_AllocationInfo.visibleOffscreenVertexLightCount);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x000A08B4 File Offset: 0x0009EAB4
		public int lightIndexCount
		{
			get
			{
				return CullingResults.GetLightIndexCount(this.ptr);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000A08D4 File Offset: 0x0009EAD4
		public int reflectionProbeIndexCount
		{
			get
			{
				return CullingResults.GetReflectionProbeIndexCount(this.ptr);
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x0000ED43 File Offset: 0x0000CF43
		public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer)
		{
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer(this.ptr, buffer);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000A08F4 File Offset: 0x0009EAF4
		public Unity.Collections.NativeArray<int> GetReflectionProbeIndexMap(Unity.Collections.Allocator allocator)
		{
			int reflectionProbeIndexMapSize = CullingResults.GetReflectionProbeIndexMapSize(this.ptr);
			Unity.Collections.NativeArray<int> nativeArray;
			nativeArray..ctor(reflectionProbeIndexMapSize, allocator, Unity.Collections.NativeArrayOptions.UninitializedMemory);
			CullingResults.FillReflectionProbeIndexMap(this.ptr, (IntPtr)nativeArray.GetUnsafePtr<int>(), reflectionProbeIndexMapSize);
			return nativeArray;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x0000ED53 File Offset: 0x0000CF53
		public void SetReflectionProbeIndexMap(Unity.Collections.NativeArray<int> lightIndexMap)
		{
			CullingResults.SetReflectionProbeIndexMap(this.ptr, (IntPtr)lightIndexMap.GetUnsafeReadOnlyPtr<int>(), lightIndexMap.Length);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public void Validate()
		{
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000A0938 File Offset: 0x0009EB38
		public static bool operator !=(CullingResults left, CullingResults right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeFieldInfoPtr_ptr;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocationInfo;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0;

		// Token: 0x04002180 RID: 8576
		private static readonly IntPtr NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002181 RID: 8577
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

		// Token: 0x04002182 RID: 8578
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0;

		// Token: 0x04002183 RID: 8579
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002184 RID: 8580
		private static readonly IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002185 RID: 8581
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002186 RID: 8582
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0;

		// Token: 0x04002187 RID: 8583
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0;

		// Token: 0x04002188 RID: 8584
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0;

		// Token: 0x04002189 RID: 8585
		private static readonly IntPtr NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0;

		// Token: 0x0400218A RID: 8586
		private static readonly IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0;

		// Token: 0x0400218B RID: 8587
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0;

		// Token: 0x0400218C RID: 8588
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0;

		// Token: 0x0400218D RID: 8589
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0;

		// Token: 0x0400218E RID: 8590
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002193 RID: 8595
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002194 RID: 8596
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0;

		// Token: 0x04002195 RID: 8597
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04002196 RID: 8598
		[FieldOffset(0)]
		public IntPtr ptr;

		// Token: 0x04002197 RID: 8599
		[FieldOffset(8)]
		public IntPtr m_AllocationInfo;

		// Token: 0x04002198 RID: 8600
		private static readonly CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegate FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField;

		// Token: 0x04002199 RID: 8601
		private static readonly CullingResults.GetReflectionProbeIndexMapSizeDelegate GetReflectionProbeIndexMapSizeDelegateField;

		// Token: 0x0400219A RID: 8602
		private static readonly CullingResults.FillReflectionProbeIndexMapDelegate FillReflectionProbeIndexMapDelegateField;

		// Token: 0x0400219B RID: 8603
		private static readonly CullingResults.SetReflectionProbeIndexMapDelegate SetReflectionProbeIndexMapDelegateField;

		// Token: 0x020009D6 RID: 2518
		private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002D2C RID: 11564
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CullingResults>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020009D7 RID: 2519
		// (Invoke) Token: 0x06003CCC RID: 15564
		private delegate void FillLightAndReflectionProbeIndicesGraphicsBufferDelegate(IntPtr cullingResultsPtr, IntPtr buffer);

		// Token: 0x020009D8 RID: 2520
		// (Invoke) Token: 0x06003CCE RID: 15566
		private delegate int GetReflectionProbeIndexMapSizeDelegate(IntPtr cullingResultsPtr);

		// Token: 0x020009D9 RID: 2521
		// (Invoke) Token: 0x06003CD0 RID: 15568
		private delegate void FillReflectionProbeIndexMapDelegate(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize);

		// Token: 0x020009DA RID: 2522
		// (Invoke) Token: 0x06003CD2 RID: 15570
		private delegate void SetReflectionProbeIndexMapDelegate(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize);
	}
}
