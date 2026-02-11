using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
[ObfuscatedName("<>f__AnonymousType0`2")]
public sealed class __f__AnonymousType0<_entry_j__TPar, _value_j__TPar> : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x0001D244 File Offset: 0x0001B444
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType0()
	{
		Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("dbg-client.dll", "", "<>f__AnonymousType0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_entry_j__TPar>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_value_j__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__entry_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, "<entry>i__Field");
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__value_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, "<value>i__Field");
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_get_entry_Public_get__entry_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663297);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_get_value_Public_get__value_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663298);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__entry_j__TPar__value_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663299);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663300);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663301);
		__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr, 100663302);
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000002 RID: 2 RVA: 0x0001D364 File Offset: 0x0001B564
	public unsafe _entry_j__TPar entry
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_get_entry_Public_get__entry_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_entry_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000003 RID: 3 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
	public unsafe _value_j__TPar value
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_get_value_Public_get__value_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_value_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0001D3DC File Offset: 0x0001B5DC
	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __f__AnonymousType0(_entry_j__TPar entry, _value_j__TPar value)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(_entry_j__TPar).IsValueType)
			{
				_entry_j__TPar entry_j__TPar = entry;
				intPtr = ((entry_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(entry_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(entry_j__TPar as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref entry;
			}
			ptr2 = intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(_value_j__TPar).IsValueType)
		{
			_value_j__TPar value_j__TPar = value;
			intPtr2 = ((value_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(value_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(value_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref value;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__entry_j__TPar__value_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494284, XrefRangeEnd = 494289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494289, XrefRangeEnd = 494291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0001D534 File Offset: 0x0001B734
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494291, XrefRangeEnd = 494315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	public __f__AnonymousType0(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000009 RID: 9 RVA: 0x0001D56C File Offset: 0x0001B76C
	// (set) Token: 0x0600000A RID: 10 RVA: 0x0001D594 File Offset: 0x0001B794
	public unsafe _entry_j__TPar _entry_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__entry_i__Field);
			return IL2CPP.PointerToValueGeneric<_entry_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__entry_i__Field);
			Type typeFromHandle = typeof(_entry_j__TPar);
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

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000B RID: 11 RVA: 0x0001D63C File Offset: 0x0001B83C
	// (set) Token: 0x0600000C RID: 12 RVA: 0x0001D664 File Offset: 0x0001B864
	public unsafe _value_j__TPar _value_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__value_i__Field);
			return IL2CPP.PointerToValueGeneric<_value_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType0<_entry_j__TPar, _value_j__TPar>.NativeFieldInfoPtr__value_i__Field);
			Type typeFromHandle = typeof(_value_j__TPar);
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

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr__entry_i__Field;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr__value_i__Field;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_get_entry_Public_get__entry_j__TPar_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get__value_j__TPar_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__entry_j__TPar__value_j__TPar_0;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
