using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000024 RID: 36
	public class DetailedLocalizationTable<TEntry> : LocalizationTable where TEntry : TableEntry
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x000104F8 File Offset: 0x0000E6F8
		// Note: this type is marked as 'beforefieldinit'.
		static DetailedLocalizationTable()
		{
			Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "DetailedLocalizationTable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr);
			DetailedLocalizationTable<TEntry>.NativeFieldInfoPtr_m_TableEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, "m_TableEntries");
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663645);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663646);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663647);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663648);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TEntry_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663649);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663650);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Item_Public_get_TEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663651);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_set_Item_Public_set_Void_String_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663652);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateTableEntry_Public_Abstract_Virtual_New_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663653);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateTableEntry_Internal_TEntry_TableEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663654);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateEmpty_Public_Virtual_Void_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663655);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntry_Public_TEntry_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663656);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntry_Public_Virtual_New_TEntry_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663657);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntryFromReference_Public_TEntry_TableEntryReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663658);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_RemoveEntry_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663659);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_RemoveEntry_Public_Virtual_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663660);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntryFromReference_Public_TEntry_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663661);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntry_Public_TEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663662);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntry_Public_Virtual_New_TEntry_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663663);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663664);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663665);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663666);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663667);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663668);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663669);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663670);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CheckForMissingSharedTableDataEntries_Public_IList_1_TEntry_MissingEntryAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663671);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_Int64_byref_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663672);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663673);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int64_TEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663674);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663675);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663676);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663677);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663678);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663679);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663680);
			DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_0_Private_Boolean_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, 100663681);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0001085C File Offset: 0x0000EA5C
		public unsafe virtual ICollection<long> prop_ICollection_1_Int64_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067012, XrefRangeEnd = 1067014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<long>>(intPtr3) : null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001089C File Offset: 0x0000EA9C
		public unsafe virtual ICollection<TEntry> Values
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1067016, RefRangeEnd = 1067019, XrefRangeStart = 1067014, XrefRangeEnd = 1067016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000108DC File Offset: 0x0000EADC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067019, XrefRangeEnd = 1067021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00010918 File Offset: 0x0000EB18
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000082 RID: 130
		public unsafe virtual TEntry this[long key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067021, XrefRangeEnd = 1067023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TEntry_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067023, XrefRangeEnd = 1067039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TEntry).IsValueType)
				{
					TEntry tentry = value;
					intPtr = ((tentry is string) ? IL2CPP.ManagedStringToIl2Cpp(tentry as string) : IL2CPP.Il2CppObjectBaseToPtr(tentry as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x17000083 RID: 131
		public unsafe TEntry this[string keyName]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067039, XrefRangeEnd = 1067040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(keyName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_get_Item_Public_get_TEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067040, XrefRangeEnd = 1067052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(keyName);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TEntry).IsValueType)
				{
					TEntry tentry = value;
					intPtr = ((tentry is string) ? IL2CPP.ManagedStringToIl2Cpp(tentry as string) : IL2CPP.Il2CppObjectBaseToPtr(tentry as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_set_Item_Public_set_Void_String_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00010AFC File Offset: 0x0000ECFC
		[CallerCount(0)]
		public unsafe virtual TEntry CreateTableEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateTableEntry_Public_Abstract_Virtual_New_TEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00010B40 File Offset: 0x0000ED40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067052, XrefRangeEnd = 1067053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntry CreateTableEntry(TableEntryData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateTableEntry_Internal_TEntry_TableEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00010B8C File Offset: 0x0000ED8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067053, XrefRangeEnd = 1067057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateEmpty(TableEntryReference entryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CreateEmpty_Public_Virtual_Void_TableEntryReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067057, XrefRangeEnd = 1067058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntry AddEntry(string key, string localized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntry_Public_TEntry_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00010C3C File Offset: 0x0000EE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067058, XrefRangeEnd = 1067066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TEntry AddEntry(long keyId, string localized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntry_Public_Virtual_New_TEntry_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00010CA0 File Offset: 0x0000EEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067066, XrefRangeEnd = 1067067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntry AddEntryFromReference(TableEntryReference entryReference, string localized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_AddEntryFromReference_Public_TEntry_TableEntryReference_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00010D04 File Offset: 0x0000EF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067067, XrefRangeEnd = 1067068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_RemoveEntry_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00010D54 File Offset: 0x0000EF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067068, XrefRangeEnd = 1067076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveEntry(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_RemoveEntry_Public_Virtual_New_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00010DA8 File Offset: 0x0000EFA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1067076, RefRangeEnd = 1067079, XrefRangeStart = 1067076, XrefRangeEnd = 1067076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntry GetEntryFromReference(TableEntryReference entryReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entryReference));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntryFromReference_Public_TEntry_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TEntry GetEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntry_Public_TEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00010E44 File Offset: 0x0000F044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067079, XrefRangeEnd = 1067080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TEntry GetEntry(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEntry_Public_Virtual_New_TEntry_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00010E98 File Offset: 0x0000F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067080, XrefRangeEnd = 1067081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(long keyId, TEntry value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TEntry).IsValueType)
			{
				TEntry tentry = value;
				intPtr = ((tentry is string) ? IL2CPP.ManagedStringToIl2Cpp(tentry as string) : IL2CPP.Il2CppObjectBaseToPtr(tentry as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00010F20 File Offset: 0x0000F120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067081, XrefRangeEnd = 1067082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<long, TEntry> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00010F68 File Offset: 0x0000F168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067082, XrefRangeEnd = 1067084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00010FB4 File Offset: 0x0000F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067084, XrefRangeEnd = 1067089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsValue(string localized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localized);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00011004 File Offset: 0x0000F204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067089, XrefRangeEnd = 1067090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<long, TEntry> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00011058 File Offset: 0x0000F258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067090, RefRangeEnd = 1067092, XrefRangeStart = 1067090, XrefRangeEnd = 1067090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000110A4 File Offset: 0x0000F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067092, XrefRangeEnd = 1067093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<long, TEntry> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000110F8 File Offset: 0x0000F2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067093, XrefRangeEnd = 1067117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<TEntry> CheckForMissingSharedTableDataEntries(MissingEntryAction action = MissingEntryAction.Nothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CheckForMissingSharedTableDataEntries_Public_IList_1_TEntry_MissingEntryAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<TEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00011144 File Offset: 0x0000F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067117, XrefRangeEnd = 1067119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(long keyId, out TEntry value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TEntry).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_Int64_byref_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TEntry).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TEntry>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000111DC File Offset: 0x0000F3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067119, XrefRangeEnd = 1067123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00011210 File Offset: 0x0000F410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067123, XrefRangeEnd = 1067130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<long, TEntry>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int64_TEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00011260 File Offset: 0x0000F460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067130, XrefRangeEnd = 1067132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<long, TEntry>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<long, TEntry>>>(intPtr3) : null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000112A0 File Offset: 0x0000F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067132, XrefRangeEnd = 1067139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00011324 File Offset: 0x0000F524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067139, XrefRangeEnd = 1067161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00011358 File Offset: 0x0000F558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067161, XrefRangeEnd = 1067198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001138C File Offset: 0x0000F58C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1067203, RefRangeEnd = 1067205, XrefRangeStart = 1067198, XrefRangeEnd = 1067203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DetailedLocalizationTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000113C8 File Offset: 0x0000F5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067205, XrefRangeEnd = 1067206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckForMissingSharedTableDataEntries_b__33_0(KeyValuePair<long, TEntry> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_0_Private_Boolean_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public DetailedLocalizationTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0001141C File Offset: 0x0000F61C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002BEC File Offset: 0x00000DEC
		public unsafe Dictionary<long, TEntry> m_TableEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetailedLocalizationTable<TEntry>.NativeFieldInfoPtr_m_TableEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<long, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DetailedLocalizationTable<TEntry>.NativeFieldInfoPtr_m_TableEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntries;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_Int64_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TEntry_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TEntry_Int64_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int64_TEntry_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_TEntry_String_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_TEntry_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableEntry_Public_Abstract_Virtual_New_TEntry_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableEntry_Internal_TEntry_TableEntryData_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmpty_Public_Virtual_Void_TableEntryReference_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_TEntry_String_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_Virtual_New_TEntry_Int64_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_AddEntryFromReference_Public_TEntry_TableEntryReference_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Public_Boolean_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Public_Virtual_New_Boolean_Int64_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_GetEntryFromReference_Public_TEntry_TableEntryReference_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_TEntry_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Virtual_New_TEntry_Int64_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Int64_TEntry_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_Int64_TEntry_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_Int64_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Int64_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_Int64_TEntry_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_CheckForMissingSharedTableDataEntries_Public_IList_1_TEntry_MissingEntryAction_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_Int64_byref_TEntry_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_Int64_TEntry_Int32_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_Int64_TEntry_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_0_Private_Boolean_KeyValuePair_2_Int64_TEntry_0;

		// Token: 0x02000124 RID: 292
		[ObfuscatedName("UnityEngine.Localization.Tables.DetailedLocalizationTable`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000D1D RID: 3357 RVA: 0x0003A74C File Offset: 0x0003894C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr);
				DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, "<>9");
				DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, "<>9__33_1");
				DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, "<>9__41_0");
				DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, 100663683);
				DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_1_Internal_TEntry_KeyValuePair_2_Int64_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, 100663684);
				DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__OnAfterDeserialize_b__41_0_Internal_Int64_TableEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr, 100663685);
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x0003A82C File Offset: 0x00038A2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DetailedLocalizationTable<TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x0003A868 File Offset: 0x00038A68
			[CallerCount(0)]
			public unsafe TEntry _CheckForMissingSharedTableDataEntries_b__33_1(KeyValuePair<long, TEntry> e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_1_Internal_TEntry_KeyValuePair_2_Int64_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TEntry>(intPtr, false, true);
				}
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x0003A8B8 File Offset: 0x00038AB8
			[CallerCount(0)]
			public unsafe long _OnAfterDeserialize_b__41_0(TableEntryData o)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DetailedLocalizationTable<TEntry>.__c.NativeMethodInfoPtr__OnAfterDeserialize_b__41_0_Internal_Int64_TableEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x00007850 File Offset: 0x00005A50
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0003A908 File Offset: 0x00038B08
			// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00007859 File Offset: 0x00005A59
			public unsafe static DetailedLocalizationTable<TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DetailedLocalizationTable<TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003A930 File Offset: 0x00038B30
			// (set) Token: 0x06000D25 RID: 3365 RVA: 0x0000786B File Offset: 0x00005A6B
			public unsafe static Func<KeyValuePair<long, TEntry>, TEntry> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<long, TEntry>, TEntry>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0003A958 File Offset: 0x00038B58
			// (set) Token: 0x06000D27 RID: 3367 RVA: 0x0000787D File Offset: 0x00005A7D
			public unsafe static Func<TableEntryData, long> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TableEntryData, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DetailedLocalizationTable<TEntry>.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000919 RID: 2329
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400091A RID: 2330
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x0400091B RID: 2331
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400091C RID: 2332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400091D RID: 2333
			private static readonly IntPtr NativeMethodInfoPtr__CheckForMissingSharedTableDataEntries_b__33_1_Internal_TEntry_KeyValuePair_2_Int64_TEntry_0;

			// Token: 0x0400091E RID: 2334
			private static readonly IntPtr NativeMethodInfoPtr__OnAfterDeserialize_b__41_0_Internal_Int64_TableEntryData_0;
		}
	}
}
