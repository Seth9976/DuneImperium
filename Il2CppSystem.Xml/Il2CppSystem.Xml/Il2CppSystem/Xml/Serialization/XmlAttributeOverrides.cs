using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000CE RID: 206
	public class XmlAttributeOverrides : Object
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x0006B16C File Offset: 0x0006936C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeOverrides()
		{
			Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeOverrides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr);
			XmlAttributeOverrides.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, "overrides");
			XmlAttributeOverrides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666448);
			XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666449);
			XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666450);
			XmlAttributeOverrides.NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666451);
			XmlAttributeOverrides.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100666452);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x0006B214 File Offset: 0x00069414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385282, XrefRangeEnd = 385288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeOverrides()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000645 RID: 1605
		public unsafe XmlAttributes this[Type type]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385288, XrefRangeEnd = 385291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000646 RID: 1606
		public unsafe XmlAttributes this[Type type, string member]
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 385297, RefRangeEnd = 385302, XrefRangeStart = 385291, XrefRangeEnd = 385297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0006B304 File Offset: 0x00069504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385302, XrefRangeEnd = 385306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeMember GetKey(Type type, string member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeMember>(intPtr3) : null;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x0006B368 File Offset: 0x00069568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385346, RefRangeEnd = 385347, XrefRangeStart = 385306, XrefRangeEnd = 385346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeOverrides.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00008525 File Offset: 0x00006725
		public XmlAttributeOverrides(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0006B3AC File Offset: 0x000695AC
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0000852E File Offset: 0x0000672E
		public unsafe Hashtable overrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeOverrides.NativeFieldInfoPtr_overrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeOverrides.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
