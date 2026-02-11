using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002D RID: 45
	public class MultiColumnListViewController : BaseListViewController
	{
		// Token: 0x06000340 RID: 832 RVA: 0x00029168 File Offset: 0x00027368
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnListViewController()
		{
			Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MultiColumnListViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr);
			MultiColumnListViewController.NativeFieldInfoPtr_m_ColumnController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, "m_ColumnController");
			MultiColumnListViewController.NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663753);
			MultiColumnListViewController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663754);
			MultiColumnListViewController.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663755);
			MultiColumnListViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663756);
			MultiColumnListViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663757);
			MultiColumnListViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663758);
			MultiColumnListViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663759);
			MultiColumnListViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663760);
			MultiColumnListViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663761);
			MultiColumnListViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663762);
			MultiColumnListViewController.NativeMethodInfoPtr_UpdateReorderClassList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr, 100663763);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00029288 File Offset: 0x00027488
		public unsafe MultiColumnController columnController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListViewController.NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnController>(intPtr3) : null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000292C8 File Offset: 0x000274C8
		public unsafe UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286147, RefRangeEnd = 286148, XrefRangeStart = 286147, XrefRangeEnd = 286147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListViewController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader>(intPtr3) : null;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00029308 File Offset: 0x00027508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286154, RefRangeEnd = 286155, XrefRangeStart = 286148, XrefRangeEnd = 286154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnListViewController>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortDescriptions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortedColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListViewController.NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00029378 File Offset: 0x00027578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286155, XrefRangeEnd = 286161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000293C8 File Offset: 0x000275C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286161, XrefRangeEnd = 286163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00029414 File Offset: 0x00027614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286163, XrefRangeEnd = 286166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00029470 File Offset: 0x00027670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286166, XrefRangeEnd = 286168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnbindItem(VisualElement element, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000294CC File Offset: 0x000276CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286168, XrefRangeEnd = 286170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0002951C File Offset: 0x0002771C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286170, XrefRangeEnd = 286182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00029558 File Offset: 0x00027758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286182, XrefRangeEnd = 286200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnListViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00029594 File Offset: 0x00027794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286200, XrefRangeEnd = 286210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateReorderClassList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnListViewController.NativeMethodInfoPtr_UpdateReorderClassList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public MultiColumnListViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600034D RID: 845 RVA: 0x000295C8 File Offset: 0x000277C8
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00002DED File Offset: 0x00000FED
		public unsafe MultiColumnController m_ColumnController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListViewController.NativeFieldInfoPtr_m_ColumnController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnListViewController.NativeFieldInfoPtr_m_ColumnController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnController;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_UpdateReorderClassList_Private_Void_0;
	}
}
