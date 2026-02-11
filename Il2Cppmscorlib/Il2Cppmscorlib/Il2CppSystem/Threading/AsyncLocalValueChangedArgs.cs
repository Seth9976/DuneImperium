using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000184 RID: 388
	public sealed class AsyncLocalValueChangedArgs<T> : ValueType
	{
		// Token: 0x060019E5 RID: 6629 RVA: 0x0009FB80 File Offset: 0x0009DD80
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocalValueChangedArgs()
		{
			Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocalValueChangedArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr);
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<PreviousValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<CurrentValue>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, "<ThreadContextChanged>k__BackingField");
			AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr, 100667828);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0009FC3C File Offset: 0x0009DE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351499, XrefRangeEnd = 1351501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncLocalValueChangedArgs(T previousValue, T currentValue, bool contextChanged)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = previousValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref previousValue;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = currentValue;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref currentValue;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncLocalValueChangedArgs<T>.NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000083E4 File Offset: 0x000065E4
		public AsyncLocalValueChangedArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000083ED File Offset: 0x000065ED
		public AsyncLocalValueChangedArgs()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocalValueChangedArgs<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0009FD18 File Offset: 0x0009DF18
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0009FD40 File Offset: 0x0009DF40
		public unsafe T _PreviousValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__PreviousValue_k__BackingField);
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

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0009FDE8 File Offset: 0x0009DFE8
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0009FE10 File Offset: 0x0009E010
		public unsafe T _CurrentValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__CurrentValue_k__BackingField);
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

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0009FEB8 File Offset: 0x0009E0B8
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x000083FF File Offset: 0x000065FF
		public unsafe bool _ThreadContextChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocalValueChangedArgs<T>.NativeFieldInfoPtr__ThreadContextChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr__PreviousValue_k__BackingField;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr__ThreadContextChanged_k__BackingField;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_T_T_Boolean_0;
	}
}
