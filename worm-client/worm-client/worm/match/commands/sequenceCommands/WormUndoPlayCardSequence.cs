using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000266 RID: 614
	public class WormUndoPlayCardSequence : WormStingerSequence
	{
		// Token: 0x06001964 RID: 6500 RVA: 0x0000F025 File Offset: 0x0000D225
		// Note: this type is marked as 'beforefieldinit'.
		static WormUndoPlayCardSequence()
		{
			Il2CppClassPointerStore<WormUndoPlayCardSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormUndoPlayCardSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUndoPlayCardSequence>.NativeClassPtr);
			WormUndoPlayCardSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoPlayCardSequence>.NativeClassPtr, 100666932);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0006571C File Offset: 0x0006391C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUndoPlayCardSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUndoPlayCardSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoPlayCardSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0000F05E File Offset: 0x0000D25E
		public WormUndoPlayCardSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
