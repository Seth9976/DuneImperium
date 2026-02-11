using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace boardgames.notifications
{
	// Token: 0x0200010A RID: 266
	public class INotifications : Il2CppObjectBase
	{
		// Token: 0x06000BC5 RID: 3013 RVA: 0x00007A19 File Offset: 0x00005C19
		// Note: this type is marked as 'beforefieldinit'.
		static INotifications()
		{
			Il2CppClassPointerStore<INotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.notifications", "INotifications");
			INotifications.NativeMethodInfoPtr_SetMessageHandler_Public_Abstract_Virtual_New_Void_Func_2_T_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifications>.NativeClassPtr, 100665056);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00042D24 File Offset: 0x00040F24
		[CallerCount(0)]
		public unsafe virtual void SetMessageHandler<T>(Func<T, IEnumerator> handler) where T : NetworkMessageEvent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifications.MethodInfoStoreGeneric_SetMessageHandler_Public_Abstract_Virtual_New_Void_Func_2_T_IEnumerator_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00007A48 File Offset: 0x00005C48
		public INotifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageHandler_Public_Abstract_Virtual_New_Void_Func_2_T_IEnumerator_0;

		// Token: 0x02000350 RID: 848
		private sealed class MethodInfoStoreGeneric_SetMessageHandler_Public_Abstract_Virtual_New_Void_Func_2_T_IEnumerator_0<T>
		{
			// Token: 0x04001924 RID: 6436
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(INotifications.NativeMethodInfoPtr_SetMessageHandler_Public_Abstract_Virtual_New_Void_Func_2_T_IEnumerator_0, Il2CppClassPointerStore<INotifications>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
