using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Newtonsoft.Json
{
	// Token: 0x02000015 RID: 21
	public class IJsonLineInfo : Il2CppObjectBase
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000128C4 File Offset: 0x00010AC4
		// Note: this type is marked as 'beforefieldinit'.
		static IJsonLineInfo()
		{
			Il2CppClassPointerStore<IJsonLineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "IJsonLineInfo");
			IJsonLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJsonLineInfo>.NativeClassPtr, 100663319);
			IJsonLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJsonLineInfo>.NativeClassPtr, 100663320);
			IJsonLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJsonLineInfo>.NativeClassPtr, 100663321);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00012928 File Offset: 0x00010B28
		[CallerCount(0)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJsonLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00012970 File Offset: 0x00010B70
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJsonLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000129B8 File Offset: 0x00010BB8
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IJsonLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022A3 File Offset: 0x000004A3
		public IJsonLineInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
