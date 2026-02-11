using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023F RID: 575
	public class BaseVisualTreeUpdater : Object
	{
		// Token: 0x06002A62 RID: 10850 RVA: 0x000B87F4 File Offset: 0x000B69F4
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVisualTreeUpdater()
		{
			Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseVisualTreeUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr);
			BaseVisualTreeUpdater.NativeFieldInfoPtr_panelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, "panelChanged");
			BaseVisualTreeUpdater.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, "m_Panel");
			BaseVisualTreeUpdater.NativeMethodInfoPtr_add_panelChanged_Public_add_Void_Action_1_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669634);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_remove_panelChanged_Public_rem_Void_Action_1_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669635);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669636);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669637);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_get_visualTree_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669638);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669639);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669640);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669641);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669642);
			BaseVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669643);
			BaseVisualTreeUpdater.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr, 100669644);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000B8928 File Offset: 0x000B6B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347680, RefRangeEnd = 347681, XrefRangeStart = 347675, XrefRangeEnd = 347680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_panelChanged(Action<BaseVisualElementPanel> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_add_panelChanged_Public_add_Void_Action_1_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000B896C File Offset: 0x000B6B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347681, XrefRangeEnd = 347686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_panelChanged(Action<BaseVisualElementPanel> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_remove_panelChanged_Public_rem_Void_Action_1_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000B89B0 File Offset: 0x000B6BB0
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x000B89F0 File Offset: 0x000B6BF0
		public unsafe virtual BaseVisualElementPanel panel
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347686, XrefRangeEnd = 347687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000B8A34 File Offset: 0x000B6C34
		public unsafe VisualElement visualTree
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 347688, RefRangeEnd = 347694, XrefRangeStart = 347687, XrefRangeEnd = 347688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_get_visualTree_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000B8A74 File Offset: 0x000B6C74
		public unsafe virtual ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000B8ABC File Offset: 0x000B6CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347694, XrefRangeEnd = 347698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000B8AF0 File Offset: 0x000B6CF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000B8B3C File Offset: 0x000B6D3C
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeUpdater.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000B8B78 File Offset: 0x000B6D78
		[CallerCount(0)]
		public unsafe virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000B8BD4 File Offset: 0x000B6DD4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVisualTreeUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVisualTreeUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeUpdater.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00011166 File Offset: 0x0000F366
		public BaseVisualTreeUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x000B8C10 File Offset: 0x000B6E10
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x0001116F File Offset: 0x0000F36F
		public unsafe Action<BaseVisualElementPanel> panelChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeUpdater.NativeFieldInfoPtr_panelChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseVisualElementPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeUpdater.NativeFieldInfoPtr_panelChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x000B8C40 File Offset: 0x000B6E40
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x0001118E File Offset: 0x0000F38E
		public unsafe BaseVisualElementPanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeUpdater.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeUpdater.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeFieldInfoPtr_panelChanged;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_add_panelChanged_Public_add_Void_Action_1_BaseVisualElementPanel_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_remove_panelChanged_Public_rem_Void_Action_1_BaseVisualElementPanel_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_BaseVisualElementPanel_0;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_BaseVisualElementPanel_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_get_VisualElement_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Abstract_Virtual_New_get_ProfilerMarker_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
