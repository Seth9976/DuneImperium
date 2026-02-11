using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000005 RID: 5
	public sealed class BitConverterLE : Object
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00005244 File Offset: 0x00003444
		// Note: this type is marked as 'beforefieldinit'.
		static BitConverterLE()
		{
			Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "BitConverterLE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr);
			BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663322);
			BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663323);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663324);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663325);
			BitConverterLE.NativeMethodInfoPtr_UShortFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663326);
			BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663327);
			BitConverterLE.NativeMethodInfoPtr_ToInt32_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663328);
			BitConverterLE.NativeMethodInfoPtr_ToUInt16_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663329);
			BitConverterLE.NativeMethodInfoPtr_ToUInt32_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663330);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005328 File Offset: 0x00003528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144620, XrefRangeEnd = 1144623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUIntBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005368 File Offset: 0x00003568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144623, XrefRangeEnd = 1144626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetULongBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000053A8 File Offset: 0x000035A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144626, XrefRangeEnd = 1144629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000053E8 File Offset: 0x000035E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144629, XrefRangeEnd = 1144632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005428 File Offset: 0x00003628
		[CallerCount(0)]
		public unsafe static void UShortFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_UShortFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000547C File Offset: 0x0000367C
		[CallerCount(0)]
		public unsafe static void UIntFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000054D0 File Offset: 0x000036D0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1144632, RefRangeEnd = 1144648, XrefRangeStart = 1144632, XrefRangeEnd = 1144632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToInt32_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005520 File Offset: 0x00003720
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1144648, RefRangeEnd = 1144667, XrefRangeStart = 1144648, XrefRangeEnd = 1144648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToUInt16_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005570 File Offset: 0x00003770
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1144632, RefRangeEnd = 1144648, XrefRangeStart = 1144632, XrefRangeEnd = 1144648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToUInt32_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020D2 File Offset: 0x000002D2
		public BitConverterLE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_UShortFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Internal_Static_UInt16_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Internal_Static_UInt32_Il2CppStructArray_1_Byte_Int32_0;
	}
}
