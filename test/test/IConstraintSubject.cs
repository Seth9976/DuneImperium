using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.constraint
{
	// Token: 0x02000007 RID: 7
	public class IConstraintSubject : Object
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002D54 File Offset: 0x00000F54
		// Note: this type is marked as 'beforefieldinit'.
		static IConstraintSubject()
		{
			Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr = IL2CPP.GetIl2CppClass("test.dll", "dwd.constraint", "IConstraintSubject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr);
			IConstraintSubject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr, 100663319);
			IConstraintSubject.NativeMethodInfoPtr__ctor_Protected_Void_IConstraintSubject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr, 100663320);
			IConstraintSubject.NativeMethodInfoPtr_GetPropertyValue_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr, 100663321);
			IConstraintSubject.NativeMethodInfoPtr_SetPropertyValue_Public_Abstract_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr, 100663322);
			IConstraintSubject.NativeMethodInfoPtr_GetDomainForProperty_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr, 100663323);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002DE8 File Offset: 0x00000FE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConstraintSubject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConstraintSubject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002E24 File Offset: 0x00001024
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConstraintSubject(IConstraintSubject other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IConstraintSubject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IConstraintSubject.NativeMethodInfoPtr__ctor_Protected_Void_IConstraintSubject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002E70 File Offset: 0x00001070
		[CallerCount(0)]
		public unsafe virtual int GetPropertyValue(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstraintSubject.NativeMethodInfoPtr_GetPropertyValue_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002EC8 File Offset: 0x000010C8
		[CallerCount(0)]
		public unsafe virtual void SetPropertyValue(string propertyName, int newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstraintSubject.NativeMethodInfoPtr_SetPropertyValue_Public_Abstract_Virtual_New_Void_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002F24 File Offset: 0x00001124
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<int> GetDomainForProperty(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConstraintSubject.NativeMethodInfoPtr_GetDomainForProperty_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000021C3 File Offset: 0x000003C3
		public IConstraintSubject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IConstraintSubject_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyValue_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyValue_Public_Abstract_Virtual_New_Void_String_Int32_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_GetDomainForProperty_Public_Abstract_Virtual_New_Il2CppStructArray_1_Int32_String_0;
	}
}
