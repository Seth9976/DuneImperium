using System;
using boardgames.match;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000CB RID: 203
	public class WormCustomChoicePromptBehaviour : PromptBehaviour<CustomChoiceInfoPrompt>
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x00032478 File Offset: 0x00030678
		// Note: this type is marked as 'beforefieldinit'.
		static WormCustomChoicePromptBehaviour()
		{
			Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormCustomChoicePromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr);
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "confirmButton");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "cancelButton");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "pileView");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "entities");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "tempPile");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "selectedChoice");
			WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "tempChild");
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664459);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664460);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664461);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664462);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_OnToggleChanged_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664463);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_ToggleOn_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664464);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_ToggleOff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664465);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664466);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Confirm_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664467);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664468);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664469);
			WormCustomChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, 100664470);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00032624 File Offset: 0x00030824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698591, XrefRangeEnd = 698646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00032660 File Offset: 0x00030860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 698661, RefRangeEnd = 698662, XrefRangeStart = 698646, XrefRangeEnd = 698661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChoices(ArchetypeID archetypeID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000326A4 File Offset: 0x000308A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 698686, RefRangeEnd = 698688, XrefRangeStart = 698662, XrefRangeEnd = 698686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateChoices(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_CreateChoices_Private_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000326E8 File Offset: 0x000308E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698688, XrefRangeEnd = 698691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtonStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0003271C File Offset: 0x0003091C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698691, XrefRangeEnd = 698715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleChanged(bool isOn, int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref choice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_OnToggleChanged_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00032768 File Offset: 0x00030968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698715, XrefRangeEnd = 698735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleOn(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_ToggleOn_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000327A8 File Offset: 0x000309A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698735, XrefRangeEnd = 698740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleOff(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_ToggleOff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000327E8 File Offset: 0x000309E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698740, XrefRangeEnd = 698750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0003281C File Offset: 0x00030A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698750, XrefRangeEnd = 698755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Confirm(int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref choice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Confirm_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00032868 File Offset: 0x00030A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698755, XrefRangeEnd = 698762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0003289C File Offset: 0x00030A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698762, XrefRangeEnd = 698766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCustomChoicePromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000328D8 File Offset: 0x00030AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698766, XrefRangeEnd = 698769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCustomChoicePromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00006596 File Offset: 0x00004796
		public WormCustomChoicePromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00032914 File Offset: 0x00030B14
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0000659F File Offset: 0x0000479F
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00032944 File Offset: 0x00030B44
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x000065BE File Offset: 0x000047BE
		public unsafe Button cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00032974 File Offset: 0x00030B74
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x000065DD File Offset: 0x000047DD
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x000329A4 File Offset: 0x00030BA4
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x000065FC File Offset: 0x000047FC
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000329D4 File Offset: 0x00030BD4
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x0000661B File Offset: 0x0000481B
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00032A04 File Offset: 0x00030C04
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x0000663A File Offset: 0x0000483A
		public Nullable<int> selectedChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoice);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_selectedChoice), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00032A34 File Offset: 0x00030C34
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00006668 File Offset: 0x00004868
		public unsafe EntityComponent tempChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour.NativeFieldInfoPtr_tempChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_selectedChoice;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_tempChild;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_CreateChoices_Private_Void_ArchetypeID_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_CreateChoices_Private_Void_EntityComponent_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonStates_Private_Void_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleChanged_Private_Void_Boolean_Int32_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_ToggleOn_Private_Void_Int32_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_ToggleOff_Private_Void_Int32_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_IEnumerator_Int32_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("worm.match.prompts.behaviours.WormCustomChoicePromptBehaviour+<Confirm>d__15")]
		public sealed class _Confirm_d__15 : Object
		{
			// Token: 0x060020DC RID: 8412 RVA: 0x0007C2F0 File Offset: 0x0007A4F0
			// Note: this type is marked as 'beforefieldinit'.
			static _Confirm_d__15()
			{
				Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour>.NativeClassPtr, "<Confirm>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, "<>1__state");
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, "<>2__current");
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, "choice");
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, "<>4__this");
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, "<confirmOrDenyPrompt>5__2");
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664471);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664472);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664473);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664474);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664475);
				WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr, 100664476);
			}

			// Token: 0x060020DD RID: 8413 RVA: 0x0007C3F8 File Offset: 0x0007A5F8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Confirm_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoicePromptBehaviour._Confirm_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020DE RID: 8414 RVA: 0x0007C440 File Offset: 0x0007A640
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020DF RID: 8415 RVA: 0x0007C474 File Offset: 0x0007A674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698533, XrefRangeEnd = 698586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0007C4B0 File Offset: 0x0007A6B0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0007C4F0 File Offset: 0x0007A6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698586, XrefRangeEnd = 698591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0007C524 File Offset: 0x0007A724
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x00012813 File Offset: 0x00010A13
			public _Confirm_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x060020E4 RID: 8420 RVA: 0x0007C564 File Offset: 0x0007A764
			// (set) Token: 0x060020E5 RID: 8421 RVA: 0x0001281C File Offset: 0x00010A1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0007C58C File Offset: 0x0007A78C
			// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00012837 File Offset: 0x00010A37
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0007C5BC File Offset: 0x0007A7BC
			// (set) Token: 0x060020E9 RID: 8425 RVA: 0x00012856 File Offset: 0x00010A56
			public unsafe int choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr_choice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr_choice)) = value;
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x060020EA RID: 8426 RVA: 0x0007C5E4 File Offset: 0x0007A7E4
			// (set) Token: 0x060020EB RID: 8427 RVA: 0x00012871 File Offset: 0x00010A71
			public unsafe WormCustomChoicePromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCustomChoicePromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x060020EC RID: 8428 RVA: 0x0007C614 File Offset: 0x0007A814
			// (set) Token: 0x060020ED RID: 8429 RVA: 0x00012890 File Offset: 0x00010A90
			public unsafe ConfirmOrDenyPrompt _confirmOrDenyPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoicePromptBehaviour._Confirm_d__15.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012EE RID: 4846
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012EF RID: 4847
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012F0 RID: 4848
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDenyPrompt_5__2;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012F5 RID: 4853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
