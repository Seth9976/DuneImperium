using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000243 RID: 579
	public class WormAgentAbilitySequence : WormStingerSequence
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x0000EA30 File Offset: 0x0000CC30
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgentAbilitySequence()
		{
			Il2CppClassPointerStore<WormAgentAbilitySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormAgentAbilitySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentAbilitySequence>.NativeClassPtr);
			WormAgentAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentAbilitySequence>.NativeClassPtr, 100666808);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00063A94 File Offset: 0x00061C94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719322, XrefRangeEnd = 719323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgentAbilitySequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentAbilitySequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0000EA69 File Offset: 0x0000CC69
		public WormAgentAbilitySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
