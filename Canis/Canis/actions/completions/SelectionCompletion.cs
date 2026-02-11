using System;
using Canis.actions.continuations;
using Canis.data;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.completions
{
	// Token: 0x02000234 RID: 564
	public class SelectionCompletion : Object
	{
		// Token: 0x0600176F RID: 5999 RVA: 0x00077518 File Offset: 0x00075718
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionCompletion()
		{
			Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.completions", "SelectionCompletion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr);
			SelectionCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668678);
			SelectionCompletion.NativeMethodInfoPtr_ResumeActiveSequences_Protected_IEnumerable_1_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668679);
			SelectionCompletion.NativeMethodInfoPtr_ClearSelection_Protected_IEnumerable_1_Action_Match_PlayerEntity_PlayerEntity_Boolean_Func_2_PendingSelection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668680);
			SelectionCompletion.NativeMethodInfoPtr_KeepLatestSelection_Protected_Virtual_New_Boolean_PendingSelection_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668681);
			SelectionCompletion.NativeMethodInfoPtr_CleanupSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668682);
			SelectionCompletion.NativeMethodInfoPtr_SendPassAndPlayFollowup_Protected_IEnumerable_1_Action_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668683);
			SelectionCompletion.NativeMethodInfoPtr_SendFollowUpSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668684);
			SelectionCompletion.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, 100668685);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000775E8 File Offset: 0x000757E8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Action> CompleteSelection(Match match, PlayerEntity selectingPlayer, PendingSelection selection, List<ActionAcrossTargets> ranActions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranActions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionCompletion.NativeMethodInfoPtr_CompleteSelection_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0007767C File Offset: 0x0007587C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 596263, RefRangeEnd = 596266, XrefRangeStart = 596257, XrefRangeEnd = 596263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> ResumeActiveSequences(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr_ResumeActiveSequences_Protected_IEnumerable_1_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000776CC File Offset: 0x000758CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 596275, RefRangeEnd = 596279, XrefRangeStart = 596266, XrefRangeEnd = 596275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> ClearSelection(Match match, PlayerEntity selectingPlayer, PlayerEntity clearPlayer, bool completed, Func<PendingSelection, bool> keepPredicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clearPlayer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keepPredicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr_ClearSelection_Protected_IEnumerable_1_Action_Match_PlayerEntity_PlayerEntity_Boolean_Func_2_PendingSelection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00077764 File Offset: 0x00075964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596279, XrefRangeEnd = 596307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool KeepLatestSelection(PendingSelection pendingSelection, PendingSelection latestSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pendingSelection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(latestSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionCompletion.NativeMethodInfoPtr_KeepLatestSelection_Protected_Virtual_New_Boolean_PendingSelection_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000777D0 File Offset: 0x000759D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 596315, RefRangeEnd = 596318, XrefRangeStart = 596307, XrefRangeEnd = 596315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> CleanupSelections(Match match, PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr_CleanupSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00077834 File Offset: 0x00075A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596318, XrefRangeEnd = 596325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> SendPassAndPlayFollowup(Match match, PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr_SendPassAndPlayFollowup_Protected_IEnumerable_1_Action_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00077898 File Offset: 0x00075A98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 596333, RefRangeEnd = 596336, XrefRangeStart = 596325, XrefRangeEnd = 596333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> SendFollowUpSelections(Match match, PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr_SendFollowUpSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000778FC File Offset: 0x00075AFC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionCompletion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0000B30C File Offset: 0x0000950C
		public SelectionCompletion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSelection_Public_Abstract_Virtual_New_IEnumerable_1_Action_Match_PlayerEntity_PendingSelection_List_1_ActionAcrossTargets_0;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_ResumeActiveSequences_Protected_IEnumerable_1_Action_Match_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Protected_IEnumerable_1_Action_Match_PlayerEntity_PlayerEntity_Boolean_Func_2_PendingSelection_Boolean_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_KeepLatestSelection_Protected_Virtual_New_Boolean_PendingSelection_PendingSelection_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_CleanupSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_SendPassAndPlayFollowup_Protected_IEnumerable_1_Action_Match_PlayerEntity_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_SendFollowUpSelections_Protected_IEnumerable_1_Action_Match_PlayerEntity_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000481 RID: 1153
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003401 RID: 13313 RVA: 0x000D3FEC File Offset: 0x000D21EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr);
				SelectionCompletion.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, "<>9");
				SelectionCompletion.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, "<>9__4_0");
				SelectionCompletion.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, "<>9__4_1");
				SelectionCompletion.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, "<>9__5_0");
				SelectionCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, 100668687);
				SelectionCompletion.__c.NativeMethodInfoPtr__CleanupSelections_b__4_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, 100668688);
				SelectionCompletion.__c.NativeMethodInfoPtr__CleanupSelections_b__4_1_Internal_Double_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, 100668689);
				SelectionCompletion.__c.NativeMethodInfoPtr__SendPassAndPlayFollowup_b__5_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr, 100668690);
			}

			// Token: 0x06003402 RID: 13314 RVA: 0x000D40B8 File Offset: 0x000D22B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003403 RID: 13315 RVA: 0x000D40F4 File Offset: 0x000D22F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PendingSelection> _CleanupSelections_b__4_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c.NativeMethodInfoPtr__CleanupSelections_b__4_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PendingSelection>>(intPtr3) : null;
				}
			}

			// Token: 0x06003404 RID: 13316 RVA: 0x000D4144 File Offset: 0x000D2344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595804, XrefRangeEnd = 595805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _CleanupSelections_b__4_1(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c.NativeMethodInfoPtr__CleanupSelections_b__4_1_Internal_Double_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x000D4194 File Offset: 0x000D2394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595805, XrefRangeEnd = 595809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendPassAndPlayFollowup_b__5_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c.NativeMethodInfoPtr__SendPassAndPlayFollowup_b__5_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003406 RID: 13318 RVA: 0x00019080 File Offset: 0x00017280
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x06003407 RID: 13319 RVA: 0x000D41E4 File Offset: 0x000D23E4
			// (set) Token: 0x06003408 RID: 13320 RVA: 0x00019089 File Offset: 0x00017289
			public unsafe static SelectionCompletion.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionCompletion.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionCompletion.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x06003409 RID: 13321 RVA: 0x000D420C File Offset: 0x000D240C
			// (set) Token: 0x0600340A RID: 13322 RVA: 0x0001909B File Offset: 0x0001729B
			public unsafe static Func<PlayerEntity, IEnumerable<PendingSelection>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, IEnumerable<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x0600340B RID: 13323 RVA: 0x000D4234 File Offset: 0x000D2434
			// (set) Token: 0x0600340C RID: 13324 RVA: 0x000190AD File Offset: 0x000172AD
			public unsafe static Func<PendingSelection, double> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x0600340D RID: 13325 RVA: 0x000D425C File Offset: 0x000D245C
			// (set) Token: 0x0600340E RID: 13326 RVA: 0x000190BF File Offset: 0x000172BF
			public unsafe static Func<PlayerEntity, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionCompletion.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002078 RID: 8312
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002079 RID: 8313
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400207A RID: 8314
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x0400207B RID: 8315
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400207C RID: 8316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400207D RID: 8317
			private static readonly IntPtr NativeMethodInfoPtr__CleanupSelections_b__4_0_Internal_IEnumerable_1_PendingSelection_PlayerEntity_0;

			// Token: 0x0400207E RID: 8318
			private static readonly IntPtr NativeMethodInfoPtr__CleanupSelections_b__4_1_Internal_Double_PendingSelection_0;

			// Token: 0x0400207F RID: 8319
			private static readonly IntPtr NativeMethodInfoPtr__SendPassAndPlayFollowup_b__5_0_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x02000482 RID: 1154
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600340F RID: 13327 RVA: 0x000D4284 File Offset: 0x000D2484
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr);
				SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr_latestSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr, "latestSelection");
				SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr, "<>9__2");
				SelectionCompletion.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr, 100668691);
				SelectionCompletion.__c__DisplayClass4_0.NativeMethodInfoPtr__CleanupSelections_b__2_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr, 100668692);
			}

			// Token: 0x06003410 RID: 13328 RVA: 0x000D4314 File Offset: 0x000D2514
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003411 RID: 13329 RVA: 0x000D4350 File Offset: 0x000D2550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595809, XrefRangeEnd = 595810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CleanupSelections_b__2(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion.__c__DisplayClass4_0.NativeMethodInfoPtr__CleanupSelections_b__2_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x000190D1 File Offset: 0x000172D1
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06003413 RID: 13331 RVA: 0x000D43A0 File Offset: 0x000D25A0
			// (set) Token: 0x06003414 RID: 13332 RVA: 0x000190DA File Offset: 0x000172DA
			public unsafe SelectionCompletion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06003415 RID: 13333 RVA: 0x000D43D0 File Offset: 0x000D25D0
			// (set) Token: 0x06003416 RID: 13334 RVA: 0x000190F9 File Offset: 0x000172F9
			public unsafe PendingSelection latestSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr_latestSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr_latestSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06003417 RID: 13335 RVA: 0x000D4400 File Offset: 0x000D2600
			// (set) Token: 0x06003418 RID: 13336 RVA: 0x00019118 File Offset: 0x00017318
			public unsafe Func<PendingSelection, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002080 RID: 8320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002081 RID: 8321
			private static readonly IntPtr NativeFieldInfoPtr_latestSelection;

			// Token: 0x04002082 RID: 8322
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04002083 RID: 8323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002084 RID: 8324
			private static readonly IntPtr NativeMethodInfoPtr__CleanupSelections_b__2_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x02000483 RID: 1155
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<CleanupSelections>d__4")]
		public sealed class _CleanupSelections_d__4 : Object
		{
			// Token: 0x06003419 RID: 13337 RVA: 0x000D4430 File Offset: 0x000D2630
			// Note: this type is marked as 'beforefieldinit'.
			static _CleanupSelections_d__4()
			{
				Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<CleanupSelections>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr);
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>1__state");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>2__current");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>l__initialThreadId");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>4__this");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "match");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>3__match");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "selectingPlayer");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>3__selectingPlayer");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>8__1");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>7__wrap1");
				SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, "<>7__wrap2");
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668693);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668694);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668695);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668696);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668697);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668698);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668699);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668700);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668701);
				SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr, 100668702);
			}

			// Token: 0x0600341A RID: 13338 RVA: 0x000D4600 File Offset: 0x000D2800
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CleanupSelections_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion._CleanupSelections_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600341B RID: 13339 RVA: 0x000D4648 File Offset: 0x000D2848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595810, XrefRangeEnd = 595820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600341C RID: 13340 RVA: 0x000D467C File Offset: 0x000D287C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595820, XrefRangeEnd = 595913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600341D RID: 13341 RVA: 0x000D46B8 File Offset: 0x000D28B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595913, XrefRangeEnd = 595916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600341E RID: 13342 RVA: 0x000D46EC File Offset: 0x000D28EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595916, XrefRangeEnd = 595919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DEF RID: 3567
			// (get) Token: 0x0600341F RID: 13343 RVA: 0x000D4720 File Offset: 0x000D2920
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003420 RID: 13344 RVA: 0x000D4760 File Offset: 0x000D2960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595919, XrefRangeEnd = 595924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DF0 RID: 3568
			// (get) Token: 0x06003421 RID: 13345 RVA: 0x000D4794 File Offset: 0x000D2994
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003422 RID: 13346 RVA: 0x000D47D4 File Offset: 0x000D29D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595924, XrefRangeEnd = 595934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003423 RID: 13347 RVA: 0x000D4814 File Offset: 0x000D2A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._CleanupSelections_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x00019137 File Offset: 0x00017337
			public _CleanupSelections_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x06003425 RID: 13349 RVA: 0x000D4854 File Offset: 0x000D2A54
			// (set) Token: 0x06003426 RID: 13350 RVA: 0x00019140 File Offset: 0x00017340
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x06003427 RID: 13351 RVA: 0x000D487C File Offset: 0x000D2A7C
			// (set) Token: 0x06003428 RID: 13352 RVA: 0x0001915B File Offset: 0x0001735B
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x06003429 RID: 13353 RVA: 0x000D48AC File Offset: 0x000D2AAC
			// (set) Token: 0x0600342A RID: 13354 RVA: 0x0001917A File Offset: 0x0001737A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x0600342B RID: 13355 RVA: 0x000D48D4 File Offset: 0x000D2AD4
			// (set) Token: 0x0600342C RID: 13356 RVA: 0x00019195 File Offset: 0x00017395
			public unsafe SelectionCompletion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE8 RID: 3560
			// (get) Token: 0x0600342D RID: 13357 RVA: 0x000D4904 File Offset: 0x000D2B04
			// (set) Token: 0x0600342E RID: 13358 RVA: 0x000191B4 File Offset: 0x000173B4
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DE9 RID: 3561
			// (get) Token: 0x0600342F RID: 13359 RVA: 0x000D4934 File Offset: 0x000D2B34
			// (set) Token: 0x06003430 RID: 13360 RVA: 0x000191D3 File Offset: 0x000173D3
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEA RID: 3562
			// (get) Token: 0x06003431 RID: 13361 RVA: 0x000D4964 File Offset: 0x000D2B64
			// (set) Token: 0x06003432 RID: 13362 RVA: 0x000191F2 File Offset: 0x000173F2
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEB RID: 3563
			// (get) Token: 0x06003433 RID: 13363 RVA: 0x000D4994 File Offset: 0x000D2B94
			// (set) Token: 0x06003434 RID: 13364 RVA: 0x00019211 File Offset: 0x00017411
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEC RID: 3564
			// (get) Token: 0x06003435 RID: 13365 RVA: 0x000D49C4 File Offset: 0x000D2BC4
			// (set) Token: 0x06003436 RID: 13366 RVA: 0x00019230 File Offset: 0x00017430
			public unsafe SelectionCompletion.__c__DisplayClass4_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DED RID: 3565
			// (get) Token: 0x06003437 RID: 13367 RVA: 0x000D49F4 File Offset: 0x000D2BF4
			// (set) Token: 0x06003438 RID: 13368 RVA: 0x0001924F File Offset: 0x0001744F
			public unsafe IEnumerator<PlayerEntity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DEE RID: 3566
			// (get) Token: 0x06003439 RID: 13369 RVA: 0x000D4A24 File Offset: 0x000D2C24
			// (set) Token: 0x0600343A RID: 13370 RVA: 0x0001926E File Offset: 0x0001746E
			public unsafe IEnumerator<Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._CleanupSelections_d__4.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002085 RID: 8325
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002086 RID: 8326
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002087 RID: 8327
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002088 RID: 8328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002089 RID: 8329
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400208A RID: 8330
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400208B RID: 8331
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x0400208C RID: 8332
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x0400208D RID: 8333
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400208E RID: 8334
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400208F RID: 8335
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04002090 RID: 8336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002091 RID: 8337
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002092 RID: 8338
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002093 RID: 8339
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002094 RID: 8340
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002095 RID: 8341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002096 RID: 8342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002097 RID: 8343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002098 RID: 8344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002099 RID: 8345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000484 RID: 1156
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<ClearSelection>d__2")]
		public sealed class _ClearSelection_d__2 : Object
		{
			// Token: 0x0600343B RID: 13371 RVA: 0x000D4A54 File Offset: 0x000D2C54
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearSelection_d__2()
			{
				Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<ClearSelection>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr);
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>1__state");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>2__current");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>l__initialThreadId");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_clearPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "clearPlayer");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__clearPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>3__clearPlayer");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_keepPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "keepPredicate");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__keepPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>3__keepPredicate");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "completed");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>3__completed");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "selectingPlayer");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>3__selectingPlayer");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "match");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>3__match");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__keptPendingSelections_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<keptPendingSelections>5__2");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__clearedPendingSelections_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<clearedPendingSelections>5__3");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__completedSelection_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<completedSelection>5__4");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>7__wrap4");
				SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, "<>7__wrap5");
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668703);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668704);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668705);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668706);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668707);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668708);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668709);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668710);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668711);
				SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr, 100668712);
			}

			// Token: 0x0600343C RID: 13372 RVA: 0x000D4CB0 File Offset: 0x000D2EB0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearSelection_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion._ClearSelection_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x000D4CF8 File Offset: 0x000D2EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595934, XrefRangeEnd = 595942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600343E RID: 13374 RVA: 0x000D4D2C File Offset: 0x000D2F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 595942, XrefRangeEnd = 596037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600343F RID: 13375 RVA: 0x000D4D68 File Offset: 0x000D2F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596037, XrefRangeEnd = 596040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003440 RID: 13376 RVA: 0x000D4D9C File Offset: 0x000D2F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596040, XrefRangeEnd = 596043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x06003441 RID: 13377 RVA: 0x000D4DD0 File Offset: 0x000D2FD0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003442 RID: 13378 RVA: 0x000D4E10 File Offset: 0x000D3010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596043, XrefRangeEnd = 596048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x06003443 RID: 13379 RVA: 0x000D4E44 File Offset: 0x000D3044
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003444 RID: 13380 RVA: 0x000D4E84 File Offset: 0x000D3084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596048, XrefRangeEnd = 596059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003445 RID: 13381 RVA: 0x000D4EC4 File Offset: 0x000D30C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ClearSelection_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003446 RID: 13382 RVA: 0x0001928D File Offset: 0x0001748D
			public _ClearSelection_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DF1 RID: 3569
			// (get) Token: 0x06003447 RID: 13383 RVA: 0x000D4F04 File Offset: 0x000D3104
			// (set) Token: 0x06003448 RID: 13384 RVA: 0x00019296 File Offset: 0x00017496
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000DF2 RID: 3570
			// (get) Token: 0x06003449 RID: 13385 RVA: 0x000D4F2C File Offset: 0x000D312C
			// (set) Token: 0x0600344A RID: 13386 RVA: 0x000192B1 File Offset: 0x000174B1
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x0600344B RID: 13387 RVA: 0x000D4F5C File Offset: 0x000D315C
			// (set) Token: 0x0600344C RID: 13388 RVA: 0x000192D0 File Offset: 0x000174D0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000DF4 RID: 3572
			// (get) Token: 0x0600344D RID: 13389 RVA: 0x000D4F84 File Offset: 0x000D3184
			// (set) Token: 0x0600344E RID: 13390 RVA: 0x000192EB File Offset: 0x000174EB
			public unsafe PlayerEntity clearPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_clearPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_clearPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF5 RID: 3573
			// (get) Token: 0x0600344F RID: 13391 RVA: 0x000D4FB4 File Offset: 0x000D31B4
			// (set) Token: 0x06003450 RID: 13392 RVA: 0x0001930A File Offset: 0x0001750A
			public unsafe PlayerEntity __3__clearPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__clearPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__clearPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF6 RID: 3574
			// (get) Token: 0x06003451 RID: 13393 RVA: 0x000D4FE4 File Offset: 0x000D31E4
			// (set) Token: 0x06003452 RID: 13394 RVA: 0x00019329 File Offset: 0x00017529
			public unsafe Func<PendingSelection, bool> keepPredicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_keepPredicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_keepPredicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF7 RID: 3575
			// (get) Token: 0x06003453 RID: 13395 RVA: 0x000D5014 File Offset: 0x000D3214
			// (set) Token: 0x06003454 RID: 13396 RVA: 0x00019348 File Offset: 0x00017548
			public unsafe Func<PendingSelection, bool> __3__keepPredicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__keepPredicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__keepPredicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DF8 RID: 3576
			// (get) Token: 0x06003455 RID: 13397 RVA: 0x000D5044 File Offset: 0x000D3244
			// (set) Token: 0x06003456 RID: 13398 RVA: 0x00019367 File Offset: 0x00017567
			public unsafe bool completed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_completed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_completed)) = value;
				}
			}

			// Token: 0x17000DF9 RID: 3577
			// (get) Token: 0x06003457 RID: 13399 RVA: 0x000D506C File Offset: 0x000D326C
			// (set) Token: 0x06003458 RID: 13400 RVA: 0x00019382 File Offset: 0x00017582
			public unsafe bool __3__completed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__completed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__completed)) = value;
				}
			}

			// Token: 0x17000DFA RID: 3578
			// (get) Token: 0x06003459 RID: 13401 RVA: 0x000D5094 File Offset: 0x000D3294
			// (set) Token: 0x0600345A RID: 13402 RVA: 0x0001939D File Offset: 0x0001759D
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFB RID: 3579
			// (get) Token: 0x0600345B RID: 13403 RVA: 0x000D50C4 File Offset: 0x000D32C4
			// (set) Token: 0x0600345C RID: 13404 RVA: 0x000193BC File Offset: 0x000175BC
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x0600345D RID: 13405 RVA: 0x000D50F4 File Offset: 0x000D32F4
			// (set) Token: 0x0600345E RID: 13406 RVA: 0x000193DB File Offset: 0x000175DB
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x0600345F RID: 13407 RVA: 0x000D5124 File Offset: 0x000D3324
			// (set) Token: 0x06003460 RID: 13408 RVA: 0x000193FA File Offset: 0x000175FA
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFE RID: 3582
			// (get) Token: 0x06003461 RID: 13409 RVA: 0x000D5154 File Offset: 0x000D3354
			// (set) Token: 0x06003462 RID: 13410 RVA: 0x00019419 File Offset: 0x00017619
			public unsafe List<PendingSelection> _keptPendingSelections_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__keptPendingSelections_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PendingSelection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__keptPendingSelections_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x06003463 RID: 13411 RVA: 0x000D5184 File Offset: 0x000D3384
			// (set) Token: 0x06003464 RID: 13412 RVA: 0x00019438 File Offset: 0x00017638
			public unsafe List<PendingSelection> _clearedPendingSelections_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__clearedPendingSelections_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PendingSelection>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__clearedPendingSelections_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x06003465 RID: 13413 RVA: 0x000D51B4 File Offset: 0x000D33B4
			// (set) Token: 0x06003466 RID: 13414 RVA: 0x00019457 File Offset: 0x00017657
			public unsafe bool _completedSelection_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__completedSelection_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr__completedSelection_5__4)) = value;
				}
			}

			// Token: 0x17000E01 RID: 3585
			// (get) Token: 0x06003467 RID: 13415 RVA: 0x000D51DC File Offset: 0x000D33DC
			// (set) Token: 0x06003468 RID: 13416 RVA: 0x00019472 File Offset: 0x00017672
			public unsafe IEnumerator<Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E02 RID: 3586
			// (get) Token: 0x06003469 RID: 13417 RVA: 0x000D520C File Offset: 0x000D340C
			// (set) Token: 0x0600346A RID: 13418 RVA: 0x00019491 File Offset: 0x00017691
			public List<PendingSelection>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap5);
					return new List<PendingSelection>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<PendingSelection>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ClearSelection_d__2.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<PendingSelection>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400209A RID: 8346
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400209B RID: 8347
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400209C RID: 8348
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400209D RID: 8349
			private static readonly IntPtr NativeFieldInfoPtr_clearPlayer;

			// Token: 0x0400209E RID: 8350
			private static readonly IntPtr NativeFieldInfoPtr___3__clearPlayer;

			// Token: 0x0400209F RID: 8351
			private static readonly IntPtr NativeFieldInfoPtr_keepPredicate;

			// Token: 0x040020A0 RID: 8352
			private static readonly IntPtr NativeFieldInfoPtr___3__keepPredicate;

			// Token: 0x040020A1 RID: 8353
			private static readonly IntPtr NativeFieldInfoPtr_completed;

			// Token: 0x040020A2 RID: 8354
			private static readonly IntPtr NativeFieldInfoPtr___3__completed;

			// Token: 0x040020A3 RID: 8355
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x040020A4 RID: 8356
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x040020A5 RID: 8357
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040020A6 RID: 8358
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040020A7 RID: 8359
			private static readonly IntPtr NativeFieldInfoPtr__keptPendingSelections_5__2;

			// Token: 0x040020A8 RID: 8360
			private static readonly IntPtr NativeFieldInfoPtr__clearedPendingSelections_5__3;

			// Token: 0x040020A9 RID: 8361
			private static readonly IntPtr NativeFieldInfoPtr__completedSelection_5__4;

			// Token: 0x040020AA RID: 8362
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040020AB RID: 8363
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040020AC RID: 8364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020AD RID: 8365
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020AE RID: 8366
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020AF RID: 8367
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040020B0 RID: 8368
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040020B1 RID: 8369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040020B2 RID: 8370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020B3 RID: 8371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020B4 RID: 8372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040020B5 RID: 8373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000485 RID: 1157
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<ResumeActiveSequences>d__1")]
		public sealed class _ResumeActiveSequences_d__1 : Object
		{
			// Token: 0x0600346B RID: 13419 RVA: 0x000D523C File Offset: 0x000D343C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResumeActiveSequences_d__1()
			{
				Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<ResumeActiveSequences>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "<>1__state");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "<>2__current");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "<>l__initialThreadId");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "match");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "<>3__match");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, "<>7__wrap1");
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668713);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668714);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668715);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668716);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668717);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668718);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668719);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668720);
				SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr, 100668721);
			}

			// Token: 0x0600346C RID: 13420 RVA: 0x000D5394 File Offset: 0x000D3594
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResumeActiveSequences_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion._ResumeActiveSequences_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600346D RID: 13421 RVA: 0x000D53DC File Offset: 0x000D35DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596059, XrefRangeEnd = 596064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600346E RID: 13422 RVA: 0x000D5410 File Offset: 0x000D3610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596064, XrefRangeEnd = 596090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600346F RID: 13423 RVA: 0x000D544C File Offset: 0x000D364C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596090, XrefRangeEnd = 596093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x06003470 RID: 13424 RVA: 0x000D5480 File Offset: 0x000D3680
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003471 RID: 13425 RVA: 0x000D54C0 File Offset: 0x000D36C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596093, XrefRangeEnd = 596098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x06003472 RID: 13426 RVA: 0x000D54F4 File Offset: 0x000D36F4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003473 RID: 13427 RVA: 0x000D5534 File Offset: 0x000D3734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596098, XrefRangeEnd = 596106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06003474 RID: 13428 RVA: 0x000D5574 File Offset: 0x000D3774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._ResumeActiveSequences_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06003475 RID: 13429 RVA: 0x000194BF File Offset: 0x000176BF
			public _ResumeActiveSequences_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x06003476 RID: 13430 RVA: 0x000D55B4 File Offset: 0x000D37B4
			// (set) Token: 0x06003477 RID: 13431 RVA: 0x000194C8 File Offset: 0x000176C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x06003478 RID: 13432 RVA: 0x000D55DC File Offset: 0x000D37DC
			// (set) Token: 0x06003479 RID: 13433 RVA: 0x000194E3 File Offset: 0x000176E3
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x0600347A RID: 13434 RVA: 0x000D560C File Offset: 0x000D380C
			// (set) Token: 0x0600347B RID: 13435 RVA: 0x00019502 File Offset: 0x00017702
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x0600347C RID: 13436 RVA: 0x000D5634 File Offset: 0x000D3834
			// (set) Token: 0x0600347D RID: 13437 RVA: 0x0001951D File Offset: 0x0001771D
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x0600347E RID: 13438 RVA: 0x000D5664 File Offset: 0x000D3864
			// (set) Token: 0x0600347F RID: 13439 RVA: 0x0001953C File Offset: 0x0001773C
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x06003480 RID: 13440 RVA: 0x000D5694 File Offset: 0x000D3894
			// (set) Token: 0x06003481 RID: 13441 RVA: 0x0001955B File Offset: 0x0001775B
			public unsafe IEnumerator<DBGSequence> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<DBGSequence>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._ResumeActiveSequences_d__1.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020B6 RID: 8374
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020B7 RID: 8375
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020B8 RID: 8376
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040020B9 RID: 8377
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040020BA RID: 8378
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040020BB RID: 8379
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040020BC RID: 8380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020BD RID: 8381
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020BE RID: 8382
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020BF RID: 8383
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040020C0 RID: 8384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040020C1 RID: 8385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020C2 RID: 8386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020C3 RID: 8387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040020C4 RID: 8388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000486 RID: 1158
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<SendFollowUpSelections>d__6")]
		public sealed class _SendFollowUpSelections_d__6 : Object
		{
			// Token: 0x06003482 RID: 13442 RVA: 0x000D56C4 File Offset: 0x000D38C4
			// Note: this type is marked as 'beforefieldinit'.
			static _SendFollowUpSelections_d__6()
			{
				Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<SendFollowUpSelections>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>1__state");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>2__current");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>l__initialThreadId");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "match");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>3__match");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>4__this");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "selectingPlayer");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, "<>3__selectingPlayer");
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668722);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668723);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668724);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668725);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668726);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668727);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668728);
				SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr, 100668729);
			}

			// Token: 0x06003483 RID: 13443 RVA: 0x000D5830 File Offset: 0x000D3A30
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendFollowUpSelections_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion._SendFollowUpSelections_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003484 RID: 13444 RVA: 0x000D5878 File Offset: 0x000D3A78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003485 RID: 13445 RVA: 0x000D58AC File Offset: 0x000D3AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596106, XrefRangeEnd = 596122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x06003486 RID: 13446 RVA: 0x000D58E8 File Offset: 0x000D3AE8
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06003487 RID: 13447 RVA: 0x000D5928 File Offset: 0x000D3B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596122, XrefRangeEnd = 596127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06003488 RID: 13448 RVA: 0x000D595C File Offset: 0x000D3B5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003489 RID: 13449 RVA: 0x000D599C File Offset: 0x000D3B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596127, XrefRangeEnd = 596137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x0600348A RID: 13450 RVA: 0x000D59DC File Offset: 0x000D3BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendFollowUpSelections_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600348B RID: 13451 RVA: 0x0001957A File Offset: 0x0001777A
			public _SendFollowUpSelections_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x0600348C RID: 13452 RVA: 0x000D5A1C File Offset: 0x000D3C1C
			// (set) Token: 0x0600348D RID: 13453 RVA: 0x00019583 File Offset: 0x00017783
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x0600348E RID: 13454 RVA: 0x000D5A44 File Offset: 0x000D3C44
			// (set) Token: 0x0600348F RID: 13455 RVA: 0x0001959E File Offset: 0x0001779E
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x06003490 RID: 13456 RVA: 0x000D5A74 File Offset: 0x000D3C74
			// (set) Token: 0x06003491 RID: 13457 RVA: 0x000195BD File Offset: 0x000177BD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x06003492 RID: 13458 RVA: 0x000D5A9C File Offset: 0x000D3C9C
			// (set) Token: 0x06003493 RID: 13459 RVA: 0x000195D8 File Offset: 0x000177D8
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E11 RID: 3601
			// (get) Token: 0x06003494 RID: 13460 RVA: 0x000D5ACC File Offset: 0x000D3CCC
			// (set) Token: 0x06003495 RID: 13461 RVA: 0x000195F7 File Offset: 0x000177F7
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x06003496 RID: 13462 RVA: 0x000D5AFC File Offset: 0x000D3CFC
			// (set) Token: 0x06003497 RID: 13463 RVA: 0x00019616 File Offset: 0x00017816
			public unsafe SelectionCompletion __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x06003498 RID: 13464 RVA: 0x000D5B2C File Offset: 0x000D3D2C
			// (set) Token: 0x06003499 RID: 13465 RVA: 0x00019635 File Offset: 0x00017835
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x0600349A RID: 13466 RVA: 0x000D5B5C File Offset: 0x000D3D5C
			// (set) Token: 0x0600349B RID: 13467 RVA: 0x00019654 File Offset: 0x00017854
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendFollowUpSelections_d__6.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020C5 RID: 8389
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020C6 RID: 8390
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020C7 RID: 8391
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040020C8 RID: 8392
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040020C9 RID: 8393
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040020CA RID: 8394
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020CB RID: 8395
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x040020CC RID: 8396
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x040020CD RID: 8397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020CE RID: 8398
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020CF RID: 8399
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020D0 RID: 8400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040020D1 RID: 8401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020D2 RID: 8402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020D3 RID: 8403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040020D4 RID: 8404
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000487 RID: 1159
		[ObfuscatedName("Canis.actions.completions.SelectionCompletion+<SendPassAndPlayFollowup>d__5")]
		public sealed class _SendPassAndPlayFollowup_d__5 : Object
		{
			// Token: 0x0600349C RID: 13468 RVA: 0x000D5B8C File Offset: 0x000D3D8C
			// Note: this type is marked as 'beforefieldinit'.
			static _SendPassAndPlayFollowup_d__5()
			{
				Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionCompletion>.NativeClassPtr, "<SendPassAndPlayFollowup>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<>1__state");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<>2__current");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<>l__initialThreadId");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "match");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<>3__match");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "selectingPlayer");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<>3__selectingPlayer");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextCurrentSelection_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<nextCurrentSelection>5__2");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelectingPlayer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<nextSelectingPlayer>5__3");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelection_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, "<nextSelection>5__4");
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668730);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668731);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668732);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668733);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668734);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668735);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668736);
				SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr, 100668737);
			}

			// Token: 0x0600349D RID: 13469 RVA: 0x000D5D20 File Offset: 0x000D3F20
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendPassAndPlayFollowup_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionCompletion._SendPassAndPlayFollowup_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600349E RID: 13470 RVA: 0x000D5D68 File Offset: 0x000D3F68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600349F RID: 13471 RVA: 0x000D5D9C File Offset: 0x000D3F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596137, XrefRangeEnd = 596243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E21 RID: 3617
			// (get) Token: 0x060034A0 RID: 13472 RVA: 0x000D5DD8 File Offset: 0x000D3FD8
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060034A1 RID: 13473 RVA: 0x000D5E18 File Offset: 0x000D4018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596243, XrefRangeEnd = 596248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E22 RID: 3618
			// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000D5E4C File Offset: 0x000D404C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034A3 RID: 13475 RVA: 0x000D5E8C File Offset: 0x000D408C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596248, XrefRangeEnd = 596257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060034A4 RID: 13476 RVA: 0x000D5ECC File Offset: 0x000D40CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060034A5 RID: 13477 RVA: 0x00019673 File Offset: 0x00017873
			public _SendPassAndPlayFollowup_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x060034A6 RID: 13478 RVA: 0x000D5F0C File Offset: 0x000D410C
			// (set) Token: 0x060034A7 RID: 13479 RVA: 0x0001967C File Offset: 0x0001787C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x060034A8 RID: 13480 RVA: 0x000D5F34 File Offset: 0x000D4134
			// (set) Token: 0x060034A9 RID: 13481 RVA: 0x00019697 File Offset: 0x00017897
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E19 RID: 3609
			// (get) Token: 0x060034AA RID: 13482 RVA: 0x000D5F64 File Offset: 0x000D4164
			// (set) Token: 0x060034AB RID: 13483 RVA: 0x000196B6 File Offset: 0x000178B6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000E1A RID: 3610
			// (get) Token: 0x060034AC RID: 13484 RVA: 0x000D5F8C File Offset: 0x000D418C
			// (set) Token: 0x060034AD RID: 13485 RVA: 0x000196D1 File Offset: 0x000178D1
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E1B RID: 3611
			// (get) Token: 0x060034AE RID: 13486 RVA: 0x000D5FBC File Offset: 0x000D41BC
			// (set) Token: 0x060034AF RID: 13487 RVA: 0x000196F0 File Offset: 0x000178F0
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E1C RID: 3612
			// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000D5FEC File Offset: 0x000D41EC
			// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0001970F File Offset: 0x0001790F
			public unsafe PlayerEntity selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E1D RID: 3613
			// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000D601C File Offset: 0x000D421C
			// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0001972E File Offset: 0x0001792E
			public unsafe PlayerEntity __3__selectingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__selectingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr___3__selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E1E RID: 3614
			// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000D604C File Offset: 0x000D424C
			// (set) Token: 0x060034B5 RID: 13493 RVA: 0x0001974D File Offset: 0x0001794D
			public unsafe PendingSelection _nextCurrentSelection_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextCurrentSelection_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextCurrentSelection_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E1F RID: 3615
			// (get) Token: 0x060034B6 RID: 13494 RVA: 0x000D607C File Offset: 0x000D427C
			// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0001976C File Offset: 0x0001796C
			public unsafe PlayerEntity _nextSelectingPlayer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelectingPlayer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelectingPlayer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E20 RID: 3616
			// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000D60AC File Offset: 0x000D42AC
			// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0001978B File Offset: 0x0001798B
			public unsafe PendingSelection _nextSelection_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelection_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PendingSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionCompletion._SendPassAndPlayFollowup_d__5.NativeFieldInfoPtr__nextSelection_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020D5 RID: 8405
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020D6 RID: 8406
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020D7 RID: 8407
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040020D8 RID: 8408
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040020D9 RID: 8409
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040020DA RID: 8410
			private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

			// Token: 0x040020DB RID: 8411
			private static readonly IntPtr NativeFieldInfoPtr___3__selectingPlayer;

			// Token: 0x040020DC RID: 8412
			private static readonly IntPtr NativeFieldInfoPtr__nextCurrentSelection_5__2;

			// Token: 0x040020DD RID: 8413
			private static readonly IntPtr NativeFieldInfoPtr__nextSelectingPlayer_5__3;

			// Token: 0x040020DE RID: 8414
			private static readonly IntPtr NativeFieldInfoPtr__nextSelection_5__4;

			// Token: 0x040020DF RID: 8415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020E0 RID: 8416
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E1 RID: 8417
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020E2 RID: 8418
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040020E3 RID: 8419
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E4 RID: 8420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020E5 RID: 8421
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040020E6 RID: 8422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
