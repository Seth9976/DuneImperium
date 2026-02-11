using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000113 RID: 275
	public class IPointerEvent : Il2CppObjectBase
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x00067388 File Offset: 0x00065588
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEvent()
		{
			Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPointerEvent");
			IPointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666373);
			IPointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666374);
			IPointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666375);
			IPointerEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666376);
			IPointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666377);
			IPointerEvent.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666378);
			IPointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666379);
			IPointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666380);
			IPointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666381);
			IPointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666382);
			IPointerEvent.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666383);
			IPointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666384);
			IPointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666385);
			IPointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666386);
			IPointerEvent.NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666387);
			IPointerEvent.NativeMethodInfoPtr_get_tilt_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666388);
			IPointerEvent.NativeMethodInfoPtr_get_penStatus_Public_Abstract_Virtual_New_get_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666389);
			IPointerEvent.NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666390);
			IPointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666391);
			IPointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666392);
			IPointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666393);
			IPointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666394);
			IPointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666395);
			IPointerEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666396);
			IPointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100666397);
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000675A4 File Offset: 0x000657A4
		public unsafe virtual int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000675EC File Offset: 0x000657EC
		public unsafe virtual string pointerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00067630 File Offset: 0x00065830
		public unsafe virtual bool isPrimary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00067678 File Offset: 0x00065878
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000676C0 File Offset: 0x000658C0
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00067708 File Offset: 0x00065908
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x00067750 File Offset: 0x00065950
		public unsafe virtual Vector3 localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x00067798 File Offset: 0x00065998
		public unsafe virtual Vector3 deltaPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000677E0 File Offset: 0x000659E0
		public unsafe virtual float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00067828 File Offset: 0x00065A28
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00067870 File Offset: 0x00065A70
		public unsafe virtual float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000678B8 File Offset: 0x00065AB8
		public unsafe virtual float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00067900 File Offset: 0x00065B00
		public unsafe virtual float altitudeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x00067948 File Offset: 0x00065B48
		public unsafe virtual float azimuthAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x00067990 File Offset: 0x00065B90
		public unsafe virtual float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000679D8 File Offset: 0x00065BD8
		public unsafe virtual Vector2 tilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_tilt_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00067A20 File Offset: 0x00065C20
		public unsafe virtual PenStatus penStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_penStatus_Public_Abstract_Virtual_New_get_PenStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00067A68 File Offset: 0x00065C68
		public unsafe virtual Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00067AB0 File Offset: 0x00065CB0
		public unsafe virtual Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00067AF8 File Offset: 0x00065CF8
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x00067B40 File Offset: 0x00065D40
		public unsafe virtual bool shiftKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00067B88 File Offset: 0x00065D88
		public unsafe virtual bool ctrlKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00067BD0 File Offset: 0x00065DD0
		public unsafe virtual bool commandKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00067C18 File Offset: 0x00065E18
		public unsafe virtual bool altKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x00067C60 File Offset: 0x00065E60
		public unsafe virtual bool actionKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00009ED4 File Offset: 0x000080D4
		public IPointerEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_get_penStatus_Public_Abstract_Virtual_New_get_PenStatus_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_get_actionKey_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
