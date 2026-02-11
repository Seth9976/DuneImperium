using System;
using dwd.core.data.composition;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.canis.data.enums;
using worm.menus.dataRenderers;

// Token: 0x0200001F RID: 31
public class WormConfigureGameColorsPromptBehaviour : MonoBehaviour
{
	// Token: 0x0600012A RID: 298 RVA: 0x0001C504 File Offset: 0x0001A704
	// Note: this type is marked as 'beforefieldinit'.
	static WormConfigureGameColorsPromptBehaviour()
	{
		Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormConfigureGameColorsPromptBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr);
		WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "slots");
		WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slotColorSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "slotColorSubscribers");
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663473);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663474);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_LoadPlayerColorFromPref_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663475);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_LoadPlayerColorFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663476);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_SavePlayerColorPref_Private_Static_Void_SubscriptionProvider_IWritableSettingDefinition_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663477);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_OpenColorPicker_Public_Void_WormPlayerEntryColorSubscriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663478);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_ClearColor_Public_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663479);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_SetColor_Private_Void_WormPlayerEntryColorSubscriber_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663480);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_GetColorPrefs_Private_Static_IReadOnlyList_1_IWritableSettingDefinition_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663481);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663482);
		WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr__SetColor_b__9_0_Private_Boolean_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, 100663483);
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0001C638 File Offset: 0x0001A838
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 688026, RefRangeEnd = 688027, XrefRangeStart = 687970, XrefRangeEnd = 688026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(IReadOnlyList<SubscriptionProvider> playerSlots)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0001C67C File Offset: 0x0001A87C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688027, XrefRangeEnd = 688051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688051, XrefRangeEnd = 688083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_LoadPlayerColorFromPref(DataComposition data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_LoadPlayerColorFromPref_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0001C6F4 File Offset: 0x0001A8F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 688147, RefRangeEnd = 688148, XrefRangeStart = 688083, XrefRangeEnd = 688147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerColorFromPref(SubscriptionProvider playerSlot, ISettingDefinition<int> playerColorPref, PieceColor defaultColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerColorPref);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultColor;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_LoadPlayerColorFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0001C758 File Offset: 0x0001A958
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688148, XrefRangeEnd = 688159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SavePlayerColorPref(SubscriptionProvider playerSlot, IWritableSettingDefinition<int> playerColorPref)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSlot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerColorPref);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_SavePlayerColorPref_Private_Static_Void_SubscriptionProvider_IWritableSettingDefinition_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688159, XrefRangeEnd = 688181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_OpenColorPicker(WormPlayerEntryColorSubscriber colorSubscriber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorSubscriber);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_OpenColorPicker_Public_Void_WormPlayerEntryColorSubscriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688181, XrefRangeEnd = 688186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ClearColor(DataComposition data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_Event_ClearColor_Public_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0001C828 File Offset: 0x0001AA28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 688225, RefRangeEnd = 688226, XrefRangeStart = 688186, XrefRangeEnd = 688225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(WormPlayerEntryColorSubscriber colorSubscriber, PieceColor color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorSubscriber);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_SetColor_Private_Void_WormPlayerEntryColorSubscriber_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0001C878 File Offset: 0x0001AA78
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 688244, RefRangeEnd = 688246, XrefRangeStart = 688226, XrefRangeEnd = 688244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IReadOnlyList<IWritableSettingDefinition<int>> GetColorPrefs()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr_GetColorPrefs_Private_Static_IReadOnlyList_1_IWritableSettingDefinition_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IWritableSettingDefinition<int>>>(intPtr3) : null;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0001C8AC File Offset: 0x0001AAAC
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormConfigureGameColorsPromptBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688246, XrefRangeEnd = 688260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _SetColor_b__9_0(PieceColor c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.NativeMethodInfoPtr__SetColor_b__9_0_Private_Boolean_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002912 File Offset: 0x00000B12
	public WormConfigureGameColorsPromptBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000137 RID: 311 RVA: 0x0001C934 File Offset: 0x0001AB34
	// (set) Token: 0x06000138 RID: 312 RVA: 0x0000291B File Offset: 0x00000B1B
	public unsafe IReadOnlyList<SubscriptionProvider> slots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<SubscriptionProvider>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000139 RID: 313 RVA: 0x0001C964 File Offset: 0x0001AB64
	// (set) Token: 0x0600013A RID: 314 RVA: 0x0000293A File Offset: 0x00000B3A
	public unsafe IReadOnlyList<WormPlayerEntryColorSubscriber> slotColorSubscribers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slotColorSubscribers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<WormPlayerEntryColorSubscriber>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.NativeFieldInfoPtr_slotColorSubscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeFieldInfoPtr_slots;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeFieldInfoPtr_slotColorSubscribers;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_SubscriptionProvider_0;

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeMethodInfoPtr_Event_LoadPlayerColorFromPref_Public_Void_DataComposition_0;

	// Token: 0x040000B5 RID: 181
	private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerColorFromPref_Private_Void_SubscriptionProvider_ISettingDefinition_1_Int32_PieceColor_0;

	// Token: 0x040000B6 RID: 182
	private static readonly IntPtr NativeMethodInfoPtr_SavePlayerColorPref_Private_Static_Void_SubscriptionProvider_IWritableSettingDefinition_1_Int32_0;

	// Token: 0x040000B7 RID: 183
	private static readonly IntPtr NativeMethodInfoPtr_Event_OpenColorPicker_Public_Void_WormPlayerEntryColorSubscriber_0;

	// Token: 0x040000B8 RID: 184
	private static readonly IntPtr NativeMethodInfoPtr_Event_ClearColor_Public_Void_DataComposition_0;

	// Token: 0x040000B9 RID: 185
	private static readonly IntPtr NativeMethodInfoPtr_SetColor_Private_Void_WormPlayerEntryColorSubscriber_PieceColor_0;

	// Token: 0x040000BA RID: 186
	private static readonly IntPtr NativeMethodInfoPtr_GetColorPrefs_Private_Static_IReadOnlyList_1_IWritableSettingDefinition_1_Int32_0;

	// Token: 0x040000BB RID: 187
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000BC RID: 188
	private static readonly IntPtr NativeMethodInfoPtr__SetColor_b__9_0_Private_Boolean_PieceColor_0;

	// Token: 0x020002B9 RID: 697
	[ObfuscatedName("WormConfigureGameColorsPromptBehaviour+<>c__DisplayClass2_0")]
	public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C79 RID: 7289 RVA: 0x0006F984 File Offset: 0x0006DB84
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass2_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_sub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, "sub");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, 100663484);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr, 100663485);
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0006FA00 File Offset: 0x0006DC00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0006FA3C File Offset: 0x0006DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687963, XrefRangeEnd = 687965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__0(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00010585 File Offset: 0x0000E785
		public __c__DisplayClass2_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x0006FA7C File Offset: 0x0006DC7C
		// (set) Token: 0x06001C7E RID: 7294 RVA: 0x0001058E File Offset: 0x0000E78E
		public unsafe WormPlayerEntryColorSubscriber sub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_sub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerEntryColorSubscriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr_sub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0006FAAC File Offset: 0x0006DCAC
		// (set) Token: 0x06001C80 RID: 7296 RVA: 0x000105AD File Offset: 0x0000E7AD
		public unsafe WormConfigureGameColorsPromptBehaviour __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConfigureGameColorsPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr_sub;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_PieceColor_0;
	}

	// Token: 0x020002BA RID: 698
	[ObfuscatedName("WormConfigureGameColorsPromptBehaviour+<>c__DisplayClass4_0")]
	public sealed class __c__DisplayClass4_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x0006FADC File Offset: 0x0006DCDC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass4_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr, "data");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr, 100663486);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeMethodInfoPtr__Event_LoadPlayerColorFromPref_b__0_Internal_Boolean_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr, 100663487);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0006FB44 File Offset: 0x0006DD44
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass4_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0006FB80 File Offset: 0x0006DD80
		[CallerCount(0)]
		public unsafe bool _Event_LoadPlayerColorFromPref_b__0(SubscriptionProvider s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeMethodInfoPtr__Event_LoadPlayerColorFromPref_b__0_Internal_Boolean_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000105CC File Offset: 0x0000E7CC
		public __c__DisplayClass4_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0006FBD0 File Offset: 0x0006DDD0
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x000105D5 File Offset: 0x0000E7D5
		public unsafe DataComposition data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass4_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr__Event_LoadPlayerColorFromPref_b__0_Internal_Boolean_SubscriptionProvider_0;
	}

	// Token: 0x020002BB RID: 699
	[ObfuscatedName("WormConfigureGameColorsPromptBehaviour+<>c__DisplayClass5_0")]
	public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C87 RID: 7303 RVA: 0x0006FC00 File Offset: 0x0006DE00
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass5_0()
		{
			Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass5_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_usedColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, "usedColors");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, "<>9__0");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100663488);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__LoadPlayerColorFromPref_b__0_Internal_Boolean_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr, 100663489);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0006FC7C File Offset: 0x0006DE7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass5_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687965, XrefRangeEnd = 687968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _LoadPlayerColorFromPref_b__0(PieceColor c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeMethodInfoPtr__LoadPlayerColorFromPref_b__0_Internal_Boolean_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x000105F4 File Offset: 0x0000E7F4
		public __c__DisplayClass5_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x0006FD04 File Offset: 0x0006DF04
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x000105FD File Offset: 0x0000E7FD
		public unsafe List<PieceColor> usedColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_usedColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PieceColor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr_usedColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x0006FD34 File Offset: 0x0006DF34
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0001061C File Offset: 0x0000E81C
		public unsafe Func<PieceColor, bool> __9__0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PieceColor, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass5_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_usedColors;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr___9__0;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeMethodInfoPtr__LoadPlayerColorFromPref_b__0_Internal_Boolean_PieceColor_0;
	}

	// Token: 0x020002BC RID: 700
	[ObfuscatedName("WormConfigureGameColorsPromptBehaviour+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C8F RID: 7311 RVA: 0x0006FD64 File Offset: 0x0006DF64
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "c");
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100663490);
			WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__SetColor_b__1_Internal_Boolean_WormPlayerEntryColorSubscriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100663491);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0006FDCC File Offset: 0x0006DFCC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0006FE08 File Offset: 0x0006E008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687968, XrefRangeEnd = 687970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetColor_b__1(WormPlayerEntryColorSubscriber s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__SetColor_b__1_Internal_Boolean_WormPlayerEntryColorSubscriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0001063B File Offset: 0x0000E83B
		public __c__DisplayClass9_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0006FE58 File Offset: 0x0006E058
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x00010644 File Offset: 0x0000E844
		public unsafe PieceColor c
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_c);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConfigureGameColorsPromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_c)) = value;
			}
		}

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_c;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeMethodInfoPtr__SetColor_b__1_Internal_Boolean_WormPlayerEntryColorSubscriber_0;
	}
}
