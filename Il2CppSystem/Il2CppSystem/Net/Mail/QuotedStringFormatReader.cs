using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Mail
{
	// Token: 0x0200024F RID: 591
	public static class QuotedStringFormatReader : Object
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x000B411C File Offset: 0x000B231C
		// Note: this type is marked as 'beforefieldinit'.
		static QuotedStringFormatReader()
		{
			Il2CppClassPointerStore<QuotedStringFormatReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Mail", "QuotedStringFormatReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuotedStringFormatReader>.NativeClassPtr);
			QuotedStringFormatReader.NativeMethodInfoPtr_ReadReverseQuoted_Internal_Static_Int32_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuotedStringFormatReader>.NativeClassPtr, 100669157);
			QuotedStringFormatReader.NativeMethodInfoPtr_ReadReverseUnQuoted_Internal_Static_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuotedStringFormatReader>.NativeClassPtr, 100669158);
			QuotedStringFormatReader.NativeMethodInfoPtr_IsValidQtext_Private_Static_Boolean_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuotedStringFormatReader>.NativeClassPtr, 100669159);
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000B4188 File Offset: 0x000B2388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 491039, RefRangeEnd = 491041, XrefRangeStart = 491028, XrefRangeEnd = 491039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadReverseQuoted(string data, int index, bool permitUnicode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permitUnicode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuotedStringFormatReader.NativeMethodInfoPtr_ReadReverseQuoted_Internal_Static_Int32_String_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000B41E8 File Offset: 0x000B23E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 491041, XrefRangeEnd = 491051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadReverseUnQuoted(string data, int index, bool permitUnicode, bool expectCommaDelimiter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permitUnicode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectCommaDelimiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuotedStringFormatReader.NativeMethodInfoPtr_ReadReverseUnQuoted_Internal_Static_Int32_String_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000B4254 File Offset: 0x000B2454
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 491057, RefRangeEnd = 491060, XrefRangeStart = 491051, XrefRangeEnd = 491057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidQtext(bool allowUnicode, char ch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowUnicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuotedStringFormatReader.NativeMethodInfoPtr_IsValidQtext_Private_Static_Boolean_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00011021 File Offset: 0x0000F221
		public QuotedStringFormatReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_ReadReverseQuoted_Internal_Static_Int32_String_Int32_Boolean_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_ReadReverseUnQuoted_Internal_Static_Int32_String_Int32_Boolean_Boolean_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_IsValidQtext_Private_Static_Boolean_Boolean_Char_0;
	}
}
