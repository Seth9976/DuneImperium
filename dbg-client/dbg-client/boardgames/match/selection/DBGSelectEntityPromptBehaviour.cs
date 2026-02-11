using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine.UI;

namespace boardgames.match.selection
{
	// Token: 0x02000269 RID: 617
	public class DBGSelectEntityPromptBehaviour : PromptBehaviour<DBGSelectEntityPrompt>
	{
		// Token: 0x06001C86 RID: 7302 RVA: 0x0007BC88 File Offset: 0x00079E88
		// Note: this type is marked as 'beforefieldinit'.
		static DBGSelectEntityPromptBehaviour()
		{
			Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGSelectEntityPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr);
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "pileView");
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "toggleGroup");
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "entities");
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "selectionResponder");
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "tempPile");
			DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "selectedEntities");
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667969);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_createViews_Protected_Void_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667970);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667971);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667972);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_DeselectAllSelections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667973);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667974);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667975);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667976);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667977);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_EntitySelected_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667978);
			DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, 100667979);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0007BE0C File Offset: 0x0007A00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535776, XrefRangeEnd = 535796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0007BE48 File Offset: 0x0007A048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535856, RefRangeEnd = 535857, XrefRangeStart = 535796, XrefRangeEnd = 535856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void createViews(List<EntityComponent> entityComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_createViews_Protected_Void_List_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0007BE8C File Offset: 0x0007A08C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535878, RefRangeEnd = 535879, XrefRangeStart = 535857, XrefRangeEnd = 535878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOn(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0007BECC File Offset: 0x0007A0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535903, RefRangeEnd = 535904, XrefRangeStart = 535879, XrefRangeEnd = 535903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ToggleOff(int buttonIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buttonIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0007BF0C File Offset: 0x0007A10C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535920, RefRangeEnd = 535921, XrefRangeStart = 535904, XrefRangeEnd = 535920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_DeselectAllSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_DeselectAllSelections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0007BF40 File Offset: 0x0007A140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535921, XrefRangeEnd = 535927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0007BF74 File Offset: 0x0007A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535927, XrefRangeEnd = 535932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator attemptSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0007BFB4 File Offset: 0x0007A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535932, XrefRangeEnd = 535940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0007BFE8 File Offset: 0x0007A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535940, XrefRangeEnd = 535943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0007C024 File Offset: 0x0007A224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535943, XrefRangeEnd = 535947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EntitySelected(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr_EntitySelected_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0007C074 File Offset: 0x0007A274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535947, XrefRangeEnd = 535957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGSelectEntityPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		public DBGSelectEntityPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0007C0B0 File Offset: 0x0007A2B0
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000F4B5 File Offset: 0x0000D6B5
		public unsafe ContainerView pileView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_pileView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public unsafe ToggleGroup toggleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_toggleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0007C110 File Offset: 0x0007A310
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000F4F3 File Offset: 0x0000D6F3
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0007C140 File Offset: 0x0007A340
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0000F512 File Offset: 0x0000D712
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0007C170 File Offset: 0x0007A370
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0000F531 File Offset: 0x0000D731
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0007C1A0 File Offset: 0x0007A3A0
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0000F550 File Offset: 0x0000D750
		public unsafe List<EntityID> selectedEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.NativeFieldInfoPtr_selectedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeFieldInfoPtr_pileView;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr_toggleGroup;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntities;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_createViews_Protected_Void_List_1_EntityComponent_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOn_Private_Void_Int32_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_Event_ToggleOff_Private_Void_Int32_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_Event_DeselectAllSelections_Public_Void_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_Event_Submit_Public_Void_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_attemptSubmit_Public_IEnumerator_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_EntitySelected_Public_Boolean_EntityID_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000462 RID: 1122
		[ObfuscatedName("boardgames.match.selection.DBGSelectEntityPromptBehaviour+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06003551 RID: 13649 RVA: 0x000C7AFC File Offset: 0x000C5CFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr);
				DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "buttonIndex");
				DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100667980);
				DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__createViews_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100667981);
				DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__createViews_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr, 100667982);
			}

			// Token: 0x06003552 RID: 13650 RVA: 0x000C7B8C File Offset: 0x000C5D8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003553 RID: 13651 RVA: 0x000C7BC8 File Offset: 0x000C5DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535752, XrefRangeEnd = 535754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _createViews_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__createViews_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003554 RID: 13652 RVA: 0x000C7BFC File Offset: 0x000C5DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535754, XrefRangeEnd = 535756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _createViews_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeMethodInfoPtr__createViews_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003555 RID: 13653 RVA: 0x0001B86F File Offset: 0x00019A6F
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FA8 RID: 4008
			// (get) Token: 0x06003556 RID: 13654 RVA: 0x000C7C30 File Offset: 0x000C5E30
			// (set) Token: 0x06003557 RID: 13655 RVA: 0x0001B878 File Offset: 0x00019A78
			public unsafe int buttonIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_buttonIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr_buttonIndex)) = value;
				}
			}

			// Token: 0x17000FA9 RID: 4009
			// (get) Token: 0x06003558 RID: 13656 RVA: 0x000C7C58 File Offset: 0x000C5E58
			// (set) Token: 0x06003559 RID: 13657 RVA: 0x0001B893 File Offset: 0x00019A93
			public unsafe DBGSelectEntityPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectEntityPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020DA RID: 8410
			private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

			// Token: 0x040020DB RID: 8411
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020DC RID: 8412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040020DD RID: 8413
			private static readonly IntPtr NativeMethodInfoPtr__createViews_b__0_Internal_Void_0;

			// Token: 0x040020DE RID: 8414
			private static readonly IntPtr NativeMethodInfoPtr__createViews_b__1_Internal_Void_0;
		}

		// Token: 0x02000463 RID: 1123
		[ObfuscatedName("boardgames.match.selection.DBGSelectEntityPromptBehaviour+<attemptSubmit>d__12")]
		public sealed class _attemptSubmit_d__12 : Object
		{
			// Token: 0x0600355A RID: 13658 RVA: 0x000C7C88 File Offset: 0x000C5E88
			// Note: this type is marked as 'beforefieldinit'.
			static _attemptSubmit_d__12()
			{
				Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour>.NativeClassPtr, "<attemptSubmit>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, "<>1__state");
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, "<>2__current");
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, "<>4__this");
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr__submitConfirmation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, "<submitConfirmation>5__2");
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667983);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667984);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667985);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667986);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667987);
				DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr, 100667988);
			}

			// Token: 0x0600355B RID: 13659 RVA: 0x000C7D7C File Offset: 0x000C5F7C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _attemptSubmit_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGSelectEntityPromptBehaviour._attemptSubmit_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600355C RID: 13660 RVA: 0x000C7DC4 File Offset: 0x000C5FC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600355D RID: 13661 RVA: 0x000C7DF8 File Offset: 0x000C5FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535756, XrefRangeEnd = 535771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FAE RID: 4014
			// (get) Token: 0x0600355E RID: 13662 RVA: 0x000C7E34 File Offset: 0x000C6034
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600355F RID: 13663 RVA: 0x000C7E74 File Offset: 0x000C6074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535771, XrefRangeEnd = 535776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FAF RID: 4015
			// (get) Token: 0x06003560 RID: 13664 RVA: 0x000C7EA8 File Offset: 0x000C60A8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003561 RID: 13665 RVA: 0x0001B8B2 File Offset: 0x00019AB2
			public _attemptSubmit_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FAA RID: 4010
			// (get) Token: 0x06003562 RID: 13666 RVA: 0x000C7EE8 File Offset: 0x000C60E8
			// (set) Token: 0x06003563 RID: 13667 RVA: 0x0001B8BB File Offset: 0x00019ABB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FAB RID: 4011
			// (get) Token: 0x06003564 RID: 13668 RVA: 0x000C7F10 File Offset: 0x000C6110
			// (set) Token: 0x06003565 RID: 13669 RVA: 0x0001B8D6 File Offset: 0x00019AD6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FAC RID: 4012
			// (get) Token: 0x06003566 RID: 13670 RVA: 0x000C7F40 File Offset: 0x000C6140
			// (set) Token: 0x06003567 RID: 13671 RVA: 0x0001B8F5 File Offset: 0x00019AF5
			public unsafe DBGSelectEntityPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectEntityPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FAD RID: 4013
			// (get) Token: 0x06003568 RID: 13672 RVA: 0x000C7F70 File Offset: 0x000C6170
			// (set) Token: 0x06003569 RID: 13673 RVA: 0x0001B914 File Offset: 0x00019B14
			public unsafe IEnumerator<Nullable<bool>> _submitConfirmation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr__submitConfirmation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Nullable<bool>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGSelectEntityPromptBehaviour._attemptSubmit_d__12.NativeFieldInfoPtr__submitConfirmation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040020DF RID: 8415
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040020E0 RID: 8416
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040020E1 RID: 8417
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040020E2 RID: 8418
			private static readonly IntPtr NativeFieldInfoPtr__submitConfirmation_5__2;

			// Token: 0x040020E3 RID: 8419
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040020E4 RID: 8420
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E5 RID: 8421
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040020E6 RID: 8422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040020E7 RID: 8423
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040020E8 RID: 8424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
