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
	// Token: 0x02000024 RID: 36
	public class LinkedListNodeCache<T> : Object
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x0000C518 File Offset: 0x0000A718
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedListNodeCache()
		{
			Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "LinkedListNodeCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr);
			LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodesCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, "m_NodesCreated");
			LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, "m_NodeCache");
			LinkedListNodeCache<T>.NativeMethodInfoPtr_Acquire_Public_LinkedListNode_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663629);
			LinkedListNodeCache<T>.NativeMethodInfoPtr_Release_Public_Void_LinkedListNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663630);
			LinkedListNodeCache<T>.NativeMethodInfoPtr_get_CreatedNodeCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663631);
			LinkedListNodeCache<T>.NativeMethodInfoPtr_get_CachedNodeCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663632);
			LinkedListNodeCache<T>.NativeMethodInfoPtr_set_CachedNodeCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663633);
			LinkedListNodeCache<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr, 100663634);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000C624 File Offset: 0x0000A824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138822, RefRangeEnd = 1138823, XrefRangeStart = 1138816, XrefRangeEnd = 1138822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNode<T> Acquire(T val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr_Acquire_Public_LinkedListNode_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<LinkedListNode<T>>(intPtr4) : null;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1138830, RefRangeEnd = 1138831, XrefRangeStart = 1138823, XrefRangeEnd = 1138830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(LinkedListNode<T> node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr_Release_Public_Void_LinkedListNode_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public unsafe int CreatedNodeCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr_get_CreatedNodeCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000C72C File Offset: 0x0000A92C
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000C768 File Offset: 0x0000A968
		public unsafe int CachedNodeCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1138831, RefRangeEnd = 1138833, XrefRangeStart = 1138831, XrefRangeEnd = 1138831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr_get_CachedNodeCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1138845, RefRangeEnd = 1138846, XrefRangeStart = 1138833, XrefRangeEnd = 1138845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr_set_CachedNodeCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedListNodeCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedListNodeCache<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedListNodeCache<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002C15 File Offset: 0x00000E15
		public LinkedListNodeCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002C1E File Offset: 0x00000E1E
		public unsafe int m_NodesCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodesCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodesCreated)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000C80C File Offset: 0x0000AA0C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002C39 File Offset: 0x00000E39
		public unsafe LinkedList<T> m_NodeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedListNodeCache<T>.NativeFieldInfoPtr_m_NodeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_m_NodesCreated;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_m_NodeCache;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_LinkedListNode_1_T_T_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_LinkedListNode_1_T_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatedNodeCount_Internal_get_Int32_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_get_CachedNodeCount_Internal_get_Int32_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_set_CachedNodeCount_Internal_set_Void_Int32_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
