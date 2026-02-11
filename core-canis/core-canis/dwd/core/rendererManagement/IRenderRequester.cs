using System;
using dwd.core.data.composition;
using dwd.core.rendererManagement.configData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.rendererManagement
{
	// Token: 0x020000FD RID: 253
	public class IRenderRequester : Il2CppObjectBase
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x0004E82C File Offset: 0x0004CA2C
		// Note: this type is marked as 'beforefieldinit'.
		static IRenderRequester()
		{
			Il2CppClassPointerStore<IRenderRequester>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement", "IRenderRequester");
			IRenderRequester.NativeMethodInfoPtr_UpdateCards_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderRequester>.NativeClassPtr, 100665446);
			IRenderRequester.NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderRequester>.NativeClassPtr, 100665447);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0004E87C File Offset: 0x0004CA7C
		[CallerCount(0)]
		public unsafe virtual void UpdateCards(Dictionary<DataComposition, VisibilityConfiguration> cards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderRequester.NativeMethodInfoPtr_UpdateCards_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0004E8CC File Offset: 0x0004CACC
		public unsafe virtual int Layer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRenderRequester.NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00007021 File Offset: 0x00005221
		public IRenderRequester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCards_Public_Abstract_Virtual_New_Void_Dictionary_2_DataComposition_VisibilityConfiguration_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_get_Layer_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
