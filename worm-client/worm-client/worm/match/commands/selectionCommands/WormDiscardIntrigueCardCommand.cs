using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200027B RID: 635
	public class WormDiscardIntrigueCardCommand : WormSelectCardPromptDragTargetCommand
	{
		// Token: 0x060019FC RID: 6652 RVA: 0x00067CB8 File Offset: 0x00065EB8
		// Note: this type is marked as 'beforefieldinit'.
		static WormDiscardIntrigueCardCommand()
		{
			Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormDiscardIntrigueCardCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr);
			WormDiscardIntrigueCardCommand.NativeFieldInfoPtr_archetypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr, "archetypeName");
			WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr, 100667073);
			WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr, 100667074);
			WormDiscardIntrigueCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr, 100667075);
			WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr, 100667076);
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00067D4C File Offset: 0x00065F4C
		public unsafe override string promptHeaderLoc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721856, XrefRangeEnd = 721888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00067D90 File Offset: 0x00065F90
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721888, XrefRangeEnd = 721890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x00067DD4 File Offset: 0x00065FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDiscardIntrigueCardCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDiscardIntrigueCardCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDiscardIntrigueCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00067E30 File Offset: 0x00066030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721890, XrefRangeEnd = 721902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CancelSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDiscardIntrigueCardCommand.NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0000F375 File Offset: 0x0000D575
		public WormDiscardIntrigueCardCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00067E78 File Offset: 0x00066078
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000F37E File Offset: 0x0000D57E
		public unsafe string archetypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardIntrigueCardCommand.NativeFieldInfoPtr_archetypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormDiscardIntrigueCardCommand.NativeFieldInfoPtr_archetypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeFieldInfoPtr_archetypeName;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_CancelSelection_Public_Virtual_Boolean_0;
	}
}
