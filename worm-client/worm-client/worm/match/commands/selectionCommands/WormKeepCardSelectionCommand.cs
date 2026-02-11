using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200027E RID: 638
	public class WormKeepCardSelectionCommand : WormSelectDiscardCardCommand
	{
		// Token: 0x06001A18 RID: 6680 RVA: 0x000683F4 File Offset: 0x000665F4
		// Note: this type is marked as 'beforefieldinit'.
		static WormKeepCardSelectionCommand()
		{
			Il2CppClassPointerStore<WormKeepCardSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormKeepCardSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormKeepCardSelectionCommand>.NativeClassPtr);
			WormKeepCardSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormKeepCardSelectionCommand>.NativeClassPtr, 100667094);
			WormKeepCardSelectionCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormKeepCardSelectionCommand>.NativeClassPtr, 100667095);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0006844C File Offset: 0x0006664C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormKeepCardSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormKeepCardSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormKeepCardSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000684A8 File Offset: 0x000666A8
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722204, XrefRangeEnd = 722206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormKeepCardSelectionCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0000F3FC File Offset: 0x0000D5FC
		public WormKeepCardSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;
	}
}
