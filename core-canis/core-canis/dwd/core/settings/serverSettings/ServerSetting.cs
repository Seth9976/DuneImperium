using System;
using Canis.utils;
using Canis.utils.ids;
using dwd.core.settings.serverSettings.save;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings
{
	// Token: 0x020000B8 RID: 184
	public class ServerSetting<T> : VersionedModel
	{
		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003FE90 File Offset: 0x0003E090
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSetting()
		{
			Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings", "ServerSetting`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr);
			ServerSetting<T>.NativeFieldInfoPtr_SaveNOOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "SaveNOOP");
			ServerSetting<T>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "key");
			ServerSetting<T>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "comparer");
			ServerSetting<T>.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "load");
			ServerSetting<T>.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "store");
			ServerSetting<T>.NativeFieldInfoPtr_deleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "deleteKey");
			ServerSetting<T>.NativeFieldInfoPtr_getAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "getAccountID");
			ServerSetting<T>.NativeFieldInfoPtr_unsafeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "unsafeCache");
			ServerSetting<T>.NativeFieldInfoPtr_cachedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "cachedID");
			ServerSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_T_Load_T_Store_T_DeleteKey_T_GetAccountID_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664910);
			ServerSetting<T>.NativeMethodInfoPtr_get_cache_Private_get_SettingCache_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664911);
			ServerSetting<T>.NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664912);
			ServerSetting<T>.NativeMethodInfoPtr_set_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664913);
			ServerSetting<T>.NativeMethodInfoPtr_delete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664914);
			ServerSetting<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664915);
			ServerSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664916);
			ServerSetting<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664917);
			ServerSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664918);
			ServerSetting<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664919);
			ServerSetting<T>.NativeMethodInfoPtr_DeleteWithoutSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664920);
			ServerSetting<T>.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664921);
			ServerSetting<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664922);
			ServerSetting<T>.NativeMethodInfoPtr_clearCacheIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664923);
			ServerSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664924);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664925);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664926);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664927);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664928);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664929);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664930);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664931);
			ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_T__SetWithoutSave_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, 100664932);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004017C File Offset: 0x0003E37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 863814, RefRangeEnd = 863815, XrefRangeStart = 863786, XrefRangeEnd = 863814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSetting(int key, T defaultValue, ServerSetting<T>.Load load, ServerSetting<T>.Store store, ServerSetting<T>.DeleteKey deleteKey, ServerSetting<T>.GetAccountID getAccountID, IEqualityComparer<T> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(load);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deleteKey);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getAccountID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_T_Load_T_Store_T_DeleteKey_T_GetAccountID_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0004026C File Offset: 0x0003E46C
		public unsafe SettingCache<T> cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863815, XrefRangeEnd = 863816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_get_cache_Private_get_SettingCache_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SettingCache<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000402AC File Offset: 0x0003E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863816, XrefRangeEnd = 863820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00040338 File Offset: 0x0003E538
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 863829, RefRangeEnd = 863838, XrefRangeStart = 863820, XrefRangeEnd = 863829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_set_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000403B0 File Offset: 0x0003E5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863838, XrefRangeEnd = 863840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_delete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000403E4 File Offset: 0x0003E5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863840, XrefRangeEnd = 863844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0004046C File Offset: 0x0003E66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863844, XrefRangeEnd = 863845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000404E4 File Offset: 0x0003E6E4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 863863, RefRangeEnd = 863873, XrefRangeStart = 863845, XrefRangeEnd = 863863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00040524 File Offset: 0x0003E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863873, XrefRangeEnd = 863874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSetting<T>.NativeMethodInfoPtr_Get_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00040568 File Offset: 0x0003E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863874, XrefRangeEnd = 863878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000405A8 File Offset: 0x0003E7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863878, XrefRangeEnd = 863879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_DeleteWithoutSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000405DC File Offset: 0x0003E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863879, XrefRangeEnd = 863883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00040610 File Offset: 0x0003E810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863883, XrefRangeEnd = 863884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(ServerSetting<T> setting)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setting);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSetting_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00040650 File Offset: 0x0003E850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863884, XrefRangeEnd = 863891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clearCacheIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_clearCacheIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00040684 File Offset: 0x0003E884
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863891, XrefRangeEnd = 863894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSetting<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000406CC File Offset: 0x0003E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863894, XrefRangeEnd = 863903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0004071C File Offset: 0x0003E91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863903, XrefRangeEnd = 863910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00040760 File Offset: 0x0003E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863910, XrefRangeEnd = 863912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000407A0 File Offset: 0x0003E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863912, XrefRangeEnd = 863913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000407D4 File Offset: 0x0003E9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863913, XrefRangeEnd = 863914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00040814 File Offset: 0x0003EA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863914, XrefRangeEnd = 863918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IRevertableSetting_Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00040854 File Offset: 0x0003EA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863918, XrefRangeEnd = 863922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000408DC File Offset: 0x0003EADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863922, XrefRangeEnd = 863923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_T__SetWithoutSave(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_T__SetWithoutSave_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000061A4 File Offset: 0x000043A4
		public ServerSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00040954 File Offset: 0x0003EB54
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x000061AD File Offset: 0x000043AD
		public unsafe static SaveRequest SaveNOOP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServerSetting<T>.NativeFieldInfoPtr_SaveNOOP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServerSetting<T>.NativeFieldInfoPtr_SaveNOOP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x0004097C File Offset: 0x0003EB7C
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x000061BF File Offset: 0x000043BF
		public unsafe int key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000409A4 File Offset: 0x0003EBA4
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x000061DA File Offset: 0x000043DA
		public unsafe IEqualityComparer<T> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000409D4 File Offset: 0x0003EBD4
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x000061F9 File Offset: 0x000043F9
		public unsafe ServerSetting<T>.Load load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>.Load>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00040A04 File Offset: 0x0003EC04
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00006218 File Offset: 0x00004418
		public unsafe ServerSetting<T>.Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>.Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00040A34 File Offset: 0x0003EC34
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe ServerSetting<T>.DeleteKey deleteKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_deleteKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>.DeleteKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_deleteKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00040A64 File Offset: 0x0003EC64
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00006256 File Offset: 0x00004456
		public unsafe ServerSetting<T>.GetAccountID getAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_getAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSetting<T>.GetAccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_getAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00040A94 File Offset: 0x0003EC94
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00006275 File Offset: 0x00004475
		public unsafe SettingCache<T> unsafeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_unsafeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingCache<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_unsafeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00040AC4 File Offset: 0x0003ECC4
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00006294 File Offset: 0x00004494
		public unsafe AccountID cachedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_cachedID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSetting<T>.NativeFieldInfoPtr_cachedID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_SaveNOOP;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_load;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_deleteKey;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_getAccountID;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeFieldInfoPtr_unsafeCache;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr_cachedID;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_T_Load_T_Store_T_DeleteKey_T_GetAccountID_T_IEqualityComparer_1_T_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_cache_Private_get_SettingCache_1_T_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_loadFromStorage_Private_Boolean_byref_T_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_set_Private_Void_T_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_delete_Private_Void_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_SaveRequest_T_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Void_T_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_SaveRequest_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_T_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_SaveRequest_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Void_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_ServerSetting_1_T_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_clearCacheIfNeeded_Private_Void_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_DeleteWithoutSave_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_T__SetWithoutSave_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x02000296 RID: 662
		public sealed class Load : MulticastDelegate
		{
			// Token: 0x06001F81 RID: 8065 RVA: 0x0008EF2C File Offset: 0x0008D12C
			// Note: this type is marked as 'beforefieldinit'.
			static Load()
			{
				Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "Load"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSetting<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr, 100664934);
				ServerSetting<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr, 100664935);
				ServerSetting<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr, 100664936);
				ServerSetting<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr, 100664937);
			}

			// Token: 0x06001F82 RID: 8066 RVA: 0x0008EFD8 File Offset: 0x0008D1D8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863742, RefRangeEnd = 863743, XrefRangeStart = 863739, XrefRangeEnd = 863742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Load(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSetting<T>.Load>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Load.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F83 RID: 8067 RVA: 0x0008F034 File Offset: 0x0008D234
			[CallerCount(0)]
			public unsafe bool Invoke(int key, out T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Load.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06001F84 RID: 8068 RVA: 0x0008F0CC File Offset: 0x0008D2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863743, XrefRangeEnd = 863750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int key, out T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Load.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				IntPtr intPtr6 = intPtr3;
				return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
			}

			// Token: 0x06001F85 RID: 8069 RVA: 0x0008F18C File Offset: 0x0008D38C
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Load.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x06001F86 RID: 8070 RVA: 0x0000D6D9 File Offset: 0x0000B8D9
			public Load(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_byref_T_0;

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_T_AsyncCallback_Object_0;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_T_IAsyncResult_0;
		}

		// Token: 0x02000297 RID: 663
		public sealed class Store : MulticastDelegate
		{
			// Token: 0x06001F87 RID: 8071 RVA: 0x0008F228 File Offset: 0x0008D428
			// Note: this type is marked as 'beforefieldinit'.
			static Store()
			{
				Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "Store"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSetting<T>.Store.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr, 100664938);
				ServerSetting<T>.Store.NativeMethodInfoPtr_Invoke_Public_Virtual_New_SaveOne_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr, 100664939);
				ServerSetting<T>.Store.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr, 100664940);
				ServerSetting<T>.Store.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SaveOne_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr, 100664941);
			}

			// Token: 0x06001F88 RID: 8072 RVA: 0x0008F2D4 File Offset: 0x0008D4D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 863753, RefRangeEnd = 863754, XrefRangeStart = 863750, XrefRangeEnd = 863753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Store(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSetting<T>.Store>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Store.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x0008F330 File Offset: 0x0008D530
			[CallerCount(0)]
			public unsafe SaveOne Invoke(int key, T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Store.NativeMethodInfoPtr_Invoke_Public_Virtual_New_SaveOne_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SaveOne>(intPtr4) : null;
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x0008F3C4 File Offset: 0x0008D5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863754, XrefRangeEnd = 863761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int key, T value, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Store.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x0008F480 File Offset: 0x0008D680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SaveOne EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.Store.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SaveOne_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveOne>(intPtr3) : null;
				}
			}

			// Token: 0x06001F8C RID: 8076 RVA: 0x0000D6E2 File Offset: 0x0000B8E2
			public Store(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x0000D6EB File Offset: 0x0000B8EB
			public static implicit operator ServerSetting<T>.Store(Func<int, T, SaveOne> A_0)
			{
				return DelegateSupport.ConvertDelegate<ServerSetting<T>.Store>(A_0);
			}

			// Token: 0x06001F8E RID: 8078 RVA: 0x0000D6F3 File Offset: 0x0000B8F3
			public static ServerSetting<T>.Store operator +(ServerSetting<T>.Store A_0, ServerSetting<T>.Store A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ServerSetting<T>.Store>();
			}

			// Token: 0x06001F8F RID: 8079 RVA: 0x0000D701 File Offset: 0x0000B901
			public static ServerSetting<T>.Store operator -(ServerSetting<T>.Store A_0, ServerSetting<T>.Store A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ServerSetting<T>.Store>();
				}
				return delegate2;
			}

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_SaveOne_Int32_T_0;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_T_AsyncCallback_Object_0;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_SaveOne_IAsyncResult_0;
		}

		// Token: 0x02000298 RID: 664
		public sealed class DeleteKey : MulticastDelegate
		{
			// Token: 0x06001F90 RID: 8080 RVA: 0x0008F4D0 File Offset: 0x0008D6D0
			// Note: this type is marked as 'beforefieldinit'.
			static DeleteKey()
			{
				Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "DeleteKey"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSetting<T>.DeleteKey.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr, 100664942);
				ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_Invoke_Public_Virtual_New_DeleteOne_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr, 100664943);
				ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr, 100664944);
				ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DeleteOne_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr, 100664945);
			}

			// Token: 0x06001F91 RID: 8081 RVA: 0x0008F57C File Offset: 0x0008D77C
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 863764, RefRangeEnd = 863782, XrefRangeStart = 863761, XrefRangeEnd = 863764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteKey(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSetting<T>.DeleteKey>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.DeleteKey.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F92 RID: 8082 RVA: 0x0008F5D8 File Offset: 0x0008D7D8
			[CallerCount(0)]
			public unsafe DeleteOne Invoke(int key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_Invoke_Public_Virtual_New_DeleteOne_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteOne>(intPtr3) : null;
				}
			}

			// Token: 0x06001F93 RID: 8083 RVA: 0x0008F624 File Offset: 0x0008D824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 863782, XrefRangeEnd = 863786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int key, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref key;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F94 RID: 8084 RVA: 0x0008F694 File Offset: 0x0008D894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteOne EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.DeleteKey.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DeleteOne_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteOne>(intPtr3) : null;
				}
			}

			// Token: 0x06001F95 RID: 8085 RVA: 0x0000D712 File Offset: 0x0000B912
			public DeleteKey(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F96 RID: 8086 RVA: 0x0000D71B File Offset: 0x0000B91B
			public static implicit operator ServerSetting<T>.DeleteKey(Func<int, DeleteOne> A_0)
			{
				return DelegateSupport.ConvertDelegate<ServerSetting<T>.DeleteKey>(A_0);
			}

			// Token: 0x06001F97 RID: 8087 RVA: 0x0000D723 File Offset: 0x0000B923
			public static ServerSetting<T>.DeleteKey operator +(ServerSetting<T>.DeleteKey A_0, ServerSetting<T>.DeleteKey A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ServerSetting<T>.DeleteKey>();
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x0000D731 File Offset: 0x0000B931
			public static ServerSetting<T>.DeleteKey operator -(ServerSetting<T>.DeleteKey A_0, ServerSetting<T>.DeleteKey A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ServerSetting<T>.DeleteKey>();
				}
				return delegate2;
			}

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001621 RID: 5665
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_DeleteOne_Int32_0;

			// Token: 0x04001622 RID: 5666
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

			// Token: 0x04001623 RID: 5667
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DeleteOne_IAsyncResult_0;
		}

		// Token: 0x02000299 RID: 665
		public sealed class GetAccountID : MulticastDelegate
		{
			// Token: 0x06001F99 RID: 8089 RVA: 0x0008F6E4 File Offset: 0x0008D8E4
			// Note: this type is marked as 'beforefieldinit'.
			static GetAccountID()
			{
				Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerSetting<T>>.NativeClassPtr, "GetAccountID"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ServerSetting<T>.GetAccountID.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr, 100664946);
				ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr, 100664947);
				ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr, 100664948);
				ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AccountID_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr, 100664949);
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x0008F790 File Offset: 0x0008D990
			[CallerCount(210)]
			[CachedScanResults(RefRangeStart = 320759, RefRangeEnd = 320969, XrefRangeStart = 320759, XrefRangeEnd = 320969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetAccountID(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSetting<T>.GetAccountID>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.GetAccountID.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9B RID: 8091 RVA: 0x0008F7EC File Offset: 0x0008D9EC
			[CallerCount(0)]
			public unsafe AccountID Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}

			// Token: 0x06001F9C RID: 8092 RVA: 0x0008F82C File Offset: 0x0008DA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x0008F890 File Offset: 0x0008DA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSetting<T>.GetAccountID.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AccountID_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x0000D742 File Offset: 0x0000B942
			public GetAccountID(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x0000D74B File Offset: 0x0000B94B
			public static implicit operator ServerSetting<T>.GetAccountID(Func<AccountID> A_0)
			{
				return DelegateSupport.ConvertDelegate<ServerSetting<T>.GetAccountID>(A_0);
			}

			// Token: 0x06001FA0 RID: 8096 RVA: 0x0000D753 File Offset: 0x0000B953
			public static ServerSetting<T>.GetAccountID operator +(ServerSetting<T>.GetAccountID A_0, ServerSetting<T>.GetAccountID A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ServerSetting<T>.GetAccountID>();
			}

			// Token: 0x06001FA1 RID: 8097 RVA: 0x0000D761 File Offset: 0x0000B961
			public static ServerSetting<T>.GetAccountID operator -(ServerSetting<T>.GetAccountID A_0, ServerSetting<T>.GetAccountID A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ServerSetting<T>.GetAccountID>();
				}
				return delegate2;
			}

			// Token: 0x04001624 RID: 5668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001625 RID: 5669
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AccountID_0;

			// Token: 0x04001626 RID: 5670
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001627 RID: 5671
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_AccountID_IAsyncResult_0;
		}
	}
}
