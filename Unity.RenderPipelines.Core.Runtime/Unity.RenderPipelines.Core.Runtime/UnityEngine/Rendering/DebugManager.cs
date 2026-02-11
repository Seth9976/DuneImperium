using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Rendering.UI;

namespace UnityEngine.Rendering
{
	// Token: 0x02000063 RID: 99
	public sealed class DebugManager : Object
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00026F20 File Offset: 0x00025120
		// Note: this type is marked as 'beforefieldinit'.
		static DebugManager()
		{
			Il2CppClassPointerStore<DebugManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugManager>.NativeClassPtr);
			DebugManager.NativeFieldInfoPtr_kEnableDebugBtn1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kEnableDebugBtn1");
			DebugManager.NativeFieldInfoPtr_kEnableDebugBtn2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kEnableDebugBtn2");
			DebugManager.NativeFieldInfoPtr_kDebugPreviousBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kDebugPreviousBtn");
			DebugManager.NativeFieldInfoPtr_kDebugNextBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kDebugNextBtn");
			DebugManager.NativeFieldInfoPtr_kValidateBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kValidateBtn");
			DebugManager.NativeFieldInfoPtr_kPersistentBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kPersistentBtn");
			DebugManager.NativeFieldInfoPtr_kDPadVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kDPadVertical");
			DebugManager.NativeFieldInfoPtr_kDPadHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kDPadHorizontal");
			DebugManager.NativeFieldInfoPtr_kMultiplierBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kMultiplierBtn");
			DebugManager.NativeFieldInfoPtr_kResetBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kResetBtn");
			DebugManager.NativeFieldInfoPtr_kEnableDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "kEnableDebug");
			DebugManager.NativeFieldInfoPtr_m_DebugActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_DebugActions");
			DebugManager.NativeFieldInfoPtr_m_DebugActionStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_DebugActionStates");
			DebugManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "s_Instance");
			DebugManager.NativeFieldInfoPtr_m_ReadOnlyPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_ReadOnlyPanels");
			DebugManager.NativeFieldInfoPtr_m_Panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_Panels");
			DebugManager.NativeFieldInfoPtr_onDisplayRuntimeUIChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "onDisplayRuntimeUIChanged");
			DebugManager.NativeFieldInfoPtr_onSetDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "onSetDirty");
			DebugManager.NativeFieldInfoPtr_resetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "resetData");
			DebugManager.NativeFieldInfoPtr_refreshEditorRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "refreshEditorRequested");
			DebugManager.NativeFieldInfoPtr_m_RequestedPanelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_RequestedPanelIndex");
			DebugManager.NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_Root");
			DebugManager.NativeFieldInfoPtr_m_RootUICanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_RootUICanvas");
			DebugManager.NativeFieldInfoPtr_m_PersistentRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_PersistentRoot");
			DebugManager.NativeFieldInfoPtr_m_RootUIPersistentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_RootUIPersistentCanvas");
			DebugManager.NativeFieldInfoPtr_windowStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "windowStateChanged");
			DebugManager.NativeFieldInfoPtr_editorUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "editorUIState");
			DebugManager.NativeFieldInfoPtr_m_EnableRuntimeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "m_EnableRuntimeUI");
			DebugManager.NativeFieldInfoPtr_runtimeUIState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "runtimeUIState");
			DebugManager.NativeMethodInfoPtr_RegisterActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664217);
			DebugManager.NativeMethodInfoPtr_EnableInputActions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664218);
			DebugManager.NativeMethodInfoPtr_AddAction_Private_Void_DebugAction_DebugActionDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664219);
			DebugManager.NativeMethodInfoPtr_SampleAction_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664220);
			DebugManager.NativeMethodInfoPtr_UpdateAction_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664221);
			DebugManager.NativeMethodInfoPtr_UpdateActions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664222);
			DebugManager.NativeMethodInfoPtr_GetAction_Internal_Single_DebugAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664223);
			DebugManager.NativeMethodInfoPtr_GetActionToggleDebugMenuWithTouch_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664224);
			DebugManager.NativeMethodInfoPtr_GetActionReleaseScrollTarget_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664225);
			DebugManager.NativeMethodInfoPtr_RegisterInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664226);
			DebugManager.NativeMethodInfoPtr_get_instance_Public_Static_get_DebugManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664227);
			DebugManager.NativeMethodInfoPtr_UpdateReadOnlyCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664228);
			DebugManager.NativeMethodInfoPtr_get_panels_Public_get_ReadOnlyCollection_1_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664229);
			DebugManager.NativeMethodInfoPtr_add_onDisplayRuntimeUIChanged_Public_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664230);
			DebugManager.NativeMethodInfoPtr_remove_onDisplayRuntimeUIChanged_Public_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664231);
			DebugManager.NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664232);
			DebugManager.NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664233);
			DebugManager.NativeMethodInfoPtr_add_resetData_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664234);
			DebugManager.NativeMethodInfoPtr_remove_resetData_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664235);
			DebugManager.NativeMethodInfoPtr_get_isAnyDebugUIActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664236);
			DebugManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664237);
			DebugManager.NativeMethodInfoPtr_RefreshEditor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664238);
			DebugManager.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664239);
			DebugManager.NativeMethodInfoPtr_ReDrawOnScreenDebug_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664240);
			DebugManager.NativeMethodInfoPtr_RegisterData_Public_Void_IDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664241);
			DebugManager.NativeMethodInfoPtr_UnregisterData_Public_Void_IDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664242);
			DebugManager.NativeMethodInfoPtr_GetState_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664243);
			DebugManager.NativeMethodInfoPtr_RegisterRootCanvas_Internal_Void_DebugUIHandlerCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664244);
			DebugManager.NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664245);
			DebugManager.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664246);
			DebugManager.NativeMethodInfoPtr_EnsurePersistentCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664247);
			DebugManager.NativeMethodInfoPtr_TogglePersistent_Internal_Void_Widget_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664248);
			DebugManager.NativeMethodInfoPtr_OnPanelDirty_Private_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664249);
			DebugManager.NativeMethodInfoPtr_PanelIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664250);
			DebugManager.NativeMethodInfoPtr_PanelDiplayName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664251);
			DebugManager.NativeMethodInfoPtr_RequestEditorWindowPanelIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664252);
			DebugManager.NativeMethodInfoPtr_GetRequestedEditorWindowPanelIndex_Internal_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664253);
			DebugManager.NativeMethodInfoPtr_GetPanel_Public_Panel_String_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664254);
			DebugManager.NativeMethodInfoPtr_FindPanelIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664255);
			DebugManager.NativeMethodInfoPtr_RemovePanel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664256);
			DebugManager.NativeMethodInfoPtr_RemovePanel_Public_Void_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664257);
			DebugManager.NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_Widget_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664258);
			DebugManager.NativeMethodInfoPtr_GetItemsFromContainer_Internal_Il2CppReferenceArray_1_Widget_Flags_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664259);
			DebugManager.NativeMethodInfoPtr_GetItem_Public_Widget_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664260);
			DebugManager.NativeMethodInfoPtr_GetItem_Private_Widget_String_IContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664261);
			DebugManager.NativeMethodInfoPtr_add_windowStateChanged_Public_Static_add_Void_Action_2_UIMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664262);
			DebugManager.NativeMethodInfoPtr_remove_windowStateChanged_Public_Static_rem_Void_Action_2_UIMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664263);
			DebugManager.NativeMethodInfoPtr_get_displayEditorUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664264);
			DebugManager.NativeMethodInfoPtr_set_displayEditorUI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664265);
			DebugManager.NativeMethodInfoPtr_get_enableRuntimeUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664266);
			DebugManager.NativeMethodInfoPtr_set_enableRuntimeUI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664267);
			DebugManager.NativeMethodInfoPtr_get_displayRuntimeUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664268);
			DebugManager.NativeMethodInfoPtr_set_displayRuntimeUI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664269);
			DebugManager.NativeMethodInfoPtr_get_displayPersistentRuntimeUI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664270);
			DebugManager.NativeMethodInfoPtr_set_displayPersistentRuntimeUI_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664271);
			DebugManager.NativeMethodInfoPtr_ToggleEditorUI_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, 100664272);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000275F4 File Offset: 0x000257F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962591, XrefRangeEnd = 962730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RegisterActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00027628 File Offset: 0x00025828
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInputActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_EnableInputActions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002765C File Offset: 0x0002585C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 962748, RefRangeEnd = 962757, XrefRangeStart = 962730, XrefRangeEnd = 962748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAction(DebugAction action, DebugActionDesc desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_AddAction_Private_Void_DebugAction_DebugActionDesc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000276AC File Offset: 0x000258AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 962780, RefRangeEnd = 962782, XrefRangeStart = 962757, XrefRangeEnd = 962780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleAction(int actionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_SampleAction_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000276EC File Offset: 0x000258EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962782, XrefRangeEnd = 962783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAction(int actionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref actionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_UpdateAction_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0002772C File Offset: 0x0002592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962783, XrefRangeEnd = 962786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_UpdateActions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00027760 File Offset: 0x00025960
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 962786, RefRangeEnd = 962794, XrefRangeStart = 962786, XrefRangeEnd = 962786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAction(DebugAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetAction_Internal_Single_DebugAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000277AC File Offset: 0x000259AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962794, XrefRangeEnd = 962807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetActionToggleDebugMenuWithTouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetActionToggleDebugMenuWithTouch_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000277E8 File Offset: 0x000259E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962807, XrefRangeEnd = 962811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetActionReleaseScrollTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetActionReleaseScrollTarget_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00027824 File Offset: 0x00025A24
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RegisterInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00027858 File Offset: 0x00025A58
		public unsafe static DebugManager instance
		{
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 962819, RefRangeEnd = 962870, XrefRangeStart = 962811, XrefRangeEnd = 962819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_instance_Public_Static_get_DebugManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugManager>(intPtr3) : null;
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0002788C File Offset: 0x00025A8C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 962898, RefRangeEnd = 962903, XrefRangeStart = 962870, XrefRangeEnd = 962898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateReadOnlyCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_UpdateReadOnlyCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000278C0 File Offset: 0x00025AC0
		public unsafe ReadOnlyCollection<DebugUI.Panel> panels
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 962904, RefRangeEnd = 962905, XrefRangeStart = 962903, XrefRangeEnd = 962904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_panels_Public_get_ReadOnlyCollection_1_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<DebugUI.Panel>>(intPtr3) : null;
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00027900 File Offset: 0x00025B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962905, XrefRangeEnd = 962910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onDisplayRuntimeUIChanged(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_add_onDisplayRuntimeUIChanged_Public_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00027944 File Offset: 0x00025B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962910, XrefRangeEnd = 962915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onDisplayRuntimeUIChanged(Action<bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_remove_onDisplayRuntimeUIChanged_Public_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00027988 File Offset: 0x00025B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962915, XrefRangeEnd = 962919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onSetDirty(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000279CC File Offset: 0x00025BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962919, XrefRangeEnd = 962923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onSetDirty(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00027A10 File Offset: 0x00025C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962923, XrefRangeEnd = 962927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_resetData(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_add_resetData_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00027A54 File Offset: 0x00025C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962927, XrefRangeEnd = 962931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_resetData(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_remove_resetData_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00027A98 File Offset: 0x00025C98
		public unsafe bool isAnyDebugUIActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962931, XrefRangeEnd = 962932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_isAnyDebugUIActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00027AD4 File Offset: 0x00025CD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 962981, RefRangeEnd = 962982, XrefRangeStart = 962932, XrefRangeEnd = 962981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00027B10 File Offset: 0x00025D10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 532994, RefRangeEnd = 532995, XrefRangeStart = 532994, XrefRangeEnd = 532995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RefreshEditor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00027B44 File Offset: 0x00025D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 962984, RefRangeEnd = 962985, XrefRangeStart = 962982, XrefRangeEnd = 962984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00027B78 File Offset: 0x00025D78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 962987, RefRangeEnd = 962992, XrefRangeStart = 962985, XrefRangeEnd = 962987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReDrawOnScreenDebug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_ReDrawOnScreenDebug_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00027BAC File Offset: 0x00025DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 962999, RefRangeEnd = 963000, XrefRangeStart = 962992, XrefRangeEnd = 962999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterData(IDebugData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RegisterData_Public_Void_IDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00027BF0 File Offset: 0x00025DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963000, XrefRangeEnd = 963007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterData(IDebugData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_UnregisterData_Public_Void_IDebugData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00027C34 File Offset: 0x00025E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963021, RefRangeEnd = 963023, XrefRangeStart = 963007, XrefRangeEnd = 963021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetState_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00027C70 File Offset: 0x00025E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963027, RefRangeEnd = 963028, XrefRangeStart = 963023, XrefRangeEnd = 963027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterRootCanvas(DebugUIHandlerCanvas root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RegisterRootCanvas_Internal_Void_DebugUIHandlerCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00027CB4 File Offset: 0x00025EB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 963030, RefRangeEnd = 963039, XrefRangeStart = 963028, XrefRangeEnd = 963030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSelection(DebugUIHandlerWidget widget, bool fromNext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromNext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00027D04 File Offset: 0x00025F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963044, RefRangeEnd = 963045, XrefRangeStart = 963039, XrefRangeEnd = 963044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScrollTarget(DebugUIHandlerWidget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00027D48 File Offset: 0x00025F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963081, RefRangeEnd = 963083, XrefRangeStart = 963045, XrefRangeEnd = 963081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsurePersistentCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_EnsurePersistentCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00027D7C File Offset: 0x00025F7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963140, RefRangeEnd = 963142, XrefRangeStart = 963083, XrefRangeEnd = 963140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TogglePersistent(DebugUI.Widget widget, Nullable<int> forceTupleIndex = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forceTupleIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_TogglePersistent_Internal_Void_Widget_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00027DD8 File Offset: 0x00025FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963142, XrefRangeEnd = 963143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDirty(DebugUI.Panel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_OnPanelDirty_Private_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00027E1C File Offset: 0x0002601C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963151, RefRangeEnd = 963152, XrefRangeStart = 963143, XrefRangeEnd = 963151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PanelIndex(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_PanelIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00027E6C File Offset: 0x0002606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963152, XrefRangeEnd = 963157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PanelDiplayName(int panelIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref panelIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_PanelDiplayName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00027EB0 File Offset: 0x000260B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963160, RefRangeEnd = 963161, XrefRangeStart = 963157, XrefRangeEnd = 963160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestEditorWindowPanelIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RequestEditorWindowPanelIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00027EF0 File Offset: 0x000260F0
		[CallerCount(0)]
		public unsafe Nullable<int> GetRequestedEditorWindowPanelIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetRequestedEditorWindowPanelIndex_Internal_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00027F28 File Offset: 0x00026128
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 963203, RefRangeEnd = 963210, XrefRangeStart = 963161, XrefRangeEnd = 963203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUI.Panel GetPanel(string displayName, bool createIfNull = false, int groupIndex = 0, bool overrideIfExist = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createIfNull;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref groupIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideIfExist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetPanel_Public_Panel_String_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Panel>(intPtr3) : null;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00027FA4 File Offset: 0x000261A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963210, XrefRangeEnd = 963225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindPanelIndex(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_FindPanelIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00027FF4 File Offset: 0x000261F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 963253, RefRangeEnd = 963256, XrefRangeStart = 963225, XrefRangeEnd = 963253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePanel(string displayName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RemovePanel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00028038 File Offset: 0x00026238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963256, XrefRangeEnd = 963260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePanel(DebugUI.Panel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_RemovePanel_Public_Void_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0002807C File Offset: 0x0002627C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 963293, RefRangeEnd = 963294, XrefRangeStart = 963260, XrefRangeEnd = 963293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DebugUI.Widget> GetItems(DebugUI.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_Widget_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr3) : null;
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000280C8 File Offset: 0x000262C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963339, RefRangeEnd = 963341, XrefRangeStart = 963294, XrefRangeEnd = 963339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DebugUI.Widget> GetItemsFromContainer(DebugUI.Flags flags, DebugUI.IContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetItemsFromContainer_Internal_Il2CppReferenceArray_1_Widget_Flags_IContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugUI.Widget>>(intPtr3) : null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00028128 File Offset: 0x00026328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963341, XrefRangeEnd = 963352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUI.Widget GetItem(string queryPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queryPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetItem_Public_Widget_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00028178 File Offset: 0x00026378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 963374, RefRangeEnd = 963376, XrefRangeStart = 963352, XrefRangeEnd = 963374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUI.Widget GetItem(string queryPath, DebugUI.IContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(queryPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_GetItem_Private_Widget_String_IContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugUI.Widget>(intPtr3) : null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000281DC File Offset: 0x000263DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963376, XrefRangeEnd = 963389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_windowStateChanged(Action<DebugManager.UIMode, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_add_windowStateChanged_Public_Static_add_Void_Action_2_UIMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00028214 File Offset: 0x00026414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963389, XrefRangeEnd = 963402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_windowStateChanged(Action<DebugManager.UIMode, bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_remove_windowStateChanged_Public_Static_rem_Void_Action_2_UIMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002824C File Offset: 0x0002644C
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00028288 File Offset: 0x00026488
		public unsafe bool displayEditorUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_displayEditorUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963402, XrefRangeEnd = 963404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_set_displayEditorUI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x000282C8 File Offset: 0x000264C8
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00028304 File Offset: 0x00026504
		public unsafe bool enableRuntimeUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_enableRuntimeUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963404, XrefRangeEnd = 963405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_set_enableRuntimeUI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00028344 File Offset: 0x00026544
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00028380 File Offset: 0x00026580
		public unsafe bool displayRuntimeUI
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 963409, RefRangeEnd = 963421, XrefRangeStart = 963405, XrefRangeEnd = 963409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_displayRuntimeUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 963461, RefRangeEnd = 963464, XrefRangeStart = 963421, XrefRangeEnd = 963461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_set_displayRuntimeUI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000283C0 File Offset: 0x000265C0
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x000283FC File Offset: 0x000265FC
		public unsafe bool displayPersistentRuntimeUI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963464, XrefRangeEnd = 963468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_get_displayPersistentRuntimeUI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963468, XrefRangeEnd = 963475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_set_displayPersistentRuntimeUI_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002843C File Offset: 0x0002663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleEditorUI(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.NativeMethodInfoPtr_ToggleEditorUI_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000049EF File Offset: 0x00002BEF
		public DebugManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0002847C File Offset: 0x0002667C
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x000049F8 File Offset: 0x00002BF8
		public unsafe static string kEnableDebugBtn1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kEnableDebugBtn1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kEnableDebugBtn1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0002849C File Offset: 0x0002669C
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00004A0A File Offset: 0x00002C0A
		public unsafe static string kEnableDebugBtn2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kEnableDebugBtn2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kEnableDebugBtn2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x000284BC File Offset: 0x000266BC
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00004A1C File Offset: 0x00002C1C
		public unsafe static string kDebugPreviousBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kDebugPreviousBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kDebugPreviousBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000284DC File Offset: 0x000266DC
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00004A2E File Offset: 0x00002C2E
		public unsafe static string kDebugNextBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kDebugNextBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kDebugNextBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000284FC File Offset: 0x000266FC
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe static string kValidateBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kValidateBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kValidateBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002851C File Offset: 0x0002671C
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00004A52 File Offset: 0x00002C52
		public unsafe static string kPersistentBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kPersistentBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kPersistentBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0002853C File Offset: 0x0002673C
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00004A64 File Offset: 0x00002C64
		public unsafe static string kDPadVertical
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kDPadVertical, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kDPadVertical, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0002855C File Offset: 0x0002675C
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00004A76 File Offset: 0x00002C76
		public unsafe static string kDPadHorizontal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kDPadHorizontal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kDPadHorizontal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0002857C File Offset: 0x0002677C
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00004A88 File Offset: 0x00002C88
		public unsafe static string kMultiplierBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kMultiplierBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kMultiplierBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0002859C File Offset: 0x0002679C
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00004A9A File Offset: 0x00002C9A
		public unsafe static string kResetBtn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kResetBtn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kResetBtn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x000285BC File Offset: 0x000267BC
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00004AAC File Offset: 0x00002CAC
		public unsafe static string kEnableDebug
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_kEnableDebug, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_kEnableDebug, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000285DC File Offset: 0x000267DC
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00004ABE File Offset: 0x00002CBE
		public unsafe Il2CppReferenceArray<DebugActionDesc> m_DebugActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_DebugActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugActionDesc>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_DebugActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0002860C File Offset: 0x0002680C
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00004ADD File Offset: 0x00002CDD
		public unsafe Il2CppReferenceArray<DebugActionState> m_DebugActionStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_DebugActionStates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DebugActionState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_DebugActionStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0002863C File Offset: 0x0002683C
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004AFC File Offset: 0x00002CFC
		public unsafe static Lazy<DebugManager> s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<DebugManager>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00028664 File Offset: 0x00026864
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00004B0E File Offset: 0x00002D0E
		public unsafe ReadOnlyCollection<DebugUI.Panel> m_ReadOnlyPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_ReadOnlyPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<DebugUI.Panel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_ReadOnlyPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00028694 File Offset: 0x00026894
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00004B2D File Offset: 0x00002D2D
		public unsafe List<DebugUI.Panel> m_Panels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_Panels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugUI.Panel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_Panels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x000286C4 File Offset: 0x000268C4
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00004B4C File Offset: 0x00002D4C
		public unsafe Action<bool> onDisplayRuntimeUIChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_onDisplayRuntimeUIChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_onDisplayRuntimeUIChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x000286F4 File Offset: 0x000268F4
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00004B6B File Offset: 0x00002D6B
		public unsafe Action onSetDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_onSetDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_onSetDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00028724 File Offset: 0x00026924
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00004B8A File Offset: 0x00002D8A
		public unsafe Action resetData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_resetData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_resetData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x00028754 File Offset: 0x00026954
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00004BA9 File Offset: 0x00002DA9
		public unsafe bool refreshEditorRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_refreshEditorRequested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_refreshEditorRequested)) = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0002877C File Offset: 0x0002697C
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00004BC4 File Offset: 0x00002DC4
		public Nullable<int> m_RequestedPanelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RequestedPanelIndex);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RequestedPanelIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x000287AC File Offset: 0x000269AC
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00004BF2 File Offset: 0x00002DF2
		public unsafe GameObject m_Root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_Root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_Root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x000287DC File Offset: 0x000269DC
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00004C11 File Offset: 0x00002E11
		public unsafe DebugUIHandlerCanvas m_RootUICanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RootUICanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerCanvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RootUICanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0002880C File Offset: 0x00026A0C
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00004C30 File Offset: 0x00002E30
		public unsafe GameObject m_PersistentRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_PersistentRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_PersistentRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0002883C File Offset: 0x00026A3C
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00004C4F File Offset: 0x00002E4F
		public unsafe DebugUIHandlerPersistentCanvas m_RootUIPersistentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RootUIPersistentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUIHandlerPersistentCanvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_RootUIPersistentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0002886C File Offset: 0x00026A6C
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00004C6E File Offset: 0x00002E6E
		public unsafe static Action<DebugManager.UIMode, bool> windowStateChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugManager.NativeFieldInfoPtr_windowStateChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DebugManager.UIMode, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugManager.NativeFieldInfoPtr_windowStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00028894 File Offset: 0x00026A94
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00004C80 File Offset: 0x00002E80
		public unsafe DebugManager.UIState editorUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_editorUIState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugManager.UIState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_editorUIState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x000288C4 File Offset: 0x00026AC4
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00004C9F File Offset: 0x00002E9F
		public unsafe bool m_EnableRuntimeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_EnableRuntimeUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_m_EnableRuntimeUI)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000288EC File Offset: 0x00026AEC
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00004CBA File Offset: 0x00002EBA
		public unsafe DebugManager.UIState runtimeUIState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_runtimeUIState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugManager.UIState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.NativeFieldInfoPtr_runtimeUIState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_kEnableDebugBtn1;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_kEnableDebugBtn2;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_kDebugPreviousBtn;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr_kDebugNextBtn;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr_kValidateBtn;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_kPersistentBtn;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_kDPadVertical;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_kDPadHorizontal;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_kMultiplierBtn;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_kResetBtn;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_kEnableDebug;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugActions;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugActionStates;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadOnlyPanels;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_m_Panels;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_onDisplayRuntimeUIChanged;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_onSetDirty;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_resetData;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_refreshEditorRequested;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestedPanelIndex;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_m_Root;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_m_RootUICanvas;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentRoot;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_m_RootUIPersistentCanvas;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_windowStateChanged;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr_editorUIState;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableRuntimeUI;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_runtimeUIState;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_RegisterActions_Private_Void_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_EnableInputActions_Internal_Void_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_AddAction_Private_Void_DebugAction_DebugActionDesc_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_SampleAction_Private_Void_Int32_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAction_Private_Void_Int32_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActions_Internal_Void_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Internal_Single_DebugAction_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_GetActionToggleDebugMenuWithTouch_Internal_Boolean_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_GetActionReleaseScrollTarget_Internal_Boolean_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInputs_Private_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_DebugManager_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_UpdateReadOnlyCollection_Private_Void_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_get_panels_Public_get_ReadOnlyCollection_1_Panel_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_add_onDisplayRuntimeUIChanged_Public_add_Void_Action_1_Boolean_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDisplayRuntimeUIChanged_Public_rem_Void_Action_1_Boolean_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_add_onSetDirty_Public_add_Void_Action_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_remove_onSetDirty_Public_rem_Void_Action_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_add_resetData_Private_add_Void_Action_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_remove_resetData_Private_rem_Void_Action_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_get_isAnyDebugUIActive_Public_get_Boolean_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEditor_Public_Void_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_ReDrawOnScreenDebug_Public_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_RegisterData_Public_Void_IDebugData_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterData_Public_Void_IDebugData_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRootCanvas_Internal_Void_DebugUIHandlerCanvas_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSelection_Internal_Void_DebugUIHandlerWidget_Boolean_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_SetScrollTarget_Internal_Void_DebugUIHandlerWidget_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_EnsurePersistentCanvas_Private_Void_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_TogglePersistent_Internal_Void_Widget_Nullable_1_Int32_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDirty_Private_Void_Panel_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_PanelIndex_Public_Int32_String_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_PanelDiplayName_Public_String_Int32_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_RequestEditorWindowPanelIndex_Public_Void_Int32_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_GetRequestedEditorWindowPanelIndex_Internal_Nullable_1_Int32_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_GetPanel_Public_Panel_String_Boolean_Int32_Boolean_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_FindPanelIndex_Public_Int32_String_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanel_Public_Void_String_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanel_Public_Void_Panel_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_GetItems_Public_Il2CppReferenceArray_1_Widget_Flags_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsFromContainer_Internal_Il2CppReferenceArray_1_Widget_Flags_IContainer_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Widget_String_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Private_Widget_String_IContainer_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_add_windowStateChanged_Public_Static_add_Void_Action_2_UIMode_Boolean_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_remove_windowStateChanged_Public_Static_rem_Void_Action_2_UIMode_Boolean_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_get_displayEditorUI_Public_get_Boolean_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_set_displayEditorUI_Public_set_Void_Boolean_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_get_enableRuntimeUI_Public_get_Boolean_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_set_enableRuntimeUI_Public_set_Void_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_get_displayRuntimeUI_Public_get_Boolean_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_set_displayRuntimeUI_Public_set_Void_Boolean_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_get_displayPersistentRuntimeUI_Public_get_Boolean_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_set_displayPersistentRuntimeUI_Public_set_Void_Boolean_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_ToggleEditorUI_Public_Void_Boolean_0;

		// Token: 0x0200018D RID: 397
		public enum UIMode
		{
			// Token: 0x04001071 RID: 4209
			EditorMode,
			// Token: 0x04001072 RID: 4210
			RuntimeMode
		}

		// Token: 0x0200018E RID: 398
		public class UIState : Object
		{
			// Token: 0x0600169E RID: 5790 RVA: 0x000617B8 File Offset: 0x0005F9B8
			// Note: this type is marked as 'beforefieldinit'.
			static UIState()
			{
				Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "UIState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr);
				DebugManager.UIState.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr, "mode");
				DebugManager.UIState.NativeFieldInfoPtr_m_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr, "m_Open");
				DebugManager.UIState.NativeMethodInfoPtr_get_open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr, 100664274);
				DebugManager.UIState.NativeMethodInfoPtr_set_open_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr, 100664275);
				DebugManager.UIState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr, 100664276);
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x0600169F RID: 5791 RVA: 0x00061848 File Offset: 0x0005FA48
			// (set) Token: 0x060016A0 RID: 5792 RVA: 0x00061884 File Offset: 0x0005FA84
			public unsafe bool open
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.UIState.NativeMethodInfoPtr_get_open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 962581, RefRangeEnd = 962584, XrefRangeStart = 962577, XrefRangeEnd = 962581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.UIState.NativeMethodInfoPtr_set_open_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060016A1 RID: 5793 RVA: 0x000618C4 File Offset: 0x0005FAC4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UIState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugManager.UIState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.UIState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A2 RID: 5794 RVA: 0x0000B593 File Offset: 0x00009793
			public UIState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00061900 File Offset: 0x0005FB00
			// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0000B59C File Offset: 0x0000979C
			public unsafe DebugManager.UIMode mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.UIState.NativeFieldInfoPtr_mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.UIState.NativeFieldInfoPtr_mode)) = value;
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00061928 File Offset: 0x0005FB28
			// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0000B5B7 File Offset: 0x000097B7
			public unsafe bool m_Open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.UIState.NativeFieldInfoPtr_m_Open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.UIState.NativeFieldInfoPtr_m_Open)) = value;
				}
			}

			// Token: 0x04001073 RID: 4211
			private static readonly IntPtr NativeFieldInfoPtr_mode;

			// Token: 0x04001074 RID: 4212
			private static readonly IntPtr NativeFieldInfoPtr_m_Open;

			// Token: 0x04001075 RID: 4213
			private static readonly IntPtr NativeMethodInfoPtr_get_open_Public_get_Boolean_0;

			// Token: 0x04001076 RID: 4214
			private static readonly IntPtr NativeMethodInfoPtr_set_open_Public_set_Void_Boolean_0;

			// Token: 0x04001077 RID: 4215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018F RID: 399
		[ObfuscatedName("UnityEngine.Rendering.DebugManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060016A7 RID: 5799 RVA: 0x00061950 File Offset: 0x0005FB50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr);
				DebugManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, "<>9");
				DebugManager.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, "<>9__48_0");
				DebugManager.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, "<>9__48_1");
				DebugManager.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, "<>9__59_0");
				DebugManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, 100664278);
				DebugManager.__c.NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, 100664279);
				DebugManager.__c.NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, 100664280);
				DebugManager.__c.NativeMethodInfoPtr__TogglePersistent_b__59_0_Internal_Int32_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, 100664281);
				DebugManager.__c.NativeMethodInfoPtr___cctor_b__94_0_Internal_DebugManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr, 100664282);
			}

			// Token: 0x060016A8 RID: 5800 RVA: 0x00061A30 File Offset: 0x0005FC30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016A9 RID: 5801 RVA: 0x00061A6C File Offset: 0x0005FC6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__48_0(bool <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <p0>;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c.NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060016AA RID: 5802 RVA: 0x00061AAC File Offset: 0x0005FCAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__48_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c.NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016AB RID: 5803 RVA: 0x00061AE0 File Offset: 0x0005FCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962584, XrefRangeEnd = 962587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TogglePersistent_b__59_0(DebugUI.Widget w)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(w);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c.NativeMethodInfoPtr__TogglePersistent_b__59_0_Internal_Int32_Widget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016AC RID: 5804 RVA: 0x00061B30 File Offset: 0x0005FD30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962587, XrefRangeEnd = 962591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugManager __cctor_b__94_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c.NativeMethodInfoPtr___cctor_b__94_0_Internal_DebugManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugManager>(intPtr3) : null;
			}

			// Token: 0x060016AD RID: 5805 RVA: 0x0000B5D2 File Offset: 0x000097D2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x060016AE RID: 5806 RVA: 0x00061B70 File Offset: 0x0005FD70
			// (set) Token: 0x060016AF RID: 5807 RVA: 0x0000B5DB File Offset: 0x000097DB
			public unsafe static DebugManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00061B98 File Offset: 0x0005FD98
			// (set) Token: 0x060016B1 RID: 5809 RVA: 0x0000B5ED File Offset: 0x000097ED
			public unsafe static Action<bool> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugManager.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugManager.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00061BC0 File Offset: 0x0005FDC0
			// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000B5FF File Offset: 0x000097FF
			public unsafe static Action __9__48_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugManager.__c.NativeFieldInfoPtr___9__48_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugManager.__c.NativeFieldInfoPtr___9__48_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060016B4 RID: 5812 RVA: 0x00061BE8 File Offset: 0x0005FDE8
			// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000B611 File Offset: 0x00009811
			public unsafe static Func<DebugUI.Widget, int> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugManager.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DebugUI.Widget, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugManager.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001078 RID: 4216
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001079 RID: 4217
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x0400107A RID: 4218
			private static readonly IntPtr NativeFieldInfoPtr___9__48_1;

			// Token: 0x0400107B RID: 4219
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x0400107C RID: 4220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400107D RID: 4221
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_0_Internal_Void_Boolean_0;

			// Token: 0x0400107E RID: 4222
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__48_1_Internal_Void_0;

			// Token: 0x0400107F RID: 4223
			private static readonly IntPtr NativeMethodInfoPtr__TogglePersistent_b__59_0_Internal_Int32_Widget_0;

			// Token: 0x04001080 RID: 4224
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__94_0_Internal_DebugManager_0;
		}

		// Token: 0x02000190 RID: 400
		[ObfuscatedName("UnityEngine.Rendering.DebugManager+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Object
		{
			// Token: 0x060016B6 RID: 5814 RVA: 0x00061C10 File Offset: 0x0005FE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugManager>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr);
				DebugManager.__c__DisplayClass66_0.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr, "displayName");
				DebugManager.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr, 100664283);
				DebugManager.__c__DisplayClass66_0.NativeMethodInfoPtr__FindPanelIndex_b__0_Internal_Boolean_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr, 100664284);
			}

			// Token: 0x060016B7 RID: 5815 RVA: 0x00061C78 File Offset: 0x0005FE78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugManager.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060016B8 RID: 5816 RVA: 0x00061CB4 File Offset: 0x0005FEB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPanelIndex_b__0(DebugUI.Panel p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugManager.__c__DisplayClass66_0.NativeMethodInfoPtr__FindPanelIndex_b__0_Internal_Boolean_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x0000B623 File Offset: 0x00009823
			public __c__DisplayClass66_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x060016BA RID: 5818 RVA: 0x00061D04 File Offset: 0x0005FF04
			// (set) Token: 0x060016BB RID: 5819 RVA: 0x0000B62C File Offset: 0x0000982C
			public unsafe string displayName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.__c__DisplayClass66_0.NativeFieldInfoPtr_displayName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugManager.__c__DisplayClass66_0.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001081 RID: 4225
			private static readonly IntPtr NativeFieldInfoPtr_displayName;

			// Token: 0x04001082 RID: 4226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001083 RID: 4227
			private static readonly IntPtr NativeMethodInfoPtr__FindPanelIndex_b__0_Internal_Boolean_Panel_0;
		}
	}
}
