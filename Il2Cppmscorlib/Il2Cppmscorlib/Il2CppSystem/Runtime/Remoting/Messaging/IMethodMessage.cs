using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002FF RID: 767
	public class IMethodMessage : Il2CppObjectBase
	{
		// Token: 0x06002F1F RID: 12063 RVA: 0x000F25BC File Offset: 0x000F07BC
		// Note: this type is marked as 'beforefieldinit'.
		static IMethodMessage()
		{
			Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMethodMessage");
			IMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670772);
			IMethodMessage.NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670773);
			IMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670774);
			IMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670775);
			IMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670776);
			IMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670777);
			IMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670778);
			IMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670779);
			IMethodMessage.NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodMessage>.NativeClassPtr, 100670780);
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000F2698 File Offset: 0x000F0898
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x000F26E0 File Offset: 0x000F08E0
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000F272C File Offset: 0x000F092C
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000F2778 File Offset: 0x000F0978
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000F27C4 File Offset: 0x000F09C4
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x000F2808 File Offset: 0x000F0A08
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000F2854 File Offset: 0x000F0A54
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x000F2898 File Offset: 0x000F0A98
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x000F28DC File Offset: 0x000F0ADC
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodMessage.NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000100CF File Offset: 0x0000E2CF
		public IMethodMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Abstract_Virtual_New_get_LogicalCallContext_0;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Abstract_Virtual_New_get_MethodBase_0;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Abstract_Virtual_New_Object_Int32_0;
	}
}
