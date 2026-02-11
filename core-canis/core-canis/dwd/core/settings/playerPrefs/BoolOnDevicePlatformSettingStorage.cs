using System;
using dwd.core.settings.platform.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CF RID: 207
	public class BoolOnDevicePlatformSettingStorage : OnDevicePlatformSettingStorage<bool>
	{
		// Token: 0x06000CB4 RID: 3252 RVA: 0x00044608 File Offset: 0x00042808
		// Note: this type is marked as 'beforefieldinit'.
		static BoolOnDevicePlatformSettingStorage()
		{
			Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "BoolOnDevicePlatformSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr);
			BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr, 100665081);
			BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr, 100665082);
			BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr, 100665083);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00044674 File Offset: 0x00042874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864716, XrefRangeEnd = 864717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool load(string key, out bool value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000446DC File Offset: 0x000428DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864717, XrefRangeEnd = 864718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void store(string key, bool value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00044738 File Offset: 0x00042938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864718, XrefRangeEnd = 864721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolOnDevicePlatformSettingStorage(PlatformSettingStorageNamespacing namespacing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolOnDevicePlatformSettingStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000067A2 File Offset: 0x000049A2
		public BoolOnDevicePlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Boolean_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Boolean_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0;
	}
}
