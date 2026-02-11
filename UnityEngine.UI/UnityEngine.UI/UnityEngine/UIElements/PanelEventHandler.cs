using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004B RID: 75
	public class PanelEventHandler : UIBehaviour
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x0002940C File Offset: 0x0002760C
		// Note: this type is marked as 'beforefieldinit'.
		static PanelEventHandler()
		{
			Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UIElements", "PanelEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr);
			PanelEventHandler.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Panel");
			PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_PointerEvent");
			PanelEventHandler.NativeFieldInfoPtr_m_LastClickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_LastClickTime");
			PanelEventHandler.NativeFieldInfoPtr_m_Selecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Selecting");
			PanelEventHandler.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Event");
			PanelEventHandler.NativeFieldInfoPtr_s_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "s_Modifiers");
			PanelEventHandler.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664711);
			PanelEventHandler.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664712);
			PanelEventHandler.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664713);
			PanelEventHandler.NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664714);
			PanelEventHandler.NativeMethodInfoPtr_get_isCurrentFocusedPanel_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664715);
			PanelEventHandler.NativeMethodInfoPtr_get_currentFocusedElement_Private_get_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664716);
			PanelEventHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664717);
			PanelEventHandler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664718);
			PanelEventHandler.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664719);
			PanelEventHandler.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664720);
			PanelEventHandler.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664721);
			PanelEventHandler.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664722);
			PanelEventHandler.NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664723);
			PanelEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664724);
			PanelEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664725);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664726);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664727);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664728);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664729);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664730);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664731);
			PanelEventHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664732);
			PanelEventHandler.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664733);
			PanelEventHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664734);
			PanelEventHandler.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664735);
			PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664736);
			PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664737);
			PanelEventHandler.NativeMethodInfoPtr_Update_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664738);
			PanelEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664739);
			PanelEventHandler.NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664740);
			PanelEventHandler.NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664741);
			PanelEventHandler.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664742);
			PanelEventHandler.NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Direction_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664743);
			PanelEventHandler.NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664744);
			PanelEventHandler.NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664745);
			PanelEventHandler.NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664746);
			PanelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664747);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00029798 File Offset: 0x00027998
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000297D8 File Offset: 0x000279D8
		public unsafe virtual IPanel panel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094307, XrefRangeEnd = 1094312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0002981C File Offset: 0x00027A1C
		public unsafe GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0002985C File Offset: 0x00027A5C
		public unsafe EventSystem eventSystem
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1094320, RefRangeEnd = 1094332, XrefRangeStart = 1094312, XrefRangeEnd = 1094320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0002989C File Offset: 0x00027A9C
		public unsafe bool isCurrentFocusedPanel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094332, XrefRangeEnd = 1094342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_isCurrentFocusedPanel_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x000298D8 File Offset: 0x00027AD8
		public unsafe Focusable currentFocusedElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094342, XrefRangeEnd = 1094343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_currentFocusedElement_Private_get_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00029918 File Offset: 0x00027B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094343, XrefRangeEnd = 1094344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelEventHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00029954 File Offset: 0x00027B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094344, XrefRangeEnd = 1094345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelEventHandler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00029990 File Offset: 0x00027B90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1094370, RefRangeEnd = 1094373, XrefRangeStart = 1094345, XrefRangeEnd = 1094370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000299C4 File Offset: 0x00027BC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1094398, RefRangeEnd = 1094401, XrefRangeStart = 1094373, XrefRangeEnd = 1094398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000299F8 File Offset: 0x00027BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094401, XrefRangeEnd = 1094405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00029A2C File Offset: 0x00027C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094405, XrefRangeEnd = 1094412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementFocus(FocusEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00029A70 File Offset: 0x00027C70
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementBlur(BlurEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00029AB4 File Offset: 0x00027CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094412, XrefRangeEnd = 1094415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00029AF8 File Offset: 0x00027CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094415, XrefRangeEnd = 1094416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00029B3C File Offset: 0x00027D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094416, XrefRangeEnd = 1094428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerMove(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00029B80 File Offset: 0x00027D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094428, XrefRangeEnd = 1094446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00029BC4 File Offset: 0x00027DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094446, XrefRangeEnd = 1094470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00029C08 File Offset: 0x00027E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094470, XrefRangeEnd = 1094502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00029C4C File Offset: 0x00027E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094502, XrefRangeEnd = 1094504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00029C90 File Offset: 0x00027E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094504, XrefRangeEnd = 1094505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00029CD4 File Offset: 0x00027ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094505, XrefRangeEnd = 1094521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00029D18 File Offset: 0x00027F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094521, XrefRangeEnd = 1094537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00029D5C File Offset: 0x00027F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094537, XrefRangeEnd = 1094554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00029DA0 File Offset: 0x00027FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094554, XrefRangeEnd = 1094567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00029DE4 File Offset: 0x00027FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094567, XrefRangeEnd = 1094569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, BaseEventData sourceEventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00029E38 File Offset: 0x00028038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094569, XrefRangeEnd = 1094571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, Event sourceEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00029E8C File Offset: 0x0002808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094571, XrefRangeEnd = 1094583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_Update_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00029EC0 File Offset: 0x000280C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094583, XrefRangeEnd = 1094584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00029EF4 File Offset: 0x000280F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1094600, RefRangeEnd = 1094605, XrefRangeStart = 1094584, XrefRangeEnd = 1094600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessImguiEvents(Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00029F38 File Offset: 0x00028138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094608, RefRangeEnd = 1094609, XrefRangeStart = 1094605, XrefRangeEnd = 1094608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessKeyboardEvent(Event e, Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00029F8C File Offset: 0x0002818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094609, XrefRangeEnd = 1094612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTabEvent(Event e, Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00029FE0 File Offset: 0x000281E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1094626, RefRangeEnd = 1094628, XrefRangeStart = 1094612, XrefRangeEnd = 1094626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Direction_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0002A044 File Offset: 0x00028244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094628, XrefRangeEnd = 1094642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendKeyUpEvent(Event e, Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0002A098 File Offset: 0x00028298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1094656, RefRangeEnd = 1094657, XrefRangeStart = 1094642, XrefRangeEnd = 1094656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendKeyDownEvent(Event e, Focusable target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002A0EC File Offset: 0x000282EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1094669, RefRangeEnd = 1094675, XrefRangeStart = 1094657, XrefRangeEnd = 1094669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, PanelEventHandler.PointerEventType eventType = PanelEventHandler.PointerEventType.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002A15C File Offset: 0x0002835C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094675, XrefRangeEnd = 1094686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelEventHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00004FD3 File Offset: 0x000031D3
		public PanelEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002A198 File Offset: 0x00028398
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00004FDC File Offset: 0x000031DC
		public unsafe BaseRuntimePanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0002A1C8 File Offset: 0x000283C8
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00004FFB File Offset: 0x000031FB
		public unsafe PanelEventHandler.PointerEvent m_PointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelEventHandler.PointerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0002A1F8 File Offset: 0x000283F8
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0000501A File Offset: 0x0000321A
		public unsafe float m_LastClickTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_LastClickTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_LastClickTime)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0002A220 File Offset: 0x00028420
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00005035 File Offset: 0x00003235
		public unsafe bool m_Selecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Selecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Selecting)) = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002A248 File Offset: 0x00028448
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00005050 File Offset: 0x00003250
		public unsafe Event m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002A278 File Offset: 0x00028478
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0000506F File Offset: 0x0000326F
		public unsafe static EventModifiers s_Modifiers
		{
			get
			{
				EventModifiers eventModifiers;
				IL2CPP.il2cpp_field_static_get_value(PanelEventHandler.NativeFieldInfoPtr_s_Modifiers, (void*)(&eventModifiers));
				return eventModifiers;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelEventHandler.NativeFieldInfoPtr_s_Modifiers, (void*)(&value));
			}
		}

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerEvent;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_m_LastClickTime;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr_m_Selecting;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_s_Modifiers;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentFocusedPanel_Private_get_Boolean_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_get_currentFocusedElement_Private_get_Focusable_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_Update_Internal_Void_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Focusable_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_Focusable_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_Focusable_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Direction_Focusable_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_Focusable_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_Focusable_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_PointerEventType_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C5 RID: 197
		public enum PointerEventType
		{
			// Token: 0x04000A4A RID: 2634
			Default,
			// Token: 0x04000A4B RID: 2635
			Down,
			// Token: 0x04000A4C RID: 2636
			Up
		}

		// Token: 0x020000C6 RID: 198
		public class PointerEvent : Object
		{
			// Token: 0x06000D47 RID: 3399 RVA: 0x00038EB0 File Offset: 0x000370B0
			// Note: this type is marked as 'beforefieldinit'.
			static PointerEvent()
			{
				Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "PointerEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr);
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pointerId>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pointerType>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<isPrimary>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<button>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pressedButtons>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<position>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<localPosition>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<deltaPosition>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<deltaTime>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<clickCount>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pressure>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<tangentialPressure>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<altitudeAngle>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<azimuthAngle>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<twist>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tilt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<tilt>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__penStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<penStatus>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<radius>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<radiusVariance>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<modifiers>k__BackingField");
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664748);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664749);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664750);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664751);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664752);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664753);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664754);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664755);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664756);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664757);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664758);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664759);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664760);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664761);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664762);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664763);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664764);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664765);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664766);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664767);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664768);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664769);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664770);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664771);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664772);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664773);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664774);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664775);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664776);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664777);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664778);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tilt_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664779);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664780);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_penStatus_Private_set_Void_PenStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664781);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664782);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664783);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664784);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664785);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664786);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664787);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664788);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664789);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664790);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664791);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664792);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664793);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664794);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664795);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100664796);
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06000D48 RID: 3400 RVA: 0x00039440 File Offset: 0x00037640
			// (set) Token: 0x06000D49 RID: 3401 RVA: 0x0003947C File Offset: 0x0003767C
			public unsafe virtual int pointerId
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000394BC File Offset: 0x000376BC
			// (set) Token: 0x06000D4B RID: 3403 RVA: 0x000394F4 File Offset: 0x000376F4
			public unsafe virtual string pointerType
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00039538 File Offset: 0x00037738
			// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00039574 File Offset: 0x00037774
			public unsafe virtual bool isPrimary
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06000D4E RID: 3406 RVA: 0x000395B4 File Offset: 0x000377B4
			// (set) Token: 0x06000D4F RID: 3407 RVA: 0x000395F0 File Offset: 0x000377F0
			public unsafe virtual int button
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00039630 File Offset: 0x00037830
			// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0003966C File Offset: 0x0003786C
			public unsafe virtual int pressedButtons
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06000D52 RID: 3410 RVA: 0x000396AC File Offset: 0x000378AC
			// (set) Token: 0x06000D53 RID: 3411 RVA: 0x000396E8 File Offset: 0x000378E8
			public unsafe virtual Vector3 position
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00039728 File Offset: 0x00037928
			// (set) Token: 0x06000D55 RID: 3413 RVA: 0x00039764 File Offset: 0x00037964
			public unsafe virtual Vector3 localPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046A RID: 1130
			// (get) Token: 0x06000D56 RID: 3414 RVA: 0x000397A4 File Offset: 0x000379A4
			// (set) Token: 0x06000D57 RID: 3415 RVA: 0x000397E0 File Offset: 0x000379E0
			public unsafe virtual Vector3 deltaPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046B RID: 1131
			// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00039820 File Offset: 0x00037A20
			// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0003985C File Offset: 0x00037A5C
			public unsafe virtual float deltaTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 885351, RefRangeEnd = 885352, XrefRangeStart = 885351, XrefRangeEnd = 885352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046C RID: 1132
			// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0003989C File Offset: 0x00037A9C
			// (set) Token: 0x06000D5B RID: 3419 RVA: 0x000398D8 File Offset: 0x00037AD8
			public unsafe virtual int clickCount
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046D RID: 1133
			// (get) Token: 0x06000D5C RID: 3420 RVA: 0x00039918 File Offset: 0x00037B18
			// (set) Token: 0x06000D5D RID: 3421 RVA: 0x00039954 File Offset: 0x00037B54
			public unsafe virtual float pressure
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 357469, RefRangeEnd = 357470, XrefRangeStart = 357469, XrefRangeEnd = 357470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046E RID: 1134
			// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00039994 File Offset: 0x00037B94
			// (set) Token: 0x06000D5F RID: 3423 RVA: 0x000399D0 File Offset: 0x00037BD0
			public unsafe virtual float tangentialPressure
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1080808, RefRangeEnd = 1080809, XrefRangeStart = 1080808, XrefRangeEnd = 1080809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700046F RID: 1135
			// (get) Token: 0x06000D60 RID: 3424 RVA: 0x00039A10 File Offset: 0x00037C10
			// (set) Token: 0x06000D61 RID: 3425 RVA: 0x00039A4C File Offset: 0x00037C4C
			public unsafe virtual float altitudeAngle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000470 RID: 1136
			// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00039A8C File Offset: 0x00037C8C
			// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00039AC8 File Offset: 0x00037CC8
			public unsafe virtual float azimuthAngle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000471 RID: 1137
			// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00039B08 File Offset: 0x00037D08
			// (set) Token: 0x06000D65 RID: 3429 RVA: 0x00039B44 File Offset: 0x00037D44
			public unsafe virtual float twist
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000472 RID: 1138
			// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00039B84 File Offset: 0x00037D84
			// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00039BC0 File Offset: 0x00037DC0
			public unsafe virtual Vector2 tilt
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tilt_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000473 RID: 1139
			// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00039C00 File Offset: 0x00037E00
			// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00039C3C File Offset: 0x00037E3C
			public unsafe virtual PenStatus penStatus
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_penStatus_Private_set_Void_PenStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00039C7C File Offset: 0x00037E7C
			// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00039CB8 File Offset: 0x00037EB8
			public unsafe virtual Vector2 radius
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00039CF8 File Offset: 0x00037EF8
			// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00039D34 File Offset: 0x00037F34
			public unsafe virtual Vector2 radiusVariance
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00039D74 File Offset: 0x00037F74
			// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00039DB0 File Offset: 0x00037FB0
			public unsafe virtual EventModifiers modifiers
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00039DF0 File Offset: 0x00037FF0
			public unsafe virtual bool shiftKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00039E2C File Offset: 0x0003802C
			public unsafe virtual bool ctrlKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00039E68 File Offset: 0x00038068
			public unsafe virtual bool commandKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00039EA4 File Offset: 0x000380A4
			public unsafe virtual bool altKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00039EE0 File Offset: 0x000380E0
			public unsafe virtual bool actionKey
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094240, XrefRangeEnd = 1094247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D75 RID: 3445 RVA: 0x00039F1C File Offset: 0x0003811C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1094306, RefRangeEnd = 1094307, XrefRangeStart = 1094247, XrefRangeEnd = 1094306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Read(PanelEventHandler self, PointerEventData eventData, PanelEventHandler.PointerEventType eventType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x00039F80 File Offset: 0x00038180
			[CallerCount(0)]
			public unsafe void SetPosition(Vector3 positionOverride, Vector3 deltaOverride)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref positionOverride;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaOverride;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00039FCC File Offset: 0x000381CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x0003A008 File Offset: 0x00038208
			[CallerCount(0)]
			public unsafe static bool Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0(int i, int start, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x000070EF File Offset: 0x000052EF
			public PointerEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0003A064 File Offset: 0x00038264
			// (set) Token: 0x06000D7B RID: 3451 RVA: 0x000070F8 File Offset: 0x000052F8
			public unsafe int _pointerId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0003A08C File Offset: 0x0003828C
			// (set) Token: 0x06000D7D RID: 3453 RVA: 0x00007113 File Offset: 0x00005313
			public unsafe string _pointerType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0003A0B4 File Offset: 0x000382B4
			// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00007132 File Offset: 0x00005332
			public unsafe bool _isPrimary_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField)) = value;
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0003A0DC File Offset: 0x000382DC
			// (set) Token: 0x06000D81 RID: 3457 RVA: 0x0000714D File Offset: 0x0000534D
			public unsafe int _button_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField)) = value;
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000D82 RID: 3458 RVA: 0x0003A104 File Offset: 0x00038304
			// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00007168 File Offset: 0x00005368
			public unsafe int _pressedButtons_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0003A12C File Offset: 0x0003832C
			// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00007183 File Offset: 0x00005383
			public unsafe Vector3 _position_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField)) = value;
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000D86 RID: 3462 RVA: 0x0003A154 File Offset: 0x00038354
			// (set) Token: 0x06000D87 RID: 3463 RVA: 0x0000719E File Offset: 0x0000539E
			public unsafe Vector3 _localPosition_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField)) = value;
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0003A17C File Offset: 0x0003837C
			// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000071B9 File Offset: 0x000053B9
			public unsafe Vector3 _deltaPosition_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField)) = value;
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0003A1A4 File Offset: 0x000383A4
			// (set) Token: 0x06000D8B RID: 3467 RVA: 0x000071D4 File Offset: 0x000053D4
			public unsafe float _deltaTime_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField)) = value;
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000D8C RID: 3468 RVA: 0x0003A1CC File Offset: 0x000383CC
			// (set) Token: 0x06000D8D RID: 3469 RVA: 0x000071EF File Offset: 0x000053EF
			public unsafe int _clickCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0003A1F4 File Offset: 0x000383F4
			// (set) Token: 0x06000D8F RID: 3471 RVA: 0x0000720A File Offset: 0x0000540A
			public unsafe float _pressure_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000D90 RID: 3472 RVA: 0x0003A21C File Offset: 0x0003841C
			// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00007225 File Offset: 0x00005425
			public unsafe float _tangentialPressure_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000D92 RID: 3474 RVA: 0x0003A244 File Offset: 0x00038444
			// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00007240 File Offset: 0x00005440
			public unsafe float _altitudeAngle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0003A26C File Offset: 0x0003846C
			// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0000725B File Offset: 0x0000545B
			public unsafe float _azimuthAngle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000D96 RID: 3478 RVA: 0x0003A294 File Offset: 0x00038494
			// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00007276 File Offset: 0x00005476
			public unsafe float _twist_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0003A2BC File Offset: 0x000384BC
			// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00007291 File Offset: 0x00005491
			public unsafe Vector2 _tilt_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tilt_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tilt_k__BackingField)) = value;
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0003A2E4 File Offset: 0x000384E4
			// (set) Token: 0x06000D9B RID: 3483 RVA: 0x000072AC File Offset: 0x000054AC
			public unsafe PenStatus _penStatus_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__penStatus_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__penStatus_k__BackingField)) = value;
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0003A30C File Offset: 0x0003850C
			// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000072C7 File Offset: 0x000054C7
			public unsafe Vector2 _radius_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField)) = value;
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0003A334 File Offset: 0x00038534
			// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000072E2 File Offset: 0x000054E2
			public unsafe Vector2 _radiusVariance_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0003A35C File Offset: 0x0003855C
			// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x000072FD File Offset: 0x000054FD
			public unsafe EventModifiers _modifiers_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
				}
			}

			// Token: 0x04000A4D RID: 2637
			private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

			// Token: 0x04000A4E RID: 2638
			private static readonly IntPtr NativeFieldInfoPtr__pointerType_k__BackingField;

			// Token: 0x04000A4F RID: 2639
			private static readonly IntPtr NativeFieldInfoPtr__isPrimary_k__BackingField;

			// Token: 0x04000A50 RID: 2640
			private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

			// Token: 0x04000A51 RID: 2641
			private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

			// Token: 0x04000A52 RID: 2642
			private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

			// Token: 0x04000A53 RID: 2643
			private static readonly IntPtr NativeFieldInfoPtr__localPosition_k__BackingField;

			// Token: 0x04000A54 RID: 2644
			private static readonly IntPtr NativeFieldInfoPtr__deltaPosition_k__BackingField;

			// Token: 0x04000A55 RID: 2645
			private static readonly IntPtr NativeFieldInfoPtr__deltaTime_k__BackingField;

			// Token: 0x04000A56 RID: 2646
			private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

			// Token: 0x04000A57 RID: 2647
			private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

			// Token: 0x04000A58 RID: 2648
			private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

			// Token: 0x04000A59 RID: 2649
			private static readonly IntPtr NativeFieldInfoPtr__altitudeAngle_k__BackingField;

			// Token: 0x04000A5A RID: 2650
			private static readonly IntPtr NativeFieldInfoPtr__azimuthAngle_k__BackingField;

			// Token: 0x04000A5B RID: 2651
			private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

			// Token: 0x04000A5C RID: 2652
			private static readonly IntPtr NativeFieldInfoPtr__tilt_k__BackingField;

			// Token: 0x04000A5D RID: 2653
			private static readonly IntPtr NativeFieldInfoPtr__penStatus_k__BackingField;

			// Token: 0x04000A5E RID: 2654
			private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

			// Token: 0x04000A5F RID: 2655
			private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

			// Token: 0x04000A60 RID: 2656
			private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

			// Token: 0x04000A61 RID: 2657
			private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A62 RID: 2658
			private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0;

			// Token: 0x04000A63 RID: 2659
			private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04000A64 RID: 2660
			private static readonly IntPtr NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0;

			// Token: 0x04000A65 RID: 2661
			private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A66 RID: 2662
			private static readonly IntPtr NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0;

			// Token: 0x04000A67 RID: 2663
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A68 RID: 2664
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0;

			// Token: 0x04000A69 RID: 2665
			private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A6A RID: 2666
			private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0;

			// Token: 0x04000A6B RID: 2667
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A6C RID: 2668
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0;

			// Token: 0x04000A6D RID: 2669
			private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A6E RID: 2670
			private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0;

			// Token: 0x04000A6F RID: 2671
			private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A70 RID: 2672
			private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0;

			// Token: 0x04000A71 RID: 2673
			private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A72 RID: 2674
			private static readonly IntPtr NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0;

			// Token: 0x04000A73 RID: 2675
			private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A74 RID: 2676
			private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0;

			// Token: 0x04000A75 RID: 2677
			private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A76 RID: 2678
			private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0;

			// Token: 0x04000A77 RID: 2679
			private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A78 RID: 2680
			private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0;

			// Token: 0x04000A79 RID: 2681
			private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A7A RID: 2682
			private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0;

			// Token: 0x04000A7B RID: 2683
			private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A7C RID: 2684
			private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0;

			// Token: 0x04000A7D RID: 2685
			private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A7E RID: 2686
			private static readonly IntPtr NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0;

			// Token: 0x04000A7F RID: 2687
			private static readonly IntPtr NativeMethodInfoPtr_get_tilt_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04000A80 RID: 2688
			private static readonly IntPtr NativeMethodInfoPtr_set_tilt_Private_set_Void_Vector2_0;

			// Token: 0x04000A81 RID: 2689
			private static readonly IntPtr NativeMethodInfoPtr_get_penStatus_Public_Virtual_Final_New_get_PenStatus_0;

			// Token: 0x04000A82 RID: 2690
			private static readonly IntPtr NativeMethodInfoPtr_set_penStatus_Private_set_Void_PenStatus_0;

			// Token: 0x04000A83 RID: 2691
			private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04000A84 RID: 2692
			private static readonly IntPtr NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0;

			// Token: 0x04000A85 RID: 2693
			private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04000A86 RID: 2694
			private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0;

			// Token: 0x04000A87 RID: 2695
			private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

			// Token: 0x04000A88 RID: 2696
			private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0;

			// Token: 0x04000A89 RID: 2697
			private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A8A RID: 2698
			private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A8B RID: 2699
			private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A8C RID: 2700
			private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A8D RID: 2701
			private static readonly IntPtr NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A8E RID: 2702
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_PointerEventType_0;

			// Token: 0x04000A8F RID: 2703
			private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0;

			// Token: 0x04000A90 RID: 2704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A91 RID: 2705
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0;
		}
	}
}
