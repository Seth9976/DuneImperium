using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.match.prompts.prompts;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000273 RID: 627
	public class WormArchetypeCustomChoiceSelectionPromptCommand : WormSelectionPromptCommand<ArchetypeCustomChoiceNode>
	{
		// Token: 0x060019C4 RID: 6596 RVA: 0x00066F6C File Offset: 0x0006516C
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeCustomChoiceSelectionPromptCommand()
		{
			Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormArchetypeCustomChoiceSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, "promptData");
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, "promptFlavors");
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667019);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667020);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667021);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667022);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667023);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667024);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667025);
			WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_get_temporaryEntityName_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, 100667026);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00067064 File Offset: 0x00065264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720931, XrefRangeEnd = 720934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypeCustomChoiceSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000670C0 File Offset: 0x000652C0
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00067108 File Offset: 0x00065308
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00067154 File Offset: 0x00065354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720934, XrefRangeEnd = 720995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void selectResult(List<EntityID> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000671A4 File Offset: 0x000653A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720995, XrefRangeEnd = 721004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000671F8 File Offset: 0x000653F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721004, XrefRangeEnd = 721083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<EntityComponent> getChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00067244 File Offset: 0x00065444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721083, XrefRangeEnd = 721091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormSelectEntityPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPrompt>(intPtr3) : null;
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00067290 File Offset: 0x00065490
		public unsafe virtual string temporaryEntityName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoiceSelectionPromptCommand.NativeMethodInfoPtr_get_temporaryEntityName_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0000F1E3 File Offset: 0x0000D3E3
		public WormArchetypeCustomChoiceSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x000672D4 File Offset: 0x000654D4
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00067304 File Offset: 0x00065504
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000F20B File Offset: 0x0000D40B
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_Int32_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_get_temporaryEntityName_Protected_Abstract_Virtual_New_get_String_0;

		// Token: 0x02000425 RID: 1061
		[ObfuscatedName("worm.match.commands.selectionCommands.WormArchetypeCustomChoiceSelectionPromptCommand+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06002C06 RID: 11270 RVA: 0x0009D864 File Offset: 0x0009BA64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr);
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr, "entityID");
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr, 100667027);
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__selectResult_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr, 100667028);
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x0009D8CC File Offset: 0x0009BACC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C08 RID: 11272 RVA: 0x0009D908 File Offset: 0x0009BB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720851, XrefRangeEnd = 720860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _selectResult_b__0(EntityComponent choice)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeMethodInfoPtr__selectResult_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C09 RID: 11273 RVA: 0x00017F2A File Offset: 0x0001612A
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x06002C0A RID: 11274 RVA: 0x0009D958 File Offset: 0x0009BB58
			// (set) Token: 0x06002C0B RID: 11275 RVA: 0x00017F33 File Offset: 0x00016133
			public unsafe EntityID entityID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_0.NativeFieldInfoPtr_entityID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400199A RID: 6554
			private static readonly IntPtr NativeFieldInfoPtr_entityID;

			// Token: 0x0400199B RID: 6555
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400199C RID: 6556
			private static readonly IntPtr NativeMethodInfoPtr__selectResult_b__0_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000426 RID: 1062
		[ObfuscatedName("worm.match.commands.selectionCommands.WormArchetypeCustomChoiceSelectionPromptCommand+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Object
		{
			// Token: 0x06002C0C RID: 11276 RVA: 0x0009D988 File Offset: 0x0009BB88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr);
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeFieldInfoPtr_archetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr, "archetypeID");
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr, 100667029);
				WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeMethodInfoPtr__selectResult_b__1_Internal_Boolean_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr, 100667030);
			}

			// Token: 0x06002C0D RID: 11277 RVA: 0x0009D9F0 File Offset: 0x0009BBF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C0E RID: 11278 RVA: 0x0009DA2C File Offset: 0x0009BC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720860, XrefRangeEnd = 720931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _selectResult_b__1(ReadOnlyAttributes button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeMethodInfoPtr__selectResult_b__1_Internal_Boolean_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C0F RID: 11279 RVA: 0x00017F52 File Offset: 0x00016152
			public __c__DisplayClass5_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x06002C10 RID: 11280 RVA: 0x0009DA7C File Offset: 0x0009BC7C
			// (set) Token: 0x06002C11 RID: 11281 RVA: 0x00017F5B File Offset: 0x0001615B
			public unsafe ArchetypeID archetypeID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeFieldInfoPtr_archetypeID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoiceSelectionPromptCommand.__c__DisplayClass5_1.NativeFieldInfoPtr_archetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400199D RID: 6557
			private static readonly IntPtr NativeFieldInfoPtr_archetypeID;

			// Token: 0x0400199E RID: 6558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400199F RID: 6559
			private static readonly IntPtr NativeMethodInfoPtr__selectResult_b__1_Internal_Boolean_ReadOnlyAttributes_0;
		}
	}
}
