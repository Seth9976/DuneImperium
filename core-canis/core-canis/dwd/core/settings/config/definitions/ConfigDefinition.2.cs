using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.config.definitions
{
	// Token: 0x020000F1 RID: 241
	public class ConfigDefinition<T> : ConfigDefinition
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x0004C388 File Offset: 0x0004A588
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigDefinition()
		{
			Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config.definitions", "ConfigDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr);
			ConfigDefinition<T>.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, "setting");
			ConfigDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, "<Default>k__BackingField");
			ConfigDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_String_T_IVersionedConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665366);
			ConfigDefinition<T>.NativeMethodInfoPtr_get_Default_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665367);
			ConfigDefinition<T>.NativeMethodInfoPtr_Get_Public_ConfigSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665368);
			ConfigDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ConfigSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665369);
			ConfigDefinition<T>.NativeMethodInfoPtr_convert_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665370);
			ConfigDefinition<T>.NativeMethodInfoPtr_load_Protected_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665371);
			ConfigDefinition<T>.NativeMethodInfoPtr_getGeneric_Protected_Virtual_ISessionWritableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665372);
			ConfigDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665373);
			ConfigDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665374);
			ConfigDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ConfigSetting_1_T_ConfigDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665375);
			ConfigDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConfigDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr, 100665376);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0004C4F8 File Offset: 0x0004A6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 867166, RefRangeEnd = 867168, XrefRangeStart = 867163, XrefRangeEnd = 867166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigDefinition(string key, T defaultValue, IVersionedConfig config = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_String_T_IVersionedConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0004C5A0 File Offset: 0x0004A7A0
		public unsafe T Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_get_Default_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0004C5DC File Offset: 0x0004A7DC
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 867169, RefRangeEnd = 867220, XrefRangeStart = 867168, XrefRangeEnd = 867169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_Get_Public_ConfigSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0004C61C File Offset: 0x0004A81C
		[CallerCount(0)]
		public unsafe virtual ConfigSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ConfigSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0004C668 File Offset: 0x0004A868
		[CallerCount(0)]
		public unsafe virtual bool convert(string stored, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stored);
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigDefinition<T>.NativeMethodInfoPtr_convert_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0004C710 File Offset: 0x0004A910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867220, XrefRangeEnd = 867223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool load(string key, out T value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_load_Protected_Boolean_String_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0004C7AC File Offset: 0x0004A9AC
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 867169, RefRangeEnd = 867220, XrefRangeStart = 867169, XrefRangeEnd = 867220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISessionWritableSetting getGeneric()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigDefinition<T>.NativeMethodInfoPtr_getGeneric_Protected_Virtual_ISessionWritableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISessionWritableSetting>(intPtr3) : null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0004C7F8 File Offset: 0x0004A9F8
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 867169, RefRangeEnd = 867220, XrefRangeStart = 867169, XrefRangeEnd = 867220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting<T> dwd_core_settings_ISettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0004C838 File Offset: 0x0004AA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867223, XrefRangeEnd = 867228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWithoutSave(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0004C8B0 File Offset: 0x0004AAB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867230, RefRangeEnd = 867231, XrefRangeStart = 867228, XrefRangeEnd = 867230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ConfigSetting<T>(ConfigDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_ConfigSetting_1_T_ConfigDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0004C8F4 File Offset: 0x0004AAF4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 867243, RefRangeEnd = 867266, XrefRangeStart = 867231, XrefRangeEnd = 867243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(ConfigDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConfigDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00006E27 File Offset: 0x00005027
		public ConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0004C934 File Offset: 0x0004AB34
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00006E30 File Offset: 0x00005030
		public unsafe ConfigSetting<T> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition<T>.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigSetting<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition<T>.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0004C964 File Offset: 0x0004AB64
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0004C98C File Offset: 0x0004AB8C
		public unsafe T _Default_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_T_IVersionedConfig_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Protected_get_T_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_ConfigSetting_1_T_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ConfigSetting_1_T_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_convert_Protected_Abstract_Virtual_New_Boolean_String_byref_T_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_load_Protected_Boolean_String_byref_T_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_getGeneric_Protected_Virtual_ISessionWritableSetting_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ConfigSetting_1_T_ConfigDefinition_1_T_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_ConfigDefinition_1_T_0;
	}
}
