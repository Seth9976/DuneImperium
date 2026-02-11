using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000080 RID: 128
	public class KeyValueFormat : Object
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x0002FA8C File Offset: 0x0002DC8C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValueFormat()
		{
			Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "KeyValueFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr);
			KeyValueFormat.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, "<Position>k__BackingField");
			KeyValueFormat.NativeFieldInfoPtr__TextFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, "<TextFormat>k__BackingField");
			KeyValueFormat.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, "<ETag>k__BackingField");
			KeyValueFormat.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_TextPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664690);
			KeyValueFormat.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_TextPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664691);
			KeyValueFormat.NativeMethodInfoPtr_get_TextFormat_Public_Virtual_New_get_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664692);
			KeyValueFormat.NativeMethodInfoPtr_set_TextFormat_Public_Virtual_New_set_Void_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664693);
			KeyValueFormat.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664694);
			KeyValueFormat.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664695);
			KeyValueFormat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr, 100664696);
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0002FB84 File Offset: 0x0002DD84
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		public unsafe virtual TextPosition Position
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_TextPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextPosition>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_TextPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0002FC20 File Offset: 0x0002DE20
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0002FC6C File Offset: 0x0002DE6C
		public unsafe virtual TextFormat TextFormat
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_get_TextFormat_Public_Virtual_New_get_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_set_TextFormat_Public_Virtual_New_set_Void_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x0002FD00 File Offset: 0x0002DF00
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueFormat.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002FD50 File Offset: 0x0002DF50
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValueFormat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValueFormat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValueFormat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00006A3B File Offset: 0x00004C3B
		public KeyValueFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002FD8C File Offset: 0x0002DF8C
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00006A44 File Offset: 0x00004C44
		public unsafe TextPosition _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__Position_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00006A63 File Offset: 0x00004C63
		public unsafe TextFormat _TextFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__TextFormat_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__TextFormat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0002FDEC File Offset: 0x0002DFEC
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00006A82 File Offset: 0x00004C82
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueFormat.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeFieldInfoPtr__TextFormat_k__BackingField;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_TextPosition_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_TextPosition_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_TextFormat_Public_Virtual_New_get_TextFormat_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_set_TextFormat_Public_Virtual_New_set_Void_TextFormat_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
