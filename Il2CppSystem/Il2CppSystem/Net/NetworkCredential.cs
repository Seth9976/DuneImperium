using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security;

namespace Il2CppSystem.Net
{
	// Token: 0x020001BD RID: 445
	public class NetworkCredential : Object
	{
		// Token: 0x06001B50 RID: 6992 RVA: 0x00086CC4 File Offset: 0x00084EC4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkCredential()
		{
			Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "NetworkCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr);
			NetworkCredential.NativeFieldInfoPtr_m_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_domain");
			NetworkCredential.NativeFieldInfoPtr_m_userName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_userName");
			NetworkCredential.NativeFieldInfoPtr_m_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, "m_password");
			NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667507);
			NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667508);
			NetworkCredential.NativeMethodInfoPtr_get_UserName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667509);
			NetworkCredential.NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667510);
			NetworkCredential.NativeMethodInfoPtr_get_Password_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667511);
			NetworkCredential.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667512);
			NetworkCredential.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667513);
			NetworkCredential.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667514);
			NetworkCredential.NativeMethodInfoPtr_InternalGetUserName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667515);
			NetworkCredential.NativeMethodInfoPtr_InternalGetPassword_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667516);
			NetworkCredential.NativeMethodInfoPtr_InternalGetDomain_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667517);
			NetworkCredential.NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr, 100667518);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00086E20 File Offset: 0x00085020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474645, RefRangeEnd = 474646, XrefRangeStart = 474634, XrefRangeEnd = 474645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkCredential(string userName, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00086E80 File Offset: 0x00085080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 474655, RefRangeEnd = 474656, XrefRangeStart = 474646, XrefRangeEnd = 474655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkCredential(string userName, string password, string domain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkCredential>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(domain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00086EF0 File Offset: 0x000850F0
		// (set) Token: 0x06001B54 RID: 6996 RVA: 0x00086F28 File Offset: 0x00085128
		public unsafe string UserName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_UserName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474656, XrefRangeEnd = 474659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00086F6C File Offset: 0x0008516C
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00086FA4 File Offset: 0x000851A4
		public unsafe string Password
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 474660, RefRangeEnd = 474668, XrefRangeStart = 474659, XrefRangeEnd = 474660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_Password_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474668, XrefRangeEnd = 474670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00086FE8 File Offset: 0x000851E8
		// (set) Token: 0x06001B58 RID: 7000 RVA: 0x00087020 File Offset: 0x00085220
		public unsafe string Domain
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 474670, XrefRangeEnd = 474673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00087064 File Offset: 0x00085264
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetUserName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetUserName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0008709C File Offset: 0x0008529C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 474660, RefRangeEnd = 474668, XrefRangeStart = 474660, XrefRangeEnd = 474668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetPassword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetPassword_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000870D4 File Offset: 0x000852D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetDomain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_InternalGetDomain_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0008710C File Offset: 0x0008530C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual NetworkCredential GetCredential(Uri uri, string authType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(authType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkCredential.NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0000BBD3 File Offset: 0x00009DD3
		public NetworkCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00087170 File Offset: 0x00085370
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000BBDC File Offset: 0x00009DDC
		public unsafe string m_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x00087198 File Offset: 0x00085398
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0000BBFB File Offset: 0x00009DFB
		public unsafe string m_userName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_userName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_userName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x000871C0 File Offset: 0x000853C0
		// (set) Token: 0x06001B63 RID: 7011 RVA: 0x0000BC1A File Offset: 0x00009E1A
		public unsafe SecureString m_password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecureString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkCredential.NativeFieldInfoPtr_m_password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeFieldInfoPtr_m_domain;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeFieldInfoPtr_m_userName;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeFieldInfoPtr_m_password;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_get_String_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_set_UserName_Public_set_Void_String_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_get_Password_Public_get_String_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUserName_Internal_String_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPassword_Internal_String_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDomain_Internal_String_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_GetCredential_Public_Virtual_Final_New_NetworkCredential_Uri_String_0;
	}
}
