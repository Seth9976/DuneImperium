using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000281 RID: 641
	public class WormOtherMemoryCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A25 RID: 6693 RVA: 0x00068734 File Offset: 0x00066934
		// Note: this type is marked as 'beforefieldinit'.
		static WormOtherMemoryCommand()
		{
			Il2CppClassPointerStore<WormOtherMemoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormOtherMemoryCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOtherMemoryCommand>.NativeClassPtr);
			WormOtherMemoryCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryCommand>.NativeClassPtr, 100667101);
			WormOtherMemoryCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOtherMemoryCommand>.NativeClassPtr, 100667102);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0006878C File Offset: 0x0006698C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722325, XrefRangeEnd = 722367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOtherMemoryCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOtherMemoryCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOtherMemoryCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000687E8 File Offset: 0x000669E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722367, XrefRangeEnd = 722376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool autoAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOtherMemoryCommand.NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000F417 File Offset: 0x0000D617
		public WormOtherMemoryCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_autoAdvance_Protected_Virtual_Boolean_0;
	}
}
