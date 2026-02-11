using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using platformCore.friend;

namespace boardgames.menus.commands
{
	// Token: 0x02000233 RID: 563
	public class RunRemoveFriendFlow : Command
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x00070A50 File Offset: 0x0006EC50
		// Note: this type is marked as 'beforefieldinit'.
		static RunRemoveFriendFlow()
		{
			Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunRemoveFriendFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr);
			RunRemoveFriendFlow.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr, "accountID");
			RunRemoveFriendFlow.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr, "name");
			RunRemoveFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_AccountID_BasicName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr, 100667287);
			RunRemoveFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr, 100667288);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00070AD0 File Offset: 0x0006ECD0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRemoveFriendFlow(AccountID accountID, BasicName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow.NativeMethodInfoPtr__ctor_Public_Void_AccountID_BasicName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00070B30 File Offset: 0x0006ED30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529892, XrefRangeEnd = 529897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRemoveFriendFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0000E068 File Offset: 0x0000C268
		public RunRemoveFriendFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00070B7C File Offset: 0x0006ED7C
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0000E071 File Offset: 0x0000C271
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00070BAC File Offset: 0x0006EDAC
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0000E090 File Offset: 0x0000C290
		public unsafe BasicName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_BasicName_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200041A RID: 1050
		[ObfuscatedName("boardgames.menus.commands.RunRemoveFriendFlow+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600319E RID: 12702 RVA: 0x000BC888 File Offset: 0x000BAA88
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRemoveFriendFlow>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr);
				RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, "<>1__state");
				RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, "<>2__current");
				RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, "<>4__this");
				RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__confirmOrDeny_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, "<confirmOrDeny>5__2");
				RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__removeFriend_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, "<removeFriend>5__3");
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667289);
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667290);
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667291);
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667292);
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667293);
				RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr, 100667294);
			}

			// Token: 0x0600319F RID: 12703 RVA: 0x000BC990 File Offset: 0x000BAB90
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRemoveFriendFlow._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060031A0 RID: 12704 RVA: 0x000BC9D8 File Offset: 0x000BABD8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031A1 RID: 12705 RVA: 0x000BCA0C File Offset: 0x000BAC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529828, XrefRangeEnd = 529887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E6C RID: 3692
			// (get) Token: 0x060031A2 RID: 12706 RVA: 0x000BCA48 File Offset: 0x000BAC48
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031A3 RID: 12707 RVA: 0x000BCA88 File Offset: 0x000BAC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529887, XrefRangeEnd = 529892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E6D RID: 3693
			// (get) Token: 0x060031A4 RID: 12708 RVA: 0x000BCABC File Offset: 0x000BACBC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRemoveFriendFlow._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060031A5 RID: 12709 RVA: 0x00019A91 File Offset: 0x00017C91
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E67 RID: 3687
			// (get) Token: 0x060031A6 RID: 12710 RVA: 0x000BCAFC File Offset: 0x000BACFC
			// (set) Token: 0x060031A7 RID: 12711 RVA: 0x00019A9A File Offset: 0x00017C9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E68 RID: 3688
			// (get) Token: 0x060031A8 RID: 12712 RVA: 0x000BCB24 File Offset: 0x000BAD24
			// (set) Token: 0x060031A9 RID: 12713 RVA: 0x00019AB5 File Offset: 0x00017CB5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E69 RID: 3689
			// (get) Token: 0x060031AA RID: 12714 RVA: 0x000BCB54 File Offset: 0x000BAD54
			// (set) Token: 0x060031AB RID: 12715 RVA: 0x00019AD4 File Offset: 0x00017CD4
			public unsafe RunRemoveFriendFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRemoveFriendFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6A RID: 3690
			// (get) Token: 0x060031AC RID: 12716 RVA: 0x000BCB84 File Offset: 0x000BAD84
			// (set) Token: 0x060031AD RID: 12717 RVA: 0x00019AF3 File Offset: 0x00017CF3
			public unsafe ConfirmOrDenyPrompt _confirmOrDeny_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__confirmOrDeny_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__confirmOrDeny_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E6B RID: 3691
			// (get) Token: 0x060031AE RID: 12718 RVA: 0x000BCBB4 File Offset: 0x000BADB4
			// (set) Token: 0x060031AF RID: 12719 RVA: 0x00019B12 File Offset: 0x00017D12
			public unsafe RemoveFriend _removeFriend_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__removeFriend_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoveFriend>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRemoveFriendFlow._execute_d__3.NativeFieldInfoPtr__removeFriend_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001EA7 RID: 7847
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001EA8 RID: 7848
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001EA9 RID: 7849
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001EAA RID: 7850
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDeny_5__2;

			// Token: 0x04001EAB RID: 7851
			private static readonly IntPtr NativeFieldInfoPtr__removeFriend_5__3;

			// Token: 0x04001EAC RID: 7852
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EAD RID: 7853
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EAE RID: 7854
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EAF RID: 7855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EB0 RID: 7856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EB1 RID: 7857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
