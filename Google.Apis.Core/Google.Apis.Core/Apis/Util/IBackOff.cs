using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Google.Apis.Util
{
	// Token: 0x02000006 RID: 6
	public class IBackOff : Il2CppObjectBase
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00004C48 File Offset: 0x00002E48
		// Note: this type is marked as 'beforefieldinit'.
		static IBackOff()
		{
			Il2CppClassPointerStore<IBackOff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Util", "IBackOff");
			IBackOff.NativeMethodInfoPtr_GetNextBackOff_Public_Abstract_Virtual_New_TimeSpan_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBackOff>.NativeClassPtr, 100663319);
			IBackOff.NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBackOff>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004C98 File Offset: 0x00002E98
		[CallerCount(0)]
		public unsafe virtual TimeSpan GetNextBackOff(int currentRetry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentRetry;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBackOff.NativeMethodInfoPtr_GetNextBackOff_Public_Abstract_Virtual_New_TimeSpan_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004CEC File Offset: 0x00002EEC
		public unsafe virtual int MaxNumOfRetries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBackOff.NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002142 File Offset: 0x00000342
		public IBackOff(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetNextBackOff_Public_Abstract_Virtual_New_TimeSpan_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxNumOfRetries_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
