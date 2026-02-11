using System;
using Canis.messages;
using dwd.core.commands;
using dwd.core.match.sequence;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core
{
	// Token: 0x02000007 RID: 7
	public class SequenceCommandFactory : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00004C8C File Offset: 0x00002E8C
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCommandFactory()
		{
			Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core", "SequenceCommandFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr);
			SequenceCommandFactory.NativeFieldInfoPtr_sequenceFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, "sequenceFactory");
			SequenceCommandFactory.NativeFieldInfoPtr_messageFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, "messageFactory");
			SequenceCommandFactory.NativeFieldInfoPtr_WarnOnCollapse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, "WarnOnCollapse");
			SequenceCommandFactory.NativeFieldInfoPtr_WarnOnGenericSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, "WarnOnGenericSequence");
			SequenceCommandFactory.NativeMethodInfoPtr__ctor_Public_Void_ISequenceToCommandFactory_IMessageToCommandFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, 100663304);
			SequenceCommandFactory.NativeMethodInfoPtr_GetCommand_Public_Command_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, 100663305);
			SequenceCommandFactory.NativeMethodInfoPtr_parseChildIntoList_Private_Void_SequenceElement_List_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, 100663306);
			SequenceCommandFactory.NativeMethodInfoPtr_parseSequence_Private_Command_MatchSequence_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, 100663307);
			SequenceCommandFactory.NativeMethodInfoPtr_parseMessage_Private_Command_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004D70 File Offset: 0x00002F70
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCommandFactory(ISequenceToCommandFactory sequenceFactory, IMessageToCommandFactory messageFactory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCommandFactory>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequenceFactory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageFactory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandFactory.NativeMethodInfoPtr__ctor_Public_Void_ISequenceToCommandFactory_IMessageToCommandFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205817, RefRangeEnd = 1205819, XrefRangeStart = 1205766, XrefRangeEnd = 1205817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetCommand(SequenceElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandFactory.NativeMethodInfoPtr_GetCommand_Public_Command_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004E20 File Offset: 0x00003020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205833, RefRangeEnd = 1205834, XrefRangeStart = 1205819, XrefRangeEnd = 1205833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void parseChildIntoList(SequenceElement element, List<Command> commands)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commands);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandFactory.NativeMethodInfoPtr_parseChildIntoList_Private_Void_SequenceElement_List_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004E74 File Offset: 0x00003074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1205837, RefRangeEnd = 1205838, XrefRangeStart = 1205834, XrefRangeEnd = 1205837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command parseSequence(MatchSequence sequence, IList<Command> children, bool isRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(children);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandFactory.NativeMethodInfoPtr_parseSequence_Private_Command_MatchSequence_IList_1_Command_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004EE4 File Offset: 0x000030E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1205849, RefRangeEnd = 1205851, XrefRangeStart = 1205838, XrefRangeEnd = 1205849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command parseMessage(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandFactory.NativeMethodInfoPtr_parseMessage_Private_Command_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002129 File Offset: 0x00000329
		public SequenceCommandFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00004F34 File Offset: 0x00003134
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002132 File Offset: 0x00000332
		public unsafe ISequenceToCommandFactory sequenceFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_sequenceFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISequenceToCommandFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_sequenceFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00004F64 File Offset: 0x00003164
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002151 File Offset: 0x00000351
		public unsafe IMessageToCommandFactory messageFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_messageFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageToCommandFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_messageFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002170 File Offset: 0x00000370
		public unsafe bool WarnOnCollapse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_WarnOnCollapse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_WarnOnCollapse)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004FBC File Offset: 0x000031BC
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000218B File Offset: 0x0000038B
		public unsafe bool WarnOnGenericSequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_WarnOnGenericSequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandFactory.NativeFieldInfoPtr_WarnOnGenericSequence)) = value;
			}
		}

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_sequenceFactory;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_messageFactory;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_WarnOnCollapse;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_WarnOnGenericSequence;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISequenceToCommandFactory_IMessageToCommandFactory_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetCommand_Public_Command_SequenceElement_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_parseChildIntoList_Private_Void_SequenceElement_List_1_Command_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_parseSequence_Private_Command_MatchSequence_IList_1_Command_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_parseMessage_Private_Command_IGameMessage_0;
	}
}
