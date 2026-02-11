using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E2 RID: 482
	public static class UIElementsRuntimeUtility : Object
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x000A99E8 File Offset: 0x000A7BE8
		// Note: this type is marked as 'beforefieldinit'.
		static UIElementsRuntimeUtility()
		{
			Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIElementsRuntimeUtility");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "onCreatePanel");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RegisteredPlayerloopCallback");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_SortedRuntimePanels");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_PanelOrderingDirty");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_ResolvedSortingIndexMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_ResolvedSortingIndexMax");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RepaintProfilerMarkerName");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_RepaintProfilerMarker");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "currentOverlayIndex");
			UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "<activeEventSystem>k__BackingField");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_DefaultEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_DefaultEventSystem");
			UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PotentiallyEmptyPanelSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "s_PotentiallyEmptyPanelSettings");
			UIElementsRuntimeUtility.NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669058);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669059);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_CreateEvent_Public_Static_EventBase_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669061);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_FindOrCreateRuntimePanel_Public_Static_BaseRuntimePanel_ScriptableObject_CreateRuntimePanelDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669062);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_DisposeRuntimePanel_Public_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669063);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterCachedPanelInternal_Private_Static_Void_Int32_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669064);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RemoveCachedPanelInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669065);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669066);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669067);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_BeginRenderOverlays_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669068);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RenderOverlaysBeforePriority_Internal_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669069);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_EndRenderOverlays_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669070);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669071);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669072);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_get_useDefaultEventSystem_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669073);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669074);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669075);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_get_defaultEventSystem_Internal_Static_get_DefaultEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669076);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669077);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Static_Void_PanelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669078);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RemoveUnusedPanels_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669079);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669080);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669081);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_SetPanelOrderingDirty_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669082);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669083);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_SortPanels_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669084);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669085);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669086);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669087);
			UIElementsRuntimeUtility.NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Internal_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, 100669088);
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000A9D44 File Offset: 0x000A7F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341205, RefRangeEnd = 341206, XrefRangeStart = 341192, XrefRangeEnd = 341205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_onCreatePanel(Action<BaseRuntimePanel> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000A9D7C File Offset: 0x000A7F7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341219, RefRangeEnd = 341221, XrefRangeStart = 341206, XrefRangeEnd = 341219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_onCreatePanel(Action<BaseRuntimePanel> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x000A9DB4 File Offset: 0x000A7FB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341227, RefRangeEnd = 341231, XrefRangeStart = 341221, XrefRangeEnd = 341227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventBase CreateEvent(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_CreateEvent_Public_Static_EventBase_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr3) : null;
			}
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x000A9DF8 File Offset: 0x000A7FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341255, RefRangeEnd = 341257, XrefRangeStart = 341231, XrefRangeEnd = 341255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, UIElementsRuntimeUtility.CreateRuntimePanelDelegate createDelegate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createDelegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_FindOrCreateRuntimePanel_Public_Static_BaseRuntimePanel_ScriptableObject_CreateRuntimePanelDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x000A9E50 File Offset: 0x000A8050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341274, RefRangeEnd = 341276, XrefRangeStart = 341257, XrefRangeEnd = 341274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeRuntimePanel(ScriptableObject ownerObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_DisposeRuntimePanel_Public_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x000A9E88 File Offset: 0x000A8088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341309, RefRangeEnd = 341310, XrefRangeStart = 341276, XrefRangeEnd = 341309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterCachedPanelInternal_Private_Static_Void_Int32_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x000A9ECC File Offset: 0x000A80CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341339, RefRangeEnd = 341341, XrefRangeStart = 341310, XrefRangeEnd = 341339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCachedPanelInternal(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RemoveCachedPanelInternal_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x000A9F00 File Offset: 0x000A8100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341341, XrefRangeEnd = 341368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOffscreenPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x000A9F28 File Offset: 0x000A8128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341384, RefRangeEnd = 341386, XrefRangeStart = 341368, XrefRangeEnd = 341384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepaintOverlayPanel(BaseRuntimePanel panel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000A9F60 File Offset: 0x000A8160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341386, XrefRangeEnd = 341390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginRenderOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_BeginRenderOverlays_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x000A9F94 File Offset: 0x000A8194
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341415, RefRangeEnd = 341417, XrefRangeStart = 341390, XrefRangeEnd = 341415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RenderOverlaysBeforePriority_Internal_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000A9FD4 File Offset: 0x000A81D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341417, XrefRangeEnd = 341422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndRenderOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_EndRenderOverlays_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000AA008 File Offset: 0x000A8208
		// (set) Token: 0x06002616 RID: 9750 RVA: 0x000AA03C File Offset: 0x000A823C
		public unsafe static Object activeEventSystem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341422, XrefRangeEnd = 341426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341426, XrefRangeEnd = 341432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000AA074 File Offset: 0x000A8274
		public unsafe static bool useDefaultEventSystem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341432, XrefRangeEnd = 341443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_get_useDefaultEventSystem_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x000AA0A4 File Offset: 0x000A82A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341482, RefRangeEnd = 341484, XrefRangeStart = 341443, XrefRangeEnd = 341482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterEventSystem(Object eventSystem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x000AA0DC File Offset: 0x000A82DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341503, RefRangeEnd = 341505, XrefRangeStart = 341484, XrefRangeEnd = 341503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterEventSystem(Object eventSystem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000AA114 File Offset: 0x000A8314
		public unsafe static DefaultEventSystem defaultEventSystem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 341518, RefRangeEnd = 341520, XrefRangeStart = 341505, XrefRangeEnd = 341518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_get_defaultEventSystem_Internal_Static_get_DefaultEventSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000AA148 File Offset: 0x000A8348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341520, XrefRangeEnd = 341578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateRuntimePanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000AA170 File Offset: 0x000A8370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341591, RefRangeEnd = 341593, XrefRangeStart = 341578, XrefRangeEnd = 341591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkPotentiallyEmpty(PanelSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Static_Void_PanelSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000AA1A8 File Offset: 0x000A83A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341619, RefRangeEnd = 341620, XrefRangeStart = 341593, XrefRangeEnd = 341619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveUnusedPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RemoveUnusedPanels_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000AA1D0 File Offset: 0x000A83D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341620, XrefRangeEnd = 341631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterPlayerloopCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000AA1F8 File Offset: 0x000A83F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341631, XrefRangeEnd = 341636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterPlayerloopCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000AA220 File Offset: 0x000A8420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341640, RefRangeEnd = 341641, XrefRangeStart = 341636, XrefRangeEnd = 341640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPanelOrderingDirty()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_SetPanelOrderingDirty_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000AA248 File Offset: 0x000A8448
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 341650, RefRangeEnd = 341656, XrefRangeStart = 341641, XrefRangeEnd = 341650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Panel> GetSortedPlayerPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr3) : null;
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000AA27C File Offset: 0x000A847C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341702, RefRangeEnd = 341703, XrefRangeStart = 341656, XrefRangeEnd = 341702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SortPanels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_SortPanels_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000AA2A4 File Offset: 0x000A84A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341725, RefRangeEnd = 341729, XrefRangeStart = 341703, XrefRangeEnd = 341725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out Nullable<int> targetDisplay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			targetDisplay = ((intPtr4 == 0) ? null : new Nullable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x000AA304 File Offset: 0x000A8504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341739, RefRangeEnd = 341740, XrefRangeStart = 341729, XrefRangeEnd = 341739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out Nullable<int> targetDisplay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			targetDisplay = ((intPtr4 == 0) ? null : new Nullable<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000AA364 File Offset: 0x000A8564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341740, XrefRangeEnd = 341748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetDisplay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000AA3B0 File Offset: 0x000A85B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341748, RefRangeEnd = 341749, XrefRangeStart = 341748, XrefRangeEnd = 341748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Internal_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x0000F7E6 File Offset: 0x0000D9E6
		public UIElementsRuntimeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x000AA3F0 File Offset: 0x000A85F0
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x0000F7EF File Offset: 0x0000D9EF
		public unsafe static Action<BaseRuntimePanel> onCreatePanel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseRuntimePanel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_onCreatePanel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000AA418 File Offset: 0x000A8618
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x0000F801 File Offset: 0x0000DA01
		public unsafe static bool s_RegisteredPlayerloopCallback
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RegisteredPlayerloopCallback, (void*)(&value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x000AA434 File Offset: 0x000A8634
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x0000F80F File Offset: 0x0000DA0F
		public unsafe static List<Panel> s_SortedRuntimePanels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Panel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_SortedRuntimePanels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000AA45C File Offset: 0x000A865C
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0000F821 File Offset: 0x0000DA21
		public unsafe static bool s_PanelOrderingDirty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PanelOrderingDirty, (void*)(&value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x000AA478 File Offset: 0x000A8678
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x0000F82F File Offset: 0x0000DA2F
		public unsafe static int s_ResolvedSortingIndexMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_ResolvedSortingIndexMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_ResolvedSortingIndexMax, (void*)(&value));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x000AA494 File Offset: 0x000A8694
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x0000F83D File Offset: 0x0000DA3D
		public unsafe static string s_RepaintProfilerMarkerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarkerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x0000F84F File Offset: 0x0000DA4F
		public unsafe static ProfilerMarker s_RepaintProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_RepaintProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x000AA4D0 File Offset: 0x000A86D0
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x0000F85D File Offset: 0x0000DA5D
		public unsafe static int currentOverlayIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_currentOverlayIndex, (void*)(&value));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002638 RID: 9784 RVA: 0x000AA4EC File Offset: 0x000A86EC
		// (set) Token: 0x06002639 RID: 9785 RVA: 0x0000F86B File Offset: 0x0000DA6B
		public unsafe static Object _activeEventSystem_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr__activeEventSystem_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000AA514 File Offset: 0x000A8714
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x0000F87D File Offset: 0x0000DA7D
		public unsafe static DefaultEventSystem s_DefaultEventSystem
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_DefaultEventSystem, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultEventSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_DefaultEventSystem, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000AA53C File Offset: 0x000A873C
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x0000F88F File Offset: 0x0000DA8F
		public unsafe static List<PanelSettings> s_PotentiallyEmptyPanelSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PotentiallyEmptyPanelSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PanelSettings>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.NativeFieldInfoPtr_s_PotentiallyEmptyPanelSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0000F8A1 File Offset: 0x0000DAA1
		public static void add_s_onRepaintOverlayPanels(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x0000F8AE File Offset: 0x0000DAAE
		public static void remove_s_onRepaintOverlayPanels(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0000F8BB File Offset: 0x0000DABB
		public static void add_onRepaintOverlayPanels(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		public static void remove_onRepaintOverlayPanels(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0000F8D5 File Offset: 0x0000DAD5
		public static void RepaintOverlayPanels()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeFieldInfoPtr_onCreatePanel;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeFieldInfoPtr_s_RegisteredPlayerloopCallback;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeFieldInfoPtr_s_SortedRuntimePanels;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelOrderingDirty;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeFieldInfoPtr_s_ResolvedSortingIndexMax;

		// Token: 0x04001B6B RID: 7019
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarkerName;

		// Token: 0x04001B6C RID: 7020
		private static readonly IntPtr NativeFieldInfoPtr_s_RepaintProfilerMarker;

		// Token: 0x04001B6D RID: 7021
		private static readonly IntPtr NativeFieldInfoPtr_currentOverlayIndex;

		// Token: 0x04001B6E RID: 7022
		private static readonly IntPtr NativeFieldInfoPtr__activeEventSystem_k__BackingField;

		// Token: 0x04001B6F RID: 7023
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultEventSystem;

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr_s_PotentiallyEmptyPanelSettings;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeMethodInfoPtr_add_onCreatePanel_Public_Static_add_Void_Action_1_BaseRuntimePanel_0;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_remove_onCreatePanel_Public_Static_rem_Void_Action_1_BaseRuntimePanel_0;

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_EventBase_Event_0;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateRuntimePanel_Public_Static_BaseRuntimePanel_ScriptableObject_CreateRuntimePanelDelegate_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeMethodInfoPtr_DisposeRuntimePanel_Public_Static_Void_ScriptableObject_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCachedPanelInternal_Private_Static_Void_Int32_IPanel_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCachedPanelInternal_Private_Static_Void_Int32_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOffscreenPanels_Public_Static_Void_0;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeMethodInfoPtr_RepaintOverlayPanel_Public_Static_Void_BaseRuntimePanel_0;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderOverlays_Internal_Static_Void_Int32_0;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeMethodInfoPtr_RenderOverlaysBeforePriority_Internal_Static_Void_Int32_Single_0;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderOverlays_Internal_Static_Void_Int32_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_get_activeEventSystem_Internal_Static_get_Object_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_set_activeEventSystem_Private_Static_set_Void_Object_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_get_useDefaultEventSystem_Internal_Static_get_Boolean_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEventSystem_Public_Static_Void_Object_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEventSystem_Public_Static_Void_Object_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultEventSystem_Internal_Static_get_DefaultEventSystem_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRuntimePanels_Public_Static_Void_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Static_Void_PanelSettings_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUnusedPanels_Internal_Static_Void_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPlayerloopCallback_Public_Static_Void_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterPlayerloopCallback_Public_Static_Void_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_SetPanelOrderingDirty_Internal_Static_Void_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_GetSortedPlayerPanels_Internal_Static_List_1_Panel_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_SortPanels_Private_Static_Void_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_MultiDisplayBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_MultiDisplayToLocalScreenPosition_Internal_Static_Vector2_Vector2_byref_Nullable_1_Int32_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_ScreenBottomLeftToPanelPosition_Internal_Static_Vector2_Vector2_Int32_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_ScreenBottomLeftToPanelDelta_Internal_Static_Vector2_Vector2_0;

		// Token: 0x020004EA RID: 1258
		public sealed class CreateRuntimePanelDelegate : MulticastDelegate
		{
			// Token: 0x06003F3F RID: 16191 RVA: 0x0001A8AB File Offset: 0x00018AAB
			// Note: this type is marked as 'beforefieldinit'.
			static CreateRuntimePanelDelegate()
			{
				Il2CppClassPointerStore<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "CreateRuntimePanelDelegate");
				UIElementsRuntimeUtility.CreateRuntimePanelDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>.NativeClassPtr, 100669089);
				UIElementsRuntimeUtility.CreateRuntimePanelDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_BaseRuntimePanel_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>.NativeClassPtr, 100669090);
			}

			// Token: 0x06003F40 RID: 16192 RVA: 0x000FC11C File Offset: 0x000FA31C
			[CallerCount(1058)]
			[CachedScanResults(RefRangeStart = 340122, RefRangeEnd = 341180, XrefRangeStart = 340113, XrefRangeEnd = 340122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateRuntimePanelDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.CreateRuntimePanelDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F41 RID: 16193 RVA: 0x000FC178 File Offset: 0x000FA378
			[CallerCount(0)]
			public unsafe BaseRuntimePanel Invoke(ScriptableObject ownerObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.CreateRuntimePanelDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_BaseRuntimePanel_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
				}
			}

			// Token: 0x06003F42 RID: 16194 RVA: 0x0001A8E9 File Offset: 0x00018AE9
			public CreateRuntimePanelDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003F43 RID: 16195 RVA: 0x0001A8F2 File Offset: 0x00018AF2
			public static implicit operator UIElementsRuntimeUtility.CreateRuntimePanelDelegate(Func<ScriptableObject, BaseRuntimePanel> A_0)
			{
				return DelegateSupport.ConvertDelegate<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>(A_0);
			}

			// Token: 0x06003F44 RID: 16196 RVA: 0x0001A8FA File Offset: 0x00018AFA
			public static UIElementsRuntimeUtility.CreateRuntimePanelDelegate operator +(UIElementsRuntimeUtility.CreateRuntimePanelDelegate A_0, UIElementsRuntimeUtility.CreateRuntimePanelDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>();
			}

			// Token: 0x06003F45 RID: 16197 RVA: 0x0001A908 File Offset: 0x00018B08
			public static UIElementsRuntimeUtility.CreateRuntimePanelDelegate operator -(UIElementsRuntimeUtility.CreateRuntimePanelDelegate A_0, UIElementsRuntimeUtility.CreateRuntimePanelDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<UIElementsRuntimeUtility.CreateRuntimePanelDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04002CB4 RID: 11444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CB5 RID: 11445
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_BaseRuntimePanel_ScriptableObject_0;
		}

		// Token: 0x020004EB RID: 1259
		[ObfuscatedName("UnityEngine.UIElements.UIElementsRuntimeUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003F46 RID: 16198 RVA: 0x000FC1C8 File Offset: 0x000FA3C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIElementsRuntimeUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr);
				UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, "<>9");
				UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, "<>9__48_0");
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100669092);
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100669093);
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100669094);
				UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__SortPanels_b__48_0_Internal_Int32_Panel_Panel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr, 100669095);
			}

			// Token: 0x06003F47 RID: 16199 RVA: 0x000FC26C File Offset: 0x000FA46C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementsRuntimeUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F48 RID: 16200 RVA: 0x000FC2A8 File Offset: 0x000FA4A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__9_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F49 RID: 16201 RVA: 0x000FC2DC File Offset: 0x000FA4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341180, XrefRangeEnd = 341184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__9_1(int displayIndex, int sortOrder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref displayIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortOrder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003F4A RID: 16202 RVA: 0x000FC328 File Offset: 0x000FA528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341184, XrefRangeEnd = 341192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortPanels_b__48_0(Panel a, Panel b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIElementsRuntimeUtility.__c.NativeMethodInfoPtr__SortPanels_b__48_0_Internal_Int32_Panel_Panel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003F4B RID: 16203 RVA: 0x0001A919 File Offset: 0x00018B19
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170012FF RID: 4863
			// (get) Token: 0x06003F4C RID: 16204 RVA: 0x000FC388 File Offset: 0x000FA588
			// (set) Token: 0x06003F4D RID: 16205 RVA: 0x0001A922 File Offset: 0x00018B22
			public unsafe static UIElementsRuntimeUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementsRuntimeUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001300 RID: 4864
			// (get) Token: 0x06003F4E RID: 16206 RVA: 0x000FC3B0 File Offset: 0x000FA5B0
			// (set) Token: 0x06003F4F RID: 16207 RVA: 0x0001A934 File Offset: 0x00018B34
			public unsafe static Comparison<Panel> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Panel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIElementsRuntimeUtility.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CB6 RID: 11446
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002CB7 RID: 11447
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04002CB8 RID: 11448
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CB9 RID: 11449
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_Void_0;

			// Token: 0x04002CBA RID: 11450
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__9_1_Internal_Void_Int32_Int32_0;

			// Token: 0x04002CBB RID: 11451
			private static readonly IntPtr NativeMethodInfoPtr__SortPanels_b__48_0_Internal_Int32_Panel_Panel_0;
		}

		// Token: 0x020004EC RID: 1260
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
