using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E2 RID: 994
	public class IResourceReader : Il2CppObjectBase
	{
		// Token: 0x06003A5A RID: 14938 RVA: 0x001195F4 File Offset: 0x001177F4
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceReader()
		{
			Il2CppClassPointerStore<IResourceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "IResourceReader");
			IResourceReader.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceReader>.NativeClassPtr, 100672013);
			IResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceReader>.NativeClassPtr, 100672014);
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00119644 File Offset: 0x00117844
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceReader.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x00119680 File Offset: 0x00117880
		[CallerCount(0)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x00015AC3 File Offset: 0x00013CC3
		public IResourceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0;
	}
}
