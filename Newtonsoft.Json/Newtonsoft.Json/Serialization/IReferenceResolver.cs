using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007C RID: 124
	public class IReferenceResolver : Il2CppObjectBase
	{
		// Token: 0x06000A51 RID: 2641 RVA: 0x00042100 File Offset: 0x00040300
		// Note: this type is marked as 'beforefieldinit'.
		static IReferenceResolver()
		{
			Il2CppClassPointerStore<IReferenceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "IReferenceResolver");
			IReferenceResolver.NativeMethodInfoPtr_ResolveReference_Public_Abstract_Virtual_New_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceResolver>.NativeClassPtr, 100665282);
			IReferenceResolver.NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceResolver>.NativeClassPtr, 100665283);
			IReferenceResolver.NativeMethodInfoPtr_IsReferenced_Public_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceResolver>.NativeClassPtr, 100665284);
			IReferenceResolver.NativeMethodInfoPtr_AddReference_Public_Abstract_Virtual_New_Void_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReferenceResolver>.NativeClassPtr, 100665285);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00042178 File Offset: 0x00040378
		[CallerCount(0)]
		public unsafe virtual Object ResolveReference(Object context, string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceResolver.NativeMethodInfoPtr_ResolveReference_Public_Abstract_Virtual_New_Object_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000421E8 File Offset: 0x000403E8
		[CallerCount(0)]
		public unsafe virtual string GetReference(Object context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceResolver.NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_String_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00042250 File Offset: 0x00040450
		[CallerCount(0)]
		public unsafe virtual bool IsReferenced(Object context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceResolver.NativeMethodInfoPtr_IsReferenced_Public_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000422BC File Offset: 0x000404BC
		[CallerCount(0)]
		public unsafe virtual void AddReference(Object context, string reference, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReferenceResolver.NativeMethodInfoPtr_AddReference_Public_Abstract_Virtual_New_Void_Object_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00005267 File Offset: 0x00003467
		public IReferenceResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_ResolveReference_Public_Abstract_Virtual_New_Object_Object_String_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_Abstract_Virtual_New_String_Object_Object_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_IsReferenced_Public_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_AddReference_Public_Abstract_Virtual_New_Void_Object_String_Object_0;
	}
}
