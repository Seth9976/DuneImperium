using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000E1 RID: 225
	public sealed class TilingJob : ValueType
	{
		// Token: 0x0600110B RID: 4363 RVA: 0x00050A00 File Offset: 0x0004EC00
		// Note: this type is marked as 'beforefieldinit'.
		static TilingJob()
		{
			Il2CppClassPointerStore<TilingJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TilingJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilingJob>.NativeClassPtr);
			TilingJob.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "lights");
			TilingJob.NativeFieldInfoPtr_reflectionProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "reflectionProbes");
			TilingJob.NativeFieldInfoPtr_tileRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileRanges");
			TilingJob.NativeFieldInfoPtr_itemsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "itemsPerTile");
			TilingJob.NativeFieldInfoPtr_rangesPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "rangesPerItem");
			TilingJob.NativeFieldInfoPtr_worldToViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "worldToViews");
			TilingJob.NativeFieldInfoPtr_tileScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileScale");
			TilingJob.NativeFieldInfoPtr_tileScaleInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileScaleInv");
			TilingJob.NativeFieldInfoPtr_viewPlaneBottoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewPlaneBottoms");
			TilingJob.NativeFieldInfoPtr_viewPlaneTops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewPlaneTops");
			TilingJob.NativeFieldInfoPtr_viewToViewportScaleBiases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "viewToViewportScaleBiases");
			TilingJob.NativeFieldInfoPtr_tileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "tileCount");
			TilingJob.NativeFieldInfoPtr_near = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "near");
			TilingJob.NativeFieldInfoPtr_isOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "isOrthographic");
			TilingJob.NativeFieldInfoPtr_m_TileYRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_TileYRange");
			TilingJob.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_Offset");
			TilingJob.NativeFieldInfoPtr_m_ViewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_ViewIndex");
			TilingJob.NativeFieldInfoPtr_m_CenterOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "m_CenterOffset");
			TilingJob.NativeFieldInfoPtr_k_CubePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "k_CubePoints");
			TilingJob.NativeFieldInfoPtr_k_CubeLineIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "k_CubeLineIndices");
			TilingJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665477);
			TilingJob.NativeMethodInfoPtr_TileLight_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665478);
			TilingJob.NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665479);
			TilingJob.NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665480);
			TilingJob.NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665481);
			TilingJob.NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665482);
			TilingJob.NativeMethodInfoPtr_ExpandY_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665483);
			TilingJob.NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665484);
			TilingJob.NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665485);
			TilingJob.NativeMethodInfoPtr_square_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665486);
			TilingJob.NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665487);
			TilingJob.NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665488);
			TilingJob.NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665489);
			TilingJob.NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665490);
			TilingJob.NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665491);
			TilingJob.NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665492);
			TilingJob.NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665493);
			TilingJob.NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665494);
			TilingJob.NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665495);
			TilingJob.NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665496);
			TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665498);
			TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665499);
			TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, 100665500);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00050D8C File Offset: 0x0004EF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 617979, XrefRangeEnd = 617991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute(int jobIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00050DD0 File Offset: 0x0004EFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618197, RefRangeEnd = 618198, XrefRangeStart = 617991, XrefRangeEnd = 618197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TileLight(int lightIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_TileLight_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00050E14 File Offset: 0x0004F014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618306, RefRangeEnd = 618307, XrefRangeStart = 618198, XrefRangeEnd = 618306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TileLightOrthographic(int lightIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00050E58 File Offset: 0x0004F058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618368, RefRangeEnd = 618369, XrefRangeStart = 618307, XrefRangeEnd = 618368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TileReflectionProbe(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00050E9C File Offset: 0x0004F09C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 618374, RefRangeEnd = 618384, XrefRangeStart = 618369, XrefRangeEnd = 618374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 ViewToTileSpace(float3 positionVS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionVS;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00050EEC File Offset: 0x0004F0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 618389, RefRangeEnd = 618392, XrefRangeStart = 618384, XrefRangeEnd = 618389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2 ViewToTileSpaceOrthographic(float3 positionVS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionVS;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00050F3C File Offset: 0x0004F13C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 618398, RefRangeEnd = 618416, XrefRangeStart = 618392, XrefRangeEnd = 618398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandY(float3 positionVS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionVS;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_ExpandY_Private_Void_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00050F80 File Offset: 0x0004F180
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 618422, RefRangeEnd = 618431, XrefRangeStart = 618416, XrefRangeEnd = 618422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandOrthographic(float3 positionVS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref positionVS;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00050FC4 File Offset: 0x0004F1C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 618436, RefRangeEnd = 618442, XrefRangeStart = 618431, XrefRangeEnd = 618436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandRangeOrthographic(ref InclusiveRange range, float xVS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &range;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xVS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00051018 File Offset: 0x0004F218
		[CallerCount(101)]
		[CachedScanResults(RefRangeStart = 618442, RefRangeEnd = 618543, XrefRangeStart = 618442, XrefRangeEnd = 618442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float square(float x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_square_Private_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00051058 File Offset: 0x0004F258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618555, RefRangeEnd = 618557, XrefRangeStart = 618543, XrefRangeEnd = 618555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p0;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x000510D4 File Offset: 0x0004F2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618580, RefRangeEnd = 618581, XrefRangeStart = 618557, XrefRangeEnd = 618580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clipRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &left;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005115C File Offset: 0x0004F35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618588, RefRangeEnd = 618589, XrefRangeStart = 618581, XrefRangeEnd = 618588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref circleCenter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleNormal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref near;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p0;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x000511E4 File Offset: 0x0004F3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618601, RefRangeEnd = 618602, XrefRangeStart = 618589, XrefRangeEnd = 618601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<float, float> IntersectEllipseLine(float a, float b, float3 line)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<float, float>(intPtr);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00051238 File Offset: 0x0004F438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618611, RefRangeEnd = 618613, XrefRangeStart = 618602, XrefRangeEnd = 618611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref U;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref V;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uv1;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &uv2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000512B4 File Offset: 0x0004F4B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618616, RefRangeEnd = 618617, XrefRangeStart = 618613, XrefRangeEnd = 618616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleNormal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleU;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleV;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p1;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00051358 File Offset: 0x0004F558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618626, RefRangeEnd = 618627, XrefRangeStart = 618617, XrefRangeEnd = 618626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cosHalfAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleRadius;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneHeight;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleU;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref circleV;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &l1;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &l2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0005140C File Offset: 0x0004F60C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 618643, RefRangeEnd = 618649, XrefRangeStart = 618627, XrefRangeEnd = 618643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref near;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000514A0 File Offset: 0x0004F6A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 618669, RefRangeEnd = 618671, XrefRangeStart = 618649, XrefRangeEnd = 618669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref o;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00051518 File Offset: 0x0004F718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 618726, RefRangeEnd = 618727, XrefRangeStart = 618671, XrefRangeEnd = 618726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref near;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref o;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000515AC File Offset: 0x0004F7AC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 618728, RefRangeEnd = 618740, XrefRangeStart = 618727, XrefRangeEnd = 618728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0(float3 p, ref TilingJob.__c__DisplayClass19_0 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x000515F8 File Offset: 0x0004F7F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 618742, RefRangeEnd = 618748, XrefRangeStart = 618740, XrefRangeEnd = 618742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1(float3 p, ref TilingJob.__c__DisplayClass19_0 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00051644 File Offset: 0x0004F844
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 618728, RefRangeEnd = 618740, XrefRangeStart = 618728, XrefRangeEnd = 618740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0(float3 p, ref TilingJob.__c__DisplayClass20_0 A_1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &A_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TilingJob.NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0000A284 File Offset: 0x00008484
		public TilingJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0000A28D File Offset: 0x0000848D
		public TilingJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TilingJob>.NativeClassPtr))
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00051690 File Offset: 0x0004F890
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x0000A29F File Offset: 0x0000849F
		public NativeArray<VisibleLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_lights);
				return new NativeArray<VisibleLight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_lights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleLight>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x000516C0 File Offset: 0x0004F8C0
		// (set) Token: 0x06001128 RID: 4392 RVA: 0x0000A2CD File Offset: 0x000084CD
		public NativeArray<VisibleReflectionProbe> reflectionProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_reflectionProbes);
				return new NativeArray<VisibleReflectionProbe>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_reflectionProbes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VisibleReflectionProbe>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x000516F0 File Offset: 0x0004F8F0
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x0000A2FB File Offset: 0x000084FB
		public NativeArray<InclusiveRange> tileRanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileRanges);
				return new NativeArray<InclusiveRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InclusiveRange>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x00051720 File Offset: 0x0004F920
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0000A329 File Offset: 0x00008529
		public unsafe int itemsPerTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_itemsPerTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_itemsPerTile)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00051748 File Offset: 0x0004F948
		// (set) Token: 0x0600112E RID: 4398 RVA: 0x0000A344 File Offset: 0x00008544
		public unsafe int rangesPerItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_rangesPerItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_rangesPerItem)) = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00051770 File Offset: 0x0004F970
		// (set) Token: 0x06001130 RID: 4400 RVA: 0x0000A35F File Offset: 0x0000855F
		public Fixed2<float4x4> worldToViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_worldToViews);
				return new Fixed2<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_worldToViews), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x000517A0 File Offset: 0x0004F9A0
		// (set) Token: 0x06001132 RID: 4402 RVA: 0x0000A38D File Offset: 0x0000858D
		public unsafe float2 tileScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileScale)) = value;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x000517C8 File Offset: 0x0004F9C8
		// (set) Token: 0x06001134 RID: 4404 RVA: 0x0000A3A8 File Offset: 0x000085A8
		public unsafe float2 tileScaleInv
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileScaleInv);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileScaleInv)) = value;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x000517F0 File Offset: 0x0004F9F0
		// (set) Token: 0x06001136 RID: 4406 RVA: 0x0000A3C3 File Offset: 0x000085C3
		public Fixed2<float> viewPlaneBottoms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewPlaneBottoms);
				return new Fixed2<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewPlaneBottoms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00051820 File Offset: 0x0004FA20
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0000A3F1 File Offset: 0x000085F1
		public Fixed2<float> viewPlaneTops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewPlaneTops);
				return new Fixed2<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewPlaneTops), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x00051850 File Offset: 0x0004FA50
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0000A41F File Offset: 0x0000861F
		public Fixed2<float4> viewToViewportScaleBiases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewToViewportScaleBiases);
				return new Fixed2<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Fixed2<float4>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_viewToViewportScaleBiases), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Fixed2<float4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x00051880 File Offset: 0x0004FA80
		// (set) Token: 0x0600113C RID: 4412 RVA: 0x0000A44D File Offset: 0x0000864D
		public unsafe int2 tileCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_tileCount)) = value;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x000518A8 File Offset: 0x0004FAA8
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0000A468 File Offset: 0x00008668
		public unsafe float near
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_near);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_near)) = value;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x000518D0 File Offset: 0x0004FAD0
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0000A483 File Offset: 0x00008683
		public unsafe bool isOrthographic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_isOrthographic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_isOrthographic)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x000518F8 File Offset: 0x0004FAF8
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0000A49E File Offset: 0x0000869E
		public unsafe InclusiveRange m_TileYRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_TileYRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_TileYRange)) = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00051920 File Offset: 0x0004FB20
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0000A4B9 File Offset: 0x000086B9
		public unsafe int m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00051948 File Offset: 0x0004FB48
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public unsafe int m_ViewIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_ViewIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_ViewIndex)) = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00051970 File Offset: 0x0004FB70
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0000A4EF File Offset: 0x000086EF
		public unsafe float2 m_CenterOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_CenterOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TilingJob.NativeFieldInfoPtr_m_CenterOffset)) = value;
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00051998 File Offset: 0x0004FB98
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x0000A50A File Offset: 0x0000870A
		public unsafe static Il2CppStructArray<float3> k_CubePoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TilingJob.NativeFieldInfoPtr_k_CubePoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TilingJob.NativeFieldInfoPtr_k_CubePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x000519C0 File Offset: 0x0004FBC0
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x0000A51C File Offset: 0x0000871C
		public unsafe static Il2CppStructArray<int4> k_CubeLineIndices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TilingJob.NativeFieldInfoPtr_k_CubeLineIndices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int4>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TilingJob.NativeFieldInfoPtr_k_CubeLineIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbes;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeFieldInfoPtr_tileRanges;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeFieldInfoPtr_itemsPerTile;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeFieldInfoPtr_rangesPerItem;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_worldToViews;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_tileScale;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeFieldInfoPtr_tileScaleInv;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeFieldInfoPtr_viewPlaneBottoms;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeFieldInfoPtr_viewPlaneTops;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeFieldInfoPtr_viewToViewportScaleBiases;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeFieldInfoPtr_tileCount;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeFieldInfoPtr_near;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeFieldInfoPtr_isOrthographic;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeFieldInfoPtr_m_TileYRange;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewIndex;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeFieldInfoPtr_m_CenterOffset;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_k_CubePoints;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_k_CubeLineIndices;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_TileLight_Private_Void_Int32_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_TileLightOrthographic_Private_Void_Int32_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_TileReflectionProbe_Private_Void_Int32_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_ViewToTileSpace_Private_float2_float3_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr_ViewToTileSpaceOrthographic_Private_float2_float3_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr_ExpandY_Private_Void_float3_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_ExpandOrthographic_Private_Void_float3_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_ExpandRangeOrthographic_Private_Void_byref_InclusiveRange_Single_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_square_Private_Static_Single_Single_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_GetSphereHorizon_Private_Static_Void_float2_Single_Single_Single_byref_float2_byref_float2_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_GetSphereYPlaneHorizon_Private_Static_Void_float3_Single_Single_Single_Single_byref_float3_byref_float3_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr_GetCircleClipPoints_Private_Static_Boolean_float3_float3_Single_Single_byref_float3_byref_float3_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_IntersectEllipseLine_Private_Static_ValueTuple_2_Single_Single_Single_Single_float3_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_GetProjectedCircleHorizon_Private_Static_Void_float2_Single_float2_float2_byref_float2_byref_float2_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_IntersectCircleYPlane_Private_Static_Boolean_Single_float3_float3_float3_float3_Single_byref_float3_byref_float3_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_GetConeSideTangentPoints_Private_Static_Void_float3_float3_Single_Single_Single_Single_float3_float3_byref_float3_byref_float3_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateNearConic_Private_Static_float3_Single_float3_float3_Single_float3_float3_Single_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_FindNearConicTangentTheta_Private_Static_float2_float2_float2_Single_float2_float2_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_FindNearConicYTheta_Private_Static_float2_Single_float3_float3_Single_float3_float3_Single_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass19_0_1;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_float3_byref___c__DisplayClass20_0_0;

		// Token: 0x020001C5 RID: 453
		[ObfuscatedName("UnityEngine.Rendering.Universal.TilingJob+<>c__DisplayClass19_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass19_0
		{
			// Token: 0x06002056 RID: 8278 RVA: 0x0007E5AC File Offset: 0x0007C7AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr);
				TilingJob.__c__DisplayClass19_0.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, "light");
				TilingJob.__c__DisplayClass19_0.NativeFieldInfoPtr_lightPositionVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, "lightPositionVS");
				TilingJob.__c__DisplayClass19_0.NativeFieldInfoPtr_lightDirectionVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, "lightDirectionVS");
				TilingJob.__c__DisplayClass19_0.NativeFieldInfoPtr_cosHalfAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, "cosHalfAngle");
				TilingJob.__c__DisplayClass19_0.NativeFieldInfoPtr_coneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, "coneHeight");
			}

			// Token: 0x06002057 RID: 8279 RVA: 0x00012808 File Offset: 0x00010A08
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TilingJob.__c__DisplayClass19_0>.NativeClassPtr, ref this));
			}

			// Token: 0x040016FF RID: 5887
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x04001700 RID: 5888
			private static readonly IntPtr NativeFieldInfoPtr_lightPositionVS;

			// Token: 0x04001701 RID: 5889
			private static readonly IntPtr NativeFieldInfoPtr_lightDirectionVS;

			// Token: 0x04001702 RID: 5890
			private static readonly IntPtr NativeFieldInfoPtr_cosHalfAngle;

			// Token: 0x04001703 RID: 5891
			private static readonly IntPtr NativeFieldInfoPtr_coneHeight;

			// Token: 0x04001704 RID: 5892
			[FieldOffset(0)]
			public VisibleLight light;

			// Token: 0x04001705 RID: 5893
			[FieldOffset(116)]
			public float3 lightPositionVS;

			// Token: 0x04001706 RID: 5894
			[FieldOffset(128)]
			public float3 lightDirectionVS;

			// Token: 0x04001707 RID: 5895
			[FieldOffset(140)]
			public float cosHalfAngle;

			// Token: 0x04001708 RID: 5896
			[FieldOffset(144)]
			public float coneHeight;
		}

		// Token: 0x020001C6 RID: 454
		[ObfuscatedName("UnityEngine.Rendering.Universal.TilingJob+<>c__DisplayClass20_0")]
		[StructLayout(2)]
		public struct __c__DisplayClass20_0
		{
			// Token: 0x06002058 RID: 8280 RVA: 0x0007E63C File Offset: 0x0007C83C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TilingJob>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr);
				TilingJob.__c__DisplayClass20_0.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr, "light");
				TilingJob.__c__DisplayClass20_0.NativeFieldInfoPtr_lightPosVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr, "lightPosVS");
				TilingJob.__c__DisplayClass20_0.NativeFieldInfoPtr_lightDirVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr, "lightDirVS");
				TilingJob.__c__DisplayClass20_0.NativeFieldInfoPtr_cosHalfAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr, "cosHalfAngle");
			}

			// Token: 0x06002059 RID: 8281 RVA: 0x0001281A File Offset: 0x00010A1A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TilingJob.__c__DisplayClass20_0>.NativeClassPtr, ref this));
			}

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeFieldInfoPtr_light;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeFieldInfoPtr_lightPosVS;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeFieldInfoPtr_lightDirVS;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeFieldInfoPtr_cosHalfAngle;

			// Token: 0x0400170D RID: 5901
			[FieldOffset(0)]
			public VisibleLight light;

			// Token: 0x0400170E RID: 5902
			[FieldOffset(116)]
			public float3 lightPosVS;

			// Token: 0x0400170F RID: 5903
			[FieldOffset(128)]
			public float3 lightDirVS;

			// Token: 0x04001710 RID: 5904
			[FieldOffset(140)]
			public float cosHalfAngle;
		}
	}
}
