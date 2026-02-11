using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000263 RID: 611
	public class WormTleilaxuTrackNoRewardsSequence : WormTleilaxuTrackBaseSequence
	{
		// Token: 0x06001952 RID: 6482 RVA: 0x0000EF7C File Offset: 0x0000D17C
		// Note: this type is marked as 'beforefieldinit'.
		static WormTleilaxuTrackNoRewardsSequence()
		{
			Il2CppClassPointerStore<WormTleilaxuTrackNoRewardsSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormTleilaxuTrackNoRewardsSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTleilaxuTrackNoRewardsSequence>.NativeClassPtr);
			WormTleilaxuTrackNoRewardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTleilaxuTrackNoRewardsSequence>.NativeClassPtr, 100666920);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00065370 File Offset: 0x00063570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTleilaxuTrackNoRewardsSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTleilaxuTrackNoRewardsSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTleilaxuTrackNoRewardsSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0000EFB5 File Offset: 0x0000D1B5
		public WormTleilaxuTrackNoRewardsSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
