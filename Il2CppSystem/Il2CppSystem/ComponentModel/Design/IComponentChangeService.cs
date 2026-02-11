using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x0200014D RID: 333
	public class IComponentChangeService : Il2CppObjectBase
	{
		// Token: 0x0600146E RID: 5230 RVA: 0x0006B5E4 File Offset: 0x000697E4
		// Note: this type is marked as 'beforefieldinit'.
		static IComponentChangeService()
		{
			Il2CppClassPointerStore<IComponentChangeService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IComponentChangeService");
			IComponentChangeService.NativeMethodInfoPtr_OnComponentChanged_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentChangeService>.NativeClassPtr, 100666347);
			IComponentChangeService.NativeMethodInfoPtr_OnComponentChanging_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComponentChangeService>.NativeClassPtr, 100666348);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x0006B634 File Offset: 0x00069834
		[CallerCount(0)]
		public unsafe virtual void OnComponentChanged(Object component, MemberDescriptor member, Object oldValue, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComponentChangeService.NativeMethodInfoPtr_OnComponentChanged_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x0006B6B8 File Offset: 0x000698B8
		[CallerCount(0)]
		public unsafe virtual void OnComponentChanging(Object component, MemberDescriptor member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComponentChangeService.NativeMethodInfoPtr_OnComponentChanging_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00009157 File Offset: 0x00007357
		public IComponentChangeService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_OnComponentChanged_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_Object_Object_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_OnComponentChanging_Public_Abstract_Virtual_New_Void_Object_MemberDescriptor_0;
	}
}
