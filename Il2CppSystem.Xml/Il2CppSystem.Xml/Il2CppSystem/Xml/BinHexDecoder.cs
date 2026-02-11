using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000B RID: 11
	public class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00016BC8 File Offset: 0x00014DC8
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexDecoder()
		{
			Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr);
			BinHexDecoder.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "buffer");
			BinHexDecoder.NativeFieldInfoPtr_curIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "curIndex");
			BinHexDecoder.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "endIndex");
			BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "hasHalfByteCached");
			BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "cachedHalfByte");
			BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663311);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663312);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663313);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663314);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00016CAC File Offset: 0x00014EAC
		public unsafe override bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00016CF4 File Offset: 0x00014EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362208, XrefRangeEnd = 362209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Decode(Il2CppStructArray<char> chars, int startPos, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00016D68 File Offset: 0x00014F68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362220, RefRangeEnd = 362222, XrefRangeStart = 362209, XrefRangeEnd = 362220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<char> chars, bool allowOddChars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00016DBC File Offset: 0x00014FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362227, RefRangeEnd = 362228, XrefRangeStart = 362222, XrefRangeEnd = 362227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pCharsEndPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytesEndPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHalfByteCached;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cachedHalfByte;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsDecoded;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002264 File Offset: 0x00000464
		public BinHexDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00016E50 File Offset: 0x00015050
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000226D File Offset: 0x0000046D
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00016E80 File Offset: 0x00015080
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000228C File Offset: 0x0000048C
		public unsafe int curIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00016EA8 File Offset: 0x000150A8
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000022A7 File Offset: 0x000004A7
		public unsafe int endIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00016ED0 File Offset: 0x000150D0
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000022C2 File Offset: 0x000004C2
		public unsafe bool hasHalfByteCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00016EF8 File Offset: 0x000150F8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022DD File Offset: 0x000004DD
		public unsafe byte cachedHalfByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte)) = value;
			}
		}

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_curIndex;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_endIndex;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_hasHalfByteCached;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_cachedHalfByte;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0;
	}
}
