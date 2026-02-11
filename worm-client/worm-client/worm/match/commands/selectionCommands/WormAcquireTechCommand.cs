using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.match.prompts.behaviours;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200026E RID: 622
	public class WormAcquireTechCommand : WormSelectCardPromptDragTargetCommand
	{
		// Token: 0x06001994 RID: 6548 RVA: 0x0006631C File Offset: 0x0006451C
		// Note: this type is marked as 'beforefieldinit'.
		static WormAcquireTechCommand()
		{
			Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormAcquireTechCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr);
			WormAcquireTechCommand.NativeFieldInfoPtr_discountedTechs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, "discountedTechs");
			WormAcquireTechCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666966);
			WormAcquireTechCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666967);
			WormAcquireTechCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666968);
			WormAcquireTechCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666969);
			WormAcquireTechCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666970);
			WormAcquireTechCommand.NativeMethodInfoPtr_GetTopTechs_Private_IEnumerable_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666971);
			WormAcquireTechCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666972);
			WormAcquireTechCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666973);
			WormAcquireTechCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666974);
			WormAcquireTechCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, 100666975);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00066428 File Offset: 0x00064628
		public unsafe override string promptHeaderLoc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720480, XrefRangeEnd = 720522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0006646C File Offset: 0x0006466C
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720522, XrefRangeEnd = 720524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000664B0 File Offset: 0x000646B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 720532, RefRangeEnd = 720533, XrefRangeStart = 720524, XrefRangeEnd = 720532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAcquireTechCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0006650C File Offset: 0x0006470C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720533, XrefRangeEnd = 720538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00066558 File Offset: 0x00064758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720538, XrefRangeEnd = 720583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000665A4 File Offset: 0x000647A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 720625, RefRangeEnd = 720628, XrefRangeStart = 720583, XrefRangeEnd = 720625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityComponent> GetTopTechs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.NativeMethodInfoPtr_GetTopTechs_Private_IEnumerable_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000665E4 File Offset: 0x000647E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720628, XrefRangeEnd = 720647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00066620 File Offset: 0x00064820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720647, XrefRangeEnd = 720681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0006665C File Offset: 0x0006485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720681, XrefRangeEnd = 720709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAcquireTechCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00066698 File Offset: 0x00064898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720709, XrefRangeEnd = 720714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000F119 File Offset: 0x0000D319
		public WormAcquireTechCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000666D8 File Offset: 0x000648D8
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x0000F122 File Offset: 0x0000D322
		public unsafe List<EntityComponent> discountedTechs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand.NativeFieldInfoPtr_discountedTechs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand.NativeFieldInfoPtr_discountedTechs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_discountedTechs;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_GetTopTechs_Private_IEnumerable_1_EntityComponent_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x02000421 RID: 1057
		[ObfuscatedName("worm.match.commands.selectionCommands.WormAcquireTechCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002BC6 RID: 11206 RVA: 0x0009CBCC File Offset: 0x0009ADCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr);
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9");
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9__8_0");
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9__8_2");
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9__8_1");
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9__10_0");
				WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, "<>9__11_0");
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666977);
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666978);
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_1_Internal_IEnumerable_1_EntityComponent_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666979);
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_2_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666980);
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__enterNodeHints_b__10_0_Internal_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666981);
				WormAcquireTechCommand.__c.NativeMethodInfoPtr__resetHints_b__11_0_Internal_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr, 100666982);
			}

			// Token: 0x06002BC7 RID: 11207 RVA: 0x0009CCE8 File Offset: 0x0009AEE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BC8 RID: 11208 RVA: 0x0009CD24 File Offset: 0x0009AF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720434, XrefRangeEnd = 720441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTopTechs_b__8_0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002BC9 RID: 11209 RVA: 0x0009CD74 File Offset: 0x0009AF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720441, XrefRangeEnd = 720465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<EntityComponent> _GetTopTechs_b__8_1(EntityComponent s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_1_Internal_IEnumerable_1_EntityComponent_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityComponent>>(intPtr3) : null;
				}
			}

			// Token: 0x06002BCA RID: 11210 RVA: 0x0009CDC4 File Offset: 0x0009AFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720465, XrefRangeEnd = 720472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTopTechs_b__8_2(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__GetTopTechs_b__8_2_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002BCB RID: 11211 RVA: 0x0009CE14 File Offset: 0x0009B014
			[CallerCount(0)]
			public unsafe EntityID _enterNodeHints_b__10_0(EntityComponent t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__enterNodeHints_b__10_0_Internal_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002BCC RID: 11212 RVA: 0x0009CE64 File Offset: 0x0009B064
			[CallerCount(0)]
			public unsafe EntityID _resetHints_b__11_0(EntityComponent t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand.__c.NativeMethodInfoPtr__resetHints_b__11_0_Internal_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06002BCD RID: 11213 RVA: 0x00017D70 File Offset: 0x00015F70
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0009CEB4 File Offset: 0x0009B0B4
			// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00017D79 File Offset: 0x00015F79
			public unsafe static WormAcquireTechCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0009CEDC File Offset: 0x0009B0DC
			// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00017D8B File Offset: 0x00015F8B
			public unsafe static Func<EntityComponent, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0009CF04 File Offset: 0x0009B104
			// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00017D9D File Offset: 0x00015F9D
			public unsafe static Func<EntityComponent, bool> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0009CF2C File Offset: 0x0009B12C
			// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00017DAF File Offset: 0x00015FAF
			public unsafe static Func<EntityComponent, IEnumerable<EntityComponent>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, IEnumerable<EntityComponent>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x0009CF54 File Offset: 0x0009B154
			// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00017DC1 File Offset: 0x00015FC1
			public unsafe static Func<EntityComponent, EntityID> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x0009CF7C File Offset: 0x0009B17C
			// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00017DD3 File Offset: 0x00015FD3
			public unsafe static Func<EntityComponent, EntityID> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAcquireTechCommand.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001972 RID: 6514
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001973 RID: 6515
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001974 RID: 6516
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x04001975 RID: 6517
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04001976 RID: 6518
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001977 RID: 6519
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04001978 RID: 6520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001979 RID: 6521
			private static readonly IntPtr NativeMethodInfoPtr__GetTopTechs_b__8_0_Internal_Boolean_EntityComponent_0;

			// Token: 0x0400197A RID: 6522
			private static readonly IntPtr NativeMethodInfoPtr__GetTopTechs_b__8_1_Internal_IEnumerable_1_EntityComponent_EntityComponent_0;

			// Token: 0x0400197B RID: 6523
			private static readonly IntPtr NativeMethodInfoPtr__GetTopTechs_b__8_2_Internal_Boolean_EntityComponent_0;

			// Token: 0x0400197C RID: 6524
			private static readonly IntPtr NativeMethodInfoPtr__enterNodeHints_b__10_0_Internal_EntityID_EntityComponent_0;

			// Token: 0x0400197D RID: 6525
			private static readonly IntPtr NativeMethodInfoPtr__resetHints_b__11_0_Internal_EntityID_EntityComponent_0;
		}

		// Token: 0x02000422 RID: 1058
		[ObfuscatedName("worm.match.commands.selectionCommands.WormAcquireTechCommand+<idle>d__6")]
		public sealed class _idle_d__6 : Object
		{
			// Token: 0x06002BDA RID: 11226 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__6()
			{
				Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAcquireTechCommand>.NativeClassPtr, "<idle>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr);
				WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, "<>1__state");
				WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, "<>2__current");
				WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, "<>4__this");
				WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr__existingPromptBehaviour_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, "<existingPromptBehaviour>5__2");
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666983);
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666984);
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666985);
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666986);
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666987);
				WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr, 100666988);
			}

			// Token: 0x06002BDB RID: 11227 RVA: 0x0009D098 File Offset: 0x0009B298
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireTechCommand._idle_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002BDC RID: 11228 RVA: 0x0009D0E0 File Offset: 0x0009B2E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BDD RID: 11229 RVA: 0x0009D114 File Offset: 0x0009B314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720472, XrefRangeEnd = 720475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x06002BDE RID: 11230 RVA: 0x0009D150 File Offset: 0x0009B350
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BDF RID: 11231 RVA: 0x0009D190 File Offset: 0x0009B390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720475, XrefRangeEnd = 720480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireTechCommand._idle_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002BE1 RID: 11233 RVA: 0x00017DE5 File Offset: 0x00015FE5
			public _idle_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x0009D204 File Offset: 0x0009B404
			// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00017DEE File Offset: 0x00015FEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x0009D22C File Offset: 0x0009B42C
			// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x00017E09 File Offset: 0x00016009
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x0009D25C File Offset: 0x0009B45C
			// (set) Token: 0x06002BE7 RID: 11239 RVA: 0x00017E28 File Offset: 0x00016028
			public unsafe WormAcquireTechCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x06002BE8 RID: 11240 RVA: 0x0009D28C File Offset: 0x0009B48C
			// (set) Token: 0x06002BE9 RID: 11241 RVA: 0x00017E47 File Offset: 0x00016047
			public unsafe WormAcquireTechPromptBehaviour _existingPromptBehaviour_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr__existingPromptBehaviour_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAcquireTechCommand._idle_d__6.NativeFieldInfoPtr__existingPromptBehaviour_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400197E RID: 6526
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400197F RID: 6527
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001980 RID: 6528
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001981 RID: 6529
			private static readonly IntPtr NativeFieldInfoPtr__existingPromptBehaviour_5__2;

			// Token: 0x04001982 RID: 6530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001983 RID: 6531
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001984 RID: 6532
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001985 RID: 6533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001986 RID: 6534
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001987 RID: 6535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
