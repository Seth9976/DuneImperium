using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028F RID: 655
	public class WormSelectOpponentCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A9E RID: 6814 RVA: 0x0000F787 File Offset: 0x0000D987
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectOpponentCommand()
		{
			Il2CppClassPointerStore<WormSelectOpponentCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectOpponentCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectOpponentCommand>.NativeClassPtr);
			WormSelectOpponentCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectOpponentCommand>.NativeClassPtr, 100667205);
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0006A200 File Offset: 0x00068400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723732, XrefRangeEnd = 723806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectOpponentCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectOpponentCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectOpponentCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0000F7C0 File Offset: 0x0000D9C0
		public WormSelectOpponentCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
