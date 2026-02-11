using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.platform
{
	// Token: 0x020000E0 RID: 224
	public class PlatformSetting : VersionedModel
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x000484D8 File Offset: 0x000466D8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSetting()
		{
			Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform", "PlatformSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr);
			PlatformSetting.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, "key");
			PlatformSetting.NativeFieldInfoPtr_settingNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, "settingNamespace");
			PlatformSetting.NativeMethodInfoPtr__ctor_Protected_Void_String_ISettingNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665221);
			PlatformSetting.NativeMethodInfoPtr_get_StorageKey_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665222);
			PlatformSetting.NativeMethodInfoPtr_ResetCacheIfNeeded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665223);
			PlatformSetting.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665224);
			PlatformSetting.NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665225);
			PlatformSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665226);
			PlatformSetting.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665227);
			PlatformSetting.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665228);
			PlatformSetting.NativeMethodInfoPtr_set_Protected_Abstract_Virtual_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665229);
			PlatformSetting.NativeMethodInfoPtr_setWithoutSave_Protected_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665230);
			PlatformSetting.NativeMethodInfoPtr_resetCache_Protected_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665231);
			PlatformSetting.NativeMethodInfoPtr_delete_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665232);
			PlatformSetting.NativeMethodInfoPtr_save_Protected_Abstract_Virtual_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665233);
			PlatformSetting.NativeMethodInfoPtr_revert_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665234);
			PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665235);
			PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665236);
			PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr, 100665237);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00048684 File Offset: 0x00046884
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 866214, RefRangeEnd = 866219, XrefRangeStart = 866211, XrefRangeEnd = 866214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSetting(string key, ISettingNamespace settingNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSetting>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settingNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr__ctor_Protected_Void_String_ISettingNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x000486E4 File Offset: 0x000468E4
		public unsafe string StorageKey
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 866225, RefRangeEnd = 866232, XrefRangeStart = 866219, XrefRangeEnd = 866225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_get_StorageKey_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0004871C File Offset: 0x0004691C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 866235, RefRangeEnd = 866273, XrefRangeStart = 866232, XrefRangeEnd = 866235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCacheIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_ResetCacheIfNeeded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00048750 File Offset: 0x00046950
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 453376, RefRangeEnd = 453388, XrefRangeStart = 453376, XrefRangeEnd = 453388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00048790 File Offset: 0x00046990
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 866273, RefRangeEnd = 866276, XrefRangeStart = 866273, XrefRangeEnd = 866273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000487D0 File Offset: 0x000469D0
		[CallerCount(0)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00048804 File Offset: 0x00046A04
		[CallerCount(0)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00048838 File Offset: 0x00046A38
		[CallerCount(0)]
		public unsafe virtual Object get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00048884 File Offset: 0x00046A84
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_set_Protected_Abstract_Virtual_New_ISaveSettingRequest_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000488E0 File Offset: 0x00046AE0
		[CallerCount(0)]
		public unsafe virtual void setWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_setWithoutSave_Protected_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00048930 File Offset: 0x00046B30
		[CallerCount(0)]
		public unsafe virtual void resetCache(bool shouldReSave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldReSave;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_resetCache_Protected_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0004897C File Offset: 0x00046B7C
		[CallerCount(0)]
		public unsafe virtual void delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_delete_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000489B8 File Offset: 0x00046BB8
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_save_Protected_Abstract_Virtual_New_ISaveSettingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00048A04 File Offset: 0x00046C04
		[CallerCount(0)]
		public unsafe virtual void revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSetting.NativeMethodInfoPtr_revert_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00048A40 File Offset: 0x00046C40
		[CallerCount(0)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00048A90 File Offset: 0x00046C90
		[CallerCount(0)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00048AD4 File Offset: 0x00046CD4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSetting.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00006AAA File Offset: 0x00004CAA
		public PlatformSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00048B14 File Offset: 0x00046D14
		// (set) Token: 0x06000D96 RID: 3478 RVA: 0x00006AB3 File Offset: 0x00004CB3
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00048B3C File Offset: 0x00046D3C
		// (set) Token: 0x06000D98 RID: 3480 RVA: 0x00006AD2 File Offset: 0x00004CD2
		public unsafe ISettingNamespace settingNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting.NativeFieldInfoPtr_settingNamespace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISettingNamespace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSetting.NativeFieldInfoPtr_settingNamespace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeFieldInfoPtr_settingNamespace;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_ISettingNamespace_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_get_StorageKey_Protected_get_String_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_ResetCacheIfNeeded_Public_Void_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_Object_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_set_Protected_Abstract_Virtual_New_ISaveSettingRequest_Object_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_setWithoutSave_Protected_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_resetCache_Protected_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_delete_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_save_Protected_Abstract_Virtual_New_ISaveSettingRequest_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_revert_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;
	}
}
