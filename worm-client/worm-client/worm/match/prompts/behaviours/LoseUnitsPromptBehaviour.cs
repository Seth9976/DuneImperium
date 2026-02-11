using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.data;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C1 RID: 193
	public class LoseUnitsPromptBehaviour : PromptBehaviour<DBGSelectEntityPrompt>
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		// Note: this type is marked as 'beforefieldinit'.
		static LoseUnitsPromptBehaviour()
		{
			Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "LoseUnitsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr);
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_parentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "parentName");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_otherPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "otherPile");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "count");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_isDefaultPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "isDefaultPile");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "selectionResponder");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "choices");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "selectedEntities");
			LoseUnitsPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "<Version>k__BackingField");
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664315);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664316);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664317);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664318);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664319);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664320);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_DecrementDisplay_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664321);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664322);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_IncrementDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664323);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr_OnChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664324);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664325);
			LoseUnitsPromptBehaviour.NativeMethodInfoPtr__IncrementDisplay_b__19_0_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, 100664326);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0002FFA4 File Offset: 0x0002E1A4
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0002FFE0 File Offset: 0x0002E1E0
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00030020 File Offset: 0x0002E220
		public unsafe virtual bool CanDecrementDisplay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697008, XrefRangeEnd = 697009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0003005C File Offset: 0x0002E25C
		public unsafe virtual bool CanIncrementDisplay
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 697014, RefRangeEnd = 697018, XrefRangeStart = 697009, XrefRangeEnd = 697014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00030098 File Offset: 0x0002E298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697018, XrefRangeEnd = 697064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoseUnitsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000300D4 File Offset: 0x0002E2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697064, XrefRangeEnd = 697066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00030108 File Offset: 0x0002E308
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 697075, RefRangeEnd = 697078, XrefRangeStart = 697066, XrefRangeEnd = 697075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DecrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_DecrementDisplay_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00030144 File Offset: 0x0002E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697078, XrefRangeEnd = 697082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00030178 File Offset: 0x0002E378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 697096, RefRangeEnd = 697099, XrefRangeStart = 697082, XrefRangeEnd = 697096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_IncrementDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000301AC File Offset: 0x0002E3AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 697101, RefRangeEnd = 697103, XrefRangeStart = 697099, XrefRangeEnd = 697101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr_OnChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000301E0 File Offset: 0x0002E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697103, XrefRangeEnd = 697123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoseUnitsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003021C File Offset: 0x0002E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697123, XrefRangeEnd = 697126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _IncrementDisplay_b__19_0(EntityID c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.NativeMethodInfoPtr__IncrementDisplay_b__19_0_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00005E38 File Offset: 0x00004038
		public LoseUnitsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0003026C File Offset: 0x0002E46C
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00005E41 File Offset: 0x00004041
		public unsafe string parentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_parentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_parentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00030294 File Offset: 0x0002E494
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00005E60 File Offset: 0x00004060
		public unsafe LoseUnitsPromptBehaviour otherPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_otherPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseUnitsPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_otherPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000302C4 File Offset: 0x0002E4C4
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00005E7F File Offset: 0x0000407F
		public unsafe TMP_Text count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x000302F4 File Offset: 0x0002E4F4
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00005E9E File Offset: 0x0000409E
		public unsafe bool isDefaultPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_isDefaultPile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_isDefaultPile)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0003031C File Offset: 0x0002E51C
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00005EB9 File Offset: 0x000040B9
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0003034C File Offset: 0x0002E54C
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00005ED8 File Offset: 0x000040D8
		public unsafe List<EntityID> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0003037C File Offset: 0x0002E57C
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00005EF7 File Offset: 0x000040F7
		public unsafe HashSet<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000303AC File Offset: 0x0002E5AC
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00005F16 File Offset: 0x00004116
		public unsafe ulong _Version_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.NativeFieldInfoPtr__Version_k__BackingField)) = value;
			}
		}

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_parentName;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_otherPile;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultPile;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr__Version_k__BackingField;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Private_set_Void_UInt64_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDecrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_get_CanIncrementDisplay_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_Event_DecrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_DecrementDisplay_Private_Boolean_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_Event_IncrementDisplay_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_IncrementDisplay_Private_Void_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_OnChanged_Private_Void_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__IncrementDisplay_b__19_0_Private_Boolean_EntityID_0;

		// Token: 0x02000316 RID: 790
		[ObfuscatedName("worm.match.prompts.behaviours.LoseUnitsPromptBehaviour+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06001FCE RID: 8142 RVA: 0x00079410 File Offset: 0x00077610
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoseUnitsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr);
				LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "entitiesProvider");
				LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664327);
				LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__initialize_b__0_Internal_ValueTuple_2_Boolean_EntityID_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr, 100664328);
			}

			// Token: 0x06001FCF RID: 8143 RVA: 0x0007948C File Offset: 0x0007768C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoseUnitsPromptBehaviour.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD0 RID: 8144 RVA: 0x000794C8 File Offset: 0x000776C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696998, XrefRangeEnd = 697008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<bool, EntityID> _initialize_b__0(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeMethodInfoPtr__initialize_b__0_Internal_ValueTuple_2_Boolean_EntityID_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<bool, EntityID>(intPtr);
				}
			}

			// Token: 0x06001FD1 RID: 8145 RVA: 0x00011E84 File Offset: 0x00010084
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B4 RID: 2228
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00079510 File Offset: 0x00077710
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00011E8D File Offset: 0x0001008D
			public unsafe EntitiesProvider entitiesProvider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_entitiesProvider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B5 RID: 2229
			// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00079540 File Offset: 0x00077740
			// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00011EAC File Offset: 0x000100AC
			public unsafe LoseUnitsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoseUnitsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoseUnitsPromptBehaviour.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400125D RID: 4701
			private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

			// Token: 0x0400125E RID: 4702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400125F RID: 4703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001260 RID: 4704
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__0_Internal_ValueTuple_2_Boolean_EntityID_EntityComponent_0;
		}
	}
}
