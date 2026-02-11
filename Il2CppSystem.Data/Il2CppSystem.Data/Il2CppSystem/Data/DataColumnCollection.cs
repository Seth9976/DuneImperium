using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x0200002B RID: 43
	public sealed class DataColumnCollection : InternalDataCollectionBase
	{
		// Token: 0x06000532 RID: 1330 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		// Note: this type is marked as 'beforefieldinit'.
		static DataColumnCollection()
		{
			Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataColumnCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr);
			DataColumnCollection.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_table");
			DataColumnCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_list");
			DataColumnCollection.NativeFieldInfoPtr__defaultNameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_defaultNameIndex");
			DataColumnCollection.NativeFieldInfoPtr__delayedAddRangeColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_delayedAddRangeColumns");
			DataColumnCollection.NativeFieldInfoPtr__columnFromName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_columnFromName");
			DataColumnCollection.NativeFieldInfoPtr__fInClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_fInClear");
			DataColumnCollection.NativeFieldInfoPtr__columnsImplementingIChangeTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_columnsImplementingIChangeTracking");
			DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIChangeTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_nColumnsImplementingIChangeTracking");
			DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIRevertibleChangeTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "_nColumnsImplementingIRevertibleChangeTracking");
			DataColumnCollection.NativeFieldInfoPtr_CollectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "CollectionChanged");
			DataColumnCollection.NativeFieldInfoPtr_CollectionChanging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "CollectionChanging");
			DataColumnCollection.NativeFieldInfoPtr_ColumnPropertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, "ColumnPropertyChanged");
			DataColumnCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664189);
			DataColumnCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664190);
			DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIChangeTracking_Internal_get_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664191);
			DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIChangeTrackingCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664192);
			DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIRevertibleChangeTrackingCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664193);
			DataColumnCollection.NativeMethodInfoPtr_get_Item_Public_get_DataColumn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664194);
			DataColumnCollection.NativeMethodInfoPtr_get_Item_Public_get_DataColumn_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664195);
			DataColumnCollection.NativeMethodInfoPtr_get_Item_Internal_get_DataColumn_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664196);
			DataColumnCollection.NativeMethodInfoPtr_Add_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664197);
			DataColumnCollection.NativeMethodInfoPtr_AddAt_Internal_Void_Int32_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664198);
			DataColumnCollection.NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664199);
			DataColumnCollection.NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664200);
			DataColumnCollection.NativeMethodInfoPtr_add_ColumnPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664201);
			DataColumnCollection.NativeMethodInfoPtr_remove_ColumnPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664202);
			DataColumnCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664203);
			DataColumnCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_Int32_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664204);
			DataColumnCollection.NativeMethodInfoPtr_ArrayRemove_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664205);
			DataColumnCollection.NativeMethodInfoPtr_AssignName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664206);
			DataColumnCollection.NativeMethodInfoPtr_BaseAdd_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664207);
			DataColumnCollection.NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataColumn_Int32_Il2CppReferenceArray_1_DataColumn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664208);
			DataColumnCollection.NativeMethodInfoPtr_BaseRemove_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664209);
			DataColumnCollection.NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataColumn_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664210);
			DataColumnCollection.NativeMethodInfoPtr_CheckIChangeTracking_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664211);
			DataColumnCollection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664212);
			DataColumnCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664213);
			DataColumnCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664214);
			DataColumnCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664215);
			DataColumnCollection.NativeMethodInfoPtr_IndexOfCaseInsensitive_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664216);
			DataColumnCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664217);
			DataColumnCollection.NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664218);
			DataColumnCollection.NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664219);
			DataColumnCollection.NativeMethodInfoPtr_OnColumnPropertyChanged_Internal_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664220);
			DataColumnCollection.NativeMethodInfoPtr_RegisterColumnName_Internal_Void_String_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664221);
			DataColumnCollection.NativeMethodInfoPtr_CanRegisterName_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664222);
			DataColumnCollection.NativeMethodInfoPtr_Remove_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664223);
			DataColumnCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664224);
			DataColumnCollection.NativeMethodInfoPtr_AddColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664225);
			DataColumnCollection.NativeMethodInfoPtr_RemoveColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr, 100664226);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0001FDD4 File Offset: 0x0001DFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898622, RefRangeEnd = 898623, XrefRangeStart = 898601, XrefRangeEnd = 898622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumnCollection(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataColumnCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001FE20 File Offset: 0x0001E020
		public unsafe override ArrayList List
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001FE60 File Offset: 0x0001E060
		public unsafe Il2CppReferenceArray<DataColumn> ColumnsImplementingIChangeTracking
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIChangeTracking_Internal_get_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
		public unsafe int ColumnsImplementingIChangeTrackingCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIChangeTrackingCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0001FEDC File Offset: 0x0001E0DC
		public unsafe int ColumnsImplementingIRevertibleChangeTrackingCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_ColumnsImplementingIRevertibleChangeTrackingCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014F RID: 335
		public unsafe DataColumn this[int index]
		{
			[CallerCount(82)]
			[CachedScanResults(RefRangeStart = 898625, RefRangeEnd = 898707, XrefRangeStart = 898623, XrefRangeEnd = 898625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_Item_Public_get_DataColumn_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000150 RID: 336
		public unsafe DataColumn this[string name]
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 898712, RefRangeEnd = 898746, XrefRangeStart = 898707, XrefRangeEnd = 898712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_Item_Public_get_DataColumn_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000151 RID: 337
		public unsafe DataColumn this[string name, string ns]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 898751, RefRangeEnd = 898755, XrefRangeStart = 898746, XrefRangeEnd = 898751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_get_Item_Internal_get_DataColumn_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00020018 File Offset: 0x0001E218
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 898756, RefRangeEnd = 898769, XrefRangeStart = 898755, XrefRangeEnd = 898756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_Add_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002005C File Offset: 0x0001E25C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 898797, RefRangeEnd = 898802, XrefRangeStart = 898769, XrefRangeEnd = 898797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAt(int index, DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_AddAt_Internal_Void_Int32_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000200AC File Offset: 0x0001E2AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898806, RefRangeEnd = 898807, XrefRangeStart = 898802, XrefRangeEnd = 898806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CollectionChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000200F0 File Offset: 0x0001E2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898811, RefRangeEnd = 898812, XrefRangeStart = 898807, XrefRangeEnd = 898811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CollectionChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00020134 File Offset: 0x0001E334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898816, RefRangeEnd = 898817, XrefRangeStart = 898812, XrefRangeEnd = 898816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ColumnPropertyChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_add_ColumnPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00020178 File Offset: 0x0001E378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898821, RefRangeEnd = 898822, XrefRangeStart = 898817, XrefRangeEnd = 898821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ColumnPropertyChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_remove_ColumnPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000201BC File Offset: 0x0001E3BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 898824, RefRangeEnd = 898826, XrefRangeStart = 898822, XrefRangeEnd = 898824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayAdd(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00020200 File Offset: 0x0001E400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898826, XrefRangeEnd = 898827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayAdd(int index, DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_Int32_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00020250 File Offset: 0x0001E450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898838, RefRangeEnd = 898839, XrefRangeStart = 898827, XrefRangeEnd = 898838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayRemove(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_ArrayRemove_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00020294 File Offset: 0x0001E494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898839, XrefRangeEnd = 898855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AssignName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_AssignName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000202CC File Offset: 0x0001E4CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 898891, RefRangeEnd = 898894, XrefRangeStart = 898855, XrefRangeEnd = 898891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseAdd(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_BaseAdd_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00020310 File Offset: 0x0001E510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898894, XrefRangeEnd = 898900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseGroupSwitch(Il2CppReferenceArray<DataColumn> oldArray, int oldLength, Il2CppReferenceArray<DataColumn> newArray, int newLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newArray);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataColumn_Int32_Il2CppReferenceArray_1_DataColumn_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00020380 File Offset: 0x0001E580
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 898910, RefRangeEnd = 898913, XrefRangeStart = 898900, XrefRangeEnd = 898910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseRemove(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_BaseRemove_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000203C4 File Offset: 0x0001E5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898968, RefRangeEnd = 898969, XrefRangeStart = 898913, XrefRangeEnd = 898968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRemove(DataColumn column, bool fThrowException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fThrowException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataColumn_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00020420 File Offset: 0x0001E620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898969, XrefRangeEnd = 898970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIChangeTracking(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_CheckIChangeTracking_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00020464 File Offset: 0x0001E664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898987, RefRangeEnd = 898988, XrefRangeStart = 898970, XrefRangeEnd = 898987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00020498 File Offset: 0x0001E698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898991, RefRangeEnd = 898992, XrefRangeStart = 898988, XrefRangeEnd = 898991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x000204E8 File Offset: 0x0001E6E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 898995, RefRangeEnd = 899000, XrefRangeStart = 898992, XrefRangeEnd = 898995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name, bool caseSensitive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseSensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00020544 File Offset: 0x0001E744
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 899007, RefRangeEnd = 899017, XrefRangeStart = 899000, XrefRangeEnd = 899007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string columnName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(columnName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00020594 File Offset: 0x0001E794
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 899022, RefRangeEnd = 899025, XrefRangeStart = 899017, XrefRangeEnd = 899022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfCaseInsensitive(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_IndexOfCaseInsensitive_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000205E4 File Offset: 0x0001E7E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 899029, RefRangeEnd = 899035, XrefRangeStart = 899025, XrefRangeEnd = 899029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MakeName(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00020628 File Offset: 0x0001E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899035, XrefRangeEnd = 899037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002066C File Offset: 0x0001E86C
		[CallerCount(0)]
		public unsafe void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000206B0 File Offset: 0x0001E8B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 899038, RefRangeEnd = 899040, XrefRangeStart = 899037, XrefRangeEnd = 899038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_OnColumnPropertyChanged_Internal_Void_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000206F4 File Offset: 0x0001E8F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 899048, RefRangeEnd = 899052, XrefRangeStart = 899040, XrefRangeEnd = 899048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterColumnName(string name, DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_RegisterColumnName_Internal_Void_String_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00020748 File Offset: 0x0001E948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899055, RefRangeEnd = 899056, XrefRangeStart = 899052, XrefRangeEnd = 899055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_CanRegisterName_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00020798 File Offset: 0x0001E998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 899068, RefRangeEnd = 899069, XrefRangeStart = 899056, XrefRangeEnd = 899068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_Remove_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000207DC File Offset: 0x0001E9DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 899079, RefRangeEnd = 899084, XrefRangeStart = 899069, XrefRangeEnd = 899079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00020820 File Offset: 0x0001EA20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 899095, RefRangeEnd = 899100, XrefRangeStart = 899084, XrefRangeEnd = 899095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_AddColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00020864 File Offset: 0x0001EA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 899100, XrefRangeEnd = 899111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataColumn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataColumnCollection.NativeMethodInfoPtr_RemoveColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00003733 File Offset: 0x00001933
		public DataColumnCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000208A8 File Offset: 0x0001EAA8
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000373C File Offset: 0x0000193C
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000208D8 File Offset: 0x0001EAD8
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0000375B File Offset: 0x0000195B
		public unsafe ArrayList _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00020908 File Offset: 0x0001EB08
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000377A File Offset: 0x0000197A
		public unsafe int _defaultNameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__defaultNameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__defaultNameIndex)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00020930 File Offset: 0x0001EB30
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00003795 File Offset: 0x00001995
		public unsafe Il2CppReferenceArray<DataColumn> _delayedAddRangeColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__delayedAddRangeColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__delayedAddRangeColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00020960 File Offset: 0x0001EB60
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000037B4 File Offset: 0x000019B4
		public unsafe Dictionary<string, DataColumn> _columnFromName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__columnFromName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__columnFromName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00020990 File Offset: 0x0001EB90
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000037D3 File Offset: 0x000019D3
		public unsafe bool _fInClear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__fInClear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__fInClear)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000209B8 File Offset: 0x0001EBB8
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000037EE File Offset: 0x000019EE
		public unsafe Il2CppReferenceArray<DataColumn> _columnsImplementingIChangeTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__columnsImplementingIChangeTracking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__columnsImplementingIChangeTracking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000209E8 File Offset: 0x0001EBE8
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0000380D File Offset: 0x00001A0D
		public unsafe int _nColumnsImplementingIChangeTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIChangeTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIChangeTracking)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00020A10 File Offset: 0x0001EC10
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00003828 File Offset: 0x00001A28
		public unsafe int _nColumnsImplementingIRevertibleChangeTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIRevertibleChangeTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr__nColumnsImplementingIRevertibleChangeTracking)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00020A38 File Offset: 0x0001EC38
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00003843 File Offset: 0x00001A43
		public unsafe CollectionChangeEventHandler CollectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_CollectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_CollectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00020A68 File Offset: 0x0001EC68
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x00003862 File Offset: 0x00001A62
		public unsafe CollectionChangeEventHandler CollectionChanging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_CollectionChanging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_CollectionChanging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00020A98 File Offset: 0x0001EC98
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00003881 File Offset: 0x00001A81
		public unsafe CollectionChangeEventHandler ColumnPropertyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_ColumnPropertyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataColumnCollection.NativeFieldInfoPtr_ColumnPropertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr__defaultNameIndex;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr__delayedAddRangeColumns;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr__columnFromName;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr__fInClear;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr__columnsImplementingIChangeTracking;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr__nColumnsImplementingIChangeTracking;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr__nColumnsImplementingIRevertibleChangeTracking;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_CollectionChanged;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_CollectionChanging;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_ColumnPropertyChanged;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnsImplementingIChangeTracking_Internal_get_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnsImplementingIChangeTrackingCount_Internal_get_Int32_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnsImplementingIRevertibleChangeTrackingCount_Internal_get_Int32_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataColumn_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataColumn_String_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_DataColumn_String_String_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_DataColumn_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_AddAt_Internal_Void_Int32_DataColumn_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_add_ColumnPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_remove_ColumnPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAdd_Private_Void_DataColumn_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAdd_Private_Void_Int32_DataColumn_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_ArrayRemove_Private_Void_DataColumn_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_AssignName_Internal_String_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_BaseAdd_Private_Void_DataColumn_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataColumn_Int32_Il2CppReferenceArray_1_DataColumn_Int32_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_BaseRemove_Private_Void_DataColumn_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataColumn_Boolean_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_CheckIChangeTracking_Private_Void_DataColumn_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfCaseInsensitive_Internal_Int32_String_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_MakeName_Private_String_Int32_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnPropertyChanged_Internal_Void_CollectionChangeEventArgs_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_RegisterColumnName_Internal_Void_String_DataColumn_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_CanRegisterName_Internal_Boolean_String_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_DataColumn_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_AddColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_RemoveColumnsImplementingIChangeTrackingList_Private_Void_DataColumn_0;
	}
}
