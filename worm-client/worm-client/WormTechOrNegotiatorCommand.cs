using System;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using worm.match.commands.selectionCommands;

// Token: 0x02000006 RID: 6
public class WormTechOrNegotiatorCommand : WormAcquireTechCommand
{
	// Token: 0x06000016 RID: 22 RVA: 0x00018EE8 File Offset: 0x000170E8
	// Note: this type is marked as 'beforefieldinit'.
	static WormTechOrNegotiatorCommand()
	{
		Il2CppClassPointerStore<WormTechOrNegotiatorCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormTechOrNegotiatorCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechOrNegotiatorCommand>.NativeClassPtr);
		WormTechOrNegotiatorCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechOrNegotiatorCommand>.NativeClassPtr, 100663310);
		WormTechOrNegotiatorCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechOrNegotiatorCommand>.NativeClassPtr, 100663311);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00018F40 File Offset: 0x00017140
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686873, XrefRangeEnd = 686874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormTechOrNegotiatorCommand(ISelectionNode node, bool fromCancel)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechOrNegotiatorCommand>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechOrNegotiatorCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000018 RID: 24 RVA: 0x00018F9C File Offset: 0x0001719C
	public unsafe override string promptFlavor
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686874, XrefRangeEnd = 686876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechOrNegotiatorCommand.NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002102 File Offset: 0x00000302
	public WormTechOrNegotiatorCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_get_promptFlavor_Protected_Virtual_get_String_0;
}
