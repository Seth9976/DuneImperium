using System;
using boardgames.match.selection;
using dwd.core.match;
using dwd.core.ui.match.prompt.prompts;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C2 RID: 194
	public class UsurpGraftCardPromptBehaviour : PromptBehaviour<FlavoredDismissablePrompt>
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x000303D4 File Offset: 0x0002E5D4
		// Note: this type is marked as 'beforefieldinit'.
		static UsurpGraftCardPromptBehaviour()
		{
			Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "UsurpGraftCardPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr);
			UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_imperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "imperiumRow");
			UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "hand");
			UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_emptyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "emptyLabel");
			UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "dragTargetSelectionPromptBehaviour");
			UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "selectionResponder");
			UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, 100664329);
			UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_PileSetup_Private_Void_PileData_PileData_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, 100664330);
			UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_ShowPile_Private_Static_Void_PileData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, 100664331);
			UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, 100664332);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000304B8 File Offset: 0x0002E6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697134, XrefRangeEnd = 697166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000304F4 File Offset: 0x0002E6F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 697186, RefRangeEnd = 697188, XrefRangeStart = 697166, XrefRangeEnd = 697186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PileSetup(UsurpGraftCardPromptBehaviour.PileData pile, UsurpGraftCardPromptBehaviour.PileData otherPile, EntityComponent pileEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pile));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(otherPile));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pileEntity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_PileSetup_Private_Void_PileData_PileData_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00030564 File Offset: 0x0002E764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697188, XrefRangeEnd = 697190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShowPile(UsurpGraftCardPromptBehaviour.PileData pile, bool show)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pile));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr_ShowPile_Private_Static_Void_PileData_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000305B0 File Offset: 0x0002E7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697190, XrefRangeEnd = 697193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsurpGraftCardPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00005F31 File Offset: 0x00004131
		public UsurpGraftCardPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x000305EC File Offset: 0x0002E7EC
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00005F3A File Offset: 0x0000413A
		public UsurpGraftCardPromptBehaviour.PileData imperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_imperiumRow);
				return new UsurpGraftCardPromptBehaviour.PileData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_imperiumRow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0003061C File Offset: 0x0002E81C
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00005F68 File Offset: 0x00004168
		public UsurpGraftCardPromptBehaviour.PileData hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_hand);
				return new UsurpGraftCardPromptBehaviour.PileData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_hand), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0003064C File Offset: 0x0002E84C
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00005F96 File Offset: 0x00004196
		public unsafe GameObject emptyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_emptyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_emptyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0003067C File Offset: 0x0002E87C
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00005FB5 File Offset: 0x000041B5
		public unsafe WormDragTargetSelectionPromptBehaviour dragTargetSelectionPromptBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDragTargetSelectionPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000306AC File Offset: 0x0002E8AC
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00005FD4 File Offset: 0x000041D4
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_imperiumRow;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_hand;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_emptyLabel;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_dragTargetSelectionPromptBehaviour;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_PileSetup_Private_Void_PileData_PileData_EntityComponent_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_ShowPile_Private_Static_Void_PileData_Boolean_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000317 RID: 791
		[Serializable]
		public sealed class PileData : ValueType
		{
			// Token: 0x06001FD6 RID: 8150 RVA: 0x00079570 File Offset: 0x00077770
			// Note: this type is marked as 'beforefieldinit'.
			static PileData()
			{
				Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "PileData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr);
				UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, "view");
				UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, "toggle");
				UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, "displays");
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x00011ECB File Offset: 0x000100CB
			public PileData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FD8 RID: 8152 RVA: 0x00011ED4 File Offset: 0x000100D4
			public PileData()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr))
			{
			}

			// Token: 0x170008B6 RID: 2230
			// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000795D8 File Offset: 0x000777D8
			// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00011EE6 File Offset: 0x000100E6
			public unsafe ContainerView view
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_view);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B7 RID: 2231
			// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00079608 File Offset: 0x00077808
			// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00011F05 File Offset: 0x00010105
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00079638 File Offset: 0x00077838
			// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00011F24 File Offset: 0x00010124
			public unsafe Il2CppReferenceArray<GameObject> displays
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_displays);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.PileData.NativeFieldInfoPtr_displays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001261 RID: 4705
			private static readonly IntPtr NativeFieldInfoPtr_view;

			// Token: 0x04001262 RID: 4706
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeFieldInfoPtr_displays;
		}

		// Token: 0x02000318 RID: 792
		[ObfuscatedName("worm.match.prompts.behaviours.UsurpGraftCardPromptBehaviour+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001FDF RID: 8159 RVA: 0x00079668 File Offset: 0x00077868
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr);
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_pile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "pile");
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_otherPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "otherPile");
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664333);
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PileSetup_b__0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664334);
				UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PileSetup_b__1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100664335);
			}

			// Token: 0x06001FE0 RID: 8160 RVA: 0x0007970C File Offset: 0x0007790C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE1 RID: 8161 RVA: 0x00079748 File Offset: 0x00077948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697126, XrefRangeEnd = 697127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PileSetup_b__0(EntityComponent child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PileSetup_b__0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001FE2 RID: 8162 RVA: 0x00079798 File Offset: 0x00077998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697127, XrefRangeEnd = 697134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PileSetup_b__1(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__PileSetup_b__1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FE3 RID: 8163 RVA: 0x00011F43 File Offset: 0x00010143
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000797D8 File Offset: 0x000779D8
			// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x00011F4C File Offset: 0x0001014C
			public unsafe UsurpGraftCardPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsurpGraftCardPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BA RID: 2234
			// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x00079808 File Offset: 0x00077A08
			// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00011F6B File Offset: 0x0001016B
			public UsurpGraftCardPromptBehaviour.PileData pile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_pile);
					return new UsurpGraftCardPromptBehaviour.PileData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_pile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00079838 File Offset: 0x00077A38
			// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x00011F99 File Offset: 0x00010199
			public UsurpGraftCardPromptBehaviour.PileData otherPile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_otherPile);
					return new UsurpGraftCardPromptBehaviour.PileData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsurpGraftCardPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_otherPile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UsurpGraftCardPromptBehaviour.PileData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeFieldInfoPtr_pile;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeFieldInfoPtr_otherPile;

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeMethodInfoPtr__PileSetup_b__0_Internal_Boolean_EntityComponent_0;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeMethodInfoPtr__PileSetup_b__1_Internal_Void_Boolean_0;
		}
	}
}
