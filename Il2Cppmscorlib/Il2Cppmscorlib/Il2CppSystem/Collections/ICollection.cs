using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x020004BA RID: 1210
	public class ICollection : Il2CppObjectBase
	{
		// Token: 0x06004A53 RID: 19027 RVA: 0x0015796C File Offset: 0x00155B6C
		// Note: this type is marked as 'beforefieldinit'.
		static ICollection()
		{
			Il2CppClassPointerStore<ICollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ICollection");
			ICollection.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100674098);
			ICollection.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100674099);
			ICollection.NativeMethodInfoPtr_get_SyncRoot_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100674100);
			ICollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100674101);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x001579E4 File Offset: 0x00155BE4
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x00157A40 File Offset: 0x00155C40
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x00157A88 File Offset: 0x00155C88
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_get_SyncRoot_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x00157AD4 File Offset: 0x00155CD4
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0001B467 File Offset: 0x00019667
		public ICollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
