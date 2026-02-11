using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class PoolableReference<T> : global::Il2CppSystem.Object where T : Component
{
	// Token: 0x0600027A RID: 634 RVA: 0x0001C4DC File Offset: 0x0001A6DC
	// Note: this type is marked as 'beforefieldinit'.
	static PoolableReference()
	{
		Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "PoolableReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr);
		PoolableReference<T>.NativeFieldInfoPtr__pooledObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, "_pooledObj");
		PoolableReference<T>.NativeFieldInfoPtr__initialUsageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, "_initialUsageCount");
		PoolableReference<T>.NativeFieldInfoPtr__objComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, "_objComponent");
		PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663634);
		PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663635);
		PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_PoolableReference_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663636);
		PoolableReference<T>.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663637);
		PoolableReference<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663638);
		PoolableReference<T>.NativeMethodInfoPtr_Set_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663639);
		PoolableReference<T>.NativeMethodInfoPtr_Set_Public_Void_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr, 100663640);
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0001C610 File Offset: 0x0001A810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853347, XrefRangeEnd = 853349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolableReference()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0001C64C File Offset: 0x0001A84C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853349, XrefRangeEnd = 853351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolableReference(T componentOfPoolableObject)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = componentOfPoolableObject;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref componentOfPoolableObject;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853351, XrefRangeEnd = 853354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PoolableReference(PoolableReference<T> poolableReference)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableReference<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poolableReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr__ctor_Public_Void_PoolableReference_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0001C71C File Offset: 0x0001A91C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853354, XrefRangeEnd = 853355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0001C750 File Offset: 0x0001A950
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853363, RefRangeEnd = 853364, XrefRangeStart = 853355, XrefRangeEnd = 853363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T Get()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0001C78C File Offset: 0x0001A98C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 853364, XrefRangeEnd = 853365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(T componentOfPoolableObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = componentOfPoolableObject;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref componentOfPoolableObject;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr_Set_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0001C804 File Offset: 0x0001AA04
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 853379, RefRangeEnd = 853380, XrefRangeStart = 853365, XrefRangeEnd = 853379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(T componentOfPoolableObject, bool allowNonePoolable)
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
				T t = componentOfPoolableObject;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref componentOfPoolableObject;
			}
			ptr2 = intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNonePoolable;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PoolableReference<T>.NativeMethodInfoPtr_Set_Public_Void_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x06000282 RID: 642 RVA: 0x000030FF File Offset: 0x000012FF
	public PoolableReference(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000283 RID: 643 RVA: 0x0001C88C File Offset: 0x0001AA8C
	// (set) Token: 0x06000284 RID: 644 RVA: 0x00003108 File Offset: 0x00001308
	public unsafe PoolableObject _pooledObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__pooledObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__pooledObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000285 RID: 645 RVA: 0x0001C8BC File Offset: 0x0001AABC
	// (set) Token: 0x06000286 RID: 646 RVA: 0x00003127 File Offset: 0x00001327
	public unsafe int _initialUsageCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__initialUsageCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__initialUsageCount)) = value;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000287 RID: 647 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
	// (set) Token: 0x06000288 RID: 648 RVA: 0x0001C90C File Offset: 0x0001AB0C
	public unsafe T _objComponent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__objComponent);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoolableReference<T>.NativeFieldInfoPtr__objComponent);
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

	// Token: 0x040001D5 RID: 469
	private static readonly IntPtr NativeFieldInfoPtr__pooledObj;

	// Token: 0x040001D6 RID: 470
	private static readonly IntPtr NativeFieldInfoPtr__initialUsageCount;

	// Token: 0x040001D7 RID: 471
	private static readonly IntPtr NativeFieldInfoPtr__objComponent;

	// Token: 0x040001D8 RID: 472
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040001D9 RID: 473
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

	// Token: 0x040001DA RID: 474
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PoolableReference_1_T_0;

	// Token: 0x040001DB RID: 475
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	// Token: 0x040001DC RID: 476
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

	// Token: 0x040001DD RID: 477
	private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_T_0;

	// Token: 0x040001DE RID: 478
	private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_T_Boolean_0;
}
