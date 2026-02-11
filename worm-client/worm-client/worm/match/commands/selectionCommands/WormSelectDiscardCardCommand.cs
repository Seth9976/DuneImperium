using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028A RID: 650
	public class WormSelectDiscardCardCommand : WormSelectCardPromptDragTargetCommand
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x00069A50 File Offset: 0x00067C50
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectDiscardCardCommand()
		{
			Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectDiscardCardCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr);
			WormSelectDiscardCardCommand.NativeFieldInfoPtr_archetypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr, "archetypeName");
			WormSelectDiscardCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr, 100667184);
			WormSelectDiscardCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr, 100667185);
			WormSelectDiscardCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr, 100667186);
			WormSelectDiscardCardCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr, 100667187);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00069AE4 File Offset: 0x00067CE4
		public unsafe override string promptHeaderLoc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723436, XrefRangeEnd = 723468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectDiscardCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00069B28 File Offset: 0x00067D28
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723468, XrefRangeEnd = 723470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectDiscardCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x00069B6C File Offset: 0x00067D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectDiscardCardCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectDiscardCardCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectDiscardCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x00069BC8 File Offset: 0x00067DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723470, XrefRangeEnd = 723482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectDiscardCardCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0000F6A9 File Offset: 0x0000D8A9
		public WormSelectDiscardCardCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x00069C10 File Offset: 0x00067E10
		// (set) Token: 0x06001A84 RID: 6788 RVA: 0x0000F6B2 File Offset: 0x0000D8B2
		public unsafe string archetypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectDiscardCardCommand.NativeFieldInfoPtr_archetypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectDiscardCardCommand.NativeFieldInfoPtr_archetypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_archetypeName;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0;
	}
}
