using System;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C7 RID: 711
	public class HagalCombatPhase : Canis.actions.Action
	{
		// Token: 0x06001D48 RID: 7496 RVA: 0x000CAF94 File Offset: 0x000C9194
		// Note: this type is marked as 'beforefieldinit'.
		static HagalCombatPhase()
		{
			Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "HagalCombatPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr);
			HagalCombatPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr, "wormMatch");
			HagalCombatPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr, "player");
			HagalCombatPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr, 100669618);
			HagalCombatPhase.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr, 100669619);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x000CB014 File Offset: 0x000C9214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157930, RefRangeEnd = 157931, XrefRangeStart = 157927, XrefRangeEnd = 157930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalCombatPhase(WormPlayer player, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000CB074 File Offset: 0x000C9274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157931, XrefRangeEnd = 157937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalCombatPhase.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0000C567 File Offset: 0x0000A767
		public HagalCombatPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x000CB0C0 File Offset: 0x000C92C0
		// (set) Token: 0x06001D4D RID: 7501 RVA: 0x0000C570 File Offset: 0x0000A770
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x000CB0F0 File Offset: 0x000C92F0
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0000C58F File Offset: 0x0000A78F
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000734 RID: 1844
		[ObfuscatedName("worm.canis.actions.phases.HagalCombatPhase+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600656E RID: 25966 RVA: 0x001E8FC4 File Offset: 0x001E71C4
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalCombatPhase>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr);
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<>1__state");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<>2__current");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<>4__this");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsChecked_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<cardsChecked>5__2");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__strengthCardsPlayed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<strengthCardsPlayed>5__3");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__revealedHagalCards_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<revealedHagalCards>5__4");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsToPlay_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<cardsToPlay>5__5");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<sequenceHelper>5__6");
				HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__hagalCard_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, "<hagalCard>5__7");
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669620);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669621);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669622);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669623);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669624);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669625);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669626);
				HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr, 100669627);
			}

			// Token: 0x0600656F RID: 25967 RVA: 0x001E9158 File Offset: 0x001E7358
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalCombatPhase._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006570 RID: 25968 RVA: 0x001E91A0 File Offset: 0x001E73A0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006571 RID: 25969 RVA: 0x001E91D4 File Offset: 0x001E73D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157759, XrefRangeEnd = 157917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B45 RID: 6981
			// (get) Token: 0x06006572 RID: 25970 RVA: 0x001E9210 File Offset: 0x001E7410
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006573 RID: 25971 RVA: 0x001E9250 File Offset: 0x001E7450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157917, XrefRangeEnd = 157925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B46 RID: 6982
			// (get) Token: 0x06006574 RID: 25972 RVA: 0x001E9284 File Offset: 0x001E7484
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006575 RID: 25973 RVA: 0x001E92C4 File Offset: 0x001E74C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157925, XrefRangeEnd = 157927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006576 RID: 25974 RVA: 0x001E9304 File Offset: 0x001E7504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalCombatPhase._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006577 RID: 25975 RVA: 0x0002767D File Offset: 0x0002587D
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B3B RID: 6971
			// (get) Token: 0x06006578 RID: 25976 RVA: 0x001E9344 File Offset: 0x001E7544
			// (set) Token: 0x06006579 RID: 25977 RVA: 0x00027686 File Offset: 0x00025886
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B3C RID: 6972
			// (get) Token: 0x0600657A RID: 25978 RVA: 0x001E936C File Offset: 0x001E756C
			// (set) Token: 0x0600657B RID: 25979 RVA: 0x000276A1 File Offset: 0x000258A1
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3D RID: 6973
			// (get) Token: 0x0600657C RID: 25980 RVA: 0x001E939C File Offset: 0x001E759C
			// (set) Token: 0x0600657D RID: 25981 RVA: 0x000276C0 File Offset: 0x000258C0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B3E RID: 6974
			// (get) Token: 0x0600657E RID: 25982 RVA: 0x001E93C4 File Offset: 0x001E75C4
			// (set) Token: 0x0600657F RID: 25983 RVA: 0x000276DB File Offset: 0x000258DB
			public unsafe HagalCombatPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalCombatPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B3F RID: 6975
			// (get) Token: 0x06006580 RID: 25984 RVA: 0x001E93F4 File Offset: 0x001E75F4
			// (set) Token: 0x06006581 RID: 25985 RVA: 0x000276FA File Offset: 0x000258FA
			public unsafe int _cardsChecked_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsChecked_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsChecked_5__2)) = value;
				}
			}

			// Token: 0x17001B40 RID: 6976
			// (get) Token: 0x06006582 RID: 25986 RVA: 0x001E941C File Offset: 0x001E761C
			// (set) Token: 0x06006583 RID: 25987 RVA: 0x00027715 File Offset: 0x00025915
			public unsafe int _strengthCardsPlayed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__strengthCardsPlayed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__strengthCardsPlayed_5__3)) = value;
				}
			}

			// Token: 0x17001B41 RID: 6977
			// (get) Token: 0x06006584 RID: 25988 RVA: 0x001E9444 File Offset: 0x001E7644
			// (set) Token: 0x06006585 RID: 25989 RVA: 0x00027730 File Offset: 0x00025930
			public unsafe List<ArchetypeID> _revealedHagalCards_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__revealedHagalCards_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__revealedHagalCards_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B42 RID: 6978
			// (get) Token: 0x06006586 RID: 25990 RVA: 0x001E9474 File Offset: 0x001E7674
			// (set) Token: 0x06006587 RID: 25991 RVA: 0x0002774F File Offset: 0x0002594F
			public unsafe int _cardsToPlay_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsToPlay_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__cardsToPlay_5__5)) = value;
				}
			}

			// Token: 0x17001B43 RID: 6979
			// (get) Token: 0x06006588 RID: 25992 RVA: 0x001E949C File Offset: 0x001E769C
			// (set) Token: 0x06006589 RID: 25993 RVA: 0x0002776A File Offset: 0x0002596A
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B44 RID: 6980
			// (get) Token: 0x0600658A RID: 25994 RVA: 0x001E94CC File Offset: 0x001E76CC
			// (set) Token: 0x0600658B RID: 25995 RVA: 0x00027789 File Offset: 0x00025989
			public unsafe WormHagalPlayable _hagalCard_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__hagalCard_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHagalPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalCombatPhase._execute_d__3.NativeFieldInfoPtr__hagalCard_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041A4 RID: 16804
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040041A5 RID: 16805
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040041A6 RID: 16806
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040041A7 RID: 16807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040041A8 RID: 16808
			private static readonly IntPtr NativeFieldInfoPtr__cardsChecked_5__2;

			// Token: 0x040041A9 RID: 16809
			private static readonly IntPtr NativeFieldInfoPtr__strengthCardsPlayed_5__3;

			// Token: 0x040041AA RID: 16810
			private static readonly IntPtr NativeFieldInfoPtr__revealedHagalCards_5__4;

			// Token: 0x040041AB RID: 16811
			private static readonly IntPtr NativeFieldInfoPtr__cardsToPlay_5__5;

			// Token: 0x040041AC RID: 16812
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x040041AD RID: 16813
			private static readonly IntPtr NativeFieldInfoPtr__hagalCard_5__7;

			// Token: 0x040041AE RID: 16814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040041AF RID: 16815
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041B0 RID: 16816
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040041B1 RID: 16817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040041B2 RID: 16818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040041B3 RID: 16819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040041B4 RID: 16820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040041B5 RID: 16821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
