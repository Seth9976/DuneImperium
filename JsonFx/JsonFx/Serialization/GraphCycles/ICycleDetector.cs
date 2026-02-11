using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace JsonFx.Serialization.GraphCycles
{
	// Token: 0x0200001D RID: 29
	public class ICycleDetector : Il2CppObjectBase
	{
		// Token: 0x0600014C RID: 332 RVA: 0x000088D8 File Offset: 0x00006AD8
		// Note: this type is marked as 'beforefieldinit'.
		static ICycleDetector()
		{
			Il2CppClassPointerStore<ICycleDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.GraphCycles", "ICycleDetector");
			ICycleDetector.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICycleDetector>.NativeClassPtr, 100663441);
			ICycleDetector.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICycleDetector>.NativeClassPtr, 100663442);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00008928 File Offset: 0x00006B28
		[CallerCount(0)]
		public unsafe virtual bool Add(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICycleDetector.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008980 File Offset: 0x00006B80
		[CallerCount(0)]
		public unsafe virtual void Remove(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICycleDetector.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002880 File Offset: 0x00000A80
		public ICycleDetector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
