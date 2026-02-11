using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EE RID: 238
	public class XmlDeclarationWrapper : XmlNodeWrapper
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x0006F3A4 File Offset: 0x0006D5A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDeclarationWrapper()
		{
			Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlDeclarationWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr);
			XmlDeclarationWrapper.NativeFieldInfoPtr__declaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, "_declaration");
			XmlDeclarationWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667157);
			XmlDeclarationWrapper.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667158);
			XmlDeclarationWrapper.NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667159);
			XmlDeclarationWrapper.NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667160);
			XmlDeclarationWrapper.NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667161);
			XmlDeclarationWrapper.NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr, 100667162);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0006F460 File Offset: 0x0006D660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDeclarationWrapper(XmlDeclaration declaration)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDeclarationWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaration);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		public unsafe virtual string Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0006F4E4 File Offset: 0x0006D6E4
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0006F51C File Offset: 0x0006D71C
		public unsafe virtual string Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765145, XrefRangeEnd = 765147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0006F560 File Offset: 0x0006D760
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0006F598 File Offset: 0x0006D798
		public unsafe virtual string Standalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765147, XrefRangeEnd = 765149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDeclarationWrapper.NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00008320 File Offset: 0x00006520
		public XmlDeclarationWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00008329 File Offset: 0x00006529
		public unsafe XmlDeclaration _declaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclarationWrapper.NativeFieldInfoPtr__declaration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDeclarationWrapper.NativeFieldInfoPtr__declaration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeFieldInfoPtr__declaration;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDeclaration_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_set_Encoding_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_set_Standalone_Public_Virtual_Final_New_set_Void_String_0;
	}
}
