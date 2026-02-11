using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E5 RID: 485
	public class UIElementsUtility : Object
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x000AAAF4 File Offset: 0x000A8CF4
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsUtility()
		{
			Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr);
			UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_ContainerStack");
			UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_UIElementsCache");
			UIElementsUtility.NativeFieldInfoPtr_s_EventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventInstance");
			UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "editorPlayModeTintColor");
			UIElementsUtility.NativeFieldInfoPtr_singleLineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "singleLineHeight");
			UIElementsUtility.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_Instance");
			UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_PanelsIterationList");
			UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_RepaintProfilerMarkerName");
			UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventProfilerMarkerName");
			UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_RepaintProfilerMarker");
			UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_EventProfilerMarker");
			UIElementsUtility.NativeFieldInfoPtr_s_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, "s_Modifiers");
			UIElementsUtility.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669118);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669119);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669120);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669121);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669122);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669123);
			UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669124);
			UIElementsUtility.NativeMethodInfoPtr_RegisterCachedPanel_Public_Static_Void_Int32_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669125);
			UIElementsUtility.NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669126);
			UIElementsUtility.NativeMethodInfoPtr_TryGetPanel_Public_Static_Boolean_Int32_byref_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669127);
			UIElementsUtility.NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669128);
			UIElementsUtility.NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669129);
			UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669130);
			UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669131);
			UIElementsUtility.NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669132);
			UIElementsUtility.NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669133);
			UIElementsUtility.NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669134);
			UIElementsUtility.NativeMethodInfoPtr_PixelsPerUnitScaleForElement_Internal_Static_Single_VisualElement_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669135);
			UIElementsUtility.NativeMethodInfoPtr_ParseMenuName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr, 100669136);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000AAD90 File Offset: 0x000A8F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341931, XrefRangeEnd = 341943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIElementsUtility()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000AADCC File Offset: 0x000A8FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341943, XrefRangeEnd = 341949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000AAE08 File Offset: 0x000A9008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341949, XrefRangeEnd = 341955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_TakeCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000AAE44 File Offset: 0x000A9044
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000AAE80 File Offset: 0x000A9080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341955, XrefRangeEnd = 341968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventHandled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000AAEE8 File Offset: 0x000A90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341968, XrefRangeEnd = 341980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_CleanupRoots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000AAF24 File Offset: 0x000A9124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341980, XrefRangeEnd = 341995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000AAF74 File Offset: 0x000A9174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341995, XrefRangeEnd = 342003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCachedPanel(int instanceID, Panel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_RegisterCachedPanel_Public_Static_Void_Int32_Panel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000AAFB8 File Offset: 0x000A91B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342011, RefRangeEnd = 342013, XrefRangeStart = 342003, XrefRangeEnd = 342011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCachedPanel(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000AAFEC File Offset: 0x000A91EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342013, XrefRangeEnd = 342021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetPanel(int instanceID, out Panel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_TryGetPanel_Public_Static_Boolean_Int32_byref_Panel_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			panel = ((intPtr4 == 0) ? null : new Panel(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000AB04C File Offset: 0x000A924C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342060, RefRangeEnd = 342061, XrefRangeStart = 342021, XrefRangeEnd = 342060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000AB0A8 File Offset: 0x000A92A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342100, RefRangeEnd = 342101, XrefRangeStart = 342061, XrefRangeEnd = 342100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContainerGUI(Event evt, Rect layoutSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layoutSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000AB0EC File Offset: 0x000A92EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342101, XrefRangeEnd = 342107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase CreateEvent(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000AB130 File Offset: 0x000A9330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342151, RefRangeEnd = 342154, XrefRangeStart = 342107, XrefRangeEnd = 342151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase CreateEvent(Event systemEvent, EventType eventType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000AB184 File Offset: 0x000A9384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342207, RefRangeEnd = 342208, XrefRangeStart = 342154, XrefRangeEnd = 342207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoDispatch(BaseVisualElementPanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000AB1C8 File Offset: 0x000A93C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342228, RefRangeEnd = 342230, XrefRangeStart = 342208, XrefRangeEnd = 342228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllPanels(List<Panel> panels, ContextType contextType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panels);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000AB20C File Offset: 0x000A940C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342237, RefRangeEnd = 342239, XrefRangeStart = 342230, XrefRangeEnd = 342237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Dictionary<int, Panel>.Enumerator(intPtr);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x000AB238 File Offset: 0x000A9438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 342244, RefRangeEnd = 342247, XrefRangeStart = 342239, XrefRangeEnd = 342244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_PixelsPerUnitScaleForElement_Internal_Static_Single_VisualElement_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000AB28C File Offset: 0x000A948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342247, XrefRangeEnd = 342261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseMenuName(string menuName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsUtility.NativeMethodInfoPtr_ParseMenuName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0000F906 File Offset: 0x0000DB06
		public UIElementsUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600266D RID: 9837 RVA: 0x000AB2C8 File Offset: 0x000A94C8
		// (set) Token: 0x0600266E RID: 9838 RVA: 0x0000F90F File Offset: 0x0000DB0F
		public unsafe static Stack<IMGUIContainer> s_ContainerStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<IMGUIContainer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_ContainerStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600266F RID: 9839 RVA: 0x000AB2F0 File Offset: 0x000A94F0
		// (set) Token: 0x06002670 RID: 9840 RVA: 0x0000F921 File Offset: 0x0000DB21
		public unsafe static Dictionary<int, Panel> s_UIElementsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_UIElementsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002671 RID: 9841 RVA: 0x000AB318 File Offset: 0x000A9518
		// (set) Token: 0x06002672 RID: 9842 RVA: 0x0000F933 File Offset: 0x0000DB33
		public unsafe static Event s_EventInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x000AB340 File Offset: 0x000A9540
		// (set) Token: 0x06002674 RID: 9844 RVA: 0x0000F945 File Offset: 0x0000DB45
		public unsafe static Color editorPlayModeTintColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_editorPlayModeTintColor, (void*)(&value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x000AB35C File Offset: 0x000A955C
		// (set) Token: 0x06002676 RID: 9846 RVA: 0x0000F953 File Offset: 0x0000DB53
		public unsafe static float singleLineHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_singleLineHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_singleLineHeight, (void*)(&value));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x000AB378 File Offset: 0x000A9578
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x0000F961 File Offset: 0x0000DB61
		public unsafe static UIElementsUtility s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementsUtility>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x000AB3A0 File Offset: 0x000A95A0
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0000F973 File Offset: 0x0000DB73
		public unsafe static List<Panel> s_PanelsIterationList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_PanelsIterationList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x000AB3C8 File Offset: 0x000A95C8
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x0000F985 File Offset: 0x0000DB85
		public unsafe static string s_RepaintProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x000AB3E8 File Offset: 0x000A95E8
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x0000F997 File Offset: 0x0000DB97
		public unsafe static string s_EventProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000AB408 File Offset: 0x000A9608
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x0000F9A9 File Offset: 0x0000DBA9
		public unsafe static ProfilerMarker s_RepaintProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x000AB424 File Offset: 0x000A9624
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x0000F9B7 File Offset: 0x0000DBB7
		public unsafe static ProfilerMarker s_EventProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_EventProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x000AB440 File Offset: 0x000A9640
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x0000F9C5 File Offset: 0x0000DBC5
		public unsafe static Il2CppStructArray<char> s_Modifiers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsUtility.NativeFieldInfoPtr_s_Modifiers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsUtility.NativeFieldInfoPtr_s_Modifiers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000AB468 File Offset: 0x000A9668
		public static IMGUIContainer GetCurrentIMGUIContainer()
		{
			bool flag = UIElementsUtility.s_ContainerStack.Count > 0;
			IMGUIContainer imguicontainer;
			if (flag)
			{
				imguicontainer = UIElementsUtility.s_ContainerStack.Peek();
			}
			else
			{
				imguicontainer = null;
			}
			return imguicontainer;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000AB49C File Offset: 0x000A969C
		public void UnityEngine.UIElements.IUIElementsUtility.UpdateSchedulers()
		{
			UIElementsUtility.s_PanelsIterationList.Clear();
			UIElementsUtility.GetAllPanels(UIElementsUtility.s_PanelsIterationList, ContextType.Editor);
			List<Panel>.Enumerator enumerator = UIElementsUtility.s_PanelsIterationList.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					Panel panel = enumerator.Current;
					panel.timerEventScheduler.UpdateScheduledEvents();
					panel.ValidateFocus();
					panel.UpdateAnimations();
					panel.UpdateBindings();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000AB524 File Offset: 0x000A9724
		public void UnityEngine.UIElements.IUIElementsUtility.RequestRepaintForPanels(Action<ScriptableObject> repaintCallback)
		{
			Dictionary<int, Panel>.Enumerator panelsIterator = UIElementsUtility.GetPanelsIterator();
			while (panelsIterator.MoveNext())
			{
				KeyValuePair<int, Panel> keyValuePair = panelsIterator.Current;
				Panel value = keyValuePair.Value;
				bool flag = value.contextType != ContextType.Editor;
				if (!flag)
				{
					bool isDirty = value.isDirty;
					if (isDirty)
					{
						repaintCallback.Invoke(value.ownerObject);
					}
				}
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000AB588 File Offset: 0x000A9788
		public static Panel FindOrCreateEditorPanel(ScriptableObject ownerObject)
		{
			Panel panel;
			bool flag = !UIElementsUtility.s_UIElementsCache.TryGetValue(ownerObject.GetInstanceID(), out panel);
			if (flag)
			{
				panel = Panel.CreateEditorPanel(ownerObject);
				UIElementsUtility.RegisterCachedPanel(ownerObject.GetInstanceID(), panel);
			}
			else
			{
				Debug.Assert(ContextType.Editor == panel.contextType, "Panel is not an editor panel.");
			}
			return panel;
		}

		// Token: 0x04001B9D RID: 7069
		private static readonly IntPtr NativeFieldInfoPtr_s_ContainerStack;

		// Token: 0x04001B9E RID: 7070
		private static readonly IntPtr NativeFieldInfoPtr_s_UIElementsCache;

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr_s_EventInstance;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeFieldInfoPtr_editorPlayModeTintColor;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeFieldInfoPtr_singleLineHeight;

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelsIterationList;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarkerName;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_s_EventProfilerMarkerName;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarker;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_s_EventProfilerMarker;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_s_Modifiers;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_MakeCurrentIMGUIContainerDirty_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_TakeCapture_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ReleaseCapture_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_ProcessEvent_Private_Virtual_Final_New_Boolean_Int32_IntPtr_byref_Boolean_0;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_CleanupRoots_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IUIElementsUtility_EndContainerGUIFromException_Private_Virtual_Final_New_Boolean_Exception_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCachedPanel_Public_Static_Void_Int32_Panel_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCachedPanel_Public_Static_Void_Int32_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_TryGetPanel_Public_Static_Boolean_Int32_byref_Panel_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainerGUI_Internal_Static_Void_LayoutCache_Event_IMGUIContainer_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUI_Internal_Static_Void_Event_Rect_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Internal_Static_EventBase_Event_EventType_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr_DoDispatch_Private_Static_Boolean_BaseVisualElementPanel_0;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPanels_Internal_Static_Void_List_1_Panel_ContextType_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_GetPanelsIterator_Internal_Static_Enumerator_Int32_Panel_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_PixelsPerUnitScaleForElement_Internal_Static_Single_VisualElement_Sprite_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_ParseMenuName_Internal_Static_String_String_0;

		// Token: 0x04001BBC RID: 7100
		public const string hiddenClassName = "unity-hidden";
	}
}
