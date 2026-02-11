using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace worm.client.match.render
{
	// Token: 0x0200029F RID: 671
	public class WormVoodooGroupedSequence : VoodooGroupedSequence
	{
		// Token: 0x06001B4B RID: 6987 RVA: 0x0006BF14 File Offset: 0x0006A114
		// Note: this type is marked as 'beforefieldinit'.
		static WormVoodooGroupedSequence()
		{
			Il2CppClassPointerStore<WormVoodooGroupedSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormVoodooGroupedSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVoodooGroupedSequence>.NativeClassPtr);
			WormVoodooGroupedSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupedSequence>.NativeClassPtr, 100667273);
			WormVoodooGroupedSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooGroupedSequence>.NativeClassPtr, 100667274);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0006BF6C File Offset: 0x0006A16C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVoodooGroupedSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooGroupedSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooGroupedSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0006BFDC File Offset: 0x0006A1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724419, XrefRangeEnd = 724422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override VoodooGroupCommand CreateGroupCommand(Command command, VoodooGroupCommand.GroupInitInfo groupInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(groupInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVoodooGroupedSequence.NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoodooGroupCommand>(intPtr3) : null;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0000FCBB File Offset: 0x0000DEBB
		public WormVoodooGroupedSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_CreateGroupCommand_Protected_Virtual_VoodooGroupCommand_Command_GroupInitInfo_0;
	}
}
