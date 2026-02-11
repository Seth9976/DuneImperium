using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000017 RID: 23
	public class IMask : Il2CppObjectBase
	{
		// Token: 0x06000268 RID: 616 RVA: 0x0001075C File Offset: 0x0000E95C
		// Note: this type is marked as 'beforefieldinit'.
		static IMask()
		{
			Il2CppClassPointerStore<IMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "IMask");
			IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663688);
			IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMask>.NativeClassPtr, 100663689);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000107AC File Offset: 0x0000E9AC
		[CallerCount(0)]
		public unsafe virtual bool Enabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000107F4 File Offset: 0x0000E9F4
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMask.NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002D4A File Offset: 0x00000F4A
		public IMask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Enabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Abstract_Virtual_New_get_RectTransform_0;
	}
}
