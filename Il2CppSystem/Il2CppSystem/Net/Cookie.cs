using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public sealed class Cookie : Object
	{
		// Token: 0x06001CE1 RID: 7393 RVA: 0x0008C89C File Offset: 0x0008AA9C
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_PortSplitDelimiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "PortSplitDelimiters");
			Cookie.NativeFieldInfoPtr_Reserved2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "Reserved2Name");
			Cookie.NativeFieldInfoPtr_Reserved2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "Reserved2Value");
			Cookie.NativeFieldInfoPtr_staticComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "staticComparer");
			Cookie.NativeFieldInfoPtr_m_comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_comment");
			Cookie.NativeFieldInfoPtr_m_commentUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_commentUri");
			Cookie.NativeFieldInfoPtr_m_cookieVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_cookieVariant");
			Cookie.NativeFieldInfoPtr_m_discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_discard");
			Cookie.NativeFieldInfoPtr_m_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domain");
			Cookie.NativeFieldInfoPtr_m_domain_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domain_implicit");
			Cookie.NativeFieldInfoPtr_m_expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_expires");
			Cookie.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_name");
			Cookie.NativeFieldInfoPtr_m_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_path");
			Cookie.NativeFieldInfoPtr_m_path_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_path_implicit");
			Cookie.NativeFieldInfoPtr_m_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port");
			Cookie.NativeFieldInfoPtr_m_port_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port_implicit");
			Cookie.NativeFieldInfoPtr_m_port_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port_list");
			Cookie.NativeFieldInfoPtr_m_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_secure");
			Cookie.NativeFieldInfoPtr_m_httpOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_httpOnly");
			Cookie.NativeFieldInfoPtr_m_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_timeStamp");
			Cookie.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_value");
			Cookie.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_version");
			Cookie.NativeFieldInfoPtr_m_domainKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domainKey");
			Cookie.NativeFieldInfoPtr_IsQuotedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "IsQuotedVersion");
			Cookie.NativeFieldInfoPtr_IsQuotedDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "IsQuotedDomain");
			Cookie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667736);
			Cookie.NativeMethodInfoPtr_get_Comment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667737);
			Cookie.NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667738);
			Cookie.NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667739);
			Cookie.NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667740);
			Cookie.NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667741);
			Cookie.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667742);
			Cookie.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667743);
			Cookie.NativeMethodInfoPtr_get__Domain_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667744);
			Cookie.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667745);
			Cookie.NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667746);
			Cookie.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667747);
			Cookie.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667748);
			Cookie.NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667749);
			Cookie.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667750);
			Cookie.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667751);
			Cookie.NativeMethodInfoPtr_get__Path_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667752);
			Cookie.NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667753);
			Cookie.NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667754);
			Cookie.NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667755);
			Cookie.NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667756);
			Cookie.NativeMethodInfoPtr_get_Port_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667757);
			Cookie.NativeMethodInfoPtr_set_Port_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667758);
			Cookie.NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667759);
			Cookie.NativeMethodInfoPtr_get__Port_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667760);
			Cookie.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667761);
			Cookie.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667762);
			Cookie.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667763);
			Cookie.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667764);
			Cookie.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667765);
			Cookie.NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667766);
			Cookie.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667767);
			Cookie.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667768);
			Cookie.NativeMethodInfoPtr_get__Version_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667769);
			Cookie.NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667770);
			Cookie.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667771);
			Cookie.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667772);
			Cookie.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100667773);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0008CDB8 File Offset: 0x0008AFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476655, XrefRangeEnd = 476676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cookie()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cookie>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0008CDF4 File Offset: 0x0008AFF4
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0008CE2C File Offset: 0x0008B02C
		public unsafe string Comment
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Comment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476676, XrefRangeEnd = 476679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0008CE70 File Offset: 0x0008B070
		public unsafe Uri CommentUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CA RID: 2250
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0008CEB4 File Offset: 0x0008B0B4
		public unsafe bool HttpOnly
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CB RID: 2251
		// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0008CEF4 File Offset: 0x0008B0F4
		public unsafe bool Discard
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0008CF34 File Offset: 0x0008B134
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0008CF6C File Offset: 0x0008B16C
		public unsafe string Domain
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476679, XrefRangeEnd = 476685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0008CFB0 File Offset: 0x0008B1B0
		public unsafe string _Domain
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476685, XrefRangeEnd = 476693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Domain_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0008CFE8 File Offset: 0x0008B1E8
		public unsafe bool Expired
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 476698, RefRangeEnd = 476701, XrefRangeStart = 476693, XrefRangeEnd = 476698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008CF RID: 2255
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0008D024 File Offset: 0x0008B224
		public unsafe DateTime Expires
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0008D064 File Offset: 0x0008B264
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0008D09C File Offset: 0x0008B29C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476701, XrefRangeEnd = 476705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0008D0E0 File Offset: 0x0008B2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 476716, RefRangeEnd = 476719, XrefRangeStart = 476705, XrefRangeEnd = 476716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalSetName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0008D130 File Offset: 0x0008B330
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0008D168 File Offset: 0x0008B368
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476719, XrefRangeEnd = 476722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0008D1AC File Offset: 0x0008B3AC
		public unsafe string _Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476722, XrefRangeEnd = 476727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Path_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0008D1E4 File Offset: 0x0008B3E4
		public unsafe bool Plain
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x0008D220 File Offset: 0x0008B420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476727, XrefRangeEnd = 476728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDomainEqualToHost(string domain, string host)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(host);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0008D274 File Offset: 0x0008B474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476806, RefRangeEnd = 476807, XrefRangeStart = 476728, XrefRangeEnd = 476806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref variant;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalDomain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localDomain);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref set_default;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x0008D30C File Offset: 0x0008B50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476807, XrefRangeEnd = 476809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DomainCharsTest(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0008D350 File Offset: 0x0008B550
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0008D388 File Offset: 0x0008B588
		public unsafe string Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Port_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476809, XrefRangeEnd = 476835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Port_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0008D3CC File Offset: 0x0008B5CC
		public unsafe Il2CppStructArray<int> PortList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x0008D40C File Offset: 0x0008B60C
		public unsafe string _Port
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476835, XrefRangeEnd = 476839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Port_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0008D444 File Offset: 0x0008B644
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0008D480 File Offset: 0x0008B680
		public unsafe bool Secure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0008D4C0 File Offset: 0x0008B6C0
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0008D4F8 File Offset: 0x0008B6F8
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476839, XrefRangeEnd = 476843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0008D53C File Offset: 0x0008B73C
		public unsafe CookieVariant Variant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0008D578 File Offset: 0x0008B778
		public unsafe string DomainKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0008D5B0 File Offset: 0x0008B7B0
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0008D5EC File Offset: 0x0008B7EC
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0008D62C File Offset: 0x0008B82C
		public unsafe string _Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476843, XrefRangeEnd = 476847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Version_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0008D664 File Offset: 0x0008B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476847, XrefRangeEnd = 476851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer GetComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0008D698 File Offset: 0x0008B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476851, XrefRangeEnd = 476857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0008D6E8 File Offset: 0x0008B8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476857, XrefRangeEnd = 476878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0008D724 File Offset: 0x0008B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476878, XrefRangeEnd = 476953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x0000C474 File Offset: 0x0000A674
		public Cookie(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0008D75C File Offset: 0x0008B95C
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000C47D File Offset: 0x0000A67D
		public unsafe static Il2CppStructArray<char> PortSplitDelimiters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_PortSplitDelimiters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_PortSplitDelimiters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0008D784 File Offset: 0x0008B984
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0000C48F File Offset: 0x0000A68F
		public unsafe static Il2CppStructArray<char> Reserved2Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_Reserved2Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_Reserved2Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0008D7AC File Offset: 0x0008B9AC
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		public unsafe static Il2CppStructArray<char> Reserved2Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_Reserved2Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_Reserved2Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0008D7D4 File Offset: 0x0008B9D4
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000C4B3 File Offset: 0x0000A6B3
		public unsafe static Comparer staticComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_staticComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_staticComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0008D7FC File Offset: 0x0008B9FC
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
		public unsafe string m_comment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_comment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_comment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0008D824 File Offset: 0x0008BA24
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
		public unsafe Uri m_commentUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_commentUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_commentUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0008D854 File Offset: 0x0008BA54
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0000C503 File Offset: 0x0000A703
		public unsafe CookieVariant m_cookieVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_cookieVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_cookieVariant)) = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0008D87C File Offset: 0x0008BA7C
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000C51E File Offset: 0x0000A71E
		public unsafe bool m_discard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_discard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_discard)) = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000C539 File Offset: 0x0000A739
		public unsafe string m_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0008D8CC File Offset: 0x0008BACC
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0000C558 File Offset: 0x0000A758
		public unsafe bool m_domain_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain_implicit)) = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000C573 File Offset: 0x0000A773
		public unsafe DateTime m_expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_expires)) = value;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0008D91C File Offset: 0x0008BB1C
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000C58E File Offset: 0x0000A78E
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0008D944 File Offset: 0x0008BB44
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000C5AD File Offset: 0x0000A7AD
		public unsafe string m_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0008D96C File Offset: 0x0008BB6C
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		public unsafe bool m_path_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path_implicit)) = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0008D994 File Offset: 0x0008BB94
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0000C5E7 File Offset: 0x0000A7E7
		public unsafe string m_port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0008D9BC File Offset: 0x0008BBBC
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000C606 File Offset: 0x0000A806
		public unsafe bool m_port_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_implicit)) = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0008D9E4 File Offset: 0x0008BBE4
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000C621 File Offset: 0x0000A821
		public unsafe Il2CppStructArray<int> m_port_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0008DA14 File Offset: 0x0008BC14
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000C640 File Offset: 0x0000A840
		public unsafe bool m_secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_secure)) = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0008DA3C File Offset: 0x0008BC3C
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0000C65B File Offset: 0x0000A85B
		public unsafe bool m_httpOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_httpOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_httpOnly)) = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0008DA64 File Offset: 0x0008BC64
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000C676 File Offset: 0x0000A876
		public unsafe DateTime m_timeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_timeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_timeStamp)) = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0008DA8C File Offset: 0x0008BC8C
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0000C691 File Offset: 0x0000A891
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x0008DAB4 File Offset: 0x0008BCB4
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000C6B0 File Offset: 0x0000A8B0
		public unsafe int m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_version)) = value;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0008DADC File Offset: 0x0008BCDC
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000C6CB File Offset: 0x0000A8CB
		public unsafe string m_domainKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domainKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domainKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0008DB04 File Offset: 0x0008BD04
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000C6EA File Offset: 0x0000A8EA
		public unsafe bool IsQuotedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedVersion)) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0008DB2C File Offset: 0x0008BD2C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000C705 File Offset: 0x0000A905
		public unsafe bool IsQuotedDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedDomain)) = value;
			}
		}

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_PortSplitDelimiters;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_Reserved2Name;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr_Reserved2Value;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr_staticComparer;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_m_comment;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_m_commentUri;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_m_cookieVariant;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_m_discard;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_m_domain;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_m_domain_implicit;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_m_expires;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_m_path;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_m_path_implicit;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeFieldInfoPtr_m_port;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeFieldInfoPtr_m_port_implicit;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeFieldInfoPtr_m_port_list;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeFieldInfoPtr_m_secure;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeFieldInfoPtr_m_httpOnly;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeFieldInfoPtr_m_timeStamp;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_m_domainKey;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_IsQuotedVersion;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_IsQuotedDomain;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_get_Comment_Public_get_String_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeMethodInfoPtr_get__Domain_Private_get_String_0;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_get__Path_Private_get_String_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_String_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_String_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get__Port_Private_get_String_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_get__Version_Private_get_String_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
