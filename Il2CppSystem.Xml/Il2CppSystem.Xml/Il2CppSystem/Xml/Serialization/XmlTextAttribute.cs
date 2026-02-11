using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000ED RID: 237
	public class XmlTextAttribute : Attribute
	{
		// Token: 0x060015DE RID: 5598 RVA: 0x00074F2C File Offset: 0x0007312C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextAttribute()
		{
			Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTextAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr);
			XmlTextAttribute.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, "dataType");
			XmlTextAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, "type");
			XmlTextAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, 100666787);
			XmlTextAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, 100666788);
			XmlTextAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, 100666789);
			XmlTextAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr, 100666790);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00074FD4 File Offset: 0x000731D4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00075010 File Offset: 0x00073210
		public unsafe string DataType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389576, RefRangeEnd = 389577, XrefRangeStart = 389575, XrefRangeEnd = 389576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextAttribute.NativeMethodInfoPtr_get_DataType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00075048 File Offset: 0x00073248
		public unsafe Type Type
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00075088 File Offset: 0x00073288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389584, RefRangeEnd = 389585, XrefRangeStart = 389577, XrefRangeEnd = 389584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00009417 File Offset: 0x00007617
		public XmlTextAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x000750CC File Offset: 0x000732CC
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x00009420 File Offset: 0x00007620
		public unsafe string dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextAttribute.NativeFieldInfoPtr_dataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextAttribute.NativeFieldInfoPtr_dataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000750F4 File Offset: 0x000732F4
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000943F File Offset: 0x0000763F
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_get_DataType_Public_get_String_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
