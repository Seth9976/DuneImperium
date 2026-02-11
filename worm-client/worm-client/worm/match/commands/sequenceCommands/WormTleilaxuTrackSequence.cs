using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000262 RID: 610
	public class WormTleilaxuTrackSequence : WormTleilaxuTrackBaseSequence
	{
		// Token: 0x0600194F RID: 6479 RVA: 0x0000EF3A File Offset: 0x0000D13A
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxuTrackSequence()
		{
			Il2CppClassPointerStore<WormTleilaxuTrackSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormTleilaxuTrackSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrackSequence>.NativeClassPtr);
			WormTleilaxuTrackSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackSequence>.NativeClassPtr, 100666919);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00065300 File Offset: 0x00063500
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxuTrackSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrackSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0000EF73 File Offset: 0x0000D173
		public WormTleilaxuTrackSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
