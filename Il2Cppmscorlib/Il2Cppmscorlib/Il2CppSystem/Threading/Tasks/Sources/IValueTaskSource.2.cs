using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks.Sources
{
	// Token: 0x020001F2 RID: 498
	public class IValueTaskSource<TResult> : Il2CppObjectBase
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x000B80DC File Offset: 0x000B62DC
		// Note: this type is marked as 'beforefieldinit'.
		static IValueTaskSource()
		{
			Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks.Sources", "IValueTaskSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IValueTaskSource<TResult>.NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668752);
			IValueTaskSource<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668753);
			IValueTaskSource<TResult>.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource<TResult>>.NativeClassPtr, 100668754);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x000B817C File Offset: 0x000B637C
		[CallerCount(0)]
		public unsafe virtual ValueTaskSourceStatus GetStatus(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource<TResult>.NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x000B81D0 File Offset: 0x000B63D0
		[CallerCount(0)]
		public unsafe virtual void OnCompleted(Action<Object> continuation, Object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x000B824C File Offset: 0x000B644C
		[CallerCount(0)]
		public unsafe virtual TResult GetResult(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource<TResult>.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0000A6ED File Offset: 0x000088ED
		public IValueTaskSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_TResult_Int16_0;
	}
}
