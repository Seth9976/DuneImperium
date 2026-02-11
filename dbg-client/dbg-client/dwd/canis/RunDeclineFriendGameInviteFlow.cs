using System;
using dwd.core.commands;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.canis
{
	// Token: 0x0200004C RID: 76
	public class RunDeclineFriendGameInviteFlow : Command
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x00026B34 File Offset: 0x00024D34
		// Note: this type is marked as 'beforefieldinit'.
		static RunDeclineFriendGameInviteFlow()
		{
			Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "RunDeclineFriendGameInviteFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr);
			RunDeclineFriendGameInviteFlow.NativeFieldInfoPtr_decline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr, "decline");
			RunDeclineFriendGameInviteFlow.NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGameDeclined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr, 100663761);
			RunDeclineFriendGameInviteFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr, 100663762);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00026BA0 File Offset: 0x00024DA0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunDeclineFriendGameInviteFlow(RequestToJoinFriendGameDeclined decline)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decline);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow.NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGameDeclined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00026BEC File Offset: 0x00024DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499303, XrefRangeEnd = 499308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunDeclineFriendGameInviteFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000349E File Offset: 0x0000169E
		public RunDeclineFriendGameInviteFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00026C38 File Offset: 0x00024E38
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000034A7 File Offset: 0x000016A7
		public unsafe RequestToJoinFriendGameDeclined decline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow.NativeFieldInfoPtr_decline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestToJoinFriendGameDeclined>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow.NativeFieldInfoPtr_decline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_decline;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGameDeclined_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020002E7 RID: 743
		[ObfuscatedName("dwd.canis.RunDeclineFriendGameInviteFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002303 RID: 8963 RVA: 0x00091348 File Offset: 0x0008F548
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663763);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663764);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663765);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663766);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663767);
				RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr, 100663768);
			}

			// Token: 0x06002304 RID: 8964 RVA: 0x00091428 File Offset: 0x0008F628
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunDeclineFriendGameInviteFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002305 RID: 8965 RVA: 0x00091470 File Offset: 0x0008F670
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002306 RID: 8966 RVA: 0x000914A4 File Offset: 0x0008F6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499233, XrefRangeEnd = 499298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x06002307 RID: 8967 RVA: 0x000914E0 File Offset: 0x0008F6E0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002308 RID: 8968 RVA: 0x00091520 File Offset: 0x0008F720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499298, XrefRangeEnd = 499303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06002309 RID: 8969 RVA: 0x00091554 File Offset: 0x0008F754
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunDeclineFriendGameInviteFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600230A RID: 8970 RVA: 0x000123E3 File Offset: 0x000105E3
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x0600230B RID: 8971 RVA: 0x00091594 File Offset: 0x0008F794
			// (set) Token: 0x0600230C RID: 8972 RVA: 0x000123EC File Offset: 0x000105EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x0600230D RID: 8973 RVA: 0x000915BC File Offset: 0x0008F7BC
			// (set) Token: 0x0600230E RID: 8974 RVA: 0x00012407 File Offset: 0x00010607
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x0600230F RID: 8975 RVA: 0x000915EC File Offset: 0x0008F7EC
			// (set) Token: 0x06002310 RID: 8976 RVA: 0x00012426 File Offset: 0x00010626
			public unsafe RunDeclineFriendGameInviteFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunDeclineFriendGameInviteFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunDeclineFriendGameInviteFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
