using System;
using dwd.core.settings.platform.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CD RID: 205
	public class IntOnDevicePlatformSettingStorage : OnDevicePlatformSettingStorage<int>
	{
		// Token: 0x06000CAA RID: 3242 RVA: 0x00044318 File Offset: 0x00042518
		// Note: this type is marked as 'beforefieldinit'.
		static IntOnDevicePlatformSettingStorage()
		{
			Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "IntOnDevicePlatformSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr);
			IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr, 100665075);
			IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr, 100665076);
			IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr, 100665077);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00044384 File Offset: 0x00042584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864704, XrefRangeEnd = 864705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool load(string key, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000443EC File Offset: 0x000425EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864705, XrefRangeEnd = 864707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void store(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00044448 File Offset: 0x00042648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864707, XrefRangeEnd = 864710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntOnDevicePlatformSettingStorage(PlatformSettingStorageNamespacing namespacing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntOnDevicePlatformSettingStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00006790 File Offset: 0x00004990
		public IntOnDevicePlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Int32_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Int32_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0;
	}
}
