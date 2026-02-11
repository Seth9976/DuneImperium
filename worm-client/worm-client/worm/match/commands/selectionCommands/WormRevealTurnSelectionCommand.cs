using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.eventTriggers;
using dwd.core.match.selection;
using dwd.core.ui.prompt;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000286 RID: 646
	public class WormRevealTurnSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x00068FD4 File Offset: 0x000671D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealTurnSelectionCommand()
		{
			Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormRevealTurnSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr);
			WormRevealTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "selectableAbilities");
			WormRevealTurnSelectionCommand.NativeFieldInfoPtr_earlyAdvanceWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "earlyAdvanceWarning");
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667133);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667134);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667135);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667136);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667137);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667138);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667139);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr_ResetHintingAtNextSelection_Private_IEnumerator_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667140);
			WormRevealTurnSelectionCommand.NativeMethodInfoPtr__resetHints_b__8_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, 100667141);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000690E0 File Offset: 0x000672E0
		public unsafe virtual IEnumerable<EntityID> SelectableAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00069120 File Offset: 0x00067320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723033, XrefRangeEnd = 723069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealTurnSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0006917C File Offset: 0x0006737C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723069, XrefRangeEnd = 723074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000691BC File Offset: 0x000673BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723074, XrefRangeEnd = 723079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealTurnSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00069208 File Offset: 0x00067408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723079, XrefRangeEnd = 723114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealTurnSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00069244 File Offset: 0x00067444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723114, XrefRangeEnd = 723161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealTurnSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00069280 File Offset: 0x00067480
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRevealTurnSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000692C8 File Offset: 0x000674C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723161, XrefRangeEnd = 723167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ResetHintingAtNextSelection(IList<EntityID> hintEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hintEntities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.NativeMethodInfoPtr_ResetHintingAtNextSelection_Private_IEnumerator_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00069318 File Offset: 0x00067518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723167, XrefRangeEnd = 723168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _resetHints_b__8_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.NativeMethodInfoPtr__resetHints_b__8_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0000F5B5 File Offset: 0x0000D7B5
		public WormRevealTurnSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00069368 File Offset: 0x00067568
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000F5BE File Offset: 0x0000D7BE
		public unsafe List<EntityID> selectableAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00069398 File Offset: 0x00067598
		// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000F5DD File Offset: 0x0000D7DD
		public unsafe Command earlyAdvanceWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand.NativeFieldInfoPtr_earlyAdvanceWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand.NativeFieldInfoPtr_earlyAdvanceWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_selectableAbilities;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_earlyAdvanceWarning;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_ResetHintingAtNextSelection_Private_IEnumerator_IList_1_EntityID_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr__resetHints_b__8_0_Private_Boolean_EntityID_0;

		// Token: 0x02000430 RID: 1072
		[ObfuscatedName("worm.match.commands.selectionCommands.WormRevealTurnSelectionCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002C7D RID: 11389 RVA: 0x0009EFC8 File Offset: 0x0009D1C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr);
				WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr, "<>9");
				WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr, "<>9__6_0");
				WormRevealTurnSelectionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr, 100667143);
				WormRevealTurnSelectionCommand.__c.NativeMethodInfoPtr__idle_b__6_0_Internal_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr, 100667144);
			}

			// Token: 0x06002C7E RID: 11390 RVA: 0x0009F044 File Offset: 0x0009D244
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealTurnSelectionCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C7F RID: 11391 RVA: 0x0009F080 File Offset: 0x0009D280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722794, XrefRangeEnd = 722797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _idle_b__6_0(Set s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand.__c.NativeMethodInfoPtr__idle_b__6_0_Internal_String_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002C80 RID: 11392 RVA: 0x00018278 File Offset: 0x00016478
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0009F0C4 File Offset: 0x0009D2C4
			// (set) Token: 0x06002C82 RID: 11394 RVA: 0x00018281 File Offset: 0x00016481
			public unsafe static WormRevealTurnSelectionCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealTurnSelectionCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x06002C83 RID: 11395 RVA: 0x0009F0EC File Offset: 0x0009D2EC
			// (set) Token: 0x06002C84 RID: 11396 RVA: 0x00018293 File Offset: 0x00016493
			public unsafe static Func<Set, string> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Set, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormRevealTurnSelectionCommand.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019E1 RID: 6625
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019E2 RID: 6626
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040019E3 RID: 6627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019E4 RID: 6628
			private static readonly IntPtr NativeMethodInfoPtr__idle_b__6_0_Internal_String_Set_0;
		}

		// Token: 0x02000431 RID: 1073
		[ObfuscatedName("worm.match.commands.selectionCommands.WormRevealTurnSelectionCommand+<Advance>d__5")]
		public sealed class _Advance_d__5 : Object
		{
			// Token: 0x06002C85 RID: 11397 RVA: 0x0009F114 File Offset: 0x0009D314
			// Note: this type is marked as 'beforefieldinit'.
			static _Advance_d__5()
			{
				Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "<Advance>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, "<>1__state");
				WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, "<>2__current");
				WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, "<>4__this");
				WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, "<selectionResponder>5__2");
				WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__confirmAdvancePrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, "<confirmAdvancePrompt>5__3");
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667145);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667146);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667147);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667148);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667149);
				WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr, 100667150);
			}

			// Token: 0x06002C86 RID: 11398 RVA: 0x0009F21C File Offset: 0x0009D41C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Advance_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._Advance_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C87 RID: 11399 RVA: 0x0009F264 File Offset: 0x0009D464
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C88 RID: 11400 RVA: 0x0009F298 File Offset: 0x0009D498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722797, XrefRangeEnd = 722843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x06002C89 RID: 11401 RVA: 0x0009F2D4 File Offset: 0x0009D4D4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C8A RID: 11402 RVA: 0x0009F314 File Offset: 0x0009D514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722843, XrefRangeEnd = 722848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x06002C8B RID: 11403 RVA: 0x0009F348 File Offset: 0x0009D548
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._Advance_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C8C RID: 11404 RVA: 0x000182A5 File Offset: 0x000164A5
			public _Advance_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x06002C8D RID: 11405 RVA: 0x0009F388 File Offset: 0x0009D588
			// (set) Token: 0x06002C8E RID: 11406 RVA: 0x000182AE File Offset: 0x000164AE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x06002C8F RID: 11407 RVA: 0x0009F3B0 File Offset: 0x0009D5B0
			// (set) Token: 0x06002C90 RID: 11408 RVA: 0x000182C9 File Offset: 0x000164C9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x06002C91 RID: 11409 RVA: 0x0009F3E0 File Offset: 0x0009D5E0
			// (set) Token: 0x06002C92 RID: 11410 RVA: 0x000182E8 File Offset: 0x000164E8
			public unsafe WormRevealTurnSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealTurnSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x06002C93 RID: 11411 RVA: 0x0009F410 File Offset: 0x0009D610
			// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00018307 File Offset: 0x00016507
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x06002C95 RID: 11413 RVA: 0x0009F440 File Offset: 0x0009D640
			// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00018326 File Offset: 0x00016526
			public unsafe ConfirmOrDenyPrompt _confirmAdvancePrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__confirmAdvancePrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._Advance_d__5.NativeFieldInfoPtr__confirmAdvancePrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019E5 RID: 6629
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019E6 RID: 6630
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019E7 RID: 6631
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019E8 RID: 6632
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x040019E9 RID: 6633
			private static readonly IntPtr NativeFieldInfoPtr__confirmAdvancePrompt_5__3;

			// Token: 0x040019EA RID: 6634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019EB RID: 6635
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019EC RID: 6636
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019ED RID: 6637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019EE RID: 6638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019EF RID: 6639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000432 RID: 1074
		[ObfuscatedName("worm.match.commands.selectionCommands.WormRevealTurnSelectionCommand+<ResetHintingAtNextSelection>d__10")]
		public sealed class _ResetHintingAtNextSelection_d__10 : Object
		{
			// Token: 0x06002C97 RID: 11415 RVA: 0x0009F470 File Offset: 0x0009D670
			// Note: this type is marked as 'beforefieldinit'.
			static _ResetHintingAtNextSelection_d__10()
			{
				Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "<ResetHintingAtNextSelection>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, "<>1__state");
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, "<>2__current");
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, "<>4__this");
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr_hintEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, "hintEntities");
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667151);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667152);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667153);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667154);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667155);
				WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr, 100667156);
			}

			// Token: 0x06002C98 RID: 11416 RVA: 0x0009F564 File Offset: 0x0009D764
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResetHintingAtNextSelection_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C99 RID: 11417 RVA: 0x0009F5AC File Offset: 0x0009D7AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C9A RID: 11418 RVA: 0x0009F5E0 File Offset: 0x0009D7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722848, XrefRangeEnd = 722856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x06002C9B RID: 11419 RVA: 0x0009F61C File Offset: 0x0009D81C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9C RID: 11420 RVA: 0x0009F65C File Offset: 0x0009D85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722856, XrefRangeEnd = 722861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x06002C9D RID: 11421 RVA: 0x0009F690 File Offset: 0x0009D890
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C9E RID: 11422 RVA: 0x00018345 File Offset: 0x00016545
			public _ResetHintingAtNextSelection_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x06002C9F RID: 11423 RVA: 0x0009F6D0 File Offset: 0x0009D8D0
			// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0001834E File Offset: 0x0001654E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x0009F6F8 File Offset: 0x0009D8F8
			// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x00018369 File Offset: 0x00016569
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x0009F728 File Offset: 0x0009D928
			// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x00018388 File Offset: 0x00016588
			public unsafe WormRevealTurnSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealTurnSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x0009F758 File Offset: 0x0009D958
			// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x000183A7 File Offset: 0x000165A7
			public unsafe IList<EntityID> hintEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr_hintEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._ResetHintingAtNextSelection_d__10.NativeFieldInfoPtr_hintEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019F0 RID: 6640
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019F1 RID: 6641
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019F2 RID: 6642
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019F3 RID: 6643
			private static readonly IntPtr NativeFieldInfoPtr_hintEntities;

			// Token: 0x040019F4 RID: 6644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019F5 RID: 6645
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019F6 RID: 6646
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019F7 RID: 6647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019F8 RID: 6648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019F9 RID: 6649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000433 RID: 1075
		[ObfuscatedName("worm.match.commands.selectionCommands.WormRevealTurnSelectionCommand+<idle>d__6")]
		public sealed class _idle_d__6 : Object
		{
			// Token: 0x06002CA7 RID: 11431 RVA: 0x0009F788 File Offset: 0x0009D988
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__6()
			{
				Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormRevealTurnSelectionCommand>.NativeClassPtr, "<idle>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr);
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<>1__state");
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<>2__current");
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<>4__this");
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__displayImperiumRow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<displayImperiumRow>5__2");
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__clientEventResponder_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<clientEventResponder>5__3");
				WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__prompter_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, "<prompter>5__4");
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667157);
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667158);
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667159);
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667160);
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667161);
				WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr, 100667162);
			}

			// Token: 0x06002CA8 RID: 11432 RVA: 0x0009F8A4 File Offset: 0x0009DAA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealTurnSelectionCommand._idle_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002CA9 RID: 11433 RVA: 0x0009F8EC File Offset: 0x0009DAEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CAA RID: 11434 RVA: 0x0009F920 File Offset: 0x0009DB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722861, XrefRangeEnd = 723028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x06002CAB RID: 11435 RVA: 0x0009F95C File Offset: 0x0009DB5C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAC RID: 11436 RVA: 0x0009F99C File Offset: 0x0009DB9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723028, XrefRangeEnd = 723033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x06002CAD RID: 11437 RVA: 0x0009F9D0 File Offset: 0x0009DBD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealTurnSelectionCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CAE RID: 11438 RVA: 0x000183C6 File Offset: 0x000165C6
			public _idle_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x06002CAF RID: 11439 RVA: 0x0009FA10 File Offset: 0x0009DC10
			// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x000183CF File Offset: 0x000165CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x0009FA38 File Offset: 0x0009DC38
			// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x000183EA File Offset: 0x000165EA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x0009FA68 File Offset: 0x0009DC68
			// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x00018409 File Offset: 0x00016609
			public unsafe WormRevealTurnSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormRevealTurnSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x0009FA98 File Offset: 0x0009DC98
			// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x00018428 File Offset: 0x00016628
			public unsafe bool _displayImperiumRow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__displayImperiumRow_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__displayImperiumRow_5__2)) = value;
				}
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x0009FAC0 File Offset: 0x0009DCC0
			// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00018443 File Offset: 0x00016643
			public unsafe ClientEventResponder _clientEventResponder_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__clientEventResponder_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__clientEventResponder_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x0009FAF0 File Offset: 0x0009DCF0
			// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00018462 File Offset: 0x00016662
			public unsafe GenericPrompter _prompter_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__prompter_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRevealTurnSelectionCommand._idle_d__6.NativeFieldInfoPtr__prompter_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019FA RID: 6650
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019FB RID: 6651
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019FC RID: 6652
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019FD RID: 6653
			private static readonly IntPtr NativeFieldInfoPtr__displayImperiumRow_5__2;

			// Token: 0x040019FE RID: 6654
			private static readonly IntPtr NativeFieldInfoPtr__clientEventResponder_5__3;

			// Token: 0x040019FF RID: 6655
			private static readonly IntPtr NativeFieldInfoPtr__prompter_5__4;

			// Token: 0x04001A00 RID: 6656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001A01 RID: 6657
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A02 RID: 6658
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001A03 RID: 6659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001A04 RID: 6660
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001A05 RID: 6661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
