using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200015B RID: 347
	public class BaseVisualElementPanel : Object
	{
		// Token: 0x060018EE RID: 6382 RVA: 0x00075014 File Offset: 0x00073214
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVisualElementPanel()
		{
			Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseVisualElementPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr);
			BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "panelDisposed");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_UIElementsBridge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_UIElementsBridge");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_Scale");
			BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "yogaConfig");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_PixelsPerPoint");
			BaseVisualElementPanel.NativeFieldInfoPtr__referenceSpritePixelsPerUnit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<referenceSpritePixelsPerUnit>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<clearSettings>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<duringLayoutPhase>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<repaintData>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<cursorManager>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<contextualMenuManager>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<disposed>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_TopElementUnderPointers");
			BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "standardShaderChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "standardWorldSpaceShaderChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "atlasChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "updateMaterial");
			BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "hierarchyChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "beforeUpdate");
			BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666962);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Abstract_Virtual_New_set_Void_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666963);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666964);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_ownerObject_Protected_Abstract_Virtual_New_set_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666965);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_saveViewData_Public_Abstract_Virtual_New_get_SavePersistentViewData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666966);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_getViewDataDictionary_Public_Abstract_Virtual_New_get_GetViewDataDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666967);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666968);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666969);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666970);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_focusController_Public_Abstract_Virtual_New_set_Void_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666971);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666972);
			BaseVisualElementPanel.NativeMethodInfoPtr_add_panelDisposed_Internal_add_Void_Action_1_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666973);
			BaseVisualElementPanel.NativeMethodInfoPtr_remove_panelDisposed_Internal_rem_Void_Action_1_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666974);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_uiElementsBridge_Internal_get_UIElementsBridge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666975);
			BaseVisualElementPanel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666976);
			BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666977);
			BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666978);
			BaseVisualElementPanel.NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666979);
			BaseVisualElementPanel.NativeMethodInfoPtr_ValidateFocus_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666980);
			BaseVisualElementPanel.NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666981);
			BaseVisualElementPanel.NativeMethodInfoPtr_UpdateAnimations_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666982);
			BaseVisualElementPanel.NativeMethodInfoPtr_UpdateBindings_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666983);
			BaseVisualElementPanel.NativeMethodInfoPtr_ApplyStyles_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666984);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scale_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666985);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_scale_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666986);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666987);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666988);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666989);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666990);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_clearSettings_Internal_get_PanelClearSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666991);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_clearSettings_Internal_set_Void_PanelClearSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666992);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666993);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_duringLayoutPhase_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666994);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666995);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_hierarchyVersion_Internal_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666996);
			BaseVisualElementPanel.NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666997);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666998);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_repaintData_Internal_Virtual_New_set_Void_RepaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100666999);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_cursorManager_Internal_Virtual_New_get_ICursorManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667000);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_cursorManager_Internal_Virtual_New_set_Void_ICursorManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667001);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_contextualMenuManager_Public_Virtual_Final_New_get_ContextualMenuManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667002);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_contextualMenuManager_Internal_set_Void_ContextualMenuManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667003);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667004);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667005);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_dispatcher_Public_Abstract_Virtual_New_set_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667006);
			BaseVisualElementPanel.NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667007);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667008);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Abstract_Virtual_New_get_IStylePropertyAnimationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667009);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Abstract_Virtual_New_set_Void_IStylePropertyAnimationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667010);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667011);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_contextType_Protected_Abstract_Virtual_New_set_Void_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667012);
			BaseVisualElementPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667013);
			BaseVisualElementPanel.NativeMethodInfoPtr_PickAll_Public_Abstract_Virtual_New_VisualElement_Vector2_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667014);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667015);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667016);
			BaseVisualElementPanel.NativeMethodInfoPtr_GetUpdater_Internal_Abstract_Virtual_New_IVisualTreeUpdater_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667017);
			BaseVisualElementPanel.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667018);
			BaseVisualElementPanel.NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Int32_Vector2_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667019);
			BaseVisualElementPanel.NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_Int32_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667020);
			BaseVisualElementPanel.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667021);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_standardShader_Internal_Abstract_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667022);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667023);
			BaseVisualElementPanel.NativeMethodInfoPtr_add_standardShaderChanged_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667024);
			BaseVisualElementPanel.NativeMethodInfoPtr_remove_standardShaderChanged_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667025);
			BaseVisualElementPanel.NativeMethodInfoPtr_add_standardWorldSpaceShaderChanged_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667026);
			BaseVisualElementPanel.NativeMethodInfoPtr_remove_standardWorldSpaceShaderChanged_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667027);
			BaseVisualElementPanel.NativeMethodInfoPtr_add_atlasChanged_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667028);
			BaseVisualElementPanel.NativeMethodInfoPtr_remove_atlasChanged_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667029);
			BaseVisualElementPanel.NativeMethodInfoPtr_InvokeAtlasChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667030);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_atlas_Public_Abstract_Virtual_New_get_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667031);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_atlas_Public_Abstract_Virtual_New_set_Void_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667032);
			BaseVisualElementPanel.NativeMethodInfoPtr_InvokeUpdateMaterial_Internal_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667033);
			BaseVisualElementPanel.NativeMethodInfoPtr_add_hierarchyChanged_Internal_add_Void_HierarchyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667034);
			BaseVisualElementPanel.NativeMethodInfoPtr_remove_hierarchyChanged_Internal_rem_Void_HierarchyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667035);
			BaseVisualElementPanel.NativeMethodInfoPtr_InvokeHierarchyChanged_Internal_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667036);
			BaseVisualElementPanel.NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667037);
			BaseVisualElementPanel.NativeMethodInfoPtr_UpdateElementUnderPointers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667038);
			BaseVisualElementPanel.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667039);
			BaseVisualElementPanel.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667040);
			BaseVisualElementPanel.NativeMethodInfoPtr_CreateMenu_Internal_Virtual_New_IGenericMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667041);
			BaseVisualElementPanel.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100667042);
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00075814 File Offset: 0x00073A14
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0007585C File Offset: 0x00073A5C
		public unsafe virtual EventInterests IMGUIEventInterests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Abstract_Virtual_New_set_Void_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000758A8 File Offset: 0x00073AA8
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000758F4 File Offset: 0x00073AF4
		public unsafe virtual ScriptableObject ownerObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_ownerObject_Protected_Abstract_Virtual_New_set_Void_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00075944 File Offset: 0x00073B44
		public unsafe virtual SavePersistentViewData saveViewData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_saveViewData_Public_Abstract_Virtual_New_get_SavePersistentViewData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SavePersistentViewData>(intPtr3) : null;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00075990 File Offset: 0x00073B90
		public unsafe virtual GetViewDataDictionary getViewDataDictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_getViewDataDictionary_Public_Abstract_Virtual_New_get_GetViewDataDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetViewDataDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x000759DC File Offset: 0x00073BDC
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x00075A24 File Offset: 0x00073C24
		public unsafe virtual int IMGUIContainersCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00075A70 File Offset: 0x00073C70
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00075ABC File Offset: 0x00073CBC
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_focusController_Public_Abstract_Virtual_New_set_Void_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00075B0C File Offset: 0x00073D0C
		public unsafe virtual IMGUIContainer rootIMGUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr3) : null;
			}
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00075B58 File Offset: 0x00073D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320545, XrefRangeEnd = 320550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_panelDisposed(Action<BaseVisualElementPanel> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_add_panelDisposed_Internal_add_Void_Action_1_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00075B9C File Offset: 0x00073D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320550, XrefRangeEnd = 320555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_panelDisposed(Action<BaseVisualElementPanel> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_remove_panelDisposed_Internal_rem_Void_Action_1_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00075BE0 File Offset: 0x00073DE0
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000B90E File Offset: 0x00009B0E
		public unsafe UIElementsBridge uiElementsBridge
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 320555, RefRangeEnd = 320558, XrefRangeStart = 320555, XrefRangeEnd = 320555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_uiElementsBridge_Internal_get_UIElementsBridge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementsBridge>(intPtr3) : null;
			}
			set
			{
				this.m_UIElementsBridge = value;
			}
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00075C20 File Offset: 0x00073E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320558, XrefRangeEnd = 320580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVisualElementPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00075C5C File Offset: 0x00073E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320584, RefRangeEnd = 320585, XrefRangeStart = 320580, XrefRangeEnd = 320584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00075C90 File Offset: 0x00073E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320585, XrefRangeEnd = 320599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00075CDC File Offset: 0x00073EDC
		[CallerCount(0)]
		public unsafe virtual void Repaint(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00075D2C File Offset: 0x00073F2C
		[CallerCount(0)]
		public unsafe virtual void ValidateFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_ValidateFocus_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00075D68 File Offset: 0x00073F68
		[CallerCount(0)]
		public unsafe virtual void ValidateLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00075DA4 File Offset: 0x00073FA4
		[CallerCount(0)]
		public unsafe virtual void UpdateAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_UpdateAnimations_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00075DE0 File Offset: 0x00073FE0
		[CallerCount(0)]
		public unsafe virtual void UpdateBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_UpdateBindings_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00075E1C File Offset: 0x0007401C
		[CallerCount(0)]
		public unsafe virtual void ApplyStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_ApplyStyles_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00075E58 File Offset: 0x00074058
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00075E94 File Offset: 0x00074094
		public unsafe float scale
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 320599, RefRangeEnd = 320603, XrefRangeStart = 320599, XrefRangeEnd = 320599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_scale_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320603, XrefRangeEnd = 320607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_scale_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000771E8 File Offset: 0x000753E8
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00075ED4 File Offset: 0x000740D4
		public unsafe float pixelsPerPoint
		{
			get
			{
				return this.m_PixelsPerPoint;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320607, XrefRangeEnd = 320611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x00075F14 File Offset: 0x00074114
		public unsafe float scaledPixelsPerPoint
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 320611, RefRangeEnd = 320619, XrefRangeStart = 320611, XrefRangeEnd = 320611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00075F50 File Offset: 0x00074150
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00075F8C File Offset: 0x0007418C
		public unsafe float referenceSpritePixelsPerUnit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320619, RefRangeEnd = 320620, XrefRangeStart = 320619, XrefRangeEnd = 320619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x00075FCC File Offset: 0x000741CC
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x00076008 File Offset: 0x00074208
		public unsafe PanelClearSettings clearSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_clearSettings_Internal_get_PanelClearSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_clearSettings_Internal_set_Void_PanelClearSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00076048 File Offset: 0x00074248
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x00076084 File Offset: 0x00074284
		public unsafe bool duringLayoutPhase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_duringLayoutPhase_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000760C4 File Offset: 0x000742C4
		public unsafe virtual uint version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007610C File Offset: 0x0007430C
		public unsafe virtual uint hierarchyVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_hierarchyVersion_Internal_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00076154 File Offset: 0x00074354
		[CallerCount(0)]
		public unsafe virtual void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeTypeFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x000761B0 File Offset: 0x000743B0
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x000761FC File Offset: 0x000743FC
		public unsafe virtual RepaintData repaintData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RepaintData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_repaintData_Internal_Virtual_New_set_Void_RepaintData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0007624C File Offset: 0x0007444C
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00076298 File Offset: 0x00074498
		public unsafe virtual ICursorManager cursorManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_cursorManager_Internal_Virtual_New_get_ICursorManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICursorManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_cursorManager_Internal_Virtual_New_set_Void_ICursorManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x000762E8 File Offset: 0x000744E8
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00076328 File Offset: 0x00074528
		public unsafe virtual ContextualMenuManager contextualMenuManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_contextualMenuManager_Public_Virtual_Final_New_get_ContextualMenuManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextualMenuManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320620, XrefRangeEnd = 320621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_contextualMenuManager_Internal_set_Void_ContextualMenuManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0007636C File Offset: 0x0007456C
		public unsafe virtual VisualElement visualTree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000763B8 File Offset: 0x000745B8
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x00076404 File Offset: 0x00074604
		public unsafe virtual EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_dispatcher_Public_Abstract_Virtual_New_set_Void_EventDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00076454 File Offset: 0x00074654
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 320626, RefRangeEnd = 320642, XrefRangeStart = 320621, XrefRangeEnd = 320626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x000764A4 File Offset: 0x000746A4
		public unsafe virtual IScheduler scheduler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x000764F0 File Offset: 0x000746F0
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x0007653C File Offset: 0x0007473C
		public unsafe virtual IStylePropertyAnimationSystem styleAnimationSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Abstract_Virtual_New_get_IStylePropertyAnimationSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStylePropertyAnimationSystem>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Abstract_Virtual_New_set_Void_IStylePropertyAnimationSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0007658C File Offset: 0x0007478C
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x000765D4 File Offset: 0x000747D4
		public unsafe virtual ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_contextType_Protected_Abstract_Virtual_New_set_Void_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00076620 File Offset: 0x00074820
		[CallerCount(0)]
		public unsafe virtual VisualElement Pick(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00076678 File Offset: 0x00074878
		[CallerCount(0)]
		public unsafe virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picked);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_PickAll_Public_Abstract_Virtual_New_VisualElement_Vector2_List_1_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x000766E4 File Offset: 0x000748E4
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x00076720 File Offset: 0x00074920
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00076760 File Offset: 0x00074960
		[CallerCount(0)]
		public unsafe virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_GetUpdater_Internal_Abstract_Virtual_New_IVisualTreeUpdater_VisualTreeUpdatePhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000767B8 File Offset: 0x000749B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320644, RefRangeEnd = 320651, XrefRangeStart = 320642, XrefRangeEnd = 320644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00076804 File Offset: 0x00074A04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320659, RefRangeEnd = 320662, XrefRangeStart = 320651, XrefRangeEnd = 320659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Int32_Vector2_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00076870 File Offset: 0x00074A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320663, RefRangeEnd = 320665, XrefRangeStart = 320662, XrefRangeEnd = 320663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_Int32_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000768C0 File Offset: 0x00074AC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 320667, RefRangeEnd = 320672, XrefRangeStart = 320665, XrefRangeEnd = 320667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitElementUnderPointers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x000768F4 File Offset: 0x00074AF4
		public unsafe virtual Shader standardShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_standardShader_Internal_Abstract_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00076940 File Offset: 0x00074B40
		// (set) Token: 0x0600196C RID: 6508 RVA: 0x0000B917 File Offset: 0x00009B17
		public unsafe virtual Shader standardWorldSpaceShader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
			set
			{
			}
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0007698C File Offset: 0x00074B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320677, RefRangeEnd = 320678, XrefRangeStart = 320673, XrefRangeEnd = 320677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_standardShaderChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_add_standardShaderChanged_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000769D0 File Offset: 0x00074BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320682, RefRangeEnd = 320683, XrefRangeStart = 320678, XrefRangeEnd = 320682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_standardShaderChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_remove_standardShaderChanged_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00076A14 File Offset: 0x00074C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320687, RefRangeEnd = 320688, XrefRangeStart = 320683, XrefRangeEnd = 320687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_standardWorldSpaceShaderChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_add_standardWorldSpaceShaderChanged_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00076A58 File Offset: 0x00074C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320692, RefRangeEnd = 320693, XrefRangeStart = 320688, XrefRangeEnd = 320692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_standardWorldSpaceShaderChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_remove_standardWorldSpaceShaderChanged_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00076A9C File Offset: 0x00074C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320697, RefRangeEnd = 320698, XrefRangeStart = 320693, XrefRangeEnd = 320697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_atlasChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_add_atlasChanged_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00076AE0 File Offset: 0x00074CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320702, RefRangeEnd = 320703, XrefRangeStart = 320698, XrefRangeEnd = 320702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_atlasChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_remove_atlasChanged_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00076B24 File Offset: 0x00074D24
		[CallerCount(0)]
		public unsafe void InvokeAtlasChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_InvokeAtlasChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00076B58 File Offset: 0x00074D58
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00076BA4 File Offset: 0x00074DA4
		public unsafe virtual AtlasBase atlas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_atlas_Public_Abstract_Virtual_New_get_AtlasBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_set_atlas_Public_Abstract_Virtual_New_set_Void_AtlasBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00076BF4 File Offset: 0x00074DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320703, RefRangeEnd = 320704, XrefRangeStart = 320703, XrefRangeEnd = 320703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeUpdateMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_InvokeUpdateMaterial_Internal_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00076C38 File Offset: 0x00074E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320708, RefRangeEnd = 320709, XrefRangeStart = 320704, XrefRangeEnd = 320708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_hierarchyChanged(HierarchyEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_add_hierarchyChanged_Internal_add_Void_HierarchyEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00076C7C File Offset: 0x00074E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320713, RefRangeEnd = 320714, XrefRangeStart = 320709, XrefRangeEnd = 320713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_hierarchyChanged(HierarchyEvent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_remove_hierarchyChanged_Internal_rem_Void_HierarchyEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00076CC0 File Offset: 0x00074EC0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 320714, RefRangeEnd = 320720, XrefRangeStart = 320714, XrefRangeEnd = 320714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_InvokeHierarchyChanged_Internal_Void_VisualElement_HierarchyChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00076D10 File Offset: 0x00074F10
		[CallerCount(0)]
		public unsafe void InvokeBeforeUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00076D44 File Offset: 0x00074F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320743, RefRangeEnd = 320744, XrefRangeStart = 320720, XrefRangeEnd = 320743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElementUnderPointers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_UpdateElementUnderPointers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00076D78 File Offset: 0x00074F78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionAdded(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00076DBC File Offset: 0x00074FBC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_UIElements_IGroupBox_OnOptionRemoved(IGroupBoxOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00076E00 File Offset: 0x00075000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320744, XrefRangeEnd = 320748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IGenericMenu CreateMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_CreateMenu_Internal_Virtual_New_IGenericMenu_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGenericMenu>(intPtr3) : null;
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00076E4C File Offset: 0x0007504C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320748, XrefRangeEnd = 320752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0000B6D0 File Offset: 0x000098D0
		public BaseVisualElementPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x00076E88 File Offset: 0x00075088
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x0000B6D9 File Offset: 0x000098D9
		public unsafe Action<BaseVisualElementPanel> panelDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseVisualElementPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00076EB8 File Offset: 0x000750B8
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0000B6F8 File Offset: 0x000098F8
		public unsafe UIElementsBridge m_UIElementsBridge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_UIElementsBridge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementsBridge>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_UIElementsBridge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00076EE8 File Offset: 0x000750E8
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x0000B717 File Offset: 0x00009917
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00076F10 File Offset: 0x00075110
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x0000B732 File Offset: 0x00009932
		public unsafe UnityEngine.Yoga.YogaConfig yogaConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Yoga.YogaConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x00076F40 File Offset: 0x00075140
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x0000B751 File Offset: 0x00009951
		public unsafe float m_PixelsPerPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint)) = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00076F68 File Offset: 0x00075168
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x0000B76C File Offset: 0x0000996C
		public unsafe float _referenceSpritePixelsPerUnit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__referenceSpritePixelsPerUnit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__referenceSpritePixelsPerUnit_k__BackingField)) = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00076F90 File Offset: 0x00075190
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0000B787 File Offset: 0x00009987
		public unsafe PanelClearSettings _clearSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00076FB8 File Offset: 0x000751B8
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000B7A2 File Offset: 0x000099A2
		public unsafe bool _duringLayoutPhase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField)) = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00076FE0 File Offset: 0x000751E0
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000B7BD File Offset: 0x000099BD
		public unsafe RepaintData _repaintData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RepaintData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00077010 File Offset: 0x00075210
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x0000B7DC File Offset: 0x000099DC
		public unsafe ICursorManager _cursorManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICursorManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00077040 File Offset: 0x00075240
		// (set) Token: 0x06001956 RID: 6486 RVA: 0x0000B7FB File Offset: 0x000099FB
		public unsafe ContextualMenuManager _contextualMenuManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualMenuManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00077070 File Offset: 0x00075270
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x0000B81A File Offset: 0x00009A1A
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00077098 File Offset: 0x00075298
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x0000B835 File Offset: 0x00009A35
		public unsafe ElementUnderPointer m_TopElementUnderPointers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ElementUnderPointer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000770C8 File Offset: 0x000752C8
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0000B854 File Offset: 0x00009A54
		public unsafe Action standardShaderChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000770F8 File Offset: 0x000752F8
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0000B873 File Offset: 0x00009A73
		public unsafe Action standardWorldSpaceShaderChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00077128 File Offset: 0x00075328
		// (set) Token: 0x06001960 RID: 6496 RVA: 0x0000B892 File Offset: 0x00009A92
		public unsafe Action atlasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001961 RID: 6497 RVA: 0x00077158 File Offset: 0x00075358
		// (set) Token: 0x06001962 RID: 6498 RVA: 0x0000B8B1 File Offset: 0x00009AB1
		public unsafe Action<Material> updateMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x00077188 File Offset: 0x00075388
		// (set) Token: 0x06001964 RID: 6500 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public unsafe HierarchyEvent hierarchyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HierarchyEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001965 RID: 6501 RVA: 0x000771B8 File Offset: 0x000753B8
		// (set) Token: 0x06001966 RID: 6502 RVA: 0x0000B8EF File Offset: 0x00009AEF
		public unsafe Action<IPanel> beforeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00077200 File Offset: 0x00075400
		// (set) Token: 0x0600196A RID: 6506 RVA: 0x00077240 File Offset: 0x00075440
		public PanelClearFlags clearFlags
		{
			get
			{
				PanelClearFlags panelClearFlags = PanelClearFlags.None;
				bool clearColor = this.clearSettings.clearColor;
				if (clearColor)
				{
					panelClearFlags |= PanelClearFlags.Color;
				}
				bool clearDepthStencil = this.clearSettings.clearDepthStencil;
				if (clearDepthStencil)
				{
					panelClearFlags |= PanelClearFlags.Depth;
				}
				return panelClearFlags;
			}
			set
			{
				PanelClearSettings clearSettings = this.clearSettings;
				clearSettings.clearColor = (value & PanelClearFlags.Color) == PanelClearFlags.Color;
				clearSettings.clearDepthStencil = (value & PanelClearFlags.Depth) == PanelClearFlags.Depth;
				this.clearSettings = clearSettings;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00077278 File Offset: 0x00075478
		public bool isDirty
		{
			get
			{
				return this.version != this.repaintVersion;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0007729C File Offset: 0x0007549C
		public void InvokeStandardShaderChanged()
		{
			bool flag = this.standardShaderChanged != null;
			if (flag)
			{
				this.standardShaderChanged.Invoke();
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000772C4 File Offset: 0x000754C4
		public void InvokeStandardWorldSpaceShaderChanged()
		{
			bool flag = this.standardWorldSpaceShaderChanged != null;
			if (flag)
			{
				this.standardWorldSpaceShaderChanged.Invoke();
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0000B91A File Offset: 0x00009B1A
		public void add_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0000B927 File Offset: 0x00009B27
		public void remove_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0000B934 File Offset: 0x00009B34
		public void add_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0000B941 File Offset: 0x00009B41
		public void remove_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr_panelDisposed;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr_m_UIElementsBridge;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeFieldInfoPtr_yogaConfig;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeFieldInfoPtr_m_PixelsPerPoint;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeFieldInfoPtr__referenceSpritePixelsPerUnit_k__BackingField;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeFieldInfoPtr__clearSettings_k__BackingField;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeFieldInfoPtr__duringLayoutPhase_k__BackingField;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeFieldInfoPtr__repaintData_k__BackingField;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeFieldInfoPtr__cursorManager_k__BackingField;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeFieldInfoPtr__contextualMenuManager_k__BackingField;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr_m_TopElementUnderPointers;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_standardShaderChanged;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_standardWorldSpaceShaderChanged;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr_atlasChanged;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_updateMaterial;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyChanged;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr_beforeUpdate;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Abstract_Virtual_New_set_Void_EventInterests_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_set_ownerObject_Protected_Abstract_Virtual_New_set_Void_ScriptableObject_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_get_saveViewData_Public_Abstract_Virtual_New_get_SavePersistentViewData_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_get_getViewDataDictionary_Public_Abstract_Virtual_New_get_GetViewDataDictionary_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_set_focusController_Public_Abstract_Virtual_New_set_Void_FocusController_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_add_panelDisposed_Internal_add_Void_Action_1_BaseVisualElementPanel_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_remove_panelDisposed_Internal_rem_Void_Action_1_BaseVisualElementPanel_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_get_uiElementsBridge_Internal_get_UIElementsBridge_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFocus_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimations_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindings_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyles_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Internal_get_Single_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Internal_set_Void_Single_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_get_clearSettings_Internal_get_PanelClearSettings_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_set_clearSettings_Internal_set_Void_PanelClearSettings_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_set_duringLayoutPhase_Internal_set_Void_Boolean_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyVersion_Internal_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_set_repaintData_Internal_Virtual_New_set_Void_RepaintData_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_get_cursorManager_Internal_Virtual_New_get_ICursorManager_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_set_cursorManager_Internal_Virtual_New_set_Void_ICursorManager_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_get_contextualMenuManager_Public_Virtual_Final_New_get_ContextualMenuManager_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_set_contextualMenuManager_Internal_set_Void_ContextualMenuManager_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatcher_Public_Abstract_Virtual_New_set_Void_EventDispatcher_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Abstract_Virtual_New_get_IStylePropertyAnimationSystem_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Abstract_Virtual_New_set_Void_IStylePropertyAnimationSystem_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_set_contextType_Protected_Abstract_Virtual_New_set_Void_ContextType_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_PickAll_Public_Abstract_Virtual_New_VisualElement_Vector2_List_1_VisualElement_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdater_Internal_Abstract_Virtual_New_IVisualTreeUpdater_VisualTreeUpdatePhase_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Int32_Vector2_EventBase_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_Int32_EventBase_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_get_standardShader_Internal_Abstract_Virtual_New_get_Shader_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_get_standardWorldSpaceShader_Internal_Virtual_New_get_Shader_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_add_standardShaderChanged_Internal_add_Void_Action_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_remove_standardShaderChanged_Internal_rem_Void_Action_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_add_standardWorldSpaceShaderChanged_Internal_add_Void_Action_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_remove_standardWorldSpaceShaderChanged_Internal_rem_Void_Action_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_add_atlasChanged_Internal_add_Void_Action_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_remove_atlasChanged_Internal_rem_Void_Action_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAtlasChanged_Protected_Void_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_Abstract_Virtual_New_get_AtlasBase_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_set_atlas_Public_Abstract_Virtual_New_set_Void_AtlasBase_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUpdateMaterial_Internal_Void_Material_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_add_hierarchyChanged_Internal_add_Void_HierarchyEvent_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_remove_hierarchyChanged_Internal_rem_Void_HierarchyEvent_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_InvokeHierarchyChanged_Internal_Void_VisualElement_HierarchyChangeType_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElementUnderPointers_Internal_Void_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionAdded_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IGroupBox_OnOptionRemoved_Private_Virtual_Final_New_Void_IGroupBoxOption_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_CreateMenu_Internal_Virtual_New_IGenericMenu_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;
	}
}
