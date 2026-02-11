using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004C RID: 76
	public class PanelRaycaster : BaseRaycaster
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x0002A294 File Offset: 0x00028494
		// Note: this type is marked as 'beforefieldinit'.
		static PanelRaycaster()
		{
			Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UIElements", "PanelRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr);
			PanelRaycaster.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, "m_Panel");
			PanelRaycaster.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664797);
			PanelRaycaster.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664798);
			PanelRaycaster.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664799);
			PanelRaycaster.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664800);
			PanelRaycaster.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664801);
			PanelRaycaster.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664802);
			PanelRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664803);
			PanelRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664804);
			PanelRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664805);
			PanelRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664806);
			PanelRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664807);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0002A3B4 File Offset: 0x000285B4
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0002A3F4 File Offset: 0x000285F4
		public unsafe virtual IPanel panel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094686, XrefRangeEnd = 1094703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0002A438 File Offset: 0x00028638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094703, XrefRangeEnd = 1094710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002A46C File Offset: 0x0002866C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094710, XrefRangeEnd = 1094717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002A4A0 File Offset: 0x000286A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094717, XrefRangeEnd = 1094733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0002A4D4 File Offset: 0x000286D4
		public unsafe GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002A514 File Offset: 0x00028714
		public unsafe override int sortOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094733, XrefRangeEnd = 1094738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002A55C File Offset: 0x0002875C
		public unsafe override int renderOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094738, XrefRangeEnd = 1094742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0002A5A4 File Offset: 0x000287A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094742, XrefRangeEnd = 1094784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002A604 File Offset: 0x00028804
		public unsafe override Camera eventCamera
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0002A650 File Offset: 0x00028850
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0000507D File Offset: 0x0000327D
		public PanelRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002A68C File Offset: 0x0002888C
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00005086 File Offset: 0x00003286
		public unsafe BaseRuntimePanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelRaycaster.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelRaycaster.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
