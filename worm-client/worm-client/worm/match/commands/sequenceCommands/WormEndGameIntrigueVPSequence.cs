using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000248 RID: 584
	public class WormEndGameIntrigueVPSequence : WormEndGameIntrigueSequence
	{
		// Token: 0x060018EC RID: 6380 RVA: 0x0000EACF File Offset: 0x0000CCCF
		// Note: this type is marked as 'beforefieldinit'.
		static WormEndGameIntrigueVPSequence()
		{
			Il2CppClassPointerStore<WormEndGameIntrigueVPSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormEndGameIntrigueVPSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEndGameIntrigueVPSequence>.NativeClassPtr);
			WormEndGameIntrigueVPSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEndGameIntrigueVPSequence>.NativeClassPtr, 100666833);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00063EAC File Offset: 0x000620AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEndGameIntrigueVPSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEndGameIntrigueVPSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEndGameIntrigueVPSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0000EB08 File Offset: 0x0000CD08
		public WormEndGameIntrigueVPSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
