using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace JsonFx.Serialization
{
	// Token: 0x02000008 RID: 8
	public class IObjectWalker : Il2CppObjectBase
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000218D File Offset: 0x0000038D
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectWalker()
		{
			Il2CppClassPointerStore<IObjectWalker>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "IObjectWalker");
			IObjectWalker.NativeMethodInfoPtr_GetTokens_Public_Abstract_Virtual_New_IEnumerable_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWalker>.NativeClassPtr, 100663339);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004E6C File Offset: 0x0000306C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Token> GetTokens(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectWalker.NativeMethodInfoPtr_GetTokens_Public_Abstract_Virtual_New_IEnumerable_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Token>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021BC File Offset: 0x000003BC
		public IObjectWalker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Public_Abstract_Virtual_New_IEnumerable_1_Token_Object_0;
	}
}
