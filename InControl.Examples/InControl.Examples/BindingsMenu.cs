using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using InControl;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000003 RID: 3
public class BindingsMenu : MonoBehaviour
{
	// Token: 0x06000016 RID: 22 RVA: 0x00003184 File Offset: 0x00001384
	// Note: this type is marked as 'beforefieldinit'.
	static BindingsMenu()
	{
		Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "", "BindingsMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr);
		BindingsMenu.NativeFieldInfoPtr_BindingButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, "BindingButtonPrefab");
		BindingsMenu.NativeFieldInfoPtr_bindingButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, "bindingButtons");
		BindingsMenu.NativeFieldInfoPtr_bindingsLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, "bindingsLayoutGroup");
		BindingsMenu.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, "canvasGroup");
		BindingsMenu.NativeFieldInfoPtr_actionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, "actionSet");
		BindingsMenu.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663320);
		BindingsMenu.NativeMethodInfoPtr_Show_Public_Void_PlayerActionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663321);
		BindingsMenu.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663322);
		BindingsMenu.NativeMethodInfoPtr_CreateBindingButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663323);
		BindingsMenu.NativeMethodInfoPtr_DeleteBindingButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663324);
		BindingsMenu.NativeMethodInfoPtr_ResetBindings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663325);
		BindingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr, 100663326);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000032A4 File Offset: 0x000014A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251051, XrefRangeEnd = 1251062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000032D8 File Offset: 0x000014D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251083, RefRangeEnd = 1251084, XrefRangeStart = 1251062, XrefRangeEnd = 1251083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show(PlayerActionSet actionSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_Show_Public_Void_PlayerActionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000331C File Offset: 0x0000151C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251084, XrefRangeEnd = 1251106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00003350 File Offset: 0x00001550
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251148, RefRangeEnd = 1251149, XrefRangeStart = 1251106, XrefRangeEnd = 1251148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateBindingButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_CreateBindingButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00003384 File Offset: 0x00001584
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251170, RefRangeEnd = 1251171, XrefRangeStart = 1251149, XrefRangeEnd = 1251170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteBindingButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_DeleteBindingButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001C RID: 28 RVA: 0x000033B8 File Offset: 0x000015B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251171, XrefRangeEnd = 1251173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBindings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr_ResetBindings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000033EC File Offset: 0x000015EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251173, XrefRangeEnd = 1251181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BindingsMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingsMenu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020D5 File Offset: 0x000002D5
	public BindingsMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00003428 File Offset: 0x00001628
	// (set) Token: 0x06000020 RID: 32 RVA: 0x000020DE File Offset: 0x000002DE
	public unsafe GameObject BindingButtonPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_BindingButtonPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_BindingButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00003458 File Offset: 0x00001658
	// (set) Token: 0x06000022 RID: 34 RVA: 0x000020FD File Offset: 0x000002FD
	public unsafe List<BindingButton> bindingButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_bindingButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BindingButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_bindingButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000023 RID: 35 RVA: 0x00003488 File Offset: 0x00001688
	// (set) Token: 0x06000024 RID: 36 RVA: 0x0000211C File Offset: 0x0000031C
	public unsafe VerticalLayoutGroup bindingsLayoutGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_bindingsLayoutGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_bindingsLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000025 RID: 37 RVA: 0x000034B8 File Offset: 0x000016B8
	// (set) Token: 0x06000026 RID: 38 RVA: 0x0000213B File Offset: 0x0000033B
	public unsafe CanvasGroup canvasGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_canvasGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000027 RID: 39 RVA: 0x000034E8 File Offset: 0x000016E8
	// (set) Token: 0x06000028 RID: 40 RVA: 0x0000215A File Offset: 0x0000035A
	public unsafe PlayerActionSet actionSet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_actionSet);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerActionSet>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingsMenu.NativeFieldInfoPtr_actionSet), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_BindingButtonPrefab;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeFieldInfoPtr_bindingButtons;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_bindingsLayoutGroup;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr_actionSet;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_PlayerActionSet_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_CreateBindingButtons_Private_Void_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_DeleteBindingButtons_Private_Void_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_ResetBindings_Public_Void_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
