using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000256 RID: 598
	public class WormPlayCardTrashSelfSequence : WormStingerSequence
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x0000ED95 File Offset: 0x0000CF95
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayCardTrashSelfSequence()
		{
			Il2CppClassPointerStore<WormPlayCardTrashSelfSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormPlayCardTrashSelfSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayCardTrashSelfSequence>.NativeClassPtr);
			WormPlayCardTrashSelfSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayCardTrashSelfSequence>.NativeClassPtr, 100666864);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00064784 File Offset: 0x00062984
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayCardTrashSelfSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayCardTrashSelfSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayCardTrashSelfSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		public WormPlayCardTrashSelfSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
