using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200013A RID: 314
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x000640F4 File Offset: 0x000622F4
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyChangingEventArgs()
		{
			Il2CppClassPointerStore<PropertyChangingEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "PropertyChangingEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyChangingEventArgs>.NativeClassPtr);
			PropertyChangingEventArgs.NativeFieldInfoPtr__propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyChangingEventArgs>.NativeClassPtr, "_propertyName");
			PropertyChangingEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyChangingEventArgs>.NativeClassPtr, 100666020);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0006414C File Offset: 0x0006234C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460705, RefRangeEnd = 460706, XrefRangeStart = 460700, XrefRangeEnd = 460705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyChangingEventArgs(string propertyName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyChangingEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyChangingEventArgs.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00008906 File Offset: 0x00006B06
		public PropertyChangingEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00064198 File Offset: 0x00062398
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x0000890F File Offset: 0x00006B0F
		public unsafe string _propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyChangingEventArgs.NativeFieldInfoPtr__propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyChangingEventArgs.NativeFieldInfoPtr__propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeFieldInfoPtr__propertyName;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
