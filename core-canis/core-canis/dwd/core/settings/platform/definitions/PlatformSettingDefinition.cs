using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.platform.definitions
{
	// Token: 0x020000E8 RID: 232
	public class PlatformSettingDefinition : Object
	{
		// Token: 0x06000DD0 RID: 3536 RVA: 0x00049DB8 File Offset: 0x00047FB8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSettingDefinition()
		{
			Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "PlatformSettingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr);
			PlatformSettingDefinition.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, "<Key>k__BackingField");
			PlatformSettingDefinition.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665291);
			PlatformSettingDefinition.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665292);
			PlatformSettingDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665293);
			PlatformSettingDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665294);
			PlatformSettingDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665295);
			PlatformSettingDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665296);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665297);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665298);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665299);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665300);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665301);
			PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr, 100665302);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00049EEC File Offset: 0x000480EC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 866634, RefRangeEnd = 866643, XrefRangeStart = 866628, XrefRangeEnd = 866634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSettingDefinition(string key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSettingDefinition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00049F38 File Offset: 0x00048138
		public unsafe string Key
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00049F70 File Offset: 0x00048170
		[CallerCount(0)]
		public unsafe virtual IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSettingDefinition.NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00049FBC File Offset: 0x000481BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866643, XrefRangeEnd = 866647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteWithoutSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00049FF0 File Offset: 0x000481F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866647, XrefRangeEnd = 866651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revert()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0004A024 File Offset: 0x00048224
		public unsafe virtual ulong Version
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 866655, RefRangeEnd = 866657, XrefRangeStart = 866651, XrefRangeEnd = 866655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0004A060 File Offset: 0x00048260
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 308626, RefRangeEnd = 308638, XrefRangeStart = 308626, XrefRangeEnd = 308638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting dwd_core_settings_ISettingDefinition_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting>(intPtr3) : null;
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0004A0A0 File Offset: 0x000482A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866657, XrefRangeEnd = 866661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object dwd_core_settings_ISetting_Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0004A0E0 File Offset: 0x000482E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866661, XrefRangeEnd = 866665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Set(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0004A130 File Offset: 0x00048330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866665, XrefRangeEnd = 866669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void dwd_core_settings_IRevertableSetting_SetWithoutSave(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0004A174 File Offset: 0x00048374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866669, XrefRangeEnd = 866673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IWritableSetting_Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0004A1B4 File Offset: 0x000483B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866673, XrefRangeEnd = 866677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest dwd_core_settings_IRevertableSetting_Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition.NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00006BD4 File Offset: 0x00004DD4
		public PlatformSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0004A1F4 File Offset: 0x000483F4
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00006BDD File Offset: 0x00004DDD
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Abstract_Virtual_New_IRevertableSetting_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWithoutSave_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Virtual_Final_New_Void_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_Get_Private_Virtual_Final_New_ISetting_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_Get_Private_Virtual_Final_New_Object_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Set_Private_Virtual_Final_New_ISaveSettingRequest_Object_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_SetWithoutSave_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_Delete_Private_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IRevertableSetting_Save_Private_Virtual_Final_New_ISaveSettingRequest_0;
	}
}
