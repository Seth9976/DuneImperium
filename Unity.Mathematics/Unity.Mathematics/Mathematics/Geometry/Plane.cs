using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics.Geometry
{
	// Token: 0x0200004D RID: 77
	[Serializable]
	[StructLayout(2)]
	public struct Plane
	{
		// Token: 0x0600258F RID: 9615 RVA: 0x000C2508 File Offset: 0x000C0708
		// Note: this type is marked as 'beforefieldinit'.
		static Plane()
		{
			Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics.Geometry", "Plane");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
			Plane.NativeFieldInfoPtr_NormalAndDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "NormalAndDistance");
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672618);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672619);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672620);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672621);
			Plane.NativeMethodInfoPtr_CreateFromUnitNormalAndDistance_Public_Static_Plane_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672622);
			Plane.NativeMethodInfoPtr_CreateFromUnitNormalAndPointInPlane_Public_Static_Plane_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672623);
			Plane.NativeMethodInfoPtr_get_Normal_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672624);
			Plane.NativeMethodInfoPtr_set_Normal_Public_set_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672625);
			Plane.NativeMethodInfoPtr_get_Distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672626);
			Plane.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672627);
			Plane.NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672628);
			Plane.NativeMethodInfoPtr_Normalize_Public_Static_float4_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672629);
			Plane.NativeMethodInfoPtr_SignedDistanceToPoint_Public_Single_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672630);
			Plane.NativeMethodInfoPtr_Projection_Public_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672631);
			Plane.NativeMethodInfoPtr_get_Flipped_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672632);
			Plane.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672633);
			Plane.NativeMethodInfoPtr_CheckPlaneIsNormalized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100672634);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x000C26A0 File Offset: 0x000C08A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642835, XrefRangeEnd = 642836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(float coefficientA, float coefficientB, float coefficientC, float coefficientD)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref coefficientA;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficientB;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficientC;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coefficientD;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x000C26FC File Offset: 0x000C08FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642837, RefRangeEnd = 642839, XrefRangeStart = 642836, XrefRangeEnd = 642837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(float3 normal, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x000C273C File Offset: 0x000C093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642839, XrefRangeEnd = 642840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(float3 normal, float3 pointInPlane)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointInPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000C277C File Offset: 0x000C097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642840, XrefRangeEnd = 642841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vector1InPlane;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector2InPlane;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointInPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000C27CC File Offset: 0x000C09CC
		[CallerCount(0)]
		public unsafe static Plane CreateFromUnitNormalAndDistance(float3 unitNormal, float distance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unitNormal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_CreateFromUnitNormalAndDistance_Public_Static_Plane_float3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000C2818 File Offset: 0x000C0A18
		[CallerCount(0)]
		public unsafe static Plane CreateFromUnitNormalAndPointInPlane(float3 unitNormal, float3 pointInPlane)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unitNormal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointInPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_CreateFromUnitNormalAndPointInPlane_Public_Static_Plane_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000C2864 File Offset: 0x000C0A64
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x000C2894 File Offset: 0x000C0A94
		public unsafe float3 Normal
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_Normal_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_set_Normal_Public_set_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000C28C8 File Offset: 0x000C0AC8
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x000C28F8 File Offset: 0x000C0AF8
		public unsafe float Distance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_Distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642841, RefRangeEnd = 642843, XrefRangeStart = 642841, XrefRangeEnd = 642841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000C292C File Offset: 0x000C0B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642843, XrefRangeEnd = 642844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane Normalize(Plane plane)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref plane;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000C296C File Offset: 0x000C0B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642844, XrefRangeEnd = 642845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float4 Normalize(float4 planeCoefficients)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref planeCoefficients;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Normalize_Public_Static_float4_float4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000C29AC File Offset: 0x000C0BAC
		[CallerCount(0)]
		public unsafe float SignedDistanceToPoint(float3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_SignedDistanceToPoint_Public_Single_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000C29EC File Offset: 0x000C0BEC
		[CallerCount(0)]
		public unsafe float3 Projection(float3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Projection_Public_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000C2A2C File Offset: 0x000C0C2C
		public unsafe Plane Flipped
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_Flipped_Public_get_Plane_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000C2A5C File Offset: 0x000C0C5C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float4(Plane plane)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref plane;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Plane_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x000C2A9C File Offset: 0x000C0C9C
		[CallerCount(0)]
		public unsafe void CheckPlaneIsNormalized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_CheckPlaneIsNormalized_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00002AD2 File Offset: 0x00000CD2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, ref this));
		}

		// Token: 0x04002629 RID: 9769
		private static readonly IntPtr NativeFieldInfoPtr_NormalAndDistance;

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_Single_0;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_float3_0;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromUnitNormalAndDistance_Public_Static_Plane_float3_Single_0;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromUnitNormalAndPointInPlane_Public_Static_Plane_float3_float3_0;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_float3_0;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeMethodInfoPtr_set_Normal_Public_set_Void_float3_0;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_Single_0;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Plane_Plane_0;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_float4_float4_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_SignedDistanceToPoint_Public_Single_float3_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_Projection_Public_float3_float3_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_get_Flipped_Public_get_Plane_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float4_Plane_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlaneIsNormalized_Private_Void_0;

		// Token: 0x0400263B RID: 9787
		[FieldOffset(0)]
		public float4 NormalAndDistance;
	}
}
