using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000099 RID: 153
	public class NamingStrategy : Object
	{
		// Token: 0x06000D4B RID: 3403 RVA: 0x0004F54C File Offset: 0x0004D74C
		// Note: this type is marked as 'beforefieldinit'.
		static NamingStrategy()
		{
			Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "NamingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr);
			NamingStrategy.NativeFieldInfoPtr__ProcessDictionaryKeys_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, "<ProcessDictionaryKeys>k__BackingField");
			NamingStrategy.NativeFieldInfoPtr__ProcessExtensionDataNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, "<ProcessExtensionDataNames>k__BackingField");
			NamingStrategy.NativeFieldInfoPtr__OverrideSpecifiedNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, "<OverrideSpecifiedNames>k__BackingField");
			NamingStrategy.NativeMethodInfoPtr_get_ProcessDictionaryKeys_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665723);
			NamingStrategy.NativeMethodInfoPtr_set_ProcessDictionaryKeys_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665724);
			NamingStrategy.NativeMethodInfoPtr_get_ProcessExtensionDataNames_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665725);
			NamingStrategy.NativeMethodInfoPtr_set_ProcessExtensionDataNames_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665726);
			NamingStrategy.NativeMethodInfoPtr_get_OverrideSpecifiedNames_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665727);
			NamingStrategy.NativeMethodInfoPtr_set_OverrideSpecifiedNames_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665728);
			NamingStrategy.NativeMethodInfoPtr_GetPropertyName_Public_Virtual_New_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665729);
			NamingStrategy.NativeMethodInfoPtr_GetExtensionDataName_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665730);
			NamingStrategy.NativeMethodInfoPtr_GetDictionaryKey_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665731);
			NamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665732);
			NamingStrategy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665733);
			NamingStrategy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665734);
			NamingStrategy.NativeMethodInfoPtr_Equals_Protected_Boolean_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665735);
			NamingStrategy.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr, 100665736);
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0004F6D0 File Offset: 0x0004D8D0
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0004F70C File Offset: 0x0004D90C
		public unsafe bool ProcessDictionaryKeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_get_ProcessDictionaryKeys_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_set_ProcessDictionaryKeys_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0004F74C File Offset: 0x0004D94C
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0004F788 File Offset: 0x0004D988
		public unsafe bool ProcessExtensionDataNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_get_ProcessExtensionDataNames_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_set_ProcessExtensionDataNames_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0004F7C8 File Offset: 0x0004D9C8
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0004F804 File Offset: 0x0004DA04
		public unsafe bool OverrideSpecifiedNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_get_OverrideSpecifiedNames_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_set_OverrideSpecifiedNames_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0004F844 File Offset: 0x0004DA44
		[CallerCount(0)]
		public unsafe virtual string GetPropertyName(string name, bool hasSpecifiedName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasSpecifiedName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_GetPropertyName_Public_Virtual_New_String_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		[CallerCount(0)]
		public unsafe virtual string GetExtensionDataName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_GetExtensionDataName_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0004F8FC File Offset: 0x0004DAFC
		[CallerCount(0)]
		public unsafe virtual string GetDictionaryKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_GetDictionaryKey_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0004F950 File Offset: 0x0004DB50
		[CallerCount(0)]
		public unsafe virtual string ResolvePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0004F9A4 File Offset: 0x0004DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753708, XrefRangeEnd = 753715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0004F9EC File Offset: 0x0004DBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753715, XrefRangeEnd = 753725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamingStrategy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0004FA44 File Offset: 0x0004DC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753725, XrefRangeEnd = 753731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(NamingStrategy other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr_Equals_Protected_Boolean_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0004FA94 File Offset: 0x0004DC94
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamingStrategy.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00006528 File Offset: 0x00004728
		public NamingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00006531 File Offset: 0x00004731
		public unsafe bool _ProcessDictionaryKeys_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__ProcessDictionaryKeys_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__ProcessDictionaryKeys_k__BackingField)) = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0004FAF8 File Offset: 0x0004DCF8
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x0000654C File Offset: 0x0000474C
		public unsafe bool _ProcessExtensionDataNames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__ProcessExtensionDataNames_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__ProcessExtensionDataNames_k__BackingField)) = value;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0004FB20 File Offset: 0x0004DD20
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00006567 File Offset: 0x00004767
		public unsafe bool _OverrideSpecifiedNames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__OverrideSpecifiedNames_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamingStrategy.NativeFieldInfoPtr__OverrideSpecifiedNames_k__BackingField)) = value;
			}
		}

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr__ProcessDictionaryKeys_k__BackingField;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr__ProcessExtensionDataNames_k__BackingField;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr__OverrideSpecifiedNames_k__BackingField;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessDictionaryKeys_Public_get_Boolean_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessDictionaryKeys_Public_set_Void_Boolean_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessExtensionDataNames_Public_get_Boolean_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_set_ProcessExtensionDataNames_Public_set_Void_Boolean_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSpecifiedNames_Public_get_Boolean_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSpecifiedNames_Public_set_Void_Boolean_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyName_Public_Virtual_New_String_String_Boolean_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_GetExtensionDataName_Public_Virtual_New_String_String_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionaryKey_Public_Virtual_New_String_String_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Abstract_Virtual_New_String_String_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Protected_Boolean_NamingStrategy_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
