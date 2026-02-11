using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000CC RID: 204
	[Serializable]
	[StructLayout(2)]
	public struct BitArray128
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x00043E40 File Offset: 0x00042040
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray128()
		{
			Il2CppClassPointerStore<BitArray128>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArray128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray128>.NativeClassPtr);
			BitArray128.NativeFieldInfoPtr_data1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, "data1");
			BitArray128.NativeFieldInfoPtr_data2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, "data2");
			BitArray128.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665444);
			BitArray128.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665445);
			BitArray128.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665446);
			BitArray128.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665447);
			BitArray128.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665448);
			BitArray128.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665449);
			BitArray128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665450);
			BitArray128.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665451);
			BitArray128.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray128_BitArray128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665452);
			BitArray128.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray128_BitArray128_BitArray128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665453);
			BitArray128.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray128_BitArray128_BitArray128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665454);
			BitArray128.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665455);
			BitArray128.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665456);
			BitArray128.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665457);
			BitArray128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray128_BitArray128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665458);
			BitArray128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray128_BitArray128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665459);
			BitArray128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665460);
			BitArray128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, 100665461);
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00044000 File Offset: 0x00042200
		public unsafe uint capacity
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00044030 File Offset: 0x00042230
		public unsafe bool allFalse
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00044060 File Offset: 0x00042260
		public unsafe bool allTrue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00044090 File Offset: 0x00042290
		public unsafe string humanizedData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974950, XrefRangeEnd = 974982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000485 RID: 1157
		public unsafe bool this[uint index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0004413C File Offset: 0x0004233C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray128(ulong initValue1, ulong initValue2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initValue2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0004417C File Offset: 0x0004237C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974982, XrefRangeEnd = 974989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray128(IEnumerable<uint> bitIndexTrue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitIndexTrue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000441B4 File Offset: 0x000423B4
		[CallerCount(0)]
		public unsafe static BitArray128 operator ~(BitArray128 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray128_BitArray128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000441F4 File Offset: 0x000423F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 974989, RefRangeEnd = 974998, XrefRangeStart = 974989, XrefRangeEnd = 974989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BitArray128 operator |(BitArray128 a, BitArray128 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray128_BitArray128_BitArray128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00044240 File Offset: 0x00042440
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 974998, RefRangeEnd = 975008, XrefRangeStart = 974998, XrefRangeEnd = 974998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BitArray128 operator &(BitArray128 a, BitArray128 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray128_BitArray128_BitArray128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0004428C File Offset: 0x0004248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975008, XrefRangeEnd = 975013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitAnd(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000442D0 File Offset: 0x000424D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975013, XrefRangeEnd = 975018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitOr(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00044314 File Offset: 0x00042514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975018, XrefRangeEnd = 975021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitNot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00044348 File Offset: 0x00042548
		[CallerCount(0)]
		public unsafe static bool operator ==(BitArray128 a, BitArray128 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray128_BitArray128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00044394 File Offset: 0x00042594
		[CallerCount(0)]
		public unsafe static bool operator !=(BitArray128 a, BitArray128 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray128_BitArray128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000443E0 File Offset: 0x000425E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975021, XrefRangeEnd = 975028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00044424 File Offset: 0x00042624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975028, XrefRangeEnd = 975030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0000843A File Offset: 0x0000663A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitArray128>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeFieldInfoPtr_data1;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeFieldInfoPtr_data2;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray128_BitArray128_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray128_BitArray128_BitArray128_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray128_BitArray128_BitArray128_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray128_BitArray128_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray128_BitArray128_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B45 RID: 2885
		[FieldOffset(0)]
		public ulong data1;

		// Token: 0x04000B46 RID: 2886
		[FieldOffset(8)]
		public ulong data2;
	}
}
