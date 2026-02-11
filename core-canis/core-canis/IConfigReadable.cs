using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

// Token: 0x02000030 RID: 48
public class IConfigReadable : Il2CppObjectBase
{
	// Token: 0x0600045C RID: 1116 RVA: 0x00003AAC File Offset: 0x00001CAC
	// Note: this type is marked as 'beforefieldinit'.
	static IConfigReadable()
	{
		Il2CppClassPointerStore<IConfigReadable>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "IConfigReadable");
		IConfigReadable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConfigReadable>.NativeClassPtr, 100663915);
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x000248F0 File Offset: 0x00022AF0
	[CallerCount(0)]
	public unsafe virtual string Get(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConfigReadable.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00003ADB File Offset: 0x00001CDB
	public IConfigReadable(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000331 RID: 817
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_String_String_0;
}
