using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028B RID: 651
	public class WormSelectFactionCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A85 RID: 6789 RVA: 0x00069C38 File Offset: 0x00067E38
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectFactionCommand()
		{
			Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectFactionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr);
			WormSelectFactionCommand.NativeFieldInfoPtr_wasShowingImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr, "wasShowingImperiumRow");
			WormSelectFactionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr, 100667188);
			WormSelectFactionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr, 100667189);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00069CA4 File Offset: 0x00067EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723482, XrefRangeEnd = 723595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectFactionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectFactionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectFactionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00069D00 File Offset: 0x00067F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723595, XrefRangeEnd = 723605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator idle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectFactionCommand.NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000F6D1 File Offset: 0x0000D8D1
		public WormSelectFactionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00069D4C File Offset: 0x00067F4C
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000F6DA File Offset: 0x0000D8DA
		public unsafe bool wasShowingImperiumRow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectFactionCommand.NativeFieldInfoPtr_wasShowingImperiumRow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSelectFactionCommand.NativeFieldInfoPtr_wasShowingImperiumRow)) = value;
			}
		}

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeFieldInfoPtr_wasShowingImperiumRow;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_idle_Protected_Virtual_IEnumerator_0;
	}
}
