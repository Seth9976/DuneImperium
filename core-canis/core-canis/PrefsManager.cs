using System;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

// Token: 0x0200003D RID: 61
public static class PrefsManager : Object
{
	// Token: 0x060004D7 RID: 1239 RVA: 0x000268A0 File Offset: 0x00024AA0
	// Note: this type is marked as 'beforefieldinit'.
	static PrefsManager()
	{
		Il2CppClassPointerStore<PrefsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "PrefsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr);
		PrefsManager.NativeFieldInfoPtr_configDefinitionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, "configDefinitionMap");
		PrefsManager.NativeMethodInfoPtr_get_All_Public_Static_get_IEnumerable_1_ISettingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, 100664000);
		PrefsManager.NativeMethodInfoPtr_AddConfig_Public_Static_Void_String_ISettingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, 100664001);
		PrefsManager.NativeMethodInfoPtr_GetConfig_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, 100664002);
		PrefsManager.NativeMethodInfoPtr_TryGetConfig_Public_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, 100664003);
		PrefsManager.NativeMethodInfoPtr_GetValue_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefsManager>.NativeClassPtr, 100664004);
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00026948 File Offset: 0x00024B48
	public unsafe static IEnumerable<ISettingDefinition> All
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857326, RefRangeEnd = 857327, XrefRangeStart = 857318, XrefRangeEnd = 857326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefsManager.NativeMethodInfoPtr_get_All_Public_Static_get_IEnumerable_1_ISettingDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ISettingDefinition>>(intPtr3) : null;
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0002697C File Offset: 0x00024B7C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857345, RefRangeEnd = 857348, XrefRangeStart = 857327, XrefRangeEnd = 857345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddConfig(string key, ISettingDefinition config)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(config);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefsManager.NativeMethodInfoPtr_AddConfig_Public_Static_Void_String_ISettingDefinition_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x000269C4 File Offset: 0x00024BC4
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 857353, RefRangeEnd = 857358, XrefRangeStart = 857348, XrefRangeEnd = 857353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetConfig<T>(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefsManager.MethodInfoStoreGeneric_GetConfig_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00026A04 File Offset: 0x00024C04
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 857371, RefRangeEnd = 857382, XrefRangeStart = 857358, XrefRangeEnd = 857371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetConfig<T>(string key, out T config)
	{
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
			intPtr2 = ref config;
		}
		ptr2 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PrefsManager.MethodInfoStoreGeneric_TryGetConfig_Public_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			config = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
		return *IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00026A94 File Offset: 0x00024C94
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857391, RefRangeEnd = 857394, XrefRangeStart = 857382, XrefRangeEnd = 857391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetValue<T>(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefsManager.MethodInfoStoreGeneric_GetValue_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00003C9F File Offset: 0x00001E9F
	public PrefsManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x00026AD4 File Offset: 0x00024CD4
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x00003CA8 File Offset: 0x00001EA8
	public unsafe static Dictionary<string, ISettingDefinition> configDefinitionMap
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(PrefsManager.NativeFieldInfoPtr_configDefinitionMap, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ISettingDefinition>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PrefsManager.NativeFieldInfoPtr_configDefinitionMap, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000386 RID: 902
	private static readonly IntPtr NativeFieldInfoPtr_configDefinitionMap;

	// Token: 0x04000387 RID: 903
	private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_Static_get_IEnumerable_1_ISettingDefinition_0;

	// Token: 0x04000388 RID: 904
	private static readonly IntPtr NativeMethodInfoPtr_AddConfig_Public_Static_Void_String_ISettingDefinition_0;

	// Token: 0x04000389 RID: 905
	private static readonly IntPtr NativeMethodInfoPtr_GetConfig_Public_Static_T_String_0;

	// Token: 0x0400038A RID: 906
	private static readonly IntPtr NativeMethodInfoPtr_TryGetConfig_Public_Static_Boolean_String_byref_T_0;

	// Token: 0x0400038B RID: 907
	private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_String_0;

	// Token: 0x02000245 RID: 581
	private sealed class MethodInfoStoreGeneric_GetConfig_Public_Static_T_String_0<T>
	{
		// Token: 0x0400155E RID: 5470
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefsManager.NativeMethodInfoPtr_GetConfig_Public_Static_T_String_0, Il2CppClassPointerStore<PrefsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000246 RID: 582
	private sealed class MethodInfoStoreGeneric_TryGetConfig_Public_Static_Boolean_String_byref_T_0<T>
	{
		// Token: 0x0400155F RID: 5471
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefsManager.NativeMethodInfoPtr_TryGetConfig_Public_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<PrefsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000247 RID: 583
	private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_String_0<T>
	{
		// Token: 0x04001560 RID: 5472
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PrefsManager.NativeMethodInfoPtr_GetValue_Public_Static_T_String_0, Il2CppClassPointerStore<PrefsManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
