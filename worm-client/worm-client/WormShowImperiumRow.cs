using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;
using worm.canis.data.enums;
using worm.match.commands;
using worm.match.prompts.behaviours;

// Token: 0x02000027 RID: 39
public class WormShowImperiumRow : MonoBehaviour
{
	// Token: 0x06000189 RID: 393 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
	// Note: this type is marked as 'beforefieldinit'.
	static WormShowImperiumRow()
	{
		Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormShowImperiumRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr);
		WormShowImperiumRow.NativeFieldInfoPtr_highlightAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "highlightAnimator");
		WormShowImperiumRow.NativeFieldInfoPtr_highlightParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "highlightParamName");
		WormShowImperiumRow.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "toggle");
		WormShowImperiumRow.NativeFieldInfoPtr_promptCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "promptCommand");
		WormShowImperiumRow.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "prompt");
		WormShowImperiumRow.NativeFieldInfoPtr_revealPromptRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "revealPromptRoutine");
		WormShowImperiumRow.NativeFieldInfoPtr__OverrideToggle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "<OverrideToggle>k__BackingField");
		WormShowImperiumRow.NativeMethodInfoPtr_get_Prompt_Public_get_WormImperiumRowPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663561);
		WormShowImperiumRow.NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormImperiumRowPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663562);
		WormShowImperiumRow.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663563);
		WormShowImperiumRow.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663564);
		WormShowImperiumRow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663565);
		WormShowImperiumRow.NativeMethodInfoPtr_Event_ShowRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663566);
		WormShowImperiumRow.NativeMethodInfoPtr_ShowRow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663567);
		WormShowImperiumRow.NativeMethodInfoPtr_Event_HideRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663568);
		WormShowImperiumRow.NativeMethodInfoPtr_HideRow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663569);
		WormShowImperiumRow.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663570);
		WormShowImperiumRow.NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663571);
		WormShowImperiumRow.NativeMethodInfoPtr_Show_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663572);
		WormShowImperiumRow.NativeMethodInfoPtr_Event_ForceOpenRevealPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663573);
		WormShowImperiumRow.NativeMethodInfoPtr_ForceOpenRevealPrompt_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663574);
		WormShowImperiumRow.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663575);
		WormShowImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663576);
		WormShowImperiumRow.NativeMethodInfoPtr__Event_ForceOpenRevealPrompt_b__21_0_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, 100663577);
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600018A RID: 394 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
	// (set) Token: 0x0600018B RID: 395 RVA: 0x0001DD24 File Offset: 0x0001BF24
	public unsafe WormImperiumRowPromptBehaviour Prompt
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_get_Prompt_Public_get_WormImperiumRowPromptBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumRowPromptBehaviour>(intPtr3) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 689343, RefRangeEnd = 689345, XrefRangeStart = 689335, XrefRangeEnd = 689343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormImperiumRowPromptBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600018C RID: 396 RVA: 0x0001DD68 File Offset: 0x0001BF68
	// (set) Token: 0x0600018D RID: 397 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
	public unsafe virtual Toggle OverrideToggle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0001DDEC File Offset: 0x0001BFEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689345, XrefRangeEnd = 689349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x0001DE20 File Offset: 0x0001C020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689349, XrefRangeEnd = 689350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ShowRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Event_ShowRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0001DE54 File Offset: 0x0001C054
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 689372, RefRangeEnd = 689376, XrefRangeStart = 689350, XrefRangeEnd = 689372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShowRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_ShowRow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x0001DE90 File Offset: 0x0001C090
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689376, XrefRangeEnd = 689377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_HideRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Event_HideRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000192 RID: 402 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 689379, RefRangeEnd = 689385, XrefRangeStart = 689377, XrefRangeEnd = 689379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HideRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_HideRow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000193 RID: 403 RVA: 0x0001DF00 File Offset: 0x0001C100
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689385, XrefRangeEnd = 689387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Event_ToggleRow(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0001DF40 File Offset: 0x0001C140
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ToggleRow(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000195 RID: 405 RVA: 0x0001DF8C File Offset: 0x0001C18C
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 689390, RefRangeEnd = 689400, XrefRangeStart = 689387, XrefRangeEnd = 689390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Show(bool show)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Show_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x0001DFCC File Offset: 0x0001C1CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 689416, RefRangeEnd = 689417, XrefRangeStart = 689400, XrefRangeEnd = 689416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ForceOpenRevealPrompt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Event_ForceOpenRevealPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x0001E000 File Offset: 0x0001C200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689417, XrefRangeEnd = 689422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ForceOpenRevealPrompt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_ForceOpenRevealPrompt_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000198 RID: 408 RVA: 0x0001E040 File Offset: 0x0001C240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689422, XrefRangeEnd = 689433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000199 RID: 409 RVA: 0x0001E074 File Offset: 0x0001C274
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormShowImperiumRow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0001E0B0 File Offset: 0x0001C2B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Event_ForceOpenRevealPrompt_b__21_0(IEnumerator _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.NativeMethodInfoPtr__Event_ForceOpenRevealPrompt_b__21_0_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002B31 File Offset: 0x00000D31
	public WormShowImperiumRow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600019C RID: 412 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
	// (set) Token: 0x0600019D RID: 413 RVA: 0x00002B3A File Offset: 0x00000D3A
	public unsafe Animator highlightAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_highlightAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_highlightAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600019E RID: 414 RVA: 0x0001E124 File Offset: 0x0001C324
	// (set) Token: 0x0600019F RID: 415 RVA: 0x00002B59 File Offset: 0x00000D59
	public unsafe string highlightParamName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_highlightParamName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_highlightParamName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001E14C File Offset: 0x0001C34C
	// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002B78 File Offset: 0x00000D78
	public unsafe Toggle toggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_toggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001E17C File Offset: 0x0001C37C
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002B97 File Offset: 0x00000D97
	public unsafe WormShowImperiumRowFlow promptCommand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_promptCommand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRowFlow>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_promptCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001E1AC File Offset: 0x0001C3AC
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002BB6 File Offset: 0x00000DB6
	public unsafe WormImperiumRowPromptBehaviour prompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_prompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumRowPromptBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001E1DC File Offset: 0x0001C3DC
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002BD5 File Offset: 0x00000DD5
	public unsafe Coroutine revealPromptRoutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_revealPromptRoutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr_revealPromptRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001E20C File Offset: 0x0001C40C
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002BF4 File Offset: 0x00000DF4
	public unsafe Toggle _OverrideToggle_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr__OverrideToggle_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow.NativeFieldInfoPtr__OverrideToggle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeFieldInfoPtr_highlightAnimator;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeFieldInfoPtr_highlightParamName;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeFieldInfoPtr_toggle;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeFieldInfoPtr_promptCommand;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeFieldInfoPtr_prompt;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeFieldInfoPtr_revealPromptRoutine;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeFieldInfoPtr__OverrideToggle_k__BackingField;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_WormImperiumRowPromptBehaviour_0;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormImperiumRowPromptBehaviour_0;

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeMethodInfoPtr_Event_ShowRow_Public_Void_0;

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeMethodInfoPtr_ShowRow_Public_Boolean_0;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeMethodInfoPtr_Event_HideRow_Public_Void_0;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeMethodInfoPtr_HideRow_Public_Boolean_0;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Static_Boolean_Boolean_0;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr_Event_ForceOpenRevealPrompt_Public_Void_0;

	// Token: 0x04000103 RID: 259
	private static readonly IntPtr NativeMethodInfoPtr_ForceOpenRevealPrompt_Private_IEnumerator_0;

	// Token: 0x04000104 RID: 260
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000105 RID: 261
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000106 RID: 262
	private static readonly IntPtr NativeMethodInfoPtr__Event_ForceOpenRevealPrompt_b__21_0_Private_Void_IEnumerator_0;

	// Token: 0x020002C6 RID: 710
	[ObfuscatedName("WormShowImperiumRow+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06001CF4 RID: 7412 RVA: 0x00071000 File Offset: 0x0006F200
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr);
			WormShowImperiumRow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr, "<>9");
			WormShowImperiumRow.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr, "<>9__22_0");
			WormShowImperiumRow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr, 100663579);
			WormShowImperiumRow.__c.NativeMethodInfoPtr__ForceOpenRevealPrompt_b__22_0_Internal_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr, 100663580);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x0007107C File Offset: 0x0006F27C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRow.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000710B8 File Offset: 0x0006F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689306, XrefRangeEnd = 689309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ForceOpenRevealPrompt_b__22_0(Set s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow.__c.NativeMethodInfoPtr__ForceOpenRevealPrompt_b__22_0_Internal_String_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00010958 File Offset: 0x0000EB58
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000710FC File Offset: 0x0006F2FC
		// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x00010961 File Offset: 0x0000EB61
		public unsafe static WormShowImperiumRow.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormShowImperiumRow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRow.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormShowImperiumRow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00071124 File Offset: 0x0006F324
		// (set) Token: 0x06001CFB RID: 7419 RVA: 0x00010973 File Offset: 0x0000EB73
		public unsafe static Func<Set, string> __9__22_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormShowImperiumRow.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Set, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormShowImperiumRow.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr__ForceOpenRevealPrompt_b__22_0_Internal_String_Set_0;
	}

	// Token: 0x020002C7 RID: 711
	[ObfuscatedName("WormShowImperiumRow+<ForceOpenRevealPrompt>d__22")]
	public sealed class _ForceOpenRevealPrompt_d__22 : global::Il2CppSystem.Object
	{
		// Token: 0x06001CFC RID: 7420 RVA: 0x0007114C File Offset: 0x0006F34C
		// Note: this type is marked as 'beforefieldinit'.
		static _ForceOpenRevealPrompt_d__22()
		{
			Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormShowImperiumRow>.NativeClassPtr, "<ForceOpenRevealPrompt>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, "<>1__state");
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, "<>2__current");
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, "<>4__this");
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663581);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663582);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663583);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663584);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663585);
			WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr, 100663586);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x0007122C File Offset: 0x0006F42C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ForceOpenRevealPrompt_d__22(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormShowImperiumRow._ForceOpenRevealPrompt_d__22>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00071274 File Offset: 0x0006F474
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000712A8 File Offset: 0x0006F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689309, XrefRangeEnd = 689330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x000712E4 File Offset: 0x0006F4E4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00071324 File Offset: 0x0006F524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689330, XrefRangeEnd = 689335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00071358 File Offset: 0x0006F558
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00010985 File Offset: 0x0000EB85
		public _ForceOpenRevealPrompt_d__22(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00071398 File Offset: 0x0006F598
		// (set) Token: 0x06001D05 RID: 7429 RVA: 0x0001098E File Offset: 0x0000EB8E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000713C0 File Offset: 0x0006F5C0
		// (set) Token: 0x06001D07 RID: 7431 RVA: 0x000109A9 File Offset: 0x0000EBA9
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x000713F0 File Offset: 0x0006F5F0
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x000109C8 File Offset: 0x0000EBC8
		public unsafe WormShowImperiumRow __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowImperiumRow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormShowImperiumRow._ForceOpenRevealPrompt_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
