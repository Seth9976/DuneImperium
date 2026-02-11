using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200025B RID: 603
	public class WormRevealAbilitySequence : WormStingerSequence
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x0000EE6D File Offset: 0x0000D06D
		// Note: this type is marked as 'beforefieldinit'.
		static WormRevealAbilitySequence()
		{
			Il2CppClassPointerStore<WormRevealAbilitySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormRevealAbilitySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRevealAbilitySequence>.NativeClassPtr);
			WormRevealAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRevealAbilitySequence>.NativeClassPtr, 100666872);
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00064B4C File Offset: 0x00062D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRevealAbilitySequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRevealAbilitySequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRevealAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0000EEA6 File Offset: 0x0000D0A6
		public WormRevealAbilitySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
