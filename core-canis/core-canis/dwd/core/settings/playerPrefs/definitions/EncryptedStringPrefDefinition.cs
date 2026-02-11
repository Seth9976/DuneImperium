using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000D6 RID: 214
	public class EncryptedStringPrefDefinition : PrefDefinition<string>
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x000460AC File Offset: 0x000442AC
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptedStringPrefDefinition()
		{
			Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "EncryptedStringPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr);
			EncryptedStringPrefDefinition.NativeFieldInfoPtr_salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr, "salt");
			EncryptedStringPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr, 100665150);
			EncryptedStringPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr, 100665151);
			EncryptedStringPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr, 100665152);
			EncryptedStringPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr, 100665153);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00046140 File Offset: 0x00044340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 865514, RefRangeEnd = 865516, XrefRangeStart = 865501, XrefRangeEnd = 865514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncryptedStringPrefDefinition(string key, string salt, bool isAccountSetting, string defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncryptedStringPrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedStringPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000461D4 File Offset: 0x000443D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865516, XrefRangeEnd = 865521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<string> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncryptedStringPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00046220 File Offset: 0x00044420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865521, XrefRangeEnd = 865525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EncryptedStringPrefDefinition UserPref(string key, string salt, string defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedStringPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncryptedStringPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0004629C File Offset: 0x0004449C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865525, XrefRangeEnd = 865529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EncryptedStringPrefDefinition SystemPref(string key, string salt, string defaultValue, ISetting<string> namespaceSetting = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptedStringPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncryptedStringPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000068DE File Offset: 0x00004ADE
		public EncryptedStringPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00046318 File Offset: 0x00044518
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x000068E7 File Offset: 0x00004AE7
		public unsafe Il2CppStructArray<byte> salt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptedStringPrefDefinition.NativeFieldInfoPtr_salt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptedStringPrefDefinition.NativeFieldInfoPtr_salt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr_salt;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_String_ISetting_1_String_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_String_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_EncryptedStringPrefDefinition_String_String_String_ISetting_1_String_0;
	}
}
