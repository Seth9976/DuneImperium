using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Data
{
	// Token: 0x0200005E RID: 94
	public class IFilter : Il2CppObjectBase
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x00004CA6 File Offset: 0x00002EA6
		// Note: this type is marked as 'beforefieldinit'.
		static IFilter()
		{
			Il2CppClassPointerStore<IFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "IFilter");
			IFilter.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Boolean_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilter>.NativeClassPtr, 100664831);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00030C60 File Offset: 0x0002EE60
		[CallerCount(0)]
		public unsafe virtual bool Invoke(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilter.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Boolean_DataRow_DataRowVersion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public IFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Boolean_DataRow_DataRowVersion_0;
	}
}
