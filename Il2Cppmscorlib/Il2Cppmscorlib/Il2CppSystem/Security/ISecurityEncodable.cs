using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x0200021A RID: 538
	public class ISecurityEncodable : Il2CppObjectBase
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x0000B6F0 File Offset: 0x000098F0
		// Note: this type is marked as 'beforefieldinit'.
		static ISecurityEncodable()
		{
			Il2CppClassPointerStore<ISecurityEncodable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "ISecurityEncodable");
			ISecurityEncodable.NativeMethodInfoPtr_ToXml_Public_Abstract_Virtual_New_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISecurityEncodable>.NativeClassPtr, 100669347);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000C8DF4 File Offset: 0x000C6FF4
		[CallerCount(0)]
		public unsafe virtual SecurityElement ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISecurityEncodable.NativeMethodInfoPtr_ToXml_Public_Abstract_Virtual_New_SecurityElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0000B71F File Offset: 0x0000991F
		public ISecurityEncodable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Public_Abstract_Virtual_New_SecurityElement_0;
	}
}
