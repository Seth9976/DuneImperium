using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.serverSettings.definitions
{
	// Token: 0x020000C3 RID: 195
	public class ServerSettingDefinition : Object
	{
		// Token: 0x06000C36 RID: 3126 RVA: 0x00042354 File Offset: 0x00040554
		// Note: this type is marked as 'beforefieldinit'.
		static ServerSettingDefinition()
		{
			Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.definitions", "ServerSettingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr);
			ServerSettingDefinition.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, "key");
			ServerSettingDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IUniqueKeyRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665017);
			ServerSettingDefinition.NativeMethodInfoPtr_get_Key_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665018);
			ServerSettingDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665019);
			ServerSettingDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665020);
			ServerSettingDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665021);
			ServerSettingDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665022);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665023);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665024);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665025);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665026);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665027);
			ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr, 100665028);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00042488 File Offset: 0x00040688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 864345, RefRangeEnd = 864348, XrefRangeStart = 864341, XrefRangeEnd = 864345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerSettingDefinition(int key, IUniqueKeyRegistry keyRegistry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerSettingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyRegistry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IUniqueKeyRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x000424E4 File Offset: 0x000406E4
		public unsafe int Key
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_get_Key_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00042520 File Offset: 0x00040720
		[CallerCount(0)]
		public unsafe virtual IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerSettingDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0004256C File Offset: 0x0004076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864348, XrefRangeEnd = 864352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000425A0 File Offset: 0x000407A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864352, XrefRangeEnd = 864356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x000425D4 File Offset: 0x000407D4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864356, XrefRangeEnd = 864360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00042610 File Offset: 0x00040810
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting dwd_core_settings_ISettingDefinition_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00042650 File Offset: 0x00040850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864360, XrefRangeEnd = 864364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00042690 File Offset: 0x00040890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864364, XrefRangeEnd = 864368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000426E0 File Offset: 0x000408E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864368, XrefRangeEnd = 864372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00042724 File Offset: 0x00040924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864372, XrefRangeEnd = 864376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00042764 File Offset: 0x00040964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864376, XrefRangeEnd = 864380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IRevertableSetting_Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00006550 File Offset: 0x00004750
		public ServerSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x000427A4 File Offset: 0x000409A4
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00006559 File Offset: 0x00004759
		public unsafe int key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition.NativeFieldInfoPtr_key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerSettingDefinition.NativeFieldInfoPtr_key)) = value;
			}
		}

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_IUniqueKeyRegistry_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Int32_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0;
	}
}
