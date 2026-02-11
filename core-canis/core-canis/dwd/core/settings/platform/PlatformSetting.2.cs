using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.platform
{
	// Token: 0x020000E1 RID: 225
	public class PlatformSetting<T> : PlatformSetting
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x00048B6C File Offset: 0x00046D6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSetting()
		{
			Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform", "PlatformSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr);
			PlatformSetting<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "comparer");
			PlatformSetting<T>.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "load");
			PlatformSetting<T>.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "store");
			PlatformSetting<T>.NativeFieldInfoPtr_deleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "deleteKey");
			PlatformSetting<T>.NativeFieldInfoPtr_unsafeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "unsafeCache");
			PlatformSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IEqualityComparer_1_T_ISettingNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665238);
			PlatformSetting<T>.NativeMethodInfoPtr_get_Cache_Private_get_SettingCache_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665239);
			PlatformSetting<T>.NativeMethodInfoPtr_resetCache_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665240);
			PlatformSetting<T>.NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665241);
			PlatformSetting<T>.NativeMethodInfoPtr_set_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665242);
			PlatformSetting<T>.NativeMethodInfoPtr_delete_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665243);
			PlatformSetting<T>.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665244);
			PlatformSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665245);
			PlatformSetting<T>.NativeMethodInfoPtr_save_Protected_Virtual_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665246);
			PlatformSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665247);
			PlatformSetting<T>.NativeMethodInfoPtr_revert_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665248);
			PlatformSetting<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665249);
			PlatformSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665250);
			PlatformSetting<T>.NativeMethodInfoPtr_get_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665251);
			PlatformSetting<T>.NativeMethodInfoPtr_set_Protected_Virtual_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665252);
			PlatformSetting<T>.NativeMethodInfoPtr_setWithoutSave_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, 100665253);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00048D7C File Offset: 0x00046F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866289, XrefRangeEnd = 866316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSetting(string key, T defaultValue, PlatformSetting<T>.Load load, PlatformSetting<T>.Store store, PlatformSetting<T>.DeleteKey deleteKey, IEqualityComparer<T> comparer, ISettingNamespace settingNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(load);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deleteKey);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settingNamespace);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IEqualityComparer_1_T_ISettingNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00048E70 File Offset: 0x00047070
		public unsafe SettingCache<T> Cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866316, XrefRangeEnd = 866317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_get_Cache_Private_get_SettingCache_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingCache<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00048EB0 File Offset: 0x000470B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866317, XrefRangeEnd = 866338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetCache(bool shouldReSave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldReSave;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_resetCache_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00048EFC File Offset: 0x000470FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866338, XrefRangeEnd = 866340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool loadFromStorage(out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00048F88 File Offset: 0x00047188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866340, XrefRangeEnd = 866347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_set_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00049000 File Offset: 0x00047200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866347, XrefRangeEnd = 866353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_delete_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0004903C File Offset: 0x0004723C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 866374, RefRangeEnd = 866375, XrefRangeStart = 866353, XrefRangeEnd = 866374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Set(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000490C4 File Offset: 0x000472C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866375, XrefRangeEnd = 866378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWithoutSave(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0004913C File Offset: 0x0004733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866378, XrefRangeEnd = 866401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISaveSettingRequest save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_save_Protected_Virtual_ISaveSettingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00049188 File Offset: 0x00047388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866401, XrefRangeEnd = 866410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000491CC File Offset: 0x000473CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866410, XrefRangeEnd = 866439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_revert_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00049208 File Offset: 0x00047408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 866449, RefRangeEnd = 866450, XrefRangeStart = 866439, XrefRangeEnd = 866449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(PlatformSetting<T> setting)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setting);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSetting_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00049248 File Offset: 0x00047448
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866450, XrefRangeEnd = 866453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00049290 File Offset: 0x00047490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866453, XrefRangeEnd = 866454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_get_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000492DC File Offset: 0x000474DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866454, XrefRangeEnd = 866462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISaveSettingRequest set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_set_Protected_Virtual_ISaveSettingRequest_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00049338 File Offset: 0x00047538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866462, XrefRangeEnd = 866472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void setWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting<T>.NativeMethodInfoPtr_setWithoutSave_Protected_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00006AF1 File Offset: 0x00004CF1
		public PlatformSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00049388 File Offset: 0x00047588
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00006AFA File Offset: 0x00004CFA
		public unsafe IEqualityComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x000493B8 File Offset: 0x000475B8
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00006B19 File Offset: 0x00004D19
		public unsafe PlatformSetting<T>.Load load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>.Load>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000493E8 File Offset: 0x000475E8
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00006B38 File Offset: 0x00004D38
		public unsafe PlatformSetting<T>.Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>.Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00049418 File Offset: 0x00047618
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00006B57 File Offset: 0x00004D57
		public unsafe PlatformSetting<T>.DeleteKey deleteKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_deleteKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>.DeleteKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_deleteKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00049448 File Offset: 0x00047648
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00006B76 File Offset: 0x00004D76
		public unsafe SettingCache<T> unsafeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_unsafeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingCache<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting<T>.NativeFieldInfoPtr_unsafeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr_deleteKey;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr_unsafeCache;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_T_Load_T_Store_T_DeleteKey_T_IEqualityComparer_1_T_ISettingNamespace_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Private_get_SettingCache_1_T_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_resetCache_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_set_Private_Void_T_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_delete_Protected_Virtual_Void_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_ISaveSettingRequest_T_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_save_Protected_Virtual_ISaveSettingRequest_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_T_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_revert_Protected_Virtual_Void_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSetting_1_T_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Virtual_Object_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_set_Protected_Virtual_ISaveSettingRequest_Object_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_setWithoutSave_Protected_Virtual_Void_Object_0;

		// Token: 0x020002A7 RID: 679
		public sealed class Load : MulticastDelegate
		{
			// Token: 0x0600202D RID: 8237 RVA: 0x000914AC File Offset: 0x0008F6AC
			// Note: this type is marked as 'beforefieldinit'.
			static Load()
			{
				Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "Load"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				PlatformSetting<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr, 100665254);
				PlatformSetting<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr, 100665255);
				PlatformSetting<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr, 100665256);
				PlatformSetting<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr, 100665257);
			}

			// Token: 0x0600202E RID: 8238 RVA: 0x00091558 File Offset: 0x0008F758
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 283310, RefRangeEnd = 283333, XrefRangeStart = 283310, XrefRangeEnd = 283333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Load(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSetting<T>.Load>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600202F RID: 8239 RVA: 0x000915B4 File Offset: 0x0008F7B4
			[CallerCount(0)]
			public unsafe bool Invoke(string key, out T value)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002030 RID: 8240 RVA: 0x00091650 File Offset: 0x0008F850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866276, XrefRangeEnd = 866280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string key, out T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x06002031 RID: 8241 RVA: 0x00091714 File Offset: 0x0008F914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out T value, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
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
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06002032 RID: 8242 RVA: 0x0000DB4B File Offset: 0x0000BD4B
			public Load(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400166C RID: 5740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400166D RID: 5741
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_byref_T_0;

			// Token: 0x0400166E RID: 5742
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_byref_T_AsyncCallback_Object_0;

			// Token: 0x0400166F RID: 5743
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0;
		}

		// Token: 0x020002A8 RID: 680
		public sealed class Store : MulticastDelegate
		{
			// Token: 0x06002033 RID: 8243 RVA: 0x000917B0 File Offset: 0x0008F9B0
			// Note: this type is marked as 'beforefieldinit'.
			static Store()
			{
				Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "Store"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				PlatformSetting<T>.Store.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr, 100665258);
				PlatformSetting<T>.Store.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr, 100665259);
				PlatformSetting<T>.Store.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr, 100665260);
				PlatformSetting<T>.Store.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr, 100665261);
			}

			// Token: 0x06002034 RID: 8244 RVA: 0x0009185C File Offset: 0x0008FA5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 866284, RefRangeEnd = 866285, XrefRangeStart = 866280, XrefRangeEnd = 866284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Store(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSetting<T>.Store>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Store.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002035 RID: 8245 RVA: 0x000918B8 File Offset: 0x0008FAB8
			[CallerCount(0)]
			public unsafe ISaveSettingRequest Invoke(string key, T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Store.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}

			// Token: 0x06002036 RID: 8246 RVA: 0x00091950 File Offset: 0x0008FB50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866285, XrefRangeEnd = 866289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string key, T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Store.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06002037 RID: 8247 RVA: 0x00091A10 File Offset: 0x0008FC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ISaveSettingRequest EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.Store.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
				}
			}

			// Token: 0x06002038 RID: 8248 RVA: 0x0000DB54 File Offset: 0x0000BD54
			public Store(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002039 RID: 8249 RVA: 0x0000DB5D File Offset: 0x0000BD5D
			public static implicit operator PlatformSetting<T>.Store(Func<string, T, ISaveSettingRequest> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlatformSetting<T>.Store>(A_0);
			}

			// Token: 0x0600203A RID: 8250 RVA: 0x0000DB65 File Offset: 0x0000BD65
			public static PlatformSetting<T>.Store operator +(PlatformSetting<T>.Store A_0, PlatformSetting<T>.Store A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlatformSetting<T>.Store>();
			}

			// Token: 0x0600203B RID: 8251 RVA: 0x0000DB73 File Offset: 0x0000BD73
			public static PlatformSetting<T>.Store operator -(PlatformSetting<T>.Store A_0, PlatformSetting<T>.Store A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlatformSetting<T>.Store>();
				}
				return delegate2;
			}

			// Token: 0x04001670 RID: 5744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001671 RID: 5745
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_T_0;

			// Token: 0x04001672 RID: 5746
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_T_AsyncCallback_Object_0;

			// Token: 0x04001673 RID: 5747
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0;
		}

		// Token: 0x020002A9 RID: 681
		public sealed class DeleteKey : MulticastDelegate
		{
			// Token: 0x0600203C RID: 8252 RVA: 0x00091A60 File Offset: 0x0008FC60
			// Note: this type is marked as 'beforefieldinit'.
			static DeleteKey()
			{
				Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformSetting<T>>.NativeClassPtr, "DeleteKey"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr, 100665262);
				PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr, 100665263);
				PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr, 100665264);
				PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr, 100665265);
			}

			// Token: 0x0600203D RID: 8253 RVA: 0x00091B0C File Offset: 0x0008FD0C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 427006, RefRangeEnd = 427011, XrefRangeStart = 427006, XrefRangeEnd = 427011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteKey(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSetting<T>.DeleteKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600203E RID: 8254 RVA: 0x00091B68 File Offset: 0x0008FD68
			[CallerCount(0)]
			public unsafe ISaveSettingRequest Invoke(string key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
				}
			}

			// Token: 0x0600203F RID: 8255 RVA: 0x00091BB8 File Offset: 0x0008FDB8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string key, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002040 RID: 8256 RVA: 0x00091C2C File Offset: 0x0008FE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ISaveSettingRequest EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting<T>.DeleteKey.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
				}
			}

			// Token: 0x06002041 RID: 8257 RVA: 0x0000DB84 File Offset: 0x0000BD84
			public DeleteKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002042 RID: 8258 RVA: 0x0000DB8D File Offset: 0x0000BD8D
			public static implicit operator PlatformSetting<T>.DeleteKey(Func<string, ISaveSettingRequest> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlatformSetting<T>.DeleteKey>(A_0);
			}

			// Token: 0x06002043 RID: 8259 RVA: 0x0000DB95 File Offset: 0x0000BD95
			public static PlatformSetting<T>.DeleteKey operator +(PlatformSetting<T>.DeleteKey A_0, PlatformSetting<T>.DeleteKey A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlatformSetting<T>.DeleteKey>();
			}

			// Token: 0x06002044 RID: 8260 RVA: 0x0000DBA3 File Offset: 0x0000BDA3
			public static PlatformSetting<T>.DeleteKey operator -(PlatformSetting<T>.DeleteKey A_0, PlatformSetting<T>.DeleteKey A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlatformSetting<T>.DeleteKey>();
				}
				return delegate2;
			}

			// Token: 0x04001674 RID: 5748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ISaveSettingRequest_String_0;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ISaveSettingRequest_IAsyncResult_0;
		}
	}
}
