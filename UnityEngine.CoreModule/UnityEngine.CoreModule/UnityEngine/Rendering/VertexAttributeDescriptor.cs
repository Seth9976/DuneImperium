using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001FD RID: 509
	[StructLayout(2)]
	public struct VertexAttributeDescriptor
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x00094928 File Offset: 0x00092B28
		// Note: this type is marked as 'beforefieldinit'.
		static VertexAttributeDescriptor()
		{
			Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VertexAttributeDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr);
			VertexAttributeDescriptor.NativeFieldInfoPtr__attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<attribute>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<format>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
			VertexAttributeDescriptor.NativeFieldInfoPtr__stream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<stream>k__BackingField");
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667852);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667853);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667854);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667855);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667856);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667857);
			VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667858);
			VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667859);
			VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667860);
			VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667861);
			VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667862);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667863);
			VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100667864);
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060021EC RID: 8684 RVA: 0x00094AAC File Offset: 0x00092CAC
		// (set) Token: 0x060021ED RID: 8685 RVA: 0x00094ADC File Offset: 0x00092CDC
		public unsafe VertexAttribute attribute
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00094B10 File Offset: 0x00092D10
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00094B40 File Offset: 0x00092D40
		public unsafe VertexAttributeFormat format
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x00094B74 File Offset: 0x00092D74
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00094BA4 File Offset: 0x00092DA4
		public unsafe int dimension
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00094BD8 File Offset: 0x00092DD8
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x00094C08 File Offset: 0x00092E08
		public unsafe int stream
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00094C3C File Offset: 0x00092E3C
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attribute;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimension;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stream;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00094C98 File Offset: 0x00092E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681502, XrefRangeEnd = 681527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00094CC4 File Offset: 0x00092EC4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00094CF4 File Offset: 0x00092EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681527, XrefRangeEnd = 681530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00094D38 File Offset: 0x00092F38
		[CallerCount(0)]
		public unsafe bool Equals(VertexAttributeDescriptor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0000CF00 File Offset: 0x0000B100
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00094D78 File Offset: 0x00092F78
		public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00094D94 File Offset: 0x00092F94
		public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr__attribute_k__BackingField;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr__format_k__BackingField;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr__dimension_k__BackingField;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr__stream_k__BackingField;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_get_dimension_Public_get_Int32_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_get_stream_Public_get_Int32_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0;

		// Token: 0x04001DDC RID: 7644
		[FieldOffset(0)]
		public VertexAttribute _attribute_k__BackingField;

		// Token: 0x04001DDD RID: 7645
		[FieldOffset(4)]
		public VertexAttributeFormat _format_k__BackingField;

		// Token: 0x04001DDE RID: 7646
		[FieldOffset(8)]
		public int _dimension_k__BackingField;

		// Token: 0x04001DDF RID: 7647
		[FieldOffset(12)]
		public int _stream_k__BackingField;
	}
}
