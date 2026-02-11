using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200028D RID: 653
	public class WormSelectLeaderCommand : WormArchetypeCustomChoiceSelectionPromptCommand
	{
		// Token: 0x06001A97 RID: 6807 RVA: 0x0006A0AC File Offset: 0x000682AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormSelectLeaderCommand()
		{
			Il2CppClassPointerStore<WormSelectLeaderCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormSelectLeaderCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSelectLeaderCommand>.NativeClassPtr);
			WormSelectLeaderCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderCommand>.NativeClassPtr, 100667202);
			WormSelectLeaderCommand.NativeMethodInfoPtr_get_temporaryEntityName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSelectLeaderCommand>.NativeClassPtr, 100667203);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0006A104 File Offset: 0x00068304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723646, XrefRangeEnd = 723688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSelectLeaderCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSelectLeaderCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSelectLeaderCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0006A160 File Offset: 0x00068360
		public unsafe override string temporaryEntityName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723688, XrefRangeEnd = 723690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormSelectLeaderCommand.NativeMethodInfoPtr_get_temporaryEntityName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x0000F73C File Offset: 0x0000D93C
		public WormSelectLeaderCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_get_temporaryEntityName_Protected_Virtual_get_String_0;
	}
}
