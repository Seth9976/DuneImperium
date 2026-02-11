using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000062 RID: 98
	public class VoodooGroupCommand : Command
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooGroupCommand()
		{
			Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooGroupCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr);
			VoodooGroupCommand.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "context");
			VoodooGroupCommand.NativeFieldInfoPtr_destinations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "destinations");
			VoodooGroupCommand.NativeFieldInfoPtr_positionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "positionMap");
			VoodooGroupCommand.NativeFieldInfoPtr_entityIDsAndSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "entityIDsAndSlots");
			VoodooGroupCommand.NativeFieldInfoPtr_hiddenViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "hiddenViews");
			VoodooGroupCommand.NativeFieldInfoPtr_entitySourceRemaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "entitySourceRemaps");
			VoodooGroupCommand.NativeFieldInfoPtr_genericSourceRemaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "genericSourceRemaps");
			VoodooGroupCommand.NativeFieldInfoPtr_entityDestinationRemaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "entityDestinationRemaps");
			VoodooGroupCommand.NativeFieldInfoPtr_genericDestinationRemaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "genericDestinationRemaps");
			VoodooGroupCommand.NativeFieldInfoPtr_seqNameRemaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "seqNameRemaps");
			VoodooGroupCommand.NativeFieldInfoPtr_additionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "additionalData");
			VoodooGroupCommand.NativeFieldInfoPtr_poolManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "poolManager");
			VoodooGroupCommand.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "entities");
			VoodooGroupCommand.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "viewManager");
			VoodooGroupCommand.NativeFieldInfoPtr_unblockedMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "unblockedMoves");
			VoodooGroupCommand.NativeFieldInfoPtr_completedMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "completedMoves");
			VoodooGroupCommand.NativeFieldInfoPtr_startId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "startId");
			VoodooGroupCommand.NativeFieldInfoPtr_destId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "destId");
			VoodooGroupCommand.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "onComplete");
			VoodooGroupCommand.NativeMethodInfoPtr_get_Context_Public_get_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664066);
			VoodooGroupCommand.NativeMethodInfoPtr_get_IsIntroduce_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664067);
			VoodooGroupCommand.NativeMethodInfoPtr_get_entityCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664068);
			VoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664069);
			VoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664070);
			VoodooGroupCommand.NativeMethodInfoPtr_createMoveContext_Private_MoveContext_String_ContainerView_ContainerView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664071);
			VoodooGroupCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_New_Void_String_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664072);
			VoodooGroupCommand.NativeMethodInfoPtr_AddToCommand_Public_Void_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664073);
			VoodooGroupCommand.NativeMethodInfoPtr_AddToCommand_Public_Void_EntityRepresentation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664074);
			VoodooGroupCommand.NativeMethodInfoPtr_IsMoveFor_Public_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664075);
			VoodooGroupCommand.NativeMethodInfoPtr_StartingPile_Public_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664076);
			VoodooGroupCommand.NativeMethodInfoPtr_DestinationPile_Public_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664077);
			VoodooGroupCommand.NativeMethodInfoPtr_finalizeContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664078);
			VoodooGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664079);
			VoodooGroupCommand.NativeMethodInfoPtr_WaitForCompletedMovesThenCleanUp_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664080);
			VoodooGroupCommand.NativeMethodInfoPtr_OnComplete_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664081);
			VoodooGroupCommand.NativeMethodInfoPtr_reparentView_Private_Void_UnitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664082);
			VoodooGroupCommand.NativeMethodInfoPtr_moveItem_Private_Void_UnitView_LocalTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664083);
			VoodooGroupCommand.NativeMethodInfoPtr_onPathUnblock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664084);
			VoodooGroupCommand.NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664085);
			VoodooGroupCommand.NativeMethodInfoPtr_initializePositions_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664086);
			VoodooGroupCommand.NativeMethodInfoPtr_updateContextForUnit_Protected_Virtual_New_Void_UnitView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664087);
			VoodooGroupCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, 100664088);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001C328 File Offset: 0x0001A528
		public unsafe MoveContext Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_get_Context_Public_get_MoveContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr3) : null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001C368 File Offset: 0x0001A568
		public unsafe bool IsIntroduce
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1112059, RefRangeEnd = 1112061, XrefRangeStart = 1112054, XrefRangeEnd = 1112059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_get_IsIntroduce_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		public unsafe int entityCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112061, XrefRangeEnd = 1112062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_get_entityCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1112063, RefRangeEnd = 1112065, XrefRangeStart = 1112062, XrefRangeEnd = 1112063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooGroupCommand(string sequenceName, VoodooGroupCommand.GroupInitInfo info)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001C444 File Offset: 0x0001A644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1112197, RefRangeEnd = 1112200, XrefRangeStart = 1112065, XrefRangeEnd = 1112197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooGroupCommand(string sequenceName, ContainerView start, ContainerView dest, EntityID startId, EntityID destId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112200, XrefRangeEnd = 1112216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveContext createMoveContext(string sequenceName, ContainerView startContainer, ContainerView destContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startContainer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_createMoveContext_Private_MoveContext_String_ContainerView_ContainerView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr3) : null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001C550 File Offset: 0x0001A750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112260, RefRangeEnd = 1112261, XrefRangeStart = 1112216, XrefRangeEnd = 1112260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleAttributes(string sequenceName, IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupCommand.NativeMethodInfoPtr_HandleAttributes_Public_Virtual_New_Void_String_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1112262, RefRangeEnd = 1112265, XrefRangeStart = 1112261, XrefRangeEnd = 1112262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToCommand(VoodooGroupCommand.GroupInitInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_AddToCommand_Public_Void_GroupInitInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001C5F8 File Offset: 0x0001A7F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1112286, RefRangeEnd = 1112289, XrefRangeStart = 1112265, XrefRangeEnd = 1112286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToCommand(EntityRepresentation entityRepr, int positionInParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityRepr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionInParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_AddToCommand_Public_Void_EntityRepresentation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001C648 File Offset: 0x0001A848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112289, XrefRangeEnd = 1112306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMoveFor(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_IsMoveFor_Public_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001C698 File Offset: 0x0001A898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112310, RefRangeEnd = 1112311, XrefRangeStart = 1112306, XrefRangeEnd = 1112310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent StartingPile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_StartingPile_Public_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112311, RefRangeEnd = 1112312, XrefRangeStart = 1112311, XrefRangeEnd = 1112311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityComponent DestinationPile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_DestinationPile_Public_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001C718 File Offset: 0x0001A918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112432, RefRangeEnd = 1112433, XrefRangeStart = 1112312, XrefRangeEnd = 1112432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void finalizeContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_finalizeContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001C74C File Offset: 0x0001A94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112433, XrefRangeEnd = 1112438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001C798 File Offset: 0x0001A998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112438, XrefRangeEnd = 1112443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForCompletedMovesThenCleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_WaitForCompletedMovesThenCleanUp_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnComplete(IEnumerator command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_OnComplete_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001C81C File Offset: 0x0001AA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112463, RefRangeEnd = 1112464, XrefRangeStart = 1112443, XrefRangeEnd = 1112463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void reparentView(UnitView unit, int slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_reparentView_Private_Void_UnitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0001C86C File Offset: 0x0001AA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112496, RefRangeEnd = 1112497, XrefRangeStart = 1112464, XrefRangeEnd = 1112496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void moveItem(UnitView unit, LocalTransform destLocalTransform, bool needPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLocalTransform;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_moveItem_Private_Void_UnitView_LocalTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0001C8CC File Offset: 0x0001AACC
		[CallerCount(0)]
		public unsafe void onPathUnblock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_onPathUnblock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0001C900 File Offset: 0x0001AB00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1112542, RefRangeEnd = 1112544, XrefRangeStart = 1112497, XrefRangeEnd = 1112542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onPathComplete(UnitView unit, PathAnimator path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0001C954 File Offset: 0x0001AB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112609, RefRangeEnd = 1112610, XrefRangeStart = 1112544, XrefRangeEnd = 1112609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void initializePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupCommand.NativeMethodInfoPtr_initializePositions_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0001C990 File Offset: 0x0001AB90
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void updateContextForUnit(UnitView unit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupCommand.NativeMethodInfoPtr_updateContextForUnit_Protected_Virtual_New_Void_UnitView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112610, XrefRangeEnd = 1112621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGroupCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00004C14 File Offset: 0x00002E14
		public VoodooGroupCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001CA24 File Offset: 0x0001AC24
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004C1D File Offset: 0x00002E1D
		public new unsafe MoveContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001CA54 File Offset: 0x0001AC54
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00004C3C File Offset: 0x00002E3C
		public unsafe Il2CppStructArray<LocalTransform> destinations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_destinations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LocalTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_destinations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001CA84 File Offset: 0x0001AC84
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00004C5B File Offset: 0x00002E5B
		public unsafe Dictionary<UnitView, UnitPosition> positionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_positionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UnitView, UnitPosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_positionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00004C7A File Offset: 0x00002E7A
		public unsafe List<ValueTuple<EntityRepresentation, int>> entityIDsAndSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entityIDsAndSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<EntityRepresentation, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entityIDsAndSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004C99 File Offset: 0x00002E99
		public unsafe List<UnitView> hiddenViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_hiddenViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_hiddenViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001CB14 File Offset: 0x0001AD14
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public unsafe Dictionary<EntityID, EntityID> entitySourceRemaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entitySourceRemaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entitySourceRemaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001CB44 File Offset: 0x0001AD44
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00004CD7 File Offset: 0x00002ED7
		public unsafe Dictionary<EntityID, string> genericSourceRemaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_genericSourceRemaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_genericSourceRemaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001CB74 File Offset: 0x0001AD74
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00004CF6 File Offset: 0x00002EF6
		public unsafe Dictionary<EntityID, EntityID> entityDestinationRemaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entityDestinationRemaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entityDestinationRemaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001CBA4 File Offset: 0x0001ADA4
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00004D15 File Offset: 0x00002F15
		public unsafe Dictionary<EntityID, string> genericDestinationRemaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_genericDestinationRemaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_genericDestinationRemaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00004D34 File Offset: 0x00002F34
		public unsafe Dictionary<EntityRepresentation, string> seqNameRemaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_seqNameRemaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityRepresentation, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_seqNameRemaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001CC04 File Offset: 0x0001AE04
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00004D53 File Offset: 0x00002F53
		public unsafe DataComposition additionalData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_additionalData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_additionalData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001CC34 File Offset: 0x0001AE34
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004D72 File Offset: 0x00002F72
		public unsafe PoolManager poolManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_poolManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_poolManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001CC64 File Offset: 0x0001AE64
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00004D91 File Offset: 0x00002F91
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001CC94 File Offset: 0x0001AE94
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004DB0 File Offset: 0x00002FB0
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001CCC4 File Offset: 0x0001AEC4
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004DCF File Offset: 0x00002FCF
		public unsafe int unblockedMoves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_unblockedMoves);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_unblockedMoves)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001CCEC File Offset: 0x0001AEEC
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00004DEA File Offset: 0x00002FEA
		public unsafe int completedMoves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_completedMoves);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_completedMoves)) = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001CD14 File Offset: 0x0001AF14
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x00004E05 File Offset: 0x00003005
		public unsafe EntityID startId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_startId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_startId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001CD44 File Offset: 0x0001AF44
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00004E24 File Offset: 0x00003024
		public unsafe EntityID destId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_destId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_destId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001CD74 File Offset: 0x0001AF74
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00004E43 File Offset: 0x00003043
		public unsafe IEnumerator onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeFieldInfoPtr_destinations;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeFieldInfoPtr_positionMap;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_entityIDsAndSlots;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr_hiddenViews;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_entitySourceRemaps;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_genericSourceRemaps;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeFieldInfoPtr_entityDestinationRemaps;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeFieldInfoPtr_genericDestinationRemaps;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeFieldInfoPtr_seqNameRemaps;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeFieldInfoPtr_additionalData;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeFieldInfoPtr_poolManager;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_unblockedMoves;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_completedMoves;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_startId;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_destId;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_MoveContext_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIntroduce_Private_get_Boolean_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_entityCount_Public_get_Int32_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GroupInitInfo_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ContainerView_ContainerView_EntityID_EntityID_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_createMoveContext_Private_MoveContext_String_ContainerView_ContainerView_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_HandleAttributes_Public_Virtual_New_Void_String_IHasAttributes_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_AddToCommand_Public_Void_GroupInitInfo_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_AddToCommand_Public_Void_EntityRepresentation_Int32_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_IsMoveFor_Public_Boolean_EntityID_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_StartingPile_Public_EntityComponent_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_DestinationPile_Public_EntityComponent_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_finalizeContext_Private_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletedMovesThenCleanUp_Private_IEnumerator_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_OnComplete_Public_Void_IEnumerator_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_reparentView_Private_Void_UnitView_Int32_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_moveItem_Private_Void_UnitView_LocalTransform_Boolean_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_onPathUnblock_Private_Void_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_onPathComplete_Private_Void_UnitView_PathAnimator_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_initializePositions_Protected_Virtual_New_Void_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_updateContextForUnit_Protected_Virtual_New_Void_UnitView_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000E5 RID: 229
		public sealed class GroupInitInfo : ValueType
		{
			// Token: 0x06000C0B RID: 3083 RVA: 0x00030A48 File Offset: 0x0002EC48
			// Note: this type is marked as 'beforefieldinit'.
			static GroupInitInfo()
			{
				Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "GroupInitInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr);
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "Start");
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "Dest");
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_StartId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "StartId");
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_DestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "DestId");
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_EntityRepr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "EntityRepr");
				VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, "PositionInParent");
				VoodooGroupCommand.GroupInitInfo.NativeMethodInfoPtr_ShouldJoin_Public_Boolean_VoodooGroupCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr, 100664089);
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x00030B00 File Offset: 0x0002ED00
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1111899, RefRangeEnd = 1111901, XrefRangeStart = 1111890, XrefRangeEnd = 1111899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool ShouldJoin(VoodooGroupCommand other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.GroupInitInfo.NativeMethodInfoPtr_ShouldJoin_Public_Boolean_VoodooGroupCommand_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00007E6C File Offset: 0x0000606C
			public GroupInitInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00007E75 File Offset: 0x00006075
			public GroupInitInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand.GroupInitInfo>.NativeClassPtr))
			{
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00030B54 File Offset: 0x0002ED54
			// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00007E87 File Offset: 0x00006087
			public unsafe ContainerView Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Start);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00030B84 File Offset: 0x0002ED84
			// (set) Token: 0x06000C12 RID: 3090 RVA: 0x00007EA6 File Offset: 0x000060A6
			public unsafe ContainerView Dest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Dest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_Dest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00030BB4 File Offset: 0x0002EDB4
			// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00007EC5 File Offset: 0x000060C5
			public unsafe EntityID StartId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_StartId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_StartId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00030BE4 File Offset: 0x0002EDE4
			// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00007EE4 File Offset: 0x000060E4
			public unsafe EntityID DestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_DestId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_DestId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00030C14 File Offset: 0x0002EE14
			// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00007F03 File Offset: 0x00006103
			public unsafe EntityRepresentation EntityRepr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_EntityRepr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityRepresentation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_EntityRepr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00030C44 File Offset: 0x0002EE44
			// (set) Token: 0x06000C1A RID: 3098 RVA: 0x00007F22 File Offset: 0x00006122
			public unsafe int PositionInParent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_PositionInParent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.GroupInitInfo.NativeFieldInfoPtr_PositionInParent)) = value;
				}
			}

			// Token: 0x04000787 RID: 1927
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04000788 RID: 1928
			private static readonly IntPtr NativeFieldInfoPtr_Dest;

			// Token: 0x04000789 RID: 1929
			private static readonly IntPtr NativeFieldInfoPtr_StartId;

			// Token: 0x0400078A RID: 1930
			private static readonly IntPtr NativeFieldInfoPtr_DestId;

			// Token: 0x0400078B RID: 1931
			private static readonly IntPtr NativeFieldInfoPtr_EntityRepr;

			// Token: 0x0400078C RID: 1932
			private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

			// Token: 0x0400078D RID: 1933
			private static readonly IntPtr NativeMethodInfoPtr_ShouldJoin_Public_Boolean_VoodooGroupCommand_0;
		}

		// Token: 0x020000E6 RID: 230
		[ObfuscatedName("lotus.VoodooGroupCommand+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Object
		{
			// Token: 0x06000C1B RID: 3099 RVA: 0x00030C6C File Offset: 0x0002EE6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr);
				VoodooGroupCommand.__c__DisplayClass31_0.NativeFieldInfoPtr_entityIDAndSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr, "entityIDAndSlot");
				VoodooGroupCommand.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr, 100664090);
				VoodooGroupCommand.__c__DisplayClass31_0.NativeMethodInfoPtr__AddToCommand_b__0_Internal_Boolean_ValueTuple_2_EntityRepresentation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr, 100664091);
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00030CD4 File Offset: 0x0002EED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00030D10 File Offset: 0x0002EF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111901, XrefRangeEnd = 1111909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddToCommand_b__0(ValueTuple<EntityRepresentation, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.__c__DisplayClass31_0.NativeMethodInfoPtr__AddToCommand_b__0_Internal_Boolean_ValueTuple_2_EntityRepresentation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C1E RID: 3102 RVA: 0x00007F3D File Offset: 0x0000613D
			public __c__DisplayClass31_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00030D64 File Offset: 0x0002EF64
			// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00007F46 File Offset: 0x00006146
			public ValueTuple<EntityRepresentation, int> entityIDAndSlot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass31_0.NativeFieldInfoPtr_entityIDAndSlot);
					return new ValueTuple<EntityRepresentation, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<EntityRepresentation, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass31_0.NativeFieldInfoPtr_entityIDAndSlot), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<EntityRepresentation, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400078E RID: 1934
			private static readonly IntPtr NativeFieldInfoPtr_entityIDAndSlot;

			// Token: 0x0400078F RID: 1935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000790 RID: 1936
			private static readonly IntPtr NativeMethodInfoPtr__AddToCommand_b__0_Internal_Boolean_ValueTuple_2_EntityRepresentation_Int32_0;
		}

		// Token: 0x020000E7 RID: 231
		[ObfuscatedName("lotus.VoodooGroupCommand+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Object
		{
			// Token: 0x06000C21 RID: 3105 RVA: 0x00030D94 File Offset: 0x0002EF94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr);
				VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr, "unit");
				VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr, "path");
				VoodooGroupCommand.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr, 100664092);
				VoodooGroupCommand.__c__DisplayClass40_0.NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr, 100664093);
			}

			// Token: 0x06000C22 RID: 3106 RVA: 0x00030E24 File Offset: 0x0002F024
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C23 RID: 3107 RVA: 0x00030E60 File Offset: 0x0002F060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111909, XrefRangeEnd = 1111918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _moveItem_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand.__c__DisplayClass40_0.NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x00007F74 File Offset: 0x00006174
			public __c__DisplayClass40_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00030E94 File Offset: 0x0002F094
			// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00007F7D File Offset: 0x0000617D
			public unsafe VoodooGroupCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00030EC4 File Offset: 0x0002F0C4
			// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00007F9C File Offset: 0x0000619C
			public unsafe UnitView unit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_unit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00030EF4 File Offset: 0x0002F0F4
			// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00007FBB File Offset: 0x000061BB
			public unsafe PathAnimator path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand.__c__DisplayClass40_0.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000791 RID: 1937
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000792 RID: 1938
			private static readonly IntPtr NativeFieldInfoPtr_unit;

			// Token: 0x04000793 RID: 1939
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04000794 RID: 1940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000795 RID: 1941
			private static readonly IntPtr NativeMethodInfoPtr__moveItem_b__0_Internal_Void_0;
		}

		// Token: 0x020000E8 RID: 232
		[ObfuscatedName("lotus.VoodooGroupCommand+<WaitForCompletedMovesThenCleanUp>d__37")]
		public sealed class _WaitForCompletedMovesThenCleanUp_d__37 : Object
		{
			// Token: 0x06000C2B RID: 3115 RVA: 0x00030F24 File Offset: 0x0002F124
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletedMovesThenCleanUp_d__37()
			{
				Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "<WaitForCompletedMovesThenCleanUp>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, "<>1__state");
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, "<>2__current");
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, "<>4__this");
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664094);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664095);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664096);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664097);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664098);
				VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr, 100664099);
			}

			// Token: 0x06000C2C RID: 3116 RVA: 0x00031004 File Offset: 0x0002F204
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForCompletedMovesThenCleanUp_d__37(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C2D RID: 3117 RVA: 0x0003104C File Offset: 0x0002F24C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x00031080 File Offset: 0x0002F280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111918, XrefRangeEnd = 1111972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000310BC File Offset: 0x0002F2BC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x000310FC File Offset: 0x0002F2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111972, XrefRangeEnd = 1111977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00031130 File Offset: 0x0002F330
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x00007FDA File Offset: 0x000061DA
			public _WaitForCompletedMovesThenCleanUp_d__37(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00031170 File Offset: 0x0002F370
			// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00007FE3 File Offset: 0x000061E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00031198 File Offset: 0x0002F398
			// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00007FFE File Offset: 0x000061FE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000311C8 File Offset: 0x0002F3C8
			// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0000801D File Offset: 0x0000621D
			public unsafe VoodooGroupCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._WaitForCompletedMovesThenCleanUp_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000796 RID: 1942
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000797 RID: 1943
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000798 RID: 1944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000799 RID: 1945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400079A RID: 1946
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400079B RID: 1947
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400079C RID: 1948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400079D RID: 1949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400079E RID: 1950
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E9 RID: 233
		[ObfuscatedName("lotus.VoodooGroupCommand+<execute>d__36")]
		public sealed class _execute_d__36 : Object
		{
			// Token: 0x06000C39 RID: 3129 RVA: 0x000311F8 File Offset: 0x0002F3F8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__36()
			{
				Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGroupCommand>.NativeClassPtr, "<execute>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr);
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<>1__state");
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<>2__current");
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<>4__this");
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToReceiveEntities_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<prepareToReceiveEntities>5__2");
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToRemoveEntities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<prepareToRemoveEntities>5__3");
				VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, "<i>5__4");
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664100);
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664101);
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664102);
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664103);
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664104);
				VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr, 100664105);
			}

			// Token: 0x06000C3A RID: 3130 RVA: 0x00031314 File Offset: 0x0002F514
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__36(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGroupCommand._execute_d__36>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x0003135C File Offset: 0x0002F55C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x00031390 File Offset: 0x0002F590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111977, XrefRangeEnd = 1112049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06000C3D RID: 3133 RVA: 0x000313CC File Offset: 0x0002F5CC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x0003140C File Offset: 0x0002F60C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112049, XrefRangeEnd = 1112054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00031440 File Offset: 0x0002F640
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGroupCommand._execute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x0000803C File Offset: 0x0000623C
			public _execute_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00031480 File Offset: 0x0002F680
			// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00008045 File Offset: 0x00006245
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000314A8 File Offset: 0x0002F6A8
			// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00008060 File Offset: 0x00006260
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000314D8 File Offset: 0x0002F6D8
			// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0000807F File Offset: 0x0000627F
			public unsafe VoodooGroupCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00031508 File Offset: 0x0002F708
			// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0000809E File Offset: 0x0000629E
			public unsafe IEnumerator _prepareToReceiveEntities_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToReceiveEntities_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToReceiveEntities_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00031538 File Offset: 0x0002F738
			// (set) Token: 0x06000C4A RID: 3146 RVA: 0x000080BD File Offset: 0x000062BD
			public unsafe IEnumerator _prepareToRemoveEntities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToRemoveEntities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__prepareToRemoveEntities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00031568 File Offset: 0x0002F768
			// (set) Token: 0x06000C4C RID: 3148 RVA: 0x000080DC File Offset: 0x000062DC
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGroupCommand._execute_d__36.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400079F RID: 1951
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040007A0 RID: 1952
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040007A1 RID: 1953
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040007A2 RID: 1954
			private static readonly IntPtr NativeFieldInfoPtr__prepareToReceiveEntities_5__2;

			// Token: 0x040007A3 RID: 1955
			private static readonly IntPtr NativeFieldInfoPtr__prepareToRemoveEntities_5__3;

			// Token: 0x040007A4 RID: 1956
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040007A5 RID: 1957
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040007A6 RID: 1958
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007A7 RID: 1959
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040007A8 RID: 1960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040007A9 RID: 1961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040007AA RID: 1962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
