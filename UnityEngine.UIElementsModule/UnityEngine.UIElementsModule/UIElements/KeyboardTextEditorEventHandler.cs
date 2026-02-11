using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000068 RID: 104
	public class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x060009A4 RID: 2468 RVA: 0x0003F2C4 File Offset: 0x0003D4C4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyboardTextEditorEventHandler()
		{
			Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyboardTextEditorEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr);
			KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_ImguiEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, "m_ImguiEvent");
			KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, "m_Changed");
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664661);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664662);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnFocus_Private_Void_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664663);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnBlur_Private_Void_BlurEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664664);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664665);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_UpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664666);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664667);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664668);
			KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnNavigationEvent_Private_Void_NavigationEventBase_1_TEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr, 100664669);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0003F3D0 File Offset: 0x0003D5D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296576, RefRangeEnd = 296577, XrefRangeStart = 296564, XrefRangeEnd = 296576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyboardTextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editingUtilities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0003F430 File Offset: 0x0003D630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296577, XrefRangeEnd = 296627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyboardTextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0003F480 File Offset: 0x0003D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296627, XrefRangeEnd = 296636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFocus(FocusEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnFocus_Private_Void_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0003F4C4 File Offset: 0x0003D6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296636, XrefRangeEnd = 296640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBlur(BlurEvent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnBlur_Private_Void_BlurEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0003F508 File Offset: 0x0003D708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296683, RefRangeEnd = 296684, XrefRangeStart = 296640, XrefRangeEnd = 296683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyDown(KeyDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0003F54C File Offset: 0x0003D74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296684, XrefRangeEnd = 296705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_UpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0003F580 File Offset: 0x0003D780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296705, XrefRangeEnd = 296725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0003F5C4 File Offset: 0x0003D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296725, XrefRangeEnd = 296738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0003F608 File Offset: 0x0003D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296738, XrefRangeEnd = 296741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNavigationEvent<TEvent>(NavigationEventBase<TEvent> evt) where TEvent : NavigationEventBase<TEvent>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyboardTextEditorEventHandler.MethodInfoStoreGeneric_OnNavigationEvent_Private_Void_NavigationEventBase_1_TEvent_0<TEvent>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00005749 File Offset: 0x00003949
		public KeyboardTextEditorEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003F64C File Offset: 0x0003D84C
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00005752 File Offset: 0x00003952
		public unsafe Event m_ImguiEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_ImguiEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_ImguiEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0003F67C File Offset: 0x0003D87C
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00005771 File Offset: 0x00003971
		public unsafe bool m_Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_Changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyboardTextEditorEventHandler.NativeFieldInfoPtr_m_Changed)) = value;
			}
		}

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_m_ImguiEvent;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_m_Changed;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextElement_TextEditingUtilities_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_Void_EventBase_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Private_Void_FocusEvent_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_OnBlur_Private_Void_BlurEvent_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyDown_Private_Void_KeyDownEvent_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Private_Void_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateCommandEvent_Private_Void_ValidateCommandEvent_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_OnExecuteCommandEvent_Private_Void_ExecuteCommandEvent_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_OnNavigationEvent_Private_Void_NavigationEventBase_1_TEvent_0;

		// Token: 0x040006BF RID: 1727
		public const int k_LineFeed = 10;

		// Token: 0x040006C0 RID: 1728
		public const int k_Space = 32;

		// Token: 0x02000386 RID: 902
		private sealed class MethodInfoStoreGeneric_OnNavigationEvent_Private_Void_NavigationEventBase_1_TEvent_0<TEvent>
		{
			// Token: 0x040027C9 RID: 10185
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(KeyboardTextEditorEventHandler.NativeMethodInfoPtr_OnNavigationEvent_Private_Void_NavigationEventBase_1_TEvent_0, Il2CppClassPointerStore<KeyboardTextEditorEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr)) }))));
		}
	}
}
