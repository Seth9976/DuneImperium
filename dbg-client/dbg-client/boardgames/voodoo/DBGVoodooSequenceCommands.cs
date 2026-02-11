using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.commands;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.voodoo
{
	// Token: 0x020000EA RID: 234
	public class DBGVoodooSequenceCommands : SequenceCommands
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x0003D668 File Offset: 0x0003B868
		// Note: this type is marked as 'beforefieldinit'.
		static DBGVoodooSequenceCommands()
		{
			Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.voodoo", "DBGVoodooSequenceCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr);
			DBGVoodooSequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr, 100664768);
			DBGVoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr, 100664769);
			DBGVoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr, 100664770);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506626, XrefRangeEnd = 506627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SequenceCommand Create(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence, bool isRoot)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGVoodooSequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0003D774 File Offset: 0x0003B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506627, XrefRangeEnd = 506631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SequenceCommand Generic(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGVoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0003D808 File Offset: 0x0003BA08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 506635, RefRangeEnd = 506638, XrefRangeStart = 506631, XrefRangeEnd = 506635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGVoodooSequenceCommands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGVoodooSequenceCommands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGVoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00006DD5 File Offset: 0x00004FD5
		public DBGVoodooSequenceCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
