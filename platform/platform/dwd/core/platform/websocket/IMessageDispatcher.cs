using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace dwd.core.platform.websocket
{
	// Token: 0x02000014 RID: 20
	public class IMessageDispatcher : Il2CppObjectBase
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00009498 File Offset: 0x00007698
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageDispatcher()
		{
			Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "IMessageDispatcher");
			IMessageDispatcher.NativeMethodInfoPtr_AddHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr, 100663525);
			IMessageDispatcher.NativeMethodInfoPtr_RemoveHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr, 100663526);
			IMessageDispatcher.NativeMethodInfoPtr_SetHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr, 100663527);
			IMessageDispatcher.NativeMethodInfoPtr_QueueMessage_Public_Abstract_Virtual_New_Void_TypedMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr, 100663528);
			IMessageDispatcher.NativeMethodInfoPtr_DispatchMessages_Public_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr, 100663529);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00009524 File Offset: 0x00007724
		[CallerCount(0)]
		public unsafe virtual void AddHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageDispatcher.MethodInfoStoreGeneric_AddHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00009574 File Offset: 0x00007774
		[CallerCount(0)]
		public unsafe virtual void RemoveHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageDispatcher.MethodInfoStoreGeneric_RemoveHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000095C4 File Offset: 0x000077C4
		[CallerCount(0)]
		public unsafe virtual void SetHandler<T>(TypedHandler<T> Handler) where T : TypedMessage
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageDispatcher.MethodInfoStoreGeneric_SetHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00009614 File Offset: 0x00007814
		[CallerCount(0)]
		public unsafe virtual void QueueMessage(TypedMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageDispatcher.NativeMethodInfoPtr_QueueMessage_Public_Abstract_Virtual_New_Void_TypedMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00009664 File Offset: 0x00007864
		[CallerCount(0)]
		public unsafe virtual IEnumerator DispatchMessages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageDispatcher.NativeMethodInfoPtr_DispatchMessages_Public_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000025FB File Offset: 0x000007FB
		public IMessageDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_SetHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_QueueMessage_Public_Abstract_Virtual_New_Void_TypedMessage_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_DispatchMessages_Public_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x0200006F RID: 111
		private sealed class MethodInfoStoreGeneric_AddHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002BB RID: 699
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMessageDispatcher.NativeMethodInfoPtr_AddHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000070 RID: 112
		private sealed class MethodInfoStoreGeneric_RemoveHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002BC RID: 700
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMessageDispatcher.NativeMethodInfoPtr_RemoveHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000071 RID: 113
		private sealed class MethodInfoStoreGeneric_SetHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0<T>
		{
			// Token: 0x040002BD RID: 701
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IMessageDispatcher.NativeMethodInfoPtr_SetHandler_Public_Abstract_Virtual_New_Void_TypedHandler_1_T_0, Il2CppClassPointerStore<IMessageDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
