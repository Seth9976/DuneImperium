using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F2 RID: 242
	public class IXmlDeclaration : Il2CppObjectBase
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x00070498 File Offset: 0x0006E698
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlDeclaration()
		{
			Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IXmlDeclaration");
			IXmlDeclaration.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr, 100667196);
			IXmlDeclaration.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr, 100667197);
			IXmlDeclaration.NativeMethodInfoPtr_set_Encoding_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr, 100667198);
			IXmlDeclaration.NativeMethodInfoPtr_get_Standalone_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr, 100667199);
			IXmlDeclaration.NativeMethodInfoPtr_set_Standalone_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDeclaration>.NativeClassPtr, 100667200);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00070524 File Offset: 0x0006E724
		public unsafe virtual string Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDeclaration.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00070568 File Offset: 0x0006E768
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x000705AC File Offset: 0x0006E7AC
		public unsafe virtual string Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDeclaration.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDeclaration.NativeMethodInfoPtr_set_Encoding_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000705FC File Offset: 0x0006E7FC
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00070640 File Offset: 0x0006E840
		public unsafe virtual string Standalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDeclaration.NativeMethodInfoPtr_get_Standalone_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDeclaration.NativeMethodInfoPtr_set_Standalone_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000083DF File Offset: 0x000065DF
		public IXmlDeclaration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_set_Encoding_Public_Abstract_Virtual_New_set_Void_String_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_set_Standalone_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
