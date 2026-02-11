using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using InControl;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000002 RID: 2
public class BindingButton : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002C94 File Offset: 0x00000E94
	// Note: this type is marked as 'beforefieldinit'.
	static BindingButton()
	{
		Il2CppClassPointerStore<BindingButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "", "BindingButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingButton>.NativeClassPtr);
		BindingButton.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "action");
		BindingButton.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "canvasGroup");
		BindingButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "button");
		BindingButton.NativeFieldInfoPtr_bindingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "bindingText");
		BindingButton.NativeMethodInfoPtr_Setup_Public_Void_PlayerAction_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663297);
		BindingButton.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663298);
		BindingButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663299);
		BindingButton.NativeMethodInfoPtr_OnBindingFound_Private_Static_Boolean_PlayerAction_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663300);
		BindingButton.NativeMethodInfoPtr_OnBindingRejected_Private_Static_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663301);
		BindingButton.NativeMethodInfoPtr_OnBindingEnded_Private_Void_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663302);
		BindingButton.NativeMethodInfoPtr_OnBindingsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663303);
		BindingButton.NativeMethodInfoPtr_GetBindingName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663304);
		BindingButton.NativeMethodInfoPtr_AnimateButtonText_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663305);
		BindingButton.NativeMethodInfoPtr_AnimateButtonColor_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663306);
		BindingButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, 100663307);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250990, RefRangeEnd = 1250991, XrefRangeStart = 1250914, XrefRangeEnd = 1250990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(PlayerAction action, CanvasGroup canvasGroup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_Setup_Public_Void_PlayerAction_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002E44 File Offset: 0x00001044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250991, XrefRangeEnd = 1251006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002E78 File Offset: 0x00001078
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251006, XrefRangeEnd = 1251012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002EAC File Offset: 0x000010AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251012, XrefRangeEnd = 1251025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OnBindingFound(PlayerAction action, BindingSource binding)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_OnBindingFound_Private_Static_Boolean_PlayerAction_BindingSource_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002F00 File Offset: 0x00001100
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251025, XrefRangeEnd = 1251027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnBindingRejected(PlayerAction action, BindingSource binding, BindingSourceRejectionType rejectionType)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rejectionType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_OnBindingRejected_Private_Static_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002F58 File Offset: 0x00001158
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251027, XrefRangeEnd = 1251030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBindingEnded(PlayerAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_OnBindingEnded_Private_Void_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002F9C File Offset: 0x0000119C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251030, XrefRangeEnd = 1251032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBindingsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_OnBindingsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002FD0 File Offset: 0x000011D0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1251038, RefRangeEnd = 1251041, XrefRangeStart = 1251032, XrefRangeEnd = 1251038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetBindingName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_GetBindingName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003008 File Offset: 0x00001208
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251041, XrefRangeEnd = 1251046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator AnimateButtonText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_AnimateButtonText_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003048 File Offset: 0x00001248
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251046, XrefRangeEnd = 1251051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator AnimateButtonColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr_AnimateButtonColor_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003088 File Offset: 0x00001288
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BindingButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	public BindingButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000030C4 File Offset: 0x000012C4
	// (set) Token: 0x0600000F RID: 15 RVA: 0x00002059 File Offset: 0x00000259
	public unsafe PlayerAction action
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_action);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000030F4 File Offset: 0x000012F4
	// (set) Token: 0x06000011 RID: 17 RVA: 0x00002078 File Offset: 0x00000278
	public unsafe CanvasGroup canvasGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_canvasGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00003124 File Offset: 0x00001324
	// (set) Token: 0x06000013 RID: 19 RVA: 0x00002097 File Offset: 0x00000297
	public unsafe Button button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00003154 File Offset: 0x00001354
	// (set) Token: 0x06000015 RID: 21 RVA: 0x000020B6 File Offset: 0x000002B6
	public unsafe Text bindingText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_bindingText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton.NativeFieldInfoPtr_bindingText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeFieldInfoPtr_action;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeFieldInfoPtr_button;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeFieldInfoPtr_bindingText;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_PlayerAction_CanvasGroup_0;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_OnBindingFound_Private_Static_Boolean_PlayerAction_BindingSource_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_OnBindingRejected_Private_Static_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_OnBindingEnded_Private_Void_PlayerAction_0;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr_OnBindingsChanged_Private_Void_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_GetBindingName_Private_String_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_AnimateButtonText_Public_IEnumerator_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_AnimateButtonColor_Public_IEnumerator_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000017 RID: 23
	[ObfuscatedName("BindingButton+<>O")]
	public static class __O : global::Il2CppSystem.Object
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0000689C File Offset: 0x00004A9C
		// Note: this type is marked as 'beforefieldinit'.
		static __O()
		{
			Il2CppClassPointerStore<BindingButton.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "<>O");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingButton.__O>.NativeClassPtr);
			BindingButton.__O.NativeFieldInfoPtr__0___OnBindingFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton.__O>.NativeClassPtr, "<0>__OnBindingFound");
			BindingButton.__O.NativeFieldInfoPtr__1___OnBindingRejected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton.__O>.NativeClassPtr, "<1>__OnBindingRejected");
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002A3B File Offset: 0x00000C3B
		public __O(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000068F0 File Offset: 0x00004AF0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002A44 File Offset: 0x00000C44
		public unsafe static Func<PlayerAction, BindingSource, bool> _0___OnBindingFound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BindingButton.__O.NativeFieldInfoPtr__0___OnBindingFound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerAction, BindingSource, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BindingButton.__O.NativeFieldInfoPtr__0___OnBindingFound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00006918 File Offset: 0x00004B18
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002A56 File Offset: 0x00000C56
		public unsafe static Action<PlayerAction, BindingSource, BindingSourceRejectionType> _1___OnBindingRejected
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BindingButton.__O.NativeFieldInfoPtr__1___OnBindingRejected, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction, BindingSource, BindingSourceRejectionType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BindingButton.__O.NativeFieldInfoPtr__1___OnBindingRejected, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr__0___OnBindingFound;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr__1___OnBindingRejected;
	}

	// Token: 0x02000018 RID: 24
	[ObfuscatedName("BindingButton+<AnimateButtonColor>d__13")]
	public sealed class _AnimateButtonColor_d__13 : global::Il2CppSystem.Object
	{
		// Token: 0x06000144 RID: 324 RVA: 0x00006940 File Offset: 0x00004B40
		// Note: this type is marked as 'beforefieldinit'.
		static _AnimateButtonColor_d__13()
		{
			Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "<AnimateButtonColor>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr);
			BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, "<>1__state");
			BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, "<>2__current");
			BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, "<>4__this");
			BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr__savedColors_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, "<savedColors>5__2");
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663308);
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663309);
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663310);
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663311);
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663312);
			BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006A34 File Offset: 0x00004C34
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _AnimateButtonColor_d__13(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingButton._AnimateButtonColor_d__13>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006A7C File Offset: 0x00004C7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250876, XrefRangeEnd = 1250891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00006AEC File Offset: 0x00004CEC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006B2C File Offset: 0x00004D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250891, XrefRangeEnd = 1250896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00006B60 File Offset: 0x00004D60
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonColor_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002A68 File Offset: 0x00000C68
		public _AnimateButtonColor_d__13(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00006BA0 File Offset: 0x00004DA0
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002A71 File Offset: 0x00000C71
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00006BC8 File Offset: 0x00004DC8
		// (set) Token: 0x0600014F RID: 335 RVA: 0x00002A8C File Offset: 0x00000C8C
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00006BF8 File Offset: 0x00004DF8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002AAB File Offset: 0x00000CAB
		public unsafe BindingButton __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00006C28 File Offset: 0x00004E28
		// (set) Token: 0x06000153 RID: 339 RVA: 0x00002ACA File Offset: 0x00000CCA
		public unsafe ColorBlock _savedColors_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr__savedColors_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonColor_d__13.NativeFieldInfoPtr__savedColors_5__2)) = value;
			}
		}

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr__savedColors_5__2;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000019 RID: 25
	[ObfuscatedName("BindingButton+<AnimateButtonText>d__12")]
	public sealed class _AnimateButtonText_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00006C50 File Offset: 0x00004E50
		// Note: this type is marked as 'beforefieldinit'.
		static _AnimateButtonText_d__12()
		{
			Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BindingButton>.NativeClassPtr, "<AnimateButtonText>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr);
			BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, "<>1__state");
			BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, "<>2__current");
			BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, "<>4__this");
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663314);
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663315);
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663316);
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663317);
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663318);
			BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr, 100663319);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006D30 File Offset: 0x00004F30
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _AnimateButtonText_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindingButton._AnimateButtonText_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006D78 File Offset: 0x00004F78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006DAC File Offset: 0x00004FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250896, XrefRangeEnd = 1250909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00006DE8 File Offset: 0x00004FE8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006E28 File Offset: 0x00005028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250909, XrefRangeEnd = 1250914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00006E5C File Offset: 0x0000505C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindingButton._AnimateButtonText_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002AE5 File Offset: 0x00000CE5
		public _AnimateButtonText_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00002AEE File Offset: 0x00000CEE
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00006EC4 File Offset: 0x000050C4
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002B09 File Offset: 0x00000D09
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00006EF4 File Offset: 0x000050F4
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002B28 File Offset: 0x00000D28
		public unsafe BindingButton __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BindingButton._AnimateButtonText_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
