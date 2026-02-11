using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CC RID: 204
	public class ElementUnderPointer : Object
	{
		// Token: 0x060011DD RID: 4573 RVA: 0x0005B754 File Offset: 0x00059954
		// Note: this type is marked as 'beforefieldinit'.
		static ElementUnderPointer()
		{
			Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ElementUnderPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr);
			ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_PendingTopElementUnderPointer");
			ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TopElementUnderPointer");
			ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TriggerPointerEvent");
			ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_TriggerMouseEvent");
			ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_PickingPointerPositions");
			ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, "m_IsPickingPointerTemporaries");
			ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665833);
			ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665834);
			ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665835);
			ElementUnderPointer.NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665836);
			ElementUnderPointer.NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665837);
			ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665838);
			ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_Int32_EventBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665839);
			ElementUnderPointer.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665840);
			ElementUnderPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr, 100665841);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0005B8B0 File Offset: 0x00059AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312067, RefRangeEnd = 312068, XrefRangeStart = 312067, XrefRangeEnd = 312067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pickPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isTemporary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0005B918 File Offset: 0x00059B18
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 312068, RefRangeEnd = 312079, XrefRangeStart = 312068, XrefRangeEnd = 312068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0005B964 File Offset: 0x00059B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312087, RefRangeEnd = 312088, XrefRangeStart = 312079, XrefRangeEnd = 312087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0005B9C4 File Offset: 0x00059BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312088, XrefRangeEnd = 312094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetEventPointerPosition(EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0005BA14 File Offset: 0x00059C14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312095, RefRangeEnd = 312098, XrefRangeStart = 312094, XrefRangeEnd = 312095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0005BA78 File Offset: 0x00059C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312099, RefRangeEnd = 312100, XrefRangeStart = 312098, XrefRangeEnd = 312099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0005BADC File Offset: 0x00059CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312138, RefRangeEnd = 312140, XrefRangeStart = 312100, XrefRangeEnd = 312138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newElementUnderPointer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref temporary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_Int32_EventBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0005BB4C File Offset: 0x00059D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312273, RefRangeEnd = 312275, XrefRangeStart = 312140, XrefRangeEnd = 312273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_ContextType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005BB9C File Offset: 0x00059D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312308, RefRangeEnd = 312310, XrefRangeStart = 312275, XrefRangeEnd = 312308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ElementUnderPointer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementUnderPointer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ElementUnderPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00008F3C File Offset: 0x0000713C
		public ElementUnderPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0005BBD8 File Offset: 0x00059DD8
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x00008F45 File Offset: 0x00007145
		public unsafe Il2CppReferenceArray<VisualElement> m_PendingTopElementUnderPointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PendingTopElementUnderPointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0005BC08 File Offset: 0x00059E08
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x00008F64 File Offset: 0x00007164
		public unsafe Il2CppReferenceArray<VisualElement> m_TopElementUnderPointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TopElementUnderPointer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0005BC38 File Offset: 0x00059E38
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x00008F83 File Offset: 0x00007183
		public unsafe Il2CppReferenceArray<IPointerEvent> m_TriggerPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPointerEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0005BC68 File Offset: 0x00059E68
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x00008FA2 File Offset: 0x000071A2
		public unsafe Il2CppReferenceArray<IMouseEvent> m_TriggerMouseEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IMouseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_TriggerMouseEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0005BC98 File Offset: 0x00059E98
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x00008FC1 File Offset: 0x000071C1
		public unsafe Il2CppStructArray<Vector2> m_PickingPointerPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_PickingPointerPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0005BCC8 File Offset: 0x00059EC8
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x00008FE0 File Offset: 0x000071E0
		public unsafe Il2CppStructArray<bool> m_IsPickingPointerTemporaries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ElementUnderPointer.NativeFieldInfoPtr_m_IsPickingPointerTemporaries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingTopElementUnderPointer;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeFieldInfoPtr_m_TopElementUnderPointer;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerPointerEvent;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeFieldInfoPtr_m_TriggerMouseEvent;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeFieldInfoPtr_m_PickingPointerPositions;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeFieldInfoPtr_m_IsPickingPointerTemporaries;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_byref_Vector2_byref_Boolean_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_Vector2_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_GetEventPointerPosition_Private_Vector2_EventBase_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_SetTemporaryElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_SetElementUnderPointer_Internal_Void_VisualElement_Int32_EventBase_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_SetElementUnderPointer_Private_Void_VisualElement_Int32_EventBase_Boolean_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_EventDispatcher_ContextType_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
