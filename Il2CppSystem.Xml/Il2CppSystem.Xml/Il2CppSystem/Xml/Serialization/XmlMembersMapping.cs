using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DB RID: 219
	[DefaultMember("Item")]
	public class XmlMembersMapping : XmlMapping
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x0006D070 File Offset: 0x0006B270
		// Note: this type is marked as 'beforefieldinit'.
		static XmlMembersMapping()
		{
			Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlMembersMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr);
			XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, "_hasWrapperElement");
			XmlMembersMapping.NativeFieldInfoPtr__mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, "_mapping");
			XmlMembersMapping.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, 100666511);
			XmlMembersMapping.NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlMembersMapping>.NativeClassPtr, 100666512);
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMembersMapping.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x0006D12C File Offset: 0x0006B32C
		public unsafe bool HasWrapperElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlMembersMapping.NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00008A02 File Offset: 0x00006C02
		public XmlMembersMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x0006D168 File Offset: 0x0006B368
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x00008A0B File Offset: 0x00006C0B
		public unsafe bool _hasWrapperElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__hasWrapperElement)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x0006D190 File Offset: 0x0006B390
		// (set) Token: 0x0600142C RID: 5164 RVA: 0x00008A26 File Offset: 0x00006C26
		public unsafe Il2CppReferenceArray<XmlMemberMapping> _mapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__mapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlMemberMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlMembersMapping.NativeFieldInfoPtr__mapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr__hasWrapperElement;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr__mapping;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_get_HasWrapperElement_Internal_get_Boolean_0;
	}
}
