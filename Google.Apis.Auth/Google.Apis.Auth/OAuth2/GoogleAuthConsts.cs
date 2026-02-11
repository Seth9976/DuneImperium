using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200000D RID: 13
	public static class GoogleAuthConsts : Object
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00008E04 File Offset: 0x00007004
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleAuthConsts()
		{
			Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "GoogleAuthConsts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr);
			GoogleAuthConsts.NativeFieldInfoPtr_AuthorizationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "AuthorizationUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_OidcAuthorizationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "OidcAuthorizationUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_ApprovalUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "ApprovalUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_TokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "TokenUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_OidcTokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "OidcTokenUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_ComputeTokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "ComputeTokenUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_RevokeTokenUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "RevokeTokenUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_JsonWebKeySetUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "JsonWebKeySetUrl");
			GoogleAuthConsts.NativeFieldInfoPtr_InstalledAppRedirectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "InstalledAppRedirectUri");
			GoogleAuthConsts.NativeFieldInfoPtr_LocalhostRedirectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAuthConsts>.NativeClassPtr, "LocalhostRedirectUri");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000242C File Offset: 0x0000062C
		public GoogleAuthConsts(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00008EFC File Offset: 0x000070FC
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002435 File Offset: 0x00000635
		public unsafe static string AuthorizationUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_AuthorizationUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_AuthorizationUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00008F1C File Offset: 0x0000711C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002447 File Offset: 0x00000647
		public unsafe static string OidcAuthorizationUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_OidcAuthorizationUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_OidcAuthorizationUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00008F3C File Offset: 0x0000713C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002459 File Offset: 0x00000659
		public unsafe static string ApprovalUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_ApprovalUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_ApprovalUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00008F5C File Offset: 0x0000715C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000246B File Offset: 0x0000066B
		public unsafe static string TokenUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_TokenUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_TokenUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00008F7C File Offset: 0x0000717C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe static string OidcTokenUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_OidcTokenUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_OidcTokenUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00008F9C File Offset: 0x0000719C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000248F File Offset: 0x0000068F
		public unsafe static string ComputeTokenUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_ComputeTokenUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_ComputeTokenUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00008FBC File Offset: 0x000071BC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000024A1 File Offset: 0x000006A1
		public unsafe static string RevokeTokenUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_RevokeTokenUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_RevokeTokenUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00008FDC File Offset: 0x000071DC
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000024B3 File Offset: 0x000006B3
		public unsafe static string JsonWebKeySetUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_JsonWebKeySetUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_JsonWebKeySetUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00008FFC File Offset: 0x000071FC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024C5 File Offset: 0x000006C5
		public unsafe static string InstalledAppRedirectUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_InstalledAppRedirectUri, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_InstalledAppRedirectUri, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000901C File Offset: 0x0000721C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000024D7 File Offset: 0x000006D7
		public unsafe static string LocalhostRedirectUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleAuthConsts.NativeFieldInfoPtr_LocalhostRedirectUri, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleAuthConsts.NativeFieldInfoPtr_LocalhostRedirectUri, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_AuthorizationUrl;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_OidcAuthorizationUrl;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_ApprovalUrl;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_TokenUrl;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_OidcTokenUrl;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_ComputeTokenUrl;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_RevokeTokenUrl;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_JsonWebKeySetUrl;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_InstalledAppRedirectUri;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_LocalhostRedirectUri;
	}
}
