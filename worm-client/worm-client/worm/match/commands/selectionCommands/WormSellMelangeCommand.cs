using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000291 RID: 657
	public class WormSellMelangeCommand : WormArchetypeCustomChoicePromptCommand
	{
		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000F7D2 File Offset: 0x0000D9D2
		// Note: this type is marked as 'beforefieldinit'.
		static WormSellMelangeCommand()
		{
			Il2CppClassPointerStore<WormSellMelangeCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSellMelangeCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSellMelangeCommand>.NativeClassPtr);
			WormSellMelangeCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSellMelangeCommand>.NativeClassPtr, 100667209);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0006A3AC File Offset: 0x000685AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723810, XrefRangeEnd = 723889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSellMelangeCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSellMelangeCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSellMelangeCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0000F80B File Offset: 0x0000DA0B
		public WormSellMelangeCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
