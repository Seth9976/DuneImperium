using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace dwd.core.match.selection
{
	// Token: 0x02000139 RID: 313
	public class IIntegerSelection : Il2CppObjectBase
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x00059B1C File Offset: 0x00057D1C
		// Note: this type is marked as 'beforefieldinit'.
		static IIntegerSelection()
		{
			Il2CppClassPointerStore<IIntegerSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "IIntegerSelection");
			IIntegerSelection.NativeMethodInfoPtr_get_Min_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIntegerSelection>.NativeClassPtr, 100665871);
			IIntegerSelection.NativeMethodInfoPtr_get_Max_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIntegerSelection>.NativeClassPtr, 100665872);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00059B6C File Offset: 0x00057D6C
		public unsafe virtual int Min
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIntegerSelection.NativeMethodInfoPtr_get_Min_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00059BB4 File Offset: 0x00057DB4
		public unsafe virtual int Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIntegerSelection.NativeMethodInfoPtr_get_Max_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0000818B File Offset: 0x0000638B
		public IIntegerSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_Min_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
