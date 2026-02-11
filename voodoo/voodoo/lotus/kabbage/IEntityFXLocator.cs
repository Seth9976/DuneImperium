using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lotus.kabbage
{
	// Token: 0x02000090 RID: 144
	public class IEntityFXLocator : Il2CppObjectBase
	{
		// Token: 0x06000894 RID: 2196 RVA: 0x00025FAC File Offset: 0x000241AC
		// Note: this type is marked as 'beforefieldinit'.
		static IEntityFXLocator()
		{
			Il2CppClassPointerStore<IEntityFXLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus.kabbage", "IEntityFXLocator");
			IEntityFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Abstract_Virtual_New_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityFXLocator>.NativeClassPtr, 100664545);
			IEntityFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityFXLocator>.NativeClassPtr, 100664546);
			IEntityFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Abstract_Virtual_New_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEntityFXLocator>.NativeClassPtr, 100664547);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00026010 File Offset: 0x00024210
		[CallerCount(0)]
		public unsafe virtual Transform GetFXTransform(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityFXLocator.NativeMethodInfoPtr_GetFXTransform_Public_Abstract_Virtual_New_Transform_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002606C File Offset: 0x0002426C
		[CallerCount(0)]
		public unsafe virtual void TryPlayFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityFXLocator.NativeMethodInfoPtr_TryPlayFX_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000260BC File Offset: 0x000242BC
		[CallerCount(0)]
		public unsafe virtual IEnumerator TryPlayBlockingFX(string fxName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fxName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEntityFXLocator.NativeMethodInfoPtr_TryPlayBlockingFX_Public_Abstract_Virtual_New_IEnumerator_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00006316 File Offset: 0x00004516
		public IEntityFXLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_GetFXTransform_Public_Abstract_Virtual_New_Transform_String_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayFX_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayBlockingFX_Public_Abstract_Virtual_New_IEnumerator_String_0;
	}
}
