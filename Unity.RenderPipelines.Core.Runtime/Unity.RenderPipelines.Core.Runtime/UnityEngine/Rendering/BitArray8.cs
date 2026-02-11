using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C8 RID: 200
	[Serializable]
	[StructLayout(2)]
	public struct BitArray8
	{
		// Token: 0x06000E71 RID: 3697 RVA: 0x00042630 File Offset: 0x00040830
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray8()
		{
			Il2CppClassPointerStore<BitArray8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArray8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray8>.NativeClassPtr);
			BitArray8.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, "data");
			BitArray8.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665371);
			BitArray8.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665372);
			BitArray8.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665373);
			BitArray8.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665374);
			BitArray8.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665375);
			BitArray8.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665376);
			BitArray8.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665377);
			BitArray8.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665378);
			BitArray8.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray8_BitArray8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665379);
			BitArray8.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray8_BitArray8_BitArray8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665380);
			BitArray8.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray8_BitArray8_BitArray8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665381);
			BitArray8.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665382);
			BitArray8.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665383);
			BitArray8.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665384);
			BitArray8.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray8_BitArray8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665385);
			BitArray8.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray8_BitArray8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665386);
			BitArray8.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665387);
			BitArray8.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, 100665388);
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000427DC File Offset: 0x000409DC
		public unsafe uint capacity
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 72449, RefRangeEnd = 72472, XrefRangeStart = 72449, XrefRangeEnd = 72472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0004280C File Offset: 0x00040A0C
		public unsafe bool allFalse
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 786806, RefRangeEnd = 786824, XrefRangeStart = 786806, XrefRangeEnd = 786824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0004283C File Offset: 0x00040A3C
		public unsafe bool allTrue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0004286C File Offset: 0x00040A6C
		public unsafe string humanizedData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974039, XrefRangeEnd = 974051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000470 RID: 1136
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00042918 File Offset: 0x00040B18
		[CallerCount(0)]
		public unsafe BitArray8(byte initValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0004294C File Offset: 0x00040B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974051, XrefRangeEnd = 974057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray8(IEnumerable<uint> bitIndexTrue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitIndexTrue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00042984 File Offset: 0x00040B84
		[CallerCount(0)]
		public unsafe static BitArray8 operator ~(BitArray8 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray8_BitArray8_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000429C4 File Offset: 0x00040BC4
		[CallerCount(0)]
		public unsafe static BitArray8 operator |(BitArray8 a, BitArray8 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray8_BitArray8_BitArray8_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00042A10 File Offset: 0x00040C10
		[CallerCount(0)]
		public unsafe static BitArray8 operator &(BitArray8 a, BitArray8 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray8_BitArray8_BitArray8_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00042A5C File Offset: 0x00040C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974057, XrefRangeEnd = 974062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitAnd(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00042AA0 File Offset: 0x00040CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974062, XrefRangeEnd = 974067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitOr(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00042AE4 File Offset: 0x00040CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974067, XrefRangeEnd = 974070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitNot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00042B18 File Offset: 0x00040D18
		[CallerCount(0)]
		public unsafe static bool operator ==(BitArray8 a, BitArray8 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray8_BitArray8_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00042B64 File Offset: 0x00040D64
		[CallerCount(0)]
		public unsafe static bool operator !=(BitArray8 a, BitArray8 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray8_BitArray8_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00042BB0 File Offset: 0x00040DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974070, XrefRangeEnd = 974073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00042BF4 File Offset: 0x00040DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974073, XrefRangeEnd = 974074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray8.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000083F2 File Offset: 0x000065F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitArray8>.NativeClassPtr, ref this));
		}

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray8_BitArray8_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray8_BitArray8_BitArray8_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray8_BitArray8_BitArray8_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray8_BitArray8_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray8_BitArray8_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AF3 RID: 2803
		[FieldOffset(0)]
		public byte data;
	}
}
