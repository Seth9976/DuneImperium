using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F3 RID: 243
	public class IXmlDocumentType : Il2CppObjectBase
	{
		// Token: 0x0600148B RID: 5259 RVA: 0x00070690 File Offset: 0x0006E890
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlDocumentType()
		{
			Il2CppClassPointerStore<IXmlDocumentType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "IXmlDocumentType");
			IXmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocumentType>.NativeClassPtr, 100667201);
			IXmlDocumentType.NativeMethodInfoPtr_get_System_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocumentType>.NativeClassPtr, 100667202);
			IXmlDocumentType.NativeMethodInfoPtr_get_Public_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocumentType>.NativeClassPtr, 100667203);
			IXmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlDocumentType>.NativeClassPtr, 100667204);
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00070708 File Offset: 0x0006E908
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0007074C File Offset: 0x0006E94C
		public unsafe virtual string System
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocumentType.NativeMethodInfoPtr_get_System_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00070790 File Offset: 0x0006E990
		public unsafe virtual string Public
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocumentType.NativeMethodInfoPtr_get_Public_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000707D4 File Offset: 0x0006E9D4
		public unsafe virtual string InternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x000083E8 File Offset: 0x000065E8
		public IXmlDocumentType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_get_System_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_Abstract_Virtual_New_get_String_0;
	}
}
