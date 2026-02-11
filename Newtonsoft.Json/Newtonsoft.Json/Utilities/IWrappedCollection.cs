using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000046 RID: 70
	public class IWrappedCollection : Il2CppObjectBase
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x00004104 File Offset: 0x00002304
		// Note: this type is marked as 'beforefieldinit'.
		static IWrappedCollection()
		{
			Il2CppClassPointerStore<IWrappedCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "IWrappedCollection");
			IWrappedCollection.NativeMethodInfoPtr_get_UnderlyingCollection_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWrappedCollection>.NativeClassPtr, 100664600);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00031838 File Offset: 0x0002FA38
		public unsafe virtual Object UnderlyingCollection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWrappedCollection.NativeMethodInfoPtr_get_UnderlyingCollection_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00004133 File Offset: 0x00002333
		public IWrappedCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingCollection_Public_Abstract_Virtual_New_get_Object_0;
	}
}
