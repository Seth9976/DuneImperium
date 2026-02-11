using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x02000153 RID: 339
	public class ITypeDescriptorFilterService : Il2CppObjectBase
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		// Note: this type is marked as 'beforefieldinit'.
		static ITypeDescriptorFilterService()
		{
			Il2CppClassPointerStore<ITypeDescriptorFilterService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "ITypeDescriptorFilterService");
			ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterAttributes_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypeDescriptorFilterService>.NativeClassPtr, 100666357);
			ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterEvents_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypeDescriptorFilterService>.NativeClassPtr, 100666358);
			ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterProperties_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITypeDescriptorFilterService>.NativeClassPtr, 100666359);
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0006BB3C File Offset: 0x00069D3C
		[CallerCount(0)]
		public unsafe virtual bool FilterAttributes(IComponent component, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterAttributes_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0006BBA8 File Offset: 0x00069DA8
		[CallerCount(0)]
		public unsafe virtual bool FilterEvents(IComponent component, IDictionary events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterEvents_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0006BC14 File Offset: 0x00069E14
		[CallerCount(0)]
		public unsafe virtual bool FilterProperties(IComponent component, IDictionary properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITypeDescriptorFilterService.NativeMethodInfoPtr_FilterProperties_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x000091D7 File Offset: 0x000073D7
		public ITypeDescriptorFilterService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_FilterAttributes_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_FilterEvents_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_FilterProperties_Public_Abstract_Virtual_New_Boolean_IComponent_IDictionary_0;
	}
}
