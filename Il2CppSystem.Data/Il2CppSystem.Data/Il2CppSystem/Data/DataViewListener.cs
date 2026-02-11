using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000047 RID: 71
	public sealed class DataViewListener : Object
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x0002AD30 File Offset: 0x00028F30
		// Note: this type is marked as 'beforefieldinit'.
		static DataViewListener()
		{
			Il2CppClassPointerStore<DataViewListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataViewListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr);
			DataViewListener.NativeFieldInfoPtr__dvWeak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, "_dvWeak");
			DataViewListener.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, "_table");
			DataViewListener.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, "_index");
			DataViewListener.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, "_objectID");
			DataViewListener.NativeMethodInfoPtr__ctor_Internal_Void_DataView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664621);
			DataViewListener.NativeMethodInfoPtr_ChildRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664622);
			DataViewListener.NativeMethodInfoPtr_ParentRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664623);
			DataViewListener.NativeMethodInfoPtr_ColumnCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664624);
			DataViewListener.NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664625);
			DataViewListener.NativeMethodInfoPtr_IndexListChanged_Internal_Void_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664626);
			DataViewListener.NativeMethodInfoPtr_RegisterMetaDataEvents_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664627);
			DataViewListener.NativeMethodInfoPtr_UnregisterMetaDataEvents_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664628);
			DataViewListener.NativeMethodInfoPtr_UnregisterMetaDataEvents_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664629);
			DataViewListener.NativeMethodInfoPtr_RegisterListChangedEvent_Internal_Void_Index_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664630);
			DataViewListener.NativeMethodInfoPtr_UnregisterListChangedEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664631);
			DataViewListener.NativeMethodInfoPtr_CleanUp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664632);
			DataViewListener.NativeMethodInfoPtr_RegisterListener_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr, 100664633);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002AEB4 File Offset: 0x000290B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902594, XrefRangeEnd = 902601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataViewListener(DataView dv)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataViewListener>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr__ctor_Internal_Void_DataView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0002AF00 File Offset: 0x00029100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902601, XrefRangeEnd = 902608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChildRelationCollectionChanged(Object sender, CollectionChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_ChildRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002AF54 File Offset: 0x00029154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902608, XrefRangeEnd = 902615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentRelationCollectionChanged(Object sender, CollectionChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_ParentRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002AFA8 File Offset: 0x000291A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902615, XrefRangeEnd = 902621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColumnCollectionChanged(Object sender, CollectionChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_ColumnCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002AFFC File Offset: 0x000291FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902624, RefRangeEnd = 902625, XrefRangeStart = 902621, XrefRangeEnd = 902624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changedType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackAddRemove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002B05C File Offset: 0x0002925C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902635, RefRangeEnd = 902636, XrefRangeStart = 902625, XrefRangeEnd = 902635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IndexListChanged(ListChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_IndexListChanged_Internal_Void_ListChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002B0A0 File Offset: 0x000292A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902667, RefRangeEnd = 902668, XrefRangeStart = 902636, XrefRangeEnd = 902667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMetaDataEvents(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_RegisterMetaDataEvents_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0002B0E4 File Offset: 0x000292E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902668, XrefRangeEnd = 902669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterMetaDataEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_UnregisterMetaDataEvents_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0002B118 File Offset: 0x00029318
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 902706, RefRangeEnd = 902715, XrefRangeStart = 902669, XrefRangeEnd = 902706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterMetaDataEvents(bool updateListeners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateListeners;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_UnregisterMetaDataEvents_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002B158 File Offset: 0x00029358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902722, RefRangeEnd = 902723, XrefRangeStart = 902715, XrefRangeEnd = 902722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterListChangedEvent(Index index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(index);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_RegisterListChangedEvent_Internal_Void_Index_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002B19C File Offset: 0x0002939C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 902731, RefRangeEnd = 902738, XrefRangeStart = 902723, XrefRangeEnd = 902731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterListChangedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_UnregisterListChangedEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0002B1D0 File Offset: 0x000293D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902738, XrefRangeEnd = 902740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp(bool updateListeners)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateListeners;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_CleanUp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0002B210 File Offset: 0x00029410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 902759, RefRangeEnd = 902760, XrefRangeStart = 902740, XrefRangeEnd = 902759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterListener(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataViewListener.NativeMethodInfoPtr_RegisterListener_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00004546 File Offset: 0x00002746
		public DataViewListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0002B254 File Offset: 0x00029454
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x0000454F File Offset: 0x0000274F
		public unsafe WeakReference _dvWeak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__dvWeak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__dvWeak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0002B284 File Offset: 0x00029484
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000456E File Offset: 0x0000276E
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0002B2B4 File Offset: 0x000294B4
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000458D File Offset: 0x0000278D
		public unsafe Index _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__index);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Index>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__index), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0002B2E4 File Offset: 0x000294E4
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000045AC File Offset: 0x000027AC
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataViewListener.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr__dvWeak;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataView_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_ChildRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_ParentRelationCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_ColumnCollectionChanged_Private_Void_Object_CollectionChangeEventArgs_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_MaintainDataView_Internal_Void_ListChangedType_DataRow_Boolean_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_IndexListChanged_Internal_Void_ListChangedEventArgs_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMetaDataEvents_Internal_Void_DataTable_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterMetaDataEvents_Internal_Void_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterMetaDataEvents_Private_Void_Boolean_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_RegisterListChangedEvent_Internal_Void_Index_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterListChangedEvent_Internal_Void_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_Boolean_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_RegisterListener_Private_Void_DataTable_0;
	}
}
