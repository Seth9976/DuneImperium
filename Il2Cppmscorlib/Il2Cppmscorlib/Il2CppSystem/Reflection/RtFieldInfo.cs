using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000445 RID: 1093
	public class RtFieldInfo : FieldInfo
	{
		// Token: 0x06003F54 RID: 16212 RVA: 0x0012F31C File Offset: 0x0012D51C
		// Note: this type is marked as 'beforefieldinit'.
		static RtFieldInfo()
		{
			Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RtFieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr);
			RtFieldInfo.NativeMethodInfoPtr_UnsafeGetValue_Internal_Abstract_Virtual_New_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100672818);
			RtFieldInfo.NativeMethodInfoPtr_UnsafeSetValue_Internal_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100672819);
			RtFieldInfo.NativeMethodInfoPtr_CheckConsistency_Internal_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100672820);
			RtFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100672821);
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x0012F39C File Offset: 0x0012D59C
		[CallerCount(0)]
		public unsafe virtual Object UnsafeGetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RtFieldInfo.NativeMethodInfoPtr_UnsafeGetValue_Internal_Abstract_Virtual_New_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0012F3F8 File Offset: 0x0012D5F8
		[CallerCount(0)]
		public unsafe virtual void UnsafeSetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RtFieldInfo.NativeMethodInfoPtr_UnsafeSetValue_Internal_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0012F48C File Offset: 0x0012D68C
		[CallerCount(0)]
		public unsafe virtual void CheckConsistency(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RtFieldInfo.NativeMethodInfoPtr_CheckConsistency_Internal_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0012F4DC File Offset: 0x0012D6DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RtFieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RtFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x00017278 File Offset: 0x00015478
		public RtFieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeGetValue_Internal_Abstract_Virtual_New_Object_Object_0;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeSetValue_Internal_Abstract_Virtual_New_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Internal_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
