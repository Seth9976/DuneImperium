using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000237 RID: 567
	public class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x060029DD RID: 10717 RVA: 0x000B6B04 File Offset: 0x000B4D04
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVisualTreeHierarchyTrackerUpdater()
		{
			Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseVisualTreeHierarchyTrackerUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr);
			BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, "m_State");
			BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, "m_CurrentChangeElement");
			BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, "m_CurrentChangeParent");
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_OnHierarchyChange_Protected_Abstract_Virtual_New_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669572);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669573);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669574);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessNewChange_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669575);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessAddOrMove_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669576);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessRemove_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669577);
			BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr, 100669578);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000B6BFC File Offset: 0x000B4DFC
		[CallerCount(0)]
		public unsafe virtual void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_OnHierarchyChange_Protected_Abstract_Virtual_New_Void_VisualElement_HierarchyChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000B6C58 File Offset: 0x000B4E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346941, RefRangeEnd = 346942, XrefRangeStart = 346937, XrefRangeEnd = 346941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000B6CB4 File Offset: 0x000B4EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346949, RefRangeEnd = 346950, XrefRangeStart = 346942, XrefRangeEnd = 346949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000B6CF0 File Offset: 0x000B4EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346954, RefRangeEnd = 346955, XrefRangeStart = 346950, XrefRangeEnd = 346954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessNewChange(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessNewChange_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000B6D34 File Offset: 0x000B4F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346955, XrefRangeEnd = 346960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAddOrMove(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessAddOrMove_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000B6D78 File Offset: 0x000B4F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346960, XrefRangeEnd = 346962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessRemove(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr_ProcessRemove_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000B6DBC File Offset: 0x000B4FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346963, RefRangeEnd = 346964, XrefRangeStart = 346962, XrefRangeEnd = 346963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVisualTreeHierarchyTrackerUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVisualTreeHierarchyTrackerUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualTreeHierarchyTrackerUpdater.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00010D76 File Offset: 0x0000EF76
		public BaseVisualTreeHierarchyTrackerUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x000B6DF8 File Offset: 0x000B4FF8
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x00010D7F File Offset: 0x0000EF7F
		public unsafe BaseVisualTreeHierarchyTrackerUpdater.State m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_State)) = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x000B6E20 File Offset: 0x000B5020
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x00010D9A File Offset: 0x0000EF9A
		public unsafe VisualElement m_CurrentChangeElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x000B6E50 File Offset: 0x000B5050
		// (set) Token: 0x060029EB RID: 10731 RVA: 0x00010DB9 File Offset: 0x0000EFB9
		public unsafe VisualElement m_CurrentChangeParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualTreeHierarchyTrackerUpdater.NativeFieldInfoPtr_m_CurrentChangeParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentChangeElement;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentChangeParent;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeMethodInfoPtr_OnHierarchyChange_Protected_Abstract_Virtual_New_Void_VisualElement_HierarchyChangeType_0;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_ProcessNewChange_Private_Void_VisualElement_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAddOrMove_Private_Void_VisualElement_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRemove_Private_Void_VisualElement_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000534 RID: 1332
		public enum State
		{
			// Token: 0x04002D83 RID: 11651
			Waiting,
			// Token: 0x04002D84 RID: 11652
			TrackingAddOrMove,
			// Token: 0x04002D85 RID: 11653
			TrackingRemove
		}
	}
}
