using System;
using dwd.core.settings.platform;
using dwd.core.settings.platform.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000CC RID: 204
	public class OnDevicePlatformSettingStorage<T> : Object
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x00043E3C File Offset: 0x0004203C
		// Note: this type is marked as 'beforefieldinit'.
		static OnDevicePlatformSettingStorage()
		{
			Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "OnDevicePlatformSettingStorage`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr);
			OnDevicePlatformSettingStorage<T>.NativeFieldInfoPtr__SettingNamespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, "<SettingNamespace>k__BackingField");
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr__ctor_Protected_Void_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665067);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_Final_New_get_ISettingNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665068);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665069);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_load_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665070);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Store_Public_Virtual_Final_New_ISaveSettingRequest_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665071);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665072);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_store_Protected_Abstract_Virtual_New_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665073);
			OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_DeleteKey_Public_Virtual_Final_New_ISaveSettingRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr, 100665074);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00043F5C File Offset: 0x0004215C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864685, RefRangeEnd = 864686, XrefRangeStart = 864679, XrefRangeEnd = 864685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDevicePlatformSettingStorage(PlatformSettingStorageNamespacing namespacing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDevicePlatformSettingStorage<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr__ctor_Protected_Void_PlatformSettingStorageNamespacing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00043FA4 File Offset: 0x000421A4
		public unsafe virtual ISettingNamespace SettingNamespace
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_Final_New_get_ISettingNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISettingNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00043FE4 File Offset: 0x000421E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864686, XrefRangeEnd = 864690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Load(string key, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00044080 File Offset: 0x00042280
		[CallerCount(0)]
		public unsafe virtual bool load(string key, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_load_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00044128 File Offset: 0x00042328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864690, XrefRangeEnd = 864694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Store(string key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Store_Public_Virtual_Final_New_ISaveSettingRequest_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x000441C0 File Offset: 0x000423C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864694, XrefRangeEnd = 864699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00044200 File Offset: 0x00042400
		[CallerCount(0)]
		public unsafe virtual void store(string key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_store_Protected_Abstract_Virtual_New_Void_String_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00044298 File Offset: 0x00042498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864699, XrefRangeEnd = 864704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest DeleteKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDevicePlatformSettingStorage<T>.NativeMethodInfoPtr_DeleteKey_Public_Virtual_Final_New_ISaveSettingRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00006768 File Offset: 0x00004968
		public OnDevicePlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000442E8 File Offset: 0x000424E8
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00006771 File Offset: 0x00004971
		public unsafe ISettingNamespace _SettingNamespace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDevicePlatformSettingStorage<T>.NativeFieldInfoPtr__SettingNamespace_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISettingNamespace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDevicePlatformSettingStorage<T>.NativeFieldInfoPtr__SettingNamespace_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr__SettingNamespace_k__BackingField;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_PlatformSettingStorageNamespacing_0;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_Final_New_get_ISettingNamespace_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Boolean_String_byref_T_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Virtual_Final_New_ISaveSettingRequest_String_T_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_store_Protected_Abstract_Virtual_New_Void_String_T_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Virtual_Final_New_ISaveSettingRequest_String_0;
	}
}
