using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000276 RID: 630
	public class WormChooseMultiplePromptCommand : WormArchetypeCustomChoicePromptCommand
	{
		// Token: 0x060019DB RID: 6619 RVA: 0x0000F24B File Offset: 0x0000D44B
		// Note: this type is marked as 'beforefieldinit'.
		static WormChooseMultiplePromptCommand()
		{
			Il2CppClassPointerStore<WormChooseMultiplePromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormChooseMultiplePromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseMultiplePromptCommand>.NativeClassPtr);
			WormChooseMultiplePromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseMultiplePromptCommand>.NativeClassPtr, 100667046);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00067588 File Offset: 0x00065788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721273, XrefRangeEnd = 721360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChooseMultiplePromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseMultiplePromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseMultiplePromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000F284 File Offset: 0x0000D484
		public WormChooseMultiplePromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
