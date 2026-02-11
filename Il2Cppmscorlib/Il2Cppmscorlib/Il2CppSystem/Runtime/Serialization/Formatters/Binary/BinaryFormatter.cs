using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000363 RID: 867
	public sealed class BinaryFormatter : Object
	{
		// Token: 0x0600345F RID: 13407 RVA: 0x00104C04 File Offset: 0x00102E04
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryFormatter()
		{
			Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr);
			BinaryFormatter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_surrogates");
			BinaryFormatter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_context");
			BinaryFormatter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_binder");
			BinaryFormatter.NativeFieldInfoPtr_m_typeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_typeFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_assemblyFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_securityLevel");
			BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_crossAppDomainArray");
			BinaryFormatter.NativeFieldInfoPtr_typeNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "typeNameCache");
			BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671335);
			BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671336);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671337);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671338);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671339);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671340);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671341);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671342);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671343);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671344);
			BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671345);
		}

		// Token: 0x17000C15 RID: 3093
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x00104DB0 File Offset: 0x00102FB0
		public unsafe FormatterAssemblyStyle AssemblyFormat
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x00104DF0 File Offset: 0x00102FF0
		public unsafe ISurrogateSelector SurrogateSelector
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00104E34 File Offset: 0x00103034
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1387969, RefRangeEnd = 1387984, XrefRangeStart = 1387965, XrefRangeEnd = 1387969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00104E70 File Offset: 0x00103070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387987, RefRangeEnd = 1387989, XrefRangeStart = 1387984, XrefRangeEnd = 1387987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00104ED4 File Offset: 0x001030D4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1387990, RefRangeEnd = 1387999, XrefRangeStart = 1387989, XrefRangeEnd = 1387990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00104F24 File Offset: 0x00103124
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1388044, RefRangeEnd = 1388051, XrefRangeStart = 1387999, XrefRangeEnd = 1388044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00104F94 File Offset: 0x00103194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388051, XrefRangeEnd = 1388052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00104FF8 File Offset: 0x001031F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1388053, RefRangeEnd = 1388056, XrefRangeStart = 1388052, XrefRangeEnd = 1388053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x0010504C File Offset: 0x0010324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388056, XrefRangeEnd = 1388057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x001050B4 File Offset: 0x001032B4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1388093, RefRangeEnd = 1388101, XrefRangeStart = 1388057, XrefRangeEnd = 1388093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00105128 File Offset: 0x00103328
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1388132, RefRangeEnd = 1388136, XrefRangeStart = 1388101, XrefRangeEnd = 1388132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInformation GetTypeInformation(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInformation>(intPtr3) : null;
			}
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000127D9 File Offset: 0x000109D9
		public BinaryFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x0010516C File Offset: 0x0010336C
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x000127E2 File Offset: 0x000109E2
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x0010519C File Offset: 0x0010339C
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x00012801 File Offset: 0x00010A01
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x001051CC File Offset: 0x001033CC
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x0001282F File Offset: 0x00010A2F
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x001051FC File Offset: 0x001033FC
		// (set) Token: 0x06003473 RID: 13427 RVA: 0x0001284E File Offset: 0x00010A4E
		public unsafe FormatterTypeStyle m_typeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat)) = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00105224 File Offset: 0x00103424
		// (set) Token: 0x06003475 RID: 13429 RVA: 0x00012869 File Offset: 0x00010A69
		public unsafe FormatterAssemblyStyle m_assemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat)) = value;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x0010524C File Offset: 0x0010344C
		// (set) Token: 0x06003477 RID: 13431 RVA: 0x00012884 File Offset: 0x00010A84
		public unsafe TypeFilterLevel m_securityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel)) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x00105274 File Offset: 0x00103474
		// (set) Token: 0x06003479 RID: 13433 RVA: 0x0001289F File Offset: 0x00010A9F
		public unsafe Il2CppReferenceArray<Object> m_crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x001052A4 File Offset: 0x001034A4
		// (set) Token: 0x0600347B RID: 13435 RVA: 0x000128BE File Offset: 0x00010ABE
		public unsafe static Dictionary<Type, TypeInformation> typeNameCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, TypeInformation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeFieldInfoPtr_m_typeFormat;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyFormat;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeFieldInfoPtr_m_securityLevel;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeFieldInfoPtr_m_crossAppDomainArray;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeFieldInfoPtr_typeNameCache;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0;
	}
}
