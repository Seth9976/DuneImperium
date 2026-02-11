using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace InControl
{
	// Token: 0x02000062 RID: 98
	public class IUpdateable : Il2CppObjectBase
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x00005C60 File Offset: 0x00003E60
		// Note: this type is marked as 'beforefieldinit'.
		static IUpdateable()
		{
			Il2CppClassPointerStore<IUpdateable>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "IUpdateable");
			IUpdateable.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpdateable>.NativeClassPtr, 100664507);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00028CF0 File Offset: 0x00026EF0
		[CallerCount(0)]
		public unsafe virtual void Update(ulong updateTick, float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateTick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUpdateable.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00005C8F File Offset: 0x00003E8F
		public IUpdateable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_UInt64_Single_0;
	}
}
