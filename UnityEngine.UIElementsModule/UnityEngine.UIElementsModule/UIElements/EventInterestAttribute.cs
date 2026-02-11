using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000228 RID: 552
	public class EventInterestAttribute : Attribute
	{
		// Token: 0x0600292D RID: 10541 RVA: 0x000B4518 File Offset: 0x000B2718
		// Note: this type is marked as 'beforefieldinit'.
		static EventInterestAttribute()
		{
			Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventInterestAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr);
			EventInterestAttribute.NativeFieldInfoPtr_eventTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr, "eventTypes");
			EventInterestAttribute.NativeFieldInfoPtr_categoryFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr, "categoryFlags");
			EventInterestAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr, 100669487);
			EventInterestAttribute.NativeMethodInfoPtr__ctor_Public_Void_EventInterestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr, 100669488);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000B4598 File Offset: 0x000B2798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346329, XrefRangeEnd = 346331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventInterestAttribute([Optional] Il2CppReferenceArray<Type> eventTypes)
		{
			if (eventTypes == null)
			{
				eventTypes = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterestAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000B45F0 File Offset: 0x000B27F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346331, XrefRangeEnd = 346332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventInterestAttribute(EventInterestOptions interests)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInterestAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interests;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInterestAttribute.NativeMethodInfoPtr__ctor_Public_Void_EventInterestOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00010999 File Offset: 0x0000EB99
		public EventInterestAttribute(params Type[] eventTypes)
			: this(new Il2CppReferenceArray<Type>(eventTypes))
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000109A7 File Offset: 0x0000EBA7
		public EventInterestAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000B4638 File Offset: 0x000B2838
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x000109B0 File Offset: 0x0000EBB0
		public unsafe Il2CppReferenceArray<Type> eventTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInterestAttribute.NativeFieldInfoPtr_eventTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInterestAttribute.NativeFieldInfoPtr_eventTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002934 RID: 10548 RVA: 0x000B4668 File Offset: 0x000B2868
		// (set) Token: 0x06002935 RID: 10549 RVA: 0x000109CF File Offset: 0x0000EBCF
		public unsafe EventCategoryFlags categoryFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInterestAttribute.NativeFieldInfoPtr_categoryFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInterestAttribute.NativeFieldInfoPtr_categoryFlags)) = value;
			}
		}

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeFieldInfoPtr_eventTypes;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeFieldInfoPtr_categoryFlags;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventInterestOptions_0;
	}
}
