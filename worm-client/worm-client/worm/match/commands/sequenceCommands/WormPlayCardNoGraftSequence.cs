using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000254 RID: 596
	public class WormPlayCardNoGraftSequence : WormStingerSequence
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x0000ED11 File Offset: 0x0000CF11
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayCardNoGraftSequence()
		{
			Il2CppClassPointerStore<WormPlayCardNoGraftSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormPlayCardNoGraftSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayCardNoGraftSequence>.NativeClassPtr);
			WormPlayCardNoGraftSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayCardNoGraftSequence>.NativeClassPtr, 100666862);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000646A4 File Offset: 0x000628A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayCardNoGraftSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayCardNoGraftSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayCardNoGraftSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0000ED4A File Offset: 0x0000CF4A
		public WormPlayCardNoGraftSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
