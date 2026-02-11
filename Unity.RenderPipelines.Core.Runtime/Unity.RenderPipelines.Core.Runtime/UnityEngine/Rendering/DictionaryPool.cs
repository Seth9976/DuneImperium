using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000051 RID: 81
	public static class DictionaryPool<TKey, TValue> : Object
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00023424 File Offset: 0x00021624
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryPool()
		{
			Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DictionaryPool`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr);
			DictionaryPool<TKey, TValue>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, "s_Pool");
			DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Get_Public_Static_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, 100664048);
			DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, 100664049);
			DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Release_Public_Static_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, 100664050);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000234F4 File Offset: 0x000216F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TValue> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Get_Public_Static_Dictionary_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00023528 File Offset: 0x00021728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectPool<Dictionary<TKey, TValue>>.PooledObject Get(out Dictionary<TKey, TValue> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Get_Public_Static_PooledObject_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new Dictionary<TKey, TValue>(intPtr4));
				return new ObjectPool<Dictionary<TKey, TValue>>.PooledObject(intPtr2);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00023578 File Offset: 0x00021778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(Dictionary<TKey, TValue> toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryPool<TKey, TValue>.NativeMethodInfoPtr_Release_Public_Static_Void_Dictionary_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000045F9 File Offset: 0x000027F9
		public DictionaryPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000235B0 File Offset: 0x000217B0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00004602 File Offset: 0x00002802
		public unsafe static ObjectPool<Dictionary<TKey, TValue>> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DictionaryPool<TKey, TValue>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Dictionary<TKey, TValue>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DictionaryPool<TKey, TValue>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Dictionary_2_TKey_TValue_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_PooledObject_Dictionary_2_TKey_TValue_byref_Dictionary_2_TKey_TValue_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_Dictionary_2_TKey_TValue_0;

		// Token: 0x02000182 RID: 386
		[ObfuscatedName("UnityEngine.Rendering.DictionaryPool`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001648 RID: 5704 RVA: 0x00060888 File Offset: 0x0005EA88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr);
				DictionaryPool<TKey, TValue>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr, "<>9");
				DictionaryPool<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr, 100664053);
				DictionaryPool<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr, 100664054);
			}

			// Token: 0x06001649 RID: 5705 RVA: 0x0006093C File Offset: 0x0005EB3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryPool<TKey, TValue>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryPool<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600164A RID: 5706 RVA: 0x00060978 File Offset: 0x0005EB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__4_0(Dictionary<TKey, TValue> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryPool<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600164B RID: 5707 RVA: 0x0000B36B File Offset: 0x0000956B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x0600164C RID: 5708 RVA: 0x000609BC File Offset: 0x0005EBBC
			// (set) Token: 0x0600164D RID: 5709 RVA: 0x0000B374 File Offset: 0x00009574
			public unsafe static DictionaryPool<TKey, TValue>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DictionaryPool<TKey, TValue>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictionaryPool<TKey, TValue>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DictionaryPool<TKey, TValue>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400103C RID: 4156
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400103D RID: 4157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400103E RID: 4158
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Void_Dictionary_2_TKey_TValue_0;
		}
	}
}
