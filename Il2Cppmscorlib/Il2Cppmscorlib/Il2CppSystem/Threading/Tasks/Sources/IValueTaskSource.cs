using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading.Tasks.Sources
{
	// Token: 0x020001F1 RID: 497
	public class IValueTaskSource : Il2CppObjectBase
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x000B7F5C File Offset: 0x000B615C
		// Note: this type is marked as 'beforefieldinit'.
		static IValueTaskSource()
		{
			Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks.Sources", "IValueTaskSource");
			IValueTaskSource.NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668749);
			IValueTaskSource.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668750);
			IValueTaskSource.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValueTaskSource>.NativeClassPtr, 100668751);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000B7FC0 File Offset: 0x000B61C0
		[CallerCount(0)]
		public unsafe virtual ValueTaskSourceStatus GetStatus(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource.NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x000B8014 File Offset: 0x000B6214
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource.NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x000B8090 File Offset: 0x000B6290
		[CallerCount(0)]
		public unsafe virtual void GetResult(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValueTaskSource.NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public IValueTaskSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_GetStatus_Public_Abstract_Virtual_New_ValueTaskSourceStatus_Int16_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Abstract_Virtual_New_Void_Action_1_Object_Object_Int16_ValueTaskSourceOnCompletedFlags_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Abstract_Virtual_New_Void_Int16_0;
	}
}
