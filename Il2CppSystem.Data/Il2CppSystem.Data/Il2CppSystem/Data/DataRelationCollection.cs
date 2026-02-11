using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000030 RID: 48
	public class DataRelationCollection : InternalDataCollectionBase
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x00023218 File Offset: 0x00021418
		// Note: this type is marked as 'beforefieldinit'.
		static DataRelationCollection()
		{
			Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataRelationCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr);
			DataRelationCollection.NativeFieldInfoPtr__inTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "_inTransition");
			DataRelationCollection.NativeFieldInfoPtr__defaultNameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "_defaultNameIndex");
			DataRelationCollection.NativeFieldInfoPtr__onCollectionChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "_onCollectionChangedDelegate");
			DataRelationCollection.NativeFieldInfoPtr__onCollectionChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "_onCollectionChangingDelegate");
			DataRelationCollection.NativeFieldInfoPtr_s_objectTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "s_objectTypeCount");
			DataRelationCollection.NativeFieldInfoPtr__objectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "_objectID");
			DataRelationCollection.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664313);
			DataRelationCollection.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664314);
			DataRelationCollection.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664315);
			DataRelationCollection.NativeMethodInfoPtr_Add_Public_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664316);
			DataRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_New_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664317);
			DataRelationCollection.NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664318);
			DataRelationCollection.NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664319);
			DataRelationCollection.NativeMethodInfoPtr_AssignName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664320);
			DataRelationCollection.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664321);
			DataRelationCollection.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664322);
			DataRelationCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664323);
			DataRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Abstract_Virtual_New_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664324);
			DataRelationCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664325);
			DataRelationCollection.NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664326);
			DataRelationCollection.NativeMethodInfoPtr_OnCollectionChanging_Protected_Virtual_New_Void_CollectionChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664327);
			DataRelationCollection.NativeMethodInfoPtr_RegisterName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664328);
			DataRelationCollection.NativeMethodInfoPtr_Remove_Public_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664329);
			DataRelationCollection.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664330);
			DataRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_New_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664331);
			DataRelationCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664332);
			DataRelationCollection.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, 100664333);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00023464 File Offset: 0x00021664
		public unsafe int ObjectID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018D RID: 397
		public unsafe virtual DataRelation this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		public unsafe virtual DataRelation this[string name]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00023554 File Offset: 0x00021754
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 900177, RefRangeEnd = 900188, XrefRangeStart = 900146, XrefRangeEnd = 900177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_Add_Public_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00023598 File Offset: 0x00021798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900203, RefRangeEnd = 900204, XrefRangeStart = 900188, XrefRangeEnd = 900203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCore(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_New_Void_DataRelation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000235E8 File Offset: 0x000217E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900222, RefRangeEnd = 900224, XrefRangeStart = 900204, XrefRangeEnd = 900222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CollectionChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0002362C File Offset: 0x0002182C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900242, RefRangeEnd = 900244, XrefRangeStart = 900224, XrefRangeEnd = 900242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CollectionChanged(CollectionChangeEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00023670 File Offset: 0x00021870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900244, XrefRangeEnd = 900245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AssignName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_AssignName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000236A8 File Offset: 0x000218A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900270, RefRangeEnd = 900271, XrefRangeStart = 900245, XrefRangeEnd = 900270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000236E4 File Offset: 0x000218E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900271, XrefRangeEnd = 900272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0002373C File Offset: 0x0002193C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 900275, RefRangeEnd = 900280, XrefRangeStart = 900272, XrefRangeEnd = 900275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalIndexOf(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0002378C File Offset: 0x0002198C
		[CallerCount(0)]
		public unsafe virtual DataSet GetDataSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Abstract_Virtual_New_DataSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000237D8 File Offset: 0x000219D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 900284, RefRangeEnd = 900289, XrefRangeStart = 900280, XrefRangeEnd = 900284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string MakeName(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_MakeName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0002381C File Offset: 0x00021A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900289, XrefRangeEnd = 900298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_CollectionChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0002386C File Offset: 0x00021A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900298, XrefRangeEnd = 900307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ccevent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_OnCollectionChanging_Protected_Virtual_New_Void_CollectionChangeEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000238BC File Offset: 0x00021ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900319, RefRangeEnd = 900320, XrefRangeStart = 900307, XrefRangeEnd = 900319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_RegisterName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00023900 File Offset: 0x00021B00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 900341, RefRangeEnd = 900345, XrefRangeStart = 900320, XrefRangeEnd = 900341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_Remove_Public_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00023944 File Offset: 0x00021B44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900351, RefRangeEnd = 900353, XrefRangeStart = 900345, XrefRangeEnd = 900351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00023984 File Offset: 0x00021B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900365, RefRangeEnd = 900366, XrefRangeStart = 900353, XrefRangeEnd = 900365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCore(DataRelation relation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_New_Void_DataRelation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000239D4 File Offset: 0x00021BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900378, RefRangeEnd = 900379, XrefRangeStart = 900366, XrefRangeEnd = 900378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00023A18 File Offset: 0x00021C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 900386, RefRangeEnd = 900388, XrefRangeStart = 900379, XrefRangeEnd = 900386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRelationCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public DataRelationCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00023A54 File Offset: 0x00021C54
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public unsafe DataRelation _inTransition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__inTransition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__inTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00023A84 File Offset: 0x00021C84
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00003BDF File Offset: 0x00001DDF
		public unsafe int _defaultNameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__defaultNameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__defaultNameIndex)) = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00023AAC File Offset: 0x00021CAC
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00003BFA File Offset: 0x00001DFA
		public unsafe CollectionChangeEventHandler _onCollectionChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__onCollectionChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__onCollectionChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00023ADC File Offset: 0x00021CDC
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00003C19 File Offset: 0x00001E19
		public unsafe CollectionChangeEventHandler _onCollectionChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__onCollectionChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__onCollectionChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00023B0C File Offset: 0x00021D0C
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00003C38 File Offset: 0x00001E38
		public unsafe static int s_objectTypeCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DataRelationCollection.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataRelationCollection.NativeFieldInfoPtr_s_objectTypeCount, (void*)(&value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00023B28 File Offset: 0x00021D28
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00003C46 File Offset: 0x00001E46
		public unsafe int _objectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__objectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.NativeFieldInfoPtr__objectID)) = value;
			}
		}

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr__inTransition;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr__defaultNameIndex;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr__onCollectionChangedDelegate;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr__onCollectionChangingDelegate;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_s_objectTypeCount;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr__objectID;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectID_Internal_get_Int32_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_Int32_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_DataRelation_String_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_DataRelation_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_AddCore_Protected_Virtual_New_Void_DataRelation_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_add_CollectionChanged_Public_add_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_remove_CollectionChanged_Public_rem_Void_CollectionChangeEventHandler_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_AssignName_Internal_String_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_String_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_InternalIndexOf_Internal_Int32_String_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_GetDataSet_Protected_Abstract_Virtual_New_DataSet_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_MakeName_Private_String_Int32_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_CollectionChangeEventArgs_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanging_Protected_Virtual_New_Void_CollectionChangeEventArgs_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_RegisterName_Internal_Void_String_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_DataRelation_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCore_Protected_Virtual_New_Void_DataRelation_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterName_Internal_Void_String_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020000DD RID: 221
		public sealed class DataTableRelationCollection : DataRelationCollection
		{
			// Token: 0x06001471 RID: 5233 RVA: 0x00061C70 File Offset: 0x0005FE70
			// Note: this type is marked as 'beforefieldinit'.
			static DataTableRelationCollection()
			{
				Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "DataTableRelationCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr);
				DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, "_table");
				DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__relations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, "_relations");
				DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__fParentCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, "_fParentCollection");
				DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr_RelationPropertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, "RelationPropertyChanged");
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664334);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664335);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_EnsureDataSet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664336);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664337);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664338);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664339);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_add_RelationPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664340);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_remove_RelationPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664341);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_AddCache_Private_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664342);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664343);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_RemoveCache_Private_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664344);
				DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr, 100664345);
			}

			// Token: 0x06001472 RID: 5234 RVA: 0x00061DDC File Offset: 0x0005FFDC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 900006, RefRangeEnd = 900011, XrefRangeStart = 899996, XrefRangeEnd = 900006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataTableRelationCollection(DataTable table, bool fParentCollection)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelationCollection.DataTableRelationCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fParentCollection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x06001473 RID: 5235 RVA: 0x00061E38 File Offset: 0x00060038
			public unsafe override ArrayList List
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
				}
			}

			// Token: 0x06001474 RID: 5236 RVA: 0x00061E78 File Offset: 0x00060078
			[CallerCount(0)]
			public unsafe void EnsureDataSet()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_EnsureDataSet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001475 RID: 5237 RVA: 0x00061EAC File Offset: 0x000600AC
			[CallerCount(0)]
			public unsafe override DataSet GetDataSet()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}

			// Token: 0x170004A6 RID: 1190
			public unsafe override DataRelation this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900011, XrefRangeEnd = 900013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
					}
				}
			}

			// Token: 0x170004A7 RID: 1191
			public unsafe override DataRelation this[string name]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900013, XrefRangeEnd = 900015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06001478 RID: 5240 RVA: 0x00061F88 File Offset: 0x00060188
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 900019, RefRangeEnd = 900021, XrefRangeStart = 900015, XrefRangeEnd = 900019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void add_RelationPropertyChanged(CollectionChangeEventHandler value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_add_RelationPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001479 RID: 5241 RVA: 0x00061FCC File Offset: 0x000601CC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 900025, RefRangeEnd = 900027, XrefRangeStart = 900021, XrefRangeEnd = 900025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void remove_RelationPropertyChanged(CollectionChangeEventHandler value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_remove_RelationPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147A RID: 5242 RVA: 0x00062010 File Offset: 0x00060210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900027, XrefRangeEnd = 900028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddCache(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_AddCache_Private_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147B RID: 5243 RVA: 0x00062054 File Offset: 0x00060254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900028, XrefRangeEnd = 900031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddCore(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147C RID: 5244 RVA: 0x00062098 File Offset: 0x00060298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900031, XrefRangeEnd = 900033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveCache(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_RemoveCache_Private_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147D RID: 5245 RVA: 0x000620DC File Offset: 0x000602DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900033, XrefRangeEnd = 900037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveCore(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataTableRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600147E RID: 5246 RVA: 0x00007B27 File Offset: 0x00005D27
			public DataTableRelationCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x0600147F RID: 5247 RVA: 0x00062120 File Offset: 0x00060320
			// (set) Token: 0x06001480 RID: 5248 RVA: 0x00007B30 File Offset: 0x00005D30
			public unsafe DataTable _table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__table);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x06001481 RID: 5249 RVA: 0x00062150 File Offset: 0x00060350
			// (set) Token: 0x06001482 RID: 5250 RVA: 0x00007B4F File Offset: 0x00005D4F
			public unsafe ArrayList _relations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__relations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__relations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x06001483 RID: 5251 RVA: 0x00062180 File Offset: 0x00060380
			// (set) Token: 0x06001484 RID: 5252 RVA: 0x00007B6E File Offset: 0x00005D6E
			public unsafe bool _fParentCollection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__fParentCollection);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr__fParentCollection)) = value;
				}
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x06001485 RID: 5253 RVA: 0x000621A8 File Offset: 0x000603A8
			// (set) Token: 0x06001486 RID: 5254 RVA: 0x00007B89 File Offset: 0x00005D89
			public unsafe CollectionChangeEventHandler RelationPropertyChanged
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr_RelationPropertyChanged);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollectionChangeEventHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataTableRelationCollection.NativeFieldInfoPtr_RelationPropertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010FE RID: 4350
			private static readonly IntPtr NativeFieldInfoPtr__table;

			// Token: 0x040010FF RID: 4351
			private static readonly IntPtr NativeFieldInfoPtr__relations;

			// Token: 0x04001100 RID: 4352
			private static readonly IntPtr NativeFieldInfoPtr__fParentCollection;

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeFieldInfoPtr_RelationPropertyChanged;

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0;

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0;

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeMethodInfoPtr_EnsureDataSet_Private_Void_0;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeMethodInfoPtr_add_RelationPropertyChanged_Internal_add_Void_CollectionChangeEventHandler_0;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeMethodInfoPtr_remove_RelationPropertyChanged_Internal_rem_Void_CollectionChangeEventHandler_0;

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeMethodInfoPtr_AddCache_Private_Void_DataRelation_0;

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeMethodInfoPtr_RemoveCache_Private_Void_DataRelation_0;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0;
		}

		// Token: 0x020000DE RID: 222
		public sealed class DataSetRelationCollection : DataRelationCollection
		{
			// Token: 0x06001487 RID: 5255 RVA: 0x000621D8 File Offset: 0x000603D8
			// Note: this type is marked as 'beforefieldinit'.
			static DataSetRelationCollection()
			{
				Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataRelationCollection>.NativeClassPtr, "DataSetRelationCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr);
				DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, "_dataSet");
				DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__relations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, "_relations");
				DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__delayLoadingRelations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, "_delayLoadingRelations");
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664346);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664347);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664348);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664349);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664350);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664351);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664352);
				DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr, 100664353);
			}

			// Token: 0x06001488 RID: 5256 RVA: 0x000622E0 File Offset: 0x000604E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 900047, RefRangeEnd = 900048, XrefRangeStart = 900037, XrefRangeEnd = 900047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataSetRelationCollection(DataSet dataSet)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataRelationCollection.DataSetRelationCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x06001489 RID: 5257 RVA: 0x0006232C File Offset: 0x0006052C
			public unsafe override ArrayList List
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
				}
			}

			// Token: 0x0600148A RID: 5258 RVA: 0x0006236C File Offset: 0x0006056C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900048, XrefRangeEnd = 900050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600148B RID: 5259 RVA: 0x000623A0 File Offset: 0x000605A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DataSet GetDataSet()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr3) : null;
			}

			// Token: 0x170004AC RID: 1196
			public unsafe override DataRelation this[int index]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900050, XrefRangeEnd = 900052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
					}
				}
			}

			// Token: 0x170004AD RID: 1197
			public unsafe override DataRelation this[string name]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900052, XrefRangeEnd = 900054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr3) : null;
					}
				}
			}

			// Token: 0x0600148E RID: 5262 RVA: 0x0006247C File Offset: 0x0006067C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900054, XrefRangeEnd = 900119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddCore(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600148F RID: 5263 RVA: 0x000624C0 File Offset: 0x000606C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 900119, XrefRangeEnd = 900146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void RemoveCore(DataRelation relation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataRelationCollection.DataSetRelationCollection.NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001490 RID: 5264 RVA: 0x00007BA8 File Offset: 0x00005DA8
			public DataSetRelationCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004A8 RID: 1192
			// (get) Token: 0x06001491 RID: 5265 RVA: 0x00062504 File Offset: 0x00060704
			// (set) Token: 0x06001492 RID: 5266 RVA: 0x00007BB1 File Offset: 0x00005DB1
			public unsafe DataSet _dataSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__dataSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06001493 RID: 5267 RVA: 0x00062534 File Offset: 0x00060734
			// (set) Token: 0x06001494 RID: 5268 RVA: 0x00007BD0 File Offset: 0x00005DD0
			public unsafe ArrayList _relations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__relations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__relations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x06001495 RID: 5269 RVA: 0x00062564 File Offset: 0x00060764
			// (set) Token: 0x06001496 RID: 5270 RVA: 0x00007BEF File Offset: 0x00005DEF
			public unsafe Il2CppReferenceArray<DataRelation> _delayLoadingRelations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__delayLoadingRelations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRelation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataRelationCollection.DataSetRelationCollection.NativeFieldInfoPtr__delayLoadingRelations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400110E RID: 4366
			private static readonly IntPtr NativeFieldInfoPtr__dataSet;

			// Token: 0x0400110F RID: 4367
			private static readonly IntPtr NativeFieldInfoPtr__relations;

			// Token: 0x04001110 RID: 4368
			private static readonly IntPtr NativeFieldInfoPtr__delayLoadingRelations;

			// Token: 0x04001111 RID: 4369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0;

			// Token: 0x04001112 RID: 4370
			private static readonly IntPtr NativeMethodInfoPtr_get_List_Protected_Virtual_get_ArrayList_0;

			// Token: 0x04001113 RID: 4371
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04001114 RID: 4372
			private static readonly IntPtr NativeMethodInfoPtr_GetDataSet_Protected_Virtual_DataSet_0;

			// Token: 0x04001115 RID: 4373
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_Int32_0;

			// Token: 0x04001116 RID: 4374
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_DataRelation_String_0;

			// Token: 0x04001117 RID: 4375
			private static readonly IntPtr NativeMethodInfoPtr_AddCore_Protected_Virtual_Void_DataRelation_0;

			// Token: 0x04001118 RID: 4376
			private static readonly IntPtr NativeMethodInfoPtr_RemoveCore_Protected_Virtual_Void_DataRelation_0;
		}
	}
}
