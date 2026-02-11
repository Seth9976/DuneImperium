using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using zen.src.match.sequences.zenCommands;

namespace zen.src.match.sequences
{
	// Token: 0x02000062 RID: 98
	public class GenericSequence : VoodooSequence
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x0002022C File Offset: 0x0001E42C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSequence()
		{
			Il2CppClassPointerStore<GenericSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.sequences", "GenericSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSequence>.NativeClassPtr);
			GenericSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSequence>.NativeClassPtr, 100664018);
			GenericSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSequence>.NativeClassPtr, 100664019);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00020284 File Offset: 0x0001E484
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 719643, RefRangeEnd = 719682, XrefRangeStart = 719643, XrefRangeEnd = 719682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSequence(SequenceID id, string name, IList<Command> sequence)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSequence>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSequence.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000202F4 File Offset: 0x0001E4F4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSequence.NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000046AD File Offset: 0x000028AD
		public GenericSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_String_IList_1_Command_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_build_Protected_Virtual_Void_SequenceBuilder_0;
	}
}
