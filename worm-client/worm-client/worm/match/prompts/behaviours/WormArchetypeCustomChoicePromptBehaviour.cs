using System;
using boardgames.match;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C4 RID: 196
	public class WormArchetypeCustomChoicePromptBehaviour : PromptBehaviour<ArchetypeCustomChoiceInfoPrompt>
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x00030CC0 File Offset: 0x0002EEC0
		// Note: this type is marked as 'beforefieldinit'.
		static WormArchetypeCustomChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormArchetypeCustomChoicePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr);
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "confirmButton");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "cancelButton");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "pileView");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "entities");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "tempPile");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "toggles");
			WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "selectedChoices");
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664359);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664360);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664361);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664362);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664363);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664364);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664365);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664366);
			WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, 100664367);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00030E30 File Offset: 0x0002F030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697464, XrefRangeEnd = 697505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00030E6C File Offset: 0x0002F06C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 697514, RefRangeEnd = 697519, XrefRangeStart = 697505, XrefRangeEnd = 697514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00030EA0 File Offset: 0x0002F0A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 697584, RefRangeEnd = 697585, XrefRangeStart = 697519, XrefRangeEnd = 697584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChoices(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697585, XrefRangeEnd = 697600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOn(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00030F24 File Offset: 0x0002F124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697600, XrefRangeEnd = 697605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOff(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00030F64 File Offset: 0x0002F164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697605, XrefRangeEnd = 697612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00030F98 File Offset: 0x0002F198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697612, XrefRangeEnd = 697619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00030FCC File Offset: 0x0002F1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697619, XrefRangeEnd = 697622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00031008 File Offset: 0x0002F208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697622, XrefRangeEnd = 697632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormArchetypeCustomChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00006176 File Offset: 0x00004376
		public WormArchetypeCustomChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00031044 File Offset: 0x0002F244
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x0000617F File Offset: 0x0000437F
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00031074 File Offset: 0x0002F274
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x0000619E File Offset: 0x0000439E
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000310A4 File Offset: 0x0002F2A4
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000061BD File Offset: 0x000043BD
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000310D4 File Offset: 0x0002F2D4
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x000061DC File Offset: 0x000043DC
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00031104 File Offset: 0x0002F304
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000061FB File Offset: 0x000043FB
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00031134 File Offset: 0x0002F334
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0000621A File Offset: 0x0000441A
		public unsafe Il2CppReferenceArray<Toggle> toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00031164 File Offset: 0x0002F364
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00006239 File Offset: 0x00004439
		public unsafe List<int> selectedChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_toggles;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_selectedChoices;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031C RID: 796
		[ObfuscatedName("worm.match.prompts.behaviours.WormArchetypeCustomChoicePromptBehaviour+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06002011 RID: 8209 RVA: 0x00079FBC File Offset: 0x000781BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr);
				WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_toggleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "toggleIndex");
				WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664368);
				WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateChoices_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664369);
				WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateChoices_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr, 100664370);
			}

			// Token: 0x06002012 RID: 8210 RVA: 0x0007A04C File Offset: 0x0007824C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002013 RID: 8211 RVA: 0x0007A088 File Offset: 0x00078288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697444, XrefRangeEnd = 697459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateChoices_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateChoices_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002014 RID: 8212 RVA: 0x0007A0BC File Offset: 0x000782BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697459, XrefRangeEnd = 697464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateChoices_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeMethodInfoPtr__CreateChoices_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002015 RID: 8213 RVA: 0x000120E9 File Offset: 0x000102E9
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06002016 RID: 8214 RVA: 0x0007A0F0 File Offset: 0x000782F0
			// (set) Token: 0x06002017 RID: 8215 RVA: 0x000120F2 File Offset: 0x000102F2
			public unsafe int toggleIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_toggleIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr_toggleIndex)) = value;
				}
			}

			// Token: 0x170008C9 RID: 2249
			// (get) Token: 0x06002018 RID: 8216 RVA: 0x0007A118 File Offset: 0x00078318
			// (set) Token: 0x06002019 RID: 8217 RVA: 0x0001210D File Offset: 0x0001030D
			public unsafe WormArchetypeCustomChoicePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypeCustomChoicePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormArchetypeCustomChoicePromptBehaviour.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001281 RID: 4737
			private static readonly IntPtr NativeFieldInfoPtr_toggleIndex;

			// Token: 0x04001282 RID: 4738
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001283 RID: 4739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001284 RID: 4740
			private static readonly IntPtr NativeMethodInfoPtr__CreateChoices_b__0_Internal_Void_0;

			// Token: 0x04001285 RID: 4741
			private static readonly IntPtr NativeMethodInfoPtr__CreateChoices_b__1_Internal_Void_0;
		}
	}
}
