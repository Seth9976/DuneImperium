using System;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.commands;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace zen.match
{
	// Token: 0x02000046 RID: 70
	public class VoodooSequenceCommands : SequenceCommands
	{
		// Token: 0x060002CC RID: 716 RVA: 0x0001A160 File Offset: 0x00018360
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooSequenceCommands()
		{
			Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.match", "VoodooSequenceCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr);
			VoodooSequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr, 100663791);
			VoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr, 100663792);
			VoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr, 100663793);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001A1CC File Offset: 0x000183CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SequenceCommand Create(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence, bool isRoot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRoot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooSequenceCommands.NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001A26C File Offset: 0x0001846C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985424, XrefRangeEnd = 985428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SequenceCommand Generic(SequenceID id, string name, ReadOnlyAttributes attributes, IList<Command> sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequence);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001A300 File Offset: 0x00018500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985428, XrefRangeEnd = 985432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooSequenceCommands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooSequenceCommands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003367 File Offset: 0x00001567
		public VoodooSequenceCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_Create_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
