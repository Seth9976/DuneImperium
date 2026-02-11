using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028E RID: 654
	public class WormSelectMasterstrokeFactionsCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A9B RID: 6811 RVA: 0x0000F745 File Offset: 0x0000D945
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectMasterstrokeFactionsCommand()
		{
			Il2CppClassPointerStore<WormSelectMasterstrokeFactionsCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectMasterstrokeFactionsCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectMasterstrokeFactionsCommand>.NativeClassPtr);
			WormSelectMasterstrokeFactionsCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectMasterstrokeFactionsCommand>.NativeClassPtr, 100667204);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0006A1A4 File Offset: 0x000683A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723690, XrefRangeEnd = 723732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectMasterstrokeFactionsCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectMasterstrokeFactionsCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectMasterstrokeFactionsCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0000F77E File Offset: 0x0000D97E
		public WormSelectMasterstrokeFactionsCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
