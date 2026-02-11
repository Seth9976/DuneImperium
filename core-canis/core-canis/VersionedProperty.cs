using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200003A RID: 58
public sealed class VersionedProperty<T> : Object
{
	// Token: 0x060004AC RID: 1196 RVA: 0x00025CA8 File Offset: 0x00023EA8
	// Note: this type is marked as 'beforefieldinit'.
	static VersionedProperty()
	{
		Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "VersionedProperty`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr);
		VersionedProperty<T>.NativeFieldInfoPtr_onDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, "onDirty");
		VersionedProperty<T>.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, "_Value");
		VersionedProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, 100663976);
		VersionedProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, 100663977);
		VersionedProperty<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, 100663978);
		VersionedProperty<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, 100663979);
		VersionedProperty<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_VersionedProperty_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr, 100663980);
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00025DA0 File Offset: 0x00023FA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857051, XrefRangeEnd = 857056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedProperty(Action onDirty)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDirty);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00025DEC File Offset: 0x00023FEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857056, XrefRangeEnd = 857063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedProperty(Action onDirty, T initialVal)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedProperty<T>>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDirty);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = initialVal;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref initialVal;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedProperty<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060004AF RID: 1199 RVA: 0x00025E80 File Offset: 0x00024080
	// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00025EBC File Offset: 0x000240BC
	public unsafe T Value
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857063, XrefRangeEnd = 857067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedProperty<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857067, XrefRangeEnd = 857086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedProperty<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00025F34 File Offset: 0x00024134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857086, XrefRangeEnd = 857091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator T(VersionedProperty<T> prop)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedProperty<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_VersionedProperty_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x00003C0B File Offset: 0x00001E0B
	public VersionedProperty(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00025F74 File Offset: 0x00024174
	// (set) Token: 0x060004B4 RID: 1204 RVA: 0x00003C14 File Offset: 0x00001E14
	public unsafe Action onDirty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedProperty<T>.NativeFieldInfoPtr_onDirty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedProperty<T>.NativeFieldInfoPtr_onDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00025FA4 File Offset: 0x000241A4
	// (set) Token: 0x060004B6 RID: 1206 RVA: 0x00025FCC File Offset: 0x000241CC
	public unsafe T _Value
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedProperty<T>.NativeFieldInfoPtr__Value);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedProperty<T>.NativeFieldInfoPtr__Value);
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

	// Token: 0x04000368 RID: 872
	private static readonly IntPtr NativeFieldInfoPtr_onDirty;

	// Token: 0x04000369 RID: 873
	private static readonly IntPtr NativeFieldInfoPtr__Value;

	// Token: 0x0400036A RID: 874
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

	// Token: 0x0400036B RID: 875
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_T_0;

	// Token: 0x0400036C RID: 876
	private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

	// Token: 0x0400036D RID: 877
	private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

	// Token: 0x0400036E RID: 878
	private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_VersionedProperty_1_T_0;
}
