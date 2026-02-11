using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000207 RID: 519
	public class IBaseUxmlFactory : Il2CppObjectBase
	{
		// Token: 0x0600280A RID: 10250 RVA: 0x000B0280 File Offset: 0x000AE480
		// Note: this type is marked as 'beforefieldinit'.
		static IBaseUxmlFactory()
		{
			Il2CppClassPointerStore<IBaseUxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IBaseUxmlFactory");
			IBaseUxmlFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseUxmlFactory>.NativeClassPtr, 100669325);
			IBaseUxmlFactory.NativeMethodInfoPtr_get_uxmlType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseUxmlFactory>.NativeClassPtr, 100669326);
			IBaseUxmlFactory.NativeMethodInfoPtr_AcceptsAttributeBag_Public_Abstract_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBaseUxmlFactory>.NativeClassPtr, 100669327);
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000B02E4 File Offset: 0x000AE4E4
		public unsafe virtual string uxmlQualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseUxmlFactory.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600280C RID: 10252 RVA: 0x000B0328 File Offset: 0x000AE528
		public unsafe virtual Type uxmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseUxmlFactory.NativeMethodInfoPtr_get_uxmlType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000B0374 File Offset: 0x000AE574
		[CallerCount(0)]
		public unsafe virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBaseUxmlFactory.NativeMethodInfoPtr_AcceptsAttributeBag_Public_Abstract_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000102E1 File Offset: 0x0000E4E1
		public IBaseUxmlFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_AcceptsAttributeBag_Public_Abstract_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0;
	}
}
