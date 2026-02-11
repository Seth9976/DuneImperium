using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000026 RID: 38
	public class IDtdParserAdapterWithValidation : Il2CppObjectBase
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x0002072C File Offset: 0x0001E92C
		// Note: this type is marked as 'beforefieldinit'.
		static IDtdParserAdapterWithValidation()
		{
			Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdParserAdapterWithValidation");
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663664);
			IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdParserAdapterWithValidation>.NativeClassPtr, 100663665);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0002077C File Offset: 0x0001E97C
		public unsafe virtual bool DtdValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000207C4 File Offset: 0x0001E9C4
		public unsafe virtual IValidationEventHandling ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDtdParserAdapterWithValidation.NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002FCC File Offset: 0x000011CC
		public IDtdParserAdapterWithValidation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationEventHandling_Public_Abstract_Virtual_New_get_IValidationEventHandling_0;
	}
}
