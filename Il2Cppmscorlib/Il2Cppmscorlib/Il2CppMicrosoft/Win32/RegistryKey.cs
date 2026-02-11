using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003E RID: 62
	public sealed class RegistryKey : MarshalByRefObject
	{
		// Token: 0x0600038B RID: 907 RVA: 0x00033868 File Offset: 0x00031A68
		// Note: this type is marked as 'beforefieldinit'.
		static RegistryKey()
		{
			Il2CppClassPointerStore<RegistryKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "RegistryKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr);
			RegistryKey.NativeFieldInfoPtr_HKEY_CLASSES_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CLASSES_ROOT");
			RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_USER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CURRENT_USER");
			RegistryKey.NativeFieldInfoPtr_HKEY_LOCAL_MACHINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_LOCAL_MACHINE");
			RegistryKey.NativeFieldInfoPtr_HKEY_USERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_USERS");
			RegistryKey.NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_PERFORMANCE_DATA");
			RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_CONFIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_CURRENT_CONFIG");
			RegistryKey.NativeFieldInfoPtr_HKEY_DYN_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "HKEY_DYN_DATA");
			RegistryKey.NativeFieldInfoPtr_s_hkeyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "s_hkeyNames");
			RegistryKey.NativeFieldInfoPtr__hkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_hkey");
			RegistryKey.NativeFieldInfoPtr__keyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_keyName");
			RegistryKey.NativeFieldInfoPtr__remoteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_remoteKey");
			RegistryKey.NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_state");
			RegistryKey.NativeFieldInfoPtr__checkMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_checkMode");
			RegistryKey.NativeFieldInfoPtr__regView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, "_regView");
			RegistryKey.NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663828);
			RegistryKey.NativeMethodInfoPtr_CreateSubKeyInternalCore_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663829);
			RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTreeCore_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663830);
			RegistryKey.NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663831);
			RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663832);
			RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecksCore_Internal_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663833);
			RegistryKey.NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663834);
			RegistryKey.NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663835);
			RegistryKey.NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663836);
			RegistryKey.NativeMethodInfoPtr_SetValueCore_Private_Void_String_Object_RegistryValueKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663837);
			RegistryKey.NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663838);
			RegistryKey.NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663839);
			RegistryKey.NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663840);
			RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663841);
			RegistryKey.NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663842);
			RegistryKey.NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_RegistryKeyPermissionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663843);
			RegistryKey.NativeMethodInfoPtr_CreateSubKeyInternal_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663844);
			RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663845);
			RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663846);
			RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTreeInternal_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663847);
			RegistryKey.NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663848);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663849);
			RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663850);
			RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecks_Internal_RegistryKey_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663851);
			RegistryKey.NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663852);
			RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663853);
			RegistryKey.NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663854);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663855);
			RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663856);
			RegistryKey.NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663857);
			RegistryKey.NativeMethodInfoPtr_SetValue_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663858);
			RegistryKey.NativeMethodInfoPtr_SetValue_Public_Void_String_Object_RegistryValueKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663859);
			RegistryKey.NativeMethodInfoPtr_CalculateValueKind_Private_RegistryValueKind_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663860);
			RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663861);
			RegistryKey.NativeMethodInfoPtr_FixupName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663862);
			RegistryKey.NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663863);
			RegistryKey.NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663864);
			RegistryKey.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663865);
			RegistryKey.NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663866);
			RegistryKey.NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663867);
			RegistryKey.NativeMethodInfoPtr_ValidateKeyMode_Private_Static_Void_RegistryKeyPermissionCheck_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663868);
			RegistryKey.NativeMethodInfoPtr_ValidateKeyOptions_Private_Static_Void_RegistryOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663869);
			RegistryKey.NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663870);
			RegistryKey.NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663871);
			RegistryKey.NativeMethodInfoPtr_IsWritable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663872);
			RegistryKey.NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663873);
			RegistryKey.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr, 100663874);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00033D5C File Offset: 0x00031F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280271, XrefRangeEnd = 1280276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePerfDataKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00033D90 File Offset: 0x00031F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280283, RefRangeEnd = 1280285, XrefRangeStart = 1280276, XrefRangeEnd = 1280283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKeyInternalCore(string subkey, RegistryKeyPermissionCheck permissionCheck, Object registrySecurityObj, RegistryOptions registryOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permissionCheck;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registrySecurityObj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref registryOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateSubKeyInternalCore_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00033E10 File Offset: 0x00032010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280285, XrefRangeEnd = 1280288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteSubKeyTreeCore(string subkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTreeCore_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00033E54 File Offset: 0x00032054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280288, XrefRangeEnd = 1280306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegistryKey OpenBaseKeyCore(RegistryHive hKeyHive, RegistryView view)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hKeyHive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00033EA4 File Offset: 0x000320A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280329, RefRangeEnd = 1280331, XrefRangeStart = 1280306, XrefRangeEnd = 1280329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnPermissionFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00033F10 File Offset: 0x00032110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280331, XrefRangeEnd = 1280348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey InternalOpenSubKeyWithoutSecurityChecksCore(string name, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecksCore_Internal_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00033F70 File Offset: 0x00032170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280348, XrefRangeEnd = 1280350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalSubKeyCountCore()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00033FAC File Offset: 0x000321AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280379, RefRangeEnd = 1280380, XrefRangeStart = 1280350, XrefRangeEnd = 1280379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalGetSubKeyNamesCore(int subkeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subkeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00033FF8 File Offset: 0x000321F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280453, RefRangeEnd = 1280455, XrefRangeStart = 1280380, XrefRangeEnd = 1280453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalGetValueCore(string name, Object defaultValue, bool doNotExpand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotExpand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00034068 File Offset: 0x00032268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280506, RefRangeEnd = 1280507, XrefRangeStart = 1280455, XrefRangeEnd = 1280506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValueCore(string name, Object value, RegistryValueKind valueKind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_SetValueCore_Private_Void_String_Object_RegistryValueKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000340CC File Offset: 0x000322CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280507, XrefRangeEnd = 1280578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Win32Error(int errorCode, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0003411C File Offset: 0x0003231C
		[CallerCount(0)]
		public unsafe static int GetRegistryKeyAccess(bool isWritable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWritable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0003415C File Offset: 0x0003235C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1280599, RefRangeEnd = 1280604, XrefRangeStart = 1280578, XrefRangeEnd = 1280599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey(SafeRegistryHandle hkey, bool writable, bool systemkey, bool remoteKey, bool isPerfData, RegistryView view)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegistryKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemkey;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remoteKey;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPerfData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000341F0 File Offset: 0x000323F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280604, XrefRangeEnd = 1280620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00034224 File Offset: 0x00032424
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1280636, RefRangeEnd = 1280642, XrefRangeStart = 1280620, XrefRangeEnd = 1280636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKey(string subkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00034274 File Offset: 0x00032474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280642, XrefRangeEnd = 1280657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permissionCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_RegistryKeyPermissionCheck_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000342D4 File Offset: 0x000324D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280657, XrefRangeEnd = 1280670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey CreateSubKeyInternal(string subkey, RegistryKeyPermissionCheck permissionCheck, Object registrySecurityObj, RegistryOptions registryOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref permissionCheck;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registrySecurityObj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref registryOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CreateSubKeyInternal_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00034354 File Offset: 0x00032554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280671, RefRangeEnd = 1280672, XrefRangeStart = 1280670, XrefRangeEnd = 1280671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteSubKeyTree(string subkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00034398 File Offset: 0x00032598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280698, RefRangeEnd = 1280699, XrefRangeStart = 1280672, XrefRangeEnd = 1280698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnMissingSubKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000343E8 File Offset: 0x000325E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280714, RefRangeEnd = 1280716, XrefRangeStart = 1280699, XrefRangeEnd = 1280714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteSubKeyTreeInternal(string subkey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subkey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_DeleteSubKeyTreeInternal_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0003442C File Offset: 0x0003262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280716, XrefRangeEnd = 1280739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegistryKey OpenBaseKey(RegistryHive hKey, RegistryView view)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hKey;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref view;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0003447C File Offset: 0x0003267C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1280747, RefRangeEnd = 1280753, XrefRangeStart = 1280739, XrefRangeEnd = 1280747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000344CC File Offset: 0x000326CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1280761, RefRangeEnd = 1280770, XrefRangeStart = 1280753, XrefRangeEnd = 1280761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey OpenSubKey(string name, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0003452C File Offset: 0x0003272C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1280794, RefRangeEnd = 1280799, XrefRangeStart = 1280770, XrefRangeEnd = 1280794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKey InternalOpenSubKeyWithoutSecurityChecks(string name, bool writable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecks_Internal_RegistryKey_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegistryKey>(intPtr3) : null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0003458C File Offset: 0x0003278C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1280803, RefRangeEnd = 1280806, XrefRangeStart = 1280799, XrefRangeEnd = 1280803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalSubKeyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000345C8 File Offset: 0x000327C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280807, RefRangeEnd = 1280809, XrefRangeStart = 1280806, XrefRangeEnd = 1280807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSubKeyNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00034608 File Offset: 0x00032808
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1280819, RefRangeEnd = 1280822, XrefRangeStart = 1280809, XrefRangeEnd = 1280819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalGetSubKeyNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00034648 File Offset: 0x00032848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280825, RefRangeEnd = 1280826, XrefRangeStart = 1280822, XrefRangeEnd = 1280825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00034698 File Offset: 0x00032898
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1280827, RefRangeEnd = 1280840, XrefRangeStart = 1280826, XrefRangeEnd = 1280827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(string name, Object defaultValue, RegistryValueOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00034708 File Offset: 0x00032908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280846, RefRangeEnd = 1280847, XrefRangeStart = 1280840, XrefRangeEnd = 1280846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalGetValue(string name, Object defaultValue, bool doNotExpand, bool checkSecurity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotExpand;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSecurity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00034788 File Offset: 0x00032988
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1280848, RefRangeEnd = 1280853, XrefRangeStart = 1280847, XrefRangeEnd = 1280848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_SetValue_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000347DC File Offset: 0x000329DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280909, RefRangeEnd = 1280910, XrefRangeStart = 1280853, XrefRangeEnd = 1280909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string name, Object value, RegistryValueKind valueKind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_SetValue_Public_Void_String_Object_RegistryValueKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00034840 File Offset: 0x00032A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280910, XrefRangeEnd = 1280920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryValueKind CalculateValueKind(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_CalculateValueKind_Private_RegistryValueKind_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00034890 File Offset: 0x00032A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280920, XrefRangeEnd = 1280923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000348C8 File Offset: 0x00032AC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1280943, RefRangeEnd = 1280949, XrefRangeStart = 1280923, XrefRangeEnd = 1280943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixupName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_FixupName_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00034904 File Offset: 0x00032B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280949, XrefRangeEnd = 1280958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FixupPath(StringBuilder path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0003493C File Offset: 0x00032B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280958, XrefRangeEnd = 1280960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureNotDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00034970 File Offset: 0x00032B70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1280964, RefRangeEnd = 1280969, XrefRangeStart = 1280960, XrefRangeEnd = 1280964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureWriteable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_EnsureWriteable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000349A4 File Offset: 0x00032BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280969, XrefRangeEnd = 1280970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegistryKeyPermissionCheck GetSubKeyPermissionCheck(bool subkeyWritable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subkeyWritable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000349F0 File Offset: 0x00032BF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1280987, RefRangeEnd = 1280994, XrefRangeStart = 1280970, XrefRangeEnd = 1280987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateKeyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00034A28 File Offset: 0x00032C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280994, XrefRangeEnd = 1280996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateKeyMode(RegistryKeyPermissionCheck mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ValidateKeyMode_Private_Static_Void_RegistryKeyPermissionCheck_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00034A5C File Offset: 0x00032C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280996, XrefRangeEnd = 1280998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateKeyOptions(RegistryOptions options)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ValidateKeyOptions_Private_Static_Void_RegistryOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00034A90 File Offset: 0x00032C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280998, XrefRangeEnd = 1281000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateKeyView(RegistryView view)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref view;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00034AC4 File Offset: 0x00032CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281000, XrefRangeEnd = 1281001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSystemKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00034B00 File Offset: 0x00032D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281001, XrefRangeEnd = 1281002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWritable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_IsWritable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00034B3C File Offset: 0x00032D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281003, RefRangeEnd = 1281004, XrefRangeStart = 1281002, XrefRangeEnd = 1281003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPerfDataKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00034B78 File Offset: 0x00032D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281004, XrefRangeEnd = 1281006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegistryKey.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00003641 File Offset: 0x00001841
		public RegistryKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00034BAC File Offset: 0x00032DAC
		// (set) Token: 0x060003BD RID: 957 RVA: 0x0000364A File Offset: 0x0000184A
		public unsafe static IntPtr HKEY_CLASSES_ROOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_CLASSES_ROOT, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_CLASSES_ROOT, (void*)(&value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00034BC8 File Offset: 0x00032DC8
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00003658 File Offset: 0x00001858
		public unsafe static IntPtr HKEY_CURRENT_USER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_USER, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_USER, (void*)(&value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00034BE4 File Offset: 0x00032DE4
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003666 File Offset: 0x00001866
		public unsafe static IntPtr HKEY_LOCAL_MACHINE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_LOCAL_MACHINE, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_LOCAL_MACHINE, (void*)(&value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00034C00 File Offset: 0x00032E00
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003674 File Offset: 0x00001874
		public unsafe static IntPtr HKEY_USERS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_USERS, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_USERS, (void*)(&value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00034C1C File Offset: 0x00032E1C
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003682 File Offset: 0x00001882
		public unsafe static IntPtr HKEY_PERFORMANCE_DATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA, (void*)(&value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00034C38 File Offset: 0x00032E38
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003690 File Offset: 0x00001890
		public unsafe static IntPtr HKEY_CURRENT_CONFIG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_CONFIG, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_CURRENT_CONFIG, (void*)(&value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00034C54 File Offset: 0x00032E54
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000369E File Offset: 0x0000189E
		public unsafe static IntPtr HKEY_DYN_DATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_HKEY_DYN_DATA, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_HKEY_DYN_DATA, (void*)(&value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00034C70 File Offset: 0x00032E70
		// (set) Token: 0x060003CB RID: 971 RVA: 0x000036AC File Offset: 0x000018AC
		public unsafe static Il2CppStringArray s_hkeyNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegistryKey.NativeFieldInfoPtr_s_hkeyNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegistryKey.NativeFieldInfoPtr_s_hkeyNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00034C98 File Offset: 0x00032E98
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000036BE File Offset: 0x000018BE
		public unsafe SafeRegistryHandle _hkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__hkey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeRegistryHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__hkey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00034CC8 File Offset: 0x00032EC8
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000036DD File Offset: 0x000018DD
		public unsafe string _keyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__keyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__keyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00034CF0 File Offset: 0x00032EF0
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000036FC File Offset: 0x000018FC
		public unsafe bool _remoteKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__remoteKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__remoteKey)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00034D18 File Offset: 0x00032F18
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003717 File Offset: 0x00001917
		public unsafe RegistryKey.StateFlags _state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__state)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00034D40 File Offset: 0x00032F40
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003732 File Offset: 0x00001932
		public unsafe RegistryKeyPermissionCheck _checkMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__checkMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__checkMode)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00034D68 File Offset: 0x00032F68
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x0000374D File Offset: 0x0000194D
		public unsafe RegistryView _regView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__regView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegistryKey.NativeFieldInfoPtr__regView)) = value;
			}
		}

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_CLASSES_ROOT;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_CURRENT_USER;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_LOCAL_MACHINE;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_USERS;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_PERFORMANCE_DATA;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_CURRENT_CONFIG;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_HKEY_DYN_DATA;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_s_hkeyNames;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr__hkey;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr__keyName;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr__remoteKey;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr__state;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr__checkMode;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr__regView;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_ClosePerfDataKey_Private_Void_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKeyInternalCore_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSubKeyTreeCore_Private_Void_String_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_OpenBaseKeyCore_Private_Static_RegistryKey_RegistryHive_RegistryView_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_InternalOpenSubKeyCore_Private_RegistryKey_String_Boolean_Boolean_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecksCore_Internal_RegistryKey_String_Boolean_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_InternalSubKeyCountCore_Private_Int32_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSubKeyNamesCore_Private_Il2CppStringArray_Int32_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetValueCore_Private_Object_String_Object_Boolean_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_SetValueCore_Private_Void_String_Object_RegistryValueKind_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_Win32Error_Private_Void_Int32_String_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_GetRegistryKeyAccess_Private_Static_Int32_Boolean_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SafeRegistryHandle_Boolean_Boolean_Boolean_Boolean_RegistryView_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKey_Public_RegistryKey_String_RegistryKeyPermissionCheck_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubKeyInternal_Private_RegistryKey_String_RegistryKeyPermissionCheck_Object_RegistryOptions_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSubKeyTree_Public_Void_String_Boolean_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSubKeyTreeInternal_Private_Void_String_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_OpenBaseKey_Public_Static_RegistryKey_RegistryHive_RegistryView_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_OpenSubKey_Public_RegistryKey_String_Boolean_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_InternalOpenSubKeyWithoutSecurityChecks_Internal_RegistryKey_String_Boolean_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_InternalSubKeyCount_Private_Int32_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyNames_Public_Il2CppStringArray_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetSubKeyNames_Private_Il2CppStringArray_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_String_Object_RegistryValueOptions_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetValue_Private_Object_String_Object_Boolean_Boolean_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_Object_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_Object_RegistryValueKind_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_CalculateValueKind_Private_RegistryValueKind_Object_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_FixupName_Private_Static_String_String_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_FixupPath_Private_Static_Void_StringBuilder_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNotDisposed_Private_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_EnsureWriteable_Private_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_GetSubKeyPermissionCheck_Private_RegistryKeyPermissionCheck_Boolean_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_ValidateKeyName_Private_Static_Void_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_ValidateKeyMode_Private_Static_Void_RegistryKeyPermissionCheck_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_ValidateKeyOptions_Private_Static_Void_RegistryOptions_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_ValidateKeyView_Private_Static_Void_RegistryView_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_IsSystemKey_Private_Boolean_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_IsWritable_Private_Boolean_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_IsPerfDataKey_Private_Boolean_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x02000573 RID: 1395
		[Flags]
		public enum StateFlags
		{
			// Token: 0x0400462D RID: 17965
			Dirty = 1,
			// Token: 0x0400462E RID: 17966
			SystemKey = 2,
			// Token: 0x0400462F RID: 17967
			WriteAccess = 4,
			// Token: 0x04004630 RID: 17968
			PerfData = 8
		}
	}
}
