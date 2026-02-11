using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200026F RID: 623
	public class WormAgentToSpaceSelectionCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x00066708 File Offset: 0x00064908
		// Note: this type is marked as 'beforefieldinit'.
		static WormAgentToSpaceSelectionCommand()
		{
			Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormAgentToSpaceSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr);
			WormAgentToSpaceSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr, "SelectableSpaceHint");
			WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr, 100666989);
			WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr, 100666990);
			WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr, 100666991);
			WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_SetTargetVFXHinting_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr, 100666992);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0006679C File Offset: 0x0006499C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAgentToSpaceSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAgentToSpaceSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000667F8 File Offset: 0x000649F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720714, XrefRangeEnd = 720716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00066834 File Offset: 0x00064A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720716, XrefRangeEnd = 720728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00066870 File Offset: 0x00064A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 720785, RefRangeEnd = 720787, XrefRangeStart = 720728, XrefRangeEnd = 720785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetVFXHinting(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAgentToSpaceSelectionCommand.NativeMethodInfoPtr_SetTargetVFXHinting_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0000F141 File Offset: 0x0000D341
		public WormAgentToSpaceSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x000668B0 File Offset: 0x00064AB0
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000F14A File Offset: 0x0000D34A
		public unsafe static string SelectableSpaceHint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAgentToSpaceSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAgentToSpaceSelectionCommand.NativeFieldInfoPtr_SelectableSpaceHint, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr_SelectableSpaceHint;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetVFXHinting_Private_Void_Boolean_0;
	}
}
