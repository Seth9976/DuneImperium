using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004AC RID: 1196
	public sealed class EventSourceAttribute : Attribute
	{
		// Token: 0x06004A0F RID: 18959 RVA: 0x00156E04 File Offset: 0x00155004
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceAttribute()
		{
			Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr);
			EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Guid>k__BackingField");
			EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, "<Name>k__BackingField");
			EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674075);
			EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674076);
			EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr, 100674077);
		}

		// Token: 0x170012F2 RID: 4850
		// (set) Token: 0x06004A10 RID: 18960 RVA: 0x00156E98 File Offset: 0x00155098
		public unsafe string Guid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (set) Token: 0x06004A11 RID: 18961 RVA: 0x00156EDC File Offset: 0x001550DC
		public unsafe string Name
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x00156F20 File Offset: 0x00155120
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x0001B1D6 File Offset: 0x000193D6
		public EventSourceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004A14 RID: 18964 RVA: 0x00156F5C File Offset: 0x0015515C
		// (set) Token: 0x06004A15 RID: 18965 RVA: 0x0001B1DF File Offset: 0x000193DF
		public unsafe string _Guid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Guid_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004A16 RID: 18966 RVA: 0x00156F84 File Offset: 0x00155184
		// (set) Token: 0x06004A17 RID: 18967 RVA: 0x0001B1FE File Offset: 0x000193FE
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeFieldInfoPtr__Guid_k__BackingField;

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeMethodInfoPtr_set_Guid_Public_set_Void_String_0;

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
