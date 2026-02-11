using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000027 RID: 39
	public class BaseListViewController : CollectionViewController
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00025A68 File Offset: 0x00023C68
		// Note: this type is marked as 'beforefieldinit'.
		static BaseListViewController()
		{
			Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseListViewController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr);
			BaseListViewController.NativeFieldInfoPtr_itemsSourceSizeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, "itemsSourceSizeChanged");
			BaseListViewController.NativeFieldInfoPtr_itemsAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, "itemsAdded");
			BaseListViewController.NativeFieldInfoPtr_itemsRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, "itemsRemoved");
			BaseListViewController.NativeMethodInfoPtr_add_itemsSourceSizeChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663631);
			BaseListViewController.NativeMethodInfoPtr_remove_itemsSourceSizeChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663632);
			BaseListViewController.NativeMethodInfoPtr_add_itemsAdded_Public_add_Void_Action_1_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663633);
			BaseListViewController.NativeMethodInfoPtr_remove_itemsAdded_Public_rem_Void_Action_1_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663634);
			BaseListViewController.NativeMethodInfoPtr_add_itemsRemoved_Public_add_Void_Action_1_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663635);
			BaseListViewController.NativeMethodInfoPtr_remove_itemsRemoved_Public_rem_Void_Action_1_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663636);
			BaseListViewController.NativeMethodInfoPtr_get_baseListView_Protected_get_BaseListView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663637);
			BaseListViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663638);
			BaseListViewController.NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableListViewItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663639);
			BaseListViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663640);
			BaseListViewController.NativeMethodInfoPtr_NeedsDragHandle_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663641);
			BaseListViewController.NativeMethodInfoPtr_AddItems_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663642);
			BaseListViewController.NativeMethodInfoPtr_Move_Public_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663643);
			BaseListViewController.NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663644);
			BaseListViewController.NativeMethodInfoPtr_RemoveItems_Public_Virtual_New_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663645);
			BaseListViewController.NativeMethodInfoPtr_RemoveItems_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663646);
			BaseListViewController.NativeMethodInfoPtr_ClearItems_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663647);
			BaseListViewController.NativeMethodInfoPtr_RaiseOnSizeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663648);
			BaseListViewController.NativeMethodInfoPtr_RaiseItemsAdded_Protected_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663649);
			BaseListViewController.NativeMethodInfoPtr_RaiseItemsRemoved_Protected_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663650);
			BaseListViewController.NativeMethodInfoPtr_AddToArray_Private_Static_Array_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663651);
			BaseListViewController.NativeMethodInfoPtr_RemoveFromArray_Private_Static_Array_Array_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663652);
			BaseListViewController.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663653);
			BaseListViewController.NativeMethodInfoPtr_EnsureItemSourceCanBeResized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663654);
			BaseListViewController.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663655);
			BaseListViewController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Type_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr, 100663656);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00025CDC File Offset: 0x00023EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284977, XrefRangeEnd = 284981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_itemsSourceSizeChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_add_itemsSourceSizeChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00025D20 File Offset: 0x00023F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284981, XrefRangeEnd = 284985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_itemsSourceSizeChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_remove_itemsSourceSizeChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00025D64 File Offset: 0x00023F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284985, XrefRangeEnd = 284990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_itemsAdded(Action<IEnumerable<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_add_itemsAdded_Public_add_Void_Action_1_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00025DA8 File Offset: 0x00023FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284990, XrefRangeEnd = 284995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_itemsAdded(Action<IEnumerable<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_remove_itemsAdded_Public_rem_Void_Action_1_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00025DEC File Offset: 0x00023FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284995, XrefRangeEnd = 285000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_itemsRemoved(Action<IEnumerable<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_add_itemsRemoved_Public_add_Void_Action_1_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00025E30 File Offset: 0x00024030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285000, XrefRangeEnd = 285005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_itemsRemoved(Action<IEnumerable<int>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_remove_itemsRemoved_Public_rem_Void_Action_1_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00025E74 File Offset: 0x00024074
		public unsafe BaseListView baseListView
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 285006, RefRangeEnd = 285014, XrefRangeStart = 285005, XrefRangeEnd = 285006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_get_baseListView_Protected_get_BaseListView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseListView>(intPtr3) : null;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00025EB4 File Offset: 0x000240B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285014, XrefRangeEnd = 285033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeMakeItem(ReusableCollectionItem reusableItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00025F04 File Offset: 0x00024104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285070, RefRangeEnd = 285072, XrefRangeStart = 285033, XrefRangeEnd = 285070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostInitRegistration(ReusableListViewItem listItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableListViewItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00025F48 File Offset: 0x00024148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285072, XrefRangeEnd = 285096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reusableItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00025FA4 File Offset: 0x000241A4
		[CallerCount(0)]
		public unsafe virtual bool NeedsDragHandle(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_NeedsDragHandle_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00025FF8 File Offset: 0x000241F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285096, XrefRangeEnd = 285161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItems(int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_AddItems_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00026044 File Offset: 0x00024244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285161, XrefRangeEnd = 285175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Move(int index, int newIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_Move_Public_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002609C File Offset: 0x0002429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285175, XrefRangeEnd = 285191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000260E8 File Offset: 0x000242E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285191, XrefRangeEnd = 285209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItems(List<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_RemoveItems_Public_Virtual_New_Void_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00026138 File Offset: 0x00024338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285209, XrefRangeEnd = 285227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItems(int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_RemoveItems_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00026184 File Offset: 0x00024384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285227, XrefRangeEnd = 285235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseListViewController.NativeMethodInfoPtr_ClearItems_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000261C0 File Offset: 0x000243C0
		[CallerCount(0)]
		public unsafe void RaiseOnSizeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_RaiseOnSizeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000261F4 File Offset: 0x000243F4
		[CallerCount(0)]
		public unsafe void RaiseItemsAdded(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_RaiseItemsAdded_Protected_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00026238 File Offset: 0x00024438
		[CallerCount(0)]
		public unsafe void RaiseItemsRemoved(IEnumerable<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(indices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_RaiseItemsRemoved_Protected_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0002627C File Offset: 0x0002447C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285235, XrefRangeEnd = 285244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array AddToArray(Array source, int itemCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_AddToArray_Private_Static_Array_Array_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000262D0 File Offset: 0x000244D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285257, RefRangeEnd = 285258, XrefRangeStart = 285244, XrefRangeEnd = 285257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array RemoveFromArray(Array source, List<int> indicesToRemove)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicesToRemove);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_RemoveFromArray_Private_Static_Array_Array_List_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00026328 File Offset: 0x00024528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285258, XrefRangeEnd = 285267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Swap(int lhs, int rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00026374 File Offset: 0x00024574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285273, RefRangeEnd = 285276, XrefRangeStart = 285267, XrefRangeEnd = 285273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureItemSourceCanBeResized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_EnsureItemSourceCanBeResized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000263A8 File Offset: 0x000245A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseListViewController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseListViewController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000263E4 File Offset: 0x000245E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285276, XrefRangeEnd = 285278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Type_PDM_0(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseListViewController.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Type_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public BaseListViewController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00026428 File Offset: 0x00024628
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00002BE9 File Offset: 0x00000DE9
		public unsafe Action itemsSourceSizeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsSourceSizeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsSourceSizeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00026458 File Offset: 0x00024658
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00002C08 File Offset: 0x00000E08
		public unsafe Action<IEnumerable<int>> itemsAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00026488 File Offset: 0x00024688
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002C27 File Offset: 0x00000E27
		public unsafe Action<IEnumerable<int>> itemsRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IEnumerable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseListViewController.NativeFieldInfoPtr_itemsRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeFieldInfoPtr_itemsSourceSizeChanged;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_itemsAdded;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_itemsRemoved;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_add_itemsSourceSizeChanged_Public_add_Void_Action_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_remove_itemsSourceSizeChanged_Public_rem_Void_Action_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_add_itemsAdded_Public_add_Void_Action_1_IEnumerable_1_Int32_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_remove_itemsAdded_Public_rem_Void_Action_1_IEnumerable_1_Int32_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_add_itemsRemoved_Public_add_Void_Action_1_IEnumerable_1_Int32_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_remove_itemsRemoved_Public_rem_Void_Action_1_IEnumerable_1_Int32_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_get_baseListView_Protected_get_BaseListView_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMakeItem_Internal_Virtual_Void_ReusableCollectionItem_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_PostInitRegistration_Internal_Void_ReusableListViewItem_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBindItem_Internal_Virtual_Void_ReusableCollectionItem_Int32_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_NeedsDragHandle_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_AddItems_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItems_Public_Virtual_New_Void_List_1_Int32_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItems_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Public_Virtual_New_Void_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnSizeChanged_Protected_Void_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_RaiseItemsAdded_Protected_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_RaiseItemsRemoved_Protected_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_AddToArray_Private_Static_Array_Array_Int32_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromArray_Private_Static_Array_Array_List_1_Int32_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Void_Int32_Int32_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_EnsureItemSourceCanBeResized_Private_Void_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Type_PDM_0;
	}
}
