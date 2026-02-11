using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x02000081 RID: 129
	[Serializable]
	[StructLayout(2)]
	public struct Char
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x000463D0 File Offset: 0x000445D0
		// Note: this type is marked as 'beforefieldinit'.
		static Char()
		{
			Il2CppClassPointerStore<char>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Char");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<char>.NativeClassPtr);
			Char.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "m_value");
			Char.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "MaxValue");
			Char.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "MinValue");
			Char.NativeFieldInfoPtr_s_categoryForLatin1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "s_categoryForLatin1");
			Char.NativeFieldInfoPtr_UNICODE_PLANE00_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE00_END");
			Char.NativeFieldInfoPtr_UNICODE_PLANE01_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE01_START");
			Char.NativeFieldInfoPtr_UNICODE_PLANE16_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE16_END");
			Char.NativeFieldInfoPtr_HIGH_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "HIGH_SURROGATE_START");
			Char.NativeFieldInfoPtr_LOW_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "LOW_SURROGATE_END");
			Char.NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664506);
			Char.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664507);
			Char.NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664508);
			Char.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664509);
			Char.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664510);
			Char.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664511);
			Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664512);
			Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664513);
			Char.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664514);
			Char.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664515);
			Char.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664516);
			Char.NativeMethodInfoPtr_Parse_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664517);
			Char.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664518);
			Char.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664519);
			Char.NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664520);
			Char.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664521);
			Char.NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664522);
			Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664523);
			Char.NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664524);
			Char.NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664525);
			Char.NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664526);
			Char.NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664527);
			Char.NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664528);
			Char.NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664529);
			Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664530);
			Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664531);
			Char.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664532);
			Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664533);
			Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664534);
			Char.NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664535);
			Char.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664536);
			Char.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664537);
			Char.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664538);
			Char.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664539);
			Char.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664540);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664541);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664542);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664543);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664544);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664545);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664546);
			Char.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664547);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664548);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664549);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664550);
			Char.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664551);
			Char.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664552);
			Char.NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664553);
			Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664554);
			Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664555);
			Char.NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664556);
			Char.NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664557);
			Char.NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664558);
			Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664559);
			Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664560);
			Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664561);
			Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664562);
			Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664563);
			Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664564);
			Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664565);
			Char.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664566);
			Char.NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664567);
			Char.NativeMethodInfoPtr_ConvertFromUtf32_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664568);
			Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664569);
			Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664570);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000469C8 File Offset: 0x00044BC8
		[CallerCount(0)]
		public unsafe static bool IsLatin1(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00046A08 File Offset: 0x00044C08
		[CallerCount(0)]
		public unsafe static bool IsAscii(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00046A48 File Offset: 0x00044C48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1299566, RefRangeEnd = 1299569, XrefRangeStart = 1299562, XrefRangeEnd = 1299566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00046A88 File Offset: 0x00044C88
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00046AB8 File Offset: 0x00044CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299569, XrefRangeEnd = 1299572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00046AFC File Offset: 0x00044CFC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 638959, RefRangeEnd = 638986, XrefRangeStart = 638959, XrefRangeEnd = 638986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(char obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00046B3C File Offset: 0x00044D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299575, RefRangeEnd = 1299576, XrefRangeStart = 1299572, XrefRangeEnd = 1299575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00046B80 File Offset: 0x00044D80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1299576, RefRangeEnd = 1299579, XrefRangeStart = 1299576, XrefRangeEnd = 1299576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00046BC0 File Offset: 0x00044DC0
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1299583, RefRangeEnd = 1299644, XrefRangeStart = 1299579, XrefRangeEnd = 1299583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00046BEC File Offset: 0x00044DEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1299648, RefRangeEnd = 1299654, XrefRangeStart = 1299644, XrefRangeEnd = 1299648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00046C28 File Offset: 0x00044E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1299655, RefRangeEnd = 1299657, XrefRangeStart = 1299654, XrefRangeEnd = 1299655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00046C60 File Offset: 0x00044E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299657, XrefRangeEnd = 1299670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Parse_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00046CA4 File Offset: 0x00044EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299671, RefRangeEnd = 1299672, XrefRangeStart = 1299670, XrefRangeEnd = 1299671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out char result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00046CF4 File Offset: 0x00044EF4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1299676, RefRangeEnd = 1299693, XrefRangeStart = 1299672, XrefRangeEnd = 1299676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00046D34 File Offset: 0x00044F34
		[CallerCount(0)]
		public unsafe static bool CheckLetter(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00046D74 File Offset: 0x00044F74
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1299700, RefRangeEnd = 1299711, XrefRangeStart = 1299693, XrefRangeEnd = 1299700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLetter(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00046DB4 File Offset: 0x00044FB4
		[CallerCount(0)]
		public unsafe static bool IsWhiteSpaceLatin1(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00046DF4 File Offset: 0x00044FF4
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 1299717, RefRangeEnd = 1299826, XrefRangeStart = 1299711, XrefRangeEnd = 1299717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00046E34 File Offset: 0x00045034
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1299831, RefRangeEnd = 1299844, XrefRangeStart = 1299826, XrefRangeEnd = 1299831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUpper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00046E74 File Offset: 0x00045074
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1299849, RefRangeEnd = 1299863, XrefRangeStart = 1299844, XrefRangeEnd = 1299849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00046EB4 File Offset: 0x000450B4
		[CallerCount(0)]
		public unsafe static bool CheckPunctuation(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00046EF4 File Offset: 0x000450F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1299870, RefRangeEnd = 1299873, XrefRangeStart = 1299863, XrefRangeEnd = 1299870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPunctuation(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00046F34 File Offset: 0x00045134
		[CallerCount(0)]
		public unsafe static bool CheckLetterOrDigit(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00046F74 File Offset: 0x00045174
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1299883, RefRangeEnd = 1299904, XrefRangeStart = 1299873, XrefRangeEnd = 1299883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLetterOrDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00046FB4 File Offset: 0x000451B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1299911, RefRangeEnd = 1299914, XrefRangeStart = 1299904, XrefRangeEnd = 1299911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpper(char c, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00047004 File Offset: 0x00045204
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1299919, RefRangeEnd = 1299928, XrefRangeStart = 1299914, XrefRangeEnd = 1299919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00047044 File Offset: 0x00045244
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1299933, RefRangeEnd = 1299941, XrefRangeStart = 1299928, XrefRangeEnd = 1299933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00047084 File Offset: 0x00045284
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1299948, RefRangeEnd = 1299952, XrefRangeStart = 1299941, XrefRangeEnd = 1299948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLower(char c, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000470D4 File Offset: 0x000452D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1299957, RefRangeEnd = 1299965, XrefRangeStart = 1299952, XrefRangeEnd = 1299957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00047114 File Offset: 0x00045314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1299970, RefRangeEnd = 1299971, XrefRangeStart = 1299965, XrefRangeEnd = 1299970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00047154 File Offset: 0x00045354
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00047184 File Offset: 0x00045384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299971, XrefRangeEnd = 1299980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000471C8 File Offset: 0x000453C8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 638989, RefRangeEnd = 639002, XrefRangeStart = 638989, XrefRangeEnd = 639002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0004720C File Offset: 0x0004540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299980, XrefRangeEnd = 1299984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00047250 File Offset: 0x00045450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299984, XrefRangeEnd = 1299988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00047294 File Offset: 0x00045494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299988, XrefRangeEnd = 1299992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x000472D8 File Offset: 0x000454D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299992, XrefRangeEnd = 1299995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0004731C File Offset: 0x0004551C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299995, XrefRangeEnd = 1299998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00047360 File Offset: 0x00045560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1299998, XrefRangeEnd = 1300001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000473A4 File Offset: 0x000455A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300001, XrefRangeEnd = 1300004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000473E8 File Offset: 0x000455E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300004, XrefRangeEnd = 1300007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0004742C File Offset: 0x0004562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300007, XrefRangeEnd = 1300016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00047470 File Offset: 0x00045670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300016, XrefRangeEnd = 1300025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000474B4 File Offset: 0x000456B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300025, XrefRangeEnd = 1300034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000474F8 File Offset: 0x000456F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300034, XrefRangeEnd = 1300043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0004753C File Offset: 0x0004573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300043, XrefRangeEnd = 1300050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00047594 File Offset: 0x00045794
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300055, RefRangeEnd = 1300058, XrefRangeStart = 1300050, XrefRangeEnd = 1300055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsControl(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000475D4 File Offset: 0x000457D4
		[CallerCount(0)]
		public unsafe static bool CheckNumber(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00047614 File Offset: 0x00045814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300065, RefRangeEnd = 1300067, XrefRangeStart = 1300058, XrefRangeEnd = 1300065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumber(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00047654 File Offset: 0x00045854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300075, RefRangeEnd = 1300076, XrefRangeStart = 1300067, XrefRangeEnd = 1300075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumber(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000476A4 File Offset: 0x000458A4
		[CallerCount(0)]
		public unsafe static bool CheckSeparator(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000476E4 File Offset: 0x000458E4
		[CallerCount(0)]
		public unsafe static bool IsSeparatorLatin1(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00047724 File Offset: 0x00045924
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1300083, RefRangeEnd = 1300102, XrefRangeStart = 1300076, XrefRangeEnd = 1300083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00047764 File Offset: 0x00045964
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1300102, RefRangeEnd = 1300112, XrefRangeStart = 1300102, XrefRangeEnd = 1300102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000477A4 File Offset: 0x000459A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300116, RefRangeEnd = 1300119, XrefRangeStart = 1300112, XrefRangeEnd = 1300116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000477F4 File Offset: 0x000459F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1300127, RefRangeEnd = 1300131, XrefRangeStart = 1300119, XrefRangeEnd = 1300127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00047844 File Offset: 0x00045A44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1300138, RefRangeEnd = 1300146, XrefRangeStart = 1300131, XrefRangeEnd = 1300138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00047884 File Offset: 0x00045A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300167, RefRangeEnd = 1300169, XrefRangeStart = 1300146, XrefRangeEnd = 1300167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000478D4 File Offset: 0x00045AD4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300169, RefRangeEnd = 1300183, XrefRangeStart = 1300169, XrefRangeEnd = 1300169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00047914 File Offset: 0x00045B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300187, RefRangeEnd = 1300189, XrefRangeStart = 1300183, XrefRangeEnd = 1300187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00047964 File Offset: 0x00045B64
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1300189, RefRangeEnd = 1300205, XrefRangeStart = 1300189, XrefRangeEnd = 1300189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLowSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000479A4 File Offset: 0x00045BA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300205, RefRangeEnd = 1300210, XrefRangeStart = 1300205, XrefRangeEnd = 1300205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000479F0 File Offset: 0x00045BF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300212, RefRangeEnd = 1300214, XrefRangeStart = 1300210, XrefRangeEnd = 1300212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertFromUtf32(int utf32)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref utf32;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ConvertFromUtf32_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00047A28 File Offset: 0x00045C28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300219, RefRangeEnd = 1300220, XrefRangeStart = 1300214, XrefRangeEnd = 1300219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00047A74 File Offset: 0x00045C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300222, RefRangeEnd = 1300223, XrefRangeStart = 1300220, XrefRangeEnd = 1300222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToUtf32(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00004235 File Offset: 0x00002435
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<char>.NativeClassPtr, ref this));
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00047AC4 File Offset: 0x00045CC4
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x00004247 File Offset: 0x00002447
		public unsafe static char MaxValue
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_MaxValue, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00047AE0 File Offset: 0x00045CE0
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00004255 File Offset: 0x00002455
		public unsafe static char MinValue
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_MinValue, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00047AFC File Offset: 0x00045CFC
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00004263 File Offset: 0x00002463
		public unsafe static Il2CppStructArray<byte> s_categoryForLatin1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_s_categoryForLatin1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_s_categoryForLatin1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00047B24 File Offset: 0x00045D24
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00004275 File Offset: 0x00002475
		public unsafe static int UNICODE_PLANE00_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE00_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE00_END, (void*)(&value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00047B40 File Offset: 0x00045D40
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00004283 File Offset: 0x00002483
		public unsafe static int UNICODE_PLANE01_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00047B5C File Offset: 0x00045D5C
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00004291 File Offset: 0x00002491
		public unsafe static int UNICODE_PLANE16_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE16_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE16_END, (void*)(&value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00047B78 File Offset: 0x00045D78
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0000429F File Offset: 0x0000249F
		public unsafe static int HIGH_SURROGATE_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00047B94 File Offset: 0x00045D94
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x000042AD File Offset: 0x000024AD
		public unsafe static int LOW_SURROGATE_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_s_categoryForLatin1;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE00_END;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE01_START;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE16_END;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_START;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_END;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Char_String_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_String_Int32_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromUtf32_Public_Static_String_Int32_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_String_Int32_0;

		// Token: 0x040005A8 RID: 1448
		[FieldOffset(0)]
		public readonly char m_value;
	}
}
