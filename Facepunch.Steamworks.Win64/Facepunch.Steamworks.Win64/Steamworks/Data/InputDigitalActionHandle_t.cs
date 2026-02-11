using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001DE RID: 478
	[StructLayout(2)]
	public struct InputDigitalActionHandle_t
	{
		// Token: 0x060017FF RID: 6143 RVA: 0x00075A48 File Offset: 0x00073C48
		// Note: this type is marked as 'beforefieldinit'.
		static InputDigitalActionHandle_t()
		{
			Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "InputDigitalActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr);
			InputDigitalActionHandle_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, "Value");
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_InputDigitalActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667701);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667702);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667703);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667704);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667705);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667706);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667707);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667708);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100667709);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00075B40 File Offset: 0x00073D40
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator InputDigitalActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_InputDigitalActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00075B80 File Offset: 0x00073D80
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(InputDigitalActionHandle_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00075BC0 File Offset: 0x00073DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x00075BEC File Offset: 0x00073DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x00075C1C File Offset: 0x00073E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951523, XrefRangeEnd = 951526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00075C60 File Offset: 0x00073E60
		[CallerCount(0)]
		public unsafe bool Equals(InputDigitalActionHandle_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00075CA0 File Offset: 0x00073EA0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputDigitalActionHandle_t a, InputDigitalActionHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00075CEC File Offset: 0x00073EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputDigitalActionHandle_t a, InputDigitalActionHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00075D38 File Offset: 0x00073F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputDigitalActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00007D49 File Offset: 0x00005F49
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InputDigitalActionHandle_t_UInt64_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputDigitalActionHandle_t_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0;

		// Token: 0x04001D79 RID: 7545
		[FieldOffset(0)]
		public ulong Value;
	}
}
