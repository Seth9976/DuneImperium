using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006C RID: 108
	public class TouchScreenTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x00040ADC File Offset: 0x0003ECDC
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenTextEditorEventHandler()
		{
			Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TouchScreenTextEditorEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr);
			TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardPoller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, "m_TouchKeyboardPoller");
			TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, "m_TouchKeyboardAllowsInPlaceEditing");
			TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_IsClicking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, "m_IsClicking");
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664757);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_PollTouchScreenKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664758);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_DoPollTouchScreenKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664759);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664760);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_CloseTouchScreenKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664761);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OpenTouchScreenKeyboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664762);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664763);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664764);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664765);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnFocusInEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664766);
			TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr, 100664767);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00040C24 File Offset: 0x0003EE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299092, RefRangeEnd = 299093, XrefRangeStart = 299088, XrefRangeEnd = 299092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchScreenTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenTextEditorEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editingUtilities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00040C84 File Offset: 0x0003EE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299115, RefRangeEnd = 299116, XrefRangeStart = 299093, XrefRangeEnd = 299115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PollTouchScreenKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_PollTouchScreenKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00040CB8 File Offset: 0x0003EEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299116, XrefRangeEnd = 299121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPollTouchScreenKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_DoPollTouchScreenKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00040CEC File Offset: 0x0003EEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299121, XrefRangeEnd = 299136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStringPositionFromKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00040D20 File Offset: 0x0003EF20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299142, RefRangeEnd = 299143, XrefRangeStart = 299136, XrefRangeEnd = 299142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTouchScreenKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_CloseTouchScreenKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00040D54 File Offset: 0x0003EF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299168, RefRangeEnd = 299169, XrefRangeStart = 299143, XrefRangeEnd = 299168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTouchScreenKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OpenTouchScreenKeyboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00040D88 File Offset: 0x0003EF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299169, XrefRangeEnd = 299191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00040DD8 File Offset: 0x0003EFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299191, XrefRangeEnd = 299203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDownEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00040E0C File Offset: 0x0003F00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299203, XrefRangeEnd = 299205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUpEvent(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00040E50 File Offset: 0x0003F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299205, XrefRangeEnd = 299214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusInEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnFocusInEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00040E84 File Offset: 0x0003F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299214, XrefRangeEnd = 299242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusOutEvent(FocusOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenTextEditorEventHandler.NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00005ACA File Offset: 0x00003CCA
		public TouchScreenTextEditorEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00040EC8 File Offset: 0x0003F0C8
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00005AD3 File Offset: 0x00003CD3
		public unsafe IVisualElementScheduledItem m_TouchKeyboardPoller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardPoller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardPoller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00040EF8 File Offset: 0x0003F0F8
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00005AF2 File Offset: 0x00003CF2
		public unsafe bool m_TouchKeyboardAllowsInPlaceEditing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00040F20 File Offset: 0x0003F120
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00005B0D File Offset: 0x00003D0D
		public unsafe bool m_IsClicking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_IsClicking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenTextEditorEventHandler.NativeFieldInfoPtr_m_IsClicking)) = value;
			}
		}

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardPoller;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeFieldInfoPtr_m_IsClicking;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_PollTouchScreenKeyboard_Private_Void_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_DoPollTouchScreenKeyboard_Private_Void_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStringPositionFromKeyboard_Private_Void_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_CloseTouchScreenKeyboard_Private_Void_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_OpenTouchScreenKeyboard_Private_Void_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUpEvent_Private_Void_PointerUpEvent_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusInEvent_Private_Void_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0;
	}
}
