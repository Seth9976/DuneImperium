using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A4 RID: 420
	public sealed class XmlSchemaCompilationSettings : Object
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x000AD5D4 File Offset: 0x000AB7D4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCompilationSettings()
		{
			Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCompilationSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr);
			XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, "enableUpaCheck");
			XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100668604);
			XmlSchemaCompilationSettings.NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr, 100668605);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000AD640 File Offset: 0x000AB840
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 344029, RefRangeEnd = 344037, XrefRangeStart = 344029, XrefRangeEnd = 344037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCompilationSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCompilationSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCompilationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000AD67C File Offset: 0x000AB87C
		public unsafe bool EnableUpaCheck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCompilationSettings.NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0000F7D5 File Offset: 0x0000D9D5
		public XmlSchemaCompilationSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000AD6B8 File Offset: 0x000AB8B8
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0000F7DE File Offset: 0x0000D9DE
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCompilationSettings.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x04001B9F RID: 7071
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x04001BA0 RID: 7072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BA1 RID: 7073
		private static readonly IntPtr NativeMethodInfoPtr_get_EnableUpaCheck_Public_get_Boolean_0;
	}
}
