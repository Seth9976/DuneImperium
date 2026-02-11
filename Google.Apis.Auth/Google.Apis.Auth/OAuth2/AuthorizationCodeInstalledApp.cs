using System;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Logging;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000008 RID: 8
	public class AuthorizationCodeInstalledApp : Object
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00007F10 File Offset: 0x00006110
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeInstalledApp()
		{
			Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "AuthorizationCodeInstalledApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr);
			AuthorizationCodeInstalledApp.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, "Logger");
			AuthorizationCodeInstalledApp.NativeFieldInfoPtr_flow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, "flow");
			AuthorizationCodeInstalledApp.NativeFieldInfoPtr_codeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, "codeReceiver");
			AuthorizationCodeInstalledApp.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, 100663407);
			AuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_Flow_Public_Virtual_Final_New_get_IAuthorizationCodeFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, 100663408);
			AuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_CodeReceiver_Public_Virtual_Final_New_get_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, 100663409);
			AuthorizationCodeInstalledApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Virtual_Final_New_Task_1_UserCredential_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, 100663410);
			AuthorizationCodeInstalledApp.NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, 100663411);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007FE0 File Offset: 0x000061E0
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeInstalledApp(IAuthorizationCodeFlow flow, ICodeReceiver codeReceiver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(codeReceiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp.NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_ICodeReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00008040 File Offset: 0x00006240
		public unsafe virtual IAuthorizationCodeFlow Flow
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_Flow_Public_Virtual_Final_New_get_IAuthorizationCodeFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr3) : null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00008080 File Offset: 0x00006280
		public unsafe virtual ICodeReceiver CodeReceiver
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp.NativeMethodInfoPtr_get_CodeReceiver_Public_Virtual_Final_New_get_ICodeReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr3) : null;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000080C0 File Offset: 0x000062C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1152837, RefRangeEnd = 1152839, XrefRangeStart = 1152821, XrefRangeEnd = 1152837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<UserCredential> AuthorizeAsync(string userId, CancellationToken taskCancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp.NativeMethodInfoPtr_AuthorizeAsync_Public_Virtual_Final_New_Task_1_UserCredential_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UserCredential>>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008128 File Offset: 0x00006328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152839, XrefRangeEnd = 1152842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldRequestAuthorizationCode(TokenResponse token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp.NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002225 File Offset: 0x00000425
		public AuthorizationCodeInstalledApp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00008178 File Offset: 0x00006378
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000222E File Offset: 0x0000042E
		public unsafe static ILogger Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000081A0 File Offset: 0x000063A0
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002240 File Offset: 0x00000440
		public unsafe IAuthorizationCodeFlow flow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_flow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAuthorizationCodeFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_flow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000081D0 File Offset: 0x000063D0
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000225F File Offset: 0x0000045F
		public unsafe ICodeReceiver codeReceiver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_codeReceiver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp.NativeFieldInfoPtr_codeReceiver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_Logger;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_flow;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_codeReceiver;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAuthorizationCodeFlow_ICodeReceiver_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_Flow_Public_Virtual_Final_New_get_IAuthorizationCodeFlow_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_CodeReceiver_Public_Virtual_Final_New_get_ICodeReceiver_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Virtual_Final_New_Task_1_UserCredential_String_CancellationToken_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRequestAuthorizationCode_Public_Boolean_TokenResponse_0;

		// Token: 0x0200003C RID: 60
		[ObfuscatedName("Google.Apis.Auth.OAuth2.AuthorizationCodeInstalledApp+<AuthorizeAsync>d__8")]
		public sealed class _AuthorizeAsync_d__8 : ValueType
		{
			// Token: 0x060003E3 RID: 995 RVA: 0x00014788 File Offset: 0x00012988
			// Note: this type is marked as 'beforefieldinit'.
			static _AuthorizeAsync_d__8()
			{
				Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthorizationCodeInstalledApp>.NativeClassPtr, "<AuthorizeAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr);
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<>1__state");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<>t__builder");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<>4__this");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "userId");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "taskCancellationToken");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<>u__1");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr__redirectUri_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<redirectUri>5__2");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, "<>u__2");
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, 100663413);
				AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr, 100663414);
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0001487C File Offset: 0x00012A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152730, XrefRangeEnd = 1152815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x000148B4 File Offset: 0x00012AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152815, XrefRangeEnd = 1152821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00003D11 File Offset: 0x00001F11
			public _AuthorizeAsync_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00003D1A File Offset: 0x00001F1A
			public _AuthorizeAsync_d__8()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeInstalledApp._AuthorizeAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000148FC File Offset: 0x00012AFC
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003D2C File Offset: 0x00001F2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00014924 File Offset: 0x00012B24
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003D47 File Offset: 0x00001F47
			public AsyncTaskMethodBuilder<UserCredential> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<UserCredential>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00014954 File Offset: 0x00012B54
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003D75 File Offset: 0x00001F75
			public unsafe AuthorizationCodeInstalledApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AuthorizationCodeInstalledApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x00014984 File Offset: 0x00012B84
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003D94 File Offset: 0x00001F94
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000149AC File Offset: 0x00012BAC
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003DB3 File Offset: 0x00001FB3
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000149DC File Offset: 0x00012BDC
			// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003DE1 File Offset: 0x00001FE1
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00014A0C File Offset: 0x00012C0C
			// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003E0F File Offset: 0x0000200F
			public unsafe string _redirectUri_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr__redirectUri_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr__redirectUri_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00014A34 File Offset: 0x00012C34
			// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003E2E File Offset: 0x0000202E
			public ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeInstalledApp._AuthorizeAsync_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AuthorizationCodeResponseUrl>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeFieldInfoPtr__redirectUri_5__2;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
