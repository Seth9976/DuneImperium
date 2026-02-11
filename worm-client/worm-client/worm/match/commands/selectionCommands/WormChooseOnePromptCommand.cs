using System;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000277 RID: 631
	public class WormChooseOnePromptCommand : WormCustomChoicePromptCommand
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x000675E4 File Offset: 0x000657E4
		// Note: this type is marked as 'beforefieldinit'.
		static WormChooseOnePromptCommand()
		{
			Il2CppClassPointerStore<WormChooseOnePromptCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormChooseOnePromptCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseOnePromptCommand>.NativeClassPtr);
			WormChooseOnePromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOnePromptCommand>.NativeClassPtr, 100667047);
			WormChooseOnePromptCommand.NativeMethodInfoPtr___ctor_b__0_0_Private_ValueTuple_2_Boolean_ArchetypeID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseOnePromptCommand>.NativeClassPtr, 100667048);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0006763C File Offset: 0x0006583C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 721560, RefRangeEnd = 721563, XrefRangeStart = 721360, XrefRangeEnd = 721560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChooseOnePromptCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseOnePromptCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOnePromptCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00067698 File Offset: 0x00065898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721563, XrefRangeEnd = 721577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, ArchetypeID> __ctor_b__0_0(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseOnePromptCommand.NativeMethodInfoPtr___ctor_b__0_0_Private_ValueTuple_2_Boolean_ArchetypeID_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<bool, ArchetypeID>(intPtr);
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0000F28D File Offset: 0x0000D48D
		public WormChooseOnePromptCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Private_ValueTuple_2_Boolean_ArchetypeID_EntityID_0;
	}
}
