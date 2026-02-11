using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Unity.Properties
{
	// Token: 0x02000013 RID: 19
	public class IPropertyBag : Il2CppObjectBase
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000024A3 File Offset: 0x000006A3
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyBag()
		{
			Il2CppClassPointerStore<IPropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IPropertyBag");
			IPropertyBag.NativeMethodInfoPtr_Accept_Public_Abstract_Virtual_New_Void_ITypeVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyBag>.NativeClassPtr, 100663356);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005414 File Offset: 0x00003614
		[CallerCount(0)]
		public unsafe virtual void Accept(ITypeVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyBag.NativeMethodInfoPtr_Accept_Public_Abstract_Virtual_New_Void_ITypeVisitor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000024D2 File Offset: 0x000006D2
		public IPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Abstract_Virtual_New_Void_ITypeVisitor_0;
	}
}
