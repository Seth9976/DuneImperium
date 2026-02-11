using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000C0 RID: 192
	public class UpdateEmbeddedObjectPositionRequest : Object
	{
		// Token: 0x0600104B RID: 4171 RVA: 0x0004990C File Offset: 0x00047B0C
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateEmbeddedObjectPositionRequest()
		{
			Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "UpdateEmbeddedObjectPositionRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr);
			UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, "<Fields>k__BackingField");
			UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__NewPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, "<NewPosition>k__BackingField");
			UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ObjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, "<ObjectId>k__BackingField");
			UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, "<ETag>k__BackingField");
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665510);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665511);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_NewPosition_Public_Virtual_New_get_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665512);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_NewPosition_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665513);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665514);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665515);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665516);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665517);
			UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr, 100665518);
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00049A40 File Offset: 0x00047C40
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00049A8C File Offset: 0x00047C8C
		public unsafe virtual Object Fields
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00049ADC File Offset: 0x00047CDC
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x00049B28 File Offset: 0x00047D28
		public unsafe virtual EmbeddedObjectPosition NewPosition
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_NewPosition_Public_Virtual_New_get_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_NewPosition_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00049B78 File Offset: 0x00047D78
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x00049BBC File Offset: 0x00047DBC
		public unsafe virtual Nullable<int> ObjectId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00049C10 File Offset: 0x00047E10
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x00049C54 File Offset: 0x00047E54
		public unsafe virtual string ETag
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00049CA4 File Offset: 0x00047EA4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateEmbeddedObjectPositionRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateEmbeddedObjectPositionRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateEmbeddedObjectPositionRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00009D4D File Offset: 0x00007F4D
		public UpdateEmbeddedObjectPositionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00049CE0 File Offset: 0x00047EE0
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00009D56 File Offset: 0x00007F56
		public unsafe Object _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001058 RID: 4184 RVA: 0x00049D10 File Offset: 0x00047F10
		// (set) Token: 0x06001059 RID: 4185 RVA: 0x00009D75 File Offset: 0x00007F75
		public unsafe EmbeddedObjectPosition _NewPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__NewPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedObjectPosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__NewPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x0600105A RID: 4186 RVA: 0x00049D40 File Offset: 0x00047F40
		// (set) Token: 0x0600105B RID: 4187 RVA: 0x00009D94 File Offset: 0x00007F94
		public Nullable<int> _ObjectId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ObjectId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ObjectId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x00049D70 File Offset: 0x00047F70
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00009DC2 File Offset: 0x00007FC2
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateEmbeddedObjectPositionRequest.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr__NewPosition_k__BackingField;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr__ObjectId_k__BackingField;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_Virtual_New_get_Object_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Public_Virtual_New_set_Void_Object_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_get_NewPosition_Public_Virtual_New_get_EmbeddedObjectPosition_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_set_NewPosition_Public_Virtual_New_set_Void_EmbeddedObjectPosition_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectId_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
