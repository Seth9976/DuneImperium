using System;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x0200002E RID: 46
	public static class TokenRequestExtenstions : Object
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0000326F File Offset: 0x0000146F
		// Note: this type is marked as 'beforefieldinit'.
		static TokenRequestExtenstions()
		{
			Il2CppClassPointerStore<TokenRequestExtenstions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "TokenRequestExtenstions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRequestExtenstions>.NativeClassPtr);
			TokenRequestExtenstions.NativeMethodInfoPtr_ExecuteAsync_Public_Static_Task_1_TokenResponse_TokenRequest_HttpClient_String_CancellationToken_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequestExtenstions>.NativeClassPtr, 100663853);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00010458 File Offset: 0x0000E658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1157062, RefRangeEnd = 1157063, XrefRangeStart = 1157044, XrefRangeEnd = 1157062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TokenResponse> ExecuteAsync(this TokenRequest request, HttpClient httpClient, string tokenServerUrl, CancellationToken taskCancellationToken, IClock clock)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenServerUrl);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequestExtenstions.NativeMethodInfoPtr_ExecuteAsync_Public_Static_Task_1_TokenResponse_TokenRequest_HttpClient_String_CancellationToken_IClock_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TokenResponse>>(intPtr3) : null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000032A8 File Offset: 0x000014A8
		public TokenRequestExtenstions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteAsync_Public_Static_Task_1_TokenResponse_TokenRequest_HttpClient_String_CancellationToken_IClock_0;

		// Token: 0x02000069 RID: 105
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Requests.TokenRequestExtenstions+<ExecuteAsync>d__0")]
		public sealed class _ExecuteAsync_d__0 : ValueType
		{
			// Token: 0x06000676 RID: 1654 RVA: 0x0001B0EC File Offset: 0x000192EC
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteAsync_d__0()
			{
				Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRequestExtenstions>.NativeClassPtr, "<ExecuteAsync>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr);
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "<>1__state");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "<>t__builder");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_tokenServerUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "tokenServerUrl");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "request");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_httpClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "httpClient");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "taskCancellationToken");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "clock");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "<response>5__2");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "<>u__1");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, "<>u__2");
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, 100663854);
				TokenRequestExtenstions._ExecuteAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr, 100663855);
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x0001B208 File Offset: 0x00019408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156976, XrefRangeEnd = 1157038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequestExtenstions._ExecuteAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x0001B240 File Offset: 0x00019440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157038, XrefRangeEnd = 1157044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequestExtenstions._ExecuteAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x00005CC6 File Offset: 0x00003EC6
			public _ExecuteAsync_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00005CCF File Offset: 0x00003ECF
			public _ExecuteAsync_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRequestExtenstions._ExecuteAsync_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x0600067B RID: 1659 RVA: 0x0001B288 File Offset: 0x00019488
			// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005CE1 File Offset: 0x00003EE1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x0600067D RID: 1661 RVA: 0x0001B2B0 File Offset: 0x000194B0
			// (set) Token: 0x0600067E RID: 1662 RVA: 0x00005CFC File Offset: 0x00003EFC
			public AsyncTaskMethodBuilder<TokenResponse> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TokenResponse>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TokenResponse>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001B2E0 File Offset: 0x000194E0
			// (set) Token: 0x06000680 RID: 1664 RVA: 0x00005D2A File Offset: 0x00003F2A
			public unsafe string tokenServerUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_tokenServerUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_tokenServerUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001B308 File Offset: 0x00019508
			// (set) Token: 0x06000682 RID: 1666 RVA: 0x00005D49 File Offset: 0x00003F49
			public unsafe TokenRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001B338 File Offset: 0x00019538
			// (set) Token: 0x06000684 RID: 1668 RVA: 0x00005D68 File Offset: 0x00003F68
			public unsafe HttpClient httpClient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_httpClient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_httpClient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001B368 File Offset: 0x00019568
			// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005D87 File Offset: 0x00003F87
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001B398 File Offset: 0x00019598
			// (set) Token: 0x06000688 RID: 1672 RVA: 0x00005DB5 File Offset: 0x00003FB5
			public unsafe IClock clock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_clock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001B3C8 File Offset: 0x000195C8
			// (set) Token: 0x0600068A RID: 1674 RVA: 0x00005DD4 File Offset: 0x00003FD4
			public unsafe HttpResponseMessage _response_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr__response_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpResponseMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x0600068B RID: 1675 RVA: 0x0001B3F8 File Offset: 0x000195F8
			// (set) Token: 0x0600068C RID: 1676 RVA: 0x00005DF3 File Offset: 0x00003FF3
			public ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x0600068D RID: 1677 RVA: 0x0001B428 File Offset: 0x00019628
			// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005E21 File Offset: 0x00004021
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequestExtenstions._ExecuteAsync_d__0.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003DB RID: 987
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003DC RID: 988
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003DD RID: 989
			private static readonly IntPtr NativeFieldInfoPtr_tokenServerUrl;

			// Token: 0x040003DE RID: 990
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x040003DF RID: 991
			private static readonly IntPtr NativeFieldInfoPtr_httpClient;

			// Token: 0x040003E0 RID: 992
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x040003E1 RID: 993
			private static readonly IntPtr NativeFieldInfoPtr_clock;

			// Token: 0x040003E2 RID: 994
			private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

			// Token: 0x040003E3 RID: 995
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003E4 RID: 996
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040003E5 RID: 997
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003E6 RID: 998
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
