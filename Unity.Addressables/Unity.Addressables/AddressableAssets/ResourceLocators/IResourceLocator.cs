using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x02000021 RID: 33
	public class IResourceLocator : Il2CppObjectBase
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceLocator()
		{
			Il2CppClassPointerStore<IResourceLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "IResourceLocator");
			IResourceLocator.NativeMethodInfoPtr_get_LocatorId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocator>.NativeClassPtr, 100663855);
			IResourceLocator.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocator>.NativeClassPtr, 100663856);
			IResourceLocator.NativeMethodInfoPtr_Locate_Public_Abstract_Virtual_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocator>.NativeClassPtr, 100663857);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00010C24 File Offset: 0x0000EE24
		public unsafe virtual string LocatorId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocator.NativeMethodInfoPtr_get_LocatorId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00010C68 File Offset: 0x0000EE68
		public unsafe virtual IEnumerable<Object> Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocator.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		[CallerCount(0)]
		public unsafe virtual bool Locate(Object key, Type type, out IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocator.NativeMethodInfoPtr_Locate_Public_Abstract_Virtual_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002E3B File Offset: 0x0000103B
		public IResourceLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_LocatorId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_Locate_Public_Abstract_Virtual_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0;
	}
}
