using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D8 RID: 472
	public class CookieTokenizer : Object
	{
		// Token: 0x06001D3B RID: 7483 RVA: 0x0008DB54 File Offset: 0x0008BD54
		// Note: this type is marked as 'beforefieldinit'.
		static CookieTokenizer()
		{
			Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr);
			CookieTokenizer.NativeFieldInfoPtr_m_eofCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_eofCookie");
			CookieTokenizer.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_index");
			CookieTokenizer.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_length");
			CookieTokenizer.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_name");
			CookieTokenizer.NativeFieldInfoPtr_m_quoted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_quoted");
			CookieTokenizer.NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_start");
			CookieTokenizer.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_token");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenLength");
			CookieTokenizer.NativeFieldInfoPtr_m_tokenStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_tokenStream");
			CookieTokenizer.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "m_value");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttributes");
			CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedServerAttributes");
			CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667775);
			CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667776);
			CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667777);
			CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667778);
			CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667779);
			CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667780);
			CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667781);
			CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667782);
			CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667783);
			CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667784);
			CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667785);
			CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667786);
			CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667787);
			CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667788);
			CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667789);
			CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667790);
			CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, 100667791);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0008DDC8 File Offset: 0x0008BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476954, XrefRangeEnd = 476957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieTokenizer(string tokenStream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0008DE14 File Offset: 0x0008C014
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0008DE50 File Offset: 0x0008C050
		public unsafe bool EndOfCookie
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0008DE90 File Offset: 0x0008C090
		public unsafe bool Eof
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0008DECC File Offset: 0x0008C0CC
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0008DF04 File Offset: 0x0008C104
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0008DF48 File Offset: 0x0008C148
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0008DF84 File Offset: 0x0008C184
		public unsafe bool Quoted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0008DFC4 File Offset: 0x0008C1C4
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x0008E000 File Offset: 0x0008C200
		public unsafe CookieToken Token
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x0008E040 File Offset: 0x0008C240
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x0008E078 File Offset: 0x0008C278
		public unsafe string Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_get_Value_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0008E0BC File Offset: 0x0008C2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476957, XrefRangeEnd = 476961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Extract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Extract_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0008E0F4 File Offset: 0x0008C2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476975, RefRangeEnd = 476976, XrefRangeStart = 476961, XrefRangeEnd = 476975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ignoreComma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreEquals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0008E14C File Offset: 0x0008C34C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476987, RefRangeEnd = 476988, XrefRangeStart = 476976, XrefRangeEnd = 476987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken Next(bool first, bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseResponseCookies;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0008E1A4 File Offset: 0x0008C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476988, XrefRangeEnd = 476993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0008E1D8 File Offset: 0x0008C3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476993, XrefRangeEnd = 477015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieToken TokenFromName(bool parseResponseCookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parseResponseCookies;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0000C720 File Offset: 0x0000A920
		public CookieTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x0008E224 File Offset: 0x0008C424
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0000C729 File Offset: 0x0000A929
		public unsafe bool m_eofCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_eofCookie)) = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x0008E24C File Offset: 0x0008C44C
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x0000C744 File Offset: 0x0000A944
		public unsafe int m_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_index)) = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x0008E274 File Offset: 0x0008C474
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0000C75F File Offset: 0x0000A95F
		public unsafe int m_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_length)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x0008E29C File Offset: 0x0008C49C
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x0000C77A File Offset: 0x0000A97A
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0008E2C4 File Offset: 0x0008C4C4
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x0000C799 File Offset: 0x0000A999
		public unsafe bool m_quoted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_quoted)) = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0008E2EC File Offset: 0x0008C4EC
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
		public unsafe int m_start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_start)) = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0008E314 File Offset: 0x0008C514
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000C7CF File Offset: 0x0000A9CF
		public unsafe CookieToken m_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_token)) = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0008E33C File Offset: 0x0008C53C
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000C7EA File Offset: 0x0000A9EA
		public unsafe int m_tokenLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenLength)) = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0008E364 File Offset: 0x0008C564
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000C805 File Offset: 0x0000AA05
		public unsafe string m_tokenStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_tokenStream), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0008E38C File Offset: 0x0008C58C
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0000C824 File Offset: 0x0000AA24
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0008E3B4 File Offset: 0x0008C5B4
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0000C843 File Offset: 0x0000AA43
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0008E3DC File Offset: 0x0008C5DC
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000C855 File Offset: 0x0000AA55
		public unsafe static Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute> RecognizedServerAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookieTokenizer.RecognizedAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieTokenizer.NativeFieldInfoPtr_RecognizedServerAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeFieldInfoPtr_m_eofCookie;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeFieldInfoPtr_m_index;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeFieldInfoPtr_m_quoted;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeFieldInfoPtr_m_start;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeFieldInfoPtr_m_token;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenLength;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenStream;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedAttributes;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeFieldInfoPtr_RecognizedServerAttributes;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfCookie_Internal_get_Boolean_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_set_EndOfCookie_Internal_set_Void_Boolean_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_get_Eof_Internal_get_Boolean_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_String_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_get_Quoted_Internal_get_Boolean_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_set_Quoted_Internal_set_Void_Boolean_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_set_Token_Internal_set_Void_CookieToken_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Internal_get_String_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_String_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Internal_String_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_FindNext_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_Next_Internal_CookieToken_Boolean_Boolean_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_TokenFromName_Internal_CookieToken_Boolean_0;

		// Token: 0x0200032B RID: 811
		public sealed class RecognizedAttribute : ValueType
		{
			// Token: 0x06002F2F RID: 12079 RVA: 0x000CDE90 File Offset: 0x000CC090
			// Note: this type is marked as 'beforefieldinit'.
			static RecognizedAttribute()
			{
				Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieTokenizer>.NativeClassPtr, "RecognizedAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr);
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_name");
				CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, "m_token");
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100667793);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100667794);
				CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr, 100667795);
			}

			// Token: 0x06002F30 RID: 12080 RVA: 0x000CDF20 File Offset: 0x000CC120
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecognizedAttribute(string name, CookieToken token)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000CDF80 File Offset: 0x000CC180
			public unsafe CookieToken Token
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F32 RID: 12082 RVA: 0x000CDFC4 File Offset: 0x000CC1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476953, XrefRangeEnd = 476954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsEqualTo(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieTokenizer.RecognizedAttribute.NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x00015223 File Offset: 0x00013423
			public RecognizedAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x0001522C File Offset: 0x0001342C
			public RecognizedAttribute()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieTokenizer.RecognizedAttribute>.NativeClassPtr))
			{
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000CE018 File Offset: 0x000CC218
			// (set) Token: 0x06002F36 RID: 12086 RVA: 0x0001523E File Offset: 0x0001343E
			public unsafe string m_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x06002F37 RID: 12087 RVA: 0x000CE040 File Offset: 0x000CC240
			// (set) Token: 0x06002F38 RID: 12088 RVA: 0x0001525D File Offset: 0x0001345D
			public unsafe CookieToken m_token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieTokenizer.RecognizedAttribute.NativeFieldInfoPtr_m_token)) = value;
				}
			}

			// Token: 0x040024FE RID: 9470
			private static readonly IntPtr NativeFieldInfoPtr_m_name;

			// Token: 0x040024FF RID: 9471
			private static readonly IntPtr NativeFieldInfoPtr_m_token;

			// Token: 0x04002500 RID: 9472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_CookieToken_0;

			// Token: 0x04002501 RID: 9473
			private static readonly IntPtr NativeMethodInfoPtr_get_Token_Internal_get_CookieToken_0;

			// Token: 0x04002502 RID: 9474
			private static readonly IntPtr NativeMethodInfoPtr_IsEqualTo_Internal_Boolean_String_0;
		}
	}
}
