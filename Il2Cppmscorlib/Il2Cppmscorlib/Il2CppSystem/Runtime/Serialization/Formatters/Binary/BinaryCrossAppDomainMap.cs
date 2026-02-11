using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000357 RID: 855
	public sealed class BinaryCrossAppDomainMap : Object
	{
		// Token: 0x06003327 RID: 13095 RVA: 0x00101524 File Offset: 0x000FF724
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainMap()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr);
			BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, "crossAppDomainArrayIndex");
			BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671263);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671264);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671265);
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x001015A4 File Offset: 0x000FF7A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x001015E0 File Offset: 0x000FF7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387270, RefRangeEnd = 1387272, XrefRangeStart = 1387269, XrefRangeEnd = 1387270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00101624 File Offset: 0x000FF824
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00011D2E File Offset: 0x0000FF2E
		public BinaryCrossAppDomainMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600332C RID: 13100 RVA: 0x00101658 File Offset: 0x000FF858
		// (set) Token: 0x0600332D RID: 13101 RVA: 0x00011D37 File Offset: 0x0000FF37
		public unsafe int crossAppDomainArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex)) = value;
			}
		}

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArrayIndex;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
