using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200010F RID: 271
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x06001686 RID: 5766 RVA: 0x0006CABC File Offset: 0x0006ACBC
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipAttribute()
		{
			Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TooltipAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr);
			TooltipAttribute.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, "tooltip");
			TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, 100666427);
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x0006CB14 File Offset: 0x0006AD14
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipAttribute(string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00008DF3 File Offset: 0x00006FF3
		public TooltipAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x0006CB60 File Offset: 0x0006AD60
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00008DFC File Offset: 0x00006FFC
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
