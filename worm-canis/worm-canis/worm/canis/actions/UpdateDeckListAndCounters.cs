using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x020002AB RID: 683
	public class UpdateDeckListAndCounters : global::Canis.actions.Action
	{
		// Token: 0x06001C34 RID: 7220 RVA: 0x000C6804 File Offset: 0x000C4A04
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateDeckListAndCounters()
		{
			Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "UpdateDeckListAndCounters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr);
			UpdateDeckListAndCounters.NativeFieldInfoPtr_indexInRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, "indexInRow");
			UpdateDeckListAndCounters.NativeFieldInfoPtr_helenaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, "helenaIndex");
			UpdateDeckListAndCounters.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, 100669065);
			UpdateDeckListAndCounters.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, 100669066);
			UpdateDeckListAndCounters.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, 100669067);
			UpdateDeckListAndCounters.NativeMethodInfoPtr_UpdateCounters_Public_Static_IEnumerable_1_Action_Int32_WormMatch_WormPlayer_WormImperiumPlayable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, 100669068);
			UpdateDeckListAndCounters.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, 100669069);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x000C68C0 File Offset: 0x000C4AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150627, RefRangeEnd = 150628, XrefRangeStart = 150626, XrefRangeEnd = 150627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateDeckListAndCounters(Match m, int indexInRow, int helenaIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexInRow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref helenaIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters.NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000C6928 File Offset: 0x000C4B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150628, XrefRangeEnd = 150634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeckListAndCounters.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x000C6974 File Offset: 0x000C4B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150634, XrefRangeEnd = 150641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> undo(Context undoContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeckListAndCounters.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x000C69D0 File Offset: 0x000C4BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150649, RefRangeEnd = 150651, XrefRangeStart = 150641, XrefRangeEnd = 150649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<global::Canis.actions.Action> UpdateCounters(int amount, WormMatch wormMatch, WormPlayer wormPlayer, WormImperiumPlayable card, bool imperiumRow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imperiumRow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters.NativeMethodInfoPtr_UpdateCounters_Public_Static_IEnumerable_1_Action_Int32_WormMatch_WormPlayer_WormImperiumPlayable_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x000C6A54 File Offset: 0x000C4C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150651, XrefRangeEnd = 150655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateDeckListAndCounters.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0000BF61 File Offset: 0x0000A161
		public UpdateDeckListAndCounters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000C6AB0 File Offset: 0x000C4CB0
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0000BF6A File Offset: 0x0000A16A
		public unsafe int indexInRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters.NativeFieldInfoPtr_indexInRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters.NativeFieldInfoPtr_indexInRow)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x000C6AD8 File Offset: 0x000C4CD8
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0000BF85 File Offset: 0x0000A185
		public unsafe int helenaIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters.NativeFieldInfoPtr_helenaIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters.NativeFieldInfoPtr_helenaIndex)) = value;
			}
		}

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_indexInRow;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeFieldInfoPtr_helenaIndex;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_Int32_Int32_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCounters_Public_Static_IEnumerable_1_Action_Int32_WormMatch_WormPlayer_WormImperiumPlayable_Boolean_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x020006FA RID: 1786
		[ObfuscatedName("worm.canis.actions.UpdateDeckListAndCounters+<UpdateCounters>d__5")]
		public sealed class _UpdateCounters_d__5 : Object
		{
			// Token: 0x060060CA RID: 24778 RVA: 0x001DAA5C File Offset: 0x001D8C5C
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateCounters_d__5()
			{
				Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, "<UpdateCounters>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>1__state");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>2__current");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>l__initialThreadId");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "card");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>3__card");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "amount");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>3__amount");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "wormMatch");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>3__wormMatch");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "wormPlayer");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>3__wormPlayer");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_imperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "imperiumRow");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__imperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<>3__imperiumRow");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr__persuasionCost_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, "<persuasionCost>5__2");
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669070);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669071);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669072);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669073);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669074);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669075);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669076);
				UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr, 100669077);
			}

			// Token: 0x060060CB RID: 24779 RVA: 0x001DAC40 File Offset: 0x001D8E40
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateCounters_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeckListAndCounters._UpdateCounters_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060CC RID: 24780 RVA: 0x001DAC88 File Offset: 0x001D8E88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060CD RID: 24781 RVA: 0x001DACBC File Offset: 0x001D8EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149893, XrefRangeEnd = 150110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170019BA RID: 6586
			// (get) Token: 0x060060CE RID: 24782 RVA: 0x001DACF8 File Offset: 0x001D8EF8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060060CF RID: 24783 RVA: 0x001DAD38 File Offset: 0x001D8F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150110, XrefRangeEnd = 150115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019BB RID: 6587
			// (get) Token: 0x060060D0 RID: 24784 RVA: 0x001DAD6C File Offset: 0x001D8F6C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060060D1 RID: 24785 RVA: 0x001DADAC File Offset: 0x001D8FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150115, XrefRangeEnd = 150125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060060D2 RID: 24786 RVA: 0x001DADEC File Offset: 0x001D8FEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060060D3 RID: 24787 RVA: 0x00025055 File Offset: 0x00023255
			public _UpdateCounters_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019AC RID: 6572
			// (get) Token: 0x060060D4 RID: 24788 RVA: 0x001DAE2C File Offset: 0x001D902C
			// (set) Token: 0x060060D5 RID: 24789 RVA: 0x0002505E File Offset: 0x0002325E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170019AD RID: 6573
			// (get) Token: 0x060060D6 RID: 24790 RVA: 0x001DAE54 File Offset: 0x001D9054
			// (set) Token: 0x060060D7 RID: 24791 RVA: 0x00025079 File Offset: 0x00023279
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019AE RID: 6574
			// (get) Token: 0x060060D8 RID: 24792 RVA: 0x001DAE84 File Offset: 0x001D9084
			// (set) Token: 0x060060D9 RID: 24793 RVA: 0x00025098 File Offset: 0x00023298
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170019AF RID: 6575
			// (get) Token: 0x060060DA RID: 24794 RVA: 0x001DAEAC File Offset: 0x001D90AC
			// (set) Token: 0x060060DB RID: 24795 RVA: 0x000250B3 File Offset: 0x000232B3
			public unsafe WormImperiumPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B0 RID: 6576
			// (get) Token: 0x060060DC RID: 24796 RVA: 0x001DAEDC File Offset: 0x001D90DC
			// (set) Token: 0x060060DD RID: 24797 RVA: 0x000250D2 File Offset: 0x000232D2
			public unsafe WormImperiumPlayable __3__card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B1 RID: 6577
			// (get) Token: 0x060060DE RID: 24798 RVA: 0x001DAF0C File Offset: 0x001D910C
			// (set) Token: 0x060060DF RID: 24799 RVA: 0x000250F1 File Offset: 0x000232F1
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x170019B2 RID: 6578
			// (get) Token: 0x060060E0 RID: 24800 RVA: 0x001DAF34 File Offset: 0x001D9134
			// (set) Token: 0x060060E1 RID: 24801 RVA: 0x0002510C File Offset: 0x0002330C
			public unsafe int __3__amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__amount)) = value;
				}
			}

			// Token: 0x170019B3 RID: 6579
			// (get) Token: 0x060060E2 RID: 24802 RVA: 0x001DAF5C File Offset: 0x001D915C
			// (set) Token: 0x060060E3 RID: 24803 RVA: 0x00025127 File Offset: 0x00023327
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B4 RID: 6580
			// (get) Token: 0x060060E4 RID: 24804 RVA: 0x001DAF8C File Offset: 0x001D918C
			// (set) Token: 0x060060E5 RID: 24805 RVA: 0x00025146 File Offset: 0x00023346
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B5 RID: 6581
			// (get) Token: 0x060060E6 RID: 24806 RVA: 0x001DAFBC File Offset: 0x001D91BC
			// (set) Token: 0x060060E7 RID: 24807 RVA: 0x00025165 File Offset: 0x00023365
			public unsafe WormPlayer wormPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_wormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B6 RID: 6582
			// (get) Token: 0x060060E8 RID: 24808 RVA: 0x001DAFEC File Offset: 0x001D91EC
			// (set) Token: 0x060060E9 RID: 24809 RVA: 0x00025184 File Offset: 0x00023384
			public unsafe WormPlayer __3__wormPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__wormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019B7 RID: 6583
			// (get) Token: 0x060060EA RID: 24810 RVA: 0x001DB01C File Offset: 0x001D921C
			// (set) Token: 0x060060EB RID: 24811 RVA: 0x000251A3 File Offset: 0x000233A3
			public unsafe bool imperiumRow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_imperiumRow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr_imperiumRow)) = value;
				}
			}

			// Token: 0x170019B8 RID: 6584
			// (get) Token: 0x060060EC RID: 24812 RVA: 0x001DB044 File Offset: 0x001D9244
			// (set) Token: 0x060060ED RID: 24813 RVA: 0x000251BE File Offset: 0x000233BE
			public unsafe bool __3__imperiumRow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__imperiumRow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr___3__imperiumRow)) = value;
				}
			}

			// Token: 0x170019B9 RID: 6585
			// (get) Token: 0x060060EE RID: 24814 RVA: 0x001DB06C File Offset: 0x001D926C
			// (set) Token: 0x060060EF RID: 24815 RVA: 0x000251D9 File Offset: 0x000233D9
			public unsafe int _persuasionCost_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr__persuasionCost_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._UpdateCounters_d__5.NativeFieldInfoPtr__persuasionCost_5__2)) = value;
				}
			}

			// Token: 0x04003EC1 RID: 16065
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EC2 RID: 16066
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EC3 RID: 16067
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003EC4 RID: 16068
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04003EC5 RID: 16069
			private static readonly IntPtr NativeFieldInfoPtr___3__card;

			// Token: 0x04003EC6 RID: 16070
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04003EC7 RID: 16071
			private static readonly IntPtr NativeFieldInfoPtr___3__amount;

			// Token: 0x04003EC8 RID: 16072
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04003EC9 RID: 16073
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04003ECA RID: 16074
			private static readonly IntPtr NativeFieldInfoPtr_wormPlayer;

			// Token: 0x04003ECB RID: 16075
			private static readonly IntPtr NativeFieldInfoPtr___3__wormPlayer;

			// Token: 0x04003ECC RID: 16076
			private static readonly IntPtr NativeFieldInfoPtr_imperiumRow;

			// Token: 0x04003ECD RID: 16077
			private static readonly IntPtr NativeFieldInfoPtr___3__imperiumRow;

			// Token: 0x04003ECE RID: 16078
			private static readonly IntPtr NativeFieldInfoPtr__persuasionCost_5__2;

			// Token: 0x04003ECF RID: 16079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003ED0 RID: 16080
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003ED1 RID: 16081
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003ED2 RID: 16082
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003ED3 RID: 16083
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003ED4 RID: 16084
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003ED5 RID: 16085
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003ED6 RID: 16086
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006FB RID: 1787
		[ObfuscatedName("worm.canis.actions.UpdateDeckListAndCounters+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x060060F0 RID: 24816 RVA: 0x001DB094 File Offset: 0x001D9294
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr);
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<>1__state");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<>2__current");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<>l__initialThreadId");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<>4__this");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<player>5__2");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__cardToAcquire_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<cardToAcquire>5__3");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<wormMatch>5__4");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesPersuasion_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<lietKynesPersuasion>5__5");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesSpent_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<lietKynesSpent>5__6");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lastCardAcquired_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<lastCardAcquired>5__7");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<>7__wrap7");
				UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__childUndo_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, "<childUndo>5__9");
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669078);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669079);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669080);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669081);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669082);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669083);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669084);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669085);
				UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr, 100669086);
			}

			// Token: 0x060060F1 RID: 24817 RVA: 0x001DB264 File Offset: 0x001D9464
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeckListAndCounters._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060060F2 RID: 24818 RVA: 0x001DB2AC File Offset: 0x001D94AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 150130, RefRangeEnd = 150131, XrefRangeStart = 150125, XrefRangeEnd = 150130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060060F3 RID: 24819 RVA: 0x001DB2E0 File Offset: 0x001D94E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150131, XrefRangeEnd = 150380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060060F4 RID: 24820 RVA: 0x001DB31C File Offset: 0x001D951C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150380, XrefRangeEnd = 150383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019C8 RID: 6600
			// (get) Token: 0x060060F5 RID: 24821 RVA: 0x001DB350 File Offset: 0x001D9550
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060060F6 RID: 24822 RVA: 0x001DB390 File Offset: 0x001D9590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150383, XrefRangeEnd = 150388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019C9 RID: 6601
			// (get) Token: 0x060060F7 RID: 24823 RVA: 0x001DB3C4 File Offset: 0x001D95C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060060F8 RID: 24824 RVA: 0x001DB404 File Offset: 0x001D9604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150388, XrefRangeEnd = 150390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060060F9 RID: 24825 RVA: 0x001DB444 File Offset: 0x001D9644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060060FA RID: 24826 RVA: 0x000251F4 File Offset: 0x000233F4
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019BC RID: 6588
			// (get) Token: 0x060060FB RID: 24827 RVA: 0x001DB484 File Offset: 0x001D9684
			// (set) Token: 0x060060FC RID: 24828 RVA: 0x000251FD File Offset: 0x000233FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170019BD RID: 6589
			// (get) Token: 0x060060FD RID: 24829 RVA: 0x001DB4AC File Offset: 0x001D96AC
			// (set) Token: 0x060060FE RID: 24830 RVA: 0x00025218 File Offset: 0x00023418
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019BE RID: 6590
			// (get) Token: 0x060060FF RID: 24831 RVA: 0x001DB4DC File Offset: 0x001D96DC
			// (set) Token: 0x06006100 RID: 24832 RVA: 0x00025237 File Offset: 0x00023437
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170019BF RID: 6591
			// (get) Token: 0x06006101 RID: 24833 RVA: 0x001DB504 File Offset: 0x001D9704
			// (set) Token: 0x06006102 RID: 24834 RVA: 0x00025252 File Offset: 0x00023452
			public unsafe UpdateDeckListAndCounters __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDeckListAndCounters>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C0 RID: 6592
			// (get) Token: 0x06006103 RID: 24835 RVA: 0x001DB534 File Offset: 0x001D9734
			// (set) Token: 0x06006104 RID: 24836 RVA: 0x00025271 File Offset: 0x00023471
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C1 RID: 6593
			// (get) Token: 0x06006105 RID: 24837 RVA: 0x001DB564 File Offset: 0x001D9764
			// (set) Token: 0x06006106 RID: 24838 RVA: 0x00025290 File Offset: 0x00023490
			public unsafe WormImperiumPlayable _cardToAcquire_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__cardToAcquire_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__cardToAcquire_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C2 RID: 6594
			// (get) Token: 0x06006107 RID: 24839 RVA: 0x001DB594 File Offset: 0x001D9794
			// (set) Token: 0x06006108 RID: 24840 RVA: 0x000252AF File Offset: 0x000234AF
			public unsafe WormMatch _wormMatch_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__wormMatch_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C3 RID: 6595
			// (get) Token: 0x06006109 RID: 24841 RVA: 0x001DB5C4 File Offset: 0x001D97C4
			// (set) Token: 0x0600610A RID: 24842 RVA: 0x000252CE File Offset: 0x000234CE
			public unsafe int _lietKynesPersuasion_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesPersuasion_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesPersuasion_5__5)) = value;
				}
			}

			// Token: 0x170019C4 RID: 6596
			// (get) Token: 0x0600610B RID: 24843 RVA: 0x001DB5EC File Offset: 0x001D97EC
			// (set) Token: 0x0600610C RID: 24844 RVA: 0x000252E9 File Offset: 0x000234E9
			public unsafe bool _lietKynesSpent_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesSpent_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lietKynesSpent_5__6)) = value;
				}
			}

			// Token: 0x170019C5 RID: 6597
			// (get) Token: 0x0600610D RID: 24845 RVA: 0x001DB614 File Offset: 0x001D9814
			// (set) Token: 0x0600610E RID: 24846 RVA: 0x00025304 File Offset: 0x00023504
			public unsafe ArchetypeID _lastCardAcquired_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lastCardAcquired_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__lastCardAcquired_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C6 RID: 6598
			// (get) Token: 0x0600610F RID: 24847 RVA: 0x001DB644 File Offset: 0x001D9844
			// (set) Token: 0x06006110 RID: 24848 RVA: 0x00025323 File Offset: 0x00023523
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019C7 RID: 6599
			// (get) Token: 0x06006111 RID: 24849 RVA: 0x001DB674 File Offset: 0x001D9874
			// (set) Token: 0x06006112 RID: 24850 RVA: 0x00025342 File Offset: 0x00023542
			public unsafe UndoNode _childUndo_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__childUndo_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._execute_d__3.NativeFieldInfoPtr__childUndo_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003ED7 RID: 16087
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003ED8 RID: 16088
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003ED9 RID: 16089
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003EDA RID: 16090
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EDB RID: 16091
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003EDC RID: 16092
			private static readonly IntPtr NativeFieldInfoPtr__cardToAcquire_5__3;

			// Token: 0x04003EDD RID: 16093
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__4;

			// Token: 0x04003EDE RID: 16094
			private static readonly IntPtr NativeFieldInfoPtr__lietKynesPersuasion_5__5;

			// Token: 0x04003EDF RID: 16095
			private static readonly IntPtr NativeFieldInfoPtr__lietKynesSpent_5__6;

			// Token: 0x04003EE0 RID: 16096
			private static readonly IntPtr NativeFieldInfoPtr__lastCardAcquired_5__7;

			// Token: 0x04003EE1 RID: 16097
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04003EE2 RID: 16098
			private static readonly IntPtr NativeFieldInfoPtr__childUndo_5__9;

			// Token: 0x04003EE3 RID: 16099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EE4 RID: 16100
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EE5 RID: 16101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EE6 RID: 16102
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003EE7 RID: 16103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003EE8 RID: 16104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EE9 RID: 16105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EEA RID: 16106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003EEB RID: 16107
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006FC RID: 1788
		[ObfuscatedName("worm.canis.actions.UpdateDeckListAndCounters+<undo>d__4")]
		public sealed class _undo_d__4 : Object
		{
			// Token: 0x06006113 RID: 24851 RVA: 0x001DB6A4 File Offset: 0x001D98A4
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__4()
			{
				Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateDeckListAndCounters>.NativeClassPtr, "<undo>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr);
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>1__state");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>2__current");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>l__initialThreadId");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>4__this");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr_undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "undoContext");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___3__undoContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>3__undoContext");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<player>5__2");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__undoNode_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<undoNode>5__3");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__card_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<card>5__4");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__wormMatch_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<wormMatch>5__5");
				UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, "<>7__wrap5");
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669087);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669088);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669089);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669090);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669091);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669092);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669093);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669094);
				UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr, 100669095);
			}

			// Token: 0x06006114 RID: 24852 RVA: 0x001DB860 File Offset: 0x001D9A60
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateDeckListAndCounters._undo_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006115 RID: 24853 RVA: 0x001DB8A8 File Offset: 0x001D9AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150390, XrefRangeEnd = 150395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006116 RID: 24854 RVA: 0x001DB8DC File Offset: 0x001D9ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150395, XrefRangeEnd = 150609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006117 RID: 24855 RVA: 0x001DB918 File Offset: 0x001D9B18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150609, XrefRangeEnd = 150612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019D5 RID: 6613
			// (get) Token: 0x06006118 RID: 24856 RVA: 0x001DB94C File Offset: 0x001D9B4C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006119 RID: 24857 RVA: 0x001DB98C File Offset: 0x001D9B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150612, XrefRangeEnd = 150617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170019D6 RID: 6614
			// (get) Token: 0x0600611A RID: 24858 RVA: 0x001DB9C0 File Offset: 0x001D9BC0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600611B RID: 24859 RVA: 0x001DBA00 File Offset: 0x001D9C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150617, XrefRangeEnd = 150626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600611C RID: 24860 RVA: 0x001DBA40 File Offset: 0x001D9C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateDeckListAndCounters._undo_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600611D RID: 24861 RVA: 0x00025361 File Offset: 0x00023561
			public _undo_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019CA RID: 6602
			// (get) Token: 0x0600611E RID: 24862 RVA: 0x001DBA80 File Offset: 0x001D9C80
			// (set) Token: 0x0600611F RID: 24863 RVA: 0x0002536A File Offset: 0x0002356A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170019CB RID: 6603
			// (get) Token: 0x06006120 RID: 24864 RVA: 0x001DBAA8 File Offset: 0x001D9CA8
			// (set) Token: 0x06006121 RID: 24865 RVA: 0x00025385 File Offset: 0x00023585
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CC RID: 6604
			// (get) Token: 0x06006122 RID: 24866 RVA: 0x001DBAD8 File Offset: 0x001D9CD8
			// (set) Token: 0x06006123 RID: 24867 RVA: 0x000253A4 File Offset: 0x000235A4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170019CD RID: 6605
			// (get) Token: 0x06006124 RID: 24868 RVA: 0x001DBB00 File Offset: 0x001D9D00
			// (set) Token: 0x06006125 RID: 24869 RVA: 0x000253BF File Offset: 0x000235BF
			public unsafe UpdateDeckListAndCounters __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDeckListAndCounters>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CE RID: 6606
			// (get) Token: 0x06006126 RID: 24870 RVA: 0x001DBB30 File Offset: 0x001D9D30
			// (set) Token: 0x06006127 RID: 24871 RVA: 0x000253DE File Offset: 0x000235DE
			public unsafe Context undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr_undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr_undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019CF RID: 6607
			// (get) Token: 0x06006128 RID: 24872 RVA: 0x001DBB60 File Offset: 0x001D9D60
			// (set) Token: 0x06006129 RID: 24873 RVA: 0x000253FD File Offset: 0x000235FD
			public unsafe Context __3__undoContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___3__undoContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___3__undoContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D0 RID: 6608
			// (get) Token: 0x0600612A RID: 24874 RVA: 0x001DBB90 File Offset: 0x001D9D90
			// (set) Token: 0x0600612B RID: 24875 RVA: 0x0002541C File Offset: 0x0002361C
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D1 RID: 6609
			// (get) Token: 0x0600612C RID: 24876 RVA: 0x001DBBC0 File Offset: 0x001D9DC0
			// (set) Token: 0x0600612D RID: 24877 RVA: 0x0002543B File Offset: 0x0002363B
			public unsafe UndoNode _undoNode_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__undoNode_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__undoNode_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D2 RID: 6610
			// (get) Token: 0x0600612E RID: 24878 RVA: 0x001DBBF0 File Offset: 0x001D9DF0
			// (set) Token: 0x0600612F RID: 24879 RVA: 0x0002545A File Offset: 0x0002365A
			public unsafe WormImperiumPlayable _card_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__card_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__card_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D3 RID: 6611
			// (get) Token: 0x06006130 RID: 24880 RVA: 0x001DBC20 File Offset: 0x001D9E20
			// (set) Token: 0x06006131 RID: 24881 RVA: 0x00025479 File Offset: 0x00023679
			public unsafe WormMatch _wormMatch_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__wormMatch_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr__wormMatch_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019D4 RID: 6612
			// (get) Token: 0x06006132 RID: 24882 RVA: 0x001DBC50 File Offset: 0x001D9E50
			// (set) Token: 0x06006133 RID: 24883 RVA: 0x00025498 File Offset: 0x00023698
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateDeckListAndCounters._undo_d__4.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EEC RID: 16108
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EED RID: 16109
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EEE RID: 16110
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003EEF RID: 16111
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EF0 RID: 16112
			private static readonly IntPtr NativeFieldInfoPtr_undoContext;

			// Token: 0x04003EF1 RID: 16113
			private static readonly IntPtr NativeFieldInfoPtr___3__undoContext;

			// Token: 0x04003EF2 RID: 16114
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04003EF3 RID: 16115
			private static readonly IntPtr NativeFieldInfoPtr__undoNode_5__3;

			// Token: 0x04003EF4 RID: 16116
			private static readonly IntPtr NativeFieldInfoPtr__card_5__4;

			// Token: 0x04003EF5 RID: 16117
			private static readonly IntPtr NativeFieldInfoPtr__wormMatch_5__5;

			// Token: 0x04003EF6 RID: 16118
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x04003EF7 RID: 16119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EF8 RID: 16120
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EF9 RID: 16121
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EFA RID: 16122
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003EFB RID: 16123
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003EFC RID: 16124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EFD RID: 16125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EFE RID: 16126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003EFF RID: 16127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
