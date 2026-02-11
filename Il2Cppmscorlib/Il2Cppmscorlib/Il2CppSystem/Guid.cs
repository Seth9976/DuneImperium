using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000A3 RID: 163
	[Serializable]
	[StructLayout(2)]
	public struct Guid
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00058CA0 File Offset: 0x00056EA0
		// Note: this type is marked as 'beforefieldinit'.
		static Guid()
		{
			Il2CppClassPointerStore<Guid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Guid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid>.NativeClassPtr);
			Guid.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "Empty");
			Guid.NativeFieldInfoPtr__a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_a");
			Guid.NativeFieldInfoPtr__b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_b");
			Guid.NativeFieldInfoPtr__c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_c");
			Guid.NativeFieldInfoPtr__d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_d");
			Guid.NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_e");
			Guid.NativeFieldInfoPtr__f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_f");
			Guid.NativeFieldInfoPtr__g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_g");
			Guid.NativeFieldInfoPtr__h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_h");
			Guid.NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_i");
			Guid.NativeFieldInfoPtr__j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_j");
			Guid.NativeFieldInfoPtr__k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_k");
			Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665227);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665228);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665229);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665230);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665231);
			Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665232);
			Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665233);
			Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665234);
			Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665235);
			Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665236);
			Guid.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665237);
			Guid.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665238);
			Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665239);
			Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665240);
			Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665241);
			Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665242);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665243);
			Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665244);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665245);
			Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665246);
			Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665247);
			Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665248);
			Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665249);
			Guid.NativeMethodInfoPtr_WriteByteHelper_Private_Void_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665250);
			Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665251);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665252);
			Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665253);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665254);
			Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665255);
			Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665256);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665257);
			Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665258);
			Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665259);
			Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665260);
			Guid.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665261);
			Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665262);
			Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665263);
			Guid.NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665264);
			Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665265);
			Guid.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665266);
			Guid.NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665267);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000590F4 File Offset: 0x000572F4
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1307477, RefRangeEnd = 1307524, XrefRangeStart = 1307476, XrefRangeEnd = 1307477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid NewGuid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00059124 File Offset: 0x00057324
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1307526, RefRangeEnd = 1307535, XrefRangeStart = 1307524, XrefRangeEnd = 1307526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(Il2CppStructArray<byte> b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0005915C File Offset: 0x0005735C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307536, RefRangeEnd = 1307537, XrefRangeStart = 1307535, XrefRangeEnd = 1307536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(ReadOnlySpan<byte> b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00059198 File Offset: 0x00057398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307537, RefRangeEnd = 1307539, XrefRangeStart = 1307537, XrefRangeEnd = 1307537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(int a, short b, short c, Il2CppStructArray<byte> d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000591FC File Offset: 0x000573FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307539, RefRangeEnd = 1307541, XrefRangeStart = 1307539, XrefRangeEnd = 1307539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000592C0 File Offset: 0x000574C0
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 1307544, RefRangeEnd = 1307594, XrefRangeStart = 1307541, XrefRangeEnd = 1307544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Guid(string g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000592F8 File Offset: 0x000574F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307594, XrefRangeEnd = 1307597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid Parse(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0005933C File Offset: 0x0005753C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307597, XrefRangeEnd = 1307598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Guid Parse(ReadOnlySpan<char> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00059384 File Offset: 0x00057584
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1307601, RefRangeEnd = 1307609, XrefRangeStart = 1307598, XrefRangeEnd = 1307601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000593D4 File Offset: 0x000575D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307609, XrefRangeEnd = 1307610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(ReadOnlySpan<char> input, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00059428 File Offset: 0x00057628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307616, RefRangeEnd = 1307617, XrefRangeStart = 1307610, XrefRangeEnd = 1307616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string input, string format, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0005948C File Offset: 0x0005768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307617, XrefRangeEnd = 1307618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000594F8 File Offset: 0x000576F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1307626, RefRangeEnd = 1307631, XrefRangeStart = 1307618, XrefRangeEnd = 1307626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuid(ReadOnlySpan<char> guidString, Guid.GuidStyles flags, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guidString));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00059560 File Offset: 0x00057760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307631, XrefRangeEnd = 1307718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guidString));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000595BC File Offset: 0x000577BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307718, XrefRangeEnd = 1307746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guidString));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00059618 File Offset: 0x00057818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307746, XrefRangeEnd = 1307751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref Guid.GuidResult result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guidString));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00059674 File Offset: 0x00057874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307751, XrefRangeEnd = 1307752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000596F8 File Offset: 0x000578F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307752, XrefRangeEnd = 1307753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0005978C File Offset: 0x0005798C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307753, XrefRangeEnd = 1307754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00059810 File Offset: 0x00057A10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1307758, RefRangeEnd = 1307769, XrefRangeStart = 1307754, XrefRangeEnd = 1307758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000598A4 File Offset: 0x00057AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307770, RefRangeEnd = 1307771, XrefRangeStart = 1307769, XrefRangeEnd = 1307770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parsePos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00059928 File Offset: 0x00057B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307797, RefRangeEnd = 1307798, XrefRangeStart = 1307771, XrefRangeEnd = 1307797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0005996C File Offset: 0x00057B6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1307800, RefRangeEnd = 1307803, XrefRangeStart = 1307798, XrefRangeEnd = 1307800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(str));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000599C0 File Offset: 0x00057BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307803, RefRangeEnd = 1307804, XrefRangeStart = 1307803, XrefRangeEnd = 1307803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteByteHelper(Span<byte> destination)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_WriteByteHelper_Private_Void_Span_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000599FC File Offset: 0x00057BFC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1307811, RefRangeEnd = 1307820, XrefRangeStart = 1307804, XrefRangeEnd = 1307811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ToByteArray()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00059A30 File Offset: 0x00057C30
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1307823, RefRangeEnd = 1307839, XrefRangeStart = 1307820, XrefRangeEnd = 1307823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00059A5C File Offset: 0x00057C5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307839, RefRangeEnd = 1307841, XrefRangeStart = 1307839, XrefRangeEnd = 1307839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00059A8C File Offset: 0x00057C8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307844, RefRangeEnd = 1307845, XrefRangeStart = 1307841, XrefRangeEnd = 1307844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00059AD0 File Offset: 0x00057CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307845, RefRangeEnd = 1307846, XrefRangeStart = 1307845, XrefRangeEnd = 1307845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Guid g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref g;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00059B10 File Offset: 0x00057D10
		[CallerCount(0)]
		public unsafe int GetResult(uint me, uint them)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref me;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref them;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00059B5C File Offset: 0x00057D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307849, RefRangeEnd = 1307850, XrefRangeStart = 1307846, XrefRangeEnd = 1307849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00059BA0 File Offset: 0x00057DA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307850, RefRangeEnd = 1307852, XrefRangeStart = 1307850, XrefRangeEnd = 1307850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00059BE0 File Offset: 0x00057DE0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 639726, RefRangeEnd = 639747, XrefRangeStart = 639726, XrefRangeEnd = 639747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00059C2C File Offset: 0x00057E2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1307852, RefRangeEnd = 1307855, XrefRangeStart = 1307852, XrefRangeEnd = 1307852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Guid a, Guid b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00059C78 File Offset: 0x00057E78
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1307856, RefRangeEnd = 1307866, XrefRangeStart = 1307855, XrefRangeEnd = 1307856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00059CB4 File Offset: 0x00057EB4
		[CallerCount(0)]
		public unsafe static char HexToChar(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00059CF4 File Offset: 0x00057EF4
		[CallerCount(0)]
		public unsafe static int HexsToChars(char* guidChars, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00059D4C File Offset: 0x00057F4C
		[CallerCount(0)]
		public unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = guidChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00059DA4 File Offset: 0x00057FA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1307881, RefRangeEnd = 1307888, XrefRangeStart = 1307866, XrefRangeEnd = 1307881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00059DF4 File Offset: 0x00057FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1307905, RefRangeEnd = 1307907, XrefRangeStart = 1307888, XrefRangeEnd = 1307905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00059E60 File Offset: 0x00058060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307907, XrefRangeEnd = 1307908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_ISpanFormattable_TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00004DBB File Offset: 0x00002FBB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Guid>.NativeClassPtr, ref this));
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00059EE0 File Offset: 0x000580E0
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x00004DCD File Offset: 0x00002FCD
		public unsafe static Guid Empty
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Guid.NativeFieldInfoPtr_Empty, (void*)(&value));
			}
		}

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr__a;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr__b;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr__c;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr__d;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr__e;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr__f;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr__g;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr__h;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr__i;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr__j;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr__k;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_String_byref_Guid_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_byref_Guid_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_WriteByteHelper_Private_Void_Span_1_Byte_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000941 RID: 2369
		[FieldOffset(0)]
		public int _a;

		// Token: 0x04000942 RID: 2370
		[FieldOffset(4)]
		public short _b;

		// Token: 0x04000943 RID: 2371
		[FieldOffset(6)]
		public short _c;

		// Token: 0x04000944 RID: 2372
		[FieldOffset(8)]
		public byte _d;

		// Token: 0x04000945 RID: 2373
		[FieldOffset(9)]
		public byte _e;

		// Token: 0x04000946 RID: 2374
		[FieldOffset(10)]
		public byte _f;

		// Token: 0x04000947 RID: 2375
		[FieldOffset(11)]
		public byte _g;

		// Token: 0x04000948 RID: 2376
		[FieldOffset(12)]
		public byte _h;

		// Token: 0x04000949 RID: 2377
		[FieldOffset(13)]
		public byte _i;

		// Token: 0x0400094A RID: 2378
		[FieldOffset(14)]
		public byte _j;

		// Token: 0x0400094B RID: 2379
		[FieldOffset(15)]
		public byte _k;

		// Token: 0x02000589 RID: 1417
		[Flags]
		public enum GuidStyles
		{
			// Token: 0x040046E6 RID: 18150
			None = 0,
			// Token: 0x040046E7 RID: 18151
			AllowParenthesis = 1,
			// Token: 0x040046E8 RID: 18152
			AllowBraces = 2,
			// Token: 0x040046E9 RID: 18153
			AllowDashes = 4,
			// Token: 0x040046EA RID: 18154
			AllowHexPrefix = 8,
			// Token: 0x040046EB RID: 18155
			RequireParenthesis = 16,
			// Token: 0x040046EC RID: 18156
			RequireBraces = 32,
			// Token: 0x040046ED RID: 18157
			RequireDashes = 64,
			// Token: 0x040046EE RID: 18158
			RequireHexPrefix = 128,
			// Token: 0x040046EF RID: 18159
			HexFormat = 160,
			// Token: 0x040046F0 RID: 18160
			NumberFormat = 0,
			// Token: 0x040046F1 RID: 18161
			DigitFormat = 64,
			// Token: 0x040046F2 RID: 18162
			BraceFormat = 96,
			// Token: 0x040046F3 RID: 18163
			ParenthesisFormat = 80,
			// Token: 0x040046F4 RID: 18164
			Any = 15
		}

		// Token: 0x0200058A RID: 1418
		public enum GuidParseThrowStyle
		{
			// Token: 0x040046F6 RID: 18166
			None,
			// Token: 0x040046F7 RID: 18167
			All,
			// Token: 0x040046F8 RID: 18168
			AllButOverflow
		}

		// Token: 0x0200058B RID: 1419
		public enum ParseFailureKind
		{
			// Token: 0x040046FA RID: 18170
			None,
			// Token: 0x040046FB RID: 18171
			ArgumentNull,
			// Token: 0x040046FC RID: 18172
			Format,
			// Token: 0x040046FD RID: 18173
			FormatWithParameter,
			// Token: 0x040046FE RID: 18174
			NativeException,
			// Token: 0x040046FF RID: 18175
			FormatWithInnerException
		}

		// Token: 0x0200058C RID: 1420
		public sealed class GuidResult : ValueType
		{
			// Token: 0x06005694 RID: 22164 RVA: 0x0018F774 File Offset: 0x0018D974
			// Note: this type is marked as 'beforefieldinit'.
			static GuidResult()
			{
				Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Guid>.NativeClassPtr, "GuidResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr);
				Guid.GuidResult.NativeFieldInfoPtr__parsedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_parsedGuid");
				Guid.GuidResult.NativeFieldInfoPtr__throwStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_throwStyle");
				Guid.GuidResult.NativeFieldInfoPtr__failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_failure");
				Guid.GuidResult.NativeFieldInfoPtr__failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_failureMessageID");
				Guid.GuidResult.NativeFieldInfoPtr__failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_failureMessageFormatArgument");
				Guid.GuidResult.NativeFieldInfoPtr__failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_failureArgumentName");
				Guid.GuidResult.NativeFieldInfoPtr__innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, "_innerException");
				Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665268);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665269);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665270);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665271);
				Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665272);
				Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr, 100665273);
			}

			// Token: 0x06005695 RID: 22165 RVA: 0x0018F8A4 File Offset: 0x0018DAA4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Guid.GuidParseThrowStyle canThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref canThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005696 RID: 22166 RVA: 0x0018F8E8 File Offset: 0x0018DAE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307447, XrefRangeEnd = 1307448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Exception nativeException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeException);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005697 RID: 22167 RVA: 0x0018F930 File Offset: 0x0018DB30
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1307452, RefRangeEnd = 1307457, XrefRangeStart = 1307448, XrefRangeEnd = 1307452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005698 RID: 22168 RVA: 0x0018F988 File Offset: 0x0018DB88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1307461, RefRangeEnd = 1307465, XrefRangeStart = 1307457, XrefRangeEnd = 1307461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005699 RID: 22169 RVA: 0x0018F9F0 File Offset: 0x0018DBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307465, XrefRangeEnd = 1307469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600569A RID: 22170 RVA: 0x0018FA80 File Offset: 0x0018DC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307469, XrefRangeEnd = 1307476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetGuidParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Guid.GuidResult.NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x0600569B RID: 22171 RVA: 0x0001ECD4 File Offset: 0x0001CED4
			public GuidResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600569C RID: 22172 RVA: 0x0001ECDD File Offset: 0x0001CEDD
			public GuidResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Guid.GuidResult>.NativeClassPtr))
			{
			}

			// Token: 0x17001622 RID: 5666
			// (get) Token: 0x0600569D RID: 22173 RVA: 0x0018FAC4 File Offset: 0x0018DCC4
			// (set) Token: 0x0600569E RID: 22174 RVA: 0x0001ECEF File Offset: 0x0001CEEF
			public unsafe Guid _parsedGuid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__parsedGuid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__parsedGuid)) = value;
				}
			}

			// Token: 0x17001623 RID: 5667
			// (get) Token: 0x0600569F RID: 22175 RVA: 0x0018FAEC File Offset: 0x0018DCEC
			// (set) Token: 0x060056A0 RID: 22176 RVA: 0x0001ED0A File Offset: 0x0001CF0A
			public unsafe Guid.GuidParseThrowStyle _throwStyle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__throwStyle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__throwStyle)) = value;
				}
			}

			// Token: 0x17001624 RID: 5668
			// (get) Token: 0x060056A1 RID: 22177 RVA: 0x0018FB14 File Offset: 0x0018DD14
			// (set) Token: 0x060056A2 RID: 22178 RVA: 0x0001ED25 File Offset: 0x0001CF25
			public unsafe Guid.ParseFailureKind _failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failure)) = value;
				}
			}

			// Token: 0x17001625 RID: 5669
			// (get) Token: 0x060056A3 RID: 22179 RVA: 0x0018FB3C File Offset: 0x0018DD3C
			// (set) Token: 0x060056A4 RID: 22180 RVA: 0x0001ED40 File Offset: 0x0001CF40
			public unsafe string _failureMessageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureMessageID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001626 RID: 5670
			// (get) Token: 0x060056A5 RID: 22181 RVA: 0x0018FB64 File Offset: 0x0018DD64
			// (set) Token: 0x060056A6 RID: 22182 RVA: 0x0001ED5F File Offset: 0x0001CF5F
			public unsafe Object _failureMessageFormatArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureMessageFormatArgument);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001627 RID: 5671
			// (get) Token: 0x060056A7 RID: 22183 RVA: 0x0018FB94 File Offset: 0x0018DD94
			// (set) Token: 0x060056A8 RID: 22184 RVA: 0x0001ED7E File Offset: 0x0001CF7E
			public unsafe string _failureArgumentName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureArgumentName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001628 RID: 5672
			// (get) Token: 0x060056A9 RID: 22185 RVA: 0x0018FBBC File Offset: 0x0018DDBC
			// (set) Token: 0x060056AA RID: 22186 RVA: 0x0001ED9D File Offset: 0x0001CF9D
			public unsafe Exception _innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Guid.GuidResult.NativeFieldInfoPtr__innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004700 RID: 18176
			private static readonly IntPtr NativeFieldInfoPtr__parsedGuid;

			// Token: 0x04004701 RID: 18177
			private static readonly IntPtr NativeFieldInfoPtr__throwStyle;

			// Token: 0x04004702 RID: 18178
			private static readonly IntPtr NativeFieldInfoPtr__failure;

			// Token: 0x04004703 RID: 18179
			private static readonly IntPtr NativeFieldInfoPtr__failureMessageID;

			// Token: 0x04004704 RID: 18180
			private static readonly IntPtr NativeFieldInfoPtr__failureMessageFormatArgument;

			// Token: 0x04004705 RID: 18181
			private static readonly IntPtr NativeFieldInfoPtr__failureArgumentName;

			// Token: 0x04004706 RID: 18182
			private static readonly IntPtr NativeFieldInfoPtr__innerException;

			// Token: 0x04004707 RID: 18183
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0;

			// Token: 0x04004708 RID: 18184
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

			// Token: 0x04004709 RID: 18185
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x0400470A RID: 18186
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

			// Token: 0x0400470B RID: 18187
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0;

			// Token: 0x0400470C RID: 18188
			private static readonly IntPtr NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0;
		}
	}
}
