using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000176 RID: 374
	public class IScheduler : Il2CppObjectBase
	{
		// Token: 0x06001BBA RID: 7098 RVA: 0x0007EBA8 File Offset: 0x0007CDA8
		// Note: this type is marked as 'beforefieldinit'.
		static IScheduler()
		{
			Il2CppClassPointerStore<IScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IScheduler");
			IScheduler.NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScheduler>.NativeClassPtr, 100667326);
			IScheduler.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScheduler>.NativeClassPtr, 100667327);
			IScheduler.NativeMethodInfoPtr_UpdateScheduledEvents_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IScheduler>.NativeClassPtr, 100667328);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0007EC0C File Offset: 0x0007CE0C
		[CallerCount(0)]
		public unsafe virtual void Unschedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScheduler.NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0007EC5C File Offset: 0x0007CE5C
		[CallerCount(0)]
		public unsafe virtual void Schedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScheduler.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0007ECAC File Offset: 0x0007CEAC
		[CallerCount(0)]
		public unsafe virtual void UpdateScheduledEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IScheduler.NativeMethodInfoPtr_UpdateScheduledEvents_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000C891 File Offset: 0x0000AA91
		public IScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_Unschedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_ScheduledItem_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScheduledEvents_Public_Abstract_Virtual_New_Void_0;
	}
}
