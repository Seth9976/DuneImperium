using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003DF RID: 991
	public sealed class ConditionalWeakTable<TKey, TValue> : Object where TKey : class where TValue : class
	{
		// Token: 0x06003A1D RID: 14877 RVA: 0x001183B0 File Offset: 0x001165B0
		// Note: this type is marked as 'beforefieldinit'.
		static ConditionalWeakTable()
		{
			Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConditionalWeakTable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr);
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "INITIAL_SIZE");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "LOAD_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "COMPACT_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "EXPAND_FACTOR");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "data");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "_lock");
			ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "size");
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671963);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671964);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671965);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671966);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671967);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671968);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671969);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671970);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671971);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671972);
			ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, 100671973);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00118598 File Offset: 0x00116798
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1395864, RefRangeEnd = 1395866, XrefRangeStart = 1395850, XrefRangeEnd = 1395864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConditionalWeakTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001185D4 File Offset: 0x001167D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395866, XrefRangeEnd = 1395869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00118608 File Offset: 0x00116808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1395880, RefRangeEnd = 1395881, XrefRangeStart = 1395869, XrefRangeEnd = 1395880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RehashWithoutResize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x0011863C File Offset: 0x0011683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395881, XrefRangeEnd = 1395883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecomputeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_RecomputeSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00118670 File Offset: 0x00116870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1395892, RefRangeEnd = 1395893, XrefRangeStart = 1395883, XrefRangeEnd = 1395892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rehash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Rehash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001186A4 File Offset: 0x001168A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395907, RefRangeEnd = 1395910, XrefRangeStart = 1395893, XrefRangeEnd = 1395907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00118764 File Offset: 0x00116964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1395923, RefRangeEnd = 1395925, XrefRangeStart = 1395910, XrefRangeEnd = 1395923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001187E8 File Offset: 0x001169E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1395938, RefRangeEnd = 1395943, XrefRangeStart = 1395925, XrefRangeEnd = 1395938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x001188BC File Offset: 0x00116ABC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1395949, RefRangeEnd = 1395952, XrefRangeStart = 1395943, XrefRangeEnd = 1395949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createValueCallback);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x00118950 File Offset: 0x00116B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395952, XrefRangeEnd = 1395966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00118990 File Offset: 0x00116B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395966, XrefRangeEnd = 1395972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x00015A17 File Offset: 0x00013C17
		public ConditionalWeakTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x001189D0 File Offset: 0x00116BD0
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x00015A20 File Offset: 0x00013C20
		public unsafe static int INITIAL_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_INITIAL_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x001189EC File Offset: 0x00116BEC
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x00015A2E File Offset: 0x00013C2E
		public unsafe static float LOAD_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_LOAD_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00118A08 File Offset: 0x00116C08
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x00015A3C File Offset: 0x00013C3C
		public unsafe static float COMPACT_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_COMPACT_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x00118A24 File Offset: 0x00116C24
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x00015A4A File Offset: 0x00013C4A
		public unsafe static float EXPAND_FACTOR
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_EXPAND_FACTOR, (void*)(&value));
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00118A40 File Offset: 0x00116C40
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x00015A58 File Offset: 0x00013C58
		public unsafe Il2CppReferenceArray<Ephemeron> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Ephemeron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x00118A70 File Offset: 0x00116C70
		// (set) Token: 0x06003A35 RID: 14901 RVA: 0x00015A77 File Offset: 0x00013C77
		public unsafe Object _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06003A36 RID: 14902 RVA: 0x00118AA0 File Offset: 0x00116CA0
		// (set) Token: 0x06003A37 RID: 14903 RVA: 0x00015A96 File Offset: 0x00013C96
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeFieldInfoPtr_INITIAL_SIZE;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_FACTOR;

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeFieldInfoPtr_COMPACT_FACTOR;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeFieldInfoPtr_EXPAND_FACTOR;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeMethodInfoPtr_RehashWithoutResize_Private_Void_0;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeSize_Private_Void_0;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr_Rehash_Private_Void_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_TKey_TValue_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TKey_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_TValue_TKey_CreateValueCallback_TKey_TValue_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020006A1 RID: 1697
		public sealed class CreateValueCallback : MulticastDelegate
		{
			// Token: 0x06005C2E RID: 23598 RVA: 0x001A27A8 File Offset: 0x001A09A8
			// Note: this type is marked as 'beforefieldinit'.
			static CreateValueCallback()
			{
				Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "CreateValueCallback"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100671974);
				ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr, 100671975);
			}

			// Token: 0x06005C2F RID: 23599 RVA: 0x001A2840 File Offset: 0x001A0A40
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 742264, RefRangeEnd = 742289, XrefRangeStart = 742264, XrefRangeEnd = 742289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateValueCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C30 RID: 23600 RVA: 0x001A289C File Offset: 0x001A0A9C
			[CallerCount(0)]
			public unsafe TValue Invoke(TKey key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.CreateValueCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}

			// Token: 0x06005C31 RID: 23601 RVA: 0x00021706 File Offset: 0x0001F906
			public CreateValueCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005C32 RID: 23602 RVA: 0x0002170F File Offset: 0x0001F90F
			public static implicit operator ConditionalWeakTable<TKey, TValue>.CreateValueCallback(Func<TKey, TValue> A_0)
			{
				return DelegateSupport.ConvertDelegate<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>(A_0);
			}

			// Token: 0x06005C33 RID: 23603 RVA: 0x00021717 File Offset: 0x0001F917
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator +(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
			}

			// Token: 0x06005C34 RID: 23604 RVA: 0x00021725 File Offset: 0x0001F925
			public static ConditionalWeakTable<TKey, TValue>.CreateValueCallback operator -(ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_0, ConditionalWeakTable<TKey, TValue>.CreateValueCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ConditionalWeakTable<TKey, TValue>.CreateValueCallback>();
				}
				return delegate2;
			}

			// Token: 0x04004AF0 RID: 19184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004AF1 RID: 19185
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TValue_TKey_0;
		}

		// Token: 0x020006A2 RID: 1698
		public sealed class Enumerator : Object
		{
			// Token: 0x06005C35 RID: 23605 RVA: 0x001A291C File Offset: 0x001A0B1C
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, "_table");
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, "_currentIndex");
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, "_current");
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_ConditionalWeakTable_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671976);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671977);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671978);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671979);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671980);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671981);
				ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr, 100671982);
			}

			// Token: 0x06005C36 RID: 23606 RVA: 0x001A2A5C File Offset: 0x001A0C5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1395817, RefRangeEnd = 1395818, XrefRangeStart = 1395815, XrefRangeEnd = 1395817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(ConditionalWeakTable<TKey, TValue> table)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalWeakTable<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_ConditionalWeakTable_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005C37 RID: 23607 RVA: 0x001A2AA8 File Offset: 0x001A0CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395818, XrefRangeEnd = 1395826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C38 RID: 23608 RVA: 0x001A2ADC File Offset: 0x001A0CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395826, XrefRangeEnd = 1395831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C39 RID: 23609 RVA: 0x001A2B10 File Offset: 0x001A0D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395831, XrefRangeEnd = 1395847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001796 RID: 6038
			// (get) Token: 0x06005C3A RID: 23610 RVA: 0x001A2B4C File Offset: 0x001A0D4C
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395847, XrefRangeEnd = 1395848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x17001797 RID: 6039
			// (get) Token: 0x06005C3B RID: 23611 RVA: 0x001A2B84 File Offset: 0x001A0D84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395848, XrefRangeEnd = 1395850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005C3C RID: 23612 RVA: 0x001A2BC4 File Offset: 0x001A0DC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005C3D RID: 23613 RVA: 0x00021736 File Offset: 0x0001F936
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001793 RID: 6035
			// (get) Token: 0x06005C3E RID: 23614 RVA: 0x001A2BF8 File Offset: 0x001A0DF8
			// (set) Token: 0x06005C3F RID: 23615 RVA: 0x0002173F File Offset: 0x0001F93F
			public unsafe ConditionalWeakTable<TKey, TValue> _table
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__table);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001794 RID: 6036
			// (get) Token: 0x06005C40 RID: 23616 RVA: 0x001A2C28 File Offset: 0x001A0E28
			// (set) Token: 0x06005C41 RID: 23617 RVA: 0x0002175E File Offset: 0x0001F95E
			public unsafe int _currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__currentIndex)) = value;
				}
			}

			// Token: 0x17001795 RID: 6037
			// (get) Token: 0x06005C42 RID: 23618 RVA: 0x001A2C50 File Offset: 0x001A0E50
			// (set) Token: 0x06005C43 RID: 23619 RVA: 0x00021779 File Offset: 0x0001F979
			public KeyValuePair<TKey, TValue> _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConditionalWeakTable<TKey, TValue>.Enumerator.NativeFieldInfoPtr__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004AF2 RID: 19186
			private static readonly IntPtr NativeFieldInfoPtr__table;

			// Token: 0x04004AF3 RID: 19187
			private static readonly IntPtr NativeFieldInfoPtr__currentIndex;

			// Token: 0x04004AF4 RID: 19188
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04004AF5 RID: 19189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalWeakTable_2_TKey_TValue_0;

			// Token: 0x04004AF6 RID: 19190
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04004AF7 RID: 19191
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004AF8 RID: 19192
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004AF9 RID: 19193
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04004AFA RID: 19194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004AFB RID: 19195
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}
	}
}
