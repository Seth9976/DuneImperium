using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

// Token: 0x02000006 RID: 6
public class IShowKeyboardCommand : Il2CppObjectBase
{
	// Token: 0x06000015 RID: 21 RVA: 0x00002106 File Offset: 0x00000306
	// Note: this type is marked as 'beforefieldinit'.
	static IShowKeyboardCommand()
	{
		Il2CppClassPointerStore<IShowKeyboardCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "IShowKeyboardCommand");
		IShowKeyboardCommand.NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShowKeyboardCommand>.NativeClassPtr, 100663303);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000107C0 File Offset: 0x0000E9C0
	[CallerCount(0)]
	public unsafe virtual string Result()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IShowKeyboardCommand.NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002135 File Offset: 0x00000335
	public IShowKeyboardCommand(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeMethodInfoPtr_Result_Public_Abstract_Virtual_New_String_0;
}
