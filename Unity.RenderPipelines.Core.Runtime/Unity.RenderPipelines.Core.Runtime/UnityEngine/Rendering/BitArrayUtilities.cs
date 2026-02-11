using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000CE RID: 206
	public static class BitArrayUtilities : Object
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00044AAC File Offset: 0x00042CAC
		// Note: this type is marked as 'beforefieldinit'.
		static BitArrayUtilities()
		{
			Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "BitArrayUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr);
			BitArrayUtilities.NativeMethodInfoPtr_Get8_Public_Static_Boolean_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665480);
			BitArrayUtilities.NativeMethodInfoPtr_Get16_Public_Static_Boolean_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665481);
			BitArrayUtilities.NativeMethodInfoPtr_Get32_Public_Static_Boolean_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665482);
			BitArrayUtilities.NativeMethodInfoPtr_Get64_Public_Static_Boolean_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665483);
			BitArrayUtilities.NativeMethodInfoPtr_Get128_Public_Static_Boolean_UInt32_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665484);
			BitArrayUtilities.NativeMethodInfoPtr_Get256_Public_Static_Boolean_UInt32_UInt64_UInt64_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665485);
			BitArrayUtilities.NativeMethodInfoPtr_Set8_Public_Static_Void_UInt32_byref_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665486);
			BitArrayUtilities.NativeMethodInfoPtr_Set16_Public_Static_Void_UInt32_byref_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665487);
			BitArrayUtilities.NativeMethodInfoPtr_Set32_Public_Static_Void_UInt32_byref_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665488);
			BitArrayUtilities.NativeMethodInfoPtr_Set64_Public_Static_Void_UInt32_byref_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665489);
			BitArrayUtilities.NativeMethodInfoPtr_Set128_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665490);
			BitArrayUtilities.NativeMethodInfoPtr_Set256_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitArrayUtilities>.NativeClassPtr, 100665491);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00044BCC File Offset: 0x00042DCC
		[CallerCount(0)]
		public unsafe static bool Get8(uint index, byte data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get8_Public_Static_Boolean_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00044C18 File Offset: 0x00042E18
		[CallerCount(0)]
		public unsafe static bool Get16(uint index, ushort data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get16_Public_Static_Boolean_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00044C64 File Offset: 0x00042E64
		[CallerCount(0)]
		public unsafe static bool Get32(uint index, uint data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get32_Public_Static_Boolean_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00044CB0 File Offset: 0x00042EB0
		[CallerCount(0)]
		public unsafe static bool Get64(uint index, ulong data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get64_Public_Static_Boolean_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00044CFC File Offset: 0x00042EFC
		[CallerCount(0)]
		public unsafe static bool Get128(uint index, ulong data1, ulong data2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get128_Public_Static_Boolean_UInt32_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00044D58 File Offset: 0x00042F58
		[CallerCount(0)]
		public unsafe static bool Get256(uint index, ulong data1, ulong data2, ulong data3, ulong data4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Get256_Public_Static_Boolean_UInt32_UInt64_UInt64_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00044DD0 File Offset: 0x00042FD0
		[CallerCount(0)]
		public unsafe static void Set8(uint index, ref byte data, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set8_Public_Static_Void_UInt32_byref_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00044E20 File Offset: 0x00043020
		[CallerCount(0)]
		public unsafe static void Set16(uint index, ref ushort data, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set16_Public_Static_Void_UInt32_byref_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00044E70 File Offset: 0x00043070
		[CallerCount(0)]
		public unsafe static void Set32(uint index, ref uint data, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set32_Public_Static_Void_UInt32_byref_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00044EC0 File Offset: 0x000430C0
		[CallerCount(0)]
		public unsafe static void Set64(uint index, ref ulong data, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set64_Public_Static_Void_UInt32_byref_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00044F10 File Offset: 0x00043110
		[CallerCount(0)]
		public unsafe static void Set128(uint index, ref ulong data1, ref ulong data2, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set128_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00044F6C File Offset: 0x0004316C
		[CallerCount(0)]
		public unsafe static void Set256(uint index, ref ulong data1, ref ulong data2, ref ulong data3, ref ulong data4, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data4;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitArrayUtilities.NativeMethodInfoPtr_Set256_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0000845E File Offset: 0x0000665E
		public BitArrayUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_Get8_Public_Static_Boolean_UInt32_Byte_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_Get16_Public_Static_Boolean_UInt32_UInt16_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_Get32_Public_Static_Boolean_UInt32_UInt32_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_Get64_Public_Static_Boolean_UInt32_UInt64_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_Get128_Public_Static_Boolean_UInt32_UInt64_UInt64_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_Get256_Public_Static_Boolean_UInt32_UInt64_UInt64_UInt64_UInt64_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_Set8_Public_Static_Void_UInt32_byref_Byte_Boolean_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_Set16_Public_Static_Void_UInt32_byref_UInt16_Boolean_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_Set32_Public_Static_Void_UInt32_byref_UInt32_Boolean_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_Set64_Public_Static_Void_UInt32_byref_UInt64_Boolean_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_Set128_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_Boolean_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_Set256_Public_Static_Void_UInt32_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_Boolean_0;
	}
}
