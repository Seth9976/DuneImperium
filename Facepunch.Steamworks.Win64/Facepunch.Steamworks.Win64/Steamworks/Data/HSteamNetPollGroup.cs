using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001EC RID: 492
	[StructLayout(2)]
	public struct HSteamNetPollGroup
	{
		// Token: 0x06001899 RID: 6297 RVA: 0x000786E8 File Offset: 0x000768E8
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamNetPollGroup()
		{
			Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HSteamNetPollGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr);
			HSteamNetPollGroup.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, "Value");
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamNetPollGroup_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667827);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667828);
			HSteamNetPollGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667829);
			HSteamNetPollGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667830);
			HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667831);
			HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667832);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667833);
			HSteamNetPollGroup.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667834);
			HSteamNetPollGroup.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, 100667835);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000787E0 File Offset: 0x000769E0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HSteamNetPollGroup(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamNetPollGroup_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00078820 File Offset: 0x00076A20
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(HSteamNetPollGroup value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00078860 File Offset: 0x00076A60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0007888C File Offset: 0x00076A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000788BC File Offset: 0x00076ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951565, XrefRangeEnd = 951568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00078900 File Offset: 0x00076B00
		[CallerCount(0)]
		public unsafe bool Equals(HSteamNetPollGroup p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00078940 File Offset: 0x00076B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamNetPollGroup a, HSteamNetPollGroup b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0007898C File Offset: 0x00076B8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamNetPollGroup a, HSteamNetPollGroup b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000789D8 File Offset: 0x00076BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamNetPollGroup other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamNetPollGroup.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00007E45 File Offset: 0x00006045
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamNetPollGroup>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamNetPollGroup_UInt32_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HSteamNetPollGroup_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamNetPollGroup_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamNetPollGroup_HSteamNetPollGroup_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamNetPollGroup_0;

		// Token: 0x04001E13 RID: 7699
		[FieldOffset(0)]
		public uint Value;
	}
}
