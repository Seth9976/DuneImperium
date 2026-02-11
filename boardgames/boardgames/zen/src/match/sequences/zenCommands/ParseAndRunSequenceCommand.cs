using System;
using System.Runtime.InteropServices;
using dwd.core.commands;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace zen.src.match.sequences.zenCommands
{
	// Token: 0x02000066 RID: 102
	public class ParseAndRunSequenceCommand : Command
	{
		// Token: 0x06000539 RID: 1337 RVA: 0x000206D4 File Offset: 0x0001E8D4
		// Note: this type is marked as 'beforefieldinit'.
		static ParseAndRunSequenceCommand()
		{
			Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences.zenCommands", "ParseAndRunSequenceCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr);
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_groupMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "groupMoves");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "output");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_introduces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "introduces");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_moves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "moves");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "sequence");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_vm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "vm");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "entitiesProvider");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "sequenceName");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentContextSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "currentContextSignal");
			ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentSubCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "currentSubCommand");
			ParseAndRunSequenceCommand.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664045);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664046);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664047);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_addGroupMove_Private_Void_VoodooMoveCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664048);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664049);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_contextForCommand_Private_Int32_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664050);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_addToCommand_Private_Void_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664051);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_isMoveRedundant_Private_Boolean_VoodooEntityMovedCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664052);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_createCommandFor_Private_VoodooMoveCommand_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664053);
			ParseAndRunSequenceCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, 100664054);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00020894 File Offset: 0x0001EA94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 987018, RefRangeEnd = 987022, XrefRangeStart = 986979, XrefRangeEnd = 987018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseAndRunSequenceCommand(IEnumerable<Command> sequence, string sn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000208F4 File Offset: 0x0001EAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987022, XrefRangeEnd = 987023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseAndRunSequenceCommand(string sn, [Optional] Il2CppReferenceArray<Command> sequence)
		{
			if (sequence == null)
			{
				sequence = new Il2CppReferenceArray<Command>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00020960 File Offset: 0x0001EB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987023, XrefRangeEnd = 987028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParseAndRunSequenceCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000209AC File Offset: 0x0001EBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 987036, RefRangeEnd = 987037, XrefRangeStart = 987028, XrefRangeEnd = 987036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addGroupMove(VoodooMoveCommand groupMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupMove);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr_addGroupMove_Private_Void_VoodooMoveCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000209F0 File Offset: 0x0001EBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987037, XrefRangeEnd = 987042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator executeGroupMoves()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParseAndRunSequenceCommand.NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00020A3C File Offset: 0x0001EC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 987065, RefRangeEnd = 987066, XrefRangeStart = 987042, XrefRangeEnd = 987065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int contextForCommand(Command c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr_contextForCommand_Private_Int32_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00020A8C File Offset: 0x0001EC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 987090, RefRangeEnd = 987091, XrefRangeStart = 987066, XrefRangeEnd = 987090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addToCommand(Command c, Command groupMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groupMove);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr_addToCommand_Private_Void_Command_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 987098, RefRangeEnd = 987100, XrefRangeStart = 987091, XrefRangeEnd = 987098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isMoveRedundant(VoodooEntityMovedCommand emc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(emc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr_isMoveRedundant_Private_Boolean_VoodooEntityMovedCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00020B30 File Offset: 0x0001ED30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 987182, RefRangeEnd = 987184, XrefRangeStart = 987100, XrefRangeEnd = 987182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooMoveCommand createCommandFor(Command c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand.NativeMethodInfoPtr_createCommandFor_Private_VoodooMoveCommand_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr3) : null;
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00020B80 File Offset: 0x0001ED80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987184, XrefRangeEnd = 987202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParseAndRunSequenceCommand.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000046D1 File Offset: 0x000028D1
		public ParseAndRunSequenceCommand(string sn, params Command[] sequence)
			: this(sn, new Il2CppReferenceArray<Command>(sequence))
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000046E0 File Offset: 0x000028E0
		public ParseAndRunSequenceCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00020BC4 File Offset: 0x0001EDC4
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x000046E9 File Offset: 0x000028E9
		public unsafe List<VoodooMoveCommand> groupMoves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_groupMoves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VoodooMoveCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_groupMoves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004708 File Offset: 0x00002908
		public unsafe List<Command> output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00020C24 File Offset: 0x0001EE24
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00004727 File Offset: 0x00002927
		public unsafe List<EntitiesIntroducedGroupCommand> introduces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_introduces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntitiesIntroducedGroupCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_introduces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00020C54 File Offset: 0x0001EE54
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00004746 File Offset: 0x00002946
		public unsafe List<EntitiesMovedGroupCommand> moves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_moves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntitiesMovedGroupCommand>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_moves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00020C84 File Offset: 0x0001EE84
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00004765 File Offset: 0x00002965
		public unsafe IEnumerable<Command> sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Command>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00004784 File Offset: 0x00002984
		public unsafe ViewManager vm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_vm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_vm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00020CE4 File Offset: 0x0001EEE4
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x000047A3 File Offset: 0x000029A3
		public unsafe EntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00020D14 File Offset: 0x0001EF14
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x000047C2 File Offset: 0x000029C2
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00020D3C File Offset: 0x0001EF3C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x000047E1 File Offset: 0x000029E1
		public unsafe int currentContextSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentContextSignal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentContextSignal)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00020D64 File Offset: 0x0001EF64
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x000047FC File Offset: 0x000029FC
		public unsafe Command currentSubCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentSubCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand.NativeFieldInfoPtr_currentSubCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_groupMoves;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_introduces;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_moves;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_sequence;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_vm;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_currentContextSignal;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_currentSubCommand;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Command_String_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Command_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_addGroupMove_Private_Void_VoodooMoveCommand_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_executeGroupMoves_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_contextForCommand_Private_Int32_Command_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_addToCommand_Private_Void_Command_Command_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_isMoveRedundant_Private_Boolean_VoodooEntityMovedCommand_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_createCommandFor_Private_VoodooMoveCommand_Command_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020001D5 RID: 469
		[ObfuscatedName("zen.src.match.sequences.zenCommands.ParseAndRunSequenceCommand+<execute>d__12")]
		public sealed class _execute_d__12 : Object
		{
			// Token: 0x06001652 RID: 5714 RVA: 0x00055FDC File Offset: 0x000541DC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__12()
			{
				Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "<execute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr);
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<>1__state");
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<>2__current");
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<>4__this");
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__groupMove_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<groupMove>5__2");
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<>7__wrap2");
				ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__c_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, "<c>5__4");
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664055);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664056);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664057);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664058);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664059);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664060);
				ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr, 100664061);
			}

			// Token: 0x06001653 RID: 5715 RVA: 0x0005610C File Offset: 0x0005430C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunSequenceCommand._execute_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001654 RID: 5716 RVA: 0x00056154 File Offset: 0x00054354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986836, XrefRangeEnd = 986841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001655 RID: 5717 RVA: 0x00056188 File Offset: 0x00054388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986841, XrefRangeEnd = 986939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001656 RID: 5718 RVA: 0x000561C4 File Offset: 0x000543C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986939, XrefRangeEnd = 986942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000673 RID: 1651
			// (get) Token: 0x06001657 RID: 5719 RVA: 0x000561F8 File Offset: 0x000543F8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001658 RID: 5720 RVA: 0x00056238 File Offset: 0x00054438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986942, XrefRangeEnd = 986947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000674 RID: 1652
			// (get) Token: 0x06001659 RID: 5721 RVA: 0x0005626C File Offset: 0x0005446C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600165A RID: 5722 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
			public _execute_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x0600165B RID: 5723 RVA: 0x000562AC File Offset: 0x000544AC
			// (set) Token: 0x0600165C RID: 5724 RVA: 0x0000C6ED File Offset: 0x0000A8ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x0600165D RID: 5725 RVA: 0x000562D4 File Offset: 0x000544D4
			// (set) Token: 0x0600165E RID: 5726 RVA: 0x0000C708 File Offset: 0x0000A908
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x0600165F RID: 5727 RVA: 0x00056304 File Offset: 0x00054504
			// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000C727 File Offset: 0x0000A927
			public unsafe ParseAndRunSequenceCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseAndRunSequenceCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001661 RID: 5729 RVA: 0x00056334 File Offset: 0x00054534
			// (set) Token: 0x06001662 RID: 5730 RVA: 0x0000C746 File Offset: 0x0000A946
			public unsafe VoodooMoveCommand _groupMove_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__groupMove_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooMoveCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__groupMove_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000671 RID: 1649
			// (get) Token: 0x06001663 RID: 5731 RVA: 0x00056364 File Offset: 0x00054564
			// (set) Token: 0x06001664 RID: 5732 RVA: 0x0000C765 File Offset: 0x0000A965
			public unsafe IEnumerator<Command> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Command>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000672 RID: 1650
			// (get) Token: 0x06001665 RID: 5733 RVA: 0x00056394 File Offset: 0x00054594
			// (set) Token: 0x06001666 RID: 5734 RVA: 0x0000C784 File Offset: 0x0000A984
			public unsafe Command _c_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__c_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._execute_d__12.NativeFieldInfoPtr__c_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000D8D RID: 3469
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D8E RID: 3470
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D8F RID: 3471
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D90 RID: 3472
			private static readonly IntPtr NativeFieldInfoPtr__groupMove_5__2;

			// Token: 0x04000D91 RID: 3473
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04000D92 RID: 3474
			private static readonly IntPtr NativeFieldInfoPtr__c_5__4;

			// Token: 0x04000D93 RID: 3475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D94 RID: 3476
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D95 RID: 3477
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D96 RID: 3478
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000D97 RID: 3479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D98 RID: 3480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D99 RID: 3481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001D6 RID: 470
		[ObfuscatedName("zen.src.match.sequences.zenCommands.ParseAndRunSequenceCommand+<executeGroupMoves>d__14")]
		public sealed class _executeGroupMoves_d__14 : Object
		{
			// Token: 0x06001667 RID: 5735 RVA: 0x000563C4 File Offset: 0x000545C4
			// Note: this type is marked as 'beforefieldinit'.
			static _executeGroupMoves_d__14()
			{
				Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParseAndRunSequenceCommand>.NativeClassPtr, "<executeGroupMoves>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, "<>1__state");
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, "<>2__current");
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, "<>4__this");
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, "<>7__wrap1");
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664062);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664063);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664064);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664065);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664066);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664067);
				ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr, 100664068);
			}

			// Token: 0x06001668 RID: 5736 RVA: 0x000564CC File Offset: 0x000546CC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _executeGroupMoves_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseAndRunSequenceCommand._executeGroupMoves_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001669 RID: 5737 RVA: 0x00056514 File Offset: 0x00054714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986947, XrefRangeEnd = 986952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600166A RID: 5738 RVA: 0x00056548 File Offset: 0x00054748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986952, XrefRangeEnd = 986971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600166B RID: 5739 RVA: 0x00056584 File Offset: 0x00054784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986971, XrefRangeEnd = 986974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000679 RID: 1657
			// (get) Token: 0x0600166C RID: 5740 RVA: 0x000565B8 File Offset: 0x000547B8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600166D RID: 5741 RVA: 0x000565F8 File Offset: 0x000547F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986974, XrefRangeEnd = 986979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700067A RID: 1658
			// (get) Token: 0x0600166E RID: 5742 RVA: 0x0005662C File Offset: 0x0005482C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x0000C7A3 File Offset: 0x0000A9A3
			public _executeGroupMoves_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000675 RID: 1653
			// (get) Token: 0x06001670 RID: 5744 RVA: 0x0005666C File Offset: 0x0005486C
			// (set) Token: 0x06001671 RID: 5745 RVA: 0x0000C7AC File Offset: 0x0000A9AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001672 RID: 5746 RVA: 0x00056694 File Offset: 0x00054894
			// (set) Token: 0x06001673 RID: 5747 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000677 RID: 1655
			// (get) Token: 0x06001674 RID: 5748 RVA: 0x000566C4 File Offset: 0x000548C4
			// (set) Token: 0x06001675 RID: 5749 RVA: 0x0000C7E6 File Offset: 0x0000A9E6
			public unsafe ParseAndRunSequenceCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseAndRunSequenceCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000678 RID: 1656
			// (get) Token: 0x06001676 RID: 5750 RVA: 0x000566F4 File Offset: 0x000548F4
			// (set) Token: 0x06001677 RID: 5751 RVA: 0x0000C805 File Offset: 0x0000AA05
			public List<Command>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___7__wrap1);
					return new List<Command>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseAndRunSequenceCommand._executeGroupMoves_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Command>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000D9A RID: 3482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D9B RID: 3483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D9C RID: 3484
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D9D RID: 3485
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000D9E RID: 3486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D9F RID: 3487
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DA0 RID: 3488
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000DA1 RID: 3489
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000DA2 RID: 3490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000DA3 RID: 3491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000DA4 RID: 3492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
