using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	[StructLayout(2)]
	public struct BitArray64
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x0004384C File Offset: 0x00041A4C
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray64()
		{
			Il2CppClassPointerStore<BitArray64>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArray64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray64>.NativeClassPtr);
			BitArray64.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, "data");
			BitArray64.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665426);
			BitArray64.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665427);
			BitArray64.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665428);
			BitArray64.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665429);
			BitArray64.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665430);
			BitArray64.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665431);
			BitArray64.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665432);
			BitArray64.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665433);
			BitArray64.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray64_BitArray64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665434);
			BitArray64.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray64_BitArray64_BitArray64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665435);
			BitArray64.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray64_BitArray64_BitArray64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665436);
			BitArray64.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665437);
			BitArray64.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665438);
			BitArray64.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665439);
			BitArray64.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray64_BitArray64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665440);
			BitArray64.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray64_BitArray64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665441);
			BitArray64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665442);
			BitArray64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, 100665443);
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000439F8 File Offset: 0x00041BF8
		public unsafe uint capacity
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00043A28 File Offset: 0x00041C28
		public unsafe bool allFalse
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 745863, RefRangeEnd = 745876, XrefRangeStart = 745863, XrefRangeEnd = 745876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00043A58 File Offset: 0x00041C58
		public unsafe bool allTrue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00043A88 File Offset: 0x00041C88
		public unsafe string humanizedData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974170, XrefRangeEnd = 974191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000480 RID: 1152
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00043B34 File Offset: 0x00041D34
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray64(ulong initValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00043B68 File Offset: 0x00041D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974191, XrefRangeEnd = 974197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray64(IEnumerable<uint> bitIndexTrue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitIndexTrue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00043BA0 File Offset: 0x00041DA0
		[CallerCount(0)]
		public unsafe static BitArray64 operator ~(BitArray64 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray64_BitArray64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00043BE0 File Offset: 0x00041DE0
		[CallerCount(0)]
		public unsafe static BitArray64 operator |(BitArray64 a, BitArray64 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray64_BitArray64_BitArray64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00043C2C File Offset: 0x00041E2C
		[CallerCount(0)]
		public unsafe static BitArray64 operator &(BitArray64 a, BitArray64 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray64_BitArray64_BitArray64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00043C78 File Offset: 0x00041E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974197, XrefRangeEnd = 974202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitAnd(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00043CBC File Offset: 0x00041EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974202, XrefRangeEnd = 974207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitOr(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00043D00 File Offset: 0x00041F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974207, XrefRangeEnd = 974210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitNot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00043D34 File Offset: 0x00041F34
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BitArray64 a, BitArray64 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray64_BitArray64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00043D80 File Offset: 0x00041F80
		[CallerCount(736)]
		[CachedScanResults(RefRangeStart = 974210, RefRangeEnd = 974946, XrefRangeStart = 974210, XrefRangeEnd = 974210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BitArray64 a, BitArray64 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray64_BitArray64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00043DCC File Offset: 0x00041FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974946, XrefRangeEnd = 974949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00043E10 File Offset: 0x00042010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974949, XrefRangeEnd = 974950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00008428 File Offset: 0x00006628
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitArray64>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray64_BitArray64_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray64_BitArray64_BitArray64_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray64_BitArray64_BitArray64_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray64_BitArray64_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray64_BitArray64_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B30 RID: 2864
		[FieldOffset(0)]
		public ulong data;
	}
}
