using System;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000280 RID: 640
	public class WormOpponentTroopsSelectionCommand : WormEntityListSelectionPromptCommand
	{
		// Token: 0x06001A20 RID: 6688 RVA: 0x000685E4 File Offset: 0x000667E4
		// Note: this type is marked as 'beforefieldinit'.
		static WormOpponentTroopsSelectionCommand()
		{
			Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormOpponentTroopsSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr);
			WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr, 100667098);
			WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr, 100667099);
			WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr, 100667100);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00068650 File Offset: 0x00066850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722208, XrefRangeEnd = 722289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormOpponentTroopsSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormOpponentTroopsSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000686AC File Offset: 0x000668AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722289, XrefRangeEnd = 722322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<EntityComponent> getChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityComponent>>(intPtr3) : null;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000686F8 File Offset: 0x000668F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722322, XrefRangeEnd = 722325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void exitNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormOpponentTroopsSelectionCommand.NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000F40E File Offset: 0x0000D60E
		public WormOpponentTroopsSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_getChoices_Protected_Virtual_List_1_EntityComponent_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_exitNode_Protected_Virtual_Void_0;
	}
}
