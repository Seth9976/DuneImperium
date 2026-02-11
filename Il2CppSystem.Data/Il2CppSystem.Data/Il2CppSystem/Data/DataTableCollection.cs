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
	// Token: 0x02000041 RID: 65
	public sealed class DataTableCollection : InternalDataCollectionBase
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x000273F4 File Offset: 0x000255F4
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableCollection()
		{
			Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr);
			DataTableCollection.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_dataSet");
			DataTableCollection.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_list");
			DataTableCollection.NativeFieldInfoPtr__defaultNameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_defaultNameIndex");
			DataTableCollection.NativeFieldInfoPtr__delayedAddRangeTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_delayedAddRangeTables");
			DataTableCollection.NativeFieldInfoPtr__onCollectionChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_onCollectionChangedDelegate");
			DataTableCollection.NativeFieldInfoPtr__onCollectionChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_onCollectionChangingDelegate");
			DataTableCollection.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "s_objectTypeCount");
			DataTableCollection.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, "_objectID");
			DataTableCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664488);
			DataTableCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664489);
			DataTableCollection.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664490);
			DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664491);
			DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664492);
			DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664493);
			DataTableCollection.NativeMethodInfoPtr_GetTable_Internal_DataTable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664494);
			DataTableCollection.NativeMethodInfoPtr_GetTableSmart_Internal_DataTable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664495);
			DataTableCollection.NativeMethodInfoPtr_Add_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664496);
			DataTableCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664497);
			DataTableCollection.NativeMethodInfoPtr_AssignName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664498);
			DataTableCollection.NativeMethodInfoPtr_BaseAdd_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664499);
			DataTableCollection.NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataTable_Int32_Il2CppReferenceArray_1_DataTable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664500);
			DataTableCollection.NativeMethodInfoPtr_BaseRemove_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664501);
			DataTableCollection.NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664502);
			DataTableCollection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664503);
			DataTableCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664504);
			DataTableCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664505);
			DataTableCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664506);
			DataTableCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664507);
			DataTableCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664508);
			DataTableCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664509);
			DataTableCollection.NativeMethodInfoPtr_ReplaceFromInference_Internal_Void_List_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664510);
			DataTableCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664511);
			DataTableCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664512);
			DataTableCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664513);
			DataTableCollection.NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664514);
			DataTableCollection.NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664515);
			DataTableCollection.NativeMethodInfoPtr_RegisterName_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664516);
			DataTableCollection.NativeMethodInfoPtr_Remove_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664517);
			DataTableCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr, 100664518);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00027730 File Offset: 0x00025930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901414, RefRangeEnd = 901415, XrefRangeStart = 901390, XrefRangeEnd = 901414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableCollection(DataSet dataSet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0002777C File Offset: 0x0002597C
		public unsafe override ArrayList List
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000277BC File Offset: 0x000259BC
		public unsafe int ObjectID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CD RID: 461
		public unsafe DataTable this[int index]
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 901417, RefRangeEnd = 901457, XrefRangeStart = 901415, XrefRangeEnd = 901417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
				}
			}
		}

		// Token: 0x170001CE RID: 462
		public unsafe DataTable this[string name]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 901459, RefRangeEnd = 901466, XrefRangeStart = 901457, XrefRangeEnd = 901459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
				}
			}
		}

		// Token: 0x170001CF RID: 463
		public unsafe DataTable this[string name, string tableNamespace]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 901468, RefRangeEnd = 901484, XrefRangeStart = 901466, XrefRangeEnd = 901468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tableNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000278F8 File Offset: 0x00025AF8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 901490, RefRangeEnd = 901499, XrefRangeStart = 901484, XrefRangeEnd = 901490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable GetTable(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_GetTable_Internal_DataTable_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0002795C File Offset: 0x00025B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901505, RefRangeEnd = 901509, XrefRangeStart = 901499, XrefRangeEnd = 901505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable GetTableSmart(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_GetTableSmart_Internal_DataTable_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000279C0 File Offset: 0x00025BC0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 901538, RefRangeEnd = 901550, XrefRangeStart = 901509, XrefRangeEnd = 901538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Add_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00027A04 File Offset: 0x00025C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901550, XrefRangeEnd = 901551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayAdd(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_ArrayAdd_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00027A48 File Offset: 0x00025C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901551, XrefRangeEnd = 901564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AssignName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_AssignName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00027A80 File Offset: 0x00025C80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901599, RefRangeEnd = 901601, XrefRangeStart = 901564, XrefRangeEnd = 901599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseAdd(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_BaseAdd_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00027AC4 File Offset: 0x00025CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901601, XrefRangeEnd = 901605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseGroupSwitch(Il2CppReferenceArray<DataTable> oldArray, int oldLength, Il2CppReferenceArray<DataTable> newArray, int newLength)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataTable_Int32_Il2CppReferenceArray_1_DataTable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00027B34 File Offset: 0x00025D34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901622, RefRangeEnd = 901625, XrefRangeStart = 901605, XrefRangeEnd = 901622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseRemove(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_BaseRemove_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00027B78 File Offset: 0x00025D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901684, RefRangeEnd = 901685, XrefRangeStart = 901625, XrefRangeEnd = 901684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRemove(DataTable table, bool fThrowException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fThrowException;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00027BD4 File Offset: 0x00025DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901715, RefRangeEnd = 901716, XrefRangeStart = 901685, XrefRangeEnd = 901715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00027C08 File Offset: 0x00025E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901716, XrefRangeEnd = 901717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00027C58 File Offset: 0x00025E58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901723, RefRangeEnd = 901727, XrefRangeStart = 901717, XrefRangeEnd = 901723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tableNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkProperty;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseSensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00027CD4 File Offset: 0x00025ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901730, RefRangeEnd = 901731, XrefRangeStart = 901727, XrefRangeEnd = 901730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00027D30 File Offset: 0x00025F30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901733, RefRangeEnd = 901737, XrefRangeStart = 901731, XrefRangeEnd = 901733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00027D80 File Offset: 0x00025F80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901738, RefRangeEnd = 901741, XrefRangeStart = 901737, XrefRangeEnd = 901738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string tableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00027DD0 File Offset: 0x00025FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901742, RefRangeEnd = 901745, XrefRangeStart = 901741, XrefRangeEnd = 901742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string tableName, string tableNamespace, bool chekforNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tableNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chekforNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00027E40 File Offset: 0x00026040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901746, RefRangeEnd = 901747, XrefRangeStart = 901745, XrefRangeEnd = 901746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceFromInference(List<DataTable> tableList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_ReplaceFromInference_Internal_Void_List_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00027E84 File Offset: 0x00026084
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 901750, RefRangeEnd = 901761, XrefRangeStart = 901747, XrefRangeEnd = 901750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalIndexOf(string tableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00027ED4 File Offset: 0x000260D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901769, RefRangeEnd = 901771, XrefRangeStart = 901761, XrefRangeEnd = 901769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalIndexOf(string tableName, string tableNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tableNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00027F34 File Offset: 0x00026134
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 901775, RefRangeEnd = 901780, XrefRangeStart = 901771, XrefRangeEnd = 901775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MakeName(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00027F78 File Offset: 0x00026178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901789, RefRangeEnd = 901792, XrefRangeStart = 901780, XrefRangeEnd = 901789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00027FBC File Offset: 0x000261BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901801, RefRangeEnd = 901804, XrefRangeStart = 901792, XrefRangeEnd = 901801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00028000 File Offset: 0x00026200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901820, RefRangeEnd = 901823, XrefRangeStart = 901804, XrefRangeEnd = 901820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name, string tbNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tbNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_RegisterName_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00028054 File Offset: 0x00026254
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901849, RefRangeEnd = 901853, XrefRangeStart = 901823, XrefRangeEnd = 901849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_Remove_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00028098 File Offset: 0x00026298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901866, RefRangeEnd = 901867, XrefRangeStart = 901853, XrefRangeEnd = 901866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000040B6 File Offset: 0x000022B6
		public DataTableCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000280DC File Offset: 0x000262DC
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x000040BF File Offset: 0x000022BF
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0002810C File Offset: 0x0002630C
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000040DE File Offset: 0x000022DE
		public unsafe ArrayList _list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x0002813C File Offset: 0x0002633C
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000040FD File Offset: 0x000022FD
		public unsafe int _defaultNameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__defaultNameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__defaultNameIndex)) = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x00028164 File Offset: 0x00026364
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00004118 File Offset: 0x00002318
		public unsafe Il2CppReferenceArray<DataTable> _delayedAddRangeTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__delayedAddRangeTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataTable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__delayedAddRangeTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00028194 File Offset: 0x00026394
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00004137 File Offset: 0x00002337
		public unsafe CollectionChangeEventHandler _onCollectionChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__onCollectionChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__onCollectionChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000281C4 File Offset: 0x000263C4
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00004156 File Offset: 0x00002356
		public unsafe CollectionChangeEventHandler _onCollectionChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__onCollectionChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__onCollectionChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000281F4 File Offset: 0x000263F4
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00004175 File Offset: 0x00002375
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataTableCollection.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataTableCollection.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00028210 File Offset: 0x00026410
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00004183 File Offset: 0x00002383
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataTableCollection.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr__list;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr__defaultNameIndex;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr__delayedAddRangeTables;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr__onCollectionChangedDelegate;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr__onCollectionChangingDelegate;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataTable_Int32_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_DataTable_String_String_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_GetTable_Internal_DataTable_String_String_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_GetTableSmart_Internal_DataTable_String_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_DataTable_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_ArrayAdd_Private_Void_DataTable_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_AssignName_Internal_String_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_BaseAdd_Private_Void_DataTable_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_BaseGroupSwitch_Private_Void_Il2CppReferenceArray_1_DataTable_Int32_Il2CppReferenceArray_1_DataTable_Int32_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_BaseRemove_Private_Void_DataTable_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_CanRemove_Internal_Boolean_DataTable_Boolean_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_String_String_Boolean_Boolean_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_String_Boolean_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_DataTable_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_String_String_Boolean_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceFromInference_Internal_Void_List_1_DataTable_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_String_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_MakeName_Private_String_Int32_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanged_Private_Void_CollectionChangeEventArgs_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanging_Private_Void_CollectionChangeEventArgs_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_RegisterName_Internal_Void_String_String_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_DataTable_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0;
	}
}
