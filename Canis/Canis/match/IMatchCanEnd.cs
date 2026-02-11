using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Canis.match
{
	// Token: 0x02000099 RID: 153
	public class IMatchCanEnd : Il2CppObjectBase
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00004F02 File Offset: 0x00003102
		// Note: this type is marked as 'beforefieldinit'.
		static IMatchCanEnd()
		{
			Il2CppClassPointerStore<IMatchCanEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.match", "IMatchCanEnd");
			IMatchCanEnd.NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMatchCanEnd>.NativeClassPtr, 100664854);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000383D8 File Offset: 0x000365D8
		[CallerCount(0)]
		public unsafe virtual bool IsGameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMatchCanEnd.NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004F31 File Offset: 0x00003131
		public IMatchCanEnd(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0;
	}
}
