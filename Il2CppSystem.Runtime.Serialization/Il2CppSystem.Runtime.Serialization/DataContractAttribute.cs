using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000002 RID: 2
	public sealed class DataContractAttribute : Attribute
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002144 File Offset: 0x00000344
		// Note: this type is marked as 'beforefieldinit'.
		static DataContractAttribute()
		{
			Il2CppClassPointerStore<DataContractAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Runtime.Serialization.dll", "System.Runtime.Serialization", "DataContractAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataContractAttribute>.NativeClassPtr);
			DataContractAttribute.NativeFieldInfoPtr_isReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataContractAttribute>.NativeClassPtr, "isReference");
			DataContractAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataContractAttribute>.NativeClassPtr, 100663297);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe bool IsReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataContractAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public DataContractAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe bool isReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataContractAttribute.NativeFieldInfoPtr_isReference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataContractAttribute.NativeFieldInfoPtr_isReference)) = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_isReference;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0;
	}
}
