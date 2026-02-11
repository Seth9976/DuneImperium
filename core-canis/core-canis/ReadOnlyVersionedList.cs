using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000024 RID: 36
public class ReadOnlyVersionedList<T> : Object
{
	// Token: 0x0600032A RID: 810 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
	// Note: this type is marked as 'beforefieldinit'.
	static ReadOnlyVersionedList()
	{
		Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "ReadOnlyVersionedList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr);
		ReadOnlyVersionedList<T>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, "source");
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663714);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663715);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663716);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663717);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663718);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_MarkDirty_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663719);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663720);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663721);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663722);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663723);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663724);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663725);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663726);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663727);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663728);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663729);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_IVersionedList_T__get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyVersionedList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663730);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663731);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663732);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663733);
		ReadOnlyVersionedList<T>.NativeMethodInfoPtr_updateItems_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr, 100663734);
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0001EFFC File Offset: 0x0001D1FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854101, XrefRangeEnd = 854163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0001F038 File Offset: 0x0001D238
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854163, XrefRangeEnd = 854188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedList(IEnumerable<T> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0001F084 File Offset: 0x0001D284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854188, XrefRangeEnd = 854266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedList(ReadOnlyVersionedList<T> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0001F0D0 File Offset: 0x0001D2D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 854374, RefRangeEnd = 854375, XrefRangeStart = 854266, XrefRangeEnd = 854374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyVersionedList(VersionedList<T> source)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyVersionedList<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600032F RID: 815 RVA: 0x0001F11C File Offset: 0x0001D31C
	public unsafe virtual ulong Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854375, XrefRangeEnd = 854378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0001F164 File Offset: 0x0001D364
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 854383, RefRangeEnd = 854384, XrefRangeStart = 854378, XrefRangeEnd = 854383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void MarkDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_MarkDirty_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0001F198 File Offset: 0x0001D398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854384, XrefRangeEnd = 854403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppArrayBase<T> ToArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854403, XrefRangeEnd = 854407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOf(T item)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x17000100 RID: 256
	public unsafe virtual T this[int index]
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 854408, RefRangeEnd = 854413, XrefRangeStart = 854407, XrefRangeEnd = 854408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0001F29C File Offset: 0x0001D49C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854413, XrefRangeEnd = 854416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Contains(T item)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0001F320 File Offset: 0x0001D520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854416, XrefRangeEnd = 854420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000336 RID: 822 RVA: 0x0001F370 File Offset: 0x0001D570
	public unsafe virtual int Count
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 854423, RefRangeEnd = 854450, XrefRangeStart = 854420, XrefRangeEnd = 854423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000337 RID: 823 RVA: 0x0001F3AC File Offset: 0x0001D5AC
	public unsafe bool IsReadOnly
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 854451, RefRangeEnd = 854462, XrefRangeStart = 854450, XrefRangeEnd = 854451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<T>.Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new List<T>.Enumerator(intPtr);
	}

	// Token: 0x06000339 RID: 825 RVA: 0x0001F420 File Offset: 0x0001D620
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854462, XrefRangeEnd = 854464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0001F460 File Offset: 0x0001D660
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600033B RID: 827 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
	public unsafe virtual ReadOnlyVersionedList<T> IVersionedList<T>.AsReadOnly
	{
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_IVersionedList_T__get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyVersionedList_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<T>>(intPtr3) : null;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600033C RID: 828 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
	public unsafe virtual bool System.Collections.ICollection.IsSynchronized
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854464, XrefRangeEnd = 854484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x0600033D RID: 829 RVA: 0x0001F51C File Offset: 0x0001D71C
	public unsafe virtual Object System.Collections.ICollection.SyncRoot
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854484, XrefRangeEnd = 854512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}
	}

	// Token: 0x0600033E RID: 830 RVA: 0x0001F55C File Offset: 0x0001D75C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 854512, XrefRangeEnd = 854515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyVersionedList<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600033F RID: 831 RVA: 0x0001F5AC File Offset: 0x0001D7AC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void updateItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReadOnlyVersionedList<T>.NativeMethodInfoPtr_updateItems_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000340 RID: 832 RVA: 0x000035AE File Offset: 0x000017AE
	public ReadOnlyVersionedList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000341 RID: 833 RVA: 0x0001F5E8 File Offset: 0x0001D7E8
	// (set) Token: 0x06000342 RID: 834 RVA: 0x000035B7 File Offset: 0x000017B7
	public unsafe VersionedList<T> source
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyVersionedList<T>.NativeFieldInfoPtr_source);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedList<T>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyVersionedList<T>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000241 RID: 577
	private static readonly IntPtr NativeFieldInfoPtr_source;

	// Token: 0x04000242 RID: 578
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000243 RID: 579
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

	// Token: 0x04000244 RID: 580
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyVersionedList_1_T_0;

	// Token: 0x04000245 RID: 581
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VersionedList_1_T_0;

	// Token: 0x04000246 RID: 582
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

	// Token: 0x04000247 RID: 583
	private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000248 RID: 584
	private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

	// Token: 0x04000249 RID: 585
	private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_0;

	// Token: 0x0400024A RID: 586
	private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

	// Token: 0x0400024B RID: 587
	private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

	// Token: 0x0400024C RID: 588
	private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_Int32_0;

	// Token: 0x0400024D RID: 589
	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400024E RID: 590
	private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

	// Token: 0x0400024F RID: 591
	private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

	// Token: 0x04000250 RID: 592
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

	// Token: 0x04000251 RID: 593
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

	// Token: 0x04000252 RID: 594
	private static readonly IntPtr NativeMethodInfoPtr_IVersionedList_T__get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyVersionedList_1_T_0;

	// Token: 0x04000253 RID: 595
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000254 RID: 596
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

	// Token: 0x04000255 RID: 597
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

	// Token: 0x04000256 RID: 598
	private static readonly IntPtr NativeMethodInfoPtr_updateItems_Protected_Virtual_New_Void_0;
}
