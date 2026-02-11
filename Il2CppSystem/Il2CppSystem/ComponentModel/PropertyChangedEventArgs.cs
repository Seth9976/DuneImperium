using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000138 RID: 312
	public class PropertyChangedEventArgs : EventArgs
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x00063F28 File Offset: 0x00062128
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyChangedEventArgs()
		{
			Il2CppClassPointerStore<PropertyChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "PropertyChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyChangedEventArgs>.NativeClassPtr);
			PropertyChangedEventArgs.NativeFieldInfoPtr__propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyChangedEventArgs>.NativeClassPtr, "_propertyName");
			PropertyChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangedEventArgs>.NativeClassPtr, 100666017);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00063F80 File Offset: 0x00062180
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 460690, RefRangeEnd = 460700, XrefRangeStart = 460685, XrefRangeEnd = 460690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyChangedEventArgs(string propertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyChangedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000088AE File Offset: 0x00006AAE
		public PropertyChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00063FCC File Offset: 0x000621CC
		// (set) Token: 0x060012AC RID: 4780 RVA: 0x000088B7 File Offset: 0x00006AB7
		public unsafe string _propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyChangedEventArgs.NativeFieldInfoPtr__propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyChangedEventArgs.NativeFieldInfoPtr__propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeFieldInfoPtr__propertyName;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
