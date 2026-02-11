using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000035 RID: 53
	public class ReusableListViewItem : ReusableCollectionItem
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x0002CC4C File Offset: 0x0002AE4C
		// Note: this type is marked as 'beforefieldinit'.
		static ReusableListViewItem()
		{
			Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ReusableListViewItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr);
			ReusableListViewItem.NativeFieldInfoPtr_m_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, "m_Container");
			ReusableListViewItem.NativeFieldInfoPtr_m_DragHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, "m_DragHandle");
			ReusableListViewItem.NativeFieldInfoPtr_m_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, "m_ItemContainer");
			ReusableListViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663904);
			ReusableListViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663905);
			ReusableListViewItem.NativeMethodInfoPtr_UpdateHierarchy_Protected_Void_VisualElement_VisualElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663906);
			ReusableListViewItem.NativeMethodInfoPtr_UpdateDragHandle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663907);
			ReusableListViewItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663908);
			ReusableListViewItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663909);
			ReusableListViewItem.NativeMethodInfoPtr_SetDragGhost_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663910);
			ReusableListViewItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr, 100663911);
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0002CD58 File Offset: 0x0002AF58
		public unsafe override VisualElement rootElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableListViewItem.NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287398, XrefRangeEnd = 287409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(VisualElement item, bool usesAnimatedDragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesAnimatedDragger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableListViewItem.NativeMethodInfoPtr_Init_Public_Void_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287413, RefRangeEnd = 287416, XrefRangeStart = 287409, XrefRangeEnd = 287413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usesAnimatedDragger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableListViewItem.NativeMethodInfoPtr_UpdateHierarchy_Protected_Void_VisualElement_VisualElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0002CE58 File Offset: 0x0002B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287416, XrefRangeEnd = 287423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDragHandle(bool needsDragHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needsDragHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableListViewItem.NativeMethodInfoPtr_UpdateDragHandle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0002CE98 File Offset: 0x0002B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287423, XrefRangeEnd = 287430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreAttachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableListViewItem.NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0002CED4 File Offset: 0x0002B0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287430, XrefRangeEnd = 287437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DetachElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableListViewItem.NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0002CF10 File Offset: 0x0002B110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287437, XrefRangeEnd = 287441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDragGhost(bool dragGhost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dragGhost;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReusableListViewItem.NativeMethodInfoPtr_SetDragGhost_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0002CF5C File Offset: 0x0002B15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287441, XrefRangeEnd = 287442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReusableListViewItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReusableListViewItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReusableListViewItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000325F File Offset: 0x0000145F
		public ReusableListViewItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0002CF98 File Offset: 0x0002B198
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003268 File Offset: 0x00001468
		public unsafe VisualElement m_Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003287 File Offset: 0x00001487
		public unsafe VisualElement m_DragHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_DragHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_DragHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0002CFF8 File Offset: 0x0002B1F8
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000032A6 File Offset: 0x000014A6
		public unsafe VisualElement m_ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReusableListViewItem.NativeFieldInfoPtr_m_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_m_Container;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_m_DragHandle;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemContainer;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_get_rootElement_Public_Virtual_get_VisualElement_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_VisualElement_Boolean_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHierarchy_Protected_Void_VisualElement_VisualElement_Boolean_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDragHandle_Public_Void_Boolean_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_PreAttachElement_Public_Virtual_Void_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_DetachElement_Public_Virtual_Void_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_SetDragGhost_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
