using System;
using Canis.json;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x02000020 RID: 32
	public sealed class ReadOnlyAttributesAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x0600021C RID: 540 RVA: 0x0000AA0C File Offset: 0x00008C0C
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttributesAnalyzer()
		{
			Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "ReadOnlyAttributesAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr);
			ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr, "attributeBuffer");
			ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr, "IAttributeType");
			ReadOnlyAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr, 100663523);
			ReadOnlyAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr, 100663524);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000AA8C File Offset: 0x00008C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218353, XrefRangeEnd = 1218373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributesAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributesAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributesAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218373, XrefRangeEnd = 1218451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributesAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public ReadOnlyAttributesAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000AB60 File Offset: 0x00008D60
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002CF2 File Offset: 0x00000EF2
		public unsafe static List<IAttribute> attributeBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_attributeBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000AB88 File Offset: 0x00008D88
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002D04 File Offset: 0x00000F04
		public unsafe Type IAttributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributesAnalyzer.NativeFieldInfoPtr_IAttributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_attributeBuffer;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_IAttributeType;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
