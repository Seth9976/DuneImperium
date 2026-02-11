using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000113 RID: 275
	public class IStrongBox : Il2CppObjectBase
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x000562F8 File Offset: 0x000544F8
		// Note: this type is marked as 'beforefieldinit'.
		static IStrongBox()
		{
			Il2CppClassPointerStore<IStrongBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "IStrongBox");
			IStrongBox.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStrongBox>.NativeClassPtr, 100666351);
			IStrongBox.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStrongBox>.NativeClassPtr, 100666352);
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00056348 File Offset: 0x00054548
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00056394 File Offset: 0x00054594
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStrongBox.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStrongBox.NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000070FB File Offset: 0x000052FB
		public IStrongBox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Abstract_Virtual_New_set_Void_Object_0;
	}
}
