using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using zen.src.match.sequences.zenCommands;

namespace zen.src.match.sequences.lotusCommands
{
	// Token: 0x02000068 RID: 104
	public class PassToPlayerSequence : VoodooSequence
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00022068 File Offset: 0x00020268
		// Note: this type is marked as 'beforefieldinit'.
		static PassToPlayerSequence()
		{
			Il2CppClassPointerStore<PassToPlayerSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences.lotusCommands", "PassToPlayerSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassToPlayerSequence>.NativeClassPtr);
			PassToPlayerSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerSequence>.NativeClassPtr, 100664192);
			PassToPlayerSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassToPlayerSequence>.NativeClassPtr, 100664193);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000220C0 File Offset: 0x000202C0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassToPlayerSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassToPlayerSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PassToPlayerSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00022130 File Offset: 0x00020330
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void build(SequenceBuilder sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PassToPlayerSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004862 File Offset: 0x00002A62
		public PassToPlayerSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0;
	}
}
