using System;
using dwd.core.settings.serverSettings.save;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.definitions
{
	// Token: 0x020000C4 RID: 196
	public class ServerSettingDefinition<T> : ServerSettingDefinition
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x000427CC File Offset: 0x000409CC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSettingDefinition()
		{
			Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.definitions", "ServerSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr);
			ServerSettingDefinition<T>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, "defaultValue");
			ServerSettingDefinition<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, "comparer");
			ServerSettingDefinition<T>.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, "setting");
			ServerSettingDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_Int32_T_IUniqueKeyRegistry_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665029);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_get_Default_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665030);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665031);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_ServerSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665032);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665033);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ServerSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665034);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSettingDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665035);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665036);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665037);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665038);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665039);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665040);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665041);
			ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr, 100665042);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0004298C File Offset: 0x00040B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864384, RefRangeEnd = 864385, XrefRangeStart = 864380, XrefRangeEnd = 864384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSettingDefinition(int key, T defaultValue, IUniqueKeyRegistry keyRegistry, IEqualityComparer<T> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyRegistry);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_Int32_T_IUniqueKeyRegistry_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00042A40 File Offset: 0x00040C40
		public unsafe T Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_get_Default_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00042A7C File Offset: 0x00040C7C
		public unsafe IEqualityComparer<T> ComparerOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00042ABC File Offset: 0x00040CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864385, XrefRangeEnd = 864386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_ServerSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00042AFC File Offset: 0x00040CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSettingDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00042B48 File Offset: 0x00040D48
		[CallerCount(0)]
		public unsafe virtual ServerSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ServerSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00042B94 File Offset: 0x00040D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864386, XrefRangeEnd = 864394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(ServerSettingDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSettingDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00042BD4 File Offset: 0x00040DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864394, XrefRangeEnd = 864405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Set(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00042C5C File Offset: 0x00040E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864405, XrefRangeEnd = 864408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00042CD4 File Offset: 0x00040ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864408, XrefRangeEnd = 864417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00042D14 File Offset: 0x00040F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864417, XrefRangeEnd = 864420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00042D54 File Offset: 0x00040F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting<T> dwd_core_settings_ISettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00042D94 File Offset: 0x00040F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864420, XrefRangeEnd = 864427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T dwd_core_settings_ISetting_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00042DD0 File Offset: 0x00040FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_T__Set(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00006574 File Offset: 0x00004774
		public ServerSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00042E58 File Offset: 0x00041058
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x00042E80 File Offset: 0x00041080
		public unsafe T defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_defaultValue);
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00042F28 File Offset: 0x00041128
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000657D File Offset: 0x0000477D
		public unsafe IEqualityComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00042F58 File Offset: 0x00041158
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0000659C File Offset: 0x0000479C
		public unsafe ServerSetting<T> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition<T>.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_T_IUniqueKeyRegistry_IEqualityComparer_1_T_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_get_T_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_ServerSetting_1_T_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_ServerSetting_1_T_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSettingDefinition_1_T_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_SaveRequest_T_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_SaveRequest_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_SaveRequest_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0;
	}
}
