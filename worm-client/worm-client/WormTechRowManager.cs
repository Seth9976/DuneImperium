using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;
using worm.match.commands;
using worm.match.prompts.behaviours;

// Token: 0x02000016 RID: 22
public class WormTechRowManager : MonoBehaviour
{
	// Token: 0x060000C3 RID: 195 RVA: 0x0001B118 File Offset: 0x00019318
	// Note: this type is marked as 'beforefieldinit'.
	static WormTechRowManager()
	{
		Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTechRowManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr);
		WormTechRowManager.NativeFieldInfoPtr_highlightAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "highlightAnimator");
		WormTechRowManager.NativeFieldInfoPtr_highlightParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "highlightParamName");
		WormTechRowManager.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "toggle");
		WormTechRowManager.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "prompt");
		WormTechRowManager.NativeFieldInfoPtr_promptCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "promptCommand");
		WormTechRowManager.NativeFieldInfoPtr__OverrideToggle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, "<OverrideToggle>k__BackingField");
		WormTechRowManager.NativeMethodInfoPtr_get_Prompt_Public_get_WormAcquireTechPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663419);
		WormTechRowManager.NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormAcquireTechPromptBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663420);
		WormTechRowManager.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663421);
		WormTechRowManager.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663422);
		WormTechRowManager.NativeMethodInfoPtr_Event_ShowRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663423);
		WormTechRowManager.NativeMethodInfoPtr_ShowRow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663424);
		WormTechRowManager.NativeMethodInfoPtr_Event_HideRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663425);
		WormTechRowManager.NativeMethodInfoPtr_HideRow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663426);
		WormTechRowManager.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663427);
		WormTechRowManager.NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663428);
		WormTechRowManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663429);
		WormTechRowManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr, 100663430);
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001B2B0 File Offset: 0x000194B0
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x0001B2F0 File Offset: 0x000194F0
	public unsafe WormAcquireTechPromptBehaviour Prompt
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_get_Prompt_Public_get_WormAcquireTechPromptBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour>(intPtr3) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 687588, RefRangeEnd = 687590, XrefRangeStart = 687580, XrefRangeEnd = 687588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormAcquireTechPromptBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001B334 File Offset: 0x00019534
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x0001B374 File Offset: 0x00019574
	public unsafe virtual Toggle OverrideToggle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0001B3B8 File Offset: 0x000195B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687590, XrefRangeEnd = 687591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ShowRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_Event_ShowRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0001B3EC File Offset: 0x000195EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 687610, RefRangeEnd = 687613, XrefRangeStart = 687591, XrefRangeEnd = 687610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShowRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_ShowRow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0001B428 File Offset: 0x00019628
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 687614, RefRangeEnd = 687615, XrefRangeStart = 687613, XrefRangeEnd = 687614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_HideRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_Event_HideRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0001B45C File Offset: 0x0001965C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 687617, RefRangeEnd = 687621, XrefRangeStart = 687615, XrefRangeEnd = 687617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HideRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_HideRow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0001B498 File Offset: 0x00019698
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687621, XrefRangeEnd = 687623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Event_ToggleRow(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x0001B4D8 File Offset: 0x000196D8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060000CE RID: 206 RVA: 0x0001B524 File Offset: 0x00019724
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687623, XrefRangeEnd = 687635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0001B558 File Offset: 0x00019758
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTechRowManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechRowManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechRowManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002602 File Offset: 0x00000802
	public WormTechRowManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x0001B594 File Offset: 0x00019794
	// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000260B File Offset: 0x0000080B
	public unsafe Animator highlightAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_highlightAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_highlightAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x0001B5C4 File Offset: 0x000197C4
	// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000262A File Offset: 0x0000082A
	public unsafe string highlightParamName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_highlightParamName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_highlightParamName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x0001B5EC File Offset: 0x000197EC
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002649 File Offset: 0x00000849
	public unsafe Toggle toggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_toggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x0001B61C File Offset: 0x0001981C
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002668 File Offset: 0x00000868
	public unsafe WormAcquireTechPromptBehaviour prompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_prompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAcquireTechPromptBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x0001B64C File Offset: 0x0001984C
	// (set) Token: 0x060000DA RID: 218 RVA: 0x00002687 File Offset: 0x00000887
	public unsafe WormShowTechRowFlow promptCommand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_promptCommand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormShowTechRowFlow>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr_promptCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000DB RID: 219 RVA: 0x0001B67C File Offset: 0x0001987C
	// (set) Token: 0x060000DC RID: 220 RVA: 0x000026A6 File Offset: 0x000008A6
	public unsafe Toggle _OverrideToggle_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr__OverrideToggle_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTechRowManager.NativeFieldInfoPtr__OverrideToggle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeFieldInfoPtr_highlightAnimator;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeFieldInfoPtr_highlightParamName;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeFieldInfoPtr_toggle;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeFieldInfoPtr_prompt;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeFieldInfoPtr_promptCommand;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeFieldInfoPtr__OverrideToggle_k__BackingField;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_WormAcquireTechPromptBehaviour_0;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Public_set_Void_WormAcquireTechPromptBehaviour_0;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeMethodInfoPtr_get_OverrideToggle_Public_Virtual_Final_New_get_Toggle_0;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeMethodInfoPtr_set_OverrideToggle_Public_Virtual_Final_New_set_Void_Toggle_0;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr_Event_ShowRow_Public_Void_0;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr_ShowRow_Public_Boolean_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr_Event_HideRow_Public_Void_0;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeMethodInfoPtr_HideRow_Public_Boolean_0;

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleRow_Public_Virtual_Final_New_Void_Boolean_0;

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeMethodInfoPtr_ToggleRow_Public_Boolean_Boolean_0;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
