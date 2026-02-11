using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F6 RID: 246
	public class XDeclarationWrapper : XObjectWrapper
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x00070D48 File Offset: 0x0006EF48
		// Note: this type is marked as 'beforefieldinit'.
		static XDeclarationWrapper()
		{
			Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XDeclarationWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr);
			XDeclarationWrapper.NativeFieldInfoPtr__Declaration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, "<Declaration>k__BackingField");
			XDeclarationWrapper.NativeMethodInfoPtr_get_Declaration_Internal_get_XDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667218);
			XDeclarationWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667219);
			XDeclarationWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667220);
			XDeclarationWrapper.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667221);
			XDeclarationWrapper.NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667222);
			XDeclarationWrapper.NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667223);
			XDeclarationWrapper.NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667224);
			XDeclarationWrapper.NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr, 100667225);
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00070E2C File Offset: 0x0006F02C
		public unsafe XDeclaration Declaration
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_get_Declaration_Internal_get_XDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDeclaration>(intPtr3) : null;
			}
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00070E6C File Offset: 0x0006F06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765260, RefRangeEnd = 765261, XrefRangeStart = 765257, XrefRangeEnd = 765260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDeclarationWrapper(XDeclaration declaration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDeclarationWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00070EB8 File Offset: 0x0006F0B8
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDeclarationWrapper.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00070F00 File Offset: 0x0006F100
		public unsafe virtual string Version
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00070F38 File Offset: 0x0006F138
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00070F70 File Offset: 0x0006F170
		public unsafe virtual string Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765261, XrefRangeEnd = 765263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00070FB4 File Offset: 0x0006F1B4
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x00070FEC File Offset: 0x0006F1EC
		public unsafe virtual string Standalone
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 373348, RefRangeEnd = 373350, XrefRangeStart = 373348, XrefRangeEnd = 373350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDeclarationWrapper.NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00008403 File Offset: 0x00006603
		public XDeclarationWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x00071030 File Offset: 0x0006F230
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x0000840C File Offset: 0x0000660C
		public unsafe XDeclaration _Declaration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDeclarationWrapper.NativeFieldInfoPtr__Declaration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XDeclaration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDeclarationWrapper.NativeFieldInfoPtr__Declaration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr__Declaration_k__BackingField;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeMethodInfoPtr_get_Declaration_Internal_get_XDeclaration_0;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XDeclaration_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0;
	}
}
