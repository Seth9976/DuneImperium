using System;
using dwd.core.settings.platform.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000D0 RID: 208
	public class StringOnDevicePlatformSettingStorage : OnDevicePlatformSettingStorage<string>
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x00044780 File Offset: 0x00042980
		// Note: this type is marked as 'beforefieldinit'.
		static StringOnDevicePlatformSettingStorage()
		{
			Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "StringOnDevicePlatformSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr);
			StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr, 100665084);
			StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr, 100665085);
			StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr, 100665086);
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x000447EC File Offset: 0x000429EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864721, XrefRangeEnd = 864727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool load(string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00044860 File Offset: 0x00042A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864727, XrefRangeEnd = 864729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void store(string key, string value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000448C0 File Offset: 0x00042AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864729, XrefRangeEnd = 864732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringOnDevicePlatformSettingStorage(PlatformSettingStorageNamespacing namespacing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringOnDevicePlatformSettingStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x000067AB File Offset: 0x000049AB
		public StringOnDevicePlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_store_Protected_Virtual_Void_String_String_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0;
	}
}
