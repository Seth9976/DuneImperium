using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.data;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus.sequences;

namespace lotus
{
	// Token: 0x02000085 RID: 133
	public class VoodooGenericSequence : SequenceCommand
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x00023B18 File Offset: 0x00021D18
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooGenericSequence()
		{
			Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "VoodooGenericSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr);
			VoodooGenericSequence.NativeFieldInfoPtr__runGroupCommandsLinearly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<runGroupCommandsLinearly>k__BackingField");
			VoodooGenericSequence.NativeFieldInfoPtr__RunAnimations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<RunAnimations>k__BackingField");
			VoodooGenericSequence.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "viewManager");
			VoodooGenericSequence.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "entitiesProvider");
			VoodooGenericSequence.NativeFieldInfoPtr_groupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "groupCommands");
			VoodooGenericSequence.NativeFieldInfoPtr_voodooCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "voodooCommands");
			VoodooGenericSequence.NativeFieldInfoPtr_SequenceGroupCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "SequenceGroupCommands");
			VoodooGenericSequence.NativeMethodInfoPtr_get_runGroupCommandsLinearly_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664365);
			VoodooGenericSequence.NativeMethodInfoPtr_get_RunAnimations_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664366);
			VoodooGenericSequence.NativeMethodInfoPtr_set_RunAnimations_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664367);
			VoodooGenericSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664368);
			VoodooGenericSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664369);
			VoodooGenericSequence.NativeMethodInfoPtr_runAnimations_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664370);
			VoodooGenericSequence.NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_New_IEnumerator_List_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664371);
			VoodooGenericSequence.NativeMethodInfoPtr_runSequenceCommands_Protected_IEnumerator_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664372);
			VoodooGenericSequence.NativeMethodInfoPtr_getSequenceCommands_Protected_List_1_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664373);
			VoodooGenericSequence.NativeMethodInfoPtr_extractAnimationCommands_Public_List_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664374);
			VoodooGenericSequence.NativeMethodInfoPtr_createOrAddToGroupCommand_Protected_ValueTuple_2_Command_VoodooGroupCommand_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664375);
			VoodooGenericSequence.NativeMethodInfoPtr_createContextAttributes_Protected_Virtual_New_ReadOnlyAttributes_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664376);
			VoodooGenericSequence.NativeMethodInfoPtr_createGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_String_ContainerView_ContainerView_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, 100664377);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00023CD8 File Offset: 0x00021ED8
		public unsafe virtual bool runGroupCommandsLinearly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGenericSequence.NativeMethodInfoPtr_get_runGroupCommandsLinearly_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00023D20 File Offset: 0x00021F20
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00023D5C File Offset: 0x00021F5C
		public unsafe virtual bool RunAnimations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_get_RunAnimations_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_set_RunAnimations_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00023D9C File Offset: 0x00021F9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1115443, RefRangeEnd = 1115448, XrefRangeStart = 1115415, XrefRangeEnd = 1115443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooGenericSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00023E0C File Offset: 0x0002200C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1115453, RefRangeEnd = 1115455, XrefRangeStart = 1115448, XrefRangeEnd = 1115453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator executeSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGenericSequence.NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00023E58 File Offset: 0x00022058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115455, XrefRangeEnd = 1115460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator runAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_runAnimations_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00023E98 File Offset: 0x00022098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115466, RefRangeEnd = 1115467, XrefRangeStart = 1115460, XrefRangeEnd = 1115466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator runAnimationCommands(List<Command> animationCommands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animationCommands);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGenericSequence.NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_New_IEnumerator_List_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00023EF4 File Offset: 0x000220F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115467, XrefRangeEnd = 1115473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runSequenceCommands(Command animationCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animationCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_runSequenceCommands_Protected_IEnumerator_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00023F44 File Offset: 0x00022144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115473, XrefRangeEnd = 1115512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Command> getSequenceCommands(Command animationCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animationCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_getSequenceCommands_Protected_List_1_Command_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr3) : null;
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00023F94 File Offset: 0x00022194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115512, XrefRangeEnd = 1115520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Command> extractAnimationCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_extractAnimationCommands_Public_List_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr3) : null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00023FD4 File Offset: 0x000221D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1115624, RefRangeEnd = 1115625, XrefRangeStart = 1115520, XrefRangeEnd = 1115624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Command, VoodooGroupCommand> createOrAddToGroupCommand(Command seqCommand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seqCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.NativeMethodInfoPtr_createOrAddToGroupCommand_Protected_ValueTuple_2_Command_VoodooGroupCommand_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<Command, VoodooGroupCommand>(intPtr);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0002401C File Offset: 0x0002221C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115625, XrefRangeEnd = 1115629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ReadOnlyAttributes createContextAttributes(Command command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGenericSequence.NativeMethodInfoPtr_createContextAttributes_Protected_Virtual_New_ReadOnlyAttributes_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00024078 File Offset: 0x00022278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115629, XrefRangeEnd = 1115633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual VoodooGroupCommand createGroupCommand(Command seqCommand, string name, ContainerView startView, ContainerView endView, EntityID startId, EntityID endId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seqCommand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startView);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endView);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooGenericSequence.NativeMethodInfoPtr_createGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_String_ContainerView_ContainerView_EntityID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr3) : null;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00005E8B File Offset: 0x0000408B
		public VoodooGenericSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00024130 File Offset: 0x00022330
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x00005E94 File Offset: 0x00004094
		public unsafe bool _runGroupCommandsLinearly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr__runGroupCommandsLinearly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr__runGroupCommandsLinearly_k__BackingField)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00024158 File Offset: 0x00022358
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00005EAF File Offset: 0x000040AF
		public unsafe bool _RunAnimations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr__RunAnimations_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr__RunAnimations_k__BackingField)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00024180 File Offset: 0x00022380
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00005ECA File Offset: 0x000040CA
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000241B0 File Offset: 0x000223B0
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00005EE9 File Offset: 0x000040E9
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x000241E0 File Offset: 0x000223E0
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00005F08 File Offset: 0x00004108
		public unsafe List<VoodooGroupCommand> groupCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_groupCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VoodooGroupCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_groupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00024210 File Offset: 0x00022410
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00005F27 File Offset: 0x00004127
		public unsafe List<Command> voodooCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_voodooCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_voodooCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00024240 File Offset: 0x00022440
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x00005F46 File Offset: 0x00004146
		public unsafe List<VoodooGenericSequence.SequenceGroupCommand> SequenceGroupCommands
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_SequenceGroupCommands);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VoodooGenericSequence.SequenceGroupCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.NativeFieldInfoPtr_SequenceGroupCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr__runGroupCommandsLinearly_k__BackingField;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr__RunAnimations_k__BackingField;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_groupCommands;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_voodooCommands;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_SequenceGroupCommands;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_get_runGroupCommandsLinearly_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_RunAnimations_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_set_RunAnimations_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_executeSequence_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_runAnimations_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_runAnimationCommands_Protected_Virtual_New_IEnumerator_List_1_Command_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_runSequenceCommands_Protected_IEnumerator_Command_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_getSequenceCommands_Protected_List_1_Command_Command_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_extractAnimationCommands_Public_List_1_Command_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_createOrAddToGroupCommand_Protected_ValueTuple_2_Command_VoodooGroupCommand_Command_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_createContextAttributes_Protected_Virtual_New_ReadOnlyAttributes_Command_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_createGroupCommand_Protected_Virtual_New_VoodooGroupCommand_Command_String_ContainerView_ContainerView_EntityID_EntityID_0;

		// Token: 0x020000FE RID: 254
		public sealed class SequenceGroupCommand : ValueType
		{
			// Token: 0x06000CFA RID: 3322 RVA: 0x00033418 File Offset: 0x00031618
			// Note: this type is marked as 'beforefieldinit'.
			static SequenceGroupCommand()
			{
				Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "SequenceGroupCommand");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr);
				VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_GroupCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr, "GroupCommand");
				VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_SequenceCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr, "SequenceCommands");
				VoodooGenericSequence.SequenceGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_VoodooGroupCommand_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr, 100664378);
			}

			// Token: 0x06000CFB RID: 3323 RVA: 0x00033480 File Offset: 0x00031680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115207, XrefRangeEnd = 1115222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SequenceGroupCommand(VoodooGroupCommand groupCommand, Command sequenceCommand)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupCommand);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequenceCommand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence.SequenceGroupCommand.NativeMethodInfoPtr__ctor_Public_Void_VoodooGroupCommand_Command_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CFC RID: 3324 RVA: 0x00008684 File Offset: 0x00006884
			public SequenceGroupCommand(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CFD RID: 3325 RVA: 0x0000868D File Offset: 0x0000688D
			public SequenceGroupCommand()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence.SequenceGroupCommand>.NativeClassPtr))
			{
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000CFE RID: 3326 RVA: 0x000334E4 File Offset: 0x000316E4
			// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0000869F File Offset: 0x0000689F
			public unsafe VoodooGroupCommand GroupCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_GroupCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_GroupCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000D00 RID: 3328 RVA: 0x00033514 File Offset: 0x00031714
			// (set) Token: 0x06000D01 RID: 3329 RVA: 0x000086BE File Offset: 0x000068BE
			public unsafe List<Command> SequenceCommands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_SequenceCommands);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence.SequenceGroupCommand.NativeFieldInfoPtr_SequenceCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400080F RID: 2063
			private static readonly IntPtr NativeFieldInfoPtr_GroupCommand;

			// Token: 0x04000810 RID: 2064
			private static readonly IntPtr NativeFieldInfoPtr_SequenceCommands;

			// Token: 0x04000811 RID: 2065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VoodooGroupCommand_Command_0;
		}

		// Token: 0x020000FF RID: 255
		[ObfuscatedName("lotus.VoodooGenericSequence+<executeSequence>d__14")]
		public sealed class _executeSequence_d__14 : Object
		{
			// Token: 0x06000D02 RID: 3330 RVA: 0x00033544 File Offset: 0x00031744
			// Note: this type is marked as 'beforefieldinit'.
			static _executeSequence_d__14()
			{
				Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<executeSequence>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr);
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<>1__state");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<>2__current");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<>4__this");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<>7__wrap1");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runImmediately_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<runImmediately>5__3");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__nestedSequence_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<nestedSequence>5__4");
				VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runAnims_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, "<runAnims>5__5");
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664379);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664380);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664381);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664382);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664383);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664384);
				VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr, 100664385);
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x00033688 File Offset: 0x00031888
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeSequence_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence._executeSequence_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D04 RID: 3332 RVA: 0x000336D0 File Offset: 0x000318D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115222, XrefRangeEnd = 1115227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x00033704 File Offset: 0x00031904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115227, XrefRangeEnd = 1115297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x00033740 File Offset: 0x00031940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115297, XrefRangeEnd = 1115300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00033774 File Offset: 0x00031974
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x000337B4 File Offset: 0x000319B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115300, XrefRangeEnd = 1115305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000337E8 File Offset: 0x000319E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._executeSequence_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x000086DD File Offset: 0x000068DD
			public _executeSequence_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00033828 File Offset: 0x00031A28
			// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000086E6 File Offset: 0x000068E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00033850 File Offset: 0x00031A50
			// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00008701 File Offset: 0x00006901
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00033880 File Offset: 0x00031A80
			// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00008720 File Offset: 0x00006920
			public unsafe VoodooGenericSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGenericSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000338B0 File Offset: 0x00031AB0
			// (set) Token: 0x06000D12 RID: 3346 RVA: 0x0000873F File Offset: 0x0000693F
			public unsafe IEnumerator<Command> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000338E0 File Offset: 0x00031AE0
			// (set) Token: 0x06000D14 RID: 3348 RVA: 0x0000875E File Offset: 0x0000695E
			public unsafe Command _runImmediately_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runImmediately_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runImmediately_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00033910 File Offset: 0x00031B10
			// (set) Token: 0x06000D16 RID: 3350 RVA: 0x0000877D File Offset: 0x0000697D
			public unsafe IAnimationSequence _nestedSequence_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__nestedSequence_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAnimationSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__nestedSequence_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00033940 File Offset: 0x00031B40
			// (set) Token: 0x06000D18 RID: 3352 RVA: 0x0000879C File Offset: 0x0000699C
			public unsafe IEnumerator _runAnims_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runAnims_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._executeSequence_d__14.NativeFieldInfoPtr__runAnims_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000812 RID: 2066
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000813 RID: 2067
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000814 RID: 2068
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000815 RID: 2069
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000816 RID: 2070
			private static readonly IntPtr NativeFieldInfoPtr__runImmediately_5__3;

			// Token: 0x04000817 RID: 2071
			private static readonly IntPtr NativeFieldInfoPtr__nestedSequence_5__4;

			// Token: 0x04000818 RID: 2072
			private static readonly IntPtr NativeFieldInfoPtr__runAnims_5__5;

			// Token: 0x04000819 RID: 2073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400081A RID: 2074
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400081B RID: 2075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400081C RID: 2076
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400081D RID: 2077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400081E RID: 2078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400081F RID: 2079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000100 RID: 256
		[ObfuscatedName("lotus.VoodooGenericSequence+<runAnimationCommands>d__16")]
		public sealed class _runAnimationCommands_d__16 : Object
		{
			// Token: 0x06000D19 RID: 3353 RVA: 0x00033970 File Offset: 0x00031B70
			// Note: this type is marked as 'beforefieldinit'.
			static _runAnimationCommands_d__16()
			{
				Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<runAnimationCommands>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<>1__state");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<>2__current");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr_animationCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "animationCommands");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<>4__this");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<>7__wrap1");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__command_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<command>5__3");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__sequenceCommands_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, "<sequenceCommands>5__4");
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664386);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664387);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664388);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664389);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664390);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664391);
				VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr, 100664392);
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x00033AB4 File Offset: 0x00031CB4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runAnimationCommands_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence._runAnimationCommands_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D1B RID: 3355 RVA: 0x00033AFC File Offset: 0x00031CFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115305, XrefRangeEnd = 1115310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x00033B30 File Offset: 0x00031D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115310, XrefRangeEnd = 1115346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D1D RID: 3357 RVA: 0x00033B6C File Offset: 0x00031D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115346, XrefRangeEnd = 1115349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00033BA0 File Offset: 0x00031DA0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x00033BE0 File Offset: 0x00031DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115349, XrefRangeEnd = 1115354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00033C14 File Offset: 0x00031E14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimationCommands_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x000087BB File Offset: 0x000069BB
			public _runAnimationCommands_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00033C54 File Offset: 0x00031E54
			// (set) Token: 0x06000D23 RID: 3363 RVA: 0x000087C4 File Offset: 0x000069C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00033C7C File Offset: 0x00031E7C
			// (set) Token: 0x06000D25 RID: 3365 RVA: 0x000087DF File Offset: 0x000069DF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00033CAC File Offset: 0x00031EAC
			// (set) Token: 0x06000D27 RID: 3367 RVA: 0x000087FE File Offset: 0x000069FE
			public unsafe List<Command> animationCommands
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr_animationCommands);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr_animationCommands), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00033CDC File Offset: 0x00031EDC
			// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000881D File Offset: 0x00006A1D
			public unsafe VoodooGenericSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGenericSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000D2A RID: 3370 RVA: 0x00033D0C File Offset: 0x00031F0C
			// (set) Token: 0x06000D2B RID: 3371 RVA: 0x0000883C File Offset: 0x00006A3C
			public List<Command>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___7__wrap1);
					return new List<Command>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00033D3C File Offset: 0x00031F3C
			// (set) Token: 0x06000D2D RID: 3373 RVA: 0x0000886A File Offset: 0x00006A6A
			public unsafe Command _command_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__command_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__command_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06000D2E RID: 3374 RVA: 0x00033D6C File Offset: 0x00031F6C
			// (set) Token: 0x06000D2F RID: 3375 RVA: 0x00008889 File Offset: 0x00006A89
			public unsafe IEnumerator _sequenceCommands_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__sequenceCommands_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimationCommands_d__16.NativeFieldInfoPtr__sequenceCommands_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000820 RID: 2080
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000821 RID: 2081
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000822 RID: 2082
			private static readonly IntPtr NativeFieldInfoPtr_animationCommands;

			// Token: 0x04000823 RID: 2083
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000824 RID: 2084
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000825 RID: 2085
			private static readonly IntPtr NativeFieldInfoPtr__command_5__3;

			// Token: 0x04000826 RID: 2086
			private static readonly IntPtr NativeFieldInfoPtr__sequenceCommands_5__4;

			// Token: 0x04000827 RID: 2087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000828 RID: 2088
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000829 RID: 2089
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400082A RID: 2090
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400082B RID: 2091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400082C RID: 2092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400082D RID: 2093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000101 RID: 257
		[ObfuscatedName("lotus.VoodooGenericSequence+<runAnimations>d__15")]
		public sealed class _runAnimations_d__15 : Object
		{
			// Token: 0x06000D30 RID: 3376 RVA: 0x00033D9C File Offset: 0x00031F9C
			// Note: this type is marked as 'beforefieldinit'.
			static _runAnimations_d__15()
			{
				Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<runAnimations>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr);
				VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, "<>1__state");
				VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, "<>2__current");
				VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, "<>4__this");
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664393);
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664394);
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664395);
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664396);
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664397);
				VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr, 100664398);
			}

			// Token: 0x06000D31 RID: 3377 RVA: 0x00033E7C File Offset: 0x0003207C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runAnimations_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence._runAnimations_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x00033EC4 File Offset: 0x000320C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00033EF8 File Offset: 0x000320F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115354, XrefRangeEnd = 1115355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00033F34 File Offset: 0x00032134
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x00033F74 File Offset: 0x00032174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115355, XrefRangeEnd = 1115360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00033FA8 File Offset: 0x000321A8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runAnimations_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x000088A8 File Offset: 0x00006AA8
			public _runAnimations_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00033FE8 File Offset: 0x000321E8
			// (set) Token: 0x06000D39 RID: 3385 RVA: 0x000088B1 File Offset: 0x00006AB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00034010 File Offset: 0x00032210
			// (set) Token: 0x06000D3B RID: 3387 RVA: 0x000088CC File Offset: 0x00006ACC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00034040 File Offset: 0x00032240
			// (set) Token: 0x06000D3D RID: 3389 RVA: 0x000088EB File Offset: 0x00006AEB
			public unsafe VoodooGenericSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGenericSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runAnimations_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400082E RID: 2094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400082F RID: 2095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000830 RID: 2096
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000831 RID: 2097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000832 RID: 2098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000833 RID: 2099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000834 RID: 2100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000835 RID: 2101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000836 RID: 2102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000102 RID: 258
		[ObfuscatedName("lotus.VoodooGenericSequence+<runSequenceCommands>d__17")]
		public sealed class _runSequenceCommands_d__17 : Object
		{
			// Token: 0x06000D3E RID: 3390 RVA: 0x00034070 File Offset: 0x00032270
			// Note: this type is marked as 'beforefieldinit'.
			static _runSequenceCommands_d__17()
			{
				Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VoodooGenericSequence>.NativeClassPtr, "<runSequenceCommands>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<>1__state");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<>2__current");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<>4__this");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr_animationCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "animationCommand");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<>7__wrap1");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<>7__wrap2");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr__sequenceCommand_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, "<sequenceCommand>5__4");
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664399);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664400);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664401);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664402);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664403);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664404);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664405);
				VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr, 100664406);
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x000341C8 File Offset: 0x000323C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runSequenceCommands_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooGenericSequence._runSequenceCommands_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x00034210 File Offset: 0x00032410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115360, XrefRangeEnd = 1115373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x00034244 File Offset: 0x00032444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115373, XrefRangeEnd = 1115403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D42 RID: 3394 RVA: 0x00034280 File Offset: 0x00032480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115403, XrefRangeEnd = 1115406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x000342B4 File Offset: 0x000324B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1115409, RefRangeEnd = 1115410, XrefRangeStart = 1115406, XrefRangeEnd = 1115409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000D44 RID: 3396 RVA: 0x000342E8 File Offset: 0x000324E8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x00034328 File Offset: 0x00032528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1115410, XrefRangeEnd = 1115415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000D46 RID: 3398 RVA: 0x0003435C File Offset: 0x0003255C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooGenericSequence._runSequenceCommands_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0000890A File Offset: 0x00006B0A
			public _runSequenceCommands_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0003439C File Offset: 0x0003259C
			// (set) Token: 0x06000D49 RID: 3401 RVA: 0x00008913 File Offset: 0x00006B13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000343C4 File Offset: 0x000325C4
			// (set) Token: 0x06000D4B RID: 3403 RVA: 0x0000892E File Offset: 0x00006B2E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000D4C RID: 3404 RVA: 0x000343F4 File Offset: 0x000325F4
			// (set) Token: 0x06000D4D RID: 3405 RVA: 0x0000894D File Offset: 0x00006B4D
			public unsafe VoodooGenericSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooGenericSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00034424 File Offset: 0x00032624
			// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0000896C File Offset: 0x00006B6C
			public unsafe Command animationCommand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr_animationCommand);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr_animationCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00034454 File Offset: 0x00032654
			// (set) Token: 0x06000D51 RID: 3409 RVA: 0x0000898B File Offset: 0x00006B8B
			public List<VoodooGenericSequence.SequenceGroupCommand>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap1);
					return new List<VoodooGenericSequence.SequenceGroupCommand>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<VoodooGenericSequence.SequenceGroupCommand>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<VoodooGenericSequence.SequenceGroupCommand>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00034484 File Offset: 0x00032684
			// (set) Token: 0x06000D53 RID: 3411 RVA: 0x000089B9 File Offset: 0x00006BB9
			public List<Command>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap2);
					return new List<Command>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000D54 RID: 3412 RVA: 0x000344B4 File Offset: 0x000326B4
			// (set) Token: 0x06000D55 RID: 3413 RVA: 0x000089E7 File Offset: 0x00006BE7
			public unsafe Command _sequenceCommand_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr__sequenceCommand_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooGenericSequence._runSequenceCommands_d__17.NativeFieldInfoPtr__sequenceCommand_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000837 RID: 2103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000838 RID: 2104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000839 RID: 2105
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400083A RID: 2106
			private static readonly IntPtr NativeFieldInfoPtr_animationCommand;

			// Token: 0x0400083B RID: 2107
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400083C RID: 2108
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400083D RID: 2109
			private static readonly IntPtr NativeFieldInfoPtr__sequenceCommand_5__4;

			// Token: 0x0400083E RID: 2110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400083F RID: 2111
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000840 RID: 2112
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000841 RID: 2113
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000842 RID: 2114
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000843 RID: 2115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000844 RID: 2116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000845 RID: 2117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
