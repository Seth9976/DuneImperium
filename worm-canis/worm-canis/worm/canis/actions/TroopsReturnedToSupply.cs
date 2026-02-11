using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x020002A3 RID: 675
	public class TroopsReturnedToSupply : global::Canis.actions.Action
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x000C5D04 File Offset: 0x000C3F04
		// Note: this type is marked as 'beforefieldinit'.
		static TroopsReturnedToSupply()
		{
			Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "TroopsReturnedToSupply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr);
			TroopsReturnedToSupply.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, 100668977);
			TroopsReturnedToSupply.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, 100668978);
			TroopsReturnedToSupply.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, 100668979);
			TroopsReturnedToSupply.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, 100668980);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000C5D84 File Offset: 0x000C3F84
		[CallerCount(191)]
		[CachedScanResults(RefRangeStart = 51381, RefRangeEnd = 51572, XrefRangeStart = 51381, XrefRangeEnd = 51572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TroopsReturnedToSupply(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000C5DD0 File Offset: 0x000C3FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149482, XrefRangeEnd = 149488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TroopsReturnedToSupply.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000C5E1C File Offset: 0x000C401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149488, XrefRangeEnd = 149495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TroopsReturnedToSupply.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000C5E78 File Offset: 0x000C4078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149495, XrefRangeEnd = 149499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TroopsReturnedToSupply.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0000BF19 File Offset: 0x0000A119
		public TroopsReturnedToSupply(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006F2 RID: 1778
		[ObfuscatedName("worm.canis.actions.TroopsReturnedToSupply+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06006000 RID: 24576 RVA: 0x001D8520 File Offset: 0x001D6720
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr);
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<>1__state");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<>2__current");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<>l__initialThreadId");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<>4__this");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__wm_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<wm>5__2");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<player>5__3");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsInSupply_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<troopsInSupply>5__4");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__undeployedTroops_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<undeployedTroops>5__5");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__unaddedTechNegotiators_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<unaddedTechNegotiators>5__6");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToGain_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<troopsToGain>5__7");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToDeploy_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<troopsToDeploy>5__8");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__negotiatorsToAdd_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<negotiatorsToAdd>5__9");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__specimensToGain_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<specimensToGain>5__10");
				TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__childUndo_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, "<childUndo>5__11");
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668981);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668982);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668983);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668984);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668985);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668986);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668987);
				TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr, 100668988);
			}

			// Token: 0x06006001 RID: 24577 RVA: 0x001D8704 File Offset: 0x001D6904
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TroopsReturnedToSupply._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006002 RID: 24578 RVA: 0x001D874C File Offset: 0x001D694C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006003 RID: 24579 RVA: 0x001D8780 File Offset: 0x001D6980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149198, XrefRangeEnd = 149405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700196D RID: 6509
			// (get) Token: 0x06006004 RID: 24580 RVA: 0x001D87BC File Offset: 0x001D69BC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006005 RID: 24581 RVA: 0x001D87FC File Offset: 0x001D69FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149405, XrefRangeEnd = 149410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700196E RID: 6510
			// (get) Token: 0x06006006 RID: 24582 RVA: 0x001D8830 File Offset: 0x001D6A30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006007 RID: 24583 RVA: 0x001D8870 File Offset: 0x001D6A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149410, XrefRangeEnd = 149412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006008 RID: 24584 RVA: 0x001D88B0 File Offset: 0x001D6AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006009 RID: 24585 RVA: 0x00024906 File Offset: 0x00022B06
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700195F RID: 6495
			// (get) Token: 0x0600600A RID: 24586 RVA: 0x001D88F0 File Offset: 0x001D6AF0
			// (set) Token: 0x0600600B RID: 24587 RVA: 0x0002490F File Offset: 0x00022B0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001960 RID: 6496
			// (get) Token: 0x0600600C RID: 24588 RVA: 0x001D8918 File Offset: 0x001D6B18
			// (set) Token: 0x0600600D RID: 24589 RVA: 0x0002492A File Offset: 0x00022B2A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001961 RID: 6497
			// (get) Token: 0x0600600E RID: 24590 RVA: 0x001D8948 File Offset: 0x001D6B48
			// (set) Token: 0x0600600F RID: 24591 RVA: 0x00024949 File Offset: 0x00022B49
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001962 RID: 6498
			// (get) Token: 0x06006010 RID: 24592 RVA: 0x001D8970 File Offset: 0x001D6B70
			// (set) Token: 0x06006011 RID: 24593 RVA: 0x00024964 File Offset: 0x00022B64
			public unsafe TroopsReturnedToSupply __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TroopsReturnedToSupply>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001963 RID: 6499
			// (get) Token: 0x06006012 RID: 24594 RVA: 0x001D89A0 File Offset: 0x001D6BA0
			// (set) Token: 0x06006013 RID: 24595 RVA: 0x00024983 File Offset: 0x00022B83
			public unsafe WormMatch _wm_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__wm_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__wm_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001964 RID: 6500
			// (get) Token: 0x06006014 RID: 24596 RVA: 0x001D89D0 File Offset: 0x001D6BD0
			// (set) Token: 0x06006015 RID: 24597 RVA: 0x000249A2 File Offset: 0x00022BA2
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001965 RID: 6501
			// (get) Token: 0x06006016 RID: 24598 RVA: 0x001D8A00 File Offset: 0x001D6C00
			// (set) Token: 0x06006017 RID: 24599 RVA: 0x000249C1 File Offset: 0x00022BC1
			public unsafe int _troopsInSupply_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsInSupply_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsInSupply_5__4)) = value;
				}
			}

			// Token: 0x17001966 RID: 6502
			// (get) Token: 0x06006018 RID: 24600 RVA: 0x001D8A28 File Offset: 0x001D6C28
			// (set) Token: 0x06006019 RID: 24601 RVA: 0x000249DC File Offset: 0x00022BDC
			public unsafe int _undeployedTroops_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__undeployedTroops_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__undeployedTroops_5__5)) = value;
				}
			}

			// Token: 0x17001967 RID: 6503
			// (get) Token: 0x0600601A RID: 24602 RVA: 0x001D8A50 File Offset: 0x001D6C50
			// (set) Token: 0x0600601B RID: 24603 RVA: 0x000249F7 File Offset: 0x00022BF7
			public unsafe int _unaddedTechNegotiators_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__unaddedTechNegotiators_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__unaddedTechNegotiators_5__6)) = value;
				}
			}

			// Token: 0x17001968 RID: 6504
			// (get) Token: 0x0600601C RID: 24604 RVA: 0x001D8A78 File Offset: 0x001D6C78
			// (set) Token: 0x0600601D RID: 24605 RVA: 0x00024A12 File Offset: 0x00022C12
			public unsafe int _troopsToGain_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToGain_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToGain_5__7)) = value;
				}
			}

			// Token: 0x17001969 RID: 6505
			// (get) Token: 0x0600601E RID: 24606 RVA: 0x001D8AA0 File Offset: 0x001D6CA0
			// (set) Token: 0x0600601F RID: 24607 RVA: 0x00024A2D File Offset: 0x00022C2D
			public unsafe int _troopsToDeploy_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToDeploy_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__troopsToDeploy_5__8)) = value;
				}
			}

			// Token: 0x1700196A RID: 6506
			// (get) Token: 0x06006020 RID: 24608 RVA: 0x001D8AC8 File Offset: 0x001D6CC8
			// (set) Token: 0x06006021 RID: 24609 RVA: 0x00024A48 File Offset: 0x00022C48
			public unsafe int _negotiatorsToAdd_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__negotiatorsToAdd_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__negotiatorsToAdd_5__9)) = value;
				}
			}

			// Token: 0x1700196B RID: 6507
			// (get) Token: 0x06006022 RID: 24610 RVA: 0x001D8AF0 File Offset: 0x001D6CF0
			// (set) Token: 0x06006023 RID: 24611 RVA: 0x00024A63 File Offset: 0x00022C63
			public unsafe int _specimensToGain_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__specimensToGain_5__10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__specimensToGain_5__10)) = value;
				}
			}

			// Token: 0x1700196C RID: 6508
			// (get) Token: 0x06006024 RID: 24612 RVA: 0x001D8B18 File Offset: 0x001D6D18
			// (set) Token: 0x06006025 RID: 24613 RVA: 0x00024A7E File Offset: 0x00022C7E
			public unsafe UndoNode _childUndo_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__childUndo_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._execute_d__1.NativeFieldInfoPtr__childUndo_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E44 RID: 15940
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E45 RID: 15941
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E46 RID: 15942
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003E47 RID: 15943
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E48 RID: 15944
			private static readonly IntPtr NativeFieldInfoPtr__wm_5__2;

			// Token: 0x04003E49 RID: 15945
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003E4A RID: 15946
			private static readonly IntPtr NativeFieldInfoPtr__troopsInSupply_5__4;

			// Token: 0x04003E4B RID: 15947
			private static readonly IntPtr NativeFieldInfoPtr__undeployedTroops_5__5;

			// Token: 0x04003E4C RID: 15948
			private static readonly IntPtr NativeFieldInfoPtr__unaddedTechNegotiators_5__6;

			// Token: 0x04003E4D RID: 15949
			private static readonly IntPtr NativeFieldInfoPtr__troopsToGain_5__7;

			// Token: 0x04003E4E RID: 15950
			private static readonly IntPtr NativeFieldInfoPtr__troopsToDeploy_5__8;

			// Token: 0x04003E4F RID: 15951
			private static readonly IntPtr NativeFieldInfoPtr__negotiatorsToAdd_5__9;

			// Token: 0x04003E50 RID: 15952
			private static readonly IntPtr NativeFieldInfoPtr__specimensToGain_5__10;

			// Token: 0x04003E51 RID: 15953
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__11;

			// Token: 0x04003E52 RID: 15954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E53 RID: 15955
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E54 RID: 15956
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E55 RID: 15957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003E56 RID: 15958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E57 RID: 15959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E58 RID: 15960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003E59 RID: 15961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006F3 RID: 1779
		[ObfuscatedName("worm.canis.actions.TroopsReturnedToSupply+<undo>d__2")]
		public sealed class _undo_d__2 : Object
		{
			// Token: 0x06006026 RID: 24614 RVA: 0x001D8B48 File Offset: 0x001D6D48
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__2()
			{
				Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TroopsReturnedToSupply>.NativeClassPtr, "<undo>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr);
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<>1__state");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<>2__current");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<>l__initialThreadId");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<>4__this");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "undoContext");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<>3__undoContext");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<player>5__2");
				TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__undoNode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, "<undoNode>5__3");
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668989);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668990);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668991);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668992);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668993);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668994);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668995);
				TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr, 100668996);
			}

			// Token: 0x06006027 RID: 24615 RVA: 0x001D8CB4 File Offset: 0x001D6EB4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TroopsReturnedToSupply._undo_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006028 RID: 24616 RVA: 0x001D8CFC File Offset: 0x001D6EFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006029 RID: 24617 RVA: 0x001D8D30 File Offset: 0x001D6F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149412, XrefRangeEnd = 149468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001977 RID: 6519
			// (get) Token: 0x0600602A RID: 24618 RVA: 0x001D8D6C File Offset: 0x001D6F6C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600602B RID: 24619 RVA: 0x001D8DAC File Offset: 0x001D6FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149468, XrefRangeEnd = 149473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001978 RID: 6520
			// (get) Token: 0x0600602C RID: 24620 RVA: 0x001D8DE0 File Offset: 0x001D6FE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600602D RID: 24621 RVA: 0x001D8E20 File Offset: 0x001D7020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149473, XrefRangeEnd = 149482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600602E RID: 24622 RVA: 0x001D8E60 File Offset: 0x001D7060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TroopsReturnedToSupply._undo_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600602F RID: 24623 RVA: 0x00024A9D File Offset: 0x00022C9D
			public _undo_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700196F RID: 6511
			// (get) Token: 0x06006030 RID: 24624 RVA: 0x001D8EA0 File Offset: 0x001D70A0
			// (set) Token: 0x06006031 RID: 24625 RVA: 0x00024AA6 File Offset: 0x00022CA6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001970 RID: 6512
			// (get) Token: 0x06006032 RID: 24626 RVA: 0x001D8EC8 File Offset: 0x001D70C8
			// (set) Token: 0x06006033 RID: 24627 RVA: 0x00024AC1 File Offset: 0x00022CC1
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001971 RID: 6513
			// (get) Token: 0x06006034 RID: 24628 RVA: 0x001D8EF8 File Offset: 0x001D70F8
			// (set) Token: 0x06006035 RID: 24629 RVA: 0x00024AE0 File Offset: 0x00022CE0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001972 RID: 6514
			// (get) Token: 0x06006036 RID: 24630 RVA: 0x001D8F20 File Offset: 0x001D7120
			// (set) Token: 0x06006037 RID: 24631 RVA: 0x00024AFB File Offset: 0x00022CFB
			public unsafe TroopsReturnedToSupply __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TroopsReturnedToSupply>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001973 RID: 6515
			// (get) Token: 0x06006038 RID: 24632 RVA: 0x001D8F50 File Offset: 0x001D7150
			// (set) Token: 0x06006039 RID: 24633 RVA: 0x00024B1A File Offset: 0x00022D1A
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001974 RID: 6516
			// (get) Token: 0x0600603A RID: 24634 RVA: 0x001D8F80 File Offset: 0x001D7180
			// (set) Token: 0x0600603B RID: 24635 RVA: 0x00024B39 File Offset: 0x00022D39
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001975 RID: 6517
			// (get) Token: 0x0600603C RID: 24636 RVA: 0x001D8FB0 File Offset: 0x001D71B0
			// (set) Token: 0x0600603D RID: 24637 RVA: 0x00024B58 File Offset: 0x00022D58
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001976 RID: 6518
			// (get) Token: 0x0600603E RID: 24638 RVA: 0x001D8FE0 File Offset: 0x001D71E0
			// (set) Token: 0x0600603F RID: 24639 RVA: 0x00024B77 File Offset: 0x00022D77
			public unsafe UndoNode _undoNode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__undoNode_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TroopsReturnedToSupply._undo_d__2.NativeFieldInfoPtr__undoNode_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E5A RID: 15962
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003E5B RID: 15963
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003E5C RID: 15964
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003E5D RID: 15965
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003E5E RID: 15966
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003E5F RID: 15967
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003E60 RID: 15968
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003E61 RID: 15969
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__3;

			// Token: 0x04003E62 RID: 15970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003E63 RID: 15971
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E64 RID: 15972
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003E65 RID: 15973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003E66 RID: 15974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003E67 RID: 15975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003E68 RID: 15976
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003E69 RID: 15977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
