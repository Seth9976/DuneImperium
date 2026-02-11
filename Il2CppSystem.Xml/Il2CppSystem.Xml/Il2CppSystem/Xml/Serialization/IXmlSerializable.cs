using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BC RID: 188
	public class IXmlSerializable : Il2CppObjectBase
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00067FF8 File Offset: 0x000661F8
		// Note: this type is marked as 'beforefieldinit'.
		static IXmlSerializable()
		{
			Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "IXmlSerializable");
			IXmlSerializable.NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr, 100666350);
			IXmlSerializable.NativeMethodInfoPtr_ReadXml_Public_Abstract_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr, 100666351);
			IXmlSerializable.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IXmlSerializable>.NativeClassPtr, 100666352);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0006805C File Offset: 0x0006625C
		[CallerCount(0)]
		public unsafe virtual XmlSchema GetSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSerializable.NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000680A8 File Offset: 0x000662A8
		[CallerCount(0)]
		public unsafe virtual void ReadXml(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSerializable.NativeMethodInfoPtr_ReadXml_Public_Abstract_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000680F8 File Offset: 0x000662F8
		[CallerCount(0)]
		public unsafe virtual void WriteXml(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IXmlSerializable.NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00007EC7 File Offset: 0x000060C7
		public IXmlSerializable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_GetSchema_Public_Abstract_Virtual_New_XmlSchema_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_ReadXml_Public_Abstract_Virtual_New_Void_XmlReader_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_WriteXml_Public_Abstract_Virtual_New_Void_XmlWriter_0;
	}
}
