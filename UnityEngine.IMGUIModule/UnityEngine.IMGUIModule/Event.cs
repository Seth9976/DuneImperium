using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class Event : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004F38 File Offset: 0x00003138
		// Note: this type is marked as 'beforefieldinit'.
		static Event()
		{
			Il2CppClassPointerStore<Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "Event");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Event>.NativeClassPtr);
			Event.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "m_Ptr");
			Event.NativeFieldInfoPtr_s_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_Current");
			Event.NativeFieldInfoPtr_s_MasterEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Event>.NativeClassPtr, "s_MasterEvent");
			Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663297);
			Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663298);
			Event.NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663299);
			Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663300);
			Event.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663301);
			Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663302);
			Event.NativeMethodInfoPtr_get_button_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663303);
			Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663304);
			Event.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663305);
			Event.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663306);
			Event.NativeMethodInfoPtr_get_twist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663307);
			Event.NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663308);
			Event.NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663309);
			Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663310);
			Event.NativeMethodInfoPtr_get_character_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663311);
			Event.NativeMethodInfoPtr_set_character_Public_set_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663312);
			Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663313);
			Event.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663314);
			Event.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663315);
			Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663316);
			Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663317);
			Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663318);
			Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663319);
			Event.NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663320);
			Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663321);
			Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663322);
			Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663323);
			Event.NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663324);
			Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663325);
			Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663326);
			Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663327);
			Event.NativeMethodInfoPtr_GetDoubleClickTime_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663328);
			Event.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663329);
			Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663330);
			Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663331);
			Event.NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663332);
			Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663333);
			Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663334);
			Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663335);
			Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663336);
			Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663337);
			Event.NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663338);
			Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663339);
			Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663340);
			Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663341);
			Event.NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663342);
			Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663343);
			Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663344);
			Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663345);
			Event.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663346);
			Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663347);
			Event.NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663348);
			Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663349);
			Event.NativeMethodInfoPtr_set_delta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663350);
			Event.NativeMethodInfoPtr_get_tilt_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Event>.NativeClassPtr, 100663351);
			Event.set_pointerTypeDelegateField = IL2CPP.ResolveICall<Event.set_pointerTypeDelegate>("UnityEngine.Event::set_pointerType");
			Event.set_buttonDelegateField = IL2CPP.ResolveICall<Event.set_buttonDelegate>("UnityEngine.Event::set_button");
			Event.set_pressureDelegateField = IL2CPP.ResolveICall<Event.set_pressureDelegate>("UnityEngine.Event::set_pressure");
			Event.set_twistDelegateField = IL2CPP.ResolveICall<Event.set_twistDelegate>("UnityEngine.Event::set_twist");
			Event.set_penStatusDelegateField = IL2CPP.ResolveICall<Event.set_penStatusDelegate>("UnityEngine.Event::set_penStatus");
			Event.set_clickCountDelegateField = IL2CPP.ResolveICall<Event.set_clickCountDelegate>("UnityEngine.Event::set_clickCount");
			Event.Internal_CopyDelegateField = IL2CPP.ResolveICall<Event.Internal_CopyDelegate>("UnityEngine.Event::Internal_Copy");
			Event.GetTypeForControlDelegateField = IL2CPP.ResolveICall<Event.GetTypeForControlDelegate>("UnityEngine.Event::GetTypeForControl");
			Event.QueueEventDelegateField = IL2CPP.ResolveICall<Event.QueueEventDelegate>("UnityEngine.Event::QueueEvent");
			Event.GetEventCountDelegateField = IL2CPP.ResolveICall<Event.GetEventCountDelegate>("UnityEngine.Event::GetEventCount");
			Event.ClearEventsDelegateField = IL2CPP.ResolveICall<Event.ClearEventsDelegate>("UnityEngine.Event::ClearEvents");
			Event.set_tilt_InjectedDelegateField = IL2CPP.ResolveICall<Event.set_tilt_InjectedDelegate>("UnityEngine.Event::set_tilt_Injected");
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000054A4 File Offset: 0x000036A4
		public unsafe EventType rawType
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 1184741, RefRangeEnd = 1184780, XrefRangeStart = 1184739, XrefRangeEnd = 1184741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_rawType_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000054E0 File Offset: 0x000036E0
		// (set) Token: 0x06000004 RID: 4 RVA: 0x0000551C File Offset: 0x0000371C
		public unsafe Vector2 mousePosition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1184782, RefRangeEnd = 1184789, XrefRangeStart = 1184780, XrefRangeEnd = 1184782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184791, RefRangeEnd = 1184793, XrefRangeStart = 1184789, XrefRangeEnd = 1184791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000555C File Offset: 0x0000375C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00005598 File Offset: 0x00003798
		public unsafe Vector2 delta
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1184795, RefRangeEnd = 1184799, XrefRangeStart = 1184793, XrefRangeEnd = 1184795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184801, RefRangeEnd = 1184802, XrefRangeStart = 1184799, XrefRangeEnd = 1184801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe PointerType pointerType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1184804, RefRangeEnd = 1184809, XrefRangeStart = 1184802, XrefRangeEnd = 1184804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_pointerTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00005614 File Offset: 0x00003814
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000020AB File Offset: 0x000002AB
		public unsafe int button
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1184811, RefRangeEnd = 1184816, XrefRangeStart = 1184809, XrefRangeEnd = 1184811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_button_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_buttonDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00005650 File Offset: 0x00003850
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000568C File Offset: 0x0000388C
		public unsafe EventModifiers modifiers
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1184818, RefRangeEnd = 1184829, XrefRangeStart = 1184816, XrefRangeEnd = 1184818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184829, XrefRangeEnd = 1184831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000056CC File Offset: 0x000038CC
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000020BE File Offset: 0x000002BE
		public unsafe float pressure
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184833, RefRangeEnd = 1184835, XrefRangeStart = 1184831, XrefRangeEnd = 1184833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_pressureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00005708 File Offset: 0x00003908
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000020D1 File Offset: 0x000002D1
		public unsafe float twist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184837, RefRangeEnd = 1184838, XrefRangeStart = 1184835, XrefRangeEnd = 1184837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_twist_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_twistDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00005744 File Offset: 0x00003944
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe Vector2 tilt
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184840, RefRangeEnd = 1184841, XrefRangeStart = 1184838, XrefRangeEnd = 1184840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.set_tilt_Injected(ref value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00005780 File Offset: 0x00003980
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000020EE File Offset: 0x000002EE
		public unsafe PenStatus penStatus
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1184843, RefRangeEnd = 1184846, XrefRangeStart = 1184841, XrefRangeEnd = 1184843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_penStatusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000057BC File Offset: 0x000039BC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002101 File Offset: 0x00000301
		public unsafe int clickCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184848, RefRangeEnd = 1184850, XrefRangeStart = 1184846, XrefRangeEnd = 1184848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Event.set_clickCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000057F8 File Offset: 0x000039F8
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00005834 File Offset: 0x00003A34
		public unsafe char character
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1184852, RefRangeEnd = 1184856, XrefRangeStart = 1184850, XrefRangeEnd = 1184852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_character_Public_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184858, RefRangeEnd = 1184860, XrefRangeStart = 1184856, XrefRangeEnd = 1184858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_character_Public_set_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00005874 File Offset: 0x00003A74
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000058B0 File Offset: 0x00003AB0
		public unsafe KeyCode keyCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1184862, RefRangeEnd = 1184865, XrefRangeStart = 1184860, XrefRangeEnd = 1184862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184867, RefRangeEnd = 1184868, XrefRangeStart = 1184865, XrefRangeEnd = 1184867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000058F0 File Offset: 0x00003AF0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000592C File Offset: 0x00003B2C
		public unsafe int displayIndex
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184870, RefRangeEnd = 1184872, XrefRangeStart = 1184868, XrefRangeEnd = 1184870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1184874, RefRangeEnd = 1184876, XrefRangeStart = 1184872, XrefRangeEnd = 1184874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000596C File Offset: 0x00003B6C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000059A8 File Offset: 0x00003BA8
		public unsafe EventType type
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1184878, RefRangeEnd = 1184912, XrefRangeStart = 1184876, XrefRangeEnd = 1184878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_type_Public_get_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1184914, RefRangeEnd = 1184919, XrefRangeStart = 1184912, XrefRangeEnd = 1184914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000059E8 File Offset: 0x00003BE8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00005A20 File Offset: 0x00003C20
		public unsafe string commandName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1184921, RefRangeEnd = 1184924, XrefRangeStart = 1184919, XrefRangeEnd = 1184921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_commandName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1184926, RefRangeEnd = 1184927, XrefRangeStart = 1184924, XrefRangeEnd = 1184926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005A64 File Offset: 0x00003C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184927, XrefRangeEnd = 1184929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Use_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005A98 File Offset: 0x00003C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184929, XrefRangeEnd = 1184931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184931, XrefRangeEnd = 1184933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005B0C File Offset: 0x00003D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1184935, RefRangeEnd = 1184936, XrefRangeStart = 1184933, XrefRangeEnd = 1184935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFromPtr(IntPtr ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005B4C File Offset: 0x00003D4C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1184938, RefRangeEnd = 1184946, XrefRangeStart = 1184936, XrefRangeEnd = 1184938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PopEvent(Event outEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005B90 File Offset: 0x00003D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184946, XrefRangeEnd = 1184948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SetNativeEvent(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184948, XrefRangeEnd = 1184967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MakeMasterEventCurrent(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1184969, RefRangeEnd = 1184972, XrefRangeStart = 1184967, XrefRangeEnd = 1184969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDoubleClickTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetDoubleClickTime_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005C28 File Offset: 0x00003E28
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1184975, RefRangeEnd = 1184984, XrefRangeStart = 1184972, XrefRangeEnd = 1184975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005C64 File Offset: 0x00003E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184984, XrefRangeEnd = 1184987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Event(int displayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Event>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005CAC File Offset: 0x00003EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184987, XrefRangeEnd = 1184993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005CE0 File Offset: 0x00003EE0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1184996, RefRangeEnd = 1185002, XrefRangeStart = 1184993, XrefRangeEnd = 1184996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00005D24 File Offset: 0x00003F24
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000624C File Offset: 0x0000444C
		public unsafe bool shift
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1185004, RefRangeEnd = 1185007, XrefRangeStart = 1185002, XrefRangeEnd = 1185004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_shift_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00005D60 File Offset: 0x00003F60
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00006284 File Offset: 0x00004484
		public unsafe bool control
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185007, XrefRangeEnd = 1185009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_control_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Control;
				}
				else
				{
					this.modifiers |= EventModifiers.Control;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00005D9C File Offset: 0x00003F9C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000062BC File Offset: 0x000044BC
		public unsafe bool alt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185009, XrefRangeEnd = 1185011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_alt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Alt;
				}
				else
				{
					this.modifiers |= EventModifiers.Alt;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00005DD8 File Offset: 0x00003FD8
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000062F4 File Offset: 0x000044F4
		public unsafe bool command
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185011, XrefRangeEnd = 1185013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_command_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Command;
				}
				else
				{
					this.modifiers |= EventModifiers.Command;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00005E14 File Offset: 0x00004014
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00005E48 File Offset: 0x00004048
		public unsafe static Event current
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1185015, RefRangeEnd = 1185041, XrefRangeStart = 1185013, XrefRangeEnd = 1185015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_current_Public_Static_get_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185049, RefRangeEnd = 1185050, XrefRangeStart = 1185041, XrefRangeEnd = 1185049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005E80 File Offset: 0x00004080
		public unsafe bool isKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185052, RefRangeEnd = 1185053, XrefRangeStart = 1185050, XrefRangeEnd = 1185052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00005EBC File Offset: 0x000040BC
		public unsafe bool isMouse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185055, RefRangeEnd = 1185056, XrefRangeStart = 1185053, XrefRangeEnd = 1185055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00005EF8 File Offset: 0x000040F8
		public unsafe bool isDirectManipulationDevice
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185058, RefRangeEnd = 1185059, XrefRangeStart = 1185056, XrefRangeEnd = 1185058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005F34 File Offset: 0x00004134
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1185195, RefRangeEnd = 1185199, XrefRangeStart = 1185059, XrefRangeEnd = 1185195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Event KeyboardEvent(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Event>(intPtr3) : null;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005F78 File Offset: 0x00004178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185199, XrefRangeEnd = 1185211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005FB4 File Offset: 0x000041B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185211, XrefRangeEnd = 1185231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006004 File Offset: 0x00004204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185231, XrefRangeEnd = 1185350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000603C File Offset: 0x0000423C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1185373, RefRangeEnd = 1185378, XrefRangeStart = 1185350, XrefRangeEnd = 1185373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006070 File Offset: 0x00004270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185378, XrefRangeEnd = 1185380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_mousePosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000060B0 File Offset: 0x000042B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185380, XrefRangeEnd = 1185382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_mousePosition_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000060F0 File Offset: 0x000042F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185382, XrefRangeEnd = 1185384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_delta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006130 File Offset: 0x00004330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185384, XrefRangeEnd = 1185386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_delta_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_set_delta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006170 File Offset: 0x00004370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185386, XrefRangeEnd = 1185388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_tilt_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Event.NativeMethodInfoPtr_get_tilt_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		public Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000061B0 File Offset: 0x000043B0
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Event.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000061D8 File Offset: 0x000043D8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe static Event s_Current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_Current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_Current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006200 File Offset: 0x00004400
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe static Event s_MasterEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Event.NativeFieldInfoPtr_s_MasterEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Event.NativeFieldInfoPtr_s_MasterEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002114 File Offset: 0x00000314
		public static IntPtr Internal_Copy(IntPtr otherPtr)
		{
			return Event.Internal_CopyDelegateField(otherPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002121 File Offset: 0x00000321
		public EventType GetTypeForControl(int controlID)
		{
			return Event.GetTypeForControlDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), controlID);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002134 File Offset: 0x00000334
		public static void QueueEvent(Event outEvent)
		{
			Event.QueueEventDelegateField(IL2CPP.Il2CppObjectBaseToPtr(outEvent));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002146 File Offset: 0x00000346
		public static int GetEventCount()
		{
			return Event.GetEventCountDelegateField();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002152 File Offset: 0x00000352
		public static void ClearEvents()
		{
			Event.ClearEventsDelegateField();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000215E File Offset: 0x0000035E
		public static void CleanupRoots()
		{
			Event.s_Current = null;
			Event.s_MasterEvent = null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00006228 File Offset: 0x00004428
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000216D File Offset: 0x0000036D
		public Ray mouseRay
		{
			get
			{
				return new Ray(Vector3.up, Vector3.up);
			}
			set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000632C File Offset: 0x0000452C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000634C File Offset: 0x0000454C
		public bool capsLock
		{
			get
			{
				return (this.modifiers & EventModifiers.CapsLock) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.CapsLock;
				}
				else
				{
					this.modifiers |= EventModifiers.CapsLock;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006384 File Offset: 0x00004584
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000063A4 File Offset: 0x000045A4
		public bool numeric
		{
			get
			{
				return (this.modifiers & EventModifiers.Numeric) > EventModifiers.None;
			}
			set
			{
				bool flag = !value;
				if (flag)
				{
					this.modifiers &= ~EventModifiers.Numeric;
				}
				else
				{
					this.modifiers |= EventModifiers.Numeric;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002170 File Offset: 0x00000370
		public bool functionKey
		{
			get
			{
				return (this.modifiers & EventModifiers.FunctionKey) > EventModifiers.None;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000063DC File Offset: 0x000045DC
		public bool isScrollWheel
		{
			get
			{
				EventType type = this.type;
				return type == EventType.ScrollWheel;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000217E File Offset: 0x0000037E
		public void set_tilt_Injected(ref Vector2 value)
		{
			Event.set_tilt_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_s_Current;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_s_MasterEvent;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_rawType_Public_get_EventType_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_get_Vector2_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Public_set_Void_Vector2_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_get_PointerType_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_get_EventModifiers_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Public_set_Void_EventModifiers_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_get_Single_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Public_get_Vector2_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_penStatus_Public_get_PenStatus_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_character_Public_get_Char_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_character_Public_set_Void_Char_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_keyCode_Public_get_KeyCode_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_keyCode_Public_set_Void_KeyCode_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_displayIndex_Public_get_Int32_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_displayIndex_Public_set_Void_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_EventType_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_EventType_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_commandName_Public_get_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_commandName_Public_set_Void_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Use_Private_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromPtr_Internal_Void_IntPtr_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_PopEvent_Public_Static_Boolean_Event_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SetNativeEvent_Private_Static_Void_IntPtr_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakeMasterEventCurrent_Internal_Static_Void_Int32_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetDoubleClickTime_Internal_Static_Int32_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_Event_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_shift_Public_get_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_control_Public_get_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_alt_Public_get_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_command_Public_get_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Event_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Public_Static_set_Void_Event_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_get_isKey_Public_get_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_isMouse_Public_get_Boolean_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_isDirectManipulationDevice_Internal_get_Boolean_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_KeyboardEvent_Public_Static_Event_String_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0400003B RID: 59
		private static readonly Event.set_pointerTypeDelegate set_pointerTypeDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly Event.set_buttonDelegate set_buttonDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly Event.set_pressureDelegate set_pressureDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly Event.set_twistDelegate set_twistDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly Event.set_penStatusDelegate set_penStatusDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly Event.set_clickCountDelegate set_clickCountDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly Event.Internal_CopyDelegate Internal_CopyDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly Event.GetTypeForControlDelegate GetTypeForControlDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly Event.QueueEventDelegate QueueEventDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly Event.GetEventCountDelegate GetEventCountDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly Event.ClearEventsDelegate ClearEventsDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly Event.set_tilt_InjectedDelegate set_tilt_InjectedDelegateField;

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600068A RID: 1674
		private delegate void set_pointerTypeDelegate(IntPtr @this, PointerType value);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600068C RID: 1676
		private delegate void set_buttonDelegate(IntPtr @this, int value);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600068E RID: 1678
		private delegate void set_pressureDelegate(IntPtr @this, float value);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000690 RID: 1680
		private delegate void set_twistDelegate(IntPtr @this, float value);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000692 RID: 1682
		private delegate void set_penStatusDelegate(IntPtr @this, PenStatus value);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000694 RID: 1684
		private delegate void set_clickCountDelegate(IntPtr @this, int value);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate IntPtr Internal_CopyDelegate(IntPtr otherPtr);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate EventType GetTypeForControlDelegate(IntPtr @this, int controlID);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate void QueueEventDelegate(IntPtr outEvent);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate int GetEventCountDelegate();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate void ClearEventsDelegate();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate void set_tilt_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
