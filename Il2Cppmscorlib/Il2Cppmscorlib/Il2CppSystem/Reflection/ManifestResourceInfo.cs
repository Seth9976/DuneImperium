using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000413 RID: 1043
	public class ManifestResourceInfo : Object
	{
		// Token: 0x06003C16 RID: 15382 RVA: 0x00120284 File Offset: 0x0011E484
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestResourceInfo()
		{
			Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ManifestResourceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr);
			ManifestResourceInfo.NativeFieldInfoPtr__ReferencedAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "<ReferencedAssembly>k__BackingField");
			ManifestResourceInfo.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "<FileName>k__BackingField");
			ManifestResourceInfo.NativeFieldInfoPtr__ResourceLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "<ResourceLocation>k__BackingField");
			ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100672260);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100672261);
			ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100672262);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100672263);
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00120340 File Offset: 0x0011E540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containingFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resourceLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06003C18 RID: 15384 RVA: 0x001203AC File Offset: 0x0011E5AC
		public unsafe virtual Assembly ReferencedAssembly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x001203F8 File Offset: 0x0011E5F8
		public unsafe virtual string FileName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06003C1A RID: 15386 RVA: 0x0012043C File Offset: 0x0011E63C
		public unsafe virtual ResourceLocation ResourceLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0001653F File Offset: 0x0001473F
		public ManifestResourceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003C1C RID: 15388 RVA: 0x00120484 File Offset: 0x0011E684
		// (set) Token: 0x06003C1D RID: 15389 RVA: 0x00016548 File Offset: 0x00014748
		public unsafe Assembly _ReferencedAssembly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__ReferencedAssembly_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__ReferencedAssembly_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003C1E RID: 15390 RVA: 0x001204B4 File Offset: 0x0011E6B4
		// (set) Token: 0x06003C1F RID: 15391 RVA: 0x00016567 File Offset: 0x00014767
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003C20 RID: 15392 RVA: 0x001204DC File Offset: 0x0011E6DC
		// (set) Token: 0x06003C21 RID: 15393 RVA: 0x00016586 File Offset: 0x00014786
		public unsafe ResourceLocation _ResourceLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__ResourceLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__ResourceLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeFieldInfoPtr__ReferencedAssembly_k__BackingField;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeFieldInfoPtr__ResourceLocation_k__BackingField;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0;
	}
}
