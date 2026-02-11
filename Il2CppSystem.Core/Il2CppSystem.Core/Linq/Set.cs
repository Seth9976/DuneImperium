using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200001E RID: 30
	public class Set<TElement> : Object
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00015588 File Offset: 0x00013788
		// Note: this type is marked as 'beforefieldinit'.
		static Set()
		{
			Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Set`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr);
			Set<TElement>.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "buckets");
			Set<TElement>.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "slots");
			Set<TElement>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "count");
			Set<TElement>.NativeFieldInfoPtr_freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "freeList");
			Set<TElement>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "comparer");
			Set<TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663763);
			Set<TElement>.NativeMethodInfoPtr_Add_Public_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663764);
			Set<TElement>.NativeMethodInfoPtr_Remove_Public_Boolean_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663765);
			Set<TElement>.NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663766);
			Set<TElement>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663767);
			Set<TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, 100663768);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000156D0 File Offset: 0x000138D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006408, RefRangeEnd = 1006409, XrefRangeStart = 1006388, XrefRangeEnd = 1006408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Set(IEqualityComparer<TElement> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001571C File Offset: 0x0001391C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1006410, RefRangeEnd = 1006412, XrefRangeStart = 1006409, XrefRangeEnd = 1006410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Add(TElement value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Add_Public_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000157A0 File Offset: 0x000139A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006412, XrefRangeEnd = 1006415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(TElement value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Remove_Public_Boolean_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00015824 File Offset: 0x00013A24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006427, RefRangeEnd = 1006428, XrefRangeStart = 1006415, XrefRangeEnd = 1006427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Find(TElement value, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000158B8 File Offset: 0x00013AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006428, XrefRangeEnd = 1006472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000158EC File Offset: 0x00013AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006472, XrefRangeEnd = 1006474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalGetHashCode(TElement value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TElement).IsValueType)
				{
					TElement telement = value;
					intPtr = ((telement is string) ? IL2CPP.ManagedStringToIl2Cpp(telement as string) : IL2CPP.Il2CppObjectBaseToPtr(telement as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Set<TElement>.NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002357 File Offset: 0x00000557
		public Set(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00015970 File Offset: 0x00013B70
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002360 File Offset: 0x00000560
		public unsafe Il2CppStructArray<int> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000159A0 File Offset: 0x00013BA0
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe Il2CppReferenceArray<Set<TElement>.Slot> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Set<TElement>.Slot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000159D0 File Offset: 0x00013BD0
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000239E File Offset: 0x0000059E
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000159F8 File Offset: 0x00013BF8
		// (set) Token: 0x0600013C RID: 316 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe int freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_freeList)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00015A20 File Offset: 0x00013C20
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000023D4 File Offset: 0x000005D4
		public unsafe IEqualityComparer<TElement> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_freeList;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TElement_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_TElement_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_TElement_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_Find_Private_Boolean_TElement_Boolean_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetHashCode_Internal_Int32_TElement_0;

		// Token: 0x020001B9 RID: 441
		public sealed class Slot : ValueType
		{
			// Token: 0x060015EE RID: 5614 RVA: 0x0006CE3C File Offset: 0x0006B03C
			// Note: this type is marked as 'beforefieldinit'.
			static Slot()
			{
				Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Set<TElement>>.NativeClassPtr, "Slot"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr);
				Set<TElement>.Slot.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "hashCode");
				Set<TElement>.Slot.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "value");
				Set<TElement>.Slot.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr, "next");
			}

			// Token: 0x060015EF RID: 5615 RVA: 0x0000924C File Offset: 0x0000744C
			public Slot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060015F0 RID: 5616 RVA: 0x00009255 File Offset: 0x00007455
			public Slot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Set<TElement>.Slot>.NativeClassPtr))
			{
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
			// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00009267 File Offset: 0x00007467
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0006CF08 File Offset: 0x0006B108
			// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0006CF30 File Offset: 0x0006B130
			public unsafe TElement value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(TElement);
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

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0006CFD8 File Offset: 0x0006B1D8
			// (set) Token: 0x060015F6 RID: 5622 RVA: 0x00009282 File Offset: 0x00007482
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Set<TElement>.Slot.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x04000F99 RID: 3993
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04000F9A RID: 3994
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000F9B RID: 3995
			private static readonly IntPtr NativeFieldInfoPtr_next;
		}
	}
}
