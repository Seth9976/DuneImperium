using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000022 RID: 34
	public class Alert : Object
	{
		// Token: 0x06000210 RID: 528 RVA: 0x0000C14C File Offset: 0x0000A34C
		// Note: this type is marked as 'beforefieldinit'.
		static Alert()
		{
			Il2CppClassPointerStore<Alert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "Alert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alert>.NativeClassPtr);
			Alert.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "level");
			Alert.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alert>.NativeClassPtr, "description");
			Alert.NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663615);
			Alert.NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663616);
			Alert.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663617);
			Alert.NativeMethodInfoPtr_inferAlertLevel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663618);
			Alert.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Alert>.NativeClassPtr, 100663619);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000C208 File Offset: 0x0000A408
		public unsafe AlertLevel Level
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000C244 File Offset: 0x0000A444
		public unsafe AlertDescription Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000C280 File Offset: 0x0000A480
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149350, RefRangeEnd = 1149352, XrefRangeStart = 1149349, XrefRangeEnd = 1149350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Alert(AlertDescription description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alert>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref description;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		[CallerCount(0)]
		public unsafe void inferAlertLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Alert.NativeMethodInfoPtr_inferAlertLevel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149352, XrefRangeEnd = 1149361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Alert.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002DDC File Offset: 0x00000FDC
		public Alert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000C340 File Offset: 0x0000A540
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002DE5 File Offset: 0x00000FE5
		public unsafe AlertLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000C368 File Offset: 0x0000A568
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002E00 File Offset: 0x00001000
		public unsafe AlertDescription description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_description);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alert.NativeFieldInfoPtr_description)) = value;
			}
		}

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_AlertLevel_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_AlertDescription_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_inferAlertLevel_Private_Void_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
