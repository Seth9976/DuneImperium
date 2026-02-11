using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022E RID: 558
	public class IVisualElementScheduledItem : Il2CppObjectBase
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x000B5278 File Offset: 0x000B3478
		// Note: this type is marked as 'beforefieldinit'.
		static IVisualElementScheduledItem()
		{
			Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IVisualElementScheduledItem");
			IVisualElementScheduledItem.NativeMethodInfoPtr_get_isActive_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669520);
			IVisualElementScheduledItem.NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669521);
			IVisualElementScheduledItem.NativeMethodInfoPtr_Pause_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669522);
			IVisualElementScheduledItem.NativeMethodInfoPtr_ExecuteLater_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669523);
			IVisualElementScheduledItem.NativeMethodInfoPtr_StartingIn_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669524);
			IVisualElementScheduledItem.NativeMethodInfoPtr_Every_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVisualElementScheduledItem>.NativeClassPtr, 100669525);
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x000B5318 File Offset: 0x000B3518
		public unsafe virtual bool isActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_get_isActive_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x000B5360 File Offset: 0x000B3560
		[CallerCount(0)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x000B539C File Offset: 0x000B359C
		[CallerCount(0)]
		public unsafe virtual void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_Pause_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x000B53D8 File Offset: 0x000B35D8
		[CallerCount(0)]
		public unsafe virtual void ExecuteLater(long delayMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delayMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_ExecuteLater_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000B5424 File Offset: 0x000B3624
		[CallerCount(0)]
		public unsafe virtual IVisualElementScheduledItem StartingIn(long delayMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delayMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_StartingIn_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x000B547C File Offset: 0x000B367C
		[CallerCount(0)]
		public unsafe virtual IVisualElementScheduledItem Every(long intervalMs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intervalMs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVisualElementScheduledItem.NativeMethodInfoPtr_Every_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00010B0F File Offset: 0x0000ED0F
		public IVisualElementScheduledItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteLater_Public_Abstract_Virtual_New_Void_Int64_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_StartingIn_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_Every_Public_Abstract_Virtual_New_IVisualElementScheduledItem_Int64_0;
	}
}
