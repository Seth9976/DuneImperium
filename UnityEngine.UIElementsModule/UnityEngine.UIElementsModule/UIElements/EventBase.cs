using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CD RID: 205
	public class EventBase : Object
	{
		// Token: 0x060011F4 RID: 4596 RVA: 0x0005BCF8 File Offset: 0x00059EF8
		// Note: this type is marked as 'beforefieldinit'.
		static EventBase()
		{
			Il2CppClassPointerStore<EventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBase>.NativeClassPtr);
			EventBase.NativeFieldInfoPtr_s_LastTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "s_LastTypeId");
			EventBase.NativeFieldInfoPtr__eventCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<eventCategory>k__BackingField");
			EventBase.NativeFieldInfoPtr_s_NextEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "s_NextEventId");
			EventBase.NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<timestamp>k__BackingField");
			EventBase.NativeFieldInfoPtr__eventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<eventId>k__BackingField");
			EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<triggerEventId>k__BackingField");
			EventBase.NativeFieldInfoPtr__propagation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<propagation>k__BackingField");
			EventBase.NativeFieldInfoPtr__path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<path>k__BackingField");
			EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<lifeCycleStatus>k__BackingField");
			EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<leafTarget>k__BackingField");
			EventBase.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_Target");
			EventBase.NativeFieldInfoPtr__skipElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<skipElements>k__BackingField");
			EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<propagationPhase>k__BackingField");
			EventBase.NativeFieldInfoPtr_m_CurrentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_CurrentTarget");
			EventBase.NativeFieldInfoPtr_m_ImguiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "m_ImguiEvent");
			EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase>.NativeClassPtr, "<originalMousePosition>k__BackingField");
			EventBase.NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665842);
			EventBase.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665843);
			EventBase.NativeMethodInfoPtr_get_eventCategory_Internal_get_EventCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665844);
			EventBase.NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665845);
			EventBase.NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665846);
			EventBase.NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665847);
			EventBase.NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665848);
			EventBase.NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665849);
			EventBase.NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665850);
			EventBase.NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665851);
			EventBase.NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665852);
			EventBase.NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665853);
			EventBase.NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665854);
			EventBase.NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665855);
			EventBase.NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665856);
			EventBase.NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665857);
			EventBase.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665858);
			EventBase.NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665859);
			EventBase.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665860);
			EventBase.NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665861);
			EventBase.NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665862);
			EventBase.NativeMethodInfoPtr_get_bubblesOrTricklesDown_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665863);
			EventBase.NativeMethodInfoPtr_get_skipDisabledElements_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665864);
			EventBase.NativeMethodInfoPtr_set_skipDisabledElements_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665865);
			EventBase.NativeMethodInfoPtr_get_ignoreCompositeRoots_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665866);
			EventBase.NativeMethodInfoPtr_set_ignoreCompositeRoots_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665867);
			EventBase.NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665868);
			EventBase.NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665869);
			EventBase.NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665870);
			EventBase.NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665871);
			EventBase.NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665872);
			EventBase.NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665873);
			EventBase.NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665874);
			EventBase.NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665875);
			EventBase.NativeMethodInfoPtr_StopPropagation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665876);
			EventBase.NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665877);
			EventBase.NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665878);
			EventBase.NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665879);
			EventBase.NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665880);
			EventBase.NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665881);
			EventBase.NativeMethodInfoPtr_PreventDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665882);
			EventBase.NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665883);
			EventBase.NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665884);
			EventBase.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665885);
			EventBase.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665886);
			EventBase.NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665887);
			EventBase.NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665888);
			EventBase.NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665889);
			EventBase.NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665890);
			EventBase.NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665891);
			EventBase.NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665892);
			EventBase.NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665893);
			EventBase.NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665894);
			EventBase.NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665895);
			EventBase.NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665896);
			EventBase.NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665897);
			EventBase.NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665898);
			EventBase.NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665899);
			EventBase.NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665900);
			EventBase.NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665901);
			EventBase.NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665902);
			EventBase.NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665903);
			EventBase.NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665904);
			EventBase.NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665905);
			EventBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665906);
			EventBase.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665907);
			EventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665908);
			EventBase.NativeMethodInfoPtr__ctor_Internal_Void_EventCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665909);
			EventBase.NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665910);
			EventBase.NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665911);
			EventBase.NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665912);
			EventBase.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase>.NativeClassPtr, 100665913);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0005C408 File Offset: 0x0005A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312310, XrefRangeEnd = 312312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long RegisterEventType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0005C438 File Offset: 0x0005A638
		public unsafe virtual long eventTypeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0005C480 File Offset: 0x0005A680
		public unsafe EventCategory eventCategory
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_eventCategory_Internal_get_EventCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0005C4BC File Offset: 0x0005A6BC
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
		public unsafe long timestamp
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0005C538 File Offset: 0x0005A738
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0005C574 File Offset: 0x0005A774
		public unsafe ulong eventId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000091B6 File Offset: 0x000073B6
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x0005C5B4 File Offset: 0x0005A7B4
		public unsafe ulong triggerEventId
		{
			get
			{
				return this._triggerEventId_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0005C5F4 File Offset: 0x0005A7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTriggerEventId(ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0005C634 File Offset: 0x0005A834
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0005C670 File Offset: 0x0005A870
		public unsafe EventBase.EventPropagation propagation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0005C6B0 File Offset: 0x0005A8B0
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0005C6F0 File Offset: 0x0005A8F0
		public unsafe PropagationPaths path
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0005C734 File Offset: 0x0005A934
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0005C770 File Offset: 0x0005A970
		public unsafe EventBase.LifeCycleStatus lifeCycleStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreDispatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0005C7EC File Offset: 0x0005A9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312313, RefRangeEnd = 312315, XrefRangeStart = 312313, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0005C83C File Offset: 0x0005AA3C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostDispatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0005C878 File Offset: 0x0005AA78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312315, RefRangeEnd = 312317, XrefRangeStart = 312315, XrefRangeEnd = 312315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x0005D84C File Offset: 0x0005BA4C
		public unsafe bool bubbles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312317, RefRangeEnd = 312318, XrefRangeStart = 312317, XrefRangeEnd = 312317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.Bubbles;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.Bubbles;
				}
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x0005C904 File Offset: 0x0005AB04
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0005D884 File Offset: 0x0005BA84
		public unsafe bool tricklesDown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312318, RefRangeEnd = 312319, XrefRangeStart = 312318, XrefRangeEnd = 312318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				if (value)
				{
					this.propagation |= EventBase.EventPropagation.TricklesDown;
				}
				else
				{
					this.propagation &= ~EventBase.EventPropagation.TricklesDown;
				}
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0005C940 File Offset: 0x0005AB40
		public unsafe bool bubblesOrTricklesDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_bubblesOrTricklesDown_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0005C97C File Offset: 0x0005AB7C
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x0005C9B8 File Offset: 0x0005ABB8
		public unsafe bool skipDisabledElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_skipDisabledElements_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_skipDisabledElements_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x0005C9F8 File Offset: 0x0005ABF8
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x0005CA34 File Offset: 0x0005AC34
		public unsafe bool ignoreCompositeRoots
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312319, RefRangeEnd = 312320, XrefRangeStart = 312319, XrefRangeEnd = 312319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_ignoreCompositeRoots_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 312320, RefRangeEnd = 312324, XrefRangeStart = 312320, XrefRangeEnd = 312320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_ignoreCompositeRoots_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0005CA74 File Offset: 0x0005AC74
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x0005CAB4 File Offset: 0x0005ACB4
		public unsafe IEventHandler leafTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312324, XrefRangeEnd = 312325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0005CB38 File Offset: 0x0005AD38
		public unsafe IEventHandler target
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 312325, RefRangeEnd = 312368, XrefRangeStart = 312325, XrefRangeEnd = 312325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 312370, RefRangeEnd = 312423, XrefRangeStart = 312368, XrefRangeEnd = 312370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0005CB7C File Offset: 0x0005AD7C
		public unsafe List<IEventHandler> skipElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IEventHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0005CBBC File Offset: 0x0005ADBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312427, RefRangeEnd = 312428, XrefRangeStart = 312423, XrefRangeEnd = 312427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Skip(IEventHandler h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x0005CC0C File Offset: 0x0005AE0C
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x0005CC48 File Offset: 0x0005AE48
		public unsafe bool isPropagationStopped
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 312428, RefRangeEnd = 312440, XrefRangeStart = 312428, XrefRangeEnd = 312428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0005CC88 File Offset: 0x0005AE88
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 312440, RefRangeEnd = 312498, XrefRangeStart = 312440, XrefRangeEnd = 312440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPropagation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_StopPropagation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x0005CCBC File Offset: 0x0005AEBC
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
		public unsafe bool isImmediatePropagationStopped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312498, RefRangeEnd = 312499, XrefRangeStart = 312498, XrefRangeEnd = 312498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0005CD38 File Offset: 0x0005AF38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 312499, RefRangeEnd = 312506, XrefRangeStart = 312499, XrefRangeEnd = 312499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopImmediatePropagation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
		public unsafe bool isDefaultPrevented
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 312506, RefRangeEnd = 312510, XrefRangeStart = 312506, XrefRangeEnd = 312506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0005CDE8 File Offset: 0x0005AFE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 312510, RefRangeEnd = 312518, XrefRangeStart = 312510, XrefRangeEnd = 312510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreventDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_PreventDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x0005CE1C File Offset: 0x0005B01C
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0005CE58 File Offset: 0x0005B058
		public unsafe PropagationPhase propagationPhase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0005CE98 File Offset: 0x0005B098
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x0005CEE4 File Offset: 0x0005B0E4
		public unsafe virtual IEventHandler currentTarget
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312534, RefRangeEnd = 312536, XrefRangeStart = 312534, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312542, RefRangeEnd = 312544, XrefRangeStart = 312536, XrefRangeEnd = 312542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x0005CF34 File Offset: 0x0005B134
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x0005CF70 File Offset: 0x0005B170
		public unsafe bool dispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0005CFB0 File Offset: 0x0005B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312544, XrefRangeEnd = 312550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkReceivedByDispatcher()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0005CFE4 File Offset: 0x0005B1E4
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0005D020 File Offset: 0x0005B220
		public unsafe bool dispatched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x0005D060 File Offset: 0x0005B260
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0005D09C File Offset: 0x0005B29C
		public unsafe bool processed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312550, RefRangeEnd = 312551, XrefRangeStart = 312550, XrefRangeEnd = 312550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x0005D0DC File Offset: 0x0005B2DC
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0005D118 File Offset: 0x0005B318
		public unsafe bool processedByFocusController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 312551, RefRangeEnd = 312554, XrefRangeStart = 312551, XrefRangeEnd = 312551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312554, RefRangeEnd = 312556, XrefRangeStart = 312554, XrefRangeEnd = 312554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0005D158 File Offset: 0x0005B358
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0005D194 File Offset: 0x0005B394
		public unsafe bool stopDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312556, RefRangeEnd = 312558, XrefRangeStart = 312556, XrefRangeEnd = 312556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0005D1D4 File Offset: 0x0005B3D4
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x0005D210 File Offset: 0x0005B410
		public unsafe bool propagateToIMGUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 312558, RefRangeEnd = 312567, XrefRangeStart = 312558, XrefRangeEnd = 312558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x0005D250 File Offset: 0x0005B450
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x0005D28C File Offset: 0x0005B48C
		public unsafe bool imguiEventIsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x0005D2CC File Offset: 0x0005B4CC
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0005D30C File Offset: 0x0005B50C
		public unsafe Event imguiEvent
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 312567, RefRangeEnd = 312586, XrefRangeStart = 312567, XrefRangeEnd = 312567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 312591, RefRangeEnd = 312598, XrefRangeStart = 312586, XrefRangeEnd = 312591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x0005D350 File Offset: 0x0005B550
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x0005D38C File Offset: 0x0005B58C
		public unsafe Vector2 originalMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0005D3CC File Offset: 0x0005B5CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312599, RefRangeEnd = 312600, XrefRangeStart = 312598, XrefRangeEnd = 312599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0005D408 File Offset: 0x0005B608
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312616, RefRangeEnd = 312619, XrefRangeStart = 312600, XrefRangeEnd = 312616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0005D43C File Offset: 0x0005B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312619, XrefRangeEnd = 312629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0005D478 File Offset: 0x0005B678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312639, RefRangeEnd = 312640, XrefRangeStart = 312629, XrefRangeEnd = 312639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventBase(EventCategory category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr__ctor_Internal_Void_EventCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0005D4C0 File Offset: 0x0005B6C0
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0005D4FC File Offset: 0x0005B6FC
		public unsafe bool pooled
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 312640, RefRangeEnd = 312642, XrefRangeStart = 312640, XrefRangeEnd = 312640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 312642, RefRangeEnd = 312646, XrefRangeStart = 312642, XrefRangeEnd = 312642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase.NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0005D53C File Offset: 0x0005B73C
		[CallerCount(0)]
		public unsafe virtual void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0005D578 File Offset: 0x0005B778
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00008FFF File Offset: 0x000071FF
		public EventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00009008 File Offset: 0x00007208
		public unsafe static long s_LastTypeId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(EventBase.NativeFieldInfoPtr_s_LastTypeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase.NativeFieldInfoPtr_s_LastTypeId, (void*)(&value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00009016 File Offset: 0x00007216
		public unsafe EventCategory _eventCategory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventCategory_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventCategory_k__BackingField)) = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0005D5F8 File Offset: 0x0005B7F8
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00009031 File Offset: 0x00007231
		public unsafe static ulong s_NextEventId
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(EventBase.NativeFieldInfoPtr_s_NextEventId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase.NativeFieldInfoPtr_s_NextEventId, (void*)(&value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0005D614 File Offset: 0x0005B814
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000903F File Offset: 0x0000723F
		public unsafe long _timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__timestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__timestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x0005D63C File Offset: 0x0005B83C
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000905A File Offset: 0x0000725A
		public unsafe ulong _eventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__eventId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x0005D664 File Offset: 0x0005B864
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x00009075 File Offset: 0x00007275
		public unsafe ulong _triggerEventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__triggerEventId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0005D68C File Offset: 0x0005B88C
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00009090 File Offset: 0x00007290
		public unsafe EventBase.EventPropagation _propagation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0005D6B4 File Offset: 0x0005B8B4
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x000090AB File Offset: 0x000072AB
		public unsafe PropagationPaths _path_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__path_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropagationPaths>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0005D6E4 File Offset: 0x0005B8E4
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x000090CA File Offset: 0x000072CA
		public unsafe EventBase.LifeCycleStatus _lifeCycleStatus_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__lifeCycleStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0005D70C File Offset: 0x0005B90C
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x000090E5 File Offset: 0x000072E5
		public unsafe IEventHandler _leafTarget_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__leafTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0005D73C File Offset: 0x0005B93C
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00009104 File Offset: 0x00007304
		public unsafe IEventHandler m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0005D76C File Offset: 0x0005B96C
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x00009123 File Offset: 0x00007323
		public unsafe List<IEventHandler> _skipElements_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__skipElements_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEventHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__skipElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0005D79C File Offset: 0x0005B99C
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x00009142 File Offset: 0x00007342
		public unsafe PropagationPhase _propagationPhase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__propagationPhase_k__BackingField)) = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0005D7C4 File Offset: 0x0005B9C4
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000915D File Offset: 0x0000735D
		public unsafe IEventHandler m_CurrentTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_CurrentTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_CurrentTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0005D7F4 File Offset: 0x0005B9F4
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000917C File Offset: 0x0000737C
		public unsafe Event m_ImguiEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_ImguiEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr_m_ImguiEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0005D824 File Offset: 0x0005BA24
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x0000919B File Offset: 0x0000739B
		public unsafe Vector2 _originalMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase.NativeFieldInfoPtr__originalMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_s_LastTypeId;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr__eventCategory_k__BackingField;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_s_NextEventId;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr__timestamp_k__BackingField;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr__eventId_k__BackingField;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr__triggerEventId_k__BackingField;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr__propagation_k__BackingField;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr__path_k__BackingField;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr__lifeCycleStatus_k__BackingField;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr__leafTarget_k__BackingField;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr__skipElements_k__BackingField;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr__propagationPhase_k__BackingField;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTarget;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_m_ImguiEvent;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeFieldInfoPtr__originalMousePosition_k__BackingField;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventType_Protected_Static_Int64_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_New_get_Int64_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCategory_Internal_get_EventCategory_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_get_timestamp_Public_get_Int64_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_set_timestamp_Private_set_Void_Int64_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_get_eventId_Internal_get_UInt64_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_set_eventId_Private_set_Void_UInt64_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_set_triggerEventId_Private_set_Void_UInt64_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_SetTriggerEventId_Internal_Void_UInt64_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_get_propagation_Internal_get_EventPropagation_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_set_propagation_Internal_set_Void_EventPropagation_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_get_path_Internal_get_PropagationPaths_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_set_path_Internal_set_Void_PropagationPaths_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_get_lifeCycleStatus_Private_get_LifeCycleStatus_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_set_lifeCycleStatus_Private_set_Void_LifeCycleStatus_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_Protected_Virtual_New_Void_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_New_Void_IPanel_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_Protected_Virtual_New_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_New_Void_IPanel_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_get_bubbles_Public_get_Boolean_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_get_tricklesDown_Public_get_Boolean_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_get_bubblesOrTricklesDown_Internal_get_Boolean_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_get_skipDisabledElements_Internal_get_Boolean_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_set_skipDisabledElements_Internal_set_Void_Boolean_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreCompositeRoots_Internal_get_Boolean_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreCompositeRoots_Internal_set_Void_Boolean_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_get_leafTarget_Internal_get_IEventHandler_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_set_leafTarget_Private_set_Void_IEventHandler_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_IEventHandler_0;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Public_set_Void_IEventHandler_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_get_skipElements_Internal_get_List_1_IEventHandler_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Internal_Boolean_IEventHandler_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_get_isPropagationStopped_Public_get_Boolean_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_set_isPropagationStopped_Private_set_Void_Boolean_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_StopPropagation_Public_Void_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_get_isImmediatePropagationStopped_Public_get_Boolean_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_set_isImmediatePropagationStopped_Private_set_Void_Boolean_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_StopImmediatePropagation_Public_Void_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultPrevented_Public_get_Boolean_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultPrevented_Private_set_Void_Boolean_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_PreventDefault_Public_Void_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_propagationPhase_Public_get_PropagationPhase_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_set_propagationPhase_Internal_set_Void_PropagationPhase_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_New_get_IEventHandler_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_New_set_Void_IEventHandler_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatch_Public_get_Boolean_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatch_Internal_set_Void_Boolean_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_MarkReceivedByDispatcher_Internal_Void_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatched_Private_get_Boolean_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_set_dispatched_Private_set_Void_Boolean_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_get_processed_Internal_get_Boolean_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_set_processed_Private_set_Void_Boolean_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_get_processedByFocusController_Internal_get_Boolean_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_set_processedByFocusController_Internal_set_Void_Boolean_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_get_stopDispatch_Internal_get_Boolean_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_set_stopDispatch_Internal_set_Void_Boolean_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_get_propagateToIMGUI_Internal_get_Boolean_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr_set_propagateToIMGUI_Internal_set_Void_Boolean_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiEventIsValid_Private_get_Boolean_0;

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiEventIsValid_Private_set_Void_Boolean_0;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_get_imguiEvent_Public_get_Event_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_set_imguiEvent_Protected_set_Void_Event_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_get_originalMousePosition_Public_get_Vector2_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_set_originalMousePosition_Private_set_Void_Vector2_0;

		// Token: 0x04000C95 RID: 3221
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_New_Void_0;

		// Token: 0x04000C96 RID: 3222
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventCategory_0;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeMethodInfoPtr_get_pooled_Protected_get_Boolean_0;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_set_pooled_Protected_set_Void_Boolean_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x020003F8 RID: 1016
		[Flags]
		public enum EventPropagation
		{
			// Token: 0x04002976 RID: 10614
			None = 0,
			// Token: 0x04002977 RID: 10615
			Bubbles = 1,
			// Token: 0x04002978 RID: 10616
			TricklesDown = 2,
			// Token: 0x04002979 RID: 10617
			Cancellable = 4,
			// Token: 0x0400297A RID: 10618
			SkipDisabledElements = 8,
			// Token: 0x0400297B RID: 10619
			IgnoreCompositeRoots = 16
		}

		// Token: 0x020003F9 RID: 1017
		[Flags]
		public enum LifeCycleStatus
		{
			// Token: 0x0400297D RID: 10621
			None = 0,
			// Token: 0x0400297E RID: 10622
			PropagationStopped = 1,
			// Token: 0x0400297F RID: 10623
			ImmediatePropagationStopped = 2,
			// Token: 0x04002980 RID: 10624
			DefaultPrevented = 4,
			// Token: 0x04002981 RID: 10625
			Dispatching = 8,
			// Token: 0x04002982 RID: 10626
			Pooled = 16,
			// Token: 0x04002983 RID: 10627
			IMGUIEventIsValid = 32,
			// Token: 0x04002984 RID: 10628
			StopDispatch = 64,
			// Token: 0x04002985 RID: 10629
			PropagateToIMGUI = 128,
			// Token: 0x04002986 RID: 10630
			Dispatched = 512,
			// Token: 0x04002987 RID: 10631
			Processed = 1024,
			// Token: 0x04002988 RID: 10632
			ProcessedByFocusController = 2048
		}
	}
}
