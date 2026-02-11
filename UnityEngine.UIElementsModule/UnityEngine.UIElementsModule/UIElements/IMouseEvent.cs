using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F3 RID: 243
	public class IMouseEvent : Il2CppObjectBase
	{
		// Token: 0x060013CA RID: 5066 RVA: 0x00062A80 File Offset: 0x00060C80
		// Note: this type is marked as 'beforefieldinit'.
		static IMouseEvent()
		{
			Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IMouseEvent");
			IMouseEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666124);
			IMouseEvent.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666125);
			IMouseEvent.NativeMethodInfoPtr_get_localMousePosition_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666126);
			IMouseEvent.NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666127);
			IMouseEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666128);
			IMouseEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666129);
			IMouseEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666130);
			IMouseEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666131);
			IMouseEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666132);
			IMouseEvent.NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666133);
			IMouseEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMouseEvent>.NativeClassPtr, 100666134);
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00062B84 File Offset: 0x00060D84
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x00062BCC File Offset: 0x00060DCC
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00062C14 File Offset: 0x00060E14
		public unsafe virtual Vector2 localMousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_localMousePosition_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x00062C5C File Offset: 0x00060E5C
		public unsafe virtual Vector2 mouseDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00062CA4 File Offset: 0x00060EA4
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00062CEC File Offset: 0x00060EEC
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00062D34 File Offset: 0x00060F34
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00062D7C File Offset: 0x00060F7C
		public unsafe virtual bool shiftKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00062DC4 File Offset: 0x00060FC4
		public unsafe virtual bool ctrlKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00062E0C File Offset: 0x0006100C
		public unsafe virtual bool commandKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00062E54 File Offset: 0x00061054
		public unsafe virtual bool altKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMouseEvent.NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00009931 File Offset: 0x00007B31
		public IMouseEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_get_localMousePosition_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseDelta_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
