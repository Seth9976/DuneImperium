using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000110 RID: 272
	public class IBindingList : Il2CppObjectBase
	{
		// Token: 0x060010FF RID: 4351 RVA: 0x0005CBB4 File Offset: 0x0005ADB4
		// Note: this type is marked as 'beforefieldinit'.
		static IBindingList()
		{
			Il2CppClassPointerStore<IBindingList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "IBindingList");
			IBindingList.NativeMethodInfoPtr_get_AllowNew_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665762);
			IBindingList.NativeMethodInfoPtr_AddNew_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665763);
			IBindingList.NativeMethodInfoPtr_get_AllowEdit_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665764);
			IBindingList.NativeMethodInfoPtr_get_AllowRemove_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665765);
			IBindingList.NativeMethodInfoPtr_get_SupportsChangeNotification_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665766);
			IBindingList.NativeMethodInfoPtr_get_SupportsSearching_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665767);
			IBindingList.NativeMethodInfoPtr_get_SupportsSorting_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665768);
			IBindingList.NativeMethodInfoPtr_get_IsSorted_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665769);
			IBindingList.NativeMethodInfoPtr_get_SortProperty_Public_Abstract_Virtual_New_get_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665770);
			IBindingList.NativeMethodInfoPtr_get_SortDirection_Public_Abstract_Virtual_New_get_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665771);
			IBindingList.NativeMethodInfoPtr_AddIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665772);
			IBindingList.NativeMethodInfoPtr_ApplySort_Public_Abstract_Virtual_New_Void_PropertyDescriptor_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665773);
			IBindingList.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Int32_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665774);
			IBindingList.NativeMethodInfoPtr_RemoveIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665775);
			IBindingList.NativeMethodInfoPtr_RemoveSort_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBindingList>.NativeClassPtr, 100665776);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0005CD08 File Offset: 0x0005AF08
		public unsafe virtual bool AllowNew
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_AllowNew_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0005CD50 File Offset: 0x0005AF50
		[CallerCount(0)]
		public unsafe virtual Object AddNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_AddNew_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0005CD9C File Offset: 0x0005AF9C
		public unsafe virtual bool AllowEdit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_AllowEdit_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0005CDE4 File Offset: 0x0005AFE4
		public unsafe virtual bool AllowRemove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_AllowRemove_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0005CE2C File Offset: 0x0005B02C
		public unsafe virtual bool SupportsChangeNotification
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_SupportsChangeNotification_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0005CE74 File Offset: 0x0005B074
		public unsafe virtual bool SupportsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_SupportsSearching_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0005CEBC File Offset: 0x0005B0BC
		public unsafe virtual bool SupportsSorting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_SupportsSorting_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0005CF04 File Offset: 0x0005B104
		public unsafe virtual bool IsSorted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_IsSorted_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0005CF4C File Offset: 0x0005B14C
		public unsafe virtual PropertyDescriptor SortProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_SortProperty_Public_Abstract_Virtual_New_get_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0005CF98 File Offset: 0x0005B198
		public unsafe virtual ListSortDirection SortDirection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_get_SortDirection_Public_Abstract_Virtual_New_get_ListSortDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005CFE0 File Offset: 0x0005B1E0
		[CallerCount(0)]
		public unsafe virtual void AddIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_AddIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005D030 File Offset: 0x0005B230
		[CallerCount(0)]
		public unsafe virtual void ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_ApplySort_Public_Abstract_Virtual_New_Void_PropertyDescriptor_ListSortDirection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005D08C File Offset: 0x0005B28C
		[CallerCount(0)]
		public unsafe virtual int Find(PropertyDescriptor property, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Int32_PropertyDescriptor_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0005D0F8 File Offset: 0x0005B2F8
		[CallerCount(0)]
		public unsafe virtual void RemoveIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_RemoveIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0005D148 File Offset: 0x0005B348
		[CallerCount(0)]
		public unsafe virtual void RemoveSort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBindingList.NativeMethodInfoPtr_RemoveSort_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00008075 File Offset: 0x00006275
		public IBindingList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowNew_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_AddNew_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowEdit_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowRemove_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsChangeNotification_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSearching_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSorting_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSorted_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_get_SortProperty_Public_Abstract_Virtual_New_get_PropertyDescriptor_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_SortDirection_Public_Abstract_Virtual_New_get_ListSortDirection_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_AddIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_ApplySort_Public_Abstract_Virtual_New_Void_PropertyDescriptor_ListSortDirection_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Int32_PropertyDescriptor_Object_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_RemoveIndex_Public_Abstract_Virtual_New_Void_PropertyDescriptor_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSort_Public_Abstract_Virtual_New_Void_0;
	}
}
