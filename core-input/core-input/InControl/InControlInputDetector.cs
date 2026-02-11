using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000017 RID: 23
	public sealed class InControlInputDetector : InputDetector
	{
		// Token: 0x060000AC RID: 172 RVA: 0x0000953C File Offset: 0x0000773C
		// Note: this type is marked as 'beforefieldinit'.
		static InControlInputDetector()
		{
			Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "InControl", "InControlInputDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr);
			InControlInputDetector.NativeFieldInfoPtr_inputBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "inputBindings");
			InControlInputDetector.NativeFieldInfoPtr_disableDeviceBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "disableDeviceBindings");
			InControlInputDetector.NativeFieldInfoPtr_buttonNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "buttonNames");
			InControlInputDetector.NativeFieldInfoPtr_axisNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "axisNames");
			InControlInputDetector.NativeFieldInfoPtr_hotkeyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "hotkeyNames");
			InControlInputDetector.NativeFieldInfoPtr_holdableButtonNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "holdableButtonNames");
			InControlInputDetector.NativeFieldInfoPtr_buttonActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "buttonActionSet");
			InControlInputDetector.NativeFieldInfoPtr_axisActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "axisActionSet");
			InControlInputDetector.NativeFieldInfoPtr_serverPrefKeyActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "serverPrefKeyActionSet");
			InControlInputDetector.NativeFieldInfoPtr_universalMouseActionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "universalMouseActionSet");
			InControlInputDetector.NativeFieldInfoPtr_inputControlTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "inputControlTypes");
			InControlInputDetector.NativeFieldInfoPtr_cachedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "cachedTouches");
			InControlInputDetector.NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663385);
			InControlInputDetector.NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663386);
			InControlInputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663387);
			InControlInputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663388);
			InControlInputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663389);
			InControlInputDetector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663390);
			InControlInputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663391);
			InControlInputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663392);
			InControlInputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663393);
			InControlInputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663394);
			InControlInputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663395);
			InControlInputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663396);
			InControlInputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663397);
			InControlInputDetector.NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663398);
			InControlInputDetector.NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663399);
			InControlInputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663400);
			InControlInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663401);
			InControlInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663402);
			InControlInputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663403);
			InControlInputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663404);
			InControlInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663405);
			InControlInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663406);
			InControlInputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663407);
			InControlInputDetector.NativeMethodInfoPtr_getButtonAction_Private_PlayerAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663408);
			InControlInputDetector.NativeMethodInfoPtr_getAxisAction_Private_PlayerAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663409);
			InControlInputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663410);
			InControlInputDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, 100663411);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00009878 File Offset: 0x00007A78
		public unsafe override IList<string> Buttons
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000098B8 File Offset: 0x00007AB8
		public unsafe override IList<string> Axes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000098F8 File Offset: 0x00007AF8
		public unsafe override ICollection<string> Hotkeys
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00009938 File Offset: 0x00007B38
		public unsafe override ICollection<string> HoldableButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00009978 File Offset: 0x00007B78
		public unsafe override int TouchCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000099B4 File Offset: 0x00007BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119509, XrefRangeEnd = 1119793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000099E8 File Offset: 0x00007BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119793, XrefRangeEnd = 1119797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyKeyboardButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00009A24 File Offset: 0x00007C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119797, XrefRangeEnd = 1119808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyGamepadButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00009A60 File Offset: 0x00007C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119808, XrefRangeEnd = 1119820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetAnyGamepadAxisMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009A9C File Offset: 0x00007C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119820, XrefRangeEnd = 1119823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonWasPressed(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009AEC File Offset: 0x00007CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119823, XrefRangeEnd = 1119826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonWasReleased(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00009B3C File Offset: 0x00007D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119826, XrefRangeEnd = 1119829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InternalButtonIsDown(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00009B8C File Offset: 0x00007D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119829, XrefRangeEnd = 1119831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float InternalGetAxisValue(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00009BDC File Offset: 0x00007DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119831, XrefRangeEnd = 1119839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<Touch> GetTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Touch>>(intPtr3) : null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00009C1C File Offset: 0x00007E1C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009C68 File Offset: 0x00007E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 GetMousePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119839, XrefRangeEnd = 1119840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetLeftMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00009CE0 File Offset: 0x00007EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119840, XrefRangeEnd = 1119841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetLeftMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00009D1C File Offset: 0x00007F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119841, XrefRangeEnd = 1119842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetRightMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00009D58 File Offset: 0x00007F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119842, XrefRangeEnd = 1119843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetRightMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009D94 File Offset: 0x00007F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119843, XrefRangeEnd = 1119844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetMiddleMouseButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00009DD0 File Offset: 0x00007FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119844, XrefRangeEnd = 1119845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetMiddleMouseButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00009E0C File Offset: 0x0000800C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector2 GetMouseScrollDelta()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00009E48 File Offset: 0x00008048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119845, XrefRangeEnd = 1119847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAction getButtonAction(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_getButtonAction_Private_PlayerAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009E98 File Offset: 0x00008098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119847, XrefRangeEnd = 1119848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerAction getAxisAction(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_getAxisAction_Private_PlayerAction_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr3) : null;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009EE8 File Offset: 0x000080E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119848, XrefRangeEnd = 1119914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray> GetBindingStringFromId(string inputId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Il2CppStringArray, Il2CppStringArray, Il2CppStringArray>(intPtr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009F30 File Offset: 0x00008130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119914, XrefRangeEnd = 1119926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlInputDetector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000024AB File Offset: 0x000006AB
		public InControlInputDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00009F6C File Offset: 0x0000816C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000024B4 File Offset: 0x000006B4
		public unsafe Il2CppReferenceArray<InControlInputDetector.InputBinding> inputBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_inputBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InControlInputDetector.InputBinding>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_inputBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00009F9C File Offset: 0x0000819C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000024D3 File Offset: 0x000006D3
		public unsafe bool disableDeviceBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_disableDeviceBindings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_disableDeviceBindings)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00009FC4 File Offset: 0x000081C4
		// (set) Token: 0x060000CE RID: 206 RVA: 0x000024EE File Offset: 0x000006EE
		public unsafe List<string> buttonNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_buttonNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_buttonNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00009FF4 File Offset: 0x000081F4
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000250D File Offset: 0x0000070D
		public unsafe List<string> axisNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_axisNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_axisNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000A024 File Offset: 0x00008224
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe HashSet<string> hotkeyNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_hotkeyNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_hotkeyNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000A054 File Offset: 0x00008254
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000254B File Offset: 0x0000074B
		public unsafe HashSet<string> holdableButtonNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_holdableButtonNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_holdableButtonNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000A084 File Offset: 0x00008284
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000256A File Offset: 0x0000076A
		public unsafe InControlInputDetector.InputActionSet buttonActionSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_buttonActionSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.InputActionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_buttonActionSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000A0B4 File Offset: 0x000082B4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002589 File Offset: 0x00000789
		public unsafe InControlInputDetector.InputActionSet axisActionSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_axisActionSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.InputActionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_axisActionSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000A0E4 File Offset: 0x000082E4
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000025A8 File Offset: 0x000007A8
		public unsafe InControlInputDetector.InputActionSet serverPrefKeyActionSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_serverPrefKeyActionSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.InputActionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_serverPrefKeyActionSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000A114 File Offset: 0x00008314
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000025C7 File Offset: 0x000007C7
		public unsafe InControlInputDetector.UniversalMouseActionSet universalMouseActionSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_universalMouseActionSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.UniversalMouseActionSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_universalMouseActionSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000A144 File Offset: 0x00008344
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000025E6 File Offset: 0x000007E6
		public unsafe Il2CppStructArray<InputControlType> inputControlTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_inputControlTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputControlType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_inputControlTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000A174 File Offset: 0x00008374
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe List<Touch> cachedTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_cachedTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Touch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.NativeFieldInfoPtr_cachedTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_inputBindings;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_disableDeviceBindings;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_buttonNames;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_axisNames;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_hotkeyNames;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_holdableButtonNames;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_buttonActionSet;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_axisActionSet;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_serverPrefKeyActionSet;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_universalMouseActionSet;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_inputControlTypes;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_cachedTouches;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_Buttons_Public_Virtual_get_IList_1_String_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_Axes_Public_Virtual_get_IList_1_String_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_Virtual_get_ICollection_1_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldableButtons_Public_Virtual_get_ICollection_1_String_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_TouchCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyKeyboardButtonPressed_Public_Virtual_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadButtonPressed_Public_Virtual_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_GetAnyGamepadAxisMoved_Public_Virtual_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasPressed_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonWasReleased_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_InternalButtonIsDown_Protected_Virtual_Boolean_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetAxisValue_Protected_Virtual_Single_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_GetTouches_Public_Virtual_IList_1_Touch_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_GetTouch_Public_Virtual_Touch_Int32_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePosition_Public_Virtual_Vector2_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetRightMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetMiddleMouseButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetMouseScrollDelta_Public_Virtual_Vector2_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_getButtonAction_Private_PlayerAction_String_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_getAxisAction_Private_PlayerAction_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingStringFromId_Public_Virtual_ValueTuple_3_Il2CppStringArray_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B7 RID: 183
		[Serializable]
		public class InputBinding : global::Il2CppSystem.Object
		{
			// Token: 0x06000826 RID: 2086 RVA: 0x00021724 File Offset: 0x0001F924
			// Note: this type is marked as 'beforefieldinit'.
			static InputBinding()
			{
				Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "InputBinding");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr);
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "name");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_bindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "bindings");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_isButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "isButton");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_isAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "isAxis");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_isServerPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "isServerPrefKey");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "isHotkey");
				InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHoldable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, "isHoldable");
				InControlInputDetector.InputBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr, 100663412);
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x000217F0 File Offset: 0x0001F9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119391, XrefRangeEnd = 1119416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputBinding()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector.InputBinding>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.InputBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x00006458 File Offset: 0x00004658
			public InputBinding(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x06000829 RID: 2089 RVA: 0x0002182C File Offset: 0x0001FA2C
			// (set) Token: 0x0600082A RID: 2090 RVA: 0x00006461 File Offset: 0x00004661
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x0600082B RID: 2091 RVA: 0x00021854 File Offset: 0x0001FA54
			// (set) Token: 0x0600082C RID: 2092 RVA: 0x00006480 File Offset: 0x00004680
			public unsafe InControlInputDetector.BindingList bindings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_bindings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.BindingList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_bindings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x0600082D RID: 2093 RVA: 0x00021884 File Offset: 0x0001FA84
			// (set) Token: 0x0600082E RID: 2094 RVA: 0x0000649F File Offset: 0x0000469F
			public unsafe bool isButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isButton);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isButton)) = value;
				}
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x0600082F RID: 2095 RVA: 0x000218AC File Offset: 0x0001FAAC
			// (set) Token: 0x06000830 RID: 2096 RVA: 0x000064BA File Offset: 0x000046BA
			public unsafe bool isAxis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isAxis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isAxis)) = value;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06000831 RID: 2097 RVA: 0x000218D4 File Offset: 0x0001FAD4
			// (set) Token: 0x06000832 RID: 2098 RVA: 0x000064D5 File Offset: 0x000046D5
			public unsafe bool isServerPrefKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isServerPrefKey);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isServerPrefKey)) = value;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x06000833 RID: 2099 RVA: 0x000218FC File Offset: 0x0001FAFC
			// (set) Token: 0x06000834 RID: 2100 RVA: 0x000064F0 File Offset: 0x000046F0
			public unsafe bool isHotkey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHotkey);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHotkey)) = value;
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x06000835 RID: 2101 RVA: 0x00021924 File Offset: 0x0001FB24
			// (set) Token: 0x06000836 RID: 2102 RVA: 0x0000650B File Offset: 0x0000470B
			public unsafe bool isHoldable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHoldable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.InputBinding.NativeFieldInfoPtr_isHoldable)) = value;
				}
			}

			// Token: 0x04000505 RID: 1285
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000506 RID: 1286
			private static readonly IntPtr NativeFieldInfoPtr_bindings;

			// Token: 0x04000507 RID: 1287
			private static readonly IntPtr NativeFieldInfoPtr_isButton;

			// Token: 0x04000508 RID: 1288
			private static readonly IntPtr NativeFieldInfoPtr_isAxis;

			// Token: 0x04000509 RID: 1289
			private static readonly IntPtr NativeFieldInfoPtr_isServerPrefKey;

			// Token: 0x0400050A RID: 1290
			private static readonly IntPtr NativeFieldInfoPtr_isHotkey;

			// Token: 0x0400050B RID: 1291
			private static readonly IntPtr NativeFieldInfoPtr_isHoldable;

			// Token: 0x0400050C RID: 1292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000B8 RID: 184
		[Serializable]
		public class BindingList : global::Il2CppSystem.Object
		{
			// Token: 0x06000837 RID: 2103 RVA: 0x0002194C File Offset: 0x0001FB4C
			// Note: this type is marked as 'beforefieldinit'.
			static BindingList()
			{
				Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "BindingList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr);
				InControlInputDetector.BindingList.NativeFieldInfoPtr_keyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr, "keyBindings");
				InControlInputDetector.BindingList.NativeFieldInfoPtr_mouseBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr, "mouseBindings");
				InControlInputDetector.BindingList.NativeFieldInfoPtr_serverPrefKeyBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr, "serverPrefKeyBindings");
				InControlInputDetector.BindingList.NativeFieldInfoPtr_deviceBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr, "deviceBindings");
				InControlInputDetector.BindingList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr, 100663413);
			}

			// Token: 0x06000838 RID: 2104 RVA: 0x000219DC File Offset: 0x0001FBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119416, XrefRangeEnd = 1119433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BindingList()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector.BindingList>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.BindingList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x00006526 File Offset: 0x00004726
			public BindingList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x0600083A RID: 2106 RVA: 0x00021A18 File Offset: 0x0001FC18
			// (set) Token: 0x0600083B RID: 2107 RVA: 0x0000652F File Offset: 0x0000472F
			public unsafe Il2CppStructArray<Key> keyBindings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_keyBindings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Key>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_keyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x00021A48 File Offset: 0x0001FC48
			// (set) Token: 0x0600083D RID: 2109 RVA: 0x0000654E File Offset: 0x0000474E
			public unsafe Il2CppStructArray<Mouse> mouseBindings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_mouseBindings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Mouse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_mouseBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x0600083E RID: 2110 RVA: 0x00021A78 File Offset: 0x0001FC78
			// (set) Token: 0x0600083F RID: 2111 RVA: 0x0000656D File Offset: 0x0000476D
			public unsafe Il2CppStructArray<int> serverPrefKeyBindings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_serverPrefKeyBindings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_serverPrefKeyBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000840 RID: 2112 RVA: 0x00021AA8 File Offset: 0x0001FCA8
			// (set) Token: 0x06000841 RID: 2113 RVA: 0x0000658C File Offset: 0x0000478C
			public unsafe Il2CppStructArray<InputControlType> deviceBindings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_deviceBindings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InputControlType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.BindingList.NativeFieldInfoPtr_deviceBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400050D RID: 1293
			private static readonly IntPtr NativeFieldInfoPtr_keyBindings;

			// Token: 0x0400050E RID: 1294
			private static readonly IntPtr NativeFieldInfoPtr_mouseBindings;

			// Token: 0x0400050F RID: 1295
			private static readonly IntPtr NativeFieldInfoPtr_serverPrefKeyBindings;

			// Token: 0x04000510 RID: 1296
			private static readonly IntPtr NativeFieldInfoPtr_deviceBindings;

			// Token: 0x04000511 RID: 1297
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000B9 RID: 185
		public class InputActionSet : PlayerActionSet
		{
			// Token: 0x06000842 RID: 2114 RVA: 0x000065AB File Offset: 0x000047AB
			// Note: this type is marked as 'beforefieldinit'.
			static InputActionSet()
			{
				Il2CppClassPointerStore<InControlInputDetector.InputActionSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "InputActionSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector.InputActionSet>.NativeClassPtr);
				InControlInputDetector.InputActionSet.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_InputBinding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.InputActionSet>.NativeClassPtr, 100663414);
			}

			// Token: 0x06000843 RID: 2115 RVA: 0x00021AD8 File Offset: 0x0001FCD8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1119473, RefRangeEnd = 1119476, XrefRangeStart = 1119433, XrefRangeEnd = 1119473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InputActionSet(IEnumerable<InControlInputDetector.InputBinding> inputBindings, bool includeDeviceBindings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector.InputActionSet>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBindings);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDeviceBindings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.InputActionSet.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_InputBinding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000844 RID: 2116 RVA: 0x000065DF File Offset: 0x000047DF
			public InputActionSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000512 RID: 1298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_InputBinding_Boolean_0;
		}

		// Token: 0x020000BA RID: 186
		public class UniversalMouseActionSet : PlayerActionSet
		{
			// Token: 0x06000845 RID: 2117 RVA: 0x00021B34 File Offset: 0x0001FD34
			// Note: this type is marked as 'beforefieldinit'.
			static UniversalMouseActionSet()
			{
				Il2CppClassPointerStore<InControlInputDetector.UniversalMouseActionSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "UniversalMouseActionSet");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector.UniversalMouseActionSet>.NativeClassPtr);
				InControlInputDetector.UniversalMouseActionSet.NativeFieldInfoPtr_MouseControlTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.UniversalMouseActionSet>.NativeClassPtr, "MouseControlTypes");
				InControlInputDetector.UniversalMouseActionSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.UniversalMouseActionSet>.NativeClassPtr, 100663415);
			}

			// Token: 0x06000846 RID: 2118 RVA: 0x00021B88 File Offset: 0x0001FD88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119476, XrefRangeEnd = 1119500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniversalMouseActionSet()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector.UniversalMouseActionSet>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.UniversalMouseActionSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000847 RID: 2119 RVA: 0x000065E8 File Offset: 0x000047E8
			public UniversalMouseActionSet(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x06000848 RID: 2120 RVA: 0x00021BC4 File Offset: 0x0001FDC4
			// (set) Token: 0x06000849 RID: 2121 RVA: 0x000065F1 File Offset: 0x000047F1
			public unsafe Il2CppStructArray<Mouse> MouseControlTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.UniversalMouseActionSet.NativeFieldInfoPtr_MouseControlTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Mouse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InControlInputDetector.UniversalMouseActionSet.NativeFieldInfoPtr_MouseControlTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000513 RID: 1299
			private static readonly IntPtr NativeFieldInfoPtr_MouseControlTypes;

			// Token: 0x04000514 RID: 1300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000BB RID: 187
		[ObfuscatedName("InControl.InControlInputDetector+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600084A RID: 2122 RVA: 0x00021BF4 File Offset: 0x0001FDF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InControlInputDetector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr);
				InControlInputDetector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_0");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_1");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_2");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_3");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_7");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_8");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_9");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_10");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_4");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_5");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__26_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__26_6");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__46_0");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__46_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__46_1");
				InControlInputDetector.__c.NativeFieldInfoPtr___9__46_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, "<>9__46_2");
				InControlInputDetector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663417);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663418);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_1_Internal_String_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663419);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_2_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663420);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_3_Internal_String_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663421);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_7_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663422);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_8_Internal_String_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663423);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_9_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663424);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_10_Internal_String_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663425);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_4_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663426);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_5_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663427);
				InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_6_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663428);
				InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_0_Internal_String_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663429);
				InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_1_Internal_String_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663430);
				InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_2_Internal_String_InputControlType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr, 100663431);
			}

			// Token: 0x0600084B RID: 2123 RVA: 0x00021E78 File Offset: 0x00020078
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlInputDetector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600084C RID: 2124 RVA: 0x00021EB4 File Offset: 0x000200B4
			[CallerCount(0)]
			public unsafe bool _Start_b__26_0(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600084D RID: 2125 RVA: 0x00021F04 File Offset: 0x00020104
			[CallerCount(0)]
			public unsafe string _Start_b__26_1(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_1_Internal_String_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00021F4C File Offset: 0x0002014C
			[CallerCount(0)]
			public unsafe bool _Start_b__26_2(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_2_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x00021F9C File Offset: 0x0002019C
			[CallerCount(0)]
			public unsafe string _Start_b__26_3(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_3_Internal_String_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000850 RID: 2128 RVA: 0x00021FE4 File Offset: 0x000201E4
			[CallerCount(0)]
			public unsafe bool _Start_b__26_7(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_7_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000851 RID: 2129 RVA: 0x00022034 File Offset: 0x00020234
			[CallerCount(0)]
			public unsafe string _Start_b__26_8(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_8_Internal_String_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000852 RID: 2130 RVA: 0x0002207C File Offset: 0x0002027C
			[CallerCount(0)]
			public unsafe bool _Start_b__26_9(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_9_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000853 RID: 2131 RVA: 0x000220CC File Offset: 0x000202CC
			[CallerCount(0)]
			public unsafe string _Start_b__26_10(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_10_Internal_String_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000854 RID: 2132 RVA: 0x00022114 File Offset: 0x00020314
			[CallerCount(0)]
			public unsafe bool _Start_b__26_4(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_4_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000855 RID: 2133 RVA: 0x00022164 File Offset: 0x00020364
			[CallerCount(0)]
			public unsafe bool _Start_b__26_5(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_5_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x000221B4 File Offset: 0x000203B4
			[CallerCount(0)]
			public unsafe bool _Start_b__26_6(InControlInputDetector.InputBinding binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__Start_b__26_6_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x00022204 File Offset: 0x00020404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119500, XrefRangeEnd = 1119503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetBindingStringFromId_b__46_0(Key x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_0_Internal_String_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x00022248 File Offset: 0x00020448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119503, XrefRangeEnd = 1119506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetBindingStringFromId_b__46_1(Mouse x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_1_Internal_String_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000859 RID: 2137 RVA: 0x0002228C File Offset: 0x0002048C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119506, XrefRangeEnd = 1119509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetBindingStringFromId_b__46_2(InputControlType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlInputDetector.__c.NativeMethodInfoPtr__GetBindingStringFromId_b__46_2_Internal_String_InputControlType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x00006610 File Offset: 0x00004810
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x0600085B RID: 2139 RVA: 0x000222D0 File Offset: 0x000204D0
			// (set) Token: 0x0600085C RID: 2140 RVA: 0x00006619 File Offset: 0x00004819
			public unsafe static InControlInputDetector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InControlInputDetector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x0600085D RID: 2141 RVA: 0x000222F8 File Offset: 0x000204F8
			// (set) Token: 0x0600085E RID: 2142 RVA: 0x0000662B File Offset: 0x0000482B
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x0600085F RID: 2143 RVA: 0x00022320 File Offset: 0x00020520
			// (set) Token: 0x06000860 RID: 2144 RVA: 0x0000663D File Offset: 0x0000483D
			public unsafe static Func<InControlInputDetector.InputBinding, string> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x00022348 File Offset: 0x00020548
			// (set) Token: 0x06000862 RID: 2146 RVA: 0x0000664F File Offset: 0x0000484F
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x06000863 RID: 2147 RVA: 0x00022370 File Offset: 0x00020570
			// (set) Token: 0x06000864 RID: 2148 RVA: 0x00006661 File Offset: 0x00004861
			public unsafe static Func<InControlInputDetector.InputBinding, string> __9__26_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x06000865 RID: 2149 RVA: 0x00022398 File Offset: 0x00020598
			// (set) Token: 0x06000866 RID: 2150 RVA: 0x00006673 File Offset: 0x00004873
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x06000867 RID: 2151 RVA: 0x000223C0 File Offset: 0x000205C0
			// (set) Token: 0x06000868 RID: 2152 RVA: 0x00006685 File Offset: 0x00004885
			public unsafe static Func<InControlInputDetector.InputBinding, string> __9__26_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06000869 RID: 2153 RVA: 0x000223E8 File Offset: 0x000205E8
			// (set) Token: 0x0600086A RID: 2154 RVA: 0x00006697 File Offset: 0x00004897
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x0600086B RID: 2155 RVA: 0x00022410 File Offset: 0x00020610
			// (set) Token: 0x0600086C RID: 2156 RVA: 0x000066A9 File Offset: 0x000048A9
			public unsafe static Func<InControlInputDetector.InputBinding, string> __9__26_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x0600086D RID: 2157 RVA: 0x00022438 File Offset: 0x00020638
			// (set) Token: 0x0600086E RID: 2158 RVA: 0x000066BB File Offset: 0x000048BB
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x0600086F RID: 2159 RVA: 0x00022460 File Offset: 0x00020660
			// (set) Token: 0x06000870 RID: 2160 RVA: 0x000066CD File Offset: 0x000048CD
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000871 RID: 2161 RVA: 0x00022488 File Offset: 0x00020688
			// (set) Token: 0x06000872 RID: 2162 RVA: 0x000066DF File Offset: 0x000048DF
			public unsafe static Func<InControlInputDetector.InputBinding, bool> __9__26_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InControlInputDetector.InputBinding, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__26_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000873 RID: 2163 RVA: 0x000224B0 File Offset: 0x000206B0
			// (set) Token: 0x06000874 RID: 2164 RVA: 0x000066F1 File Offset: 0x000048F1
			public unsafe static Func<Key, string> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Key, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000875 RID: 2165 RVA: 0x000224D8 File Offset: 0x000206D8
			// (set) Token: 0x06000876 RID: 2166 RVA: 0x00006703 File Offset: 0x00004903
			public unsafe static Func<Mouse, string> __9__46_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Mouse, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000877 RID: 2167 RVA: 0x00022500 File Offset: 0x00020700
			// (set) Token: 0x06000878 RID: 2168 RVA: 0x00006715 File Offset: 0x00004915
			public unsafe static Func<InputControlType, string> __9__46_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InputControlType, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InControlInputDetector.__c.NativeFieldInfoPtr___9__46_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000515 RID: 1301
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000516 RID: 1302
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04000517 RID: 1303
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x04000518 RID: 1304
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x04000519 RID: 1305
			private static readonly IntPtr NativeFieldInfoPtr___9__26_3;

			// Token: 0x0400051A RID: 1306
			private static readonly IntPtr NativeFieldInfoPtr___9__26_7;

			// Token: 0x0400051B RID: 1307
			private static readonly IntPtr NativeFieldInfoPtr___9__26_8;

			// Token: 0x0400051C RID: 1308
			private static readonly IntPtr NativeFieldInfoPtr___9__26_9;

			// Token: 0x0400051D RID: 1309
			private static readonly IntPtr NativeFieldInfoPtr___9__26_10;

			// Token: 0x0400051E RID: 1310
			private static readonly IntPtr NativeFieldInfoPtr___9__26_4;

			// Token: 0x0400051F RID: 1311
			private static readonly IntPtr NativeFieldInfoPtr___9__26_5;

			// Token: 0x04000520 RID: 1312
			private static readonly IntPtr NativeFieldInfoPtr___9__26_6;

			// Token: 0x04000521 RID: 1313
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04000522 RID: 1314
			private static readonly IntPtr NativeFieldInfoPtr___9__46_1;

			// Token: 0x04000523 RID: 1315
			private static readonly IntPtr NativeFieldInfoPtr___9__46_2;

			// Token: 0x04000524 RID: 1316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000525 RID: 1317
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_0_Internal_Boolean_InputBinding_0;

			// Token: 0x04000526 RID: 1318
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_1_Internal_String_InputBinding_0;

			// Token: 0x04000527 RID: 1319
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_2_Internal_Boolean_InputBinding_0;

			// Token: 0x04000528 RID: 1320
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_3_Internal_String_InputBinding_0;

			// Token: 0x04000529 RID: 1321
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_7_Internal_Boolean_InputBinding_0;

			// Token: 0x0400052A RID: 1322
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_8_Internal_String_InputBinding_0;

			// Token: 0x0400052B RID: 1323
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_9_Internal_Boolean_InputBinding_0;

			// Token: 0x0400052C RID: 1324
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_10_Internal_String_InputBinding_0;

			// Token: 0x0400052D RID: 1325
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_4_Internal_Boolean_InputBinding_0;

			// Token: 0x0400052E RID: 1326
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_5_Internal_Boolean_InputBinding_0;

			// Token: 0x0400052F RID: 1327
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_6_Internal_Boolean_InputBinding_0;

			// Token: 0x04000530 RID: 1328
			private static readonly IntPtr NativeMethodInfoPtr__GetBindingStringFromId_b__46_0_Internal_String_Key_0;

			// Token: 0x04000531 RID: 1329
			private static readonly IntPtr NativeMethodInfoPtr__GetBindingStringFromId_b__46_1_Internal_String_Mouse_0;

			// Token: 0x04000532 RID: 1330
			private static readonly IntPtr NativeMethodInfoPtr__GetBindingStringFromId_b__46_2_Internal_String_InputControlType_0;
		}
	}
}
