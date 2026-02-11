using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	[StructLayout(2)]
	public struct BitArray16
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00042C24 File Offset: 0x00040E24
		// Note: this type is marked as 'beforefieldinit'.
		static BitArray16()
		{
			Il2CppClassPointerStore<BitArray16>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArray16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArray16>.NativeClassPtr);
			BitArray16.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, "data");
			BitArray16.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665389);
			BitArray16.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665390);
			BitArray16.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665391);
			BitArray16.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665392);
			BitArray16.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665393);
			BitArray16.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665394);
			BitArray16.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665395);
			BitArray16.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665396);
			BitArray16.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray16_BitArray16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665397);
			BitArray16.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray16_BitArray16_BitArray16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665398);
			BitArray16.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray16_BitArray16_BitArray16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665399);
			BitArray16.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665400);
			BitArray16.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665401);
			BitArray16.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665402);
			BitArray16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray16_BitArray16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665403);
			BitArray16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray16_BitArray16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665404);
			BitArray16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665405);
			BitArray16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, 100665406);
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00042DD0 File Offset: 0x00040FD0
		public unsafe uint capacity
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00042E00 File Offset: 0x00041000
		public unsafe bool allFalse
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00042E30 File Offset: 0x00041030
		public unsafe bool allTrue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00042E60 File Offset: 0x00041060
		public unsafe string humanizedData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974074, XrefRangeEnd = 974095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000475 RID: 1141
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00042F0C File Offset: 0x0004110C
		[CallerCount(0)]
		public unsafe BitArray16(ushort initValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00042F40 File Offset: 0x00041140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974095, XrefRangeEnd = 974101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitArray16(IEnumerable<uint> bitIndexTrue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bitIndexTrue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00042F78 File Offset: 0x00041178
		[CallerCount(0)]
		public unsafe static BitArray16 operator ~(BitArray16 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray16_BitArray16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00042FB8 File Offset: 0x000411B8
		[CallerCount(0)]
		public unsafe static BitArray16 operator |(BitArray16 a, BitArray16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray16_BitArray16_BitArray16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00043004 File Offset: 0x00041204
		[CallerCount(0)]
		public unsafe static BitArray16 operator &(BitArray16 a, BitArray16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray16_BitArray16_BitArray16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00043050 File Offset: 0x00041250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974101, XrefRangeEnd = 974106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitAnd(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00043094 File Offset: 0x00041294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974106, XrefRangeEnd = 974111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitOr(IBitArray other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000430D8 File Offset: 0x000412D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974111, XrefRangeEnd = 974114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBitArray BitNot()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBitArray>(intPtr3) : null;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0004310C File Offset: 0x0004130C
		[CallerCount(0)]
		public unsafe static bool operator ==(BitArray16 a, BitArray16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray16_BitArray16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00043158 File Offset: 0x00041358
		[CallerCount(0)]
		public unsafe static bool operator !=(BitArray16 a, BitArray16 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray16_BitArray16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000431A4 File Offset: 0x000413A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974114, XrefRangeEnd = 974117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000431E8 File Offset: 0x000413E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 974117, XrefRangeEnd = 974118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArray16.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00008404 File Offset: 0x00006604
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BitArray16>.NativeClassPtr, ref this));
		}

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_get_capacity_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_get_allFalse_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_get_allTrue_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_get_humanizedData_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Boolean_UInt32_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_UInt32_Boolean_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_UInt32_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_BitArray16_BitArray16_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_BitArray16_BitArray16_BitArray16_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_BitArray16_BitArray16_BitArray16_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_BitAnd_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_BitOr_Public_Virtual_Final_New_IBitArray_IBitArray_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_BitNot_Public_Virtual_Final_New_IBitArray_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BitArray16_BitArray16_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BitArray16_BitArray16_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B07 RID: 2823
		[FieldOffset(0)]
		public ushort data;
	}
}
