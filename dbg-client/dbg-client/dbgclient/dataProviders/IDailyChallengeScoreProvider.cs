using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Events;

namespace dbgclient.dataProviders
{
	// Token: 0x020000C5 RID: 197
	public class IDailyChallengeScoreProvider : Il2CppObjectBase
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x00037FA8 File Offset: 0x000361A8
		// Note: this type is marked as 'beforefieldinit'.
		static IDailyChallengeScoreProvider()
		{
			Il2CppClassPointerStore<IDailyChallengeScoreProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataProviders", "IDailyChallengeScoreProvider");
			IDailyChallengeScoreProvider.NativeMethodInfoPtr_AddScoreUpdatedListener_Public_Abstract_Virtual_New_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDailyChallengeScoreProvider>.NativeClassPtr, 100664541);
			IDailyChallengeScoreProvider.NativeMethodInfoPtr_GetScoreForMethod_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDailyChallengeScoreProvider>.NativeClassPtr, 100664542);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00037FF8 File Offset: 0x000361F8
		[CallerCount(0)]
		public unsafe virtual void AddScoreUpdatedListener(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDailyChallengeScoreProvider.NativeMethodInfoPtr_AddScoreUpdatedListener_Public_Abstract_Virtual_New_Void_UnityAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00038048 File Offset: 0x00036248
		[CallerCount(0)]
		public unsafe virtual int GetScoreForMethod(int methodId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDailyChallengeScoreProvider.NativeMethodInfoPtr_GetScoreForMethod_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00005E59 File Offset: 0x00004059
		public IDailyChallengeScoreProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_AddScoreUpdatedListener_Public_Abstract_Virtual_New_Void_UnityAction_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_GetScoreForMethod_Public_Abstract_Virtual_New_Int32_Int32_0;
	}
}
