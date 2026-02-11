using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.match.commands.sequenceCommands;

namespace worm
{
	// Token: 0x02000039 RID: 57
	public class WormAcquireCardRecliamedForcesSequence : WormStingerSequence
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000330D File Offset: 0x0000150D
		// Note: this type is marked as 'beforefieldinit'.
		static WormAcquireCardRecliamedForcesSequence()
		{
			Il2CppClassPointerStore<WormAcquireCardRecliamedForcesSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormAcquireCardRecliamedForcesSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAcquireCardRecliamedForcesSequence>.NativeClassPtr);
			WormAcquireCardRecliamedForcesSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAcquireCardRecliamedForcesSequence>.NativeClassPtr, 100663718);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00020D14 File Offset: 0x0001EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 690419, XrefRangeEnd = 690420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAcquireCardRecliamedForcesSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAcquireCardRecliamedForcesSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAcquireCardRecliamedForcesSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003346 File Offset: 0x00001546
		public WormAcquireCardRecliamedForcesSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;
	}
}
