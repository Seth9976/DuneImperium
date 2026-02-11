using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.commands
{
	// Token: 0x02000172 RID: 370
	public class SequenceCommands : Object
	{
		// Token: 0x06001547 RID: 5447 RVA: 0x000690C4 File Offset: 0x000672C4
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCommands()
		{
			Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "SequenceCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr);
			SequenceCommands.NativeFieldInfoPtr_expectedParamTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, "expectedParamTypes");
			SequenceCommands.NativeFieldInfoPtr_transLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, "transLookup");
			SequenceCommands.NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Create_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666509);
			SequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666510);
			SequenceCommands.NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Generic_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666511);
			SequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666512);
			SequenceCommands.NativeMethodInfoPtr_GetCommand_Public_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666513);
			SequenceCommands.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666514);
			SequenceCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666515);
			SequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr, 100666516);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x000691BC File Offset: 0x000673BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875951, XrefRangeEnd = 875952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SequenceCommand dwd_core_match_sequence_commands_ISequenceToCommandFactory_Create(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence, bool isRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Create_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00069254 File Offset: 0x00067454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875952, XrefRangeEnd = 875953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SequenceCommand Create(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence, bool isRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000692F4 File Offset: 0x000674F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875953, XrefRangeEnd = 875954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SequenceCommand dwd_core_match_sequence_commands_ISequenceToCommandFactory_Generic(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Generic_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0006937C File Offset: 0x0006757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875954, XrefRangeEnd = 875958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SequenceCommand Generic(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00069410 File Offset: 0x00067610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 875978, RefRangeEnd = 875981, XrefRangeStart = 875958, XrefRangeEnd = 875978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCommand GetCommand(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr_GetCommand_Public_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00069498 File Offset: 0x00067698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875981, XrefRangeEnd = 876023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr_Reset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x000694C0 File Offset: 0x000676C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 876126, RefRangeEnd = 876127, XrefRangeStart = 876023, XrefRangeEnd = 876126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IEnumerable<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x000694F8 File Offset: 0x000676F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCommands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCommands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0000966C File Offset: 0x0000786C
		public SequenceCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00069534 File Offset: 0x00067734
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x00009675 File Offset: 0x00007875
		public unsafe static Il2CppReferenceArray<Type> expectedParamTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SequenceCommands.NativeFieldInfoPtr_expectedParamTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SequenceCommands.NativeFieldInfoPtr_expectedParamTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0006955C File Offset: 0x0006775C
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x00009687 File Offset: 0x00007887
		public unsafe static ReadOnlyDictionary<string, Func<Il2CppReferenceArray<Object>, Object>> transLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SequenceCommands.NativeFieldInfoPtr_transLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<string, Func<Il2CppReferenceArray<Object>, Object>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SequenceCommands.NativeFieldInfoPtr_transLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_expectedParamTypes;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_transLookup;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Create_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_sequence_commands_ISequenceToCommandFactory_Generic_Private_Virtual_Final_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_Generic_Protected_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_IEnumerable_1_Type_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
