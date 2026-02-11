using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.input.compositeModule.inputDetection
{
	// Token: 0x02000099 RID: 153
	public sealed class UnityInputDetector : InputDetector
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x0001C9EC File Offset: 0x0001ABEC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityInputDetector()
		{
			Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.inputDetection", "UnityInputDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr);
			UnityInputDetector.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "buttons");
			UnityInputDetector.NativeFieldInfoPtr_axes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "axes");
			UnityInputDetector.NativeFieldInfoPtr_hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "hotkeys");
			UnityInputDetector.NativeFieldInfoPtr_holdableButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "holdableButtons");
			UnityInputDetector.NativeFieldInfoPtr_gamepadOnlyAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "gamepadOnlyAxes");
			UnityInputDetector.NativeFieldInfoPtr_NumJoystickButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "NumJoystickButtons");
			UnityInputDetector.NativeFieldInfoPtr_joystickButtonNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "joystickButtonNames");
			UnityInputDetector.NativeFieldInfoPtr_cachedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, "cachedTouches");
			UnityInputDetector.NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664135);
			UnityInputDetector.NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664136);
			UnityInputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664137);
			UnityInputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664138);
			UnityInputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664139);
			UnityInputDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664140);
			UnityInputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664141);
			UnityInputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664142);
			UnityInputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664143);
			UnityInputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664144);
			UnityInputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664145);
			UnityInputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664146);
			UnityInputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664147);
			UnityInputDetector.NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664148);
			UnityInputDetector.NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664149);
			UnityInputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664150);
			UnityInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664151);
			UnityInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664152);
			UnityInputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664153);
			UnityInputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664154);
			UnityInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664155);
			UnityInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664156);
			UnityInputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664157);
			UnityInputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664158);
			UnityInputDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr, 100664159);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		public unsafe override IList<string> Buttons
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		public unsafe override IList<string> Axes
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001CD30 File Offset: 0x0001AF30
		public unsafe override ICollection<string> Hotkeys
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public unsafe override ICollection<string> HoldableButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
		public unsafe override int TouchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125649, XrefRangeEnd = 1125658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001CE20 File Offset: 0x0001B020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyKeyboardButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001CE5C File Offset: 0x0001B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125658, XrefRangeEnd = 1125660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyGamepadButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001CE98 File Offset: 0x0001B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125660, XrefRangeEnd = 1125662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyGamepadAxisMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001CED4 File Offset: 0x0001B0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonWasPressed(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001CF24 File Offset: 0x0001B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125662, XrefRangeEnd = 1125663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonWasReleased(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001CF74 File Offset: 0x0001B174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125663, XrefRangeEnd = 1125664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonIsDown(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float InternalGetAxisValue(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001D014 File Offset: 0x0001B214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125664, XrefRangeEnd = 1125672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<Touch> GetTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Touch>>(intPtr3) : null;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001D054 File Offset: 0x0001B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Touch GetTouch(int touchId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref touchId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 GetMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001D0DC File Offset: 0x0001B2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125672, XrefRangeEnd = 1125673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetLeftMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001D118 File Offset: 0x0001B318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125673, XrefRangeEnd = 1125674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetLeftMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001D154 File Offset: 0x0001B354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125674, XrefRangeEnd = 1125675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetRightMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001D190 File Offset: 0x0001B390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125675, XrefRangeEnd = 1125676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetRightMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001D1CC File Offset: 0x0001B3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125676, XrefRangeEnd = 1125677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetMiddleMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001D208 File Offset: 0x0001B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125677, XrefRangeEnd = 1125678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetMiddleMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001D244 File Offset: 0x0001B444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 GetMouseScrollDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001D280 File Offset: 0x0001B480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125678, XrefRangeEnd = 1125681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray> GetBindingStringFromId(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray>(intPtr);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125681, XrefRangeEnd = 1125708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityInputDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInputDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00005926 File Offset: 0x00003B26
		public UnityInputDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001D304 File Offset: 0x0001B504
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x0000592F File Offset: 0x00003B2F
		public unsafe Il2CppStringArray buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001D334 File Offset: 0x0001B534
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0000594E File Offset: 0x00003B4E
		public unsafe Il2CppStringArray axes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_axes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_axes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001D364 File Offset: 0x0001B564
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0000596D File Offset: 0x00003B6D
		public unsafe Il2CppStringArray hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001D394 File Offset: 0x0001B594
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x0000598C File Offset: 0x00003B8C
		public unsafe Il2CppStringArray holdableButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_holdableButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_holdableButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x000059AB File Offset: 0x00003BAB
		public unsafe Il2CppStringArray gamepadOnlyAxes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_gamepadOnlyAxes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_gamepadOnlyAxes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001D3F4 File Offset: 0x0001B5F4
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x000059CA File Offset: 0x00003BCA
		public unsafe static int NumJoystickButtons
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UnityInputDetector.NativeFieldInfoPtr_NumJoystickButtons, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityInputDetector.NativeFieldInfoPtr_NumJoystickButtons, (void*)(&value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001D410 File Offset: 0x0001B610
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x000059D8 File Offset: 0x00003BD8
		public unsafe Il2CppStringArray joystickButtonNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_joystickButtonNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_joystickButtonNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001D440 File Offset: 0x0001B640
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x000059F7 File Offset: 0x00003BF7
		public unsafe List<Touch> cachedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_cachedTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInputDetector.NativeFieldInfoPtr_cachedTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_buttons;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_axes;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_hotkeys;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_holdableButtons;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_gamepadOnlyAxes;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_NumJoystickButtons;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_joystickButtonNames;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_cachedTouches;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
