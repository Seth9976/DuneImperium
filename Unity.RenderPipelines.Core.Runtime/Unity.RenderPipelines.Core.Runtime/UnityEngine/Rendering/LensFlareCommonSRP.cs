using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A0 RID: 160
	public sealed class LensFlareCommonSRP : Object
	{
		// Token: 0x06000B94 RID: 2964 RVA: 0x00037388 File Offset: 0x00035588
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareCommonSRP()
		{
			Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareCommonSRP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr);
			LensFlareCommonSRP.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Instance");
			LensFlareCommonSRP.NativeFieldInfoPtr_m_Padlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Padlock");
			LensFlareCommonSRP.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_Data");
			LensFlareCommonSRP.NativeFieldInfoPtr_m_AvailableIndicies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "m_AvailableIndicies");
			LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "maxLensFlareWithOcclusion");
			LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "maxLensFlareWithOcclusionTemporalSample");
			LensFlareCommonSRP.NativeFieldInfoPtr_mergeNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "mergeNeeded");
			LensFlareCommonSRP.NativeFieldInfoPtr_occlusionRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "occlusionRT");
			LensFlareCommonSRP.NativeFieldInfoPtr_frameIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "frameIdx");
			LensFlareCommonSRP.NativeFieldInfoPtr_s_SupportsLensFlareTexFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "s_SupportsLensFlareTexFormat");
			LensFlareCommonSRP.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665045);
			LensFlareCommonSRP.NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665046);
			LensFlareCommonSRP.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665047);
			LensFlareCommonSRP.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665048);
			LensFlareCommonSRP.NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665049);
			LensFlareCommonSRP.NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665050);
			LensFlareCommonSRP.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665051);
			LensFlareCommonSRP.NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665052);
			LensFlareCommonSRP.NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665053);
			LensFlareCommonSRP.NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665054);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665055);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665056);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665057);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665058);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665059);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665060);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665061);
			LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665062);
			LensFlareCommonSRP.NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665063);
			LensFlareCommonSRP.NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665064);
			LensFlareCommonSRP.NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665065);
			LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665066);
			LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665067);
			LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665068);
			LensFlareCommonSRP.NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665069);
			LensFlareCommonSRP.NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Boolean_Boolean_Int32_Int32_Texture_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665070);
			LensFlareCommonSRP.NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665071);
			LensFlareCommonSRP.NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665072);
			LensFlareCommonSRP.NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665073);
			LensFlareCommonSRP.NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665074);
			LensFlareCommonSRP.NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665075);
			LensFlareCommonSRP.NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665076);
			LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665078);
			LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665079);
			LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665080);
			LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass40_0_byref___c__DisplayClass40_1_byref___c__DisplayClass40_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665081);
			LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, 100665082);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00037764 File Offset: 0x00035964
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareCommonSRP()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000377A0 File Offset: 0x000359A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 970674, RefRangeEnd = 970677, XrefRangeStart = 970667, XrefRangeEnd = 970674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOcclusionRTCompatible()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000377D0 File Offset: 0x000359D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 970712, RefRangeEnd = 970714, XrefRangeStart = 970677, XrefRangeEnd = 970712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000377F8 File Offset: 0x000359F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 970734, RefRangeEnd = 970735, XrefRangeStart = 970714, XrefRangeEnd = 970734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00037820 File Offset: 0x00035A20
		public unsafe static LensFlareCommonSRP Instance
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 970760, RefRangeEnd = 970772, XrefRangeStart = 970735, XrefRangeEnd = 970760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LensFlareCommonSRP>(intPtr3) : null;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00037854 File Offset: 0x00035A54
		public unsafe List<LensFlareCommonSRP.LensFlareCompInfo> Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970772, XrefRangeEnd = 970776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LensFlareCommonSRP.LensFlareCompInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00037894 File Offset: 0x00035A94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 970781, RefRangeEnd = 970785, XrefRangeStart = 970776, XrefRangeEnd = 970781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000378D0 File Offset: 0x00035AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970785, XrefRangeEnd = 970800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextAvailableIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0003790C File Offset: 0x00035B0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 970847, RefRangeEnd = 970850, XrefRangeStart = 970800, XrefRangeEnd = 970847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddData(LensFlareComponentSRP newData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00037950 File Offset: 0x00035B50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 970884, RefRangeEnd = 970888, XrefRangeStart = 970850, XrefRangeEnd = 970884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveData(LensFlareComponentSRP data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00037994 File Offset: 0x00035B94
		[CallerCount(0)]
		public unsafe static float ShapeAttenuationPointLight()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000379C4 File Offset: 0x00035BC4
		[CallerCount(0)]
		public unsafe static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00037A10 File Offset: 0x00035C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970888, XrefRangeEnd = 970891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref innerSpotPercent01;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00037A78 File Offset: 0x00035C78
		[CallerCount(0)]
		public unsafe static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00037AC4 File Offset: 0x00035CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970891, XrefRangeEnd = 970894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00037B10 File Offset: 0x00035D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970894, XrefRangeEnd = 970911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightPositionWS;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00037B7C File Offset: 0x00035D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970911, XrefRangeEnd = 970914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00037BC8 File Offset: 0x00035DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970914, XrefRangeEnd = 970917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forward;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00037C14 File Offset: 0x00035E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 970929, RefRangeEnd = 970932, XrefRangeStart = 970917, XrefRangeEnd = 970929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comp);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00037C7C File Offset: 0x00035E7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 970946, RefRangeEnd = 970951, XrefRangeStart = 970932, XrefRangeEnd = 970946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translationScale;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayOff0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vLocalScreenRatio;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angleDeg;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angularOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionOffset;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoRotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00037D2C File Offset: 0x00035F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 970951, RefRangeEnd = 970954, XrefRangeStart = 970951, XrefRangeEnd = 970951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref globalCos0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref globalSin0;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00037D94 File Offset: 0x00035F94
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 970961, RefRangeEnd = 970967, XrefRangeStart = 970954, XrefRangeEnd = 970961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalLight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCameraRelative;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewProjMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00037E10 File Offset: 0x00036010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970967, XrefRangeEnd = 970968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isCameraRelative;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewProjMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPosWS;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00037E78 File Offset: 0x00036078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970968, XrefRangeEnd = 970972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00037EC8 File Offset: 0x000360C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970972, XrefRangeEnd = 971001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCloudLayerOpacityNeeded(Camera cam)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00037F0C File Offset: 0x0003610C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971015, RefRangeEnd = 971016, XrefRangeStart = 971001, XrefRangeEnd = 971015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useBackgroundCloudOcclusion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumetricCloudOcclusion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasCloudLayer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareCloudOpacity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareSunOcclusionTex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cloudOpacityTexture);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sunOcclusionTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Boolean_Boolean_Int32_Int32_Texture_Texture_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00037FB0 File Offset: 0x000361B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971150, RefRangeEnd = 971151, XrefRangeStart = 971016, XrefRangeEnd = 971150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lensFlareShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePanini;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniDistance;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniCropToFit;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCameraRelative;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPositionWS;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewProjMatrix;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaEnabled;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasCloudLayer;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cloudOpacityTexture);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sunOcclusionTexture);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareOcclusionTex;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareCloudOpacity;
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareOcclusionIndex;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareTex;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareColorValue;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareSunOcclusionTex;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData0;
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData1;
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData2;
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData3;
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0003816C File Offset: 0x0003636C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 971429, RefRangeEnd = 971430, XrefRangeStart = 971151, XrefRangeEnd = 971429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)30) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lensFlareShader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualWidth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usePanini;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniDistance;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniCropToFit;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCameraRelative;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPositionWS;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewProjMatrix;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaEnabled;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasCloudLayer;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cloudOpacityTexture);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sunOcclusionTexture);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorBuffer;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(GetLensFlareLightAttenuation);
			ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareOcclusionRemapTex;
			ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareOcclusionTex;
			ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareOcclusionIndex;
			ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareCloudOpacity;
			ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareSunOcclusionTex;
			ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareTex;
			ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareColorValue;
			ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData0;
			ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData1;
			ptr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData2;
			ptr[checked(unchecked((UIntPtr)27) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData3;
			ptr[checked(unchecked((UIntPtr)28) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _FlareData4;
			ptr[checked(unchecked((UIntPtr)29) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debugView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00038368 File Offset: 0x00036568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 971444, RefRangeEnd = 971446, XrefRangeStart = 971430, XrefRangeEnd = 971444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldOfView;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniProjectionCropToFit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paniniProjectionDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000383EC File Offset: 0x000365EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971446, XrefRangeEnd = 971447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actualWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldOfView;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00038448 File Offset: 0x00036648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971447, XrefRangeEnd = 971453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actualWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actualHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fieldOfView;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000384B0 File Offset: 0x000366B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971453, XrefRangeEnd = 971455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Panini_Generic_Inv(Vector2 projPos, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref projPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000384FC File Offset: 0x000366FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971455, XrefRangeEnd = 971456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_0(float d, float l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00038548 File Offset: 0x00036748
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_1(float d, float l)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00038594 File Offset: 0x00036794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 971464, RefRangeEnd = 971466, XrefRangeStart = 971456, XrefRangeEnd = 971464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Method_Internal_Static_Single_Vector3_Vector3_0(Vector3 p1, Vector3 p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000385E0 File Offset: 0x000367E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 971476, RefRangeEnd = 971480, XrefRangeStart = 971466, XrefRangeEnd = 971476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass40_0_byref___c__DisplayClass40_1_byref___c__DisplayClass40_2_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref LensFlareCommonSRP.__c__DisplayClass40_0 A_4, ref LensFlareCommonSRP.__c__DisplayClass40_1 A_5, ref LensFlareCommonSRP.__c__DisplayClass40_2 A_6)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rayOff;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayOff0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref curSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(distortionCurve);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_4;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_5);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_6;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass40_0_byref___c__DisplayClass40_1_byref___c__DisplayClass40_2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00038680 File Offset: 0x00036880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971480, XrefRangeEnd = 971481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Method_Internal_Static_Single_Single_Single_PDM_2(float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00006F80 File Offset: 0x00005180
		public LensFlareCommonSRP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000386CC File Offset: 0x000368CC
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00006F89 File Offset: 0x00005189
		public unsafe static LensFlareCommonSRP m_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareCommonSRP>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000386F4 File Offset: 0x000368F4
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00006F9B File Offset: 0x0000519B
		public unsafe static Object m_Padlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Padlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Padlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0003871C File Offset: 0x0003691C
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00006FAD File Offset: 0x000051AD
		public unsafe static List<LensFlareCommonSRP.LensFlareCompInfo> m_Data
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Data, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LensFlareCommonSRP.LensFlareCompInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_Data, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00038744 File Offset: 0x00036944
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00006FBF File Offset: 0x000051BF
		public unsafe static List<int> m_AvailableIndicies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_AvailableIndicies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_m_AvailableIndicies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0003876C File Offset: 0x0003696C
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00006FD1 File Offset: 0x000051D1
		public unsafe static int maxLensFlareWithOcclusion
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusion, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusion, (void*)(&value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00038788 File Offset: 0x00036988
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00006FDF File Offset: 0x000051DF
		public unsafe static int maxLensFlareWithOcclusionTemporalSample
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample, (void*)(&value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x000387A4 File Offset: 0x000369A4
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00006FED File Offset: 0x000051ED
		public unsafe static int mergeNeeded
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_mergeNeeded, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_mergeNeeded, (void*)(&value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000387C0 File Offset: 0x000369C0
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00006FFB File Offset: 0x000051FB
		public unsafe static RTHandle occlusionRT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_occlusionRT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_occlusionRT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000387E8 File Offset: 0x000369E8
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0000700D File Offset: 0x0000520D
		public unsafe static int frameIdx
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_frameIdx, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_frameIdx, (void*)(&value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00038804 File Offset: 0x00036A04
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0000701B File Offset: 0x0000521B
		public unsafe static bool s_SupportsLensFlareTexFormat
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LensFlareCommonSRP.NativeFieldInfoPtr_s_SupportsLensFlareTexFormat, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareCommonSRP.NativeFieldInfoPtr_s_SupportsLensFlareTexFormat, (void*)(&value));
			}
		}

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_m_Padlock;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableIndicies;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_maxLensFlareWithOcclusion;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_maxLensFlareWithOcclusionTemporalSample;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_mergeNeeded;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_occlusionRT;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_frameIdx;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeFieldInfoPtr_s_SupportsLensFlareTexFormat;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_IsOcclusionRTCompatible_Public_Static_Boolean_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LensFlareCommonSRP_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Private_get_List_1_LensFlareCompInfo_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_GetNextAvailableIndex_Private_Int32_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_Void_LensFlareComponentSRP_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_RemoveData_Public_Void_LensFlareComponentSRP_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationPointLight_Public_Static_Single_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationDirLight_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotConeLight_Public_Static_Single_Vector3_Vector3_Single_Single_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotBoxLight_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationSpotPyramidLight_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaTubeLight_Public_Static_Single_Vector3_Vector3_Single_Camera_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaRectangleLight_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_ShapeAttenuationAreaDiscLight_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_IsLensFlareSRPHidden_Private_Static_Boolean_Camera_LensFlareComponentSRP_LensFlareDataSRP_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_GetFlareData0_Public_Static_Vector4_Vector2_Vector2_Vector2_Vector2_Single_Single_Single_Vector2_Boolean_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_GetLensFlareRayOffset_Private_Static_Vector2_Vector2_Single_Single_Single_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewport_Private_Static_Vector3_Camera_Boolean_Boolean_Matrix4x4_Vector3_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportLocal_Private_Static_Vector3_Boolean_Matrix4x4_Vector3_Vector3_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_WorldToViewportDistance_Private_Static_Vector3_Camera_Vector3_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudLayerOpacityNeeded_Public_Static_Boolean_Camera_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_SetOcclusionPermutation_Private_Static_Void_CommandBuffer_Boolean_Boolean_Boolean_Int32_Int32_Texture_Texture_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_ComputeOcclusion_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_DoLensFlareDataDrivenCommon_Public_Static_Void_Material_Camera_Single_Single_Boolean_Single_Single_Boolean_Vector3_Matrix4x4_CommandBuffer_Boolean_Boolean_Texture_Texture_RenderTargetIdentifier_Func_4_Light_Camera_Vector3_Single_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_DoPaniniProjection_Private_Static_Vector2_Vector2_Single_Single_Single_Single_Single_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_CalcViewExtents_Private_Static_Vector2_Single_Single_Single_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_CalcCropExtents_Private_Static_Vector2_Single_Single_Single_Single_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_Panini_Generic_Inv_Private_Static_Vector2_Vector2_Single_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_1;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector3_Vector3_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector2_Vector2_Vector2_Vector2_AnimationCurve_byref___c__DisplayClass40_0_byref___c__DisplayClass40_1_byref___c__DisplayClass40_2_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Single_Single_PDM_2;

		// Token: 0x020001DE RID: 478
		public class LensFlareCompInfo : Object
		{
			// Token: 0x06001A09 RID: 6665 RVA: 0x0006C268 File Offset: 0x0006A468
			// Note: this type is marked as 'beforefieldinit'.
			static LensFlareCompInfo()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "LensFlareCompInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr);
				LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr, "index");
				LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_comp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr, "comp");
				LensFlareCommonSRP.LensFlareCompInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr, 100665083);
			}

			// Token: 0x06001A0A RID: 6666 RVA: 0x0006C2D0 File Offset: 0x0006A4D0
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LensFlareCompInfo(int idx, LensFlareComponentSRP cmp)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP.LensFlareCompInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref idx;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cmp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.LensFlareCompInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A0B RID: 6667 RVA: 0x0000D080 File Offset: 0x0000B280
			public LensFlareCompInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06001A0C RID: 6668 RVA: 0x0006C32C File Offset: 0x0006A52C
			// (set) Token: 0x06001A0D RID: 6669 RVA: 0x0000D089 File Offset: 0x0000B289
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0006C354 File Offset: 0x0006A554
			// (set) Token: 0x06001A0F RID: 6671 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
			public unsafe LensFlareComponentSRP comp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_comp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.LensFlareCompInfo.NativeFieldInfoPtr_comp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012EB RID: 4843
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040012EC RID: 4844
			private static readonly IntPtr NativeFieldInfoPtr_comp;

			// Token: 0x040012ED RID: 4845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_LensFlareComponentSRP_0;
		}

		// Token: 0x020001DF RID: 479
		[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Object
		{
			// Token: 0x06001A10 RID: 6672 RVA: 0x0006C384 File Offset: 0x0006A584
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr);
				LensFlareCommonSRP.__c__DisplayClass21_0.NativeFieldInfoPtr_newData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr, "newData");
				LensFlareCommonSRP.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr, 100665084);
				LensFlareCommonSRP.__c__DisplayClass21_0.NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr, 100665085);
			}

			// Token: 0x06001A11 RID: 6673 RVA: 0x0006C3EC File Offset: 0x0006A5EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A12 RID: 6674 RVA: 0x0006C428 File Offset: 0x0006A628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970643, XrefRangeEnd = 970648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddData_b__0(LensFlareCommonSRP.LensFlareCompInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.__c__DisplayClass21_0.NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A13 RID: 6675 RVA: 0x0000D0C3 File Offset: 0x0000B2C3
			public __c__DisplayClass21_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06001A14 RID: 6676 RVA: 0x0006C478 File Offset: 0x0006A678
			// (set) Token: 0x06001A15 RID: 6677 RVA: 0x0000D0CC File Offset: 0x0000B2CC
			public unsafe LensFlareComponentSRP newData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass21_0.NativeFieldInfoPtr_newData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass21_0.NativeFieldInfoPtr_newData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeFieldInfoPtr_newData;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeMethodInfoPtr__AddData_b__0_Internal_Boolean_LensFlareCompInfo_0;
		}

		// Token: 0x020001E0 RID: 480
		[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06001A16 RID: 6678 RVA: 0x0006C4A8 File Offset: 0x0006A6A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr);
				LensFlareCommonSRP.__c__DisplayClass22_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr, "data");
				LensFlareCommonSRP.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr, 100665086);
				LensFlareCommonSRP.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr, 100665087);
			}

			// Token: 0x06001A17 RID: 6679 RVA: 0x0006C510 File Offset: 0x0006A710
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A18 RID: 6680 RVA: 0x0006C54C File Offset: 0x0006A74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970648, XrefRangeEnd = 970667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveData_b__0(LensFlareCommonSRP.LensFlareCompInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareCommonSRP.__c__DisplayClass22_0.NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001A19 RID: 6681 RVA: 0x0000D0EB File Offset: 0x0000B2EB
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0006C59C File Offset: 0x0006A79C
			// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
			public unsafe LensFlareComponentSRP data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass22_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareComponentSRP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass22_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeMethodInfoPtr__RemoveData_b__0_Internal_Boolean_LensFlareCompInfo_0;
		}

		// Token: 0x020001E1 RID: 481
		[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass40_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass40_0
		{
			// Token: 0x06001A1C RID: 6684 RVA: 0x0000D113 File Offset: 0x0000B313
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_0>.NativeClassPtr);
				LensFlareCommonSRP.__c__DisplayClass40_0.NativeFieldInfoPtr_screenPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_0>.NativeClassPtr, "screenPos");
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x0000D147 File Offset: 0x0000B347
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_0>.NativeClassPtr, ref this));
			}

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeFieldInfoPtr_screenPos;

			// Token: 0x040012F5 RID: 4853
			[FieldOffset(0)]
			public Vector2 screenPos;
		}

		// Token: 0x020001E2 RID: 482
		[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass40_1")]
		public sealed class __c__DisplayClass40_1 : ValueType
		{
			// Token: 0x06001A1E RID: 6686 RVA: 0x0000D159 File Offset: 0x0000B359
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_1()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass40_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_1>.NativeClassPtr);
				LensFlareCommonSRP.__c__DisplayClass40_1.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_1>.NativeClassPtr, "element");
			}

			// Token: 0x06001A1F RID: 6687 RVA: 0x0000D18D File Offset: 0x0000B38D
			public __c__DisplayClass40_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A20 RID: 6688 RVA: 0x0000D196 File Offset: 0x0000B396
			public __c__DisplayClass40_1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_1>.NativeClassPtr))
			{
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0006C5CC File Offset: 0x0006A7CC
			// (set) Token: 0x06001A22 RID: 6690 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
			public unsafe LensFlareDataElementSRP element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass40_1.NativeFieldInfoPtr_element);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareDataElementSRP>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareCommonSRP.__c__DisplayClass40_1.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeFieldInfoPtr_element;
		}

		// Token: 0x020001E3 RID: 483
		[ObfuscatedName("UnityEngine.Rendering.LensFlareCommonSRP+<>c__DisplayClass40_2")]
		[StructLayout(2)]
		public struct __c__DisplayClass40_2
		{
			// Token: 0x06001A23 RID: 6691 RVA: 0x0006C5FC File Offset: 0x0006A7FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_2()
			{
				Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LensFlareCommonSRP>.NativeClassPtr, "<>c__DisplayClass40_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr);
				LensFlareCommonSRP.__c__DisplayClass40_2.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, "position");
				LensFlareCommonSRP.__c__DisplayClass40_2.NativeFieldInfoPtr_globalCos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, "globalCos0");
				LensFlareCommonSRP.__c__DisplayClass40_2.NativeFieldInfoPtr_globalSin0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, "globalSin0");
				LensFlareCommonSRP.__c__DisplayClass40_2.NativeFieldInfoPtr_combinedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, "combinedScale");
				LensFlareCommonSRP.__c__DisplayClass40_2.NativeFieldInfoPtr_usedAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, "usedAspectRatio");
			}

			// Token: 0x06001A24 RID: 6692 RVA: 0x0000D1C7 File Offset: 0x0000B3C7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LensFlareCommonSRP.__c__DisplayClass40_2>.NativeClassPtr, ref this));
			}

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeFieldInfoPtr_globalCos0;

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeFieldInfoPtr_globalSin0;

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeFieldInfoPtr_combinedScale;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeFieldInfoPtr_usedAspectRatio;

			// Token: 0x040012FC RID: 4860
			[FieldOffset(0)]
			public float position;

			// Token: 0x040012FD RID: 4861
			[FieldOffset(4)]
			public float globalCos0;

			// Token: 0x040012FE RID: 4862
			[FieldOffset(8)]
			public float globalSin0;

			// Token: 0x040012FF RID: 4863
			[FieldOffset(12)]
			public float combinedScale;

			// Token: 0x04001300 RID: 4864
			[FieldOffset(16)]
			public float usedAspectRatio;
		}
	}
}
