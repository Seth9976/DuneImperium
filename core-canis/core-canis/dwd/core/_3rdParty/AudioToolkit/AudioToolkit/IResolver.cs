using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace dwd.core._3rdParty.AudioToolkit.AudioToolkit
{
	// Token: 0x0200022A RID: 554
	public class IResolver : Il2CppObjectBase
	{
		// Token: 0x06001E10 RID: 7696 RVA: 0x0000CE01 File Offset: 0x0000B001
		// Note: this type is marked as 'beforefieldinit'.
		static IResolver()
		{
			Il2CppClassPointerStore<IResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core._3rdParty.AudioToolkit.AudioToolkit", "IResolver");
			IResolver.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_AudioSubItem_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolver>.NativeClassPtr, 100668101);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0008A230 File Offset: 0x00088430
		[CallerCount(0)]
		public unsafe virtual void Resolve(AudioSubItem item, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolver.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_AudioSubItem_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0000CE30 File Offset: 0x0000B030
		public IResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Void_AudioSubItem_Object_0;
	}
}
