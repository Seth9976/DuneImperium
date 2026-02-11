using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000033 RID: 51
	public class Scrollbar : Selectable
	{
		// Token: 0x060005A3 RID: 1443 RVA: 0x0001CE38 File Offset: 0x0001B038
		// Note: this type is marked as 'beforefieldinit'.
		static Scrollbar()
		{
			Il2CppClassPointerStore<Scrollbar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Scrollbar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr);
			Scrollbar.NativeFieldInfoPtr_m_HandleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_HandleRect");
			Scrollbar.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Direction");
			Scrollbar.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Value");
			Scrollbar.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Size");
			Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_NumberOfSteps");
			Scrollbar.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_OnValueChanged");
			Scrollbar.NativeFieldInfoPtr_m_ContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_ContainerRect");
			Scrollbar.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Offset");
			Scrollbar.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Tracker");
			Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_PointerDownRepeat");
			Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "isPointerDownAndNotDragging");
			Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_DelayedUpdateVisuals");
			Scrollbar.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664208);
			Scrollbar.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664209);
			Scrollbar.NativeMethodInfoPtr_get_direction_Public_get_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664210);
			Scrollbar.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664211);
			Scrollbar.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664212);
			Scrollbar.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664213);
			Scrollbar.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664214);
			Scrollbar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664215);
			Scrollbar.NativeMethodInfoPtr_get_size_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664216);
			Scrollbar.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664217);
			Scrollbar.NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664218);
			Scrollbar.NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664219);
			Scrollbar.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664220);
			Scrollbar.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664221);
			Scrollbar.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664222);
			Scrollbar.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664223);
			Scrollbar.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664224);
			Scrollbar.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664225);
			Scrollbar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664226);
			Scrollbar.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664227);
			Scrollbar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664228);
			Scrollbar.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664229);
			Scrollbar.NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664230);
			Scrollbar.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664231);
			Scrollbar.NativeMethodInfoPtr_get_axis_Private_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664232);
			Scrollbar.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664233);
			Scrollbar.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664234);
			Scrollbar.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664235);
			Scrollbar.NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664236);
			Scrollbar.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664237);
			Scrollbar.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664238);
			Scrollbar.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664239);
			Scrollbar.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664240);
			Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664241);
			Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664242);
			Scrollbar.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664243);
			Scrollbar.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664244);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664245);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664246);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664247);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664248);
			Scrollbar.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664249);
			Scrollbar.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664250);
			Scrollbar.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664251);
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0001D308 File Offset: 0x0001B508
		public unsafe RectTransform handleRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1090596, RefRangeEnd = 1090598, XrefRangeStart = 1090591, XrefRangeEnd = 1090596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0001D34C File Offset: 0x0001B54C
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0001D388 File Offset: 0x0001B588
		public unsafe Scrollbar.Direction direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_direction_Public_get_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090598, XrefRangeEnd = 1090602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090602, XrefRangeEnd = 1090615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scrollbar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001D404 File Offset: 0x0001B604
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0001D440 File Offset: 0x0001B640
		public unsafe float value
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1090616, RefRangeEnd = 1090634, XrefRangeStart = 1090615, XrefRangeEnd = 1090616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1090635, RefRangeEnd = 1090647, XrefRangeStart = 1090634, XrefRangeEnd = 1090635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001D480 File Offset: 0x0001B680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090647, XrefRangeEnd = 1090651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueWithoutNotify(float input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x0001D508 File Offset: 0x0001B708
		public unsafe float size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_size_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1090656, RefRangeEnd = 1090660, XrefRangeStart = 1090651, XrefRangeEnd = 1090656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001D548 File Offset: 0x0001B748
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x0001D584 File Offset: 0x0001B784
		public unsafe int numberOfSteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090660, XrefRangeEnd = 1090665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001D5C4 File Offset: 0x0001B7C4
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0001D604 File Offset: 0x0001B804
		public unsafe Scrollbar.ScrollEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar.ScrollEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001D648 File Offset: 0x0001B848
		public unsafe float stepSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001D684 File Offset: 0x0001B884
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001D70C File Offset: 0x0001B90C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001D748 File Offset: 0x0001B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090665, XrefRangeEnd = 1090672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001D784 File Offset: 0x0001B984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090672, XrefRangeEnd = 1090674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090674, XrefRangeEnd = 1090675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001D7FC File Offset: 0x0001B9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1090690, RefRangeEnd = 1090692, XrefRangeStart = 1090675, XrefRangeEnd = 1090690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001D830 File Offset: 0x0001BA30
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1090701, RefRangeEnd = 1090715, XrefRangeStart = 1090692, XrefRangeEnd = 1090701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float input, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001D87C File Offset: 0x0001BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090715, XrefRangeEnd = 1090717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
		public unsafe Scrollbar.Axis axis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_axis_Private_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
		public unsafe bool reverseValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001D930 File Offset: 0x0001BB30
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1090736, RefRangeEnd = 1090747, XrefRangeStart = 1090717, XrefRangeEnd = 1090736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001D964 File Offset: 0x0001BB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1090768, RefRangeEnd = 1090769, XrefRangeStart = 1090747, XrefRangeEnd = 1090768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090769, XrefRangeEnd = 1090774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleCorner;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		[CallerCount(0)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001DA44 File Offset: 0x0001BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090774, XrefRangeEnd = 1090790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001DA94 File Offset: 0x0001BC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090790, XrefRangeEnd = 1090795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090795, XrefRangeEnd = 1090800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0001DB34 File Offset: 0x0001BD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090800, XrefRangeEnd = 1090803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClickRepeat(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0001DB84 File Offset: 0x0001BD84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1090809, RefRangeEnd = 1090811, XrefRangeStart = 1090803, XrefRangeEnd = 1090809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0001DBE4 File Offset: 0x0001BDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090811, XrefRangeEnd = 1090812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0001DC34 File Offset: 0x0001BE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090812, XrefRangeEnd = 1090843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0001DC84 File Offset: 0x0001BE84
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0001DD68 File Offset: 0x0001BF68
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0001DDB4 File Offset: 0x0001BFB4
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0001DE04 File Offset: 0x0001C004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1090862, RefRangeEnd = 1090865, XrefRangeStart = 1090843, XrefRangeEnd = 1090862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeRectLayouts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001DE50 File Offset: 0x0001C050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00003F14 File Offset: 0x00002114
		public Scrollbar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001DE90 File Offset: 0x0001C090
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00003F1D File Offset: 0x0000211D
		public unsafe RectTransform m_HandleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_HandleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_HandleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00003F3C File Offset: 0x0000213C
		public unsafe Scrollbar.Direction m_Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Direction)) = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00003F57 File Offset: 0x00002157
		public unsafe float m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001DF10 File Offset: 0x0001C110
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00003F72 File Offset: 0x00002172
		public unsafe float m_Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001DF38 File Offset: 0x0001C138
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00003F8D File Offset: 0x0000218D
		public unsafe int m_NumberOfSteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps)) = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001DF60 File Offset: 0x0001C160
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00003FA8 File Offset: 0x000021A8
		public unsafe Scrollbar.ScrollEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar.ScrollEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001DF90 File Offset: 0x0001C190
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00003FC7 File Offset: 0x000021C7
		public unsafe RectTransform m_ContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_ContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_ContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00003FE6 File Offset: 0x000021E6
		public unsafe Vector2 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00004001 File Offset: 0x00002201
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001E010 File Offset: 0x0001C210
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x0000401C File Offset: 0x0000221C
		public unsafe Coroutine m_PointerDownRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001E040 File Offset: 0x0001C240
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0000403B File Offset: 0x0000223B
		public unsafe bool isPointerDownAndNotDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging)) = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001E068 File Offset: 0x0001C268
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00004056 File Offset: 0x00002256
		public unsafe bool m_DelayedUpdateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals)) = value;
			}
		}

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_m_HandleRect;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberOfSteps;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerRect;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownRepeat;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_isPointerDownAndNotDragging;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedUpdateVisuals;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Direction_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Single_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Single_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_stepSize_Private_get_Single_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_get_axis_Private_get_Axis_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000A9 RID: 169
		public enum Direction
		{
			// Token: 0x040009DA RID: 2522
			LeftToRight,
			// Token: 0x040009DB RID: 2523
			RightToLeft,
			// Token: 0x040009DC RID: 2524
			BottomToTop,
			// Token: 0x040009DD RID: 2525
			TopToBottom
		}

		// Token: 0x020000AA RID: 170
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
			// Token: 0x06000CBC RID: 3260 RVA: 0x00006C30 File Offset: 0x00004E30
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollEvent()
			{
				Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "ScrollEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr);
				Scrollbar.ScrollEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr, 100664252);
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x00037378 File Offset: 0x00035578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090555, XrefRangeEnd = 1090558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.ScrollEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x00006C64 File Offset: 0x00004E64
			public ScrollEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009DE RID: 2526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000AB RID: 171
		public enum Axis
		{
			// Token: 0x040009E0 RID: 2528
			Horizontal,
			// Token: 0x040009E1 RID: 2529
			Vertical
		}

		// Token: 0x020000AC RID: 172
		[ObfuscatedName("UnityEngine.UI.Scrollbar+<ClickRepeat>d__58")]
		public sealed class _ClickRepeat_d__58 : Object
		{
			// Token: 0x06000CBF RID: 3263 RVA: 0x000373B4 File Offset: 0x000355B4
			// Note: this type is marked as 'beforefieldinit'.
			static _ClickRepeat_d__58()
			{
				Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "<ClickRepeat>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr);
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>1__state");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>2__current");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>4__this");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "screenPosition");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "camera");
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664253);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664254);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664255);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664256);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664257);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100664258);
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x000374BC File Offset: 0x000356BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClickRepeat_d__58(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00037504 File Offset: 0x00035704
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x00037538 File Offset: 0x00035738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090558, XrefRangeEnd = 1090579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00037574 File Offset: 0x00035774
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x000375B4 File Offset: 0x000357B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090579, XrefRangeEnd = 1090591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000375E8 File Offset: 0x000357E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00006C6D File Offset: 0x00004E6D
			public _ClickRepeat_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00037628 File Offset: 0x00035828
			// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00006C76 File Offset: 0x00004E76
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00037650 File Offset: 0x00035850
			// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00006C91 File Offset: 0x00004E91
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00037680 File Offset: 0x00035880
			// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00006CB0 File Offset: 0x00004EB0
			public unsafe Scrollbar __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000CCD RID: 3277 RVA: 0x000376B0 File Offset: 0x000358B0
			// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00006CCF File Offset: 0x00004ECF
			public unsafe Vector2 screenPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition)) = value;
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000376D8 File Offset: 0x000358D8
			// (set) Token: 0x06000CD0 RID: 3280 RVA: 0x00006CEA File Offset: 0x00004EEA
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009E2 RID: 2530
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009E3 RID: 2531
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009E4 RID: 2532
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040009E5 RID: 2533
			private static readonly IntPtr NativeFieldInfoPtr_screenPosition;

			// Token: 0x040009E6 RID: 2534
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x040009E7 RID: 2535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009E8 RID: 2536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009E9 RID: 2537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009EA RID: 2538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009EB RID: 2539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009EC RID: 2540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
