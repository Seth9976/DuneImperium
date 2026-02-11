using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000205 RID: 517
	public sealed class NumericalFilter : ValueType
	{
		// Token: 0x060019DF RID: 6623 RVA: 0x0007CEB4 File Offset: 0x0007B0B4
		// Note: this type is marked as 'beforefieldinit'.
		static NumericalFilter()
		{
			Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NumericalFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr);
			NumericalFilter.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, "<Key>k__BackingField");
			NumericalFilter.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, "<Value>k__BackingField");
			NumericalFilter.NativeFieldInfoPtr__Comparer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, "<Comparer>k__BackingField");
			NumericalFilter.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668031);
			NumericalFilter.NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668032);
			NumericalFilter.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668033);
			NumericalFilter.NativeMethodInfoPtr_set_Value_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668034);
			NumericalFilter.NativeMethodInfoPtr_get_Comparer_Public_get_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668035);
			NumericalFilter.NativeMethodInfoPtr_set_Comparer_Internal_set_Void_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668036);
			NumericalFilter.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_LobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr, 100668037);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0007CFAC File Offset: 0x0007B1AC
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		public unsafe string Key
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0007D030 File Offset: 0x0007B230
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0007D074 File Offset: 0x0007B274
		public unsafe int Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_set_Value_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0007D0B8 File Offset: 0x0007B2B8
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0007D0FC File Offset: 0x0007B2FC
		public unsafe LobbyComparison Comparer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_get_Comparer_Public_get_LobbyComparison_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr_set_Comparer_Internal_set_Void_LobbyComparison_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0007D140 File Offset: 0x0007B340
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 745917, RefRangeEnd = 745928, XrefRangeStart = 745917, XrefRangeEnd = 745928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumericalFilter(string k, int v, LobbyComparison c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(k);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericalFilter.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_LobbyComparison_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000086A4 File Offset: 0x000068A4
		public NumericalFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000086AD File Offset: 0x000068AD
		public NumericalFilter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumericalFilter>.NativeClassPtr))
		{
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0007D1AC File Offset: 0x0007B3AC
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x000086BF File Offset: 0x000068BF
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x000086DE File Offset: 0x000068DE
		public unsafe int _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0007D1FC File Offset: 0x0007B3FC
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x000086F9 File Offset: 0x000068F9
		public unsafe LobbyComparison _Comparer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Comparer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumericalFilter.NativeFieldInfoPtr__Comparer_k__BackingField)) = value;
			}
		}

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr__Comparer_k__BackingField;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Internal_set_Void_String_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Internal_set_Void_Int32_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparer_Public_get_LobbyComparison_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_set_Comparer_Internal_set_Void_LobbyComparison_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_LobbyComparison_0;
	}
}
