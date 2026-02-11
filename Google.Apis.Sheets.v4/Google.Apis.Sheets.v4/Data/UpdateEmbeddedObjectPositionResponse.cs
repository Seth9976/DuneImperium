using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000C1 RID: 193
	public class UpdateEmbeddedObjectPositionResponse : Object
	{
		// Token: 0x0600105E RID: 4190 RVA: 0x00049D98 File Offset: 0x00047F98
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateEmbeddedObjectPositionResponse()
		{
			Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateEmbeddedObjectPositionResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr);
			UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, "<Position>k__BackingField");
			UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, 100665519);
			UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, 100665520);
			UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, 100665521);
			UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, 100665522);
			UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr, 100665523);
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600105F RID: 4191 RVA: 0x00049E54 File Offset: 0x00048054
		// (set) Token: 0x06001060 RID: 4192 RVA: 0x00049EA0 File Offset: 0x000480A0
		public unsafe virtual EmbeddedObjectPosition Position
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x00049EF0 File Offset: 0x000480F0
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x00049F34 File Offset: 0x00048134
		public unsafe virtual string ETag
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00049F84 File Offset: 0x00048184
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateEmbeddedObjectPositionResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateEmbeddedObjectPositionResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00009DE1 File Offset: 0x00007FE1
		public UpdateEmbeddedObjectPositionResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x00049FC0 File Offset: 0x000481C0
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x00009DEA File Offset: 0x00007FEA
		public unsafe EmbeddedObjectPosition _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__Position_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__Position_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00049FF0 File Offset: 0x000481F0
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x00009E09 File Offset: 0x00008009
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionResponse.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_New_get_EmbeddedObjectPosition_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
