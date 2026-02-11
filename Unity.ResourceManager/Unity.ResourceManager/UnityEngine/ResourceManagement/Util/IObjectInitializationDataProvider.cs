using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001F RID: 31
	public class IObjectInitializationDataProvider : Il2CppObjectBase
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000BD94 File Offset: 0x00009F94
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectInitializationDataProvider()
		{
			Il2CppClassPointerStore<IObjectInitializationDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "IObjectInitializationDataProvider");
			IObjectInitializationDataProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectInitializationDataProvider>.NativeClassPtr, 100663616);
			IObjectInitializationDataProvider.NativeMethodInfoPtr_CreateObjectInitializationData_Public_Abstract_Virtual_New_ObjectInitializationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectInitializationDataProvider>.NativeClassPtr, 100663617);
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000BDE4 File Offset: 0x00009FE4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectInitializationDataProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000BE28 File Offset: 0x0000A028
		[CallerCount(0)]
		public unsafe virtual ObjectInitializationData CreateObjectInitializationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectInitializationDataProvider.NativeMethodInfoPtr_CreateObjectInitializationData_Public_Abstract_Virtual_New_ObjectInitializationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ObjectInitializationData(intPtr);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002B3A File Offset: 0x00000D3A
		public IObjectInitializationDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectInitializationData_Public_Abstract_Virtual_New_ObjectInitializationData_0;
	}
}
