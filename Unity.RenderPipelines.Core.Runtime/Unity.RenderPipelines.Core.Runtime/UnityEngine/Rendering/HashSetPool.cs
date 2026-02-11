using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000050 RID: 80
	public static class HashSetPool<T> : Object
	{
		// Token: 0x060005D0 RID: 1488 RVA: 0x00023284 File Offset: 0x00021484
		// Note: this type is marked as 'beforefieldinit'.
		static HashSetPool()
		{
			Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HashSetPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr);
			HashSetPool<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, "s_Pool");
			HashSetPool<T>.NativeMethodInfoPtr_Get_Public_Static_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, 100664041);
			HashSetPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_HashSet_1_T_byref_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, 100664042);
			HashSetPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, 100664043);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00023340 File Offset: 0x00021540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960378, XrefRangeEnd = 960385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSetPool<T>.NativeMethodInfoPtr_Get_Public_Static_HashSet_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<T>>(intPtr3) : null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00023374 File Offset: 0x00021574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960385, XrefRangeEnd = 960392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectPool<HashSet<T>>.PooledObject Get(out HashSet<T> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashSetPool<T>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_HashSet_1_T_byref_HashSet_1_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new HashSet<T>(intPtr4));
				return new ObjectPool<HashSet<T>>.PooledObject(intPtr2);
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000233C4 File Offset: 0x000215C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960392, XrefRangeEnd = 960399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(HashSet<T> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSetPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_HashSet_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000045DE File Offset: 0x000027DE
		public HashSetPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x000233FC File Offset: 0x000215FC
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x000045E7 File Offset: 0x000027E7
		public unsafe static ObjectPool<HashSet<T>> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HashSetPool<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<HashSet<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashSetPool<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_HashSet_1_T_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_HashSet_1_T_byref_HashSet_1_T_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_HashSet_1_T_0;

		// Token: 0x02000181 RID: 385
		[ObfuscatedName("UnityEngine.Rendering.HashSetPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001642 RID: 5698 RVA: 0x0006073C File Offset: 0x0005E93C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HashSetPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr);
				HashSetPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr, "<>9");
				HashSetPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr, 100664046);
				HashSetPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_HashSet_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr, 100664047);
			}

			// Token: 0x06001643 RID: 5699 RVA: 0x000607E0 File Offset: 0x0005E9E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HashSetPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSetPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001644 RID: 5700 RVA: 0x0006081C File Offset: 0x0005EA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960377, XrefRangeEnd = 960378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_0(HashSet<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashSetPool<T>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_HashSet_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001645 RID: 5701 RVA: 0x0000B350 File Offset: 0x00009550
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001646 RID: 5702 RVA: 0x00060860 File Offset: 0x0005EA60
			// (set) Token: 0x06001647 RID: 5703 RVA: 0x0000B359 File Offset: 0x00009559
			public unsafe static HashSetPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HashSetPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSetPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HashSetPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001039 RID: 4153
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400103A RID: 4154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400103B RID: 4155
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_HashSet_1_T_0;
		}
	}
}
