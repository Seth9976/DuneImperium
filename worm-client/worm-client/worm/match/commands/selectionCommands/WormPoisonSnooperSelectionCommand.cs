using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000283 RID: 643
	public class WormPoisonSnooperSelectionCommand : WormChooseOnePromptCommand
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormPoisonSnooperSelectionCommand()
		{
			Il2CppClassPointerStore<WormPoisonSnooperSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormPoisonSnooperSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPoisonSnooperSelectionCommand>.NativeClassPtr);
			WormPoisonSnooperSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPoisonSnooperSelectionCommand>.NativeClassPtr, 100667120);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00068C38 File Offset: 0x00066E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPoisonSnooperSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPoisonSnooperSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPoisonSnooperSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000F4F1 File Offset: 0x0000D6F1
		public WormPoisonSnooperSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
