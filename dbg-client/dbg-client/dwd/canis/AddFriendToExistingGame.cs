using System;
using boardgames.data;
using boardgames.matchMaking.commands;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.platform.websocket.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.canis
{
	// Token: 0x02000047 RID: 71
	public class AddFriendToExistingGame : Command
	{
		// Token: 0x060002BA RID: 698 RVA: 0x000262CC File Offset: 0x000244CC
		// Note: this type is marked as 'beforefieldinit'.
		static AddFriendToExistingGame()
		{
			Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "AddFriendToExistingGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr);
			AddFriendToExistingGame.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "id");
			AddFriendToExistingGame.NativeFieldInfoPtr__friendData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "_friendData");
			AddFriendToExistingGame.NativeFieldInfoPtr_addPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "addPlayer");
			AddFriendToExistingGame.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "slots");
			AddFriendToExistingGame.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_List_1_SubscriptionProvider_Action_3_DataComposition_PlayerType_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, 100663723);
			AddFriendToExistingGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, 100663724);
			AddFriendToExistingGame.NativeMethodInfoPtr__execute_b__5_1_Private_Boolean_RosterEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, 100663725);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00026388 File Offset: 0x00024588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499016, XrefRangeEnd = 499021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddFriendToExistingGame(DataComposition friendData, AccountID id, List<SubscriptionProvider> slots, Action<DataComposition, PlayerTypeData.PlayerType, AccountID> del)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(slots);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(del);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_List_1_SubscriptionProvider_Action_3_DataComposition_PlayerType_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0002640C File Offset: 0x0002460C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499021, XrefRangeEnd = 499026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AddFriendToExistingGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00026458 File Offset: 0x00024658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499026, XrefRangeEnd = 499029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__5_1(RosterEntry _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame.NativeMethodInfoPtr__execute_b__5_1_Private_Boolean_RosterEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000032EB File Offset: 0x000014EB
		public AddFriendToExistingGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000264A8 File Offset: 0x000246A8
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000032F4 File Offset: 0x000014F4
		public unsafe AccountID id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000264D8 File Offset: 0x000246D8
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00003313 File Offset: 0x00001513
		public unsafe DataComposition _friendData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr__friendData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr__friendData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00026508 File Offset: 0x00024708
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00003332 File Offset: 0x00001532
		public unsafe Action<DataComposition, PlayerTypeData.PlayerType, AccountID> addPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_addPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DataComposition, PlayerTypeData.PlayerType, AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_addPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00026538 File Offset: 0x00024738
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00003351 File Offset: 0x00001551
		public unsafe List<SubscriptionProvider> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr__friendData;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_addPlayer;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_List_1_SubscriptionProvider_Action_3_DataComposition_PlayerType_AccountID_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_1_Private_Boolean_RosterEntry_0;

		// Token: 0x020002E2 RID: 738
		[ObfuscatedName("dwd.canis.AddFriendToExistingGame+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022B9 RID: 8889 RVA: 0x000905AC File Offset: 0x0008E7AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr);
				AddFriendToExistingGame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, "<>9");
				AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, "<>9__5_0");
				AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, "<>9__5_2");
				AddFriendToExistingGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, 100663727);
				AddFriendToExistingGame.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_RosterEntry_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, 100663728);
				AddFriendToExistingGame.__c.NativeMethodInfoPtr__execute_b__5_2_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr, 100663729);
			}

			// Token: 0x060022BA RID: 8890 RVA: 0x00090650 File Offset: 0x0008E850
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendToExistingGame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022BB RID: 8891 RVA: 0x0009068C File Offset: 0x0008E88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498944, XrefRangeEnd = 498947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RosterEntry _execute_b__5_0(SubscriptionProvider slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_RosterEntry_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RosterEntry>(intPtr3) : null;
				}
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x000906DC File Offset: 0x0008E8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498947, XrefRangeEnd = 498950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__5_2(SubscriptionProvider _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame.__c.NativeMethodInfoPtr__execute_b__5_2_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060022BD RID: 8893 RVA: 0x000121A4 File Offset: 0x000103A4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x060022BE RID: 8894 RVA: 0x0009072C File Offset: 0x0008E92C
			// (set) Token: 0x060022BF RID: 8895 RVA: 0x000121AD File Offset: 0x000103AD
			public unsafe static AddFriendToExistingGame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddFriendToExistingGame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00090754 File Offset: 0x0008E954
			// (set) Token: 0x060022C1 RID: 8897 RVA: 0x000121BF File Offset: 0x000103BF
			public unsafe static Func<SubscriptionProvider, RosterEntry> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, RosterEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x060022C2 RID: 8898 RVA: 0x0009077C File Offset: 0x0008E97C
			// (set) Token: 0x060022C3 RID: 8899 RVA: 0x000121D1 File Offset: 0x000103D1
			public unsafe static Func<SubscriptionProvider, bool> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AddFriendToExistingGame.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_RosterEntry_SubscriptionProvider_0;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_2_Internal_Boolean_SubscriptionProvider_0;
		}

		// Token: 0x020002E3 RID: 739
		[ObfuscatedName("dwd.canis.AddFriendToExistingGame+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x060022C4 RID: 8900 RVA: 0x000907A4 File Offset: 0x0008E9A4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddFriendToExistingGame>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr);
				AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, "<>1__state");
				AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, "<>2__current");
				AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, "<>4__this");
				AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr__canInviteUser_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, "<canInviteUser>5__2");
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663730);
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663731);
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663732);
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663733);
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663734);
				AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr, 100663735);
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x00090898 File Offset: 0x0008EA98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddFriendToExistingGame._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022C6 RID: 8902 RVA: 0x000908E0 File Offset: 0x0008EAE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022C7 RID: 8903 RVA: 0x00090914 File Offset: 0x0008EB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498950, XrefRangeEnd = 499011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x060022C8 RID: 8904 RVA: 0x00090950 File Offset: 0x0008EB50
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022C9 RID: 8905 RVA: 0x00090990 File Offset: 0x0008EB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499011, XrefRangeEnd = 499016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x060022CA RID: 8906 RVA: 0x000909C4 File Offset: 0x0008EBC4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddFriendToExistingGame._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022CB RID: 8907 RVA: 0x000121E3 File Offset: 0x000103E3
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x060022CC RID: 8908 RVA: 0x00090A04 File Offset: 0x0008EC04
			// (set) Token: 0x060022CD RID: 8909 RVA: 0x000121EC File Offset: 0x000103EC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x060022CE RID: 8910 RVA: 0x00090A2C File Offset: 0x0008EC2C
			// (set) Token: 0x060022CF RID: 8911 RVA: 0x00012207 File Offset: 0x00010407
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00090A5C File Offset: 0x0008EC5C
			// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00012226 File Offset: 0x00010426
			public unsafe AddFriendToExistingGame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddFriendToExistingGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00090A8C File Offset: 0x0008EC8C
			// (set) Token: 0x060022D3 RID: 8915 RVA: 0x00012245 File Offset: 0x00010445
			public unsafe ICanInviteUser _canInviteUser_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr__canInviteUser_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICanInviteUser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddFriendToExistingGame._execute_d__5.NativeFieldInfoPtr__canInviteUser_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeFieldInfoPtr__canInviteUser_5__2;

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
