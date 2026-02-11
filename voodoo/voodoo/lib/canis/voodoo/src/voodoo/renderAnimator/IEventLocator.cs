using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace lib.canis.voodoo.src.voodoo.renderAnimator
{
	// Token: 0x02000014 RID: 20
	public class IEventLocator : Il2CppObjectBase
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000260A File Offset: 0x0000080A
		// Note: this type is marked as 'beforefieldinit'.
		static IEventLocator()
		{
			Il2CppClassPointerStore<IEventLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.canis.voodoo.src.voodoo.renderAnimator", "IEventLocator");
			IEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEventLocator>.NativeClassPtr, 100663368);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AEE0 File Offset: 0x000090E0
		[CallerCount(0)]
		public unsafe virtual void InvokeEvent(string triggerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEventLocator.NativeMethodInfoPtr_InvokeEvent_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002639 File Offset: 0x00000839
		public IEventLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEvent_Public_Abstract_Virtual_New_Void_String_0;
	}
}
