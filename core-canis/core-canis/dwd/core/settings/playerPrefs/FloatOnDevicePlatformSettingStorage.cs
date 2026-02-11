using System;
using dwd.core.settings.platform.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CE RID: 206
	public class FloatOnDevicePlatformSettingStorage : OnDevicePlatformSettingStorage<float>
	{
		// Token: 0x06000CAF RID: 3247 RVA: 0x00044490 File Offset: 0x00042690
		// Note: this type is marked as 'beforefieldinit'.
		static FloatOnDevicePlatformSettingStorage()
		{
			Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "FloatOnDevicePlatformSettingStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr);
			FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr, 100665078);
			FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr, 100665079);
			FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr, 100665080);
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000444FC File Offset: 0x000426FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864710, XrefRangeEnd = 864711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool load(string key, out float value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00044564 File Offset: 0x00042764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864711, XrefRangeEnd = 864713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void store(string key, float value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000445C0 File Offset: 0x000427C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864713, XrefRangeEnd = 864716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloatOnDevicePlatformSettingStorage(PlatformSettingStorageNamespacing namespacing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatOnDevicePlatformSettingStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatOnDevicePlatformSettingStorage.NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00006799 File Offset: 0x00004999
		public FloatOnDevicePlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Virtual_Boolean_String_byref_Single_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_store_Protected_Virtual_Void_String_Single_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformSettingStorageNamespacing_0;
	}
}
