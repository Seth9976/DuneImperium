using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F5 RID: 245
	public class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement
	{
		// Token: 0x06001684 RID: 5764 RVA: 0x0007740C File Offset: 0x0007560C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberExpandable()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberExpandable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr);
			XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, "_flatArrayIndex");
			XmlTypeMapMemberExpandable.NativeMethodInfoPtr_get_FlatArrayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, 100666869);
			XmlTypeMapMemberExpandable.NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, 100666870);
			XmlTypeMapMemberExpandable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr, 100666871);
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x0007748C File Offset: 0x0007568C
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x000774C8 File Offset: 0x000756C8
		public unsafe int FlatArrayIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberExpandable.NativeMethodInfoPtr_get_FlatArrayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberExpandable.NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00077508 File Offset: 0x00075708
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 389801, RefRangeEnd = 389807, XrefRangeStart = 389801, XrefRangeEnd = 389807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberExpandable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberExpandable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberExpandable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000098BF File Offset: 0x00007ABF
		public XmlTypeMapMemberExpandable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00077544 File Offset: 0x00075744
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x000098C8 File Offset: 0x00007AC8
		public unsafe int _flatArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberExpandable.NativeFieldInfoPtr__flatArrayIndex)) = value;
			}
		}

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr__flatArrayIndex;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_get_FlatArrayIndex_Public_get_Int32_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_set_FlatArrayIndex_Public_set_Void_Int32_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
