using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200005A RID: 90
public static class VectorUtil : global::Il2CppSystem.Object
{
	// Token: 0x0600069B RID: 1691 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
	// Note: this type is marked as 'beforefieldinit'.
	static VectorUtil()
	{
		Il2CppClassPointerStore<VectorUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "VectorUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr);
		VectorUtil.NativeMethodInfoPtr_SquaredDistance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664292);
		VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664293);
		VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664294);
		VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664295);
		VectorUtil.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664296);
		VectorUtil.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664297);
		VectorUtil.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664298);
		VectorUtil.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664299);
		VectorUtil.NativeMethodInfoPtr_Clamp01_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664300);
		VectorUtil.NativeMethodInfoPtr_Clamp01_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664301);
		VectorUtil.NativeMethodInfoPtr_Clamp_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664302);
		VectorUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664303);
		VectorUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664304);
		VectorUtil.NativeMethodInfoPtr_GetTextAnchorOffsetScale_Public_Static_Vector3_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664305);
		VectorUtil.NativeMethodInfoPtr_GetSignedAngleBetweenVectors_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664306);
		VectorUtil.NativeMethodInfoPtr_FaceAlongPlane_Public_Static_Void_Transform_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664307);
		VectorUtil.NativeMethodInfoPtr_PlanePointDistance_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664308);
		VectorUtil.NativeMethodInfoPtr_withX_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664309);
		VectorUtil.NativeMethodInfoPtr_withY_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664310);
		VectorUtil.NativeMethodInfoPtr_plusX_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664311);
		VectorUtil.NativeMethodInfoPtr_plusY_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664312);
		VectorUtil.NativeMethodInfoPtr_withX_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664313);
		VectorUtil.NativeMethodInfoPtr_withY_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664314);
		VectorUtil.NativeMethodInfoPtr_withZ_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664315);
		VectorUtil.NativeMethodInfoPtr_plusX_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664316);
		VectorUtil.NativeMethodInfoPtr_plusY_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664317);
		VectorUtil.NativeMethodInfoPtr_plusZ_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorUtil>.NativeClassPtr, 100664318);
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x0002E704 File Offset: 0x0002C904
	[CallerCount(0)]
	public unsafe static float SquaredDistance(Vector3 a, Vector3 b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_SquaredDistance_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x0002E750 File Offset: 0x0002C950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860276, XrefRangeEnd = 860279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Abs(this Vector2 v)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x0002E790 File Offset: 0x0002C990
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 860282, RefRangeEnd = 860283, XrefRangeStart = 860279, XrefRangeEnd = 860282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Abs(this Vector3 v)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0002E7D0 File Offset: 0x0002C9D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860283, XrefRangeEnd = 860286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 Abs(this Vector4 v)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Abs_Public_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x0002E810 File Offset: 0x0002CA10
	[CallerCount(0)]
	public unsafe static Vector2 ToV2(this float f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x0002E850 File Offset: 0x0002CA50
	[CallerCount(0)]
	public unsafe static Vector3 ToV3(this float f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x0002E890 File Offset: 0x0002CA90
	[CallerCount(0)]
	public unsafe static Vector3 ToV3(this Vector2 v2)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x0002E8D0 File Offset: 0x0002CAD0
	[CallerCount(0)]
	public unsafe static Vector2 ToV2(this Vector3 v3)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x0002E910 File Offset: 0x0002CB10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860286, XrefRangeEnd = 860287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Clamp01(this Vector2 v)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Clamp01_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x0002E950 File Offset: 0x0002CB50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860287, XrefRangeEnd = 860289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Clamp01(this Vector3 v)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Clamp01_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x0002E990 File Offset: 0x0002CB90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 860289, RefRangeEnd = 860291, XrefRangeStart = 860289, XrefRangeEnd = 860289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Clamp(Vector3 input, Vector3 min, Vector3 max)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref input;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Clamp_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0002E9EC File Offset: 0x0002CBEC
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 860292, RefRangeEnd = 860299, XrefRangeStart = 860291, XrefRangeEnd = 860292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(this Vector2 v, Vector2 other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0002EA38 File Offset: 0x0002CC38
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 860302, RefRangeEnd = 860307, XrefRangeStart = 860299, XrefRangeEnd = 860302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Approximately(this Vector3 v, Vector3 other)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref other;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0002EA84 File Offset: 0x0002CC84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860307, XrefRangeEnd = 860309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetTextAnchorOffsetScale(TextAnchor anchor)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_GetTextAnchorOffsetScale_Public_Static_Vector3_TextAnchor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x0002EAC4 File Offset: 0x0002CCC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860309, XrefRangeEnd = 860314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetSignedAngleBetweenVectors(Vector3 fromVector, Vector3 toVector, Vector3 toVectorsRight)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fromVector;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toVector;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toVectorsRight;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_GetSignedAngleBetweenVectors_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006AB RID: 1707 RVA: 0x0002EB20 File Offset: 0x0002CD20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 860314, XrefRangeEnd = 860324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FaceAlongPlane(Transform transform, Vector3 directionToFace, Vector3 destRight, Vector3 originalFacing, Vector3 planeNormal)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref directionToFace;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destRight;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalFacing;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref planeNormal;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_FaceAlongPlane_Public_Static_Void_Transform_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x0002EB90 File Offset: 0x0002CD90
	[CallerCount(0)]
	public unsafe static float PlanePointDistance(Vector3 planeCenter, Vector3 planeNormal, Vector3 point)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref planeCenter;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref planeNormal;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_PlanePointDistance_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x0002EBEC File Offset: 0x0002CDEC
	[CallerCount(0)]
	public unsafe static Vector2 withX(this Vector2 v2, float x)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v2;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_withX_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0002EC38 File Offset: 0x0002CE38
	[CallerCount(0)]
	public unsafe static Vector2 withY(this Vector2 v2, float y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v2;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_withY_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x0002EC84 File Offset: 0x0002CE84
	[CallerCount(0)]
	public unsafe static Vector2 plusX(this Vector2 v2, float x)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v2;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_plusX_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x0002ECD0 File Offset: 0x0002CED0
	[CallerCount(0)]
	public unsafe static Vector2 plusY(this Vector2 v2, float y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v2;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_plusY_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x0002ED1C File Offset: 0x0002CF1C
	[CallerCount(0)]
	public unsafe static Vector3 withX(this Vector3 v3, float x)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_withX_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x0002ED68 File Offset: 0x0002CF68
	[CallerCount(0)]
	public unsafe static Vector3 withY(this Vector3 v3, float y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_withY_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
	[CallerCount(0)]
	public unsafe static Vector3 withZ(this Vector3 v3, float z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_withZ_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x0002EE00 File Offset: 0x0002D000
	[CallerCount(0)]
	public unsafe static Vector3 plusX(this Vector3 v3, float x)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_plusX_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x0002EE4C File Offset: 0x0002D04C
	[CallerCount(0)]
	public unsafe static Vector3 plusY(this Vector3 v3, float y)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_plusY_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x0002EE98 File Offset: 0x0002D098
	[CallerCount(0)]
	public unsafe static Vector3 plusZ(this Vector3 v3, float z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v3;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorUtil.NativeMethodInfoPtr_plusZ_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000042CD File Offset: 0x000024CD
	public VectorUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040004F2 RID: 1266
	private static readonly IntPtr NativeMethodInfoPtr_SquaredDistance_Public_Static_Single_Vector3_Vector3_0;

	// Token: 0x040004F3 RID: 1267
	private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector2_Vector2_0;

	// Token: 0x040004F4 RID: 1268
	private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector3_Vector3_0;

	// Token: 0x040004F5 RID: 1269
	private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Vector4_Vector4_0;

	// Token: 0x040004F6 RID: 1270
	private static readonly IntPtr NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Single_0;

	// Token: 0x040004F7 RID: 1271
	private static readonly IntPtr NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Single_0;

	// Token: 0x040004F8 RID: 1272
	private static readonly IntPtr NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector2_0;

	// Token: 0x040004F9 RID: 1273
	private static readonly IntPtr NativeMethodInfoPtr_ToV2_Public_Static_Vector2_Vector3_0;

	// Token: 0x040004FA RID: 1274
	private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Vector2_Vector2_0;

	// Token: 0x040004FB RID: 1275
	private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Vector3_Vector3_0;

	// Token: 0x040004FC RID: 1276
	private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

	// Token: 0x040004FD RID: 1277
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_0;

	// Token: 0x040004FE RID: 1278
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_0;

	// Token: 0x040004FF RID: 1279
	private static readonly IntPtr NativeMethodInfoPtr_GetTextAnchorOffsetScale_Public_Static_Vector3_TextAnchor_0;

	// Token: 0x04000500 RID: 1280
	private static readonly IntPtr NativeMethodInfoPtr_GetSignedAngleBetweenVectors_Public_Static_Single_Vector3_Vector3_Vector3_0;

	// Token: 0x04000501 RID: 1281
	private static readonly IntPtr NativeMethodInfoPtr_FaceAlongPlane_Public_Static_Void_Transform_Vector3_Vector3_Vector3_Vector3_0;

	// Token: 0x04000502 RID: 1282
	private static readonly IntPtr NativeMethodInfoPtr_PlanePointDistance_Public_Static_Single_Vector3_Vector3_Vector3_0;

	// Token: 0x04000503 RID: 1283
	private static readonly IntPtr NativeMethodInfoPtr_withX_Public_Static_Vector2_Vector2_Single_0;

	// Token: 0x04000504 RID: 1284
	private static readonly IntPtr NativeMethodInfoPtr_withY_Public_Static_Vector2_Vector2_Single_0;

	// Token: 0x04000505 RID: 1285
	private static readonly IntPtr NativeMethodInfoPtr_plusX_Public_Static_Vector2_Vector2_Single_0;

	// Token: 0x04000506 RID: 1286
	private static readonly IntPtr NativeMethodInfoPtr_plusY_Public_Static_Vector2_Vector2_Single_0;

	// Token: 0x04000507 RID: 1287
	private static readonly IntPtr NativeMethodInfoPtr_withX_Public_Static_Vector3_Vector3_Single_0;

	// Token: 0x04000508 RID: 1288
	private static readonly IntPtr NativeMethodInfoPtr_withY_Public_Static_Vector3_Vector3_Single_0;

	// Token: 0x04000509 RID: 1289
	private static readonly IntPtr NativeMethodInfoPtr_withZ_Public_Static_Vector3_Vector3_Single_0;

	// Token: 0x0400050A RID: 1290
	private static readonly IntPtr NativeMethodInfoPtr_plusX_Public_Static_Vector3_Vector3_Single_0;

	// Token: 0x0400050B RID: 1291
	private static readonly IntPtr NativeMethodInfoPtr_plusY_Public_Static_Vector3_Vector3_Single_0;

	// Token: 0x0400050C RID: 1292
	private static readonly IntPtr NativeMethodInfoPtr_plusZ_Public_Static_Vector3_Vector3_Single_0;
}
