using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000145 RID: 325
	public class ITransform : Il2CppObjectBase
	{
		// Token: 0x06001832 RID: 6194 RVA: 0x00072AC4 File Offset: 0x00070CC4
		// Note: this type is marked as 'beforefieldinit'.
		static ITransform()
		{
			Il2CppClassPointerStore<ITransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ITransform");
			ITransform.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransform>.NativeClassPtr, 100666883);
			ITransform.NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransform>.NativeClassPtr, 100666884);
			ITransform.NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransform>.NativeClassPtr, 100666885);
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00072B28 File Offset: 0x00070D28
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00072B70 File Offset: 0x00070D70
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransform.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransform.NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00072BBC File Offset: 0x00070DBC
		public unsafe virtual Vector3 scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransform.NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0000B23C File Offset: 0x0000943C
		public ITransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector3_0;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Vector3_0;
	}
}
