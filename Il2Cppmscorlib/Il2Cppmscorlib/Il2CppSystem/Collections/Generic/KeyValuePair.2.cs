using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004EE RID: 1262
	[Serializable]
	public sealed class KeyValuePair<TKey, TValue> : ValueType
	{
		// Token: 0x06004DB8 RID: 19896 RVA: 0x00168A0C File Offset: 0x00166C0C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePair()
		{
			Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyValuePair`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr);
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "key");
			KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, "value");
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100674972);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100674973);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100674974);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100674975);
			KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, 100674976);
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00168B18 File Offset: 0x00166D18
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1420620, RefRangeEnd = 1420636, XrefRangeStart = 1420618, XrefRangeEnd = 1420620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair(TKey key, TValue value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x00168BE8 File Offset: 0x00166DE8
		public unsafe TKey Key
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Key_Public_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06004DBB RID: 19899 RVA: 0x00168C28 File Offset: 0x00166E28
		public unsafe TValue Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_get_Value_Public_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x00168C68 File Offset: 0x00166E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420636, XrefRangeEnd = 1420641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x00168CA4 File Offset: 0x00166EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420641, XrefRangeEnd = 1420648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deconstruct(out TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr2;
				if (!typeof(TKey).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref key;
				}
				ptr2 = intPtr2;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(TValue).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref value;
			}
			ptr3 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(KeyValuePair<TKey, TValue>.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_TKey_byref_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(TKey).IsValueType)
			{
				IntPtr intPtr7 = intPtr;
				key = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<TKey>(intPtr7, false, false));
			}
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr8 = intPtr3;
				value = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr8, false, false));
			}
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x0001C206 File Offset: 0x0001A406
		public KeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x0001C20F File Offset: 0x0001A40F
		public KeyValuePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x00168D78 File Offset: 0x00166F78
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x00168DA0 File Offset: 0x00166FA0
		public unsafe TKey key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_key);
				Type typeFromHandle = typeof(TKey);
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

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x00168E48 File Offset: 0x00167048
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x00168E70 File Offset: 0x00167070
		public unsafe TValue value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValuePair<TKey, TValue>.NativeFieldInfoPtr_value);
				Type typeFromHandle = typeof(TValue);
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

		// Token: 0x04003F8A RID: 16266
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04003F8B RID: 16267
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04003F8C RID: 16268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TKey_TValue_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_TKey_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_TValue_0;

		// Token: 0x04003F8F RID: 16271
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_TKey_byref_TValue_0;
	}
}
