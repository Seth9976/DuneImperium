using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000DF RID: 223
	public class XmlRootAttribute : Attribute
	{
		// Token: 0x06001470 RID: 5232 RVA: 0x0006E554 File Offset: 0x0006C754
		// Note: this type is marked as 'beforefieldinit'.
		static XmlRootAttribute()
		{
			Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlRootAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr);
			XmlRootAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, "dataType");
			XmlRootAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, "elementName");
			XmlRootAttribute.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, "isNullable");
			XmlRootAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, "ns");
			XmlRootAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666550);
			XmlRootAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666551);
			XmlRootAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666552);
			XmlRootAttribute.NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666553);
			XmlRootAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666554);
			XmlRootAttribute.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666555);
			XmlRootAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666556);
			XmlRootAttribute.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666557);
			XmlRootAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666558);
			XmlRootAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666559);
			XmlRootAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr, 100666560);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0006E6B0 File Offset: 0x0006C8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387008, RefRangeEnd = 387009, XrefRangeStart = 387007, XrefRangeEnd = 387008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlRootAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x0006E6EC File Offset: 0x0006C8EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 387011, RefRangeEnd = 387016, XrefRangeStart = 387009, XrefRangeEnd = 387011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlRootAttribute(string elementName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlRootAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0006E738 File Offset: 0x0006C938
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x0006E770 File Offset: 0x0006C970
		public unsafe string DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 387017, RefRangeEnd = 387018, XrefRangeStart = 387016, XrefRangeEnd = 387017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0006E7EC File Offset: 0x0006C9EC
		public unsafe string ElementName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 387019, RefRangeEnd = 387022, XrefRangeStart = 387018, XrefRangeEnd = 387019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0006E830 File Offset: 0x0006CA30
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x0006E86C File Offset: 0x0006CA6C
		public unsafe bool IsNullable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0006E8AC File Offset: 0x0006CAAC
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
		public unsafe string Namespace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0006E928 File Offset: 0x0006CB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 387031, RefRangeEnd = 387032, XrefRangeStart = 387022, XrefRangeEnd = 387031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlRootAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x00008C25 File Offset: 0x00006E25
		public XmlRootAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0006E96C File Offset: 0x0006CB6C
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x00008C2E File Offset: 0x00006E2E
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0006E994 File Offset: 0x0006CB94
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x00008C4D File Offset: 0x00006E4D
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x00008C6C File Offset: 0x00006E6C
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00008C87 File Offset: 0x00006E87
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlRootAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_set_DataType_Public_set_Void_String_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
