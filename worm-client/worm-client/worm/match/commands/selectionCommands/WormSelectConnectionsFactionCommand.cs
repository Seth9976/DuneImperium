using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000289 RID: 649
	public class WormSelectConnectionsFactionCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x0000F667 File Offset: 0x0000D867
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectConnectionsFactionCommand()
		{
			Il2CppClassPointerStore<WormSelectConnectionsFactionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectConnectionsFactionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectConnectionsFactionCommand>.NativeClassPtr);
			WormSelectConnectionsFactionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectConnectionsFactionCommand>.NativeClassPtr, 100667183);
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000699F4 File Offset: 0x00067BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723351, XrefRangeEnd = 723436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectConnectionsFactionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectConnectionsFactionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectConnectionsFactionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		public WormSelectConnectionsFactionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
