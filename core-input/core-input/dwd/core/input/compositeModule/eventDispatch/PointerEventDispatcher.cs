using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace dwd.core.input.compositeModule.eventDispatch
{
	// Token: 0x0200009C RID: 156
	public class PointerEventDispatcher : UIEventDispatcher
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0001D664 File Offset: 0x0001B864
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventDispatcher()
		{
			Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.eventDispatch", "PointerEventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr);
			PointerEventDispatcher.NativeFieldInfoPtr_checkTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "checkTouch");
			PointerEventDispatcher.NativeFieldInfoPtr_checkMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "checkMouse");
			PointerEventDispatcher.NativeFieldInfoPtr_currentInputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "currentInputDetector");
			PointerEventDispatcher.NativeFieldInfoPtr_currentEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "currentEventSystem");
			PointerEventDispatcher.NativeFieldInfoPtr_touchPointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "touchPointerEventData");
			PointerEventDispatcher.NativeFieldInfoPtr_mousePointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "mousePointerEventData");
			PointerEventDispatcher.NativeFieldInfoPtr_pointerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "pointerDatas");
			PointerEventDispatcher.NativeFieldInfoPtr_raycastResultCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "raycastResultCache");
			PointerEventDispatcher.NativeFieldInfoPtr_MouseButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "MouseButtons");
			PointerEventDispatcher.NativeFieldInfoPtr_MouseButtonPointerDataIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "MouseButtonPointerDataIds");
			PointerEventDispatcher.NativeFieldInfoPtr_IgnoreRaycastLayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "IgnoreRaycastLayerIndex");
			PointerEventDispatcher.NativeFieldInfoPtr_LongTapThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, "LongTapThreshold");
			PointerEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664165);
			PointerEventDispatcher.NativeMethodInfoPtr_dispatchTouchEvents_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664166);
			PointerEventDispatcher.NativeMethodInfoPtr_dispatchMouseEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664167);
			PointerEventDispatcher.NativeMethodInfoPtr_getTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664168);
			PointerEventDispatcher.NativeMethodInfoPtr_getMousePointerEventData_Private_PointerEventData_InputButton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664169);
			PointerEventDispatcher.NativeMethodInfoPtr_getStateForMouseButton_Private_Void_InputButton_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664170);
			PointerEventDispatcher.NativeMethodInfoPtr_processPress_Protected_Void_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664171);
			PointerEventDispatcher.NativeMethodInfoPtr_processRelease_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664172);
			PointerEventDispatcher.NativeMethodInfoPtr_processMove_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664173);
			PointerEventDispatcher.NativeMethodInfoPtr_processDrag_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664174);
			PointerEventDispatcher.NativeMethodInfoPtr_handlePointerExitAndEnter_Private_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664175);
			PointerEventDispatcher.NativeMethodInfoPtr_ClearPointerData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664176);
			PointerEventDispatcher.NativeMethodInfoPtr_removePointerData_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664177);
			PointerEventDispatcher.NativeMethodInfoPtr_getPointerData_Private_Boolean_Int32_byref_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664178);
			PointerEventDispatcher.NativeMethodInfoPtr_shouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664179);
			PointerEventDispatcher.NativeMethodInfoPtr_findFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664180);
			PointerEventDispatcher.NativeMethodInfoPtr_findCommonRoot_Private_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664181);
			PointerEventDispatcher.NativeMethodInfoPtr_isMouseSupported_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664182);
			PointerEventDispatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664183);
			PointerEventDispatcher.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664184);
			PointerEventDispatcher.NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664185);
			PointerEventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr, 100664186);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001D93C File Offset: 0x0001BB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125711, XrefRangeEnd = 1125719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DispatchEvents(InputDetector inputDetector, EventSystem eventSystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventDispatcher.NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125719, XrefRangeEnd = 1125732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool dispatchTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventDispatcher.NativeMethodInfoPtr_dispatchTouchEvents_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001D9F0 File Offset: 0x0001BBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125760, RefRangeEnd = 1125761, XrefRangeStart = 1125732, XrefRangeEnd = 1125760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool dispatchMouseEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_dispatchMouseEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001DA2C File Offset: 0x0001BC2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1125781, RefRangeEnd = 1125784, XrefRangeStart = 1125761, XrefRangeEnd = 1125781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData getTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_getTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001DA94 File Offset: 0x0001BC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1125799, RefRangeEnd = 1125800, XrefRangeStart = 1125784, XrefRangeEnd = 1125799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData getMousePointerEventData(PointerEventData.InputButton mouseButton, Vector2 mousePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mouseButton;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_getMousePointerEventData_Private_PointerEventData_InputButton_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		[CallerCount(0)]
		public unsafe void getStateForMouseButton(PointerEventData.InputButton inputButton, out bool pressed, out bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputButton;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_getStateForMouseButton_Private_Void_InputButton_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001DB4C File Offset: 0x0001BD4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1125849, RefRangeEnd = 1125851, XrefRangeStart = 1125800, XrefRangeEnd = 1125849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void processPress(PointerEventData pointerEvent, bool simulatePointerEnter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref simulatePointerEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_processPress_Protected_Void_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001DB9C File Offset: 0x0001BD9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1125915, RefRangeEnd = 1125917, XrefRangeStart = 1125851, XrefRangeEnd = 1125915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void processRelease(PointerEventData pointerEvent, bool simulatePointerExit, bool longTapsAreClicks = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref simulatePointerExit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref longTapsAreClicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_processRelease_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1125942, RefRangeEnd = 1125944, XrefRangeStart = 1125917, XrefRangeEnd = 1125942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void processMove(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_processMove_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001DC40 File Offset: 0x0001BE40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1125985, RefRangeEnd = 1125988, XrefRangeStart = 1125944, XrefRangeEnd = 1125985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void processDrag(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_processDrag_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001DC84 File Offset: 0x0001BE84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1126112, RefRangeEnd = 1126116, XrefRangeStart = 1125988, XrefRangeEnd = 1126112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPointerData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEnterTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_handlePointerExitAndEnter_Private_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001DCD8 File Offset: 0x0001BED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126153, RefRangeEnd = 1126154, XrefRangeStart = 1126116, XrefRangeEnd = 1126153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPointerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_ClearPointerData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001DD0C File Offset: 0x0001BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126154, XrefRangeEnd = 1126158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void removePointerData(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_removePointerData_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001DD50 File Offset: 0x0001BF50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1126163, RefRangeEnd = 1126165, XrefRangeStart = 1126158, XrefRangeEnd = 1126163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool getPointerData(int id, out PointerEventData data, bool create)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_getPointerData_Private_Boolean_Int32_byref_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new PointerEventData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		[CallerCount(0)]
		public unsafe static bool shouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pressPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDragThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_shouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001DE34 File Offset: 0x0001C034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1126180, RefRangeEnd = 1126182, XrefRangeStart = 1126165, XrefRangeEnd = 1126180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastResult findFirstRaycast(List<RaycastResult> candidates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_findFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001DE70 File Offset: 0x0001C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126182, XrefRangeEnd = 1126205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject findCommonRoot(GameObject g1, GameObject g2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_findCommonRoot_Private_Static_GameObject_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126205, XrefRangeEnd = 1126206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool isMouseSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_isMouseSupported_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126206, XrefRangeEnd = 1126253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventDispatcher.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001DF3C File Offset: 0x0001C13C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126263, RefRangeEnd = 1126264, XrefRangeStart = 1126253, XrefRangeEnd = 1126263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject(int pointerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001DF88 File Offset: 0x0001C188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126264, XrefRangeEnd = 1126270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData PointerForIndex(int pointerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001DFD4 File Offset: 0x0001C1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126270, XrefRangeEnd = 1126289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00005A69 File Offset: 0x00003C69
		public PointerEventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001E010 File Offset: 0x0001C210
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00005A72 File Offset: 0x00003C72
		public unsafe bool checkTouch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_checkTouch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_checkTouch)) = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0001E038 File Offset: 0x0001C238
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00005A8D File Offset: 0x00003C8D
		public unsafe bool checkMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_checkMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_checkMouse)) = value;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0001E060 File Offset: 0x0001C260
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public unsafe InputDetector currentInputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_currentInputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_currentInputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001E090 File Offset: 0x0001C290
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00005AC7 File Offset: 0x00003CC7
		public unsafe EventSystem currentEventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_currentEventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_currentEventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005AE6 File Offset: 0x00003CE6
		public unsafe PointerEventData touchPointerEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_touchPointerEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_touchPointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00005B05 File Offset: 0x00003D05
		public unsafe PointerEventData mousePointerEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_mousePointerEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_mousePointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001E120 File Offset: 0x0001C320
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00005B24 File Offset: 0x00003D24
		public unsafe Dictionary<int, PointerEventData> pointerDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_pointerDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_pointerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001E150 File Offset: 0x0001C350
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00005B43 File Offset: 0x00003D43
		public unsafe List<RaycastResult> raycastResultCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_raycastResultCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventDispatcher.NativeFieldInfoPtr_raycastResultCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001E180 File Offset: 0x0001C380
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00005B62 File Offset: 0x00003D62
		public unsafe static Il2CppStructArray<PointerEventData.InputButton> MouseButtons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerEventDispatcher.NativeFieldInfoPtr_MouseButtons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PointerEventData.InputButton>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerEventDispatcher.NativeFieldInfoPtr_MouseButtons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00005B74 File Offset: 0x00003D74
		public unsafe static Dictionary<PointerEventData.InputButton, int> MouseButtonPointerDataIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerEventDispatcher.NativeFieldInfoPtr_MouseButtonPointerDataIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PointerEventData.InputButton, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerEventDispatcher.NativeFieldInfoPtr_MouseButtonPointerDataIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0001E1D0 File Offset: 0x0001C3D0
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00005B86 File Offset: 0x00003D86
		public unsafe static int IgnoreRaycastLayerIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerEventDispatcher.NativeFieldInfoPtr_IgnoreRaycastLayerIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerEventDispatcher.NativeFieldInfoPtr_IgnoreRaycastLayerIndex, (void*)(&value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001E1EC File Offset: 0x0001C3EC
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00005B94 File Offset: 0x00003D94
		public unsafe static float LongTapThreshold
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PointerEventDispatcher.NativeFieldInfoPtr_LongTapThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerEventDispatcher.NativeFieldInfoPtr_LongTapThreshold, (void*)(&value));
			}
		}

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_checkTouch;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_checkMouse;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_currentInputDetector;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_currentEventSystem;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_touchPointerEventData;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_mousePointerEventData;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_pointerDatas;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_raycastResultCache;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_MouseButtons;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_MouseButtonPointerDataIds;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreRaycastLayerIndex;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_LongTapThreshold;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Public_Virtual_Boolean_InputDetector_EventSystem_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_dispatchTouchEvents_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_dispatchMouseEvents_Private_Boolean_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_getTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_getMousePointerEventData_Private_PointerEventData_InputButton_Vector2_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_getStateForMouseButton_Private_Void_InputButton_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_processPress_Protected_Void_PointerEventData_Boolean_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_processRelease_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_processMove_Protected_Void_PointerEventData_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_processDrag_Protected_Void_PointerEventData_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_handlePointerExitAndEnter_Private_Void_PointerEventData_GameObject_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_ClearPointerData_Public_Void_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_removePointerData_Protected_Void_PointerEventData_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_getPointerData_Private_Boolean_Int32_byref_PointerEventData_Boolean_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_shouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_findFirstRaycast_Private_Static_RaycastResult_List_1_RaycastResult_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_findCommonRoot_Private_Static_GameObject_GameObject_GameObject_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_isMouseSupported_Private_Static_Boolean_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_PointerForIndex_Public_PointerEventData_Int32_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
