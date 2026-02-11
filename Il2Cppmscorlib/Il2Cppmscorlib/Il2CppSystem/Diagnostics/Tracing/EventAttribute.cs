using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004AA RID: 1194
	public sealed class EventAttribute : Attribute
	{
		// Token: 0x060049E3 RID: 18915 RVA: 0x001561C8 File Offset: 0x001543C8
		// Note: this type is marked as 'beforefieldinit'.
		static EventAttribute()
		{
			Il2CppClassPointerStore<EventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr);
			EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<EventId>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Level_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Level>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Keywords>k__BackingField");
			EventAttribute.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, "<Message>k__BackingField");
			EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674045);
			EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674046);
			EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674047);
			EventAttribute.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674048);
			EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr, 100674049);
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x001562AC File Offset: 0x001544AC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventAttribute(int eventId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (set) Token: 0x060049E5 RID: 18917 RVA: 0x001562F4 File Offset: 0x001544F4
		public unsafe int EventId
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (set) Token: 0x060049E6 RID: 18918 RVA: 0x00156334 File Offset: 0x00154534
		public unsafe EventLevel Level
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012EA RID: 4842
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x00156374 File Offset: 0x00154574
		public unsafe EventKeywords Keywords
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012EB RID: 4843
		// (set) Token: 0x060049E8 RID: 18920 RVA: 0x001563B4 File Offset: 0x001545B4
		public unsafe string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventAttribute.NativeMethodInfoPtr_set_Message_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x0001B10B File Offset: 0x0001930B
		public EventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x001563F8 File Offset: 0x001545F8
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x0001B114 File Offset: 0x00019314
		public unsafe int _EventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x00156420 File Offset: 0x00154620
		// (set) Token: 0x060049ED RID: 18925 RVA: 0x0001B12F File Offset: 0x0001932F
		public unsafe EventLevel _Level_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Level_k__BackingField)) = value;
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060049EE RID: 18926 RVA: 0x00156448 File Offset: 0x00154648
		// (set) Token: 0x060049EF RID: 18927 RVA: 0x0001B14A File Offset: 0x0001934A
		public unsafe EventKeywords _Keywords_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Keywords_k__BackingField)) = value;
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060049F0 RID: 18928 RVA: 0x00156470 File Offset: 0x00154670
		// (set) Token: 0x060049F1 RID: 18929 RVA: 0x0001B165 File Offset: 0x00019365
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventAttribute.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeFieldInfoPtr__EventId_k__BackingField;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeFieldInfoPtr__Level_k__BackingField;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeFieldInfoPtr__Keywords_k__BackingField;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeMethodInfoPtr_set_EventId_Private_set_Void_Int32_0;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeMethodInfoPtr_set_Level_Public_set_Void_EventLevel_0;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeMethodInfoPtr_set_Keywords_Public_set_Void_EventKeywords_0;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Public_set_Void_String_0;
	}
}
