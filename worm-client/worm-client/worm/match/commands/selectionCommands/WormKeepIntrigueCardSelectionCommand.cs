using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200027F RID: 639
	public class WormKeepIntrigueCardSelectionCommand : WormDiscardIntrigueCardCommand
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000684EC File Offset: 0x000666EC
		// Note: this type is marked as 'beforefieldinit'.
		static WormKeepIntrigueCardSelectionCommand()
		{
			Il2CppClassPointerStore<WormKeepIntrigueCardSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormKeepIntrigueCardSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormKeepIntrigueCardSelectionCommand>.NativeClassPtr);
			WormKeepIntrigueCardSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormKeepIntrigueCardSelectionCommand>.NativeClassPtr, 100667096);
			WormKeepIntrigueCardSelectionCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormKeepIntrigueCardSelectionCommand>.NativeClassPtr, 100667097);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00068544 File Offset: 0x00066744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormKeepIntrigueCardSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormKeepIntrigueCardSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormKeepIntrigueCardSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000685A0 File Offset: 0x000667A0
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722206, XrefRangeEnd = 722208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormKeepIntrigueCardSelectionCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000F405 File Offset: 0x0000D605
		public WormKeepIntrigueCardSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;
	}
}
