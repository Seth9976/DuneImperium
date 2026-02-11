using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.playerPrefs.definitions
{
	// Token: 0x020000DC RID: 220
	public class PrefDefinition<T> : PrefDefinition
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x00047574 File Offset: 0x00045774
		// Note: this type is marked as 'beforefieldinit'.
		static PrefDefinition()
		{
			Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs.definitions", "PrefDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr);
			PrefDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, "<Default>k__BackingField");
			PrefDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, "<ComparerOverride>k__BackingField");
			PrefDefinition<T>.NativeFieldInfoPtr_setting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, "setting");
			PrefDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_T_IEqualityComparer_1_T_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665193);
			PrefDefinition<T>.NativeMethodInfoPtr_get_Default_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665194);
			PrefDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Private_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665195);
			PrefDefinition<T>.NativeMethodInfoPtr_Get_Public_PrefSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665196);
			PrefDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665197);
			PrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_PrefSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665198);
			PrefDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PrefDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665199);
			PrefDefinition<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665200);
			PrefDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665201);
			PrefDefinition<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665202);
			PrefDefinition<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665203);
			PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665204);
			PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665205);
			PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665206);
			PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr, 100665207);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00047748 File Offset: 0x00045948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 865898, RefRangeEnd = 865901, XrefRangeStart = 865889, XrefRangeEnd = 865898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefDefinition(string key, bool isAccountSetting, T defaultValue, IEqualityComparer<T> comparer = null, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefDefinition<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_T_IEqualityComparer_1_T_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00047810 File Offset: 0x00045A10
		public unsafe T Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_get_Default_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x0004784C File Offset: 0x00045A4C
		public unsafe IEqualityComparer<T> ComparerOverride
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_get_ComparerOverride_Private_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0004788C File Offset: 0x00045A8C
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 865902, RefRangeEnd = 865958, XrefRangeStart = 865901, XrefRangeEnd = 865902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefSetting<T> Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_Get_Public_PrefSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000478CC File Offset: 0x00045ACC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 865902, RefRangeEnd = 865958, XrefRangeStart = 865902, XrefRangeEnd = 865958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IRevertableSetting get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefDefinition<T>.NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRevertableSetting>(intPtr3) : null;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00047918 File Offset: 0x00045B18
		[CallerCount(0)]
		public unsafe virtual PrefSetting<T> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefDefinition<T>.NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_PrefSetting_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00047964 File Offset: 0x00045B64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 865966, RefRangeEnd = 865968, XrefRangeStart = 865958, XrefRangeEnd = 865966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator T(PrefDefinition<T> definition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_T_PrefDefinition_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000479A4 File Offset: 0x00045BA4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 865990, RefRangeEnd = 866005, XrefRangeStart = 865968, XrefRangeEnd = 865990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_Set_Public_SaveRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00047A2C File Offset: 0x00045C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866005, XrefRangeEnd = 866013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00047AA4 File Offset: 0x00045CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866013, XrefRangeEnd = 866033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_Delete_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00047AE4 File Offset: 0x00045CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866033, XrefRangeEnd = 866046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_Save_Public_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveRequest>(intPtr3) : null;
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00047B24 File Offset: 0x00045D24
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 865902, RefRangeEnd = 865958, XrefRangeStart = 865902, XrefRangeEnd = 865958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISetting<T> dwd_core_settings_ISettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00047B64 File Offset: 0x00045D64
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 865902, RefRangeEnd = 865958, XrefRangeStart = 865902, XrefRangeEnd = 865958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IWritableSetting<T> dwd_core_settings_IWritableSettingDefinition_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWritableSetting<T>>(intPtr3) : null;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00047BA4 File Offset: 0x00045DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866046, XrefRangeEnd = 866049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T dwd_core_settings_ISetting_T__Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00047BE0 File Offset: 0x00045DE0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 865990, RefRangeEnd = 866005, XrefRangeStart = 865990, XrefRangeEnd = 866005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefDefinition<T>.NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ISaveSettingRequest>(intPtr4) : null;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0000698C File Offset: 0x00004B8C
		public PrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00047C68 File Offset: 0x00045E68
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00047C90 File Offset: 0x00045E90
		public unsafe T _Default_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr__Default_k__BackingField);
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

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00047D38 File Offset: 0x00045F38
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00006995 File Offset: 0x00004B95
		public unsafe IEqualityComparer<T> _ComparerOverride_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr__ComparerOverride_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00047D68 File Offset: 0x00045F68
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x000069B4 File Offset: 0x00004BB4
		public unsafe PrefSetting<T> setting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr_setting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefDefinition<T>.NativeFieldInfoPtr_setting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr__ComparerOverride_k__BackingField;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr_setting;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Boolean_T_IEqualityComparer_1_T_ISetting_1_String_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Protected_get_T_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_get_ComparerOverride_Private_get_IEqualityComparer_1_T_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_PrefSetting_1_T_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_get_Protected_Virtual_IRevertableSetting_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Abstract_Virtual_New_PrefSetting_1_T_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_T_PrefDefinition_1_T_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_SaveRequest_T_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_SetWithoutSave_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_SaveRequest_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_SaveRequest_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISettingDefinition_T__Get_Private_Virtual_Final_New_ISetting_1_T_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSettingDefinition_T__Get_Private_Virtual_Final_New_IWritableSetting_1_T_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_ISetting_T__Get_Private_Virtual_Final_New_T_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_settings_IWritableSetting_T__Set_Private_Virtual_Final_New_ISaveSettingRequest_T_0;
	}
}
