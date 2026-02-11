using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000144 RID: 324
	public class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x00089FE0 File Offset: 0x000881E0
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_year()
		{
			Il2CppClassPointerStore<Datatype_year>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_year");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr);
			Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100667435);
			Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100667436);
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0008A038 File Offset: 0x00088238
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0008A080 File Offset: 0x00088280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394383, XrefRangeEnd = 394387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_year()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0000BBBA File Offset: 0x00009DBA
		public Datatype_year(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
