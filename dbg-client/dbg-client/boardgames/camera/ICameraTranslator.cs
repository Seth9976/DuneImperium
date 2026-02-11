using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace boardgames.camera
{
	// Token: 0x0200029F RID: 671
	public class ICameraTranslator : Il2CppObjectBase
	{
		// Token: 0x06001FFB RID: 8187 RVA: 0x000881CC File Offset: 0x000863CC
		// Note: this type is marked as 'beforefieldinit'.
		static ICameraTranslator()
		{
			Il2CppClassPointerStore<ICameraTranslator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.camera", "ICameraTranslator");
			ICameraTranslator.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraTranslator>.NativeClassPtr, 100668610);
			ICameraTranslator.NativeMethodInfoPtr_TranslateScreenDelta_Public_Abstract_Virtual_New_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraTranslator>.NativeClassPtr, 100668611);
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x0008821C File Offset: 0x0008641C
		public unsafe virtual Vector3 CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICameraTranslator.NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00088264 File Offset: 0x00086464
		[CallerCount(0)]
		public unsafe virtual void TranslateScreenDelta(Vector3 startPosition, Vector3 endPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICameraTranslator.NativeMethodInfoPtr_TranslateScreenDelta_Public_Abstract_Virtual_New_Void_Vector3_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00010D21 File Offset: 0x0000EF21
		public ICameraTranslator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_TranslateScreenDelta_Public_Abstract_Virtual_New_Void_Vector3_Vector3_0;
	}
}
