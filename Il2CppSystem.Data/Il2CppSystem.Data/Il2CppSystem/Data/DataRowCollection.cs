using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data
{
	// Token: 0x02000037 RID: 55
	public sealed class DataRowCollection : InternalDataCollectionBase
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00025F14 File Offset: 0x00024114
		// Note: this type is marked as 'beforefieldinit'.
		static DataRowCollection()
		{
			Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRowCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr);
			DataRowCollection.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, "_table");
			DataRowCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, "_list");
			DataRowCollection.NativeFieldInfoPtr__nullInList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, "_nullInList");
			DataRowCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664436);
			DataRowCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664437);
			DataRowCollection.NativeMethodInfoPtr_get_Item_Public_get_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664438);
			DataRowCollection.NativeMethodInfoPtr_Add_Public_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664439);
			DataRowCollection.NativeMethodInfoPtr_DiffInsertAt_Internal_Void_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664440);
			DataRowCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664441);
			DataRowCollection.NativeMethodInfoPtr_AddWithColumnEvents_Internal_DataRow_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664442);
			DataRowCollection.NativeMethodInfoPtr_ArrayAdd_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664443);
			DataRowCollection.NativeMethodInfoPtr_ArrayInsert_Internal_Void_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664444);
			DataRowCollection.NativeMethodInfoPtr_ArrayClear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664445);
			DataRowCollection.NativeMethodInfoPtr_ArrayRemove_Internal_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664446);
			DataRowCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664447);
			DataRowCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664448);
			DataRowCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, 100664449);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00026098 File Offset: 0x00024298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901193, RefRangeEnd = 901194, XrefRangeStart = 901181, XrefRangeEnd = 901193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRowCollection(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000260E4 File Offset: 0x000242E4
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901194, XrefRangeEnd = 901198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B8 RID: 440
		public unsafe DataRow this[int index]
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 901202, RefRangeEnd = 901217, XrefRangeStart = 901198, XrefRangeEnd = 901202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_get_Item_Public_get_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002616C File Offset: 0x0002436C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901219, RefRangeEnd = 901223, XrefRangeStart = 901217, XrefRangeEnd = 901219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_Add_Public_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000261B0 File Offset: 0x000243B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901232, RefRangeEnd = 901235, XrefRangeStart = 901223, XrefRangeEnd = 901232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiffInsertAt(DataRow row, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_DiffInsertAt_Internal_Void_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00026200 File Offset: 0x00024400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901239, RefRangeEnd = 901242, XrefRangeStart = 901235, XrefRangeEnd = 901239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00026250 File Offset: 0x00024450
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901245, RefRangeEnd = 901247, XrefRangeStart = 901242, XrefRangeEnd = 901245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow AddWithColumnEvents([Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_AddWithColumnEvents_Internal_DataRow_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000262B0 File Offset: 0x000244B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901252, RefRangeEnd = 901254, XrefRangeStart = 901247, XrefRangeEnd = 901252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayAdd(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_ArrayAdd_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000262F4 File Offset: 0x000244F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901254, XrefRangeEnd = 901259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayInsert(DataRow row, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_ArrayInsert_Internal_Void_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00026344 File Offset: 0x00024544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901263, RefRangeEnd = 901264, XrefRangeStart = 901259, XrefRangeEnd = 901263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_ArrayClear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00026378 File Offset: 0x00024578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901272, RefRangeEnd = 901273, XrefRangeStart = 901264, XrefRangeEnd = 901272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayRemove(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_ArrayRemove_Internal_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000263BC File Offset: 0x000245BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901273, XrefRangeEnd = 901277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Array ar, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0002640C File Offset: 0x0002460C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901281, RefRangeEnd = 901282, XrefRangeStart = 901277, XrefRangeEnd = 901281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<DataRow> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002645C File Offset: 0x0002465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901282, XrefRangeEnd = 901286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00003EFB File Offset: 0x000020FB
		public DataRow AddWithColumnEvents(params Object[] values)
		{
			return this.AddWithColumnEvents(new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00003F09 File Offset: 0x00002109
		public DataRowCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0002649C File Offset: 0x0002469C
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00003F12 File Offset: 0x00002112
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x000264CC File Offset: 0x000246CC
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00003F31 File Offset: 0x00002131
		public unsafe DataRowCollection.DataRowTree _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRowCollection.DataRowTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000264FC File Offset: 0x000246FC
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00003F50 File Offset: 0x00002150
		public unsafe int _nullInList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__nullInList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRowCollection.NativeFieldInfoPtr__nullInList)) = value;
			}
		}

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr__nullInList;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataRow_Int32_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_DataRow_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr_DiffInsertAt_Internal_Void_DataRow_Int32_0;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_DataRow_0;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeMethodInfoPtr_AddWithColumnEvents_Internal_DataRow_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAdd_Internal_Void_DataRow_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr_ArrayInsert_Internal_Void_DataRow_Int32_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr_ArrayClear_Internal_Void_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_ArrayRemove_Internal_Void_DataRow_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_DataRow_Int32_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

		// Token: 0x020000DF RID: 223
		public sealed class DataRowTree : RBTree<DataRow>
		{
			// Token: 0x06001497 RID: 5271 RVA: 0x00062594 File Offset: 0x00060794
			// Note: this type is marked as 'beforefieldinit'.
			static DataRowTree()
			{
				Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataRowCollection>.NativeClassPtr, "DataRowTree");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr);
				DataRowCollection.DataRowTree.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr, 100664450);
				DataRowCollection.DataRowTree.NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_DataRow_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr, 100664451);
				DataRowCollection.DataRowTree.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_DataRow_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr, 100664452);
			}

			// Token: 0x06001498 RID: 5272 RVA: 0x000625FC File Offset: 0x000607FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901172, XrefRangeEnd = 901175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataRowTree()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRowCollection.DataRowTree>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.DataRowTree.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001499 RID: 5273 RVA: 0x00062638 File Offset: 0x00060838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901175, XrefRangeEnd = 901178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int CompareNode(DataRow record1, DataRow record2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(record1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(record2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.DataRowTree.NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_DataRow_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600149A RID: 5274 RVA: 0x00062698 File Offset: 0x00060898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901178, XrefRangeEnd = 901181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int CompareSateliteTreeNode(DataRow record1, DataRow record2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(record1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(record2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRowCollection.DataRowTree.NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_DataRow_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600149B RID: 5275 RVA: 0x00007C0E File Offset: 0x00005E0E
			public DataRowTree(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001119 RID: 4377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400111A RID: 4378
			private static readonly IntPtr NativeMethodInfoPtr_CompareNode_Protected_Virtual_Int32_DataRow_DataRow_0;

			// Token: 0x0400111B RID: 4379
			private static readonly IntPtr NativeMethodInfoPtr_CompareSateliteTreeNode_Protected_Virtual_Int32_DataRow_DataRow_0;
		}
	}
}
