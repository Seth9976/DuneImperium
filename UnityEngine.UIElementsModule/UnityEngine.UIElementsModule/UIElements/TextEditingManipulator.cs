using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D7 RID: 471
	public class TextEditingManipulator : Object
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x000A3A74 File Offset: 0x000A1C74
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditingManipulator()
		{
			Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextEditingManipulator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr);
			TextEditingManipulator.NativeFieldInfoPtr_m_TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, "m_TextElement");
			TextEditingManipulator.NativeFieldInfoPtr_editingEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, "editingEventHandler");
			TextEditingManipulator.NativeFieldInfoPtr_editingUtilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, "editingUtilities");
			TextEditingManipulator.NativeFieldInfoPtr_m_TouchScreenTextFieldInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, "m_TouchScreenTextFieldInitialized");
			TextEditingManipulator.NativeFieldInfoPtr_m_HardwareKeyboardPoller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, "m_HardwareKeyboardPoller");
			TextEditingManipulator.NativeMethodInfoPtr_get_touchScreenTextFieldChanged_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668828);
			TextEditingManipulator.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668829);
			TextEditingManipulator.NativeMethodInfoPtr_InitTextEditorEventHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668830);
			TextEditingManipulator.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668831);
			TextEditingManipulator.NativeMethodInfoPtr_OnFocusInEvent_Private_Void_FocusInEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668832);
			TextEditingManipulator.NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668833);
			TextEditingManipulator.NativeMethodInfoPtr__OnFocusInEvent_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr, 100668834);
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000A3B94 File Offset: 0x000A1D94
		public unsafe bool touchScreenTextFieldChanged
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 338582, RefRangeEnd = 338584, XrefRangeStart = 338576, XrefRangeEnd = 338582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr_get_touchScreenTextFieldChanged_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000A3BD0 File Offset: 0x000A1DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338595, RefRangeEnd = 338596, XrefRangeStart = 338584, XrefRangeEnd = 338595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditingManipulator(TextElement textElement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditingManipulator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textElement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr__ctor_Public_Void_TextElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000A3C1C File Offset: 0x000A1E1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338608, RefRangeEnd = 338611, XrefRangeStart = 338596, XrefRangeEnd = 338608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextEditorEventHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr_InitTextEditorEventHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000A3C50 File Offset: 0x000A1E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338626, RefRangeEnd = 338627, XrefRangeStart = 338611, XrefRangeEnd = 338626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000A3C94 File Offset: 0x000A1E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338640, RefRangeEnd = 338641, XrefRangeStart = 338627, XrefRangeEnd = 338640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusInEvent(FocusInEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr_OnFocusInEvent_Private_Void_FocusInEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000A3CD8 File Offset: 0x000A1ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338641, XrefRangeEnd = 338646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocusOutEvent(FocusOutEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000A3D1C File Offset: 0x000A1F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338646, XrefRangeEnd = 338648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnFocusInEvent_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditingManipulator.NativeMethodInfoPtr__OnFocusInEvent_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0000F092 File Offset: 0x0000D292
		public TextEditingManipulator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000A3D50 File Offset: 0x000A1F50
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0000F09B File Offset: 0x0000D29B
		public unsafe TextElement m_TextElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_TextElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_TextElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x000A3D80 File Offset: 0x000A1F80
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0000F0BA File Offset: 0x0000D2BA
		public unsafe TextEditorEventHandler editingEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_editingEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextEditorEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_editingEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x000A3DB0 File Offset: 0x000A1FB0
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0000F0D9 File Offset: 0x0000D2D9
		public unsafe TextEditingUtilities editingUtilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_editingUtilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextEditingUtilities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_editingUtilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x000A3DE0 File Offset: 0x000A1FE0
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
		public unsafe bool m_TouchScreenTextFieldInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_TouchScreenTextFieldInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_TouchScreenTextFieldInitialized)) = value;
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000A3E08 File Offset: 0x000A2008
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0000F113 File Offset: 0x0000D313
		public unsafe IVisualElementScheduledItem m_HardwareKeyboardPoller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_HardwareKeyboardPoller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditingManipulator.NativeFieldInfoPtr_m_HardwareKeyboardPoller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_m_TextElement;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeFieldInfoPtr_editingEventHandler;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeFieldInfoPtr_editingUtilities;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeFieldInfoPtr_m_TouchScreenTextFieldInitialized;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeFieldInfoPtr_m_HardwareKeyboardPoller;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_get_touchScreenTextFieldChanged_Private_get_Boolean_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextElement_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_InitTextEditorEventHandler_Private_Void_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Internal_Void_EventBase_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusInEvent_Private_Void_FocusInEvent_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_OnFocusOutEvent_Private_Void_FocusOutEvent_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr__OnFocusInEvent_b__10_0_Private_Void_0;
	}
}
