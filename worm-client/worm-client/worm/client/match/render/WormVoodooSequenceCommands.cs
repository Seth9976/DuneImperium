using System;
using boardgames.voodoo;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.match.sequence.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.client.match.render
{
	// Token: 0x020002A0 RID: 672
	public class WormVoodooSequenceCommands : DBGVoodooSequenceCommands
	{
		// Token: 0x06001B4F RID: 6991 RVA: 0x0006C050 File Offset: 0x0006A250
		// Note: this type is marked as 'beforefieldinit'.
		static WormVoodooSequenceCommands()
		{
			Il2CppClassPointerStore<WormVoodooSequenceCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match.render", "WormVoodooSequenceCommands");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVoodooSequenceCommands>.NativeClassPtr);
			WormVoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooSequenceCommands>.NativeClassPtr, 100667275);
			WormVoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVoodooSequenceCommands>.NativeClassPtr, 100667276);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724422, XrefRangeEnd = 724426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVoodooSequenceCommands.NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceCommand>(intPtr3) : null;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0006C13C File Offset: 0x0006A33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724426, XrefRangeEnd = 724427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVoodooSequenceCommands()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVoodooSequenceCommands>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVoodooSequenceCommands.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		public WormVoodooSequenceCommands(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_Generic_Protected_Virtual_SequenceCommand_SequenceID_String_ReadOnlyAttributes_IList_1_Command_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
