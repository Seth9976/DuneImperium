using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000068 RID: 104
	public sealed class Merger : Object
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x00033850 File Offset: 0x00031A50
		// Note: this type is marked as 'beforefieldinit'.
		static Merger()
		{
			Il2CppClassPointerStore<Merger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "Merger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merger>.NativeClassPtr);
			Merger.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_dataSet");
			Merger.NativeFieldInfoPtr__dataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_dataTable");
			Merger.NativeFieldInfoPtr__preserveChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_preserveChanges");
			Merger.NativeFieldInfoPtr__missingSchemaAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_missingSchemaAction");
			Merger.NativeFieldInfoPtr__isStandAlonetable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_isStandAlonetable");
			Merger.NativeFieldInfoPtr__IgnoreNSforTableLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merger>.NativeClassPtr, "_IgnoreNSforTableLookup");
			Merger.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664930);
			Merger.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_MissingSchemaAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664931);
			Merger.NativeMethodInfoPtr_MergeDataSet_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664932);
			Merger.NativeMethodInfoPtr_MergeTable_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664933);
			Merger.NativeMethodInfoPtr_MergeTable_Private_Void_DataTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664934);
			Merger.NativeMethodInfoPtr_MergeSchema_Private_DataTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664935);
			Merger.NativeMethodInfoPtr_MergeTableData_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664936);
			Merger.NativeMethodInfoPtr_MergeConstraints_Private_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664937);
			Merger.NativeMethodInfoPtr_MergeConstraints_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664938);
			Merger.NativeMethodInfoPtr_MergeRelation_Private_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664939);
			Merger.NativeMethodInfoPtr_MergeExtendedProperties_Private_Void_PropertyCollection_PropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664940);
			Merger.NativeMethodInfoPtr_GetSrcKey_Private_DataKey_DataTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merger>.NativeClassPtr, 100664941);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000339E8 File Offset: 0x00031BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905219, RefRangeEnd = 905220, XrefRangeStart = 905217, XrefRangeEnd = 905219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Merger(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveChanges;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missingSchemaAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_MissingSchemaAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00033A50 File Offset: 0x00031C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905222, RefRangeEnd = 905223, XrefRangeStart = 905220, XrefRangeEnd = 905222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Merger(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveChanges;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missingSchemaAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_MissingSchemaAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00033AB8 File Offset: 0x00031CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905322, RefRangeEnd = 905323, XrefRangeStart = 905223, XrefRangeEnd = 905322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeDataSet(DataSet source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeDataSet_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00033AFC File Offset: 0x00031CFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905338, RefRangeEnd = 905339, XrefRangeStart = 905323, XrefRangeEnd = 905338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeTable(DataTable src)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeTable_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00033B40 File Offset: 0x00031D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905375, RefRangeEnd = 905376, XrefRangeStart = 905339, XrefRangeEnd = 905375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeTable(DataTable src, DataTable dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeTable_Private_Void_DataTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00033B94 File Offset: 0x00031D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905445, RefRangeEnd = 905446, XrefRangeStart = 905376, XrefRangeEnd = 905445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable MergeSchema(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeSchema_Private_DataTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00033BE4 File Offset: 0x00031DE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905449, RefRangeEnd = 905451, XrefRangeStart = 905446, XrefRangeEnd = 905449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeTableData(DataTable src)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeTableData_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00033C28 File Offset: 0x00031E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905451, XrefRangeEnd = 905454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeConstraints(DataSet source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeConstraints_Private_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00033C6C File Offset: 0x00031E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 905471, RefRangeEnd = 905473, XrefRangeStart = 905454, XrefRangeEnd = 905471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeConstraints(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeConstraints_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00033CB0 File Offset: 0x00031EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 905555, RefRangeEnd = 905556, XrefRangeStart = 905473, XrefRangeEnd = 905555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeRelation(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeRelation_Private_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00033CF4 File Offset: 0x00031EF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 905568, RefRangeEnd = 905574, XrefRangeStart = 905556, XrefRangeEnd = 905568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_MergeExtendedProperties_Private_Void_PropertyCollection_PropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00033D48 File Offset: 0x00031F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 905574, XrefRangeEnd = 905582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataKey GetSrcKey(DataTable src, DataTable dst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merger.NativeMethodInfoPtr_GetSrcKey_Private_DataKey_DataTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DataKey(intPtr);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00005002 File Offset: 0x00003202
		public Merger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00033DA4 File Offset: 0x00031FA4
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000500B File Offset: 0x0000320B
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00033DD4 File Offset: 0x00031FD4
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000502A File Offset: 0x0000322A
		public unsafe DataTable _dataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__dataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__dataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00033E04 File Offset: 0x00032004
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00005049 File Offset: 0x00003249
		public unsafe bool _preserveChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__preserveChanges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__preserveChanges)) = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00033E2C File Offset: 0x0003202C
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005064 File Offset: 0x00003264
		public unsafe MissingSchemaAction _missingSchemaAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__missingSchemaAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__missingSchemaAction)) = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00033E54 File Offset: 0x00032054
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x0000507F File Offset: 0x0000327F
		public unsafe bool _isStandAlonetable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__isStandAlonetable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__isStandAlonetable)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00033E7C File Offset: 0x0003207C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0000509A File Offset: 0x0000329A
		public unsafe bool _IgnoreNSforTableLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__IgnoreNSforTableLookup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merger.NativeFieldInfoPtr__IgnoreNSforTableLookup)) = value;
			}
		}

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr__dataTable;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr__preserveChanges;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr__missingSchemaAction;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr__isStandAlonetable;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNSforTableLookup;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_MissingSchemaAction_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_MissingSchemaAction_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_MergeDataSet_Internal_Void_DataSet_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_MergeTable_Internal_Void_DataTable_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_MergeTable_Private_Void_DataTable_DataTable_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_MergeSchema_Private_DataTable_DataTable_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_MergeTableData_Private_Void_DataTable_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_MergeConstraints_Private_Void_DataSet_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_MergeConstraints_Private_Void_DataTable_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_MergeRelation_Private_Void_DataRelation_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_MergeExtendedProperties_Private_Void_PropertyCollection_PropertyCollection_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_GetSrcKey_Private_DataKey_DataTable_DataTable_0;
	}
}
