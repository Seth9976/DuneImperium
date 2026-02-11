using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x02000037 RID: 55
public class GameManagers : MonoBehaviour
{
	// Token: 0x06000495 RID: 1173 RVA: 0x000257F0 File Offset: 0x000239F0
	// Note: this type is marked as 'beforefieldinit'.
	static GameManagers()
	{
		Il2CppClassPointerStore<GameManagers>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GameManagers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManagers>.NativeClassPtr);
		GameManagers.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, "_instance");
		GameManagers.NativeFieldInfoPtr_registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, "registry");
		GameManagers.NativeFieldInfoPtr_shuttingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, "shuttingDown");
		GameManagers.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663965);
		GameManagers.NativeMethodInfoPtr_RegisterManager_Public_Void_IGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663966);
		GameManagers.NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663967);
		GameManagers.NativeMethodInfoPtr_TryGetManager_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663968);
		GameManagers.NativeMethodInfoPtr_GetManager_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663969);
		GameManagers.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663970);
		GameManagers.NativeMethodInfoPtr_Get_Public_Static_GameManagers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663971);
		GameManagers.NativeMethodInfoPtr_GetMgr_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663972);
		GameManagers.NativeMethodInfoPtr_TryGetMgr_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663973);
		GameManagers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManagers>.NativeClassPtr, 100663974);
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00025924 File Offset: 0x00023B24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856915, XrefRangeEnd = 856961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00025958 File Offset: 0x00023B58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856966, RefRangeEnd = 856967, XrefRangeStart = 856961, XrefRangeEnd = 856966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterManager(IGameManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr_RegisterManager_Public_Void_IGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0002599C File Offset: 0x00023B9C
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 689957, RefRangeEnd = 689983, XrefRangeStart = 689957, XrefRangeEnd = 689983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x000259D0 File Offset: 0x00023BD0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857001, RefRangeEnd = 857004, XrefRangeStart = 856967, XrefRangeEnd = 857001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetManager<T>(out T manager) where T : class
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
				intPtr2 = ref manager;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameManagers.MethodInfoStoreGeneric_TryGetManager_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				manager = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00025A5C File Offset: 0x00023C5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857004, XrefRangeEnd = 857006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetManager<T>() where T : class
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.MethodInfoStoreGeneric_GetManager_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00025A98 File Offset: 0x00023C98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857006, XrefRangeEnd = 857015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00025ACC File Offset: 0x00023CCC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 857022, RefRangeEnd = 857024, XrefRangeStart = 857015, XrefRangeEnd = 857022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameManagers Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr_Get_Public_Static_GameManagers_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameManagers>(intPtr3) : null;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00025B00 File Offset: 0x00023D00
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857032, RefRangeEnd = 857035, XrefRangeStart = 857024, XrefRangeEnd = 857032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMgr<T>() where T : class
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.MethodInfoStoreGeneric_GetMgr_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00025B30 File Offset: 0x00023D30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857042, RefRangeEnd = 857043, XrefRangeStart = 857035, XrefRangeEnd = 857042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetMgr<T>(out T manager) where T : class
	{
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
				intPtr2 = ref manager;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameManagers.MethodInfoStoreGeneric_TryGetMgr_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				manager = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00025BB0 File Offset: 0x00023DB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857043, XrefRangeEnd = 857051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameManagers()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManagers>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManagers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00003B50 File Offset: 0x00001D50
	public GameManagers(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00025BEC File Offset: 0x00023DEC
	// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003B59 File Offset: 0x00001D59
	public unsafe static GameManagers _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameManagers.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameManagers>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameManagers.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00025C14 File Offset: 0x00023E14
	// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003B6B File Offset: 0x00001D6B
	public unsafe Dictionary<Type, IGameManager> registry
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManagers.NativeFieldInfoPtr_registry);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, IGameManager>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManagers.NativeFieldInfoPtr_registry), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00025C44 File Offset: 0x00023E44
	// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003B8A File Offset: 0x00001D8A
	public unsafe bool shuttingDown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManagers.NativeFieldInfoPtr_shuttingDown);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManagers.NativeFieldInfoPtr_shuttingDown)) = value;
		}
	}

	// Token: 0x0400035A RID: 858
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x0400035B RID: 859
	private static readonly IntPtr NativeFieldInfoPtr_registry;

	// Token: 0x0400035C RID: 860
	private static readonly IntPtr NativeFieldInfoPtr_shuttingDown;

	// Token: 0x0400035D RID: 861
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400035E RID: 862
	private static readonly IntPtr NativeMethodInfoPtr_RegisterManager_Public_Void_IGameManager_0;

	// Token: 0x0400035F RID: 863
	private static readonly IntPtr NativeMethodInfoPtr_dwd_core_client_IApplicationQuitHandler_HandleApplicationQuit_Private_Virtual_Final_New_Void_0;

	// Token: 0x04000360 RID: 864
	private static readonly IntPtr NativeMethodInfoPtr_TryGetManager_Public_Boolean_byref_T_0;

	// Token: 0x04000361 RID: 865
	private static readonly IntPtr NativeMethodInfoPtr_GetManager_Public_T_0;

	// Token: 0x04000362 RID: 866
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000363 RID: 867
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_GameManagers_0;

	// Token: 0x04000364 RID: 868
	private static readonly IntPtr NativeMethodInfoPtr_GetMgr_Public_Static_T_0;

	// Token: 0x04000365 RID: 869
	private static readonly IntPtr NativeMethodInfoPtr_TryGetMgr_Public_Static_Boolean_byref_T_0;

	// Token: 0x04000366 RID: 870
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000241 RID: 577
	private sealed class MethodInfoStoreGeneric_TryGetManager_Public_Boolean_byref_T_0<T>
	{
		// Token: 0x0400155A RID: 5466
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManagers.NativeMethodInfoPtr_TryGetManager_Public_Boolean_byref_T_0, Il2CppClassPointerStore<GameManagers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000242 RID: 578
	private sealed class MethodInfoStoreGeneric_GetManager_Public_T_0<T>
	{
		// Token: 0x0400155B RID: 5467
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManagers.NativeMethodInfoPtr_GetManager_Public_T_0, Il2CppClassPointerStore<GameManagers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000243 RID: 579
	private sealed class MethodInfoStoreGeneric_GetMgr_Public_Static_T_0<T>
	{
		// Token: 0x0400155C RID: 5468
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManagers.NativeMethodInfoPtr_GetMgr_Public_Static_T_0, Il2CppClassPointerStore<GameManagers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000244 RID: 580
	private sealed class MethodInfoStoreGeneric_TryGetMgr_Public_Static_Boolean_byref_T_0<T>
	{
		// Token: 0x0400155D RID: 5469
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameManagers.NativeMethodInfoPtr_TryGetMgr_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<GameManagers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
