using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x0200005A RID: 90
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x060002FD RID: 765 RVA: 0x0001E898 File Offset: 0x0001CA98
		// Note: this type is marked as 'beforefieldinit'.
		static UsedImplicitlyAttribute()
		{
			Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "UsedImplicitlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr);
			UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<UseKindFlags>k__BackingField");
			UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<TargetFlags>k__BackingField");
			UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663581);
			UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663582);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001E918 File Offset: 0x0001CB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644282, XrefRangeEnd = 644283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedImplicitlyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001E954 File Offset: 0x0001CB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644283, XrefRangeEnd = 644284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useKindFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000038C3 File Offset: 0x00001AC3
		public UsedImplicitlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000038CC File Offset: 0x00001ACC
		public unsafe ImplicitUseKindFlags _UseKindFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001E9D4 File Offset: 0x0001CBD4
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000038E7 File Offset: 0x00001AE7
		public unsafe ImplicitUseTargetFlags _TargetFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00003902 File Offset: 0x00001B02
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				return this._UseKindFlags_k__BackingField;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000390A File Offset: 0x00001B0A
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				return this._TargetFlags_k__BackingField;
			}
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr__UseKindFlags_k__BackingField;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr__TargetFlags_k__BackingField;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0;
	}
}
