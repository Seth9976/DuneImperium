using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002E RID: 46
	public class MultiColumnTreeViewController : BaseTreeViewController
	{
		// Token: 0x0600034F RID: 847 RVA: 0x000295F8 File Offset: 0x000277F8
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnTreeViewController()
		{
			Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MultiColumnTreeViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr);
			MultiColumnTreeViewController.NativeFieldInfoPtr_m_ColumnController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, "m_ColumnController");
			MultiColumnTreeViewController.NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663764);
			MultiColumnTreeViewController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663765);
			MultiColumnTreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663766);
			MultiColumnTreeViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663767);
			MultiColumnTreeViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663768);
			MultiColumnTreeViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663769);
			MultiColumnTreeViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663770);
			MultiColumnTreeViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663771);
			MultiColumnTreeViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663772);
			MultiColumnTreeViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr, 100663773);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00029704 File Offset: 0x00027904
		public unsafe MultiColumnController columnController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeViewController.NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultiColumnController>(intPtr3) : null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00029744 File Offset: 0x00027944
		public unsafe UnityEngine.UIElements.Internal.MultiColumnCollectionHeader header
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 286210, RefRangeEnd = 286211, XrefRangeStart = 286210, XrefRangeEnd = 286210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeViewController.NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader>(intPtr3) : null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00029784 File Offset: 0x00027984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286220, RefRangeEnd = 286221, XrefRangeStart = 286211, XrefRangeEnd = 286220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnTreeViewController>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnTreeViewController.NativeMethodInfoPtr__ctor_Protected_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000297F4 File Offset: 0x000279F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286221, XrefRangeEnd = 286230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00029844 File Offset: 0x00027A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286230, XrefRangeEnd = 286232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VisualElement MakeItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00029890 File Offset: 0x00027A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286232, XrefRangeEnd = 286235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000298EC File Offset: 0x00027AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286235, XrefRangeEnd = 286237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00029948 File Offset: 0x00027B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286237, XrefRangeEnd = 286239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00029998 File Offset: 0x00027B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286239, XrefRangeEnd = 286241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PrepareView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000299D4 File Offset: 0x00027BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286241, XrefRangeEnd = 286247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultiColumnTreeViewController.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002E0C File Offset: 0x0000100C
		public MultiColumnTreeViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00029A10 File Offset: 0x00027C10
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00002E15 File Offset: 0x00001015
		public unsafe MultiColumnController m_ColumnController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeViewController.NativeFieldInfoPtr_m_ColumnController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiColumnController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiColumnTreeViewController.NativeFieldInfoPtr_m_ColumnController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnController;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_get_columnController_Public_get_MultiColumnController_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_header_Internal_get_MultiColumnCollectionHeader_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Columns_SortColumnDescriptions_List_1_SortColumnDescription_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_MakeItem_Protected_Virtual_VisualElement_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_BindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_UnbindItem_Protected_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Protected_Virtual_Void_VisualElement_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_PrepareView_Protected_Virtual_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
	}
}
