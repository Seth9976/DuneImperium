using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200000E RID: 14
	public sealed class EventId : ValueType
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003398 File Offset: 0x00001598
		// Note: this type is marked as 'beforefieldinit'.
		static EventId()
		{
			Il2CppClassPointerStore<EventId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.Abstractions.dll", "Microsoft.Extensions.Logging", "EventId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventId>.NativeClassPtr);
			EventId.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventId>.NativeClassPtr, "<Id>k__BackingField");
			EventId.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventId>.NativeClassPtr, "<Name>k__BackingField");
			EventId.NativeMethodInfoPtr_op_Implicit_Public_Static_EventId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663326);
			EventId.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663327);
			EventId.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663328);
			EventId.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663329);
			EventId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663330);
			EventId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663331);
			EventId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663332);
			EventId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventId>.NativeClassPtr, 100663333);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003490 File Offset: 0x00001690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264584, XrefRangeEnd = 1264585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator EventId(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_op_Implicit_Public_Static_EventId_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new EventId(intPtr);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000034C8 File Offset: 0x000016C8
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventId(int id, string name = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventId>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003528 File Offset: 0x00001728
		public unsafe int Id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000356C File Offset: 0x0000176C
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000035A8 File Offset: 0x000017A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264585, XrefRangeEnd = 1264586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000035E4 File Offset: 0x000017E4
		[CallerCount(0)]
		public unsafe bool Equals(EventId other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000363C File Offset: 0x0000183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264586, XrefRangeEnd = 1264589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003690 File Offset: 0x00001890
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000229D File Offset: 0x0000049D
		public EventId(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000022A6 File Offset: 0x000004A6
		public EventId()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventId>.NativeClassPtr))
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000036D4 File Offset: 0x000018D4
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000022B8 File Offset: 0x000004B8
		public unsafe int _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventId.NativeFieldInfoPtr__Id_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventId.NativeFieldInfoPtr__Id_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000036FC File Offset: 0x000018FC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000022D3 File Offset: 0x000004D3
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventId.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventId.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EventId_Int32_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventId_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
