using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004CF RID: 1231
	[Serializable]
	public class Hashtable : Object
	{
		// Token: 0x06004BA5 RID: 19365 RVA: 0x0015D798 File Offset: 0x0015B998
		// Note: this type is marked as 'beforefieldinit'.
		static Hashtable()
		{
			Il2CppClassPointerStore<Hashtable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Hashtable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable>.NativeClassPtr);
			Hashtable.NativeFieldInfoPtr_HashPrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashPrime");
			Hashtable.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "InitialSize");
			Hashtable.NativeFieldInfoPtr_LoadFactorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "LoadFactorName");
			Hashtable.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "VersionName");
			Hashtable.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ComparerName");
			Hashtable.NativeFieldInfoPtr_HashCodeProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashCodeProviderName");
			Hashtable.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashSizeName");
			Hashtable.NativeFieldInfoPtr_KeysName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeysName");
			Hashtable.NativeFieldInfoPtr_ValuesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValuesName");
			Hashtable.NativeFieldInfoPtr_KeyComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyComparerName");
			Hashtable.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_buckets");
			Hashtable.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_count");
			Hashtable.NativeFieldInfoPtr__occupancy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_occupancy");
			Hashtable.NativeFieldInfoPtr__loadsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_loadsize");
			Hashtable.NativeFieldInfoPtr__loadFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_loadFactor");
			Hashtable.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_version");
			Hashtable.NativeFieldInfoPtr__isWriterInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_isWriterInProgress");
			Hashtable.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_keys");
			Hashtable.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_values");
			Hashtable.NativeFieldInfoPtr__keycomparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_keycomparer");
			Hashtable.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "_syncRoot");
			Hashtable.NativeFieldInfoPtr_s_serializationInfoTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "s_serializationInfoTable");
			Hashtable.NativeMethodInfoPtr_get_SerializationInfoTable_Private_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674471);
			Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674472);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674473);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674474);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674475);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674476);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674477);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674478);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674479);
			Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674480);
			Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674481);
			Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674482);
			Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674483);
			Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674484);
			Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674485);
			Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674486);
			Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674487);
			Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674488);
			Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674489);
			Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674490);
			Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674491);
			Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674492);
			Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674493);
			Hashtable.NativeMethodInfoPtr_expand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674494);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674495);
			Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674496);
			Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674497);
			Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674498);
			Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674499);
			Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674500);
			Hashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674501);
			Hashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674502);
			Hashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674503);
			Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674504);
			Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674505);
			Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674506);
			Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674507);
			Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674508);
			Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674509);
			Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674510);
			Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674511);
			Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674512);
			Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674513);
			Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, 100674514);
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x0015DCF0 File Offset: 0x0015BEF0
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> SerializationInfoTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416725, XrefRangeEnd = 1416730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_get_SerializationInfoTable_Private_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0015DD24 File Offset: 0x0015BF24
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(bool trash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0015DD6C File Offset: 0x0015BF6C
		[CallerCount(155)]
		[CachedScanResults(RefRangeStart = 1416731, RefRangeEnd = 1416886, XrefRangeStart = 1416730, XrefRangeEnd = 1416731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x0015DDA8 File Offset: 0x0015BFA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1416887, RefRangeEnd = 1416894, XrefRangeStart = 1416886, XrefRangeEnd = 1416887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x0015DDF0 File Offset: 0x0015BFF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1416905, RefRangeEnd = 1416913, XrefRangeStart = 1416894, XrefRangeEnd = 1416905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x0015DE48 File Offset: 0x0015C048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416913, XrefRangeEnd = 1416915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x0015DEB0 File Offset: 0x0015C0B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1416921, RefRangeEnd = 1416923, XrefRangeStart = 1416915, XrefRangeEnd = 1416921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0015DF10 File Offset: 0x0015C110
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1416925, RefRangeEnd = 1416931, XrefRangeStart = 1416923, XrefRangeEnd = 1416925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x0015DF5C File Offset: 0x0015C15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1416933, RefRangeEnd = 1416935, XrefRangeStart = 1416931, XrefRangeEnd = 1416933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x0015DFB8 File Offset: 0x0015C1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416935, XrefRangeEnd = 1416941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadFactor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hcp);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x0015E034 File Offset: 0x0015C234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1416951, RefRangeEnd = 1416953, XrefRangeStart = 1416941, XrefRangeEnd = 1416951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hashtable(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x0015E098 File Offset: 0x0015C298
		[CallerCount(0)]
		public unsafe uint InitHash(Object key, int hashsize, out uint seed, out uint incr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashsize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &seed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &incr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x0015E110 File Offset: 0x0015C310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416953, XrefRangeEnd = 1416954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x0015E170 File Offset: 0x0015C370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1416961, RefRangeEnd = 1416962, XrefRangeStart = 1416954, XrefRangeEnd = 1416961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x0015E1AC File Offset: 0x0015C3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416962, XrefRangeEnd = 1416969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x0015E1F8 File Offset: 0x0015C3F8
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x0015E250 File Offset: 0x0015C450
		[CallerCount(0)]
		public unsafe virtual bool ContainsKey(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x0015E2A8 File Offset: 0x0015C4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416969, XrefRangeEnd = 1416970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyKeys(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0015E2F8 File Offset: 0x0015C4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416970, XrefRangeEnd = 1416975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyEntries(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x0015E348 File Offset: 0x0015C548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416975, XrefRangeEnd = 1416982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x0015E3A4 File Offset: 0x0015C5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416982, XrefRangeEnd = 1416983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyValues(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001382 RID: 4994
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416983, XrefRangeEnd = 1416991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416991, XrefRangeEnd = 1416992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x0015E4B0 File Offset: 0x0015C6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416992, XrefRangeEnd = 1416998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void expand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_expand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x0015E4E4 File Offset: 0x0015C6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416998, XrefRangeEnd = 1417000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x0015E518 File Offset: 0x0015C718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417000, XrefRangeEnd = 1417002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_UpdateVersion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x0015E54C File Offset: 0x0015C74C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1417012, RefRangeEnd = 1417015, XrefRangeStart = 1417002, XrefRangeEnd = 1417012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void rehash(int newsize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newsize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_rehash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x0015E58C File Offset: 0x0015C78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417015, XrefRangeEnd = 1417021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x0015E5CC File Offset: 0x0015C7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417021, XrefRangeEnd = 1417027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x0015E618 File Offset: 0x0015C818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417027, XrefRangeEnd = 1417031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHash(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x0015E670 File Offset: 0x0015C870
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x0015E6B8 File Offset: 0x0015C8B8
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x0015E700 File Offset: 0x0015C900
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x0015E748 File Offset: 0x0015C948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417031, XrefRangeEnd = 1417035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool KeyEquals(Object item, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x0015E7B4 File Offset: 0x0015C9B4
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417035, XrefRangeEnd = 1417041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x0015E800 File Offset: 0x0015CA00
		public unsafe virtual ICollection Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417041, XrefRangeEnd = 1417047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x0015E84C File Offset: 0x0015CA4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1417068, RefRangeEnd = 1417071, XrefRangeStart = 1417047, XrefRangeEnd = 1417068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(Object key, Object nvalue, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x0015E8B0 File Offset: 0x0015CAB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417074, RefRangeEnd = 1417075, XrefRangeStart = 1417071, XrefRangeEnd = 1417074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void putEntry(Il2CppReferenceArray<Hashtable.bucket> newBuckets, Object key, Object nvalue, int hashcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newBuckets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nvalue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x0015E924 File Offset: 0x0015CB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1417075, RefRangeEnd = 1417076, XrefRangeStart = 1417075, XrefRangeEnd = 1417075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x0015E974 File Offset: 0x0015CB74
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417076, XrefRangeEnd = 1417081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x0015E9C0 File Offset: 0x0015CBC0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x0015EA08 File Offset: 0x0015CC08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1417086, RefRangeEnd = 1417091, XrefRangeStart = 1417081, XrefRangeEnd = 1417086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable Synchronized(Hashtable table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x0015EA4C File Offset: 0x0015CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417091, XrefRangeEnd = 1417166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x0015EAB0 File Offset: 0x0015CCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417166, XrefRangeEnd = 1417291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x0001BA1A File Offset: 0x00019C1A
		public Hashtable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0015EB00 File Offset: 0x0015CD00
		// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x0001BA23 File Offset: 0x00019C23
		public unsafe static int HashPrime
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashPrime, (void*)(&value));
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0015EB1C File Offset: 0x0015CD1C
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x0001BA31 File Offset: 0x00019C31
		public unsafe static int InitialSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_InitialSize, (void*)(&value));
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0015EB38 File Offset: 0x0015CD38
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x0001BA3F File Offset: 0x00019C3F
		public unsafe static string LoadFactorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_LoadFactorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x0015EB58 File Offset: 0x0015CD58
		// (set) Token: 0x06004BDA RID: 19418 RVA: 0x0001BA51 File Offset: 0x00019C51
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x0015EB78 File Offset: 0x0015CD78
		// (set) Token: 0x06004BDC RID: 19420 RVA: 0x0001BA63 File Offset: 0x00019C63
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x0015EB98 File Offset: 0x0015CD98
		// (set) Token: 0x06004BDE RID: 19422 RVA: 0x0001BA75 File Offset: 0x00019C75
		public unsafe static string HashCodeProviderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashCodeProviderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x0015EBB8 File Offset: 0x0015CDB8
		// (set) Token: 0x06004BE0 RID: 19424 RVA: 0x0001BA87 File Offset: 0x00019C87
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06004BE1 RID: 19425 RVA: 0x0015EBD8 File Offset: 0x0015CDD8
		// (set) Token: 0x06004BE2 RID: 19426 RVA: 0x0001BA99 File Offset: 0x00019C99
		public unsafe static string KeysName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeysName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeysName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x0015EBF8 File Offset: 0x0015CDF8
		// (set) Token: 0x06004BE4 RID: 19428 RVA: 0x0001BAAB File Offset: 0x00019CAB
		public unsafe static string ValuesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_ValuesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_ValuesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x0015EC18 File Offset: 0x0015CE18
		// (set) Token: 0x06004BE6 RID: 19430 RVA: 0x0001BABD File Offset: 0x00019CBD
		public unsafe static string KeyComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_KeyComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06004BE7 RID: 19431 RVA: 0x0015EC38 File Offset: 0x0015CE38
		// (set) Token: 0x06004BE8 RID: 19432 RVA: 0x0001BACF File Offset: 0x00019CCF
		public unsafe Il2CppReferenceArray<Hashtable.bucket> _buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Hashtable.bucket>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06004BE9 RID: 19433 RVA: 0x0015EC68 File Offset: 0x0015CE68
		// (set) Token: 0x06004BEA RID: 19434 RVA: 0x0001BAEE File Offset: 0x00019CEE
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x0015EC90 File Offset: 0x0015CE90
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x0001BB09 File Offset: 0x00019D09
		public unsafe int _occupancy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__occupancy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__occupancy)) = value;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x0015ECB8 File Offset: 0x0015CEB8
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x0001BB24 File Offset: 0x00019D24
		public unsafe int _loadsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__loadsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__loadsize)) = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x0015ECE0 File Offset: 0x0015CEE0
		// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x0001BB3F File Offset: 0x00019D3F
		public unsafe float _loadFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__loadFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__loadFactor)) = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x0015ED08 File Offset: 0x0015CF08
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x0001BB5A File Offset: 0x00019D5A
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x0015ED30 File Offset: 0x0015CF30
		// (set) Token: 0x06004BF4 RID: 19444 RVA: 0x0001BB75 File Offset: 0x00019D75
		public unsafe bool _isWriterInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__isWriterInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__isWriterInProgress)) = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x0015ED58 File Offset: 0x0015CF58
		// (set) Token: 0x06004BF6 RID: 19446 RVA: 0x0001BB90 File Offset: 0x00019D90
		public unsafe ICollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x0015ED88 File Offset: 0x0015CF88
		// (set) Token: 0x06004BF8 RID: 19448 RVA: 0x0001BBAF File Offset: 0x00019DAF
		public unsafe ICollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x0015EDB8 File Offset: 0x0015CFB8
		// (set) Token: 0x06004BFA RID: 19450 RVA: 0x0001BBCE File Offset: 0x00019DCE
		public unsafe IEqualityComparer _keycomparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__keycomparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06004BFB RID: 19451 RVA: 0x0015EDE8 File Offset: 0x0015CFE8
		// (set) Token: 0x06004BFC RID: 19452 RVA: 0x0001BBED File Offset: 0x00019DED
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x0015EE18 File Offset: 0x0015D018
		// (set) Token: 0x06004BFE RID: 19454 RVA: 0x0001BC0C File Offset: 0x00019E0C
		public unsafe static ConditionalWeakTable<Object, SerializationInfo> s_serializationInfoTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hashtable.NativeFieldInfoPtr_s_serializationInfoTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, SerializationInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hashtable.NativeFieldInfoPtr_s_serializationInfoTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003DEA RID: 15850
		private static readonly IntPtr NativeFieldInfoPtr_HashPrime;

		// Token: 0x04003DEB RID: 15851
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x04003DEC RID: 15852
		private static readonly IntPtr NativeFieldInfoPtr_LoadFactorName;

		// Token: 0x04003DED RID: 15853
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x04003DEE RID: 15854
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x04003DEF RID: 15855
		private static readonly IntPtr NativeFieldInfoPtr_HashCodeProviderName;

		// Token: 0x04003DF0 RID: 15856
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x04003DF1 RID: 15857
		private static readonly IntPtr NativeFieldInfoPtr_KeysName;

		// Token: 0x04003DF2 RID: 15858
		private static readonly IntPtr NativeFieldInfoPtr_ValuesName;

		// Token: 0x04003DF3 RID: 15859
		private static readonly IntPtr NativeFieldInfoPtr_KeyComparerName;

		// Token: 0x04003DF4 RID: 15860
		private static readonly IntPtr NativeFieldInfoPtr__buckets;

		// Token: 0x04003DF5 RID: 15861
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04003DF6 RID: 15862
		private static readonly IntPtr NativeFieldInfoPtr__occupancy;

		// Token: 0x04003DF7 RID: 15863
		private static readonly IntPtr NativeFieldInfoPtr__loadsize;

		// Token: 0x04003DF8 RID: 15864
		private static readonly IntPtr NativeFieldInfoPtr__loadFactor;

		// Token: 0x04003DF9 RID: 15865
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003DFA RID: 15866
		private static readonly IntPtr NativeFieldInfoPtr__isWriterInProgress;

		// Token: 0x04003DFB RID: 15867
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04003DFC RID: 15868
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04003DFD RID: 15869
		private static readonly IntPtr NativeFieldInfoPtr__keycomparer;

		// Token: 0x04003DFE RID: 15870
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003DFF RID: 15871
		private static readonly IntPtr NativeFieldInfoPtr_s_serializationInfoTable;

		// Token: 0x04003E00 RID: 15872
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializationInfoTable_Private_Static_get_ConditionalWeakTable_2_Object_SerializationInfo_0;

		// Token: 0x04003E01 RID: 15873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04003E02 RID: 15874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E03 RID: 15875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003E04 RID: 15876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_0;

		// Token: 0x04003E05 RID: 15877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IEqualityComparer_0;

		// Token: 0x04003E06 RID: 15878
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHashCodeProvider_IComparer_0;

		// Token: 0x04003E07 RID: 15879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_IHashCodeProvider_IComparer_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly IntPtr NativeMethodInfoPtr_InitHash_Private_UInt32_Object_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x04003E0C RID: 15884
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_Object_0;

		// Token: 0x04003E0D RID: 15885
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x04003E0F RID: 15887
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003E10 RID: 15888
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04003E11 RID: 15889
		private static readonly IntPtr NativeMethodInfoPtr_CopyKeys_Private_Void_Array_Int32_0;

		// Token: 0x04003E12 RID: 15890
		private static readonly IntPtr NativeMethodInfoPtr_CopyEntries_Private_Void_Array_Int32_0;

		// Token: 0x04003E13 RID: 15891
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003E14 RID: 15892
		private static readonly IntPtr NativeMethodInfoPtr_CopyValues_Private_Void_Array_Int32_0;

		// Token: 0x04003E15 RID: 15893
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Object_Object_0;

		// Token: 0x04003E16 RID: 15894
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly IntPtr NativeMethodInfoPtr_expand_Private_Void_0;

		// Token: 0x04003E18 RID: 15896
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Private_Void_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly IntPtr NativeMethodInfoPtr_rehash_Private_Void_Int32_0;

		// Token: 0x04003E1B RID: 15899
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003E1C RID: 15900
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IDictionaryEnumerator_0;

		// Token: 0x04003E1D RID: 15901
		private static readonly IntPtr NativeMethodInfoPtr_GetHash_Protected_Virtual_New_Int32_Object_0;

		// Token: 0x04003E1E RID: 15902
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003E1F RID: 15903
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003E20 RID: 15904
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003E21 RID: 15905
		private static readonly IntPtr NativeMethodInfoPtr_KeyEquals_Protected_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_ICollection_0;

		// Token: 0x04003E23 RID: 15907
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_New_get_ICollection_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_Void_Object_Object_Boolean_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly IntPtr NativeMethodInfoPtr_putEntry_Private_Void_Il2CppReferenceArray_1_bucket_Object_Object_Int32_0;

		// Token: 0x04003E26 RID: 15910
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04003E28 RID: 15912
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_Hashtable_Hashtable_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x020006F1 RID: 1777
		public sealed class bucket : ValueType
		{
			// Token: 0x06005E75 RID: 24181 RVA: 0x001AB018 File Offset: 0x001A9218
			// Note: this type is marked as 'beforefieldinit'.
			static bucket()
			{
				Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "bucket");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr);
				Hashtable.bucket.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "key");
				Hashtable.bucket.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "val");
				Hashtable.bucket.NativeFieldInfoPtr_hash_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr, "hash_coll");
			}

			// Token: 0x06005E76 RID: 24182 RVA: 0x000227CB File Offset: 0x000209CB
			public bucket(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005E77 RID: 24183 RVA: 0x000227D4 File Offset: 0x000209D4
			public bucket()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.bucket>.NativeClassPtr))
			{
			}

			// Token: 0x17001847 RID: 6215
			// (get) Token: 0x06005E78 RID: 24184 RVA: 0x001AB080 File Offset: 0x001A9280
			// (set) Token: 0x06005E79 RID: 24185 RVA: 0x000227E6 File Offset: 0x000209E6
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001848 RID: 6216
			// (get) Token: 0x06005E7A RID: 24186 RVA: 0x001AB0B0 File Offset: 0x001A92B0
			// (set) Token: 0x06005E7B RID: 24187 RVA: 0x00022805 File Offset: 0x00020A05
			public unsafe Object val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_val), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001849 RID: 6217
			// (get) Token: 0x06005E7C RID: 24188 RVA: 0x001AB0E0 File Offset: 0x001A92E0
			// (set) Token: 0x06005E7D RID: 24189 RVA: 0x00022824 File Offset: 0x00020A24
			public unsafe int hash_coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.bucket.NativeFieldInfoPtr_hash_coll)) = value;
				}
			}

			// Token: 0x04004CF8 RID: 19704
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04004CF9 RID: 19705
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04004CFA RID: 19706
			private static readonly IntPtr NativeFieldInfoPtr_hash_coll;
		}

		// Token: 0x020006F2 RID: 1778
		[Serializable]
		public class KeyCollection : Object
		{
			// Token: 0x06005E7E RID: 24190 RVA: 0x001AB108 File Offset: 0x001A9308
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "KeyCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr);
				Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, "_hashtable");
				Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674515);
				Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674516);
				Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674517);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674518);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674519);
				Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr, 100674520);
			}

			// Token: 0x06005E7F RID: 24191 RVA: 0x001AB1C0 File Offset: 0x001A93C0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.KeyCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E80 RID: 24192 RVA: 0x001AB20C File Offset: 0x001A940C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416618, XrefRangeEnd = 1416621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E81 RID: 24193 RVA: 0x001AB268 File Offset: 0x001A9468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416621, XrefRangeEnd = 1416627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x1700184B RID: 6219
			// (get) Token: 0x06005E82 RID: 24194 RVA: 0x001AB2B4 File Offset: 0x001A94B4
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416627, XrefRangeEnd = 1416628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700184C RID: 6220
			// (get) Token: 0x06005E83 RID: 24195 RVA: 0x001AB2FC File Offset: 0x001A94FC
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700184D RID: 6221
			// (get) Token: 0x06005E84 RID: 24196 RVA: 0x001AB348 File Offset: 0x001A9548
			public unsafe virtual int Count
			{
				[CallerCount(39)]
				[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E85 RID: 24197 RVA: 0x0002283F File Offset: 0x00020A3F
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700184A RID: 6218
			// (get) Token: 0x06005E86 RID: 24198 RVA: 0x001AB390 File Offset: 0x001A9590
			// (set) Token: 0x06005E87 RID: 24199 RVA: 0x00022848 File Offset: 0x00020A48
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.KeyCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CFB RID: 19707
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x04004CFC RID: 19708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x04004CFD RID: 19709
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004CFE RID: 19710
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004CFF RID: 19711
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004D00 RID: 19712
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x04004D01 RID: 19713
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x020006F3 RID: 1779
		[Serializable]
		public class ValueCollection : Object
		{
			// Token: 0x06005E88 RID: 24200 RVA: 0x001AB3C0 File Offset: 0x001A95C0
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "ValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr);
				Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, "_hashtable");
				Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674521);
				Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674522);
				Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674523);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674524);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674525);
				Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr, 100674526);
			}

			// Token: 0x06005E89 RID: 24201 RVA: 0x001AB478 File Offset: 0x001A9678
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(Hashtable hashtable)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.ValueCollection.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E8A RID: 24202 RVA: 0x001AB4C4 File Offset: 0x001A96C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416628, XrefRangeEnd = 1416631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E8B RID: 24203 RVA: 0x001AB520 File Offset: 0x001A9720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416631, XrefRangeEnd = 1416637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x1700184F RID: 6223
			// (get) Token: 0x06005E8C RID: 24204 RVA: 0x001AB56C File Offset: 0x001A976C
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001850 RID: 6224
			// (get) Token: 0x06005E8D RID: 24205 RVA: 0x001AB5B4 File Offset: 0x001A97B4
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001851 RID: 6225
			// (get) Token: 0x06005E8E RID: 24206 RVA: 0x001AB600 File Offset: 0x001A9800
			public unsafe virtual int Count
			{
				[CallerCount(39)]
				[CachedScanResults(RefRangeStart = 320461, RefRangeEnd = 320500, XrefRangeStart = 320461, XrefRangeEnd = 320500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E8F RID: 24207 RVA: 0x00022867 File Offset: 0x00020A67
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700184E RID: 6222
			// (get) Token: 0x06005E90 RID: 24208 RVA: 0x001AB648 File Offset: 0x001A9848
			// (set) Token: 0x06005E91 RID: 24209 RVA: 0x00022870 File Offset: 0x00020A70
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.ValueCollection.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D02 RID: 19714
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x04004D03 RID: 19715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x04004D04 RID: 19716
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

			// Token: 0x04004D05 RID: 19717
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

			// Token: 0x04004D06 RID: 19718
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

			// Token: 0x04004D07 RID: 19719
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

			// Token: 0x04004D08 RID: 19720
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;
		}

		// Token: 0x020006F4 RID: 1780
		[Serializable]
		public class SyncHashtable : Hashtable
		{
			// Token: 0x06005E92 RID: 24210 RVA: 0x001AB678 File Offset: 0x001A9878
			// Note: this type is marked as 'beforefieldinit'.
			static SyncHashtable()
			{
				Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "SyncHashtable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr);
				Hashtable.SyncHashtable.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, "_table");
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674527);
				Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674528);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674529);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674530);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674531);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674532);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674533);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674534);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674535);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674536);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674537);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674538);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674539);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674540);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674541);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674542);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674543);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674544);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674545);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674546);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674547);
				Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr, 100674548);
			}

			// Token: 0x06005E93 RID: 24211 RVA: 0x001AB870 File Offset: 0x001A9A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416637, XrefRangeEnd = 1416639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(Hashtable table)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E94 RID: 24212 RVA: 0x001AB8BC File Offset: 0x001A9ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416639, XrefRangeEnd = 1416645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncHashtable(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.SyncHashtable>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E95 RID: 24213 RVA: 0x001AB920 File Offset: 0x001A9B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416645, XrefRangeEnd = 1416650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001853 RID: 6227
			// (get) Token: 0x06005E96 RID: 24214 RVA: 0x001AB984 File Offset: 0x001A9B84
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416650, XrefRangeEnd = 1416651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001854 RID: 6228
			// (get) Token: 0x06005E97 RID: 24215 RVA: 0x001AB9CC File Offset: 0x001A9BCC
			public unsafe override bool IsReadOnly
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416651, XrefRangeEnd = 1416652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001855 RID: 6229
			// (get) Token: 0x06005E98 RID: 24216 RVA: 0x001ABA14 File Offset: 0x001A9C14
			public unsafe override bool IsFixedSize
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416652, XrefRangeEnd = 1416653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001856 RID: 6230
			// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001ABA5C File Offset: 0x001A9C5C
			public unsafe override bool IsSynchronized
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001857 RID: 6231
			public unsafe override Object this[Object key]
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416653, XrefRangeEnd = 1416654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416654, XrefRangeEnd = 1416658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001858 RID: 6232
			// (get) Token: 0x06005E9C RID: 24220 RVA: 0x001ABB60 File Offset: 0x001A9D60
			public unsafe override Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416658, XrefRangeEnd = 1416659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E9D RID: 24221 RVA: 0x001ABBAC File Offset: 0x001A9DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416659, XrefRangeEnd = 1416663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Add(Object key, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E9E RID: 24222 RVA: 0x001ABC0C File Offset: 0x001A9E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416663, XrefRangeEnd = 1416667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E9F RID: 24223 RVA: 0x001ABC48 File Offset: 0x001A9E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416667, XrefRangeEnd = 1416668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005EA0 RID: 24224 RVA: 0x001ABCA0 File Offset: 0x001A9EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416668, XrefRangeEnd = 1416676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ContainsKey(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005EA1 RID: 24225 RVA: 0x001ABCF8 File Offset: 0x001A9EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416676, XrefRangeEnd = 1416680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int arrayIndex)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EA2 RID: 24226 RVA: 0x001ABD54 File Offset: 0x001A9F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416680, XrefRangeEnd = 1416691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06005EA3 RID: 24227 RVA: 0x001ABDA0 File Offset: 0x001A9FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416691, XrefRangeEnd = 1416692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.SyncHashtable.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005EA4 RID: 24228 RVA: 0x001ABDE0 File Offset: 0x001A9FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IDictionaryEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
			}

			// Token: 0x17001859 RID: 6233
			// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x001ABE2C File Offset: 0x001AA02C
			public unsafe override ICollection Keys
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416692, XrefRangeEnd = 1416696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x1700185A RID: 6234
			// (get) Token: 0x06005EA6 RID: 24230 RVA: 0x001ABE78 File Offset: 0x001AA078
			public unsafe override ICollection Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416696, XrefRangeEnd = 1416700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
				}
			}

			// Token: 0x06005EA7 RID: 24231 RVA: 0x001ABEC4 File Offset: 0x001AA0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416700, XrefRangeEnd = 1416704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Remove(Object key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005EA8 RID: 24232 RVA: 0x001ABF14 File Offset: 0x001AA114
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnDeserialization(Object sender)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.SyncHashtable.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005EA9 RID: 24233 RVA: 0x0002288F File Offset: 0x00020A8F
			public SyncHashtable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001852 RID: 6226
			// (get) Token: 0x06005EAA RID: 24234 RVA: 0x001ABF64 File Offset: 0x001AA164
			// (set) Token: 0x06005EAB RID: 24235 RVA: 0x00022898 File Offset: 0x00020A98
			public unsafe Hashtable _table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.SyncHashtable.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D09 RID: 19721
			private static readonly IntPtr NativeFieldInfoPtr__table;

			// Token: 0x04004D0A RID: 19722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_0;

			// Token: 0x04004D0B RID: 19723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004D0C RID: 19724
			private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004D0D RID: 19725
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04004D0E RID: 19726
			private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

			// Token: 0x04004D0F RID: 19727
			private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_get_Boolean_0;

			// Token: 0x04004D10 RID: 19728
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;

			// Token: 0x04004D11 RID: 19729
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_Object_Object_0;

			// Token: 0x04004D12 RID: 19730
			private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_Object_0;

			// Token: 0x04004D13 RID: 19731
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_get_Object_0;

			// Token: 0x04004D14 RID: 19732
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_Object_Object_0;

			// Token: 0x04004D15 RID: 19733
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04004D16 RID: 19734
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004D17 RID: 19735
			private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004D18 RID: 19736
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x04004D19 RID: 19737
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x04004D1A RID: 19738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004D1B RID: 19739
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IDictionaryEnumerator_0;

			// Token: 0x04004D1C RID: 19740
			private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_get_ICollection_0;

			// Token: 0x04004D1D RID: 19741
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_get_ICollection_0;

			// Token: 0x04004D1E RID: 19742
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_Object_0;

			// Token: 0x04004D1F RID: 19743
			private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;
		}

		// Token: 0x020006F5 RID: 1781
		[Serializable]
		public class HashtableEnumerator : Object
		{
			// Token: 0x06005EAC RID: 24236 RVA: 0x001ABF94 File Offset: 0x001AA194
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableEnumerator()
			{
				Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr);
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_hashtable");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__bucket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_bucket");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_version");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_current");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__getObjectRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_getObjectRetType");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_currentKey");
				Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, "_currentValue");
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674549);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674550);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674551);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674552);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674553);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674554);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674555);
				Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr, 100674556);
			}

			// Token: 0x06005EAD RID: 24237 RVA: 0x001AC0EC File Offset: 0x001AA2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416704, XrefRangeEnd = 1416707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashtableEnumerator(Hashtable hashtable, int getObjRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hashtable.HashtableEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hashtable);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getObjRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EAE RID: 24238 RVA: 0x001AC148 File Offset: 0x001AA348
			[CallerCount(105)]
			[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x17001862 RID: 6242
			// (get) Token: 0x06005EAF RID: 24239 RVA: 0x001AC188 File Offset: 0x001AA388
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005EB0 RID: 24240 RVA: 0x001AC1D4 File Offset: 0x001AA3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416707, XrefRangeEnd = 1416710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001863 RID: 6243
			// (get) Token: 0x06005EB1 RID: 24241 RVA: 0x001AC21C File Offset: 0x001AA41C
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416710, XrefRangeEnd = 1416711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001864 RID: 6244
			// (get) Token: 0x06005EB2 RID: 24242 RVA: 0x001AC260 File Offset: 0x001AA460
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416711, XrefRangeEnd = 1416715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001865 RID: 6245
			// (get) Token: 0x06005EB3 RID: 24243 RVA: 0x001AC2AC File Offset: 0x001AA4AC
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005EB4 RID: 24244 RVA: 0x001AC2F8 File Offset: 0x001AA4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1416715, XrefRangeEnd = 1416725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hashtable.HashtableEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005EB5 RID: 24245 RVA: 0x000228B7 File Offset: 0x00020AB7
			public HashtableEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700185B RID: 6235
			// (get) Token: 0x06005EB6 RID: 24246 RVA: 0x001AC334 File Offset: 0x001AA534
			// (set) Token: 0x06005EB7 RID: 24247 RVA: 0x000228C0 File Offset: 0x00020AC0
			public unsafe Hashtable _hashtable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__hashtable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700185C RID: 6236
			// (get) Token: 0x06005EB8 RID: 24248 RVA: 0x001AC364 File Offset: 0x001AA564
			// (set) Token: 0x06005EB9 RID: 24249 RVA: 0x000228DF File Offset: 0x00020ADF
			public unsafe int _bucket
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__bucket);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__bucket)) = value;
				}
			}

			// Token: 0x1700185D RID: 6237
			// (get) Token: 0x06005EBA RID: 24250 RVA: 0x001AC38C File Offset: 0x001AA58C
			// (set) Token: 0x06005EBB RID: 24251 RVA: 0x000228FA File Offset: 0x00020AFA
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x1700185E RID: 6238
			// (get) Token: 0x06005EBC RID: 24252 RVA: 0x001AC3B4 File Offset: 0x001AA5B4
			// (set) Token: 0x06005EBD RID: 24253 RVA: 0x00022915 File Offset: 0x00020B15
			public unsafe bool _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__current)) = value;
				}
			}

			// Token: 0x1700185F RID: 6239
			// (get) Token: 0x06005EBE RID: 24254 RVA: 0x001AC3DC File Offset: 0x001AA5DC
			// (set) Token: 0x06005EBF RID: 24255 RVA: 0x00022930 File Offset: 0x00020B30
			public unsafe int _getObjectRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__getObjectRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__getObjectRetType)) = value;
				}
			}

			// Token: 0x17001860 RID: 6240
			// (get) Token: 0x06005EC0 RID: 24256 RVA: 0x001AC404 File Offset: 0x001AA604
			// (set) Token: 0x06005EC1 RID: 24257 RVA: 0x0002294B File Offset: 0x00020B4B
			public unsafe Object _currentKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001861 RID: 6241
			// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x001AC434 File Offset: 0x001AA634
			// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x0002296A File Offset: 0x00020B6A
			public unsafe Object _currentValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hashtable.HashtableEnumerator.NativeFieldInfoPtr__currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004D20 RID: 19744
			private static readonly IntPtr NativeFieldInfoPtr__hashtable;

			// Token: 0x04004D21 RID: 19745
			private static readonly IntPtr NativeFieldInfoPtr__bucket;

			// Token: 0x04004D22 RID: 19746
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004D23 RID: 19747
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04004D24 RID: 19748
			private static readonly IntPtr NativeFieldInfoPtr__getObjectRetType;

			// Token: 0x04004D25 RID: 19749
			private static readonly IntPtr NativeFieldInfoPtr__currentKey;

			// Token: 0x04004D26 RID: 19750
			private static readonly IntPtr NativeFieldInfoPtr__currentValue;

			// Token: 0x04004D27 RID: 19751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hashtable_Int32_0;

			// Token: 0x04004D28 RID: 19752
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

			// Token: 0x04004D29 RID: 19753
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Object_0;

			// Token: 0x04004D2A RID: 19754
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_New_Boolean_0;

			// Token: 0x04004D2B RID: 19755
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_New_get_DictionaryEntry_0;

			// Token: 0x04004D2C RID: 19756
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_New_get_Object_0;

			// Token: 0x04004D2D RID: 19757
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

			// Token: 0x04004D2E RID: 19758
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
		}

		// Token: 0x020006F6 RID: 1782
		public class HashtableDebugView : Object
		{
			// Token: 0x06005EC4 RID: 24260 RVA: 0x00022989 File Offset: 0x00020B89
			// Note: this type is marked as 'beforefieldinit'.
			static HashtableDebugView()
			{
				Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hashtable>.NativeClassPtr, "HashtableDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hashtable.HashtableDebugView>.NativeClassPtr);
			}

			// Token: 0x06005EC5 RID: 24261 RVA: 0x000229A9 File Offset: 0x00020BA9
			public HashtableDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
