using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.pooling
{
	// Token: 0x02000119 RID: 281
	public class PrefabPool<T> : global::Il2CppSystem.Object where T : Component
	{
		// Token: 0x06000FE7 RID: 4071 RVA: 0x000528F0 File Offset: 0x00050AF0
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabPool()
		{
			Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.pooling", "PrefabPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr);
			PrefabPool<T>.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "Prefab");
			PrefabPool<T>.NativeFieldInfoPtr_zeroOutNewInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "zeroOutNewInstance");
			PrefabPool<T>.NativeFieldInfoPtr_worldPositionStays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "worldPositionStays");
			PrefabPool<T>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "parent");
			PrefabPool<T>.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "pool");
			PrefabPool<T>.NativeFieldInfoPtr_initialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, "initialize");
			PrefabPool<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Transform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665620);
			PrefabPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_T_T_Transform_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665621);
			PrefabPool<T>.NativeMethodInfoPtr_get_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665622);
			PrefabPool<T>.NativeMethodInfoPtr_release_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665623);
			PrefabPool<T>.NativeMethodInfoPtr_destroy_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665624);
			PrefabPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665625);
			PrefabPool<T>.NativeMethodInfoPtr_Request_Public_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665626);
			PrefabPool<T>.NativeMethodInfoPtr_EmptyPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665627);
			PrefabPool<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr, 100665628);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00052A88 File Offset: 0x00050C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869152, RefRangeEnd = 869153, XrefRangeStart = 869125, XrefRangeEnd = 869152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabPool(T prefab, Transform parent, int max, int preloaded = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preloaded;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Transform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00052B38 File Offset: 0x00050D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869181, RefRangeEnd = 869182, XrefRangeStart = 869153, XrefRangeEnd = 869181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabPool(Action<T> init, T prefab, Transform parent, int max, int preloaded = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preloaded;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_T_T_Transform_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00052BFC File Offset: 0x00050DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869182, XrefRangeEnd = 869187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_get_Private_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00052C38 File Offset: 0x00050E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869187, XrefRangeEnd = 869203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void release(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_release_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00052CB0 File Offset: 0x00050EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869203, XrefRangeEnd = 869211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void destroy(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_destroy_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00052D28 File Offset: 0x00050F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869213, RefRangeEnd = 869214, XrefRangeStart = 869211, XrefRangeEnd = 869213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00052DA0 File Offset: 0x00050FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869231, RefRangeEnd = 869233, XrefRangeStart = 869214, XrefRangeEnd = 869231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Request(Transform transform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_Request_Public_T_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00052DEC File Offset: 0x00050FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869233, XrefRangeEnd = 869238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmptyPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_EmptyPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00052E20 File Offset: 0x00051020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869238, XrefRangeEnd = 869244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabPool<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0000779B File Offset: 0x0000599B
		public PrefabPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00052E58 File Offset: 0x00051058
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00052E80 File Offset: 0x00051080
		public unsafe T Prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_Prefab);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_Prefab);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00052F28 File Offset: 0x00051128
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x000077A4 File Offset: 0x000059A4
		public unsafe bool zeroOutNewInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_zeroOutNewInstance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_zeroOutNewInstance)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00052F50 File Offset: 0x00051150
		// (set) Token: 0x06000FF7 RID: 4087 RVA: 0x000077BF File Offset: 0x000059BF
		public unsafe bool worldPositionStays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_worldPositionStays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_worldPositionStays)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00052F78 File Offset: 0x00051178
		// (set) Token: 0x06000FF9 RID: 4089 RVA: 0x000077DA File Offset: 0x000059DA
		public unsafe Transform parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00052FA8 File Offset: 0x000511A8
		// (set) Token: 0x06000FFB RID: 4091 RVA: 0x000077F9 File Offset: 0x000059F9
		public unsafe Pool<T> pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pool<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00052FD8 File Offset: 0x000511D8
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00007818 File Offset: 0x00005A18
		public unsafe Action<T> initialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_initialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabPool<T>.NativeFieldInfoPtr_initialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_Prefab;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_zeroOutNewInstance;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_worldPositionStays;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_initialize;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Transform_Int32_Int32_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_T_T_Transform_Int32_Int32_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_get_Private_T_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_release_Private_Void_T_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_destroy_Private_Void_T_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_Request_Public_T_Transform_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_EmptyPool_Public_Void_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;
	}
}
