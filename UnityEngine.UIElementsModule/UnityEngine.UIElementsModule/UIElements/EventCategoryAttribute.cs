using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000229 RID: 553
	public class EventCategoryAttribute : Attribute
	{
		// Token: 0x06002936 RID: 10550 RVA: 0x000B4690 File Offset: 0x000B2890
		// Note: this type is marked as 'beforefieldinit'.
		static EventCategoryAttribute()
		{
			Il2CppClassPointerStore<EventCategoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCategoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCategoryAttribute>.NativeClassPtr);
			EventCategoryAttribute.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCategoryAttribute>.NativeClassPtr, "category");
			EventCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_EventCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCategoryAttribute>.NativeClassPtr, 100669489);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000B46E8 File Offset: 0x000B28E8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346332, XrefRangeEnd = 346333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCategoryAttribute(EventCategory category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCategoryAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCategoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_EventCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000109EA File Offset: 0x0000EBEA
		public EventCategoryAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000B4730 File Offset: 0x000B2930
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x000109F3 File Offset: 0x0000EBF3
		public unsafe EventCategory category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCategoryAttribute.NativeFieldInfoPtr_category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCategoryAttribute.NativeFieldInfoPtr_category)) = value;
			}
		}

		// Token: 0x04001D62 RID: 7522
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x04001D63 RID: 7523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCategory_0;
	}
}
