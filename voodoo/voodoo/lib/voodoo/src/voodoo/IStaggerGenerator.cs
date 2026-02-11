using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lib.voodoo.src.voodoo
{
	// Token: 0x02000015 RID: 21
	public class IStaggerGenerator : Il2CppObjectBase
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000AF30 File Offset: 0x00009130
		// Note: this type is marked as 'beforefieldinit'.
		static IStaggerGenerator()
		{
			Il2CppClassPointerStore<IStaggerGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.voodoo.src.voodoo", "IStaggerGenerator");
			IStaggerGenerator.NativeMethodInfoPtr_GetStagger_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStaggerGenerator>.NativeClassPtr, 100663369);
			IStaggerGenerator.NativeMethodInfoPtr_HasStagger_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStaggerGenerator>.NativeClassPtr, 100663370);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000AF80 File Offset: 0x00009180
		[CallerCount(0)]
		public unsafe virtual float GetStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStaggerGenerator.NativeMethodInfoPtr_GetStagger_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[CallerCount(0)]
		public unsafe virtual bool HasStagger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStaggerGenerator.NativeMethodInfoPtr_HasStagger_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002642 File Offset: 0x00000842
		public IStaggerGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetStagger_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_HasStagger_Public_Abstract_Virtual_New_Boolean_0;
	}
}
