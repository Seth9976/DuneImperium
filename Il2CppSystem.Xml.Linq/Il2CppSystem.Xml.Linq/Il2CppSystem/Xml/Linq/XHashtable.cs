using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200000E RID: 14
	public sealed class XHashtable<TValue> : Object
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00005B88 File Offset: 0x00003D88
		// Note: this type is marked as 'beforefieldinit'.
		static XHashtable()
		{
			Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XHashtable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr);
			XHashtable<TValue>.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, "_state");
			XHashtable<TValue>.NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, 100663438);
			XHashtable<TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, 100663439);
			XHashtable<TValue>.NativeMethodInfoPtr_Add_Public_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, 100663440);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005C44 File Offset: 0x00003E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237992, RefRangeEnd = 1237994, XrefRangeStart = 1237983, XrefRangeEnd = 1237992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XHashtable(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extractKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1237996, RefRangeEnd = 1237998, XrefRangeStart = 1237994, XrefRangeEnd = 1237996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string key, int index, int count, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005D5C File Offset: 0x00003F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238005, RefRangeEnd = 1238007, XrefRangeStart = 1237998, XrefRangeEnd = 1238005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue Add(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.NativeMethodInfoPtr_Add_Public_TValue_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000231B File Offset: 0x0000051B
		public XHashtable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005DDC File Offset: 0x00003FDC
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002324 File Offset: 0x00000524
		public unsafe XHashtable<TValue>.XHashtableState _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.NativeFieldInfoPtr__state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XHashtable<TValue>.XHashtableState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.NativeFieldInfoPtr__state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_TValue_TValue_0;

		// Token: 0x02000025 RID: 37
		public sealed class ExtractKeyDelegate : MulticastDelegate
		{
			// Token: 0x060001C7 RID: 455 RVA: 0x000099DC File Offset: 0x00007BDC
			// Note: this type is marked as 'beforefieldinit'.
			static ExtractKeyDelegate()
			{
				Il2CppClassPointerStore<XHashtable<TValue>.ExtractKeyDelegate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, "ExtractKeyDelegate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				XHashtable<TValue>.ExtractKeyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.ExtractKeyDelegate>.NativeClassPtr, 100663441);
				XHashtable<TValue>.ExtractKeyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.ExtractKeyDelegate>.NativeClassPtr, 100663442);
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00009A60 File Offset: 0x00007C60
			[CallerCount(1058)]
			[CachedScanResults(RefRangeStart = 340122, RefRangeEnd = 341180, XrefRangeStart = 340122, XrefRangeEnd = 341180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExtractKeyDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XHashtable<TValue>.ExtractKeyDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.ExtractKeyDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00009ABC File Offset: 0x00007CBC
			[CallerCount(0)]
			public unsafe string Invoke(TValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = value;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.ExtractKeyDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.Il2CppStringToManaged(intPtr2);
				}
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00002AC1 File Offset: 0x00000CC1
			public ExtractKeyDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00002ACA File Offset: 0x00000CCA
			public static implicit operator XHashtable<TValue>.ExtractKeyDelegate(Func<TValue, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<XHashtable<TValue>.ExtractKeyDelegate>(A_0);
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00002AD2 File Offset: 0x00000CD2
			public static XHashtable<TValue>.ExtractKeyDelegate operator +(XHashtable<TValue>.ExtractKeyDelegate A_0, XHashtable<TValue>.ExtractKeyDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XHashtable<TValue>.ExtractKeyDelegate>();
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00002AE0 File Offset: 0x00000CE0
			public static XHashtable<TValue>.ExtractKeyDelegate operator -(XHashtable<TValue>.ExtractKeyDelegate A_0, XHashtable<TValue>.ExtractKeyDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XHashtable<TValue>.ExtractKeyDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000148 RID: 328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000149 RID: 329
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_TValue_0;
		}

		// Token: 0x02000026 RID: 38
		public sealed class XHashtableState : Object
		{
			// Token: 0x060001CE RID: 462 RVA: 0x00009B3C File Offset: 0x00007D3C
			// Note: this type is marked as 'beforefieldinit'.
			static XHashtableState()
			{
				Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XHashtable<TValue>>.NativeClassPtr, "XHashtableState"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr);
				XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, "_buckets");
				XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, "_entries");
				XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__numEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, "_numEntries");
				XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__extractKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, "_extractKey");
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663443);
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_Resize_Public_XHashtableState_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663444);
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663445);
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_TryAdd_Public_Boolean_TValue_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663446);
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_FindEntry_Private_Boolean_Int32_String_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663447);
				XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_ComputeHashCode_Private_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, 100663448);
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00009C6C File Offset: 0x00007E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237936, XrefRangeEnd = 1237954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XHashtableState(XHashtable<TValue>.ExtractKeyDelegate extractKey, int capacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(extractKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00009CC8 File Offset: 0x00007EC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1237964, RefRangeEnd = 1237965, XrefRangeStart = 1237954, XrefRangeEnd = 1237964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XHashtable<TValue>.XHashtableState Resize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_Resize_Public_XHashtableState_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XHashtable<TValue>.XHashtableState>(intPtr3) : null;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x00009D08 File Offset: 0x00007F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237965, XrefRangeEnd = 1237967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryGetValue(string key, int index, int count, out TValue value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(TValue).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x00009DC4 File Offset: 0x00007FC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1237975, RefRangeEnd = 1237977, XrefRangeStart = 1237967, XrefRangeEnd = 1237975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryAdd(TValue value, out TValue newValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = value;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
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
					intPtr3 = ref newValue;
				}
				ptr3 = intPtr3;
				IntPtr intPtr5;
				IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_TryAdd_Public_Boolean_TValue_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
				Il2CppException.RaiseExceptionIfNecessary(intPtr5);
				if (!typeof(TValue).IsValueType)
				{
					IntPtr intPtr6 = intPtr2;
					newValue = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr4);
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x00009E98 File Offset: 0x00008098
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1237979, RefRangeEnd = 1237982, XrefRangeStart = 1237977, XrefRangeEnd = 1237979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref hashCode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entryIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_FindEntry_Private_Boolean_Int32_String_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x00009F20 File Offset: 0x00008120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237982, XrefRangeEnd = 1237983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int ComputeHashCode(string key, int index, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XHashtable<TValue>.XHashtableState.NativeMethodInfoPtr_ComputeHashCode_Private_Static_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00002AF1 File Offset: 0x00000CF1
			public XHashtableState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00009F80 File Offset: 0x00008180
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002AFA File Offset: 0x00000CFA
			public unsafe Il2CppStructArray<int> _buckets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__buckets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00009FB0 File Offset: 0x000081B0
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002B19 File Offset: 0x00000D19
			public unsafe Il2CppReferenceArray<XHashtable<TValue>.XHashtableState.Entry> _entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XHashtable<TValue>.XHashtableState.Entry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00009FE0 File Offset: 0x000081E0
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002B38 File Offset: 0x00000D38
			public unsafe int _numEntries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__numEntries);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__numEntries)) = value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A008 File Offset: 0x00008208
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00002B53 File Offset: 0x00000D53
			public unsafe XHashtable<TValue>.ExtractKeyDelegate _extractKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__extractKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XHashtable<TValue>.ExtractKeyDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.NativeFieldInfoPtr__extractKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014A RID: 330
			private static readonly IntPtr NativeFieldInfoPtr__buckets;

			// Token: 0x0400014B RID: 331
			private static readonly IntPtr NativeFieldInfoPtr__entries;

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeFieldInfoPtr__numEntries;

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeFieldInfoPtr__extractKey;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExtractKeyDelegate_TValue_Int32_0;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_XHashtableState_TValue_0;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_Int32_Int32_byref_TValue_0;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TValue_byref_TValue_0;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_Boolean_Int32_String_Int32_Int32_byref_Int32_0;

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeMethodInfoPtr_ComputeHashCode_Private_Static_Int32_String_Int32_Int32_0;

			// Token: 0x02000029 RID: 41
			public sealed class Entry : ValueType
			{
				// Token: 0x060001EA RID: 490 RVA: 0x0000A208 File Offset: 0x00008408
				// Note: this type is marked as 'beforefieldinit'.
				static Entry()
				{
					Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr);
					XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr, "Value");
					XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr, "HashCode");
					XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr, "Next");
				}

				// Token: 0x060001EB RID: 491 RVA: 0x00002BF3 File Offset: 0x00000DF3
				public Entry(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060001EC RID: 492 RVA: 0x00002BFC File Offset: 0x00000DFC
				public Entry()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XHashtable<TValue>.XHashtableState.Entry>.NativeClassPtr))
				{
				}

				// Token: 0x17000085 RID: 133
				// (get) Token: 0x060001ED RID: 493 RVA: 0x0000A2AC File Offset: 0x000084AC
				// (set) Token: 0x060001EE RID: 494 RVA: 0x0000A2D4 File Offset: 0x000084D4
				public unsafe TValue Value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Value);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Value);
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

				// Token: 0x17000086 RID: 134
				// (get) Token: 0x060001EF RID: 495 RVA: 0x0000A37C File Offset: 0x0000857C
				// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002C0E File Offset: 0x00000E0E
				public unsafe int HashCode
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_HashCode);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_HashCode)) = value;
					}
				}

				// Token: 0x17000087 RID: 135
				// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000A3A4 File Offset: 0x000085A4
				// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002C29 File Offset: 0x00000E29
				public unsafe int Next
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Next);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XHashtable<TValue>.XHashtableState.Entry.NativeFieldInfoPtr_Next)) = value;
					}
				}

				// Token: 0x0400015A RID: 346
				private static readonly IntPtr NativeFieldInfoPtr_Value;

				// Token: 0x0400015B RID: 347
				private static readonly IntPtr NativeFieldInfoPtr_HashCode;

				// Token: 0x0400015C RID: 348
				private static readonly IntPtr NativeFieldInfoPtr_Next;
			}
		}
	}
}
