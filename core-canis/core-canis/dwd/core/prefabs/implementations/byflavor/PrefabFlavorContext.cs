using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.prefabs.implementations.byflavor
{
	// Token: 0x02000117 RID: 279
	public sealed class PrefabFlavorContext : ValueType
	{
		// Token: 0x06000FC7 RID: 4039 RVA: 0x0005219C File Offset: 0x0005039C
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabFlavorContext()
		{
			Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.implementations.byflavor", "PrefabFlavorContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr);
			PrefabFlavorContext.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, "flavors");
			PrefabFlavorContext.NativeMethodInfoPtr_get_Flavors_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665603);
			PrefabFlavorContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665604);
			PrefabFlavorContext.NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665605);
			PrefabFlavorContext.NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665606);
			PrefabFlavorContext.NativeMethodInfoPtr_Match_Public_Virtual_Final_New_Boolean_PrefabFlavorsMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665607);
			PrefabFlavorContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665608);
			PrefabFlavorContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabFlavorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, 100665609);
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0005226C File Offset: 0x0005046C
		public unsafe ICollection<string> Flavors
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 868872, RefRangeEnd = 868888, XrefRangeStart = 868865, XrefRangeEnd = 868872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_get_Flavors_Public_get_ICollection_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000522B0 File Offset: 0x000504B0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 868895, RefRangeEnd = 868932, XrefRangeStart = 868888, XrefRangeEnd = 868895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabFlavorContext(IEnumerable<string> flavors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00052300 File Offset: 0x00050500
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 868949, RefRangeEnd = 868967, XrefRangeStart = 868932, XrefRangeEnd = 868949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabFlavorContext WithFlavors([Optional] Il2CppStringArray newFlavors)
		{
			if (newFlavors == null)
			{
				newFlavors = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PrefabFlavorContext(intPtr);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0005235C File Offset: 0x0005055C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 868990, RefRangeEnd = 868996, XrefRangeStart = 868967, XrefRangeEnd = 868990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabFlavorContext WithFlavors(IEnumerable<string> newFlavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_IEnumerable_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new PrefabFlavorContext(intPtr);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000523AC File Offset: 0x000505AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 869004, RefRangeEnd = 869006, XrefRangeStart = 868996, XrefRangeEnd = 869004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(PrefabFlavorsMetaData metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(metadata));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_Match_Public_Virtual_Final_New_Boolean_PrefabFlavorsMetaData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00052404 File Offset: 0x00050604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 869006, XrefRangeEnd = 869019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00052440 File Offset: 0x00050640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 869023, RefRangeEnd = 869024, XrefRangeStart = 869019, XrefRangeEnd = 869023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PrefabFlavorContext other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabFlavorContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabFlavorContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00007685 File Offset: 0x00005885
		public PrefabFlavorContext WithFlavors(params string[] newFlavors)
		{
			return this.WithFlavors(new Il2CppStringArray(newFlavors));
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00007693 File Offset: 0x00005893
		public PrefabFlavorContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0000769C File Offset: 0x0000589C
		public PrefabFlavorContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00052498 File Offset: 0x00050698
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x000076AE File Offset: 0x000058AE
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorContext.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabFlavorContext.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_get_ICollection_1_String_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_Il2CppStringArray_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavors_Public_PrefabFlavorContext_IEnumerable_1_String_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Virtual_Final_New_Boolean_PrefabFlavorsMetaData_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabFlavorContext_0;
	}
}
