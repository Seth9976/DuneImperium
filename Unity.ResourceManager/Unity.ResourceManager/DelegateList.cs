using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000004 RID: 4
public class DelegateList<T> : Object
{
	// Token: 0x06000007 RID: 7 RVA: 0x00004DA0 File Offset: 0x00002FA0
	// Note: this type is marked as 'beforefieldinit'.
	static DelegateList()
	{
		Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "", "DelegateList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr);
		DelegateList<T>.NativeFieldInfoPtr_m_acquireFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, "m_acquireFunc");
		DelegateList<T>.NativeFieldInfoPtr_m_releaseFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, "m_releaseFunc");
		DelegateList<T>.NativeFieldInfoPtr_m_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, "m_callbacks");
		DelegateList<T>.NativeFieldInfoPtr_m_invoking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, "m_invoking");
		DelegateList<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Action_1_T_LinkedListNode_1_Action_1_T_Action_1_LinkedListNode_1_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663299);
		DelegateList<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663300);
		DelegateList<T>.NativeMethodInfoPtr_Add_Public_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663301);
		DelegateList<T>.NativeMethodInfoPtr_Remove_Public_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663302);
		DelegateList<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663303);
		DelegateList<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663304);
		DelegateList<T>.NativeMethodInfoPtr_CreateWithGlobalCache_Public_Static_DelegateList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, 100663305);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00004EE8 File Offset: 0x000030E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135488, XrefRangeEnd = 1135501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DelegateList(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acquireFunc);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(releaseFunc);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Action_1_T_LinkedListNode_1_Action_1_T_Action_1_LinkedListNode_1_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00004F48 File Offset: 0x00003148
	public unsafe int Count
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1135501, RefRangeEnd = 1135506, XrefRangeStart = 1135501, XrefRangeEnd = 1135501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00004F84 File Offset: 0x00003184
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1135515, RefRangeEnd = 1135522, XrefRangeStart = 1135506, XrefRangeEnd = 1135515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Add(Action<T> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_Add_Public_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00004FC8 File Offset: 0x000031C8
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1135528, RefRangeEnd = 1135538, XrefRangeStart = 1135522, XrefRangeEnd = 1135528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(Action<T> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_Remove_Public_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000500C File Offset: 0x0000320C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1135546, RefRangeEnd = 1135548, XrefRangeStart = 1135538, XrefRangeEnd = 1135546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Invoke(T res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = res;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref res;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00005084 File Offset: 0x00003284
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1135550, RefRangeEnd = 1135552, XrefRangeStart = 1135548, XrefRangeEnd = 1135550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000050B8 File Offset: 0x000032B8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1135589, RefRangeEnd = 1135596, XrefRangeStart = 1135552, XrefRangeEnd = 1135589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DelegateList<T> CreateWithGlobalCache()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateList<T>.NativeMethodInfoPtr_CreateWithGlobalCache_Public_Static_DelegateList_1_T_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DelegateList<T>>(intPtr3) : null;
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020D4 File Offset: 0x000002D4
	public DelegateList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000050EC File Offset: 0x000032EC
	// (set) Token: 0x06000011 RID: 17 RVA: 0x000020DD File Offset: 0x000002DD
	public unsafe Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_acquireFunc);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action<T>, LinkedListNode<Action<T>>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_acquireFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000012 RID: 18 RVA: 0x0000511C File Offset: 0x0000331C
	// (set) Token: 0x06000013 RID: 19 RVA: 0x000020FC File Offset: 0x000002FC
	public unsafe Action<LinkedListNode<Action<T>>> m_releaseFunc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_releaseFunc);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LinkedListNode<Action<T>>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_releaseFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000014 RID: 20 RVA: 0x0000514C File Offset: 0x0000334C
	// (set) Token: 0x06000015 RID: 21 RVA: 0x0000211B File Offset: 0x0000031B
	public unsafe LinkedList<Action<T>> m_callbacks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_callbacks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<Action<T>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000016 RID: 22 RVA: 0x0000517C File Offset: 0x0000337C
	// (set) Token: 0x06000017 RID: 23 RVA: 0x0000213A File Offset: 0x0000033A
	public unsafe bool m_invoking
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_invoking);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelegateList<T>.NativeFieldInfoPtr_m_invoking)) = value;
		}
	}

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeFieldInfoPtr_m_acquireFunc;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeFieldInfoPtr_m_releaseFunc;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeFieldInfoPtr_m_callbacks;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeFieldInfoPtr_m_invoking;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Action_1_T_LinkedListNode_1_Action_1_T_Action_1_LinkedListNode_1_Action_1_T_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Action_1_T_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Action_1_T_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_CreateWithGlobalCache_Public_Static_DelegateList_1_T_0;

	// Token: 0x02000059 RID: 89
	[ObfuscatedName("DelegateList`1+<>O")]
	public static class __O : Object
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x0001A17C File Offset: 0x0001837C
		// Note: this type is marked as 'beforefieldinit'.
		static __O()
		{
			Il2CppClassPointerStore<DelegateList<T>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateList<T>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateList<T>.__O>.NativeClassPtr);
			DelegateList<T>.__O.NativeFieldInfoPtr__0___Acquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>.__O>.NativeClassPtr, "<0>__Acquire");
			DelegateList<T>.__O.NativeFieldInfoPtr__1___Release = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateList<T>.__O>.NativeClassPtr, "<1>__Release");
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00003F0A File Offset: 0x0000210A
		public __O(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001A20C File Offset: 0x0001840C
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003F13 File Offset: 0x00002113
		public unsafe static Func<Action<T>, LinkedListNode<Action<T>>> _0___Acquire
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DelegateList<T>.__O.NativeFieldInfoPtr__0___Acquire, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Action<T>, LinkedListNode<Action<T>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DelegateList<T>.__O.NativeFieldInfoPtr__0___Acquire, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001A234 File Offset: 0x00018434
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003F25 File Offset: 0x00002125
		public unsafe static Action<LinkedListNode<Action<T>>> _1___Release
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DelegateList<T>.__O.NativeFieldInfoPtr__1___Release, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LinkedListNode<Action<T>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DelegateList<T>.__O.NativeFieldInfoPtr__1___Release, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr__0___Acquire;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr__1___Release;
	}
}
