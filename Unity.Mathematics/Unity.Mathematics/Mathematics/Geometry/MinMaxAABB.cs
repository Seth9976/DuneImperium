using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics.Geometry
{
	// Token: 0x0200004B RID: 75
	[Serializable]
	[StructLayout(2)]
	public struct MinMaxAABB
	{
		// Token: 0x06002578 RID: 9592 RVA: 0x000C1E90 File Offset: 0x000C0090
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxAABB()
		{
			Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics.Geometry", "MinMaxAABB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr);
			MinMaxAABB.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, "Min");
			MinMaxAABB.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, "Max");
			MinMaxAABB.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672599);
			MinMaxAABB.NativeMethodInfoPtr_CreateFromCenterAndExtents_Public_Static_MinMaxAABB_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672600);
			MinMaxAABB.NativeMethodInfoPtr_CreateFromCenterAndHalfExtents_Public_Static_MinMaxAABB_float3_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672601);
			MinMaxAABB.NativeMethodInfoPtr_get_Extents_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672602);
			MinMaxAABB.NativeMethodInfoPtr_get_HalfExtents_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672603);
			MinMaxAABB.NativeMethodInfoPtr_get_Center_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672604);
			MinMaxAABB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672605);
			MinMaxAABB.NativeMethodInfoPtr_get_SurfaceArea_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672606);
			MinMaxAABB.NativeMethodInfoPtr_Contains_Public_Boolean_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672607);
			MinMaxAABB.NativeMethodInfoPtr_Contains_Public_Boolean_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672608);
			MinMaxAABB.NativeMethodInfoPtr_Overlaps_Public_Boolean_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672609);
			MinMaxAABB.NativeMethodInfoPtr_Expand_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672610);
			MinMaxAABB.NativeMethodInfoPtr_Encapsulate_Public_Void_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672611);
			MinMaxAABB.NativeMethodInfoPtr_Encapsulate_Public_Void_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672612);
			MinMaxAABB.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxAABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672613);
			MinMaxAABB.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, 100672614);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000C2028 File Offset: 0x000C0228
		[CallerCount(0)]
		public unsafe MinMaxAABB(float3 min, float3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000C2068 File Offset: 0x000C0268
		[CallerCount(0)]
		public unsafe static MinMaxAABB CreateFromCenterAndExtents(float3 center, float3 extents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_CreateFromCenterAndExtents_Public_Static_MinMaxAABB_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000C20B4 File Offset: 0x000C02B4
		[CallerCount(0)]
		public unsafe static MinMaxAABB CreateFromCenterAndHalfExtents(float3 center, float3 halfExtents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref halfExtents;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_CreateFromCenterAndHalfExtents_Public_Static_MinMaxAABB_float3_float3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000C2100 File Offset: 0x000C0300
		public unsafe float3 Extents
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_get_Extents_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600257D RID: 9597 RVA: 0x000C2130 File Offset: 0x000C0330
		public unsafe float3 HalfExtents
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_get_HalfExtents_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000C2160 File Offset: 0x000C0360
		public unsafe float3 Center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_get_Center_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000C2190 File Offset: 0x000C0390
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000C21C0 File Offset: 0x000C03C0
		public unsafe float SurfaceArea
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_get_SurfaceArea_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000C21F0 File Offset: 0x000C03F0
		[CallerCount(0)]
		public unsafe bool Contains(float3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Contains_Public_Boolean_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000C2230 File Offset: 0x000C0430
		[CallerCount(0)]
		public unsafe bool Contains(MinMaxAABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aabb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Contains_Public_Boolean_MinMaxAABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000C2270 File Offset: 0x000C0470
		[CallerCount(0)]
		public unsafe bool Overlaps(MinMaxAABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aabb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Overlaps_Public_Boolean_MinMaxAABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000C22B0 File Offset: 0x000C04B0
		[CallerCount(0)]
		public unsafe void Expand(float signedDistance)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref signedDistance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Expand_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000C22E4 File Offset: 0x000C04E4
		[CallerCount(0)]
		public unsafe void Encapsulate(MinMaxAABB aabb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aabb;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Encapsulate_Public_Void_MinMaxAABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000C2318 File Offset: 0x000C0518
		[CallerCount(0)]
		public unsafe void Encapsulate(float3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Encapsulate_Public_Void_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x000C234C File Offset: 0x000C054C
		[CallerCount(0)]
		public unsafe bool Equals(MinMaxAABB other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxAABB_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x000C238C File Offset: 0x000C058C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642814, XrefRangeEnd = 642822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxAABB.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00002AB7 File Offset: 0x00000CB7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxAABB>.NativeClassPtr, ref this));
		}

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float3_float3_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromCenterAndExtents_Public_Static_MinMaxAABB_float3_float3_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromCenterAndHalfExtents_Public_Static_MinMaxAABB_float3_float3_0;

		// Token: 0x04002617 RID: 9751
		private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_float3_0;

		// Token: 0x04002618 RID: 9752
		private static readonly IntPtr NativeMethodInfoPtr_get_HalfExtents_Public_get_float3_0;

		// Token: 0x04002619 RID: 9753
		private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_float3_0;

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr_get_SurfaceArea_Public_get_Single_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_float3_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_MinMaxAABB_0;

		// Token: 0x0400261E RID: 9758
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_MinMaxAABB_0;

		// Token: 0x0400261F RID: 9759
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Void_Single_0;

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_MinMaxAABB_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_float3_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MinMaxAABB_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002624 RID: 9764
		[FieldOffset(0)]
		public float3 Min;

		// Token: 0x04002625 RID: 9765
		[FieldOffset(12)]
		public float3 Max;
	}
}
