using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class MenuManager : MonoBehaviour
{
	// Token: 0x0600004D RID: 77 RVA: 0x00003A60 File Offset: 0x00001C60
	// Note: this type is marked as 'beforefieldinit'.
	static MenuManager()
	{
		Il2CppClassPointerStore<MenuManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "", "MenuManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuManager>.NativeClassPtr);
		MenuManager.NativeFieldInfoPtr__MenuActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "<MenuActions>k__BackingField");
		MenuManager.NativeFieldInfoPtr__GameActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "<GameActions>k__BackingField");
		MenuManager.NativeFieldInfoPtr_BindingsMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "BindingsMenu");
		MenuManager.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "instance");
		MenuManager.NativeFieldInfoPtr_applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "applicationIsQuitting");
		MenuManager.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, "lockObject");
		MenuManager.NativeMethodInfoPtr_get_MenuActions_Public_get_MenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663331);
		MenuManager.NativeMethodInfoPtr_set_MenuActions_Private_set_Void_MenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663332);
		MenuManager.NativeMethodInfoPtr_get_GameActions_Public_get_GameActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663333);
		MenuManager.NativeMethodInfoPtr_set_GameActions_Private_set_Void_GameActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663334);
		MenuManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663335);
		MenuManager.NativeMethodInfoPtr_SetupInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663336);
		MenuManager.NativeMethodInfoPtr_ResetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663337);
		MenuManager.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663338);
		MenuManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663339);
		MenuManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_MenuManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663340);
		MenuManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenuManager>.NativeClassPtr, 100663341);
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00003BE4 File Offset: 0x00001DE4
	// (set) Token: 0x0600004F RID: 79 RVA: 0x00003C24 File Offset: 0x00001E24
	public unsafe MenuActions MenuActions
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_get_MenuActions_Public_get_MenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MenuActions>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_set_MenuActions_Private_set_Void_MenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00003C68 File Offset: 0x00001E68
	// (set) Token: 0x06000051 RID: 81 RVA: 0x00003CA8 File Offset: 0x00001EA8
	public unsafe GameActions GameActions
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_get_GameActions_Public_get_GameActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameActions>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_set_GameActions_Private_set_Void_GameActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00003CEC File Offset: 0x00001EEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251348, XrefRangeEnd = 1251374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00003D20 File Offset: 0x00001F20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251374, XrefRangeEnd = 1251402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_SetupInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00003D54 File Offset: 0x00001F54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251402, XrefRangeEnd = 1251406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_ResetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003D88 File Offset: 0x00001F88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251406, XrefRangeEnd = 1251413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003DB0 File Offset: 0x00001FB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251413, XrefRangeEnd = 1251420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000057 RID: 87 RVA: 0x00003DE4 File Offset: 0x00001FE4
	public unsafe static MenuManager Instance
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251458, RefRangeEnd = 1251460, XrefRangeStart = 1251420, XrefRangeEnd = 1251458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_MenuManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MenuManager>(intPtr3) : null;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003E18 File Offset: 0x00002018
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MenuManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenuManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000233D File Offset: 0x0000053D
	public MenuManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600005A RID: 90 RVA: 0x00003E54 File Offset: 0x00002054
	// (set) Token: 0x0600005B RID: 91 RVA: 0x00002346 File Offset: 0x00000546
	public unsafe MenuActions _MenuActions_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr__MenuActions_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuActions>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr__MenuActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600005C RID: 92 RVA: 0x00003E84 File Offset: 0x00002084
	// (set) Token: 0x0600005D RID: 93 RVA: 0x00002365 File Offset: 0x00000565
	public unsafe GameActions _GameActions_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr__GameActions_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameActions>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr__GameActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600005E RID: 94 RVA: 0x00003EB4 File Offset: 0x000020B4
	// (set) Token: 0x0600005F RID: 95 RVA: 0x00002384 File Offset: 0x00000584
	public unsafe BindingsMenu BindingsMenu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr_BindingsMenu);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingsMenu>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MenuManager.NativeFieldInfoPtr_BindingsMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000060 RID: 96 RVA: 0x00003EE4 File Offset: 0x000020E4
	// (set) Token: 0x06000061 RID: 97 RVA: 0x000023A3 File Offset: 0x000005A3
	public unsafe static MenuManager instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(MenuManager.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MenuManager.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000062 RID: 98 RVA: 0x00003F0C File Offset: 0x0000210C
	// (set) Token: 0x06000063 RID: 99 RVA: 0x000023B5 File Offset: 0x000005B5
	public unsafe static bool applicationIsQuitting
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(MenuManager.NativeFieldInfoPtr_applicationIsQuitting, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MenuManager.NativeFieldInfoPtr_applicationIsQuitting, (void*)(&value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000064 RID: 100 RVA: 0x00003F28 File Offset: 0x00002128
	// (set) Token: 0x06000065 RID: 101 RVA: 0x000023C3 File Offset: 0x000005C3
	public unsafe static global::Il2CppSystem.Object lockObject
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(MenuManager.NativeFieldInfoPtr_lockObject, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MenuManager.NativeFieldInfoPtr_lockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeFieldInfoPtr__MenuActions_k__BackingField;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeFieldInfoPtr__GameActions_k__BackingField;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr_BindingsMenu;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeFieldInfoPtr_applicationIsQuitting;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeFieldInfoPtr_lockObject;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_get_MenuActions_Public_get_MenuActions_0;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeMethodInfoPtr_set_MenuActions_Private_set_Void_MenuActions_0;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_get_GameActions_Public_get_GameActions_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_set_GameActions_Private_set_Void_GameActions_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_SetupInput_Private_Void_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_ResetInput_Private_Void_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MenuManager_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
