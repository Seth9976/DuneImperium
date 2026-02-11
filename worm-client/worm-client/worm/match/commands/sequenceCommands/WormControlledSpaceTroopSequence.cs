using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000245 RID: 581
	public class WormControlledSpaceTroopSequence : WormStingerSequence
	{
		// Token: 0x060018E1 RID: 6369 RVA: 0x00063C18 File Offset: 0x00061E18
		// Note: this type is marked as 'beforefieldinit'.
		static WormControlledSpaceTroopSequence()
		{
			Il2CppClassPointerStore<WormControlledSpaceTroopSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormControlledSpaceTroopSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormControlledSpaceTroopSequence>.NativeClassPtr);
			WormControlledSpaceTroopSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlledSpaceTroopSequence>.NativeClassPtr, 100666822);
			WormControlledSpaceTroopSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormControlledSpaceTroopSequence>.NativeClassPtr, 100666823);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00063C70 File Offset: 0x00061E70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormControlledSpaceTroopSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormControlledSpaceTroopSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormControlledSpaceTroopSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00063CE0 File Offset: 0x00061EE0
		public unsafe override bool OnlyShowOpponents
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormControlledSpaceTroopSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0000EA7B File Offset: 0x0000CC7B
		public WormControlledSpaceTroopSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0;
	}
}
