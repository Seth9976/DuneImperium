using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.platform.definitions
{
	// Token: 0x020000E4 RID: 228
	public class IPlatformSettingStorage<T> : Il2CppObjectBase
	{
		// Token: 0x06000DC0 RID: 3520 RVA: 0x00049768 File Offset: 0x00047968
		// Note: this type is marked as 'beforefieldinit'.
		static IPlatformSettingStorage()
		{
			Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "IPlatformSettingStorage`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665275);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_Store_Public_Abstract_Virtual_New_ISaveSettingRequest_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665276);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_DeleteKey_Public_Abstract_Virtual_New_ISaveSettingRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665277);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665278);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_New_get_ISettingNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665279);
			IPlatformSettingStorage<T>.NativeMethodInfoPtr_Create_Public_Static_IPlatformSettingStorage_1_T_PlatformSettingStorageNamespacing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlatformSettingStorage<T>>.NativeClassPtr, 100665280);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00049844 File Offset: 0x00047A44
		[CallerCount(0)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformSettingStorage<T>.NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Boolean_String_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000498EC File Offset: 0x00047AEC
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformSettingStorage<T>.NativeMethodInfoPtr_Store_Public_Abstract_Virtual_New_ISaveSettingRequest_String_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00049990 File Offset: 0x00047B90
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest DeleteKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformSettingStorage<T>.NativeMethodInfoPtr_DeleteKey_Public_Abstract_Virtual_New_ISaveSettingRequest_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000499EC File Offset: 0x00047BEC
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformSettingStorage<T>.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_ISaveSettingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00049A38 File Offset: 0x00047C38
		public unsafe virtual ISettingNamespace SettingNamespace
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlatformSettingStorage<T>.NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_New_get_ISettingNamespace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISettingNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00049A84 File Offset: 0x00047C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 866526, RefRangeEnd = 866527, XrefRangeStart = 866513, XrefRangeEnd = 866526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPlatformSettingStorage<T> Create(PlatformSettingStorageNamespacing namespacing)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespacing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPlatformSettingStorage<T>.NativeMethodInfoPtr_Create_Public_Static_IPlatformSettingStorage_1_T_PlatformSettingStorageNamespacing_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPlatformSettingStorage<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00006BB9 File Offset: 0x00004DB9
		public IPlatformSettingStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Abstract_Virtual_New_Boolean_String_byref_T_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Abstract_Virtual_New_ISaveSettingRequest_String_T_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Abstract_Virtual_New_ISaveSettingRequest_String_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_ISaveSettingRequest_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_get_SettingNamespace_Public_Virtual_New_get_ISettingNamespace_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IPlatformSettingStorage_1_T_PlatformSettingStorageNamespacing_0;
	}
}
