using System;
using boardgames.match.selection;
using dwd.core.match.selection;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200026A RID: 618
	public class ChooseSpecimensCommand : DBGEntityListSelectionPromptCommand
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00065BA8 File Offset: 0x00063DA8
		// Note: this type is marked as 'beforefieldinit'.
		static ChooseSpecimensCommand()
		{
			Il2CppClassPointerStore<ChooseSpecimensCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "ChooseSpecimensCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseSpecimensCommand>.NativeClassPtr);
			ChooseSpecimensCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensCommand>.NativeClassPtr, 100666943);
			ChooseSpecimensCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseSpecimensCommand>.NativeClassPtr, 100666944);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00065C00 File Offset: 0x00063E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720257, XrefRangeEnd = 720258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChooseSpecimensCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseSpecimensCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChooseSpecimensCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00065C5C File Offset: 0x00063E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720258, XrefRangeEnd = 720266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefabFlavorContext getPromptFlavors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChooseSpecimensCommand.NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_PrefabFlavorContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new PrefabFlavorContext(intPtr);
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0000F0BB File Offset: 0x0000D2BB
		public ChooseSpecimensCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_getPromptFlavors_Protected_Virtual_PrefabFlavorContext_0;
	}
}
