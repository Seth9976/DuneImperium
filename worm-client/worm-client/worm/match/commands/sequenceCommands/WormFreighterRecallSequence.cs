using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200024A RID: 586
	public class WormFreighterRecallSequence : WormStingerSequence
	{
		// Token: 0x060018F2 RID: 6386 RVA: 0x0000EB53 File Offset: 0x0000CD53
		// Note: this type is marked as 'beforefieldinit'.
		static WormFreighterRecallSequence()
		{
			Il2CppClassPointerStore<WormFreighterRecallSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormFreighterRecallSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFreighterRecallSequence>.NativeClassPtr);
			WormFreighterRecallSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFreighterRecallSequence>.NativeClassPtr, 100666835);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00063F8C File Offset: 0x0006218C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFreighterRecallSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFreighterRecallSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFreighterRecallSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		public WormFreighterRecallSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
