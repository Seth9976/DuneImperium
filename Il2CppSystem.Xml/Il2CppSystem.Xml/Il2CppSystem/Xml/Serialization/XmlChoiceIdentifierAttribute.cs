using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D0 RID: 208
	public class XmlChoiceIdentifierAttribute : Attribute
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0006BD94 File Offset: 0x00069F94
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChoiceIdentifierAttribute()
		{
			Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlChoiceIdentifierAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr);
			XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, "memberName");
			XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, 100666471);
			XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, 100666472);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0006BE00 File Offset: 0x0006A000
		public unsafe string MemberName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385577, XrefRangeEnd = 385578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0006BE38 File Offset: 0x0006A038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385578, XrefRangeEnd = 385584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChoiceIdentifierAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00008700 File Offset: 0x00006900
		public XmlChoiceIdentifierAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0006BE7C File Offset: 0x0006A07C
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00008709 File Offset: 0x00006909
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChoiceIdentifierAttribute.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
