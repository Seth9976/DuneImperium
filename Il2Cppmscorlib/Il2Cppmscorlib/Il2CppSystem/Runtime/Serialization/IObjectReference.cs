using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000316 RID: 790
	public class IObjectReference : Il2CppObjectBase
	{
		// Token: 0x06003085 RID: 12421 RVA: 0x00010A62 File Offset: 0x0000EC62
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectReference()
		{
			Il2CppClassPointerStore<IObjectReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IObjectReference");
			IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectReference>.NativeClassPtr, 100670953);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x000F7A38 File Offset: 0x000F5C38
		[CallerCount(0)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x00010A91 File Offset: 0x0000EC91
		public IObjectReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0;
	}
}
