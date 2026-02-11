using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BD RID: 189
	public class IXmlTextParser : Il2CppObjectBase
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x00068148 File Offset: 0x00066348
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlTextParser()
		{
			Il2CppClassPointerStore<IXmlTextParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "IXmlTextParser");
			IXmlTextParser.NativeMethodInfoPtr_get_Normalized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlTextParser>.NativeClassPtr, 100666353);
			IXmlTextParser.NativeMethodInfoPtr_set_Normalized_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlTextParser>.NativeClassPtr, 100666354);
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x00068198 File Offset: 0x00066398
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x000681E0 File Offset: 0x000663E0
		public unsafe virtual bool Normalized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlTextParser.NativeMethodInfoPtr_get_Normalized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlTextParser.NativeMethodInfoPtr_set_Normalized_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00007ED0 File Offset: 0x000060D0
		public IXmlTextParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_set_Normalized_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}
