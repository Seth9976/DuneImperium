using System;
using Canis.json;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000022 RID: 34
	public sealed class SerializableAttributesAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000B38C File Offset: 0x0000958C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableAttributesAnalyzer()
		{
			Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "SerializableAttributesAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr);
			SerializableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr, "IAttributeType");
			SerializableAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr, 100663558);
			SerializableAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr, 100663559);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B3F8 File Offset: 0x000095F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218811, XrefRangeEnd = 1218831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributesAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributesAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000B434 File Offset: 0x00009634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218831, XrefRangeEnd = 1218842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002D6A File Offset: 0x00000F6A
		public SerializableAttributesAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0000B4CC File Offset: 0x000096CC
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002D73 File Offset: 0x00000F73
		public unsafe Type IAttributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_IAttributeType;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
