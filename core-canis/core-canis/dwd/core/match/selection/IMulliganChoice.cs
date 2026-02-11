using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace dwd.core.match.selection
{
	// Token: 0x0200013A RID: 314
	public class IMulliganChoice : Il2CppObjectBase
	{
		// Token: 0x06001198 RID: 4504 RVA: 0x00059BFC File Offset: 0x00057DFC
		// Note: this type is marked as 'beforefieldinit'.
		static IMulliganChoice()
		{
			Il2CppClassPointerStore<IMulliganChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IMulliganChoice");
			IMulliganChoice.NativeMethodInfoPtr_get_MulliganChoice_Public_Abstract_Virtual_New_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMulliganChoice>.NativeClassPtr, 100665873);
			IMulliganChoice.NativeMethodInfoPtr_MakeMulliganChoice_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMulliganChoice>.NativeClassPtr, 100665874);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00059C4C File Offset: 0x00057E4C
		public unsafe virtual Nullable<bool> MulliganChoice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMulliganChoice.NativeMethodInfoPtr_get_MulliganChoice_Public_Abstract_Virtual_New_get_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00059C90 File Offset: 0x00057E90
		[CallerCount(0)]
		public unsafe virtual void MakeMulliganChoice(bool mulligan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mulligan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMulliganChoice.NativeMethodInfoPtr_MakeMulliganChoice_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00008194 File Offset: 0x00006394
		public IMulliganChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_get_MulliganChoice_Public_Abstract_Virtual_New_get_Nullable_1_Boolean_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_MakeMulliganChoice_Public_Abstract_Virtual_New_Void_Boolean_0;
	}
}
