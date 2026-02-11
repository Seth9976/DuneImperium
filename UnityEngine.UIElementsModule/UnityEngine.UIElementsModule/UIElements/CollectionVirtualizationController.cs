using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000031 RID: 49
	public class CollectionVirtualizationController : Object
	{
		// Token: 0x06000379 RID: 889 RVA: 0x0002A19C File Offset: 0x0002839C
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionVirtualizationController()
		{
			Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CollectionVirtualizationController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr);
			CollectionVirtualizationController.NativeFieldInfoPtr_m_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, "m_ScrollView");
			CollectionVirtualizationController.NativeMethodInfoPtr_get_firstVisibleIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663807);
			CollectionVirtualizationController.NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663808);
			CollectionVirtualizationController.NativeMethodInfoPtr_get_visibleItemCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663809);
			CollectionVirtualizationController.NativeMethodInfoPtr__ctor_Protected_Void_ScrollView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663810);
			CollectionVirtualizationController.NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663811);
			CollectionVirtualizationController.NativeMethodInfoPtr_ScrollToItem_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663812);
			CollectionVirtualizationController.NativeMethodInfoPtr_Resize_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663813);
			CollectionVirtualizationController.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663814);
			CollectionVirtualizationController.NativeMethodInfoPtr_GetIndexFromPosition_Public_Abstract_Virtual_New_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663815);
			CollectionVirtualizationController.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Abstract_Virtual_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663816);
			CollectionVirtualizationController.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663817);
			CollectionVirtualizationController.NativeMethodInfoPtr_OnFocus_Public_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663818);
			CollectionVirtualizationController.NativeMethodInfoPtr_OnBlur_Public_Abstract_Virtual_New_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663819);
			CollectionVirtualizationController.NativeMethodInfoPtr_UpdateBackground_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663820);
			CollectionVirtualizationController.NativeMethodInfoPtr_get_activeItems_Public_Abstract_Virtual_New_get_IEnumerable_1_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663821);
			CollectionVirtualizationController.NativeMethodInfoPtr_StartDragItem_Internal_Abstract_Virtual_New_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663822);
			CollectionVirtualizationController.NativeMethodInfoPtr_EndDrag_Internal_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr, 100663823);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0002A334 File Offset: 0x00028534
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0002A37C File Offset: 0x0002857C
		public unsafe virtual int firstVisibleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_get_firstVisibleIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002A3C8 File Offset: 0x000285C8
		public unsafe virtual int visibleItemCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_get_visibleItemCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0002A410 File Offset: 0x00028610
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286433, XrefRangeEnd = 286435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionVirtualizationController(ScrollView scrollView)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionVirtualizationController>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionVirtualizationController.NativeMethodInfoPtr__ctor_Protected_Void_ScrollView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0002A45C File Offset: 0x0002865C
		[CallerCount(0)]
		public unsafe virtual void Refresh(bool rebuild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rebuild;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0002A4A8 File Offset: 0x000286A8
		[CallerCount(0)]
		public unsafe virtual void ScrollToItem(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_ScrollToItem_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0002A4F4 File Offset: 0x000286F4
		[CallerCount(0)]
		public unsafe virtual void Resize(Vector2 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_Resize_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0002A540 File Offset: 0x00028740
		[CallerCount(0)]
		public unsafe virtual void OnScroll(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0002A58C File Offset: 0x0002878C
		[CallerCount(0)]
		public unsafe virtual int GetIndexFromPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_GetIndexFromPosition_Public_Abstract_Virtual_New_Int32_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0002A5E0 File Offset: 0x000287E0
		[CallerCount(0)]
		public unsafe virtual float GetExpectedItemHeight(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_GetExpectedItemHeight_Public_Abstract_Virtual_New_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0002A634 File Offset: 0x00028834
		[CallerCount(0)]
		public unsafe virtual float GetExpectedContentHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_GetExpectedContentHeight_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0002A67C File Offset: 0x0002887C
		[CallerCount(0)]
		public unsafe virtual void OnFocus(VisualElement leafTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leafTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_OnFocus_Public_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0002A6CC File Offset: 0x000288CC
		[CallerCount(0)]
		public unsafe virtual void OnBlur(VisualElement willFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(willFocus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_OnBlur_Public_Abstract_Virtual_New_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0002A71C File Offset: 0x0002891C
		[CallerCount(0)]
		public unsafe virtual void UpdateBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_UpdateBackground_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002A758 File Offset: 0x00028958
		public unsafe virtual IEnumerable<ReusableCollectionItem> activeItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_get_activeItems_Public_Abstract_Virtual_New_get_IEnumerable_1_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ReusableCollectionItem>>(intPtr3) : null;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0002A7A4 File Offset: 0x000289A4
		[CallerCount(0)]
		public unsafe virtual void StartDragItem(ReusableCollectionItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_StartDragItem_Internal_Abstract_Virtual_New_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0002A7F4 File Offset: 0x000289F4
		[CallerCount(0)]
		public unsafe virtual void EndDrag(int dropIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dropIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectionVirtualizationController.NativeMethodInfoPtr_EndDrag_Internal_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002EBA File Offset: 0x000010BA
		public CollectionVirtualizationController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0002A840 File Offset: 0x00028A40
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00002EC3 File Offset: 0x000010C3
		public unsafe ScrollView m_ScrollView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionVirtualizationController.NativeFieldInfoPtr_m_ScrollView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionVirtualizationController.NativeFieldInfoPtr_m_ScrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollView;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_get_firstVisibleIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_set_firstVisibleIndex_Protected_Abstract_Virtual_New_set_Void_Int32_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleItemCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ScrollView_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToItem_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Abstract_Virtual_New_Void_Vector2_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexFromPosition_Public_Abstract_Virtual_New_Int32_Vector2_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedItemHeight_Public_Abstract_Virtual_New_Single_Int32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedContentHeight_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_OnFocus_Public_Abstract_Virtual_New_Void_VisualElement_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_OnBlur_Public_Abstract_Virtual_New_Void_VisualElement_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBackground_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_activeItems_Public_Abstract_Virtual_New_get_IEnumerable_1_ReusableCollectionItem_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_StartDragItem_Internal_Abstract_Virtual_New_Void_ReusableCollectionItem_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Internal_Abstract_Virtual_New_Void_Int32_0;
	}
}
