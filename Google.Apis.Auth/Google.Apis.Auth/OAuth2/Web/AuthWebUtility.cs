using System;
using Google.Apis.Util.Store;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2.Web
{
	// Token: 0x02000021 RID: 33
	public class AuthWebUtility : Object
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000D428 File Offset: 0x0000B628
		// Note: this type is marked as 'beforefieldinit'.
		static AuthWebUtility()
		{
			Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Web", "AuthWebUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr);
			AuthWebUtility.NativeMethodInfoPtr_ExtracRedirectFromState_Public_Static_Task_1_String_IDataStore_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr, 100663741);
			AuthWebUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr, 100663742);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000D480 File Offset: 0x0000B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156691, XrefRangeEnd = 1156707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<string> ExtracRedirectFromState(IDataStore dataStore, string userId, string state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataStore);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthWebUtility.NativeMethodInfoPtr_ExtracRedirectFromState_Public_Static_Task_1_String_IDataStore_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthWebUtility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthWebUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002CEC File Offset: 0x00000EEC
		public AuthWebUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_ExtracRedirectFromState_Public_Static_Task_1_String_IDataStore_String_String_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000067 RID: 103
		[ObfuscatedName("Google.Apis.Auth.OAuth2.Web.AuthWebUtility+<ExtracRedirectFromState>d__0")]
		public sealed class _ExtracRedirectFromState_d__0 : ValueType
		{
			// Token: 0x0600064E RID: 1614 RVA: 0x0001AB78 File Offset: 0x00018D78
			// Note: this type is marked as 'beforefieldinit'.
			static _ExtracRedirectFromState_d__0()
			{
				Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthWebUtility>.NativeClassPtr, "<ExtracRedirectFromState>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr);
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<>1__state");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<>t__builder");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "state");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_dataStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "dataStore");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "userId");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__oauthState_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<oauthState>5__2");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__userKey_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<userKey>5__3");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<>u__1");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, "<>u__2");
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, 100663743);
				AuthWebUtility._ExtracRedirectFromState_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr, 100663744);
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x0001AC80 File Offset: 0x00018E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156645, XrefRangeEnd = 1156685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthWebUtility._ExtracRedirectFromState_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x0001ACB8 File Offset: 0x00018EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156685, XrefRangeEnd = 1156691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthWebUtility._ExtracRedirectFromState_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00005A7C File Offset: 0x00003C7C
			public _ExtracRedirectFromState_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00005A85 File Offset: 0x00003C85
			public _ExtracRedirectFromState_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthWebUtility._ExtracRedirectFromState_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000653 RID: 1619 RVA: 0x0001AD00 File Offset: 0x00018F00
			// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005A97 File Offset: 0x00003C97
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001AD28 File Offset: 0x00018F28
			// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005AB2 File Offset: 0x00003CB2
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001AD58 File Offset: 0x00018F58
			// (set) Token: 0x06000658 RID: 1624 RVA: 0x00005AE0 File Offset: 0x00003CE0
			public unsafe string state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_state);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_state), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001AD80 File Offset: 0x00018F80
			// (set) Token: 0x0600065A RID: 1626 RVA: 0x00005AFF File Offset: 0x00003CFF
			public unsafe IDataStore dataStore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_dataStore);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDataStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_dataStore), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001ADB0 File Offset: 0x00018FB0
			// (set) Token: 0x0600065C RID: 1628 RVA: 0x00005B1E File Offset: 0x00003D1E
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001ADD8 File Offset: 0x00018FD8
			// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005B3D File Offset: 0x00003D3D
			public unsafe string _oauthState_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__oauthState_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__oauthState_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001AE00 File Offset: 0x00019000
			// (set) Token: 0x06000660 RID: 1632 RVA: 0x00005B5C File Offset: 0x00003D5C
			public unsafe string _userKey_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__userKey_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr__userKey_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001AE28 File Offset: 0x00019028
			// (set) Token: 0x06000662 RID: 1634 RVA: 0x00005B7B File Offset: 0x00003D7B
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001AE58 File Offset: 0x00019058
			// (set) Token: 0x06000664 RID: 1636 RVA: 0x00005BA9 File Offset: 0x00003DA9
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthWebUtility._ExtracRedirectFromState_d__0.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040003C8 RID: 968
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040003C9 RID: 969
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040003CA RID: 970
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040003CB RID: 971
			private static readonly IntPtr NativeFieldInfoPtr_dataStore;

			// Token: 0x040003CC RID: 972
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x040003CD RID: 973
			private static readonly IntPtr NativeFieldInfoPtr__oauthState_5__2;

			// Token: 0x040003CE RID: 974
			private static readonly IntPtr NativeFieldInfoPtr__userKey_5__3;

			// Token: 0x040003CF RID: 975
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040003D0 RID: 976
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040003D1 RID: 977
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040003D2 RID: 978
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
