using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.config.definitions
{
	// Token: 0x020000F0 RID: 240
	public class ConfigDefinition : Object
	{
		// Token: 0x06000E40 RID: 3648 RVA: 0x0004BEF0 File Offset: 0x0004A0F0
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigDefinition()
		{
			Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config.definitions", "ConfigDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr);
			ConfigDefinition.NativeFieldInfoPtr_defaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, "defaultConfig");
			ConfigDefinition.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, "config");
			ConfigDefinition.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, "key");
			ConfigDefinition.NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665355);
			ConfigDefinition.NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665356);
			ConfigDefinition.NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665357);
			ConfigDefinition.NativeMethodInfoPtr__ctor_Protected_Void_IVersionedConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665358);
			ConfigDefinition.NativeMethodInfoPtr_get_Key_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665359);
			ConfigDefinition.NativeMethodInfoPtr_getGeneric_Protected_Abstract_Virtual_New_ISessionWritableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665360);
			ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665361);
			ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665362);
			ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665363);
			ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665364);
			ConfigDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr, 100665365);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0004C038 File Offset: 0x0004A238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867074, XrefRangeEnd = 867083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void assertValidKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0004C070 File Offset: 0x0004A270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867115, RefRangeEnd = 867116, XrefRangeStart = 867083, XrefRangeEnd = 867115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeDefaultConfig(string directory, string filename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0004C0B8 File Offset: 0x0004A2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867116, XrefRangeEnd = 867134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeDefaultConfig(string contents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0004C0F0 File Offset: 0x0004A2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867146, RefRangeEnd = 867147, XrefRangeStart = 867134, XrefRangeEnd = 867146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigDefinition(IVersionedConfig config, string key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr__ctor_Protected_Void_IVersionedConfig_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0004C150 File Offset: 0x0004A350
		public unsafe string Key
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_get_Key_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0004C188 File Offset: 0x0004A388
		[CallerCount(0)]
		public unsafe virtual ISessionWritableSetting getGeneric()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigDefinition.NativeMethodInfoPtr_getGeneric_Protected_Abstract_Virtual_New_ISessionWritableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISessionWritableSetting>(intPtr3) : null;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0004C1D4 File Offset: 0x0004A3D4
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting dwd_core_settings_ISettingDefinition_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0004C214 File Offset: 0x0004A414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867147, XrefRangeEnd = 867151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0004C254 File Offset: 0x0004A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867151, XrefRangeEnd = 867155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_ISessionWritableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0004C298 File Offset: 0x0004A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867155, XrefRangeEnd = 867159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_ISessionWritableSetting_DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0004C2CC File Offset: 0x0004A4CC
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867159, XrefRangeEnd = 867163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00006DCE File Offset: 0x00004FCE
		public ConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0004C308 File Offset: 0x0004A508
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00006DD7 File Offset: 0x00004FD7
		public unsafe static IVersionedConfig defaultConfig
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfigDefinition.NativeFieldInfoPtr_defaultConfig, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVersionedConfig>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigDefinition.NativeFieldInfoPtr_defaultConfig, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0004C330 File Offset: 0x0004A530
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00006DE9 File Offset: 0x00004FE9
		public unsafe IVersionedConfig config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition.NativeFieldInfoPtr_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVersionedConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0004C360 File Offset: 0x0004A560
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00006E08 File Offset: 0x00005008
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_defaultConfig;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_config;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_assertValidKey_Private_Static_Void_String_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_String_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDefaultConfig_Public_Static_Void_String_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IVersionedConfig_String_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Protected_get_String_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_getGeneric_Protected_Abstract_Virtual_New_ISessionWritableSetting_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISessionWritableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;
	}
}
