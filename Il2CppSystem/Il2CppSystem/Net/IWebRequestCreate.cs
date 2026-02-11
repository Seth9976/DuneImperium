using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B4 RID: 436
	public class IWebRequestCreate : Il2CppObjectBase
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x0000B92A File Offset: 0x00009B2A
		// Note: this type is marked as 'beforefieldinit'.
		static IWebRequestCreate()
		{
			Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "IWebRequestCreate");
			IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWebRequestCreate>.NativeClassPtr, 100667483);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00085F58 File Offset: 0x00084158
		[CallerCount(0)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWebRequestCreate.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0000B959 File Offset: 0x00009B59
		public IWebRequestCreate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_WebRequest_Uri_0;
	}
}
