using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.inputDetection
{
	// Token: 0x02000098 RID: 152
	public class InputDetector : UIBehaviour
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x0001BAF4 File Offset: 0x00019CF4
		// Note: this type is marked as 'beforefieldinit'.
		static InputDetector()
		{
			Il2CppClassPointerStore<InputDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.inputDetection", "InputDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDetector>.NativeClassPtr);
			InputDetector.NativeFieldInfoPtr_HotkeysEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, "HotkeysEnabled");
			InputDetector.NativeFieldInfoPtr_GamepadInputEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, "GamepadInputEnabled");
			InputDetector.NativeFieldInfoPtr_lastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, "lastMousePosition");
			InputDetector.NativeFieldInfoPtr_mouseMovedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, "mouseMovedThisFrame");
			InputDetector.NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664097);
			InputDetector.NativeMethodInfoPtr_get_Axes_Public_Abstract_Virtual_New_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664098);
			InputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Abstract_Virtual_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664099);
			InputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Abstract_Virtual_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664100);
			InputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664101);
			InputDetector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664102);
			InputDetector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664103);
			InputDetector.NativeMethodInfoPtr_GetAnyButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664104);
			InputDetector.NativeMethodInfoPtr_GetAnyAxisMoved_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664105);
			InputDetector.NativeMethodInfoPtr_GetAnyTouchActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664106);
			InputDetector.NativeMethodInfoPtr_GetAnyMouseButtonDown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664107);
			InputDetector.NativeMethodInfoPtr_GetAnyMouseButtonUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664108);
			InputDetector.NativeMethodInfoPtr_GetMouseMoved_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664109);
			InputDetector.NativeMethodInfoPtr_IsHotkey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664110);
			InputDetector.NativeMethodInfoPtr_IsHoldable_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664111);
			InputDetector.NativeMethodInfoPtr_ButtonWasPressed_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664112);
			InputDetector.NativeMethodInfoPtr_ButtonWasReleased_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664113);
			InputDetector.NativeMethodInfoPtr_ButtonIsDown_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664114);
			InputDetector.NativeMethodInfoPtr_GetAxisValue_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664115);
			InputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664116);
			InputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664117);
			InputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664118);
			InputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664119);
			InputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664120);
			InputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664121);
			InputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Abstract_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664122);
			InputDetector.NativeMethodInfoPtr_GetTouches_Public_Abstract_Virtual_New_IList_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664123);
			InputDetector.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664124);
			InputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Abstract_Virtual_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664125);
			InputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664126);
			InputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664127);
			InputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664128);
			InputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664129);
			InputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664130);
			InputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664131);
			InputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Abstract_Virtual_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664132);
			InputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Abstract_Virtual_New_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664133);
			InputDetector.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDetector>.NativeClassPtr, 100664134);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001BE6C File Offset: 0x0001A06C
		public unsafe virtual IList<string> Buttons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		public unsafe virtual IList<string> Axes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_get_Axes_Public_Abstract_Virtual_New_get_IList_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001BF04 File Offset: 0x0001A104
		public unsafe virtual ICollection<string> Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Abstract_Virtual_New_get_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001BF50 File Offset: 0x0001A150
		public unsafe virtual ICollection<string> HoldableButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Abstract_Virtual_New_get_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001BF9C File Offset: 0x0001A19C
		public unsafe virtual int TouchCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001BFE4 File Offset: 0x0001A1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125583, RefRangeEnd = 1125584, XrefRangeStart = 1125582, XrefRangeEnd = 1125583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001C020 File Offset: 0x0001A220
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001C05C File Offset: 0x0001A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125584, XrefRangeEnd = 1125591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAnyButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAnyButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001C098 File Offset: 0x0001A298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125591, XrefRangeEnd = 1125599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAnyAxisMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAnyAxisMoved_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125599, XrefRangeEnd = 1125608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAnyTouchActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAnyTouchActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001C110 File Offset: 0x0001A310
		[CallerCount(0)]
		public unsafe bool GetAnyMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAnyMouseButtonDown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001C14C File Offset: 0x0001A34C
		[CallerCount(0)]
		public unsafe bool GetAnyMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAnyMouseButtonUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001C188 File Offset: 0x0001A388
		[CallerCount(0)]
		public unsafe bool GetMouseMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetMouseMoved_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1125609, RefRangeEnd = 1125634, XrefRangeStart = 1125608, XrefRangeEnd = 1125609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHotkey(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_IsHotkey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001C214 File Offset: 0x0001A414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125635, RefRangeEnd = 1125636, XrefRangeStart = 1125634, XrefRangeEnd = 1125635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHoldable(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_IsHoldable_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001C264 File Offset: 0x0001A464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125637, RefRangeEnd = 1125638, XrefRangeStart = 1125636, XrefRangeEnd = 1125637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ButtonWasPressed(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_ButtonWasPressed_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125638, XrefRangeEnd = 1125639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ButtonWasReleased(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_ButtonWasReleased_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001C304 File Offset: 0x0001A504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125640, RefRangeEnd = 1125641, XrefRangeStart = 1125639, XrefRangeEnd = 1125640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ButtonIsDown(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_ButtonIsDown_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001C354 File Offset: 0x0001A554
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1125642, RefRangeEnd = 1125649, XrefRangeStart = 1125641, XrefRangeEnd = 1125642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxisValue(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr_GetAxisValue_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		[CallerCount(0)]
		public unsafe virtual bool GetAnyKeyboardButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		[CallerCount(0)]
		public unsafe virtual bool GetAnyGamepadButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001C434 File Offset: 0x0001A634
		[CallerCount(0)]
		public unsafe virtual bool GetAnyGamepadAxisMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001C47C File Offset: 0x0001A67C
		[CallerCount(0)]
		public unsafe virtual bool InternalButtonWasPressed(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		[CallerCount(0)]
		public unsafe virtual bool InternalButtonWasReleased(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001C52C File Offset: 0x0001A72C
		[CallerCount(0)]
		public unsafe virtual bool InternalButtonIsDown(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001C584 File Offset: 0x0001A784
		[CallerCount(0)]
		public unsafe virtual float InternalGetAxisValue(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Abstract_Virtual_New_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001C5DC File Offset: 0x0001A7DC
		[CallerCount(0)]
		public unsafe virtual IList<Touch> GetTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetTouches_Public_Abstract_Virtual_New_IList_1_Touch_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Touch>>(intPtr3) : null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001C628 File Offset: 0x0001A828
		[CallerCount(0)]
		public unsafe virtual Touch GetTouch(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001C67C File Offset: 0x0001A87C
		[CallerCount(0)]
		public unsafe virtual Vector2 GetMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Abstract_Virtual_New_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
		[CallerCount(0)]
		public unsafe virtual bool GetLeftMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001C70C File Offset: 0x0001A90C
		[CallerCount(0)]
		public unsafe virtual bool GetLeftMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001C754 File Offset: 0x0001A954
		[CallerCount(0)]
		public unsafe virtual bool GetRightMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001C79C File Offset: 0x0001A99C
		[CallerCount(0)]
		public unsafe virtual bool GetRightMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		[CallerCount(0)]
		public unsafe virtual bool GetMiddleMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001C82C File Offset: 0x0001AA2C
		[CallerCount(0)]
		public unsafe virtual bool GetMiddleMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001C874 File Offset: 0x0001AA74
		[CallerCount(0)]
		public unsafe virtual Vector2 GetMouseScrollDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Abstract_Virtual_New_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001C8BC File Offset: 0x0001AABC
		[CallerCount(0)]
		public unsafe virtual ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray> GetBindingStringFromId(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Abstract_Virtual_New_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray>(intPtr);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001C910 File Offset: 0x0001AB10
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDetector.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000058B1 File Offset: 0x00003AB1
		public InputDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001C94C File Offset: 0x0001AB4C
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000058BA File Offset: 0x00003ABA
		public unsafe bool HotkeysEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_HotkeysEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_HotkeysEnabled)) = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001C974 File Offset: 0x0001AB74
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000058D5 File Offset: 0x00003AD5
		public unsafe bool GamepadInputEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_GamepadInputEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_GamepadInputEnabled)) = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001C99C File Offset: 0x0001AB9C
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000058F0 File Offset: 0x00003AF0
		public unsafe Vector2 lastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_lastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_lastMousePosition)) = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0000590B File Offset: 0x00003B0B
		public unsafe bool mouseMovedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_mouseMovedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputDetector.NativeFieldInfoPtr_mouseMovedThisFrame)) = value;
			}
		}

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_HotkeysEnabled;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_GamepadInputEnabled;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_lastMousePosition;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_mouseMovedThisFrame;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Abstract_Virtual_New_get_IList_1_String_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_Abstract_Virtual_New_get_IList_1_String_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_Abstract_Virtual_New_get_ICollection_1_String_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldableButtons_Public_Abstract_Virtual_New_get_ICollection_1_String_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyButtonDown_Public_Boolean_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyAxisMoved_Public_Boolean_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyTouchActive_Public_Boolean_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyMouseButtonDown_Public_Boolean_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyMouseButtonUp_Public_Boolean_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseMoved_Public_Boolean_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_IsHotkey_Public_Boolean_String_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_IsHoldable_Public_Boolean_String_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_ButtonWasPressed_Public_Boolean_String_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_ButtonWasReleased_Public_Boolean_String_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_ButtonIsDown_Public_Boolean_String_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisValue_Public_Single_String_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonIsDown_Protected_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetAxisValue_Protected_Abstract_Virtual_New_Single_String_0;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeMethodInfoPtr_GetTouches_Public_Abstract_Virtual_New_IList_1_Touch_0;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Abstract_Virtual_New_Touch_Int32_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePosition_Public_Abstract_Virtual_New_Vector2_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseScrollDelta_Public_Abstract_Virtual_New_Vector2_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingStringFromId_Public_Abstract_Virtual_New_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
