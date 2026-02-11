using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CB RID: 459
	[StructLayout(2)]
	public struct HAuthTicket
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x00071DB8 File Offset: 0x0006FFB8
		// Note: this type is marked as 'beforefieldinit'.
		static HAuthTicket()
		{
			Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr);
			HAuthTicket.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, "Value");
			HAuthTicket.NativeMethodInfoPtr_op_Implicit_Public_Static_HAuthTicket_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667530);
			HAuthTicket.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667531);
			HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667532);
			HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667533);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667534);
			HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667535);
			HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667536);
			HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667537);
			HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, 100667538);
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00071EB0 File Offset: 0x000700B0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HAuthTicket(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Implicit_Public_Static_HAuthTicket_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00071EF0 File Offset: 0x000700F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(HAuthTicket value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00071F30 File Offset: 0x00070130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00071F5C File Offset: 0x0007015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00071F8C File Offset: 0x0007018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951451, XrefRangeEnd = 951454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00071FD0 File Offset: 0x000701D0
		[CallerCount(0)]
		public unsafe bool Equals(HAuthTicket p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00072010 File Offset: 0x00070210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HAuthTicket a, HAuthTicket b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0007205C File Offset: 0x0007025C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HAuthTicket a, HAuthTicket b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000720A8 File Offset: 0x000702A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HAuthTicket other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HAuthTicket.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00007BF3 File Offset: 0x00005DF3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HAuthTicket>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HAuthTicket_UInt32_0;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HAuthTicket_0;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CA4 RID: 7332
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HAuthTicket_0;

		// Token: 0x04001CA5 RID: 7333
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x04001CA6 RID: 7334
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HAuthTicket_HAuthTicket_0;

		// Token: 0x04001CA7 RID: 7335
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HAuthTicket_0;

		// Token: 0x04001CA8 RID: 7336
		[FieldOffset(0)]
		public uint Value;
	}
}
