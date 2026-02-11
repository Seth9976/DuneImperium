using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Data
{
	// Token: 0x02000045 RID: 69
	public sealed class DataTableTypeConverter : ReferenceConverter
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x000287B8 File Offset: 0x000269B8
		// Note: this type is marked as 'beforefieldinit'.
		static DataTableTypeConverter()
		{
			Il2CppClassPointerStore<DataTableTypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataTableTypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataTableTypeConverter>.NativeClassPtr);
			DataTableTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableTypeConverter>.NativeClassPtr, 100664531);
			DataTableTypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataTableTypeConverter>.NativeClassPtr, 100664532);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00028810 File Offset: 0x00026A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901896, XrefRangeEnd = 901906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTableTypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataTableTypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableTypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0002884C File Offset: 0x00026A4C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataTableTypeConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000421E File Offset: 0x0000241E
		public DataTableTypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;
	}
}
