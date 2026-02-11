using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000268 RID: 616
	public class ChooseAcquireTleilaxuLocationSelectionCommand : WormChooseOnePromptCommand
	{
		// Token: 0x0600196C RID: 6508 RVA: 0x0000F070 File Offset: 0x0000D270
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseAcquireTleilaxuLocationSelectionCommand()
		{
			Il2CppClassPointerStore<ChooseAcquireTleilaxuLocationSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "ChooseAcquireTleilaxuLocationSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseAcquireTleilaxuLocationSelectionCommand>.NativeClassPtr);
			ChooseAcquireTleilaxuLocationSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseAcquireTleilaxuLocationSelectionCommand>.NativeClassPtr, 100666936);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000658DC File Offset: 0x00063ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720177, XrefRangeEnd = 720202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseAcquireTleilaxuLocationSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseAcquireTleilaxuLocationSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseAcquireTleilaxuLocationSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0000F0A9 File Offset: 0x0000D2A9
		public ChooseAcquireTleilaxuLocationSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
