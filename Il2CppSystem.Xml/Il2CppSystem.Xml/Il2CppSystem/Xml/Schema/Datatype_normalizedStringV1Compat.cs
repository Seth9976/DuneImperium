using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200014D RID: 333
	public class Datatype_normalizedStringV1Compat : Datatype_string
	{
		// Token: 0x06001BF3 RID: 7155 RVA: 0x0008B86C File Offset: 0x00089A6C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_normalizedStringV1Compat()
		{
			Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_normalizedStringV1Compat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr);
			Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr, 100667492);
			Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr, 100667493);
			Datatype_normalizedStringV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr, 100667494);
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0008B8D8 File Offset: 0x00089AD8
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 73337, RefRangeEnd = 73340, XrefRangeStart = 73337, XrefRangeEnd = 73340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0008B920 File Offset: 0x00089B20
		public unsafe override bool HasValueFacets
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_normalizedStringV1Compat.NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0008B968 File Offset: 0x00089B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_normalizedStringV1Compat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_normalizedStringV1Compat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_normalizedStringV1Compat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0000BC9B File Offset: 0x00009E9B
		public Datatype_normalizedStringV1Compat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValueFacets_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
