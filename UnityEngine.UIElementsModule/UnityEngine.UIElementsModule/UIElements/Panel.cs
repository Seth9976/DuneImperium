using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000160 RID: 352
	public class Panel : BaseVisualElementPanel
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x000776BC File Offset: 0x000758BC
		// Note: this type is marked as 'beforefieldinit'.
		static Panel()
		{
			Il2CppClassPointerStore<Panel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Panel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Panel>.NativeClassPtr);
			Panel.NativeFieldInfoPtr_m_RootContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_RootContainer");
			Panel.NativeFieldInfoPtr_m_VisualTreeUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_VisualTreeUpdater");
			Panel.NativeFieldInfoPtr_m_StylePropertyAnimationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_StylePropertyAnimationSystem");
			Panel.NativeFieldInfoPtr_m_PanelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_PanelName");
			Panel.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Version");
			Panel.NativeFieldInfoPtr_m_RepaintVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_RepaintVersion");
			Panel.NativeFieldInfoPtr_m_HierarchyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_HierarchyVersion");
			Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerBeforeUpdate");
			Panel.NativeFieldInfoPtr_m_MarkerUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerUpdate");
			Panel.NativeFieldInfoPtr_m_MarkerLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerLayout");
			Panel.NativeFieldInfoPtr_m_MarkerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerBindings");
			Panel.NativeFieldInfoPtr_m_MarkerAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_MarkerAnimations");
			Panel.NativeFieldInfoPtr_s_MarkerPickAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "s_MarkerPickAll");
			Panel.NativeFieldInfoPtr__dispatcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<dispatcher>k__BackingField");
			Panel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Scheduler");
			Panel.NativeFieldInfoPtr__ownerObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<ownerObject>k__BackingField");
			Panel.NativeFieldInfoPtr__contextType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<contextType>k__BackingField");
			Panel.NativeFieldInfoPtr__saveViewData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<saveViewData>k__BackingField");
			Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<getViewDataDictionary>k__BackingField");
			Panel.NativeFieldInfoPtr__focusController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<focusController>k__BackingField");
			Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<IMGUIEventInterests>k__BackingField");
			Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<loadResourceFunc>k__BackingField");
			Panel.NativeFieldInfoPtr_m_JustReceivedFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_JustReceivedFocus");
			Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<TimeSinceStartup>k__BackingField");
			Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<IMGUIContainersCount>k__BackingField");
			Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "<rootIMGUIContainer>k__BackingField");
			Panel.NativeFieldInfoPtr_m_StandardShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_StandardShader");
			Panel.NativeFieldInfoPtr_m_Atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_Atlas");
			Panel.NativeFieldInfoPtr_m_ValidatingLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "m_ValidatingLayout");
			Panel.NativeFieldInfoPtr_beforeAnyRepaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Panel>.NativeClassPtr, "beforeAnyRepaint");
			Panel.NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667051);
			Panel.NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667052);
			Panel.NativeMethodInfoPtr_set_dispatcher_Public_Virtual_Final_set_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667053);
			Panel.NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667054);
			Panel.NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667055);
			Panel.NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Virtual_get_IStylePropertyAnimationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667056);
			Panel.NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Virtual_set_Void_IStylePropertyAnimationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667057);
			Panel.NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667058);
			Panel.NativeMethodInfoPtr_set_ownerObject_Protected_Virtual_set_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667059);
			Panel.NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667060);
			Panel.NativeMethodInfoPtr_set_contextType_Protected_Virtual_set_Void_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667061);
			Panel.NativeMethodInfoPtr_get_saveViewData_Public_Virtual_get_SavePersistentViewData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667062);
			Panel.NativeMethodInfoPtr_get_getViewDataDictionary_Public_Virtual_get_GetViewDataDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667063);
			Panel.NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667064);
			Panel.NativeMethodInfoPtr_set_focusController_Public_Virtual_Final_set_Void_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667065);
			Panel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667066);
			Panel.NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Virtual_set_Void_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667067);
			Panel.NativeMethodInfoPtr_get_loadResourceFunc_Private_Static_get_LoadResourceFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667068);
			Panel.NativeMethodInfoPtr_LoadResource_Internal_Static_Object_String_Type_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667069);
			Panel.NativeMethodInfoPtr_Focus_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667070);
			Panel.NativeMethodInfoPtr_Blur_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667071);
			Panel.NativeMethodInfoPtr_ValidateFocus_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667072);
			Panel.NativeMethodInfoPtr_get_name_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667073);
			Panel.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667074);
			Panel.NativeMethodInfoPtr_CreateMarkers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667075);
			Panel.NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667076);
			Panel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667077);
			Panel.NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Virtual_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667078);
			Panel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667079);
			Panel.NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667080);
			Panel.NativeMethodInfoPtr_get_hierarchyVersion_Internal_Virtual_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667081);
			Panel.NativeMethodInfoPtr_get_standardShader_Internal_Virtual_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667082);
			Panel.NativeMethodInfoPtr_get_atlas_Public_Virtual_get_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667083);
			Panel.NativeMethodInfoPtr_set_atlas_Public_Virtual_set_Void_AtlasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667084);
			Panel.NativeMethodInfoPtr__ctor_Public_Void_ScriptableObject_ContextType_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667085);
			Panel.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667086);
			Panel.NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667087);
			Panel.NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667088);
			Panel.NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667089);
			Panel.NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667090);
			Panel.NativeMethodInfoPtr_PickAll_Public_Virtual_VisualElement_Vector2_List_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667091);
			Panel.NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667092);
			Panel.NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667093);
			Panel.NativeMethodInfoPtr_UpdateAnimations_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667094);
			Panel.NativeMethodInfoPtr_UpdateBindings_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667095);
			Panel.NativeMethodInfoPtr_ApplyStyles_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667096);
			Panel.NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667097);
			Panel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667098);
			Panel.NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667099);
			Panel.NativeMethodInfoPtr_GetUpdater_Internal_Virtual_IVisualTreeUpdater_VisualTreeUpdatePhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667100);
			Panel.NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Panel>.NativeClassPtr, 100667102);
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00077D40 File Offset: 0x00075F40
		public unsafe override VisualElement visualTree
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 321260, RefRangeEnd = 321264, XrefRangeStart = 321260, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x00077D80 File Offset: 0x00075F80
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x00077DC0 File Offset: 0x00075FC0
		public unsafe override EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321264, XrefRangeEnd = 321265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_set_dispatcher_Public_Virtual_Final_set_Void_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x00077E04 File Offset: 0x00076004
		public unsafe TimerEventScheduler timerEventScheduler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321265, XrefRangeEnd = 321270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerEventScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00077E44 File Offset: 0x00076044
		public unsafe override IScheduler scheduler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00077E90 File Offset: 0x00076090
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x00077EDC File Offset: 0x000760DC
		public unsafe override IStylePropertyAnimationSystem styleAnimationSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Virtual_get_IStylePropertyAnimationSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IStylePropertyAnimationSystem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321270, XrefRangeEnd = 321274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Virtual_set_Void_IStylePropertyAnimationSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00077F2C File Offset: 0x0007612C
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00077F78 File Offset: 0x00076178
		public unsafe override ScriptableObject ownerObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321274, XrefRangeEnd = 321275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_ownerObject_Protected_Virtual_set_Void_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x00077FC8 File Offset: 0x000761C8
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x00078010 File Offset: 0x00076210
		public unsafe override ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_contextType_Protected_Virtual_set_Void_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0007805C File Offset: 0x0007625C
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0000BD4D File Offset: 0x00009F4D
		public unsafe override SavePersistentViewData saveViewData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_saveViewData_Public_Virtual_get_SavePersistentViewData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SavePersistentViewData>(intPtr3) : null;
			}
			set
			{
				this._saveViewData_k__BackingField = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x000780A8 File Offset: 0x000762A8
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0000BD56 File Offset: 0x00009F56
		public unsafe override GetViewDataDictionary getViewDataDictionary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_getViewDataDictionary_Public_Virtual_get_GetViewDataDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetViewDataDictionary>(intPtr3) : null;
			}
			set
			{
				this._getViewDataDictionary_k__BackingField = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x000780F4 File Offset: 0x000762F4
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x00078134 File Offset: 0x00076334
		public unsafe override FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321275, XrefRangeEnd = 321276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_set_focusController_Public_Virtual_Final_set_Void_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x00078178 File Offset: 0x00076378
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x000781C0 File Offset: 0x000763C0
		public unsafe override EventInterests IMGUIEventInterests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Virtual_set_Void_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0007820C File Offset: 0x0007640C
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000BD5F File Offset: 0x00009F5F
		public unsafe static LoadResourceFunction loadResourceFunc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321276, XrefRangeEnd = 321280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_loadResourceFunc_Private_Static_get_LoadResourceFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadResourceFunction>(intPtr3) : null;
			}
			set
			{
				Panel._loadResourceFunc_k__BackingField = value;
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00078240 File Offset: 0x00076440
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 321294, RefRangeEnd = 321301, XrefRangeStart = 321280, XrefRangeEnd = 321294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object LoadResource(string pathName, Type type, float dpiScaling)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dpiScaling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_LoadResource_Internal_Static_Object_String_Type_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000782A4 File Offset: 0x000764A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321301, RefRangeEnd = 321305, XrefRangeStart = 321301, XrefRangeEnd = 321301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_Focus_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000782D8 File Offset: 0x000764D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321314, RefRangeEnd = 321318, XrefRangeStart = 321305, XrefRangeEnd = 321314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blur()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_Blur_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0007830C File Offset: 0x0007650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321318, XrefRangeEnd = 321321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_ValidateFocus_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00078348 File Offset: 0x00076548
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00078380 File Offset: 0x00076580
		public unsafe string name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321321, RefRangeEnd = 321322, XrefRangeStart = 321321, XrefRangeEnd = 321321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_name_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321322, XrefRangeEnd = 321324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_set_name_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000783C4 File Offset: 0x000765C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321360, RefRangeEnd = 321363, XrefRangeStart = 321324, XrefRangeEnd = 321360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateMarkers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_CreateMarkers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000783F8 File Offset: 0x000765F8
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000BD67 File Offset: 0x00009F67
		public unsafe static TimeMsFunction TimeSinceStartup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321363, XrefRangeEnd = 321367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeMsFunction>(intPtr3) : null;
			}
			set
			{
				Panel._TimeSinceStartup_k__BackingField = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x0007842C File Offset: 0x0007662C
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x00078474 File Offset: 0x00076674
		public unsafe override int IMGUIContainersCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Virtual_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x000784C0 File Offset: 0x000766C0
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0000BD6F File Offset: 0x00009F6F
		public unsafe override IMGUIContainer rootIMGUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr3) : null;
			}
			set
			{
				this._rootIMGUIContainer_k__BackingField = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x0007850C File Offset: 0x0007670C
		public unsafe override uint version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00078554 File Offset: 0x00076754
		public unsafe override uint hierarchyVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_hierarchyVersion_Internal_Virtual_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x0007859C File Offset: 0x0007679C
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x000790CC File Offset: 0x000772CC
		public unsafe override Shader standardShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_standardShader_Internal_Virtual_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_StandardShader != value;
				if (flag)
				{
					this.m_StandardShader = value;
					base.InvokeStandardShaderChanged();
				}
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x000785E8 File Offset: 0x000767E8
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x00078634 File Offset: 0x00076834
		public unsafe override AtlasBase atlas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_get_atlas_Public_Virtual_get_AtlasBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321367, XrefRangeEnd = 321370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_set_atlas_Public_Virtual_set_Void_AtlasBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00078684 File Offset: 0x00076884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321443, RefRangeEnd = 321444, XrefRangeStart = 321370, XrefRangeEnd = 321443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Panel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr__ctor_Public_Void_ScriptableObject_ContextType_EventDispatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000786F0 File Offset: 0x000768F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321459, RefRangeEnd = 321460, XrefRangeStart = 321444, XrefRangeEnd = 321459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0007873C File Offset: 0x0007693C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 321468, RefRangeEnd = 321485, XrefRangeStart = 321460, XrefRangeEnd = 321468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeSinceStartupMs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0007876C File Offset: 0x0007696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321485, XrefRangeEnd = 321486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DefaultTimeSinceStartupMs()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0007879C File Offset: 0x0007699C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321490, RefRangeEnd = 321492, XrefRangeStart = 321486, XrefRangeEnd = 321490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picked);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeIgnoredElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00078810 File Offset: 0x00076A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321510, RefRangeEnd = 321512, XrefRangeStart = 321492, XrefRangeEnd = 321510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(picked);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeIgnoredElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00078884 File Offset: 0x00076A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321512, XrefRangeEnd = 321518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_PickAll_Public_Virtual_VisualElement_Vector2_List_1_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000788F0 File Offset: 0x00076AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321518, XrefRangeEnd = 321531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement Pick(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00078948 File Offset: 0x00076B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321531, XrefRangeEnd = 321534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00078984 File Offset: 0x00076B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321534, XrefRangeEnd = 321536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_UpdateAnimations_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000789C0 File Offset: 0x00076BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321536, XrefRangeEnd = 321538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_UpdateBindings_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000789FC File Offset: 0x00076BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321538, XrefRangeEnd = 321540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_ApplyStyles_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00078A38 File Offset: 0x00076C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321540, XrefRangeEnd = 321546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateForRepaint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00078A6C File Offset: 0x00076C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321578, RefRangeEnd = 321580, XrefRangeStart = 321546, XrefRangeEnd = 321578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Repaint(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00078ABC File Offset: 0x00076CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321580, XrefRangeEnd = 321581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00078B18 File Offset: 0x00076D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321581, XrefRangeEnd = 321583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Panel.NativeMethodInfoPtr_GetUpdater_Internal_Virtual_IVisualTreeUpdater_VisualTreeUpdatePhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualTreeUpdater>(intPtr3) : null;
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00078B70 File Offset: 0x00076D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321591, RefRangeEnd = 321593, XrefRangeStart = 321583, XrefRangeEnd = 321591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int Method_Internal_Static_Vector2Int_Vector2_0(Vector2 p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Panel.NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0000BA0E File Offset: 0x00009C0E
		public Panel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00078BB0 File Offset: 0x00076DB0
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000BA17 File Offset: 0x00009C17
		public unsafe VisualElement m_RootContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RootContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RootContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00078BE0 File Offset: 0x00076DE0
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000BA36 File Offset: 0x00009C36
		public unsafe VisualTreeUpdater m_VisualTreeUpdater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_VisualTreeUpdater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeUpdater>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_VisualTreeUpdater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00078C10 File Offset: 0x00076E10
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000BA55 File Offset: 0x00009C55
		public unsafe IStylePropertyAnimationSystem m_StylePropertyAnimationSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StylePropertyAnimationSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStylePropertyAnimationSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StylePropertyAnimationSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00078C40 File Offset: 0x00076E40
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000BA74 File Offset: 0x00009C74
		public unsafe string m_PanelName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_PanelName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_PanelName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00078C68 File Offset: 0x00076E68
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0000BA93 File Offset: 0x00009C93
		public unsafe uint m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00078C90 File Offset: 0x00076E90
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0000BAAE File Offset: 0x00009CAE
		public unsafe uint m_RepaintVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RepaintVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_RepaintVersion)) = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00078CB8 File Offset: 0x00076EB8
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000BAC9 File Offset: 0x00009CC9
		public unsafe uint m_HierarchyVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_HierarchyVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_HierarchyVersion)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00078CE0 File Offset: 0x00076EE0
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		public unsafe ProfilerMarker m_MarkerBeforeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBeforeUpdate)) = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00078D08 File Offset: 0x00076F08
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x0000BAFF File Offset: 0x00009CFF
		public unsafe ProfilerMarker m_MarkerUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerUpdate)) = value;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00078D30 File Offset: 0x00076F30
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000BB1A File Offset: 0x00009D1A
		public unsafe ProfilerMarker m_MarkerLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerLayout)) = value;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00078D58 File Offset: 0x00076F58
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0000BB35 File Offset: 0x00009D35
		public unsafe ProfilerMarker m_MarkerBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBindings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerBindings)) = value;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00078D80 File Offset: 0x00076F80
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000BB50 File Offset: 0x00009D50
		public unsafe ProfilerMarker m_MarkerAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerAnimations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_MarkerAnimations)) = value;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00078DA8 File Offset: 0x00076FA8
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000BB6B File Offset: 0x00009D6B
		public unsafe static ProfilerMarker s_MarkerPickAll
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr_s_MarkerPickAll, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr_s_MarkerPickAll, (void*)(&value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00078DC4 File Offset: 0x00076FC4
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0000BB79 File Offset: 0x00009D79
		public unsafe EventDispatcher _dispatcher_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__dispatcher_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__dispatcher_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00078DF4 File Offset: 0x00076FF4
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000BB98 File Offset: 0x00009D98
		public unsafe TimerEventScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerEventScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00078E24 File Offset: 0x00077024
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0000BBB7 File Offset: 0x00009DB7
		public unsafe ScriptableObject _ownerObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__ownerObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__ownerObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00078E54 File Offset: 0x00077054
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0000BBD6 File Offset: 0x00009DD6
		public unsafe ContextType _contextType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__contextType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__contextType_k__BackingField)) = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00078E7C File Offset: 0x0007707C
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0000BBF1 File Offset: 0x00009DF1
		public unsafe SavePersistentViewData _saveViewData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__saveViewData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SavePersistentViewData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__saveViewData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00078EAC File Offset: 0x000770AC
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000BC10 File Offset: 0x00009E10
		public unsafe GetViewDataDictionary _getViewDataDictionary_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetViewDataDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__getViewDataDictionary_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00078EDC File Offset: 0x000770DC
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000BC2F File Offset: 0x00009E2F
		public unsafe FocusController _focusController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__focusController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__focusController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00078F0C File Offset: 0x0007710C
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x0000BC4E File Offset: 0x00009E4E
		public unsafe EventInterests _IMGUIEventInterests_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField)) = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00078F34 File Offset: 0x00077134
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x0000BC69 File Offset: 0x00009E69
		public unsafe static LoadResourceFunction _loadResourceFunc_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadResourceFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr__loadResourceFunc_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00078F5C File Offset: 0x0007715C
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0000BC7B File Offset: 0x00009E7B
		public unsafe bool m_JustReceivedFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_JustReceivedFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_JustReceivedFocus)) = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00078F84 File Offset: 0x00077184
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000BC96 File Offset: 0x00009E96
		public unsafe static TimeMsFunction _TimeSinceStartup_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeMsFunction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr__TimeSinceStartup_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00078FAC File Offset: 0x000771AC
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		public unsafe int _IMGUIContainersCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField)) = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00078FD4 File Offset: 0x000771D4
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000BCC3 File Offset: 0x00009EC3
		public unsafe IMGUIContainer _rootIMGUIContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00079004 File Offset: 0x00077204
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000BCE2 File Offset: 0x00009EE2
		public unsafe Shader m_StandardShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StandardShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_StandardShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00079034 File Offset: 0x00077234
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0000BD01 File Offset: 0x00009F01
		public unsafe AtlasBase m_Atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Atlas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtlasBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_Atlas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00079064 File Offset: 0x00077264
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0000BD20 File Offset: 0x00009F20
		public unsafe bool m_ValidatingLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_ValidatingLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Panel.NativeFieldInfoPtr_m_ValidatingLayout)) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x0007908C File Offset: 0x0007728C
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0000BD3B File Offset: 0x00009F3B
		public unsafe static Action<Panel> beforeAnyRepaint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Panel.NativeFieldInfoPtr_beforeAnyRepaint, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Panel.NativeFieldInfoPtr_beforeAnyRepaint, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000790B4 File Offset: 0x000772B4
		public VisualTreeUpdater visualTreeUpdater
		{
			get
			{
				return this.m_VisualTreeUpdater;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0000BD78 File Offset: 0x00009F78
		public override uint repaintVersion
		{
			get
			{
				return this.m_RepaintVersion;
			}
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000790FC File Offset: 0x000772FC
		public static Panel CreateEditorPanel(ScriptableObject ownerObject)
		{
			return new Panel(ownerObject, ContextType.Editor, EventDispatcher.CreateDefault());
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0007911C File Offset: 0x0007731C
		public static VisualElement PickAllWithoutValidatingLayout(VisualElement root, Vector2 point)
		{
			return Panel.PickAll(root, point, null, false);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00079138 File Offset: 0x00077338
		public void UpdateWithoutRepaint()
		{
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.ViewData);
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Bindings);
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Animation);
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Styles);
			this.m_VisualTreeUpdater.UpdateVisualTreePhase(VisualTreeUpdatePhase.Layout);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0000BD80 File Offset: 0x00009F80
		public static void add_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0000BD8D File Offset: 0x00009F8D
		public static void remove_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0000BD9A File Offset: 0x00009F9A
		public override void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			this.m_VisualTreeUpdater.SetUpdater(updater, phase);
		}

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_m_RootContainer;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_m_VisualTreeUpdater;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_m_StylePropertyAnimationSystem;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelName;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeFieldInfoPtr_m_RepaintVersion;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeFieldInfoPtr_m_HierarchyVersion;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerBeforeUpdate;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerUpdate;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerLayout;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerBindings;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_m_MarkerAnimations;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerPickAll;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr__dispatcher_k__BackingField;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr__ownerObject_k__BackingField;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr__contextType_k__BackingField;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr__saveViewData_k__BackingField;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr__getViewDataDictionary_k__BackingField;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr__focusController_k__BackingField;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr__IMGUIEventInterests_k__BackingField;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr__loadResourceFunc_k__BackingField;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeFieldInfoPtr_m_JustReceivedFocus;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceStartup_k__BackingField;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr__IMGUIContainersCount_k__BackingField;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr__rootIMGUIContainer_k__BackingField;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr_m_StandardShader;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_m_Atlas;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidatingLayout;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_beforeAnyRepaint;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Virtual_Final_get_VisualElement_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Virtual_Final_get_EventDispatcher_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatcher_Public_Virtual_Final_set_Void_EventDispatcher_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_get_timerEventScheduler_Public_get_TimerEventScheduler_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_get_scheduler_Internal_Virtual_get_IScheduler_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_get_styleAnimationSystem_Internal_Virtual_get_IStylePropertyAnimationSystem_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_set_styleAnimationSystem_Internal_Virtual_set_Void_IStylePropertyAnimationSystem_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_get_ownerObject_Public_Virtual_get_ScriptableObject_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_set_ownerObject_Protected_Virtual_set_Void_ScriptableObject_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Virtual_get_ContextType_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_set_contextType_Protected_Virtual_set_Void_ContextType_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_get_saveViewData_Public_Virtual_get_SavePersistentViewData_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_get_getViewDataDictionary_Public_Virtual_get_GetViewDataDictionary_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Virtual_Final_get_FocusController_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_set_focusController_Public_Virtual_Final_set_Void_FocusController_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Virtual_get_EventInterests_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_set_IMGUIEventInterests_Public_Virtual_set_Void_EventInterests_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_get_loadResourceFunc_Private_Static_get_LoadResourceFunction_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_LoadResource_Internal_Static_Object_String_Type_Single_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Internal_Void_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Internal_Void_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFocus_Public_Virtual_Void_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Internal_get_String_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Internal_set_Void_String_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarkers_Private_Void_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceStartup_Private_Static_get_TimeMsFunction_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Virtual_get_Int32_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_set_IMGUIContainersCount_Public_Virtual_set_Void_Int32_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Virtual_get_IMGUIContainer_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_Virtual_get_UInt32_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchyVersion_Internal_Virtual_get_UInt32_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_get_standardShader_Internal_Virtual_get_Shader_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_get_atlas_Public_Virtual_get_AtlasBase_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_set_atlas_Public_Virtual_set_Void_AtlasBase_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScriptableObject_ContextType_EventDispatcher_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_TimeSinceStartupMs_Public_Static_Int64_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_DefaultTimeSinceStartupMs_Internal_Static_Int64_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_PickAll_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_PerformPick_Private_Static_VisualElement_VisualElement_Vector2_List_1_VisualElement_Boolean_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_PickAll_Public_Virtual_VisualElement_Vector2_List_1_VisualElement_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_Pick_Public_Virtual_VisualElement_Vector2_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLayout_Public_Virtual_Void_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAnimations_Public_Virtual_Void_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindings_Public_Virtual_Void_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyles_Public_Virtual_Void_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_UpdateForRepaint_Private_Void_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_Repaint_Public_Virtual_Void_Event_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Internal_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdater_Internal_Virtual_IVisualTreeUpdater_VisualTreeUpdatePhase_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_0;
	}
}
