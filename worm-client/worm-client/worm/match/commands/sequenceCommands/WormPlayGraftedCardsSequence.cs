using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000258 RID: 600
	public class WormPlayGraftedCardsSequence : WormStingerSequence
	{
		// Token: 0x06001924 RID: 6436 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayGraftedCardsSequence()
		{
			Il2CppClassPointerStore<WormPlayGraftedCardsSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormPlayGraftedCardsSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayGraftedCardsSequence>.NativeClassPtr);
			WormPlayGraftedCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayGraftedCardsSequence>.NativeClassPtr, 100666868);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00064960 File Offset: 0x00062B60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayGraftedCardsSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayGraftedCardsSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayGraftedCardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0000EE19 File Offset: 0x0000D019
		public WormPlayGraftedCardsSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
