using System;
using boardgames.commands;
using boardgames.data;
using boardgames.kabbage;
using boardgames.match.behaviours;
using boardgames.prompts;
using boardgames.tutorial;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.match.selection;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using lotus.kabbage;
using UnityEngine;

namespace boardgames.match.tutorial
{
	// Token: 0x0200025A RID: 602
	public class TutorialEffects : MonoBehaviour
	{
		// Token: 0x06001B5E RID: 7006 RVA: 0x00076E90 File Offset: 0x00075090
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialEffects()
		{
			Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "TutorialEffects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr);
			TutorialEffects.NativeFieldInfoPtr_DoinkerFXName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "DoinkerFXName");
			TutorialEffects.NativeFieldInfoPtr_SelectionDoinkerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "SelectionDoinkerID");
			TutorialEffects.NativeFieldInfoPtr_GoalsPromptID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "GoalsPromptID");
			TutorialEffects.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "entitiesProvider");
			TutorialEffects.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "viewManager");
			TutorialEffects.NativeFieldInfoPtr_persistentPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "persistentPrompts");
			TutorialEffects.NativeFieldInfoPtr_persistentHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "persistentHints");
			TutorialEffects.NativeFieldInfoPtr_selectionScopedQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "selectionScopedQueue");
			TutorialEffects.NativeFieldInfoPtr_registeredCallsToAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "registeredCallsToAction");
			TutorialEffects.NativeFieldInfoPtr_activelyRunningCallsToAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "activelyRunningCallsToAction");
			TutorialEffects.NativeFieldInfoPtr_delayedTutorialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "delayedTutorialEffects");
			TutorialEffects.NativeFieldInfoPtr__SuppressTutorials_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<SuppressTutorials>k__BackingField");
			TutorialEffects.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<Version>k__BackingField");
			TutorialEffects.NativeMethodInfoPtr_get_SuppressTutorials_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667688);
			TutorialEffects.NativeMethodInfoPtr_set_SuppressTutorials_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667689);
			TutorialEffects.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667690);
			TutorialEffects.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667691);
			TutorialEffects.NativeMethodInfoPtr_ShowingPrompt_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667692);
			TutorialEffects.NativeMethodInfoPtr_RunDelayedTutorialEffect_Public_Virtual_New_Void_DBGTutorialEventCommand_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667693);
			TutorialEffects.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667694);
			TutorialEffects.NativeMethodInfoPtr_runTutorialEffectAfterDuration_Private_IEnumerator_DBGTutorialEventCommand_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667695);
			TutorialEffects.NativeMethodInfoPtr_AddPersistentHint_Private_Void_Int32_IPersistentEffectCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667696);
			TutorialEffects.NativeMethodInfoPtr_ShowHint_Public_Virtual_New_Command_Int32_EntityID_List_1_String_SelectionStageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667697);
			TutorialEffects.NativeMethodInfoPtr_HideSelectionHint_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667698);
			TutorialEffects.NativeMethodInfoPtr_RunSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667699);
			TutorialEffects.NativeMethodInfoPtr_TerminateSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667700);
			TutorialEffects.NativeMethodInfoPtr_Hide_Public_Virtual_New_Command_Int32_SelectionStageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667701);
			TutorialEffects.NativeMethodInfoPtr_deferredHideAction_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667702);
			TutorialEffects.NativeMethodInfoPtr_InvokeTutorialEvent_Public_Virtual_New_Void_EntityID_String_Int32_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667703);
			TutorialEffects.NativeMethodInfoPtr_ShowSelectionHint_Public_Virtual_New_Void_EntityID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667704);
			TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithEntityName_Public_Virtual_New_Command_Int32_String_Int32_String_List_1_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667705);
			TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithGenericLocator_Public_Virtual_New_Command_Int32_String_String_List_1_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667706);
			TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithEntityID_Public_Virtual_New_Command_Int32_EntityID_String_String_List_1_String_EntityComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667707);
			TutorialEffects.NativeMethodInfoPtr_showVisualHighlight_Protected_Virtual_New_IEnumerator_Int32_String_String_IEntityFXLocator_EntityView_List_1_String_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667708);
			TutorialEffects.NativeMethodInfoPtr_ShowGoals_Public_Virtual_New_Command_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667709);
			TutorialEffects.NativeMethodInfoPtr_HideGoals_Public_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667710);
			TutorialEffects.NativeMethodInfoPtr_ShowPrompt_Public_Virtual_New_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667711);
			TutorialEffects.NativeMethodInfoPtr_MoveCamera_Public_Virtual_New_Command_Int32_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667712);
			TutorialEffects.NativeMethodInfoPtr_Focus_Public_Virtual_New_Command_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667713);
			TutorialEffects.NativeMethodInfoPtr_deferredFocusAction_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667714);
			TutorialEffects.NativeMethodInfoPtr_CallToAction_Public_Virtual_New_Command_Int32_String_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667715);
			TutorialEffects.NativeMethodInfoPtr_deferredFindAndRunCallToAction_Private_IEnumerator_Int32_String_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667716);
			TutorialEffects.NativeMethodInfoPtr_runAllCTAs_Private_IEnumerator_List_1_ITutorialCallToAction_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667717);
			TutorialEffects.NativeMethodInfoPtr_RegisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667718);
			TutorialEffects.NativeMethodInfoPtr_UnregisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667719);
			TutorialEffects.NativeMethodInfoPtr_IsCallToActionRegistered_Public_Virtual_New_Boolean_ITutorialCallToAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667720);
			TutorialEffects.NativeMethodInfoPtr_IsCallToActionRunning_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667721);
			TutorialEffects.NativeMethodInfoPtr_IsShowingHint_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667722);
			TutorialEffects.NativeMethodInfoPtr_findViewWithEntityID_Private_EntityView_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667723);
			TutorialEffects.NativeMethodInfoPtr_findViewForEntityName_Private_EntityView_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667724);
			TutorialEffects.NativeMethodInfoPtr_boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_Private_Virtual_Final_New_IEnumerable_1_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667725);
			TutorialEffects.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, 100667726);
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x000772D0 File Offset: 0x000754D0
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0007730C File Offset: 0x0007550C
		public unsafe bool SuppressTutorials
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_get_SuppressTutorials_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_set_SuppressTutorials_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0007734C File Offset: 0x0007554C
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00077388 File Offset: 0x00075588
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000773C8 File Offset: 0x000755C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533671, XrefRangeEnd = 533683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShowingPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_ShowingPrompt_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00077404 File Offset: 0x00075604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533683, XrefRangeEnd = 533715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RunDelayedTutorialEffect(DBGTutorialEventCommand command, MutableAttributes tutorialActionAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tutorialActionAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_RunDelayedTutorialEffect_Public_Virtual_New_Void_DBGTutorialEventCommand_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00077464 File Offset: 0x00075664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533715, XrefRangeEnd = 533720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000774A4 File Offset: 0x000756A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533720, XrefRangeEnd = 533727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runTutorialEffectAfterDuration(DBGTutorialEventCommand command, MutableAttributes actionAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_runTutorialEffectAfterDuration_Private_IEnumerator_DBGTutorialEventCommand_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00077508 File Offset: 0x00075708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 533745, RefRangeEnd = 533748, XrefRangeStart = 533727, XrefRangeEnd = 533745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPersistentHint(int tutorialID, IPersistentEffectCommand hintCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_AddPersistentHint_Private_Void_Int32_IPersistentEffectCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00077558 File Offset: 0x00075758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533748, XrefRangeEnd = 533784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowHint(int tutorialID, EntityID entityID, List<string> vfxTags, SelectionStageData selectionStageData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionStageData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowHint_Public_Virtual_New_Command_Int32_EntityID_List_1_String_SelectionStageData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x000775E8 File Offset: 0x000757E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533784, XrefRangeEnd = 533788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideSelectionHint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_HideSelectionHint_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00077624 File Offset: 0x00075824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533788, XrefRangeEnd = 533794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator RunSelectionScopedActions(ISelectionNode node, Nullable<int> overrideStage = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideStage));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_RunSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00077698 File Offset: 0x00075898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533794, XrefRangeEnd = 533800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator TerminateSelectionScopedActions(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_TerminateSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000776F4 File Offset: 0x000758F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533800, XrefRangeEnd = 533821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command Hide(int tutorialID, SelectionStageData selectionStageData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionStageData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_Hide_Public_Virtual_New_Command_Int32_SelectionStageData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x00077760 File Offset: 0x00075960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533821, XrefRangeEnd = 533826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator deferredHideAction(int tutorialID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_deferredHideAction_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000777AC File Offset: 0x000759AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533826, XrefRangeEnd = 533862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InvokeTutorialEvent(EntityID locationID, string entityName, int viewLayer, List<string> identifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locationID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_InvokeTutorialEvent_Public_Virtual_New_Void_EntityID_String_Int32_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007782C File Offset: 0x00075A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533862, XrefRangeEnd = 533866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowSelectionHint(EntityID location, string anchorName = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(anchorName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowSelectionHint_Public_Virtual_New_Void_EntityID_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007788C File Offset: 0x00075A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533866, XrefRangeEnd = 533876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowVisualHighlightWithEntityName(int tutorialID, string targetEntityName, int viewLayer, string fxName, List<string> vfxTags, EntityComponent fxData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetEntityName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithEntityName_Public_Virtual_New_Command_Int32_String_Int32_String_List_1_String_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0007793C File Offset: 0x00075B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533876, XrefRangeEnd = 533880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowVisualHighlightWithGenericLocator(int tutorialID, string fxName, string anchorName, List<string> vfxTags, EntityComponent fxData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(anchorName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithGenericLocator_Public_Virtual_New_Command_Int32_String_String_List_1_String_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000779E0 File Offset: 0x00075BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533880, XrefRangeEnd = 533890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowVisualHighlightWithEntityID(int tutorialID, EntityID locationID, string fxName, string anchorName, List<string> vfxTags, EntityComponent fxData = null, int viewLayer = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locationID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(anchorName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowVisualHighlightWithEntityID_Public_Virtual_New_Command_Int32_EntityID_String_String_List_1_String_EntityComponent_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00077AA4 File Offset: 0x00075CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533890, XrefRangeEnd = 533901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator showVisualHighlight(int tutorialID, string fxName, string anchorName, IEntityFXLocator fxLocator, EntityView location, List<string> vfxTags, EntityComponent fxData = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(anchorName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxLocator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxTags);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fxData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_showVisualHighlight_Protected_Virtual_New_IEnumerator_Int32_String_String_IEntityFXLocator_EntityView_List_1_String_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00077B6C File Offset: 0x00075D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533901, XrefRangeEnd = 533908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowGoals(DataComposition promptData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowGoals_Public_Virtual_New_Command_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00077BC8 File Offset: 0x00075DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 533908, RefRangeEnd = 533909, XrefRangeStart = 533908, XrefRangeEnd = 533908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command HideGoals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_HideGoals_Public_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00077C08 File Offset: 0x00075E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533909, XrefRangeEnd = 533951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command ShowPrompt(DataComposition promptData, string dialogType, Nullable<int> tutorialID = null, string dialogScope = "", MutableAttributes attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tutorialID));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogScope);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_ShowPrompt_Public_Virtual_New_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00077CB4 File Offset: 0x00075EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533951, XrefRangeEnd = 533955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command MoveCamera(int tutorialID, List<EntityID> targetEntities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_MoveCamera_Public_Virtual_New_Command_Int32_List_1_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00077D20 File Offset: 0x00075F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533955, XrefRangeEnd = 533961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command Focus(int tutorialID, string focusId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(focusId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_Focus_Public_Virtual_New_Command_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00077D8C File Offset: 0x00075F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533961, XrefRangeEnd = 533966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator deferredFocusAction(string focusId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(focusId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_deferredFocusAction_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00077DDC File Offset: 0x00075FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533966, XrefRangeEnd = 533974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Command CallToAction(int tutorialID, string fxName, MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_CallToAction_Public_Virtual_New_Command_Int32_String_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00077E58 File Offset: 0x00076058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533974, XrefRangeEnd = 533981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator deferredFindAndRunCallToAction(int tutorialID, string fxName, MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fxName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_deferredFindAndRunCallToAction_Private_IEnumerator_Int32_String_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00077EC8 File Offset: 0x000760C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533981, XrefRangeEnd = 533988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runAllCTAs(List<ITutorialCallToAction> callToActions, MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callToActions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_runAllCTAs_Private_IEnumerator_List_1_ITutorialCallToAction_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00077F2C File Offset: 0x0007612C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533988, XrefRangeEnd = 534013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterCallToAction(ITutorialCallToAction callToAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callToAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_RegisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00077F7C File Offset: 0x0007617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534013, XrefRangeEnd = 534031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterCallToAction(ITutorialCallToAction callToAction, string overrideIdentifier = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callToAction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_UnregisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00077FDC File Offset: 0x000761DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534031, XrefRangeEnd = 534038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsCallToActionRegistered(ITutorialCallToAction callToAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callToAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_IsCallToActionRegistered_Public_Virtual_New_Boolean_ITutorialCallToAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00078034 File Offset: 0x00076234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534038, XrefRangeEnd = 534049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsCallToActionRunning(string identifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TutorialEffects.NativeMethodInfoPtr_IsCallToActionRunning_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007808C File Offset: 0x0007628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534049, XrefRangeEnd = 534053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsShowingHint(int tutorialID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tutorialID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_IsShowingHint_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x000780D8 File Offset: 0x000762D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534076, RefRangeEnd = 534078, XrefRangeStart = 534053, XrefRangeEnd = 534076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView findViewWithEntityID(EntityID locationID, int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locationID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_findViewWithEntityID_Private_EntityView_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00078138 File Offset: 0x00076338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 534125, RefRangeEnd = 534127, XrefRangeStart = 534078, XrefRangeEnd = 534125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityView findViewForEntityName(string targetEntityName, int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetEntityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_findViewForEntityName_Private_EntityView_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr3) : null;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00078198 File Offset: 0x00076398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534127, XrefRangeEnd = 534149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IPrompt> boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr_boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_Private_Virtual_Final_New_IEnumerable_1_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IPrompt>>(intPtr3) : null;
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000781D8 File Offset: 0x000763D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 534192, RefRangeEnd = 534193, XrefRangeStart = 534149, XrefRangeEnd = 534192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialEffects()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0000ED93 File Offset: 0x0000CF93
		public TutorialEffects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x00078214 File Offset: 0x00076414
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0000ED9C File Offset: 0x0000CF9C
		public unsafe static string DoinkerFXName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialEffects.NativeFieldInfoPtr_DoinkerFXName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialEffects.NativeFieldInfoPtr_DoinkerFXName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00078234 File Offset: 0x00076434
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0000EDAE File Offset: 0x0000CFAE
		public unsafe static int SelectionDoinkerID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TutorialEffects.NativeFieldInfoPtr_SelectionDoinkerID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialEffects.NativeFieldInfoPtr_SelectionDoinkerID, (void*)(&value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x00078250 File Offset: 0x00076450
		// (set) Token: 0x06001B8C RID: 7052 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		public unsafe static int GoalsPromptID
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TutorialEffects.NativeFieldInfoPtr_GoalsPromptID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialEffects.NativeFieldInfoPtr_GoalsPromptID, (void*)(&value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0007826C File Offset: 0x0007646C
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000EDCA File Offset: 0x0000CFCA
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0007829C File Offset: 0x0007649C
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000EDE9 File Offset: 0x0000CFE9
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000782CC File Offset: 0x000764CC
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000EE08 File Offset: 0x0000D008
		public unsafe Dictionary<int, DisplayGenericPrompt> persistentPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_persistentPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DisplayGenericPrompt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_persistentPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x000782FC File Offset: 0x000764FC
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0000EE27 File Offset: 0x0000D027
		public unsafe Dictionary<int, List<IPersistentEffectCommand>> persistentHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_persistentHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<IPersistentEffectCommand>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_persistentHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0007832C File Offset: 0x0007652C
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0000EE46 File Offset: 0x0000D046
		public unsafe List<ValueTuple<int, int, Command>> selectionScopedQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_selectionScopedQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, int, Command>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_selectionScopedQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0007835C File Offset: 0x0007655C
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000EE65 File Offset: 0x0000D065
		public unsafe Dictionary<string, List<ITutorialCallToAction>> registeredCallsToAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_registeredCallsToAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<ITutorialCallToAction>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_registeredCallsToAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0007838C File Offset: 0x0007658C
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000EE84 File Offset: 0x0000D084
		public unsafe List<string> activelyRunningCallsToAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_activelyRunningCallsToAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_activelyRunningCallsToAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000783BC File Offset: 0x000765BC
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000EEA3 File Offset: 0x0000D0A3
		public unsafe Dictionary<int, Coroutine> delayedTutorialEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_delayedTutorialEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr_delayedTutorialEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000783EC File Offset: 0x000765EC
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000EEC2 File Offset: 0x0000D0C2
		public unsafe bool _SuppressTutorials_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr__SuppressTutorials_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr__SuppressTutorials_k__BackingField)) = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00078414 File Offset: 0x00076614
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000EEDD File Offset: 0x0000D0DD
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerFXName;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeFieldInfoPtr_SelectionDoinkerID;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeFieldInfoPtr_GoalsPromptID;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeFieldInfoPtr_persistentPrompts;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeFieldInfoPtr_persistentHints;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeFieldInfoPtr_selectionScopedQueue;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_registeredCallsToAction;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeFieldInfoPtr_activelyRunningCallsToAction;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeFieldInfoPtr_delayedTutorialEffects;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeFieldInfoPtr__SuppressTutorials_k__BackingField;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_get_SuppressTutorials_Public_get_Boolean_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_set_SuppressTutorials_Public_set_Void_Boolean_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_ShowingPrompt_Public_Boolean_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_RunDelayedTutorialEffect_Public_Virtual_New_Void_DBGTutorialEventCommand_MutableAttributes_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_runTutorialEffectAfterDuration_Private_IEnumerator_DBGTutorialEventCommand_MutableAttributes_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_AddPersistentHint_Private_Void_Int32_IPersistentEffectCommand_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr_ShowHint_Public_Virtual_New_Command_Int32_EntityID_List_1_String_SelectionStageData_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_HideSelectionHint_Public_Virtual_New_Void_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_RunSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_Nullable_1_Int32_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_TerminateSelectionScopedActions_Public_Virtual_New_IEnumerator_ISelectionNode_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Command_Int32_SelectionStageData_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_deferredHideAction_Private_IEnumerator_Int32_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTutorialEvent_Public_Virtual_New_Void_EntityID_String_Int32_List_1_String_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_ShowSelectionHint_Public_Virtual_New_Void_EntityID_String_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_ShowVisualHighlightWithEntityName_Public_Virtual_New_Command_Int32_String_Int32_String_List_1_String_EntityComponent_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_ShowVisualHighlightWithGenericLocator_Public_Virtual_New_Command_Int32_String_String_List_1_String_EntityComponent_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr_ShowVisualHighlightWithEntityID_Public_Virtual_New_Command_Int32_EntityID_String_String_List_1_String_EntityComponent_Int32_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_showVisualHighlight_Protected_Virtual_New_IEnumerator_Int32_String_String_IEntityFXLocator_EntityView_List_1_String_EntityComponent_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_ShowGoals_Public_Virtual_New_Command_DataComposition_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_HideGoals_Public_Command_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Public_Virtual_New_Command_DataComposition_String_Nullable_1_Int32_String_MutableAttributes_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_MoveCamera_Public_Virtual_New_Command_Int32_List_1_EntityID_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Virtual_New_Command_Int32_String_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_deferredFocusAction_Private_IEnumerator_String_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_CallToAction_Public_Virtual_New_Command_Int32_String_MutableAttributes_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_deferredFindAndRunCallToAction_Private_IEnumerator_Int32_String_MutableAttributes_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_runAllCTAs_Private_IEnumerator_List_1_ITutorialCallToAction_MutableAttributes_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallToAction_Public_Virtual_New_Void_ITutorialCallToAction_String_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_IsCallToActionRegistered_Public_Virtual_New_Boolean_ITutorialCallToAction_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_IsCallToActionRunning_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_IsShowingHint_Public_Boolean_Int32_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_findViewWithEntityID_Private_EntityView_EntityID_Int32_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_findViewForEntityName_Private_EntityView_String_Int32_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_Private_Virtual_Final_New_IEnumerable_1_IPrompt_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000447 RID: 1095
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060033D2 RID: 13266 RVA: 0x000C32A8 File Offset: 0x000C14A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr);
				TutorialEffects.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9");
				TutorialEffects.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__29_0");
				TutorialEffects.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__29_1");
				TutorialEffects.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__43_0");
				TutorialEffects.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__44_0");
				TutorialEffects.__c.NativeFieldInfoPtr___9__51_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__51_1");
				TutorialEffects.__c.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, "<>9__52_0");
				TutorialEffects.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667728);
				TutorialEffects.__c.NativeMethodInfoPtr__deferredHideAction_b__29_0_Internal_Void_IPersistentEffectCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667729);
				TutorialEffects.__c.NativeMethodInfoPtr__deferredHideAction_b__29_1_Internal_Boolean_IPersistentEffectCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667730);
				TutorialEffects.__c.NativeMethodInfoPtr__deferredFindAndRunCallToAction_b__43_0_Internal_String_ITutorialCallToAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667731);
				TutorialEffects.__c.NativeMethodInfoPtr__runAllCTAs_b__44_0_Internal_Boolean_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667732);
				TutorialEffects.__c.NativeMethodInfoPtr__findViewForEntityName_b__51_1_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667733);
				TutorialEffects.__c.NativeMethodInfoPtr__boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_b__52_0_Internal_IPrompt_DisplayGenericPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr, 100667734);
			}

			// Token: 0x060033D3 RID: 13267 RVA: 0x000C33EC File Offset: 0x000C15EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033D4 RID: 13268 RVA: 0x000C3428 File Offset: 0x000C1628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533142, XrefRangeEnd = 533146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _deferredHideAction_b__29_0(IPersistentEffectCommand vfx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfx);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__deferredHideAction_b__29_0_Internal_Void_IPersistentEffectCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060033D5 RID: 13269 RVA: 0x000C346C File Offset: 0x000C166C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533146, XrefRangeEnd = 533149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _deferredHideAction_b__29_1(IPersistentEffectCommand vfx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(vfx);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__deferredHideAction_b__29_1_Internal_Boolean_IPersistentEffectCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033D6 RID: 13270 RVA: 0x000C34BC File Offset: 0x000C16BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533149, XrefRangeEnd = 533153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _deferredFindAndRunCallToAction_b__43_0(ITutorialCallToAction c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__deferredFindAndRunCallToAction_b__43_0_Internal_String_ITutorialCallToAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060033D7 RID: 13271 RVA: 0x000C3504 File Offset: 0x000C1704
			[CallerCount(0)]
			public unsafe bool _runAllCTAs_b__44_0(Command cta)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cta);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__runAllCTAs_b__44_0_Internal_Boolean_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060033D8 RID: 13272 RVA: 0x000C3554 File Offset: 0x000C1754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533153, XrefRangeEnd = 533154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _findViewForEntityName_b__51_1(KeyValuePair<EntityID, EntityComponent> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__findViewForEntityName_b__51_1_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060033D9 RID: 13273 RVA: 0x000C35AC File Offset: 0x000C17AC
			[CallerCount(0)]
			public unsafe IPrompt _boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_b__52_0(DisplayGenericPrompt p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c.NativeMethodInfoPtr__boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_b__52_0_Internal_IPrompt_DisplayGenericPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr3) : null;
				}
			}

			// Token: 0x060033DA RID: 13274 RVA: 0x0001ABBF File Offset: 0x00018DBF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F25 RID: 3877
			// (get) Token: 0x060033DB RID: 13275 RVA: 0x000C35FC File Offset: 0x000C17FC
			// (set) Token: 0x060033DC RID: 13276 RVA: 0x0001ABC8 File Offset: 0x00018DC8
			public unsafe static TutorialEffects.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F26 RID: 3878
			// (get) Token: 0x060033DD RID: 13277 RVA: 0x000C3624 File Offset: 0x000C1824
			// (set) Token: 0x060033DE RID: 13278 RVA: 0x0001ABDA File Offset: 0x00018DDA
			public unsafe static Action<IPersistentEffectCommand> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IPersistentEffectCommand>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F27 RID: 3879
			// (get) Token: 0x060033DF RID: 13279 RVA: 0x000C364C File Offset: 0x000C184C
			// (set) Token: 0x060033E0 RID: 13280 RVA: 0x0001ABEC File Offset: 0x00018DEC
			public unsafe static Func<IPersistentEffectCommand, bool> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPersistentEffectCommand, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F28 RID: 3880
			// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000C3674 File Offset: 0x000C1874
			// (set) Token: 0x060033E2 RID: 13282 RVA: 0x0001ABFE File Offset: 0x00018DFE
			public unsafe static Func<ITutorialCallToAction, string> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ITutorialCallToAction, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F29 RID: 3881
			// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000C369C File Offset: 0x000C189C
			// (set) Token: 0x060033E4 RID: 13284 RVA: 0x0001AC10 File Offset: 0x00018E10
			public unsafe static Func<Command, bool> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Command, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2A RID: 3882
			// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000C36C4 File Offset: 0x000C18C4
			// (set) Token: 0x060033E6 RID: 13286 RVA: 0x0001AC22 File Offset: 0x00018E22
			public unsafe static Func<KeyValuePair<EntityID, EntityComponent>, EntityID> __9__51_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__51_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, EntityComponent>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__51_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2B RID: 3883
			// (get) Token: 0x060033E7 RID: 13287 RVA: 0x000C36EC File Offset: 0x000C18EC
			// (set) Token: 0x060033E8 RID: 13288 RVA: 0x0001AC34 File Offset: 0x00018E34
			public unsafe static Func<DisplayGenericPrompt, IPrompt> __9__52_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TutorialEffects.__c.NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DisplayGenericPrompt, IPrompt>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TutorialEffects.__c.NativeFieldInfoPtr___9__52_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FF6 RID: 8182
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001FF7 RID: 8183
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04001FF8 RID: 8184
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x04001FF9 RID: 8185
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04001FFA RID: 8186
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x04001FFB RID: 8187
			private static readonly IntPtr NativeFieldInfoPtr___9__51_1;

			// Token: 0x04001FFC RID: 8188
			private static readonly IntPtr NativeFieldInfoPtr___9__52_0;

			// Token: 0x04001FFD RID: 8189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001FFE RID: 8190
			private static readonly IntPtr NativeMethodInfoPtr__deferredHideAction_b__29_0_Internal_Void_IPersistentEffectCommand_0;

			// Token: 0x04001FFF RID: 8191
			private static readonly IntPtr NativeMethodInfoPtr__deferredHideAction_b__29_1_Internal_Boolean_IPersistentEffectCommand_0;

			// Token: 0x04002000 RID: 8192
			private static readonly IntPtr NativeMethodInfoPtr__deferredFindAndRunCallToAction_b__43_0_Internal_String_ITutorialCallToAction_0;

			// Token: 0x04002001 RID: 8193
			private static readonly IntPtr NativeMethodInfoPtr__runAllCTAs_b__44_0_Internal_Boolean_Command_0;

			// Token: 0x04002002 RID: 8194
			private static readonly IntPtr NativeMethodInfoPtr__findViewForEntityName_b__51_1_Internal_EntityID_KeyValuePair_2_EntityID_EntityComponent_0;

			// Token: 0x04002003 RID: 8195
			private static readonly IntPtr NativeMethodInfoPtr__boardgames_tutorials_ITutorialPrompter_GetPersistentPrompts_b__52_0_Internal_IPrompt_DisplayGenericPrompt_0;
		}

		// Token: 0x02000448 RID: 1096
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060033E9 RID: 13289 RVA: 0x000C3714 File Offset: 0x000C1914
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr);
				TutorialEffects.__c__DisplayClass24_0.NativeFieldInfoPtr_effectCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr, "effectCommand");
				TutorialEffects.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr, 100667735);
				TutorialEffects.__c__DisplayClass24_0.NativeMethodInfoPtr__ShowHint_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr, 100667736);
			}

			// Token: 0x060033EA RID: 13290 RVA: 0x000C377C File Offset: 0x000C197C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033EB RID: 13291 RVA: 0x000C37B8 File Offset: 0x000C19B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533154, XrefRangeEnd = 533155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowHint_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass24_0.NativeMethodInfoPtr__ShowHint_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033EC RID: 13292 RVA: 0x0001AC46 File Offset: 0x00018E46
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F2C RID: 3884
			// (get) Token: 0x060033ED RID: 13293 RVA: 0x000C37EC File Offset: 0x000C19EC
			// (set) Token: 0x060033EE RID: 13294 RVA: 0x0001AC4F File Offset: 0x00018E4F
			public unsafe ShowTutorialHint effectCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass24_0.NativeFieldInfoPtr_effectCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowTutorialHint>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass24_0.NativeFieldInfoPtr_effectCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002004 RID: 8196
			private static readonly IntPtr NativeFieldInfoPtr_effectCommand;

			// Token: 0x04002005 RID: 8197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002006 RID: 8198
			private static readonly IntPtr NativeMethodInfoPtr__ShowHint_b__0_Internal_Void_0;
		}

		// Token: 0x02000449 RID: 1097
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060033EF RID: 13295 RVA: 0x000C381C File Offset: 0x000C1A1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr);
				TutorialEffects.__c__DisplayClass35_0.NativeFieldInfoPtr_effectCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr, "effectCommand");
				TutorialEffects.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr, 100667737);
				TutorialEffects.__c__DisplayClass35_0.NativeMethodInfoPtr__showVisualHighlight_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr, 100667738);
			}

			// Token: 0x060033F0 RID: 13296 RVA: 0x000C3884 File Offset: 0x000C1A84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033F1 RID: 13297 RVA: 0x000C38C0 File Offset: 0x000C1AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _showVisualHighlight_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass35_0.NativeMethodInfoPtr__showVisualHighlight_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033F2 RID: 13298 RVA: 0x0001AC6E File Offset: 0x00018E6E
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F2D RID: 3885
			// (get) Token: 0x060033F3 RID: 13299 RVA: 0x000C38F4 File Offset: 0x000C1AF4
			// (set) Token: 0x060033F4 RID: 13300 RVA: 0x0001AC77 File Offset: 0x00018E77
			public unsafe RunVFXKabbage effectCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass35_0.NativeFieldInfoPtr_effectCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunVFXKabbage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass35_0.NativeFieldInfoPtr_effectCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002007 RID: 8199
			private static readonly IntPtr NativeFieldInfoPtr_effectCommand;

			// Token: 0x04002008 RID: 8200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002009 RID: 8201
			private static readonly IntPtr NativeMethodInfoPtr__showVisualHighlight_b__0_Internal_Void_0;
		}

		// Token: 0x0200044A RID: 1098
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060033F5 RID: 13301 RVA: 0x000C3924 File Offset: 0x000C1B24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr);
				TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_displayPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, "displayPrompt");
				TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, "prompt");
				TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, "tutorialID");
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667739);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667740);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667741);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667742);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667743);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667744);
				TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr, 100667745);
			}

			// Token: 0x060033F6 RID: 13302 RVA: 0x000C3A2C File Offset: 0x000C1C2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033F7 RID: 13303 RVA: 0x000C3A68 File Offset: 0x000C1C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowPrompt_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033F8 RID: 13304 RVA: 0x000C3A9C File Offset: 0x000C1C9C
			[CallerCount(0)]
			public unsafe bool _ShowPrompt_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060033F9 RID: 13305 RVA: 0x000C3AD8 File Offset: 0x000C1CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowPrompt_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033FA RID: 13306 RVA: 0x000C3B0C File Offset: 0x000C1D0C
			[CallerCount(0)]
			public unsafe bool _ShowPrompt_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060033FB RID: 13307 RVA: 0x000C3B48 File Offset: 0x000C1D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533155, XrefRangeEnd = 533162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowPrompt_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033FC RID: 13308 RVA: 0x000C3B7C File Offset: 0x000C1D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533162, XrefRangeEnd = 533169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ShowPrompt_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass38_0.NativeMethodInfoPtr__ShowPrompt_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060033FD RID: 13309 RVA: 0x0001AC96 File Offset: 0x00018E96
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F2E RID: 3886
			// (get) Token: 0x060033FE RID: 13310 RVA: 0x000C3BB0 File Offset: 0x000C1DB0
			// (set) Token: 0x060033FF RID: 13311 RVA: 0x0001AC9F File Offset: 0x00018E9F
			public unsafe DisplayGenericPrompt displayPrompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_displayPrompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_displayPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F2F RID: 3887
			// (get) Token: 0x06003400 RID: 13312 RVA: 0x000C3BE0 File Offset: 0x000C1DE0
			// (set) Token: 0x06003401 RID: 13313 RVA: 0x0001ACBE File Offset: 0x00018EBE
			public unsafe TutorialPrompt prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_prompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F30 RID: 3888
			// (get) Token: 0x06003402 RID: 13314 RVA: 0x000C3C10 File Offset: 0x000C1E10
			// (set) Token: 0x06003403 RID: 13315 RVA: 0x0001ACDD File Offset: 0x00018EDD
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F31 RID: 3889
			// (get) Token: 0x06003404 RID: 13316 RVA: 0x000C3C40 File Offset: 0x000C1E40
			// (set) Token: 0x06003405 RID: 13317 RVA: 0x0001ACFC File Offset: 0x00018EFC
			public Nullable<int> tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_tutorialID);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass38_0.NativeFieldInfoPtr_tutorialID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400200A RID: 8202
			private static readonly IntPtr NativeFieldInfoPtr_displayPrompt;

			// Token: 0x0400200B RID: 8203
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x0400200C RID: 8204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400200D RID: 8205
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x0400200E RID: 8206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400200F RID: 8207
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__0_Internal_Void_0;

			// Token: 0x04002010 RID: 8208
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__1_Internal_Boolean_0;

			// Token: 0x04002011 RID: 8209
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__2_Internal_Void_0;

			// Token: 0x04002012 RID: 8210
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__3_Internal_Boolean_0;

			// Token: 0x04002013 RID: 8211
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__4_Internal_Void_0;

			// Token: 0x04002014 RID: 8212
			private static readonly IntPtr NativeMethodInfoPtr__ShowPrompt_b__5_Internal_Void_0;
		}

		// Token: 0x0200044B RID: 1099
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06003406 RID: 13318 RVA: 0x000C3C70 File Offset: 0x000C1E70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr);
				TutorialEffects.__c__DisplayClass51_0.NativeFieldInfoPtr_targetEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr, "targetEntityName");
				TutorialEffects.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr, 100667746);
				TutorialEffects.__c__DisplayClass51_0.NativeMethodInfoPtr__findViewForEntityName_b__0_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr, 100667747);
			}

			// Token: 0x06003407 RID: 13319 RVA: 0x000C3CD8 File Offset: 0x000C1ED8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003408 RID: 13320 RVA: 0x000C3D14 File Offset: 0x000C1F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533169, XrefRangeEnd = 533172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _findViewForEntityName_b__0(KeyValuePair<EntityID, EntityComponent> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects.__c__DisplayClass51_0.NativeMethodInfoPtr__findViewForEntityName_b__0_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003409 RID: 13321 RVA: 0x0001AD2A File Offset: 0x00018F2A
			public __c__DisplayClass51_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F32 RID: 3890
			// (get) Token: 0x0600340A RID: 13322 RVA: 0x000C3D68 File Offset: 0x000C1F68
			// (set) Token: 0x0600340B RID: 13323 RVA: 0x0001AD33 File Offset: 0x00018F33
			public unsafe string targetEntityName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass51_0.NativeFieldInfoPtr_targetEntityName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects.__c__DisplayClass51_0.NativeFieldInfoPtr_targetEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002015 RID: 8213
			private static readonly IntPtr NativeFieldInfoPtr_targetEntityName;

			// Token: 0x04002016 RID: 8214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002017 RID: 8215
			private static readonly IntPtr NativeMethodInfoPtr__findViewForEntityName_b__0_Internal_Boolean_KeyValuePair_2_EntityID_EntityComponent_0;
		}

		// Token: 0x0200044C RID: 1100
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<RunSelectionScopedActions>d__26")]
		public sealed class _RunSelectionScopedActions_d__26 : global::Il2CppSystem.Object
		{
			// Token: 0x0600340C RID: 13324 RVA: 0x000C3D90 File Offset: 0x000C1F90
			// Note: this type is marked as 'beforefieldinit'.
			static _RunSelectionScopedActions_d__26()
			{
				Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<RunSelectionScopedActions>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "<>1__state");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "<>2__current");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "<>4__this");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_overrideStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "overrideStage");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "node");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr__nodeStage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "<nodeStage>5__2");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, "<>7__wrap2");
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667748);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667749);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667750);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667751);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667752);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667753);
				TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr, 100667754);
			}

			// Token: 0x0600340D RID: 13325 RVA: 0x000C3ED4 File Offset: 0x000C20D4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunSelectionScopedActions_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._RunSelectionScopedActions_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600340E RID: 13326 RVA: 0x000C3F1C File Offset: 0x000C211C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 533177, RefRangeEnd = 533178, XrefRangeStart = 533172, XrefRangeEnd = 533177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600340F RID: 13327 RVA: 0x000C3F50 File Offset: 0x000C2150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533178, XrefRangeEnd = 533202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003410 RID: 13328 RVA: 0x000C3F8C File Offset: 0x000C218C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533202, XrefRangeEnd = 533205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x06003411 RID: 13329 RVA: 0x000C3FC0 File Offset: 0x000C21C0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x000C4000 File Offset: 0x000C2200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533205, XrefRangeEnd = 533210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F3B RID: 3899
			// (get) Token: 0x06003413 RID: 13331 RVA: 0x000C4034 File Offset: 0x000C2234
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._RunSelectionScopedActions_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003414 RID: 13332 RVA: 0x0001AD52 File Offset: 0x00018F52
			public _RunSelectionScopedActions_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F33 RID: 3891
			// (get) Token: 0x06003415 RID: 13333 RVA: 0x000C4074 File Offset: 0x000C2274
			// (set) Token: 0x06003416 RID: 13334 RVA: 0x0001AD5B File Offset: 0x00018F5B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F34 RID: 3892
			// (get) Token: 0x06003417 RID: 13335 RVA: 0x000C409C File Offset: 0x000C229C
			// (set) Token: 0x06003418 RID: 13336 RVA: 0x0001AD76 File Offset: 0x00018F76
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F35 RID: 3893
			// (get) Token: 0x06003419 RID: 13337 RVA: 0x000C40CC File Offset: 0x000C22CC
			// (set) Token: 0x0600341A RID: 13338 RVA: 0x0001AD95 File Offset: 0x00018F95
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x0600341B RID: 13339 RVA: 0x000C40FC File Offset: 0x000C22FC
			// (set) Token: 0x0600341C RID: 13340 RVA: 0x0001ADB4 File Offset: 0x00018FB4
			public Nullable<int> overrideStage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_overrideStage);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_overrideStage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x0600341D RID: 13341 RVA: 0x000C412C File Offset: 0x000C232C
			// (set) Token: 0x0600341E RID: 13342 RVA: 0x0001ADE2 File Offset: 0x00018FE2
			public unsafe ISelectionNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x0600341F RID: 13343 RVA: 0x000C415C File Offset: 0x000C235C
			// (set) Token: 0x06003420 RID: 13344 RVA: 0x0001AE01 File Offset: 0x00019001
			public unsafe int _nodeStage_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr__nodeStage_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr__nodeStage_5__2)) = value;
				}
			}

			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x06003421 RID: 13345 RVA: 0x000C4184 File Offset: 0x000C2384
			// (set) Token: 0x06003422 RID: 13346 RVA: 0x0001AE1C File Offset: 0x0001901C
			public List<ValueTuple<int, int, Command>>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___7__wrap2);
					return new List<ValueTuple<int, int, Command>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<int, int, Command>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._RunSelectionScopedActions_d__26.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<int, int, Command>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002018 RID: 8216
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002019 RID: 8217
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400201A RID: 8218
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400201B RID: 8219
			private static readonly IntPtr NativeFieldInfoPtr_overrideStage;

			// Token: 0x0400201C RID: 8220
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x0400201D RID: 8221
			private static readonly IntPtr NativeFieldInfoPtr__nodeStage_5__2;

			// Token: 0x0400201E RID: 8222
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400201F RID: 8223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002020 RID: 8224
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002021 RID: 8225
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002022 RID: 8226
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002023 RID: 8227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002024 RID: 8228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002025 RID: 8229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200044D RID: 1101
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<Start>d__21")]
		public sealed class _Start_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x06003423 RID: 13347 RVA: 0x000C41B4 File Offset: 0x000C23B4
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__21()
			{
				Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<Start>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr);
				TutorialEffects._Start_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, "<>1__state");
				TutorialEffects._Start_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, "<>2__current");
				TutorialEffects._Start_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, "<>4__this");
				TutorialEffects._Start_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667755);
				TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667756);
				TutorialEffects._Start_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667757);
				TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667758);
				TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667759);
				TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr, 100667760);
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x000C4294 File Offset: 0x000C2494
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._Start_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003425 RID: 13349 RVA: 0x000C42DC File Offset: 0x000C24DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003426 RID: 13350 RVA: 0x000C4310 File Offset: 0x000C2510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533210, XrefRangeEnd = 533246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x06003427 RID: 13351 RVA: 0x000C434C File Offset: 0x000C254C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003428 RID: 13352 RVA: 0x000C438C File Offset: 0x000C258C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533246, XrefRangeEnd = 533251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x06003429 RID: 13353 RVA: 0x000C43C0 File Offset: 0x000C25C0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._Start_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600342A RID: 13354 RVA: 0x0001AE4A File Offset: 0x0001904A
			public _Start_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F3C RID: 3900
			// (get) Token: 0x0600342B RID: 13355 RVA: 0x000C4400 File Offset: 0x000C2600
			// (set) Token: 0x0600342C RID: 13356 RVA: 0x0001AE53 File Offset: 0x00019053
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F3D RID: 3901
			// (get) Token: 0x0600342D RID: 13357 RVA: 0x000C4428 File Offset: 0x000C2628
			// (set) Token: 0x0600342E RID: 13358 RVA: 0x0001AE6E File Offset: 0x0001906E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x0600342F RID: 13359 RVA: 0x000C4458 File Offset: 0x000C2658
			// (set) Token: 0x06003430 RID: 13360 RVA: 0x0001AE8D File Offset: 0x0001908D
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._Start_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002026 RID: 8230
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002027 RID: 8231
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002028 RID: 8232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002029 RID: 8233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400202A RID: 8234
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400202B RID: 8235
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400202C RID: 8236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400202D RID: 8237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400202E RID: 8238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200044E RID: 1102
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<TerminateSelectionScopedActions>d__27")]
		public sealed class _TerminateSelectionScopedActions_d__27 : global::Il2CppSystem.Object
		{
			// Token: 0x06003431 RID: 13361 RVA: 0x000C4488 File Offset: 0x000C2688
			// Note: this type is marked as 'beforefieldinit'.
			static _TerminateSelectionScopedActions_d__27()
			{
				Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<TerminateSelectionScopedActions>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, "<>1__state");
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, "<>2__current");
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, "<>4__this");
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, "node");
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, "<>7__wrap1");
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667761);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667762);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667763);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667764);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667765);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667766);
				TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr, 100667767);
			}

			// Token: 0x06003432 RID: 13362 RVA: 0x000C45A4 File Offset: 0x000C27A4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TerminateSelectionScopedActions_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._TerminateSelectionScopedActions_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003433 RID: 13363 RVA: 0x000C45EC File Offset: 0x000C27EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 533256, RefRangeEnd = 533257, XrefRangeStart = 533251, XrefRangeEnd = 533256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003434 RID: 13364 RVA: 0x000C4620 File Offset: 0x000C2820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533257, XrefRangeEnd = 533294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003435 RID: 13365 RVA: 0x000C465C File Offset: 0x000C285C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533294, XrefRangeEnd = 533297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x06003436 RID: 13366 RVA: 0x000C4690 File Offset: 0x000C2890
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003437 RID: 13367 RVA: 0x000C46D0 File Offset: 0x000C28D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533297, XrefRangeEnd = 533302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x06003438 RID: 13368 RVA: 0x000C4704 File Offset: 0x000C2904
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003439 RID: 13369 RVA: 0x0001AEAC File Offset: 0x000190AC
			public _TerminateSelectionScopedActions_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x0600343A RID: 13370 RVA: 0x000C4744 File Offset: 0x000C2944
			// (set) Token: 0x0600343B RID: 13371 RVA: 0x0001AEB5 File Offset: 0x000190B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x0600343C RID: 13372 RVA: 0x000C476C File Offset: 0x000C296C
			// (set) Token: 0x0600343D RID: 13373 RVA: 0x0001AED0 File Offset: 0x000190D0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x0600343E RID: 13374 RVA: 0x000C479C File Offset: 0x000C299C
			// (set) Token: 0x0600343F RID: 13375 RVA: 0x0001AEEF File Offset: 0x000190EF
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x06003440 RID: 13376 RVA: 0x000C47CC File Offset: 0x000C29CC
			// (set) Token: 0x06003441 RID: 13377 RVA: 0x0001AF0E File Offset: 0x0001910E
			public unsafe ISelectionNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x06003442 RID: 13378 RVA: 0x000C47FC File Offset: 0x000C29FC
			// (set) Token: 0x06003443 RID: 13379 RVA: 0x0001AF2D File Offset: 0x0001912D
			public List<Command>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___7__wrap1);
					return new List<Command>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._TerminateSelectionScopedActions_d__27.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400202F RID: 8239
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002030 RID: 8240
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002031 RID: 8241
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002032 RID: 8242
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04002033 RID: 8243
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04002034 RID: 8244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002035 RID: 8245
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002036 RID: 8246
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002037 RID: 8247
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002038 RID: 8248
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002039 RID: 8249
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400203A RID: 8250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200044F RID: 1103
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<deferredFindAndRunCallToAction>d__43")]
		public sealed class _deferredFindAndRunCallToAction_d__43 : global::Il2CppSystem.Object
		{
			// Token: 0x06003444 RID: 13380 RVA: 0x000C482C File Offset: 0x000C2A2C
			// Note: this type is marked as 'beforefieldinit'.
			static _deferredFindAndRunCallToAction_d__43()
			{
				Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<deferredFindAndRunCallToAction>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "<>1__state");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "<>2__current");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "<>4__this");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "fxName");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "attributes");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "tutorialID");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr__callToActions_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, "<callToActions>5__2");
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667768);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667769);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667770);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667771);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667772);
				TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr, 100667773);
			}

			// Token: 0x06003445 RID: 13381 RVA: 0x000C495C File Offset: 0x000C2B5C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _deferredFindAndRunCallToAction_d__43(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._deferredFindAndRunCallToAction_d__43>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003446 RID: 13382 RVA: 0x000C49A4 File Offset: 0x000C2BA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x000C49D8 File Offset: 0x000C2BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533302, XrefRangeEnd = 533378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x06003448 RID: 13384 RVA: 0x000C4A14 File Offset: 0x000C2C14
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003449 RID: 13385 RVA: 0x000C4A54 File Offset: 0x000C2C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533378, XrefRangeEnd = 533383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x0600344A RID: 13386 RVA: 0x000C4A88 File Offset: 0x000C2C88
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600344B RID: 13387 RVA: 0x0001AF5B File Offset: 0x0001915B
			public _deferredFindAndRunCallToAction_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F48 RID: 3912
			// (get) Token: 0x0600344C RID: 13388 RVA: 0x000C4AC8 File Offset: 0x000C2CC8
			// (set) Token: 0x0600344D RID: 13389 RVA: 0x0001AF64 File Offset: 0x00019164
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F49 RID: 3913
			// (get) Token: 0x0600344E RID: 13390 RVA: 0x000C4AF0 File Offset: 0x000C2CF0
			// (set) Token: 0x0600344F RID: 13391 RVA: 0x0001AF7F File Offset: 0x0001917F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4A RID: 3914
			// (get) Token: 0x06003450 RID: 13392 RVA: 0x000C4B20 File Offset: 0x000C2D20
			// (set) Token: 0x06003451 RID: 13393 RVA: 0x0001AF9E File Offset: 0x0001919E
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4B RID: 3915
			// (get) Token: 0x06003452 RID: 13394 RVA: 0x000C4B50 File Offset: 0x000C2D50
			// (set) Token: 0x06003453 RID: 13395 RVA: 0x0001AFBD File Offset: 0x000191BD
			public unsafe string fxName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_fxName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F4C RID: 3916
			// (get) Token: 0x06003454 RID: 13396 RVA: 0x000C4B78 File Offset: 0x000C2D78
			// (set) Token: 0x06003455 RID: 13397 RVA: 0x0001AFDC File Offset: 0x000191DC
			public unsafe MutableAttributes attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4D RID: 3917
			// (get) Token: 0x06003456 RID: 13398 RVA: 0x000C4BA8 File Offset: 0x000C2DA8
			// (set) Token: 0x06003457 RID: 13399 RVA: 0x0001AFFB File Offset: 0x000191FB
			public unsafe int tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_tutorialID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr_tutorialID)) = value;
				}
			}

			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x06003458 RID: 13400 RVA: 0x000C4BD0 File Offset: 0x000C2DD0
			// (set) Token: 0x06003459 RID: 13401 RVA: 0x0001B016 File Offset: 0x00019216
			public unsafe List<ITutorialCallToAction> _callToActions_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr__callToActions_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITutorialCallToAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFindAndRunCallToAction_d__43.NativeFieldInfoPtr__callToActions_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400203B RID: 8251
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400203C RID: 8252
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400203D RID: 8253
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400203E RID: 8254
			private static readonly IntPtr NativeFieldInfoPtr_fxName;

			// Token: 0x0400203F RID: 8255
			private static readonly IntPtr NativeFieldInfoPtr_attributes;

			// Token: 0x04002040 RID: 8256
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04002041 RID: 8257
			private static readonly IntPtr NativeFieldInfoPtr__callToActions_5__2;

			// Token: 0x04002042 RID: 8258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002043 RID: 8259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002044 RID: 8260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002045 RID: 8261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002046 RID: 8262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002047 RID: 8263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000450 RID: 1104
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<deferredFocusAction>d__41")]
		public sealed class _deferredFocusAction_d__41 : global::Il2CppSystem.Object
		{
			// Token: 0x0600345A RID: 13402 RVA: 0x000C4C00 File Offset: 0x000C2E00
			// Note: this type is marked as 'beforefieldinit'.
			static _deferredFocusAction_d__41()
			{
				Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<deferredFocusAction>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr);
				TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, "<>1__state");
				TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, "<>2__current");
				TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr_focusId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, "focusId");
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667774);
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667775);
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667776);
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667777);
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667778);
				TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr, 100667779);
			}

			// Token: 0x0600345B RID: 13403 RVA: 0x000C4CE0 File Offset: 0x000C2EE0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _deferredFocusAction_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._deferredFocusAction_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600345C RID: 13404 RVA: 0x000C4D28 File Offset: 0x000C2F28
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600345D RID: 13405 RVA: 0x000C4D5C File Offset: 0x000C2F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533383, XrefRangeEnd = 533387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x0600345E RID: 13406 RVA: 0x000C4D98 File Offset: 0x000C2F98
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600345F RID: 13407 RVA: 0x000C4DD8 File Offset: 0x000C2FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533387, XrefRangeEnd = 533392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x06003460 RID: 13408 RVA: 0x000C4E0C File Offset: 0x000C300C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredFocusAction_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003461 RID: 13409 RVA: 0x0001B035 File Offset: 0x00019235
			public _deferredFocusAction_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x06003462 RID: 13410 RVA: 0x000C4E4C File Offset: 0x000C304C
			// (set) Token: 0x06003463 RID: 13411 RVA: 0x0001B03E File Offset: 0x0001923E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x06003464 RID: 13412 RVA: 0x000C4E74 File Offset: 0x000C3074
			// (set) Token: 0x06003465 RID: 13413 RVA: 0x0001B059 File Offset: 0x00019259
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x06003466 RID: 13414 RVA: 0x000C4EA4 File Offset: 0x000C30A4
			// (set) Token: 0x06003467 RID: 13415 RVA: 0x0001B078 File Offset: 0x00019278
			public unsafe string focusId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr_focusId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredFocusAction_d__41.NativeFieldInfoPtr_focusId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002048 RID: 8264
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002049 RID: 8265
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400204A RID: 8266
			private static readonly IntPtr NativeFieldInfoPtr_focusId;

			// Token: 0x0400204B RID: 8267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400204C RID: 8268
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400204D RID: 8269
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400204E RID: 8270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400204F RID: 8271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002050 RID: 8272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000451 RID: 1105
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<deferredHideAction>d__29")]
		public sealed class _deferredHideAction_d__29 : global::Il2CppSystem.Object
		{
			// Token: 0x06003468 RID: 13416 RVA: 0x000C4ECC File Offset: 0x000C30CC
			// Note: this type is marked as 'beforefieldinit'.
			static _deferredHideAction_d__29()
			{
				Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<deferredHideAction>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr);
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "<>1__state");
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "<>2__current");
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "<>4__this");
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "tutorialID");
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__displayPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "<displayPrompt>5__2");
				TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__vfxKabbages_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, "<vfxKabbages>5__3");
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667780);
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667781);
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667782);
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667783);
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667784);
				TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr, 100667785);
			}

			// Token: 0x06003469 RID: 13417 RVA: 0x000C4FE8 File Offset: 0x000C31E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _deferredHideAction_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._deferredHideAction_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600346A RID: 13418 RVA: 0x000C5030 File Offset: 0x000C3230
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600346B RID: 13419 RVA: 0x000C5064 File Offset: 0x000C3264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533392, XrefRangeEnd = 533445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F5C RID: 3932
			// (get) Token: 0x0600346C RID: 13420 RVA: 0x000C50A0 File Offset: 0x000C32A0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600346D RID: 13421 RVA: 0x000C50E0 File Offset: 0x000C32E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533445, XrefRangeEnd = 533450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F5D RID: 3933
			// (get) Token: 0x0600346E RID: 13422 RVA: 0x000C5114 File Offset: 0x000C3314
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._deferredHideAction_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600346F RID: 13423 RVA: 0x0001B097 File Offset: 0x00019297
			public _deferredHideAction_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x06003470 RID: 13424 RVA: 0x000C5154 File Offset: 0x000C3354
			// (set) Token: 0x06003471 RID: 13425 RVA: 0x0001B0A0 File Offset: 0x000192A0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x06003472 RID: 13426 RVA: 0x000C517C File Offset: 0x000C337C
			// (set) Token: 0x06003473 RID: 13427 RVA: 0x0001B0BB File Offset: 0x000192BB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x06003474 RID: 13428 RVA: 0x000C51AC File Offset: 0x000C33AC
			// (set) Token: 0x06003475 RID: 13429 RVA: 0x0001B0DA File Offset: 0x000192DA
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x06003476 RID: 13430 RVA: 0x000C51DC File Offset: 0x000C33DC
			// (set) Token: 0x06003477 RID: 13431 RVA: 0x0001B0F9 File Offset: 0x000192F9
			public unsafe int tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr_tutorialID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr_tutorialID)) = value;
				}
			}

			// Token: 0x17000F5A RID: 3930
			// (get) Token: 0x06003478 RID: 13432 RVA: 0x000C5204 File Offset: 0x000C3404
			// (set) Token: 0x06003479 RID: 13433 RVA: 0x0001B114 File Offset: 0x00019314
			public unsafe DisplayGenericPrompt _displayPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__displayPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__displayPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5B RID: 3931
			// (get) Token: 0x0600347A RID: 13434 RVA: 0x000C5234 File Offset: 0x000C3434
			// (set) Token: 0x0600347B RID: 13435 RVA: 0x0001B133 File Offset: 0x00019333
			public unsafe List<IPersistentEffectCommand> _vfxKabbages_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__vfxKabbages_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPersistentEffectCommand>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._deferredHideAction_d__29.NativeFieldInfoPtr__vfxKabbages_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002051 RID: 8273
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002052 RID: 8274
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002053 RID: 8275
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002054 RID: 8276
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04002055 RID: 8277
			private static readonly IntPtr NativeFieldInfoPtr__displayPrompt_5__2;

			// Token: 0x04002056 RID: 8278
			private static readonly IntPtr NativeFieldInfoPtr__vfxKabbages_5__3;

			// Token: 0x04002057 RID: 8279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002058 RID: 8280
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002059 RID: 8281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400205A RID: 8282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400205B RID: 8283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400205C RID: 8284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000452 RID: 1106
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<runAllCTAs>d__44")]
		public sealed class _runAllCTAs_d__44 : global::Il2CppSystem.Object
		{
			// Token: 0x0600347C RID: 13436 RVA: 0x000C5264 File Offset: 0x000C3464
			// Note: this type is marked as 'beforefieldinit'.
			static _runAllCTAs_d__44()
			{
				Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<runAllCTAs>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr);
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "<>1__state");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "<>2__current");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_callToActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "callToActions");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "attributes");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "<>4__this");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__ctas_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "<ctas>5__2");
				TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__coroutines_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, "<coroutines>5__3");
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667786);
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667787);
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667788);
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667789);
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667790);
				TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr, 100667791);
			}

			// Token: 0x0600347D RID: 13437 RVA: 0x000C5394 File Offset: 0x000C3594
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runAllCTAs_d__44(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._runAllCTAs_d__44>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600347E RID: 13438 RVA: 0x000C53DC File Offset: 0x000C35DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600347F RID: 13439 RVA: 0x000C5410 File Offset: 0x000C3610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533450, XrefRangeEnd = 533530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F65 RID: 3941
			// (get) Token: 0x06003480 RID: 13440 RVA: 0x000C544C File Offset: 0x000C364C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003481 RID: 13441 RVA: 0x000C548C File Offset: 0x000C368C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533530, XrefRangeEnd = 533535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F66 RID: 3942
			// (get) Token: 0x06003482 RID: 13442 RVA: 0x000C54C0 File Offset: 0x000C36C0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runAllCTAs_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003483 RID: 13443 RVA: 0x0001B152 File Offset: 0x00019352
			public _runAllCTAs_d__44(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F5E RID: 3934
			// (get) Token: 0x06003484 RID: 13444 RVA: 0x000C5500 File Offset: 0x000C3700
			// (set) Token: 0x06003485 RID: 13445 RVA: 0x0001B15B File Offset: 0x0001935B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F5F RID: 3935
			// (get) Token: 0x06003486 RID: 13446 RVA: 0x000C5528 File Offset: 0x000C3728
			// (set) Token: 0x06003487 RID: 13447 RVA: 0x0001B176 File Offset: 0x00019376
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F60 RID: 3936
			// (get) Token: 0x06003488 RID: 13448 RVA: 0x000C5558 File Offset: 0x000C3758
			// (set) Token: 0x06003489 RID: 13449 RVA: 0x0001B195 File Offset: 0x00019395
			public unsafe List<ITutorialCallToAction> callToActions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_callToActions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITutorialCallToAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_callToActions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F61 RID: 3937
			// (get) Token: 0x0600348A RID: 13450 RVA: 0x000C5588 File Offset: 0x000C3788
			// (set) Token: 0x0600348B RID: 13451 RVA: 0x0001B1B4 File Offset: 0x000193B4
			public unsafe MutableAttributes attributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_attributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F62 RID: 3938
			// (get) Token: 0x0600348C RID: 13452 RVA: 0x000C55B8 File Offset: 0x000C37B8
			// (set) Token: 0x0600348D RID: 13453 RVA: 0x0001B1D3 File Offset: 0x000193D3
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F63 RID: 3939
			// (get) Token: 0x0600348E RID: 13454 RVA: 0x000C55E8 File Offset: 0x000C37E8
			// (set) Token: 0x0600348F RID: 13455 RVA: 0x0001B1F2 File Offset: 0x000193F2
			public unsafe List<Command> _ctas_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__ctas_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__ctas_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F64 RID: 3940
			// (get) Token: 0x06003490 RID: 13456 RVA: 0x000C5618 File Offset: 0x000C3818
			// (set) Token: 0x06003491 RID: 13457 RVA: 0x0001B211 File Offset: 0x00019411
			public unsafe List<Coroutine> _coroutines_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__coroutines_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Coroutine>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runAllCTAs_d__44.NativeFieldInfoPtr__coroutines_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400205D RID: 8285
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400205E RID: 8286
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400205F RID: 8287
			private static readonly IntPtr NativeFieldInfoPtr_callToActions;

			// Token: 0x04002060 RID: 8288
			private static readonly IntPtr NativeFieldInfoPtr_attributes;

			// Token: 0x04002061 RID: 8289
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002062 RID: 8290
			private static readonly IntPtr NativeFieldInfoPtr__ctas_5__2;

			// Token: 0x04002063 RID: 8291
			private static readonly IntPtr NativeFieldInfoPtr__coroutines_5__3;

			// Token: 0x04002064 RID: 8292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002065 RID: 8293
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002066 RID: 8294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002067 RID: 8295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002068 RID: 8296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002069 RID: 8297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000453 RID: 1107
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<runTutorialEffectAfterDuration>d__22")]
		public sealed class _runTutorialEffectAfterDuration_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06003492 RID: 13458 RVA: 0x000C5648 File Offset: 0x000C3848
			// Note: this type is marked as 'beforefieldinit'.
			static _runTutorialEffectAfterDuration_d__22()
			{
				Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<runTutorialEffectAfterDuration>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "<>1__state");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "<>2__current");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_actionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "actionAttributes");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "<>4__this");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "command");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__tutorialDelaySeconds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "<tutorialDelaySeconds>5__2");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__currentRunDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, "<currentRunDuration>5__3");
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667792);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667793);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667794);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667795);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667796);
				TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr, 100667797);
			}

			// Token: 0x06003493 RID: 13459 RVA: 0x000C5778 File Offset: 0x000C3978
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runTutorialEffectAfterDuration_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._runTutorialEffectAfterDuration_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003494 RID: 13460 RVA: 0x000C57C0 File Offset: 0x000C39C0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003495 RID: 13461 RVA: 0x000C57F4 File Offset: 0x000C39F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533535, XrefRangeEnd = 533549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F6E RID: 3950
			// (get) Token: 0x06003496 RID: 13462 RVA: 0x000C5830 File Offset: 0x000C3A30
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003497 RID: 13463 RVA: 0x000C5870 File Offset: 0x000C3A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533549, XrefRangeEnd = 533554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F6F RID: 3951
			// (get) Token: 0x06003498 RID: 13464 RVA: 0x000C58A4 File Offset: 0x000C3AA4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003499 RID: 13465 RVA: 0x0001B230 File Offset: 0x00019430
			public _runTutorialEffectAfterDuration_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F67 RID: 3943
			// (get) Token: 0x0600349A RID: 13466 RVA: 0x000C58E4 File Offset: 0x000C3AE4
			// (set) Token: 0x0600349B RID: 13467 RVA: 0x0001B239 File Offset: 0x00019439
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F68 RID: 3944
			// (get) Token: 0x0600349C RID: 13468 RVA: 0x000C590C File Offset: 0x000C3B0C
			// (set) Token: 0x0600349D RID: 13469 RVA: 0x0001B254 File Offset: 0x00019454
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F69 RID: 3945
			// (get) Token: 0x0600349E RID: 13470 RVA: 0x000C593C File Offset: 0x000C3B3C
			// (set) Token: 0x0600349F RID: 13471 RVA: 0x0001B273 File Offset: 0x00019473
			public unsafe MutableAttributes actionAttributes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_actionAttributes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_actionAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6A RID: 3946
			// (get) Token: 0x060034A0 RID: 13472 RVA: 0x000C596C File Offset: 0x000C3B6C
			// (set) Token: 0x060034A1 RID: 13473 RVA: 0x0001B292 File Offset: 0x00019492
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6B RID: 3947
			// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000C599C File Offset: 0x000C3B9C
			// (set) Token: 0x060034A3 RID: 13475 RVA: 0x0001B2B1 File Offset: 0x000194B1
			public unsafe DBGTutorialEventCommand command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTutorialEventCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6C RID: 3948
			// (get) Token: 0x060034A4 RID: 13476 RVA: 0x000C59CC File Offset: 0x000C3BCC
			// (set) Token: 0x060034A5 RID: 13477 RVA: 0x0001B2D0 File Offset: 0x000194D0
			public unsafe float _tutorialDelaySeconds_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__tutorialDelaySeconds_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__tutorialDelaySeconds_5__2)) = value;
				}
			}

			// Token: 0x17000F6D RID: 3949
			// (get) Token: 0x060034A6 RID: 13478 RVA: 0x000C59F4 File Offset: 0x000C3BF4
			// (set) Token: 0x060034A7 RID: 13479 RVA: 0x0001B2EB File Offset: 0x000194EB
			public unsafe float _currentRunDuration_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__currentRunDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._runTutorialEffectAfterDuration_d__22.NativeFieldInfoPtr__currentRunDuration_5__3)) = value;
				}
			}

			// Token: 0x0400206A RID: 8298
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400206B RID: 8299
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400206C RID: 8300
			private static readonly IntPtr NativeFieldInfoPtr_actionAttributes;

			// Token: 0x0400206D RID: 8301
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400206E RID: 8302
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400206F RID: 8303
			private static readonly IntPtr NativeFieldInfoPtr__tutorialDelaySeconds_5__2;

			// Token: 0x04002070 RID: 8304
			private static readonly IntPtr NativeFieldInfoPtr__currentRunDuration_5__3;

			// Token: 0x04002071 RID: 8305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002072 RID: 8306
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002073 RID: 8307
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002074 RID: 8308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002075 RID: 8309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002076 RID: 8310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000454 RID: 1108
		[ObfuscatedName("boardgames.match.tutorial.TutorialEffects+<showVisualHighlight>d__35")]
		public sealed class _showVisualHighlight_d__35 : global::Il2CppSystem.Object
		{
			// Token: 0x060034A8 RID: 13480 RVA: 0x000C5A1C File Offset: 0x000C3C1C
			// Note: this type is marked as 'beforefieldinit'.
			static _showVisualHighlight_d__35()
			{
				Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialEffects>.NativeClassPtr, "<showVisualHighlight>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr);
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "<>1__state");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "<>2__current");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "fxLocator");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "location");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "fxName");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_anchorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "anchorName");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_vfxTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "vfxTags");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "<>8__1");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "fxData");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "<>4__this");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_tutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "tutorialID");
				TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr__block_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, "<block>5__2");
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667798);
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667799);
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667800);
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667801);
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667802);
				TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr, 100667803);
			}

			// Token: 0x060034A9 RID: 13481 RVA: 0x000C5BB0 File Offset: 0x000C3DB0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _showVisualHighlight_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEffects._showVisualHighlight_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060034AA RID: 13482 RVA: 0x000C5BF8 File Offset: 0x000C3DF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060034AB RID: 13483 RVA: 0x000C5C2C File Offset: 0x000C3E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533554, XrefRangeEnd = 533661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x060034AC RID: 13484 RVA: 0x000C5C68 File Offset: 0x000C3E68
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034AD RID: 13485 RVA: 0x000C5CA8 File Offset: 0x000C3EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533661, XrefRangeEnd = 533671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x060034AE RID: 13486 RVA: 0x000C5CDC File Offset: 0x000C3EDC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEffects._showVisualHighlight_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060034AF RID: 13487 RVA: 0x0001B306 File Offset: 0x00019506
			public _showVisualHighlight_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000C5D1C File Offset: 0x000C3F1C
			// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0001B30F File Offset: 0x0001950F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000C5D44 File Offset: 0x000C3F44
			// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0001B32A File Offset: 0x0001952A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F72 RID: 3954
			// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000C5D74 File Offset: 0x000C3F74
			// (set) Token: 0x060034B5 RID: 13493 RVA: 0x0001B349 File Offset: 0x00019549
			public unsafe IEntityFXLocator fxLocator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxLocator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityFXLocator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x060034B6 RID: 13494 RVA: 0x000C5DA4 File Offset: 0x000C3FA4
			// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0001B368 File Offset: 0x00019568
			public unsafe EntityView location
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_location);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_location), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000C5DD4 File Offset: 0x000C3FD4
			// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0001B387 File Offset: 0x00019587
			public unsafe string fxName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x060034BA RID: 13498 RVA: 0x000C5DFC File Offset: 0x000C3FFC
			// (set) Token: 0x060034BB RID: 13499 RVA: 0x0001B3A6 File Offset: 0x000195A6
			public unsafe string anchorName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_anchorName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_anchorName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x060034BC RID: 13500 RVA: 0x000C5E24 File Offset: 0x000C4024
			// (set) Token: 0x060034BD RID: 13501 RVA: 0x0001B3C5 File Offset: 0x000195C5
			public unsafe List<string> vfxTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_vfxTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_vfxTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F77 RID: 3959
			// (get) Token: 0x060034BE RID: 13502 RVA: 0x000C5E54 File Offset: 0x000C4054
			// (set) Token: 0x060034BF RID: 13503 RVA: 0x0001B3E4 File Offset: 0x000195E4
			public unsafe TutorialEffects.__c__DisplayClass35_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x060034C0 RID: 13504 RVA: 0x000C5E84 File Offset: 0x000C4084
			// (set) Token: 0x060034C1 RID: 13505 RVA: 0x0001B403 File Offset: 0x00019603
			public unsafe EntityComponent fxData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_fxData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F79 RID: 3961
			// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000C5EB4 File Offset: 0x000C40B4
			// (set) Token: 0x060034C3 RID: 13507 RVA: 0x0001B422 File Offset: 0x00019622
			public unsafe TutorialEffects __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7A RID: 3962
			// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000C5EE4 File Offset: 0x000C40E4
			// (set) Token: 0x060034C5 RID: 13509 RVA: 0x0001B441 File Offset: 0x00019641
			public unsafe int tutorialID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_tutorialID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr_tutorialID)) = value;
				}
			}

			// Token: 0x17000F7B RID: 3963
			// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000C5F0C File Offset: 0x000C410C
			// (set) Token: 0x060034C7 RID: 13511 RVA: 0x0001B45C File Offset: 0x0001965C
			public unsafe IEnumerator _block_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr__block_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEffects._showVisualHighlight_d__35.NativeFieldInfoPtr__block_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002077 RID: 8311
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002078 RID: 8312
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002079 RID: 8313
			private static readonly IntPtr NativeFieldInfoPtr_fxLocator;

			// Token: 0x0400207A RID: 8314
			private static readonly IntPtr NativeFieldInfoPtr_location;

			// Token: 0x0400207B RID: 8315
			private static readonly IntPtr NativeFieldInfoPtr_fxName;

			// Token: 0x0400207C RID: 8316
			private static readonly IntPtr NativeFieldInfoPtr_anchorName;

			// Token: 0x0400207D RID: 8317
			private static readonly IntPtr NativeFieldInfoPtr_vfxTags;

			// Token: 0x0400207E RID: 8318
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400207F RID: 8319
			private static readonly IntPtr NativeFieldInfoPtr_fxData;

			// Token: 0x04002080 RID: 8320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002081 RID: 8321
			private static readonly IntPtr NativeFieldInfoPtr_tutorialID;

			// Token: 0x04002082 RID: 8322
			private static readonly IntPtr NativeFieldInfoPtr__block_5__2;

			// Token: 0x04002083 RID: 8323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002084 RID: 8324
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002085 RID: 8325
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002086 RID: 8326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002087 RID: 8327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002088 RID: 8328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
