using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x02000152 RID: 338
	public class IReferenceService : Il2CppObjectBase
	{
		// Token: 0x0600147F RID: 5247 RVA: 0x0006B968 File Offset: 0x00069B68
		// Note: this type is marked as 'beforefieldinit'.
		static IReferenceService()
		{
			Il2CppClassPointerStore<IReferenceService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "IReferenceService");
			IReferenceService.NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceService>.NativeClassPtr, 100666354);
			IReferenceService.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceService>.NativeClassPtr, 100666355);
			IReferenceService.NativeMethodInfoPtr_GetReferences_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceService>.NativeClassPtr, 100666356);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0006B9CC File Offset: 0x00069BCC
		[CallerCount(0)]
		public unsafe virtual Object GetReference(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceService.NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0006BA28 File Offset: 0x00069C28
		[CallerCount(0)]
		public unsafe virtual string GetName(Object reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceService.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0006BA7C File Offset: 0x00069C7C
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetReferences(Type baseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceService.NativeMethodInfoPtr_GetReferences_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x000091CE File Offset: 0x000073CE
		public IReferenceService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_Object_String_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_GetReferences_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_0;
	}
}
