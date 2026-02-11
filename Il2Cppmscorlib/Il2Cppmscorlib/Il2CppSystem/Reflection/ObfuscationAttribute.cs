using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200041D RID: 1053
	public sealed class ObfuscationAttribute : Attribute
	{
		// Token: 0x06003C8A RID: 15498 RVA: 0x00122600 File Offset: 0x00120800
		// Note: this type is marked as 'beforefieldinit'.
		static ObfuscationAttribute()
		{
			Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ObfuscationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr);
			ObfuscationAttribute.NativeFieldInfoPtr__StripAfterObfuscation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, "<StripAfterObfuscation>k__BackingField");
			ObfuscationAttribute.NativeFieldInfoPtr__Exclude_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, "<Exclude>k__BackingField");
			ObfuscationAttribute.NativeFieldInfoPtr__ApplyToMembers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, "<ApplyToMembers>k__BackingField");
			ObfuscationAttribute.NativeFieldInfoPtr__Feature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, "<Feature>k__BackingField");
			ObfuscationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, 100672346);
			ObfuscationAttribute.NativeMethodInfoPtr_set_StripAfterObfuscation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, 100672347);
			ObfuscationAttribute.NativeMethodInfoPtr_set_Exclude_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, 100672348);
			ObfuscationAttribute.NativeMethodInfoPtr_set_ApplyToMembers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr, 100672349);
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x001226D0 File Offset: 0x001208D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398965, XrefRangeEnd = 1398970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObfuscationAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscationAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E22 RID: 3618
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x0012270C File Offset: 0x0012090C
		public unsafe bool StripAfterObfuscation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscationAttribute.NativeMethodInfoPtr_set_StripAfterObfuscation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (set) Token: 0x06003C8D RID: 15501 RVA: 0x0012274C File Offset: 0x0012094C
		public unsafe bool Exclude
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscationAttribute.NativeMethodInfoPtr_set_Exclude_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x0012278C File Offset: 0x0012098C
		public unsafe bool ApplyToMembers
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscationAttribute.NativeMethodInfoPtr_set_ApplyToMembers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00016650 File Offset: 0x00014850
		public ObfuscationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x001227CC File Offset: 0x001209CC
		// (set) Token: 0x06003C91 RID: 15505 RVA: 0x00016659 File Offset: 0x00014859
		public unsafe bool _StripAfterObfuscation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__StripAfterObfuscation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__StripAfterObfuscation_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x001227F4 File Offset: 0x001209F4
		// (set) Token: 0x06003C93 RID: 15507 RVA: 0x00016674 File Offset: 0x00014874
		public unsafe bool _Exclude_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__Exclude_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__Exclude_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x0012281C File Offset: 0x00120A1C
		// (set) Token: 0x06003C95 RID: 15509 RVA: 0x0001668F File Offset: 0x0001488F
		public unsafe bool _ApplyToMembers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__ApplyToMembers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__ApplyToMembers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003C96 RID: 15510 RVA: 0x00122844 File Offset: 0x00120A44
		// (set) Token: 0x06003C97 RID: 15511 RVA: 0x000166AA File Offset: 0x000148AA
		public unsafe string _Feature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__Feature_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscationAttribute.NativeFieldInfoPtr__Feature_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeFieldInfoPtr__StripAfterObfuscation_k__BackingField;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeFieldInfoPtr__Exclude_k__BackingField;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeFieldInfoPtr__ApplyToMembers_k__BackingField;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeFieldInfoPtr__Feature_k__BackingField;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_set_StripAfterObfuscation_Public_set_Void_Boolean_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr_set_Exclude_Public_set_Void_Boolean_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_set_ApplyToMembers_Public_set_Void_Boolean_0;
	}
}
