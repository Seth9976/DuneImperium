using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.platform.definitions
{
	// Token: 0x020000E9 RID: 233
	public class PlatformSettingDefinition<T> : PlatformSettingDefinition
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x0004A21C File Offset: 0x0004841C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSettingDefinition()
		{
			Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform.definitions", "PlatformSettingDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr);
			PlatformSettingDefinition<T>.NativeFieldInfoPtr_namespacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, "namespacing");
			PlatformSettingDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, "<Default>k__BackingField");
			PlatformSettingDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, "<ComparerOverride>k__BackingField");
			PlatformSettingDefinition<T>.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, "setting");
			PlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665303);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_Default_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665304);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665305);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_PlatformSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665306);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665307);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_New_PlatformSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665308);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSettingDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665309);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_Set_Public_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665310);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665311);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665312);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665313);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665314);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665315);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665316);
			PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr, 100665317);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0004A404 File Offset: 0x00048604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866677, XrefRangeEnd = 866727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSettingDefinition(string key, T defaultValue, PlatformSettingStorageNamespacing namespacing = PlatformSettingStorageNamespacing.KeepForNew, IEqualityComparer<T> comparer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformSettingDefinition<T>>.NativeClassPtr))
		{
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
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref namespacing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0004A4B8 File Offset: 0x000486B8
		public unsafe T Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_Default_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x0004A4F4 File Offset: 0x000486F4
		public unsafe IEqualityComparer<T> ComparerOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0004A534 File Offset: 0x00048734
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 866728, RefRangeEnd = 866761, XrefRangeStart = 866727, XrefRangeEnd = 866728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_Get_Public_PlatformSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0004A574 File Offset: 0x00048774
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 866728, RefRangeEnd = 866761, XrefRangeStart = 866728, XrefRangeEnd = 866761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSettingDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0004A5C0 File Offset: 0x000487C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866761, XrefRangeEnd = 866804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PlatformSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformSettingDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Virtual_New_PlatformSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0004A60C File Offset: 0x0004880C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 866807, RefRangeEnd = 866829, XrefRangeStart = 866804, XrefRangeEnd = 866807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(PlatformSettingDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSettingDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0004A64C File Offset: 0x0004884C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 866847, RefRangeEnd = 866859, XrefRangeStart = 866829, XrefRangeEnd = 866847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISaveSettingRequest Set(T value)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_Set_Public_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0004A6D4 File Offset: 0x000488D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866859, XrefRangeEnd = 866877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0004A74C File Offset: 0x0004894C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866877, XrefRangeEnd = 866885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0004A78C File Offset: 0x0004898C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866885, XrefRangeEnd = 866895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISaveSettingRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr3) : null;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0004A7CC File Offset: 0x000489CC
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 866728, RefRangeEnd = 866761, XrefRangeStart = 866728, XrefRangeEnd = 866761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting<T> dwd_core_settings_ISettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0004A80C File Offset: 0x00048A0C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 866728, RefRangeEnd = 866761, XrefRangeStart = 866728, XrefRangeEnd = 866761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IWritableSetting<T> dwd_core_settings_IWritableSettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWritableSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0004A84C File Offset: 0x00048A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866895, XrefRangeEnd = 866901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T dwd_core_settings_ISetting_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0004A888 File Offset: 0x00048A88
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 866847, RefRangeEnd = 866859, XrefRangeStart = 866847, XrefRangeEnd = 866859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlatformSettingDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00006BFC File Offset: 0x00004DFC
		public PlatformSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x0004A910 File Offset: 0x00048B10
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00006C05 File Offset: 0x00004E05
		public unsafe PlatformSettingStorageNamespacing namespacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr_namespacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr_namespacing)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0004A938 File Offset: 0x00048B38
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0004A960 File Offset: 0x00048B60
		public unsafe T _Default_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
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

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0004AA08 File Offset: 0x00048C08
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00006C20 File Offset: 0x00004E20
		public unsafe IEqualityComparer<T> _ComparerOverride_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0004AA38 File Offset: 0x00048C38
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00006C3F File Offset: 0x00004E3F
		public unsafe PlatformSetting<T> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSetting<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformSettingDefinition<T>.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_namespacing;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr__ComparerOverride_k__BackingField;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_T_PlatformSettingStorageNamespacing_IEqualityComparer_1_T_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_get_T_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_get_ComparerOverride_Public_get_IEqualityComparer_1_T_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_PlatformSetting_1_T_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_New_PlatformSetting_1_T_0;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_PlatformSettingDefinition_1_T_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_ISaveSettingRequest_T_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_ISaveSettingRequest_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0;
	}
}
