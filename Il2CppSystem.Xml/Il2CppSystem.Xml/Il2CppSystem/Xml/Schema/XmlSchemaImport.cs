using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CB RID: 459
	public class XmlSchemaImport : XmlSchemaExternal
	{
		// Token: 0x06002688 RID: 9864 RVA: 0x000B4788 File Offset: 0x000B2988
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaImport()
		{
			Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaImport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr);
			XmlSchemaImport.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, "ns");
			XmlSchemaImport.NativeFieldInfoPtr_annotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, "annotation");
			XmlSchemaImport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668862);
			XmlSchemaImport.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668863);
			XmlSchemaImport.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668864);
			XmlSchemaImport.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr, 100668865);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000B4830 File Offset: 0x000B2A30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 412395, RefRangeEnd = 412398, XrefRangeStart = 412394, XrefRangeEnd = 412395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaImport()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaImport>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x000B486C File Offset: 0x000B2A6C
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x000B48A4 File Offset: 0x000B2AA4
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaImport.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000B48E8 File Offset: 0x000B2AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAnnotation(XmlSchemaAnnotation annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaImport.NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00010618 File Offset: 0x0000E818
		public XmlSchemaImport(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x000B4938 File Offset: 0x000B2B38
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00010621 File Offset: 0x0000E821
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x000B4960 File Offset: 0x000B2B60
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x00010640 File Offset: 0x0000E840
		public unsafe XmlSchemaAnnotation annotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_annotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnnotation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaImport.NativeFieldInfoPtr_annotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeFieldInfoPtr_annotation;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Internal_Virtual_Void_XmlSchemaAnnotation_0;
	}
}
