using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000027 RID: 39
	public class IDtdParserAdapterV1 : Il2CppObjectBase
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00020810 File Offset: 0x0001EA10
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterV1()
		{
			Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterV1");
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663666);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663667);
			IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterV1>.NativeClassPtr, 100663668);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00020874 File Offset: 0x0001EA74
		public unsafe virtual bool V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000208BC File Offset: 0x0001EABC
		public unsafe virtual bool Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00020904 File Offset: 0x0001EB04
		public unsafe virtual bool Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterV1.NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002FD5 File Offset: 0x000011D5
		public IDtdParserAdapterV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_get_V1CompatibilityMode_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalization_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
