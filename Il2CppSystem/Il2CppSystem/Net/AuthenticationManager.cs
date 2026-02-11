using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020001EA RID: 490
	public class AuthenticationManager : Object
	{
		// Token: 0x06001E85 RID: 7813 RVA: 0x00092A00 File Offset: 0x00090C00
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationManager()
		{
			Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AuthenticationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr);
			AuthenticationManager.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "modules");
			AuthenticationManager.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "locker");
			AuthenticationManager.NativeFieldInfoPtr_credential_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, "credential_policy");
			AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100667945);
			AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100667946);
			AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100667947);
			AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationManager>.NativeClassPtr, 100667948);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00092ABC File Offset: 0x00090CBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 478589, RefRangeEnd = 478591, XrefRangeStart = 478552, XrefRangeEnd = 478589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureModules()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00092AE4 File Offset: 0x00090CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478613, RefRangeEnd = 478614, XrefRangeStart = 478591, XrefRangeEnd = 478613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00092B4C File Offset: 0x00090D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 478649, RefRangeEnd = 478651, XrefRangeStart = 478614, XrefRangeEnd = 478649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(challenge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00092BB4 File Offset: 0x00090DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478676, RefRangeEnd = 478677, XrefRangeStart = 478651, XrefRangeEnd = 478676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Authorization PreAuthenticate(WebRequest request, ICredentials credentials)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationManager.NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Authorization>(intPtr3) : null;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0000CFDB File Offset: 0x0000B1DB
		public AuthenticationManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00092C0C File Offset: 0x00090E0C
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		public unsafe static ArrayList modules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_modules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_modules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x00092C34 File Offset: 0x00090E34
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x0000CFF6 File Offset: 0x0000B1F6
		public unsafe static Object locker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_locker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_locker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00092C5C File Offset: 0x00090E5C
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x0000D008 File Offset: 0x0000B208
		public unsafe static ICredentialPolicy credential_policy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentialPolicy>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthenticationManager.NativeFieldInfoPtr_credential_policy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeFieldInfoPtr_credential_policy;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr_EnsureModules_Private_Static_Void_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_Authenticate_Public_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_DoAuthenticate_Private_Static_Authorization_String_WebRequest_ICredentials_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_PreAuthenticate_Public_Static_Authorization_WebRequest_ICredentials_0;
	}
}
