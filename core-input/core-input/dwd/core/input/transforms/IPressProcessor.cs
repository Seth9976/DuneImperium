using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.input.transforms
{
	// Token: 0x02000061 RID: 97
	public class IPressProcessor : Il2CppObjectBase
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x00012604 File Offset: 0x00010804
		// Note: this type is marked as 'beforefieldinit'.
		static IPressProcessor()
		{
			Il2CppClassPointerStore<IPressProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.transforms", "IPressProcessor");
			IPressProcessor.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPressProcessor>.NativeClassPtr, 100663711);
			IPressProcessor.NativeMethodInfoPtr_get_ReadyForCleanUp_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPressProcessor>.NativeClassPtr, 100663712);
			IPressProcessor.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_PressEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPressProcessor>.NativeClassPtr, 100663713);
			IPressProcessor.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPressProcessor>.NativeClassPtr, 100663714);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0001267C File Offset: 0x0001087C
		public unsafe virtual Transform Transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPressProcessor.NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000126C8 File Offset: 0x000108C8
		public unsafe virtual bool ReadyForCleanUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPressProcessor.NativeMethodInfoPtr_get_ReadyForCleanUp_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00012710 File Offset: 0x00010910
		[CallerCount(0)]
		public unsafe virtual void Process(PressEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPressProcessor.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_PressEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00012760 File Offset: 0x00010960
		[CallerCount(0)]
		public unsafe virtual void Update(float unscaledTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPressProcessor.NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000042A4 File Offset: 0x000024A4
		public IPressProcessor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadyForCleanUp_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_PressEvent_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Abstract_Virtual_New_Void_Single_0;
	}
}
