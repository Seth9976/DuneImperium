using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Google.Apis.Requests
{
	// Token: 0x02000014 RID: 20
	public class IDirectResponseSchema : Il2CppObjectBase
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0000A6C8 File Offset: 0x000088C8
		// Note: this type is marked as 'beforefieldinit'.
		static IDirectResponseSchema()
		{
			Il2CppClassPointerStore<IDirectResponseSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Requests", "IDirectResponseSchema");
			IDirectResponseSchema.NativeMethodInfoPtr_get_ETag_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDirectResponseSchema>.NativeClassPtr, 100663603);
			IDirectResponseSchema.NativeMethodInfoPtr_set_ETag_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDirectResponseSchema>.NativeClassPtr, 100663604);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000A718 File Offset: 0x00008918
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000A75C File Offset: 0x0000895C
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDirectResponseSchema.NativeMethodInfoPtr_get_ETag_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDirectResponseSchema.NativeMethodInfoPtr_set_ETag_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002751 File Offset: 0x00000951
		public IDirectResponseSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Abstract_Virtual_New_set_Void_String_0;
	}
}
