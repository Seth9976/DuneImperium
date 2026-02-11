using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x0200005B RID: 91
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0001E9FC File Offset: 0x0001CBFC
		// Note: this type is marked as 'beforefieldinit'.
		static MeansImplicitUseAttribute()
		{
			Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "MeansImplicitUseAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr);
			MeansImplicitUseAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr, "<UseKindFlags>k__BackingField");
			MeansImplicitUseAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr, "<TargetFlags>k__BackingField");
			MeansImplicitUseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr, 100663583);
			MeansImplicitUseAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr, 100663584);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001EA7C File Offset: 0x0001CC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeansImplicitUseAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeansImplicitUseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001EAB8 File Offset: 0x0001CCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeansImplicitUseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useKindFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeansImplicitUseAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003912 File Offset: 0x00001B12
		public MeansImplicitUseAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0001EB10 File Offset: 0x0001CD10
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe ImplicitUseKindFlags _UseKindFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeansImplicitUseAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeansImplicitUseAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0001EB38 File Offset: 0x0001CD38
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003936 File Offset: 0x00001B36
		public unsafe ImplicitUseTargetFlags _TargetFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeansImplicitUseAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeansImplicitUseAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00003951 File Offset: 0x00001B51
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				return this._UseKindFlags_k__BackingField;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00003959 File Offset: 0x00001B59
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				return this._TargetFlags_k__BackingField;
			}
		}

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr__UseKindFlags_k__BackingField;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr__TargetFlags_k__BackingField;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0;
	}
}
