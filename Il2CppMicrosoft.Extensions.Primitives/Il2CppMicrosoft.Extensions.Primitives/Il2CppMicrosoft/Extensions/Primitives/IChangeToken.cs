using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Primitives
{
	// Token: 0x02000009 RID: 9
	public class IChangeToken : Il2CppObjectBase
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000270C File Offset: 0x0000090C
		// Note: this type is marked as 'beforefieldinit'.
		static IChangeToken()
		{
			Il2CppClassPointerStore<IChangeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Primitives.dll", "Microsoft.Extensions.Primitives", "IChangeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IChangeToken>.NativeClassPtr);
			IChangeToken.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChangeToken>.NativeClassPtr, 100663316);
			IChangeToken.NativeMethodInfoPtr_get_ActiveChangeCallbacks_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChangeToken>.NativeClassPtr, 100663317);
			IChangeToken.NativeMethodInfoPtr_RegisterChangeCallback_Public_Abstract_Virtual_New_IDisposable_Action_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IChangeToken>.NativeClassPtr, 100663318);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002778 File Offset: 0x00000978
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChangeToken.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000027C0 File Offset: 0x000009C0
		public unsafe virtual bool ActiveChangeCallbacks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChangeToken.NativeMethodInfoPtr_get_ActiveChangeCallbacks_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002808 File Offset: 0x00000A08
		[CallerCount(0)]
		public unsafe virtual IDisposable RegisterChangeCallback(Action<Object> callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IChangeToken.NativeMethodInfoPtr_RegisterChangeCallback_Public_Abstract_Virtual_New_IDisposable_Action_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021AA File Offset: 0x000003AA
		public IChangeToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveChangeCallbacks_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChangeCallback_Public_Abstract_Virtual_New_IDisposable_Action_1_Object_Object_0;
	}
}
