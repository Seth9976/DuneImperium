using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000044 RID: 68
	public sealed class DataTablePropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x0002840C File Offset: 0x0002660C
		// Note: this type is marked as 'beforefieldinit'.
		static DataTablePropertyDescriptor()
		{
			Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTablePropertyDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr);
			DataTablePropertyDescriptor.NativeFieldInfoPtr__Table_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, "<Table>k__BackingField");
			DataTablePropertyDescriptor.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664522);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664523);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664524);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664525);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664526);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664527);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664528);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664529);
			DataTablePropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTablePropertyDescriptor>.NativeClassPtr, 100664530);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00028504 File Offset: 0x00026704
		public unsafe DataTable Table
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_get_Table_Public_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00028544 File Offset: 0x00026744
		public unsafe override Type ComponentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901874, XrefRangeEnd = 901880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00028584 File Offset: 0x00026784
		public unsafe override bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000285C0 File Offset: 0x000267C0
		public unsafe override Type PropertyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901880, XrefRangeEnd = 901886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00028600 File Offset: 0x00026800
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00028650 File Offset: 0x00026850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901886, XrefRangeEnd = 901896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000286A0 File Offset: 0x000268A0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000286E4 File Offset: 0x000268E4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValue(Object component, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00028738 File Offset: 0x00026938
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSerializeValue(Object component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTablePropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000041F6 File Offset: 0x000023F6
		public DataTablePropertyDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00028788 File Offset: 0x00026988
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x000041FF File Offset: 0x000023FF
		public unsafe DataTable _Table_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTablePropertyDescriptor.NativeFieldInfoPtr__Table_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTablePropertyDescriptor.NativeFieldInfoPtr__Table_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr__Table_k__BackingField;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_get_Table_Public_get_DataTable_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
	}
}
