using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012D RID: 301
	public static class Buffer : Object
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x00086A84 File Offset: 0x00084C84
		// Note: this type is marked as 'beforefieldinit'.
		static Buffer()
		{
			Il2CppClassPointerStore<Buffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Buffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer>.NativeClassPtr);
			Buffer.NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666844);
			Buffer.NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666845);
			Buffer.NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666846);
			Buffer.NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666847);
			Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666848);
			Buffer.NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666849);
			Buffer.NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666850);
			Buffer.NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666851);
			Buffer.NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666852);
			Buffer.NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666853);
			Buffer.NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666854);
			Buffer.NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666855);
			Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666856);
			Buffer.NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666857);
			Buffer.NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666858);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00086BE0 File Offset: 0x00084DE0
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1338663, RefRangeEnd = 1338705, XrefRangeStart = 1338662, XrefRangeEnd = 1338663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffsetBytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffsetBytes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x00086C60 File Offset: 0x00084E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338705, RefRangeEnd = 1338706, XrefRangeStart = 1338705, XrefRangeEnd = 1338705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x00086CC8 File Offset: 0x00084EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338706, XrefRangeEnd = 1338707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ByteLength(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00086D0C File Offset: 0x00084F0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338707, RefRangeEnd = 1338710, XrefRangeStart = 1338707, XrefRangeEnd = 1338707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMemory(byte* src, long len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00086D4C File Offset: 0x00084F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338712, RefRangeEnd = 1338714, XrefRangeStart = 1338710, XrefRangeEnd = 1338712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memcpy(byte* pDest, int destIndex, Il2CppStructArray<byte> src, int srcIndex, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00086DBC File Offset: 0x00084FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338714, XrefRangeEnd = 1338715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalMemcpy(byte* dest, byte* src, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00086E08 File Offset: 0x00085008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338716, RefRangeEnd = 1338718, XrefRangeStart = 1338715, XrefRangeEnd = 1338716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ByteLength(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00086E4C File Offset: 0x0008504C
		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 1338721, RefRangeEnd = 1338966, XrefRangeStart = 1338718, XrefRangeEnd = 1338721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00086EC0 File Offset: 0x000850C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1338972, RefRangeEnd = 1338976, XrefRangeStart = 1338966, XrefRangeEnd = 1338972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = source;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationSizeInBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceBytesToCopy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00086F1C File Offset: 0x0008511C
		[CallerCount(0)]
		public unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00086F68 File Offset: 0x00085168
		[CallerCount(0)]
		public unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00086FB4 File Offset: 0x000851B4
		[CallerCount(0)]
		public unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00087000 File Offset: 0x00085200
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1338976, RefRangeEnd = 1339002, XrefRangeStart = 1338976, XrefRangeEnd = 1338976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memcpy(byte* dest, byte* src, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x0008704C File Offset: 0x0008524C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1339004, RefRangeEnd = 1339041, XrefRangeStart = 1339002, XrefRangeEnd = 1339004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00087098 File Offset: 0x00085298
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1339042, RefRangeEnd = 1339048, XrefRangeStart = 1339041, XrefRangeEnd = 1339042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementCount;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Buffer.MethodInfoStoreGeneric_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			destination = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			source = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000065F5 File Offset: 0x000047F5
		public Buffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0;

		// Token: 0x020005E5 RID: 1509
		private sealed class MethodInfoStoreGeneric_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0<T>
		{
			// Token: 0x040047A3 RID: 18339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Buffer.NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0, Il2CppClassPointerStore<Buffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
