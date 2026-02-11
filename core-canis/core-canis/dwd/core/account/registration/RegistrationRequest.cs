using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.account.registration
{
	// Token: 0x02000224 RID: 548
	public class RegistrationRequest : Object
	{
		// Token: 0x06001DDC RID: 7644 RVA: 0x00089A88 File Offset: 0x00087C88
		// Note: this type is marked as 'beforefieldinit'.
		static RegistrationRequest()
		{
			Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.registration", "RegistrationRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr);
			RegistrationRequest.NativeFieldInfoPtr_PlatformUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "PlatformUrl");
			RegistrationRequest.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "Client");
			RegistrationRequest.NativeFieldInfoPtr_Username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "Username");
			RegistrationRequest.NativeFieldInfoPtr_Fullname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "Fullname");
			RegistrationRequest.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "Password");
			RegistrationRequest.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, "ScreenName");
			RegistrationRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr, 100668095);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00089B44 File Offset: 0x00087D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886883, RefRangeEnd = 886884, XrefRangeStart = 886876, XrefRangeEnd = 886883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistrationRequest(string platformUrl, string client, string fullname, string username, string password, string screenName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistrationRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullname);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(screenName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistrationRequest.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		public RegistrationRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00089BEC File Offset: 0x00087DEC
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0000CBCD File Offset: 0x0000ADCD
		public unsafe string PlatformUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_PlatformUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_PlatformUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00089C14 File Offset: 0x00087E14
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00089C3C File Offset: 0x00087E3C
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0000CC0B File Offset: 0x0000AE0B
		public unsafe string Username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00089C64 File Offset: 0x00087E64
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0000CC2A File Offset: 0x0000AE2A
		public unsafe string Fullname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Fullname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Fullname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00089C8C File Offset: 0x00087E8C
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0000CC49 File Offset: 0x0000AE49
		public unsafe string Password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00089CB4 File Offset: 0x00087EB4
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistrationRequest.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_PlatformUrl;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeFieldInfoPtr_Username;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr_Fullname;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeFieldInfoPtr_Password;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0;
	}
}
