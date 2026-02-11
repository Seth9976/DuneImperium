using System;
using dwd.core.direction;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000033 RID: 51
public static class BoundsUtil : global::Il2CppSystem.Object
{
	// Token: 0x0600046D RID: 1133 RVA: 0x00024CD4 File Offset: 0x00022ED4
	// Note: this type is marked as 'beforefieldinit'.
	static BoundsUtil()
	{
		Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "BoundsUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr);
		BoundsUtil.NativeMethodInfoPtr_localPositionRelativeToAnchor_Private_Static_Vector3_Bounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663926);
		BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663927);
		BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663928);
		BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663929);
		BoundsUtil.NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_MonoBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663930);
		BoundsUtil.NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_GlobalTransform_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663931);
		BoundsUtil.NativeMethodInfoPtr_GetCorners_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663932);
		BoundsUtil.NativeMethodInfoPtr_GetCorners_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663933);
		BoundsUtil.NativeMethodInfoPtr_GetCorners2D_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663934);
		BoundsUtil.NativeMethodInfoPtr_GetCorners2D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663935);
		BoundsUtil.NativeMethodInfoPtr_GetCorners3D_Public_Static_Il2CppStructArray_1_Vector3_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663936);
		BoundsUtil.NativeMethodInfoPtr_GetCorners3D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, 100663937);
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x00024DF4 File Offset: 0x00022FF4
	[CallerCount(0)]
	public unsafe static Vector3 localPositionRelativeToAnchor(Bounds bounds, Vector3 direction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_localPositionRelativeToAnchor_Private_Static_Vector3_Bounds_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x00024E40 File Offset: 0x00023040
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856713, XrefRangeEnd = 856714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 LocalPositionRelativeToAnchor(Bounds bounds, Direction direction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x00024E8C File Offset: 0x0002308C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856714, XrefRangeEnd = 856715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 LocalPositionRelativeToAnchor(Bounds bounds, Direction2 direction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00024ED8 File Offset: 0x000230D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856715, XrefRangeEnd = 856716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 LocalPositionRelativeToAnchor(Bounds bounds, Direction3 direction)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00024F24 File Offset: 0x00023124
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856716, XrefRangeEnd = 856726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds LocalToGlobalBounds(MonoBounds bounds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_MonoBounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00024F68 File Offset: 0x00023168
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856732, RefRangeEnd = 856733, XrefRangeStart = 856726, XrefRangeEnd = 856732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds LocalToGlobalBounds(GlobalTransform transform, Bounds bounds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref transform;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_GlobalTransform_Bounds_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00024FB4 File Offset: 0x000231B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856733, XrefRangeEnd = 856737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetCorners(this Bounds bounds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00024FF4 File Offset: 0x000231F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856737, XrefRangeEnd = 856738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCorners(this Bounds bounds, ref Il2CppStructArray<Vector2> points)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(points);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		points = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector2>(intPtr4));
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00025050 File Offset: 0x00023250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetCorners2D(this Bounds bounds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners2D_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00025090 File Offset: 0x00023290
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 856738, RefRangeEnd = 856741, XrefRangeStart = 856738, XrefRangeEnd = 856738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCorners2D(this Bounds bounds, ref Il2CppStructArray<Vector2> points)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(points);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners2D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		points = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector2>(intPtr4));
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x000250EC File Offset: 0x000232EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856741, XrefRangeEnd = 856745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetCorners3D(this Bounds bounds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners3D_Public_Static_Il2CppStructArray_1_Vector3_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x0002512C File Offset: 0x0002332C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856745, RefRangeEnd = 856747, XrefRangeStart = 856745, XrefRangeEnd = 856745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetCorners3D(this Bounds bounds, ref Il2CppStructArray<Vector3> points)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bounds;
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(points);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.NativeMethodInfoPtr_GetCorners3D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		points = ((intPtr4 == 0) ? null : new Il2CppStructArray<Vector3>(intPtr4));
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00003AF6 File Offset: 0x00001CF6
	public BoundsUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400033C RID: 828
	private static readonly IntPtr NativeMethodInfoPtr_localPositionRelativeToAnchor_Private_Static_Vector3_Bounds_Vector3_0;

	// Token: 0x0400033D RID: 829
	private static readonly IntPtr NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction_0;

	// Token: 0x0400033E RID: 830
	private static readonly IntPtr NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction2_0;

	// Token: 0x0400033F RID: 831
	private static readonly IntPtr NativeMethodInfoPtr_LocalPositionRelativeToAnchor_Public_Static_Vector3_Bounds_Direction3_0;

	// Token: 0x04000340 RID: 832
	private static readonly IntPtr NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_MonoBounds_0;

	// Token: 0x04000341 RID: 833
	private static readonly IntPtr NativeMethodInfoPtr_LocalToGlobalBounds_Public_Static_Bounds_GlobalTransform_Bounds_0;

	// Token: 0x04000342 RID: 834
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0;

	// Token: 0x04000343 RID: 835
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0;

	// Token: 0x04000344 RID: 836
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners2D_Public_Static_Il2CppStructArray_1_Vector2_Bounds_0;

	// Token: 0x04000345 RID: 837
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners2D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector2_0;

	// Token: 0x04000346 RID: 838
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners3D_Public_Static_Il2CppStructArray_1_Vector3_Bounds_0;

	// Token: 0x04000347 RID: 839
	private static readonly IntPtr NativeMethodInfoPtr_GetCorners3D_Public_Static_Void_Bounds_byref_Il2CppStructArray_1_Vector3_0;

	// Token: 0x0200023E RID: 574
	public sealed class BoundsComparer : EqualityComparer<Bounds>
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x0008BA08 File Offset: 0x00089C08
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsComparer()
		{
			Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoundsUtil>.NativeClassPtr, "BoundsComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr);
			BoundsUtil.BoundsComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr, "Default");
			BoundsUtil.BoundsComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr, 100663938);
			BoundsUtil.BoundsComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr, 100663939);
			BoundsUtil.BoundsComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr, 100663940);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0008BA84 File Offset: 0x00089C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856704, XrefRangeEnd = 856707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoundsComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsUtil.BoundsComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.BoundsComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0008BAC0 File Offset: 0x00089CC0
		[CallerCount(0)]
		public unsafe override bool Equals(Bounds x, Bounds y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.BoundsComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Bounds_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0008BB18 File Offset: 0x00089D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856707, XrefRangeEnd = 856713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(Bounds obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsUtil.BoundsComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0000D170 File Offset: 0x0000B370
		public BoundsComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0008BB64 File Offset: 0x00089D64
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0000D179 File Offset: 0x0000B379
		public new unsafe static BoundsUtil.BoundsComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BoundsUtil.BoundsComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoundsUtil.BoundsComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoundsUtil.BoundsComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Bounds_Bounds_0;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Bounds_0;
	}
}
