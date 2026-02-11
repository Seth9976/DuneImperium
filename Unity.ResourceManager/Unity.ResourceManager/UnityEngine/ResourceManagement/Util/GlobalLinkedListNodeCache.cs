using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000025 RID: 37
	public static class GlobalLinkedListNodeCache<T> : Object
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0000C83C File Offset: 0x0000AA3C
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalLinkedListNodeCache()
		{
			Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "GlobalLinkedListNodeCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr);
			GlobalLinkedListNodeCache<T>.NativeFieldInfoPtr_m_globalCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr, "m_globalCache");
			GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_get_CacheExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr, 100663635);
			GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_SetCacheSize_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr, 100663636);
			GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_Acquire_Public_Static_LinkedListNode_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr, 100663637);
			GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_Release_Public_Static_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalLinkedListNodeCache<T>>.NativeClassPtr, 100663638);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000C90C File Offset: 0x0000AB0C
		public unsafe static bool CacheExists
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1138848, RefRangeEnd = 1138849, XrefRangeStart = 1138846, XrefRangeEnd = 1138848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_get_CacheExists_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000C93C File Offset: 0x0000AB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138866, RefRangeEnd = 1138867, XrefRangeStart = 1138849, XrefRangeEnd = 1138866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCacheSize(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_SetCacheSize_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000C970 File Offset: 0x0000AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138867, XrefRangeEnd = 1138884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinkedListNode<T> Acquire(T val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_Acquire_Public_Static_LinkedListNode_1_T_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr4) : null;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138884, XrefRangeEnd = 1138935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(LinkedListNode<T> node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalLinkedListNodeCache<T>.NativeMethodInfoPtr_Release_Public_Static_Void_LinkedListNode_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002C58 File Offset: 0x00000E58
		public GlobalLinkedListNodeCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000CA24 File Offset: 0x0000AC24
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe static LinkedListNodeCache<T> m_globalCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalLinkedListNodeCache<T>.NativeFieldInfoPtr_m_globalCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNodeCache<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalLinkedListNodeCache<T>.NativeFieldInfoPtr_m_globalCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_m_globalCache;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_CacheExists_Public_Static_get_Boolean_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_SetCacheSize_Public_Static_Void_Int32_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_LinkedListNode_1_T_T_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_LinkedListNode_1_T_0;
	}
}
