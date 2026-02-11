using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties.Internal
{
	// Token: 0x02000023 RID: 35
	public class IAttributes : Il2CppObjectBase
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00007228 File Offset: 0x00005428
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributes()
		{
			Il2CppClassPointerStore<IAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "IAttributes");
			IAttributes.NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributes>.NativeClassPtr, 100663445);
			IAttributes.NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_IEnumerable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributes>.NativeClassPtr, 100663446);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00007278 File Offset: 0x00005478
		[CallerCount(0)]
		public unsafe virtual void AddAttribute(Attribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributes.NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000072C8 File Offset: 0x000054C8
		[CallerCount(0)]
		public unsafe virtual void AddAttributes(IEnumerable<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAttributes.NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_IEnumerable_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000028ED File Offset: 0x00000AED
		public IAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_Attribute_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_IEnumerable_1_Attribute_0;
	}
}
