using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000068 RID: 104
	public static class ExecuteEvents : Object
	{
		// Token: 0x06000A34 RID: 2612 RVA: 0x0002EB10 File Offset: 0x0002CD10
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteEvents()
		{
			Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "ExecuteEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr);
			ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerMoveHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerEnterHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerExitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerDownHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerUpHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_PointerClickHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InitializePotentialDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_BeginDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_EndDragHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DropHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DropHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_ScrollHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_UpdateSelectedHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SelectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_DeselectHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_MoveHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_SubmitHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_CancelHandler");
			ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "s_InternalTransformList");
			ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664976);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664977);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664978);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664979);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664980);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664981);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664982);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664983);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664984);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664985);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664986);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664987);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664988);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664989);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664990);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664991);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664992);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664993);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664994);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664995);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664996);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664997);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664998);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100664999);
			ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665000);
			ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665001);
			ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665002);
			ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665003);
			ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665004);
			ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665005);
			ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665006);
			ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665007);
			ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665008);
			ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665009);
			ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665010);
			ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665011);
			ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665012);
			ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665013);
			ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665014);
			ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665015);
			ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665016);
			ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665017);
			ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665018);
			ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, 100665019);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002F02C File Offset: 0x0002D22C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1095680, RefRangeEnd = 1095693, XrefRangeStart = 1095672, XrefRangeEnd = 1095680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ValidateEventData<T>(BaseEventData data) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002F06C File Offset: 0x0002D26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095693, XrefRangeEnd = 1095703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerMoveHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095703, XrefRangeEnd = 1095713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerEnterHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095713, XrefRangeEnd = 1095723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerExitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002F144 File Offset: 0x0002D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095723, XrefRangeEnd = 1095733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerDownHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002F18C File Offset: 0x0002D38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095733, XrefRangeEnd = 1095743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerUpHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095743, XrefRangeEnd = 1095753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IPointerClickHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002F21C File Offset: 0x0002D41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095753, XrefRangeEnd = 1095763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002F264 File Offset: 0x0002D464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095763, XrefRangeEnd = 1095773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IBeginDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002F2AC File Offset: 0x0002D4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095773, XrefRangeEnd = 1095783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095783, XrefRangeEnd = 1095793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IEndDragHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002F33C File Offset: 0x0002D53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095793, XrefRangeEnd = 1095803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDropHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002F384 File Offset: 0x0002D584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095803, XrefRangeEnd = 1095813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IScrollHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002F3CC File Offset: 0x0002D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095813, XrefRangeEnd = 1095817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002F414 File Offset: 0x0002D614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095817, XrefRangeEnd = 1095821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISelectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002F45C File Offset: 0x0002D65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095821, XrefRangeEnd = 1095825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IDeselectHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002F4A4 File Offset: 0x0002D6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095825, XrefRangeEnd = 1095836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(IMoveHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002F4EC File Offset: 0x0002D6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095836, XrefRangeEnd = 1095840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ISubmitHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002F534 File Offset: 0x0002D734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095840, XrefRangeEnd = 1095844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Execute(ICancelHandler handler, BaseEventData eventData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002F57C File Offset: 0x0002D77C
		public unsafe static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095844, XrefRangeEnd = 1095848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerMoveHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095848, XrefRangeEnd = 1095852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095852, XrefRangeEnd = 1095856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0002F618 File Offset: 0x0002D818
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095856, XrefRangeEnd = 1095860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0002F64C File Offset: 0x0002D84C
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095860, XrefRangeEnd = 1095864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002F680 File Offset: 0x0002D880
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095864, XrefRangeEnd = 1095868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002F6B4 File Offset: 0x0002D8B4
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095868, XrefRangeEnd = 1095872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0002F6E8 File Offset: 0x0002D8E8
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095872, XrefRangeEnd = 1095876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002F71C File Offset: 0x0002D91C
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> dragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095876, XrefRangeEnd = 1095880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x0002F750 File Offset: 0x0002D950
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095880, XrefRangeEnd = 1095884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002F784 File Offset: 0x0002D984
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> dropHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095884, XrefRangeEnd = 1095888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0002F7B8 File Offset: 0x0002D9B8
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095888, XrefRangeEnd = 1095892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002F7EC File Offset: 0x0002D9EC
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095892, XrefRangeEnd = 1095896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002F820 File Offset: 0x0002DA20
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> selectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095896, XrefRangeEnd = 1095900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002F854 File Offset: 0x0002DA54
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095900, XrefRangeEnd = 1095904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0002F888 File Offset: 0x0002DA88
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> moveHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095904, XrefRangeEnd = 1095908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002F8BC File Offset: 0x0002DABC
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095908, XrefRangeEnd = 1095912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002F8F0 File Offset: 0x0002DAF0
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095912, XrefRangeEnd = 1095916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002F924 File Offset: 0x0002DB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1095932, RefRangeEnd = 1095933, XrefRangeStart = 1095916, XrefRangeEnd = 1095932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventChain(GameObject root, IList<Transform> eventChain)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002F96C File Offset: 0x0002DB6C
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 1095976, RefRangeEnd = 1096047, XrefRangeStart = 1095933, XrefRangeEnd = 1095976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(functor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1096065, RefRangeEnd = 1096098, XrefRangeStart = 1096047, XrefRangeEnd = 1096065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callbackFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002FA3C File Offset: 0x0002DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096098, XrefRangeEnd = 1096109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldSendToComponent<T>(Component component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002FA80 File Offset: 0x0002DC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1096156, RefRangeEnd = 1096159, XrefRangeStart = 1096109, XrefRangeEnd = 1096156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002FAC8 File Offset: 0x0002DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096159, XrefRangeEnd = 1096174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanHandleEvent<T>(GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002FB0C File Offset: 0x0002DD0C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1096206, RefRangeEnd = 1096238, XrefRangeStart = 1096174, XrefRangeEnd = 1096206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject GetEventHandler<T>(GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00005ACE File Offset: 0x00003CCE
		public ExecuteEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002FB50 File Offset: 0x0002DD50
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00005AD7 File Offset: 0x00003CD7
		public unsafe static ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerMoveHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerMoveHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002FB78 File Offset: 0x0002DD78
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public unsafe static ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerEnterHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerEnterHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002FBA0 File Offset: 0x0002DDA0
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00005AFB File Offset: 0x00003CFB
		public unsafe static ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerExitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerExitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00005B0D File Offset: 0x00003D0D
		public unsafe static ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerDownHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerDownHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00005B1F File Offset: 0x00003D1F
		public unsafe static ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerUpHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerUpHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002FC18 File Offset: 0x0002DE18
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00005B31 File Offset: 0x00003D31
		public unsafe static ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IPointerClickHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_PointerClickHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002FC40 File Offset: 0x0002DE40
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00005B43 File Offset: 0x00003D43
		public unsafe static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IInitializePotentialDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InitializePotentialDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002FC68 File Offset: 0x0002DE68
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00005B55 File Offset: 0x00003D55
		public unsafe static ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IBeginDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_BeginDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002FC90 File Offset: 0x0002DE90
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00005B67 File Offset: 0x00003D67
		public unsafe static ExecuteEvents.EventFunction<IDragHandler> s_DragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00005B79 File Offset: 0x00003D79
		public unsafe static ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IEndDragHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_EndDragHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002FCE0 File Offset: 0x0002DEE0
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005B8B File Offset: 0x00003D8B
		public unsafe static ExecuteEvents.EventFunction<IDropHandler> s_DropHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDropHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DropHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0002FD08 File Offset: 0x0002DF08
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00005B9D File Offset: 0x00003D9D
		public unsafe static ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IScrollHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_ScrollHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002FD30 File Offset: 0x0002DF30
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00005BAF File Offset: 0x00003DAF
		public unsafe static ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IUpdateSelectedHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_UpdateSelectedHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002FD58 File Offset: 0x0002DF58
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00005BC1 File Offset: 0x00003DC1
		public unsafe static ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISelectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SelectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002FD80 File Offset: 0x0002DF80
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00005BD3 File Offset: 0x00003DD3
		public unsafe static ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IDeselectHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_DeselectHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00005BE5 File Offset: 0x00003DE5
		public unsafe static ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<IMoveHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_MoveHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00005BF7 File Offset: 0x00003DF7
		public unsafe static ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ISubmitHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_SubmitHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00005C09 File Offset: 0x00003E09
		public unsafe static ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecuteEvents.EventFunction<ICancelHandler>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_CancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002FE20 File Offset: 0x0002E020
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00005C1B File Offset: 0x00003E1B
		public unsafe static List<Transform> s_InternalTransformList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExecuteEvents.NativeFieldInfoPtr_s_InternalTransformList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerMoveHandler;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerEnterHandler;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerExitHandler;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerDownHandler;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerUpHandler;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_s_PointerClickHandler;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_s_InitializePotentialDragHandler;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_s_BeginDragHandler;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_s_DragHandler;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_s_EndDragHandler;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_s_DropHandler;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_s_ScrollHandler;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_s_UpdateSelectedHandler;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectHandler;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_s_DeselectHandler;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_s_MoveHandler;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_s_SubmitHandler;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_s_CancelHandler;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalTransformList;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerMoveHandler_BaseEventData_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerEnterHandler_BaseEventData_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerExitHandler_BaseEventData_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerDownHandler_BaseEventData_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerUpHandler_BaseEventData_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IPointerClickHandler_BaseEventData_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IInitializePotentialDragHandler_BaseEventData_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IBeginDragHandler_BaseEventData_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDragHandler_BaseEventData_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IEndDragHandler_BaseEventData_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDropHandler_BaseEventData_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IScrollHandler_BaseEventData_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IUpdateSelectedHandler_BaseEventData_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISelectHandler_BaseEventData_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IDeselectHandler_BaseEventData_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_IMoveHandler_BaseEventData_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ISubmitHandler_BaseEventData_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_ICancelHandler_BaseEventData_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerMoveHandler_Public_Static_get_EventFunction_1_IPointerMoveHandler_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnterHandler_Public_Static_get_EventFunction_1_IPointerEnterHandler_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerExitHandler_Public_Static_get_EventFunction_1_IPointerExitHandler_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDownHandler_Public_Static_get_EventFunction_1_IPointerDownHandler_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerUpHandler_Public_Static_get_EventFunction_1_IPointerUpHandler_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClickHandler_Public_Static_get_EventFunction_1_IPointerClickHandler_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_get_initializePotentialDrag_Public_Static_get_EventFunction_1_IInitializePotentialDragHandler_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_beginDragHandler_Public_Static_get_EventFunction_1_IBeginDragHandler_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_get_dragHandler_Public_Static_get_EventFunction_1_IDragHandler_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_get_endDragHandler_Public_Static_get_EventFunction_1_IEndDragHandler_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_get_dropHandler_Public_Static_get_EventFunction_1_IDropHandler_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollHandler_Public_Static_get_EventFunction_1_IScrollHandler_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_get_updateSelectedHandler_Public_Static_get_EventFunction_1_IUpdateSelectedHandler_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_get_selectHandler_Public_Static_get_EventFunction_1_ISelectHandler_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_get_deselectHandler_Public_Static_get_EventFunction_1_IDeselectHandler_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_get_moveHandler_Public_Static_get_EventFunction_1_IMoveHandler_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_get_submitHandler_Public_Static_get_EventFunction_1_ISubmitHandler_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelHandler_Public_Static_get_EventFunction_1_ICancelHandler_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_GetEventChain_Private_Static_Void_GameObject_IList_1_Transform_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0;

		// Token: 0x020000CD RID: 205
		public sealed class EventFunction<T1> : MulticastDelegate
		{
			// Token: 0x06000DBB RID: 3515 RVA: 0x0003A6AC File Offset: 0x000388AC
			// Note: this type is marked as 'beforefieldinit'.
			static EventFunction()
			{
				Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr, "EventFunction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) })).TypeHandle.value);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665021);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665022);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665023);
				ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr, 100665024);
			}

			// Token: 0x06000DBC RID: 3516 RVA: 0x0003A758 File Offset: 0x00038958
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EventFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteEvents.EventFunction<T1>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DBD RID: 3517 RVA: 0x0003A7B4 File Offset: 0x000389B4
			[CallerCount(0)]
			public unsafe void Invoke(T1 handler, BaseEventData eventData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref handler;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06000DBE RID: 3518 RVA: 0x0003A840 File Offset: 0x00038A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T1).IsValueType)
					{
						T1 t = handler;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref handler;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06000DBF RID: 3519 RVA: 0x0003A900 File Offset: 0x00038B00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteEvents.EventFunction<T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000DC0 RID: 3520 RVA: 0x00007430 File Offset: 0x00005630
			public EventFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000DC1 RID: 3521 RVA: 0x00007439 File Offset: 0x00005639
			public static implicit operator ExecuteEvents.EventFunction<T1>(Action<T1, BaseEventData> A_0)
			{
				return DelegateSupport.ConvertDelegate<ExecuteEvents.EventFunction<T1>>(A_0);
			}

			// Token: 0x06000DC2 RID: 3522 RVA: 0x00007441 File Offset: 0x00005641
			public static ExecuteEvents.EventFunction<T1>operator +(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ExecuteEvents.EventFunction<T1>>();
			}

			// Token: 0x06000DC3 RID: 3523 RVA: 0x0000744F File Offset: 0x0000564F
			public static ExecuteEvents.EventFunction<T1>operator -(ExecuteEvents.EventFunction<T1> A_0, ExecuteEvents.EventFunction<T1> A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ExecuteEvents.EventFunction<T1>>();
				}
				return delegate2;
			}

			// Token: 0x04000AA5 RID: 2725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000AA6 RID: 2726
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_BaseEventData_0;

			// Token: 0x04000AA7 RID: 2727
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T1_BaseEventData_AsyncCallback_Object_0;

			// Token: 0x04000AA8 RID: 2728
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020000CE RID: 206
		private sealed class MethodInfoStoreGeneric_ValidateEventData_Public_Static_T_BaseEventData_0<T>
		{
			// Token: 0x04000AA9 RID: 2729
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ValidateEventData_Public_Static_T_BaseEventData_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000CF RID: 207
		private sealed class MethodInfoStoreGeneric_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x04000AAA RID: 2730
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_Execute_Public_Static_Boolean_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D0 RID: 208
		private sealed class MethodInfoStoreGeneric_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0<T>
		{
			// Token: 0x04000AAB RID: 2731
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ExecuteHierarchy_Public_Static_GameObject_GameObject_BaseEventData_EventFunction_1_T_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D1 RID: 209
		private sealed class MethodInfoStoreGeneric_ShouldSendToComponent_Private_Static_Boolean_Component_0<T>
		{
			// Token: 0x04000AAC RID: 2732
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_ShouldSendToComponent_Private_Static_Boolean_Component_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D2 RID: 210
		private sealed class MethodInfoStoreGeneric_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0<T>
		{
			// Token: 0x04000AAD RID: 2733
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventList_Private_Static_Void_GameObject_IList_1_IEventSystemHandler_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D3 RID: 211
		private sealed class MethodInfoStoreGeneric_CanHandleEvent_Public_Static_Boolean_GameObject_0<T>
		{
			// Token: 0x04000AAE RID: 2734
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_CanHandleEvent_Public_Static_Boolean_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020000D4 RID: 212
		private sealed class MethodInfoStoreGeneric_GetEventHandler_Public_Static_GameObject_GameObject_0<T>
		{
			// Token: 0x04000AAF RID: 2735
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExecuteEvents.NativeMethodInfoPtr_GetEventHandler_Public_Static_GameObject_GameObject_0, Il2CppClassPointerStore<ExecuteEvents>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
