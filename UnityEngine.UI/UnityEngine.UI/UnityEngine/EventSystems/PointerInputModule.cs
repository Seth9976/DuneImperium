using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006B RID: 107
	public class PointerInputModule : BaseInputModule
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x00030F70 File Offset: 0x0002F170
		// Note: this type is marked as 'beforefieldinit'.
		static PointerInputModule()
		{
			Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr);
			PointerInputModule.NativeFieldInfoPtr_kMouseLeftId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseLeftId");
			PointerInputModule.NativeFieldInfoPtr_kMouseRightId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseRightId");
			PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kMouseMiddleId");
			PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "kFakeTouchesId");
			PointerInputModule.NativeFieldInfoPtr_m_PointerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_PointerData");
			PointerInputModule.NativeFieldInfoPtr_m_MouseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "m_MouseState");
			PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665066);
			PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665067);
			PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665068);
			PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665069);
			PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665070);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665071);
			PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665072);
			PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665073);
			PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665074);
			PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665075);
			PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665076);
			PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665077);
			PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665078);
			PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665079);
			PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665080);
			PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, 100665081);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00031158 File Offset: 0x0002F358
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1096522, RefRangeEnd = 1096529, XrefRangeStart = 1096517, XrefRangeEnd = 1096522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPointerData(int id, out PointerEventData data, bool create)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			data = ((intPtr4 == 0) ? null : new PointerEventData(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000311D4 File Offset: 0x0002F3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096533, RefRangeEnd = 1096534, XrefRangeStart = 1096529, XrefRangeEnd = 1096533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePointerData(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00031218 File Offset: 0x0002F418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1096563, RefRangeEnd = 1096566, XrefRangeStart = 1096534, XrefRangeEnd = 1096563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00031280 File Offset: 0x0002F480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096566, XrefRangeEnd = 1096568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000312D4 File Offset: 0x0002F4D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1096570, RefRangeEnd = 1096573, XrefRangeStart = 1096568, XrefRangeEnd = 1096570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00031320 File Offset: 0x0002F520
		[CallerCount(0)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003136C File Offset: 0x0002F56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096573, XrefRangeEnd = 1096601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000313C4 File Offset: 0x0002F5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096601, XrefRangeEnd = 1096602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData GetLastPointerEventData(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00031410 File Offset: 0x0002F610
		[CallerCount(0)]
		public unsafe static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00031478 File Offset: 0x0002F678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1096606, RefRangeEnd = 1096607, XrefRangeStart = 1096602, XrefRangeEnd = 1096606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessMove(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000314C8 File Offset: 0x0002F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096607, XrefRangeEnd = 1096642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00031518 File Offset: 0x0002F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096642, XrefRangeEnd = 1096644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003156C File Offset: 0x0002F76C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1096666, RefRangeEnd = 1096668, XrefRangeStart = 1096644, XrefRangeEnd = 1096666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_ClearSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000315A0 File Offset: 0x0002F7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096668, XrefRangeEnd = 1096699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerInputModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000315E4 File Offset: 0x0002F7E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1096710, RefRangeEnd = 1096718, XrefRangeStart = 1096699, XrefRangeEnd = 1096710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00031638 File Offset: 0x0002F838
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1096745, RefRangeEnd = 1096748, XrefRangeStart = 1096718, XrefRangeEnd = 1096745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00005D14 File Offset: 0x00003F14
		public PointerInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00031674 File Offset: 0x0002F874
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00005D1D File Offset: 0x00003F1D
		public unsafe static int kMouseLeftId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseLeftId, (void*)(&value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00031690 File Offset: 0x0002F890
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00005D2B File Offset: 0x00003F2B
		public unsafe static int kMouseRightId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseRightId, (void*)(&value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000316AC File Offset: 0x0002F8AC
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00005D39 File Offset: 0x00003F39
		public unsafe static int kMouseMiddleId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kMouseMiddleId, (void*)(&value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000316C8 File Offset: 0x0002F8C8
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00005D47 File Offset: 0x00003F47
		public unsafe static int kFakeTouchesId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerInputModule.NativeFieldInfoPtr_kFakeTouchesId, (void*)(&value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000316E4 File Offset: 0x0002F8E4
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00005D55 File Offset: 0x00003F55
		public unsafe Dictionary<int, PointerEventData> m_PointerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PointerEventData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_PointerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00031714 File Offset: 0x0002F914
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00005D74 File Offset: 0x00003F74
		public unsafe PointerInputModule.MouseState m_MouseState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.NativeFieldInfoPtr_m_MouseState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_kMouseLeftId;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_kMouseRightId;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_kMouseMiddleId;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_kFakeTouchesId;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerData;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseState;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerData_Protected_Boolean_Int32_byref_PointerEventData_Boolean_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_RemovePointerData_Protected_Void_PointerEventData_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_GetTouchPointerEventData_Protected_PointerEventData_Touch_byref_Boolean_byref_Boolean_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_CopyFromTo_Protected_Void_PointerEventData_PointerEventData_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_StateForMouseButton_Protected_FramePressState_Int32_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_GetMousePointerEventData_Protected_Virtual_New_MouseState_Int32_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetLastPointerEventData_Protected_PointerEventData_Int32_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStartDrag_Private_Static_Boolean_Vector2_Vector2_Single_Boolean_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMove_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDrag_Protected_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Protected_Void_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_DeselectIfSelectionChanged_Protected_Void_GameObject_BaseEventData_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000D5 RID: 213
		public class ButtonState : Object
		{
			// Token: 0x06000DCB RID: 3531 RVA: 0x0003AB90 File Offset: 0x00038D90
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonState()
			{
				Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "ButtonState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr);
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_Button");
				PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, "m_EventData");
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665082);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665083);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665084);
				PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665085);
				PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr, 100665086);
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0003AC48 File Offset: 0x00038E48
			// (set) Token: 0x06000DCD RID: 3533 RVA: 0x0003AC88 File Offset: 0x00038E88
			public unsafe PointerInputModule.MouseButtonEventData eventData
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x06000DCE RID: 3534 RVA: 0x0003ACCC File Offset: 0x00038ECC
			// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0003AD08 File Offset: 0x00038F08
			public unsafe PointerEventData.InputButton button
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000DD0 RID: 3536 RVA: 0x0003AD48 File Offset: 0x00038F48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.ButtonState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.ButtonState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DD1 RID: 3537 RVA: 0x00007460 File Offset: 0x00005660
			public ButtonState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0003AD84 File Offset: 0x00038F84
			// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00007469 File Offset: 0x00005669
			public unsafe PointerEventData.InputButton m_Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_Button)) = value;
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0003ADAC File Offset: 0x00038FAC
			// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00007484 File Offset: 0x00005684
			public unsafe PointerInputModule.MouseButtonEventData m_EventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerInputModule.MouseButtonEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.ButtonState.NativeFieldInfoPtr_m_EventData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AB0 RID: 2736
			private static readonly IntPtr NativeFieldInfoPtr_m_Button;

			// Token: 0x04000AB1 RID: 2737
			private static readonly IntPtr NativeFieldInfoPtr_m_EventData;

			// Token: 0x04000AB2 RID: 2738
			private static readonly IntPtr NativeMethodInfoPtr_get_eventData_Public_get_MouseButtonEventData_0;

			// Token: 0x04000AB3 RID: 2739
			private static readonly IntPtr NativeMethodInfoPtr_set_eventData_Public_set_Void_MouseButtonEventData_0;

			// Token: 0x04000AB4 RID: 2740
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

			// Token: 0x04000AB5 RID: 2741
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

			// Token: 0x04000AB6 RID: 2742
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D6 RID: 214
		public class MouseState : Object
		{
			// Token: 0x06000DD6 RID: 3542 RVA: 0x0003ADDC File Offset: 0x00038FDC
			// Note: this type is marked as 'beforefieldinit'.
			static MouseState()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr);
				PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, "m_TrackedButtons");
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665087);
				PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665088);
				PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665089);
				PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665090);
				PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr, 100665091);
			}

			// Token: 0x06000DD7 RID: 3543 RVA: 0x0003AE80 File Offset: 0x00039080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096460, XrefRangeEnd = 1096464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyPressesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DD8 RID: 3544 RVA: 0x0003AEBC File Offset: 0x000390BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096464, XrefRangeEnd = 1096468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AnyReleasesThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DD9 RID: 3545 RVA: 0x0003AEF8 File Offset: 0x000390F8
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1096489, RefRangeEnd = 1096504, XrefRangeStart = 1096468, XrefRangeEnd = 1096489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerInputModule.ButtonState>(intPtr3) : null;
				}
			}

			// Token: 0x06000DDA RID: 3546 RVA: 0x0003AF44 File Offset: 0x00039144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096504, XrefRangeEnd = 1096507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref button;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stateForMouseButton;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DDB RID: 3547 RVA: 0x0003AFA4 File Offset: 0x000391A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1096507, XrefRangeEnd = 1096515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseState()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DDC RID: 3548 RVA: 0x000074A3 File Offset: 0x000056A3
			public MouseState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0003AFE0 File Offset: 0x000391E0
			// (set) Token: 0x06000DDE RID: 3550 RVA: 0x000074AC File Offset: 0x000056AC
			public unsafe List<PointerInputModule.ButtonState> m_TrackedButtons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PointerInputModule.ButtonState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseState.NativeFieldInfoPtr_m_TrackedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AB7 RID: 2743
			private static readonly IntPtr NativeFieldInfoPtr_m_TrackedButtons;

			// Token: 0x04000AB8 RID: 2744
			private static readonly IntPtr NativeMethodInfoPtr_AnyPressesThisFrame_Public_Boolean_0;

			// Token: 0x04000AB9 RID: 2745
			private static readonly IntPtr NativeMethodInfoPtr_AnyReleasesThisFrame_Public_Boolean_0;

			// Token: 0x04000ABA RID: 2746
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonState_Public_ButtonState_InputButton_0;

			// Token: 0x04000ABB RID: 2747
			private static readonly IntPtr NativeMethodInfoPtr_SetButtonState_Public_Void_InputButton_FramePressState_PointerEventData_0;

			// Token: 0x04000ABC RID: 2748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000D7 RID: 215
		public class MouseButtonEventData : Object
		{
			// Token: 0x06000DDF RID: 3551 RVA: 0x0003B010 File Offset: 0x00039210
			// Note: this type is marked as 'beforefieldinit'.
			static MouseButtonEventData()
			{
				Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PointerInputModule>.NativeClassPtr, "MouseButtonEventData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr);
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonState");
				PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, "buttonData");
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665092);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665093);
				PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr, 100665094);
			}

			// Token: 0x06000DE0 RID: 3552 RVA: 0x0003B0A0 File Offset: 0x000392A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1096515, RefRangeEnd = 1096516, XrefRangeStart = 1096515, XrefRangeEnd = 1096515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool PressedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x0003B0DC File Offset: 0x000392DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1096516, RefRangeEnd = 1096517, XrefRangeStart = 1096516, XrefRangeEnd = 1096516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ReleasedThisFrame()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x0003B118 File Offset: 0x00039318
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MouseButtonEventData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerInputModule.MouseButtonEventData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerInputModule.MouseButtonEventData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DE3 RID: 3555 RVA: 0x000074CB File Offset: 0x000056CB
			public MouseButtonEventData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0003B154 File Offset: 0x00039354
			// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x000074D4 File Offset: 0x000056D4
			public unsafe PointerEventData.FramePressState buttonState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonState)) = value;
				}
			}

			// Token: 0x17000488 RID: 1160
			// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0003B17C File Offset: 0x0003937C
			// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x000074EF File Offset: 0x000056EF
			public unsafe PointerEventData buttonData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerInputModule.MouseButtonEventData.NativeFieldInfoPtr_buttonData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000ABD RID: 2749
			private static readonly IntPtr NativeFieldInfoPtr_buttonState;

			// Token: 0x04000ABE RID: 2750
			private static readonly IntPtr NativeFieldInfoPtr_buttonData;

			// Token: 0x04000ABF RID: 2751
			private static readonly IntPtr NativeMethodInfoPtr_PressedThisFrame_Public_Boolean_0;

			// Token: 0x04000AC0 RID: 2752
			private static readonly IntPtr NativeMethodInfoPtr_ReleasedThisFrame_Public_Boolean_0;

			// Token: 0x04000AC1 RID: 2753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
