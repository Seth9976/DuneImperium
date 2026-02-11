using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.selection;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine.UI;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000282 RID: 642
	public class WormPlayerTurnSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A29 RID: 6697 RVA: 0x00068830 File Offset: 0x00066A30
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerTurnSelectionCommand()
		{
			Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormPlayerTurnSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr);
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "SelectableSpaceHint");
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_OneStepAheadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "OneStepAheadHint");
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_setAsideCardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "setAsideCardID");
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_MinAutoSelectWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "MinAutoSelectWait");
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_displayGenericPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "displayGenericPrompt");
			WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "selectableAbilities");
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667103);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667104);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667105);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667106);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667107);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667108);
			WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, 100667109);
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00068964 File Offset: 0x00066B64
		public unsafe virtual IEnumerable<EntityID> SelectableAbilities
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000689A4 File Offset: 0x00066BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722490, XrefRangeEnd = 722526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerTurnSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00068A00 File Offset: 0x00066C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722526, XrefRangeEnd = 722531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00068A40 File Offset: 0x00066C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722531, XrefRangeEnd = 722616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00068A7C File Offset: 0x00066C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722616, XrefRangeEnd = 722674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00068AB8 File Offset: 0x00066CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722674, XrefRangeEnd = 722749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00068B04 File Offset: 0x00066D04
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerTurnSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0000F420 File Offset: 0x0000D620
		public WormPlayerTurnSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00068B4C File Offset: 0x00066D4C
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x0000F429 File Offset: 0x0000D629
		public unsafe static string SelectableSpaceHint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00068B6C File Offset: 0x00066D6C
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x0000F43B File Offset: 0x0000D63B
		public unsafe static string OneStepAheadHint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_OneStepAheadHint, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_OneStepAheadHint, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x00068B8C File Offset: 0x00066D8C
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0000F44D File Offset: 0x0000D64D
		public unsafe EntityID setAsideCardID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_setAsideCardID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_setAsideCardID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00068BBC File Offset: 0x00066DBC
		// (set) Token: 0x06001A39 RID: 6713 RVA: 0x0000F46C File Offset: 0x0000D66C
		public unsafe static TimeSpan MinAutoSelectWait
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_MinAutoSelectWait, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_MinAutoSelectWait, (void*)(&value));
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00068BD8 File Offset: 0x00066DD8
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x0000F47A File Offset: 0x0000D67A
		public unsafe Command displayGenericPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_displayGenericPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_displayGenericPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00068C08 File Offset: 0x00066E08
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000F499 File Offset: 0x0000D699
		public unsafe List<EntityID> selectableAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.NativeFieldInfoPtr_selectableAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_SelectableSpaceHint;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_OneStepAheadHint;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_setAsideCardID;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_MinAutoSelectWait;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_displayGenericPrompt;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_selectableAbilities;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_EntityID_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x0200042D RID: 1069
		[ObfuscatedName("worm.match.commands.selectionCommands.WormPlayerTurnSelectionCommand+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06002C56 RID: 11350 RVA: 0x0009E810 File Offset: 0x0009CA10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr);
				WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr, "viewManager");
				WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr, 100667111);
				WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr, 100667112);
				WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr, 100667113);
			}

			// Token: 0x06002C57 RID: 11351 RVA: 0x0009E88C File Offset: 0x0009CA8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C58 RID: 11352 RVA: 0x0009E8C8 File Offset: 0x0009CAC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _enterNode_b__0(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C59 RID: 11353 RVA: 0x0009E918 File Offset: 0x0009CB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722376, XrefRangeEnd = 722381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Selectable _enterNode_b__1(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
				}
			}

			// Token: 0x06002C5A RID: 11354 RVA: 0x0001814E File Offset: 0x0001634E
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x06002C5B RID: 11355 RVA: 0x0009E968 File Offset: 0x0009CB68
			// (set) Token: 0x06002C5C RID: 11356 RVA: 0x00018157 File Offset: 0x00016357
			public unsafe ViewManager viewManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_viewManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand.__c__DisplayClass12_0.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C9 RID: 6601
			private static readonly IntPtr NativeFieldInfoPtr_viewManager;

			// Token: 0x040019CA RID: 6602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019CB RID: 6603
			private static readonly IntPtr NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0;

			// Token: 0x040019CC RID: 6604
			private static readonly IntPtr NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0;
		}

		// Token: 0x0200042E RID: 1070
		[ObfuscatedName("worm.match.commands.selectionCommands.WormPlayerTurnSelectionCommand+<Advance>d__9")]
		public sealed class _Advance_d__9 : Object
		{
			// Token: 0x06002C5D RID: 11357 RVA: 0x0009E998 File Offset: 0x0009CB98
			// Note: this type is marked as 'beforefieldinit'.
			static _Advance_d__9()
			{
				Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand>.NativeClassPtr, "<Advance>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, "<>1__state");
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, "<>2__current");
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, "<>4__this");
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__selectionResponder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, "<selectionResponder>5__2");
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__confirmOrDenyPrompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, "<confirmOrDenyPrompt>5__3");
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667114);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667115);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667116);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667117);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667118);
				WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr, 100667119);
			}

			// Token: 0x06002C5E RID: 11358 RVA: 0x0009EAA0 File Offset: 0x0009CCA0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Advance_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerTurnSelectionCommand._Advance_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C5F RID: 11359 RVA: 0x0009EAE8 File Offset: 0x0009CCE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C60 RID: 11360 RVA: 0x0009EB1C File Offset: 0x0009CD1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722381, XrefRangeEnd = 722485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06002C61 RID: 11361 RVA: 0x0009EB58 File Offset: 0x0009CD58
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C62 RID: 11362 RVA: 0x0009EB98 File Offset: 0x0009CD98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722485, XrefRangeEnd = 722490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06002C63 RID: 11363 RVA: 0x0009EBCC File Offset: 0x0009CDCC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerTurnSelectionCommand._Advance_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x00018176 File Offset: 0x00016376
			public _Advance_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0009EC0C File Offset: 0x0009CE0C
			// (set) Token: 0x06002C66 RID: 11366 RVA: 0x0001817F File Offset: 0x0001637F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0009EC34 File Offset: 0x0009CE34
			// (set) Token: 0x06002C68 RID: 11368 RVA: 0x0001819A File Offset: 0x0001639A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0009EC64 File Offset: 0x0009CE64
			// (set) Token: 0x06002C6A RID: 11370 RVA: 0x000181B9 File Offset: 0x000163B9
			public unsafe WormPlayerTurnSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerTurnSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x06002C6B RID: 11371 RVA: 0x0009EC94 File Offset: 0x0009CE94
			// (set) Token: 0x06002C6C RID: 11372 RVA: 0x000181D8 File Offset: 0x000163D8
			public unsafe DBGSelectionResponder _selectionResponder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__selectionResponder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__selectionResponder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x06002C6D RID: 11373 RVA: 0x0009ECC4 File Offset: 0x0009CEC4
			// (set) Token: 0x06002C6E RID: 11374 RVA: 0x000181F7 File Offset: 0x000163F7
			public unsafe ConfirmOrDenyPrompt _confirmOrDenyPrompt_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__confirmOrDenyPrompt_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerTurnSelectionCommand._Advance_d__9.NativeFieldInfoPtr__confirmOrDenyPrompt_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019CD RID: 6605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019CE RID: 6606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019CF RID: 6607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019D0 RID: 6608
			private static readonly IntPtr NativeFieldInfoPtr__selectionResponder_5__2;

			// Token: 0x040019D1 RID: 6609
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDenyPrompt_5__3;

			// Token: 0x040019D2 RID: 6610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019D3 RID: 6611
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019D4 RID: 6612
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019D5 RID: 6613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019D6 RID: 6614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019D7 RID: 6615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
