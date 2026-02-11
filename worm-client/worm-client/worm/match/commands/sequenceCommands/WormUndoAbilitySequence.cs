using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000265 RID: 613
	public class WormUndoAbilitySequence : WormStingerSequence
	{
		// Token: 0x06001960 RID: 6496 RVA: 0x00065610 File Offset: 0x00063810
		// Note: this type is marked as 'beforefieldinit'.
		static WormUndoAbilitySequence()
		{
			Il2CppClassPointerStore<WormUndoAbilitySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormUndoAbilitySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUndoAbilitySequence>.NativeClassPtr);
			WormUndoAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoAbilitySequence>.NativeClassPtr, 100666930);
			WormUndoAbilitySequence.NativeMethodInfoPtr_get_StingerName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoAbilitySequence>.NativeClassPtr, 100666931);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00065668 File Offset: 0x00063868
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUndoAbilitySequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUndoAbilitySequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoAbilitySequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000656D8 File Offset: 0x000638D8
		public unsafe override string StingerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720130, XrefRangeEnd = 720142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUndoAbilitySequence.NativeMethodInfoPtr_get_StingerName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0000F01C File Offset: 0x0000D21C
		public WormUndoAbilitySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_get_StingerName_Protected_Virtual_get_String_0;
	}
}
