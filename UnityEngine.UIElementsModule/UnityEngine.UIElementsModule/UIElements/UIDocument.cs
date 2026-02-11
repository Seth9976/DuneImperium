using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000139 RID: 313
	public sealed class UIDocument : MonoBehaviour
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x0006FD70 File Offset: 0x0006DF70
		// Note: this type is marked as 'beforefieldinit'.
		static UIDocument()
		{
			Il2CppClassPointerStore<UIDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDocument>.NativeClassPtr);
			UIDocument.NativeFieldInfoPtr_k_RootStyleClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "k_RootStyleClassName");
			UIDocument.NativeFieldInfoPtr_k_VisualElementNameSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "k_VisualElementNameSuffix");
			UIDocument.NativeFieldInfoPtr_k_DefaultSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "k_DefaultSortingOrder");
			UIDocument.NativeFieldInfoPtr_s_CurrentUIDocumentCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "s_CurrentUIDocumentCounter");
			UIDocument.NativeFieldInfoPtr_m_UIDocumentCreationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_UIDocumentCreationIndex");
			UIDocument.NativeFieldInfoPtr_m_PanelSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_PanelSettings");
			UIDocument.NativeFieldInfoPtr_m_PreviousPanelSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_PreviousPanelSettings");
			UIDocument.NativeFieldInfoPtr_m_ParentUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_ParentUI");
			UIDocument.NativeFieldInfoPtr_m_ChildrenContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_ChildrenContent");
			UIDocument.NativeFieldInfoPtr_m_ChildrenContentCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_ChildrenContentCopy");
			UIDocument.NativeFieldInfoPtr_sourceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "sourceAsset");
			UIDocument.NativeFieldInfoPtr_m_RootVisualElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_RootVisualElement");
			UIDocument.NativeFieldInfoPtr_m_FirstChildInsertIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_FirstChildInsertIndex");
			UIDocument.NativeFieldInfoPtr_m_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, "m_SortingOrder");
			UIDocument.NativeMethodInfoPtr_get_panelSettings_Public_get_PanelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666788);
			UIDocument.NativeMethodInfoPtr_set_panelSettings_Public_set_Void_PanelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666789);
			UIDocument.NativeMethodInfoPtr_get_parentUI_Public_get_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666790);
			UIDocument.NativeMethodInfoPtr_set_parentUI_Private_set_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666791);
			UIDocument.NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666792);
			UIDocument.NativeMethodInfoPtr_set_visualTreeAsset_Public_set_Void_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666793);
			UIDocument.NativeMethodInfoPtr_get_rootVisualElement_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666794);
			UIDocument.NativeMethodInfoPtr_get_firstChildInserIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666795);
			UIDocument.NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666796);
			UIDocument.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666797);
			UIDocument.NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666798);
			UIDocument.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666799);
			UIDocument.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666800);
			UIDocument.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666801);
			UIDocument.NativeMethodInfoPtr_SetupFromHierarchy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666802);
			UIDocument.NativeMethodInfoPtr_FindUIDocumentParent_Private_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666803);
			UIDocument.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666804);
			UIDocument.NativeMethodInfoPtr_AddChildAndInsertContentToVisualTree_Private_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666805);
			UIDocument.NativeMethodInfoPtr_RemoveChild_Private_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666806);
			UIDocument.NativeMethodInfoPtr_RecreateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666807);
			UIDocument.NativeMethodInfoPtr_SetupRootClassList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666808);
			UIDocument.NativeMethodInfoPtr_AddRootVisualElementToTree_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666809);
			UIDocument.NativeMethodInfoPtr_RemoveFromHierarchy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666810);
			UIDocument.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666811);
			UIDocument.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666812);
			UIDocument.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666813);
			UIDocument.NativeMethodInfoPtr_ReactToHierarchyChanged_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDocument>.NativeClassPtr, 100666814);
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x000700D4 File Offset: 0x0006E2D4
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x00070114 File Offset: 0x0006E314
		public unsafe PanelSettings panelSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_panelSettings_Public_get_PanelSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318903, RefRangeEnd = 318906, XrefRangeStart = 318862, XrefRangeEnd = 318903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_set_panelSettings_Public_set_Void_PanelSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00070158 File Offset: 0x0006E358
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x00070198 File Offset: 0x0006E398
		public unsafe UIDocument parentUI
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_parentUI_Public_get_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIDocument>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_set_parentUI_Private_set_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000701DC File Offset: 0x0006E3DC
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0007021C File Offset: 0x0006E41C
		public unsafe VisualTreeAsset visualTreeAsset
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 312325, RefRangeEnd = 312368, XrefRangeStart = 312325, XrefRangeEnd = 312368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318906, XrefRangeEnd = 318908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_set_visualTreeAsset_Public_set_Void_VisualTreeAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00070260 File Offset: 0x0006E460
		public unsafe VisualElement rootVisualElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_rootVisualElement_Public_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x000702A0 File Offset: 0x0006E4A0
		public unsafe int firstChildInserIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_firstChildInserIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x000702DC File Offset: 0x0006E4DC
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x00070318 File Offset: 0x0006E518
		public unsafe float sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318908, XrefRangeEnd = 318909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00070358 File Offset: 0x0006E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318909, XrefRangeEnd = 318910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySortingOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0007038C File Offset: 0x0006E58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318910, XrefRangeEnd = 318916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIDocument()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDocument>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000703C8 File Offset: 0x0006E5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318916, XrefRangeEnd = 318917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000703FC File Offset: 0x0006E5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318917, XrefRangeEnd = 318927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00070430 File Offset: 0x0006E630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318947, RefRangeEnd = 318950, XrefRangeStart = 318927, XrefRangeEnd = 318947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFromHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_SetupFromHierarchy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x00070464 File Offset: 0x0006E664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318950, XrefRangeEnd = 318959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIDocument FindUIDocumentParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_FindUIDocumentParent_Private_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIDocument>(intPtr3) : null;
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x000704A4 File Offset: 0x0006E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318959, XrefRangeEnd = 318973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000704D8 File Offset: 0x0006E6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318984, RefRangeEnd = 318985, XrefRangeStart = 318973, XrefRangeEnd = 318984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildAndInsertContentToVisualTree(UIDocument child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_AddChildAndInsertContentToVisualTree_Private_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0007051C File Offset: 0x0006E71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318985, XrefRangeEnd = 318989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(UIDocument child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_RemoveChild_Private_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x00070560 File Offset: 0x0006E760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319062, RefRangeEnd = 319065, XrefRangeStart = 318989, XrefRangeEnd = 319062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecreateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_RecreateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00070594 File Offset: 0x0006E794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319072, RefRangeEnd = 319073, XrefRangeStart = 319065, XrefRangeEnd = 319072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupRootClassList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_SetupRootClassList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000705C8 File Offset: 0x0006E7C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 319082, RefRangeEnd = 319088, XrefRangeStart = 319073, XrefRangeEnd = 319082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRootVisualElementToTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_AddRootVisualElementToTree_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000705FC File Offset: 0x0006E7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319096, RefRangeEnd = 319098, XrefRangeStart = 319088, XrefRangeEnd = 319096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromHierarchy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_RemoveFromHierarchy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00070630 File Offset: 0x0006E830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319098, XrefRangeEnd = 319100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00070664 File Offset: 0x0006E864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319100, XrefRangeEnd = 319128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00070698 File Offset: 0x0006E898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319128, XrefRangeEnd = 319129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000706CC File Offset: 0x0006E8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319139, RefRangeEnd = 319141, XrefRangeStart = 319129, XrefRangeEnd = 319139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReactToHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIDocument.NativeMethodInfoPtr_ReactToHierarchyChanged_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0000AC9E File Offset: 0x00008E9E
		public UIDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00070700 File Offset: 0x0006E900
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x0000ACA7 File Offset: 0x00008EA7
		public unsafe static string k_RootStyleClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIDocument.NativeFieldInfoPtr_k_RootStyleClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIDocument.NativeFieldInfoPtr_k_RootStyleClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x00070720 File Offset: 0x0006E920
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x0000ACB9 File Offset: 0x00008EB9
		public unsafe static string k_VisualElementNameSuffix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIDocument.NativeFieldInfoPtr_k_VisualElementNameSuffix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIDocument.NativeFieldInfoPtr_k_VisualElementNameSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00070740 File Offset: 0x0006E940
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0000ACCB File Offset: 0x00008ECB
		public unsafe static int k_DefaultSortingOrder
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIDocument.NativeFieldInfoPtr_k_DefaultSortingOrder, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIDocument.NativeFieldInfoPtr_k_DefaultSortingOrder, (void*)(&value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0007075C File Offset: 0x0006E95C
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000ACD9 File Offset: 0x00008ED9
		public unsafe static int s_CurrentUIDocumentCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIDocument.NativeFieldInfoPtr_s_CurrentUIDocumentCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIDocument.NativeFieldInfoPtr_s_CurrentUIDocumentCounter, (void*)(&value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00070778 File Offset: 0x0006E978
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000ACE7 File Offset: 0x00008EE7
		public unsafe int m_UIDocumentCreationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_UIDocumentCreationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_UIDocumentCreationIndex)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000707A0 File Offset: 0x0006E9A0
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000AD02 File Offset: 0x00008F02
		public unsafe PanelSettings m_PanelSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_PanelSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_PanelSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000707D0 File Offset: 0x0006E9D0
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000AD21 File Offset: 0x00008F21
		public unsafe PanelSettings m_PreviousPanelSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_PreviousPanelSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_PreviousPanelSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00070800 File Offset: 0x0006EA00
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000AD40 File Offset: 0x00008F40
		public unsafe UIDocument m_ParentUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ParentUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ParentUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00070830 File Offset: 0x0006EA30
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000AD5F File Offset: 0x00008F5F
		public unsafe UIDocumentList m_ChildrenContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ChildrenContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIDocumentList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ChildrenContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x00070860 File Offset: 0x0006EA60
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000AD7E File Offset: 0x00008F7E
		public unsafe List<UIDocument> m_ChildrenContentCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ChildrenContentCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIDocument>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_ChildrenContentCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00070890 File Offset: 0x0006EA90
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000AD9D File Offset: 0x00008F9D
		public unsafe VisualTreeAsset sourceAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_sourceAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_sourceAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000708C0 File Offset: 0x0006EAC0
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0000ADBC File Offset: 0x00008FBC
		public unsafe VisualElement m_RootVisualElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_RootVisualElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_RootVisualElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000708F0 File Offset: 0x0006EAF0
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0000ADDB File Offset: 0x00008FDB
		public unsafe int m_FirstChildInsertIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_FirstChildInsertIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_FirstChildInsertIndex)) = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00070918 File Offset: 0x0006EB18
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000ADF6 File Offset: 0x00008FF6
		public unsafe float m_SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIDocument.NativeFieldInfoPtr_m_SortingOrder)) = value;
			}
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_k_RootStyleClassName;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_k_VisualElementNameSuffix;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultSortingOrder;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentUIDocumentCounter;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeFieldInfoPtr_m_UIDocumentCreationIndex;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelSettings;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousPanelSettings;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentUI;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildrenContent;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildrenContentCopy;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeFieldInfoPtr_sourceAsset;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeFieldInfoPtr_m_RootVisualElement;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstChildInsertIndex;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingOrder;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_get_panelSettings_Public_get_PanelSettings_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_set_panelSettings_Public_set_Void_PanelSettings_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_get_parentUI_Public_get_UIDocument_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_set_parentUI_Private_set_Void_UIDocument_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_set_visualTreeAsset_Public_set_Void_VisualTreeAsset_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_get_rootVisualElement_Public_get_VisualElement_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_get_firstChildInserIndex_Internal_get_Int32_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_SetupFromHierarchy_Private_Void_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_FindUIDocumentParent_Private_UIDocument_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAndInsertContentToVisualTree_Private_Void_UIDocument_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Private_Void_UIDocument_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_RecreateUI_Private_Void_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_SetupRootClassList_Private_Void_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_AddRootVisualElementToTree_Private_Void_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromHierarchy_Private_Void_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Private_Void_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_ReactToHierarchyChanged_Internal_Void_0;
	}
}
