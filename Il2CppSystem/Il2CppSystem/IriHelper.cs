using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200005C RID: 92
	public static class IriHelper : Object
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00030198 File Offset: 0x0002E398
		// Note: this type is marked as 'beforefieldinit'.
		static IriHelper()
		{
			Il2CppClassPointerStore<IriHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IriHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IriHelper>.NativeClassPtr);
			IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664206);
			IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664207);
			IriHelper.NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664208);
			IriHelper.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IriHelper>.NativeClassPtr, 100664209);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00030218 File Offset: 0x0002E418
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 434024, RefRangeEnd = 434028, XrefRangeStart = 434024, XrefRangeEnd = 434024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIriUnicodeRange(char unicode, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00030264 File Offset: 0x0002E464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 434132, RefRangeEnd = 434135, XrefRangeStart = 434028, XrefRangeEnd = 434132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &surrogatePair;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isQuery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000302CC File Offset: 0x0002E4CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 434139, RefRangeEnd = 434140, XrefRangeStart = 434135, XrefRangeEnd = 434139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIsReserved(char ch, UriComponents component)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00030318 File Offset: 0x0002E518
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 434222, RefRangeEnd = 434227, XrefRangeStart = 434140, XrefRangeEnd = 434222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pInput;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IriHelper.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00003BFE File Offset: 0x00001DFE
		public IriHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Boolean_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_CheckIriUnicodeRange_Internal_Static_Boolean_Char_Char_byref_Boolean_Boolean_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsReserved_Internal_Static_Boolean_Char_UriComponents_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_Static_String_ptr_Char_Int32_Int32_UriComponents_0;
	}
}
