using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200002B RID: 43
	public class MediaTypeHeaderValue : Object
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000F89C File Offset: 0x0000DA9C
		// Note: this type is marked as 'beforefieldinit'.
		static MediaTypeHeaderValue()
		{
			Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "MediaTypeHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr);
			MediaTypeHeaderValue.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, "parameters");
			MediaTypeHeaderValue.NativeFieldInfoPtr_media_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, "media_type");
			MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663741);
			MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Protected_Void_MediaTypeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663742);
			MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663743);
			MediaTypeHeaderValue.NativeMethodInfoPtr_get_CharSet_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663744);
			MediaTypeHeaderValue.NativeMethodInfoPtr_set_CharSet_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663745);
			MediaTypeHeaderValue.NativeMethodInfoPtr_set_MediaType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663746);
			MediaTypeHeaderValue.NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663747);
			MediaTypeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663748);
			MediaTypeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663749);
			MediaTypeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663750);
			MediaTypeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663751);
			MediaTypeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_MediaTypeHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663752);
			MediaTypeHeaderValue.NativeMethodInfoPtr_TryParseMediaType_Internal_Static_Nullable_1_Token_Lexer_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, 100663753);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1174870, RefRangeEnd = 1174876, XrefRangeStart = 1174855, XrefRangeEnd = 1174870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaTypeHeaderValue(string mediaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mediaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000FA44 File Offset: 0x0000DC44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174903, RefRangeEnd = 1174904, XrefRangeStart = 1174876, XrefRangeEnd = 1174903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaTypeHeaderValue(MediaTypeHeaderValue source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Protected_Void_MediaTypeHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000FA90 File Offset: 0x0000DC90
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaTypeHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000FACC File Offset: 0x0000DCCC
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0000FB04 File Offset: 0x0000DD04
		public unsafe string CharSet
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174922, RefRangeEnd = 1174924, XrefRangeStart = 1174904, XrefRangeEnd = 1174922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_get_CharSet_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174945, RefRangeEnd = 1174947, XrefRangeStart = 1174924, XrefRangeEnd = 1174945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_set_CharSet_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E2 RID: 226
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public unsafe string MediaType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174947, XrefRangeEnd = 1174961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_set_MediaType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		public unsafe ICollection<NameValueHeaderValue> Parameters
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1174968, RefRangeEnd = 1174970, XrefRangeStart = 1174961, XrefRangeEnd = 1174968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<NameValueHeaderValue>>(intPtr3) : null;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000FBCC File Offset: 0x0000DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174970, XrefRangeEnd = 1174974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000FC0C File Offset: 0x0000DE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174974, XrefRangeEnd = 1174981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaTypeHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174981, XrefRangeEnd = 1174985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaTypeHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000FCAC File Offset: 0x0000DEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174985, XrefRangeEnd = 1174989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MediaTypeHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174989, XrefRangeEnd = 1175013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, out MediaTypeHeaderValue parsedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_MediaTypeHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new MediaTypeHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000FD54 File Offset: 0x0000DF54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1175040, RefRangeEnd = 1175044, XrefRangeStart = 1175013, XrefRangeEnd = 1175040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<Token> TryParseMediaType(Lexer lexer, out string media)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.NativeMethodInfoPtr_TryParseMediaType_Internal_Static_Nullable_1_Token_Lexer_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			media = IL2CPP.Il2CppStringToManaged(intPtr);
			return new Nullable<Token>(intPtr2);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002FF6 File Offset: 0x000011F6
		public MediaTypeHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002FFF File Offset: 0x000011FF
		public unsafe List<NameValueHeaderValue> parameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaTypeHeaderValue.NativeFieldInfoPtr_parameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NameValueHeaderValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaTypeHeaderValue.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe string media_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaTypeHeaderValue.NativeFieldInfoPtr_media_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MediaTypeHeaderValue.NativeFieldInfoPtr_media_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_parameters;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_media_type;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_MediaTypeHeaderValue_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_CharSet_Public_get_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_set_CharSet_Public_set_Void_String_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_set_MediaType_Public_set_Void_String_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_ICollection_1_NameValueHeaderValue_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_MediaTypeHeaderValue_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_TryParseMediaType_Internal_Static_Nullable_1_Token_Lexer_byref_String_0;

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("System.Net.Http.Headers.MediaTypeHeaderValue+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060004D6 RID: 1238 RVA: 0x00017034 File Offset: 0x00015234
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MediaTypeHeaderValue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr);
				MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr, "<>9");
				MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr, "<>9__6_0");
				MediaTypeHeaderValue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr, 100663755);
				MediaTypeHeaderValue.__c.NativeMethodInfoPtr__get_CharSet_b__6_0_Internal_Boolean_NameValueHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr, 100663756);
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x000170B0 File Offset: 0x000152B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaTypeHeaderValue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x000170EC File Offset: 0x000152EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174851, XrefRangeEnd = 1174855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CharSet_b__6_0(NameValueHeaderValue l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MediaTypeHeaderValue.__c.NativeMethodInfoPtr__get_CharSet_b__6_0_Internal_Boolean_NameValueHeaderValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x000040EA File Offset: 0x000022EA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x0001713C File Offset: 0x0001533C
			// (set) Token: 0x060004DB RID: 1243 RVA: 0x000040F3 File Offset: 0x000022F3
			public unsafe static MediaTypeHeaderValue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MediaTypeHeaderValue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000175 RID: 373
			// (get) Token: 0x060004DC RID: 1244 RVA: 0x00017164 File Offset: 0x00015364
			// (set) Token: 0x060004DD RID: 1245 RVA: 0x00004105 File Offset: 0x00002305
			public unsafe static Predicate<NameValueHeaderValue> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NameValueHeaderValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MediaTypeHeaderValue.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400036C RID: 876
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400036D RID: 877
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400036E RID: 878
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400036F RID: 879
			private static readonly IntPtr NativeMethodInfoPtr__get_CharSet_b__6_0_Internal_Boolean_NameValueHeaderValue_0;
		}
	}
}
