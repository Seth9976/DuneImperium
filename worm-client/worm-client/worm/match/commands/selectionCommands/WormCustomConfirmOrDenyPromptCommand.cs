using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200027A RID: 634
	public class WormCustomConfirmOrDenyPromptCommand : WormCustomChoicePromptCommand
	{
		// Token: 0x060019F9 RID: 6649 RVA: 0x0000F333 File Offset: 0x0000D533
		// Note: this type is marked as 'beforefieldinit'.
		static WormCustomConfirmOrDenyPromptCommand()
		{
			Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormCustomConfirmOrDenyPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptCommand>.NativeClassPtr);
			WormCustomConfirmOrDenyPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptCommand>.NativeClassPtr, 100667072);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00067C5C File Offset: 0x00065E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721738, XrefRangeEnd = 721856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCustomConfirmOrDenyPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomConfirmOrDenyPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomConfirmOrDenyPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0000F36C File Offset: 0x0000D56C
		public WormCustomConfirmOrDenyPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
