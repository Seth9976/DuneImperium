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
	// Token: 0x0200025E RID: 606
	public class GiveAllianceToken : global::Canis.actions.Action
	{
		// Token: 0x060019ED RID: 6637 RVA: 0x000BDAFC File Offset: 0x000BBCFC
		// Note: this type is marked as 'beforefieldinit'.
		static GiveAllianceToken()
		{
			Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "GiveAllianceToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr);
			GiveAllianceToken.NativeFieldInfoPtr_allianceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, "allianceToken");
			GiveAllianceToken.NativeMethodInfoPtr__ctor_Public_Void_WormEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, 100668084);
			GiveAllianceToken.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, 100668085);
			GiveAllianceToken.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, 100668086);
			GiveAllianceToken.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, 100668087);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000BDB90 File Offset: 0x000BBD90
		[CallerCount(106)]
		[CachedScanResults(RefRangeStart = 139275, RefRangeEnd = 139381, XrefRangeStart = 139273, XrefRangeEnd = 139275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GiveAllianceToken(WormEntity allianceToken, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allianceToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken.NativeMethodInfoPtr__ctor_Public_Void_WormEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000BDBF0 File Offset: 0x000BBDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139381, XrefRangeEnd = 139387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GiveAllianceToken.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000BDC3C File Offset: 0x000BBE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139387, XrefRangeEnd = 139394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GiveAllianceToken.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000BDC98 File Offset: 0x000BBE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139394, XrefRangeEnd = 139399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GiveAllianceToken.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0000B291 File Offset: 0x00009491
		public GiveAllianceToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000BDCF4 File Offset: 0x000BBEF4
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0000B29A File Offset: 0x0000949A
		public unsafe WormEntity allianceToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken.NativeFieldInfoPtr_allianceToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken.NativeFieldInfoPtr_allianceToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeFieldInfoPtr_allianceToken;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormEntity_Match_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x02000697 RID: 1687
		[ObfuscatedName("worm.canis.actions.GiveAllianceToken+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x0600580C RID: 22540 RVA: 0x001C0F1C File Offset: 0x001BF11C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr);
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<>1__state");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<>2__current");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<>l__initialThreadId");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<>4__this");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__opponent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<opponent>5__2");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<player>5__3");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<wormMatch>5__4");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__stealSequence_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<stealSequence>5__5");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__playerAllianceTokenVP_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<playerAllianceTokenVP>5__6");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__childUndo_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<childUndo>5__7");
				GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, "<>7__wrap7");
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668088);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668089);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668090);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668091);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668092);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668093);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668094);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668095);
				GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr, 100668096);
			}

			// Token: 0x0600580D RID: 22541 RVA: 0x001C10D8 File Offset: 0x001BF2D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveAllianceToken._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600580E RID: 22542 RVA: 0x001C1120 File Offset: 0x001BF320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138971, XrefRangeEnd = 138976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600580F RID: 22543 RVA: 0x001C1154 File Offset: 0x001BF354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138976, XrefRangeEnd = 139209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005810 RID: 22544 RVA: 0x001C1190 File Offset: 0x001BF390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139209, XrefRangeEnd = 139212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001680 RID: 5760
			// (get) Token: 0x06005811 RID: 22545 RVA: 0x001C11C4 File Offset: 0x001BF3C4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005812 RID: 22546 RVA: 0x001C1204 File Offset: 0x001BF404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139212, XrefRangeEnd = 139217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001681 RID: 5761
			// (get) Token: 0x06005813 RID: 22547 RVA: 0x001C1238 File Offset: 0x001BF438
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005814 RID: 22548 RVA: 0x001C1278 File Offset: 0x001BF478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139217, XrefRangeEnd = 139219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005815 RID: 22549 RVA: 0x001C12B8 File Offset: 0x001BF4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005816 RID: 22550 RVA: 0x0001FF68 File Offset: 0x0001E168
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001675 RID: 5749
			// (get) Token: 0x06005817 RID: 22551 RVA: 0x001C12F8 File Offset: 0x001BF4F8
			// (set) Token: 0x06005818 RID: 22552 RVA: 0x0001FF71 File Offset: 0x0001E171
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001676 RID: 5750
			// (get) Token: 0x06005819 RID: 22553 RVA: 0x001C1320 File Offset: 0x001BF520
			// (set) Token: 0x0600581A RID: 22554 RVA: 0x0001FF8C File Offset: 0x0001E18C
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001677 RID: 5751
			// (get) Token: 0x0600581B RID: 22555 RVA: 0x001C1350 File Offset: 0x001BF550
			// (set) Token: 0x0600581C RID: 22556 RVA: 0x0001FFAB File Offset: 0x0001E1AB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001678 RID: 5752
			// (get) Token: 0x0600581D RID: 22557 RVA: 0x001C1378 File Offset: 0x001BF578
			// (set) Token: 0x0600581E RID: 22558 RVA: 0x0001FFC6 File Offset: 0x0001E1C6
			public unsafe GiveAllianceToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GiveAllianceToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001679 RID: 5753
			// (get) Token: 0x0600581F RID: 22559 RVA: 0x001C13A8 File Offset: 0x001BF5A8
			// (set) Token: 0x06005820 RID: 22560 RVA: 0x0001FFE5 File Offset: 0x0001E1E5
			public unsafe WormPlayer _opponent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__opponent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__opponent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167A RID: 5754
			// (get) Token: 0x06005821 RID: 22561 RVA: 0x001C13D8 File Offset: 0x001BF5D8
			// (set) Token: 0x06005822 RID: 22562 RVA: 0x00020004 File Offset: 0x0001E204
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167B RID: 5755
			// (get) Token: 0x06005823 RID: 22563 RVA: 0x001C1408 File Offset: 0x001BF608
			// (set) Token: 0x06005824 RID: 22564 RVA: 0x00020023 File Offset: 0x0001E223
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167C RID: 5756
			// (get) Token: 0x06005825 RID: 22565 RVA: 0x001C1438 File Offset: 0x001BF638
			// (set) Token: 0x06005826 RID: 22566 RVA: 0x00020042 File Offset: 0x0001E242
			public unsafe SequenceHelper _stealSequence_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__stealSequence_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__stealSequence_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167D RID: 5757
			// (get) Token: 0x06005827 RID: 22567 RVA: 0x001C1468 File Offset: 0x001BF668
			// (set) Token: 0x06005828 RID: 22568 RVA: 0x00020061 File Offset: 0x0001E261
			public unsafe int _playerAllianceTokenVP_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__playerAllianceTokenVP_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__playerAllianceTokenVP_5__6)) = value;
				}
			}

			// Token: 0x1700167E RID: 5758
			// (get) Token: 0x06005829 RID: 22569 RVA: 0x001C1490 File Offset: 0x001BF690
			// (set) Token: 0x0600582A RID: 22570 RVA: 0x0002007C File Offset: 0x0001E27C
			public unsafe UndoNode _childUndo_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__childUndo_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr__childUndo_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167F RID: 5759
			// (get) Token: 0x0600582B RID: 22571 RVA: 0x001C14C0 File Offset: 0x001BF6C0
			// (set) Token: 0x0600582C RID: 22572 RVA: 0x0002009B File Offset: 0x0001E29B
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._execute_d__2.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400396A RID: 14698
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400396B RID: 14699
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400396C RID: 14700
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400396D RID: 14701
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400396E RID: 14702
			private static readonly IntPtr NativeFieldInfoPtr__opponent_5__2;

			// Token: 0x0400396F RID: 14703
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x04003970 RID: 14704
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003971 RID: 14705
			private static readonly IntPtr NativeFieldInfoPtr__stealSequence_5__5;

			// Token: 0x04003972 RID: 14706
			private static readonly IntPtr NativeFieldInfoPtr__playerAllianceTokenVP_5__6;

			// Token: 0x04003973 RID: 14707
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__7;

			// Token: 0x04003974 RID: 14708
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04003975 RID: 14709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003976 RID: 14710
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003977 RID: 14711
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003978 RID: 14712
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003979 RID: 14713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400397A RID: 14714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400397B RID: 14715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400397C RID: 14716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400397D RID: 14717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000698 RID: 1688
		[ObfuscatedName("worm.canis.actions.GiveAllianceToken+<undo>d__3")]
		public sealed class _undo_d__3 : Object
		{
			// Token: 0x0600582D RID: 22573 RVA: 0x001C14F0 File Offset: 0x001BF6F0
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__3()
			{
				Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GiveAllianceToken>.NativeClassPtr, "<undo>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr);
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "<>1__state");
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "<>2__current");
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "<>l__initialThreadId");
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "undoContext");
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "<>3__undoContext");
				GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, "<>4__this");
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668097);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668098);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668099);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668100);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668101);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668102);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668103);
				GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr, 100668104);
			}

			// Token: 0x0600582E RID: 22574 RVA: 0x001C1634 File Offset: 0x001BF834
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GiveAllianceToken._undo_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600582F RID: 22575 RVA: 0x001C167C File Offset: 0x001BF87C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005830 RID: 22576 RVA: 0x001C16B0 File Offset: 0x001BF8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139219, XrefRangeEnd = 139259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001688 RID: 5768
			// (get) Token: 0x06005831 RID: 22577 RVA: 0x001C16EC File Offset: 0x001BF8EC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005832 RID: 22578 RVA: 0x001C172C File Offset: 0x001BF92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139259, XrefRangeEnd = 139264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001689 RID: 5769
			// (get) Token: 0x06005833 RID: 22579 RVA: 0x001C1760 File Offset: 0x001BF960
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005834 RID: 22580 RVA: 0x001C17A0 File Offset: 0x001BF9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139264, XrefRangeEnd = 139273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005835 RID: 22581 RVA: 0x001C17E0 File Offset: 0x001BF9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GiveAllianceToken._undo_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005836 RID: 22582 RVA: 0x000200BA File Offset: 0x0001E2BA
			public _undo_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001682 RID: 5762
			// (get) Token: 0x06005837 RID: 22583 RVA: 0x001C1820 File Offset: 0x001BFA20
			// (set) Token: 0x06005838 RID: 22584 RVA: 0x000200C3 File Offset: 0x0001E2C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001683 RID: 5763
			// (get) Token: 0x06005839 RID: 22585 RVA: 0x001C1848 File Offset: 0x001BFA48
			// (set) Token: 0x0600583A RID: 22586 RVA: 0x000200DE File Offset: 0x0001E2DE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001684 RID: 5764
			// (get) Token: 0x0600583B RID: 22587 RVA: 0x001C1878 File Offset: 0x001BFA78
			// (set) Token: 0x0600583C RID: 22588 RVA: 0x000200FD File Offset: 0x0001E2FD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001685 RID: 5765
			// (get) Token: 0x0600583D RID: 22589 RVA: 0x001C18A0 File Offset: 0x001BFAA0
			// (set) Token: 0x0600583E RID: 22590 RVA: 0x00020118 File Offset: 0x0001E318
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001686 RID: 5766
			// (get) Token: 0x0600583F RID: 22591 RVA: 0x001C18D0 File Offset: 0x001BFAD0
			// (set) Token: 0x06005840 RID: 22592 RVA: 0x00020137 File Offset: 0x0001E337
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001687 RID: 5767
			// (get) Token: 0x06005841 RID: 22593 RVA: 0x001C1900 File Offset: 0x001BFB00
			// (set) Token: 0x06005842 RID: 22594 RVA: 0x00020156 File Offset: 0x0001E356
			public unsafe GiveAllianceToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GiveAllianceToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GiveAllianceToken._undo_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400397E RID: 14718
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400397F RID: 14719
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003980 RID: 14720
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003981 RID: 14721
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003982 RID: 14722
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003983 RID: 14723
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003984 RID: 14724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003985 RID: 14725
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003986 RID: 14726
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003987 RID: 14727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003988 RID: 14728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003989 RID: 14729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400398A RID: 14730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400398B RID: 14731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
