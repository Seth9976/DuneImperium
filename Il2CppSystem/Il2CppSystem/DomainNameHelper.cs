using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000068 RID: 104
	public class DomainNameHelper : Object
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x0003594C File Offset: 0x00033B4C
		// Note: this type is marked as 'beforefieldinit'.
		static DomainNameHelper()
		{
			Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "DomainNameHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr);
			DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664385);
			DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664386);
			DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664387);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664388);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664389);
			DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664390);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664391);
			DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664392);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664393);
			DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664394);
			DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664395);
			DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DomainNameHelper>.NativeClassPtr, 100664396);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00035A6C File Offset: 0x00033C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436559, XrefRangeEnd = 436576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &loopback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00035AD4 File Offset: 0x00033CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436577, RefRangeEnd = 436578, XrefRangeStart = 436576, XrefRangeEnd = 436577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00035B48 File Offset: 0x00033D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436580, RefRangeEnd = 436581, XrefRangeStart = 436578, XrefRangeEnd = 436580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &returnedEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notImplicitFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00035BBC File Offset: 0x00033DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436583, RefRangeEnd = 436584, XrefRangeStart = 436581, XrefRangeEnd = 436583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(string hostname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00035BF8 File Offset: 0x00033DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436586, RefRangeEnd = 436588, XrefRangeStart = 436584, XrefRangeEnd = 436586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00035C68 File Offset: 0x00033E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 436602, RefRangeEnd = 436604, XrefRangeStart = 436588, XrefRangeEnd = 436602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(bidiStrippedHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			bidiStrippedHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00035CEC File Offset: 0x00033EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 436604, XrefRangeEnd = 436608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIdnAce(string input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00035D3C File Offset: 0x00033F3C
		[CallerCount(0)]
		public unsafe static bool IsIdnAce(char* input, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00035D88 File Offset: 0x00033F88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 436613, RefRangeEnd = 436614, XrefRangeStart = 436608, XrefRangeEnd = 436613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(idnHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hostname;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00035DF0 File Offset: 0x00033FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 436651, RefRangeEnd = 436654, XrefRangeStart = 436614, XrefRangeEnd = 436651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = hostname;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &allAscii;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atLeastOneValidIdn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00035E60 File Offset: 0x00034060
		[CallerCount(0)]
		public unsafe static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00035EAC File Offset: 0x000340AC
		[CallerCount(0)]
		public unsafe static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &notCanonical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DomainNameHelper.NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000041BD File Offset: 0x000023BD
		public DomainNameHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_ParseCanonicalName_Internal_Static_String_String_Int32_Int32_byref_Boolean_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_IsValidByIri_Internal_Static_Boolean_ptr_Char_UInt16_byref_Int32_byref_Boolean_Boolean_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_String_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_IdnEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_String_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_String_Int32_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_IsIdnAce_Private_Static_Boolean_ptr_Char_Int32_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_String_ptr_Char_Int32_Int32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_UnicodeEquivalent_Internal_Static_String_ptr_Char_Int32_Int32_byref_Boolean_byref_Boolean_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_IsASCIILetterOrDigit_Private_Static_Boolean_Char_byref_Boolean_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_IsValidDomainLabelCharacter_Private_Static_Boolean_Char_byref_Boolean_0;
	}
}
