using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000274 RID: 628
	public class WormBypassProtocolSpaceportPromptCommand : WormChooseOnePromptCommand
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x00067334 File Offset: 0x00065534
		// Note: this type is marked as 'beforefieldinit'.
		static WormBypassProtocolSpaceportPromptCommand()
		{
			Il2CppClassPointerStore<WormBypassProtocolSpaceportPromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormBypassProtocolSpaceportPromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormBypassProtocolSpaceportPromptCommand>.NativeClassPtr);
			WormBypassProtocolSpaceportPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBypassProtocolSpaceportPromptCommand>.NativeClassPtr, 100667031);
			WormBypassProtocolSpaceportPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormBypassProtocolSpaceportPromptCommand>.NativeClassPtr, 100667032);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0006738C File Offset: 0x0006558C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721091, XrefRangeEnd = 721092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormBypassProtocolSpaceportPromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormBypassProtocolSpaceportPromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormBypassProtocolSpaceportPromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000673E8 File Offset: 0x000655E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721092, XrefRangeEnd = 721122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormBypassProtocolSpaceportPromptCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000F239 File Offset: 0x0000D439
		public WormBypassProtocolSpaceportPromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;
	}
}
