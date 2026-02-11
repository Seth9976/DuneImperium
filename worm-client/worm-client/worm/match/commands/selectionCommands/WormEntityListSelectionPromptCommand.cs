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
	// Token: 0x0200027C RID: 636
	public class WormEntityListSelectionPromptCommand : WormSelectionPromptCommand<EntityListTargetNode>
	{
		// Token: 0x06001A04 RID: 6660 RVA: 0x00067EA0 File Offset: 0x000660A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEntityListSelectionPromptCommand()
		{
			Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormEntityListSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr);
			WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, "promptData");
			WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, "promptFlavors");
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667077);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_SetPromptData_Protected_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667078);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667079);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667080);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667081);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667082);
			WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, 100667083);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00067F84 File Offset: 0x00066184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721913, XrefRangeEnd = 721916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEntityListSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityListSelectionPromptCommand.NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00067FE0 File Offset: 0x000661E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 721985, RefRangeEnd = 721991, XrefRangeStart = 721916, XrefRangeEnd = 721985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPromptData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_SetPromptData_Protected_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00068024 File Offset: 0x00066224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721991, XrefRangeEnd = 722014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0006806C File Offset: 0x0006626C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000680B8 File Offset: 0x000662B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722014, XrefRangeEnd = 722028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormSelectEntityPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSelectEntityPrompt>(intPtr3) : null;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00068104 File Offset: 0x00066304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722028, XrefRangeEnd = 722046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void selectResult(List<EntityID> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00068154 File Offset: 0x00066354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722046, XrefRangeEnd = 722103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<EntityComponent> getChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEntityListSelectionPromptCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0000F39D File Offset: 0x0000D59D
		public WormEntityListSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x000681A0 File Offset: 0x000663A0
		// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0000F3A6 File Offset: 0x0000D5A6
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x000681D0 File Offset: 0x000663D0
		// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000F3C5 File Offset: 0x0000D5C5
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr_SetPromptData_Protected_Void_DataComposition_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_WormSelectEntityPrompt_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_selectResult_Protected_Virtual_Void_List_1_EntityID_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0;

		// Token: 0x0200042B RID: 1067
		[ObfuscatedName("worm.match.commands.selectionCommands.WormEntityListSelectionPromptCommand+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002C49 RID: 11337 RVA: 0x0009E564 File Offset: 0x0009C764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr);
				WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_targetHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr, "targetHinting");
				WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr, 100667084);
				WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__SetPromptData_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr, 100667085);
			}

			// Token: 0x06002C4A RID: 11338 RVA: 0x0009E5CC File Offset: 0x0009C7CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEntityListSelectionPromptCommand.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C4B RID: 11339 RVA: 0x0009E608 File Offset: 0x0009C808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721902, XrefRangeEnd = 721913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetPromptData_b__0(EntityID e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeMethodInfoPtr__SetPromptData_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C4C RID: 11340 RVA: 0x000180FE File Offset: 0x000162FE
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0009E658 File Offset: 0x0009C858
			// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00018107 File Offset: 0x00016307
			public unsafe Dictionary<EntityID, ReadOnlyAttributes> targetHinting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_targetHinting);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEntityListSelectionPromptCommand.__c__DisplayClass3_0.NativeFieldInfoPtr_targetHinting), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C2 RID: 6594
			private static readonly IntPtr NativeFieldInfoPtr_targetHinting;

			// Token: 0x040019C3 RID: 6595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019C4 RID: 6596
			private static readonly IntPtr NativeMethodInfoPtr__SetPromptData_b__0_Internal_Boolean_EntityID_0;
		}
	}
}
