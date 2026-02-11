using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000287 RID: 647
	public class WormSelectAgentCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x000693C8 File Offset: 0x000675C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectAgentCommand()
		{
			Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectAgentCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr);
			WormSelectAgentCommand.NativeFieldInfoPtr_wasShowingImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr, "wasShowingImperiumRow");
			WormSelectAgentCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr, 100667163);
			WormSelectAgentCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr, 100667164);
			WormSelectAgentCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr, 100667165);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00069448 File Offset: 0x00067648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectAgentCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectAgentCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectAgentCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000694A4 File Offset: 0x000676A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723168, XrefRangeEnd = 723170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectAgentCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000694F0 File Offset: 0x000676F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723170, XrefRangeEnd = 723172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectAgentCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000F5FC File Offset: 0x0000D7FC
		public WormSelectAgentCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x0006952C File Offset: 0x0006772C
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000F605 File Offset: 0x0000D805
		public unsafe bool wasShowingImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectAgentCommand.NativeFieldInfoPtr_wasShowingImperiumRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectAgentCommand.NativeFieldInfoPtr_wasShowingImperiumRow)) = value;
			}
		}

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_wasShowingImperiumRow;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;
	}
}
