using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class ConfigFile : global::Il2CppSystem.Object
{
	// Token: 0x0600044A RID: 1098 RVA: 0x00024378 File Offset: 0x00022578
	// Note: this type is marked as 'beforefieldinit'.
	static ConfigFile()
	{
		Il2CppClassPointerStore<ConfigFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "ConfigFile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr);
		ConfigFile.NativeFieldInfoPtr_duplicateLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, "duplicateLogger");
		ConfigFile.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, "config");
		ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663903);
		ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663904);
		ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663905);
		ConfigFile.NativeMethodInfoPtr_FromFileContents_Public_Static_ConfigFile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663906);
		ConfigFile.NativeMethodInfoPtr_loadFromStream_Public_Void_TextReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663907);
		ConfigFile.NativeMethodInfoPtr_TrySplitLine_Public_Static_Boolean_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663908);
		ConfigFile.NativeMethodInfoPtr_add_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663909);
		ConfigFile.NativeMethodInfoPtr_set_Protected_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663910);
		ConfigFile.NativeMethodInfoPtr_set_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663911);
		ConfigFile.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663912);
		ConfigFile.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663913);
		ConfigFile.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr, 100663914);
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x000244C0 File Offset: 0x000226C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856437, XrefRangeEnd = 856457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfigFile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x000244FC File Offset: 0x000226FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 856489, RefRangeEnd = 856493, XrefRangeStart = 856457, XrefRangeEnd = 856489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfigFile(string filepath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filepath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00024548 File Offset: 0x00022748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856493, XrefRangeEnd = 856530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfigFile(TextAsset contents)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigFile>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00024594 File Offset: 0x00022794
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856564, RefRangeEnd = 856566, XrefRangeStart = 856530, XrefRangeEnd = 856564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConfigFile FromFileContents(string contents)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_FromFileContents_Public_Static_ConfigFile_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigFile>(intPtr3) : null;
		}
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x000245D8 File Offset: 0x000227D8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 856591, RefRangeEnd = 856594, XrefRangeStart = 856566, XrefRangeEnd = 856591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadFromStream(TextReader reader, string assetName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_loadFromStream_Public_Void_TextReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0002462C File Offset: 0x0002282C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856594, XrefRangeEnd = 856610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TrySplitLine(string line, out string key, out string value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2 = 0;
		ptr3 = &intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_TrySplitLine_Public_Static_Boolean_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		key = IL2CPP.Il2CppStringToManaged(intPtr);
		value = IL2CPP.Il2CppStringToManaged(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x000246A4 File Offset: 0x000228A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856610, XrefRangeEnd = 856611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add(string key, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigFile.NativeMethodInfoPtr_add_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00024704 File Offset: 0x00022904
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856611, XrefRangeEnd = 856612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void set(string key, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigFile.NativeMethodInfoPtr_set_Protected_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00024764 File Offset: 0x00022964
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 856625, RefRangeEnd = 856627, XrefRangeStart = 856612, XrefRangeEnd = 856625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set(string key, string value, bool warnIfDuplicate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnIfDuplicate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_set_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x000247C8 File Offset: 0x000229C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856634, RefRangeEnd = 856635, XrefRangeStart = 856627, XrefRangeEnd = 856634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string Get(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00024810 File Offset: 0x00022A10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856635, XrefRangeEnd = 856641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, string>>>(intPtr3) : null;
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00024850 File Offset: 0x00022A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856641, XrefRangeEnd = 856647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigFile.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00003A65 File Offset: 0x00001C65
	public ConfigFile(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000458 RID: 1112 RVA: 0x00024890 File Offset: 0x00022A90
	// (set) Token: 0x06000459 RID: 1113 RVA: 0x00003A6E File Offset: 0x00001C6E
	public unsafe StringBuilder duplicateLogger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigFile.NativeFieldInfoPtr_duplicateLogger);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigFile.NativeFieldInfoPtr_duplicateLogger), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x0600045A RID: 1114 RVA: 0x000248C0 File Offset: 0x00022AC0
	// (set) Token: 0x0600045B RID: 1115 RVA: 0x00003A8D File Offset: 0x00001C8D
	public unsafe Dictionary<string, string> config
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigFile.NativeFieldInfoPtr_config);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigFile.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000323 RID: 803
	private static readonly IntPtr NativeFieldInfoPtr_duplicateLogger;

	// Token: 0x04000324 RID: 804
	private static readonly IntPtr NativeFieldInfoPtr_config;

	// Token: 0x04000325 RID: 805
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000326 RID: 806
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000327 RID: 807
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextAsset_0;

	// Token: 0x04000328 RID: 808
	private static readonly IntPtr NativeMethodInfoPtr_FromFileContents_Public_Static_ConfigFile_String_0;

	// Token: 0x04000329 RID: 809
	private static readonly IntPtr NativeMethodInfoPtr_loadFromStream_Public_Void_TextReader_String_0;

	// Token: 0x0400032A RID: 810
	private static readonly IntPtr NativeMethodInfoPtr_TrySplitLine_Public_Static_Boolean_String_byref_String_byref_String_0;

	// Token: 0x0400032B RID: 811
	private static readonly IntPtr NativeMethodInfoPtr_add_Public_Virtual_New_Void_String_String_0;

	// Token: 0x0400032C RID: 812
	private static readonly IntPtr NativeMethodInfoPtr_set_Protected_Virtual_New_Void_String_String_0;

	// Token: 0x0400032D RID: 813
	private static readonly IntPtr NativeMethodInfoPtr_set_Private_Void_String_String_Boolean_0;

	// Token: 0x0400032E RID: 814
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_String_String_0;

	// Token: 0x0400032F RID: 815
	private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_String_0;

	// Token: 0x04000330 RID: 816
	private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
}
