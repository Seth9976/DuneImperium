using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.sequenceCommands
{
	// Token: 0x02000250 RID: 592
	public class WormIntrigueRefillDeckSequence : WormStingerSequence
	{
		// Token: 0x06001908 RID: 6408 RVA: 0x000643A4 File Offset: 0x000625A4
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntrigueRefillDeckSequence()
		{
			Il2CppClassPointerStore<WormIntrigueRefillDeckSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.sequenceCommands", "WormIntrigueRefillDeckSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueRefillDeckSequence>.NativeClassPtr);
			WormIntrigueRefillDeckSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueRefillDeckSequence>.NativeClassPtr, 100666856);
			WormIntrigueRefillDeckSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueRefillDeckSequence>.NativeClassPtr, 100666857);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000643FC File Offset: 0x000625FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 719323, RefRangeEnd = 719327, XrefRangeStart = 719323, XrefRangeEnd = 719327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntrigueRefillDeckSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueRefillDeckSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueRefillDeckSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0006446C File Offset: 0x0006266C
		public unsafe override bool OnlyShowOpponents
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueRefillDeckSequence.NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0000EC7B File Offset: 0x0000CE7B
		public WormIntrigueRefillDeckSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_get_OnlyShowOpponents_Protected_Virtual_get_Boolean_0;
	}
}
