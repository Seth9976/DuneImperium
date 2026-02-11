using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A3 RID: 163
	public class DragEventsProcessor : Object
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x000555D0 File Offset: 0x000537D0
		// Note: this type is marked as 'beforefieldinit'.
		static DragEventsProcessor()
		{
			Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DragEventsProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr);
			DragEventsProcessor.NativeFieldInfoPtr_m_IsRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, "m_IsRegistered");
			DragEventsProcessor.NativeFieldInfoPtr_m_DragState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, "m_DragState");
			DragEventsProcessor.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, "m_Start");
			DragEventsProcessor.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, "m_Target");
			DragEventsProcessor.NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665607);
			DragEventsProcessor.NativeMethodInfoPtr_get_useDragEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665608);
			DragEventsProcessor.NativeMethodInfoPtr_get_dragAndDrop_Protected_get_IDragAndDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665609);
			DragEventsProcessor.NativeMethodInfoPtr_get_isEditorContext_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665610);
			DragEventsProcessor.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665611);
			DragEventsProcessor.NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665612);
			DragEventsProcessor.NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665613);
			DragEventsProcessor.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665614);
			DragEventsProcessor.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665615);
			DragEventsProcessor.NativeMethodInfoPtr_CanStartDrag_Protected_Abstract_Virtual_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665616);
			DragEventsProcessor.NativeMethodInfoPtr_StartDrag_FamOrAssem_Abstract_Virtual_New_StartDragArgs_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665617);
			DragEventsProcessor.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665618);
			DragEventsProcessor.NativeMethodInfoPtr_OnDrop_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665619);
			DragEventsProcessor.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665620);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665621);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerUpEvent_Internal_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665622);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerLeaveEvent_Private_Void_PointerLeaveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665623);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerCancelEvent_Private_Void_PointerCancelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665624);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerCapturedOut_Private_Void_PointerCaptureOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665625);
			DragEventsProcessor.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665626);
			DragEventsProcessor.NativeMethodInfoPtr_GetDropTarget_Private_DragEventsProcessor_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr, 100665627);
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000557F4 File Offset: 0x000539F4
		public unsafe virtual bool supportsDragEvents
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0005583C File Offset: 0x00053A3C
		public unsafe bool useDragEvents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310082, RefRangeEnd = 310083, XrefRangeStart = 310082, XrefRangeEnd = 310082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_get_useDragEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00055878 File Offset: 0x00053A78
		public unsafe IDragAndDrop dragAndDrop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310083, XrefRangeEnd = 310086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_get_dragAndDrop_Protected_get_IDragAndDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDragAndDrop>(intPtr3) : null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x000558B8 File Offset: 0x00053AB8
		public unsafe virtual bool isEditorContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310086, XrefRangeEnd = 310099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_get_isEditorContext_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00055900 File Offset: 0x00053B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310099, XrefRangeEnd = 310121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragEventsProcessor(VisualElement target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragEventsProcessor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0005594C File Offset: 0x00053B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310121, XrefRangeEnd = 310122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacksFromTarget(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00055990 File Offset: 0x00053B90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 310176, RefRangeEnd = 310180, XrefRangeStart = 310122, XrefRangeEnd = 310176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000559C4 File Offset: 0x00053BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310180, XrefRangeEnd = 310181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00055A08 File Offset: 0x00053C08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310253, RefRangeEnd = 310256, XrefRangeStart = 310181, XrefRangeEnd = 310253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unregisterPanelEvents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00055A48 File Offset: 0x00053C48
		[CallerCount(0)]
		public unsafe virtual bool CanStartDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_CanStartDrag_Protected_Abstract_Virtual_New_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00055A9C File Offset: 0x00053C9C
		[CallerCount(0)]
		public unsafe virtual StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_StartDrag_FamOrAssem_Abstract_Virtual_New_StartDragArgs_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StartDragArgs(intPtr);
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00055AEC File Offset: 0x00053CEC
		[CallerCount(0)]
		public unsafe virtual void UpdateDrag(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00055B38 File Offset: 0x00053D38
		[CallerCount(0)]
		public unsafe virtual void OnDrop(Vector3 pointerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_OnDrop_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00055B84 File Offset: 0x00053D84
		[CallerCount(0)]
		public unsafe virtual void ClearDragAndDropUI(bool dragCancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragCancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragEventsProcessor.NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00055BD0 File Offset: 0x00053DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310256, XrefRangeEnd = 310262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDownEvent(PointerDownEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00055C14 File Offset: 0x00053E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310262, XrefRangeEnd = 310272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUpEvent(PointerUpEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerUpEvent_Internal_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00055C58 File Offset: 0x00053E58
		[CallerCount(0)]
		public unsafe void OnPointerLeaveEvent(PointerLeaveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerLeaveEvent_Private_Void_PointerLeaveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00055C9C File Offset: 0x00053E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310272, XrefRangeEnd = 310279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCancelEvent(PointerCancelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerCancelEvent_Private_Void_PointerCancelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00055CE0 File Offset: 0x00053EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310279, XrefRangeEnd = 310284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerCapturedOut(PointerCaptureOutEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerCapturedOut_Private_Void_PointerCaptureOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00055D24 File Offset: 0x00053F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310284, XrefRangeEnd = 310298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMoveEvent(PointerMoveEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00055D68 File Offset: 0x00053F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310300, RefRangeEnd = 310301, XrefRangeStart = 310298, XrefRangeEnd = 310300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragEventsProcessor GetDropTarget(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragEventsProcessor.NativeMethodInfoPtr_GetDropTarget_Private_DragEventsProcessor_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragEventsProcessor>(intPtr3) : null;
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x000081EE File Offset: 0x000063EE
		public DragEventsProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00055DB4 File Offset: 0x00053FB4
		// (set) Token: 0x06001026 RID: 4134 RVA: 0x000081F7 File Offset: 0x000063F7
		public unsafe bool m_IsRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_IsRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_IsRegistered)) = value;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00055DDC File Offset: 0x00053FDC
		// (set) Token: 0x06001028 RID: 4136 RVA: 0x00008212 File Offset: 0x00006412
		public unsafe DragEventsProcessor.DragState m_DragState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_DragState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_DragState)) = value;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00055E04 File Offset: 0x00054004
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x0000822D File Offset: 0x0000642D
		public unsafe Vector3 m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00055E2C File Offset: 0x0005402C
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00008248 File Offset: 0x00006448
		public unsafe VisualElement m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragEventsProcessor.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00008267 File Offset: 0x00006467
		public bool isRegistered
		{
			get
			{
				return this.m_IsRegistered;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0000826F File Offset: 0x0000646F
		public DragEventsProcessor.DragState dragState
		{
			get
			{
				return this.m_DragState;
			}
		}

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_m_IsRegistered;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_m_DragState;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_supportsDragEvents_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_get_useDragEvents_Private_get_Boolean_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_get_dragAndDrop_Protected_get_IDragAndDrop_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_isEditorContext_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_VisualElement_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_AttachToPanelEvent_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksFromTarget_Private_Void_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Private_Void_DetachFromPanelEvent_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Internal_Void_Boolean_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDrag_Protected_Abstract_Virtual_New_Boolean_Vector3_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_StartDrag_FamOrAssem_Abstract_Virtual_New_StartDragArgs_Vector3_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_OnDrop_FamOrAssem_Abstract_Virtual_New_Void_Vector3_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_ClearDragAndDropUI_Protected_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDownEvent_Private_Void_PointerDownEvent_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUpEvent_Internal_Void_PointerUpEvent_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerLeaveEvent_Private_Void_PointerLeaveEvent_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCancelEvent_Private_Void_PointerCancelEvent_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerCapturedOut_Private_Void_PointerCaptureOutEvent_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMoveEvent_Private_Void_PointerMoveEvent_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_GetDropTarget_Private_DragEventsProcessor_Vector2_0;

		// Token: 0x020003E0 RID: 992
		public enum DragState
		{
			// Token: 0x0400293F RID: 10559
			None,
			// Token: 0x04002940 RID: 10560
			CanStartDrag,
			// Token: 0x04002941 RID: 10561
			Dragging
		}
	}
}
