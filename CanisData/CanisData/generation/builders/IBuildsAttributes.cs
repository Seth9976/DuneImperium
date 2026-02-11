using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace CanisData.generation.builders
{
	// Token: 0x0200002B RID: 43
	public class IBuildsAttributes : Il2CppObjectBase
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00009B24 File Offset: 0x00007D24
		// Note: this type is marked as 'beforefieldinit'.
		static IBuildsAttributes()
		{
			Il2CppClassPointerStore<IBuildsAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.builders", "IBuildsAttributes");
			IBuildsAttributes.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_IReadOnlyList_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBuildsAttributes>.NativeClassPtr, 100663515);
			IBuildsAttributes.NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBuildsAttributes>.NativeClassPtr, 100663516);
			IBuildsAttributes.NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBuildsAttributes>.NativeClassPtr, 100663517);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00009B88 File Offset: 0x00007D88
		public unsafe virtual IReadOnlyList<AttributeConstructionParameters> Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBuildsAttributes.NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_IReadOnlyList_1_AttributeConstructionParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AttributeConstructionParameters>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009BD4 File Offset: 0x00007DD4
		[CallerCount(0)]
		public unsafe virtual void AddAttribute(string attributeName, string attributeValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBuildsAttributes.NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009C34 File Offset: 0x00007E34
		[CallerCount(0)]
		public unsafe virtual void AddAttributes(AttributeConstructionParameters attr1, [Optional] Il2CppReferenceArray<AttributeConstructionParameters> attrs)
		{
			if (attrs == null)
			{
				attrs = new Il2CppReferenceArray<AttributeConstructionParameters>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBuildsAttributes.NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public virtual void AddAttributes(AttributeConstructionParameters attr1, params AttributeConstructionParameters[] attrs)
		{
			this.AddAttributes(attr1, new Il2CppReferenceArray<AttributeConstructionParameters>(attrs));
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002CC3 File Offset: 0x00000EC3
		public IBuildsAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Abstract_Virtual_New_get_IReadOnlyList_1_AttributeConstructionParameters_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributes_Public_Abstract_Virtual_New_Void_AttributeConstructionParameters_Il2CppReferenceArray_1_AttributeConstructionParameters_0;
	}
}
