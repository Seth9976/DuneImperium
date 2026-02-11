using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000005 RID: 5
	public static class BigNumber : Object
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00004D18 File Offset: 0x00002F18
		// Note: this type is marked as 'beforefieldinit'.
		static BigNumber()
		{
			Il2CppClassPointerStore<BigNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "BigNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigNumber>.NativeClassPtr);
			BigNumber.NativeMethodInfoPtr_TryValidateParseStyleInteger_Internal_Static_Boolean_NumberStyles_byref_ArgumentException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663394);
			BigNumber.NativeMethodInfoPtr_TryParseBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663395);
			BigNumber.NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663396);
			BigNumber.NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663397);
			BigNumber.NativeMethodInfoPtr_HexNumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663398);
			BigNumber.NativeMethodInfoPtr_NumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663399);
			BigNumber.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663400);
			BigNumber.NativeMethodInfoPtr_FormatBigIntegerToHex_Private_Static_String_Boolean_BigInteger_Char_Int32_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663401);
			BigNumber.NativeMethodInfoPtr_FormatBigInteger_Internal_Static_String_BigInteger_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663402);
			BigNumber.NativeMethodInfoPtr_FormatBigInteger_Private_Static_String_Boolean_BigInteger_String_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, 100663403);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00004E10 File Offset: 0x00003010
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1236038, RefRangeEnd = 1236041, XrefRangeStart = 1236033, XrefRangeEnd = 1236038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_TryValidateParseStyleInteger_Internal_Static_Boolean_NumberStyles_byref_ArgumentException_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new ArgumentException(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004E70 File Offset: 0x00003070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236072, RefRangeEnd = 1236074, XrefRangeStart = 1236041, XrefRangeEnd = 1236072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_TryParseBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_BigInteger_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new BigInteger(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004EFC File Offset: 0x000030FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236085, RefRangeEnd = 1236087, XrefRangeStart = 1236074, XrefRangeEnd = 1236085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004F58 File Offset: 0x00003158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236087, XrefRangeEnd = 1236096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new BigInteger(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004FBC File Offset: 0x000031BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236111, RefRangeEnd = 1236112, XrefRangeStart = 1236096, XrefRangeEnd = 1236111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(number);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_HexNumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005014 File Offset: 0x00003214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236133, RefRangeEnd = 1236134, XrefRangeStart = 1236112, XrefRangeEnd = 1236133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(number);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_NumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000506C File Offset: 0x0000326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236134, XrefRangeEnd = 1236135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000050C0 File Offset: 0x000032C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236209, RefRangeEnd = 1236210, XrefRangeStart = 1236135, XrefRangeEnd = 1236209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetSpan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spanSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_FormatBigIntegerToHex_Private_Static_String_Boolean_BigInteger_Char_Int32_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005174 File Offset: 0x00003374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236210, XrefRangeEnd = 1236214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_FormatBigInteger_Internal_Static_String_BigInteger_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000051DC File Offset: 0x000033DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1236274, RefRangeEnd = 1236278, XrefRangeStart = 1236214, XrefRangeEnd = 1236274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetSpan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(formatString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(formatSpan));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spanSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.NativeMethodInfoPtr_FormatBigInteger_Private_Static_String_Boolean_BigInteger_String_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002196 File Offset: 0x00000396
		public BigNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_TryValidateParseStyleInteger_Internal_Static_Boolean_NumberStyles_byref_ArgumentException_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_TryParseBigInteger_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_BigInteger_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_ParseBigInteger_Internal_Static_BigInteger_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_NumberToBigInteger_Private_Static_Boolean_byref_BigNumberBuffer_byref_BigInteger_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_FormatBigIntegerToHex_Private_Static_String_Boolean_BigInteger_Char_Int32_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_FormatBigInteger_Internal_Static_String_BigInteger_String_NumberFormatInfo_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_FormatBigInteger_Private_Static_String_Boolean_BigInteger_String_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_byref_Boolean_0;

		// Token: 0x0200000B RID: 11
		public sealed class BigNumberBuffer : ValueType
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x00005E60 File Offset: 0x00004060
			// Note: this type is marked as 'beforefieldinit'.
			static BigNumberBuffer()
			{
				Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigNumber>.NativeClassPtr, "BigNumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr);
				BigNumber.BigNumberBuffer.NativeFieldInfoPtr_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr, "digits");
				BigNumber.BigNumberBuffer.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr, "precision");
				BigNumber.BigNumberBuffer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr, "scale");
				BigNumber.BigNumberBuffer.NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr, "sign");
				BigNumber.BigNumberBuffer.NativeMethodInfoPtr_Create_Public_Static_BigNumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr, 100663404);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00005EF0 File Offset: 0x000040F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1236028, XrefRangeEnd = 1236033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigNumber.BigNumberBuffer Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigNumber.BigNumberBuffer.NativeMethodInfoPtr_Create_Public_Static_BigNumberBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigNumber.BigNumberBuffer(intPtr);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00002246 File Offset: 0x00000446
			public BigNumberBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x0000224F File Offset: 0x0000044F
			public BigNumberBuffer()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigNumber.BigNumberBuffer>.NativeClassPtr))
			{
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00005F1C File Offset: 0x0000411C
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002261 File Offset: 0x00000461
			public unsafe StringBuilder digits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_digits);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_digits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005F4C File Offset: 0x0000414C
			// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002280 File Offset: 0x00000480
			public unsafe int precision
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_precision);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_precision)) = value;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005F74 File Offset: 0x00004174
			// (set) Token: 0x060000BA RID: 186 RVA: 0x0000229B File Offset: 0x0000049B
			public unsafe int scale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060000BB RID: 187 RVA: 0x00005F9C File Offset: 0x0000419C
			// (set) Token: 0x060000BC RID: 188 RVA: 0x000022B6 File Offset: 0x000004B6
			public unsafe bool sign
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_sign);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigNumber.BigNumberBuffer.NativeFieldInfoPtr_sign)) = value;
				}
			}

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeFieldInfoPtr_digits;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeFieldInfoPtr_precision;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeFieldInfoPtr_sign;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_BigNumberBuffer_0;
		}
	}
}
