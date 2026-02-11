using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007B RID: 123
	public class IContractResolver : Il2CppObjectBase
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x0000522F File Offset: 0x0000342F
		// Note: this type is marked as 'beforefieldinit'.
		static IContractResolver()
		{
			Il2CppClassPointerStore<IContractResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "IContractResolver");
			IContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Abstract_Virtual_New_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContractResolver>.NativeClassPtr, 100665281);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000420A4 File Offset: 0x000402A4
		[CallerCount(0)]
		public unsafe virtual JsonContract ResolveContract(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Abstract_Virtual_New_JsonContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0000525E File Offset: 0x0000345E
		public IContractResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_ResolveContract_Public_Abstract_Virtual_New_JsonContract_Type_0;
	}
}
