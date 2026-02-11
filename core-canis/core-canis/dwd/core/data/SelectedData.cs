using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001CB RID: 459
	public class SelectedData<T> : VersionedDataComponent
	{
		// Token: 0x06001970 RID: 6512 RVA: 0x00078E28 File Offset: 0x00077028
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedData()
		{
			Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "SelectedData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr);
			SelectedData<T>.NativeFieldInfoPtr_OnSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, "OnSelectionChanged");
			SelectedData<T>.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, "selected");
			SelectedData<T>.NativeMethodInfoPtr_add_OnSelectionChanged_Public_add_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667337);
			SelectedData<T>.NativeMethodInfoPtr_remove_OnSelectionChanged_Public_rem_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667338);
			SelectedData<T>.NativeMethodInfoPtr_get_Selected_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667339);
			SelectedData<T>.NativeMethodInfoPtr_set_Selected_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667340);
			SelectedData<T>.NativeMethodInfoPtr_setSelected_Protected_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667341);
			SelectedData<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667342);
			SelectedData<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667343);
			SelectedData<T>.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, 100667344);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00078F5C File Offset: 0x0007715C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 881338, RefRangeEnd = 881341, XrefRangeStart = 881333, XrefRangeEnd = 881338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSelectionChanged(Action<T> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.NativeMethodInfoPtr_add_OnSelectionChanged_Public_add_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00078FA0 File Offset: 0x000771A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881341, XrefRangeEnd = 881346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSelectionChanged(Action<T> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.NativeMethodInfoPtr_remove_OnSelectionChanged_Public_rem_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00078FE4 File Offset: 0x000771E4
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00079020 File Offset: 0x00077220
		public unsafe T Selected
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.NativeMethodInfoPtr_get_Selected_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(49)]
			[CachedScanResults(RefRangeStart = 283239, RefRangeEnd = 283288, XrefRangeStart = 283239, XrefRangeEnd = 283288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.NativeMethodInfoPtr_set_Selected_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00079098 File Offset: 0x00077298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881346, XrefRangeEnd = 881349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void setSelected(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedData<T>.NativeMethodInfoPtr_setSelected_Protected_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0007911C File Offset: 0x0007731C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 881383, RefRangeEnd = 881394, XrefRangeStart = 881349, XrefRangeEnd = 881383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedData(T initialSelection = default(T))
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = initialSelection;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref initialSelection;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x000791A0 File Offset: 0x000773A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881394, XrefRangeEnd = 881397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedData<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000791E4 File Offset: 0x000773E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881397, XrefRangeEnd = 881400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedData<T>.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0000B28E File Offset: 0x0000948E
		public SelectedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x00079230 File Offset: 0x00077430
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0000B297 File Offset: 0x00009497
		public unsafe Action<T> OnSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedData<T>.NativeFieldInfoPtr_OnSelectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedData<T>.NativeFieldInfoPtr_OnSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00079260 File Offset: 0x00077460
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x00079288 File Offset: 0x00077488
		public unsafe T selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedData<T>.NativeFieldInfoPtr_selected);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedData<T>.NativeFieldInfoPtr_selected);
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

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_OnSelectionChanged;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSelectionChanged_Public_add_Void_Action_1_T_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSelectionChanged_Public_rem_Void_Action_1_T_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_get_Selected_Public_get_T_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_set_Selected_Public_set_Void_T_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_setSelected_Protected_Virtual_New_Void_T_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x02000364 RID: 868
		[ObfuscatedName("dwd.core.data.SelectedData`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060027A0 RID: 10144 RVA: 0x000A7FE0 File Offset: 0x000A61E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectedData<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr);
				SelectedData<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr, "<>9");
				SelectedData<T>.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr, "<>9__8_0");
				SelectedData<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr, 100667346);
				SelectedData<T>.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr, 100667347);
			}

			// Token: 0x060027A1 RID: 10145 RVA: 0x000A8098 File Offset: 0x000A6298
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedData<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027A2 RID: 10146 RVA: 0x000A80D4 File Offset: 0x000A62D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__8_0(T <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = <p0>;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref <p0>;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SelectedData<T>.__c.NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060027A3 RID: 10147 RVA: 0x00012005 File Offset: 0x00010205
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000A814C File Offset: 0x000A634C
			// (set) Token: 0x060027A5 RID: 10149 RVA: 0x0001200E File Offset: 0x0001020E
			public unsafe static SelectedData<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedData<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectedData<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedData<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000A8174 File Offset: 0x000A6374
			// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00012020 File Offset: 0x00010220
			public unsafe static Action<T> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectedData<T>.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectedData<T>.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AE9 RID: 6889
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001AEA RID: 6890
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04001AEB RID: 6891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AEC RID: 6892
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__8_0_Internal_Void_T_0;
		}
	}
}
