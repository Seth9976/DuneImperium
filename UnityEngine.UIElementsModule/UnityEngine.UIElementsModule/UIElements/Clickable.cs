using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000025 RID: 37
	public class Clickable : PointerManipulator
	{
		// Token: 0x06000245 RID: 581 RVA: 0x0002479C File Offset: 0x0002299C
		// Note: this type is marked as 'beforefieldinit'.
		static Clickable()
		{
			Il2CppClassPointerStore<Clickable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Clickable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clickable>.NativeClassPtr);
			Clickable.NativeFieldInfoPtr_clickedWithEventInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "clickedWithEventInfo");
			Clickable.NativeFieldInfoPtr_clicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "clicked");
			Clickable.NativeFieldInfoPtr_m_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "m_Delay");
			Clickable.NativeFieldInfoPtr_m_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "m_Interval");
			Clickable.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<active>k__BackingField");
			Clickable.NativeFieldInfoPtr__lastMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "<lastMousePosition>k__BackingField");
			Clickable.NativeFieldInfoPtr_m_ActivePointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "m_ActivePointerId");
			Clickable.NativeFieldInfoPtr_m_AcceptClicksIfDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "m_AcceptClicksIfDisabled");
			Clickable.NativeFieldInfoPtr_m_Repeater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clickable>.NativeClassPtr, "m_Repeater");
			Clickable.NativeMethodInfoPtr_add_clickedWithEventInfo_Public_add_Void_Action_1_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663583);
			Clickable.NativeMethodInfoPtr_remove_clickedWithEventInfo_Public_rem_Void_Action_1_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663584);
			Clickable.NativeMethodInfoPtr_add_clicked_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663585);
			Clickable.NativeMethodInfoPtr_remove_clicked_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663586);
			Clickable.NativeMethodInfoPtr_get_active_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663587);
			Clickable.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663588);
			Clickable.NativeMethodInfoPtr_get_lastMousePosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663589);
			Clickable.NativeMethodInfoPtr_set_lastMousePosition_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663590);
			Clickable.NativeMethodInfoPtr_get_acceptClicksIfDisabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663591);
			Clickable.NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663592);
			Clickable.NativeMethodInfoPtr_get_invokePolicy_Private_get_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663593);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663594);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_1_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663595);
			Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663596);
			Clickable.NativeMethodInfoPtr_OnTimer_Private_Void_TimerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663597);
			Clickable.NativeMethodInfoPtr_IsRepeatable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663598);
			Clickable.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663599);
			Clickable.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663600);
			Clickable.NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663601);
			Clickable.NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663602);
			Clickable.NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663603);
			Clickable.NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663604);
			Clickable.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663605);
			Clickable.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663606);
			Clickable.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663607);
			Clickable.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663608);
			Clickable.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663609);
			Clickable.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663610);
			Clickable.NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663611);
			Clickable.NativeMethodInfoPtr_Invoke_Protected_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663612);
			Clickable.NativeMethodInfoPtr_SimulateSingleClick_Internal_Void_EventBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663613);
			Clickable.NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663614);
			Clickable.NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_New_Void_EventBase_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663615);
			Clickable.NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663616);
			Clickable.NativeMethodInfoPtr_ProcessCancelEvent_Protected_Virtual_New_Void_EventBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663617);
			Clickable.NativeMethodInfoPtr__SimulateSingleClick_b__43_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clickable>.NativeClassPtr, 100663618);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00024B50 File Offset: 0x00022D50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284372, RefRangeEnd = 284373, XrefRangeStart = 284367, XrefRangeEnd = 284372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_clickedWithEventInfo(Action<EventBase> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_add_clickedWithEventInfo_Public_add_Void_Action_1_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00024B94 File Offset: 0x00022D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284378, RefRangeEnd = 284380, XrefRangeStart = 284373, XrefRangeEnd = 284378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_clickedWithEventInfo(Action<EventBase> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_remove_clickedWithEventInfo_Public_rem_Void_Action_1_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00024BD8 File Offset: 0x00022DD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 284384, RefRangeEnd = 284389, XrefRangeStart = 284380, XrefRangeEnd = 284384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_clicked(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_add_clicked_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00024C1C File Offset: 0x00022E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284389, XrefRangeEnd = 284393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_clicked(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_remove_clicked_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00024C60 File Offset: 0x00022E60
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00024C9C File Offset: 0x00022E9C
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_active_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00024CDC File Offset: 0x00022EDC
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00024D18 File Offset: 0x00022F18
		public unsafe Vector2 lastMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_lastMousePosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_lastMousePosition_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00024D58 File Offset: 0x00022F58
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00024D94 File Offset: 0x00022F94
		public unsafe bool acceptClicksIfDisabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_acceptClicksIfDisabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 284393, RefRangeEnd = 284400, XrefRangeStart = 284393, XrefRangeEnd = 284393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00024DD4 File Offset: 0x00022FD4
		public unsafe InvokePolicy invokePolicy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_get_invokePolicy_Private_get_InvokePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00024E10 File Offset: 0x00023010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284406, RefRangeEnd = 284408, XrefRangeStart = 284400, XrefRangeEnd = 284406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable(Action handler, long delay, long interval)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00024E78 File Offset: 0x00023078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284408, XrefRangeEnd = 284413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable(Action<EventBase> handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_1_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00024EC4 File Offset: 0x000230C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284418, RefRangeEnd = 284421, XrefRangeStart = 284413, XrefRangeEnd = 284418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clickable(Action handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clickable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00024F10 File Offset: 0x00023110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284421, XrefRangeEnd = 284431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimer(TimerState timerState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnTimer_Private_Void_TimerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00024F50 File Offset: 0x00023150
		[CallerCount(0)]
		public unsafe bool IsRepeatable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_IsRepeatable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00024F8C File Offset: 0x0002318C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284431, XrefRangeEnd = 284521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00024FC8 File Offset: 0x000231C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284521, XrefRangeEnd = 284612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00025004 File Offset: 0x00023204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284612, XrefRangeEnd = 284618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseDown(MouseDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00025048 File Offset: 0x00023248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284618, XrefRangeEnd = 284619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseMove(MouseMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002508C File Offset: 0x0002328C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284619, XrefRangeEnd = 284625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseUp(MouseUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000250D0 File Offset: 0x000232D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284625, XrefRangeEnd = 284629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMouseCaptureOut(MouseCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00025114 File Offset: 0x00023314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284629, XrefRangeEnd = 284637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00025158 File Offset: 0x00023358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284637, XrefRangeEnd = 284644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002519C File Offset: 0x0002339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284644, XrefRangeEnd = 284652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000251E0 File Offset: 0x000233E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284652, XrefRangeEnd = 284658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCancel(PointerCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00025224 File Offset: 0x00023424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284658, XrefRangeEnd = 284663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00025268 File Offset: 0x00023468
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284666, RefRangeEnd = 284670, XrefRangeStart = 284663, XrefRangeEnd = 284666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000252B4 File Offset: 0x000234B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284670, XrefRangeEnd = 284674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNotMouseEvent(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000252F4 File Offset: 0x000234F4
		[CallerCount(0)]
		public unsafe void Invoke(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_Invoke_Protected_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00025338 File Offset: 0x00023538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284691, RefRangeEnd = 284692, XrefRangeStart = 284674, XrefRangeEnd = 284691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimulateSingleClick(EventBase evt, int delayMs = 100)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayMs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr_SimulateSingleClick_Internal_Void_EventBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00025388 File Offset: 0x00023588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284729, RefRangeEnd = 284730, XrefRangeStart = 284692, XrefRangeEnd = 284729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000253F4 File Offset: 0x000235F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284739, RefRangeEnd = 284740, XrefRangeStart = 284730, XrefRangeEnd = 284739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_New_Void_EventBase_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00025450 File Offset: 0x00023650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284760, RefRangeEnd = 284761, XrefRangeStart = 284740, XrefRangeEnd = 284760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000254BC File Offset: 0x000236BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284761, XrefRangeEnd = 284777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessCancelEvent(EventBase evt, int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Clickable.NativeMethodInfoPtr_ProcessCancelEvent_Protected_Virtual_New_Void_EventBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00025518 File Offset: 0x00023718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284777, XrefRangeEnd = 284781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SimulateSingleClick_b__43_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clickable.NativeMethodInfoPtr__SimulateSingleClick_b__43_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002AA2 File Offset: 0x00000CA2
		public Clickable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002554C File Offset: 0x0002374C
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe Action<EventBase> clickedWithEventInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_clickedWithEventInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EventBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_clickedWithEventInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002557C File Offset: 0x0002377C
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002ACA File Offset: 0x00000CCA
		public unsafe Action clicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_clicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_clicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000255AC File Offset: 0x000237AC
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002AE9 File Offset: 0x00000CE9
		public unsafe long m_Delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Delay)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000255D4 File Offset: 0x000237D4
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002B04 File Offset: 0x00000D04
		public unsafe long m_Interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Interval)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000255FC File Offset: 0x000237FC
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002B1F File Offset: 0x00000D1F
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00025624 File Offset: 0x00023824
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002B3A File Offset: 0x00000D3A
		public unsafe Vector2 _lastMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__lastMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr__lastMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0002564C File Offset: 0x0002384C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002B55 File Offset: 0x00000D55
		public unsafe int m_ActivePointerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_ActivePointerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_ActivePointerId)) = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00025674 File Offset: 0x00023874
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00002B70 File Offset: 0x00000D70
		public unsafe bool m_AcceptClicksIfDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_AcceptClicksIfDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_AcceptClicksIfDisabled)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002569C File Offset: 0x0002389C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002B8B File Offset: 0x00000D8B
		public unsafe IVisualElementScheduledItem m_Repeater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Repeater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clickable.NativeFieldInfoPtr_m_Repeater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_clickedWithEventInfo;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_clicked;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_m_Delay;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_m_Interval;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr__lastMousePosition_k__BackingField;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_ActivePointerId;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_m_AcceptClicksIfDisabled;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_Repeater;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_add_clickedWithEventInfo_Public_add_Void_Action_1_EventBase_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_remove_clickedWithEventInfo_Public_rem_Void_Action_1_EventBase_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_add_clicked_Public_add_Void_Action_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_remove_clicked_Public_rem_Void_Action_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Protected_get_Boolean_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_lastMousePosition_Public_get_Vector2_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_set_lastMousePosition_Private_set_Void_Vector2_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_acceptClicksIfDisabled_Internal_get_Boolean_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_set_acceptClicksIfDisabled_Internal_set_Void_Boolean_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_invokePolicy_Private_get_InvokePolicy_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Int64_Int64_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_EventBase_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_OnTimer_Private_Void_TimerState_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_IsRepeatable_Private_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseDown_Protected_Void_MouseDownEvent_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseMove_Protected_Void_MouseMoveEvent_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseUp_Protected_Void_MouseUpEvent_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_OnMouseCaptureOut_Private_Void_MouseCaptureOutEvent_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_PointerDownEvent_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Private_Void_PointerMoveEvent_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Private_Void_PointerUpEvent_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCancel_Private_Void_PointerCancelEvent_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCaptureOut_Private_Void_PointerCaptureOutEvent_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPointer_Private_Boolean_Int32_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_IsNotMouseEvent_Private_Static_Boolean_Int32_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Protected_Void_EventBase_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_SimulateSingleClick_Internal_Void_EventBase_Int32_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDownEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMoveEvent_Protected_Virtual_New_Void_EventBase_Vector2_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_ProcessUpEvent_Protected_Virtual_New_Void_EventBase_Vector2_Int32_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCancelEvent_Protected_Virtual_New_Void_EventBase_Int32_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr__SimulateSingleClick_b__43_0_Private_Void_0;
	}
}
