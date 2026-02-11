using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x0200025F RID: 607
	public class WormSignetAbilitySequence : WormStingerSequence
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x0000EEE6 File Offset: 0x0000D0E6
		// Note: this type is marked as 'beforefieldinit'.
		static WormSignetAbilitySequence()
		{
			Il2CppClassPointerStore<WormSignetAbilitySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormSignetAbilitySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSignetAbilitySequence>.NativeClassPtr);
			WormSignetAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSignetAbilitySequence>.NativeClassPtr, 100666899);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00064F58 File Offset: 0x00063158
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSignetAbilitySequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSignetAbilitySequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSignetAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0000EF1F File Offset: 0x0000D11F
		public WormSignetAbilitySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
