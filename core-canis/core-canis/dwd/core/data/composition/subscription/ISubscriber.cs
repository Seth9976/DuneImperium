using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.data.composition.subscription
{
	// Token: 0x020001E4 RID: 484
	public class ISubscriber : Il2CppObjectBase
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x0007DB48 File Offset: 0x0007BD48
		// Note: this type is marked as 'beforefieldinit'.
		static ISubscriber()
		{
			Il2CppClassPointerStore<ISubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition.subscription", "ISubscriber");
			ISubscriber.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubscriber>.NativeClassPtr, 100667508);
			ISubscriber.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubscriber>.NativeClassPtr, 100667509);
			ISubscriber.NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubscriber>.NativeClassPtr, 100667510);
			ISubscriber.NativeMethodInfoPtr_ManagedUpdate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISubscriber>.NativeClassPtr, 100667511);
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0007DBC0 File Offset: 0x0007BDC0
		public unsafe virtual Transform transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubscriber.NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0007DC0C File Offset: 0x0007BE0C
		public unsafe virtual DataComposition Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubscriber.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0007DC58 File Offset: 0x0007BE58
		[CallerCount(0)]
		public unsafe virtual void Republish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubscriber.NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0007DC94 File Offset: 0x0007BE94
		[CallerCount(0)]
		public unsafe virtual void ManagedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISubscriber.NativeMethodInfoPtr_ManagedUpdate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0000B743 File Offset: 0x00009943
		public ISubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_DataComposition_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_Republish_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_ManagedUpdate_Public_Abstract_Virtual_New_Void_0;
	}
}
