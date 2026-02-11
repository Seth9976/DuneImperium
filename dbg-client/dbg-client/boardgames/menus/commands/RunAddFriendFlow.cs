using System;
using boardgames.menus.prompts;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using platformCore.friend;

namespace boardgames.menus.commands
{
	// Token: 0x02000219 RID: 537
	public class RunAddFriendFlow : Command
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
		// Note: this type is marked as 'beforefieldinit'.
		static RunAddFriendFlow()
		{
			Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunAddFriendFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr);
			RunAddFriendFlow.NativeFieldInfoPtr_targetAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, "targetAccount");
			RunAddFriendFlow.NativeFieldInfoPtr_showFriendListAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, "showFriendListAfter");
			RunAddFriendFlow.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, "info");
			RunAddFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, 100666967);
			RunAddFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, 100666968);
			RunAddFriendFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, 100666969);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0006D548 File Offset: 0x0006B748
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 505858, RefRangeEnd = 505863, XrefRangeStart = 505858, XrefRangeEnd = 505863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunAddFriendFlow(string targetAccount = null, bool showFriendListAfter = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetAccount);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showFriendListAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0006D5A4 File Offset: 0x0006B7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527493, XrefRangeEnd = 527498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunAddFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0006D5F0 File Offset: 0x0006B7F0
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0000D9BA File Offset: 0x0000BBBA
		public RunAddFriendFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0006D628 File Offset: 0x0006B828
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000D9C3 File Offset: 0x0000BBC3
		public unsafe string targetAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_targetAccount);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_targetAccount), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0006D650 File Offset: 0x0006B850
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000D9E2 File Offset: 0x0000BBE2
		public unsafe bool showFriendListAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_showFriendListAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_showFriendListAfter)) = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0006D678 File Offset: 0x0006B878
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000D9FD File Offset: 0x0000BBFD
		public ErrorInfo info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_info);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow.NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr_targetAccount;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr_showFriendListAfter;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x020003F1 RID: 1009
		[ObfuscatedName("boardgames.menus.commands.RunAddFriendFlow+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002F25 RID: 12069 RVA: 0x000B5378 File Offset: 0x000B3578
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunAddFriendFlow>.NativeClassPtr, "<execute>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr);
				RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, "<>1__state");
				RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, "<>2__current");
				RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, "<>4__this");
				RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__sendFriendInvitation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, "<sendFriendInvitation>5__2");
				RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__addFriendPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, "<addFriendPrompt>5__3");
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666970);
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666971);
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666972);
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666973);
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666974);
				RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr, 100666975);
			}

			// Token: 0x06002F26 RID: 12070 RVA: 0x000B5480 File Offset: 0x000B3680
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunAddFriendFlow._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F27 RID: 12071 RVA: 0x000B54C8 File Offset: 0x000B36C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F28 RID: 12072 RVA: 0x000B54FC File Offset: 0x000B36FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527422, XrefRangeEnd = 527488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x06002F29 RID: 12073 RVA: 0x000B5538 File Offset: 0x000B3738
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F2A RID: 12074 RVA: 0x000B5578 File Offset: 0x000B3778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527488, XrefRangeEnd = 527493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000B55AC File Offset: 0x000B37AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunAddFriendFlow._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x000185C6 File Offset: 0x000167C6
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000B55EC File Offset: 0x000B37EC
			// (set) Token: 0x06002F2E RID: 12078 RVA: 0x000185CF File Offset: 0x000167CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x06002F2F RID: 12079 RVA: 0x000B5614 File Offset: 0x000B3814
			// (set) Token: 0x06002F30 RID: 12080 RVA: 0x000185EA File Offset: 0x000167EA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000B5644 File Offset: 0x000B3844
			// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00018609 File Offset: 0x00016809
			public unsafe RunAddFriendFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunAddFriendFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x06002F33 RID: 12083 RVA: 0x000B5674 File Offset: 0x000B3874
			// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00018628 File Offset: 0x00016828
			public unsafe SendFriendInvitation _sendFriendInvitation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__sendFriendInvitation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendFriendInvitation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__sendFriendInvitation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x06002F35 RID: 12085 RVA: 0x000B56A4 File Offset: 0x000B38A4
			// (set) Token: 0x06002F36 RID: 12086 RVA: 0x00018647 File Offset: 0x00016847
			public unsafe AddFriendPrompt _addFriendPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__addFriendPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddFriendPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunAddFriendFlow._execute_d__4.NativeFieldInfoPtr__addFriendPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D2B RID: 7467
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D2C RID: 7468
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D2D RID: 7469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D2E RID: 7470
			private static readonly IntPtr NativeFieldInfoPtr__sendFriendInvitation_5__2;

			// Token: 0x04001D2F RID: 7471
			private static readonly IntPtr NativeFieldInfoPtr__addFriendPrompt_5__3;

			// Token: 0x04001D30 RID: 7472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D31 RID: 7473
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D32 RID: 7474
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D33 RID: 7475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D34 RID: 7476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D35 RID: 7477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
