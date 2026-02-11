using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002DA RID: 730
	public class IConstructionCallMessage : Il2CppObjectBase
	{
		// Token: 0x06002D80 RID: 11648 RVA: 0x000ECD84 File Offset: 0x000EAF84
		// Note: this type is marked as 'beforefieldinit'.
		static IConstructionCallMessage()
		{
			Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IConstructionCallMessage");
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670596);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670597);
			IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670598);
			IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670599);
			IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670600);
			IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstructionCallMessage>.NativeClassPtr, 100670601);
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000ECE24 File Offset: 0x000EB024
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000ECE70 File Offset: 0x000EB070
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000ECEB4 File Offset: 0x000EB0B4
		// (set) Token: 0x06002D84 RID: 11652 RVA: 0x000ECF00 File Offset: 0x000EB100
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000ECF50 File Offset: 0x000EB150
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000ECF9C File Offset: 0x000EB19C
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstructionCallMessage.NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x0000F4C1 File Offset: 0x0000D6C1
		public IConstructionCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002620 RID: 9760
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04002621 RID: 9761
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002622 RID: 9762
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x04002623 RID: 9763
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Abstract_Virtual_New_set_Void_IActivator_0;

		// Token: 0x04002624 RID: 9764
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002625 RID: 9765
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Abstract_Virtual_New_get_IList_0;
	}
}
