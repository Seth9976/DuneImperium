using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001DE RID: 478
	[StructLayout(2)]
	public struct TextShadow
	{
		// Token: 0x060025EC RID: 9708 RVA: 0x000A937C File Offset: 0x000A757C
		// Note: this type is marked as 'beforefieldinit'.
		static TextShadow()
		{
			Il2CppClassPointerStore<TextShadow>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextShadow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextShadow>.NativeClassPtr);
			TextShadow.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "offset");
			TextShadow.NativeFieldInfoPtr_blurRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "blurRadius");
			TextShadow.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, "color");
			TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669041);
			TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669042);
			TextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669043);
			TextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669044);
			TextShadow.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextShadow_TextShadow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669045);
			TextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669046);
			TextShadow.NativeMethodInfoPtr_LerpUnclamped_Internal_Static_TextShadow_TextShadow_TextShadow_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, 100669047);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000A9474 File Offset: 0x000A7674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340045, XrefRangeEnd = 340049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000A94B8 File Offset: 0x000A76B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340049, RefRangeEnd = 340051, XrefRangeStart = 340049, XrefRangeEnd = 340049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TextShadow other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000A94F8 File Offset: 0x000A76F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340058, RefRangeEnd = 340060, XrefRangeStart = 340051, XrefRangeEnd = 340058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000A9528 File Offset: 0x000A7728
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340061, RefRangeEnd = 340064, XrefRangeStart = 340060, XrefRangeEnd = 340061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TextShadow style1, TextShadow style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000A9574 File Offset: 0x000A7774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340064, RefRangeEnd = 340066, XrefRangeStart = 340064, XrefRangeEnd = 340064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TextShadow style1, TextShadow style2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextShadow_TextShadow_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000A95C0 File Offset: 0x000A77C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340066, XrefRangeEnd = 340078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000A95EC File Offset: 0x000A77EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340078, RefRangeEnd = 340080, XrefRangeStart = 340078, XrefRangeEnd = 340078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextShadow.NativeMethodInfoPtr_LerpUnclamped_Internal_Static_TextShadow_TextShadow_TextShadow_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0000F799 File Offset: 0x0000D999
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextShadow>.NativeClassPtr, ref this));
		}

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_blurRadius;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TextShadow_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TextShadow_TextShadow_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TextShadow_TextShadow_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Internal_Static_TextShadow_TextShadow_TextShadow_Single_0;

		// Token: 0x04001B58 RID: 7000
		[FieldOffset(0)]
		public Vector2 offset;

		// Token: 0x04001B59 RID: 7001
		[FieldOffset(8)]
		public float blurRadius;

		// Token: 0x04001B5A RID: 7002
		[FieldOffset(12)]
		public Color color;
	}
}
