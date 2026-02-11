using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.pooling
{
	// Token: 0x02000118 RID: 280
	public class Pool<T> : Object
	{
		// Token: 0x06000FD4 RID: 4052 RVA: 0x000524C8 File Offset: 0x000506C8
		// Note: this type is marked as 'beforefieldinit'.
		static Pool()
		{
			Il2CppClassPointerStore<Pool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.pooling", "Pool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr);
			Pool<T>.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "pool");
			Pool<T>.NativeFieldInfoPtr_constructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "constructor");
			Pool<T>.NativeFieldInfoPtr_resetMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "resetMethod");
			Pool<T>.NativeFieldInfoPtr_overflowMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "overflowMethod");
			Pool<T>.NativeFieldInfoPtr_maxPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "maxPoolSize");
			Pool<T>.NativeFieldInfoPtr_spawnedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "spawnedItems");
			Pool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Nullable_1_UInt32_Action_1_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, 100665610);
			Pool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, 100665611);
			Pool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, 100665612);
			Pool<T>.NativeMethodInfoPtr_Empty_Public_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, 100665613);
			Pool<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, 100665614);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00052610 File Offset: 0x00050810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 869065, RefRangeEnd = 869068, XrefRangeStart = 869024, XrefRangeEnd = 869065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pool(Func<T> constructor, Action<T> resetMethod = null, Nullable<uint> maxPoolSize = null, Action<T> overflowMethod = null, uint preloadCount = 0U)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resetMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(maxPoolSize));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overflowMethod);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preloadCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Nullable_1_UInt32_Action_1_T_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000526A8 File Offset: 0x000508A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 869069, RefRangeEnd = 869081, XrefRangeStart = 869068, XrefRangeEnd = 869069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000526E4 File Offset: 0x000508E4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 869087, RefRangeEnd = 869100, XrefRangeStart = 869081, XrefRangeEnd = 869087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0005275C File Offset: 0x0005095C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869114, RefRangeEnd = 869116, XrefRangeStart = 869100, XrefRangeEnd = 869114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Empty(Action<T> itemHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pool<T>.NativeMethodInfoPtr_Empty_Public_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000527A0 File Offset: 0x000509A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869123, RefRangeEnd = 869125, XrefRangeStart = 869116, XrefRangeEnd = 869123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatistics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pool<T>.NativeMethodInfoPtr_GetStatistics_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000076CD File Offset: 0x000058CD
		public Pool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000527D8 File Offset: 0x000509D8
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x000076D6 File Offset: 0x000058D6
		public unsafe Stack<T> pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_pool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00052808 File Offset: 0x00050A08
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000076F5 File Offset: 0x000058F5
		public unsafe Func<T> constructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_constructor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_constructor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00052838 File Offset: 0x00050A38
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00007714 File Offset: 0x00005914
		public unsafe Action<T> resetMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_resetMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_resetMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00052868 File Offset: 0x00050A68
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00007733 File Offset: 0x00005933
		public unsafe Action<T> overflowMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_overflowMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_overflowMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00052898 File Offset: 0x00050A98
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00007752 File Offset: 0x00005952
		public Nullable<uint> maxPoolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_maxPoolSize);
				return new Nullable<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<uint>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_maxPoolSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<uint>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000528C8 File Offset: 0x00050AC8
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00007780 File Offset: 0x00005980
		public unsafe int spawnedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_spawnedItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pool<T>.NativeFieldInfoPtr_spawnedItems)) = value;
			}
		}

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr_pool;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeFieldInfoPtr_constructor;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr_resetMethod;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_overflowMethod;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_maxPoolSize;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_spawnedItems;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Nullable_1_UInt32_Action_1_T_UInt32_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Void_Action_1_T_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_GetStatistics_Public_String_0;

		// Token: 0x020002C5 RID: 709
		[ObfuscatedName("dwd.core.pooling.Pool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600212D RID: 8493 RVA: 0x00094E68 File Offset: 0x00093068
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr);
				Pool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, "<>9");
				Pool<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, "<>9__6_0");
				Pool<T>.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, "<>9__6_1");
				Pool<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, "<>9__9_0");
				Pool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, 100665616);
				Pool<T>.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, 100665617);
				Pool<T>.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, 100665618);
				Pool<T>.__c.NativeMethodInfoPtr__Empty_b__9_0_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr, 100665619);
			}

			// Token: 0x0600212E RID: 8494 RVA: 0x00094F70 File Offset: 0x00093170
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600212F RID: 8495 RVA: 0x00094FAC File Offset: 0x000931AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__6_0(T <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = <p0>;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref <p0>;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pool<T>.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002130 RID: 8496 RVA: 0x00095024 File Offset: 0x00093224
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__6_1(T <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = <p0>;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref <p0>;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pool<T>.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002131 RID: 8497 RVA: 0x0009509C File Offset: 0x0009329C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Empty_b__9_0(T <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = <p0>;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref <p0>;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pool<T>.__c.NativeMethodInfoPtr__Empty_b__9_0_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06002132 RID: 8498 RVA: 0x0000E337 File Offset: 0x0000C537
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06002133 RID: 8499 RVA: 0x00095114 File Offset: 0x00093314
			// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000E340 File Offset: 0x0000C540
			public unsafe static Pool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06002135 RID: 8501 RVA: 0x0009513C File Offset: 0x0009333C
			// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000E352 File Offset: 0x0000C552
			public unsafe static Action<T> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pool<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pool<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x00095164 File Offset: 0x00093364
			// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000E364 File Offset: 0x0000C564
			public unsafe static Action<T> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pool<T>.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pool<T>.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x06002139 RID: 8505 RVA: 0x0009518C File Offset: 0x0009338C
			// (set) Token: 0x0600213A RID: 8506 RVA: 0x0000E376 File Offset: 0x0000C576
			public unsafe static Action<T> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pool<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pool<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001705 RID: 5893
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Void_T_0;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_1_Internal_Void_T_0;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeMethodInfoPtr__Empty_b__9_0_Internal_Void_T_0;
		}
	}
}
