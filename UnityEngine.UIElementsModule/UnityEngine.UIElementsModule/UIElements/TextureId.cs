using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000172 RID: 370
	[StructLayout(2)]
	public struct TextureId
	{
		// Token: 0x06001B7B RID: 7035 RVA: 0x0007DDA8 File Offset: 0x0007BFA8
		// Note: this type is marked as 'beforefieldinit'.
		static TextureId()
		{
			Il2CppClassPointerStore<TextureId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextureId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureId>.NativeClassPtr);
			TextureId.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureId>.NativeClassPtr, "m_Index");
			TextureId.NativeFieldInfoPtr_invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureId>.NativeClassPtr, "invalid");
			TextureId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667292);
			TextureId.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667293);
			TextureId.NativeMethodInfoPtr_ConvertToGpu_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667294);
			TextureId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667295);
			TextureId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667296);
			TextureId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667297);
			TextureId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextureId_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureId>.NativeClassPtr, 100667298);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0007DE8C File Offset: 0x0007C08C
		[CallerCount(0)]
		public unsafe TextureId(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0007DEC0 File Offset: 0x0007C0C0
		public unsafe int index
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 323134, RefRangeEnd = 323137, XrefRangeStart = 323134, XrefRangeEnd = 323134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_get_index_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0007DEF0 File Offset: 0x0007C0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323140, RefRangeEnd = 323142, XrefRangeStart = 323137, XrefRangeEnd = 323140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ConvertToGpu()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_ConvertToGpu_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0007DF20 File Offset: 0x0007C120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323142, XrefRangeEnd = 323147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0007DF64 File Offset: 0x0007C164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323147, XrefRangeEnd = 323148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0007DF94 File Offset: 0x0007C194
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 323148, RefRangeEnd = 323154, XrefRangeStart = 323148, XrefRangeEnd = 323148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TextureId left, TextureId right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0007DFE0 File Offset: 0x0007C1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323154, XrefRangeEnd = 323157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TextureId left, TextureId right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextureId_TextureId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000C79F File Offset: 0x0000A99F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureId>.NativeClassPtr, ref this));
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0007E02C File Offset: 0x0007C22C
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000C7B1 File Offset: 0x0000A9B1
		public unsafe static TextureId invalid
		{
			get
			{
				TextureId textureId;
				IL2CPP.il2cpp_field_static_get_value(TextureId.NativeFieldInfoPtr_invalid, (void*)(&textureId));
				return textureId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureId.NativeFieldInfoPtr_invalid, (void*)(&value));
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0007E048 File Offset: 0x0007C248
		public bool IsValid()
		{
			return this.m_Index > 0;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0007E064 File Offset: 0x0007C264
		public bool Equals(TextureId other)
		{
			return this.m_Index == other.m_Index;
		}

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeFieldInfoPtr_invalid;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToGpu_Public_Single_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextureId_TextureId_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextureId_TextureId_0;

		// Token: 0x04001300 RID: 4864
		[FieldOffset(0)]
		public readonly int m_Index;
	}
}
