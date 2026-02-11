using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200024D RID: 589
	public class WormHagalRefillDeckSequence : WormStingerSequence
	{
		// Token: 0x060018FE RID: 6398 RVA: 0x0000EBEE File Offset: 0x0000CDEE
		// Note: this type is marked as 'beforefieldinit'.
		static WormHagalRefillDeckSequence()
		{
			Il2CppClassPointerStore<WormHagalRefillDeckSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormHagalRefillDeckSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHagalRefillDeckSequence>.NativeClassPtr);
			WormHagalRefillDeckSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHagalRefillDeckSequence>.NativeClassPtr, 100666846);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x000641B0 File Offset: 0x000623B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHagalRefillDeckSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHagalRefillDeckSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHagalRefillDeckSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0000EC27 File Offset: 0x0000CE27
		public WormHagalRefillDeckSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
