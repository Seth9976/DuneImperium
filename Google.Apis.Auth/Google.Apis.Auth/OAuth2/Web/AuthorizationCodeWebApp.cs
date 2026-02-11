using System;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Requests;
using Google.Apis.Auth.OAuth2.Responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Web
{
	// Token: 0x02000020 RID: 32
	public class AuthorizationCodeWebApp : Object
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0000D088 File Offset: 0x0000B288
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeWebApp()
		{
			Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Web", "AuthorizationCodeWebApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr);
			AuthorizationCodeWebApp.NativeFieldInfoPtr_StateKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "StateKey");
			AuthorizationCodeWebApp.NativeFieldInfoPtr_StateRandomLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "StateRandomLength");
			AuthorizationCodeWebApp.NativeFieldInfoPtr_flow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "flow");
			AuthorizationCodeWebApp.NativeFieldInfoPtr_redirectUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "redirectUri");
			AuthorizationCodeWebApp.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "state");
			AuthorizationCodeWebApp.NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663728);
			AuthorizationCodeWebApp.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663729);
			AuthorizationCodeWebApp.NativeMethodInfoPtr_get_State_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663730);
			AuthorizationCodeWebApp.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663731);
			AuthorizationCodeWebApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Task_1_AuthResult_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663732);
			AuthorizationCodeWebApp.NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, 100663733);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000D194 File Offset: 0x0000B394
		public unsafe IAuthorizationCodeFlow Flow
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr3) : null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		public unsafe string RedirectUri
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000D20C File Offset: 0x0000B40C
		public unsafe string State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr_get_State_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000D244 File Offset: 0x0000B444
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeWebApp(IAuthorizationCodeFlow flow, string redirectUri, string state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(redirectUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000D2B4 File Offset: 0x0000B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156626, XrefRangeEnd = 1156642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<AuthorizationCodeWebApp.AuthResult> AuthorizeAsync(string userId, CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Task_1_AuthResult_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AuthorizationCodeWebApp.AuthResult>>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000D31C File Offset: 0x0000B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156642, XrefRangeEnd = 1156645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldRequestAuthorizationCode(TokenResponse token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002C66 File Offset: 0x00000E66
		public AuthorizationCodeWebApp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000D36C File Offset: 0x0000B56C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002C6F File Offset: 0x00000E6F
		public unsafe static string StateKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeWebApp.NativeFieldInfoPtr_StateKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeWebApp.NativeFieldInfoPtr_StateKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000D38C File Offset: 0x0000B58C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002C81 File Offset: 0x00000E81
		public unsafe static int StateRandomLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeWebApp.NativeFieldInfoPtr_StateRandomLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeWebApp.NativeFieldInfoPtr_StateRandomLength, (void*)(&value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002C8F File Offset: 0x00000E8F
		public unsafe IAuthorizationCodeFlow flow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_flow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_flow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002CAE File Offset: 0x00000EAE
		public unsafe string redirectUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_redirectUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_redirectUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000D400 File Offset: 0x0000B600
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002CCD File Offset: 0x00000ECD
		public unsafe string state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_state);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.NativeFieldInfoPtr_state), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_StateKey;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_StateRandomLength;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_flow;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_redirectUri;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_Flow_Public_get_IAuthorizationCodeFlow_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_String_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_String_String_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Task_1_AuthResult_String_CancellationToken_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0;

		// Token: 0x02000065 RID: 101
		public class AuthResult : Object
		{
			// Token: 0x0600062C RID: 1580 RVA: 0x0001A60C File Offset: 0x0001880C
			// Note: this type is marked as 'beforefieldinit'.
			static AuthResult()
			{
				Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "AuthResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr);
				AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__Credential_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, "<Credential>k__BackingField");
				AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__RedirectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, "<RedirectUri>k__BackingField");
				AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_get_Credential_Public_get_UserCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, 100663734);
				AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_set_Credential_Public_set_Void_UserCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, 100663735);
				AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, 100663736);
				AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, 100663737);
				AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr, 100663738);
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001A6C4 File Offset: 0x000188C4
			// (set) Token: 0x0600062E RID: 1582 RVA: 0x0001A704 File Offset: 0x00018904
			public unsafe UserCredential Credential
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_get_Credential_Public_get_UserCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_set_Credential_Public_set_Void_UserCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001A748 File Offset: 0x00018948
			// (set) Token: 0x06000630 RID: 1584 RVA: 0x0001A780 File Offset: 0x00018980
			public unsafe string RedirectUri
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x0001A7C4 File Offset: 0x000189C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AuthResult()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeWebApp.AuthResult>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp.AuthResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x000058CB File Offset: 0x00003ACB
			public AuthResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001A800 File Offset: 0x00018A00
			// (set) Token: 0x06000634 RID: 1588 RVA: 0x000058D4 File Offset: 0x00003AD4
			public unsafe UserCredential _Credential_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__Credential_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__Credential_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001A830 File Offset: 0x00018A30
			// (set) Token: 0x06000636 RID: 1590 RVA: 0x000058F3 File Offset: 0x00003AF3
			public unsafe string _RedirectUri_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__RedirectUri_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp.AuthResult.NativeFieldInfoPtr__RedirectUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040003B6 RID: 950
			private static readonly IntPtr NativeFieldInfoPtr__Credential_k__BackingField;

			// Token: 0x040003B7 RID: 951
			private static readonly IntPtr NativeFieldInfoPtr__RedirectUri_k__BackingField;

			// Token: 0x040003B8 RID: 952
			private static readonly IntPtr NativeMethodInfoPtr_get_Credential_Public_get_UserCredential_0;

			// Token: 0x040003B9 RID: 953
			private static readonly IntPtr NativeMethodInfoPtr_set_Credential_Public_set_Void_UserCredential_0;

			// Token: 0x040003BA RID: 954
			private static readonly IntPtr NativeMethodInfoPtr_get_RedirectUri_Public_get_String_0;

			// Token: 0x040003BB RID: 955
			private static readonly IntPtr NativeMethodInfoPtr_set_RedirectUri_Public_set_Void_String_0;

			// Token: 0x040003BC RID: 956
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000066 RID: 102
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Web.AuthorizationCodeWebApp+<AuthorizeAsync>d__13")]
		public sealed class _AuthorizeAsync_d__13 : ValueType
		{
			// Token: 0x06000637 RID: 1591 RVA: 0x0001A858 File Offset: 0x00018A58
			// Note: this type is marked as 'beforefieldinit'.
			static _AuthorizeAsync_d__13()
			{
				Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeWebApp>.NativeClassPtr, "<AuthorizeAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr);
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<>1__state");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<>4__this");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "userId");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<>u__1");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__codeRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<codeRequest>5__2");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__oauthState_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<oauthState>5__3");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, "<>u__2");
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, 100663739);
				AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr, 100663740);
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x0001A960 File Offset: 0x00018B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156543, XrefRangeEnd = 1156620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x0001A998 File Offset: 0x00018B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156620, XrefRangeEnd = 1156626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00005912 File Offset: 0x00003B12
			public _AuthorizeAsync_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x0000591B File Offset: 0x00003B1B
			public _AuthorizeAsync_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeWebApp._AuthorizeAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001A9E0 File Offset: 0x00018BE0
			// (set) Token: 0x0600063D RID: 1597 RVA: 0x0000592D File Offset: 0x00003B2D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x0600063E RID: 1598 RVA: 0x0001AA08 File Offset: 0x00018C08
			// (set) Token: 0x0600063F RID: 1599 RVA: 0x00005948 File Offset: 0x00003B48
			public AsyncTaskMethodBuilder<AuthorizationCodeWebApp.AuthResult> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AuthorizationCodeWebApp.AuthResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeWebApp.AuthResult>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AuthorizationCodeWebApp.AuthResult>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001AA38 File Offset: 0x00018C38
			// (set) Token: 0x06000641 RID: 1601 RVA: 0x00005976 File Offset: 0x00003B76
			public unsafe AuthorizationCodeWebApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeWebApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001AA68 File Offset: 0x00018C68
			// (set) Token: 0x06000643 RID: 1603 RVA: 0x00005995 File Offset: 0x00003B95
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001AA90 File Offset: 0x00018C90
			// (set) Token: 0x06000645 RID: 1605 RVA: 0x000059B4 File Offset: 0x00003BB4
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001AAC0 File Offset: 0x00018CC0
			// (set) Token: 0x06000647 RID: 1607 RVA: 0x000059E2 File Offset: 0x00003BE2
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001AAF0 File Offset: 0x00018CF0
			// (set) Token: 0x06000649 RID: 1609 RVA: 0x00005A10 File Offset: 0x00003C10
			public unsafe AuthorizationCodeRequestUrl _codeRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__codeRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeRequestUrl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__codeRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001AB20 File Offset: 0x00018D20
			// (set) Token: 0x0600064B RID: 1611 RVA: 0x00005A2F File Offset: 0x00003C2F
			public unsafe string _oauthState_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__oauthState_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr__oauthState_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001AB48 File Offset: 0x00018D48
			// (set) Token: 0x0600064D RID: 1613 RVA: 0x00005A4E File Offset: 0x00003C4E
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeWebApp._AuthorizeAsync_d__13.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003BD RID: 957
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003BE RID: 958
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003BF RID: 959
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003C0 RID: 960
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x040003C1 RID: 961
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040003C2 RID: 962
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003C3 RID: 963
			private static readonly IntPtr NativeFieldInfoPtr__codeRequest_5__2;

			// Token: 0x040003C4 RID: 964
			private static readonly IntPtr NativeFieldInfoPtr__oauthState_5__3;

			// Token: 0x040003C5 RID: 965
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040003C6 RID: 966
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003C7 RID: 967
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
