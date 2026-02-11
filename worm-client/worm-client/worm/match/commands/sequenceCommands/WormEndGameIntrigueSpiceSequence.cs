using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000249 RID: 585
	public class WormEndGameIntrigueSpiceSequence : WormEndGameIntrigueSequence
	{
		// Token: 0x060018EF RID: 6383 RVA: 0x0000EB11 File Offset: 0x0000CD11
		// Note: this type is marked as 'beforefieldinit'.
		static WormEndGameIntrigueSpiceSequence()
		{
			Il2CppClassPointerStore<WormEndGameIntrigueSpiceSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormEndGameIntrigueSpiceSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEndGameIntrigueSpiceSequence>.NativeClassPtr);
			WormEndGameIntrigueSpiceSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndGameIntrigueSpiceSequence>.NativeClassPtr, 100666834);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00063F1C File Offset: 0x0006211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEndGameIntrigueSpiceSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEndGameIntrigueSpiceSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndGameIntrigueSpiceSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0000EB4A File Offset: 0x0000CD4A
		public WormEndGameIntrigueSpiceSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
