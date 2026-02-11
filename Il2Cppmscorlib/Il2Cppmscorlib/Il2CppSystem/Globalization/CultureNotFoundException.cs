using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200046C RID: 1132
	[Serializable]
	public class CultureNotFoundException : ArgumentException
	{
		// Token: 0x060043E1 RID: 17377 RVA: 0x00140594 File Offset: 0x0013E794
		// Note: this type is marked as 'beforefieldinit'.
		static CultureNotFoundException()
		{
			Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CultureNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr);
			CultureNotFoundException.NativeFieldInfoPtr__invalidCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "_invalidCultureName");
			CultureNotFoundException.NativeFieldInfoPtr__invalidCultureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, "_invalidCultureId");
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673336);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673337);
			CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673338);
			CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673339);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673340);
			CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673341);
			CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673342);
			CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673343);
			CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr, 100673344);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x001406A0 File Offset: 0x0013E8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407133, XrefRangeEnd = 1407136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x001406DC File Offset: 0x0013E8DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1407137, RefRangeEnd = 1407138, XrefRangeStart = 1407136, XrefRangeEnd = 1407137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x0014073C File Offset: 0x0013E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407138, XrefRangeEnd = 1407162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x001407A0 File Offset: 0x0013E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407162, XrefRangeEnd = 1407181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x00140804 File Offset: 0x0013EA04
		public unsafe virtual Nullable<int> InvalidCultureId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00140848 File Offset: 0x0013EA48
		public unsafe virtual string InvalidCultureName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x0014088C File Offset: 0x0013EA8C
		public unsafe static string DefaultMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407181, XrefRangeEnd = 1407183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x001408B8 File Offset: 0x0013EAB8
		public unsafe string FormatedInvalidCultureId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407183, XrefRangeEnd = 1407197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureNotFoundException.NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x060043EA RID: 17386 RVA: 0x001408F0 File Offset: 0x0013EAF0
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407197, XrefRangeEnd = 1407219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CultureNotFoundException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00018852 File Offset: 0x00016A52
		public CultureNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060043EC RID: 17388 RVA: 0x00140934 File Offset: 0x0013EB34
		// (set) Token: 0x060043ED RID: 17389 RVA: 0x0001885B File Offset: 0x00016A5B
		public unsafe string _invalidCultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr__invalidCultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr__invalidCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x0014095C File Offset: 0x0013EB5C
		// (set) Token: 0x060043EF RID: 17391 RVA: 0x0001887A File Offset: 0x00016A7A
		public Nullable<int> _invalidCultureId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr__invalidCultureId);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureNotFoundException.NativeFieldInfoPtr__invalidCultureId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeFieldInfoPtr__invalidCultureName;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeFieldInfoPtr__invalidCultureId;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureId_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidCultureName_Public_Virtual_New_get_String_0;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultMessage_Private_Static_get_String_0;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatedInvalidCultureId_Private_get_String_0;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
