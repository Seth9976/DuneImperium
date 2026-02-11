using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x020001DD RID: 477
	[Serializable]
	public class CookieContainer : Object
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x0008EE7C File Offset: 0x0008D07C
		// Note: this type is marked as 'beforefieldinit'.
		static CookieContainer()
		{
			Il2CppClassPointerStore<CookieContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr);
			CookieContainer.NativeFieldInfoPtr_DefaultCookieLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "DefaultCookieLimit");
			CookieContainer.NativeFieldInfoPtr_DefaultPerDomainCookieLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "DefaultPerDomainCookieLimit");
			CookieContainer.NativeFieldInfoPtr_DefaultCookieLengthLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "DefaultCookieLengthLimit");
			CookieContainer.NativeFieldInfoPtr_HeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "HeaderInfo");
			CookieContainer.NativeFieldInfoPtr_m_domainTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_domainTable");
			CookieContainer.NativeFieldInfoPtr_m_maxCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookieSize");
			CookieContainer.NativeFieldInfoPtr_m_maxCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookies");
			CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookiesPerDomain");
			CookieContainer.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_count");
			CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_fqdnMyDomain");
			CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667822);
			CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667823);
			CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667824);
			CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667825);
			CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667826);
			CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667827);
			CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667828);
			CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667829);
			CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667830);
			CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667831);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667832);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100667833);
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0008F064 File Offset: 0x0008D264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477217, RefRangeEnd = 477219, XrefRangeStart = 477203, XrefRangeEnd = 477217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0008F0A0 File Offset: 0x0008D2A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477225, RefRangeEnd = 477227, XrefRangeStart = 477219, XrefRangeEnd = 477225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRemoveDomain(string key, PathList value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0008F0F4 File Offset: 0x0008D2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477284, RefRangeEnd = 477285, XrefRangeStart = 477227, XrefRangeEnd = 477284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0008F144 File Offset: 0x0008D344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477401, RefRangeEnd = 477403, XrefRangeStart = 477285, XrefRangeEnd = 477401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AgeCookies(string domain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0008F194 File Offset: 0x0008D394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477410, RefRangeEnd = 477411, XrefRangeStart = 477403, XrefRangeEnd = 477410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExpireCollection(CookieCollection cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0008F1E4 File Offset: 0x0008D3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477432, RefRangeEnd = 477433, XrefRangeStart = 477411, XrefRangeEnd = 477432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalDomain(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0008F234 File Offset: 0x0008D434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477498, RefRangeEnd = 477500, XrefRangeStart = 477433, XrefRangeEnd = 477498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(headerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(setCookieHeader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477554, RefRangeEnd = 477555, XrefRangeStart = 477500, XrefRangeEnd = 477554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection InternalGetCookies(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0008F308 File Offset: 0x0008D508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477612, RefRangeEnd = 477614, XrefRangeStart = 477555, XrefRangeEnd = 477612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookies);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(domainAttribute);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchOnlyPlainCookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0008F39C File Offset: 0x0008D59C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477624, RefRangeEnd = 477626, XrefRangeStart = 477614, XrefRangeEnd = 477624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlainOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0008F41C File Offset: 0x0008D61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 477631, RefRangeEnd = 477633, XrefRangeStart = 477626, XrefRangeEnd = 477631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0008F464 File Offset: 0x0008D664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 477669, RefRangeEnd = 477670, XrefRangeStart = 477633, XrefRangeEnd = 477669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri, out string optCookie2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			optCookie2 = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000C981 File Offset: 0x0000AB81
		public CookieContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0008F4C8 File Offset: 0x0008D6C8
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0000C98A File Offset: 0x0000AB8A
		public unsafe static int DefaultCookieLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_DefaultCookieLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_DefaultCookieLimit, (void*)(&value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0008F4E4 File Offset: 0x0008D6E4
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0000C998 File Offset: 0x0000AB98
		public unsafe static int DefaultPerDomainCookieLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_DefaultPerDomainCookieLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_DefaultPerDomainCookieLimit, (void*)(&value));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0008F500 File Offset: 0x0008D700
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
		public unsafe static int DefaultCookieLengthLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_DefaultCookieLengthLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_DefaultCookieLengthLimit, (void*)(&value));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0008F51C File Offset: 0x0008D71C
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		public unsafe static Il2CppReferenceArray<HeaderVariantInfo> HeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HeaderVariantInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0008F544 File Offset: 0x0008D744
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000C9C6 File Offset: 0x0000ABC6
		public unsafe Hashtable m_domainTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0008F574 File Offset: 0x0008D774
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
		public unsafe int m_maxCookieSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize)) = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0008F59C File Offset: 0x0008D79C
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000CA00 File Offset: 0x0000AC00
		public unsafe int m_maxCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies)) = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0008F5C4 File Offset: 0x0008D7C4
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000CA1B File Offset: 0x0000AC1B
		public unsafe int m_maxCookiesPerDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain)) = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0008F5EC File Offset: 0x0008D7EC
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0000CA36 File Offset: 0x0000AC36
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0008F614 File Offset: 0x0008D814
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0000CA51 File Offset: 0x0000AC51
		public unsafe string m_fqdnMyDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCookieLimit;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPerDomainCookieLimit;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCookieLengthLimit;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_HeaderInfo;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_m_domainTable;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookieSize;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookies;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookiesPerDomain;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr_m_fqdnMyDomain;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0;
	}
}
