using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000DB RID: 219
	public class PrefDefinition : Object
	{
		// Token: 0x06000D32 RID: 3378 RVA: 0x00046FD4 File Offset: 0x000451D4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefDefinition()
		{
			Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "PrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr);
			PrefDefinition.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, "key");
			PrefDefinition.NativeFieldInfoPtr__IsAccountSetting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, "<IsAccountSetting>k__BackingField");
			PrefDefinition.NativeFieldInfoPtr_namespaceSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, "namespaceSetting");
			PrefDefinition.NativeMethodInfoPtr_get_Key_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665179);
			PrefDefinition.NativeMethodInfoPtr_get_IsAccountSetting_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665180);
			PrefDefinition.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665181);
			PrefDefinition.NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665182);
			PrefDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665183);
			PrefDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665184);
			PrefDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665185);
			PrefDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665186);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665187);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665188);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665189);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665190);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665191);
			PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr, 100665192);
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00047158 File Offset: 0x00045358
		public unsafe string Key
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_get_Key_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00047190 File Offset: 0x00045390
		public unsafe bool IsAccountSetting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_get_IsAccountSetting_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000471CC File Offset: 0x000453CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 865846, RefRangeEnd = 865852, XrefRangeStart = 865832, XrefRangeEnd = 865846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefDefinition(string key, bool isAccountSetting, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00047238 File Offset: 0x00045438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865852, XrefRangeEnd = 865853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void assertValidKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00047270 File Offset: 0x00045470
		[CallerCount(0)]
		public unsafe virtual IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000472BC File Offset: 0x000454BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865853, XrefRangeEnd = 865857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000472F0 File Offset: 0x000454F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 865861, RefRangeEnd = 865862, XrefRangeStart = 865857, XrefRangeEnd = 865861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00047324 File Offset: 0x00045524
		public unsafe virtual ulong Version
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 865866, RefRangeEnd = 865869, XrefRangeStart = 865862, XrefRangeEnd = 865866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00047360 File Offset: 0x00045560
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting dwd_core_settings_ISettingDefinition_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000473A0 File Offset: 0x000455A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865869, XrefRangeEnd = 865873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000473E0 File Offset: 0x000455E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865873, XrefRangeEnd = 865877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00047430 File Offset: 0x00045630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865877, XrefRangeEnd = 865881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00047474 File Offset: 0x00045674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865881, XrefRangeEnd = 865885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000474B4 File Offset: 0x000456B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 865885, XrefRangeEnd = 865889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IRevertableSetting_Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x0000692A File Offset: 0x00004B2A
		public PrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x000474F4 File Offset: 0x000456F4
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00006933 File Offset: 0x00004B33
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0004751C File Offset: 0x0004571C
		// (set) Token: 0x06000D45 RID: 3397 RVA: 0x00006952 File Offset: 0x00004B52
		public unsafe bool _IsAccountSetting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr__IsAccountSetting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr__IsAccountSetting_k__BackingField)) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000D46 RID: 3398 RVA: 0x00047544 File Offset: 0x00045744
		// (set) Token: 0x06000D47 RID: 3399 RVA: 0x0000696D File Offset: 0x00004B6D
		public unsafe ISetting<string> namespaceSetting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr_namespaceSetting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISetting<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition.NativeFieldInfoPtr_namespaceSetting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr__IsAccountSetting_k__BackingField;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeFieldInfoPtr_namespaceSetting;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Protected_get_String_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAccountSetting_Protected_get_Boolean_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_ISetting_1_String_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0;
	}
}
