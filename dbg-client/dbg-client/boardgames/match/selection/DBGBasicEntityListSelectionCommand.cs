using System;
using boardgames.match.behaviours;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000265 RID: 613
	public class DBGBasicEntityListSelectionCommand : DBGSelectionCommand<IEntityListSelection>
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x0007A838 File Offset: 0x00078A38
		// Note: this type is marked as 'beforefieldinit'.
		static DBGBasicEntityListSelectionCommand()
		{
			Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGBasicEntityListSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr);
			DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "hintedEntities");
			DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPreviousSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "hintedPreviousSelections");
			DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "selectionPromptRenderers");
			DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_filteredHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "filteredHints");
			DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPlayerPhaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "hintedPlayerPhaseButton");
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667903);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_get_previousSelectableEntityNames_Protected_Virtual_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667904);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667905);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_SetHints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667906);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667907);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667908);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelection_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667909);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelectionHintsSelected_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667910);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelectionHintsUnSelectable_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667911);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnUnselection_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667912);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnUnselectionHints_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667913);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667914);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667915);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667916);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_previousSelectionHints_Protected_Virtual_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667917);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_showFilteredSelectionHint_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667918);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667919);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_filteredSelectionHints_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667920);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667921);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_exitNodeHints_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667922);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667923);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_isPreviousSelectable_Protected_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667924);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__filteredSelectionHints_b__24_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667925);
			DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__filteredSelectionHints_b__24_1_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, 100667926);
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0007AAAC File Offset: 0x00078CAC
		public unsafe virtual bool ShowSelectionPrompt
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0007AAF4 File Offset: 0x00078CF4
		public unsafe virtual List<string> previousSelectableEntityNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534994, XrefRangeEnd = 535005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_get_previousSelectableEntityNames_Protected_Virtual_New_get_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0007AB40 File Offset: 0x00078D40
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 535107, RefRangeEnd = 535121, XrefRangeStart = 535005, XrefRangeEnd = 535107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGBasicEntityListSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0007AB9C File Offset: 0x00078D9C
		[CallerCount(0)]
		public unsafe void SetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_SetHints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0007ABD0 File Offset: 0x00078DD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 535126, RefRangeEnd = 535130, XrefRangeStart = 535121, XrefRangeEnd = 535126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0007AC1C File Offset: 0x00078E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535130, XrefRangeEnd = 535156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0007AC74 File Offset: 0x00078E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535156, XrefRangeEnd = 535173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hintOnSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelection_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0007ACC4 File Offset: 0x00078EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535173, XrefRangeEnd = 535176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hintOnSelectionHintsSelected(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelectionHintsSelected_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0007AD14 File Offset: 0x00078F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535176, XrefRangeEnd = 535179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hintOnSelectionHintsUnSelectable(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnSelectionHintsUnSelectable_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0007AD64 File Offset: 0x00078F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535179, XrefRangeEnd = 535183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hintOnUnselection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnUnselection_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0007ADB4 File Offset: 0x00078FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535183, XrefRangeEnd = 535186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void hintOnUnselectionHints(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_hintOnUnselectionHints_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0007AE04 File Offset: 0x00079004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535186, XrefRangeEnd = 535218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0007AE4C File Offset: 0x0007904C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 535258, RefRangeEnd = 535262, XrefRangeStart = 535218, XrefRangeEnd = 535258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0007AE98 File Offset: 0x00079098
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 535271, RefRangeEnd = 535275, XrefRangeStart = 535262, XrefRangeEnd = 535271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0007AED4 File Offset: 0x000790D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535275, XrefRangeEnd = 535281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void previousSelectionHints(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_previousSelectionHints_Protected_Virtual_New_Void_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0007AF24 File Offset: 0x00079124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535281, XrefRangeEnd = 535286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void showFilteredSelectionHint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_showFilteredSelectionHint_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0007AF60 File Offset: 0x00079160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 535308, RefRangeEnd = 535311, XrefRangeStart = 535286, XrefRangeEnd = 535308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0007AFA8 File Offset: 0x000791A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535311, XrefRangeEnd = 535360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void filteredSelectionHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_filteredSelectionHints_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0007AFE4 File Offset: 0x000791E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 535381, RefRangeEnd = 535387, XrefRangeStart = 535360, XrefRangeEnd = 535381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0007B020 File Offset: 0x00079220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535387, XrefRangeEnd = 535404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void exitNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_exitNodeHints_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0007B05C File Offset: 0x0007925C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 535418, RefRangeEnd = 535423, XrefRangeStart = 535404, XrefRangeEnd = 535418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0007B098 File Offset: 0x00079298
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 535447, RefRangeEnd = 535450, XrefRangeStart = 535423, XrefRangeEnd = 535447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isPreviousSelectable(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr_isPreviousSelectable_Protected_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0007B0E8 File Offset: 0x000792E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535450, XrefRangeEnd = 535465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _filteredSelectionHints_b__24_0(EntityID he)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(he);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__filteredSelectionHints_b__24_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0007B138 File Offset: 0x00079338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535465, XrefRangeEnd = 535480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _filteredSelectionHints_b__24_1(EntityID he)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(he);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.NativeMethodInfoPtr__filteredSelectionHints_b__24_1_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0000F315 File Offset: 0x0000D515
		public DBGBasicEntityListSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0007B188 File Offset: 0x00079388
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0000F31E File Offset: 0x0000D51E
		public unsafe Dictionary<EntityID, EntityID> hintedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0007B1B8 File Offset: 0x000793B8
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x0000F33D File Offset: 0x0000D53D
		public unsafe List<EntityID> hintedPreviousSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPreviousSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPreviousSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0007B1E8 File Offset: 0x000793E8
		// (set) Token: 0x06001C5A RID: 7258 RVA: 0x0000F35C File Offset: 0x0000D55C
		public unsafe List<SelectionPromptRenderer> selectionPromptRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionPromptRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_selectionPromptRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0007B218 File Offset: 0x00079418
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0000F37B File Offset: 0x0000D57B
		public unsafe List<EntityID> filteredHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_filteredHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_filteredHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0007B248 File Offset: 0x00079448
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0000F39A File Offset: 0x0000D59A
		public unsafe bool hintedPlayerPhaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPlayerPhaseButton);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.NativeFieldInfoPtr_hintedPlayerPhaseButton)) = value;
			}
		}

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeFieldInfoPtr_hintedEntities;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_hintedPreviousSelections;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_selectionPromptRenderers;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_filteredHints;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_hintedPlayerPhaseButton;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowSelectionPrompt_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_get_previousSelectableEntityNames_Protected_Virtual_New_get_List_1_String_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_SetHints_Public_Void_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_hintOnSelection_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_hintOnSelectionHintsSelected_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_hintOnSelectionHintsUnSelectable_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_hintOnUnselection_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_hintOnUnselectionHints_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_New_Void_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_previousSelectionHints_Protected_Virtual_New_Void_EntityID_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_showFilteredSelectionHint_Protected_Virtual_New_Void_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_filteredSelectionHints_Protected_Virtual_New_Void_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_exitNodeHints_Protected_Virtual_New_Void_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_New_Void_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_isPreviousSelectable_Protected_Boolean_EntityID_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr__filteredSelectionHints_b__24_0_Private_Boolean_EntityID_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr__filteredSelectionHints_b__24_1_Private_Boolean_EntityID_0;

		// Token: 0x0200045B RID: 1115
		[ObfuscatedName("boardgames.match.selection.DBGBasicEntityListSelectionCommand+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06003515 RID: 13589 RVA: 0x000C6E7C File Offset: 0x000C507C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr);
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeFieldInfoPtr_he = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr, "he");
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr, 100667927);
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeMethodInfoPtr__filteredSelectionHints_b__2_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr, 100667928);
			}

			// Token: 0x06003516 RID: 13590 RVA: 0x000C6EE4 File Offset: 0x000C50E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003517 RID: 13591 RVA: 0x000C6F20 File Offset: 0x000C5120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534964, XrefRangeEnd = 534968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _filteredSelectionHints_b__2(EntityID fh)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fh);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeMethodInfoPtr__filteredSelectionHints_b__2_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003518 RID: 13592 RVA: 0x0001B6DE File Offset: 0x000198DE
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F98 RID: 3992
			// (get) Token: 0x06003519 RID: 13593 RVA: 0x000C6F70 File Offset: 0x000C5170
			// (set) Token: 0x0600351A RID: 13594 RVA: 0x0001B6E7 File Offset: 0x000198E7
			public unsafe EntityID he
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeFieldInfoPtr_he);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_0.NativeFieldInfoPtr_he), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020B8 RID: 8376
			private static readonly IntPtr NativeFieldInfoPtr_he;

			// Token: 0x040020B9 RID: 8377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020BA RID: 8378
			private static readonly IntPtr NativeMethodInfoPtr__filteredSelectionHints_b__2_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200045C RID: 1116
		[ObfuscatedName("boardgames.match.selection.DBGBasicEntityListSelectionCommand+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Object
		{
			// Token: 0x0600351B RID: 13595 RVA: 0x000C6FA0 File Offset: 0x000C51A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr);
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeFieldInfoPtr_he = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr, "he");
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr, 100667929);
				DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeMethodInfoPtr__filteredSelectionHints_b__3_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr, 100667930);
			}

			// Token: 0x0600351C RID: 13596 RVA: 0x000C7008 File Offset: 0x000C5208
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600351D RID: 13597 RVA: 0x000C7044 File Offset: 0x000C5244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534968, XrefRangeEnd = 534972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _filteredSelectionHints_b__3(EntityID fh)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fh);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeMethodInfoPtr__filteredSelectionHints_b__3_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600351E RID: 13598 RVA: 0x0001B706 File Offset: 0x00019906
			public __c__DisplayClass24_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F99 RID: 3993
			// (get) Token: 0x0600351F RID: 13599 RVA: 0x000C7094 File Offset: 0x000C5294
			// (set) Token: 0x06003520 RID: 13600 RVA: 0x0001B70F File Offset: 0x0001990F
			public unsafe EntityID he
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeFieldInfoPtr_he);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand.__c__DisplayClass24_1.NativeFieldInfoPtr_he), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020BB RID: 8379
			private static readonly IntPtr NativeFieldInfoPtr_he;

			// Token: 0x040020BC RID: 8380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020BD RID: 8381
			private static readonly IntPtr NativeMethodInfoPtr__filteredSelectionHints_b__3_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200045D RID: 1117
		[ObfuscatedName("boardgames.match.selection.DBGBasicEntityListSelectionCommand+<idle>d__11")]
		public sealed class _idle_d__11 : Object
		{
			// Token: 0x06003521 RID: 13601 RVA: 0x000C70C4 File Offset: 0x000C52C4
			// Note: this type is marked as 'beforefieldinit'.
			static _idle_d__11()
			{
				Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand>.NativeClassPtr, "<idle>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, "<>1__state");
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, "<>2__current");
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, "<>4__this");
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667931);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667932);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667933);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667934);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667935);
				DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr, 100667936);
			}

			// Token: 0x06003522 RID: 13602 RVA: 0x000C71A4 File Offset: 0x000C53A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _idle_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGBasicEntityListSelectionCommand._idle_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003523 RID: 13603 RVA: 0x000C71EC File Offset: 0x000C53EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003524 RID: 13604 RVA: 0x000C7220 File Offset: 0x000C5420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534972, XrefRangeEnd = 534989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F9D RID: 3997
			// (get) Token: 0x06003525 RID: 13605 RVA: 0x000C725C File Offset: 0x000C545C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003526 RID: 13606 RVA: 0x000C729C File Offset: 0x000C549C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534989, XrefRangeEnd = 534994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F9E RID: 3998
			// (get) Token: 0x06003527 RID: 13607 RVA: 0x000C72D0 File Offset: 0x000C54D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGBasicEntityListSelectionCommand._idle_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003528 RID: 13608 RVA: 0x0001B72E File Offset: 0x0001992E
			public _idle_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F9A RID: 3994
			// (get) Token: 0x06003529 RID: 13609 RVA: 0x000C7310 File Offset: 0x000C5510
			// (set) Token: 0x0600352A RID: 13610 RVA: 0x0001B737 File Offset: 0x00019937
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F9B RID: 3995
			// (get) Token: 0x0600352B RID: 13611 RVA: 0x000C7338 File Offset: 0x000C5538
			// (set) Token: 0x0600352C RID: 13612 RVA: 0x0001B752 File Offset: 0x00019952
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F9C RID: 3996
			// (get) Token: 0x0600352D RID: 13613 RVA: 0x000C7368 File Offset: 0x000C5568
			// (set) Token: 0x0600352E RID: 13614 RVA: 0x0001B771 File Offset: 0x00019971
			public unsafe DBGBasicEntityListSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGBasicEntityListSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGBasicEntityListSelectionCommand._idle_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020BE RID: 8382
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020BF RID: 8383
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020C0 RID: 8384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020C1 RID: 8385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020C2 RID: 8386
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020C3 RID: 8387
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020C4 RID: 8388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020C5 RID: 8389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020C6 RID: 8390
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
