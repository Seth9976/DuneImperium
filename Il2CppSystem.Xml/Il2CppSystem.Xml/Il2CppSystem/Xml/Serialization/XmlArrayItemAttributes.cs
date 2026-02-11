using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CC RID: 204
	public class XmlArrayItemAttributes : CollectionBase
	{
		// Token: 0x06001374 RID: 4980 RVA: 0x0006AC28 File Offset: 0x00068E28
		// Note: this type is marked as 'beforefieldinit'.
		static XmlArrayItemAttributes()
		{
			Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlArrayItemAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr);
			XmlArrayItemAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlArrayItemAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666437);
			XmlArrayItemAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666438);
			XmlArrayItemAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666439);
			XmlArrayItemAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr, 100666440);
		}

		// Token: 0x1700063A RID: 1594
		public unsafe XmlArrayItemAttribute this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385222, XrefRangeEnd = 385228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlArrayItemAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlArrayItemAttribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0006ACF4 File Offset: 0x00068EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385233, RefRangeEnd = 385234, XrefRangeStart = 385228, XrefRangeEnd = 385233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlArrayItemAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0006AD44 File Offset: 0x00068F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385263, RefRangeEnd = 385264, XrefRangeStart = 385234, XrefRangeEnd = 385263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0006AD88 File Offset: 0x00068F88
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlArrayItemAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlArrayItemAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlArrayItemAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0000847C File Offset: 0x0000667C
		public XmlArrayItemAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlArrayItemAttribute_Int32_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlArrayItemAttribute_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
