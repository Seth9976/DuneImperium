using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001E0 RID: 480
	public class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup
	{
		// Token: 0x06002820 RID: 10272 RVA: 0x000BAA14 File Offset: 0x000B8C14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSubstitutionGroupV1Compat()
		{
			Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSubstitutionGroupV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr);
			XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, "choice");
			XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, 100669096);
			XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr, 100669097);
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000BAA80 File Offset: 0x000B8C80
		public unsafe XmlSchemaChoice Choice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000BAAC0 File Offset: 0x000B8CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414721, RefRangeEnd = 414722, XrefRangeStart = 414705, XrefRangeEnd = 414721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSubstitutionGroupV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSubstitutionGroupV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSubstitutionGroupV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00010FE6 File Offset: 0x0000F1E6
		public XmlSchemaSubstitutionGroupV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x000BAAFC File Offset: 0x000B8CFC
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x00010FEF File Offset: 0x0000F1EF
		public unsafe XmlSchemaChoice choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSubstitutionGroupV1Compat.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_get_Choice_Internal_get_XmlSchemaChoice_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
