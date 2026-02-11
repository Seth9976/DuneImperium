using System;
using dbgclient.voodoo.layout;
using dwd.core.match;
using dwd.core.match.data;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using worm;

// Token: 0x0200000F RID: 15
public class WormDiscardPilesButtonManager : MonoBehaviour
{
	// Token: 0x0600005D RID: 93 RVA: 0x00019CE4 File Offset: 0x00017EE4
	// Note: this type is marked as 'beforefieldinit'.
	static WormDiscardPilesButtonManager()
	{
		Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormDiscardPilesButtonManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr);
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_globalTrashContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "globalTrashContainer");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_Intrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "Intrigue");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_Imperium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "Imperium");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_Conflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "Conflict");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_IntrigueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "IntrigueCount");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_ImperiumCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "ImperiumCount");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_ConflictCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "ConflictCount");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "layouts");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_wormEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "wormEntities");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempConflictPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "tempConflictPile");
		WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempTrashPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "tempTrashPile");
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663354);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleTrash_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663355);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleIntrigue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663356);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleImperium_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663357);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleConflict_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663358);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_Close_Private_IEnumerator_PromptAnims_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663359);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663360);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663361);
		WormDiscardPilesButtonManager.NativeMethodInfoPtr__Event_ToggleImperium_b__14_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, 100663362);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00019EA4 File Offset: 0x000180A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687197, XrefRangeEnd = 687202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00019EE4 File Offset: 0x000180E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687202, XrefRangeEnd = 687206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ToggleTrash(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleTrash_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00019F24 File Offset: 0x00018124
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687206, XrefRangeEnd = 687220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ToggleIntrigue(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleIntrigue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00019F64 File Offset: 0x00018164
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687220, XrefRangeEnd = 687270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ToggleImperium(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleImperium_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00019FA4 File Offset: 0x000181A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687270, XrefRangeEnd = 687288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_ToggleConflict(bool isOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Event_ToggleConflict_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00019FE4 File Offset: 0x000181E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 687294, RefRangeEnd = 687296, XrefRangeStart = 687288, XrefRangeEnd = 687294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Close(PromptAnims prompt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_Close_Private_IEnumerator_PromptAnims_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0001A034 File Offset: 0x00018234
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687296, XrefRangeEnd = 687300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x0001A068 File Offset: 0x00018268
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687300, XrefRangeEnd = 687305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormDiscardPilesButtonManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x0001A0A4 File Offset: 0x000182A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687305, XrefRangeEnd = 687308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _Event_ToggleImperium_b__14_0(EntityComponent c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager.NativeMethodInfoPtr__Event_ToggleImperium_b__14_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000022DE File Offset: 0x000004DE
	public WormDiscardPilesButtonManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000068 RID: 104 RVA: 0x0001A0F4 File Offset: 0x000182F4
	// (set) Token: 0x06000069 RID: 105 RVA: 0x000022E7 File Offset: 0x000004E7
	public unsafe PromptAnims globalTrashContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_globalTrashContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_globalTrashContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600006A RID: 106 RVA: 0x0001A124 File Offset: 0x00018324
	// (set) Token: 0x0600006B RID: 107 RVA: 0x00002306 File Offset: 0x00000506
	public unsafe GameObject Intrigue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Intrigue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Intrigue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600006C RID: 108 RVA: 0x0001A154 File Offset: 0x00018354
	// (set) Token: 0x0600006D RID: 109 RVA: 0x00002325 File Offset: 0x00000525
	public unsafe GameObject Imperium
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Imperium);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Imperium), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600006E RID: 110 RVA: 0x0001A184 File Offset: 0x00018384
	// (set) Token: 0x0600006F RID: 111 RVA: 0x00002344 File Offset: 0x00000544
	public unsafe PromptAnims Conflict
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Conflict);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_Conflict), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000070 RID: 112 RVA: 0x0001A1B4 File Offset: 0x000183B4
	// (set) Token: 0x06000071 RID: 113 RVA: 0x00002363 File Offset: 0x00000563
	public unsafe TMP_Text IntrigueCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_IntrigueCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_IntrigueCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000072 RID: 114 RVA: 0x0001A1E4 File Offset: 0x000183E4
	// (set) Token: 0x06000073 RID: 115 RVA: 0x00002382 File Offset: 0x00000582
	public unsafe TMP_Text ImperiumCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_ImperiumCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_ImperiumCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000074 RID: 116 RVA: 0x0001A214 File Offset: 0x00018414
	// (set) Token: 0x06000075 RID: 117 RVA: 0x000023A1 File Offset: 0x000005A1
	public unsafe TMP_Text ConflictCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_ConflictCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_ConflictCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000076 RID: 118 RVA: 0x0001A244 File Offset: 0x00018444
	// (set) Token: 0x06000077 RID: 119 RVA: 0x000023C0 File Offset: 0x000005C0
	public unsafe Il2CppReferenceArray<PaginatedLayout> layouts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_layouts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PaginatedLayout>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_layouts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000078 RID: 120 RVA: 0x0001A274 File Offset: 0x00018474
	// (set) Token: 0x06000079 RID: 121 RVA: 0x000023DF File Offset: 0x000005DF
	public unsafe WormEntities wormEntities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_wormEntities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_wormEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600007A RID: 122 RVA: 0x0001A2A4 File Offset: 0x000184A4
	// (set) Token: 0x0600007B RID: 123 RVA: 0x000023FE File Offset: 0x000005FE
	public unsafe EntityComponent tempConflictPile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempConflictPile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempConflictPile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600007C RID: 124 RVA: 0x0001A2D4 File Offset: 0x000184D4
	// (set) Token: 0x0600007D RID: 125 RVA: 0x0000241D File Offset: 0x0000061D
	public unsafe EntityComponent tempTrashPile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempTrashPile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager.NativeFieldInfoPtr_tempTrashPile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeFieldInfoPtr_globalTrashContainer;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeFieldInfoPtr_Intrigue;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeFieldInfoPtr_Imperium;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeFieldInfoPtr_Conflict;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeFieldInfoPtr_IntrigueCount;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeFieldInfoPtr_ImperiumCount;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeFieldInfoPtr_ConflictCount;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeFieldInfoPtr_layouts;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeFieldInfoPtr_wormEntities;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeFieldInfoPtr_tempConflictPile;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeFieldInfoPtr_tempTrashPile;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleTrash_Public_Void_Boolean_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleIntrigue_Public_Void_Boolean_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleImperium_Public_Void_Boolean_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleConflict_Public_Void_Boolean_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_Close_Private_IEnumerator_PromptAnims_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr__Event_ToggleImperium_b__14_0_Private_Boolean_EntityComponent_0;

	// Token: 0x020002AE RID: 686
	[ObfuscatedName("WormDiscardPilesButtonManager+<Close>d__16")]
	public sealed class _Close_d__16 : global::Il2CppSystem.Object
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x0006E26C File Offset: 0x0006C46C
		// Note: this type is marked as 'beforefieldinit'.
		static _Close_d__16()
		{
			Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "<Close>d__16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr);
			WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, "<>1__state");
			WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, "<>2__current");
			WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, "prompt");
			WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, "<>4__this");
			WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr__close_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, "<close>5__2");
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663363);
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663364);
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663365);
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663366);
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663367);
			WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr, 100663368);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0006E374 File Offset: 0x0006C574
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Close_d__16(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Close_d__16>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0006E3BC File Offset: 0x0006C5BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687155, XrefRangeEnd = 687180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x0006E42C File Offset: 0x0006C62C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0006E46C File Offset: 0x0006C66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687180, XrefRangeEnd = 687185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x0006E4A0 File Offset: 0x0006C6A0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Close_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00010179 File Offset: 0x0000E379
		public _Close_d__16(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x00010182 File Offset: 0x0000E382
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x0006E508 File Offset: 0x0006C708
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x0001019D File Offset: 0x0000E39D
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x0006E538 File Offset: 0x0006C738
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x000101BC File Offset: 0x0000E3BC
		public unsafe PromptAnims prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PromptAnims>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x0006E568 File Offset: 0x0006C768
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x000101DB File Offset: 0x0000E3DB
		public unsafe WormDiscardPilesButtonManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDiscardPilesButtonManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0006E598 File Offset: 0x0006C798
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x000101FA File Offset: 0x0000E3FA
		public unsafe IEnumerator _close_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr__close_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Close_d__16.NativeFieldInfoPtr__close_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr__close_5__2;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020002AF RID: 687
	[ObfuscatedName("WormDiscardPilesButtonManager+<Start>d__11")]
	public sealed class _Start_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C0B RID: 7179 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__11()
		{
			Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormDiscardPilesButtonManager>.NativeClassPtr, "<Start>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr);
			WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, "<>1__state");
			WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, "<>2__current");
			WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, "<>4__this");
			WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, "<entitiesProvider>5__2");
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663369);
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663370);
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663371);
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663372);
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663373);
			WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr, 100663374);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0006E6BC File Offset: 0x0006C8BC
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardPilesButtonManager._Start_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0006E704 File Offset: 0x0006C904
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0006E738 File Offset: 0x0006C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687185, XrefRangeEnd = 687192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x0006E774 File Offset: 0x0006C974
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687192, XrefRangeEnd = 687197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x0006E7E8 File Offset: 0x0006C9E8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardPilesButtonManager._Start_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00010219 File Offset: 0x0000E419
		public _Start_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x0006E828 File Offset: 0x0006CA28
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x00010222 File Offset: 0x0000E422
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0006E850 File Offset: 0x0006CA50
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x0001023D File Offset: 0x0000E43D
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0006E880 File Offset: 0x0006CA80
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0001025C File Offset: 0x0000E45C
		public unsafe WormDiscardPilesButtonManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDiscardPilesButtonManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0001027B File Offset: 0x0000E47B
		public unsafe EntitiesProvider _entitiesProvider_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardPilesButtonManager._Start_d__11.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
