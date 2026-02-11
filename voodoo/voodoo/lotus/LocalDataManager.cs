using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000049 RID: 73
	public class LocalDataManager<K, V> : Object where V : class
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00017A40 File Offset: 0x00015C40
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataManager()
		{
			Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "LocalDataManager`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr);
			LocalDataManager<K, V>.NativeFieldInfoPtr_itemsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, "itemsMap");
			LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_IEnumerable_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663822);
			LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_List_1_V_Func_2_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663823);
			LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663824);
			LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663825);
			LocalDataManager<K, V>.NativeMethodInfoPtr_Get_Public_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663826);
			LocalDataManager<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_K_byref_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663827);
			LocalDataManager<K, V>.NativeMethodInfoPtr_Remove_Public_Boolean_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663828);
			LocalDataManager<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr, 100663829);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00017B74 File Offset: 0x00015D74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1110361, RefRangeEnd = 1110366, XrefRangeStart = 1110342, XrefRangeEnd = 1110361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ingest(IEnumerable<V> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_IEnumerable_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00017BB8 File Offset: 0x00015DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110366, XrefRangeEnd = 1110373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ingest(List<V> items, Func<V, K> f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(f);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_List_1_V_Func_2_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00017C0C File Offset: 0x00015E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1110380, RefRangeEnd = 1110382, XrefRangeStart = 1110373, XrefRangeEnd = 1110380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ingest(V item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = item;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00017C84 File Offset: 0x00015E84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1110401, RefRangeEnd = 1110405, XrefRangeStart = 1110382, XrefRangeEnd = 1110401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ingest(V item, K k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = item;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(K).IsValueType)
			{
				K k2 = k;
				intPtr2 = ((k2 is string) ? IL2CPP.ManagedStringToIl2Cpp(k2 as string) : IL2CPP.Il2CppObjectBaseToPtr(k2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref k;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Ingest_Public_Void_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00017D44 File Offset: 0x00015F44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1110421, RefRangeEnd = 1110425, XrefRangeStart = 1110405, XrefRangeEnd = 1110421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe V Get(K id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = id;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Get_Public_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00017DC4 File Offset: 0x00015FC4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1110429, RefRangeEnd = 1110437, XrefRangeStart = 1110425, XrefRangeEnd = 1110429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(K id, out V val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(K).IsValueType)
				{
					K k = id;
					intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(V).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref val;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_K_byref_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(V).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				val = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<V>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00017E98 File Offset: 0x00016098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110437, XrefRangeEnd = 1110444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(V val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = val;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr_Remove_Public_Boolean_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00017F1C File Offset: 0x0001611C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1110453, RefRangeEnd = 1110459, XrefRangeStart = 1110444, XrefRangeEnd = 1110453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataManager<K, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataManager<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000044DD File Offset: 0x000026DD
		public LocalDataManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00017F58 File Offset: 0x00016158
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x000044E6 File Offset: 0x000026E6
		public unsafe Dictionary<K, V> itemsMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataManager<K, V>.NativeFieldInfoPtr_itemsMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<K, V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataManager<K, V>.NativeFieldInfoPtr_itemsMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeFieldInfoPtr_itemsMap;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_Ingest_Public_Void_IEnumerable_1_V_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_Ingest_Public_Void_List_1_V_Func_2_V_K_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_Ingest_Public_Void_V_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_Ingest_Public_Void_V_K_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_V_K_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_K_byref_V_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_V_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
