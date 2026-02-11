using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000381 RID: 897
	public class ICustomMarshaler : Il2CppObjectBase
	{
		// Token: 0x06003792 RID: 14226 RVA: 0x0010FD04 File Offset: 0x0010DF04
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomMarshaler()
		{
			Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ICustomMarshaler");
			ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100671623);
			ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100671624);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100671625);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100671626);
			ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100671627);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0010FD90 File Offset: 0x0010DF90
		[CallerCount(0)]
		public unsafe virtual Object MarshalNativeToManaged(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0010FDE8 File Offset: 0x0010DFE8
		[CallerCount(0)]
		public unsafe virtual IntPtr MarshalManagedToNative(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0010FE40 File Offset: 0x0010E040
		[CallerCount(0)]
		public unsafe virtual void CleanUpNativeData(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x0010FE8C File Offset: 0x0010E08C
		[CallerCount(0)]
		public unsafe virtual void CleanUpManagedData(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x0010FEDC File Offset: 0x0010E0DC
		[CallerCount(0)]
		public unsafe virtual int GetNativeDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00014500 File Offset: 0x00012700
		public ICustomMarshaler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0;
	}
}
