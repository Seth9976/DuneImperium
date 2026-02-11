using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004BE RID: 1214
	public class IEnumerable : Il2CppObjectBase
	{
		// Token: 0x06004A6E RID: 19054 RVA: 0x0001B4BA File Offset: 0x000196BA
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerable()
		{
			Il2CppClassPointerStore<IEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEnumerable");
			IEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerable>.NativeClassPtr, 100674117);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00158140 File Offset: 0x00156340
		[CallerCount(0)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerable.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0001B4E9 File Offset: 0x000196E9
		public IEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CFD RID: 15613
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_0;
	}
}
