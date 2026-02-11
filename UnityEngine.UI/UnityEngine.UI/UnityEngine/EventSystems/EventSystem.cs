using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000065 RID: 101
	public class EventSystem : UIBehaviour
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x0002D204 File Offset: 0x0002B404
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystem()
		{
			Il2CppClassPointerStore<EventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "EventSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem>.NativeClassPtr);
			EventSystem.NativeFieldInfoPtr_m_SystemInputModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SystemInputModules");
			EventSystem.NativeFieldInfoPtr_m_CurrentInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentInputModule");
			EventSystem.NativeFieldInfoPtr_m_EventSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_EventSystems");
			EventSystem.NativeFieldInfoPtr_m_FirstSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_FirstSelected");
			EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_sendNavigationEvents");
			EventSystem.NativeFieldInfoPtr_m_DragThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DragThreshold");
			EventSystem.NativeFieldInfoPtr_m_CurrentSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentSelected");
			EventSystem.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_HasFocus");
			EventSystem.NativeFieldInfoPtr_m_SelectionGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SelectionGuard");
			EventSystem.NativeFieldInfoPtr_m_DummyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DummyData");
			EventSystem.NativeFieldInfoPtr_s_RaycastComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "s_RaycastComparer");
			EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "s_UIToolkitOverride");
			EventSystem.NativeFieldInfoPtr_m_Started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_Started");
			EventSystem.NativeFieldInfoPtr_m_IsTrackingUIToolkitPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_IsTrackingUIToolkitPanels");
			EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664911);
			EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664912);
			EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664913);
			EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664914);
			EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664915);
			EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664916);
			EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664917);
			EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664918);
			EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664919);
			EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664920);
			EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664921);
			EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664922);
			EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664923);
			EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664924);
			EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664925);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664926);
			EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664927);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664928);
			EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664929);
			EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664930);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664931);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664932);
			EventSystem.NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664933);
			EventSystem.NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664934);
			EventSystem.NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664935);
			EventSystem.NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664936);
			EventSystem.NativeMethodInfoPtr_StartTrackingUIToolkitPanels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664937);
			EventSystem.NativeMethodInfoPtr_StopTrackingUIToolkitPanels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664938);
			EventSystem.NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664939);
			EventSystem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664940);
			EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664941);
			EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664942);
			EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664943);
			EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664944);
			EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664945);
			EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664946);
			EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664947);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0002D630 File Offset: 0x0002B830
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0002D664 File Offset: 0x0002B864
		public unsafe static EventSystem current
		{
			[CallerCount(137)]
			[CachedScanResults(RefRangeStart = 1095010, RefRangeEnd = 1095147, XrefRangeStart = 1095000, XrefRangeEnd = 1095010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095147, XrefRangeEnd = 1095164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0002D69C File Offset: 0x0002B89C
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0002D6D8 File Offset: 0x0002B8D8
		public unsafe bool sendNavigationEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002D718 File Offset: 0x0002B918
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0002D754 File Offset: 0x0002B954
		public unsafe int pixelDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0002D794 File Offset: 0x0002B994
		public unsafe BaseInputModule currentInputModule
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0002D7D4 File Offset: 0x0002B9D4
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002D814 File Offset: 0x0002BA14
		public unsafe GameObject firstSelectedGameObject
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002D858 File Offset: 0x0002BA58
		public unsafe GameObject currentSelectedGameObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0002D898 File Offset: 0x0002BA98
		public unsafe GameObject lastSelectedGameObject
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002D914 File Offset: 0x0002BB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095164, XrefRangeEnd = 1095172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0002D950 File Offset: 0x0002BB50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1095188, RefRangeEnd = 1095190, XrefRangeStart = 1095172, XrefRangeEnd = 1095188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0002D984 File Offset: 0x0002BB84
		public unsafe bool alreadySelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1095215, RefRangeEnd = 1095227, XrefRangeStart = 1095190, XrefRangeEnd = 1095215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0002DA14 File Offset: 0x0002BC14
		public unsafe BaseEventData baseEventDataCache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095227, XrefRangeEnd = 1095233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002DA54 File Offset: 0x0002BC54
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1095240, RefRangeEnd = 1095264, XrefRangeStart = 1095233, XrefRangeEnd = 1095240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095264, XrefRangeEnd = 1095303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1095328, RefRangeEnd = 1095335, XrefRangeStart = 1095303, XrefRangeEnd = 1095328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastResults);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002DB4C File Offset: 0x0002BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095335, XrefRangeEnd = 1095339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002DB88 File Offset: 0x0002BD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095339, XrefRangeEnd = 1095343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
		public unsafe bool isUIToolkitActiveEventSystem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1095351, RefRangeEnd = 1095353, XrefRangeStart = 1095343, XrefRangeEnd = 1095351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002DC10 File Offset: 0x0002BE10
		public unsafe bool sendUIToolkitEvents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095353, XrefRangeEnd = 1095357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0002DC4C File Offset: 0x0002BE4C
		public unsafe bool createUIToolkitPanelGameObjectsOnStart
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095357, XrefRangeEnd = 1095361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002DC88 File Offset: 0x0002BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095361, XrefRangeEnd = 1095388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeEventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendEvents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createPanelGameObjectsOnStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002DCDC File Offset: 0x0002BEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1095424, RefRangeEnd = 1095426, XrefRangeStart = 1095388, XrefRangeEnd = 1095424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrackingUIToolkitPanels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_StartTrackingUIToolkitPanels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002DD10 File Offset: 0x0002BF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095426, XrefRangeEnd = 1095436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrackingUIToolkitPanels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_StopTrackingUIToolkitPanels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002DD44 File Offset: 0x0002BF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1095477, RefRangeEnd = 1095478, XrefRangeStart = 1095436, XrefRangeEnd = 1095477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002DD88 File Offset: 0x0002BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095478, XrefRangeEnd = 1095479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002DDC4 File Offset: 0x0002BFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095479, XrefRangeEnd = 1095498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002DE00 File Offset: 0x0002C000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095498, XrefRangeEnd = 1095525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002DE3C File Offset: 0x0002C03C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1095535, RefRangeEnd = 1095537, XrefRangeStart = 1095525, XrefRangeEnd = 1095535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TickModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002DE70 File Offset: 0x0002C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095537, XrefRangeEnd = 1095538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002DEBC File Offset: 0x0002C0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095538, XrefRangeEnd = 1095564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002DEF8 File Offset: 0x0002C0F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1095575, RefRangeEnd = 1095576, XrefRangeStart = 1095564, XrefRangeEnd = 1095575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEventModule(BaseInputModule module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002DF3C File Offset: 0x0002C13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095576, XrefRangeEnd = 1095596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00005925 File Offset: 0x00003B25
		public EventSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002DF80 File Offset: 0x0002C180
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0000592E File Offset: 0x00003B2E
		public unsafe List<BaseInputModule> m_SystemInputModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInputModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x0000594D File Offset: 0x00003B4D
		public unsafe BaseInputModule m_CurrentInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe static List<EventSystem> m_EventSystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventSystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0002E008 File Offset: 0x0002C208
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x0000597E File Offset: 0x00003B7E
		public unsafe GameObject m_FirstSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0002E038 File Offset: 0x0002C238
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x0000599D File Offset: 0x00003B9D
		public unsafe bool m_sendNavigationEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002E060 File Offset: 0x0002C260
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x000059B8 File Offset: 0x00003BB8
		public unsafe int m_DragThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0002E088 File Offset: 0x0002C288
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x000059D3 File Offset: 0x00003BD3
		public unsafe GameObject m_CurrentSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x000059F2 File Offset: 0x00003BF2
		public unsafe bool m_HasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00005A0D File Offset: 0x00003C0D
		public unsafe bool m_SelectionGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0002E108 File Offset: 0x0002C308
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00005A28 File Offset: 0x00003C28
		public unsafe BaseEventData m_DummyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002E138 File Offset: 0x0002C338
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00005A47 File Offset: 0x00003C47
		public unsafe static Comparison<RaycastResult> s_RaycastComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0002E160 File Offset: 0x0002C360
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00005A59 File Offset: 0x00003C59
		public unsafe static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride, intPtr);
				return new EventSystem.UIToolkitOverrideConfig(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0002E19C File Offset: 0x0002C39C
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00005A70 File Offset: 0x00003C70
		public unsafe bool m_Started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_Started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_Started)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00005A8B File Offset: 0x00003C8B
		public unsafe bool m_IsTrackingUIToolkitPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_IsTrackingUIToolkitPanels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_IsTrackingUIToolkitPanels)) = value;
			}
		}

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_m_SystemInputModules;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentInputModule;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystems;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstSelected;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeFieldInfoPtr_m_sendNavigationEvents;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeFieldInfoPtr_m_DragThreshold;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelected;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFocus;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionGuard;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_m_DummyData;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_s_RaycastComparer;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_s_UIToolkitOverride;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_m_Started;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTrackingUIToolkitPanels;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModules_Public_Void_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_StartTrackingUIToolkitPanels_Private_Void_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_StopTrackingUIToolkitPanels_Private_Void_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_TickModules_Private_Void_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000C9 RID: 201
		public sealed class UIToolkitOverrideConfig : ValueType
		{
			// Token: 0x06000DA2 RID: 3490 RVA: 0x0003A384 File Offset: 0x00038584
			// Note: this type is marked as 'beforefieldinit'.
			static UIToolkitOverrideConfig()
			{
				Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "UIToolkitOverrideConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr);
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "activeEventSystem");
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "sendEvents");
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "createPanelGameObjectsOnStart");
			}

			// Token: 0x06000DA3 RID: 3491 RVA: 0x00007318 File Offset: 0x00005518
			public UIToolkitOverrideConfig(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x00007321 File Offset: 0x00005521
			public UIToolkitOverrideConfig()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr))
			{
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0003A3EC File Offset: 0x000385EC
			// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00007333 File Offset: 0x00005533
			public unsafe EventSystem activeEventSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0003A41C File Offset: 0x0003861C
			// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00007352 File Offset: 0x00005552
			public unsafe bool sendEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents)) = value;
				}
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0003A444 File Offset: 0x00038644
			// (set) Token: 0x06000DAA RID: 3498 RVA: 0x0000736D File Offset: 0x0000556D
			public unsafe bool createPanelGameObjectsOnStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart)) = value;
				}
			}

			// Token: 0x04000A9B RID: 2715
			private static readonly IntPtr NativeFieldInfoPtr_activeEventSystem;

			// Token: 0x04000A9C RID: 2716
			private static readonly IntPtr NativeFieldInfoPtr_sendEvents;

			// Token: 0x04000A9D RID: 2717
			private static readonly IntPtr NativeFieldInfoPtr_createPanelGameObjectsOnStart;
		}

		// Token: 0x020000CA RID: 202
		[ObfuscatedName("UnityEngine.EventSystems.EventSystem+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Object
		{
			// Token: 0x06000DAB RID: 3499 RVA: 0x0003A46C File Offset: 0x0003866C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr);
				EventSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr, "go");
				EventSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr, 100664949);
				EventSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr, 100664950);
			}

			// Token: 0x06000DAC RID: 3500 RVA: 0x0003A4D4 File Offset: 0x000386D4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DAD RID: 3501 RVA: 0x0003A510 File Offset: 0x00038710
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094996, XrefRangeEnd = 1095000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUIToolkitPanelGameObject_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.__c__DisplayClass56_0.NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x00007388 File Offset: 0x00005588
			public __c__DisplayClass56_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0003A544 File Offset: 0x00038744
			// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00007391 File Offset: 0x00005591
			public unsafe GameObject go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.__c__DisplayClass56_0.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A9E RID: 2718
			private static readonly IntPtr NativeFieldInfoPtr_go;

			// Token: 0x04000A9F RID: 2719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AA0 RID: 2720
			private static readonly IntPtr NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0;
		}
	}
}
