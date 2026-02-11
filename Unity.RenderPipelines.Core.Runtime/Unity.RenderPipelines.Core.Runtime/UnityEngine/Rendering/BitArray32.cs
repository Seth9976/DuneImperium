using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	[StructLayout(2)]
	public struct BitArray32
	{
		// Token: 0x06000E99 RID: 3737 RVA: 0x00043218 File Offset: 0x00041418
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray32()
		{
			Il2CppClassPointerStore<BitArray32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArray32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray32>.NativeClassPtr);
			BitArray32.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, "data");
			BitArray32.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665407);
			BitArray32.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665408);
			BitArray32.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665409);
			BitArray32.NativeMethodInfoPtr_get_humanizedVersion_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665410);
			BitArray32.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665411);
			BitArray32.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665412);
			BitArray32.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665413);
			BitArray32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665414);
			BitArray32.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665415);
			BitArray32.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665416);
			BitArray32.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665417);
			BitArray32.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665418);
			BitArray32.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray32_BitArray32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665419);
			BitArray32.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray32_BitArray32_BitArray32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665420);
			BitArray32.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray32_BitArray32_BitArray32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665421);
			BitArray32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray32_BitArray32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665422);
			BitArray32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray32_BitArray32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665423);
			BitArray32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665424);
			BitArray32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, 100665425);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x000433D8 File Offset: 0x000415D8
		public unsafe uint capacity
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00043408 File Offset: 0x00041608
		public unsafe bool allFalse
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 974118, RefRangeEnd = 974122, XrefRangeStart = 974118, XrefRangeEnd = 974118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00043438 File Offset: 0x00041638
		public unsafe bool allTrue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00043468 File Offset: 0x00041668
		public unsafe string humanizedVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974122, XrefRangeEnd = 974126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_humanizedVersion_Private_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00043494 File Offset: 0x00041694
		public unsafe string humanizedData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974126, XrefRangeEnd = 974147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00043540 File Offset: 0x00041740
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray32(uint initValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00043574 File Offset: 0x00041774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974147, XrefRangeEnd = 974153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray32(IEnumerable<uint> bitIndexTrue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitIndexTrue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000435AC File Offset: 0x000417AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974153, XrefRangeEnd = 974158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitAnd(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000435F0 File Offset: 0x000417F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974158, XrefRangeEnd = 974163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitOr(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00043634 File Offset: 0x00041834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974163, XrefRangeEnd = 974166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitNot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00043668 File Offset: 0x00041868
		[CallerCount(0)]
		public unsafe static BitArray32 operator ~(BitArray32 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray32_BitArray32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000436A8 File Offset: 0x000418A8
		[CallerCount(0)]
		public unsafe static BitArray32 operator |(BitArray32 a, BitArray32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray32_BitArray32_BitArray32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000436F4 File Offset: 0x000418F4
		[CallerCount(0)]
		public unsafe static BitArray32 operator &(BitArray32 a, BitArray32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray32_BitArray32_BitArray32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00043740 File Offset: 0x00041940
		[CallerCount(0)]
		public unsafe static bool operator ==(BitArray32 a, BitArray32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray32_BitArray32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0004378C File Offset: 0x0004198C
		[CallerCount(0)]
		public unsafe static bool operator !=(BitArray32 a, BitArray32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray32_BitArray32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000437D8 File Offset: 0x000419D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974166, XrefRangeEnd = 974169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0004381C File Offset: 0x00041A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974169, XrefRangeEnd = 974170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00008416 File Offset: 0x00006616
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitArray32>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedVersion_Private_get_String_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray32_BitArray32_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray32_BitArray32_BitArray32_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray32_BitArray32_BitArray32_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray32_BitArray32_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray32_BitArray32_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B1C RID: 2844
		[FieldOffset(0)]
		public uint data;
	}
}
