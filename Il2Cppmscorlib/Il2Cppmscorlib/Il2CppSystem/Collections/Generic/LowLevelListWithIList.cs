using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FD RID: 1277
	public sealed class LowLevelListWithIList<T> : LowLevelList<T>
	{
		// Token: 0x06004ECC RID: 20172 RVA: 0x0016DD88 File Offset: 0x0016BF88
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelListWithIList()
		{
			Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "LowLevelListWithIList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr);
			LowLevelListWithIList<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, 100675159);
			LowLevelListWithIList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, 100675160);
			LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, 100675161);
			LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, 100675162);
			LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, 100675163);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x0016DE58 File Offset: 0x0016C058
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1425856, RefRangeEnd = 1425861, XrefRangeStart = 1425849, XrefRangeEnd = 1425856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelListWithIList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x0016DE94 File Offset: 0x0016C094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1425876, RefRangeEnd = 1425877, XrefRangeStart = 1425861, XrefRangeEnd = 1425876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelListWithIList(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x0016DEDC File Offset: 0x0016C0DC
		public unsafe bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x0016DF18 File Offset: 0x0016C118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425877, XrefRangeEnd = 1425879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0016DF58 File Offset: 0x0016C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x0001C6F9 File Offset: 0x0001A8F9
		public LowLevelListWithIList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004053 RID: 16467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004054 RID: 16468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004055 RID: 16469
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004056 RID: 16470
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x04004057 RID: 16471
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200070F RID: 1807
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005FF5 RID: 24565 RVA: 0x001B1400 File Offset: 0x001AF600
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LowLevelListWithIList<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr);
				LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, "_list");
				LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, "_index");
				LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, "_version");
				LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, "_current");
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_LowLevelListWithIList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675164);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675165);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675166);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675167);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675168);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675169);
				LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr, 100675170);
			}

			// Token: 0x06005FF6 RID: 24566 RVA: 0x001B1544 File Offset: 0x001AF744
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1425845, RefRangeEnd = 1425847, XrefRangeStart = 1425844, XrefRangeEnd = 1425845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(LowLevelListWithIList<T> list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_LowLevelListWithIList_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005FF7 RID: 24567 RVA: 0x001B1594 File Offset: 0x001AF794
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FF8 RID: 24568 RVA: 0x001B15CC File Offset: 0x001AF7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425847, XrefRangeEnd = 1425848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005FF9 RID: 24569 RVA: 0x001B1610 File Offset: 0x001AF810
			[CallerCount(0)]
			public unsafe bool MoveNextRare()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018D4 RID: 6356
			// (get) Token: 0x06005FFA RID: 24570 RVA: 0x001B1654 File Offset: 0x001AF854
			public unsafe T Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170018D5 RID: 6357
			// (get) Token: 0x06005FFB RID: 24571 RVA: 0x001B1694 File Offset: 0x001AF894
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425848, XrefRangeEnd = 1425849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005FFC RID: 24572 RVA: 0x001B16D8 File Offset: 0x001AF8D8
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelListWithIList<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005FFD RID: 24573 RVA: 0x00023105 File Offset: 0x00021305
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005FFE RID: 24574 RVA: 0x0002310E File Offset: 0x0002130E
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelListWithIList<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170018D0 RID: 6352
			// (get) Token: 0x06005FFF RID: 24575 RVA: 0x001B1710 File Offset: 0x001AF910
			// (set) Token: 0x06006000 RID: 24576 RVA: 0x00023120 File Offset: 0x00021320
			public unsafe LowLevelListWithIList<T> _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelListWithIList<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018D1 RID: 6353
			// (get) Token: 0x06006001 RID: 24577 RVA: 0x001B1740 File Offset: 0x001AF940
			// (set) Token: 0x06006002 RID: 24578 RVA: 0x0002313F File Offset: 0x0002133F
			public unsafe int _index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__index)) = value;
				}
			}

			// Token: 0x170018D2 RID: 6354
			// (get) Token: 0x06006003 RID: 24579 RVA: 0x001B1768 File Offset: 0x001AF968
			// (set) Token: 0x06006004 RID: 24580 RVA: 0x0002315A File Offset: 0x0002135A
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170018D3 RID: 6355
			// (get) Token: 0x06006005 RID: 24581 RVA: 0x001B1790 File Offset: 0x001AF990
			// (set) Token: 0x06006006 RID: 24582 RVA: 0x001B17B8 File Offset: 0x001AF9B8
			public unsafe T _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LowLevelListWithIList<T>.Enumerator.NativeFieldInfoPtr__current);
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

			// Token: 0x04004DF3 RID: 19955
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04004DF4 RID: 19956
			private static readonly IntPtr NativeFieldInfoPtr__index;

			// Token: 0x04004DF5 RID: 19957
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04004DF6 RID: 19958
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04004DF7 RID: 19959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LowLevelListWithIList_1_T_0;

			// Token: 0x04004DF8 RID: 19960
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004DF9 RID: 19961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004DFA RID: 19962
			private static readonly IntPtr NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0;

			// Token: 0x04004DFB RID: 19963
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004DFC RID: 19964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004DFD RID: 19965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
