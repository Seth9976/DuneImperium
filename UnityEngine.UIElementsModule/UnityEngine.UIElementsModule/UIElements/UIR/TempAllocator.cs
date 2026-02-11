using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200026C RID: 620
	public class TempAllocator<T> : Object where T : new()
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x000C40D4 File Offset: 0x000C22D4
		// Note: this type is marked as 'beforefieldinit'.
		static TempAllocator()
		{
			Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "TempAllocator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr);
			TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMinCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "m_ExcessMinCapacity");
			TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMaxCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "m_ExcessMaxCapacity");
			TempAllocator<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "m_Pool");
			TempAllocator<T>.NativeFieldInfoPtr_m_Excess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "m_Excess");
			TempAllocator<T>.NativeFieldInfoPtr_m_NextExcessSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "m_NextExcessSize");
			TempAllocator<T>.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "<disposed>k__BackingField");
			TempAllocator<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100669995);
			TempAllocator<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100669996);
			TempAllocator<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100669997);
			TempAllocator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100669998);
			TempAllocator<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100669999);
			TempAllocator<T>.NativeMethodInfoPtr_Alloc_Public_NativeSlice_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100670000);
			TempAllocator<T>.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100670001);
			TempAllocator<T>.NativeMethodInfoPtr_ReleaseExcess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, 100670002);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x000C4258 File Offset: 0x000C2458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351695, RefRangeEnd = 351697, XrefRangeStart = 351683, XrefRangeEnd = 351695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TempAllocator(int poolCapacity, int excessMinCapacity, int excessMaxCapacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref poolCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excessMinCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excessMaxCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000C42BC File Offset: 0x000C24BC
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x000C42F8 File Offset: 0x000C24F8
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x000C4338 File Offset: 0x000C2538
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351703, RefRangeEnd = 351706, XrefRangeStart = 351697, XrefRangeEnd = 351703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000C436C File Offset: 0x000C256C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351706, XrefRangeEnd = 351708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000C43AC File Offset: 0x000C25AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 351727, RefRangeEnd = 351732, XrefRangeStart = 351708, XrefRangeEnd = 351727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSlice<T> Alloc(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_Alloc_Public_NativeSlice_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new NativeSlice<T>(intPtr);
			}
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000C43F0 File Offset: 0x000C25F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351733, RefRangeEnd = 351735, XrefRangeStart = 351732, XrefRangeEnd = 351733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000C4424 File Offset: 0x000C2624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351742, RefRangeEnd = 351745, XrefRangeStart = 351735, XrefRangeEnd = 351742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseExcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TempAllocator<T>.NativeMethodInfoPtr_ReleaseExcess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00012DE9 File Offset: 0x00010FE9
		public TempAllocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x000C4458 File Offset: 0x000C2658
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00012DF2 File Offset: 0x00010FF2
		public unsafe int m_ExcessMinCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMinCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMinCapacity)) = value;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000C4480 File Offset: 0x000C2680
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x00012E0D File Offset: 0x0001100D
		public unsafe int m_ExcessMaxCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMaxCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_ExcessMaxCapacity)) = value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000C44A8 File Offset: 0x000C26A8
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00012E28 File Offset: 0x00011028
		public TempAllocator<T>.Page m_Pool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_Pool);
				return new TempAllocator<T>.Page(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000C44D8 File Offset: 0x000C26D8
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00012E56 File Offset: 0x00011056
		public unsafe List<TempAllocator<T>.Page> m_Excess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_Excess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TempAllocator<T>.Page>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_Excess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x000C4508 File Offset: 0x000C2708
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00012E75 File Offset: 0x00011075
		public unsafe int m_NextExcessSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_NextExcessSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr_m_NextExcessSize)) = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x000C4530 File Offset: 0x000C2730
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00012E90 File Offset: 0x00011090
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x04002105 RID: 8453
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcessMinCapacity;

		// Token: 0x04002106 RID: 8454
		private static readonly IntPtr NativeFieldInfoPtr_m_ExcessMaxCapacity;

		// Token: 0x04002107 RID: 8455
		private static readonly IntPtr NativeFieldInfoPtr_m_Pool;

		// Token: 0x04002108 RID: 8456
		private static readonly IntPtr NativeFieldInfoPtr_m_Excess;

		// Token: 0x04002109 RID: 8457
		private static readonly IntPtr NativeFieldInfoPtr_m_NextExcessSize;

		// Token: 0x0400210A RID: 8458
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400210B RID: 8459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x0400210C RID: 8460
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x0400210D RID: 8461
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x0400210E RID: 8462
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400210F RID: 8463
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Void_Boolean_0;

		// Token: 0x04002110 RID: 8464
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Public_NativeSlice_1_T_Int32_0;

		// Token: 0x04002111 RID: 8465
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002112 RID: 8466
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseExcess_Private_Void_0;

		// Token: 0x0200055B RID: 1371
		public sealed class Page : ValueType
		{
			// Token: 0x060041DB RID: 16859 RVA: 0x00103568 File Offset: 0x00101768
			// Note: this type is marked as 'beforefieldinit'.
			static Page()
			{
				Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TempAllocator<T>>.NativeClassPtr, "Page"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr);
				TempAllocator<T>.Page.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr, "array");
				TempAllocator<T>.Page.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr, "used");
			}

			// Token: 0x060041DC RID: 16860 RVA: 0x0001C006 File Offset: 0x0001A206
			public Page(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060041DD RID: 16861 RVA: 0x0001C00F File Offset: 0x0001A20F
			public Page()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TempAllocator<T>.Page>.NativeClassPtr))
			{
			}

			// Token: 0x170013BD RID: 5053
			// (get) Token: 0x060041DE RID: 16862 RVA: 0x001035F8 File Offset: 0x001017F8
			// (set) Token: 0x060041DF RID: 16863 RVA: 0x0001C021 File Offset: 0x0001A221
			public NativeArray<T> array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.Page.NativeFieldInfoPtr_array);
					return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.Page.NativeFieldInfoPtr_array), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170013BE RID: 5054
			// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00103628 File Offset: 0x00101828
			// (set) Token: 0x060041E1 RID: 16865 RVA: 0x0001C04F File Offset: 0x0001A24F
			public unsafe int used
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.Page.NativeFieldInfoPtr_used);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TempAllocator<T>.Page.NativeFieldInfoPtr_used)) = value;
				}
			}

			// Token: 0x04002E35 RID: 11829
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x04002E36 RID: 11830
			private static readonly IntPtr NativeFieldInfoPtr_used;
		}
	}
}
