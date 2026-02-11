using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000246 RID: 582
	public class WormDiscardCardsSequence : WormStingerSequence
	{
		// Token: 0x060018E5 RID: 6373 RVA: 0x0000EA84 File Offset: 0x0000CC84
		// Note: this type is marked as 'beforefieldinit'.
		static WormDiscardCardsSequence()
		{
			Il2CppClassPointerStore<WormDiscardCardsSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormDiscardCardsSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardCardsSequence>.NativeClassPtr);
			WormDiscardCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardCardsSequence>.NativeClassPtr, 100666824);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00063D28 File Offset: 0x00061F28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDiscardCardsSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardCardsSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0000EABD File Offset: 0x0000CCBD
		public WormDiscardCardsSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
