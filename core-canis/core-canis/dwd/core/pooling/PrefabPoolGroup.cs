using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.pooling
{
	// Token: 0x0200011A RID: 282
	public class PrefabPoolGroup<T> : global::Il2CppSystem.Object where T : Component
	{
		// Token: 0x06000FFE RID: 4094 RVA: 0x00053008 File Offset: 0x00051208
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabPoolGroup()
		{
			Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.pooling", "PrefabPoolGroup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr);
			PrefabPoolGroup<T>.NativeFieldInfoPtr_zeroOutNewInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, "zeroOutNewInstance");
			PrefabPoolGroup<T>.NativeFieldInfoPtr_poolLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, "poolLookup");
			PrefabPoolGroup<T>.NativeMethodInfoPtr_get_ZeroOutNewIntance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665629);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_set_ZeroOutNewIntance_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665630);
			PrefabPoolGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665631);
			PrefabPoolGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_PrefabPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665632);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_HasPool_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665633);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_AddPool_Public_Void_PrefabPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665634);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_Request_Public_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665635);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_Release_Public_Void_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665636);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_EmptyPool_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665637);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_EmptyAllPools_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665638);
			PrefabPoolGroup<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr, 100665639);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00053178 File Offset: 0x00051378
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x000531B4 File Offset: 0x000513B4
		public unsafe bool ZeroOutNewIntance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_get_ZeroOutNewIntance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_set_ZeroOutNewIntance_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000531F4 File Offset: 0x000513F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869244, XrefRangeEnd = 869249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabPoolGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00053230 File Offset: 0x00051430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869271, RefRangeEnd = 869272, XrefRangeStart = 869249, XrefRangeEnd = 869271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabPoolGroup(IEnumerable<PrefabPool<T>> pools)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabPoolGroup<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pools);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_PrefabPool_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0005327C File Offset: 0x0005147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869272, XrefRangeEnd = 869274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPool(T prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prefab;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prefab;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_HasPool_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00053300 File Offset: 0x00051500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869274, XrefRangeEnd = 869276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPool(PrefabPool<T> pool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_AddPool_Public_Void_PrefabPool_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00053344 File Offset: 0x00051544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869308, RefRangeEnd = 869309, XrefRangeStart = 869276, XrefRangeEnd = 869308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Request(T prefab, Transform transform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prefab;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prefab;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_Request_Public_T_T_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000533D8 File Offset: 0x000515D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869328, RefRangeEnd = 869329, XrefRangeStart = 869309, XrefRangeEnd = 869328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(T prefab, T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prefab;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prefab;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = instance;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref instance;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_Release_Public_Void_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00053498 File Offset: 0x00051698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869329, XrefRangeEnd = 869332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmptyPool(T prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = prefab;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref prefab;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_EmptyPool_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00053510 File Offset: 0x00051710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869332, XrefRangeEnd = 869342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmptyAllPools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_EmptyAllPools_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00053544 File Offset: 0x00051744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869360, RefRangeEnd = 869361, XrefRangeStart = 869342, XrefRangeEnd = 869360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPoolGroup<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00007837 File Offset: 0x00005A37
		public PrefabPoolGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x0005357C File Offset: 0x0005177C
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00007840 File Offset: 0x00005A40
		public unsafe bool zeroOutNewInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPoolGroup<T>.NativeFieldInfoPtr_zeroOutNewInstance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPoolGroup<T>.NativeFieldInfoPtr_zeroOutNewInstance)) = value;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x000535A4 File Offset: 0x000517A4
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x0000785B File Offset: 0x00005A5B
		public unsafe Dictionary<T, PrefabPool<T>> poolLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPoolGroup<T>.NativeFieldInfoPtr_poolLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, PrefabPool<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPoolGroup<T>.NativeFieldInfoPtr_poolLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr_zeroOutNewInstance;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr_poolLookup;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_get_ZeroOutNewIntance_Public_get_Boolean_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_set_ZeroOutNewIntance_Public_set_Void_Boolean_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_PrefabPool_1_T_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_HasPool_Public_Boolean_T_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_AddPool_Public_Void_PrefabPool_1_T_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_T_T_Transform_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_T_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_EmptyPool_Public_Void_T_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_EmptyAllPools_Public_Void_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;
	}
}
