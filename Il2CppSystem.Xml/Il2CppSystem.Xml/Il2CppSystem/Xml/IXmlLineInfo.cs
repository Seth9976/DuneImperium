using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000081 RID: 129
	public class IXmlLineInfo : Il2CppObjectBase
	{
		// Token: 0x06000F51 RID: 3921 RVA: 0x00059280 File Offset: 0x00057480
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlLineInfo()
		{
			Il2CppClassPointerStore<IXmlLineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IXmlLineInfo");
			IXmlLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlLineInfo>.NativeClassPtr, 100665820);
			IXmlLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlLineInfo>.NativeClassPtr, 100665821);
			IXmlLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlLineInfo>.NativeClassPtr, 100665822);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x000592E4 File Offset: 0x000574E4
		[CallerCount(0)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlLineInfo.NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0005932C File Offset: 0x0005752C
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlLineInfo.NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00059374 File Offset: 0x00057574
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlLineInfo.NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00006F8B File Offset: 0x0000518B
		public IXmlLineInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
