using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class WWWTranscoder : Object
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002EF0 File Offset: 0x000010F0
		// Note: this type is marked as 'beforefieldinit'.
		static WWWTranscoder()
		{
			Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine", "WWWTranscoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr);
			WWWTranscoder.NativeFieldInfoPtr_ucHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "ucHexChars");
			WWWTranscoder.NativeFieldInfoPtr_lcHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "lcHexChars");
			WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlEscapeChar");
			WWWTranscoder.NativeFieldInfoPtr_urlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlSpace");
			WWWTranscoder.NativeFieldInfoPtr_dataSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "dataSpace");
			WWWTranscoder.NativeFieldInfoPtr_urlForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlForbidden");
			WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpEscapeChar");
			WWWTranscoder.NativeFieldInfoPtr_qpSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpSpace");
			WWWTranscoder.NativeFieldInfoPtr_qpForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpForbidden");
			WWWTranscoder.NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663309);
			WWWTranscoder.NativeMethodInfoPtr_Byte2Hex_Private_Static_Void_Byte_Il2CppStructArray_1_Byte_byref_Byte_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663310);
			WWWTranscoder.NativeMethodInfoPtr_URLEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663311);
			WWWTranscoder.NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663312);
			WWWTranscoder.NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663313);
			WWWTranscoder.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663314);
			WWWTranscoder.NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663315);
			WWWTranscoder.NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663316);
			WWWTranscoder.NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663317);
			WWWTranscoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663318);
			WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663319);
			WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000030C4 File Offset: 0x000012C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247007, XrefRangeEnd = 1247009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Hex2Byte(Il2CppStructArray<byte> b, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003114 File Offset: 0x00001314
		[CallerCount(0)]
		public unsafe static void Byte2Hex(byte b, Il2CppStructArray<byte> hexChars, out byte byte0, out byte byte1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hexChars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &byte0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &byte1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Byte2Hex_Private_Static_Void_Byte_Il2CppStructArray_1_Byte_byref_Byte_byref_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003174 File Offset: 0x00001374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247009, XrefRangeEnd = 1247014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> URLEncode(Il2CppStructArray<byte> toEncode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_URLEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000031B8 File Offset: 0x000013B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247014, XrefRangeEnd = 1247019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> DataEncode(Il2CppStructArray<byte> toEncode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000031FC File Offset: 0x000013FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247028, RefRangeEnd = 1247030, XrefRangeStart = 1247019, XrefRangeEnd = 1247028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QPEncode(string toEncode, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toEncode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000324C File Offset: 0x0000144C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1247057, RefRangeEnd = 1247064, XrefRangeStart = 1247030, XrefRangeEnd = 1247057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Encode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space, Il2CppStructArray<byte> forbidden, bool uppercase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escapeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forbidden);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uppercase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000032D0 File Offset: 0x000014D0
		[CallerCount(0)]
		public unsafe static bool ByteArrayContains(Il2CppStructArray<byte> array, byte b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003320 File Offset: 0x00001520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247064, XrefRangeEnd = 1247069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> URLDecode(Il2CppStructArray<byte> toEncode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003364 File Offset: 0x00001564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247069, XrefRangeEnd = 1247070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ByteSubArrayEquals(Il2CppStructArray<byte> array, int index, Il2CppStructArray<byte> comperand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comperand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000033C8 File Offset: 0x000015C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247096, RefRangeEnd = 1247098, XrefRangeStart = 1247070, XrefRangeEnd = 1247096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref escapeChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(space);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000342C File Offset: 0x0000162C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247106, RefRangeEnd = 1247108, XrefRangeStart = 1247098, XrefRangeEnd = 1247106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SevenBitClean(string s, Encoding e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003480 File Offset: 0x00001680
		[CallerCount(0)]
		public unsafe static bool SevenBitClean(byte* input, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTranscoder.NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021F5 File Offset: 0x000003F5
		public WWWTranscoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000034CC File Offset: 0x000016CC
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021FE File Offset: 0x000003FE
		public unsafe static Il2CppStructArray<byte> ucHexChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_ucHexChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_ucHexChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000034F4 File Offset: 0x000016F4
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002210 File Offset: 0x00000410
		public unsafe static Il2CppStructArray<byte> lcHexChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_lcHexChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_lcHexChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000351C File Offset: 0x0000171C
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002222 File Offset: 0x00000422
		public unsafe static byte urlEscapeChar
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlEscapeChar, (void*)(&value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003538 File Offset: 0x00001738
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002230 File Offset: 0x00000430
		public unsafe static Il2CppStructArray<byte> urlSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003560 File Offset: 0x00001760
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002242 File Offset: 0x00000442
		public unsafe static Il2CppStructArray<byte> dataSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_dataSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_dataSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002254 File Offset: 0x00000454
		public unsafe static Il2CppStructArray<byte> urlForbidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_urlForbidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_urlForbidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000035B0 File Offset: 0x000017B0
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002266 File Offset: 0x00000466
		public unsafe static byte qpEscapeChar
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpEscapeChar, (void*)(&value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000035CC File Offset: 0x000017CC
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002274 File Offset: 0x00000474
		public unsafe static Il2CppStructArray<byte> qpSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000035F4 File Offset: 0x000017F4
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002286 File Offset: 0x00000486
		public unsafe static Il2CppStructArray<byte> qpForbidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTranscoder.NativeFieldInfoPtr_qpForbidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTranscoder.NativeFieldInfoPtr_qpForbidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000361C File Offset: 0x0000181C
		public static string URLEncode(string toEncode)
		{
			return WWWTranscoder.URLEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000363C File Offset: 0x0000183C
		public static string URLEncode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace, WWWTranscoder.urlForbidden, false);
			return WWWForm.DefaultEncoding.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003680 File Offset: 0x00001880
		public static string DataEncode(string toEncode)
		{
			return WWWTranscoder.DataEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000036A0 File Offset: 0x000018A0
		public static string DataEncode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Encode(e.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace, WWWTranscoder.urlForbidden, false);
			return WWWForm.DefaultEncoding.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000036E4 File Offset: 0x000018E4
		public static string QPEncode(string toEncode)
		{
			return WWWTranscoder.QPEncode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003704 File Offset: 0x00001904
		public static Il2CppStructArray<byte> QPEncode(Il2CppStructArray<byte> toEncode)
		{
			return WWWTranscoder.Encode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace, WWWTranscoder.qpForbidden, true);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000372C File Offset: 0x0000192C
		public static string URLDecode(string toEncode)
		{
			return WWWTranscoder.URLDecode(toEncode, Encoding.UTF8);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000374C File Offset: 0x0000194C
		public static string URLDecode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.urlEscapeChar, WWWTranscoder.urlSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003788 File Offset: 0x00001988
		public static string DataDecode(string toDecode)
		{
			return WWWTranscoder.DataDecode(toDecode, Encoding.UTF8);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000037A8 File Offset: 0x000019A8
		public static string DataDecode(string toDecode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toDecode), WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000037E4 File Offset: 0x000019E4
		public static Il2CppStructArray<byte> DataDecode(Il2CppStructArray<byte> toDecode)
		{
			return WWWTranscoder.Decode(toDecode, WWWTranscoder.urlEscapeChar, WWWTranscoder.dataSpace);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003808 File Offset: 0x00001A08
		public static string QPDecode(string toEncode)
		{
			return WWWTranscoder.QPDecode(toEncode, Encoding.UTF8);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003828 File Offset: 0x00001A28
		public static string QPDecode(string toEncode, Encoding e)
		{
			Il2CppStructArray<byte> il2CppStructArray = WWWTranscoder.Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
			return e.GetString(il2CppStructArray, 0, il2CppStructArray.Length);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003864 File Offset: 0x00001A64
		public static Il2CppStructArray<byte> QPDecode(Il2CppStructArray<byte> toEncode)
		{
			return WWWTranscoder.Decode(toEncode, WWWTranscoder.qpEscapeChar, WWWTranscoder.qpSpace);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003888 File Offset: 0x00001A88
		public static bool SevenBitClean(string s)
		{
			return WWWTranscoder.SevenBitClean(s, Encoding.UTF8);
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_ucHexChars;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_lcHexChars;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_urlEscapeChar;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_urlSpace;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_dataSpace;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_urlForbidden;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_qpEscapeChar;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_qpSpace;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_qpForbidden;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Byte2Hex_Private_Static_Void_Byte_Il2CppStructArray_1_Byte_byref_Byte_byref_Byte_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_URLEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_DataEncode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_QPEncode_Public_Static_String_String_Encoding_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_ByteArrayContains_Private_Static_Boolean_Il2CppStructArray_1_Byte_Byte_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_String_Encoding_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_SevenBitClean_Public_Static_Boolean_ptr_Byte_Int32_0;
	}
}
