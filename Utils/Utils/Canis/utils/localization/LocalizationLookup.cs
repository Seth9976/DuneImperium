using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.utils.localization
{
	// Token: 0x02000012 RID: 18
	public class LocalizationLookup : VersionedModel
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000073C4 File Offset: 0x000055C4
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationLookup()
		{
			Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "LocalizationLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr);
			LocalizationLookup.NativeFieldInfoPtr_checksums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, "checksums");
			LocalizationLookup.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, "lookup");
			LocalizationLookup.NativeFieldInfoPtr__Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, "_Disabled");
			LocalizationLookup.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663405);
			LocalizationLookup.NativeMethodInfoPtr_get_Disabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663406);
			LocalizationLookup.NativeMethodInfoPtr_set_Disabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663407);
			LocalizationLookup.NativeMethodInfoPtr_formatKey_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663408);
			LocalizationLookup.NativeMethodInfoPtr_GetChecksums_Public_Virtual_Final_New_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663409);
			LocalizationLookup.NativeMethodInfoPtr_SetChecksums_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663410);
			LocalizationLookup.NativeMethodInfoPtr_Localize_Public_Virtual_Final_New_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663411);
			LocalizationLookup.NativeMethodInfoPtr_TryLocalize_Public_Virtual_Final_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663412);
			LocalizationLookup.NativeMethodInfoPtr_LocalizeWithWarning_Private_String_String_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663413);
			LocalizationLookup.NativeMethodInfoPtr_BeginTransaction_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663414);
			LocalizationLookup.NativeMethodInfoPtr_EndTransaction_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663415);
			LocalizationLookup.NativeMethodInfoPtr_SetPairs_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663416);
			LocalizationLookup.NativeMethodInfoPtr_RemoveKeys_Public_Virtual_Final_New_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663417);
			LocalizationLookup.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663418);
			LocalizationLookup.NativeMethodInfoPtr_Has_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663419);
			LocalizationLookup.NativeMethodInfoPtr_GetKeysWithPrefix_Public_Virtual_Final_New_Boolean_String_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663420);
			LocalizationLookup.NativeMethodInfoPtr_SetupRowIDMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663421);
			LocalizationLookup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr, 100663422);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00007598 File Offset: 0x00005798
		public unsafe virtual bool Initialized
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000075D4 File Offset: 0x000057D4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00007610 File Offset: 0x00005810
		public unsafe virtual bool Disabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_get_Disabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_set_Disabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00007650 File Offset: 0x00005850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178102, XrefRangeEnd = 1178104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string formatKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_formatKey_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007698 File Offset: 0x00005898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178104, XrefRangeEnd = 1178110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, string> GetChecksums()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_GetChecksums_Public_Virtual_Final_New_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000076D8 File Offset: 0x000058D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178110, XrefRangeEnd = 1178132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetChecksums(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_SetChecksums_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000771C File Offset: 0x0000591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178132, XrefRangeEnd = 1178133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Localize(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_Localize_Public_Virtual_Final_New_String_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007784 File Offset: 0x00005984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178133, XrefRangeEnd = 1178136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryLocalize(string key, out string value, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_TryLocalize_Public_Virtual_Final_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000780C File Offset: 0x00005A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1178146, RefRangeEnd = 1178148, XrefRangeStart = 1178136, XrefRangeEnd = 1178146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LocalizeWithWarning(string key, bool warn, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_LocalizeWithWarning_Private_String_String_Boolean_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00007884 File Offset: 0x00005A84
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool BeginTransaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_BeginTransaction_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000078C0 File Offset: 0x00005AC0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndTransaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_EndTransaction_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000078F4 File Offset: 0x00005AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178148, XrefRangeEnd = 1178170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPairs(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_SetPairs_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007938 File Offset: 0x00005B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178170, XrefRangeEnd = 1178190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveKeys(IEnumerable<string> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_RemoveKeys_Public_Virtual_Final_New_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000797C File Offset: 0x00005B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178190, XrefRangeEnd = 1178196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000079B0 File Offset: 0x00005BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178196, XrefRangeEnd = 1178201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Has(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_Has_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007A00 File Offset: 0x00005C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178201, XrefRangeEnd = 1178220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetKeysWithPrefix(string prefix, ICollection<string> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_GetKeysWithPrefix_Public_Virtual_Final_New_Boolean_String_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007A60 File Offset: 0x00005C60
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupRowIDMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr_SetupRowIDMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007A94 File Offset: 0x00005C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1178234, RefRangeEnd = 1178235, XrefRangeStart = 1178220, XrefRangeEnd = 1178234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationLookup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002399 File Offset: 0x00000599
		public virtual string Localize(string key, params Object[] args)
		{
			return this.Localize(key, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000023A8 File Offset: 0x000005A8
		public virtual bool TryLocalize(string key, out string value, params Object[] args)
		{
			return this.TryLocalize(key, out value, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000023B8 File Offset: 0x000005B8
		public string LocalizeWithWarning(string key, bool warn, params Object[] args)
		{
			return this.LocalizeWithWarning(key, warn, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000023C8 File Offset: 0x000005C8
		public LocalizationLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00007AD0 File Offset: 0x00005CD0
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000023D1 File Offset: 0x000005D1
		public unsafe Dictionary<string, string> checksums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr_checksums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr_checksums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000023F0 File Offset: 0x000005F0
		public unsafe Dictionary<string, string> lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00007B30 File Offset: 0x00005D30
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000240F File Offset: 0x0000060F
		public unsafe bool _Disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr__Disabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationLookup.NativeFieldInfoPtr__Disabled)) = value;
			}
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_checksums;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr__Disabled;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_Disabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_set_Disabled_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_formatKey_Private_String_String_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_GetChecksums_Public_Virtual_Final_New_Dictionary_2_String_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_SetChecksums_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_Localize_Public_Virtual_Final_New_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Virtual_Final_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_LocalizeWithWarning_Private_String_String_Boolean_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_BeginTransaction_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_EndTransaction_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_SetPairs_Public_Virtual_Final_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeys_Public_Virtual_Final_New_Void_IEnumerable_1_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetKeysWithPrefix_Public_Virtual_Final_New_Boolean_String_ICollection_1_String_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_SetupRowIDMap_Public_Void_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
