using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001DF RID: 479
	[StructLayout(2)]
	public struct InputAnalogActionHandle_t
	{
		// Token: 0x0600180A RID: 6154 RVA: 0x00075D78 File Offset: 0x00073F78
		// Note: this type is marked as 'beforefieldinit'.
		static InputAnalogActionHandle_t()
		{
			Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "InputAnalogActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr);
			InputAnalogActionHandle_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, "Value");
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_InputAnalogActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667710);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667711);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667712);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667713);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667714);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667715);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667716);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667717);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100667718);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00075E70 File Offset: 0x00074070
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator InputAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_InputAnalogActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00075EB0 File Offset: 0x000740B0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(InputAnalogActionHandle_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00075EF0 File Offset: 0x000740F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x00075F1C File Offset: 0x0007411C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00075F4C File Offset: 0x0007414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951526, XrefRangeEnd = 951529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00075F90 File Offset: 0x00074190
		[CallerCount(0)]
		public unsafe bool Equals(InputAnalogActionHandle_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00075FD0 File Offset: 0x000741D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputAnalogActionHandle_t a, InputAnalogActionHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0007601C File Offset: 0x0007421C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputAnalogActionHandle_t a, InputAnalogActionHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00076068 File Offset: 0x00074268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00007D5B File Offset: 0x00005F5B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InputAnalogActionHandle_t_UInt64_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InputAnalogActionHandle_t_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0;

		// Token: 0x04001D84 RID: 7556
		[FieldOffset(0)]
		public ulong Value;
	}
}
