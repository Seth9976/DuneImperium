using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.sequence.commands
{
	// Token: 0x0200000C RID: 12
	public class ISequenceToCommandFactory : Il2CppObjectBase
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000058A0 File Offset: 0x00003AA0
		// Note: this type is marked as 'beforefieldinit'.
		static ISequenceToCommandFactory()
		{
			Il2CppClassPointerStore<ISequenceToCommandFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-commands.dll", "dwd.core.match.sequence.commands", "ISequenceToCommandFactory");
			ISequenceToCommandFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceToCommandFactory>.NativeClassPtr, 100663329);
			ISequenceToCommandFactory.NativeMethodInfoPtr_Generic_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISequenceToCommandFactory>.NativeClassPtr, 100663330);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000058F0 File Offset: 0x00003AF0
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISequenceToCommandFactory.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005990 File Offset: 0x00003B90
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISequenceToCommandFactory.NativeMethodInfoPtr_Generic_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002308 File Offset: 0x00000508
		public ISequenceToCommandFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_Generic_Public_Abstract_Virtual_New_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;
	}
}
