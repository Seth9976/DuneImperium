using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000267 RID: 615
	public class AcquireTleilaxuCardCommand : WormSelectCardPromptDragTargetCommand
	{
		// Token: 0x06001967 RID: 6503 RVA: 0x0006578C File Offset: 0x0006398C
		// Note: this type is marked as 'beforefieldinit'.
		static AcquireTleilaxuCardCommand()
		{
			Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "AcquireTleilaxuCardCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr);
			AcquireTleilaxuCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr, 100666933);
			AcquireTleilaxuCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr, 100666934);
			AcquireTleilaxuCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr, 100666935);
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000657F8 File Offset: 0x000639F8
		public unsafe override string promptHeaderLoc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720142, XrefRangeEnd = 720174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTleilaxuCardCommand.NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x0006583C File Offset: 0x00063A3C
		public unsafe override string promptFlavor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720174, XrefRangeEnd = 720176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AcquireTleilaxuCardCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00065880 File Offset: 0x00063A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720176, XrefRangeEnd = 720177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AcquireTleilaxuCardCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AcquireTleilaxuCardCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AcquireTleilaxuCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000F067 File Offset: 0x0000D267
		public AcquireTleilaxuCardCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_get_promptHeaderLoc_Protected_Virtual_get_String_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;
	}
}
