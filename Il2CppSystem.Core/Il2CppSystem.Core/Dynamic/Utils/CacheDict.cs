using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x02000126 RID: 294
	public sealed class CacheDict<TKey, TValue> : Object
	{
		// Token: 0x06001146 RID: 4422 RVA: 0x0005A504 File Offset: 0x00058704
		// Note: this type is marked as 'beforefieldinit'.
		static CacheDict()
		{
			Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "CacheDict`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr);
			CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "_mask");
			CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "_entries");
			CacheDict<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100666574);
			CacheDict<TKey, TValue>.NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100666575);
			CacheDict<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100666576);
			CacheDict<TKey, TValue>.NativeMethodInfoPtr_Add_Internal_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100666577);
			CacheDict<TKey, TValue>.NativeMethodInfoPtr_set_Item_Internal_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, 100666578);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0005A610 File Offset: 0x00058810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029598, RefRangeEnd = 1029600, XrefRangeStart = 1029590, XrefRangeEnd = 1029598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CacheDict(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005A658 File Offset: 0x00058858
		[CallerCount(0)]
		public unsafe static int AlignSize(int size)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0005A698 File Offset: 0x00058898
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1029602, RefRangeEnd = 1029606, XrefRangeStart = 1029600, XrefRangeEnd = 1029602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0005A76C File Offset: 0x0005896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029606, XrefRangeEnd = 1029612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr_Add_Internal_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x17000542 RID: 1346
		public unsafe TKey this[TKey key]
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1029618, RefRangeEnd = 1029622, XrefRangeStart = 1029612, XrefRangeEnd = 1029618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.NativeMethodInfoPtr_set_Item_Internal_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000074D9 File Offset: 0x000056D9
		public CacheDict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0005A8EC File Offset: 0x00058AEC
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x000074E2 File Offset: 0x000056E2
		public unsafe int _mask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__mask)) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0005A914 File Offset: 0x00058B14
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x000074FD File Offset: 0x000056FD
		public unsafe Il2CppReferenceArray<CacheDict<TKey, TValue>.Entry> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CacheDict<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeFieldInfoPtr__mask;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_AlignSize_Private_Static_Int32_Int32_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Internal_Boolean_TKey_byref_TValue_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_TKey_TValue_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_TKey_TValue_0;

		// Token: 0x0200034A RID: 842
		public sealed class Entry : Object
		{
			// Token: 0x06001C0C RID: 7180 RVA: 0x0008471C File Offset: 0x0008291C
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CacheDict<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr);
				CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr, "_hash");
				CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr, "_key");
				CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr, "_value");
				CacheDict<TKey, TValue>.Entry.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr, 100666579);
			}

			// Token: 0x06001C0D RID: 7181 RVA: 0x000847E4 File Offset: 0x000829E4
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 425621, RefRangeEnd = 425634, XrefRangeStart = 425621, XrefRangeEnd = 425634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(int hash, TKey key, TValue value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CacheDict<TKey, TValue>.Entry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hash;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CacheDict<TKey, TValue>.Entry.NativeMethodInfoPtr__ctor_Internal_Void_Int32_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x06001C0E RID: 7182 RVA: 0x0000AB5F File Offset: 0x00008D5F
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001C0F RID: 7183 RVA: 0x000848BC File Offset: 0x00082ABC
			// (set) Token: 0x06001C10 RID: 7184 RVA: 0x0000AB68 File Offset: 0x00008D68
			public unsafe int _hash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__hash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__hash)) = value;
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06001C11 RID: 7185 RVA: 0x000848E4 File Offset: 0x00082AE4
			// (set) Token: 0x06001C12 RID: 7186 RVA: 0x0008490C File Offset: 0x00082B0C
			public unsafe TKey _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__key);
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

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001C13 RID: 7187 RVA: 0x000849B4 File Offset: 0x00082BB4
			// (set) Token: 0x06001C14 RID: 7188 RVA: 0x000849DC File Offset: 0x00082BDC
			public unsafe TValue _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CacheDict<TKey, TValue>.Entry.NativeFieldInfoPtr__value);
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

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeFieldInfoPtr__hash;

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_TKey_TValue_0;
		}
	}
}
