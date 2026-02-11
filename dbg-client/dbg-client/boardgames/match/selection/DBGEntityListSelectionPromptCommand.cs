using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.selection
{
	// Token: 0x02000267 RID: 615
	public class DBGEntityListSelectionPromptCommand : DBGEntityComponentChoicesSelectionPromptCommand<IEntityListSelection>
	{
		// Token: 0x06001C6C RID: 7276 RVA: 0x0007B610 File Offset: 0x00079810
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntityListSelectionPromptCommand()
		{
			Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.selection", "DBGEntityListSelectionPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr);
			DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, "promptData");
			DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, "promptFlavors");
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667957);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667958);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667959);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667960);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667961);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667962);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667963);
			DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr, 100667964);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0007B708 File Offset: 0x00079908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 535584, RefRangeEnd = 535586, XrefRangeStart = 535579, XrefRangeEnd = 535584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGEntityListSelectionPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityListSelectionPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0007B764 File Offset: 0x00079964
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0007B7B0 File Offset: 0x000799B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535586, XrefRangeEnd = 535618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0007B7F8 File Offset: 0x000799F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535618, XrefRangeEnd = 535633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool submitSelection(EntityID entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0007B850 File Offset: 0x00079A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535633, XrefRangeEnd = 535693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool tryGetChoices(out List<EntityComponent> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				choices = ((intPtr4 == 0) ? null : new List<EntityComponent>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0007B8BC File Offset: 0x00079ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 535713, RefRangeEnd = 535714, XrefRangeStart = 535693, XrefRangeEnd = 535713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition getPromptData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0007B908 File Offset: 0x00079B08
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PrefabFlavorContext getPromptFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0007B94C File Offset: 0x00079B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 535714, XrefRangeEnd = 535734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGSelectionPrompt getPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGEntityListSelectionPromptCommand.NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGSelectionPrompt>(intPtr3) : null;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0000F3F8 File Offset: 0x0000D5F8
		public DBGEntityListSelectionPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x0007B998 File Offset: 0x00079B98
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0000F401 File Offset: 0x0000D601
		public unsafe DataComposition promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0007B9C8 File Offset: 0x00079BC8
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0000F420 File Offset: 0x0000D620
		public PrefabFlavorContext promptFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGEntityListSelectionPromptCommand.NativeFieldInfoPtr_promptFlavors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeFieldInfoPtr_promptData;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeFieldInfoPtr_promptFlavors;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_submitSelection_Protected_Virtual_Boolean_EntityID_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_tryGetChoices_Protected_Virtual_Boolean_byref_List_1_EntityComponent_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_getPromptData_Protected_Virtual_New_DataComposition_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_New_PrefabFlavorContext_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_getPrompt_Protected_Virtual_DBGSelectionPrompt_0;
	}
}
