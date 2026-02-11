using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000141 RID: 321
	public class IsAttribute : PropertiesPhrase
	{
		// Token: 0x06000E64 RID: 3684 RVA: 0x000565C4 File Offset: 0x000547C4
		// Note: this type is marked as 'beforefieldinit'.
		static IsAttribute()
		{
			Il2CppClassPointerStore<IsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "IsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsAttribute>.NativeClassPtr);
			IsAttribute.NativeFieldInfoPtr_AttributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsAttribute>.NativeClassPtr, "AttributeKey");
			IsAttribute.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsAttribute>.NativeClassPtr, 100666421);
			IsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsAttribute>.NativeClassPtr, 100666422);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00056630 File Offset: 0x00054830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577414, XrefRangeEnd = 577426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IsAttribute.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00056688 File Offset: 0x00054888
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0000743F File Offset: 0x0000563F
		public IsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000566C4 File Offset: 0x000548C4
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00007448 File Offset: 0x00005648
		public unsafe int AttributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsAttribute.NativeFieldInfoPtr_AttributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IsAttribute.NativeFieldInfoPtr_AttributeKey)) = value;
			}
		}

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_AttributeKey;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
