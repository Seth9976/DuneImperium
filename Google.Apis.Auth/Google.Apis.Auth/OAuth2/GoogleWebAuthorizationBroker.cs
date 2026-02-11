using System;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000010 RID: 16
	public class GoogleWebAuthorizationBroker : Object
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00009A60 File Offset: 0x00007C60
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleWebAuthorizationBroker()
		{
			Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "GoogleWebAuthorizationBroker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr);
			GoogleWebAuthorizationBroker.NativeFieldInfoPtr_Folder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, "Folder");
			GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_ClientSecrets_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, 100663495);
			GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Stream_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, 100663496);
			GoogleWebAuthorizationBroker.NativeMethodInfoPtr_ReauthorizeAsync_Public_Static_Task_UserCredential_CancellationToken_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, 100663497);
			GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Initializer_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, 100663498);
			GoogleWebAuthorizationBroker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, 100663499);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00009B08 File Offset: 0x00007D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154016, XrefRangeEnd = 1154035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<UserCredential> AuthorizeAsync(ClientSecrets clientSecrets, IEnumerable<string> scopes, string user, CancellationToken taskCancellationToken, IDataStore dataStore = null, ICodeReceiver codeReceiver = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientSecrets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(user);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataStore);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(codeReceiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_ClientSecrets_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UserCredential>>(intPtr3) : null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00009BB0 File Offset: 0x00007DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154035, XrefRangeEnd = 1154054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<UserCredential> AuthorizeAsync(Stream clientSecretsStream, IEnumerable<string> scopes, string user, CancellationToken taskCancellationToken, IDataStore dataStore = null, ICodeReceiver codeReceiver = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientSecretsStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(user);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataStore);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(codeReceiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Stream_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UserCredential>>(intPtr3) : null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009C58 File Offset: 0x00007E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154054, XrefRangeEnd = 1154066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task ReauthorizeAsync(UserCredential userCredential, CancellationToken taskCancellationToken, ICodeReceiver codeReceiver = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userCredential);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(codeReceiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker.NativeMethodInfoPtr_ReauthorizeAsync_Public_Static_Task_UserCredential_CancellationToken_ICodeReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009CC8 File Offset: 0x00007EC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1154085, RefRangeEnd = 1154087, XrefRangeStart = 1154066, XrefRangeEnd = 1154085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<UserCredential> AuthorizeAsync(GoogleAuthorizationCodeFlow.Initializer initializer, IEnumerable<string> scopes, string user, CancellationToken taskCancellationToken, IDataStore dataStore = null, ICodeReceiver codeReceiver = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(user);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataStore);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(codeReceiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker.NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Initializer_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UserCredential>>(intPtr3) : null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009D70 File Offset: 0x00007F70
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleWebAuthorizationBroker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002578 File Offset: 0x00000778
		public GoogleWebAuthorizationBroker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00009DAC File Offset: 0x00007FAC
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002581 File Offset: 0x00000781
		public unsafe static string Folder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleWebAuthorizationBroker.NativeFieldInfoPtr_Folder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleWebAuthorizationBroker.NativeFieldInfoPtr_Folder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_Folder;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_ClientSecrets_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Stream_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ReauthorizeAsync_Public_Static_Task_UserCredential_CancellationToken_ICodeReceiver_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_AuthorizeAsync_Public_Static_Task_1_UserCredential_Initializer_IEnumerable_1_String_String_CancellationToken_IDataStore_ICodeReceiver_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000048 RID: 72
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker+<AuthorizeAsync>d__1")]
		public sealed class _AuthorizeAsync_d__1 : ValueType
		{
			// Token: 0x06000468 RID: 1128 RVA: 0x00015DAC File Offset: 0x00013FAC
			// Note: this type is marked as 'beforefieldinit'.
			static _AuthorizeAsync_d__1()
			{
				Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, "<AuthorizeAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "<>1__state");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "<>t__builder");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_clientSecrets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "clientSecrets");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "scopes");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "user");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "taskCancellationToken");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_dataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "dataStore");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_codeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "codeReceiver");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, "<>u__1");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, 100663501);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr, 100663502);
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x00015EB4 File Offset: 0x000140B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153854, XrefRangeEnd = 1153881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x00015EEC File Offset: 0x000140EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153881, XrefRangeEnd = 1153887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x000042E9 File Offset: 0x000024E9
			public _AuthorizeAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600046C RID: 1132 RVA: 0x000042F2 File Offset: 0x000024F2
			public _AuthorizeAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x0600046D RID: 1133 RVA: 0x00015F34 File Offset: 0x00014134
			// (set) Token: 0x0600046E RID: 1134 RVA: 0x00004304 File Offset: 0x00002504
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x00015F5C File Offset: 0x0001415C
			// (set) Token: 0x06000470 RID: 1136 RVA: 0x0000431F File Offset: 0x0000251F
			public AsyncTaskMethodBuilder<UserCredential> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<UserCredential>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000471 RID: 1137 RVA: 0x00015F8C File Offset: 0x0001418C
			// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000434D File Offset: 0x0000254D
			public unsafe ClientSecrets clientSecrets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_clientSecrets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSecrets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_clientSecrets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000473 RID: 1139 RVA: 0x00015FBC File Offset: 0x000141BC
			// (set) Token: 0x06000474 RID: 1140 RVA: 0x0000436C File Offset: 0x0000256C
			public unsafe IEnumerable<string> scopes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_scopes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x00015FEC File Offset: 0x000141EC
			// (set) Token: 0x06000476 RID: 1142 RVA: 0x0000438B File Offset: 0x0000258B
			public unsafe string user
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_user);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_user), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x00016014 File Offset: 0x00014214
			// (set) Token: 0x06000478 RID: 1144 RVA: 0x000043AA File Offset: 0x000025AA
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000479 RID: 1145 RVA: 0x00016044 File Offset: 0x00014244
			// (set) Token: 0x0600047A RID: 1146 RVA: 0x000043D8 File Offset: 0x000025D8
			public unsafe IDataStore dataStore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_dataStore);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_dataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x0600047B RID: 1147 RVA: 0x00016074 File Offset: 0x00014274
			// (set) Token: 0x0600047C RID: 1148 RVA: 0x000043F7 File Offset: 0x000025F7
			public unsafe ICodeReceiver codeReceiver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_codeReceiver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr_codeReceiver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600047D RID: 1149 RVA: 0x000160A4 File Offset: 0x000142A4
			// (set) Token: 0x0600047E RID: 1150 RVA: 0x00004416 File Offset: 0x00002616
			public ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002CB RID: 715
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002CC RID: 716
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeFieldInfoPtr_clientSecrets;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeFieldInfoPtr_scopes;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeFieldInfoPtr_user;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeFieldInfoPtr_dataStore;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeFieldInfoPtr_codeReceiver;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000049 RID: 73
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker+<AuthorizeAsync>d__2")]
		public sealed class _AuthorizeAsync_d__2 : ValueType
		{
			// Token: 0x0600047F RID: 1151 RVA: 0x000160D4 File Offset: 0x000142D4
			// Note: this type is marked as 'beforefieldinit'.
			static _AuthorizeAsync_d__2()
			{
				Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, "<AuthorizeAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "<>1__state");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "<>t__builder");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_clientSecretsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "clientSecretsStream");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "scopes");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "user");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "taskCancellationToken");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_dataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "dataStore");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_codeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "codeReceiver");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, "<>u__1");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, 100663503);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr, 100663504);
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x000161DC File Offset: 0x000143DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153887, XrefRangeEnd = 1153914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00016214 File Offset: 0x00014414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153914, XrefRangeEnd = 1153920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00004444 File Offset: 0x00002644
			public _AuthorizeAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x0000444D File Offset: 0x0000264D
			public _AuthorizeAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x0001625C File Offset: 0x0001445C
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x0000445F File Offset: 0x0000265F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x00016284 File Offset: 0x00014484
			// (set) Token: 0x06000487 RID: 1159 RVA: 0x0000447A File Offset: 0x0000267A
			public AsyncTaskMethodBuilder<UserCredential> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<UserCredential>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x06000488 RID: 1160 RVA: 0x000162B4 File Offset: 0x000144B4
			// (set) Token: 0x06000489 RID: 1161 RVA: 0x000044A8 File Offset: 0x000026A8
			public unsafe Stream clientSecretsStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_clientSecretsStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_clientSecretsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x000162E4 File Offset: 0x000144E4
			// (set) Token: 0x0600048B RID: 1163 RVA: 0x000044C7 File Offset: 0x000026C7
			public unsafe IEnumerable<string> scopes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_scopes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x00016314 File Offset: 0x00014514
			// (set) Token: 0x0600048D RID: 1165 RVA: 0x000044E6 File Offset: 0x000026E6
			public unsafe string user
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_user);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_user), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001633C File Offset: 0x0001453C
			// (set) Token: 0x0600048F RID: 1167 RVA: 0x00004505 File Offset: 0x00002705
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001636C File Offset: 0x0001456C
			// (set) Token: 0x06000491 RID: 1169 RVA: 0x00004533 File Offset: 0x00002733
			public unsafe IDataStore dataStore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_dataStore);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_dataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001639C File Offset: 0x0001459C
			// (set) Token: 0x06000493 RID: 1171 RVA: 0x00004552 File Offset: 0x00002752
			public unsafe ICodeReceiver codeReceiver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_codeReceiver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr_codeReceiver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000494 RID: 1172 RVA: 0x000163CC File Offset: 0x000145CC
			// (set) Token: 0x06000495 RID: 1173 RVA: 0x00004571 File Offset: 0x00002771
			public ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeFieldInfoPtr_clientSecretsStream;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeFieldInfoPtr_scopes;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeFieldInfoPtr_user;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeFieldInfoPtr_dataStore;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeFieldInfoPtr_codeReceiver;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker+<ReauthorizeAsync>d__3")]
		public sealed class _ReauthorizeAsync_d__3 : ValueType
		{
			// Token: 0x06000496 RID: 1174 RVA: 0x000163FC File Offset: 0x000145FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ReauthorizeAsync_d__3()
			{
				Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, "<ReauthorizeAsync>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr);
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "<>1__state");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "<>t__builder");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_codeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "codeReceiver");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_userCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "userCredential");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "taskCancellationToken");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "<>u__1");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, "<>u__2");
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, 100663505);
				GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr, 100663506);
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x000164DC File Offset: 0x000146DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153920, XrefRangeEnd = 1153960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00016514 File Offset: 0x00014714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153960, XrefRangeEnd = 1153964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x0000459F File Offset: 0x0000279F
			public _ReauthorizeAsync_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x000045A8 File Offset: 0x000027A8
			public _ReauthorizeAsync_d__3()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3>.NativeClassPtr))
			{
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001655C File Offset: 0x0001475C
			// (set) Token: 0x0600049C RID: 1180 RVA: 0x000045BA File Offset: 0x000027BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x00016584 File Offset: 0x00014784
			// (set) Token: 0x0600049E RID: 1182 RVA: 0x000045D5 File Offset: 0x000027D5
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x0600049F RID: 1183 RVA: 0x000165B4 File Offset: 0x000147B4
			// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00004603 File Offset: 0x00002803
			public unsafe ICodeReceiver codeReceiver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_codeReceiver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_codeReceiver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x000165E4 File Offset: 0x000147E4
			// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00004622 File Offset: 0x00002822
			public unsafe UserCredential userCredential
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_userCredential);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_userCredential), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00016614 File Offset: 0x00014814
			// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00004641 File Offset: 0x00002841
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00016644 File Offset: 0x00014844
			// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0000466F File Offset: 0x0000286F
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00016674 File Offset: 0x00014874
			// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0000469D File Offset: 0x0000289D
			public ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._ReauthorizeAsync_d__3.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeFieldInfoPtr_codeReceiver;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr_userCredential;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002E9 RID: 745
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker+<AuthorizeAsync>d__4")]
		public sealed class _AuthorizeAsync_d__4 : ValueType
		{
			// Token: 0x060004A9 RID: 1193 RVA: 0x000166A4 File Offset: 0x000148A4
			// Note: this type is marked as 'beforefieldinit'.
			static _AuthorizeAsync_d__4()
			{
				Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleWebAuthorizationBroker>.NativeClassPtr, "<AuthorizeAsync>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "<>1__state");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "<>t__builder");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_initializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "initializer");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "scopes");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_dataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "dataStore");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_codeReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "codeReceiver");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "user");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "taskCancellationToken");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, "<>u__1");
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, 100663507);
				GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr, 100663508);
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x000167AC File Offset: 0x000149AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153964, XrefRangeEnd = 1154010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x000167E4 File Offset: 0x000149E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1154010, XrefRangeEnd = 1154016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x000046CB File Offset: 0x000028CB
			public _AuthorizeAsync_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x000046D4 File Offset: 0x000028D4
			public _AuthorizeAsync_d__4()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleWebAuthorizationBroker._AuthorizeAsync_d__4>.NativeClassPtr))
			{
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001682C File Offset: 0x00014A2C
			// (set) Token: 0x060004AF RID: 1199 RVA: 0x000046E6 File Offset: 0x000028E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00016854 File Offset: 0x00014A54
			// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00004701 File Offset: 0x00002901
			public AsyncTaskMethodBuilder<UserCredential> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<UserCredential>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<UserCredential>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00016884 File Offset: 0x00014A84
			// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0000472F File Offset: 0x0000292F
			public unsafe GoogleAuthorizationCodeFlow.Initializer initializer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_initializer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleAuthorizationCodeFlow.Initializer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_initializer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060004B4 RID: 1204 RVA: 0x000168B4 File Offset: 0x00014AB4
			// (set) Token: 0x060004B5 RID: 1205 RVA: 0x0000474E File Offset: 0x0000294E
			public unsafe IEnumerable<string> scopes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_scopes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000168E4 File Offset: 0x00014AE4
			// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000476D File Offset: 0x0000296D
			public unsafe IDataStore dataStore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_dataStore);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_dataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00016914 File Offset: 0x00014B14
			// (set) Token: 0x060004B9 RID: 1209 RVA: 0x0000478C File Offset: 0x0000298C
			public unsafe ICodeReceiver codeReceiver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_codeReceiver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICodeReceiver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_codeReceiver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060004BA RID: 1210 RVA: 0x00016944 File Offset: 0x00014B44
			// (set) Token: 0x060004BB RID: 1211 RVA: 0x000047AB File Offset: 0x000029AB
			public unsafe string user
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_user);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_user), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001696C File Offset: 0x00014B6C
			// (set) Token: 0x060004BD RID: 1213 RVA: 0x000047CA File Offset: 0x000029CA
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001699C File Offset: 0x00014B9C
			// (set) Token: 0x060004BF RID: 1215 RVA: 0x000047F8 File Offset: 0x000029F8
			public ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleWebAuthorizationBroker._AuthorizeAsync_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<UserCredential>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002EA RID: 746
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002EB RID: 747
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002EC RID: 748
			private static readonly IntPtr NativeFieldInfoPtr_initializer;

			// Token: 0x040002ED RID: 749
			private static readonly IntPtr NativeFieldInfoPtr_scopes;

			// Token: 0x040002EE RID: 750
			private static readonly IntPtr NativeFieldInfoPtr_dataStore;

			// Token: 0x040002EF RID: 751
			private static readonly IntPtr NativeFieldInfoPtr_codeReceiver;

			// Token: 0x040002F0 RID: 752
			private static readonly IntPtr NativeFieldInfoPtr_user;

			// Token: 0x040002F1 RID: 753
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040002F2 RID: 754
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002F3 RID: 755
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002F4 RID: 756
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
