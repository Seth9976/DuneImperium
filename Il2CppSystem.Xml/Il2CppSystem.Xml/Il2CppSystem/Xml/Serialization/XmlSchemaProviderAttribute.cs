using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000E0 RID: 224
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x0006EA0C File Offset: 0x0006CC0C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaProviderAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSchemaProviderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr);
			XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, "_methodName");
			XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, "_isAny");
			XmlSchemaProviderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666561);
			XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666562);
			XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666563);
			XmlSchemaProviderAttribute.NativeMethodInfoPtr_set_IsAny_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr, 100666564);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0006EAB4 File Offset: 0x0006CCB4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaProviderAttribute(string methodName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaProviderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0006EB00 File Offset: 0x0006CD00
		public unsafe string MethodName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0006EB38 File Offset: 0x0006CD38
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x0006EB74 File Offset: 0x0006CD74
		public unsafe bool IsAny
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaProviderAttribute.NativeMethodInfoPtr_set_IsAny_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00008CA6 File Offset: 0x00006EA6
		public XmlSchemaProviderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0006EBB4 File Offset: 0x0006CDB4
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x00008CAF File Offset: 0x00006EAF
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0006EBDC File Offset: 0x0006CDDC
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x00008CCE File Offset: 0x00006ECE
		public unsafe bool _isAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaProviderAttribute.NativeFieldInfoPtr__isAny)) = value;
			}
		}

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeFieldInfoPtr__isAny;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_get_String_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAny_Public_get_Boolean_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAny_Public_set_Void_Boolean_0;
	}
}
