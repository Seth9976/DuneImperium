using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.platform;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200022A RID: 554
	public class RunInviteFriendFlow : Command
	{
		// Token: 0x06001944 RID: 6468 RVA: 0x0006FA50 File Offset: 0x0006DC50
		// Note: this type is marked as 'beforefieldinit'.
		static RunInviteFriendFlow()
		{
			Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunInviteFriendFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr);
			RunInviteFriendFlow.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr, "accountID");
			RunInviteFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr, 100667180);
			RunInviteFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr, 100667181);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0006FABC File Offset: 0x0006DCBC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunInviteFriendFlow(AccountID accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0006FB08 File Offset: 0x0006DD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529039, XrefRangeEnd = 529044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunInviteFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0000DEBF File Offset: 0x0000C0BF
		public RunInviteFriendFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x0006FB54 File Offset: 0x0006DD54
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200040B RID: 1035
		[ObfuscatedName("boardgames.menus.commands.RunInviteFriendFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060030BF RID: 12479 RVA: 0x000B9FD8 File Offset: 0x000B81D8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunInviteFriendFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr);
				RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr__inviteFriend_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, "<inviteFriend>5__2");
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667182);
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667183);
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667184);
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667185);
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667186);
				RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr, 100667187);
			}

			// Token: 0x060030C0 RID: 12480 RVA: 0x000BA0CC File Offset: 0x000B82CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunInviteFriendFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060030C1 RID: 12481 RVA: 0x000BA114 File Offset: 0x000B8314
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030C2 RID: 12482 RVA: 0x000BA148 File Offset: 0x000B8348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 528961, XrefRangeEnd = 529034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E1A RID: 3610
			// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000BA184 File Offset: 0x000B8384
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030C4 RID: 12484 RVA: 0x000BA1C4 File Offset: 0x000B83C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529034, XrefRangeEnd = 529039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E1B RID: 3611
			// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000BA1F8 File Offset: 0x000B83F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunInviteFriendFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060030C6 RID: 12486 RVA: 0x00019347 File Offset: 0x00017547
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000BA238 File Offset: 0x000B8438
			// (set) Token: 0x060030C8 RID: 12488 RVA: 0x00019350 File Offset: 0x00017550
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x060030C9 RID: 12489 RVA: 0x000BA260 File Offset: 0x000B8460
			// (set) Token: 0x060030CA RID: 12490 RVA: 0x0001936B File Offset: 0x0001756B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x060030CB RID: 12491 RVA: 0x000BA290 File Offset: 0x000B8490
			// (set) Token: 0x060030CC RID: 12492 RVA: 0x0001938A File Offset: 0x0001758A
			public unsafe RunInviteFriendFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunInviteFriendFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E19 RID: 3609
			// (get) Token: 0x060030CD RID: 12493 RVA: 0x000BA2C0 File Offset: 0x000B84C0
			// (set) Token: 0x060030CE RID: 12494 RVA: 0x000193A9 File Offset: 0x000175A9
			public unsafe SendInvitationEmail _inviteFriend_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr__inviteFriend_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendInvitationEmail>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunInviteFriendFlow._execute_d__2.NativeFieldInfoPtr__inviteFriend_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E23 RID: 7715
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E24 RID: 7716
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E25 RID: 7717
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E26 RID: 7718
			private static readonly IntPtr NativeFieldInfoPtr__inviteFriend_5__2;

			// Token: 0x04001E27 RID: 7719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001E28 RID: 7720
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E29 RID: 7721
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001E2A RID: 7722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001E2B RID: 7723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001E2C RID: 7724
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
